using System;
using UnityEngine;

// Token: 0x0200007E RID: 126
public class ComboColor : MonoBehaviour
{
	// Token: 0x0600177E RID: 6014 RVA: 0x000BCFBC File Offset: 0x000BB1BC
	public void method_0(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -84 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 103;
		}
		else
		{
			num2 = int_2 % 89;
			if (num > 1 && num2 == 0)
			{
				num2 = 100;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 4;
			}
			else
			{
				num *= 3;
			}
			this.color_2 = this.color_0[1];
			this.color_3 = this.color_1[1];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x0000C6F1 File Offset: 0x0000A8F1
	private void method_1()
	{
		this.method_60(0);
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x000BD0F0 File Offset: 0x000BB2F0
	public void method_2(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 19 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -75;
		}
		else
		{
			num2 = int_2 % 72;
			if (num > 0 && num2 == 0)
			{
				num2 = -76;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 6;
			}
			else
			{
				num *= 0;
			}
			this.color_2 = this.color_0[3];
			this.color_3 = this.color_1[2];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x000BD224 File Offset: 0x000BB424
	public void method_3(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -84 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 6;
		}
		else
		{
			num2 = int_2 % -18;
			if (num > 0 && num2 == 0)
			{
				num2 = -112;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 5;
			}
			else
			{
				num *= 3;
			}
			this.color_2 = this.color_0[1];
			this.color_3 = this.color_1[7];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x000BD358 File Offset: 0x000BB558
	public void method_4(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -53 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 121;
		}
		else
		{
			num2 = int_2 % -36;
			if (num > 1 && num2 == 0)
			{
				num2 = -117;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 5;
			}
			else
			{
				num *= 4;
			}
			this.color_2 = this.color_0[0];
			this.color_3 = this.color_1[2];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x0000C709 File Offset: 0x0000A909
	private void method_5()
	{
		this.method_2(1);
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x0000C712 File Offset: 0x0000A912
	private void method_6()
	{
		this.method_75(1);
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x000BD48C File Offset: 0x000BB68C
	public void method_7(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 31 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 21;
		}
		else
		{
			num2 = int_2 % 8;
			if (num > 1 && num2 == 0)
			{
				num2 = 0;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 7;
			}
			else
			{
				num *= 0;
			}
			this.color_2 = this.color_0[3];
			this.color_3 = this.color_1[3];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x0000C71B File Offset: 0x0000A91B
	public void method_8()
	{
		this.bool_0 = true;
		this.method_64(this.int_0);
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x0000C730 File Offset: 0x0000A930
	private void method_9()
	{
		this.method_2(0);
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x000BD5C0 File Offset: 0x000BB7C0
	public void method_10(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -41 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 20;
		}
		else
		{
			num2 = int_2 % -89;
			if (num > 1 && num2 == 0)
			{
				num2 = -45;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 7;
			}
			else
			{
				num *= 0;
			}
			this.color_2 = this.color_0[6];
			this.color_3 = this.color_1[8];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x000BD6F4 File Offset: 0x000BB8F4
	public void method_11(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -9 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 99;
		}
		else
		{
			num2 = int_2 % 15;
			if (num > 1 && num2 == 0)
			{
				num2 = -42;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 0;
			}
			else
			{
				num *= 2;
			}
			this.color_2 = this.color_0[6];
			this.color_3 = this.color_1[2];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x000BD828 File Offset: 0x000BBA28
	public void method_12(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -64 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -50;
		}
		else
		{
			num2 = int_2 % -118;
			if (num > 0 && num2 == 0)
			{
				num2 = -11;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 5;
			}
			else
			{
				num *= 4;
			}
			this.color_2 = this.color_0[6];
			this.color_3 = this.color_1[2];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x0000C739 File Offset: 0x0000A939
	public void method_13()
	{
		this.bool_0 = true;
		this.method_25(this.int_0);
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x000BD95C File Offset: 0x000BBB5C
	public void method_14(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 66 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 79;
		}
		else
		{
			num2 = int_2 % -29;
			if (num > 0 && num2 == 0)
			{
				num2 = -24;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 1;
			}
			else
			{
				num *= 8;
			}
			this.color_2 = this.color_0[3];
			this.color_3 = this.color_1[0];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x0000C74E File Offset: 0x0000A94E
	public void method_15()
	{
		this.bool_0 = false;
		this.method_53(this.int_0);
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x0000C763 File Offset: 0x0000A963
	private void method_16()
	{
		this.method_57(0);
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x000BDA90 File Offset: 0x000BBC90
	public void method_17(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -29 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -73;
		}
		else
		{
			num2 = int_2 % 56;
			if (num > 0 && num2 == 0)
			{
				num2 = -80;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 1;
			}
			else
			{
				num *= 6;
			}
			this.color_2 = this.color_0[2];
			this.color_3 = this.color_1[7];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x0000C76C File Offset: 0x0000A96C
	public void method_18()
	{
		this.bool_0 = true;
		this.method_21(this.int_0);
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x0000C781 File Offset: 0x0000A981
	public void method_19()
	{
		this.bool_0 = true;
		this.method_50(this.int_0);
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x0000C796 File Offset: 0x0000A996
	public void method_20()
	{
		this.bool_0 = true;
		this.method_4(this.int_0);
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x000BDBC4 File Offset: 0x000BBDC4
	public void method_21(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -34 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 50;
		}
		else
		{
			num2 = int_2 % -93;
			if (num > 1 && num2 == 0)
			{
				num2 = -41;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 8;
			}
			else
			{
				num *= 6;
			}
			this.color_2 = this.color_0[7];
			this.color_3 = this.color_1[5];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x0000C7AB File Offset: 0x0000A9AB
	public void method_22()
	{
		this.bool_0 = false;
		this.method_3(this.int_0);
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x000BDCF8 File Offset: 0x000BBEF8
	public void method_23(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 87 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 19;
		}
		else
		{
			num2 = int_2 % -55;
			if (num > 1 && num2 == 0)
			{
				num2 = -27;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 4;
			}
			else
			{
				num *= 7;
			}
			this.color_2 = this.color_0[5];
			this.color_3 = this.color_1[3];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
	public void method_24()
	{
		this.bool_0 = false;
		this.method_25(this.int_0);
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x000BDE2C File Offset: 0x000BC02C
	public void method_25(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -109 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 4;
		}
		else
		{
			num2 = int_2 % -20;
			if (num > 1 && num2 == 0)
			{
				num2 = -19;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 8;
			}
			else
			{
				num *= 2;
			}
			this.color_2 = this.color_0[5];
			this.color_3 = this.color_1[7];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x0000C6F1 File Offset: 0x0000A8F1
	private void method_26()
	{
		this.method_60(0);
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x0000C7D5 File Offset: 0x0000A9D5
	public void method_27()
	{
		this.bool_0 = false;
		this.method_2(this.int_0);
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x0000C7EA File Offset: 0x0000A9EA
	private void method_28()
	{
		this.method_67(0);
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x0000C7F3 File Offset: 0x0000A9F3
	private void method_29()
	{
		this.method_21(0);
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x0000C7FC File Offset: 0x0000A9FC
	private void method_30()
	{
		this.method_11(1);
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x0000C805 File Offset: 0x0000AA05
	private void method_31()
	{
		this.method_0(0);
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x0000C712 File Offset: 0x0000A912
	private void method_32()
	{
		this.method_75(1);
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x0000C80E File Offset: 0x0000AA0E
	public void method_33()
	{
		this.bool_0 = true;
		this.method_81(this.int_0);
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x0000C7AB File Offset: 0x0000A9AB
	public void method_34()
	{
		this.bool_0 = false;
		this.method_3(this.int_0);
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x0000C823 File Offset: 0x0000AA23
	public void method_35()
	{
		this.bool_0 = false;
		this.method_47(this.int_0);
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x0000C838 File Offset: 0x0000AA38
	public void method_36()
	{
		this.bool_0 = true;
		this.method_23(this.int_0);
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x0000C84D File Offset: 0x0000AA4D
	private void Start()
	{
		this.method_53(0);
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x0000C805 File Offset: 0x0000AA05
	private void method_37()
	{
		this.method_0(0);
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x0000C856 File Offset: 0x0000AA56
	public void method_38()
	{
		this.bool_0 = false;
		this.method_23(this.int_0);
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x000BDF60 File Offset: 0x000BC160
	public void method_39(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 85 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 11;
		}
		else
		{
			num2 = int_2 % -46;
			if (num > 0 && num2 == 0)
			{
				num2 = 66;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 8;
			}
			else
			{
				num *= 5;
			}
			this.color_2 = this.color_0[8];
			this.color_3 = this.color_1[8];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x0000C86B File Offset: 0x0000AA6B
	private void method_40()
	{
		this.method_64(1);
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x0000C874 File Offset: 0x0000AA74
	private void method_41()
	{
		this.method_25(1);
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x0000C87D File Offset: 0x0000AA7D
	public void method_42()
	{
		this.bool_0 = false;
		this.method_17(this.int_0);
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x0000C856 File Offset: 0x0000AA56
	public void method_43()
	{
		this.bool_0 = false;
		this.method_23(this.int_0);
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x0000C892 File Offset: 0x0000AA92
	public void method_44()
	{
		this.bool_0 = true;
		this.method_39(this.int_0);
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x0000C8A7 File Offset: 0x0000AAA7
	public void method_45()
	{
		this.bool_0 = false;
		this.method_0(this.int_0);
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x000BE094 File Offset: 0x000BC294
	public void method_46(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -58 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 48;
		}
		else
		{
			num2 = int_2 % -20;
			if (num > 1 && num2 == 0)
			{
				num2 = -116;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 1;
			}
			else
			{
				num *= 7;
			}
			this.color_2 = this.color_0[1];
			this.color_3 = this.color_1[4];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x000BE1C8 File Offset: 0x000BC3C8
	public void method_47(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -36 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -47;
		}
		else
		{
			num2 = int_2 % -117;
			if (num > 0 && num2 == 0)
			{
				num2 = 115;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 5;
			}
			else
			{
				num *= 4;
			}
			this.color_2 = this.color_0[2];
			this.color_3 = this.color_1[6];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x0000C8BC File Offset: 0x0000AABC
	private void method_48()
	{
		this.method_3(1);
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x0000C712 File Offset: 0x0000A912
	private void method_49()
	{
		this.method_75(1);
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x000BE2FC File Offset: 0x000BC4FC
	public void method_50(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -10 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 115;
		}
		else
		{
			num2 = int_2 % 124;
			if (num > 1 && num2 == 0)
			{
				num2 = 52;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 8;
			}
			else
			{
				num *= 8;
			}
			this.color_2 = this.color_0[0];
			this.color_3 = this.color_1[3];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x0000C781 File Offset: 0x0000A981
	public void method_51()
	{
		this.bool_0 = true;
		this.method_50(this.int_0);
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x0000C8C5 File Offset: 0x0000AAC5
	public void method_52()
	{
		this.bool_0 = false;
		this.method_11(this.int_0);
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x000BE430 File Offset: 0x000BC630
	public void method_53(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 10 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 10;
		}
		else
		{
			num2 = int_2 % 10;
			if (num > 1 && num2 == 0)
			{
				num2 = 10;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 2;
			}
			else
			{
				num *= 2;
			}
			this.color_2 = this.color_0[5];
			this.color_3 = this.color_1[5];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x0000C8DA File Offset: 0x0000AADA
	public void method_54()
	{
		this.bool_0 = false;
		this.method_10(this.int_0);
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x0000C8C5 File Offset: 0x0000AAC5
	public void method_55()
	{
		this.bool_0 = false;
		this.method_11(this.int_0);
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x0000C8EF File Offset: 0x0000AAEF
	private void method_56()
	{
		this.method_7(1);
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x000BE564 File Offset: 0x000BC764
	public void method_57(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 75 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 92;
		}
		else
		{
			num2 = int_2 % -92;
			if (num > 1 && num2 == 0)
			{
				num2 = -87;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 6;
			}
			else
			{
				num *= 0;
			}
			this.color_2 = this.color_0[6];
			this.color_3 = this.color_1[8];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x0000C71B File Offset: 0x0000A91B
	public void method_58()
	{
		this.bool_0 = true;
		this.method_64(this.int_0);
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x0000C823 File Offset: 0x0000AA23
	public void method_59()
	{
		this.bool_0 = false;
		this.method_47(this.int_0);
	}

	// Token: 0x060017BC RID: 6076 RVA: 0x000BE698 File Offset: 0x000BC898
	public void method_60(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -79 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -34;
		}
		else
		{
			num2 = int_2 % 51;
			if (num > 1 && num2 == 0)
			{
				num2 = 88;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 7;
			}
			else
			{
				num *= 3;
			}
			this.color_2 = this.color_0[6];
			this.color_3 = this.color_1[4];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017BD RID: 6077 RVA: 0x0000C763 File Offset: 0x0000A963
	private void method_61()
	{
		this.method_57(0);
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
	public void method_62()
	{
		this.bool_0 = true;
		this.method_2(this.int_0);
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x000BE7CC File Offset: 0x000BC9CC
	public void method_63(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 9 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -22;
		}
		else
		{
			num2 = int_2 % -87;
			if (num > 0 && num2 == 0)
			{
				num2 = 65;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 5;
			}
			else
			{
				num *= 4;
			}
			this.color_2 = this.color_0[0];
			this.color_3 = this.color_1[1];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017C0 RID: 6080 RVA: 0x000BE900 File Offset: 0x000BCB00
	public void method_64(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / -46 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -37;
		}
		else
		{
			num2 = int_2 % 8;
			if (num > 1 && num2 == 0)
			{
				num2 = -85;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 8;
			}
			else
			{
				num *= 8;
			}
			this.color_2 = this.color_0[6];
			this.color_3 = this.color_1[5];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x0000C8DA File Offset: 0x0000AADA
	public void method_65()
	{
		this.bool_0 = false;
		this.method_10(this.int_0);
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
	public void method_66()
	{
		this.bool_0 = false;
		this.method_25(this.int_0);
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x000BEA34 File Offset: 0x000BCC34
	public void method_67(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 1 + 1;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = 113;
		}
		else
		{
			num2 = int_2 % 45;
			if (num > 1 && num2 == 0)
			{
				num2 = -106;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 1;
			}
			else
			{
				num *= 4;
			}
			this.color_2 = this.color_0[0];
			this.color_3 = this.color_1[3];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 1)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x0000C90D File Offset: 0x0000AB0D
	public void method_68()
	{
		this.bool_0 = true;
		this.method_0(this.int_0);
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x0000C7FC File Offset: 0x0000A9FC
	private void method_69()
	{
		this.method_11(1);
	}

	// Token: 0x060017C6 RID: 6086 RVA: 0x0000C76C File Offset: 0x0000A96C
	public void method_70()
	{
		this.bool_0 = true;
		this.method_21(this.int_0);
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x0000C922 File Offset: 0x0000AB22
	public void method_71()
	{
		this.bool_0 = true;
		this.method_3(this.int_0);
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x0000C8EF File Offset: 0x0000AAEF
	private void method_72()
	{
		this.method_7(1);
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x0000C937 File Offset: 0x0000AB37
	public void method_73()
	{
		this.bool_0 = true;
		this.method_53(this.int_0);
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x0000C94C File Offset: 0x0000AB4C
	private void method_74()
	{
		this.method_23(0);
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x000BEB68 File Offset: 0x000BCD68
	public void method_75(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 17 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -114;
		}
		else
		{
			num2 = int_2 % 21;
			if (num > 1 && num2 == 0)
			{
				num2 = -117;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 3;
			}
			else
			{
				num *= 3;
			}
			this.color_2 = this.color_0[5];
			this.color_3 = this.color_1[1];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x0000C955 File Offset: 0x0000AB55
	private void method_76()
	{
		this.method_17(0);
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
	public void method_77()
	{
		this.bool_0 = true;
		this.method_2(this.int_0);
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x0000C74E File Offset: 0x0000A94E
	public void method_78()
	{
		this.bool_0 = false;
		this.method_53(this.int_0);
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x0000C8BC File Offset: 0x0000AABC
	private void method_79()
	{
		this.method_3(1);
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x0000C90D File Offset: 0x0000AB0D
	public void method_80()
	{
		this.bool_0 = true;
		this.method_0(this.int_0);
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x000BEC9C File Offset: 0x000BCE9C
	public void method_81(int int_2)
	{
		this.int_0 = int_2;
		int num = int_2 / 81 + 0;
		int num2;
		if (num >= this.int_1)
		{
			num = this.int_1;
			num2 = -51;
		}
		else
		{
			num2 = int_2 % 16;
			if (num > 0 && num2 == 0)
			{
				num2 = 16;
			}
		}
		if (this.bool_0)
		{
			if (num == 0)
			{
				num = 2;
			}
			else
			{
				num *= 7;
			}
			this.color_2 = this.color_0[6];
			this.color_3 = this.color_1[5];
		}
		else
		{
			this.color_2 = this.color_0[num];
			this.color_3 = this.color_1[num];
		}
		this.spriteRenderer_1.sprite = this.sprite_0[num2];
		if (num > 0)
		{
			this.spriteRenderer_2.sprite = this.sprite_1[num];
			this.spriteRenderer_3.sprite = this.sprite_2[num];
		}
		else
		{
			this.spriteRenderer_2.sprite = null;
			this.spriteRenderer_3.sprite = null;
		}
		this.spriteRenderer_2.color = (this.spriteRenderer_1.color = (this.spriteRenderer_1.color = this.color_2));
		this.spriteRenderer_3.color = this.color_3;
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x0000C95E File Offset: 0x0000AB5E
	public void method_82()
	{
		this.bool_0 = true;
		this.method_47(this.int_0);
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x0000C973 File Offset: 0x0000AB73
	public void method_83()
	{
		this.bool_0 = false;
		this.method_39(this.int_0);
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x0000C988 File Offset: 0x0000AB88
	public void method_84()
	{
		this.bool_0 = false;
		this.method_57(this.int_0);
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x0000C99D File Offset: 0x0000AB9D
	private void method_85()
	{
		this.method_57(1);
	}

	// Token: 0x040003AA RID: 938
	public SpriteRenderer spriteRenderer_0;

	// Token: 0x040003AB RID: 939
	public SpriteRenderer spriteRenderer_1;

	// Token: 0x040003AC RID: 940
	public SpriteRenderer spriteRenderer_2;

	// Token: 0x040003AD RID: 941
	public SpriteRenderer spriteRenderer_3;

	// Token: 0x040003AE RID: 942
	public Sprite[] sprite_0;

	// Token: 0x040003AF RID: 943
	public Sprite[] sprite_1;

	// Token: 0x040003B0 RID: 944
	public Sprite[] sprite_2;

	// Token: 0x040003B1 RID: 945
	public Color[] color_0;

	// Token: 0x040003B2 RID: 946
	public Color[] color_1;

	// Token: 0x040003B3 RID: 947
	private Color color_2;

	// Token: 0x040003B4 RID: 948
	private Color color_3;

	// Token: 0x040003B5 RID: 949
	private bool bool_0;

	// Token: 0x040003B6 RID: 950
	private int int_0;

	// Token: 0x040003B7 RID: 951
	private int int_1 = 4;
}
