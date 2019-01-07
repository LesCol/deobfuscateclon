using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200017B RID: 379
	public sealed class ChannelAftertouchEvent : ChannelEvent
	{
		// Token: 0x060032C8 RID: 13000 RVA: 0x00016CDA File Offset: 0x00014EDA
		public ChannelAftertouchEvent() : base(1)
		{
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00016CE3 File Offset: 0x00014EE3
		public ChannelAftertouchEvent(SevenBitNumber aftertouchValue) : this()
		{
			this.AftertouchValue = aftertouchValue;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x00016CF2 File Offset: 0x00014EF2
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00016CFB File Offset: 0x00014EFB
		public SevenBitNumber AftertouchValue
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

		// Token: 0x060032CC RID: 13004 RVA: 0x00016D05 File Offset: 0x00014F05
		public override string ToString()
		{
			return string.Format("Channel Aftertouch [{0}] ({1})", base.Channel, this.AftertouchValue);
		}

		// Token: 0x04000B3E RID: 2878
		private const int ParametersCount = 1;

		// Token: 0x04000B3F RID: 2879
		private const int AftertouchValueParameterIndex = 0;
	}
}
