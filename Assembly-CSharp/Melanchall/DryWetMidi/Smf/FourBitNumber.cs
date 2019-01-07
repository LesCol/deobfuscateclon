using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000175 RID: 373
	public struct FourBitNumber : IComparable<FourBitNumber>
	{
		// Token: 0x06003296 RID: 12950 RVA: 0x00016AFA File Offset: 0x00014CFA
		public FourBitNumber(byte value)
		{
			this._value = value;
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x00016B03 File Offset: 0x00014D03
		public static implicit operator byte(FourBitNumber number)
		{
			return number._value;
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00016B0B File Offset: 0x00014D0B
		public static explicit operator FourBitNumber(byte number)
		{
			return new FourBitNumber(number);
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x001479D8 File Offset: 0x00145BD8
		public int CompareTo(FourBitNumber other)
		{
			return this._value.CompareTo(other._value);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x001479FC File Offset: 0x00145BFC
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00016B13 File Offset: 0x00014D13
		public override bool Equals(object obj)
		{
			return obj is FourBitNumber && ((FourBitNumber)obj)._value == this._value;
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00147A18 File Offset: 0x00145C18
		public override int GetHashCode()
		{
			return this._value.GetHashCode();
		}

		// Token: 0x04000B2D RID: 2861
		public static readonly FourBitNumber MinValue = new FourBitNumber(0);

		// Token: 0x04000B2E RID: 2862
		public static readonly FourBitNumber MaxValue = new FourBitNumber(15);

		// Token: 0x04000B2F RID: 2863
		private const byte Min = 0;

		// Token: 0x04000B30 RID: 2864
		private const byte Max = 15;

		// Token: 0x04000B31 RID: 2865
		private readonly byte _value;
	}
}
