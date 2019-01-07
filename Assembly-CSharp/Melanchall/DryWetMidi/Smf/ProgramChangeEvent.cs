using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000182 RID: 386
	public sealed class ProgramChangeEvent : ChannelEvent
	{
		// Token: 0x060032EE RID: 13038 RVA: 0x00016CDA File Offset: 0x00014EDA
		public ProgramChangeEvent() : base(1)
		{
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00016EBE File Offset: 0x000150BE
		public ProgramChangeEvent(SevenBitNumber programNumber) : this()
		{
			this.ProgramNumber = programNumber;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00016CF2 File Offset: 0x00014EF2
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00016CFB File Offset: 0x00014EFB
		public SevenBitNumber ProgramNumber
		{
			get
			{
				return base[0];
			}
			set
			{
				base[0] = value;
			}
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x00016ECD File Offset: 0x000150CD
		public override string ToString()
		{
			return string.Format("Program Change [{0}] ({1})", base.Channel, this.ProgramNumber);
		}

		// Token: 0x04000B4D RID: 2893
		private const int ParametersCount = 1;

		// Token: 0x04000B4E RID: 2894
		private const int ProgramNumberParameterIndex = 0;
	}
}
