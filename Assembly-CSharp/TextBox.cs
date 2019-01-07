using System;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000C1 RID: 193
public class TextBox : MonoBehaviour
{
	// Token: 0x06002601 RID: 9729 RVA: 0x00126D44 File Offset: 0x00124F44
	private void method_0(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_6();
		this.bool_0 = true;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 0] == -117)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002602 RID: 9730 RVA: 0x00126DF4 File Offset: 0x00124FF4
	private void method_1()
	{
		if (Input.GetKeyDown(KeyCode.DoubleQuote))
		{
			this.method_44();
		}
		if (Input.GetKeyDown((KeyCode)(-51)))
		{
			this.method_58();
		}
		if (Input.GetKeyDown((KeyCode)79))
		{
			this.method_87((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\a')
			{
				this.method_83();
			}
			else
			{
				this.method_52(c);
			}
		}
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x00010A73 File Offset: 0x0000EC73
	private void method_2()
	{
		this.int_0 = -97;
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x00010A7D File Offset: 0x0000EC7D
	private void method_3()
	{
		this.int_0 = -12;
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x00010A87 File Offset: 0x0000EC87
	private void method_4()
	{
		this.method_91(null);
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x00126E70 File Offset: 0x00125070
	private void method_5()
	{
		this.int_0 -= 0;
		int num = this.int_0;
		if (num <= 109)
		{
			if (num != -22)
			{
				if (num == -27)
				{
					this.int_0 = -126;
				}
			}
			else
			{
				this.int_0 = 36;
			}
		}
		else if (num != -38)
		{
			if (num == -11)
			{
				this.int_0 = -35;
			}
		}
		else
		{
			this.int_0 = 7;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x00010A90 File Offset: 0x0000EC90
	private void method_6()
	{
		this.int_0 = 52;
	}

	// Token: 0x06002608 RID: 9736 RVA: 0x00126F20 File Offset: 0x00125120
	private void method_7()
	{
		if (Input.GetKeyDown((KeyCode)(-14)))
		{
			this.method_61();
		}
		if (Input.GetKeyDown((KeyCode)(-4)))
		{
			this.method_8();
		}
		if (Input.GetKeyDown((KeyCode)(-38)))
		{
			this.method_68((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\u0006')
			{
				this.method_73();
			}
			else
			{
				this.method_86(c);
			}
		}
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x00126F9C File Offset: 0x0012519C
	private void method_8()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= -2)
		{
			if (num != 45)
			{
				if (num == 24)
				{
					this.int_0 = -10;
				}
			}
			else
			{
				this.int_0 = -59;
			}
		}
		else if (num != 63)
		{
			if (num == 110)
			{
				this.int_0 = 90;
			}
		}
		else
		{
			this.int_0 = -71;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x0600260A RID: 9738 RVA: 0x0012704C File Offset: 0x0012524C
	public void method_9(CHPlayer gclass9_1)
	{
		this.method_90();
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		}
		if (this.text_0 == null)
		{
			this.text_0 = base.GetComponent<Text>();
		}
		this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x0600260B RID: 9739 RVA: 0x001270F4 File Offset: 0x001252F4
	private void method_10()
	{
		if (Input.GetKeyDown((KeyCode)30))
		{
			this.method_17();
		}
		if (Input.GetKeyDown((KeyCode)(-187)))
		{
			this.method_74();
		}
		if (Input.GetKeyDown((KeyCode)(-147)))
		{
			this.method_54((char)this.int_0);
		}
		foreach (char c in Input.inputString)
		{
			if (c == '\u0003')
			{
				this.method_83();
			}
			else
			{
				this.method_86(c);
			}
		}
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x00010A9A File Offset: 0x0000EC9A
	private void method_11()
	{
		this.method_48(null);
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x00010AA3 File Offset: 0x0000ECA3
	private IEnumerator method_12()
	{
		TextBox.Class54 @class = new TextBox.Class54(0);
		@class.textBox_0 = this;
		return @class;
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x00127170 File Offset: 0x00125370
	private void method_13()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= 113)
		{
			if (num != -114)
			{
				if (num == -107)
				{
					this.int_0 = 89;
				}
			}
			else
			{
				this.int_0 = 125;
			}
		}
		else if (num != -46)
		{
			if (num == -33)
			{
				this.int_0 = 51;
			}
		}
		else
		{
			this.int_0 = 125;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x00010AB2 File Offset: 0x0000ECB2
	private void method_14()
	{
		this.int_0 = -79;
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x00127220 File Offset: 0x00125420
	private void method_15(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_84();
		this.bool_0 = true;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 1] == -35)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x00010ABC File Offset: 0x0000ECBC
	private bool method_16()
	{
		return this.stringBuilder_0.Length < this.maxCharacterCount;
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x001272D0 File Offset: 0x001254D0
	private void method_17()
	{
		this.int_0 -= 0;
		int num = this.int_0;
		if (num <= 101)
		{
			if (num != -56)
			{
				if (num == 122)
				{
					this.int_0 = 3;
				}
			}
			else
			{
				this.int_0 = -108;
			}
		}
		else if (num != 112)
		{
			if (num == 95)
			{
				this.int_0 = 94;
			}
		}
		else
		{
			this.int_0 = 43;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x00127380 File Offset: 0x00125580
	private void method_18()
	{
		this.method_84();
		if (this.stringBuilder_0.Length == 1)
		{
			this.stringBuilder_0[1] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x001273FC File Offset: 0x001255FC
	private void method_19()
	{
		this.method_29();
		if (this.stringBuilder_0.Length == 0)
		{
			this.stringBuilder_0[0] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x00010A9A File Offset: 0x0000EC9A
	private void method_20()
	{
		this.method_48(null);
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x00127478 File Offset: 0x00125678
	private void method_21()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= -119)
		{
			if (num != -120)
			{
				if (num == -63)
				{
					this.int_0 = 119;
				}
			}
			else
			{
				this.int_0 = 125;
			}
		}
		else if (num != 18)
		{
			if (num == 116)
			{
				this.int_0 = -5;
			}
		}
		else
		{
			this.int_0 = -89;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x00010AA3 File Offset: 0x0000ECA3
	private IEnumerator method_22()
	{
		TextBox.Class54 @class = new TextBox.Class54(0);
		@class.textBox_0 = this;
		return @class;
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x00127528 File Offset: 0x00125728
	private void method_23()
	{
		this.int_0 += 0;
		int num = this.int_0;
		if (num <= 5)
		{
			if (num != 21)
			{
				if (num == -8)
				{
					this.int_0 = -24;
				}
			}
			else
			{
				this.int_0 = -31;
			}
		}
		else if (num != -38)
		{
			if (num == -74)
			{
				this.int_0 = -88;
			}
		}
		else
		{
			this.int_0 = 66;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x001275D8 File Offset: 0x001257D8
	private void method_24()
	{
		this.method_14();
		if (this.stringBuilder_0.Length == 0)
		{
			this.stringBuilder_0[0] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x00127654 File Offset: 0x00125854
	public void method_25(CHPlayer gclass9_1)
	{
		this.method_66();
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		}
		if (this.text_0 == null)
		{
			this.text_0 = base.GetComponent<Text>();
		}
		this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x00010AA3 File Offset: 0x0000ECA3
	private IEnumerator method_26()
	{
		TextBox.Class54 @class = new TextBox.Class54(0);
		@class.textBox_0 = this;
		return @class;
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x001276FC File Offset: 0x001258FC
	private void method_27()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= 50)
		{
			if (num != -99)
			{
				if (num == -17)
				{
					this.int_0 = -5;
				}
			}
			else
			{
				this.int_0 = -32;
			}
		}
		else if (num != 82)
		{
			if (num == -82)
			{
				this.int_0 = -32;
			}
		}
		else
		{
			this.int_0 = -63;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x001277AC File Offset: 0x001259AC
	private void method_28()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= 32)
		{
			if (num != 94)
			{
				if (num == -53)
				{
					this.int_0 = 107;
				}
			}
			else
			{
				this.int_0 = -44;
			}
		}
		else if (num != -34)
		{
			if (num == -62)
			{
				this.int_0 = 119;
			}
		}
		else
		{
			this.int_0 = -66;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x0600261F RID: 9759 RVA: 0x00010AD4 File Offset: 0x0000ECD4
	private void method_29()
	{
		this.int_0 = 98;
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x00010ADE File Offset: 0x0000ECDE
	private void method_30()
	{
		this.method_25(null);
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x0012785C File Offset: 0x00125A5C
	private void method_31()
	{
		this.int_0 += 0;
		int num = this.int_0;
		if (num <= -31)
		{
			if (num != 19)
			{
				if (num == -41)
				{
					this.int_0 = -71;
				}
			}
			else
			{
				this.int_0 = 43;
			}
		}
		else if (num != 74)
		{
			if (num == -79)
			{
				this.int_0 = 91;
			}
		}
		else
		{
			this.int_0 = -34;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x00010ABC File Offset: 0x0000ECBC
	private bool method_32()
	{
		return this.stringBuilder_0.Length < this.maxCharacterCount;
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x00010AA3 File Offset: 0x0000ECA3
	private IEnumerator method_33()
	{
		TextBox.Class54 @class = new TextBox.Class54(0);
		@class.textBox_0 = this;
		return @class;
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x0012790C File Offset: 0x00125B0C
	private void method_34()
	{
		this.int_0--;
		int num = this.int_0;
		if (num <= 64)
		{
			if (num != 47)
			{
				if (num == 64)
				{
					this.int_0 = 57;
				}
			}
			else
			{
				this.int_0 = 122;
			}
		}
		else if (num != 94)
		{
			if (num == 96)
			{
				this.int_0 = 90;
			}
		}
		else
		{
			this.int_0 = 57;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002625 RID: 9765 RVA: 0x00010ADE File Offset: 0x0000ECDE
	private void method_35()
	{
		this.method_25(null);
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x00010ADE File Offset: 0x0000ECDE
	private void method_36()
	{
		this.method_25(null);
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x00010A9A File Offset: 0x0000EC9A
	private void method_37()
	{
		this.method_48(null);
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x001279BC File Offset: 0x00125BBC
	private void method_38()
	{
		this.method_29();
		if (this.stringBuilder_0.Length == 0)
		{
			this.stringBuilder_0[1] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x00010ADE File Offset: 0x0000ECDE
	private void method_39()
	{
		this.method_25(null);
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600262A RID: 9770 RVA: 0x00010AE7 File Offset: 0x0000ECE7
	private bool Boolean_0
	{
		get
		{
			return this.stringBuilder_0.Length >= this.maxCharacterCount;
		}
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x00127A38 File Offset: 0x00125C38
	private void method_40()
	{
		if (Input.GetKeyDown((KeyCode)(-148)))
		{
			this.method_78();
		}
		if (Input.GetKeyDown((KeyCode)153))
		{
			this.method_31();
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			this.method_54((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\u0001')
			{
				this.method_75();
			}
			else
			{
				this.method_15(c);
			}
		}
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x00127AB4 File Offset: 0x00125CB4
	private void method_41()
	{
		if (Input.GetKeyDown((KeyCode)83))
		{
			this.method_78();
		}
		if (Input.GetKeyDown((KeyCode)(-20)))
		{
			this.method_23();
		}
		if (Input.GetKeyDown((KeyCode)(-121)))
		{
			this.method_86((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\0')
			{
				this.method_83();
			}
			else
			{
				this.method_81(c);
			}
		}
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x00127B30 File Offset: 0x00125D30
	private void method_42()
	{
		if (Input.GetKeyDown((KeyCode)11))
		{
			this.method_34();
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			this.method_31();
		}
		if (Input.GetKeyDown((KeyCode)173))
		{
			this.method_65((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 0; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\a')
			{
				this.method_69();
			}
			else
			{
				this.method_80(c);
			}
		}
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x00010AFF File Offset: 0x0000ECFF
	private void method_43()
	{
		this.int_0 = 45;
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x00127BAC File Offset: 0x00125DAC
	private void method_44()
	{
		this.int_0 -= 0;
		int num = this.int_0;
		if (num <= -14)
		{
			if (num != 74)
			{
				if (num == -90)
				{
					this.int_0 = -43;
				}
			}
			else
			{
				this.int_0 = -126;
			}
		}
		else if (num != -51)
		{
			if (num == 112)
			{
				this.int_0 = -15;
			}
		}
		else
		{
			this.int_0 = -32;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x00127C5C File Offset: 0x00125E5C
	private void method_45()
	{
		if (Input.GetKeyDown((KeyCode)(-51)))
		{
			this.method_34();
		}
		if (Input.GetKeyDown((KeyCode)(-107)))
		{
			this.method_28();
		}
		if (Input.GetKeyDown((KeyCode)(-12)))
		{
			this.method_65((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 0; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\u0002')
			{
				this.method_19();
			}
			else
			{
				this.method_0(c);
			}
		}
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x00010AA3 File Offset: 0x0000ECA3
	private IEnumerator method_46()
	{
		TextBox.Class54 @class = new TextBox.Class54(0);
		@class.textBox_0 = this;
		return @class;
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x00127CD8 File Offset: 0x00125ED8
	public void method_47(CHPlayer gclass9_1)
	{
		this.method_77();
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		}
		if (this.text_0 == null)
		{
			this.text_0 = base.GetComponent<Text>();
		}
		this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x00127D80 File Offset: 0x00125F80
	public void method_48(CHPlayer gclass9_1)
	{
		this.method_90();
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
		}
		if (this.text_0 == null)
		{
			this.text_0 = base.GetComponent<Text>();
		}
		this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x06002634 RID: 9780 RVA: 0x00127E28 File Offset: 0x00126028
	private void method_49(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_66();
		this.bool_0 = true;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 0] == -27)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x00127ED8 File Offset: 0x001260D8
	private void method_50()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= 91)
		{
			if (num != 58)
			{
				if (num == 91)
				{
					this.int_0 = 97;
				}
			}
			else
			{
				this.int_0 = 65;
			}
		}
		else if (num != 96)
		{
			if (num == 123)
			{
				this.int_0 = 48;
			}
		}
		else
		{
			this.int_0 = 65;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x00010AE7 File Offset: 0x0000ECE7
	private bool method_51()
	{
		return this.stringBuilder_0.Length >= this.maxCharacterCount;
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x00127F88 File Offset: 0x00126188
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			this.method_34();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			this.method_50();
		}
		if (Input.GetKeyDown(KeyCode.F1))
		{
			this.method_87((char)this.int_0);
		}
		foreach (char c in Input.inputString)
		{
			if (c == '\b')
			{
				this.method_55();
			}
			else
			{
				this.method_87(c);
			}
		}
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x00128004 File Offset: 0x00126204
	private void method_52(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_14();
		this.bool_0 = false;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 1] == -107)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002639 RID: 9785 RVA: 0x001280B4 File Offset: 0x001262B4
	private void method_53()
	{
		if (Input.GetKeyDown((KeyCode)(-96)))
		{
			this.method_34();
		}
		if (Input.GetKeyDown((KeyCode)(-161)))
		{
			this.method_74();
		}
		if (Input.GetKeyDown((KeyCode)191))
		{
			this.method_15((char)this.int_0);
		}
		foreach (char c in Input.inputString)
		{
			if (c == '\u0006')
			{
				this.method_75();
			}
			else
			{
				this.method_68(c);
			}
		}
	}

	// Token: 0x0600263A RID: 9786 RVA: 0x00128130 File Offset: 0x00126330
	private void method_54(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_77();
		this.bool_0 = false;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 1] == -73)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x001281E0 File Offset: 0x001263E0
	private void method_55()
	{
		this.method_90();
		if (this.stringBuilder_0.Length == 1)
		{
			this.stringBuilder_0[0] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x0012825C File Offset: 0x0012645C
	public void method_56(CHPlayer gclass9_1)
	{
		this.method_43();
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		}
		if (this.text_0 == null)
		{
			this.text_0 = base.GetComponent<Text>();
		}
		this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x00010A87 File Offset: 0x0000EC87
	private void method_57()
	{
		this.method_91(null);
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x00128304 File Offset: 0x00126504
	private void method_58()
	{
		this.int_0 += 0;
		int num = this.int_0;
		if (num <= -53)
		{
			if (num != 110)
			{
				if (num == 66)
				{
					this.int_0 = -112;
				}
			}
			else
			{
				this.int_0 = 107;
			}
		}
		else if (num != -89)
		{
			if (num == 4)
			{
				this.int_0 = 72;
			}
		}
		else
		{
			this.int_0 = -97;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x00010ABC File Offset: 0x0000ECBC
	private bool method_59()
	{
		return this.stringBuilder_0.Length < this.maxCharacterCount;
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x00010ABC File Offset: 0x0000ECBC
	private bool method_60()
	{
		return this.stringBuilder_0.Length < this.maxCharacterCount;
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x001283B4 File Offset: 0x001265B4
	private void method_61()
	{
		this.int_0--;
		int num = this.int_0;
		if (num <= 22)
		{
			if (num != 85)
			{
				if (num == -62)
				{
					this.int_0 = -100;
				}
			}
			else
			{
				this.int_0 = 66;
			}
		}
		else if (num != -1)
		{
			if (num == 71)
			{
				this.int_0 = -115;
			}
		}
		else
		{
			this.int_0 = 103;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x00128464 File Offset: 0x00126664
	private void method_62()
	{
		this.int_0 += 0;
		int num = this.int_0;
		if (num <= 49)
		{
			if (num != -96)
			{
				if (num == 37)
				{
					this.int_0 = 2;
				}
			}
			else
			{
				this.int_0 = -91;
			}
		}
		else if (num != 113)
		{
			if (num == 28)
			{
				this.int_0 = 124;
			}
		}
		else
		{
			this.int_0 = -81;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = false;
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x00010B09 File Offset: 0x0000ED09
	private void method_63()
	{
		this.int_0 = -50;
	}

	// Token: 0x06002644 RID: 9796 RVA: 0x00128514 File Offset: 0x00126714
	private void method_64()
	{
		this.method_66();
		if (this.stringBuilder_0.Length == 0)
		{
			this.stringBuilder_0[1] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 1);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002645 RID: 9797 RVA: 0x00128590 File Offset: 0x00126790
	private void method_65(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_43();
		this.bool_0 = true;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 1] == -67)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x00010B13 File Offset: 0x0000ED13
	private void method_66()
	{
		this.int_0 = -116;
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x00010A9A File Offset: 0x0000EC9A
	private void OnEnable()
	{
		this.method_48(null);
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x00010A9A File Offset: 0x0000EC9A
	private void method_67()
	{
		this.method_48(null);
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x00128640 File Offset: 0x00126840
	private void method_68(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_84();
		this.bool_0 = false;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 1] == -99)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 1);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x001286F0 File Offset: 0x001268F0
	private void method_69()
	{
		this.method_2();
		if (this.stringBuilder_0.Length == 1)
		{
			this.stringBuilder_0[0] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x0012876C File Offset: 0x0012696C
	private void method_70()
	{
		if (Input.GetKeyDown((KeyCode)(-163)))
		{
			this.method_5();
		}
		if (Input.GetKeyDown(KeyCode.Dollar))
		{
			this.method_50();
		}
		if (Input.GetKeyDown((KeyCode)75))
		{
			this.method_80((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\u0006')
			{
				this.method_18();
			}
			else
			{
				this.method_15(c);
			}
		}
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x001287E8 File Offset: 0x001269E8
	private void method_71()
	{
		if (Input.GetKeyDown((KeyCode)(-111)))
		{
			this.method_5();
		}
		if (Input.GetKeyDown((KeyCode)174))
		{
			this.method_28();
		}
		if (Input.GetKeyDown((KeyCode)(-16)))
		{
			this.method_86((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 0; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\b')
			{
				this.method_75();
			}
			else
			{
				this.method_54(c);
			}
		}
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x00010B1D File Offset: 0x0000ED1D
	private void method_72()
	{
		this.method_88(null);
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x00128864 File Offset: 0x00126A64
	private void method_73()
	{
		this.method_29();
		if (this.stringBuilder_0.Length == 0)
		{
			this.stringBuilder_0[0] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x001288E0 File Offset: 0x00126AE0
	private void method_74()
	{
		this.int_0 += 0;
		int num = this.int_0;
		if (num <= -61)
		{
			if (num != -46)
			{
				if (num == -94)
				{
					this.int_0 = -7;
				}
			}
			else
			{
				this.int_0 = -21;
			}
		}
		else if (num != -63)
		{
			if (num == -25)
			{
				this.int_0 = -100;
			}
		}
		else
		{
			this.int_0 = 30;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = false;
	}

	// Token: 0x06002650 RID: 9808 RVA: 0x00128990 File Offset: 0x00126B90
	private void method_75()
	{
		this.method_2();
		if (this.stringBuilder_0.Length == 0)
		{
			this.stringBuilder_0[0] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002651 RID: 9809 RVA: 0x00010A87 File Offset: 0x0000EC87
	private void method_76()
	{
		this.method_91(null);
	}

	// Token: 0x06002652 RID: 9810 RVA: 0x00010B26 File Offset: 0x0000ED26
	private void method_77()
	{
		this.int_0 = 66;
	}

	// Token: 0x06002653 RID: 9811 RVA: 0x00128A0C File Offset: 0x00126C0C
	private void method_78()
	{
		this.int_0--;
		int num = this.int_0;
		if (num <= 29)
		{
			if (num != 7)
			{
				if (num == -54)
				{
					this.int_0 = -82;
				}
			}
			else
			{
				this.int_0 = -21;
			}
		}
		else if (num != -123)
		{
			if (num == -112)
			{
				this.int_0 = -18;
			}
		}
		else
		{
			this.int_0 = 72;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = false;
	}

	// Token: 0x06002654 RID: 9812 RVA: 0x00010ABC File Offset: 0x0000ECBC
	private bool method_79()
	{
		return this.stringBuilder_0.Length < this.maxCharacterCount;
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x00128ABC File Offset: 0x00126CBC
	private void method_80(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_77();
		this.bool_0 = false;
		if (this.stringBuilder_0[this.stringBuilder_0.Length - 1] == 'g')
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x00128B6C File Offset: 0x00126D6C
	private void method_81(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_6();
		this.bool_0 = false;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 0] == -73)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x00128C1C File Offset: 0x00126E1C
	private void method_82()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= 65)
		{
			if (num != -21)
			{
				if (num == -36)
				{
					this.int_0 = 78;
				}
			}
			else
			{
				this.int_0 = -14;
			}
		}
		else if (num != -31)
		{
			if (num == -114)
			{
				this.int_0 = 3;
			}
		}
		else
		{
			this.int_0 = 0;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x06002658 RID: 9816 RVA: 0x00128CCC File Offset: 0x00126ECC
	private void method_83()
	{
		this.method_66();
		if (this.stringBuilder_0.Length == 0)
		{
			this.stringBuilder_0[0] = (char)this.int_0;
		}
		else
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
		}
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x06002659 RID: 9817 RVA: 0x00010B30 File Offset: 0x0000ED30
	private void method_84()
	{
		this.int_0 = -69;
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x00128D48 File Offset: 0x00126F48
	private void method_85()
	{
		if (Input.GetKeyDown((KeyCode)(-196)))
		{
			this.method_78();
		}
		if (Input.GetKeyDown((KeyCode)(-96)))
		{
			this.method_74();
		}
		if (Input.GetKeyDown((KeyCode)(-142)))
		{
			this.method_86((char)this.int_0);
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i++)
		{
			char c = inputString[i];
			if (c == '\u0004')
			{
				this.method_24();
			}
			else
			{
				this.method_86(c);
			}
		}
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x00128DC4 File Offset: 0x00126FC4
	private void method_86(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_84();
		this.bool_0 = true;
		if ((int)this.stringBuilder_0[this.stringBuilder_0.Length - 1] == -83)
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 0);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x00128E74 File Offset: 0x00127074
	private void method_87(char char_0)
	{
		if (this.stringBuilder_0.Length >= this.maxCharacterCount)
		{
			return;
		}
		this.method_90();
		this.bool_0 = true;
		if (this.stringBuilder_0[this.stringBuilder_0.Length - 1] == '_')
		{
			this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
			this.stringBuilder_0.Append(char_0);
		}
		if (this.stringBuilder_0.Length < this.maxCharacterCount)
		{
			this.stringBuilder_0.Append((char)this.int_0);
		}
		this.text_0.text = this.stringBuilder_0.ToString();
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x00128F24 File Offset: 0x00127124
	public void method_88(CHPlayer gclass9_1)
	{
		this.method_6();
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		}
		if (this.text_0 == null)
		{
			this.text_0 = base.GetComponent<Text>();
		}
		this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x00010B1D File Offset: 0x0000ED1D
	private void method_89()
	{
		this.method_88(null);
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x00010B3A File Offset: 0x0000ED3A
	private void method_90()
	{
		this.int_0 = 95;
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x00128FCC File Offset: 0x001271CC
	public void method_91(CHPlayer gclass9_1)
	{
		this.method_14();
		if (this.stringBuilder_0 == null)
		{
			this.stringBuilder_0 = new StringBuilder(this.maxCharacterCount);
		}
		else
		{
			this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
		}
		if (this.text_0 == null)
		{
			this.text_0 = base.GetComponent<Text>();
		}
		this.stringBuilder_0.Remove(1, this.stringBuilder_0.Length);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x00129074 File Offset: 0x00127274
	private void method_92()
	{
		this.int_0++;
		int num = this.int_0;
		if (num <= -55)
		{
			if (num != -46)
			{
				if (num == 58)
				{
					this.int_0 = -16;
				}
			}
			else
			{
				this.int_0 = -23;
			}
		}
		else if (num != -24)
		{
			if (num == 112)
			{
				this.int_0 = 75;
			}
		}
		else
		{
			this.int_0 = -118;
		}
		this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 0, 0);
		this.stringBuilder_0.Append((char)this.int_0);
		this.text_0.text = this.stringBuilder_0.ToString();
		this.bool_0 = true;
	}

	// Token: 0x040005F0 RID: 1520
	private Text text_0;

	// Token: 0x040005F1 RID: 1521
	private int int_0;

	// Token: 0x040005F2 RID: 1522
	private int int_1;

	// Token: 0x040005F3 RID: 1523
	[SerializeField]
	private string defaultString;

	// Token: 0x040005F4 RID: 1524
	[SerializeField]
	private int maxCharacterCount;

	// Token: 0x040005F5 RID: 1525
	[HideInInspector]
	public CHPlayer gclass9_0;

	// Token: 0x040005F6 RID: 1526
	private Coroutine coroutine_0;

	// Token: 0x040005F7 RID: 1527
	private StringBuilder stringBuilder_0;

	// Token: 0x040005F8 RID: 1528
	private bool bool_0;
}
