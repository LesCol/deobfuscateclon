using System;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public class VisibleHitWindow : MonoBehaviour
{
	// Token: 0x06002771 RID: 10097 RVA: 0x0012DC00 File Offset: 0x0012BE00
	private void method_0()
	{
		this.transform_0.localScale = new Vector3(1945f, this.float_0 * 220f * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue);
		this.transform_0.localPosition = new Vector3(1871f, 1136f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25()));
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x0012DC88 File Offset: 0x0012BE88
	private void method_1()
	{
		if (!GlobalVariables.instance.gclass5_33.method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_21();
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x0012DCEC File Offset: 0x0012BEEC
	private void method_2()
	{
		this.transform_0.localScale = new Vector3(1810f, this.float_0 * 443f * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue);
		this.transform_0.localPosition = new Vector3(1984f, 1918f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_5()));
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x0012DD74 File Offset: 0x0012BF74
	private void method_3()
	{
		if (!GlobalVariables.instance.gclass5_33.method_14())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_15();
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x0012DDD8 File Offset: 0x0012BFD8
	private void method_4()
	{
		this.transform_0.localScale = new Vector3(554f, this.float_0 * 783f * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25());
		this.transform_0.localPosition = new Vector3(1601f, 628f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue));
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x0012DE60 File Offset: 0x0012C060
	private void method_5()
	{
		if (!GlobalVariables.instance.gclass5_33.method_14())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_6();
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x0012DEC4 File Offset: 0x0012C0C4
	private void method_6()
	{
		this.transform_0.localScale = new Vector3(712f, this.float_0 * 450f * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue);
		this.transform_0.localPosition = new Vector3(606f, 1950f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue));
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x0012DF4C File Offset: 0x0012C14C
	private void method_7()
	{
		this.transform_0.localScale = new Vector3(952f, this.float_0 * 1491f * (float)this.gclass9_0.gclass10_0.gclass5_0.method_5());
		this.transform_0.localPosition = new Vector3(1002f, 941f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25()));
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x0012DFD4 File Offset: 0x0012C1D4
	private void method_8()
	{
		this.transform_0.localScale = new Vector3(268f, this.float_0 * 466f * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue);
		this.transform_0.localPosition = new Vector3(687f, 1460f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25()));
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x0012E05C File Offset: 0x0012C25C
	private void method_9()
	{
		this.transform_0.localScale = new Vector3(95f, this.float_0 * 811f * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue);
		this.transform_0.localPosition = new Vector3(1548f, 1900f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25()));
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x0012E0E4 File Offset: 0x0012C2E4
	private void method_10()
	{
		if (!GlobalVariables.instance.gclass5_33.Boolean_1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_9();
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x0012E148 File Offset: 0x0012C348
	private void method_11()
	{
		if (!GlobalVariables.instance.gclass5_33.Boolean_1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_7();
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x0012E1AC File Offset: 0x0012C3AC
	private void Start()
	{
		if (!GlobalVariables.instance.gclass5_33.Boolean_1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_16();
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x0012E210 File Offset: 0x0012C410
	private void method_12()
	{
		if (!GlobalVariables.instance.gclass5_33.method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_22();
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x0012E274 File Offset: 0x0012C474
	private void method_13()
	{
		this.transform_0.localScale = new Vector3(1884f, this.float_0 * 470f * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue);
		this.transform_0.localPosition = new Vector3(833f, 29f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_5()));
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x0012E2FC File Offset: 0x0012C4FC
	private void method_14()
	{
		this.transform_0.localScale = new Vector3(1339f, this.float_0 * 1668f * (float)this.gclass9_0.gclass10_0.gclass5_0.method_5());
		this.transform_0.localPosition = new Vector3(25f, 525f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25()));
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x0012E384 File Offset: 0x0012C584
	private void method_15()
	{
		this.transform_0.localScale = new Vector3(1771f, this.float_0 * 180f * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25());
		this.transform_0.localPosition = new Vector3(1484f, 701f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_5()));
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x0012E40C File Offset: 0x0012C60C
	private void method_16()
	{
		this.transform_0.localScale = new Vector3(1f, this.float_0 * 2f * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue);
		this.transform_0.localPosition = new Vector3(0f, 0f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue));
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x0012E494 File Offset: 0x0012C694
	private void method_17()
	{
		if (!GlobalVariables.instance.gclass5_33.method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_16();
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x0012E4F8 File Offset: 0x0012C6F8
	private void method_18()
	{
		if (!GlobalVariables.instance.gclass5_33.method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_16();
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x0012E494 File Offset: 0x0012C694
	private void method_19()
	{
		if (!GlobalVariables.instance.gclass5_33.method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = true;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_16();
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x0012E55C File Offset: 0x0012C75C
	private void method_20()
	{
		if (!GlobalVariables.instance.gclass5_33.method_14())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_22();
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x0012E5C0 File Offset: 0x0012C7C0
	private void method_21()
	{
		this.transform_0.localScale = new Vector3(231f, this.float_0 * 1493f * (float)this.gclass9_0.gclass10_0.gclass5_0.method_5());
		this.transform_0.localPosition = new Vector3(1020f, 445f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.CurrentValue));
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x0012E648 File Offset: 0x0012C848
	private void method_22()
	{
		this.transform_0.localScale = new Vector3(831f, this.float_0 * 670f * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25());
		this.transform_0.localPosition = new Vector3(967f, 1875f, -(GlobalVariables.instance.videoOffset.Single_2 * (float)this.gclass9_0.gclass10_0.gclass5_0.method_25()));
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x0012E6D0 File Offset: 0x0012C8D0
	private void method_23()
	{
		if (!GlobalVariables.instance.gclass5_33.method_14())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.GetComponent<SpriteRenderer>().enabled = false;
		this.transform_0 = base.transform;
		this.gclass9_0 = this.transform_0.parent.GetComponent<BasePlayer>().player;
		this.method_4();
	}

	// Token: 0x04000600 RID: 1536
	private Transform transform_0;

	// Token: 0x04000601 RID: 1537
	private float float_0 = 0.07f;

	// Token: 0x04000602 RID: 1538
	private CHPlayer gclass9_0;
}
