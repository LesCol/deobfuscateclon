using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200007B RID: 123
public class CameraShake : MonoBehaviour
{
	// Token: 0x060016B5 RID: 5813 RVA: 0x0000C381 File Offset: 0x0000A581
	public void method_0()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_2());
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_1()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_2()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x0000C3AD File Offset: 0x0000A5AD
	private void method_3()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = GlobalVariables.instance.gclass5_29.Boolean_1;
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_4()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
	public void method_5()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_7());
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x0000C401 File Offset: 0x0000A601
	public void method_6()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_20());
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x0000C41E File Offset: 0x0000A61E
	private IEnumerator method_7()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(0);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x0000C42D File Offset: 0x0000A62D
	private void Start()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = !GlobalVariables.instance.gclass5_29.Boolean_1;
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x0000C464 File Offset: 0x0000A664
	public void method_8()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_40());
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x0000C381 File Offset: 0x0000A581
	public void method_9()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_2());
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x0000C481 File Offset: 0x0000A681
	private void method_10()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = GlobalVariables.instance.gclass5_29.method_14();
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x0000C41E File Offset: 0x0000A61E
	private IEnumerator method_11()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(0);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_12()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x0000C481 File Offset: 0x0000A681
	private void method_13()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = GlobalVariables.instance.gclass5_29.method_14();
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x0000C4EA File Offset: 0x0000A6EA
	private void method_14()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = GlobalVariables.instance.gclass5_29.method_4();
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_15()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x0000C521 File Offset: 0x0000A721
	public void method_16()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_41());
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_17()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_18()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x0000C53E File Offset: 0x0000A73E
	public void method_19()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_26());
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_20()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x0000C55B File Offset: 0x0000A75B
	public void method_21()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_18());
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x0000C481 File Offset: 0x0000A681
	private void method_22()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = GlobalVariables.instance.gclass5_29.method_14();
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_23()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
	public void method_24()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_7());
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x0000C578 File Offset: 0x0000A778
	private void method_25()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = !GlobalVariables.instance.gclass5_29.method_4();
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x0000C41E File Offset: 0x0000A61E
	private IEnumerator method_26()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(0);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x0000C3AD File Offset: 0x0000A5AD
	private void method_27()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = GlobalVariables.instance.gclass5_29.Boolean_1;
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x0000C42D File Offset: 0x0000A62D
	private void method_28()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = !GlobalVariables.instance.gclass5_29.Boolean_1;
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_29()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x0000C5AF File Offset: 0x0000A7AF
	private void method_30()
	{
		this.transform_0 = base.transform;
		this.vector3_1 = this.transform_0.localPosition;
		this.bool_0 = GlobalVariables.instance.gclass5_29.method_30();
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x0000C5E6 File Offset: 0x0000A7E6
	public void method_31()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_4());
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x0000C603 File Offset: 0x0000A803
	public void method_32()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_12());
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x0000C41E File Offset: 0x0000A61E
	private IEnumerator method_33()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(0);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_34()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_35()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_36()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x0000C41E File Offset: 0x0000A61E
	private IEnumerator method_37()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(0);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x0000C620 File Offset: 0x0000A820
	public void method_38()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_33());
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x0000C620 File Offset: 0x0000A820
	public void method_39()
	{
		if (this.bool_0)
		{
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_33());
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_40()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x0000C39E File Offset: 0x0000A59E
	private IEnumerator method_41()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(1);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x0000C41E File Offset: 0x0000A61E
	private IEnumerator method_42()
	{
		CameraShake.Class32 @class = new CameraShake.Class32(0);
		@class.cameraShake_0 = this;
		return @class;
	}

	// Token: 0x0400039A RID: 922
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(0.016f);

	// Token: 0x0400039B RID: 923
	private Transform transform_0;

	// Token: 0x0400039C RID: 924
	private Coroutine coroutine_0;

	// Token: 0x0400039D RID: 925
	public Vector3 vector3_0 = new Vector3(0.02f, 1.02f, -6.33f);

	// Token: 0x0400039E RID: 926
	private Vector3 vector3_1;

	// Token: 0x0400039F RID: 927
	private Vector3 vector3_2;

	// Token: 0x040003A0 RID: 928
	private bool bool_0;
}
