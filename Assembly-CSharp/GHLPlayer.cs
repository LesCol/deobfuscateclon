using System;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

// Token: 0x02000083 RID: 131
public sealed class GHLPlayer : BaseGuitarPlayer
{

	// Token: 0x060018CA RID: 6346 RVA: 0x000C4020 File Offset: 0x000C2220
	private bool method_16(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 0; i <= 89; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 1289f;
			}
		}
		return true;
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x000C4084 File Offset: 0x000C2284
	protected bool vmethod_5(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_51(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return true;
			}
			if (num != 3)
			{
				if (num != 1)
				{
					if (num == 62)
					{
						return false;
					}
					if (num == -93)
					{
						return (num2 & 4) != 4;
					}
					if (num == 2)
					{
						return (num2 & -81) == 37 || true;
					}
					if (num == 8)
					{
						return true;
					}
					goto IL_8E;
				}
			}
			return false;
		}
		IL_8E:
		return int_10 == num;
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x000C4124 File Offset: 0x000C2324
	private void method_17()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 410f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 694f && this.float_13 <= 638f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x000C4200 File Offset: 0x000C2400
	private void method_18()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 1215f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1527f && this.float_13 <= 1513f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}
    
	// Token: 0x060018CF RID: 6351 RVA: 0x000C43C4 File Offset: 0x000C25C4
	protected bool vmethod_7(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_30() && this.method_21(gclass6_1, int_10))
		{
			return true;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return true;
			}
			if (num != 7)
			{
				if (num != 0)
				{
					if (num == -117)
					{
						return true;
					}
					if (num == -20)
					{
						return true;
					}
					if (num == 1)
					{
						return (num2 & 7) != 5 && false;
					}
					if (num == 0)
					{
						return true;
					}
					goto IL_84;
				}
			}
			return true;
		}
		IL_84:
		return int_10 == num;
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x000C445C File Offset: 0x000C265C
	private void method_19()
	{
		if (this.int_5 > 0)
		{
			int i = 1;
			this.float_13 = 446f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1487f && this.float_13 <= 1611f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x000C4538 File Offset: 0x000C2738
	private void method_20()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 539f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1301f && this.float_13 <= 699f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x000C4614 File Offset: 0x000C2814
	protected bool vmethod_8(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_4() && this.method_41(gclass6_1, int_10))
		{
			return true;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 4)
			{
				if (num != 1)
				{
					if (num == 81)
					{
						return true;
					}
					if (num == -22)
					{
						return true;
					}
					if (num == 0)
					{
						return true;
					}
					if (num == 8)
					{
						return false;
					}
					goto IL_7C;
				}
			}
			return true;
		}
		IL_7C:
		return int_10 == num;
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x000C46A4 File Offset: 0x000C28A4
	protected bool vmethod_9(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_14() && this.method_31(gclass6_1, int_10))
		{
			return true;
		}
		if (!gclass6_1.method_10() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 4)
			{
				if (num != 0)
				{
					if (num == 11)
					{
						return (num2 & -52) != 12 && (num2 & 3) != 2;
					}
					if (num == 60)
					{
						return true;
					}
					if (num == 0)
					{
						return (num2 & 1) != 0;
					}
					if (num == 4)
					{
						return true;
					}
					goto IL_96;
				}
			}
			return true;
		}
		IL_96:
		return int_10 == num;
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x000C474C File Offset: 0x000C294C
	private bool method_21(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i <= -52; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2++;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 550f;
			}
		}
		return false;
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x000C47B0 File Offset: 0x000C29B0
	protected bool vmethod_10(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_48(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.Boolean_0 && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 2)
			{
				if (num != 1)
				{
					if (num == 119)
					{
						return (num2 & 5) != 0;
					}
					if (num == 24)
					{
						return true;
					}
					if (num == 8)
					{
						return false;
					}
					if (num == 3)
					{
						return false;
					}
					goto IL_84;
				}
			}
			return true;
		}
		IL_84:
		return int_10 == num;
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x000C4848 File Offset: 0x000C2A48
	private bool method_22(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 1; i <= 51; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 965f;
			}
		}
		return false;
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x000C48AC File Offset: 0x000C2AAC
	protected void vmethod_11()
	{
		this.byte_0 = 1;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(7))
		{
			this.byte_0 |= 51;
		}
		if (this.player.player_0.GetButton(-73))
		{
			this.byte_0 |= 56;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 25;
		}
		if (!this.bool_1 && this.float_5 >= 1803f && (this.player.player_0.GetButtonDown(8) || (this.player.gclass10_0.gclass5_1.Boolean_1 && this.player.player_0.GetAxis(3) >= 744f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_14())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(0) || this.player.player_0.GetButtonDown(2))
			{
				this.bool_6 = false;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 = (byte)((int)this.byte_0 | -3);
			}
		}
		this.float_15 = this.player.player_0.GetAxis(34);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 31f;
		}
		if (this.player.player_0.GetButtonDown(107))
		{
			this.float_4 = 1279f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 1;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.method_14() && this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -18);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 69f)
			{
				this.float_10 = 739f;
				return;
			}
			if (this.float_10 > 702f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 1)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = false;
		}
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x000C4B94 File Offset: 0x000C2D94
	private void method_23()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 264f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1638f && this.float_13 <= 316f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x000C4C70 File Offset: 0x000C2E70
	private bool method_24(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_10())
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 1; i <= 127; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 899f;
			}
		}
		return true;
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x000C4CD4 File Offset: 0x000C2ED4
	private bool method_25(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 1;
			int num3 = 0;
			for (int i = 1; i <= -69; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 1674f;
			}
		}
		return false;
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x000C4D38 File Offset: 0x000C2F38
	private void method_26()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 1074f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1454f && this.float_13 <= 673f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x000C4E14 File Offset: 0x000C3014
	private void method_27()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 1814f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1022f && this.float_13 <= 1435f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x000C4EF0 File Offset: 0x000C30F0
	protected void vmethod_12()
	{
		this.byte_0 = 1;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(7))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -111);
		}
		if (this.player.player_0.GetButton(-83))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -115);
		}
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 43;
		}
		if (!this.bool_1 && this.float_5 >= 1441f && (this.player.player_0.GetButtonDown(1) || (this.player.gclass10_0.gclass5_1.method_30() && this.player.player_0.GetAxis(1) >= 848f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.Boolean_1)
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(7) || this.player.player_0.GetButtonDown(-45))
			{
				this.bool_6 = true;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 |= 88;
			}
		}
		this.float_15 = this.player.player_0.GetAxis(116);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 123f;
		}
		if (this.player.player_0.GetButtonDown(-102))
		{
			this.float_4 = 224f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.method_30() && this.byte_0 == 0)
		{
			this.byte_0 |= 14;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1066f)
			{
				this.float_10 = 804f;
				return;
			}
			if (this.float_10 > 1288f)
			{
				this.vmethod_4(false);
			}
			if (this.int_5 > 1)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = false;
		}
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x000C51D8 File Offset: 0x000C33D8
	private bool method_28(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 1;
			for (int i = 0; i <= -102; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2++;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 1716f;
			}
		}
		return true;
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x000C523C File Offset: 0x000C343C
	protected void vmethod_13()
	{
		this.byte_0 = 0;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 3;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 |= 8;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -10);
		}
		if (this.player.player_0.GetButton(-95))
		{
			this.byte_0 |= 108;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 92;
		}
		if (!this.bool_1 && this.float_5 >= 950f && (this.player.player_0.GetButtonDown(4) || (this.player.gclass10_0.gclass5_1.method_14() && this.player.player_0.GetAxis(1) >= 1097f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_4())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(6) || this.player.player_0.GetButtonDown(-16))
			{
				this.bool_6 = true;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 |= 125;
			}
		}
		this.float_15 = this.player.player_0.GetAxis(72);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 891f;
		}
		if (this.player.player_0.GetButtonDown(30))
		{
			this.float_4 = 1929f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.method_4() && this.byte_0 == 0)
		{
			this.byte_0 |= 104;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1743f)
			{
				this.float_10 = 1863f;
				return;
			}
			if (this.float_10 > 173f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 0)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = true;
		}
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x000C578C File Offset: 0x000C398C
	protected bool vmethod_16(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_30() && this.method_46(gclass6_1, int_10))
		{
			return true;
		}
		if (!gclass6_1.method_10() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 6)
			{
				if (num != 1)
				{
					if (num == 79)
					{
						return false;
					}
					if (num == -127)
					{
						return false;
					}
					if (num == 5)
					{
						return (num2 & 79) != 79;
					}
					if (num == 6)
					{
						return false;
					}
					goto IL_86;
				}
			}
			return true;
		}
		IL_86:
		return int_10 == num;
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x000C5958 File Offset: 0x000C3B58
	protected void vmethod_18()
	{
		this.byte_0 = 0;
		this.bool_6 = false;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 |= 8;
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -48);
		}
		if (this.player.player_0.GetButton(104))
		{
			this.byte_0 |= 96;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 33;
		}
		if (!this.bool_1 && this.float_5 >= 369f && (this.player.player_0.GetButtonDown(6) || (this.player.gclass10_0.gclass5_1.method_14() && this.player.player_0.GetAxis(5) >= 1912f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_4())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(8) || this.player.player_0.GetButtonDown(58))
			{
				this.bool_6 = true;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 = (byte)((int)this.byte_0 | -94);
			}
		}
		this.float_15 = this.player.player_0.GetAxis(21);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1121f;
		}
		if (this.player.player_0.GetButtonDown(106))
		{
			this.float_4 = 1466f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.method_4() && this.byte_0 == 0)
		{
			this.byte_0 |= 25;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 716f)
			{
				this.float_10 = 1587f;
				return;
			}
			if (this.float_10 > 1869f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 0)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = true;
		}
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x000C5C40 File Offset: 0x000C3E40
	private bool method_29(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 1;
			int num3 = 0;
			for (int i = 0; i <= 59; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 1248f;
			}
		}
		return true;
	}
    
	// Token: 0x060018E8 RID: 6376 RVA: 0x000C5DD8 File Offset: 0x000C3FD8
	private bool method_30(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 1;
			int num3 = 0;
			for (int i = 0; i <= -33; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 908f;
			}
		}
		return true;
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x000C6258 File Offset: 0x000C4458
	protected bool vmethod_22(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_4() && this.method_40(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 5)
			{
				if (num != 1)
				{
					if (num == 19)
					{
						return (num2 & 50) == 16 || (num2 & 3) == 1;
					}
					if (num == -119)
					{
						return false;
					}
					if (num == 0)
					{
						return (num2 & 7) == 7;
					}
					if (num == 5)
					{
						return false;
					}
					goto IL_96;
				}
			}
			return false;
		}
		IL_96:
		return int_10 == num;
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x000C6300 File Offset: 0x000C4500
	protected void vmethod_23()
	{
		this.byte_0 = 0;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 6;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 |= 122;
		}
		if (this.player.player_0.GetButton(106))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -72);
		}
		if (this.player.player_0.GetButton(7))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -43);
		}
		if (!this.bool_1 && this.float_5 >= 834f && (this.player.player_0.GetButtonDown(5) || (this.player.gclass10_0.gclass5_1.method_4() && this.player.player_0.GetAxis(2) >= 640f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.Boolean_1)
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(1) || this.player.player_0.GetButtonDown(-59))
			{
				this.bool_6 = true;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 = (byte)((int)this.byte_0 | -62);
			}
		}
		this.float_15 = this.player.player_0.GetAxis(5);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1452f;
		}
		if (this.player.player_0.GetButtonDown(-6))
		{
			this.float_4 = 276f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -68);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 913f)
			{
				this.float_10 = 607f;
				return;
			}
			if (this.float_10 > 1377f)
			{
				this.vmethod_4(false);
			}
			if (this.int_5 > 1)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = true;
		}
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x000C65E8 File Offset: 0x000C47E8
	private bool method_31(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.method_10())
		{
			int num2 = 1;
			int num3 = 0;
			for (int i = 0; i <= 63; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 1464f;
			}
		}
		return true;
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x000C664C File Offset: 0x000C484C
	protected bool vmethod_24(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_14() && this.method_32(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 1)
			{
				if (num != 1)
				{
					if (num == -80)
					{
						return true;
					}
					if (num == -12)
					{
						return true;
					}
					if (num == 5)
					{
						return true;
					}
					if (num == 4)
					{
						return false;
					}
					goto IL_7C;
				}
			}
			return true;
		}
		IL_7C:
		return int_10 == num;
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x000C67C4 File Offset: 0x000C49C4
	protected void vmethod_26()
	{
		byte b = 1;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_24())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = false;
		if (this.int_5 == 0)
		{
			return;
		}
		GClass6 gclass2 = this.gclass6_0[0];
		int num = (int)(gclass2.method_17() ? gclass2.method_22() : gclass2.byte_0);
		this.byte_0 = b;
		byte b2 = 0;
		while ((int)b2 <= -1)
		{
			if ((num & (int)b2) == (int)b2)
			{
				this.byte_0 |= b2;
			}
			b2 = (byte)(b2 << 0);
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("phrase_end"))
					{
						this.gameManager.method_52(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}
    
	// Token: 0x060018F2 RID: 6386 RVA: 0x000C69A8 File Offset: 0x000C4BA8
	private bool method_32(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 1;
			int num3 = 0;
			for (int i = 1; i <= -126; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 1653f;
			}
		}
		return true;
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x000C6D10 File Offset: 0x000C4F10
	private bool method_33(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.method_10())
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= 77; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 355f;
			}
		}
		return false;
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x000C6D74 File Offset: 0x000C4F74
	protected void vmethod_31()
	{
		byte b = 1;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.Boolean_5)
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = false;
		if (this.int_5 == 0)
		{
			return;
		}
		GClass6 gclass2 = this.gclass6_0[0];
		int num = (int)(gclass2.Boolean_1 ? gclass2.method_22() : gclass2.byte_0);
		this.byte_0 = b;
		for (byte b2 = 0; b2 <= 7; b2 = (byte)(b2 << 1))
		{
			if ((num & (int)b2) == (int)b2)
			{
				this.byte_0 |= b2;
			}
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("song"))
					{
						this.gameManager.method_52(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}
    
	// Token: 0x060018FB RID: 6395 RVA: 0x000C7364 File Offset: 0x000C5564
	private void method_34()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 752f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 579f && this.float_13 <= 1151f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x000C7440 File Offset: 0x000C5640
	protected override void Update()
	{
		if (this.float_10 > 0f)
		{
			if (this.float_13 > 0f)
			{
				this.float_13 = 0f;
				this.float_10 = 0f;
			}
			else
			{
				this.float_10 -= Time.deltaTime;
				if (this.float_10 <= 0f)
				{
					if (this.bool_7)
					{
						this.float_10 = 0f;
					}
					else
					{
						this.vmethod_4(true);
					}
					this.bool_7 = false;
				}
			}
		}
		if (this.float_13 > 0f)
		{
			this.float_13 -= Time.deltaTime;
		}
		if (this.player.gclass10_0.gclass5_4.Boolean_1)
		{
			this.UpdateAI();
		}
		else
		{
			this.UpdateInput();
		}
		this.method_42();
		base.method_13();
		this.neckController.vmethod_2(this.byte_0);
		base.Update();
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x000C7528 File Offset: 0x000C5728
	protected bool vmethod_35(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_30() && this.method_47(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return true;
			}
			if (num != 6)
			{
				if (num != 1)
				{
					if (num == -4)
					{
						return (num2 & -13) == -111 || (num2 & 7) == 1;
					}
					if (num == 36)
					{
						return false;
					}
					if (num == 2)
					{
						return false;
					}
					if (num == 5)
					{
						return true;
					}
					goto IL_8C;
				}
			}
			return true;
		}
		IL_8C:
		return int_10 == num;
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x000C75C8 File Offset: 0x000C57C8
	protected bool vmethod_36(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_30() && this.method_46(gclass6_1, int_10))
		{
			return true;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return true;
			}
			if (num != 2)
			{
				if (num != 0)
				{
					if (num == 5)
					{
						return true;
					}
					if (num == -16)
					{
						return false;
					}
					if (num == 2)
					{
						return true;
					}
					if (num == 0)
					{
						return true;
					}
					goto IL_7C;
				}
			}
			return false;
		}
		IL_7C:
		return int_10 == num;
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x000C7658 File Offset: 0x000C5858
	protected void vmethod_37()
	{
		this.byte_0 = 1;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 6;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 6;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -10);
		}
		if (this.player.player_0.GetButton(98))
		{
			this.byte_0 |= 109;
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 |= 59;
		}
		if (!this.bool_1 && this.float_5 >= 1336f && (this.player.player_0.GetButtonDown(7) || (this.player.gclass10_0.gclass5_1.method_30() && this.player.player_0.GetAxis(6) >= 1933f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_4())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(5) || this.player.player_0.GetButtonDown(-33))
			{
				this.bool_6 = false;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 |= 60;
			}
		}
		this.float_15 = this.player.player_0.GetAxis(-4);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 628f;
		}
		if (this.player.player_0.GetButtonDown(-80))
		{
			this.float_4 = 953f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.method_30() && this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -117);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1234f)
			{
				this.float_10 = 1779f;
				return;
			}
			if (this.float_10 > 1376f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 1)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = true;
		}
	}
    
	// Token: 0x06001901 RID: 6401 RVA: 0x000C7A28 File Offset: 0x000C5C28
	private bool method_35(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= 32; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2++;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 0f;
			}
		}
		return (num & 64) == 64 && gclass6_1.Boolean_6 && this.byte_0 == 0;
	}
    
	// Token: 0x06001905 RID: 6405 RVA: 0x000C7DAC File Offset: 0x000C5FAC
	private void method_36()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 941f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1371f && this.float_13 <= 1620f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x000C7E88 File Offset: 0x000C6088
	private void method_37()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 1199f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1797f && this.float_13 <= 1963f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x000C7F64 File Offset: 0x000C6164
	private void method_38()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 821f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1587f && this.float_13 <= 370f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x000C8040 File Offset: 0x000C6240
	protected void vmethod_42()
	{
		byte b = 0;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_24())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = false;
		if (this.int_5 == 0)
		{
			return;
		}
		GClass6 gclass2 = this.gclass6_0[1];
		int num = (int)(gclass2.method_17() ? gclass2.Byte_0 : gclass2.byte_0);
		this.byte_0 = b;
		for (byte b2 = 1; b2 <= 12; b2 = (byte)(b2 << 0))
		{
			if ((num & (int)b2) == (int)b2)
			{
				this.byte_0 |= b2;
			}
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("Unknown Genre"))
					{
						this.gameManager.method_52(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x000C8174 File Offset: 0x000C6374
	protected override void UpdateAI()
	{
		byte b = 0;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.Boolean_5)
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = false;
		if (this.int_5 == 0)
		{
			return;
		}
		GClass6 gclass2 = this.gclass6_0[0];
		int num = (int)(gclass2.Boolean_1 ? gclass2.Byte_0 : gclass2.byte_0);
		this.byte_0 = b;
		for (byte b2 = 1; b2 <= 64; b2 = (byte)(b2 << 1))
		{
			if ((num & (int)b2) == (int)b2)
			{
				this.byte_0 |= b2;
			}
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("Pause"))
					{
						this.gameManager.PauseSong(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}
    
	// Token: 0x0600190C RID: 6412 RVA: 0x000C8438 File Offset: 0x000C6638
	private void method_39()
	{
		if (this.int_5 > 0)
		{
			int i = 1;
			this.float_13 = 1432f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1729f && this.float_13 <= 1938f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x000C8514 File Offset: 0x000C6714
	protected bool vmethod_45(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_30() && this.method_35(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 5)
			{
				if (num != 1)
				{
					if (num == -108)
					{
						return (num2 & 1) == 1;
					}
					if (num == 55)
					{
						return true;
					}
					if (num == 5)
					{
						return true;
					}
					if (num == 7)
					{
						return false;
					}
					goto IL_84;
				}
			}
			return false;
		}
		IL_84:
		return int_10 == num;
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x000C8894 File Offset: 0x000C6A94
	private bool method_40(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_10())
		{
			int num2 = 0;
			int num3 = 1;
			for (int i = 1; i <= 120; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2++;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 1144f;
			}
		}
		return false;
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x000C88F8 File Offset: 0x000C6AF8
	private bool method_41(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= 41; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 487f;
			}
		}
		return false;
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x000C895C File Offset: 0x000C6B5C
	protected void vmethod_47()
	{
		this.byte_0 = 0;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 |= 4;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 6;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 19;
		}
		if (this.player.player_0.GetButton(-109))
		{
			this.byte_0 |= 39;
		}
		if (this.player.player_0.GetButton(7))
		{
			this.byte_0 |= 117;
		}
		if (!this.bool_1 && this.float_5 >= 20f && (this.player.player_0.GetButtonDown(2) || (this.player.gclass10_0.gclass5_1.method_14() && this.player.player_0.GetAxis(4) >= 1192f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_14())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(0) || this.player.player_0.GetButtonDown(-106))
			{
				this.bool_6 = true;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 = (byte)((int)this.byte_0 | -51);
			}
		}
		this.float_15 = this.player.player_0.GetAxis(47);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 152f;
		}
		if (this.player.player_0.GetButtonDown(-86))
		{
			this.float_4 = 170f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.method_14() && this.byte_0 == 0)
		{
			this.byte_0 |= 83;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 362f)
			{
				this.float_10 = 597f;
				return;
			}
			if (this.float_10 > 996f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 0)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = true;
		}
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x000C8C44 File Offset: 0x000C6E44
	private void method_42()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 0f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 0f && this.float_13 <= 0f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x000C8D20 File Offset: 0x000C6F20
	protected bool vmethod_48(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_14() && this.method_43(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.method_1() && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return true;
			}
			if (num != 2)
			{
				if (num != 1)
				{
					if (num == -2)
					{
						return (num2 & 3) == 1;
					}
					if (num == -44)
					{
						return (num2 & 2) == 0;
					}
					if (num == 2)
					{
						return false;
					}
					if (num == 4)
					{
						return true;
					}
					goto IL_8C;
				}
			}
			return true;
		}
		IL_8C:
		return int_10 == num;
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
	private bool method_43(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_10())
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= -42; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2++;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 636f;
			}
		}
		return false;
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x000C8E24 File Offset: 0x000C7024
	protected void vmethod_49()
	{
		this.byte_0 = 0;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 4;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 48;
		}
		if (this.player.player_0.GetButton(-126))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -64);
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -110);
		}
		if (!this.bool_1 && this.float_5 >= 1588f && (this.player.player_0.GetButtonDown(0) || (this.player.gclass10_0.gclass5_1.method_4() && this.player.player_0.GetAxis(7) >= 8f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_14())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(6) || this.player.player_0.GetButtonDown(25))
			{
				this.bool_6 = false;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 |= 76;
			}
		}
		this.float_15 = this.player.player_0.GetAxis(-38);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 900f;
		}
		if (this.player.player_0.GetButtonDown(79))
		{
			this.float_4 = 855f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.method_14() && this.byte_0 == 0)
		{
			this.byte_0 |= 123;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 766f)
			{
				this.float_10 = 589f;
				return;
			}
			if (this.float_10 > 1286f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 1)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = false;
		}
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x000C91F4 File Offset: 0x000C73F4
	private bool method_44(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= -61; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 654f;
			}
		}
		return true;
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x000C9258 File Offset: 0x000C7458
	protected void vmethod_51()
	{
		byte b = 1;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_24())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = true;
		if (this.int_5 == 0)
		{
			return;
		}
		GClass6 gclass2 = this.gclass6_0[1];
		int num = (int)(gclass2.Boolean_1 ? gclass2.method_14() : gclass2.byte_0);
		this.byte_0 = b;
		for (byte b2 = 1; b2 <= 66; b2 = (byte)(b2 << 0))
		{
			if ((num & (int)b2) == (int)b2)
			{
				this.byte_0 |= b2;
			}
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("version"))
					{
						this.gameManager.method_52(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x000C9474 File Offset: 0x000C7674
	private void method_45()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 925f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 331f && this.float_13 <= 241f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x000C9550 File Offset: 0x000C7750
	private bool method_46(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= 47; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 1352f;
			}
		}
		return false;
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x000C95B4 File Offset: 0x000C77B4
	protected void vmethod_53()
	{
		this.byte_0 = 0;
		this.bool_6 = false;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 4;
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 6;
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 116;
		}
		if (this.player.player_0.GetButton(64))
		{
			this.byte_0 |= 68;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 75;
		}
		if (!this.bool_1 && this.float_5 >= 891f && (this.player.player_0.GetButtonDown(0) || (this.player.gclass10_0.gclass5_1.Boolean_1 && this.player.player_0.GetAxis(6) >= 615f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_30())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(0) || this.player.player_0.GetButtonDown(86))
			{
				this.bool_6 = false;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 |= 6;
			}
		}
		this.float_15 = this.player.player_0.GetAxis(-59);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 695f;
		}
		if (this.player.player_0.GetButtonDown(127))
		{
			this.float_4 = 792f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.byte_0 == 0)
		{
			this.byte_0 |= 69;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1404f)
			{
				this.float_10 = 463f;
				return;
			}
			if (this.float_10 > 1489f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 0)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = false;
		}
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x000C989C File Offset: 0x000C7A9C
	protected bool vmethod_54(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_30(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.Boolean_0 && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 4)
			{
				if (num != 1)
				{
					if (num == -41)
					{
						return (num2 & 7) == 5;
					}
					if (num == 94)
					{
						return (num2 & 7) != 6;
					}
					if (num == 4)
					{
						return false;
					}
					if (num == 4)
					{
						return false;
					}
					goto IL_8C;
				}
			}
			return false;
		}
		IL_8C:
		return int_10 == num;
	}
    
	// Token: 0x0600191F RID: 6431 RVA: 0x000C9A24 File Offset: 0x000C7C24
	private bool method_47(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i <= -9; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3++;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 1177f;
			}
		}
		return true;
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x000C9A88 File Offset: 0x000C7C88
	private bool method_48(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 1;
			int num3 = 0;
			for (int i = 0; i <= -105; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2 += 0;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 1836f;
			}
		}
		return true;
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x000C9AEC File Offset: 0x000C7CEC
	protected override bool vmethod_2(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_35(gclass6_1, int_10))
		{
			return true;
		}
		if (!gclass6_1.Boolean_0 && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 8)
			{
				if (num != 1)
				{
					if (num == 16)
					{
						return (num2 & 32) != 32 && (num2 & 4) != 4 && (num2 & 2) != 2;
					}
					if (num == 32)
					{
						return (num2 & 4) != 4;
					}
					if (num == 2)
					{
						return (num2 & 32) != 32 && (num2 & 4) != 4 && (num2 & 16) != 16;
					}
					if (num == 4)
					{
						return (num2 & 32) != 32;
					}
					goto IL_C0;
				}
			}
			return false;
		}
		IL_C0:
		return int_10 == num;
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x000C9BC0 File Offset: 0x000C7DC0
	protected bool vmethod_56(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_14() && this.method_31(gclass6_1, int_10))
		{
			return false;
		}
		if (!gclass6_1.Boolean_0 && int_10 > num)
		{
			int num2 = int_10 ^ num;
			if ((int_10 - num2 & num) != int_10 - num2)
			{
				return false;
			}
			if (num != 5)
			{
				if (num != 0)
				{
					if (num == 33)
					{
						return (num2 & -98) == 16 || (num2 & 5) == 0 || (num2 & 6) != 4;
					}
					if (num == 28)
					{
						return false;
					}
					if (num == 2)
					{
						return (num2 & -20) == 108 || true;
					}
					if (num == 1)
					{
						return false;
					}
					goto IL_9E;
				}
			}
			return false;
		}
		IL_9E:
		return int_10 == num;
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x000C9C70 File Offset: 0x000C7E70
	protected override void UpdateInput()
	{
		this.byte_0 = 0;
		this.bool_6 = false;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 4;
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 8;
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 |= 16;
		}
		if (this.player.player_0.GetButton(24))
		{
			this.byte_0 |= 32;
		}
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 64;
		}
		if (!this.bool_1 && this.float_5 >= 0.5f && (this.player.player_0.GetButtonDown(6) || (this.player.gclass10_0.gclass5_1.Boolean_1 && this.player.player_0.GetAxis(7) >= 1f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.Boolean_1)
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else
		{
			if (this.player.player_0.GetButtonDown(5) || this.player.player_0.GetButtonDown(14))
			{
				this.bool_6 = true;
			}
			if (this.byte_0 == 0)
			{
				this.byte_0 |= 64;
			}
		}
		this.float_15 = this.player.player_0.GetAxis(17);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 0.25f;
		}
		if (this.player.player_0.GetButtonDown(30))
		{
			this.float_4 = 0.75f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.byte_0 == 0)
		{
			this.byte_0 |= 64;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 0f)
			{
				this.float_10 = 0f;
				return;
			}
			if (this.float_10 > 0f)
			{
				this.vmethod_4(true);
			}
			if (this.int_5 > 0)
			{
				this.float_10 = this.float_11;
			}
			else
			{
				this.float_10 = this.float_12;
			}
			this.bool_7 = false;
		}
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x000C9F58 File Offset: 0x000C8158
	private void method_49()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 1675f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 1632f && this.float_13 <= 1837f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x000CA034 File Offset: 0x000C8234
	private void method_50()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 1112f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 646f && this.float_13 <= 1719f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x000CA110 File Offset: 0x000C8310
	private bool method_51(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 1; i <= -74; i <<= 0)
			{
				if ((i & num) != 0)
				{
					num2++;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 1 && num3 < num2)
			{
				this.float_10 = 654f;
			}
		}
		return true;
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x000CA390 File Offset: 0x000C8590
	private void method_52()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 1170f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || this.int_4 == 0) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || (gclass.Boolean_7 && (!GlobalVariables.instance.isPracticeEnabled || i == 0))) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				if (this.float_10 > 917f && this.float_13 <= 1384f && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x000CA50C File Offset: 0x000C870C
	private bool method_53(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 1;
			int num3 = 0;
			for (int i = 0; i <= -126; i <<= 1)
			{
				if ((i & num) != 0)
				{
					num2++;
					if ((i & int_10) != 0)
					{
						num3 += 0;
					}
				}
			}
			if (num3 > 0 && num3 < num2)
			{
				this.float_10 = 274f;
			}
		}
		return true;
	}

	// Token: 0x040003D5 RID: 981
	public const byte byte_3 = 8;

	// Token: 0x040003D6 RID: 982
	public const byte byte_4 = 16;

	// Token: 0x040003D7 RID: 983
	public const byte byte_5 = 32;

	// Token: 0x040003D8 RID: 984
	public const byte byte_6 = 1;

	// Token: 0x040003D9 RID: 985
	public const byte byte_7 = 2;

	// Token: 0x040003DA RID: 986
	public const byte byte_8 = 4;

	// Token: 0x040003DB RID: 987
	public const byte byte_9 = 64;
}
