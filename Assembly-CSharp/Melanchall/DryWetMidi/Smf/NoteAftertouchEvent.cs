using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200017D RID: 381
	public sealed class NoteAftertouchEvent : ChannelEvent
	{
		// Token: 0x060032D4 RID: 13012 RVA: 0x00016D27 File Offset: 0x00014F27
		public NoteAftertouchEvent() : base(2)
		{
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00016D86 File Offset: 0x00014F86
		public NoteAftertouchEvent(SevenBitNumber noteNumber, SevenBitNumber aftertouchValue) : this()
		{
			this.NoteNumber = noteNumber;
			this.AftertouchValue = aftertouchValue;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x00016CF2 File Offset: 0x00014EF2
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x00016CFB File Offset: 0x00014EFB
		public SevenBitNumber NoteNumber
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00016D46 File Offset: 0x00014F46
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00016D4F File Offset: 0x00014F4F
		public SevenBitNumber AftertouchValue
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

		// Token: 0x060032DA RID: 13018 RVA: 0x00016D9C File Offset: 0x00014F9C
		public override string ToString()
		{
			return string.Format("Note Aftertouch [{0}] ({1}, {2})", base.Channel, this.NoteNumber, this.AftertouchValue);
		}

		// Token: 0x04000B43 RID: 2883
		private const int ParametersCount = 2;

		// Token: 0x04000B44 RID: 2884
		private const int NoteNumberParameterIndex = 0;

		// Token: 0x04000B45 RID: 2885
		private const int AftertouchValueParameterIndex = 1;
	}
}
