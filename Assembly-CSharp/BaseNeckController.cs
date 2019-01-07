using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000079 RID: 121
public abstract class BaseNeckController : MonoBehaviour
{
	// Token: 0x06001695 RID: 5781
	public abstract void vmethod_0();

	// Token: 0x06001696 RID: 5782
	public abstract void vmethod_1(byte byte_1, bool bool_0, bool bool_1, bool bool_2);

	// Token: 0x06001697 RID: 5783
	public abstract void vmethod_2(byte byte_1);

	// Token: 0x06001698 RID: 5784
	public abstract void vmethod_3(byte byte_1);

	// Token: 0x06001699 RID: 5785
	public abstract void vmethod_4();

	// Token: 0x0600169A RID: 5786
	protected abstract IEnumerator vmethod_5();

	// Token: 0x0600169B RID: 5787 RVA: 0x000BA754 File Offset: 0x000B8954
	public virtual void vmethod_6()
	{
		base.StartCoroutine(this.vmethod_5());
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.gclass5_4.Boolean_1 || !GlobalVariables.instance.gclass5_35.Boolean_1)
		{
			global::Animator[] array = this.animator_0;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().enabled = false;
			}
		}
	}

	// Token: 0x0600169C RID: 5788
	public abstract void vmethod_7();

	// Token: 0x0600169D RID: 5789 RVA: 0x000BA7C4 File Offset: 0x000B89C4
	public virtual void vmethod_8()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	// Token: 0x04000366 RID: 870
	public BaseFretAnimator[] baseFretAnimator_0;

	// Token: 0x04000367 RID: 871
	public global::Animator[] animator_0;

	// Token: 0x04000368 RID: 872
	public global::Animator[] animator_1;

	// Token: 0x04000369 RID: 873
	public GameObject[] gameObject_0;

	// Token: 0x0400036A RID: 874
	protected byte byte_0 = 128;
}
