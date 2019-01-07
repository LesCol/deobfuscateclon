using System;
using System.Text;
using UnityEngine;

// Token: 0x020000BF RID: 191
public class SpriteFont : MonoBehaviour
{
	// Token: 0x06002559 RID: 9561 RVA: 0x00010805 File Offset: 0x0000EA05
	private void method_0()
	{
		this.stringBuilder_0 = new StringBuilder(1, 74);
		this.method_19(1);
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x0011FE60 File Offset: 0x0011E060
	public void method_1(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 2 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[98];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 'J')];
				num--;
			}
		}
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x0011FF38 File Offset: 0x0011E138
	public void method_2(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 0 || i == 3))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[63];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '?')];
				num -= 0;
			}
		}
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x0001081C File Offset: 0x0000EA1C
	private void method_3()
	{
		this.stringBuilder_0 = new StringBuilder(1, 48);
		this.method_47(0);
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x00010833 File Offset: 0x0000EA33
	private void method_4()
	{
		this.stringBuilder_0 = new StringBuilder(0, 90);
		this.method_14(1);
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x00120010 File Offset: 0x0011E210
	public void method_5(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 0 || i == 5))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-18];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -30];
				num -= 0;
			}
		}
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x0001084A File Offset: 0x0000EA4A
	private void method_6()
	{
		this.stringBuilder_0 = new StringBuilder(0, -111);
		this.method_11(0);
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x00010861 File Offset: 0x0000EA61
	private void method_7()
	{
		this.stringBuilder_0 = new StringBuilder(1, -19);
		this.method_45(1);
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x001200E8 File Offset: 0x0011E2E8
	public void method_8(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 7 || i == 8))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[77];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -36];
				num--;
			}
		}
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x00010878 File Offset: 0x0000EA78
	private void method_9()
	{
		this.stringBuilder_0 = new StringBuilder(0, -79);
		this.method_1(1);
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x0001088F File Offset: 0x0000EA8F
	private void method_10()
	{
		this.stringBuilder_0 = new StringBuilder(1, 28);
		this.method_57(1);
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x001201C0 File Offset: 0x0011E3C0
	public void method_11(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 1; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 1 || i == 3))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[117];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -46];
				num--;
			}
		}
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000108A6 File Offset: 0x0000EAA6
	private void method_12()
	{
		this.stringBuilder_0 = new StringBuilder(1, -60);
		this.method_5(1);
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000108BD File Offset: 0x0000EABD
	private void method_13()
	{
		this.stringBuilder_0 = new StringBuilder(0, 65);
		this.method_45(1);
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x00120298 File Offset: 0x0011E498
	public void method_14(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 5 || i == 8))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-88];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '+')];
				num -= 0;
			}
		}
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x00120370 File Offset: 0x0011E570
	public void method_15(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 3 || i == 8))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[27];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -7];
				num -= 0;
			}
		}
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x00120448 File Offset: 0x0011E648
	public void method_16(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 3 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[10];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '0')];
				num--;
			}
		}
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000108D4 File Offset: 0x0000EAD4
	private void method_17()
	{
		this.stringBuilder_0 = new StringBuilder(1, -35);
		this.method_28(0);
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x000108EB File Offset: 0x0000EAEB
	private void method_18()
	{
		this.stringBuilder_0 = new StringBuilder(1, 38);
		this.method_5(0);
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x00120520 File Offset: 0x0011E720
	public void method_19(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 3 || i == 0))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-27];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -78];
				num -= 0;
			}
		}
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x00010902 File Offset: 0x0000EB02
	private void method_20()
	{
		this.stringBuilder_0 = new StringBuilder(1, 45);
		this.method_49(0);
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x001205F8 File Offset: 0x0011E7F8
	public void method_21(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 2 || i == 6))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[82];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -1];
				num -= 0;
			}
		}
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x001206D0 File Offset: 0x0011E8D0
	public void method_22(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 4))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-47];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\n')];
				num -= 0;
			}
		}
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x001207A8 File Offset: 0x0011E9A8
	public void method_23(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 8))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[29];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -128];
				num -= 0;
			}
		}
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x00120880 File Offset: 0x0011EA80
	public void method_24(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 8 || i == 0))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-105];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 'H')];
				num--;
			}
		}
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x00120958 File Offset: 0x0011EB58
	public void method_25(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 5 || i == 8))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-23];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -97];
				num -= 0;
			}
		}
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x00120A30 File Offset: 0x0011EC30
	public void method_26(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 4))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[123];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\u0015')];
				num--;
			}
		}
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x00010919 File Offset: 0x0000EB19
	private void method_27()
	{
		this.stringBuilder_0 = new StringBuilder(1, 116);
		this.method_40(1);
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x00010930 File Offset: 0x0000EB30
	private void Start()
	{
		this.stringBuilder_0 = new StringBuilder(0, 20);
		this.method_16(0);
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x00120B08 File Offset: 0x0011ED08
	public void method_28(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 2))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[123];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 'L')];
				num -= 0;
			}
		}
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x00010947 File Offset: 0x0000EB47
	private void method_29()
	{
		this.stringBuilder_0 = new StringBuilder(1, -52);
		this.method_1(1);
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x00120BE0 File Offset: 0x0011EDE0
	public void method_30(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 8 || i == 0))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-128];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -28];
				num -= 0;
			}
		}
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x00120CB8 File Offset: 0x0011EEB8
	public void method_31(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 8 || i == 6))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-124];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -68];
				num--;
			}
		}
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x0001095E File Offset: 0x0000EB5E
	private void method_32()
	{
		this.stringBuilder_0 = new StringBuilder(0, 31);
		this.method_53(1);
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x00010975 File Offset: 0x0000EB75
	private void method_33()
	{
		this.stringBuilder_0 = new StringBuilder(1, -121);
		this.method_14(0);
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x00120D90 File Offset: 0x0011EF90
	public void method_34(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 1 || i == 8))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[46];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 's')];
				num--;
			}
		}
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x0001098C File Offset: 0x0000EB8C
	private void method_35()
	{
		this.stringBuilder_0 = new StringBuilder(1, 125);
		this.method_57(0);
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x000109A3 File Offset: 0x0000EBA3
	private void method_36()
	{
		this.stringBuilder_0 = new StringBuilder(0, -13);
		this.method_15(0);
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x00120E68 File Offset: 0x0011F068
	public void method_37(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 5 || i == 3))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[35];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 'h')];
				num--;
			}
		}
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x00120F40 File Offset: 0x0011F140
	public void method_38(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 5 || i == 5))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[99];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\u0016')];
				num -= 0;
			}
		}
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x000109C9 File Offset: 0x0000EBC9
	private void method_39()
	{
		this.stringBuilder_0 = new StringBuilder(0, 15);
		this.method_41(0);
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x00121018 File Offset: 0x0011F218
	public void method_40(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 0))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-28];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -83];
				num--;
			}
		}
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x001210F0 File Offset: 0x0011F2F0
	public void method_41(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[97];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '^')];
				num--;
			}
		}
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x001211C8 File Offset: 0x0011F3C8
	public void method_42(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[127];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 'a')];
				num--;
			}
		}
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x001212A0 File Offset: 0x0011F4A0
	public void method_43(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 5 || i == 0))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[97];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -93];
				num--;
			}
		}
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x00121378 File Offset: 0x0011F578
	public void method_44(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 0 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[70];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\u0003')];
				num--;
			}
		}
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x00121450 File Offset: 0x0011F650
	public void method_45(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 5 || i == 0))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-107];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\u0002')];
				num -= 0;
			}
		}
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x00121528 File Offset: 0x0011F728
	public void method_46(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 7 || i == 1))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[4];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -27];
				num -= 0;
			}
		}
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x00121600 File Offset: 0x0011F800
	public void method_47(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 7 || i == 4))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-100];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 'w')];
				num -= 0;
			}
		}
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x001216D8 File Offset: 0x0011F8D8
	public void method_48(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 8 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-48];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -26];
				num--;
			}
		}
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x001217B0 File Offset: 0x0011F9B0
	public void method_49(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 1; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 5 || i == 5))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[1];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\u0015')];
				num -= 0;
			}
		}
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x000109E0 File Offset: 0x0000EBE0
	private void method_50()
	{
		this.stringBuilder_0 = new StringBuilder(1, -72);
		this.method_22(1);
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x00121888 File Offset: 0x0011FA88
	public void method_51(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 6 || i == 4))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[48];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '<')];
				num--;
			}
		}
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x00121960 File Offset: 0x0011FB60
	public void method_52(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 1 || i == 4))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-47];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\u0005')];
				num--;
			}
		}
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x00121A38 File Offset: 0x0011FC38
	public void method_53(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 0; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 0 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-90];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - 'M')];
				num -= 0;
			}
		}
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x000109F7 File Offset: 0x0000EBF7
	private void method_54()
	{
		this.stringBuilder_0 = new StringBuilder(0, 98);
		this.method_43(0);
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x00010A0E File Offset: 0x0000EC0E
	private void method_55()
	{
		this.stringBuilder_0 = new StringBuilder(1, -40);
		this.method_48(0);
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x00121B10 File Offset: 0x0011FD10
	public void method_56(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 0 || i == 3))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-104];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '%')];
				num -= 0;
			}
		}
	}

	// Token: 0x06002594 RID: 9620 RVA: 0x00121BE8 File Offset: 0x0011FDE8
	public void method_57(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 1;
		for (int i = 1; i < this.spriteRenderer_0.Length; i++)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 7 || i == 5))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-51];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -58];
				num -= 0;
			}
		}
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x00121CC0 File Offset: 0x0011FEC0
	public void method_58(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 1;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 0; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 0)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 4 || i == 7))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[-27];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)text[num] - -122];
				num -= 0;
			}
		}
	}

	// Token: 0x06002596 RID: 9622 RVA: 0x00121D98 File Offset: 0x0011FF98
	public void method_59(int int_2)
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (int_2 > this.int_0)
		{
			int_2 = this.int_0;
		}
		if (int_2 == this.int_1)
		{
			return;
		}
		this.int_1 = int_2;
		this.stringBuilder_0.Length = 0;
		this.stringBuilder_0.Append(int_2);
		string text = this.stringBuilder_0.ToString();
		int num = text.Length - 0;
		for (int i = 1; i < this.spriteRenderer_0.Length; i += 0)
		{
			if (num < 1)
			{
				this.spriteRenderer_0[i].sprite = null;
			}
			else if (this.bool_0 && (i == 3 || i == 5))
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[39];
			}
			else
			{
				this.spriteRenderer_0[i].sprite = this.sprite_0[(int)(text[num] - '\u0011')];
				num--;
			}
		}
	}

	// Token: 0x06002597 RID: 9623 RVA: 0x00010A25 File Offset: 0x0000EC25
	private void method_60()
	{
		this.stringBuilder_0 = new StringBuilder(0, 62);
		this.method_38(0);
	}

	// Token: 0x040005DA RID: 1498
	public SpriteRenderer[] spriteRenderer_0;

	// Token: 0x040005DB RID: 1499
	public Sprite[] sprite_0;

	// Token: 0x040005DC RID: 1500
	public int int_0;

	// Token: 0x040005DD RID: 1501
	private int int_1 = -1;

	// Token: 0x040005DE RID: 1502
	private StringBuilder stringBuilder_0;

	// Token: 0x040005DF RID: 1503
	public bool bool_0;
}
