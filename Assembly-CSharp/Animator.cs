using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class Animator : MonoBehaviour
{
	// Token: 0x06001601 RID: 5633 RVA: 0x0000BB92 File Offset: 0x00009D92
	private void Start()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_15();
		}
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x0000BBD0 File Offset: 0x00009DD0
	public void method_0()
	{
		this.int_0 = 1;
		this.int_2 = 1;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_3();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x0000BC0D File Offset: 0x00009E0D
	public void method_1()
	{
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.spriteRenderer_0.sprite = null;
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x0000BC2F File Offset: 0x00009E2F
	public void method_2(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_7();
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x0000BC5E File Offset: 0x00009E5E
	private IEnumerator method_3()
	{
		global::Animator.Class31 @class = new global::Animator.Class31(0);
		@class.animator_0 = this;
		return @class;
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x0000BC6D File Offset: 0x00009E6D
	private void method_4()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_36();
		}
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x0000BC5E File Offset: 0x00009E5E
	private IEnumerator method_5()
	{
		global::Animator.Class31 @class = new global::Animator.Class31(0);
		@class.animator_0 = this;
		return @class;
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x0000BCAB File Offset: 0x00009EAB
	public void method_6(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_43();
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x0000BCDA File Offset: 0x00009EDA
	public void method_7()
	{
		this.int_0 = 1;
		this.int_2 = 0;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_3();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x0000BD17 File Offset: 0x00009F17
	public void method_8(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_29();
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x0000BC5E File Offset: 0x00009E5E
	private IEnumerator method_9()
	{
		global::Animator.Class31 @class = new global::Animator.Class31(0);
		@class.animator_0 = this;
		return @class;
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x0000BD46 File Offset: 0x00009F46
	private void method_10()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_7();
		}
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x0000BD84 File Offset: 0x00009F84
	public void method_11()
	{
		this.int_0 = 1;
		this.int_2 = 1;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_19();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x0000BDC1 File Offset: 0x00009FC1
	public void method_12(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_13();
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x0000BE03 File Offset: 0x0000A003
	public void method_13()
	{
		this.int_0 = 0;
		this.int_2 = 0;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_3();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x0000BCAB File Offset: 0x00009EAB
	public void method_14(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_43();
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x0000BE40 File Offset: 0x0000A040
	public void method_15()
	{
		this.int_0 = 0;
		this.int_2 = 0;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_9();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x0000BE7D File Offset: 0x0000A07D
	private void method_16()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_37();
		}
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x0000BC0D File Offset: 0x00009E0D
	public void method_17()
	{
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.spriteRenderer_0.sprite = null;
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x0000BC2F File Offset: 0x00009E2F
	public void method_18(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_7();
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x0000BC5E File Offset: 0x00009E5E
	private IEnumerator method_19()
	{
		global::Animator.Class31 @class = new global::Animator.Class31(0);
		@class.animator_0 = this;
		return @class;
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x0000BC0D File Offset: 0x00009E0D
	public void method_20()
	{
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.spriteRenderer_0.sprite = null;
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x0000BEBB File Offset: 0x0000A0BB
	public void method_21()
	{
		this.int_0 = 1;
		this.int_2 = 1;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_33();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x0000BD17 File Offset: 0x00009F17
	public void method_22(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_29();
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
	private void method_23()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_21();
		}
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x0000BC2F File Offset: 0x00009E2F
	public void method_24(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_7();
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x0000BC0D File Offset: 0x00009E0D
	public void method_25()
	{
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.spriteRenderer_0.sprite = null;
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x0000BF36 File Offset: 0x0000A136
	public void method_26(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_44();
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x0000BD84 File Offset: 0x00009F84
	public void method_27()
	{
		this.int_0 = 1;
		this.int_2 = 1;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_19();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x0000BF65 File Offset: 0x0000A165
	private void method_28()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_13();
		}
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x0000BE03 File Offset: 0x0000A003
	public void method_29()
	{
		this.int_0 = 0;
		this.int_2 = 0;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_3();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x06001621 RID: 5665 RVA: 0x0000BFA3 File Offset: 0x0000A1A3
	public void method_30(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_37();
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x0000BFD2 File Offset: 0x0000A1D2
	private void method_31()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_44();
		}
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x0000C010 File Offset: 0x0000A210
	private void method_32()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_43();
		}
	}

	// Token: 0x06001624 RID: 5668 RVA: 0x0000BC5E File Offset: 0x00009E5E
	private IEnumerator method_33()
	{
		global::Animator.Class31 @class = new global::Animator.Class31(0);
		@class.animator_0 = this;
		return @class;
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x0000BB92 File Offset: 0x00009D92
	private void method_34()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_15();
		}
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x0000C04E File Offset: 0x0000A24E
	public void method_35(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_15();
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x0000C07D File Offset: 0x0000A27D
	public void method_36()
	{
		this.int_0 = 0;
		this.int_2 = 1;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_41();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x0000C0BA File Offset: 0x0000A2BA
	public void method_37()
	{
		this.int_0 = 0;
		this.int_2 = 0;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_19();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x0000C0F7 File Offset: 0x0000A2F7
	public void method_38()
	{
		this.int_0 = 1;
		this.int_2 = 0;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_41();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x0000BC2F File Offset: 0x00009E2F
	public void method_39(bool bool_2)
	{
		if (bool_2)
		{
			this.spriteRenderer_0.color = this.color_1;
		}
		else
		{
			this.spriteRenderer_0.color = this.color_0;
		}
		this.method_7();
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x0000C134 File Offset: 0x0000A334
	private void method_40()
	{
		this.spriteRenderer_0 = base.GetComponent<SpriteRenderer>();
		this.color_0 = this.spriteRenderer_0.color;
		this.waitForSeconds_0 = new WaitForSeconds(this.float_0);
		if (this.bool_1)
		{
			this.method_29();
		}
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x0000C172 File Offset: 0x0000A372
	private IEnumerator method_41()
	{
		global::Animator.Class31 @class = new global::Animator.Class31(1);
		@class.animator_0 = this;
		return @class;
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x0000BC0D File Offset: 0x00009E0D
	public void method_42()
	{
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.spriteRenderer_0.sprite = null;
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0000BD84 File Offset: 0x00009F84
	public void method_43()
	{
		this.int_0 = 1;
		this.int_2 = 1;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_19();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x0000C181 File Offset: 0x0000A381
	public void method_44()
	{
		this.int_0 = 1;
		this.int_2 = 0;
		if (this.bool_0)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_19();
		base.StartCoroutine(this.ienumerator_0);
	}

	// Token: 0x0400034C RID: 844
	public float float_0 = 0.01f;

	// Token: 0x0400034D RID: 845
	private SpriteRenderer spriteRenderer_0;

	// Token: 0x0400034E RID: 846
	private int int_0;

	// Token: 0x0400034F RID: 847
	public Sprite[] sprite_0;

	// Token: 0x04000350 RID: 848
	private IEnumerator ienumerator_0;

	// Token: 0x04000351 RID: 849
	private bool bool_0;

	// Token: 0x04000352 RID: 850
	private Color color_0;

	// Token: 0x04000353 RID: 851
	public Color color_1;

	// Token: 0x04000354 RID: 852
	private WaitForSeconds waitForSeconds_0;

	// Token: 0x04000355 RID: 853
	public int int_1;

	// Token: 0x04000356 RID: 854
	private int int_2;

	// Token: 0x04000357 RID: 855
	public bool bool_1;
}
