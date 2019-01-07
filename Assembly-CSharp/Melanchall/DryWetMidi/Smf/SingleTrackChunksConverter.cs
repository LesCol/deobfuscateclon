using System;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200016C RID: 364
	internal sealed class SingleTrackChunksConverter : IChunksConverter
	{
		// Token: 0x06003262 RID: 12898 RVA: 0x0014778C File Offset: 0x0014598C
		public IEnumerable<MidiChunk> Convert(IEnumerable<MidiChunk> chunks)
		{
			TrackChunk[] array = chunks.OfType<TrackChunk>().ToArray<TrackChunk>();
			if (array.Length == 1)
			{
				return chunks;
			}
			MidiEvent midiEvent;
			IEnumerable<SingleTrackChunksConverter.EventDescriptor> enumerable = array.SelectMany(delegate(TrackChunk trackChunk)
			{
				long absoluteTime = 0L;
				int channel = -1;
				return trackChunk.Events.Select(delegate(MidiEvent midiEvent)
				{
					ChannelPrefixEvent channelPrefixEvent = midiEvent as ChannelPrefixEvent;
					if (channelPrefixEvent != null)
					{
						channel = (int)channelPrefixEvent.Channel;
					}
					if (!(midiEvent is MetaEvent))
					{
						channel = -1;
					}
					return new SingleTrackChunksConverter.EventDescriptor(midiEvent, absoluteTime += midiEvent.DeltaTime, channel);
				});
			}).OrderBy((SingleTrackChunksConverter.EventDescriptor d) => d, new SingleTrackChunksConverter.EventDescriptorComparer());
			TrackChunk trackChunk2 = new TrackChunk();
			long num = 0L;
			foreach (SingleTrackChunksConverter.EventDescriptor eventDescriptor in enumerable)
			{
				midiEvent = eventDescriptor.Event.Clone();
				midiEvent.DeltaTime = eventDescriptor.AbsoluteTime - num;
				trackChunk2.Events.Add(midiEvent);
				num = eventDescriptor.AbsoluteTime;
			}
			return new TrackChunk[]
			{
				trackChunk2
			}.Concat(from c in chunks
			where !(c is TrackChunk)
			select c);
		}

		// Token: 0x0200016D RID: 365
		private sealed class EventDescriptor
		{
			// Token: 0x06003264 RID: 12900 RVA: 0x0001688C File Offset: 0x00014A8C
			public EventDescriptor(MidiEvent midiEvent, long absoluteTime, int channel)
			{
				this.Event = midiEvent;
				this.AbsoluteTime = absoluteTime;
				this.Channel = channel;
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06003265 RID: 12901 RVA: 0x000168A9 File Offset: 0x00014AA9
			public MidiEvent Event { get; }

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06003266 RID: 12902 RVA: 0x000168B1 File Offset: 0x00014AB1
			public long AbsoluteTime { get; }

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06003267 RID: 12903 RVA: 0x000168B9 File Offset: 0x00014AB9
			public int Channel { get; }
		}

		// Token: 0x0200016E RID: 366
		private sealed class EventDescriptorComparer : IComparer<SingleTrackChunksConverter.EventDescriptor>
		{
			// Token: 0x06003268 RID: 12904 RVA: 0x001478A8 File Offset: 0x00145AA8
			public int Compare(SingleTrackChunksConverter.EventDescriptor x, SingleTrackChunksConverter.EventDescriptor y)
			{
				long num = x.AbsoluteTime - y.AbsoluteTime;
				if (num != 0L)
				{
					return (int)(num / Math.Abs(num));
				}
				MetaEvent metaEvent = x.Event as MetaEvent;
				MetaEvent metaEvent2 = y.Event as MetaEvent;
				if (metaEvent != null && metaEvent2 == null)
				{
					return -1;
				}
				if (metaEvent == null && metaEvent2 != null)
				{
					return 1;
				}
				if (metaEvent == null && metaEvent2 == null)
				{
					return 0;
				}
				int num2 = x.Channel - y.Channel;
				if (num2 != 0)
				{
					return num2;
				}
				ChannelPrefixEvent channelPrefixEvent = x.Event as ChannelPrefixEvent;
				ChannelPrefixEvent channelPrefixEvent2 = y.Event as ChannelPrefixEvent;
				if (channelPrefixEvent != null && channelPrefixEvent2 == null)
				{
					return -1;
				}
				if (channelPrefixEvent == null && channelPrefixEvent2 != null)
				{
					return 1;
				}
				return 0;
			}
		}
	}
}
