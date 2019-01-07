using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000183 RID: 387
	internal static class EventStatusBytes
	{
		// Token: 0x02000184 RID: 388
		internal static class Global
		{
			// Token: 0x04000B4F RID: 2895
			public const byte Meta = 255;

			// Token: 0x04000B50 RID: 2896
			public const byte NormalSysEx = 240;

			// Token: 0x04000B51 RID: 2897
			public const byte EscapeSysEx = 247;
		}

		// Token: 0x02000185 RID: 389
		internal static class Meta
		{
			// Token: 0x04000B52 RID: 2898
			public const byte SequenceNumber = 0;

			// Token: 0x04000B53 RID: 2899
			public const byte Text = 1;

			// Token: 0x04000B54 RID: 2900
			public const byte CopyrightNotice = 2;

			// Token: 0x04000B55 RID: 2901
			public const byte SequenceTrackName = 3;

			// Token: 0x04000B56 RID: 2902
			public const byte InstrumentName = 4;

			// Token: 0x04000B57 RID: 2903
			public const byte Lyric = 5;

			// Token: 0x04000B58 RID: 2904
			public const byte Marker = 6;

			// Token: 0x04000B59 RID: 2905
			public const byte CuePoint = 7;

			// Token: 0x04000B5A RID: 2906
			public const byte ProgramName = 8;

			// Token: 0x04000B5B RID: 2907
			public const byte DeviceName = 9;

			// Token: 0x04000B5C RID: 2908
			public const byte ChannelPrefix = 32;

			// Token: 0x04000B5D RID: 2909
			public const byte PortPrefix = 33;

			// Token: 0x04000B5E RID: 2910
			public const byte EndOfTrack = 47;

			// Token: 0x04000B5F RID: 2911
			public const byte SetTempo = 81;

			// Token: 0x04000B60 RID: 2912
			public const byte SmpteOffset = 84;

			// Token: 0x04000B61 RID: 2913
			public const byte TimeSignature = 88;

			// Token: 0x04000B62 RID: 2914
			public const byte KeySignature = 89;

			// Token: 0x04000B63 RID: 2915
			public const byte SequencerSpecific = 127;
		}

		// Token: 0x02000186 RID: 390
		internal static class Channel
		{
			// Token: 0x04000B64 RID: 2916
			public const byte NoteOff = 8;

			// Token: 0x04000B65 RID: 2917
			public const byte NoteOn = 9;

			// Token: 0x04000B66 RID: 2918
			public const byte NoteAftertouch = 10;

			// Token: 0x04000B67 RID: 2919
			public const byte ControlChange = 11;

			// Token: 0x04000B68 RID: 2920
			public const byte ProgramChange = 12;

			// Token: 0x04000B69 RID: 2921
			public const byte ChannelAftertouch = 13;

			// Token: 0x04000B6A RID: 2922
			public const byte PitchBend = 14;
		}
	}
}
