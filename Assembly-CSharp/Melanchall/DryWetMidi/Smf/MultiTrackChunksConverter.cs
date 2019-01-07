using System;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000168 RID: 360
	internal sealed class MultiTrackChunksConverter : IChunksConverter
	{
		// Token: 0x06003252 RID: 12882 RVA: 0x00147588 File Offset: 0x00145788
		public IEnumerable<MidiChunk> Convert(IEnumerable<MidiChunk> chunks)
		{
			TrackChunk[] array = chunks.OfType<TrackChunk>().ToArray<TrackChunk>();
			if (array.Length != 1)
			{
				return chunks;
			}
			MultiTrackChunksConverter.TrackChunkDescriptor[] array2 = (from i in Enumerable.Range(0, 17)
			select new MultiTrackChunksConverter.TrackChunkDescriptor()).ToArray<MultiTrackChunksConverter.TrackChunkDescriptor>();
			FourBitNumber? fourBitNumber = null;
			using (IEnumerator<MidiEvent> enumerator = (from m in array.First<TrackChunk>().Events
			select m.Clone()).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MidiEvent midiEvent = enumerator.Current;
					Array.ForEach<MultiTrackChunksConverter.TrackChunkDescriptor>(array2, delegate(MultiTrackChunksConverter.TrackChunkDescriptor d)
					{
						d.DeltaTime += midiEvent.DeltaTime;
					});
					ChannelEvent channelEvent = midiEvent as ChannelEvent;
					if (channelEvent != null)
					{
						array2[(int)(channelEvent.Channel + 1)].AddEvent(midiEvent.Clone());
						fourBitNumber = null;
					}
					else
					{
						if (!(midiEvent is MetaEvent))
						{
							fourBitNumber = null;
						}
						ChannelPrefixEvent channelPrefixEvent = midiEvent as ChannelPrefixEvent;
						if (channelPrefixEvent != null)
						{
							fourBitNumber = new FourBitNumber?((FourBitNumber)channelPrefixEvent.Channel);
						}
						if (fourBitNumber != null)
						{
							array2[(int)(fourBitNumber.Value + 1)].AddEvent(midiEvent);
						}
						else
						{
							array2[0].AddEvent(midiEvent);
						}
					}
				}
			}
			return (from d in array2
			select d.Chunk into c
			where c.Events.Any<MidiEvent>()
			select c).Concat(from c in chunks
			where !(c is TrackChunk)
			select c);
		}

		// Token: 0x04000B13 RID: 2835
		private const int ChannelsCount = 16;

		// Token: 0x02000169 RID: 361
		private sealed class TrackChunkDescriptor
		{
			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06003254 RID: 12884 RVA: 0x000167E8 File Offset: 0x000149E8
			public TrackChunk Chunk { get; } = new TrackChunk();

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06003255 RID: 12885 RVA: 0x000167F0 File Offset: 0x000149F0
			// (set) Token: 0x06003256 RID: 12886 RVA: 0x000167F8 File Offset: 0x000149F8
			public long DeltaTime { get; set; }

			// Token: 0x06003257 RID: 12887 RVA: 0x00016801 File Offset: 0x00014A01
			public void AddEvent(MidiEvent midiEvent)
			{
				midiEvent.DeltaTime = this.DeltaTime;
				this.Chunk.Events.Add(midiEvent);
				this.DeltaTime = 0L;
			}
		}
	}
}
