using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A1 RID: 417
	internal interface IEventReader
	{
		// Token: 0x060033A2 RID: 13218
		MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte);
	}
}
