using System;

// Token: 0x0200009A RID: 154
public struct GStruct2
{
	// Token: 0x06001D96 RID: 7574 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
	public void method_0(long long_1)
	{
		this.long_0 |= long_1;
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x000F2320 File Offset: 0x000F0520
	public bool method_1(GStruct2.GEnum12 genum12_0)
	{
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)obj;
			if (this.method_7(genum11_, genum12_0))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x0000D902 File Offset: 0x0000BB02
	public long method_2()
	{
		return this.long_0;
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x000F2390 File Offset: 0x000F0590
	public void method_3(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_38(genum11_0, genum12_0);
		if ((this.long_0 & num) == num)
		{
			return;
		}
		this.long_0 |= num;
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x000F23C0 File Offset: 0x000F05C0
	public bool method_4(GStruct2.GEnum11 genum11_0)
	{
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum12)))
		{
			GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj;
			if (this.method_37(genum11_0, genum12_))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x0000D90A File Offset: 0x0000BB0A
	public void method_5()
	{
		this.long_0 = 0L;
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x0000D902 File Offset: 0x0000BB02
	public long method_6()
	{
		return this.long_0;
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x000F2430 File Offset: 0x000F0630
	public bool method_7(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_41(genum11_0, genum12_0);
		return (this.long_0 & num) == num;
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x0000D90A File Offset: 0x0000BB0A
	public void method_8()
	{
		this.long_0 = 0L;
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x0000D91B File Offset: 0x0000BB1B
	private long method_9(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		return 1L << (int)(genum11_0 * GStruct2.GEnum11.GHLGuitar + (int)genum12_0);
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0000D902 File Offset: 0x0000BB02
	// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 |= value;
		}
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x000F2454 File Offset: 0x000F0654
	public bool method_10(GStruct2.GEnum11 genum11_0)
	{
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum12)))
		{
			GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj;
			if (this.method_36(genum11_0, genum12_))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x000F24C4 File Offset: 0x000F06C4
	public bool method_11(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_24(genum11_0, genum12_0);
		return (this.long_0 & num) == num;
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x000F24E8 File Offset: 0x000F06E8
	public void method_12(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_9(genum11_0, genum12_0);
		if ((this.long_0 & num) == num)
		{
			return;
		}
		this.long_0 |= num;
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
	public void method_13(long long_1)
	{
		this.long_0 |= long_1;
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x000F2518 File Offset: 0x000F0718
	public bool method_14(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_20(genum11_0, genum12_0);
		return (this.long_0 & num) == num;
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x000F253C File Offset: 0x000F073C
	public bool method_15(GStruct2.GEnum12 genum12_0)
	{
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)obj;
			if (this.method_36(genum11_, genum12_0))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x0000D90A File Offset: 0x0000BB0A
	public void method_16()
	{
		this.long_0 = 0L;
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
	public void method_17(long long_1)
	{
		this.long_0 |= long_1;
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x0000D92F File Offset: 0x0000BB2F
	private long method_18(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		return 0L << (int)(genum11_0 * GStruct2.GEnum11.Keys + (int)genum12_0 & (GStruct2.GEnum11)(-61));
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x000F24C4 File Offset: 0x000F06C4
	public bool method_19(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_24(genum11_0, genum12_0);
		return (this.long_0 & num) == num;
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x0000D943 File Offset: 0x0000BB43
	private long method_20(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		return 0L << (int)(genum11_0 * GStruct2.GEnum11.GHLGuitar + (int)genum12_0 & (GStruct2.GEnum11)19);
	}

	// Token: 0x06001DAD RID: 7597 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
	public void method_21(long long_1)
	{
		this.long_0 |= long_1;
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x0000D90A File Offset: 0x0000BB0A
	public void method_22()
	{
		this.long_0 = 0L;
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x0000D90A File Offset: 0x0000BB0A
	public void method_23()
	{
		this.long_0 = 0L;
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x0000D957 File Offset: 0x0000BB57
	private long method_24(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		return 0L << (int)(genum11_0 * GStruct2.GEnum11.Keys + (int)genum12_0 & (GStruct2.GEnum11)(-100));
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x000F25AC File Offset: 0x000F07AC
	public void method_25(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_18(genum11_0, genum12_0);
		if ((this.long_0 & num) == num)
		{
			return;
		}
		this.long_0 |= num;
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x0000D90A File Offset: 0x0000BB0A
	public void method_26()
	{
		this.long_0 = 0L;
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x0000D90A File Offset: 0x0000BB0A
	public void method_27()
	{
		this.long_0 = 0L;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x000F25DC File Offset: 0x000F07DC
	public void method_28(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_24(genum11_0, genum12_0);
		if ((this.long_0 & num) == num)
		{
			return;
		}
		this.long_0 |= num;
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x000F260C File Offset: 0x000F080C
	public bool method_29(GStruct2.GEnum12 genum12_0)
	{
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)obj;
			if (this.method_36(genum11_, genum12_0))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
	public void method_30(long long_1)
	{
		this.long_0 |= long_1;
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x0000D96B File Offset: 0x0000BB6B
	public void method_31()
	{
		this.long_0 = 1L;
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x000F2390 File Offset: 0x000F0590
	public void method_32(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_38(genum11_0, genum12_0);
		if ((this.long_0 & num) == num)
		{
			return;
		}
		this.long_0 |= num;
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x0000D902 File Offset: 0x0000BB02
	public long method_33()
	{
		return this.long_0;
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x000F24C4 File Offset: 0x000F06C4
	public bool method_34(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_24(genum11_0, genum12_0);
		return (this.long_0 & num) == num;
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x000F2390 File Offset: 0x000F0590
	public void method_35(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_38(genum11_0, genum12_0);
		if ((this.long_0 & num) == num)
		{
			return;
		}
		this.long_0 |= num;
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x000F267C File Offset: 0x000F087C
	public bool method_36(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_9(genum11_0, genum12_0);
		return (this.long_0 & num) == num;
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x000F2518 File Offset: 0x000F0718
	public bool method_37(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		long num = this.method_20(genum11_0, genum12_0);
		return (this.long_0 & num) == num;
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x0000D97C File Offset: 0x0000BB7C
	private long method_38(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		return 0L << (int)(genum11_0 * GStruct2.GEnum11.GuitarCoop + (int)genum12_0 & (GStruct2.GEnum11)(-117));
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x0000D902 File Offset: 0x0000BB02
	public long method_39()
	{
		return this.long_0;
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x000F26A0 File Offset: 0x000F08A0
	public bool method_40(GStruct2.GEnum11 genum11_0)
	{
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum12)))
		{
			GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj;
			if (this.method_36(genum11_0, genum12_))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x0000D990 File Offset: 0x0000BB90
	private long method_41(GStruct2.GEnum11 genum11_0, GStruct2.GEnum12 genum12_0)
	{
		return 0L << (int)(genum11_0 * GStruct2.GEnum11.Band + (int)genum12_0 & (GStruct2.GEnum11)(-107));
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x000F2710 File Offset: 0x000F0910
	public bool method_42(GStruct2.GEnum12 genum12_0)
	{
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)obj;
			if (this.method_37(genum11_, genum12_0))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040004A3 RID: 1187
	private long long_0;

	// Token: 0x040004A4 RID: 1188
	private const byte byte_0 = 4;

	// Token: 0x0200009B RID: 155
	public enum GEnum11
	{
		// Token: 0x040004A6 RID: 1190
		None = -1,
		// Token: 0x040004A7 RID: 1191
		Guitar,
		// Token: 0x040004A8 RID: 1192
		Bass,
		// Token: 0x040004A9 RID: 1193
		Rhythm,
		// Token: 0x040004AA RID: 1194
		GuitarCoop,
		// Token: 0x040004AB RID: 1195
		GHLGuitar,
		// Token: 0x040004AC RID: 1196
		GHLBass,
		// Token: 0x040004AD RID: 1197
		Drums,
		// Token: 0x040004AE RID: 1198
		Keys,
		// Token: 0x040004AF RID: 1199
		Band
	}

	// Token: 0x0200009C RID: 156
	public enum GEnum12
	{
		// Token: 0x040004B1 RID: 1201
		Easy,
		// Token: 0x040004B2 RID: 1202
		Medium,
		// Token: 0x040004B3 RID: 1203
		Hard,
		// Token: 0x040004B4 RID: 1204
		Expert
	}
}
