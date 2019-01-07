using System;
using System.Diagnostics;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001AA RID: 426
	internal sealed class SysExEventWriter : IEventWriter
	{
		// Token: 0x060033BF RID: 13247 RVA: 0x00148774 File Offset: 0x00146974
		public void Write(MidiEvent midiEvent, MidiWriter writer, WritingSettings settings, bool writeStatusByte)
		{
			if (writeStatusByte)
			{
				Type type = midiEvent.GetType();
				byte value;
				StandardEventTypes.SysEx.TryGetStatusByte(type, out value);
				writer.WriteByte(value);
			}
			int size = midiEvent.GetSize(settings);
			writer.WriteVlqNumber(size);
			midiEvent.Write(writer, settings);
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x001487B8 File Offset: 0x001469B8
		public int CalculateSize(MidiEvent midiEvent, WritingSettings settings, bool writeStatusByte)
		{
			int size = midiEvent.GetSize(settings);
			return (writeStatusByte ? 1 : 0) + size.GetVlqLength() + size;
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x001487E0 File Offset: 0x001469E0
		public byte GetStatusByte(MidiEvent midiEvent)
		{
			byte result;
			StandardEventTypes.SysEx.TryGetStatusByte(midiEvent.GetType(), out result);
			return result;
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002C8A File Offset: 0x00000E8A
		[Conditional("DEBUG")]
		private static void VerifyEvent(MidiEvent midiEvent)
		{
		}
	}
}
