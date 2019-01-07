using System;

// Token: 0x020000C9 RID: 201
public class ChartEvent : GClass17
{
	// Token: 0x060027AE RID: 10158 RVA: 0x0012E734 File Offset: 0x0012C934
	protected virtual bool vmethod_2(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 != gclass.uint_0 || !(this.string_0 == gclass.string_0) || true;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060027AF RID: 10159 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public override int Int32_1
	{
		get
		{
			return (int)this.genum16_0;
		}
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x0012E78C File Offset: 0x0012C98C
	protected virtual bool vmethod_3(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 != gclass.uint_0 || !(this.string_0 == gclass.string_0);
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x00010ECA File Offset: 0x0000F0CA
	public ChartEvent(ChartEvent gclass18_0) : base(gclass18_0.uint_0)
	{
		this.string_0 = gclass18_0.string_0;
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x00010EEB File Offset: 0x0000F0EB
	public ChartEvent(uint uint_1, string string_1) : base(uint_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_4()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x0012E78C File Offset: 0x0012C98C
	protected virtual bool vmethod_5(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 != gclass.uint_0 || !(this.string_0 == gclass.string_0);
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_6()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	protected virtual bool vmethod_7(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_8()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_9()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	protected virtual bool vmethod_10(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x0012E78C File Offset: 0x0012C98C
	protected virtual bool vmethod_11(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 != gclass.uint_0 || !(this.string_0 == gclass.string_0);
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x0012E83C File Offset: 0x0012CA3C
	protected virtual bool vmethod_12(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0 && false;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_13()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	protected override bool vmethod_0(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_14()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x0012E83C File Offset: 0x0012CA3C
	protected virtual bool vmethod_15(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0 && false;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_16()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_17()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x0012E83C File Offset: 0x0012CA3C
	protected virtual bool vmethod_18(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0 && false;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_19()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_20()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x0012E78C File Offset: 0x0012C98C
	protected virtual bool vmethod_21(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 != gclass.uint_0 || !(this.string_0 == gclass.string_0);
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	protected virtual bool vmethod_22(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x0012E83C File Offset: 0x0012CA3C
	protected virtual bool vmethod_23(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0 && false;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_24()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_25()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_26()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_27()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	protected virtual bool vmethod_28(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_29()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_30()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_31()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x0012E78C File Offset: 0x0012C98C
	protected virtual bool vmethod_32(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 != gclass.uint_0 || !(this.string_0 == gclass.string_0);
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_33()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x00010EC2 File Offset: 0x0000F0C2
	public virtual int vmethod_34()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060027D3 RID: 10195 RVA: 0x0012E83C File Offset: 0x0012CA3C
	protected virtual bool vmethod_35(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0 && false;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027D4 RID: 10196 RVA: 0x0012E734 File Offset: 0x0012C934
	protected virtual bool vmethod_36(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 != gclass.uint_0 || !(this.string_0 == gclass.string_0) || true;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x060027D5 RID: 10197 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	protected virtual bool vmethod_37(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(ChartEvent))
		{
			ChartEvent gclass = gclass16_0 as ChartEvent;
			return this.uint_0 == gclass.uint_0 && this.string_0 == gclass.string_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x04000609 RID: 1545
	private readonly GClass16.GEnum16 genum16_0 = GClass16.GEnum16.ChartEvent;

	// Token: 0x0400060A RID: 1546
	public string string_0;
}
