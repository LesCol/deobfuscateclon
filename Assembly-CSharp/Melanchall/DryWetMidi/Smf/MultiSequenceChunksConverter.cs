using System;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000165 RID: 357
	internal sealed class MultiSequenceChunksConverter : IChunksConverter
	{
		// Token: 0x06003246 RID: 12870 RVA: 0x00147440 File Offset: 0x00145640
		public IEnumerable<MidiChunk> Convert(IEnumerable<MidiChunk> chunks)
		{
			TrackChunk[] array = chunks.OfType<TrackChunk>().ToArray<TrackChunk>();
			if (array.Length == 0)
			{
				return chunks;
			}
			IEnumerable<Class0<TrackChunk, int>> source = array.Select((TrackChunk c, int i) => new Class0<TrackChunk, int>(c, ((int)MultiSequenceChunksConverter.GetSequenceNumber(c)) ?? i)).ToArray<Class0<TrackChunk, int>>();
			IChunksConverter singleTrackChunksConverter = ChunksConverterFactory.GetConverter(MidiFileFormat.SingleTrack);
			return (from n in source
			group n by n.Prop_1).SelectMany((IGrouping<int, Class0<TrackChunk, int>> g) => singleTrackChunksConverter.Convert(from n in g
			select n.Prop_0)).Concat(from c in chunks
			where !(c is TrackChunk)
			select c);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x001474FC File Offset: 0x001456FC
		private static ushort? GetSequenceNumber(TrackChunk trackChunk)
		{
			SequenceNumberEvent sequenceNumberEvent = trackChunk.Events.TakeWhile((MidiEvent m) => m.DeltaTime == 0L).OfType<SequenceNumberEvent>().FirstOrDefault<SequenceNumberEvent>();
			if (sequenceNumberEvent == null)
			{
				return null;
			}
			return new ushort?(sequenceNumberEvent.Number);
		}
	}
}
