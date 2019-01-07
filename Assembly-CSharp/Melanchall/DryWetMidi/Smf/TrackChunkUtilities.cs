using System;
using System.Collections.Generic;
using System.Linq;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001D4 RID: 468
	public static class TrackChunkUtilities
	{
		// Token: 0x0600348A RID: 13450 RVA: 0x0001826B File Offset: 0x0001646B
		public static IEnumerable<TrackChunk> GetTrackChunks(this MidiFile midiFile)
		{
			return midiFile.Chunks.OfType<TrackChunk>();
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00018278 File Offset: 0x00016478
		public static TrackChunk Merge(this IEnumerable<TrackChunk> trackChunks)
		{
			return TrackChunkUtilities.ConvertTrackChunks(trackChunks, MidiFileFormat.SingleTrack).First<TrackChunk>();
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00018286 File Offset: 0x00016486
		public static IEnumerable<TrackChunk> Explode(this TrackChunk trackChunk)
		{
			return TrackChunkUtilities.ConvertTrackChunks(new TrackChunk[]
			{
				trackChunk
			}, MidiFileFormat.MultiTrack);
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00018298 File Offset: 0x00016498
		private static IEnumerable<TrackChunk> ConvertTrackChunks(IEnumerable<TrackChunk> trackChunks, MidiFileFormat format)
		{
			return ChunksConverterFactory.GetConverter(format).Convert(trackChunks).OfType<TrackChunk>();
		}
	}
}
