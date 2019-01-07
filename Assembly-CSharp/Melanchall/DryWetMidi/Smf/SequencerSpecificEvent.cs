using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000198 RID: 408
	public sealed class SequencerSpecificEvent : MetaEvent
	{
		// Token: 0x06003350 RID: 13136 RVA: 0x00016FCC File Offset: 0x000151CC
		public SequencerSpecificEvent()
		{
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00017329 File Offset: 0x00015529
		public SequencerSpecificEvent(byte[] data) : this()
		{
			this.Data = data;
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x00017338 File Offset: 0x00015538
		// (set) Token: 0x06003353 RID: 13139 RVA: 0x00017340 File Offset: 0x00015540
		public byte[] Data { get; set; }

		// Token: 0x06003354 RID: 13140 RVA: 0x00017349 File Offset: 0x00015549
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			this.Data = reader.ReadBytes(size);
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00147EB0 File Offset: 0x001460B0
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data != null)
			{
				writer.WriteBytes(data);
			}
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00017358 File Offset: 0x00015558
		protected override int GetContentSize(WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.Length;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00017368 File Offset: 0x00015568
		protected override MidiEvent CloneEvent()
		{
			byte[] data = this.Data;
			return new SequencerSpecificEvent(((data != null) ? data.Clone() : null) as byte[]);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00017386 File Offset: 0x00015586
		public override string ToString()
		{
			return "Sequencer Specific";
		}
	}
}
