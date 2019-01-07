using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A8 RID: 424
	internal interface IEventWriter
	{
		// Token: 0x060033B7 RID: 13239
		void Write(MidiEvent midiEvent, MidiWriter writer, WritingSettings settings, bool writeStatusByte);

		// Token: 0x060033B8 RID: 13240
		int CalculateSize(MidiEvent midiEvent, WritingSettings settings, bool writeStatusByte);

		// Token: 0x060033B9 RID: 13241
		byte GetStatusByte(MidiEvent midiEvent);
	}
}
