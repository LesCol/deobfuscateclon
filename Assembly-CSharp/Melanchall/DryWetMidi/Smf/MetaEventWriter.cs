using System;
using System.Diagnostics;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A9 RID: 425
	internal sealed class MetaEventWriter : IEventWriter
	{
		// Token: 0x060033BA RID: 13242 RVA: 0x001486D0 File Offset: 0x001468D0
		public void Write(MidiEvent midiEvent, MidiWriter writer, WritingSettings settings, bool writeStatusByte)
		{
			if (writeStatusByte)
			{
				writer.WriteByte(byte.MaxValue);
			}
			UnknownMetaEvent unknownMetaEvent = midiEvent as UnknownMetaEvent;
			byte statusByte;
			if (unknownMetaEvent != null)
			{
				statusByte = unknownMetaEvent.StatusByte;
			}
			else
			{
				Type type = midiEvent.GetType();
				if (!StandardEventTypes.Meta.TryGetStatusByte(type, out statusByte))
				{
					EventTypesCollection customMetaEventTypes = settings.CustomMetaEventTypes;
					if (customMetaEventTypes != null)
					{
						bool flag = !customMetaEventTypes.TryGetStatusByte(type, out statusByte);
					}
				}
			}
			writer.WriteByte(statusByte);
			int size = midiEvent.GetSize(settings);
			writer.WriteVlqNumber(size);
			midiEvent.Write(writer, settings);
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x0014874C File Offset: 0x0014694C
		public int CalculateSize(MidiEvent midiEvent, WritingSettings settings, bool writeStatusByte)
		{
			int size = midiEvent.GetSize(settings);
			return (writeStatusByte ? 1 : 0) + 1 + size.GetVlqLength() + size;
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00017810 File Offset: 0x00015A10
		public byte GetStatusByte(MidiEvent midiEvent)
		{
			return byte.MaxValue;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00002C8A File Offset: 0x00000E8A
		[Conditional("DEBUG")]
		private static void VerifyEvent(MidiEvent midiEvent)
		{
		}
	}
}
