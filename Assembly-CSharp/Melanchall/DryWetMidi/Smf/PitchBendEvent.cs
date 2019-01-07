using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000181 RID: 385
	public sealed class PitchBendEvent : ChannelEvent
	{
		// Token: 0x060032E9 RID: 13033 RVA: 0x00016D27 File Offset: 0x00014F27
		public PitchBendEvent() : base(2)
		{
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x00016E5C File Offset: 0x0001505C
		public PitchBendEvent(ushort pitchValue) : this()
		{
			this.PitchValue = pitchValue;
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060032EB RID: 13035 RVA: 0x00016E6B File Offset: 0x0001506B
		// (set) Token: 0x060032EC RID: 13036 RVA: 0x00016E80 File Offset: 0x00015080
		public ushort PitchValue
		{
			get
			{
				return DataTypesUtilities.Combine(base[1], base[0]);
			}
			set
			{
				base[0] = value.GetTail();
				base[1] = value.GetHead();
			}
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x00016E9C File Offset: 0x0001509C
		public override string ToString()
		{
			return string.Format("Pitch Bend [{0}] ({1})", base.Channel, this.PitchValue);
		}

		// Token: 0x04000B4A RID: 2890
		private const int ParametersCount = 2;

		// Token: 0x04000B4B RID: 2891
		private const int PitchValueLsbParameterIndex = 0;

		// Token: 0x04000B4C RID: 2892
		private const int PitchValueMsbParameterIndex = 1;
	}
}
