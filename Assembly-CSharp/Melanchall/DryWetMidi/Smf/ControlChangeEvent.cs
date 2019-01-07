using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200017C RID: 380
	public sealed class ControlChangeEvent : ChannelEvent
	{
		// Token: 0x060032CD RID: 13005 RVA: 0x00016D27 File Offset: 0x00014F27
		public ControlChangeEvent() : base(2)
		{
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00016D30 File Offset: 0x00014F30
		public ControlChangeEvent(SevenBitNumber controlNumber, SevenBitNumber controlValue) : this()
		{
			this.ControlNumber = controlNumber;
			this.ControlValue = controlValue;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x00016CF2 File Offset: 0x00014EF2
		// (set) Token: 0x060032D0 RID: 13008 RVA: 0x00016CFB File Offset: 0x00014EFB
		public SevenBitNumber ControlNumber
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060032D1 RID: 13009 RVA: 0x00016D46 File Offset: 0x00014F46
		// (set) Token: 0x060032D2 RID: 13010 RVA: 0x00016D4F File Offset: 0x00014F4F
		public SevenBitNumber ControlValue
		{
			get
			{
				return base[1];
			}
			set
			{
				base[1] = value;
			}
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00016D59 File Offset: 0x00014F59
		public override string ToString()
		{
			return string.Format("Control Change [{0}] ({1}, {2})", base.Channel, this.ControlNumber, this.ControlValue);
		}

		// Token: 0x04000B40 RID: 2880
		private const int ParametersCount = 2;

		// Token: 0x04000B41 RID: 2881
		private const int ControlNumberParameterIndex = 0;

		// Token: 0x04000B42 RID: 2882
		private const int ControlValueParameterIndex = 1;
	}
}
