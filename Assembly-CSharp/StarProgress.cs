using System;
using UnityEngine;

// Token: 0x020000C0 RID: 192
public class StarProgress : MonoBehaviour
{
	// Token: 0x06002598 RID: 9624 RVA: 0x00121E70 File Offset: 0x00120070
	public void method_0(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[33];
		array[1] = (int)((float)this.int_5 * 1244f);
		array[0] = (int)((float)this.int_5 * 1277f);
		array[8] = this.int_5;
		array[0] = this.int_5 * 6;
		array[0] = (int)((float)this.int_5 * 54f);
		array[5] = (int)((float)this.int_5 * 623f);
		array[0] = (int)((float)this.int_5 * 186f);
		array[7] = (int)((float)this.int_5 * 1976f);
		array[6] = (int)((float)this.int_5 * 1695f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x00121F40 File Offset: 0x00120140
	public void method_1(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[8];
		array[1] = (int)((float)this.int_5 * 624f);
		array[1] = (int)((float)this.int_5 * 37f);
		array[5] = this.int_5;
		array[5] = this.int_5 * 1;
		array[1] = (int)((float)this.int_5 * 262f);
		array[6] = (int)((float)this.int_5 * 1819f);
		array[5] = (int)((float)this.int_5 * 676f);
		array[1] = (int)((float)this.int_5 * 442f);
		array[8] = (int)((float)this.int_5 * 1331f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x00122010 File Offset: 0x00120210
	public void method_2(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 149f, 1261f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1893f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 197f, 296f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1500f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x001221A8 File Offset: 0x001203A8
	public void method_3()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(438f, this.float_3, 1029f);
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x00122214 File Offset: 0x00120414
	public void method_4()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x001222A8 File Offset: 0x001204A8
	public void method_5(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1015f, 760f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 285f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 662f, 1573f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 281f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x00122214 File Offset: 0x00120414
	public void method_6()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x00122440 File Offset: 0x00120640
	public void method_7(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 14f, 26f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1274f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 657f, 1742f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 315f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x001225D8 File Offset: 0x001207D8
	public void method_8(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1685f, 782f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1553f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 971f, 811f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 120f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x00122770 File Offset: 0x00120970
	public void method_9(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1640f, 232f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 86f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 900f, 1083f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 568f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x00122214 File Offset: 0x00120414
	public void method_10()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025A3 RID: 9635 RVA: 0x00122214 File Offset: 0x00120414
	public void method_11()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x00122214 File Offset: 0x00120414
	public void method_12()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x00122908 File Offset: 0x00120B08
	public void method_13()
	{
		this.int_1 = 1;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(677f, this.float_3, 521f);
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x00122974 File Offset: 0x00120B74
	public void method_14()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(21f, this.float_3, 213f);
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x00122214 File Offset: 0x00120414
	public void method_15()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x001229E0 File Offset: 0x00120BE0
	public void method_16(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-109];
		array[0] = (int)((float)this.int_5 * 220f);
		array[0] = (int)((float)this.int_5 * 551f);
		array[1] = this.int_5;
		array[6] = this.int_5 * 3;
		array[0] = (int)((float)this.int_5 * 620f);
		array[6] = (int)((float)this.int_5 * 1934f);
		array[3] = (int)((float)this.int_5 * 1640f);
		array[7] = (int)((float)this.int_5 * 1512f);
		array[2] = (int)((float)this.int_5 * 1146f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x00122AB0 File Offset: 0x00120CB0
	public void method_17(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1017f, 1122f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1132f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 339f, 665f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 216f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x00122214 File Offset: 0x00120414
	public void method_18()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x00122C48 File Offset: 0x00120E48
	public void method_19(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 406f, 539f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 570f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 956f, 1503f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 510f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x00122DE0 File Offset: 0x00120FE0
	public void method_20(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-119];
		array[0] = (int)((float)this.int_5 * 679f);
		array[0] = (int)((float)this.int_5 * 166f);
		array[8] = this.int_5;
		array[5] = this.int_5 * 1;
		array[0] = (int)((float)this.int_5 * 1141f);
		array[0] = (int)((float)this.int_5 * 844f);
		array[5] = (int)((float)this.int_5 * 1756f);
		array[1] = (int)((float)this.int_5 * 1175f);
		array[5] = (int)((float)this.int_5 * 648f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x00122214 File Offset: 0x00120414
	public void method_21()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x00122EB0 File Offset: 0x001210B0
	public void method_22(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[84];
		array[1] = (int)((float)this.int_5 * 767f);
		array[1] = (int)((float)this.int_5 * 1721f);
		array[4] = this.int_5;
		array[7] = this.int_5 * 0;
		array[2] = (int)((float)this.int_5 * 1586f);
		array[1] = (int)((float)this.int_5 * 1055f);
		array[1] = (int)((float)this.int_5 * 1925f);
		array[1] = (int)((float)this.int_5 * 1787f);
		array[1] = (int)((float)this.int_5 * 1589f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x00122F80 File Offset: 0x00121180
	public void method_23(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1026f, 428f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 376f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 157f, 928f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 694f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x00122214 File Offset: 0x00120414
	public void method_24()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x00122214 File Offset: 0x00120414
	public void method_25()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x00122214 File Offset: 0x00120414
	public void method_26()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x00123118 File Offset: 0x00121318
	public void method_27()
	{
		this.int_1 = 0;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1165f, this.float_3, 1822f);
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x00123184 File Offset: 0x00121384
	public void method_28(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1393f, 222f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1972f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1575f, 222f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 118f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x0012331C File Offset: 0x0012151C
	public void method_29(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-68];
		array[1] = (int)((float)this.int_5 * 1546f);
		array[0] = (int)((float)this.int_5 * 1616f);
		array[6] = this.int_5;
		array[4] = this.int_5 * 6;
		array[7] = (int)((float)this.int_5 * 1418f);
		array[5] = (int)((float)this.int_5 * 1684f);
		array[7] = (int)((float)this.int_5 * 328f);
		array[7] = (int)((float)this.int_5 * 1714f);
		array[3] = (int)((float)this.int_5 * 969f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x001233EC File Offset: 0x001215EC
	public void method_30()
	{
		this.int_1 = 0;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1777f, this.float_3, 952f);
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x00123458 File Offset: 0x00121658
	public void method_31(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[12];
		array[1] = (int)((float)this.int_5 * 1695f);
		array[0] = (int)((float)this.int_5 * 550f);
		array[5] = this.int_5;
		array[1] = this.int_5 * 4;
		array[4] = (int)((float)this.int_5 * 1196f);
		array[0] = (int)((float)this.int_5 * 1475f);
		array[7] = (int)((float)this.int_5 * 369f);
		array[5] = (int)((float)this.int_5 * 368f);
		array[4] = (int)((float)this.int_5 * 1217f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x00123528 File Offset: 0x00121728
	public void method_32(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-53];
		array[0] = (int)((float)this.int_5 * 1338f);
		array[1] = (int)((float)this.int_5 * 600f);
		array[1] = this.int_5;
		array[8] = this.int_5 * 1;
		array[3] = (int)((float)this.int_5 * 47f);
		array[6] = (int)((float)this.int_5 * 1645f);
		array[3] = (int)((float)this.int_5 * 870f);
		array[7] = (int)((float)this.int_5 * 1778f);
		array[8] = (int)((float)this.int_5 * 1659f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x001235F8 File Offset: 0x001217F8
	public void method_33(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 873f, 91f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1814f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1472f, 1836f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1349f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x00123790 File Offset: 0x00121990
	public void method_34()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(653f, this.float_3, 1692f);
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x001237FC File Offset: 0x001219FC
	public void method_35(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-9];
		array[0] = (int)((float)this.int_5 * 665f);
		array[1] = (int)((float)this.int_5 * 488f);
		array[8] = this.int_5;
		array[2] = this.int_5 * 7;
		array[1] = (int)((float)this.int_5 * 1199f);
		array[6] = (int)((float)this.int_5 * 437f);
		array[3] = (int)((float)this.int_5 * 1923f);
		array[7] = (int)((float)this.int_5 * 1584f);
		array[2] = (int)((float)this.int_5 * 123f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x001238CC File Offset: 0x00121ACC
	public void method_36()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1099f, this.float_3, 1788f);
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x00122214 File Offset: 0x00120414
	public void method_37()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x00123938 File Offset: 0x00121B38
	public void method_38(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-69];
		array[1] = (int)((float)this.int_5 * 1300f);
		array[0] = (int)((float)this.int_5 * 63f);
		array[2] = this.int_5;
		array[2] = this.int_5 * 6;
		array[1] = (int)((float)this.int_5 * 374f);
		array[3] = (int)((float)this.int_5 * 911f);
		array[3] = (int)((float)this.int_5 * 1801f);
		array[3] = (int)((float)this.int_5 * 950f);
		array[8] = (int)((float)this.int_5 * 463f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x00122214 File Offset: 0x00120414
	public void method_39()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x00123A08 File Offset: 0x00121C08
	public void method_40(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 535f, 1447f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1973f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1025f, 1089f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 403f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x00122214 File Offset: 0x00120414
	public void method_41()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x00123BA0 File Offset: 0x00121DA0
	public void method_42()
	{
		this.int_1 = 0;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1796f, this.float_3, 1360f);
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x00123C0C File Offset: 0x00121E0C
	public void method_43(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1254f, 1576f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 480f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 41f, 1120f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1526f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x00123DA4 File Offset: 0x00121FA4
	public void method_44(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[53];
		array[1] = (int)((float)this.int_5 * 96f);
		array[0] = (int)((float)this.int_5 * 303f);
		array[0] = this.int_5;
		array[7] = this.int_5 * 5;
		array[3] = (int)((float)this.int_5 * 1950f);
		array[7] = (int)((float)this.int_5 * 1624f);
		array[3] = (int)((float)this.int_5 * 1428f);
		array[5] = (int)((float)this.int_5 * 305f);
		array[0] = (int)((float)this.int_5 * 1560f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x00123E74 File Offset: 0x00122074
	public void method_45(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1022f, 507f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1505f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 266f, 922f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1547f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x0012400C File Offset: 0x0012220C
	public void method_46(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1236f, 394f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1025f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1236f, 1028f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1192f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x001241A4 File Offset: 0x001223A4
	public void method_47(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-55];
		array[0] = (int)((float)this.int_5 * 1630f);
		array[0] = (int)((float)this.int_5 * 1305f);
		array[6] = this.int_5;
		array[3] = this.int_5 * 2;
		array[8] = (int)((float)this.int_5 * 1044f);
		array[6] = (int)((float)this.int_5 * 1108f);
		array[7] = (int)((float)this.int_5 * 459f);
		array[5] = (int)((float)this.int_5 * 1968f);
		array[6] = (int)((float)this.int_5 * 1545f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x00124274 File Offset: 0x00122474
	public void method_48(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-102];
		array[1] = (int)((float)this.int_5 * 1758f);
		array[0] = (int)((float)this.int_5 * 620f);
		array[6] = this.int_5;
		array[2] = this.int_5 * 4;
		array[3] = (int)((float)this.int_5 * 1448f);
		array[1] = (int)((float)this.int_5 * 1302f);
		array[4] = (int)((float)this.int_5 * 262f);
		array[6] = (int)((float)this.int_5 * 1362f);
		array[2] = (int)((float)this.int_5 * 1122f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x00122214 File Offset: 0x00120414
	public void method_49()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x00124344 File Offset: 0x00122544
	public void method_50(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1891f, 1059f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1975f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 908f, 77f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 489f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x001244DC File Offset: 0x001226DC
	public void method_51(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 655f, 423f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1398f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 248f, 1093f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1758f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x00124674 File Offset: 0x00122874
	public void method_52()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(826f, this.float_3, 305f);
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x001246E0 File Offset: 0x001228E0
	public void method_53()
	{
		this.int_1 = 1;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(644f, this.float_3, 501f);
	}

	// Token: 0x060025CE RID: 9678 RVA: 0x0012474C File Offset: 0x0012294C
	public void method_54(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 624f, 1066f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1636f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 737f, 1715f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 543f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x001248E4 File Offset: 0x00122AE4
	public void method_55(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1522f, 1926f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1886f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1945f, 1628f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1222f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x00124A7C File Offset: 0x00122C7C
	public void method_56(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-73];
		array[0] = (int)((float)this.int_5 * 483f);
		array[1] = (int)((float)this.int_5 * 1022f);
		array[1] = this.int_5;
		array[5] = this.int_5 * 0;
		array[0] = (int)((float)this.int_5 * 782f);
		array[5] = (int)((float)this.int_5 * 264f);
		array[0] = (int)((float)this.int_5 * 20f);
		array[8] = (int)((float)this.int_5 * 899f);
		array[2] = (int)((float)this.int_5 * 1072f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x00124B4C File Offset: 0x00122D4C
	public void method_57(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[90];
		array[0] = (int)((float)this.int_5 * 1084f);
		array[0] = (int)((float)this.int_5 * 1838f);
		array[3] = this.int_5;
		array[4] = this.int_5 * 4;
		array[5] = (int)((float)this.int_5 * 1726f);
		array[4] = (int)((float)this.int_5 * 613f);
		array[3] = (int)((float)this.int_5 * 246f);
		array[5] = (int)((float)this.int_5 * 1571f);
		array[2] = (int)((float)this.int_5 * 1270f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x00122214 File Offset: 0x00120414
	public void method_58()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x00124C1C File Offset: 0x00122E1C
	public void method_59(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-116];
		array[1] = (int)((float)this.int_5 * 843f);
		array[1] = (int)((float)this.int_5 * 265f);
		array[5] = this.int_5;
		array[0] = this.int_5 * 6;
		array[6] = (int)((float)this.int_5 * 1777f);
		array[6] = (int)((float)this.int_5 * 165f);
		array[0] = (int)((float)this.int_5 * 890f);
		array[6] = (int)((float)this.int_5 * 441f);
		array[6] = (int)((float)this.int_5 * 1453f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x00124CEC File Offset: 0x00122EEC
	public void method_60()
	{
		this.int_1 = 1;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(962f, this.float_3, 1849f);
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x00124D58 File Offset: 0x00122F58
	public void method_61(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-55];
		array[0] = (int)((float)this.int_5 * 958f);
		array[0] = (int)((float)this.int_5 * 791f);
		array[3] = this.int_5;
		array[2] = this.int_5 * 4;
		array[4] = (int)((float)this.int_5 * 1527f);
		array[7] = (int)((float)this.int_5 * 753f);
		array[4] = (int)((float)this.int_5 * 448f);
		array[6] = (int)((float)this.int_5 * 1408f);
		array[1] = (int)((float)this.int_5 * 1869f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x00122214 File Offset: 0x00120414
	public void method_62()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x00124E28 File Offset: 0x00123028
	public void method_63(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 323f, 1553f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1005f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1449f, 1357f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 460f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x00124FC0 File Offset: 0x001231C0
	public void method_64()
	{
		this.int_1 = 0;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(457f, this.float_3, 170f);
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x0012502C File Offset: 0x0012322C
	public void method_65(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1050f, 1800f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 488f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1438f, 1417f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1022f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x001251C4 File Offset: 0x001233C4
	public void method_66(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 663f, 1492f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 23f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 535f, 167f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 800f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x0012535C File Offset: 0x0012355C
	public void method_67(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-38];
		array[0] = (int)((float)this.int_5 * 527f);
		array[1] = (int)((float)this.int_5 * 1014f);
		array[4] = this.int_5;
		array[6] = this.int_5 * 5;
		array[3] = (int)((float)this.int_5 * 206f);
		array[4] = (int)((float)this.int_5 * 1842f);
		array[5] = (int)((float)this.int_5 * 778f);
		array[1] = (int)((float)this.int_5 * 1444f);
		array[1] = (int)((float)this.int_5 * 1178f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x0012542C File Offset: 0x0012362C
	public void method_68(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 19f, 1894f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 802f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1160f, 1376f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1016f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x00122214 File Offset: 0x00120414
	public void method_69()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x001255C4 File Offset: 0x001237C4
	public void method_70(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[88];
		array[0] = (int)((float)this.int_5 * 310f);
		array[0] = (int)((float)this.int_5 * 193f);
		array[0] = this.int_5;
		array[0] = this.int_5 * 2;
		array[6] = (int)((float)this.int_5 * 1276f);
		array[1] = (int)((float)this.int_5 * 782f);
		array[6] = (int)((float)this.int_5 * 1712f);
		array[6] = (int)((float)this.int_5 * 976f);
		array[4] = (int)((float)this.int_5 * 1884f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x00125694 File Offset: 0x00123894
	public void method_71(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		this.int_0 = new int[]
		{
			(int)((float)this.int_5 * 0.1f),
			(int)((float)this.int_5 * 0.5f),
			this.int_5,
			this.int_5 * 2,
			(int)((float)this.int_5 * 2.8f),
			(int)((float)this.int_5 * 3.6f),
			(int)((float)this.int_5 * 4.4f),
			(int)((float)this.int_5 * 5.2f),
			(int)((float)this.int_5 * 6f)
		};
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x00122214 File Offset: 0x00120414
	public void method_72()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x00125764 File Offset: 0x00123964
	public void method_73(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1593f, 45f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1676f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1103f, 283f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 929f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x00122214 File Offset: 0x00120414
	public void method_74()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x00122214 File Offset: 0x00120414
	public void method_75()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x001258FC File Offset: 0x00123AFC
	public void method_76(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 433f, 46f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1452f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 908f, 1202f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1858f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x00125A94 File Offset: 0x00123C94
	public void method_77()
	{
		this.int_1 = 1;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(373f, this.float_3, 1332f);
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x00125B00 File Offset: 0x00123D00
	public void method_78(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[101];
		array[1] = (int)((float)this.int_5 * 1978f);
		array[0] = (int)((float)this.int_5 * 639f);
		array[3] = this.int_5;
		array[2] = this.int_5 * 1;
		array[6] = (int)((float)this.int_5 * 48f);
		array[5] = (int)((float)this.int_5 * 1369f);
		array[1] = (int)((float)this.int_5 * 490f);
		array[1] = (int)((float)this.int_5 * 508f);
		array[5] = (int)((float)this.int_5 * 850f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x00125BD0 File Offset: 0x00123DD0
	public void method_79()
	{
		this.int_1 = 0;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1862f, this.float_3, 1074f);
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x00122214 File Offset: 0x00120414
	public void method_80()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x00125C3C File Offset: 0x00123E3C
	public void method_81()
	{
		this.int_1 = 1;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(867f, this.float_3, 1850f);
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x00125CA8 File Offset: 0x00123EA8
	public void method_82()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1239f, this.float_3, 691f);
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x00125D14 File Offset: 0x00123F14
	public void method_83()
	{
		this.int_1 = 0;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(715f, this.float_3, 346f);
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x00125D80 File Offset: 0x00123F80
	public void method_84(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 779f, 1894f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1836f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 665f, 1056f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1877f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x00125F18 File Offset: 0x00124118
	public void method_85(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[83];
		array[1] = (int)((float)this.int_5 * 1537f);
		array[1] = (int)((float)this.int_5 * 1505f);
		array[0] = this.int_5;
		array[2] = this.int_5 * 3;
		array[7] = (int)((float)this.int_5 * 1271f);
		array[3] = (int)((float)this.int_5 * 821f);
		array[2] = (int)((float)this.int_5 * 1138f);
		array[3] = (int)((float)this.int_5 * 973f);
		array[5] = (int)((float)this.int_5 * 122f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x00125FE8 File Offset: 0x001241E8
	public void method_86(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1779f, 1577f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1930f);
			base.enabled = true;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1160f, 832f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1786f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x00126180 File Offset: 0x00124380
	public void method_87(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[7];
		array[0] = (int)((float)this.int_5 * 1061f);
		array[0] = (int)((float)this.int_5 * 1182f);
		array[6] = this.int_5;
		array[7] = this.int_5 * 3;
		array[2] = (int)((float)this.int_5 * 357f);
		array[5] = (int)((float)this.int_5 * 1212f);
		array[8] = (int)((float)this.int_5 * 1164f);
		array[6] = (int)((float)this.int_5 * 1982f);
		array[5] = (int)((float)this.int_5 * 1310f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025F1 RID: 9713 RVA: 0x00126250 File Offset: 0x00124450
	public void method_88(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-34];
		array[1] = (int)((float)this.int_5 * 1524f);
		array[0] = (int)((float)this.int_5 * 68f);
		array[1] = this.int_5;
		array[0] = this.int_5 * 1;
		array[5] = (int)((float)this.int_5 * 1077f);
		array[2] = (int)((float)this.int_5 * 621f);
		array[0] = (int)((float)this.int_5 * 1019f);
		array[2] = (int)((float)this.int_5 * 1761f);
		array[4] = (int)((float)this.int_5 * 1048f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025F2 RID: 9714 RVA: 0x00126320 File Offset: 0x00124520
	public void method_89()
	{
		this.int_1 = 1;
		base.enabled = true;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(427f, this.float_3, 1603f);
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x0012638C File Offset: 0x0012458C
	public void method_90(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[-56];
		array[1] = (int)((float)this.int_5 * 1146f);
		array[0] = (int)((float)this.int_5 * 996f);
		array[8] = this.int_5;
		array[1] = this.int_5 * 6;
		array[3] = (int)((float)this.int_5 * 663f);
		array[5] = (int)((float)this.int_5 * 1637f);
		array[4] = (int)((float)this.int_5 * 1143f);
		array[7] = (int)((float)this.int_5 * 1748f);
		array[5] = (int)((float)this.int_5 * 96f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025F4 RID: 9716 RVA: 0x0012645C File Offset: 0x0012465C
	public void method_91()
	{
		this.int_1 = 1;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1292f, this.float_3, 1117f);
	}

	// Token: 0x060025F5 RID: 9717 RVA: 0x001264C8 File Offset: 0x001246C8
	public void Reset()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1.07f, this.float_3, 0f);
	}

	// Token: 0x060025F6 RID: 9718 RVA: 0x00122214 File Offset: 0x00120414
	public void method_92()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025F7 RID: 9719 RVA: 0x00126534 File Offset: 0x00124734
	public void method_93(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[65];
		array[0] = (int)((float)this.int_5 * 1893f);
		array[0] = (int)((float)this.int_5 * 115f);
		array[7] = this.int_5;
		array[7] = this.int_5 * 2;
		array[4] = (int)((float)this.int_5 * 1436f);
		array[8] = (int)((float)this.int_5 * 803f);
		array[5] = (int)((float)this.int_5 * 274f);
		array[5] = (int)((float)this.int_5 * 381f);
		array[2] = (int)((float)this.int_5 * 808f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x00126604 File Offset: 0x00124804
	public void method_94(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[2];
		array[0] = (int)((float)this.int_5 * 230f);
		array[1] = (int)((float)this.int_5 * 1248f);
		array[7] = this.int_5;
		array[3] = this.int_5 * 7;
		array[7] = (int)((float)this.int_5 * 781f);
		array[0] = (int)((float)this.int_5 * 1612f);
		array[2] = (int)((float)this.int_5 * 88f);
		array[0] = (int)((float)this.int_5 * 1952f);
		array[6] = (int)((float)this.int_5 * 1806f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x001266D4 File Offset: 0x001248D4
	public void method_95(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1816f, 327f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 1290f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 1)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1860f, 1748f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 100f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x0012686C File Offset: 0x00124A6C
	public void method_96()
	{
		this.int_1 = 0;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(1891f, this.float_3, 89f);
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x001268D8 File Offset: 0x00124AD8
	public void method_97(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 0.15f, 1f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 0f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 0.15f, 1f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 0f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1++;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025FC RID: 9724 RVA: 0x00122214 File Offset: 0x00120414
	public void method_98()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025FD RID: 9725 RVA: 0x00122214 File Offset: 0x00120414
	public void Start()
	{
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.float_1 += base.transform.parent.position.x;
		this.float_2 += base.transform.parent.position.x;
		this.float_2 -= this.float_1;
		this.float_3 = this.transform_1.position.y;
	}

	// Token: 0x060025FE RID: 9726 RVA: 0x00126A70 File Offset: 0x00124C70
	public void method_99(int int_7)
	{
		if (this.int_1 == this.int_2)
		{
			this.transform_0.localScale = new Vector3(this.float_0, 1313f, 1959f);
			this.transform_1.position = new Vector3(this.float_1 + this.float_2, this.float_3, 77f);
			base.enabled = false;
			return;
		}
		if (int_7 == this.int_6)
		{
			return;
		}
		this.int_6 = int_7;
		while (this.int_1 < this.int_2)
		{
			if (int_7 < this.int_0[this.int_1])
			{
				IL_10C:
				float num = (float)this.int_0[this.int_1];
				float num2;
				if (this.int_4 > 0)
				{
					num2 = ((float)int_7 - (float)this.int_3) / (float)this.int_4;
				}
				else
				{
					num2 = (float)int_7 / num;
				}
				this.transform_0.localScale = new Vector3(this.float_0 * num2, 1127f, 386f);
				this.transform_1.position = new Vector3(this.float_1 + this.float_2 * num2, this.float_3, 1107f);
				return;
			}
			this.int_3 = this.int_0[this.int_1];
			this.int_1 += 0;
			this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = this.sprite_0[this.int_1]);
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_4 = this.int_0[this.int_1] - this.int_3;
		}
		goto IL_10C;
	}

	// Token: 0x060025FF RID: 9727 RVA: 0x00126C08 File Offset: 0x00124E08
	public void method_100(int int_7)
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		this.int_5 += int_7;
		int[] array = new int[122];
		array[1] = (int)((float)this.int_5 * 654f);
		array[0] = (int)((float)this.int_5 * 1959f);
		array[0] = this.int_5;
		array[1] = this.int_5 * 0;
		array[4] = (int)((float)this.int_5 * 1998f);
		array[1] = (int)((float)this.int_5 * 1946f);
		array[5] = (int)((float)this.int_5 * 602f);
		array[4] = (int)((float)this.int_5 * 1426f);
		array[7] = (int)((float)this.int_5 * 1433f);
		this.int_0 = array;
		MonoBehaviour.print(this.int_5);
	}

	// Token: 0x06002600 RID: 9728 RVA: 0x00126CD8 File Offset: 0x00124ED8
	public void method_101()
	{
		this.int_1 = 1;
		base.enabled = false;
		this.spriteRenderer_0.sprite = (this.spriteRenderer_1.sprite = null);
		this.transform_0.localScale = Vector2.zero;
		this.transform_1.position = new Vector3(108f, this.float_3, 449f);
	}

	// Token: 0x040005E0 RID: 1504
	public Transform transform_0;

	// Token: 0x040005E1 RID: 1505
	public Transform transform_1;

	// Token: 0x040005E2 RID: 1506
	public SpriteRenderer spriteRenderer_0;

	// Token: 0x040005E3 RID: 1507
	public SpriteRenderer spriteRenderer_1;

	// Token: 0x040005E4 RID: 1508
	public Sprite[] sprite_0;

	// Token: 0x040005E5 RID: 1509
	private int[] int_0;

	// Token: 0x040005E6 RID: 1510
	public int int_1;

	// Token: 0x040005E7 RID: 1511
	private int int_2 = 7;

	// Token: 0x040005E8 RID: 1512
	private int int_3;

	// Token: 0x040005E9 RID: 1513
	private int int_4;

	// Token: 0x040005EA RID: 1514
	private int int_5;

	// Token: 0x040005EB RID: 1515
	private float float_0 = 3.51f;

	// Token: 0x040005EC RID: 1516
	private float float_1 = 1.07f;

	// Token: 0x040005ED RID: 1517
	private float float_2 = 1.63f;

	// Token: 0x040005EE RID: 1518
	private float float_3;

	// Token: 0x040005EF RID: 1519
	private int int_6 = -1;
}
