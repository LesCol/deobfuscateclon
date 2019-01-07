using System;
using System.Collections.Generic;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000163 RID: 355
	internal static class ChunksConverterFactory
	{
		// Token: 0x06003243 RID: 12867 RVA: 0x0014740C File Offset: 0x0014560C
		public static IChunksConverter GetConverter(MidiFileFormat format)
		{
			IChunksConverter result;
			if (!ChunksConverterFactory._converters.TryGetValue(format, out result))
			{
				throw new NotSupportedException(string.Format("Converter for the {0} format is not supported.", format));
			}
			return result;
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x00016749 File Offset: 0x00014949
		// Note: this type is marked as 'beforefieldinit'.
		static ChunksConverterFactory()
		{
			Dictionary<MidiFileFormat, IChunksConverter> dictionary = new Dictionary<MidiFileFormat, IChunksConverter>();
			dictionary[MidiFileFormat.SingleTrack] = new SingleTrackChunksConverter();
			dictionary[MidiFileFormat.MultiTrack] = new MultiTrackChunksConverter();
			dictionary[MidiFileFormat.MultiSequence] = new MultiSequenceChunksConverter();
			ChunksConverterFactory._converters = dictionary;
		}

		// Token: 0x04000B0B RID: 2827
		private static readonly Dictionary<MidiFileFormat, IChunksConverter> _converters;
	}
}
