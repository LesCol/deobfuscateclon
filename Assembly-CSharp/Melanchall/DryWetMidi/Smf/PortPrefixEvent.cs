using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000195 RID: 405
	public sealed class PortPrefixEvent : MetaEvent
	{
		// Token: 0x0600333A RID: 13114 RVA: 0x00016FCC File Offset: 0x000151CC
		public PortPrefixEvent()
		{
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0001723C File Offset: 0x0001543C
		public PortPrefixEvent(byte port) : this()
		{
			this.Port = port;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x0001724B File Offset: 0x0001544B
		// (set) Token: 0x0600333D RID: 13117 RVA: 0x00017253 File Offset: 0x00015453
		public byte Port { get; set; }

		// Token: 0x0600333E RID: 13118 RVA: 0x0001725C File Offset: 0x0001545C
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			if (size >= 1)
			{
				this.Port = reader.ReadByte();
			}
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x0001726E File Offset: 0x0001546E
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteByte(this.Port);
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0000D05B File Offset: 0x0000B25B
		protected override int GetContentSize(WritingSettings settings)
		{
			return 1;
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x0001727C File Offset: 0x0001547C
		protected override MidiEvent CloneEvent()
		{
			return new PortPrefixEvent(this.Port);
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00017289 File Offset: 0x00015489
		public override string ToString()
		{
			return string.Format("Port Prefix ({0})", this.Port);
		}
	}
}
