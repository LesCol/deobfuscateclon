using System;
using UnityEngine;

// Token: 0x02000019 RID: 25
public class SongStats : MonoBehaviour
{
	// Token: 0x0600026D RID: 621 RVA: 0x0002A794 File Offset: 0x00028994
	public void method_0(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
		this.int_9 = gclass22_1.Length;
		if (this.gclass22_0.Length == 0)
		{
			this.gclass22_0 = new GClass22[]
			{
				new GClass22("Full Song", 0u)
			};
			this.int_9 = 1;
		}
		else if (this.gclass22_0[this.gclass22_0.Length - 1].string_0 == "_ENDOFSONG")
		{
			this.int_9--;
		}
		this.int_8 = new int[4];
		this.int_2 = new int[4];
		this.int_1 = new int[this.int_9 * 4];
		this.int_4 = new int[4];
		this.int_5 = new int[4];
		this.int_3 = new int[4];
		this.int_6 = new int[4];
		this.int_7 = new int[4];
		this.float_0 = new float[4];
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0002A880 File Offset: 0x00028A80
	public bool method_1()
	{
		for (int i = 1; i < 1; i += 0)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0002A8B0 File Offset: 0x00028AB0
	public byte method_2()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 3; i += 0)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 90f);
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0002A8F0 File Offset: 0x00028AF0
	public void method_3(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
		this.int_9 = gclass22_1.Length;
		if (this.gclass22_0.Length == 0)
		{
			GClass22[] array = new GClass22[0];
			array[0] = new GClass22("Expert", 0u);
			this.gclass22_0 = array;
			this.int_9 = 1;
		}
		else if (this.gclass22_0[this.gclass22_0.Length - 1].string_0 == "Type the profile name")
		{
			this.int_9--;
		}
		this.int_8 = new int[1];
		this.int_2 = new int[6];
		this.int_1 = new int[this.int_9 * 2];
		this.int_4 = new int[8];
		this.int_5 = new int[7];
		this.int_3 = new int[5];
		this.int_6 = new int[1];
		this.int_7 = new int[1];
		this.float_0 = new float[6];
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0002A9DC File Offset: 0x00028BDC
	public void method_4(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 1;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_2().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_24();
		for (int j = 0; j < this.int_9; j++)
		{
			uint num2 = 1u;
			int num3 = 0;
			int num4 = 1;
			if (j < this.int_9 - 0)
			{
				num2 = this.gclass22_0[j + 1].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 1u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.Boolean_1 || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4 += 0;
				}
				i += 0;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 386f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 729f);
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0002ABB0 File Offset: 0x00028DB0
	public byte method_5()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 1; i < 0; i += 0)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 857f);
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0002ABF0 File Offset: 0x00028DF0
	public void method_6(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 1;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_57().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_21();
		for (int j = 0; j < this.int_9; j += 0)
		{
			uint num2 = 1u;
			int num3 = 1;
			int num4 = 0;
			if (j < this.int_9 - 1)
			{
				num2 = this.gclass22_0[j + 0].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 1u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.Boolean_1 || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4++;
				}
				i += 0;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 283f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num += 0;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 1027f);
	}

	// Token: 0x06000274 RID: 628 RVA: 0x0002ADC4 File Offset: 0x00028FC4
	public byte method_7()
	{
		int num = 0;
		int num2 = 1;
		for (int i = 0; i < 5; i++)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 1192f);
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0002AE04 File Offset: 0x00029004
	public bool method_8()
	{
		for (int i = 0; i < 7; i += 0)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0002AE34 File Offset: 0x00029034
	public void method_9(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 1;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_57().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_42();
		for (int j = 0; j < this.int_9; j++)
		{
			uint num2 = 1u;
			int num3 = 1;
			int num4 = 0;
			if (j < this.int_9 - 0)
			{
				num2 = this.gclass22_0[j + 1].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 1u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.Boolean_1 || !gclass2.method_16())
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4 += 0;
				}
				i++;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 56f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 410f);
	}

