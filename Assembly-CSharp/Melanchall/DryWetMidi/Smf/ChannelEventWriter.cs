using System;
using System.Diagnostics;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A6 RID: 422
	internal sealed class ChannelEventWriter : IEventWriter
	{
		// Token: 0x060033B0 RID: 13232 RVA: 0x00148648 File Offset: 0x00146848
		public void Write(MidiEvent midiEvent, MidiWriter writer, WritingSettings settings, bool writeStatusByte)
		{
			if (writeStatusByte)
			{
				Type type = midiEvent.GetType();
				byte number;
				StandardEventTypes.Channel.TryGetStatusByte(type, out number);
				FourBitNumber channel = ((ChannelEvent)midiEvent).Channel;
				byte value = DataTypesUtilities.Combine((FourBitNumber)number, channel);
				writer.WriteByte(value);
			}
			midiEvent.Write(writer, settings);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000177BC File Offset: 0x000159BC
		public int CalculateSize(MidiEvent midiEvent, WritingSettings settings, bool writeStatusByte)
		{
			return (writeStatusByte ? 1 : 0) + midiEvent.GetSize(settings);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00148698 File Offset: 0x00146898
		public byte GetStatusByte(MidiEvent midiEvent)
		{
			byte number;
			StandardEventTypes.Channel.TryGetStatusByte(midiEvent.GetType(), out number);
			return DataTypesUtilities.Combine((FourBitNumber)number, ((ChannelEvent)midiEvent).Channel);
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00002C8A File Offset: 0x00000E8A
		[Conditional("DEBUG")]
		private static void VerifyEvent(MidiEvent midiEvent)
		{
		}
	}
}
