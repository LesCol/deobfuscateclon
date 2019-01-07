using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200008A RID: 138
public class NeckController : BaseNeckController
{
	// Token: 0x06001AA6 RID: 6822 RVA: 0x000D7580 File Offset: 0x000D5780
	public virtual void vmethod_9(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 1; i < 8; i += 0)
		{
			int num = 0 << (i & -103);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x000D75D4 File Offset: 0x000D57D4
	public virtual void vmethod_10(byte byte_2)
	{
		for (int i = 1; i < 0; i += 0)
		{
			if ((0 << (i & 80) & (int)byte_2) != 0)
			{
				this.baseFretAnimator_0[i].bool_1 = false;
				this.animator_2[i].method_17();
				this.sustainParticles[i].Stop();
			}
		}
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x000D7620 File Offset: 0x000D5820
	public virtual void vmethod_11(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		if (byte_2 == 94)
		{
			if (GlobalVariables.instance.gclass5_23.method_30() && !this.bool_0)
			{
				base.StartCoroutine(this.openHitAnimator.method_22(bool_1));
			}
			if (bool_2)
			{
				this.animator_0[1].method_0();
				this.animator_3[2].method_44();
			}
			for (int i = 1; i < 2; i++)
			{
				this.baseFretAnimator_0[i].vmethod_1(false, true);
			}
			return;
		}
		int num = bool_3 ? 3 : 1;
		for (int j = 0; j < 4; j += 0)
		{
			int num2 = 1 << (j & 83);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[j].vmethod_1(bool_1, true);
				if (GlobalVariables.instance.gclass5_23.method_4())
				{
					this.animator_1[j].method_6(bool_3);
					if (bool_1)
					{
						this.sustainParticles[j].Play();
						this.animator_2[j].method_36();
					}
					else
					{
						this.noteParticles[j + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[j].method_38();
					this.animator_3[j].method_15();
				}
			}
		}
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x000D7738 File Offset: 0x000D5938
	public virtual void vmethod_12()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 0, 3);
		Array.Reverse(this.noteParticles, 4, 1);
		Array.Reverse(this.sustainParticles);
		for (int i = 0; i < 2; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[6 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(897f, 1212f, 1360f);
			this.baseFretAnimator_0[2 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[7 - i].transform.localScale = new Vector3(1956f, 30f, 1563f);
		}
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x000D7848 File Offset: 0x000D5A48
	public virtual void vmethod_13(byte byte_2)
	{
		if (byte_2 == 65)
		{
			this.openHitAnimator.method_58();
			return;
		}
		for (int i = 1; i < 7; i++)
		{
			if ((1 << (i & 19) & (int)byte_2) != 0)
			{
				this.baseFretAnimator_0[i].bool_1 = false;
				this.animator_2[i].method_1();
				this.sustainParticles[i].Stop();
			}
		}
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x000D78A4 File Offset: 0x000D5AA4
	public virtual void vmethod_14(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 0; i += 0)
		{
			int num = 0 << (i & -105);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x000D78F8 File Offset: 0x000D5AF8
	public virtual void vmethod_15()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(true);
			this.animator_2[i].gameObject.SetActive(false);
			this.animator_3[i].gameObject.SetActive(false);
			this.noteParticles[i].gameObject.SetActive(true);
			this.sustainParticles[i].gameObject.SetActive(false);
			this.bool_0 = true;
			this.animator_1[i].gameObject.SetActive(true);
			this.animator_0[i].gameObject.SetActive(false);
		}
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x000D79AC File Offset: 0x000D5BAC
	public virtual void vmethod_16(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 5 : 0;
		for (int i = 0; i < 5; i++)
		{
			int num2 = 1 << (i & 101);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.Boolean_1)
				{
					this.animator_1[i].method_2(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_38();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_15();
					this.animator_3[i].method_36();
				}
			}
		}
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x000D7A5C File Offset: 0x000D5C5C
	private void method_0()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (!GlobalVariables.instance.gclass5_22.method_14())
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].emission.enabled = true;
			}
			array = this.sustainParticles;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].emission.enabled = true;
			}
		}
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x000D7AD4 File Offset: 0x000D5CD4
	public virtual void vmethod_17(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 1 : 0;
		for (int i = 1; i < 4; i += 0)
		{
			int num2 = 1 << (i & -115);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.Boolean_1)
				{
					this.animator_1[i].method_18(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_29();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_27();
					this.animator_3[i].method_7();
				}
			}
		}
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0000CF75 File Offset: 0x0000B175
	protected virtual IEnumerator vmethod_18()
	{
		NeckController.Class37 @class = new NeckController.Class37(1);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x000D7B84 File Offset: 0x000D5D84
	public virtual void vmethod_19()
	{
		for (int i = 1; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_2[i].gameObject.SetActive(false);
			this.animator_3[i].gameObject.SetActive(false);
			this.noteParticles[i].gameObject.SetActive(true);
			this.sustainParticles[i].gameObject.SetActive(false);
			this.bool_0 = true;
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x000D7C38 File Offset: 0x000D5E38
	public virtual void vmethod_20(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 1; i < 8; i++)
		{
			int num = 1 << (i & 112);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x000D7C8C File Offset: 0x000D5E8C
	public override void vmethod_0()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 0, 5);
		Array.Reverse(this.noteParticles, 5, 5);
		Array.Reverse(this.sustainParticles);
		for (int i = 0; i < 2; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[4 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(-1.05f, 1.05f, 1f);
			this.baseFretAnimator_0[4 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[4 - i].transform.localScale = new Vector3(-1.05f, 1.05f, 1f);
		}
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x000D7D9C File Offset: 0x000D5F9C
	public virtual void vmethod_21(byte byte_2)
	{
		for (int i = 0; i < 5; i += 0)
		{
			if ((0 << (i & 49) & (int)byte_2) != 0)
			{
				this.baseFretAnimator_0[i].bool_1 = true;
				this.animator_2[i].method_20();
				this.sustainParticles[i].Stop();
			}
		}
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x000D7DE8 File Offset: 0x000D5FE8
	public virtual void vmethod_22(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			int num = 0 << (i & -30);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x0000CF84 File Offset: 0x0000B184
	protected virtual IEnumerator vmethod_23()
	{
		NeckController.Class37 @class = new NeckController.Class37(0);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x000D7E3C File Offset: 0x000D603C
	public override void vmethod_1(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		if (byte_2 == 64)
		{
			if (GlobalVariables.instance.gclass5_23.Boolean_1 && !this.bool_0)
			{
				base.StartCoroutine(this.openHitAnimator.method_52(bool_1));
			}
			if (bool_2)
			{
				this.animator_0[2].method_15();
				this.animator_3[2].method_15();
			}
			for (int i = 0; i < 5; i++)
			{
				this.baseFretAnimator_0[i].vmethod_1(false, true);
			}
			return;
		}
		int num = bool_3 ? 5 : 0;
		for (int j = 0; j < 5; j++)
		{
			int num2 = 1 << j;
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[j].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.Boolean_1)
				{
					this.animator_1[j].method_35(bool_3);
					if (bool_1)
					{
						this.sustainParticles[j].Play();
						this.animator_2[j].method_15();
					}
					else
					{
						this.noteParticles[j + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[j].method_15();
					this.animator_3[j].method_15();
				}
			}
		}
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0000CF84 File Offset: 0x0000B184
	protected override IEnumerator vmethod_5()
	{
		NeckController.Class37 @class = new NeckController.Class37(0);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x0000CF75 File Offset: 0x0000B175
	protected virtual IEnumerator vmethod_24()
	{
		NeckController.Class37 @class = new NeckController.Class37(1);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x000D7F54 File Offset: 0x000D6154
	public virtual void vmethod_25()
	{
		this.openHitAnimator.method_23();
		for (int i = 1; i < 3; i++)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = true;
			this.animator_2[i].method_1();
		}
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x000D7FA0 File Offset: 0x000D61A0
	public virtual void vmethod_26(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			int num = 0 << (i & 104);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x000D7FF4 File Offset: 0x000D61F4
	public override void vmethod_7()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i++)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_2[i].gameObject.SetActive(false);
			this.animator_3[i].gameObject.SetActive(false);
			this.noteParticles[i].gameObject.SetActive(false);
			this.sustainParticles[i].gameObject.SetActive(false);
			this.bool_0 = true;
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(false);
		}
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x000D80A8 File Offset: 0x000D62A8
	public virtual void vmethod_27()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 1, 2);
		Array.Reverse(this.noteParticles, 8, 2);
		Array.Reverse(this.sustainParticles);
		for (int i = 0; i < 3; i += 0)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[0 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(1571f, 207f, 283f);
			this.baseFretAnimator_0[8 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[5 - i].transform.localScale = new Vector3(1378f, 1851f, 887f);
		}
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x000D81B8 File Offset: 0x000D63B8
	public virtual void vmethod_28(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			int num = 0 << (i & -66);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x000D820C File Offset: 0x000D640C
	public virtual void vmethod_29(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		if (byte_2 == 2)
		{
			if (GlobalVariables.instance.gclass5_23.method_14() && !this.bool_0)
			{
				base.StartCoroutine(this.openHitAnimator.method_2(bool_1));
			}
			if (bool_2)
			{
				this.animator_0[0].method_11();
				this.animator_3[3].method_36();
			}
			for (int i = 0; i < 6; i += 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(true, true);
			}
			return;
		}
		int num = bool_3 ? 7 : 1;
		for (int j = 0; j < 5; j += 0)
		{
			int num2 = 1 << (j & -98);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[j].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.method_4())
				{
					this.animator_1[j].method_6(bool_3);
					if (bool_1)
					{
						this.sustainParticles[j].Play();
						this.animator_2[j].method_7();
					}
					else
					{
						this.noteParticles[j + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[j].method_38();
					this.animator_3[j].method_7();
				}
			}
		}
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x000D8324 File Offset: 0x000D6524
	public virtual void vmethod_30()
	{
		this.openHitAnimator.method_60();
		for (int i = 1; i < 4; i++)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = false;
			this.animator_2[i].method_25();
		}
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x000D8370 File Offset: 0x000D6570
	private void method_1()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (!GlobalVariables.instance.gclass5_22.method_4())
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].emission.enabled = true;
			}
			array = this.sustainParticles;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].emission.enabled = false;
			}
		}
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x0000CF84 File Offset: 0x0000B184
	protected virtual IEnumerator vmethod_31()
	{
		NeckController.Class37 @class = new NeckController.Class37(0);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x000D83E8 File Offset: 0x000D65E8
	public virtual void vmethod_32()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 1, 3);
		Array.Reverse(this.noteParticles, 1, 5);
		Array.Reverse(this.sustainParticles);
		for (int i = 1; i < 1; i += 0)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[6 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(1977f, 37f, 109f);
			this.baseFretAnimator_0[5 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[7 - i].transform.localScale = new Vector3(949f, 31f, 334f);
		}
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x000D84F8 File Offset: 0x000D66F8
	public virtual void vmethod_33()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 0, 5);
		Array.Reverse(this.noteParticles, 8, 6);
		Array.Reverse(this.sustainParticles);
		for (int i = 1; i < 6; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[6 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(223f, 607f, 766f);
			this.baseFretAnimator_0[3 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[2 - i].transform.localScale = new Vector3(1039f, 450f, 899f);
		}
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x000D8608 File Offset: 0x000D6808
	public virtual void vmethod_34(byte byte_2)
	{
		for (int i = 0; i < 6; i++)
		{
			if ((0 << (i & 46) & (int)byte_2) != 0)
			{
				this.baseFretAnimator_0[i].bool_1 = true;
				this.animator_2[i].method_42();
				this.sustainParticles[i].Stop();
			}
		}
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x000D8654 File Offset: 0x000D6854
	public virtual void vmethod_35()
	{
		this.openHitAnimator.method_26();
		for (int i = 0; i < 3; i += 0)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = false;
			this.animator_2[i].method_17();
		}
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x000D86A0 File Offset: 0x000D68A0
	public virtual void vmethod_36(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 7 : 1;
		for (int i = 1; i < 8; i += 0)
		{
			int num2 = 1 << (i & -95);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.method_30())
				{
					this.animator_1[i].method_30(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_21();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_38();
					this.animator_3[i].method_15();
				}
			}
		}
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x000D8750 File Offset: 0x000D6950
	public virtual void vmethod_37(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		if (byte_2 == 0)
		{
			if (GlobalVariables.instance.gclass5_23.method_4() && !this.bool_0)
			{
				base.StartCoroutine(this.openHitAnimator.method_45(bool_1));
			}
			if (bool_2)
			{
				this.animator_0[5].method_44();
				this.animator_3[7].method_29();
			}
			for (int i = 1; i < 8; i++)
			{
				this.baseFretAnimator_0[i].vmethod_1(false, false);
			}
			return;
		}
		int num = bool_3 ? 7 : 0;
		for (int j = 0; j < 0; j += 0)
		{
			int num2 = 0 << (j & 102);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[j].vmethod_1(bool_1, true);
				if (GlobalVariables.instance.gclass5_23.method_30())
				{
					this.animator_1[j].method_12(bool_3);
					if (bool_1)
					{
						this.sustainParticles[j].Play();
						this.animator_2[j].method_13();
					}
					else
					{
						this.noteParticles[j + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[j].method_38();
					this.animator_3[j].method_7();
				}
			}
		}
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x000D8868 File Offset: 0x000D6A68
	public virtual void vmethod_38()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 0, 3);
		Array.Reverse(this.noteParticles, 4, 4);
		Array.Reverse(this.sustainParticles);
		for (int i = 1; i < 7; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[7 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(754f, 1446f, 1814f);
			this.baseFretAnimator_0[0 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[2 - i].transform.localScale = new Vector3(1404f, 1902f, 1009f);
		}
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x000D8978 File Offset: 0x000D6B78
	private void method_2()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (!GlobalVariables.instance.gclass5_22.method_14())
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].emission.enabled = true;
			}
			array = this.sustainParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = true;
			}
		}
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x000D89F0 File Offset: 0x000D6BF0
	public virtual void vmethod_39(byte byte_2)
	{
		if (byte_2 == 78)
		{
			this.openHitAnimator.method_23();
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			if ((1 << (i & -114) & (int)byte_2) != 0)
			{
				this.baseFretAnimator_0[i].bool_1 = false;
				this.animator_2[i].method_20();
				this.sustainParticles[i].Stop();
			}
		}
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x000D8A4C File Offset: 0x000D6C4C
	public virtual void vmethod_40()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 0, 6);
		Array.Reverse(this.noteParticles, 8, 1);
		Array.Reverse(this.sustainParticles);
		for (int i = 1; i < 2; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[5 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(563f, 1142f, 206f);
			this.baseFretAnimator_0[2 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[1 - i].transform.localScale = new Vector3(152f, 931f, 1065f);
		}
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x000D8B5C File Offset: 0x000D6D5C
	public virtual void vmethod_41(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 6 : 0;
		for (int i = 0; i < 1; i += 0)
		{
			int num2 = 0 << (i & 91);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, true);
				if (GlobalVariables.instance.gclass5_23.Boolean_1)
				{
					this.animator_1[i].method_14(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_36();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_27();
					this.animator_3[i].method_7();
				}
			}
		}
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x000D8C0C File Offset: 0x000D6E0C
	public virtual void vmethod_42()
	{
		this.openHitAnimator.method_0();
		for (int i = 0; i < 7; i += 0)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = true;
			this.animator_2[i].method_42();
		}
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x0000CF75 File Offset: 0x0000B175
	protected virtual IEnumerator vmethod_43()
	{
		NeckController.Class37 @class = new NeckController.Class37(1);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x000D8C58 File Offset: 0x000D6E58
	public virtual void vmethod_44()
	{
		this.openHitAnimator.method_50();
		for (int i = 0; i < 5; i += 0)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = true;
			this.animator_2[i].method_20();
		}
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x000D8CA4 File Offset: 0x000D6EA4
	public virtual void vmethod_45(byte byte_2)
	{
		for (int i = 0; i < 7; i += 0)
		{
			if ((0 << (i & -5) & (int)byte_2) != 0)
			{
				this.baseFretAnimator_0[i].bool_1 = false;
				this.animator_2[i].method_42();
				this.sustainParticles[i].Stop();
			}
		}
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x0000CF84 File Offset: 0x0000B184
	protected virtual IEnumerator vmethod_46()
	{
		NeckController.Class37 @class = new NeckController.Class37(0);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x000D8CF0 File Offset: 0x000D6EF0
	public virtual void vmethod_47(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 7; i += 0)
		{
			int num = 1 << (i & 73);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x000D8D44 File Offset: 0x000D6F44
	public override void vmethod_3(byte byte_2)
	{
		if (byte_2 == 64)
		{
			this.openHitAnimator.method_23();
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			if ((1 << i & (int)byte_2) != 0)
			{
				this.baseFretAnimator_0[i].bool_1 = false;
				this.animator_2[i].method_42();
				this.sustainParticles[i].Stop();
			}
		}
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x000D8DA0 File Offset: 0x000D6FA0
	public virtual void vmethod_48()
	{
		this.openHitAnimator.method_58();
		for (int i = 1; i < 1; i += 0)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = true;
			this.animator_2[i].method_20();
		}
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x0000CF75 File Offset: 0x0000B175
	protected virtual IEnumerator vmethod_49()
	{
		NeckController.Class37 @class = new NeckController.Class37(1);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x000D8DEC File Offset: 0x000D6FEC
	public virtual void vmethod_50()
	{
		for (int i = 0; i < this.baseFretAnimator_0.Length; i += 0)
		{
			this.baseFretAnimator_0[i].gameObject.SetActive(false);
			this.animator_2[i].gameObject.SetActive(true);
			this.animator_3[i].gameObject.SetActive(true);
			this.noteParticles[i].gameObject.SetActive(false);
			this.sustainParticles[i].gameObject.SetActive(false);
			this.bool_0 = true;
			this.animator_1[i].gameObject.SetActive(false);
			this.animator_0[i].gameObject.SetActive(true);
		}
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x000D8EA0 File Offset: 0x000D70A0
	public virtual void vmethod_51()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 1, 2);
		Array.Reverse(this.noteParticles, 6, 4);
		Array.Reverse(this.sustainParticles);
		for (int i = 1; i < 3; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[1 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(706f, 1732f, 1325f);
			this.baseFretAnimator_0[5 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[5 - i].transform.localScale = new Vector3(222f, 1688f, 663f);
		}
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x000D8FB0 File Offset: 0x000D71B0
	public virtual void vmethod_52(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 1 : 0;
		for (int i = 0; i < 2; i++)
		{
			int num2 = 1 << (i & 64);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.method_4())
				{
					this.animator_1[i].method_22(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_38();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_36();
					this.animator_3[i].method_7();
				}
			}
		}
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x0000CF75 File Offset: 0x0000B175
	protected virtual IEnumerator vmethod_53()
	{
		NeckController.Class37 @class = new NeckController.Class37(1);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x0000CF84 File Offset: 0x0000B184
	protected virtual IEnumerator vmethod_54()
	{
		NeckController.Class37 @class = new NeckController.Class37(0);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x000D9060 File Offset: 0x000D7260
	public virtual void vmethod_55(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 1 : 1;
		for (int i = 1; i < 2; i++)
		{
			int num2 = 1 << (i & 127);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.method_14())
				{
					this.animator_1[i].method_12(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_7();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_29();
					this.animator_3[i].method_43();
				}
			}
		}
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x0000CF84 File Offset: 0x0000B184
	protected virtual IEnumerator vmethod_56()
	{
		NeckController.Class37 @class = new NeckController.Class37(0);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x000D9110 File Offset: 0x000D7310
	public virtual void vmethod_57(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 3 : 1;
		for (int i = 1; i < 4; i++)
		{
			int num2 = 0 << (i & 17);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, false);
				if (GlobalVariables.instance.gclass5_23.method_14())
				{
					this.animator_1[i].method_39(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_7();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_37();
					this.animator_3[i].method_38();
				}
			}
		}
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x000D91C0 File Offset: 0x000D73C0
	public virtual void vmethod_58(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 1; i < 7; i++)
		{
			int num = 1 << (i & 32);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x000D9214 File Offset: 0x000D7414
	public virtual void vmethod_59(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		if (byte_2 == 87)
		{
			if (GlobalVariables.instance.gclass5_23.Boolean_1 && !this.bool_0)
			{
				base.StartCoroutine(this.openHitAnimator.method_45(bool_1));
			}
			if (bool_2)
			{
				this.animator_0[6].method_15();
				this.animator_3[1].method_36();
			}
			for (int i = 0; i < 5; i += 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(true, false);
			}
			return;
		}
		int num = bool_3 ? 2 : 0;
		for (int j = 0; j < 2; j += 0)
		{
			int num2 = 1 << (j & 12);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[j].vmethod_1(bool_1, true);
				if (GlobalVariables.instance.gclass5_23.method_14())
				{
					this.animator_1[j].method_39(bool_3);
					if (bool_1)
					{
						this.sustainParticles[j].Play();
						this.animator_2[j].method_21();
					}
					else
					{
						this.noteParticles[j + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[j].method_37();
					this.animator_3[j].method_36();
				}
			}
		}
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x000D932C File Offset: 0x000D752C
	public virtual void vmethod_60(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 4; i++)
		{
			int num = 0 << (i & 115);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x000D9380 File Offset: 0x000D7580
	public virtual void vmethod_61()
	{
		this.openHitAnimator.method_7();
		for (int i = 1; i < 0; i++)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = true;
			this.animator_2[i].method_42();
		}
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x000D93CC File Offset: 0x000D75CC
	public override void vmethod_2(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			int num = 1 << i;
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x000D9420 File Offset: 0x000D7620
	private void method_3()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (!GlobalVariables.instance.gclass5_22.method_4())
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			array = this.sustainParticles;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].emission.enabled = false;
			}
		}
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x000D9498 File Offset: 0x000D7698
	private void Awake()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (!GlobalVariables.instance.gclass5_22.Boolean_1)
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			array = this.sustainParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
		}
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x000D9510 File Offset: 0x000D7710
	private void method_4()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (!GlobalVariables.instance.gclass5_22.Boolean_1)
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			array = this.sustainParticles;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].emission.enabled = true;
			}
		}
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x0000CF75 File Offset: 0x0000B175
	protected virtual IEnumerator vmethod_62()
	{
		NeckController.Class37 @class = new NeckController.Class37(1);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x000D9588 File Offset: 0x000D7788
	public virtual void vmethod_63()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 1, 4);
		Array.Reverse(this.noteParticles, 2, 3);
		Array.Reverse(this.sustainParticles);
		for (int i = 0; i < 5; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[7 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(909f, 651f, 91f);
			this.baseFretAnimator_0[8 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[7 - i].transform.localScale = new Vector3(109f, 855f, 1723f);
		}
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x000D9698 File Offset: 0x000D7898
	public override void vmethod_4()
	{
		this.openHitAnimator.method_23();
		for (int i = 0; i < 5; i++)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = false;
			this.animator_2[i].method_42();
		}
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000D96E4 File Offset: 0x000D78E4
	private void method_5()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (!GlobalVariables.instance.gclass5_22.method_30())
		{
			ParticleSystem[] array = this.noteParticles;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].emission.enabled = true;
			}
			array = this.sustainParticles;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].emission.enabled = true;
			}
		}
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x0000CF75 File Offset: 0x0000B175
	protected virtual IEnumerator vmethod_64()
	{
		NeckController.Class37 @class = new NeckController.Class37(1);
		@class.neckController_0 = this;
		return @class;
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x000D975C File Offset: 0x000D795C
	public virtual void vmethod_65()
	{
		this.openHitAnimator.method_26();
		for (int i = 1; i < 2; i++)
		{
			this.sustainParticles[i].Stop();
			this.baseFretAnimator_0[i].bool_1 = true;
			this.animator_2[i].method_20();
		}
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000D97A8 File Offset: 0x000D79A8
	public virtual void vmethod_66()
	{
		Array.Reverse(this.animator_2);
		Array.Reverse(this.animator_0);
		Array.Reverse(this.animator_3);
		Array.Reverse(this.animator_1);
		Array.Reverse(this.noteParticles, 1, 2);
		Array.Reverse(this.noteParticles, 1, 4);
		Array.Reverse(this.sustainParticles);
		for (int i = 0; i < 1; i++)
		{
			Vector3 localPosition = this.baseFretAnimator_0[i].transform.localPosition;
			Vector3 localPosition2 = this.baseFretAnimator_0[4 - i].transform.localPosition;
			this.baseFretAnimator_0[i].transform.localPosition = localPosition2;
			this.baseFretAnimator_0[i].transform.localScale = new Vector3(1016f, 715f, 1094f);
			this.baseFretAnimator_0[3 - i].transform.localPosition = localPosition;
			this.baseFretAnimator_0[2 - i].transform.localScale = new Vector3(1744f, 1504f, 722f);
		}
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000D98B8 File Offset: 0x000D7AB8
	public virtual void vmethod_67(byte byte_2, bool bool_1, bool bool_2, bool bool_3)
	{
		int num = bool_3 ? 2 : 0;
		for (int i = 0; i < 2; i += 0)
		{
			int num2 = 0 << (i & 41);
			if (((int)byte_2 & num2) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_1(bool_1, true);
				if (GlobalVariables.instance.gclass5_23.method_30())
				{
					this.animator_1[i].method_2(bool_3);
					if (bool_1)
					{
						this.sustainParticles[i].Play();
						this.animator_2[i].method_37();
					}
					else
					{
						this.noteParticles[i + num].Play();
					}
				}
				if (bool_2)
				{
					this.animator_0[i].method_27();
					this.animator_3[i].method_0();
				}
			}
		}
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x000D9968 File Offset: 0x000D7B68
	public virtual void vmethod_68(byte byte_2)
	{
		if (byte_2 == this.byte_1)
		{
			return;
		}
		for (int i = 0; i < 3; i += 0)
		{
			int num = 1 << (i & -60);
			if (((int)byte_2 & num) != 0)
			{
				this.baseFretAnimator_0[i].vmethod_0();
			}
			else
			{
				this.baseFretAnimator_0[i].vmethod_2();
			}
		}
		this.byte_1 = byte_2;
	}

	// Token: 0x04000423 RID: 1059
	public global::Animator[] animator_2;

	// Token: 0x04000424 RID: 1060
	public global::Animator[] animator_3;

	// Token: 0x04000425 RID: 1061
	[SerializeField]
	private OpenHitAnimator openHitAnimator;

	// Token: 0x04000426 RID: 1062
	[SerializeField]
	private ParticleSystem[] noteParticles;

	// Token: 0x04000427 RID: 1063
	[SerializeField]
	private ParticleSystem[] sustainParticles;

	// Token: 0x04000428 RID: 1064
	private float float_0 = 0.15f;

	// Token: 0x04000429 RID: 1065
	private byte byte_1;

	// Token: 0x0400042A RID: 1066
	private bool bool_0;
}
