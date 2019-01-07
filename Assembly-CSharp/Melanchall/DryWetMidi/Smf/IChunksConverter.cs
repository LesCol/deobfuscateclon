using System;
using System.Collections.Generic;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000164 RID: 356
	internal interface IChunksConverter
	{
		// Token: 0x06003245 RID: 12869
		IEnumerable<MidiChunk> Convert(IEnumerable<MidiChunk> chunks);
	}
}
