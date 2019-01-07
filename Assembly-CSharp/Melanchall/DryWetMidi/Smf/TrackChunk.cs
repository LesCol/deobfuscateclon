using System;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200015F RID: 351
	public sealed class TrackChunk : MidiChunk
	{
		// Token: 0x0600322C RID: 12844 RVA: 0x00016694 File Offset: 0x00014894
		public TrackChunk() : base("MTrk")
		{
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000166AC File Offset: 0x000148AC
		public TrackChunk(IEnumerable<MidiEvent> events) : this()
		{
			this.Events.AddRange(events);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000166AC File Offset: 0x000148AC
		public TrackChunk(params MidiEvent[] events) : this()
		{
			this.Events.AddRange(events);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x000166C0 File Offset: 0x000148C0
		public EventsCollection Events { get; } = new EventsCollection();

		// Token: 0x06003230 RID: 12848 RVA: 0x00146DC0 File Offset: 0x00144FC0
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size)
		{
			long num = reader.Position + (long)((ulong)size);
			bool flag = false;
			byte? b = null;
			this.onEvents = new List<int>(1);
			while (reader.Position < num && !reader.EndReached)
			{
				MidiEvent midiEvent = this.ReadEvent(reader, settings, ref b);
				if (midiEvent != null)
				{
					if (midiEvent is EndOfTrackEvent)
					{
						flag = true;
						break;
					}
					this.Events.Add(midiEvent);
				}
			}
			if (settings.MissedEndOfTrackPolicy == MissedEndOfTrackPolicy.Abort && !flag)
			{
				throw new MissedEndOfTrackEventException();
			}
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00146E38 File Offset: 0x00145038
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			this.ProcessEvents(settings, delegate(IEventWriter eventWriter, MidiEvent midiEvent, bool writeStatusByte)
			{
				writer.WriteVlqNumber(midiEvent.DeltaTime);
				eventWriter.Write(midiEvent, writer, settings, writeStatusByte);
			});
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00146E74 File Offset: 0x00145074
		protected override uint GetContentSize(WritingSettings settings)
		{
			uint result = 0u;
			this.ProcessEvents(settings, delegate(IEventWriter eventWriter, MidiEvent midiEvent, bool writeStatusByte)
			{
				result += (uint)(midiEvent.DeltaTime.GetVlqLength() + eventWriter.CalculateSize(midiEvent, settings, writeStatusByte));
			});
			return result;
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x00146EB4 File Offset: 0x001450B4
		private MidiEvent ReadEvent(MidiReader reader, ReadingSettings settings, ref byte? channelEventStatusByte)
		{
			long num = reader.ReadVlqLongNumber();
			if (num < 0L)
			{
				num = 0L;
			}
			this.absTime += num;
			byte b = reader.ReadByte();
			if (b <= SevenBitNumber.MaxValue)
			{
				if (channelEventStatusByte == null)
				{
					throw new UnexpectedRunningStatusException();
				}
				b = channelEventStatusByte.Value;
				long position = reader.Position;
				reader.Position = position - 1L;
			}
			MidiEvent midiEvent = EventReaderFactory.GetReader(b).Read(reader, settings, b);
			if (settings.SilentNoteOnPolicy == SilentNoteOnPolicy.NoteOff)
			{
				NoteOnEvent noteOnEvent = midiEvent as NoteOnEvent;
				SevenBitNumber? sevenBitNumber = (noteOnEvent != null) ? new SevenBitNumber?(noteOnEvent.Velocity) : null;
				int? num2 = (sevenBitNumber != null) ? new int?((int)sevenBitNumber.GetValueOrDefault()) : null;
				if (num2.GetValueOrDefault() == 0 & num2 != null)
				{
					midiEvent = new NoteOffEvent
					{
						DeltaTime = noteOnEvent.DeltaTime,
						Channel = noteOnEvent.Channel,
						NoteNumber = noteOnEvent.NoteNumber
					};
				}
			}
			if (midiEvent is ChannelEvent)
			{
				channelEventStatusByte = new byte?(b);
			}
			midiEvent.DeltaTime = num;
			midiEvent.AbsoluteTime = this.absTime;
			if (midiEvent is NoteOnEvent)
			{
				this.onEvents.Add(this.Events.Count);
			}
			else if (midiEvent is NoteOffEvent)
			{
				for (int i = 0; i < this.onEvents.Count; i++)
				{
					NoteOnEvent noteOnEvent2 = this.Events[this.onEvents[i]] as NoteOnEvent;
					if (noteOnEvent2.Channel == ((NoteOffEvent)midiEvent).Channel && noteOnEvent2.NoteNumber == ((NoteOffEvent)midiEvent).NoteNumber)
					{
						((NoteOnEvent)this.Events[this.onEvents[i]]).OffEvent = (NoteOffEvent)midiEvent;
						this.onEvents.RemoveAt(i);
						return null;
					}
				}
			}
			return midiEvent;
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x001470DC File Offset: 0x001452DC
		private void ProcessEvents(WritingSettings settings, Action<IEventWriter, MidiEvent, bool> eventHandler)
		{
			byte? b = null;
			bool flag = true;
			bool flag2 = true;
			bool flag3 = true;
			foreach (MidiEvent midiEvent in this.Events.Concat(new EndOfTrackEvent[]
			{
				new EndOfTrackEvent()
			}))
			{
				if (!(midiEvent is UnknownMetaEvent) || !settings.CompressionPolicy.HasFlag(CompressionPolicy.DeleteUnknownMetaEvents))
				{
					if (settings.CompressionPolicy.HasFlag(CompressionPolicy.NoteOffAsSilentNoteOn))
					{
						NoteOffEvent noteOffEvent = midiEvent as NoteOffEvent;
						if (noteOffEvent != null)
						{
							midiEvent = new NoteOnEvent
							{
								DeltaTime = noteOffEvent.DeltaTime,
								Channel = noteOffEvent.Channel,
								NoteNumber = noteOffEvent.NoteNumber
							};
						}
					}
					if ((!settings.CompressionPolicy.HasFlag(CompressionPolicy.DeleteDefaultSetTempo) || !TrackChunk.TrySkipDefaultSetTempo(midiEvent, ref flag)) && (!settings.CompressionPolicy.HasFlag(CompressionPolicy.DeleteDefaultKeySignature) || !TrackChunk.TrySkipDefaultKeySignature(midiEvent, ref flag2)) && (!settings.CompressionPolicy.HasFlag(CompressionPolicy.DeleteDefaultTimeSignature) || !TrackChunk.TrySkipDefaultTimeSignature(midiEvent, ref flag3)))
					{
						IEventWriter writer = EventWriterFactory.GetWriter(midiEvent);
						bool arg;
						if (midiEvent is ChannelEvent)
						{
							byte statusByte = writer.GetStatusByte(midiEvent);
							byte? b2 = b;
							int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
							int num2 = (int)statusByte;
							arg = (!(num.GetValueOrDefault() == num2 & num != null) || !settings.CompressionPolicy.HasFlag(CompressionPolicy.UseRunningStatus));
							b = new byte?(statusByte);
						}
						else
						{
							b = null;
							arg = true;
						}
						eventHandler(writer, midiEvent, arg);
					}
				}
			}
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x001472E4 File Offset: 0x001454E4
		private static bool TrySkipDefaultSetTempo(MidiEvent midiEvent, ref bool skip)
		{
			if (skip)
			{
				SetTempoEvent setTempoEvent = midiEvent as SetTempoEvent;
				if (setTempoEvent != null)
				{
					if (setTempoEvent.MicrosecondsPerQuarterNote == 500000L)
					{
						return true;
					}
					skip = false;
				}
			}
			return false;
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00147318 File Offset: 0x00145518
		private static bool TrySkipDefaultKeySignature(MidiEvent midiEvent, ref bool skip)
		{
			if (skip)
			{
				KeySignatureEvent keySignatureEvent = midiEvent as KeySignatureEvent;
				if (keySignatureEvent != null)
				{
					if (keySignatureEvent.Key == 0 && keySignatureEvent.Scale == 0)
					{
						return true;
					}
					skip = false;
				}
			}
			return false;
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x0014734C File Offset: 0x0014554C
		private static bool TrySkipDefaultTimeSignature(MidiEvent midiEvent, ref bool skip)
		{
			if (skip)
			{
				TimeSignatureEvent timeSignatureEvent = midiEvent as TimeSignatureEvent;
				if (timeSignatureEvent != null)
				{
					if (timeSignatureEvent.Numerator == 4 && timeSignatureEvent.Denominator == 4 && timeSignatureEvent.ClocksPerClick == 24 && timeSignatureEvent.NumberOf32ndNotesPerBeat == 8)
					{
						return true;
					}
					skip = false;
				}
			}
			return false;
		}

		// Token: 0x04000B02 RID: 2818
		public const string Id = "MTrk";

		// Token: 0x04000B04 RID: 2820
		private List<int> onEvents;

		// Token: 0x04000B05 RID: 2821
		private long absTime;
	}
}
