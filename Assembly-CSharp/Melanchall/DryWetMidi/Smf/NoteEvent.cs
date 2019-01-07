using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200017E RID: 382
	public abstract class NoteEvent : ChannelEvent
	{
		// Token: 0x060032DB RID: 13019 RVA: 0x00016D27 File Offset: 0x00014F27
		public NoteEvent() : base(2)
		{
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x00016DC9 File Offset: 0x00014FC9
		public NoteEvent(SevenBitNumber noteNumber, SevenBitNumber velocity) : this()
		{
			this.NoteNumber = noteNumber;
			this.Velocity = velocity;
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x00016CF2 File Offset: 0x00014EF2
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x00016CFB File Offset: 0x00014EFB
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

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x00016D46 File Offset: 0x00014F46
		// (set) Token: 0x060032E0 RID: 13024 RVA: 0x00016D4F File Offset: 0x00014F4F
		public SevenBitNumber Velocity
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

		// Token: 0x04000B46 RID: 2886
		private const int ParametersCount = 2;

		// Token: 0x04000B47 RID: 2887
		private const int NoteNumberParameterIndex = 0;

		// Token: 0x04000B48 RID: 2888
		private const int VelocityParameterIndex = 1;
	}
}