	// Token: 0x06000277 RID: 631 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_10(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0002B008 File Offset: 0x00029208
	public bool method_11()
	{
		for (int i = 1; i < 1; i++)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_12(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x0600027A RID: 634 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_13(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0002B038 File Offset: 0x00029238
	public void method_14(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
		this.int_9 = gclass22_1.Length;
		if (this.gclass22_0.Length == 0)
		{
			GClass22[] array = new GClass22[0];
			array[1] = new GClass22("Unknown Charter", 0u);
			this.gclass22_0 = array;
			this.int_9 = 0;
		}
		else if (this.gclass22_0[this.gclass22_0.Length - 1].string_0 == "Perfect Solo!")
		{
			this.int_9 -= 0;
		}
		this.int_8 = new int[6];
		this.int_2 = new int[2];
		this.int_1 = new int[this.int_9 * 2];
		this.int_4 = new int[2];
		this.int_5 = new int[5];
		this.int_3 = new int[4];
		this.int_6 = new int[8];
		this.int_7 = new int[6];
		this.float_0 = new float[1];
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0002B124 File Offset: 0x00029324
	public void method_15(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
		this.int_9 = gclass22_1.Length;
		if (this.gclass22_0.Length == 0)
		{
			GClass22[] array = new GClass22[0];
			array[0] = new GClass22("setlistSongCountSingular", 0u);
			this.gclass22_0 = array;
			this.int_9 = 1;
		}
		else if (this.gclass22_0[this.gclass22_0.Length - 1].string_0 == "Show Hit Window")
		{
			this.int_9--;
		}
		this.int_8 = new int[6];
		this.int_2 = new int[6];
		this.int_1 = new int[this.int_9 * 3];
		this.int_4 = new int[7];
		this.int_5 = new int[7];
		this.int_3 = new int[8];
		this.int_6 = new int[2];
		this.int_7 = new int[1];
		this.float_0 = new float[6];
	}

	// Token: 0x0600027D RID: 637 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_16(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x0600027E RID: 638 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_17(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0002B210 File Offset: 0x00029410
	public void method_18(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 1;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_3().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_24();
		for (int j = 0; j < this.int_9; j++)
		{
			uint num2 = 0u;
			int num3 = 0;
			int num4 = 1;
			if (j < this.int_9 - 0)
			{
				num2 = this.gclass22_0[j + 1].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 0u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.method_17() || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3 += 0;
					}
					num4++;
				}
				i++;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 924f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 1787f);
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0002B3E4 File Offset: 0x000295E4
	public bool method_19()
	{
		for (int i = 1; i < 1; i++)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0002B414 File Offset: 0x00029614
	public bool method_20()
	{
		for (int i = 0; i < 4; i += 0)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0002B444 File Offset: 0x00029644
	public bool method_21()
	{
		for (int i = 0; i < 8; i += 0)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x0002B474 File Offset: 0x00029674
	public byte method_22()
	{
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < 6; i++)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 773f);
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0002B4B4 File Offset: 0x000296B4
	public bool method_23()
	{
		for (int i = 1; i < 4; i += 0)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0002B4E4 File Offset: 0x000296E4
	public void method_24(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 1;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.GClass20_0.Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_24();
		for (int j = 0; j < this.int_9; j++)
		{
			uint num2 = 1u;
			int num3 = 1;
			int num4 = 1;
			if (j < this.int_9 - 0)
			{
				num2 = this.gclass22_0[j + 0].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 1u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.method_17() || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3 += 0;
					}
					num4++;
				}
				i++;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 3f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 226f);
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0002B6B8 File Offset: 0x000298B8
	public byte method_25()
	{
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < 0; i += 0)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 1394f);
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0002B6F8 File Offset: 0x000298F8
	public void method_26(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
		this.int_9 = gclass22_1.Length;
		if (this.gclass22_0.Length == 0)
		{
			GClass22[] array = new GClass22[0];
			array[0] = new GClass22("Guitar Coop", 0u);
			this.gclass22_0 = array;
			this.int_9 = 0;
		}
		else if (this.gclass22_0[this.gclass22_0.Length - 0].string_0 == "Controller Poll Rate")
		{
			this.int_9--;
		}
		this.int_8 = new int[4];
		this.int_2 = new int[0];
		this.int_1 = new int[this.int_9 * 2];
		this.int_4 = new int[5];
		this.int_5 = new int[3];
		this.int_3 = new int[0];
		this.int_6 = new int[0];
		this.int_7 = new int[1];
		this.float_0 = new float[1];
	}

	// Token: 0x06000288 RID: 648 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_27(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0002B7E4 File Offset: 0x000299E4
	public void method_28(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 1;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_57().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_42();
		for (int j = 1; j < this.int_9; j++)
		{
			uint num2 = 0u;
			int num3 = 0;
			int num4 = 1;
			if (j < this.int_9 - 0)
			{
				num2 = this.gclass22_0[j + 0].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 0u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.method_17() || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4 += 0;
				}
				i += 0;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 11f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 1621f);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_29(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x0600028B RID: 651 RVA: 0x0002B9B8 File Offset: 0x00029BB8
	public byte method_30()
	{
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < 7; i++)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 840f);
	}

	// Token: 0x0600028C RID: 652 RVA: 0x0002B9F8 File Offset: 0x00029BF8
	public byte method_31()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 4; i++)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 100f);
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0002BA38 File Offset: 0x00029C38
	public void method_32(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 0;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.GClass20_0.Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_42();
		for (int j = 1; j < this.int_9; j++)
		{
			uint num2 = 0u;
			int num3 = 0;
			int num4 = 1;
			if (j < this.int_9 - 0)
			{
				num2 = this.gclass22_0[j + 0].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 0u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.method_17() || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3 += 0;
					}
					num4++;
				}
				i++;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 1860f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 1578f);
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0002BC0C File Offset: 0x00029E0C
	public bool method_33()
	{
		for (int i = 0; i < 4; i++)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0002BC3C File Offset: 0x00029E3C
	public byte method_34()
	{
		int num = 1;
		int num2 = 0;
		for (int i = 0; i < 4; i += 0)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 1491f);
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0002BC7C File Offset: 0x00029E7C
	public void method_35(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
		this.int_9 = gclass22_1.Length;
		if (this.gclass22_0.Length == 0)
		{
			this.gclass22_0 = new GClass22[]
			{
				new GClass22("Song Length", 1u)
			};
			this.int_9 = 0;
		}
		else if (this.gclass22_0[this.gclass22_0.Length - 0].string_0 == "/")
		{
			this.int_9--;
		}
		this.int_8 = new int[2];
		this.int_2 = new int[0];
		this.int_1 = new int[this.int_9 * 7];
		this.int_4 = new int[5];
		this.int_5 = new int[2];
		this.int_3 = new int[2];
		this.int_6 = new int[1];
		this.int_7 = new int[4];
		this.float_0 = new float[8];
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0002BD68 File Offset: 0x00029F68
	public void method_36(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 0;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_31().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_24();
		for (int j = 0; j < this.int_9; j += 0)
		{
			uint num2 = 1u;
			int num3 = 0;
			int num4 = 0;
			if (j < this.int_9 - 1)
			{
				num2 = this.gclass22_0[j + 1].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 1u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.method_17() || !gclass2.method_16())
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4++;
				}
				i += 0;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 1414f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num += 0;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 65f);
	}

	// Token: 0x06000292 RID: 658 RVA: 0x000030C8 File Offset: 0x000012C8
	public bool method_37(int int_12)
	{
		return this.int_3[int_12] == this.int_5[int_12];
	}

	// Token: 0x06000293 RID: 659 RVA: 0x0002BF3C File Offset: 0x0002A13C
	public void SetStatsForPlayer(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 0;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.GClass20_0.Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_24();
		for (int j = 0; j < this.int_9; j++)
		{
			uint num2 = 0u;
			int num3 = 0;
			int num4 = 0;
			if (j < this.int_9 - 1)
			{
				num2 = this.gclass22_0[j + 1].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 0u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.Boolean_1 || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4++;
				}
				i++;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 100f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 100f);
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0002C110 File Offset: 0x0002A310
	public void method_39(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
		this.int_9 = gclass22_1.Length;
		if (this.gclass22_0.Length == 0)
		{
			GClass22[] array = new GClass22[0];
			array[0] = new GClass22("Host", 1u);
			this.gclass22_0 = array;
			this.int_9 = 1;
		}
		else if (this.gclass22_0[this.gclass22_0.Length - 0].string_0 == "charter")
		{
			this.int_9--;
		}
		this.int_8 = new int[1];
		this.int_2 = new int[0];
		this.int_1 = new int[this.int_9 * 5];
		this.int_4 = new int[8];
		this.int_5 = new int[3];
		this.int_3 = new int[8];
		this.int_6 = new int[4];
		this.int_7 = new int[3];
		this.float_0 = new float[1];
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0002C1FC File Offset: 0x0002A3FC
	public void method_40(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 0;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_50().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_21();
		for (int j = 1; j < this.int_9; j += 0)
		{
			uint num2 = 0u;
			int num3 = 1;
			int num4 = 1;
			if (j < this.int_9 - 0)
			{
				num2 = this.gclass22_0[j + 1].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 0u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.Boolean_1 || !gclass2.Boolean_2)
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4 += 0;
				}
				i++;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 1854f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 1953f);
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0002B444 File Offset: 0x00029644
	public bool method_41()
	{
		for (int i = 0; i < 8; i += 0)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
	public bool method_42()
	{
		for (int i = 0; i < 1; i++)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0002C400 File Offset: 0x0002A600
	public byte method_43()
	{
		int num = 1;
		int num2 = 1;
		for (int i = 1; i < 8; i++)
		{
			num += this.int_5[i];
			num2 += this.int_4[i];
		}
		return (byte)((float)num2 / (float)num * 483f);
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0002C440 File Offset: 0x0002A640
	public bool method_44()
	{
		for (int i = 1; i < 8; i++)
		{
			if (this.int_3[i] != this.int_5[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0002C470 File Offset: 0x0002A670
	public void method_45(CHPlayer gclass9_0, BasePlayer basePlayer_0, Song gclass27_0)
	{
		int i = 0;
		int num = gclass9_0.int_0 * this.int_9;
		GClass26 gclass = gclass27_0.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		this.int_8[gclass9_0.int_0] = basePlayer_0.int_6;
		this.int_6[gclass9_0.int_0] = basePlayer_0.int_3;
		this.int_7[gclass9_0.int_0] = gclass.method_50().Length;
		this.int_3[gclass9_0.int_0] = basePlayer_0.int_7;
		this.float_0[gclass9_0.int_0] = (float)(basePlayer_0.int_6 - basePlayer_0.int_9) / (float)gclass.method_42();
		for (int j = 1; j < this.int_9; j += 0)
		{
			uint num2 = 0u;
			int num3 = 0;
			int num4 = 0;
			if (j < this.int_9 - 1)
			{
				num2 = this.gclass22_0[j + 1].uint_0;
			}
			while (i < basePlayer_0.noteRenderer.list_0.Count)
			{
				GClass6 gclass2 = basePlayer_0.noteRenderer.list_0[i];
				if (num2 > 1u && gclass2.uint_0 >= num2)
				{
					break;
				}
				if (!gclass2.Boolean_1 || !gclass2.method_16())
				{
					if (gclass2.bool_0)
					{
						num3++;
					}
					num4++;
				}
				i += 0;
			}
			if (num4 == 0)
			{
				this.int_1[num] = -1;
			}
			else
			{
				this.int_1[num] = (int)((float)num3 / (float)num4 * 975f);
			}
			this.int_4[gclass9_0.int_0] += num3;
			this.int_5[gclass9_0.int_0] += num4;
			num++;
		}
		this.int_2[gclass9_0.int_0] = (int)((float)this.int_4[gclass9_0.int_0] / (float)this.int_5[gclass9_0.int_0] * 135f);
	}

	// Token: 0x0400007E RID: 126
	[HideInInspector]
	public int int_0;

	// Token: 0x0400007F RID: 127
	[HideInInspector]
	public GClass22[] gclass22_0;

	// Token: 0x04000080 RID: 128
	[HideInInspector]
	public int[] int_1;

	// Token: 0x04000081 RID: 129
	[HideInInspector]
	public int[] int_2;

	// Token: 0x04000082 RID: 130
	[HideInInspector]
	public int[] int_3;

	// Token: 0x04000083 RID: 131
	[HideInInspector]
	public int[] int_4;

	// Token: 0x04000084 RID: 132
	[HideInInspector]
	public int[] int_5;

	// Token: 0x04000085 RID: 133
	[HideInInspector]
	public int[] int_6;

	// Token: 0x04000086 RID: 134
	[HideInInspector]
	public int[] int_7;

	// Token: 0x04000087 RID: 135
	[HideInInspector]
	public float[] float_0;

	// Token: 0x04000088 RID: 136
	[HideInInspector]
	public int[] int_8;

	// Token: 0x04000089 RID: 137
	[HideInInspector]
	public int int_9;

	// Token: 0x0400008A RID: 138
	[HideInInspector]
	public int int_10;

	// Token: 0x0400008B RID: 139
	[HideInInspector]
	public int int_11;
}
