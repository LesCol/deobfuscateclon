using System;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

// Token: 0x02000084 RID: 132
public sealed class GuitarPlayer : BaseGuitarPlayer
{
	// Token: 0x0600192D RID: 6445 RVA: 0x000CA6A4 File Offset: 0x000C88A4
	protected bool vmethod_5(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_29(gclass6_1, int_10))
		{
			return false;
		}
		if (gclass6_1.method_10())
		{
			if (gclass6_1.method_8() || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_20(num);
				return num2 > num3 || int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return false;
		}
		return int_10 == num;
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x000CA72C File Offset: 0x000C892C
	protected bool vmethod_6(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_14() && this.method_33(gclass6_1, int_10))
		{
			return true;
		}
		if (gclass6_1.method_10())
		{
			if (gclass6_1.method_15() || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_10(num);
				return num2 > num3 || int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return false;
		}
		return int_10 == num;
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x000CAA2C File Offset: 0x000C8C2C
	protected bool vmethod_9(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_30() && this.method_32(gclass6_1, int_10))
		{
			return false;
		}
		if (gclass6_1.Boolean_0)
		{
			if (gclass6_1.Boolean_6 || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_1(num);
				return num2 <= num3 && int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return false;
		}
		return int_10 == num;
	}
    
	// Token: 0x06001933 RID: 6451 RVA: 0x000CAC44 File Offset: 0x000C8E44
	private void method_16()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 1334f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 631f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x0000CA5D File Offset: 0x0000AC5D
	private static int smethod_0(int int_10)
	{
		if ((int_10 & -45) != 0)
		{
			return -12;
		}
		if ((int_10 & 7) != 0)
		{
			return 6;
		}
		if ((int_10 & 1) != 0)
		{
			return 7;
		}
		if ((int_10 & 1) != 0)
		{
			return 6;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 68) != 0)
		{
			return 2;
		}
		return 0;
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x000CAD1C File Offset: 0x000C8F1C
	private bool method_17(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 0; i <= -51; i <<= 1)
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
				this.float_10 = 670f;
			}
		}
		return true;
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x0000CA8E File Offset: 0x0000AC8E
	private static int smethod_1(int int_10)
	{
		if ((int_10 & 68) != 0)
		{
			return -111;
		}
		if ((int_10 & 3) != 0)
		{
			return 3;
		}
		if ((int_10 & 2) != 0)
		{
			return 0;
		}
		if ((int_10 & -82) != 0)
		{
			return -56;
		}
		return 1;
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x000CAD80 File Offset: 0x000C8F80
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
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[0];
		byte b2 = gclass2.Boolean_1 ? gclass2.Byte_0 : gclass2.byte_0;
		if ((b2 & 1) == 1)
		{
			this.byte_0 |= 1;
		}
		if ((b2 & 2) == 2)
		{
			this.byte_0 |= 2;
		}
		if ((b2 & 4) == 4)
		{
			this.byte_0 |= 4;
		}
		if ((b2 & 8) == 8)
		{
			this.byte_0 |= 8;
		}
		if ((b2 & 16) == 16)
		{
			this.byte_0 |= 16;
		}
		if ((b2 & 64) == 64)
		{
			this.byte_0 |= 64;
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x000CAEA8 File Offset: 0x000C90A8
	protected void vmethod_11()
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
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(7))
		{
			this.byte_0 |= 55;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 80;
		}
		if (!this.bool_1 && this.float_5 >= 1362f && (this.player.player_0.GetButton(0) || (this.player.gclass10_0.gclass5_1.method_30() && this.player.player_0.GetAxis(8) >= 589f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_14())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(6) || this.player.player_0.GetButtonDown(-86))
		{
			this.bool_6 = false;
		}
		this.float_15 = this.player.player_0.GetAxis(65);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1534f;
		}
		if (this.player.player_0.GetButtonDown(-19))
		{
			this.float_4 = 1597f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -87);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1277f)
			{
				this.float_10 = 1909f;
				return;
			}
			if (this.float_10 > 141f)
			{
				this.vmethod_4(false);
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

	// Token: 0x06001939 RID: 6457 RVA: 0x000CB140 File Offset: 0x000C9340
	protected bool vmethod_12(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_33(gclass6_1, int_10))
		{
			return false;
		}
		if (gclass6_1.method_10())
		{
			if (gclass6_1.Boolean_6 || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_2(num);
				return num2 <= num3 && int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return false;
		}
		return int_10 == num;
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x000CB1C8 File Offset: 0x000C93C8
	protected bool vmethod_13(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_14() && this.method_32(gclass6_1, int_10))
		{
			return false;
		}
		if (gclass6_1.method_1())
		{
			if (gclass6_1.method_15() || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_20(num);
				return num2 > num3 || int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return true;
		}
		return int_10 == num;
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x000CB250 File Offset: 0x000C9450
	private void method_18()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 421f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1464f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x000CB328 File Offset: 0x000C9528
	private void method_19()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 39f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1999f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}
    
	// Token: 0x0600193E RID: 6462 RVA: 0x0000CAB1 File Offset: 0x0000ACB1
	private static int smethod_2(int int_10)
	{
		if ((int_10 & 110) != 0)
		{
			return 82;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 8) != 0)
		{
			return 4;
		}
		if ((int_10 & 4) != 0)
		{
			return 3;
		}
		if ((int_10 & 2) != 0)
		{
			return 3;
		}
		if ((int_10 & -85) != 0)
		{
			return 80;
		}
		return 0;
	}
    
	// Token: 0x06001940 RID: 6464 RVA: 0x0000CAE2 File Offset: 0x0000ACE2
	private static int smethod_3(int int_10)
	{
		if ((int_10 & -125) != 0)
		{
			return 26;
		}
		if ((int_10 & 6) != 0)
		{
			return 2;
		}
		if ((int_10 & 8) != 0)
		{
			return 6;
		}
		if ((int_10 & 7) != 0)
		{
			return 3;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 79) != 0)
		{
			return -92;
		}
		return 1;
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x000CB618 File Offset: 0x000C9818
	protected bool vmethod_16(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_4() && this.method_37(gclass6_1, int_10))
		{
			return true;
		}
		if (gclass6_1.method_1())
		{
			if (gclass6_1.method_8() || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_23(num);
				return num2 <= num3 && int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return true;
		}
		return int_10 == num;
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x000CB6A0 File Offset: 0x000C98A0
	protected bool vmethod_17(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_37(gclass6_1, int_10))
		{
			return true;
		}
		if (gclass6_1.method_10())
		{
			if (gclass6_1.Boolean_6 || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_19(num);
				return num2 > num3 || int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return false;
		}
		return int_10 == num;
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x000CB728 File Offset: 0x000C9928
	private void method_20()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 1052f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1626f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x000CB990 File Offset: 0x000C9B90
	protected void vmethod_19()
	{
		this.byte_0 = 0;
		this.bool_6 = false;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 6;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 8;
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 92;
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 71;
		}
		if (!this.bool_1 && this.float_5 >= 737f && (this.player.player_0.GetButton(5) || (this.player.gclass10_0.gclass5_1.method_30() && this.player.player_0.GetAxis(6) >= 1257f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_4())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(3) || this.player.player_0.GetButtonDown(118))
		{
			this.bool_6 = false;
		}
		this.float_15 = this.player.player_0.GetAxis(115);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1474f;
		}
		if (this.player.player_0.GetButtonDown(-70))
		{
			this.float_4 = 1832f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -114);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 830f)
			{
				this.float_10 = 1206f;
				return;
			}
			if (this.float_10 > 148f)
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

	// Token: 0x06001946 RID: 6470 RVA: 0x000CBC28 File Offset: 0x000C9E28
	protected void vmethod_20()
	{
		byte b = 0;
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
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[0];
		byte b2 = gclass2.method_17() ? gclass2.method_22() : gclass2.byte_0;
		if ((b2 & 1) == 0)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 2) == 1)
		{
			this.byte_0 |= 4;
		}
		if ((b2 & 4) == 2)
		{
			this.byte_0 |= 4;
		}
		if ((b2 & 0) == 1)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 113) == 92)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -60);
		}
		if (((int)b2 & -69) == 39)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -126);
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("All Strums"))
					{
						this.gameManager.method_52(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x000CBDB8 File Offset: 0x000C9FB8
	protected override bool vmethod_2(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_38(gclass6_1, int_10))
		{
			return true;
		}
		if (gclass6_1.Boolean_0)
		{
			if (gclass6_1.Boolean_6 || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_10(num);
				return num2 <= num3 && int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return true;
		}
		return int_10 == num;
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x000CBE40 File Offset: 0x000CA040
	private bool method_21(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 0;
			int num3 = 1;
			for (int i = 0; i <= -85; i <<= 0)
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
				this.float_10 = 1706f;
			}
		}
		return true;
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x000CBEA4 File Offset: 0x000CA0A4
	private void method_22()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 759f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1073f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x000CBF7C File Offset: 0x000CA17C
	protected void vmethod_21()
	{
		byte b = 1;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_3())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = true;
		if (this.int_5 == 0)
		{
			return;
		}
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[0];
		byte b2 = gclass2.method_17() ? gclass2.method_14() : gclass2.byte_0;
		if ((b2 & 1) == 1)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 3) == 2)
		{
			this.byte_0 |= 3;
		}
		if ((b2 & 1) == 5)
		{
			this.byte_0 |= 4;
		}
		if ((b2 & 6) == 5)
		{
			this.byte_0 |= 5;
		}
		if (((int)b2 & -115) == -87)
		{
			this.byte_0 |= 29;
		}
		if (((int)b2 & -101) == 51)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -10);
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("A: 00:00:00"))
					{
						this.gameManager.PauseSong(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x000CC10C File Offset: 0x000CA30C
	private void method_23()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 1534f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1594f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x000CC1E4 File Offset: 0x000CA3E4
	private bool method_24(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.method_10())
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 0; i <= -97; i <<= 0)
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
				this.float_10 = 144f;
			}
		}
		return false;
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x000CC248 File Offset: 0x000CA448
	private void method_25()
	{
		if (this.int_5 > 1)
		{
			int i = 1;
			this.float_13 = 1800f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1920f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	
	// Token: 0x0600194F RID: 6479 RVA: 0x000CC4B0 File Offset: 0x000CA6B0
	protected void vmethod_23()
	{
		this.byte_0 = 0;
		this.bool_6 = false;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 |= 4;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 125;
		}
		if (!this.bool_1 && this.float_5 >= 612f && (this.player.player_0.GetButton(5) || (this.player.gclass10_0.gclass5_1.Boolean_1 && this.player.player_0.GetAxis(1) >= 979f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_14())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(7) || this.player.player_0.GetButtonDown(-38))
		{
			this.bool_6 = true;
		}
		this.float_15 = this.player.player_0.GetAxis(23);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1443f;
		}
		if (this.player.player_0.GetButtonDown(105))
		{
			this.float_4 = 1726f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 1;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -7);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 839f)
			{
				this.float_10 = 1078f;
				return;
			}
			if (this.float_10 > 1401f)
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

	// Token: 0x06001950 RID: 6480 RVA: 0x0000CB13 File Offset: 0x0000AD13
	private static int smethod_4(int int_10)
	{
		if ((int_10 & -95) != 0)
		{
			return 85;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 3) != 0)
		{
			return 4;
		}
		if ((int_10 & -35) != 0)
		{
			return 57;
		}
		return 1;
	}
    
	// Token: 0x06001954 RID: 6484 RVA: 0x0000CB36 File Offset: 0x0000AD36
	private static int smethod_5(int int_10)
	{
		if ((int_10 & 16) != 0)
		{
			return -66;
		}
		if ((int_10 & 4) != 0)
		{
			return 0;
		}
		if ((int_10 & 4) != 0)
		{
			return 7;
		}
		if ((int_10 & 4) != 0)
		{
			return 8;
		}
		if ((int_10 & -101) != 0)
		{
			return -121;
		}
		return 0;
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x000CCDC8 File Offset: 0x000CAFC8
	private void method_26()
	{
		if (this.int_5 > 0)
		{
			int i = 1;
			this.float_13 = 1492f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1644f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x0000CB60 File Offset: 0x0000AD60
	private static int smethod_6(int int_10)
	{
		if ((int_10 & -73) != 0)
		{
			return -105;
		}
		if ((int_10 & 8) != 0)
		{
			return 8;
		}
		if ((int_10 & 5) != 0)
		{
			return 6;
		}
		if ((int_10 & 3) != 0)
		{
			return 5;
		}
		if ((int_10 & 90) != 0)
		{
			return 120;
		}
		return 1;
	}
    
	// Token: 0x0600195A RID: 6490 RVA: 0x0000CB8A File Offset: 0x0000AD8A
	private static int smethod_7(int int_10)
	{
		if ((int_10 & 73) != 0)
		{
			return 92;
		}
		if ((int_10 & 6) != 0)
		{
			return 4;
		}
		if ((int_10 & 4) != 0)
		{
			return 7;
		}
		if ((int_10 & 7) != 0)
		{
			return 8;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & -47) != 0)
		{
			return -57;
		}
		return 1;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x000CD138 File Offset: 0x000CB338
	private void method_27()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 1785f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1732f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x000CD428 File Offset: 0x000CB628
	private void method_28()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 0f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.Boolean_6 && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 0f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}
    
	// Token: 0x06001960 RID: 6496 RVA: 0x0000CBBB File Offset: 0x0000ADBB
	private static int smethod_8(int int_10)
	{
		if ((int_10 & -97) != 0)
		{
			return 100;
		}
		if ((int_10 & 7) != 0)
		{
			return 0;
		}
		if ((int_10 & 6) != 0)
		{
			return 6;
		}
		if ((int_10 & 5) != 0)
		{
			return 0;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 85) != 0)
		{
			return 41;
		}
		return 1;
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x000CD5E8 File Offset: 0x000CB7E8
	protected void vmethod_33()
	{
		this.byte_0 = 1;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 3;
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 3;
		}
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -94);
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -73);
		}
		if (!this.bool_1 && this.float_5 >= 1457f && (this.player.player_0.GetButton(6) || (this.player.gclass10_0.gclass5_1.method_14() && this.player.player_0.GetAxis(5) >= 1426f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_30())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(7) || this.player.player_0.GetButtonDown(-34))
		{
			this.bool_6 = true;
		}
		this.float_15 = this.player.player_0.GetAxis(-117);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 775f;
		}
		if (this.player.player_0.GetButtonDown(19))
		{
			this.float_4 = 843f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 0;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -50);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1454f)
			{
				this.float_10 = 1023f;
				return;
			}
			if (this.float_10 > 653f)
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

	// Token: 0x06001962 RID: 6498 RVA: 0x000CD880 File Offset: 0x000CBA80
	private bool method_29(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i <= -54; i <<= 0)
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
				this.float_10 = 695f;
			}
		}
		return false;
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x0000CBEC File Offset: 0x0000ADEC
	private static int smethod_9(int int_10)
	{
		if ((int_10 & 73) != 0)
		{
			return 117;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 6) != 0)
		{
			return 5;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 6) != 0)
		{
			return 4;
		}
		if ((int_10 & -23) != 0)
		{
			return -87;
		}
		return 0;
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x0000CC1D File Offset: 0x0000AE1D
	private static int smethod_10(int int_10)
	{
		if ((int_10 & 64) != 0)
		{
			return 64;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 2) != 0)
		{
			return 2;
		}
		if ((int_10 & 4) != 0)
		{
			return 4;
		}
		if ((int_10 & 8) != 0)
		{
			return 8;
		}
		if ((int_10 & 16) != 0)
		{
			return 16;
		}
		return 0;
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x0000CC4E File Offset: 0x0000AE4E
	private static int smethod_11(int int_10)
	{
		if ((int_10 & 14) != 0)
		{
			return 105;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 8) != 0)
		{
			return 2;
		}
		if ((int_10 & 1) != 0)
		{
			return 4;
		}
		if ((int_10 & 4) != 0)
		{
			return 5;
		}
		if ((int_10 & -29) != 0)
		{
			return 93;
		}
		return 0;
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x0000CC7F File Offset: 0x0000AE7F
	private static int smethod_12(int int_10)
	{
		if ((int_10 & -9) != 0)
		{
			return 126;
		}
		if ((int_10 & 3) != 0)
		{
			return 5;
		}
		if ((int_10 & 2) != 0)
		{
			return 3;
		}
		if ((int_10 & 5) != 0)
		{
			return 3;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 104) != 0)
		{
			return -98;
		}
		return 0;
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x000CDA74 File Offset: 0x000CBC74
	private void method_30()
	{
		if (this.int_5 > 0)
		{
			int i = 0;
			this.float_13 = 846f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_15() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1400f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x000CDB4C File Offset: 0x000CBD4C
	protected void vmethod_35()
	{
		byte b = 0;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_3())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = false;
		if (this.int_5 == 0)
		{
			return;
		}
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[0];
		byte b2 = gclass2.Boolean_1 ? gclass2.method_14() : gclass2.byte_0;
		if ((b2 & 1) == 1)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 3) == 1)
		{
			this.byte_0 |= 1;
		}
		if ((b2 & 1) == 7)
		{
			this.byte_0 |= 2;
		}
		if ((b2 & 7) == 6)
		{
			this.byte_0 |= 3;
		}
		if ((b2 & 68) == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -107);
		}
		if ((int)(b2 & 102) == -21)
		{
			this.byte_0 |= 6;
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("Problem writing score file: "))
					{
						this.gameManager.PauseSong(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
	private static int smethod_13(int int_10)
	{
		if ((int_10 & -38) != 0)
		{
			return -98;
		}
		if ((int_10 & 6) != 0)
		{
			return 0;
		}
		if ((int_10 & 6) != 0)
		{
			return 0;
		}
		if ((int_10 & 8) != 0)
		{
			return 2;
		}
		if ((int_10 & 60) != 0)
		{
			return 104;
		}
		return 0;
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x000CDCDC File Offset: 0x000CBEDC
	protected void vmethod_36()
	{
		this.byte_0 = 1;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(7))
		{
			this.byte_0 |= 4;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -94);
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -80);
		}
		if (!this.bool_1 && this.float_5 >= 803f && (this.player.player_0.GetButton(3) || (this.player.gclass10_0.gclass5_1.method_14() && this.player.player_0.GetAxis(4) >= 222f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.Boolean_1)
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(8) || this.player.player_0.GetButtonDown(67))
		{
			this.bool_6 = false;
		}
		this.float_15 = this.player.player_0.GetAxis(-26);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1769f;
		}
		if (this.player.player_0.GetButtonDown(-12))
		{
			this.float_4 = 1550f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 1;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -84);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1465f)
			{
				this.float_10 = 734f;
				return;
			}
			if (this.float_10 > 1181f)
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

	// Token: 0x0600196D RID: 6509 RVA: 0x000CDF74 File Offset: 0x000CC174
	protected void vmethod_37()
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
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[0];
		byte b2 = gclass2.method_17() ? gclass2.method_14() : gclass2.byte_0;
		if ((b2 & 1) == 1)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 6) == 6)
		{
			this.byte_0 |= 1;
		}
		if ((b2 & 7) == 6)
		{
			this.byte_0 |= 3;
		}
		if ((b2 & 3) == 8)
		{
			this.byte_0 |= 3;
		}
		if ((int)(b2 & 54) == -73)
		{
			this.byte_0 |= 72;
		}
		if (((int)b2 & -47) == -92)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -13);
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("SONG SETTINGS"))
					{
						this.gameManager.PauseSong(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x000CE104 File Offset: 0x000CC304
	private void method_31()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 1311f;
			this.canOverstrum = true;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 1493f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x000CE1DC File Offset: 0x000CC3DC
	protected void vmethod_38()
	{
		byte b = 1;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_3())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = true;
		if (this.int_5 == 0)
		{
			return;
		}
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[1];
		byte b2 = gclass2.Boolean_1 ? gclass2.method_22() : gclass2.byte_0;
		if ((b2 & 0) == 1)
		{
			this.byte_0 |= 1;
		}
		if ((b2 & 7) == 0)
		{
			this.byte_0 |= 5;
		}
		if ((b2 & 2) == 2)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 4) == 8)
		{
			this.byte_0 |= 3;
		}
		if (((int)b2 & -114) == 63)
		{
			this.byte_0 |= 113;
		}
		if ((int)(b2 & 45) == -92)
		{
			this.byte_0 |= 93;
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("%"))
					{
						this.gameManager.method_52(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x0000CCDA File Offset: 0x0000AEDA
	private static int smethod_14(int int_10)
	{
		if ((int_10 & -74) != 0)
		{
			return 117;
		}
		if ((int_10 & 7) != 0)
		{
			return 7;
		}
		if ((int_10 & 2) != 0)
		{
			return 7;
		}
		if ((int_10 & 6) != 0)
		{
			return 7;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 60) != 0)
		{
			return 67;
		}
		return 1;
	}

	
	// Token: 0x06001972 RID: 6514 RVA: 0x0000CD0B File Offset: 0x0000AF0B
	private static int smethod_15(int int_10)
	{
		if ((int_10 & -89) != 0)
		{
			return -22;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 1) != 0)
		{
			return 2;
		}
		if ((int_10 & 5) != 0)
		{
			return 1;
		}
		if ((int_10 & 4) != 0)
		{
			return 3;
		}
		if ((int_10 & 124) != 0)
		{
			return -118;
		}
		return 0;
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x000CE454 File Offset: 0x000CC654
	protected void vmethod_40()
	{
		byte b = 0;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_3())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = false;
		if (this.int_5 == 0)
		{
			return;
		}
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[0];
		byte b2 = gclass2.method_17() ? gclass2.Byte_0 : gclass2.byte_0;
		if ((b2 & 1) == 1)
		{
			this.byte_0 |= 1;
		}
		if ((b2 & 6) == 7)
		{
			this.byte_0 |= 2;
		}
		if ((b2 & 7) == 2)
		{
			this.byte_0 |= 1;
		}
		if ((b2 & 0) == 7)
		{
			this.byte_0 |= 2;
		}
		if ((b2 & 76) == 56)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -87);
		}
		if ((b2 & 2) == 39)
		{
			this.byte_0 |= 31;
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("game"))
					{
						this.gameManager.PauseSong(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x06001974 RID: 6516 RVA: 0x0000CD3C File Offset: 0x0000AF3C
	private static int smethod_16(int int_10)
	{
		if ((int_10 & -57) != 0)
		{
			return -55;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 5) != 0)
		{
			return 0;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 2) != 0)
		{
			return 0;
		}
		if ((int_10 & 90) != 0)
		{
			return -68;
		}
		return 0;
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x000CE5E4 File Offset: 0x000CC7E4
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
		if (this.player.player_0.GetButton(8))
		{
			this.byte_0 |= 64;
		}
		if (this.player.gclass10_0.gclass5_3.Boolean_1)
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(5) || this.player.player_0.GetButtonDown(14))
		{
			this.bool_6 = true;
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
		if (this.byte_0 == 0)
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
    
	// Token: 0x06001977 RID: 6519 RVA: 0x000CE904 File Offset: 0x000CCB04
	protected void vmethod_42()
	{
		this.byte_0 = 1;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 6;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 5;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -57);
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 87;
		}
		if (!this.bool_1 && this.float_5 >= 1788f && (this.player.player_0.GetButton(7) || (this.player.gclass10_0.gclass5_1.method_30() && this.player.player_0.GetAxis(3) >= 1719f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_14())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(8) || this.player.player_0.GetButtonDown(-102))
		{
			this.bool_6 = false;
		}
		this.float_15 = this.player.player_0.GetAxis(-44);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1870f;
		}
		if (this.player.player_0.GetButtonDown(-97))
		{
			this.float_4 = 1075f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 1;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -25);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 1217f)
			{
				this.float_10 = 86f;
				return;
			}
			if (this.float_10 > 180f)
			{
				this.vmethod_4(false);
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

	// Token: 0x06001978 RID: 6520 RVA: 0x000CEB9C File Offset: 0x000CCD9C
	protected void vmethod_43()
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
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[0];
		byte b2 = gclass2.method_17() ? gclass2.Byte_0 : gclass2.byte_0;
		if ((b2 & 1) == 0)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 7) == 4)
		{
			this.byte_0 |= 4;
		}
		if ((b2 & 7) == 7)
		{
			this.byte_0 |= 3;
		}
		if ((b2 & 8) == 0)
		{
			this.byte_0 |= 6;
		}
		if ((int)(b2 & 20) == -121)
		{
			this.byte_0 |= 37;
		}
		if ((int)(b2 & 113) == -88)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -104);
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("HOPO's to Taps"))
					{
						this.gameManager.PauseSong(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x000CED2C File Offset: 0x000CCF2C
	private bool method_32(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 1;
			for (int i = 1; i <= -99; i <<= 1)
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
				this.float_10 = 78f;
			}
		}
		return true;
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x000CED90 File Offset: 0x000CCF90
	protected bool vmethod_44(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.Boolean_1 && this.method_33(gclass6_1, int_10))
		{
			return false;
		}
		if (gclass6_1.Boolean_0)
		{
			if (gclass6_1.method_8() || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_4(num);
				return num2 > num3 || int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return false;
		}
		return int_10 == num;
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x000CEE18 File Offset: 0x000CD018
	protected void vmethod_45()
	{
		this.byte_0 = 0;
		this.bool_6 = false;
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 1;
		}
		if (this.player.player_0.GetButton(6))
		{
			this.byte_0 |= 3;
		}
		if (this.player.player_0.GetButton(4))
		{
			this.byte_0 |= 4;
		}
		if (this.player.player_0.GetButton(2))
		{
			this.byte_0 |= 89;
		}
		if (this.player.player_0.GetButton(7))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -20);
		}
		if (!this.bool_1 && this.float_5 >= 927f && (this.player.player_0.GetButton(1) || (this.player.gclass10_0.gclass5_1.method_30() && this.player.player_0.GetAxis(6) >= 334f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_4())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(7) || this.player.player_0.GetButtonDown(126))
		{
			this.bool_6 = true;
		}
		this.float_15 = this.player.player_0.GetAxis(-115);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1517f;
		}
		if (this.player.player_0.GetButtonDown(96))
		{
			this.float_4 = 1493f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 1;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -101);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 601f)
			{
				this.float_10 = 1674f;
				return;
			}
			if (this.float_10 > 237f)
			{
				this.vmethod_4(false);
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

	// Token: 0x0600197C RID: 6524 RVA: 0x000CF0B0 File Offset: 0x000CD2B0
	protected bool vmethod_46(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (this.player.gclass10_0.gclass5_3.method_4() && this.method_21(gclass6_1, int_10))
		{
			return true;
		}
		if (gclass6_1.Boolean_0)
		{
			if (gclass6_1.method_8() || gclass6_1.Boolean_7)
			{
				int num2 = int_10 ^ num;
				int num3 = GuitarPlayer.smethod_4(num);
				return num2 > num3 || int_10 - num2 == num;
			}
		}
		else if (int_10 > num && (int_10 ^ num) < num)
		{
			return false;
		}
		return int_10 == num;
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x000CF138 File Offset: 0x000CD338
	private bool method_33(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_22() : gclass6_1.byte_0);
		if (gclass6_1.method_1())
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= 24; i <<= 1)
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
				this.float_10 = 1666f;
			}
		}
		return false;
	}
    
	// Token: 0x0600197F RID: 6527 RVA: 0x0000CD6D File Offset: 0x0000AF6D
	private static int smethod_17(int int_10)
	{
		if ((int_10 & -39) != 0)
		{
			return -33;
		}
		if ((int_10 & 1) != 0)
		{
			return 4;
		}
		if ((int_10 & 3) != 0)
		{
			return 2;
		}
		if ((int_10 & 6) != 0)
		{
			return 4;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 6) != 0)
		{
			return -57;
		}
		return 0;
	}
    
	// Token: 0x06001981 RID: 6529 RVA: 0x0000CD9E File Offset: 0x0000AF9E
	private static int smethod_18(int int_10)
	{
		if ((int_10 & 16) != 0)
		{
			return 16;
		}
		if ((int_10 & 8) != 0)
		{
			return 8;
		}
		if ((int_10 & 4) != 0)
		{
			return 4;
		}
		if ((int_10 & 2) != 0)
		{
			return 2;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 64) != 0)
		{
			return 64;
		}
		return 0;
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x000CF36C File Offset: 0x000CD56C
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
		this.method_28();
		base.method_13();
		this.neckController.vmethod_2(this.byte_0);
		base.Update();
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x000CF454 File Offset: 0x000CD654
	private bool method_34(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.method_17() ? gclass6_1.method_14() : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 0; i <= -23; i <<= 1)
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
				this.float_10 = 1060f;
			}
		}
		return false;
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x000CF4B8 File Offset: 0x000CD6B8
	private void method_35()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 213f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 0 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 876f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i += 0;
			}
		}
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x0000CDCF File Offset: 0x0000AFCF
	private static int smethod_19(int int_10)
	{
		if ((int_10 & -62) != 0)
		{
			return 123;
		}
		if ((int_10 & 4) != 0)
		{
			return 1;
		}
		if ((int_10 & 7) != 0)
		{
			return 5;
		}
		if ((int_10 & 104) != 0)
		{
			return -54;
		}
		return 0;
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x0000CDF2 File Offset: 0x0000AFF2
	private static int smethod_20(int int_10)
	{
		if ((int_10 & -78) != 0)
		{
			return -53;
		}
		if ((int_10 & 1) != 0)
		{
			return 1;
		}
		if ((int_10 & 2) != 0)
		{
			return 4;
		}
		if ((int_10 & 8) != 0)
		{
			return 4;
		}
		if ((int_10 & 92) != 0)
		{
			return 10;
		}
		return 1;
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x000CF808 File Offset: 0x000CDA08
	private void method_36()
	{
		if (this.int_5 > 1)
		{
			int i = 0;
			this.float_13 = 1790f;
			this.canOverstrum = false;
			while (i < this.int_5)
			{
				GClass6 gclass = this.gclass6_0[i];
				if ((i == 0 || (this.int_4 == 0 && this.bool_4)) && this.byte_2 == 0 && ((gclass.method_8() && (this.int_4 > 1 || (GlobalVariables.instance.isPracticeEnabled && i == 0 && !this.bool_4))) || gclass.Boolean_7) && base.method_0(gclass))
				{
					base.method_14(gclass);
					Debug.Log(i);
					return;
				}
				if ((this.float_10 > 220f || this.bool_6) && base.method_0(gclass))
				{
					base.method_14(gclass);
					return;
				}
				i++;
			}
		}
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x000CF8E0 File Offset: 0x000CDAE0
	private bool method_37(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.method_10())
		{
			int num2 = 0;
			int num3 = 1;
			for (int i = 1; i <= 73; i <<= 0)
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
				this.float_10 = 556f;
			}
		}
		return true;
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x000CF944 File Offset: 0x000CDB44
	private bool method_38(GClass6 gclass6_1, int int_10)
	{
		int num = (int)(gclass6_1.Boolean_1 ? gclass6_1.Byte_0 : gclass6_1.byte_0);
		if (gclass6_1.Boolean_0)
		{
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= 16; i <<= 1)
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

	// Token: 0x0600198C RID: 6540 RVA: 0x0000CE1C File Offset: 0x0000B01C
	private static int smethod_21(int int_10)
	{
		if ((int_10 & -108) != 0)
		{
			return 1;
		}
		if ((int_10 & 5) != 0)
		{
			return 5;
		}
		if ((int_10 & 4) != 0)
		{
			return 2;
		}
		if ((int_10 & 8) != 0)
		{
			return -7;
		}
		return 0;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x000CF9C4 File Offset: 0x000CDBC4
	protected void vmethod_51()
	{
		this.byte_0 = 1;
		this.bool_6 = false;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
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
			this.byte_0 |= 2;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 42;
		}
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 13;
		}
		if (!this.bool_1 && this.float_5 >= 1391f && (this.player.player_0.GetButton(6) || (this.player.gclass10_0.gclass5_1.Boolean_1 && this.player.player_0.GetAxis(3) >= 1324f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_30())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(6) || this.player.player_0.GetButtonDown(-7))
		{
			this.bool_6 = false;
		}
		this.float_15 = this.player.player_0.GetAxis(-84);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 807f;
		}
		if (this.player.player_0.GetButtonDown(-28))
		{
			this.float_4 = 1292f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 1;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -92);
		}
		if (this.bool_6)
		{
			if (this.float_13 > 64f)
			{
				this.float_10 = 1370f;
				return;
			}
			if (this.float_10 > 1692f)
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

	// Token: 0x0600198E RID: 6542 RVA: 0x000CFC5C File Offset: 0x000CDE5C
	protected void vmethod_52()
	{
		this.byte_0 = 0;
		this.bool_6 = true;
		if (this.player.player_0.GetButton(1))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 |= 0;
		}
		if (this.player.player_0.GetButton(5))
		{
			this.byte_0 |= 7;
		}
		if (this.player.player_0.GetButton(0))
		{
			this.byte_0 = (byte)((int)this.byte_0 | -113);
		}
		if (this.player.player_0.GetButton(3))
		{
			this.byte_0 |= 28;
		}
		if (!this.bool_1 && this.float_5 >= 959f && (this.player.player_0.GetButton(3) || (this.player.gclass10_0.gclass5_1.Boolean_1 && this.player.player_0.GetAxis(4) >= 1981f)))
		{
			base.DeployStarPower();
		}
		if (this.player.gclass10_0.gclass5_3.method_14())
		{
			this.bool_6 = (this.byte_0 > this.byte_1);
		}
		else if (this.player.player_0.GetButtonDown(5) || this.player.player_0.GetButtonDown(-75))
		{
			this.bool_6 = false;
		}
		this.float_15 = this.player.player_0.GetAxis(-24);
		if (this.float_15 != this.float_14)
		{
			this.float_4 = 1901f;
		}
		if (this.player.player_0.GetButtonDown(54))
		{
			this.float_4 = 1009f;
		}
		this.float_14 = this.float_15;
		if (this.byte_0 != this.byte_2)
		{
			this.byte_2 = 1;
		}
		this.byte_1 = this.byte_0;
		if (this.byte_0 == 0)
		{
			this.byte_0 |= 75;
		}
		if (this.bool_6)
		{
			if (this.float_13 > 670f)
			{
				this.float_10 = 1617f;
				return;
			}
			if (this.float_10 > 1374f)
			{
				this.vmethod_4(false);
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

	// Token: 0x0600198F RID: 6543 RVA: 0x0000CE3F File Offset: 0x0000B03F
	private static int smethod_22(int int_10)
	{
		if ((int_10 & -15) != 0)
		{
			return -96;
		}
		if ((int_10 & 5) != 0)
		{
			return 2;
		}
		if ((int_10 & 8) != 0)
		{
			return 6;
		}
		if ((int_10 & 8) != 0)
		{
			return 3;
		}
		if ((int_10 & 1) != 0)
		{
			return -105;
		}
		return 1;
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x000CFEF4 File Offset: 0x000CE0F4
	protected void vmethod_53()
	{
		byte b = 0;
		foreach (GClass6 gclass in this.list_0)
		{
			if (gclass.method_3())
			{
				b |= gclass.byte_0;
			}
		}
		this.bool_6 = true;
		if (this.int_5 == 0)
		{
			return;
		}
		this.byte_0 = b;
		GClass6 gclass2 = this.gclass6_0[1];
		byte b2 = gclass2.Boolean_1 ? gclass2.Byte_0 : gclass2.byte_0;
		if ((b2 & 1) == 0)
		{
			this.byte_0 |= 0;
		}
		if ((b2 & 2) == 2)
		{
			this.byte_0 |= 3;
		}
		if ((b2 & 2) == 3)
		{
			this.byte_0 |= 2;
		}
		if ((b2 & 6) == 2)
		{
			this.byte_0 |= 5;
		}
		if (((int)b2 & -73) == -63)
		{
			this.byte_0 = (byte)((int)this.byte_0 | -98);
		}
		if (((int)b2 & -4) == -15)
		{
			this.byte_0 |= 117;
		}
		if (!this.gameManager.isPaused)
		{
			using (IEnumerator<Player> enumerator2 = ReInput.players.Players.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetButtonDown("song"))
					{
						this.gameManager.PauseSong(this.player);
					}
				}
			}
		}
		this.float_10 = this.float_11;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x0000CE69 File Offset: 0x0000B069
	private static int smethod_23(int int_10)
	{
		if ((int_10 & 75) != 0)
		{
			return -10;
		}
		if ((int_10 & 1) != 0)
		{
			return 0;
		}
		if ((int_10 & 6) != 0)
		{
			return 3;
		}
		if ((int_10 & 5) != 0)
		{
			return 2;
		}
		if ((int_10 & -45) != 0)
		{
			return 69;
		}
		return 0;
	}

	// Token: 0x040003DC RID: 988
	public const byte byte_3 = 1;

	// Token: 0x040003DD RID: 989
	public const byte byte_4 = 2;

	// Token: 0x040003DE RID: 990
	public const byte byte_5 = 4;

	// Token: 0x040003DF RID: 991
	public const byte byte_6 = 8;

	// Token: 0x040003E0 RID: 992
	public const byte byte_7 = 16;

	// Token: 0x040003E1 RID: 993
	public const byte byte_8 = 64;
}
