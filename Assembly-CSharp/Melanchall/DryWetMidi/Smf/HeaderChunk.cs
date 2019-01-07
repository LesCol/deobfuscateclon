using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200015A RID: 346
	internal sealed class HeaderChunk : MidiChunk
	{
		// Token: 0x0600320F RID: 12815 RVA: 0x00016546 File Offset: 0x00014746
		internal HeaderChunk() : base("MThd")
		{
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x00016553 File Offset: 0x00014753
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x0001655B File Offset: 0x0001475B
		public ushort FileFormat { get; set; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x00016564 File Offset: 0x00014764
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x0001656C File Offset: 0x0001476C
		public TimeDivision TimeDivision { get; set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x00016575 File Offset: 0x00014775
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x0001657D File Offset: 0x0001477D
		public ushort TracksNumber { get; set; }

		// Token: 0x06003216 RID: 12822 RVA: 0x00146C5C File Offset: 0x00144E5C
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size)
		{
			ushort num = reader.ReadWord();
			if (settings.UnknownFileFormatPolicy == UnknownFileFormatPolicy.Abort && !Enum.IsDefined(typeof(MidiFileFormat), (int)num))
			{
				throw new UnknownFileFormatException(string.Format("File format {0} is unknown.", num), num);
			}
			this.FileFormat = num;
			this.TracksNumber = reader.ReadWord();
			this.TimeDivision = TimeDivisionFactory.GetTimeDivision(reader.ReadInt16());
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00016586 File Offset: 0x00014786
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteWord(this.FileFormat);
			writer.WriteWord(this.TracksNumber);
			writer.WriteInt16(this.TimeDivision.ToInt16());
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000165B1 File Offset: 0x000147B1
		protected override uint GetContentSize(WritingSettings settings)
		{
			return 6u;
		}

		// Token: 0x04000AF6 RID: 2806
		public const string Id = "MThd";
	}
}
