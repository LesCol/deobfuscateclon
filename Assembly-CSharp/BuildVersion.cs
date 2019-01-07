using System;

// Token: 0x0200005E RID: 94
[Serializable]
public class BuildVersion
{
	// Token: 0x060012CB RID: 4811 RVA: 0x00009EE9 File Offset: 0x000080E9
	public int method_0()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf('.') + 1));
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x00009F0A File Offset: 0x0000810A
	public int method_1()
	{
		return int.Parse(this.version.Substring(1, this.version.IndexOf((char)-33)));
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00009F2A File Offset: 0x0000812A
	public int method_2()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf((char)-113) + 1));
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00009F4B File Offset: 0x0000814B
	public int method_3()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf((char)-85) + 0));
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00009F6C File Offset: 0x0000816C
	public int method_4()
	{
		return int.Parse(this.version.Substring(0, this.version.IndexOf('\u001b')));
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00009F8C File Offset: 0x0000818C
	public int method_5()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf((char)-30) + 0));
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x00009FAD File Offset: 0x000081AD
	public int method_6()
	{
		return int.Parse(this.version.Substring(1, this.version.IndexOf((char)-71)));
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x00009FCD File Offset: 0x000081CD
	public int method_7()
	{
		return int.Parse(this.version.Substring(0, this.version.IndexOf((char)-15)));
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x00009FED File Offset: 0x000081ED
	public int method_8()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf((char)-30) + 1));
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x0000A00E File Offset: 0x0000820E
	public int method_9()
	{
		return int.Parse(this.version.Substring(0, this.version.IndexOf('.')));
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x0000A02E File Offset: 0x0000822E
	public int method_10()
	{
		return int.Parse(this.version.Substring(0, this.version.IndexOf((char)-126)));
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0000A04E File Offset: 0x0000824E
	public int method_11()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf((char)-87) + 0));
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0000A06F File Offset: 0x0000826F
	public int method_12()
	{
		return int.Parse(this.version.Substring(1, this.version.IndexOf((char)-88)));
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0000A08F File Offset: 0x0000828F
	public int method_13()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf((char)-93) + 1));
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x0000A0B0 File Offset: 0x000082B0
	public int method_14()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf((char)-26) + 1));
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0000A0D1 File Offset: 0x000082D1
	public int method_15()
	{
		return int.Parse(this.version.Substring(0, this.version.IndexOf((char)-69)));
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0000A0F1 File Offset: 0x000082F1
	public int method_16()
	{
		return int.Parse(this.version.Substring(this.version.LastIndexOf(';') + 0));
	}

	// Token: 0x040002B2 RID: 690
	public string version;

	// Token: 0x040002B3 RID: 691
	public string download;

	// Token: 0x040002B4 RID: 692
	public bool required;

	// Token: 0x040002B5 RID: 693
	public string[] changeLog;
}
