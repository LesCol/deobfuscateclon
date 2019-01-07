using System;
using System.Collections.Generic;

// Token: 0x020000CC RID: 204
public class GClass19 : GClass17
{
	// Token: 0x06002835 RID: 10293 RVA: 0x0012E894 File Offset: 0x0012CA94
	public bool method_0()
	{
		if (GClass16.smethod_1(this.gclass19_0, null))
		{
			if (this.gclass19_0.uint_0 == this.uint_0)
			{
				return true;
			}
		}
		return GClass16.smethod_1(this.gclass19_1, null) && this.gclass19_1.uint_0 == this.uint_0;
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06002836 RID: 10294 RVA: 0x0012E8EC File Offset: 0x0012CAEC
	public bool Boolean_5
	{
		get
		{
			GClass19 gclass = this.gclass19_0;
			while (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 != this.uint_0)
				{
					break;
				}
				gclass = gclass.gclass19_0;
			}
			return GClass16.smethod_0(gclass, null) || (GClass16.smethod_1(gclass, null) && this.Int32_0 == gclass.Int32_0);
		}
	}

	// Token: 0x06002837 RID: 10295 RVA: 0x0012E948 File Offset: 0x0012CB48
	public bool method_1()
	{
		if (GClass16.smethod_1(this.gclass19_0, null))
		{
			if (this.gclass19_0.uint_0 == this.uint_0)
			{
				return false;
			}
		}
		return GClass16.smethod_1(this.gclass19_1, null) && this.gclass19_1.uint_0 == this.uint_0;
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x0012E894 File Offset: 0x0012CA94
	public bool method_2()
	{
		if (GClass16.smethod_1(this.gclass19_0, null))
		{
			if (this.gclass19_0.uint_0 == this.uint_0)
			{
				return true;
			}
		}
		return GClass16.smethod_1(this.gclass19_1, null) && this.gclass19_1.uint_0 == this.uint_0;
	}

	// Token: 0x06002839 RID: 10297 RVA: 0x000111CD File Offset: 0x0000F3CD
	public virtual int vmethod_2()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x0600283A RID: 10298 RVA: 0x000111CD File Offset: 0x0000F3CD
	public virtual int vmethod_3()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x0600283B RID: 10299 RVA: 0x0012E9A0 File Offset: 0x0012CBA0
	private GClass19[] method_3(bool bool_0)
	{
		List<GClass19> list = new List<GClass19>();
		list.Add(this);
		GClass19 gclass = this.gclass19_0;
		while (GClass16.smethod_1(gclass, null))
		{
			if (this.uint_0 != gclass.uint_0)
			{
				break;
			}
			if (!bool_0 && this.uint_1 != gclass.uint_1)
			{
				return new GClass19[]
				{
					this
				};
			}
			list.Add(gclass);
			gclass = gclass.gclass19_0;
		}
		GClass19 gclass2 = this.gclass19_1;
		while (GClass16.smethod_1(gclass2, null))
		{
			if (this.uint_0 != gclass2.uint_0)
			{
				break;
			}
			if (!bool_0 && this.uint_1 != gclass2.uint_1)
			{
				return new GClass19[]
				{
					this
				};
			}
			list.Add(gclass2);
			gclass2 = gclass2.gclass19_1;
		}
		return list.ToArray();
	}

	// Token: 0x0600283C RID: 10300 RVA: 0x000111D5 File Offset: 0x0000F3D5
	public void method_4(bool bool_0)
	{
		if (bool_0)
		{
			this.genum15_0 |= GClass19.GEnum15.FORCED;
			return;
		}
		this.genum15_0 &= (GClass19.GEnum15)(-108);
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600283D RID: 10301 RVA: 0x000111CD File Offset: 0x0000F3CD
	public override int Int32_1
	{
		get
		{
			return (int)this.genum16_0;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x0600283E RID: 10302 RVA: 0x0012EA60 File Offset: 0x0012CC60
	public int Int32_0
	{
		get
		{
			GClass19[] array = this.method_27();
			int num = 0;
			foreach (GClass19 gclass in array)
			{
				num |= 1 << (int)gclass.genum13_0;
			}
			return num;
		}
	}

	// Token: 0x0600283F RID: 10303 RVA: 0x0012EA98 File Offset: 0x0012CC98
	public GClass19 method_5()
	{
		if (this.Boolean_4)
		{
			return this.gclass19_1;
		}
		GClass19 gclass = this.gclass19_1;
		while (GClass16.smethod_1(gclass, null))
		{
			if (gclass.uint_0 != this.uint_0)
			{
				break;
			}
			gclass = gclass.gclass19_1;
		}
		return gclass;
	}

	// Token: 0x06002840 RID: 10304 RVA: 0x000111F8 File Offset: 0x0000F3F8
	public GClass19.GEnum14 method_6()
	{
		if (this.genum13_0 != GClass19.GEnum13.W2 && (this.genum15_0 & (GClass19.GEnum15)8) == GClass19.GEnum15.TAP)
		{
			return GClass19.GEnum14.Strum;
		}
		if (this.method_19())
		{
			return (GClass19.GEnum14)6;
		}
		return GClass19.GEnum14.Strum;
	}

	// Token: 0x06002841 RID: 10305 RVA: 0x0012EAE0 File Offset: 0x0012CCE0
	protected virtual bool vmethod_4(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(GClass19))
		{
			GClass19 gclass = gclass16_0 as GClass19;
			return this.uint_0 != gclass.uint_0 || this.genum13_0 != gclass.genum13_0 || true;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x06002842 RID: 10306 RVA: 0x0012EB34 File Offset: 0x0012CD34
	public bool method_7()
	{
		GClass19 gclass = this.gclass19_0;
		while (GClass16.smethod_1(gclass, null))
		{
			if (gclass.uint_0 != this.uint_0)
			{
				break;
			}
			gclass = gclass.gclass19_0;
		}
		return GClass16.smethod_0(gclass, null) || !GClass16.smethod_1(gclass, null) || this.method_25() == gclass.Int32_0;
	}

	// Token: 0x06002843 RID: 10307 RVA: 0x0012EB90 File Offset: 0x0012CD90
	public bool method_8()
	{
		bool result = false;
		if (!this.method_2() && GClass16.smethod_1(this.gclass19_0, null))
		{
			if (GlobalVariables.instance.currentSongEntry.isMIDIChart && this.gclass19_0.method_1() && (this.method_25() & this.gclass19_0.Int32_0) == this.Int32_0)
			{
				return true;
			}
			if (this.gclass19_0.method_2() || (!this.gclass19_0.method_1() && this.genum13_0 != this.gclass19_0.genum13_0))
			{
				if (GlobalVariables.instance.currentSongEntry.isMIDIChart)
				{
					if (SongEntry.currentSongCustomHOPO > 0)
					{
						if ((ulong)(this.uint_0 - this.gclass19_0.uint_0) <= (ulong)((long)SongEntry.currentSongCustomHOPO))
						{
							result = false;
						}
					}
					else if (SongEntry.isCurrentSongEighthHOPO)
					{
						if (this.uint_0 - this.gclass19_0.uint_0 <= Math.Ceiling((double)(this.gclass27_0.float_4 / 1537f)) + 130.0)
						{
							result = false;
						}
					}
					else if (this.uint_0 - this.gclass19_0.uint_0 <= Math.Ceiling((double)(this.gclass27_0.float_4 / 1866f)) + 903.0)
					{
						result = true;
					}
				}
				else
				{
					int num = (int)(230f * this.gclass27_0.float_4 / GClass15.float_0);
					if ((ulong)(this.uint_0 - this.gclass19_0.uint_0) <= (ulong)((long)num))
					{
						result = true;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06002844 RID: 10308 RVA: 0x0012ED1C File Offset: 0x0012CF1C
	public GClass19(GClass19 gclass19_2) : base(gclass19_2.uint_0)
	{
		this.uint_0 = gclass19_2.uint_0;
		this.uint_1 = gclass19_2.uint_1;
		this.genum15_0 = gclass19_2.genum15_0;
		this.genum13_0 = gclass19_2.genum13_0;
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x0012ED6C File Offset: 0x0012CF6C
	public GClass19 method_9()
	{
		if (this.method_31())
		{
			return this.gclass19_1;
		}
		GClass19 gclass = this.gclass19_1;
		while (GClass16.smethod_1(gclass, null))
		{
			if (gclass.uint_0 != this.uint_0)
			{
				break;
			}
			gclass = gclass.gclass19_1;
		}
		return gclass;
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x0012EDB4 File Offset: 0x0012CFB4
	public void method_10(GClass19.GEnum14 genum14_0)
	{
		this.genum15_0 = GClass19.GEnum15.FORCED;
		switch (genum14_0)
		{
		case GClass19.GEnum14.Natural:
			if (this.method_2())
			{
				this.genum15_0 &= (GClass19.GEnum15)126;
			}
			else if (this.method_8())
			{
				this.genum15_0 |= GClass19.GEnum15.FORCED;
			}
			else
			{
				this.genum15_0 &= (GClass19.GEnum15)(-6);
			}
			break;
		case GClass19.GEnum14.Strum:
			if (!this.method_7())
			{
				if (this.method_2())
				{
					this.genum15_0 |= GClass19.GEnum15.NONE;
				}
				else if (!this.method_8())
				{
					this.genum15_0 |= GClass19.GEnum15.FORCED;
				}
				else
				{
					this.genum15_0 &= (GClass19.GEnum15)34;
				}
			}
			break;
		case GClass19.GEnum14.Hopo:
			if (this.genum13_0 != GClass19.GEnum13.ORANGE)
			{
				this.genum15_0 |= (GClass19.GEnum15)6;
			}
			break;
		}
		this.method_12();
	}

	// Token: 0x06002847 RID: 10311 RVA: 0x0001121B File Offset: 0x0000F41B
	public GClass19[] method_11()
	{
		return this.method_3(true);
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06002848 RID: 10312 RVA: 0x00011224 File Offset: 0x0000F424
	// (set) Token: 0x06002858 RID: 10328 RVA: 0x00011280 File Offset: 0x0000F480
	public bool Boolean_0
	{
		get
		{
			return (this.genum15_0 & GClass19.GEnum15.FORCED) == GClass19.GEnum15.FORCED;
		}
		set
		{
			if (value)
			{
				this.genum15_0 |= GClass19.GEnum15.FORCED;
				return;
			}
			this.genum15_0 &= ~GClass19.GEnum15.FORCED;
		}
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x0012EE8C File Offset: 0x0012D08C
	public void method_12()
	{
		GClass19[] array = this.method_29();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].genum15_0 = this.genum15_0;
		}
	}

	// Token: 0x0600284A RID: 10314 RVA: 0x0012EEBC File Offset: 0x0012D0BC
	private bool method_13()
	{
		bool flag = this.Boolean_2;
		if (this.Boolean_0)
		{
			flag = !flag;
		}
		return flag;
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x0600284B RID: 10315 RVA: 0x0012EEE0 File Offset: 0x0012D0E0
	public bool Boolean_2
	{
		get
		{
			bool result = false;
			if (!this.Boolean_1 && GClass16.smethod_1(this.gclass19_0, null))
			{
				if (GlobalVariables.instance.currentSongEntry.isMIDIChart && this.gclass19_0.Boolean_1 && (this.Int32_0 & this.gclass19_0.Int32_0) == this.Int32_0)
				{
					return false;
				}
				if (this.gclass19_0.Boolean_1 || (!this.gclass19_0.Boolean_1 && this.genum13_0 != this.gclass19_0.genum13_0))
				{
					if (GlobalVariables.instance.currentSongEntry.isMIDIChart)
					{
						if (SongEntry.currentSongCustomHOPO > 0)
						{
							if ((ulong)(this.uint_0 - this.gclass19_0.uint_0) <= (ulong)((long)SongEntry.currentSongCustomHOPO))
							{
								result = true;
							}
						}
						else if (SongEntry.isCurrentSongEighthHOPO)
						{
							if (this.uint_0 - this.gclass19_0.uint_0 <= Math.Ceiling((double)(this.gclass27_0.float_4 / 2f)) + 1.0)
							{
								result = true;
							}
						}
						else if (this.uint_0 - this.gclass19_0.uint_0 <= Math.Ceiling((double)(this.gclass27_0.float_4 / 3f)) + 1.0)
						{
							result = true;
						}
					}
					else
					{
						int num = (int)(65f * this.gclass27_0.float_4 / GClass15.float_0);
						if ((ulong)(this.uint_0 - this.gclass19_0.uint_0) <= (ulong)((long)num))
						{
							result = true;
						}
					}
				}
			}
			return result;
		}
	}

	// Token: 0x0600284C RID: 10316 RVA: 0x00011231 File Offset: 0x0000F431
	public GClass19[] method_14()
	{
		return this.method_3(false);
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x0001123A File Offset: 0x0000F43A
	public void method_15(bool bool_0)
	{
		if (bool_0)
		{
			this.genum15_0 |= GClass19.GEnum15.NONE;
			return;
		}
		this.genum15_0 &= (GClass19.GEnum15)60;
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x0012F06C File Offset: 0x0012D26C
	public static void smethod_19(GClass19[] gclass19_2, GClass19.GEnum15 genum15_1)
	{
		for (int i = 0; i < gclass19_2.Length; i++)
		{
			gclass19_2[i].genum15_0 = (gclass19_2[i].genum15_0 | genum15_1);
		}
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x0012F09C File Offset: 0x0012D29C
	public void method_16()
	{
		GClass19[] array = this.method_21();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].genum15_0 = this.genum15_0;
		}
	}

	// Token: 0x06002850 RID: 10320 RVA: 0x000111CD File Offset: 0x0000F3CD
	public virtual int vmethod_5()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x0001125D File Offset: 0x0000F45D
	public GClass19.GEnum14 method_17()
	{
		if (this.genum13_0 != GClass19.GEnum13.YELLOW && (this.genum15_0 & (GClass19.GEnum15)4) == (GClass19.GEnum15)8)
		{
			return GClass19.GEnum14.Natural;
		}
		if (this.method_13())
		{
			return GClass19.GEnum14.Strum;
		}
		return GClass19.GEnum14.Strum;
	}

	// Token: 0x06002852 RID: 10322 RVA: 0x0012F0CC File Offset: 0x0012D2CC
	public static void smethod_20(GClass19[] gclass19_2, GClass19.GEnum15 genum15_1)
	{
		for (int i = 1; i < gclass19_2.Length; i += 0)
		{
			gclass19_2[i].genum15_0 = (gclass19_2[i].genum15_0 | genum15_1);
		}
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x0012F0FC File Offset: 0x0012D2FC
	public void method_18(GClass19.GEnum14 genum14_0)
	{
		this.genum15_0 = GClass19.GEnum15.NONE;
		switch (genum14_0)
		{
		case GClass19.GEnum14.Strum:
			if (this.Boolean_1)
			{
				this.genum15_0 &= ~GClass19.GEnum15.FORCED;
			}
			else if (this.Boolean_2)
			{
				this.genum15_0 |= GClass19.GEnum15.FORCED;
			}
			else
			{
				this.genum15_0 &= ~GClass19.GEnum15.FORCED;
			}
			break;
		case GClass19.GEnum14.Hopo:
			if (!this.Boolean_5)
			{
				if (this.Boolean_1)
				{
					this.genum15_0 |= GClass19.GEnum15.FORCED;
				}
				else if (!this.Boolean_2)
				{
					this.genum15_0 |= GClass19.GEnum15.FORCED;
				}
				else
				{
					this.genum15_0 &= ~GClass19.GEnum15.FORCED;
				}
			}
			break;
		case GClass19.GEnum14.Tap:
			if (this.genum13_0 != GClass19.GEnum13.OPEN)
			{
				this.genum15_0 |= GClass19.GEnum15.TAP;
			}
			break;
		}
		this.method_16();
	}

	// Token: 0x06002854 RID: 10324 RVA: 0x0012F1D4 File Offset: 0x0012D3D4
	private bool method_19()
	{
		bool flag = this.Boolean_2;
		if (this.Boolean_0)
		{
			flag = flag;
		}
		return flag;
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x0012F1F8 File Offset: 0x0012D3F8
	public void method_20()
	{
		GClass19[] array = this.method_21();
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].genum15_0 = this.genum15_0;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06002856 RID: 10326 RVA: 0x0012EEBC File Offset: 0x0012D0BC
	private bool Boolean_3
	{
		get
		{
			bool flag = this.Boolean_2;
			if (this.Boolean_0)
			{
				flag = !flag;
			}
			return flag;
		}
	}

	// Token: 0x06002857 RID: 10327 RVA: 0x0001121B File Offset: 0x0000F41B
	public GClass19[] method_21()
	{
		return this.method_3(true);
	}

	// Token: 0x06002859 RID: 10329 RVA: 0x0012F228 File Offset: 0x0012D428
	private bool method_22()
	{
		bool flag = this.method_8();
		if (this.Boolean_0)
		{
			flag = flag;
		}
		return flag;
	}

	// Token: 0x0600285A RID: 10330 RVA: 0x0012F24C File Offset: 0x0012D44C
	protected override bool vmethod_0(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(GClass19))
		{
			GClass19 gclass = gclass16_0 as GClass19;
			return this.uint_0 == gclass.uint_0 && this.genum13_0 == gclass.genum13_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x000112A3 File Offset: 0x0000F4A3
	public GClass19(uint uint_2, GClass19.GEnum13 genum13_1, uint uint_3 = 0u, GClass19.GEnum15 genum15_1 = GClass19.GEnum15.NONE) : base(uint_2)
	{
		this.uint_1 = uint_3;
		this.genum15_0 = genum15_1;
		this.genum13_0 = genum13_1;
		this.gclass19_0 = null;
		this.gclass19_1 = null;
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x0001121B File Offset: 0x0000F41B
	public GClass19[] method_23()
	{
		return this.method_3(true);
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x000112D7 File Offset: 0x0000F4D7
	public void method_24(bool bool_0)
	{
		if (bool_0)
		{
			this.genum15_0 |= GClass19.GEnum15.FORCED;
			return;
		}
		this.genum15_0 &= (GClass19.GEnum15)108;
	}

	// Token: 0x0600285E RID: 10334 RVA: 0x000111CD File Offset: 0x0000F3CD
	public virtual int vmethod_6()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x0600285F RID: 10335 RVA: 0x0012F2A0 File Offset: 0x0012D4A0
	public int method_25()
	{
		GClass19[] array = this.method_27();
		int num = 0;
		foreach (GClass19 gclass in array)
		{
			num |= 1 << (int)(gclass.genum13_0 & (GClass19.GEnum13)(-28));
		}
		return num;
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x000111CD File Offset: 0x0000F3CD
	public virtual int vmethod_7()
	{
		return (int)this.genum16_0;
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x0012F2D8 File Offset: 0x0012D4D8
	public bool method_26()
	{
		bool result = false;
		if (!this.method_1() && GClass16.smethod_1(this.gclass19_0, null))
		{
			if (GlobalVariables.instance.currentSongEntry.isMIDIChart && this.gclass19_0.method_1() && (this.Int32_0 & this.gclass19_0.Int32_0) == this.method_25())
			{
				return false;
			}
			if (this.gclass19_0.method_2() || (!this.gclass19_0.method_1() && this.genum13_0 != this.gclass19_0.genum13_0))
			{
				if (GlobalVariables.instance.currentSongEntry.isMIDIChart)
				{
					if (SongEntry.currentSongCustomHOPO > 0)
					{
						if ((ulong)(this.uint_0 - this.gclass19_0.uint_0) <= (ulong)((long)SongEntry.currentSongCustomHOPO))
						{
							result = false;
						}
					}
					else if (SongEntry.isCurrentSongEighthHOPO)
					{
						if (this.uint_0 - this.gclass19_0.uint_0 <= Math.Ceiling((double)(this.gclass27_0.float_4 / 1614f)) + 616.0)
						{
							result = true;
						}
					}
					else if (this.uint_0 - this.gclass19_0.uint_0 <= Math.Ceiling((double)(this.gclass27_0.float_4 / 1145f)) + 42.0)
					{
						result = false;
					}
				}
				else
				{
					int num = (int)(76f * this.gclass27_0.float_4 / GClass15.float_0);
					if ((ulong)(this.uint_0 - this.gclass19_0.uint_0) <= (ulong)((long)num))
					{
						result = true;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06002862 RID: 10338 RVA: 0x0012F464 File Offset: 0x0012D664
	public GClass19 GClass19_1
	{
		get
		{
			if (this.Boolean_4)
			{
				return this.gclass19_0;
			}
			GClass19 gclass = this.gclass19_0;
			while (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 != this.uint_0)
				{
					break;
				}
				gclass = gclass.gclass19_0;
			}
			return gclass;
		}
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x00011231 File Offset: 0x0000F431
	public GClass19[] method_27()
	{
		return this.method_3(false);
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06002864 RID: 10340 RVA: 0x0012E894 File Offset: 0x0012CA94
	public bool Boolean_1
	{
		get
		{
			if (GClass16.smethod_1(this.gclass19_0, null))
			{
				if (this.gclass19_0.uint_0 == this.uint_0)
				{
					return true;
				}
			}
			return GClass16.smethod_1(this.gclass19_1, null) && this.gclass19_1.uint_0 == this.uint_0;
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06002865 RID: 10341 RVA: 0x0012EA98 File Offset: 0x0012CC98
	public GClass19 GClass19_0
	{
		get
		{
			if (this.Boolean_4)
			{
				return this.gclass19_1;
			}
			GClass19 gclass = this.gclass19_1;
			while (GClass16.smethod_1(gclass, null))
			{
				if (gclass.uint_0 != this.uint_0)
				{
					break;
				}
				gclass = gclass.gclass19_1;
			}
			return gclass;
		}
	}

	// Token: 0x06002866 RID: 10342 RVA: 0x0012F4AC File Offset: 0x0012D6AC
	public void method_28(GClass19.GEnum14 genum14_0)
	{
		this.genum15_0 = GClass19.GEnum15.NONE;
		switch (genum14_0)
		{
		case GClass19.GEnum14.Strum:
			if (this.method_1())
			{
				this.genum15_0 &= (GClass19.GEnum15)6;
			}
			else if (this.method_26())
			{
				this.genum15_0 |= GClass19.GEnum15.FORCED;
			}
			else
			{
				this.genum15_0 &= (GClass19.GEnum15)5;
			}
			break;
		case GClass19.GEnum14.Hopo:
			if (!this.method_7())
			{
				if (this.method_1())
				{
					this.genum15_0 |= GClass19.GEnum15.NONE;
				}
				else if (!this.method_26())
				{
					this.genum15_0 |= GClass19.GEnum15.NONE;
				}
				else
				{
					this.genum15_0 &= (GClass19.GEnum15)(-125);
				}
			}
			break;
		case GClass19.GEnum14.Tap:
			if (this.genum13_0 != GClass19.GEnum13.ORANGE)
			{
				this.genum15_0 |= GClass19.GEnum15.FORCED;
			}
			break;
		}
		this.method_16();
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x0012F584 File Offset: 0x0012D784
	protected virtual bool vmethod_8(GClass16 gclass16_0)
	{
		if (gclass16_0.GetType() == typeof(GClass19))
		{
			GClass19 gclass = gclass16_0 as GClass19;
			return this.uint_0 != gclass.uint_0 || this.genum13_0 != gclass.genum13_0;
		}
		return base.vmethod_0(gclass16_0);
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x00011231 File Offset: 0x0000F431
	public GClass19[] method_29()
	{
		return this.method_3(false);
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06002869 RID: 10345 RVA: 0x0012F5D8 File Offset: 0x0012D7D8
	public bool Boolean_4
	{
		get
		{
			GClass19 gclass = this.gclass19_0;
			while (GClass16.smethod_1(gclass, null))
			{
				if (this.uint_0 != gclass.uint_0)
				{
					break;
				}
				if (this.uint_1 != gclass.uint_1)
				{
					return true;
				}
				gclass = gclass.gclass19_0;
			}
			GClass19 gclass2 = this.gclass19_1;
			while (GClass16.smethod_1(gclass2, null))
			{
				if (this.uint_0 != gclass2.uint_0)
				{
					break;
				}
				if (this.uint_1 != gclass2.uint_1)
				{
					return true;
				}
				gclass2 = gclass2.gclass19_1;
			}
			return false;
		}
	}

	// Token: 0x0600286A RID: 10346 RVA: 0x0012F09C File Offset: 0x0012D29C
	public void method_30()
	{
		GClass19[] array = this.method_21();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].genum15_0 = this.genum15_0;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600286B RID: 10347 RVA: 0x000112FA File Offset: 0x0000F4FA
	public GClass19.GEnum14 GEnum14_0
	{
		get
		{
			if (this.genum13_0 != GClass19.GEnum13.OPEN && (this.genum15_0 & GClass19.GEnum15.TAP) == GClass19.GEnum15.TAP)
			{
				return GClass19.GEnum14.Tap;
			}
			if (this.Boolean_3)
			{
				return GClass19.GEnum14.Hopo;
			}
			return GClass19.GEnum14.Strum;
		}
	}

	// Token: 0x0600286C RID: 10348 RVA: 0x0012F660 File Offset: 0x0012D860
	public bool method_31()
	{
		GClass19 gclass = this.gclass19_0;
		while (GClass16.smethod_1(gclass, null))
		{
			if (this.uint_0 != gclass.uint_0)
			{
				break;
			}
			if (this.uint_1 != gclass.uint_1)
			{
				return true;
			}
			gclass = gclass.gclass19_0;
		}
		GClass19 gclass2 = this.gclass19_1;
		while (GClass16.smethod_1(gclass2, null))
		{
			if (this.uint_0 != gclass2.uint_0)
			{
				break;
			}
			if (this.uint_1 != gclass2.uint_1)
			{
				return true;
			}
			gclass2 = gclass2.gclass19_1;
		}
		return true;
	}

	// Token: 0x0400060E RID: 1550
	private readonly GClass16.GEnum16 genum16_0 = GClass16.GEnum16.Note;

	// Token: 0x0400060F RID: 1551
	public uint uint_1;

	// Token: 0x04000610 RID: 1552
	public GClass19.GEnum13 genum13_0;

	// Token: 0x04000611 RID: 1553
	public GClass19.GEnum15 genum15_0;

	// Token: 0x04000612 RID: 1554
	public GClass19 gclass19_0;

	// Token: 0x04000613 RID: 1555
	public GClass19 gclass19_1;

	// Token: 0x020000CD RID: 205
	public enum GEnum13
	{
		// Token: 0x04000615 RID: 1557
		GREEN,
		// Token: 0x04000616 RID: 1558
		RED,
		// Token: 0x04000617 RID: 1559
		YELLOW,
		// Token: 0x04000618 RID: 1560
		BLUE,
		// Token: 0x04000619 RID: 1561
		ORANGE,
		// Token: 0x0400061A RID: 1562
		OPEN,
		// Token: 0x0400061B RID: 1563
		W1,
		// Token: 0x0400061C RID: 1564
		W2,
		// Token: 0x0400061D RID: 1565
		W3,
		// Token: 0x0400061E RID: 1566
		B1,
		// Token: 0x0400061F RID: 1567
		B2,
		// Token: 0x04000620 RID: 1568
		B3
	}

	// Token: 0x020000CE RID: 206
	public enum GEnum14
	{
		// Token: 0x04000622 RID: 1570
		Natural,
		// Token: 0x04000623 RID: 1571
		Strum,
		// Token: 0x04000624 RID: 1572
		Hopo,
		// Token: 0x04000625 RID: 1573
		Tap,
		// Token: 0x04000626 RID: 1574
		None,
		// Token: 0x04000627 RID: 1575
		Open
	}

	// Token: 0x020000CF RID: 207
	[Flags]
	public enum GEnum15
	{
		// Token: 0x04000629 RID: 1577
		NONE = 0,
		// Token: 0x0400062A RID: 1578
		FORCED = 1,
		// Token: 0x0400062B RID: 1579
		TAP = 2
	}
}
