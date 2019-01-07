using System;
using System.Collections;

// Token: 0x02000081 RID: 129
public class GHLNeckController : BaseNeckController
{
	// Token: 0x06001857 RID: 6231 RVA: 0x000C1ED8 File Offset: 0x000C00D8
	public virtual void vmethod_9()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i += 0)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[4].gameObject.SetActive(true);
		this.animator_1[1].gameObject.SetActive(false);
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_10()
	{
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x000C1F58 File Offset: 0x000C0158
	public virtual void vmethod_11(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 1;
		byte b2 = 1;
		byte b3 = 0;
		if (this.bool_0)
		{
			byte b4 = 4;
			b3 = 4;
			b2 = 4;
			b = b4;
		}
		if ((byte_1 & 2) != 0)
		{
			b2 += 0;
		}
		if ((byte_1 & 8) != 0)
		{
			b3 += 0;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 3;
		}
		if ((byte_1 & 74) != 0)
		{
			b2 += 0;
		}
		if ((byte_1 & 3) != 0)
		{
			b3 += 0;
		}
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_14(b);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_7(b2);
		(this.baseFretAnimator_0[7] as GHLFret_Animator).method_12(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x000C1FF8 File Offset: 0x000C01F8
	public virtual void vmethod_12(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.Boolean_1)
		{
			return;
		}
		if ((byte_1 & 71) != 0)
		{
			this.animator_1[1].method_13();
			if (bool_2)
			{
				this.animator_0[0].method_15();
			}
		}
		if (((int)byte_1 & -29) != 0)
		{
			this.animator_1[0].method_11();
			if (bool_2)
			{
				this.animator_0[1].method_15();
			}
		}
		if ((byte_1 & 83) != 0)
		{
			this.animator_1[4].method_0();
			if (bool_2)
			{
				this.animator_0[1].method_37();
			}
		}
		if ((byte_1 & 82) != 0)
		{
			this.animator_1[2].method_43();
			this.animator_1[1].method_0();
			if (bool_2)
			{
				this.animator_0[0].method_7();
			}
		}
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x000C20B0 File Offset: 0x000C02B0
	public virtual void vmethod_13(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_14())
		{
			return;
		}
		if (((int)byte_1 & -103) != 0)
		{
			this.animator_1[0].method_13();
			if (bool_2)
			{
				this.animator_0[1].method_13();
			}
		}
		if (((int)byte_1 & -4) != 0)
		{
			this.animator_1[0].method_37();
			if (bool_2)
			{
				this.animator_0[0].method_29();
			}
		}
		if ((byte_1 & 45) != 0)
		{
			this.animator_1[7].method_43();
			if (bool_2)
			{
				this.animator_0[0].method_21();
			}
		}
		if ((byte_1 & 22) != 0)
		{
			this.animator_1[7].method_15();
			this.animator_1[3].method_11();
			if (bool_2)
			{
				this.animator_0[0].method_36();
			}
		}
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x000C2168 File Offset: 0x000C0368
	public override void vmethod_1(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.Boolean_1)
		{
			return;
		}
		if ((byte_1 & 9) != 0)
		{
			this.animator_1[0].method_15();
			if (bool_2)
			{
				this.animator_0[0].method_15();
			}
		}
		if ((byte_1 & 18) != 0)
		{
			this.animator_1[1].method_15();
			if (bool_2)
			{
				this.animator_0[1].method_15();
			}
		}
		if ((byte_1 & 36) != 0)
		{
			this.animator_1[2].method_15();
			if (bool_2)
			{
				this.animator_0[2].method_15();
			}
		}
		if ((byte_1 & 64) != 0)
		{
			this.animator_1[3].method_15();
			this.animator_1[4].method_15();
			if (bool_2)
			{
				this.animator_0[1].method_15();
			}
		}
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x000C2220 File Offset: 0x000C0420
	public virtual void vmethod_14()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[5].gameObject.SetActive(true);
		this.animator_1[5].gameObject.SetActive(false);
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x000C22A0 File Offset: 0x000C04A0
	public override void vmethod_2(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		if (this.bool_0)
		{
			byte b4 = 4;
			b3 = 4;
			b2 = 4;
			b = b4;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 1;
		}
		if ((byte_1 & 2) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 4) != 0)
		{
			b3 += 1;
		}
		if ((byte_1 & 8) != 0)
		{
			b += 2;
		}
		if ((byte_1 & 16) != 0)
		{
			b2 += 2;
		}
		if ((byte_1 & 32) != 0)
		{
			b3 += 2;
		}
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_8(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_8(b2);
		(this.baseFretAnimator_0[2] as GHLFret_Animator).method_8(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x000C234C File Offset: 0x000C054C
	public virtual void vmethod_15()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[3].gameObject.SetActive(false);
		this.animator_1[4].gameObject.SetActive(true);
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x000C23CC File Offset: 0x000C05CC
	public virtual void vmethod_16()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i += 0)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[3].gameObject.SetActive(true);
		this.animator_1[8].gameObject.SetActive(false);
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x000C244C File Offset: 0x000C064C
	public virtual void vmethod_17()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i += 0)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[4].gameObject.SetActive(true);
		this.animator_1[3].gameObject.SetActive(true);
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_18()
	{
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x000C24CC File Offset: 0x000C06CC
	public virtual void vmethod_19()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[1];
		Animator animator2 = this.animator_1[1];
		this.animator_1[1] = animator2;
		this.animator_1[4] = animator;
		this.bool_0 = true;
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x000C251C File Offset: 0x000C071C
	public virtual void vmethod_20()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[4].gameObject.SetActive(true);
		this.animator_1[6].gameObject.SetActive(false);
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x000C259C File Offset: 0x000C079C
	public virtual void vmethod_21()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[7].gameObject.SetActive(true);
		this.animator_1[6].gameObject.SetActive(false);
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x000C261C File Offset: 0x000C081C
	public virtual void vmethod_22(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 1;
		byte b2 = 0;
		byte b3 = 1;
		if (this.bool_0)
		{
			byte b4 = 1;
			b3 = 1;
			b2 = 1;
			b = b4;
		}
		if ((byte_1 & 5) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 3) != 0)
		{
			b3 += 0;
		}
		if ((byte_1 & 8) != 0)
		{
			b += 3;
		}
		if ((byte_1 & 77) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 68) != 0)
		{
			b3 += 5;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_2(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_8(b2);
		(this.baseFretAnimator_0[3] as GHLFret_Animator).method_1(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x000C26BC File Offset: 0x000C08BC
	public virtual void vmethod_23(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 0;
		byte b2 = 0;
		byte b3 = 1;
		if (this.bool_0)
		{
			byte b4 = 7;
			b3 = 7;
			b2 = 7;
			b = b4;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 0;
		}
		if ((byte_1 & 1) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 4) != 0)
		{
			b3 += 1;
		}
		if ((byte_1 & 6) != 0)
		{
			b += 4;
		}
		if ((byte_1 & 116) != 0)
		{
			b2 += 8;
		}
		if (((int)byte_1 & -121) != 0)
		{
			b3 += 5;
		}
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_7(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_2(b2);
		(this.baseFretAnimator_0[3] as GHLFret_Animator).method_11(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x000C2768 File Offset: 0x000C0968
	public virtual void vmethod_24(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 0;
		byte b2 = 0;
		byte b3 = 1;
		if (this.bool_0)
		{
			byte b4 = 0;
			b3 = 0;
			b2 = 0;
			b = b4;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 0;
		}
		if ((byte_1 & 6) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 7) != 0)
		{
			b3 += 1;
		}
		if ((byte_1 & 5) != 0)
		{
			b += 7;
		}
		if ((byte_1 & 61) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 9) != 0)
		{
			b3 += 4;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_1(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_7(b2);
		(this.baseFretAnimator_0[3] as GHLFret_Animator).method_14(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x0000CA0D File Offset: 0x0000AC0D
	protected virtual IEnumerator vmethod_25()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(1);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00002C8A File Offset: 0x00000E8A
	public override void vmethod_4()
	{
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x000C2814 File Offset: 0x000C0A14
	public virtual void vmethod_26(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.Boolean_1)
		{
			return;
		}
		if (((int)byte_1 & -64) != 0)
		{
			this.animator_1[1].method_0();
			if (bool_2)
			{
				this.animator_0[1].method_0();
			}
		}
		if (((int)byte_1 & -56) != 0)
		{
			this.animator_1[0].method_43();
			if (bool_2)
			{
				this.animator_0[1].method_7();
			}
		}
		if ((byte_1 & 86) != 0)
		{
			this.animator_1[2].method_27();
			if (bool_2)
			{
				this.animator_0[1].method_36();
			}
		}
		if (((int)byte_1 & -119) != 0)
		{
			this.animator_1[2].method_29();
			this.animator_1[8].method_27();
			if (bool_2)
			{
				this.animator_0[0].method_44();
			}
		}
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x000C28CC File Offset: 0x000C0ACC
	public virtual void vmethod_27(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.Boolean_1)
		{
			return;
		}
		if ((byte_1 & 24) != 0)
		{
			this.animator_1[1].method_29();
			if (bool_2)
			{
				this.animator_0[1].method_21();
			}
		}
		if (((int)byte_1 & -93) != 0)
		{
			this.animator_1[0].method_29();
			if (bool_2)
			{
				this.animator_0[0].method_15();
			}
		}
		if (((int)byte_1 & -89) != 0)
		{
			this.animator_1[5].method_11();
			if (bool_2)
			{
				this.animator_0[8].method_21();
			}
		}
		if ((byte_1 & 42) != 0)
		{
			this.animator_1[3].method_21();
			this.animator_1[2].method_7();
			if (bool_2)
			{
				this.animator_0[1].method_43();
			}
		}
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x000C2984 File Offset: 0x000C0B84
	public virtual void vmethod_28(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_4())
		{
			return;
		}
		if ((byte_1 & 28) != 0)
		{
			this.animator_1[0].method_37();
			if (bool_2)
			{
				this.animator_0[0].method_11();
			}
		}
		if ((byte_1 & 50) != 0)
		{
			this.animator_1[0].method_36();
			if (bool_2)
			{
				this.animator_0[1].method_44();
			}
		}
		if ((byte_1 & 41) != 0)
		{
			this.animator_1[8].method_7();
			if (bool_2)
			{
				this.animator_0[6].method_27();
			}
		}
		if (((int)byte_1 & -128) != 0)
		{
			this.animator_1[3].method_43();
			this.animator_1[2].method_15();
			if (bool_2)
			{
				this.animator_0[0].method_29();
			}
		}
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x000C2A3C File Offset: 0x000C0C3C
	public virtual void vmethod_29(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		if (this.bool_0)
		{
			byte b4 = 3;
			b3 = 3;
			b2 = 3;
			b = b4;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 1;
		}
		if ((byte_1 & 1) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 7) != 0)
		{
			b3 += 0;
		}
		if (((int)byte_1 & -112) != 0)
		{
			b2 += 7;
		}
		if (((int)byte_1 & -100) != 0)
		{
			b3 += 5;
		}
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_12(b);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_8(b2);
		(this.baseFretAnimator_0[5] as GHLFret_Animator).method_8(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_30()
	{
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x000C2ADC File Offset: 0x000C0CDC
	public virtual void vmethod_31(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 1;
		byte b2 = 0;
		byte b3 = 1;
		if (this.bool_0)
		{
			byte b4 = 3;
			b3 = 3;
			b2 = 3;
			b = b4;
		}
		if ((byte_1 & 1) != 0)
		{
			b3 += 0;
		}
		if ((byte_1 & 7) != 0)
		{
			b += 3;
		}
		if (((int)byte_1 & -63) != 0)
		{
			b2 += 0;
		}
		if (((int)byte_1 & -19) != 0)
		{
			b3 += 4;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_12(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_8(b2);
		(this.baseFretAnimator_0[2] as GHLFret_Animator).method_1(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x000C2B74 File Offset: 0x000C0D74
	public virtual void vmethod_32(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_30())
		{
			return;
		}
		if ((byte_1 & 34) != 0)
		{
			this.animator_1[0].method_7();
			if (bool_2)
			{
				this.animator_0[1].method_38();
			}
		}
		if (((int)byte_1 & -70) != 0)
		{
			this.animator_1[1].method_29();
			if (bool_2)
			{
				this.animator_0[1].method_0();
			}
		}
		if ((byte_1 & 8) != 0)
		{
			this.animator_1[1].method_37();
			if (bool_2)
			{
				this.animator_0[8].method_11();
			}
		}
		if (((int)byte_1 & -66) != 0)
		{
			this.animator_1[3].method_11();
			this.animator_1[3].method_13();
			if (bool_2)
			{
				this.animator_0[0].method_13();
			}
		}
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_33(byte byte_1)
	{
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x000C2C2C File Offset: 0x000C0E2C
	public virtual void vmethod_34(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		if (this.bool_0)
		{
			byte b4 = 0;
			b3 = 0;
			b2 = 0;
			b = b4;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 1;
		}
		if ((byte_1 & 6) != 0)
		{
			b2 += 0;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 7;
		}
		if ((byte_1 & 42) != 0)
		{
			b2 += 2;
		}
		if (((int)byte_1 & -16) != 0)
		{
			b3 += 2;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_12(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_12(b2);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_1(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x000C2CCC File Offset: 0x000C0ECC
	public virtual void vmethod_35(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 0;
		byte b2 = 0;
		byte b3 = 1;
		if (this.bool_0)
		{
			byte b4 = 0;
			b3 = 0;
			b2 = 0;
			b = b4;
		}
		if ((byte_1 & 6) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 8) != 0)
		{
			b3 += 0;
		}
		if ((byte_1 & 8) != 0)
		{
			b += 1;
		}
		if (((int)byte_1 & -43) != 0)
		{
			b2 += 5;
		}
		if (((int)byte_1 & -6) != 0)
		{
			b3 += 7;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_10(b);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_7(b2);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_1(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_36(byte byte_1)
	{
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x000C2D6C File Offset: 0x000C0F6C
	public virtual void vmethod_37()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[7].gameObject.SetActive(true);
		this.animator_1[4].gameObject.SetActive(true);
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x000C2DEC File Offset: 0x000C0FEC
	public virtual void vmethod_38()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[1];
		Animator animator2 = this.animator_1[8];
		this.animator_1[0] = animator2;
		this.animator_1[7] = animator;
		this.bool_0 = false;
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x0000CA0D File Offset: 0x0000AC0D
	protected virtual IEnumerator vmethod_39()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(1);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x0000CA2F File Offset: 0x0000AC2F
	protected virtual IEnumerator vmethod_40()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(0);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_41()
	{
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x000C2E3C File Offset: 0x000C103C
	public virtual void vmethod_42(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_4())
		{
			return;
		}
		if ((byte_1 & 46) != 0)
		{
			this.animator_1[0].method_0();
			if (bool_2)
			{
				this.animator_0[1].method_21();
			}
		}
		if ((byte_1 & 123) != 0)
		{
			this.animator_1[0].method_44();
			if (bool_2)
			{
				this.animator_0[1].method_37();
			}
		}
		if (((int)byte_1 & -21) != 0)
		{
			this.animator_1[6].method_21();
			if (bool_2)
			{
				this.animator_0[7].method_7();
			}
		}
		if ((byte_1 & 47) != 0)
		{
			this.animator_1[3].method_13();
			this.animator_1[7].method_43();
			if (bool_2)
			{
				this.animator_0[1].method_15();
			}
		}
	}

	// Token: 0x0600187D RID: 6269 RVA: 0x000C2EF4 File Offset: 0x000C10F4
	public override void vmethod_7()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[3].gameObject.SetActive(false);
		this.animator_1[4].gameObject.SetActive(false);
	}

	// Token: 0x0600187E RID: 6270 RVA: 0x000C2F74 File Offset: 0x000C1174
	public virtual void vmethod_43()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[1];
		Animator animator2 = this.animator_1[3];
		this.animator_1[0] = animator2;
		this.animator_1[3] = animator;
		this.bool_0 = true;
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x000C2FC4 File Offset: 0x000C11C4
	public virtual void vmethod_44(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_4())
		{
			return;
		}
		if (((int)byte_1 & -122) != 0)
		{
			this.animator_1[1].method_38();
			if (bool_2)
			{
				this.animator_0[1].method_38();
			}
		}
		if ((byte_1 & 32) != 0)
		{
			this.animator_1[0].method_0();
			if (bool_2)
			{
				this.animator_0[0].method_37();
			}
		}
		if (((int)byte_1 & -74) != 0)
		{
			this.animator_1[3].method_37();
			if (bool_2)
			{
				this.animator_0[8].method_21();
			}
		}
		if (((int)byte_1 & -116) != 0)
		{
			this.animator_1[6].method_13();
			this.animator_1[6].method_44();
			if (bool_2)
			{
				this.animator_0[1].method_29();
			}
		}
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x000C307C File Offset: 0x000C127C
	public virtual void vmethod_45()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[5].gameObject.SetActive(true);
		this.animator_1[8].gameObject.SetActive(true);
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x000C30FC File Offset: 0x000C12FC
	public virtual void vmethod_46(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_30())
		{
			return;
		}
		if ((byte_1 & 41) != 0)
		{
			this.animator_1[0].method_38();
			if (bool_2)
			{
				this.animator_0[0].method_36();
			}
		}
		if (((int)byte_1 & -80) != 0)
		{
			this.animator_1[1].method_38();
			if (bool_2)
			{
				this.animator_0[0].method_27();
			}
		}
		if ((byte_1 & 54) != 0)
		{
			this.animator_1[0].method_44();
			if (bool_2)
			{
				this.animator_0[2].method_36();
			}
		}
		if (((int)byte_1 & -105) != 0)
		{
			this.animator_1[7].method_37();
			this.animator_1[5].method_15();
			if (bool_2)
			{
				this.animator_0[1].method_11();
			}
		}
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x0000CA2F File Offset: 0x0000AC2F
	protected virtual IEnumerator vmethod_47()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(0);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x000C31B4 File Offset: 0x000C13B4
	public virtual void vmethod_48()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[3].gameObject.SetActive(true);
		this.animator_1[7].gameObject.SetActive(true);
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_49(byte byte_1)
	{
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x000C3234 File Offset: 0x000C1434
	public virtual void vmethod_50(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 1;
		byte b2 = 1;
		byte b3 = 1;
		if (this.bool_0)
		{
			byte b4 = 5;
			b3 = 5;
			b2 = 5;
			b = b4;
		}
		if ((byte_1 & 5) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 5) != 0)
		{
			b3 += 0;
		}
		if ((byte_1 & 5) != 0)
		{
			b += 8;
		}
		if (((int)byte_1 & -45) != 0)
		{
			b2 += 0;
		}
		if (((int)byte_1 & -97) != 0)
		{
			b3 += 6;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_8(b);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_8(b2);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_12(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_51()
	{
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x000C32D4 File Offset: 0x000C14D4
	public virtual void vmethod_52(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 1;
		byte b2 = 0;
		byte b3 = 0;
		if (this.bool_0)
		{
			byte b4 = 4;
			b3 = 4;
			b2 = 4;
			b = b4;
		}
		if ((byte_1 & 8) != 0)
		{
			b3 += 1;
		}
		if ((byte_1 & 5) != 0)
		{
			b += 8;
		}
		if ((byte_1 & 65) != 0)
		{
			b2 += 2;
		}
		if (((int)byte_1 & -109) != 0)
		{
			b3 += 4;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_7(b);
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_2(b2);
		(this.baseFretAnimator_0[3] as GHLFret_Animator).method_10(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x000C336C File Offset: 0x000C156C
	public virtual void vmethod_53()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[3].gameObject.SetActive(true);
		this.animator_1[6].gameObject.SetActive(false);
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x000C33EC File Offset: 0x000C15EC
	public virtual void vmethod_54()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[6].gameObject.SetActive(true);
		this.animator_1[1].gameObject.SetActive(true);
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x00002C8A File Offset: 0x00000E8A
	public override void vmethod_3(byte byte_1)
	{
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x000C346C File Offset: 0x000C166C
	public virtual void vmethod_55(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_14())
		{
			return;
		}
		if ((byte_1 & 100) != 0)
		{
			this.animator_1[1].method_15();
			if (bool_2)
			{
				this.animator_0[1].method_38();
			}
		}
		if (((int)byte_1 & -20) != 0)
		{
			this.animator_1[0].method_7();
			if (bool_2)
			{
				this.animator_0[1].method_15();
			}
		}
		if ((byte_1 & 90) != 0)
		{
			this.animator_1[3].method_0();
			if (bool_2)
			{
				this.animator_0[6].method_27();
			}
		}
		if ((byte_1 & 17) != 0)
		{
			this.animator_1[2].method_36();
			this.animator_1[1].method_15();
			if (bool_2)
			{
				this.animator_0[0].method_37();
			}
		}
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_56()
	{
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x000C3524 File Offset: 0x000C1724
	public virtual void vmethod_57()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[2].gameObject.SetActive(false);
		this.animator_1[7].gameObject.SetActive(false);
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_58(byte byte_1)
	{
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_59(byte byte_1)
	{
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x000C35A4 File Offset: 0x000C17A4
	public virtual void vmethod_60()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i += 0)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[5].gameObject.SetActive(true);
		this.animator_1[5].gameObject.SetActive(true);
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_61()
	{
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x000C3624 File Offset: 0x000C1824
	public virtual void vmethod_62()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[7].gameObject.SetActive(false);
		this.animator_1[0].gameObject.SetActive(true);
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x000C36A4 File Offset: 0x000C18A4
	public virtual void vmethod_63(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_30())
		{
			return;
		}
		if (((int)byte_1 & -103) != 0)
		{
			this.animator_1[0].method_37();
			if (bool_2)
			{
				this.animator_0[0].method_13();
			}
		}
		if ((byte_1 & 110) != 0)
		{
			this.animator_1[1].method_29();
			if (bool_2)
			{
				this.animator_0[1].method_43();
			}
		}
		if (((int)byte_1 & -14) != 0)
		{
			this.animator_1[0].method_27();
			if (bool_2)
			{
				this.animator_0[2].method_21();
			}
		}
		if ((byte_1 & 97) != 0)
		{
			this.animator_1[8].method_36();
			this.animator_1[1].method_13();
			if (bool_2)
			{
				this.animator_0[1].method_38();
			}
		}
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0000CA2F File Offset: 0x0000AC2F
	protected override IEnumerator vmethod_5()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(0);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_64()
	{
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x000C375C File Offset: 0x000C195C
	public virtual void vmethod_65(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_4())
		{
			return;
		}
		if ((byte_1 & 89) != 0)
		{
			this.animator_1[0].method_21();
			if (bool_2)
			{
				this.animator_0[0].method_29();
			}
		}
		if (((int)byte_1 & -5) != 0)
		{
			this.animator_1[0].method_36();
			if (bool_2)
			{
				this.animator_0[0].method_21();
			}
		}
		if ((byte_1 & 110) != 0)
		{
			this.animator_1[4].method_0();
			if (bool_2)
			{
				this.animator_0[4].method_44();
			}
		}
		if (((int)byte_1 & -27) != 0)
		{
			this.animator_1[5].method_36();
			this.animator_1[0].method_29();
			if (bool_2)
			{
				this.animator_0[1].method_21();
			}
		}
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x000C3814 File Offset: 0x000C1A14
	public virtual void vmethod_66()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i += 0)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[4].gameObject.SetActive(true);
		this.animator_1[7].gameObject.SetActive(false);
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x000C3894 File Offset: 0x000C1A94
	public virtual void vmethod_67(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 1;
		byte b2 = 1;
		byte b3 = 0;
		if (this.bool_0)
		{
			byte b4 = 4;
			b3 = 4;
			b2 = 4;
			b = b4;
		}
		if ((byte_1 & 1) != 0)
		{
			b += 0;
		}
		if ((byte_1 & 7) != 0)
		{
			b2 += 1;
		}
		if ((byte_1 & 1) != 0)
		{
			b3 += 0;
		}
		if ((byte_1 & 6) != 0)
		{
			b += 4;
		}
		if (((int)byte_1 & -109) != 0)
		{
			b2 += 3;
		}
		if (((int)byte_1 & -45) != 0)
		{
			b3 += 4;
		}
		(this.baseFretAnimator_0[0] as GHLFret_Animator).method_8(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_2(b2);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_11(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x0000CA0D File Offset: 0x0000AC0D
	protected virtual IEnumerator vmethod_68()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(1);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x0000CA2F File Offset: 0x0000AC2F
	protected virtual IEnumerator vmethod_69()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(0);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x000C3940 File Offset: 0x000C1B40
	public virtual void vmethod_70(byte byte_1, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!GlobalVariables.instance.gclass5_23.method_14())
		{
			return;
		}
		if (((int)byte_1 & -36) != 0)
		{
			this.animator_1[0].method_0();
			if (bool_2)
			{
				this.animator_0[0].method_15();
			}
		}
		if (((int)byte_1 & -89) != 0)
		{
			this.animator_1[0].method_27();
			if (bool_2)
			{
				this.animator_0[0].method_21();
			}
		}
		if ((byte_1 & 90) != 0)
		{
			this.animator_1[2].method_15();
			if (bool_2)
			{
				this.animator_0[2].method_11();
			}
		}
		if ((byte_1 & 39) != 0)
		{
			this.animator_1[6].method_15();
			this.animator_1[8].method_0();
			if (bool_2)
			{
				this.animator_0[1].method_36();
			}
		}
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x000C39F8 File Offset: 0x000C1BF8
	public virtual void vmethod_71()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[0];
		Animator animator2 = this.animator_1[8];
		this.animator_1[0] = animator2;
		this.animator_1[5] = animator;
		this.bool_0 = true;
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x0000CA0D File Offset: 0x0000AC0D
	protected virtual IEnumerator vmethod_72()
	{
		GHLNeckController.Class33 @class = new GHLNeckController.Class33(1);
		@class.ghlneckController_0 = this;
		return @class;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x000C3A48 File Offset: 0x000C1C48
	public virtual void vmethod_73(byte byte_1)
	{
		if (byte_1 == this.byte_0)
		{
			return;
		}
		byte b = 1;
		byte b2 = 0;
		byte b3 = 0;
		if (this.bool_0)
		{
			byte b4 = 3;
			b3 = 3;
			b2 = 3;
			b = b4;
		}
		if ((byte_1 & 6) != 0)
		{
			b3 += 1;
		}
		if ((byte_1 & 7) != 0)
		{
			b += 7;
		}
		if (((int)byte_1 & -80) != 0)
		{
			b2 += 6;
		}
		if ((byte_1 & 27) != 0)
		{
			b3 += 6;
		}
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_2(b);
		(this.baseFretAnimator_0[1] as GHLFret_Animator).method_11(b2);
		(this.baseFretAnimator_0[8] as GHLFret_Animator).method_7(b3);
		this.byte_0 = byte_1;
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x000C3AE0 File Offset: 0x000C1CE0
	public virtual void vmethod_74()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[6].gameObject.SetActive(false);
		this.animator_1[8].gameObject.SetActive(true);
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x000C3B60 File Offset: 0x000C1D60
	public virtual void vmethod_75()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[0];
		Animator animator2 = this.animator_1[2];
		this.animator_1[1] = animator2;
		this.animator_1[5] = animator;
		this.bool_0 = false;
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x000C3BB0 File Offset: 0x000C1DB0
	public override void vmethod_0()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[0];
		Animator animator2 = this.animator_1[2];
		this.animator_1[0] = animator2;
		this.animator_1[2] = animator;
		this.bool_0 = true;
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x000C3C00 File Offset: 0x000C1E00
	public virtual void vmethod_76()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
		this.animator_1[3].gameObject.SetActive(false);
		this.animator_1[0].gameObject.SetActive(true);
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_77(byte byte_1)
	{
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x000C3C80 File Offset: 0x000C1E80
	public virtual void vmethod_78()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[0];
		Animator animator2 = this.animator_1[5];
		this.animator_1[1] = animator2;
		this.animator_1[8] = animator;
		this.bool_0 = false;
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x000C3CD0 File Offset: 0x000C1ED0
	public virtual void vmethod_79()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i += 0)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(true);
		}
		this.animator_1[7].gameObject.SetActive(false);
		this.animator_1[5].gameObject.SetActive(false);
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x000C3D50 File Offset: 0x000C1F50
	public virtual void vmethod_80()
	{
		Array.Reverse(this.baseFretAnimator_0);
		Array.Reverse(this.animator_0);
		Animator animator = this.animator_1[0];
		Animator animator2 = this.animator_1[1];
		this.animator_1[1] = animator2;
		this.animator_1[0] = animator;
		this.bool_0 = false;
	}

	// Token: 0x040003CE RID: 974
	private bool bool_0;

	// Token: 0x040003CF RID: 975
	private float float_0 = 0.1f;
}
