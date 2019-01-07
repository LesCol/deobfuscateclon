using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001C8 RID: 456
	public enum UnknownChunkIdPolicy : byte
	{
		// Token: 0x04000BFB RID: 3067
		ReadAsUnknownChunk,
		// Token: 0x04000BFC RID: 3068
		Skip,
		// Token: 0x04000BFD RID: 3069
		Abort
	}
}
