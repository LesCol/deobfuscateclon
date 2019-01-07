using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200018C RID: 396
	public sealed class ChannelPrefixEvent : MetaEvent
	{
		// Token: 0x06003307 RID: 13063 RVA: 0x00016FCC File Offset: 0x000151CC
		public ChannelPrefixEvent()
		{
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x0001701F File Offset: 0x0001521F
		public ChannelPrefixEvent(byte channel) : this()
		{
			this.Channel = channel;
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x0001702E File Offset: 0x0001522E
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x00017036 File Offset: 0x00015236
		public byte Channel { get; set; }

		// Token: 0x0600330B RID: 13067 RVA: 0x0001703F File Offset: 0x0001523F
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			this.Channel = reader.ReadByte();
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x0001704D File Offset: 0x0001524D
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteByte(this.Channel);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x0000D05B File Offset: 0x0000B25B
		protected override int GetContentSize(WritingSettings settings)
		{
			return 1;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x0001705B File Offset: 0x0001525B
		protected override MidiEvent CloneEvent()
		{
			return new ChannelPrefixEvent(this.Channel);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x00017068 File Offset: 0x00015268
		public override string ToString()
		{
			return string.Format("Channel Prefix ({0})", this.Channel);
		}
	}
}
