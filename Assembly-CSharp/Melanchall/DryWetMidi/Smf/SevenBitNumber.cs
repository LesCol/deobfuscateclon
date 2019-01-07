using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000176 RID: 374
	public struct SevenBitNumber : IComparable<SevenBitNumber>
	{
		// Token: 0x0600329E RID: 12958 RVA: 0x00016B4B File Offset: 0x00014D4B
		public SevenBitNumber(byte value)
		{
			this._value = value;
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x00016B54 File Offset: 0x00014D54
		public static implicit operator byte(SevenBitNumber number)
		{
			return number._value;
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00016B5C File Offset: 0x00014D5C
		public static explicit operator SevenBitNumber(byte number)
		{
			return new SevenBitNumber(number);
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00016B64 File Offset: 0x00014D64
		public int CompareTo(SevenBitNumber other)
		{
			return this._value.CompareTo(other._value);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00016B77 File Offset: 0x00014D77
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00016B84 File Offset: 0x00014D84
		public override bool Equals(object obj)
		{
			return obj is SevenBitNumber && ((SevenBitNumber)obj)._value == this._value;
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00016BA3 File Offset: 0x00014DA3
		public override int GetHashCode()
		{
			return this._value.GetHashCode();
		}

		// Token: 0x04000B32 RID: 2866
		public static readonly SevenBitNumber MinValue = new SevenBitNumber(0);

		// Token: 0x04000B33 RID: 2867
		public static readonly SevenBitNumber MaxValue = new SevenBitNumber(127);

		// Token: 0x04000B34 RID: 2868
		private const byte Min = 0;

		// Token: 0x04000B35 RID: 2869
		private const byte Max = 127;

		// Token: 0x04000B36 RID: 2870
		private byte _value;
	}
}
