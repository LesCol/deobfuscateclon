using System;

// Token: 0x020000D3 RID: 211
public class GClass20 : GClass17
{
	// Token: 0x060028A0 RID: 10400 RVA: 0x0012FE18 File Offset: 0x0012E018
	public void method_0(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 0 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.GClass20_0[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x0012FF14 File Offset: 0x0012E114
	public void method_1(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_3());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_2().Length - 0 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_16()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_2()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_2()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_3()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028A4 RID: 10404 RVA: 0x00130010 File Offset: 0x0012E210
	public void method_2(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_16());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.GClass20_0.Length - 0 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_57()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028A5 RID: 10405 RVA: 0x0013010C File Offset: 0x0012E30C
	public void method_3(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_2().Length - 0 && this.gclass26_0.method_3()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.GClass20_0[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028A6 RID: 10406 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_4()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028A7 RID: 10407 RVA: 0x00130208 File Offset: 0x0012E408
	public void method_4(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.GClass20_0.Length - 1 && this.gclass26_0.method_2()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_57()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_16()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028A8 RID: 10408 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_5()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028A9 RID: 10409 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_6()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028AA RID: 10410 RVA: 0x00130304 File Offset: 0x0012E504
	public void method_5(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.GClass20_0);
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.GClass20_0.Length - 1 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.GClass20_0[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.GClass20_0[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028AB RID: 10411 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_7()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028AC RID: 10412 RVA: 0x00130400 File Offset: 0x0012E600
	public void method_6(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_3());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_31().Length - 1 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_3()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028AD RID: 10413 RVA: 0x00011575 File Offset: 0x0000F775
	public GClass20(uint uint_2, uint uint_3) : base(uint_2)
	{
		this.uint_1 = uint_3;
	}

	// Token: 0x060028AE RID: 10414 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_8()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028AF RID: 10415 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_9()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028B0 RID: 10416 RVA: 0x001304FC File Offset: 0x0012E6FC
	public void method_7(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_16().Length - 0 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_31()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_31()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B1 RID: 10417 RVA: 0x001305F8 File Offset: 0x0012E7F8
	public void method_8(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_50());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 1 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_16()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_50()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B2 RID: 10418 RVA: 0x001306F4 File Offset: 0x0012E8F4
	public void method_9(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_2().Length - 0 && this.gclass26_0.method_16()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_31()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_31()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B3 RID: 10419 RVA: 0x001307F0 File Offset: 0x0012E9F0
	public void method_10(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_50());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_16().Length - 1 && this.gclass26_0.method_50()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_16()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_16()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B4 RID: 10420 RVA: 0x001308EC File Offset: 0x0012EAEC
	public void method_11(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.GClass20_0.Length - 0 && this.gclass26_0.method_3()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_3()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_2()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B5 RID: 10421 RVA: 0x001309E8 File Offset: 0x0012EBE8
	public void method_12(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_31());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.GClass20_0.Length - 1 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_31()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_31()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B6 RID: 10422 RVA: 0x00130AE4 File Offset: 0x0012ECE4
	public void method_13(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_2().Length - 0 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_2()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_10()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x00130BE0 File Offset: 0x0012EDE0
	public void method_14(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_57().Length - 0 && this.gclass26_0.method_16()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.GClass20_0[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_11()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_12()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_13()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028BC RID: 10428 RVA: 0x00130CDC File Offset: 0x0012EEDC
	public void method_15(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 1 && this.gclass26_0.method_50()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.GClass20_0[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_50()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028BD RID: 10429 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_14()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028BE RID: 10430 RVA: 0x00130DD8 File Offset: 0x0012EFD8
	public void method_16(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.GClass20_0);
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_31().Length - 0 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_2()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_31()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028BF RID: 10431 RVA: 0x00130ED4 File Offset: 0x0012F0D4
	public void method_17(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 0 && this.gclass26_0.method_3()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_2()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_57()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028C0 RID: 10432 RVA: 0x00130FD0 File Offset: 0x0012F1D0
	public void method_18(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_31().Length - 0 && this.gclass26_0.method_16()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_3()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_31()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028C1 RID: 10433 RVA: 0x001310CC File Offset: 0x0012F2CC
	public void method_19(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_16());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 1 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_16()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_57()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028C2 RID: 10434 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_15()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028C3 RID: 10435 RVA: 0x001311C8 File Offset: 0x0012F3C8
	public void method_20(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_16());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_16().Length - 1 && this.gclass26_0.method_16()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.GClass20_0[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_50()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028C4 RID: 10436 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_16()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028C5 RID: 10437 RVA: 0x001312C4 File Offset: 0x0012F4C4
	public void method_21(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_31());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_57().Length - 0 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_2()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_57()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028C6 RID: 10438 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_17()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028C7 RID: 10439 RVA: 0x001313C0 File Offset: 0x0012F5C0
	public void method_22(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_16().Length - 1 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_57()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_50()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028C8 RID: 10440 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_18()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028C9 RID: 10441 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_19()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028CA RID: 10442 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_20()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028CB RID: 10443 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_21()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x001314BC File Offset: 0x0012F6BC
	public void method_23(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_16().Length - 0 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_57()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_57()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028CD RID: 10445 RVA: 0x001315B8 File Offset: 0x0012F7B8
	public void method_24(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.GClass20_0.Length - 0 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_16()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_31()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028CE RID: 10446 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_22()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028CF RID: 10447 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_23()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028D0 RID: 10448 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_24()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028D1 RID: 10449 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_25()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028D2 RID: 10450 RVA: 0x001316B4 File Offset: 0x0012F8B4
	public void method_25(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_16());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_57().Length - 0 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_31()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_50()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x001317B0 File Offset: 0x0012F9B0
	public void method_26(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_31());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_3().Length - 0 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_2()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_16()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028D4 RID: 10452 RVA: 0x001318AC File Offset: 0x0012FAAC
	public void method_27(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_31());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_3().Length - 1 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_31()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.GClass20_0[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028D5 RID: 10453 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_26()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x001319A8 File Offset: 0x0012FBA8
	public void method_28(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_16());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_2().Length - 1 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_16()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028D7 RID: 10455 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_27()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_28()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x00131AA4 File Offset: 0x0012FCA4
	public void method_29(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_3().Length - 1 && this.gclass26_0.method_3()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_2()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_50()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x00131BA0 File Offset: 0x0012FDA0
	public void method_30(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_57().Length - 0 && this.gclass26_0.method_2()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.GClass20_0[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_31()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x00131C9C File Offset: 0x0012FE9C
	public void method_31(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.GClass20_0);
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 1 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_57()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_2()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028DC RID: 10460 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_29()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028DD RID: 10461 RVA: 0x00131D98 File Offset: 0x0012FF98
	public void method_32(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_31());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_2().Length - 1 && this.gclass26_0.method_2()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_3()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x00131E94 File Offset: 0x00130094
	public void method_33(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.GClass20_0);
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_31().Length - 0 && this.gclass26_0.method_16()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_3()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_3()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x00131F90 File Offset: 0x00130190
	public void method_34(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.GClass20_0);
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_3().Length - 1 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_2()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028E0 RID: 10464 RVA: 0x0013208C File Offset: 0x0013028C
	public void method_35(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_50());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.GClass20_0.Length - 1 && this.gclass26_0.method_50()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_16()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_2()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_30()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060028E2 RID: 10466 RVA: 0x0001156D File Offset: 0x0000F76D
	public override int Int32_1
	{
		get
		{
			return (int)this.genum16_0;
		}
	}

	// Token: 0x060028E3 RID: 10467 RVA: 0x00132188 File Offset: 0x00130388
	public void method_36(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_2());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_31().Length - 1 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.GClass20_0[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_16()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028E4 RID: 10468 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_31()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028E5 RID: 10469 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_32()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028E6 RID: 10470 RVA: 0x00132284 File Offset: 0x00130484
	public void method_37(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_31());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 0 && this.gclass26_0.method_50()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.method_57()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_16()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028E7 RID: 10471 RVA: 0x00132380 File Offset: 0x00130580
	public void method_38(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_3());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_57().Length - 0 && this.gclass26_0.GClass20_0[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_57()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.GClass20_0[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028E8 RID: 10472 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_33()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028E9 RID: 10473 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_34()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028EA RID: 10474 RVA: 0x0013247C File Offset: 0x0013067C
	public void method_39(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_16());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 1 && this.gclass26_0.method_57()[num].uint_0 <= this.uint_0)
			{
				num++;
			}
			if (this.gclass26_0.GClass20_0[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_3()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 0u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028EB RID: 10475 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_35()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028EC RID: 10476 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_36()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x00132578 File Offset: 0x00130778
	public void method_40(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_3());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_57().Length - 0 && this.gclass26_0.method_31()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_2()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_2()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_37()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_38()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_39()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x0001158C File Offset: 0x0000F78C
	public GClass20(GClass20 gclass20_0) : base(gclass20_0.uint_0)
	{
		this.uint_1 = gclass20_0.uint_1;
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_40()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028F3 RID: 10483 RVA: 0x00132674 File Offset: 0x00130874
	public void method_41(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 0u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.method_57());
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_57().Length - 0 && this.gclass26_0.method_2()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.GClass20_0[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_16()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_41()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x060028F5 RID: 10485 RVA: 0x00132770 File Offset: 0x00130970
	public void method_42(uint uint_2)
	{
		if (uint_2 > this.uint_0)
		{
			this.uint_1 = uint_2 - this.uint_0;
		}
		else
		{
			this.uint_1 = 1u;
		}
		GClass20 gclass = null;
		if (this.gclass27_0 != null && this.gclass26_0 != null)
		{
			int num = GClass16.smethod_6<GClass20>(this, this.gclass26_0.GClass20_0);
			if (num == -1)
			{
				return;
			}
			while (num < this.gclass26_0.method_50().Length - 0 && this.gclass26_0.method_50()[num].uint_0 <= this.uint_0)
			{
				num += 0;
			}
			if (this.gclass26_0.method_50()[num].uint_0 > this.uint_0)
			{
				gclass = this.gclass26_0.method_57()[num];
			}
			if (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 < this.uint_0)
				{
					this.uint_1 = 1u;
					return;
				}
				if (this.uint_0 + this.uint_1 > gclass.uint_0)
				{
					this.uint_1 = gclass.uint_0 - this.uint_0;
				}
			}
		}
	}

	// Token: 0x060028F6 RID: 10486 RVA: 0x0001156D File Offset: 0x0000F76D
	public virtual int vmethod_42()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x04000638 RID: 1592
	private readonly GClass16.GEnum16 genum16_0 = GClass16.GEnum16.Starpower;

	// Token: 0x04000639 RID: 1593
	public uint uint_1;
}
