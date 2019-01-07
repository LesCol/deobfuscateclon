using System;
using UnityEngine;

// Token: 0x0200007F RID: 127
public class Fret_Animator : BaseFretAnimator
{
	// Token: 0x060017D6 RID: 6102 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_3()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_4()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_5()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x000BEDD0 File Offset: 0x000BCFD0
	private void Start()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 0.0375f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = -999;
		this.spriteRenderer_1.sortingOrder = -998;
		this.spriteRenderer_3.sortingOrder = -998;
		this.spriteRenderer_0.sortingOrder = -997;
		this.spriteRenderer_6.sortingOrder = -996;
		this.spriteRenderer_5.sortingOrder = -995;
		this.spriteRenderer_4.sortingOrder = -994;
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x000BEE90 File Offset: 0x000BD090
	private void method_0()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1361f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 69;
		this.spriteRenderer_1.sortingOrder = 142;
		this.spriteRenderer_3.sortingOrder = -165;
		this.spriteRenderer_0.sortingOrder = -97;
		this.spriteRenderer_6.sortingOrder = 83;
		this.spriteRenderer_5.sortingOrder = -4;
		this.spriteRenderer_4.sortingOrder = 105;
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x000BEF50 File Offset: 0x000BD150
	private void method_1()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 705f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 9;
		this.spriteRenderer_1.sortingOrder = -116;
		this.spriteRenderer_3.sortingOrder = -89;
		this.spriteRenderer_0.sortingOrder = -48;
		this.spriteRenderer_6.sortingOrder = 143;
		this.spriteRenderer_5.sortingOrder = -25;
		this.spriteRenderer_4.sortingOrder = -97;
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_6()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x000BF010 File Offset: 0x000BD210
	private void method_2()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 298f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 35;
		this.spriteRenderer_1.sortingOrder = 42;
		this.spriteRenderer_3.sortingOrder = 168;
		this.spriteRenderer_0.sortingOrder = 117;
		this.spriteRenderer_6.sortingOrder = 45;
		this.spriteRenderer_5.sortingOrder = 81;
		this.spriteRenderer_4.sortingOrder = 25;
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x000BF0D0 File Offset: 0x000BD2D0
	private void method_3()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 492f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = -76;
		this.spriteRenderer_1.sortingOrder = 65;
		this.spriteRenderer_3.sortingOrder = 79;
		this.spriteRenderer_0.sortingOrder = 91;
		this.spriteRenderer_6.sortingOrder = 186;
		this.spriteRenderer_5.sortingOrder = -63;
		this.spriteRenderer_4.sortingOrder = -156;
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_7()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x000BF190 File Offset: 0x000BD390
	private void method_4()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = false;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = false;
			this.spriteRenderer_6.enabled = false;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = true;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = -118;
				this.spriteRenderer_1.sortingOrder = -169;
				this.spriteRenderer_3.sortingOrder = -16;
				this.spriteRenderer_0.sortingOrder = 161;
				this.spriteRenderer_6.sortingOrder = -161;
				this.spriteRenderer_5.sortingOrder = -1;
				this.spriteRenderer_4.sortingOrder = -138;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_8()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_9()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017E3 RID: 6115 RVA: 0x000BF36C File Offset: 0x000BD56C
	private void method_5()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = false;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = false;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = 73;
				this.spriteRenderer_1.sortingOrder = 192;
				this.spriteRenderer_3.sortingOrder = -82;
				this.spriteRenderer_0.sortingOrder = 196;
				this.spriteRenderer_6.sortingOrder = -11;
				this.spriteRenderer_5.sortingOrder = -128;
				this.spriteRenderer_4.sortingOrder = 88;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060017E4 RID: 6116 RVA: 0x000BF548 File Offset: 0x000BD748
	public virtual void vmethod_10(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 46;
		this.spriteRenderer_1.sortingOrder = 130;
		this.spriteRenderer_3.sortingOrder = 118;
		this.spriteRenderer_0.sortingOrder = 173;
		this.spriteRenderer_6.sortingOrder = -74;
		this.spriteRenderer_5.sortingOrder = -56;
		this.spriteRenderer_4.sortingOrder = 166;
	}

