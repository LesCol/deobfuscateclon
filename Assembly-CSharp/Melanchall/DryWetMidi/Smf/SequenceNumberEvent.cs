using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000197 RID: 407
	public sealed class SequenceNumberEvent : MetaEvent
	{
		// Token: 0x06003347 RID: 13127 RVA: 0x00016FCC File Offset: 0x000151CC
		public SequenceNumberEvent()
		{
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000172C4 File Offset: 0x000154C4
		public SequenceNumberEvent(ushort number) : this()
		{
			this.Number = number;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x000172D3 File Offset: 0x000154D3
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x000172DB File Offset: 0x000154DB
		public ushort Number { get; set; }

		// Token: 0x0600334B RID: 13131 RVA: 0x000172E4 File Offset: 0x000154E4
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			if (size < 2)
			{
				return;
			}
			this.Number = reader.ReadWord();
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000172F7 File Offset: 0x000154F7
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteWord(this.Number);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000171BC File Offset: 0x000153BC
		protected override int GetContentSize(WritingSettings settings)
		{
			return 2;
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00017305 File Offset: 0x00015505
		protected override MidiEvent CloneEvent()
		{
			return new SequenceNumberEvent(this.Number);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00017312 File Offset: 0x00015512
		public override string ToString()
		{
			return string.Format("Sequence Number ({0})", this.Number);
		}
	}
}
