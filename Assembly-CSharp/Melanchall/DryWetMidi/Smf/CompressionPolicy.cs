using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001D5 RID: 469
	[Flags]
	public enum CompressionPolicy
	{
		// Token: 0x04000C0E RID: 3086
		NoCompression = 0,
		// Token: 0x04000C0F RID: 3087
		Default = 31,
		// Token: 0x04000C10 RID: 3088
		UseRunningStatus = 1,
		// Token: 0x04000C11 RID: 3089
		NoteOffAsSilentNoteOn = 2,
		// Token: 0x04000C12 RID: 3090
		DeleteDefaultTimeSignature = 4,
		// Token: 0x04000C13 RID: 3091
		DeleteDefaultKeySignature = 8,
		// Token: 0x04000C14 RID: 3092
		DeleteDefaultSetTempo = 16,
		// Token: 0x04000C15 RID: 3093
		DeleteUnknownMetaEvents = 32,
		// Token: 0x04000C16 RID: 3094
		DeleteUnknownChunks = 64
	}
}
