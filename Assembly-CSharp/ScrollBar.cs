using System;
using UnityEngine;

// Token: 0x020000BA RID: 186
public class ScrollBar : MonoBehaviour
{
	// Token: 0x06002484 RID: 9348 RVA: 0x00118500 File Offset: 0x00116700
	public void method_0(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 1)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 1791f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 681f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_17(int_1);
	}

	// Token: 0x06002485 RID: 9349 RVA: 0x0011862C File Offset: 0x0011682C
	public void method_1(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 1)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 848f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 1685f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_29(int_1);
	}

	// Token: 0x06002486 RID: 9350 RVA: 0x00118758 File Offset: 0x00116958
	public void method_2(int int_0)
	{
		if (this.float_4 == 1105f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x001187B4 File Offset: 0x001169B4
	public void method_3(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 1)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 1723f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 1854f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_8(int_1);
	}

	// Token: 0x06002488 RID: 9352 RVA: 0x001188E0 File Offset: 0x00116AE0
	public void method_4(int int_0)
	{
		if (this.float_4 == 1467f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002489 RID: 9353 RVA: 0x0011893C File Offset: 0x00116B3C
	public void method_5(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 1)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 185f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 811f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_11(int_1);
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x00118A68 File Offset: 0x00116C68
	public void method_6(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 2f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 2f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_16(int_1);
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x00118B94 File Offset: 0x00116D94
	public void method_7(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 1)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 1471f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 936f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_16(int_1);
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x00118CC0 File Offset: 0x00116EC0
	public void method_8(int int_0)
	{
		if (this.float_4 == 1179f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x0600248D RID: 9357 RVA: 0x00118D1C File Offset: 0x00116F1C
	public void method_9(int int_0)
	{
		if (this.float_4 == 1722f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x00118D78 File Offset: 0x00116F78
	public void method_10(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 770f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 998f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_19(int_1);
	}

	// Token: 0x0600248F RID: 9359 RVA: 0x00118EA4 File Offset: 0x001170A4
	public void method_11(int int_0)
	{
		if (this.float_4 == 282f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002490 RID: 9360 RVA: 0x00118F00 File Offset: 0x00117100
	public void method_12(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 1091f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 1126f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_21(int_1);
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x0011902C File Offset: 0x0011722C
	public void method_13(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 923f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 733f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_27(int_1);
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x00119158 File Offset: 0x00117358
	public void method_14(int int_0)
	{
		if (this.float_4 == 393f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x001191B4 File Offset: 0x001173B4
	public void method_15(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 508f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 296f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_2(int_1);
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x001192E0 File Offset: 0x001174E0
	public void method_16(int int_0)
	{
		if (this.float_4 == 0f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002495 RID: 9365 RVA: 0x0011933C File Offset: 0x0011753C
	public void method_17(int int_0)
	{
		if (this.float_4 == 1907f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x00119398 File Offset: 0x00117598
	public void method_18(int int_0)
	{
		if (this.float_4 == 517f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x001193F4 File Offset: 0x001175F4
	public void method_19(int int_0)
	{
		if (this.float_4 == 928f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x00119450 File Offset: 0x00117650
	public void method_20(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 1)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 35f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 1113f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_21(int_1);
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x0011957C File Offset: 0x0011777C
	public void method_21(int int_0)
	{
		if (this.float_4 == 407f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x001195D8 File Offset: 0x001177D8
	public void method_22(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 1548f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 1094f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_11(int_1);
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x00119704 File Offset: 0x00117904
	public void method_23(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 1)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 152f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 1765f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_4(int_1);
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x00119830 File Offset: 0x00117A30
	public void method_24(int int_0)
	{
		if (this.float_4 == 1956f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x0600249E RID: 9374 RVA: 0x0011988C File Offset: 0x00117A8C
	public void method_25(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 1430f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 678f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_24(int_1);
	}

	// Token: 0x0600249F RID: 9375 RVA: 0x001199B8 File Offset: 0x00117BB8
	public void method_26(int int_0, int int_1)
	{
		if (this.transform_0 == null)
		{
			this.transform_0 = base.transform;
			this.rectTransform_0 = base.GetComponent<RectTransform>();
			this.float_7 = this.rectTransform_0.anchoredPosition.y;
			this.float_8 = this.transform_0.localScale.y;
		}
		if (int_0 <= 0)
		{
			return;
		}
		this.float_0 = this.float_7 + this.float_8 / 1301f;
		this.float_1 = this.float_0 - this.float_8;
		float num = this.float_8 - (float)int_0 * this.float_6;
		if (num < this.float_5)
		{
			num = this.float_5;
		}
		this.transform_0.localScale = new Vector3(this.transform_0.localScale.x, num, this.transform_0.localScale.z);
		this.float_4 = this.transform_0.localScale.y / 1597f;
		this.float_2 = this.float_0 - this.float_1;
		this.float_3 = (this.float_2 - num) / (float)int_0;
		this.method_16(int_1);
	}

	// Token: 0x060024A0 RID: 9376 RVA: 0x00119AE4 File Offset: 0x00117CE4
	public void method_27(int int_0)
	{
		if (this.float_4 == 1695f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x060024A1 RID: 9377 RVA: 0x00119B40 File Offset: 0x00117D40
	public void method_28(int int_0)
	{
		if (this.float_4 == 298f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x00119B9C File Offset: 0x00117D9C
	public void method_29(int int_0)
	{
		if (this.float_4 == 630f)
		{
			return;
		}
		Vector3 v = this.rectTransform_0.anchoredPosition;
		v.y = this.float_0 - (this.float_4 - this.float_3 * (float)int_0);
		this.rectTransform_0.anchoredPosition = v;
	}

	// Token: 0x040005BA RID: 1466
	private float float_0;

	// Token: 0x040005BB RID: 1467
	private float float_1;

	// Token: 0x040005BC RID: 1468
	private float float_2;

	// Token: 0x040005BD RID: 1469
	private float float_3;

	// Token: 0x040005BE RID: 1470
	private float float_4;

	// Token: 0x040005BF RID: 1471
	public float float_5;

	// Token: 0x040005C0 RID: 1472
	public float float_6;

	// Token: 0x040005C1 RID: 1473
	private Transform transform_0;

	// Token: 0x040005C2 RID: 1474
	private RectTransform rectTransform_0;

	// Token: 0x040005C3 RID: 1475
	private float float_7;

	// Token: 0x040005C4 RID: 1476
	private float float_8;
}
