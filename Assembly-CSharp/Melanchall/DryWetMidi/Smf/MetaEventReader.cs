using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A2 RID: 418
	internal sealed class MetaEventReader : IEventReader
	{
		// Token: 0x060033A3 RID: 13219 RVA: 0x00148300 File Offset: 0x00146500
		public MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte)
		{
			byte b = reader.ReadByte();
			int num = reader.ReadVlqNumber();
			string typeName;
			MetaEventReader.TryGetEventType(b, out typeName);
			MetaEvent @event = this.GetEvent(typeName, b);
			long position = reader.Position;
			@event.Read(reader, settings, num);
			long num2 = reader.Position - position;
			long num3 = (long)num - num2;
			if (num3 > 0L)
			{
				reader.Position += num3;
			}
			return @event;
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00017760 File Offset: 0x00015960
		private static bool TryGetEventType(byte statusByte, out string eventType)
		{
			return StandardEventTypes.Meta.TryGetType(statusByte, out eventType);
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x0014836C File Offset: 0x0014656C
		private MetaEvent GetEvent(string typeName, byte status)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(typeName);
			if (num <= 2040605826u)
			{
				if (num <= 757105320u)
				{
					if (num <= 45005866u)
					{
						if (num != 28452538u)
						{
							if (num == 45005866u)
							{
								if (typeName == "TimeSignatureEvent")
								{
									return new TimeSignatureEvent();
								}
							}
						}
						else if (typeName == "SetTempoEvent")
						{
							return new SetTempoEvent();
						}
					}
					else if (num != 431988501u)
					{
						if (num == 757105320u)
						{
							if (typeName == "ChannelPrefixEvent")
							{
								return new ChannelPrefixEvent();
							}
						}
					}
					else if (typeName == "MarkerEvent")
					{
						return new MarkerEvent();
					}
				}
				else if (num <= 1535957770u)
				{
					if (num != 1236424022u)
					{
						if (num == 1535957770u)
						{
							if (typeName == "CopyrightNoticeEvent")
							{
								return new CopyrightNoticeEvent();
							}
						}
					}
					else if (typeName == "EndOfTrackEvent")
					{
						return new EndOfTrackEvent();
					}
				}
				else if (num != 1810609568u)
				{
					if (num != 1826634370u)
					{
						if (num == 2040605826u)
						{
							if (typeName == "CuePointEvent")
							{
								return new CuePointEvent();
							}
						}
					}
					else if (typeName == "KeySignatureEvent")
					{
						return new KeySignatureEvent();
					}
				}
				else if (typeName == "DeviceNameEvent")
				{
					return new DeviceNameEvent();
				}
			}
			else if (num <= 2767452083u)
			{
				if (num <= 2202407608u)
				{
					if (num != 2054064260u)
					{
						if (num == 2202407608u)
						{
							if (typeName == "ProgramNameEvent")
							{
								return new ProgramNameEvent();
							}
						}
					}
					else if (typeName == "SequenceTrackNameEvent")
					{
						return new SequenceTrackNameEvent();
					}
				}
				else if (num != 2307539212u)
				{
					if (num != 2356256044u)
					{
						if (num == 2767452083u)
						{
							if (typeName == "SequenceNumberEvent")
							{
								return new SequenceNumberEvent();
							}
						}
					}
					else if (typeName == "LyricEvent")
					{
						return new LyricEvent();
					}
				}
				else if (typeName == "UnknownMetaEvent")
				{
					return new UnknownMetaEvent(status);
				}
			}
			else if (num <= 3412826102u)
			{
				if (num != 3063633002u)
				{
					if (num == 3412826102u)
					{
						if (typeName == "PortPrefixEvent")
						{
							return new PortPrefixEvent();
						}
					}
				}
				else if (typeName == "TextEvent")
				{
					return new TextEvent();
				}
			}
			else if (num != 3454801426u)
			{
				if (num != 3542655393u)
				{
					if (num == 3804882413u)
					{
						if (typeName == "SmpteOffsetEvent")
						{
							return new SmpteOffsetEvent();
						}
					}
				}
				else if (typeName == "InstrumentNameEvent")
				{
					return new InstrumentNameEvent();
				}
			}
			else if (typeName == "SequencerSpecificEvent")
			{
				return new SequencerSpecificEvent();
			}
			return null;
		}
	}
}