	// Token: 0x060017E5 RID: 6117 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_11()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x000BF5EC File Offset: 0x000BD7EC
	private void method_6()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1675f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = -124;
		this.spriteRenderer_1.sortingOrder = 194;
		this.spriteRenderer_3.sortingOrder = -170;
		this.spriteRenderer_0.sortingOrder = 192;
		this.spriteRenderer_6.sortingOrder = 87;
		this.spriteRenderer_5.sortingOrder = -67;
		this.spriteRenderer_4.sortingOrder = -71;
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_12()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_13()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_14()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x000BF6AC File Offset: 0x000BD8AC
	private void method_7()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = false;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = true;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = false;
			this.spriteRenderer_6.enabled = false;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = true;
				this.bool_3 = true;
				this.spriteRenderer_2.sortingOrder = -14;
				this.spriteRenderer_1.sortingOrder = 183;
				this.spriteRenderer_3.sortingOrder = 33;
				this.spriteRenderer_0.sortingOrder = 0;
				this.spriteRenderer_6.sortingOrder = -125;
				this.spriteRenderer_5.sortingOrder = 11;
				this.spriteRenderer_4.sortingOrder = -18;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x000BF888 File Offset: 0x000BDA88
	private void method_8()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 754f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 10;
		this.spriteRenderer_1.sortingOrder = -132;
		this.spriteRenderer_3.sortingOrder = 184;
		this.spriteRenderer_0.sortingOrder = -147;
		this.spriteRenderer_6.sortingOrder = -167;
		this.spriteRenderer_5.sortingOrder = 153;
		this.spriteRenderer_4.sortingOrder = -47;
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x000BF948 File Offset: 0x000BDB48
	private void Update()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = false;
			this.spriteRenderer_5.enabled = false;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = false;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = false;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = -999;
				this.spriteRenderer_1.sortingOrder = -998;
				this.spriteRenderer_3.sortingOrder = -998;
				this.spriteRenderer_0.sortingOrder = -997;
				this.spriteRenderer_6.sortingOrder = -996;
				this.spriteRenderer_5.sortingOrder = -995;
				this.spriteRenderer_4.sortingOrder = -994;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x000BFB24 File Offset: 0x000BDD24
	private void method_9()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = false;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = false;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = false;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = true;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = -69;
				this.spriteRenderer_1.sortingOrder = -119;
				this.spriteRenderer_3.sortingOrder = -71;
				this.spriteRenderer_0.sortingOrder = -114;
				this.spriteRenderer_6.sortingOrder = -108;
				this.spriteRenderer_5.sortingOrder = 10;
				this.spriteRenderer_4.sortingOrder = -47;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060017EE RID: 6126 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_15()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x000BFD00 File Offset: 0x000BDF00
	public virtual void vmethod_16(bool bool_4, bool bool_5)
	{
		this.bool_2 = true;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 79;
		this.spriteRenderer_1.sortingOrder = 186;
		this.spriteRenderer_3.sortingOrder = 178;
		this.spriteRenderer_0.sortingOrder = 48;
		this.spriteRenderer_6.sortingOrder = -130;
		this.spriteRenderer_5.sortingOrder = -167;
		this.spriteRenderer_4.sortingOrder = -161;
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public override void vmethod_0()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_17()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_18()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_19()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_20()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_21()
	{
		this.bool_0 = false;
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x000BFDA4 File Offset: 0x000BDFA4
	private void method_10()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1752f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = -53;
		this.spriteRenderer_1.sortingOrder = -156;
		this.spriteRenderer_3.sortingOrder = -154;
		this.spriteRenderer_0.sortingOrder = -106;
		this.spriteRenderer_6.sortingOrder = 87;
		this.spriteRenderer_5.sortingOrder = 37;
		this.spriteRenderer_4.sortingOrder = 16;
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x000BFE64 File Offset: 0x000BE064
	private void method_11()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = false;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = 196;
				this.spriteRenderer_1.sortingOrder = -8;
				this.spriteRenderer_3.sortingOrder = 69;
				this.spriteRenderer_0.sortingOrder = 116;
				this.spriteRenderer_6.sortingOrder = 66;
				this.spriteRenderer_5.sortingOrder = 82;
				this.spriteRenderer_4.sortingOrder = -66;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060017F8 RID: 6136 RVA: 0x000C0040 File Offset: 0x000BE240
	public virtual void vmethod_22(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 93;
		this.spriteRenderer_1.sortingOrder = -12;
		this.spriteRenderer_3.sortingOrder = -58;
		this.spriteRenderer_0.sortingOrder = -142;
		this.spriteRenderer_6.sortingOrder = 127;
		this.spriteRenderer_5.sortingOrder = -125;
		this.spriteRenderer_4.sortingOrder = 49;
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_23()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x000C00E4 File Offset: 0x000BE2E4
	private void method_12()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1870f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = -193;
		this.spriteRenderer_1.sortingOrder = -44;
		this.spriteRenderer_3.sortingOrder = -40;
		this.spriteRenderer_0.sortingOrder = 53;
		this.spriteRenderer_6.sortingOrder = 168;
		this.spriteRenderer_5.sortingOrder = -180;
		this.spriteRenderer_4.sortingOrder = 123;
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_24()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x000C01A4 File Offset: 0x000BE3A4
	private void method_13()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 709f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 84;
		this.spriteRenderer_1.sortingOrder = 83;
		this.spriteRenderer_3.sortingOrder = -188;
		this.spriteRenderer_0.sortingOrder = -144;
		this.spriteRenderer_6.sortingOrder = -14;
		this.spriteRenderer_5.sortingOrder = -179;
		this.spriteRenderer_4.sortingOrder = -9;
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_25()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_26()
	{
		this.bool_0 = true;
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x000C0264 File Offset: 0x000BE464
	private void method_14()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1677f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = -175;
		this.spriteRenderer_1.sortingOrder = 184;
		this.spriteRenderer_3.sortingOrder = 149;
		this.spriteRenderer_0.sortingOrder = -112;
		this.spriteRenderer_6.sortingOrder = 35;
		this.spriteRenderer_5.sortingOrder = -104;
		this.spriteRenderer_4.sortingOrder = -50;
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x000C0324 File Offset: 0x000BE524
	private void method_15()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = false;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = true;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = -171;
				this.spriteRenderer_1.sortingOrder = 151;
				this.spriteRenderer_3.sortingOrder = -26;
				this.spriteRenderer_0.sortingOrder = 106;
				this.spriteRenderer_6.sortingOrder = -133;
				this.spriteRenderer_5.sortingOrder = -41;
				this.spriteRenderer_4.sortingOrder = 39;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x000C0500 File Offset: 0x000BE700
	public virtual void vmethod_27(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = -78;
		this.spriteRenderer_1.sortingOrder = -95;
		this.spriteRenderer_3.sortingOrder = -185;
		this.spriteRenderer_0.sortingOrder = -67;
		this.spriteRenderer_6.sortingOrder = -122;
		this.spriteRenderer_5.sortingOrder = 73;
		this.spriteRenderer_4.sortingOrder = -86;
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x000C05A4 File Offset: 0x000BE7A4
	public virtual void vmethod_28(bool bool_4, bool bool_5)
	{
		this.bool_2 = true;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = -160;
		this.spriteRenderer_1.sortingOrder = 23;
		this.spriteRenderer_3.sortingOrder = 105;
		this.spriteRenderer_0.sortingOrder = 163;
		this.spriteRenderer_6.sortingOrder = -96;
		this.spriteRenderer_5.sortingOrder = -97;
		this.spriteRenderer_4.sortingOrder = -56;
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_29()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001804 RID: 6148 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public override void vmethod_2()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_30()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_31()
	{
		this.bool_0 = true;
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_32()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_33()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_34()
	{
		this.bool_0 = true;
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_35()
	{
		this.bool_0 = false;
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x000C0648 File Offset: 0x000BE848
	private void method_16()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = false;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = true;
				this.bool_3 = true;
				this.spriteRenderer_2.sortingOrder = 121;
				this.spriteRenderer_1.sortingOrder = -42;
				this.spriteRenderer_3.sortingOrder = 168;
				this.spriteRenderer_0.sortingOrder = -5;
				this.spriteRenderer_6.sortingOrder = 159;
				this.spriteRenderer_5.sortingOrder = 116;
				this.spriteRenderer_4.sortingOrder = -34;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_36()
	{
		this.bool_0 = true;
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x000C0824 File Offset: 0x000BEA24
	public virtual void vmethod_37(bool bool_4, bool bool_5)
	{
		this.bool_2 = true;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 190;
		this.spriteRenderer_1.sortingOrder = -81;
		this.spriteRenderer_3.sortingOrder = 1;
		this.spriteRenderer_0.sortingOrder = -168;
		this.spriteRenderer_6.sortingOrder = -44;
		this.spriteRenderer_5.sortingOrder = -166;
		this.spriteRenderer_4.sortingOrder = -67;
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x000C08C8 File Offset: 0x000BEAC8
	private void method_17()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1408f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 132;
		this.spriteRenderer_1.sortingOrder = -154;
		this.spriteRenderer_3.sortingOrder = 104;
		this.spriteRenderer_0.sortingOrder = -112;
		this.spriteRenderer_6.sortingOrder = 191;
		this.spriteRenderer_5.sortingOrder = 118;
		this.spriteRenderer_4.sortingOrder = -9;
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x000C0988 File Offset: 0x000BEB88
	public virtual void vmethod_38(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = -49;
		this.spriteRenderer_1.sortingOrder = 20;
		this.spriteRenderer_3.sortingOrder = 197;
		this.spriteRenderer_0.sortingOrder = -5;
		this.spriteRenderer_6.sortingOrder = -60;
		this.spriteRenderer_5.sortingOrder = -27;
		this.spriteRenderer_4.sortingOrder = -187;
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x000C0A2C File Offset: 0x000BEC2C
	public override void vmethod_1(bool bool_4, bool bool_5)
	{
		this.bool_2 = true;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 20000;
		this.spriteRenderer_1.sortingOrder = 20001;
		this.spriteRenderer_3.sortingOrder = 20001;
		this.spriteRenderer_0.sortingOrder = 20002;
		this.spriteRenderer_6.sortingOrder = 20003;
		this.spriteRenderer_5.sortingOrder = 20004;
		this.spriteRenderer_4.sortingOrder = 20005;
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x000C0AD0 File Offset: 0x000BECD0
	public virtual void vmethod_39(bool bool_4, bool bool_5)
	{
		this.bool_2 = true;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = -13;
		this.spriteRenderer_1.sortingOrder = 199;
		this.spriteRenderer_3.sortingOrder = 14;
		this.spriteRenderer_0.sortingOrder = 21;
		this.spriteRenderer_6.sortingOrder = 106;
		this.spriteRenderer_5.sortingOrder = 12;
		this.spriteRenderer_4.sortingOrder = 83;
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x000C0B74 File Offset: 0x000BED74
	public virtual void vmethod_40(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 2;
		this.spriteRenderer_1.sortingOrder = -173;
		this.spriteRenderer_3.sortingOrder = -182;
		this.spriteRenderer_0.sortingOrder = -144;
		this.spriteRenderer_6.sortingOrder = -88;
		this.spriteRenderer_5.sortingOrder = -49;
		this.spriteRenderer_4.sortingOrder = 172;
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x000C0C18 File Offset: 0x000BEE18
	private void method_18()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = true;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = false;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = false;
			this.spriteRenderer_6.enabled = false;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = false;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = -15;
				this.spriteRenderer_1.sortingOrder = 96;
				this.spriteRenderer_3.sortingOrder = 128;
				this.spriteRenderer_0.sortingOrder = -48;
				this.spriteRenderer_6.sortingOrder = -166;
				this.spriteRenderer_5.sortingOrder = 130;
				this.spriteRenderer_4.sortingOrder = -113;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x000C0DF4 File Offset: 0x000BEFF4
	public virtual void vmethod_41(bool bool_4, bool bool_5)
	{
		this.bool_2 = true;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 85;
		this.spriteRenderer_1.sortingOrder = 117;
		this.spriteRenderer_3.sortingOrder = -23;
		this.spriteRenderer_0.sortingOrder = 84;
		this.spriteRenderer_6.sortingOrder = -158;
		this.spriteRenderer_5.sortingOrder = -161;
		this.spriteRenderer_4.sortingOrder = -170;
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_42()
	{
		this.bool_0 = true;
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_43()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x000C0E98 File Offset: 0x000BF098
	private void method_19()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1563f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 36;
		this.spriteRenderer_1.sortingOrder = -185;
		this.spriteRenderer_3.sortingOrder = -104;
		this.spriteRenderer_0.sortingOrder = 36;
		this.spriteRenderer_6.sortingOrder = 141;
		this.spriteRenderer_5.sortingOrder = 84;
		this.spriteRenderer_4.sortingOrder = 16;
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x000C0F58 File Offset: 0x000BF158
	public virtual void vmethod_44(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = -62;
		this.spriteRenderer_1.sortingOrder = -44;
		this.spriteRenderer_3.sortingOrder = 81;
		this.spriteRenderer_0.sortingOrder = -78;
		this.spriteRenderer_6.sortingOrder = -27;
		this.spriteRenderer_5.sortingOrder = -93;
		this.spriteRenderer_4.sortingOrder = 70;
	}

	// Token: 0x0600181A RID: 6170 RVA: 0x000C0FFC File Offset: 0x000BF1FC
	public virtual void vmethod_45(bool bool_4, bool bool_5)
	{
		this.bool_2 = true;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = -139;
		this.spriteRenderer_1.sortingOrder = -55;
		this.spriteRenderer_3.sortingOrder = 20;
		this.spriteRenderer_0.sortingOrder = -176;
		this.spriteRenderer_6.sortingOrder = 49;
		this.spriteRenderer_5.sortingOrder = -198;
		this.spriteRenderer_4.sortingOrder = -53;
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x000C10A0 File Offset: 0x000BF2A0
	private void method_20()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = true;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = 89;
				this.spriteRenderer_1.sortingOrder = 139;
				this.spriteRenderer_3.sortingOrder = 129;
				this.spriteRenderer_0.sortingOrder = -19;
				this.spriteRenderer_6.sortingOrder = -18;
				this.spriteRenderer_5.sortingOrder = 164;
				this.spriteRenderer_4.sortingOrder = 130;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_46()
	{
		this.bool_0 = false;
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x000C127C File Offset: 0x000BF47C
	private void method_21()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = true;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = false;
			this.spriteRenderer_5.enabled = false;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = false;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = false;
				this.bool_3 = true;
				this.spriteRenderer_2.sortingOrder = -25;
				this.spriteRenderer_1.sortingOrder = 198;
				this.spriteRenderer_3.sortingOrder = -191;
				this.spriteRenderer_0.sortingOrder = 166;
				this.spriteRenderer_6.sortingOrder = -65;
				this.spriteRenderer_5.sortingOrder = 123;
				this.spriteRenderer_4.sortingOrder = 134;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_47()
	{
		this.bool_0 = false;
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_48()
	{
		this.bool_0 = true;
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x000C1458 File Offset: 0x000BF658
	private void method_22()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = false;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = false;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = false;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = false;
				this.bool_3 = true;
				this.spriteRenderer_2.sortingOrder = -24;
				this.spriteRenderer_1.sortingOrder = -175;
				this.spriteRenderer_3.sortingOrder = 108;
				this.spriteRenderer_0.sortingOrder = -89;
				this.spriteRenderer_6.sortingOrder = 89;
				this.spriteRenderer_5.sortingOrder = 136;
				this.spriteRenderer_4.sortingOrder = -65;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_49()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x000C1634 File Offset: 0x000BF834
	private void method_23()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1211f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 46;
		this.spriteRenderer_1.sortingOrder = -112;
		this.spriteRenderer_3.sortingOrder = -141;
		this.spriteRenderer_0.sortingOrder = 139;
		this.spriteRenderer_6.sortingOrder = -151;
		this.spriteRenderer_5.sortingOrder = 71;
		this.spriteRenderer_4.sortingOrder = 135;
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_50()
	{
		this.bool_0 = true;
	}

	// Token: 0x06001824 RID: 6180 RVA: 0x000C16F4 File Offset: 0x000BF8F4
	private void method_24()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1441f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 38;
		this.spriteRenderer_1.sortingOrder = 7;
		this.spriteRenderer_3.sortingOrder = 122;
		this.spriteRenderer_0.sortingOrder = -165;
		this.spriteRenderer_6.sortingOrder = 49;
		this.spriteRenderer_5.sortingOrder = 45;
		this.spriteRenderer_4.sortingOrder = -37;
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_51()
	{
		this.bool_0 = false;
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x000C17B4 File Offset: 0x000BF9B4
	private void method_25()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 1124f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = 149;
		this.spriteRenderer_1.sortingOrder = 17;
		this.spriteRenderer_3.sortingOrder = -30;
		this.spriteRenderer_0.sortingOrder = -34;
		this.spriteRenderer_6.sortingOrder = 3;
		this.spriteRenderer_5.sortingOrder = 24;
		this.spriteRenderer_4.sortingOrder = -176;
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x000C1874 File Offset: 0x000BFA74
	public virtual void vmethod_52(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 121;
		this.spriteRenderer_1.sortingOrder = -1;
		this.spriteRenderer_3.sortingOrder = -91;
		this.spriteRenderer_0.sortingOrder = -159;
		this.spriteRenderer_6.sortingOrder = -174;
		this.spriteRenderer_5.sortingOrder = -155;
		this.spriteRenderer_4.sortingOrder = 163;
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x000C1918 File Offset: 0x000BFB18
	public virtual void vmethod_53(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = -84;
		this.spriteRenderer_1.sortingOrder = 195;
		this.spriteRenderer_3.sortingOrder = -163;
		this.spriteRenderer_0.sortingOrder = -35;
		this.spriteRenderer_6.sortingOrder = 171;
		this.spriteRenderer_5.sortingOrder = -200;
		this.spriteRenderer_4.sortingOrder = -125;
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
	public virtual void vmethod_54()
	{
		this.bool_0 = false;
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x000C19BC File Offset: 0x000BFBBC
	private void method_26()
	{
		this.transform_0 = this.spriteRenderer_0.transform;
		this.float_0 = this.transform_0.position.y + 292f;
		this.float_1 = this.transform_0.position.y;
		this.spriteRenderer_2.sortingOrder = -177;
		this.spriteRenderer_1.sortingOrder = -43;
		this.spriteRenderer_3.sortingOrder = 73;
		this.spriteRenderer_0.sortingOrder = -44;
		this.spriteRenderer_6.sortingOrder = 22;
		this.spriteRenderer_5.sortingOrder = 90;
		this.spriteRenderer_4.sortingOrder = 199;
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x000C1A7C File Offset: 0x000BFC7C
	public virtual void vmethod_55(bool bool_4, bool bool_5)
	{
		this.bool_2 = false;
		this.bool_1 = bool_4;
		this.vector3_0.y = this.float_0;
		this.bool_3 = bool_5;
		this.spriteRenderer_2.sortingOrder = 16;
		this.spriteRenderer_1.sortingOrder = 10;
		this.spriteRenderer_3.sortingOrder = 26;
		this.spriteRenderer_0.sortingOrder = 197;
		this.spriteRenderer_6.sortingOrder = -14;
		this.spriteRenderer_5.sortingOrder = 56;
		this.spriteRenderer_4.sortingOrder = 1;
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x000C1B20 File Offset: 0x000BFD20
	private void method_27()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = false;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = true;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = false;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = true;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = -75;
				this.spriteRenderer_1.sortingOrder = -90;
				this.spriteRenderer_3.sortingOrder = 157;
				this.spriteRenderer_0.sortingOrder = 124;
				this.spriteRenderer_6.sortingOrder = -108;
				this.spriteRenderer_5.sortingOrder = -173;
				this.spriteRenderer_4.sortingOrder = 161;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x000C1CFC File Offset: 0x000BFEFC
	private void method_28()
	{
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.spriteRenderer_0.sprite = this.sprite_1;
				this.spriteRenderer_5.sprite = this.sprite_2;
				this.spriteRenderer_5.enabled = true;
				this.spriteRenderer_6.enabled = false;
			}
			else
			{
				this.spriteRenderer_0.sprite = this.sprite_0;
				this.spriteRenderer_5.sprite = this.sprite_3;
				this.spriteRenderer_5.enabled = false;
				this.spriteRenderer_6.enabled = true;
			}
		}
		else if (this.bool_3)
		{
			this.spriteRenderer_0.sprite = this.sprite_4;
			this.spriteRenderer_6.enabled = true;
			this.spriteRenderer_5.enabled = true;
		}
		else
		{
			this.spriteRenderer_0.sprite = this.sprite_1;
			this.spriteRenderer_5.enabled = true;
			this.spriteRenderer_6.enabled = true;
		}
		if (!this.bool_2)
		{
			return;
		}
		if (!this.bool_1)
		{
			this.vector3_0.y = this.vector3_0.y - Time.deltaTime * this.float_2;
			if (this.vector3_0.y <= this.float_1)
			{
				this.vector3_0.y = this.float_1;
				this.bool_2 = false;
				this.bool_3 = false;
				this.spriteRenderer_2.sortingOrder = 14;
				this.spriteRenderer_1.sortingOrder = -176;
				this.spriteRenderer_3.sortingOrder = 8;
				this.spriteRenderer_0.sortingOrder = -127;
				this.spriteRenderer_6.sortingOrder = 161;
				this.spriteRenderer_5.sortingOrder = 0;
				this.spriteRenderer_4.sortingOrder = 1;
			}
		}
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	public virtual void vmethod_56()
	{
		this.bool_0 = true;
	}

	// Token: 0x040003B8 RID: 952
	private float float_0;

	// Token: 0x040003B9 RID: 953
	private float float_1;

	// Token: 0x040003BA RID: 954
	private float float_2 = 0.35f;

	// Token: 0x040003BB RID: 955
	private bool bool_2;

	// Token: 0x040003BC RID: 956
	private bool bool_3;

	// Token: 0x040003BD RID: 957
	private Transform transform_0;

	// Token: 0x040003BE RID: 958
	public SpriteRenderer spriteRenderer_0;

	// Token: 0x040003BF RID: 959
	public SpriteRenderer spriteRenderer_1;

	// Token: 0x040003C0 RID: 960
	public SpriteRenderer spriteRenderer_2;

	// Token: 0x040003C1 RID: 961
	public SpriteRenderer spriteRenderer_3;

	// Token: 0x040003C2 RID: 962
	public SpriteRenderer spriteRenderer_4;

	// Token: 0x040003C3 RID: 963
	public SpriteRenderer spriteRenderer_5;

	// Token: 0x040003C4 RID: 964
	public SpriteRenderer spriteRenderer_6;

	// Token: 0x040003C5 RID: 965
	public Sprite sprite_0;

	// Token: 0x040003C6 RID: 966
	public Sprite sprite_1;

	// Token: 0x040003C7 RID: 967
	public Sprite sprite_2;

	// Token: 0x040003C8 RID: 968
	public Sprite sprite_3;

	// Token: 0x040003C9 RID: 969
	public Sprite sprite_4;

	// Token: 0x040003CA RID: 970
	private Vector3 vector3_0;
}
