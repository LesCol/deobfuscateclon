using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200018A RID: 394
	internal static class StandardEventTypes
	{
		// Token: 0x04000B71 RID: 2929
		internal static readonly EventTypesCollection Channel = new EventTypesCollection
		{
			{
				typeof(ChannelAftertouchEvent),
				13
			},
			{
				typeof(ControlChangeEvent),
				11
			},
			{
				typeof(NoteAftertouchEvent),
				10
			},
			{
				typeof(NoteOffEvent),
				8
			},
			{
				typeof(NoteOnEvent),
				9
			},
			{
				typeof(PitchBendEvent),
				14
			},
			{
				typeof(ProgramChangeEvent),
				12
			}
		};

		// Token: 0x04000B72 RID: 2930
		internal static readonly EventTypesCollection Meta = new EventTypesCollection
		{
			{
				typeof(SequenceNumberEvent),
				0
			},
			{
				typeof(TextEvent),
				1
			},
			{
				typeof(CopyrightNoticeEvent),
				2
			},
			{
				typeof(SequenceTrackNameEvent),
				3
			},
			{
				typeof(InstrumentNameEvent),
				4
			},
			{
				typeof(LyricEvent),
				5
			},
			{
				typeof(MarkerEvent),
				6
			},
			{
				typeof(CuePointEvent),
				7
			},
			{
				typeof(ProgramNameEvent),
				8
			},
			{
				typeof(DeviceNameEvent),
				9
			},
			{
				typeof(ChannelPrefixEvent),
				32
			},
			{
				typeof(PortPrefixEvent),
				33
			},
			{
				typeof(EndOfTrackEvent),
				47
			},
			{
				typeof(SetTempoEvent),
				81
			},
			{
				typeof(SmpteOffsetEvent),
				84
			},
			{
				typeof(TimeSignatureEvent),
				88
			},
			{
				typeof(KeySignatureEvent),
				89
			},
			{
				typeof(SequencerSpecificEvent),
				127
			}
		};

		// Token: 0x04000B73 RID: 2931
		internal static readonly EventTypesCollection SysEx = new EventTypesCollection
		{
			{
				typeof(EscapeSysExEvent),
				247
			},
			{
				typeof(NormalSysExEvent),
				240
			}
		};
	}
}
