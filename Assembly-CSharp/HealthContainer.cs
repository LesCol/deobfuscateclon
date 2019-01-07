using System;
using UnityEngine;

// Token: 0x02000085 RID: 133
public class HealthContainer : MonoBehaviour
{
	// Token: 0x06001992 RID: 6546 RVA: 0x000D0084 File Offset: 0x000CE284
	public void method_0(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1922f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1961f) * 1001f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 537f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x000D01B4 File Offset: 0x000CE3B4
	private void method_1()
	{
		this.float_5 = 614f;
		this.float_6 = 1650f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x000D0200 File Offset: 0x000CE400
	private void method_2()
	{
		this.float_5 = 1019f;
		this.float_6 = 1444f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x000D024C File Offset: 0x000CE44C
	private void method_3()
	{
		this.float_5 = 1817f;
		this.float_6 = 1933f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x000D0298 File Offset: 0x000CE498
	private void method_4()
	{
		this.float_5 = 1466f;
		this.float_6 = 1014f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x000D02E4 File Offset: 0x000CE4E4
	private void method_5()
	{
		this.float_5 = 910f;
		this.float_6 = 187f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x000D0330 File Offset: 0x000CE530
	public void method_6(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1093f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1215f) * 1858f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 828f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x000D0460 File Offset: 0x000CE660
	private void method_7()
	{
		this.float_5 = 183f;
		this.float_6 = 464f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x000D04AC File Offset: 0x000CE6AC
	public void method_8(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1201f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1025f) * 710f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 474f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x000D05DC File Offset: 0x000CE7DC
	public void method_9(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1244f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 213f) * 1199f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1813f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x000D070C File Offset: 0x000CE90C
	public void method_10(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1560f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1619f) * 493f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1904f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x000D083C File Offset: 0x000CEA3C
	public void method_11(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1982f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 926f) * 1060f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1247f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x000D096C File Offset: 0x000CEB6C
	public void method_12(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1415f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 689f) * 1369f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1928f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x000D0A9C File Offset: 0x000CEC9C
	private void method_13()
	{
		this.float_5 = 1010f;
		this.float_6 = 1956f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x000D0AE8 File Offset: 0x000CECE8
	public void method_14(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 187f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1824f) * 1448f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 497f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x000D0C18 File Offset: 0x000CEE18
	public void method_15(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1294f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 508f) * 842f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 218f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x000D0D48 File Offset: 0x000CEF48
	private void method_16()
	{
		this.float_5 = 548f;
		this.float_6 = 13f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x000D0D94 File Offset: 0x000CEF94
	public void method_17(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1424f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 652f) * 1622f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 256f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x000D0EC4 File Offset: 0x000CF0C4
	private void method_18()
	{
		this.float_5 = 388f;
		this.float_6 = 1074f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x000D0F10 File Offset: 0x000CF110
	public void method_19(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 400f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 898f) * 896f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 546f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x000D1040 File Offset: 0x000CF240
	public void method_20(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 519f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1109f) * 1823f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1839f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x000D1170 File Offset: 0x000CF370
	private void method_21()
	{
		this.float_5 = 1681f;
		this.float_6 = 1817f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x000D11BC File Offset: 0x000CF3BC
	public void method_22(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1638f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1682f) * 772f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1379f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x000D12EC File Offset: 0x000CF4EC
	public void method_23(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 845f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1742f) * 786f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 389f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x000D141C File Offset: 0x000CF61C
	public void method_24(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1654f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 615f) * 1100f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1077f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x000D154C File Offset: 0x000CF74C
	private void method_25()
	{
		this.float_5 = 1050f;
		this.float_6 = 1111f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x000D1598 File Offset: 0x000CF798
	public void method_26(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 210f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 281f) * 1261f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1173f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x000D16C8 File Offset: 0x000CF8C8
	public void method_27(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1320f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 824f) * 22f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 475f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x000D17F8 File Offset: 0x000CF9F8
	private void method_28()
	{
		this.float_5 = 1741f;
		this.float_6 = 909f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x000D1844 File Offset: 0x000CFA44
	public void method_29(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1119f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1256f) * 30f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1479f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x000D1974 File Offset: 0x000CFB74
	public void method_30(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1701f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1072f) * 1347f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1018f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x000D1AA4 File Offset: 0x000CFCA4
	private void Start()
	{
		this.float_5 = 0.333333343f;
		this.float_6 = 0.72f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x000D1AF0 File Offset: 0x000CFCF0
	public void method_31(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 555f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 573f) * 1780f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1811f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x000D1C20 File Offset: 0x000CFE20
	private void method_32()
	{
		this.float_5 = 1621f;
		this.float_6 = 1870f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x000D1C6C File Offset: 0x000CFE6C
	private void method_33()
	{
		this.float_5 = 1901f;
		this.float_6 = 218f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x000D1CB8 File Offset: 0x000CFEB8
	public void method_34(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1808f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 31f) * 1678f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 814f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x000D1DE8 File Offset: 0x000CFFE8
	public void method_35(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1923f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 806f) * 1356f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 593f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x000D1F18 File Offset: 0x000D0118
	private void method_36()
	{
		this.float_5 = 1785f;
		this.float_6 = 948f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x000D1F64 File Offset: 0x000D0164
	public void method_37(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 0.5f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 0.5f) * 2f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 2f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x000D2094 File Offset: 0x000D0294
	public void method_38(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1803f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1868f) * 818f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 824f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x000D21C4 File Offset: 0x000D03C4
	private void method_39()
	{
		this.float_5 = 1491f;
		this.float_6 = 1807f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x000D2210 File Offset: 0x000D0410
	public void method_40(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1719f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 792f) * 691f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1183f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x000D2340 File Offset: 0x000D0540
	private void method_41()
	{
		this.float_5 = 1911f;
		this.float_6 = 242f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x000D238C File Offset: 0x000D058C
	private void method_42()
	{
		this.float_5 = 967f;
		this.float_6 = 1225f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x000D23D8 File Offset: 0x000D05D8
	private void method_43()
	{
		this.float_5 = 672f;
		this.float_6 = 1725f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x000D2424 File Offset: 0x000D0624
	public void method_44(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1823f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1138f) * 866f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 501f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x000D2554 File Offset: 0x000D0754
	public void method_45(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 966f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1801f) * 123f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1677f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x000D2684 File Offset: 0x000D0884
	public void method_46(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1001f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 575f) * 526f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1476f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x000D27B4 File Offset: 0x000D09B4
	public void method_47(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 696f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 626f) * 1163f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1020f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x000D28E4 File Offset: 0x000D0AE4
	private void method_48()
	{
		this.float_5 = 140f;
		this.float_6 = 1475f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x000D2930 File Offset: 0x000D0B30
	private void method_49()
	{
		this.float_5 = 1746f;
		this.float_6 = 1234f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x000D297C File Offset: 0x000D0B7C
	public void method_50(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 490f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1439f) * 1165f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1824f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x000D2AAC File Offset: 0x000D0CAC
	private void method_51()
	{
		this.float_5 = 219f;
		this.float_6 = 873f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x000D2AF8 File Offset: 0x000D0CF8
	public void method_52(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1256f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 891f) * 1857f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 172f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x000D2C28 File Offset: 0x000D0E28
	private void method_53()
	{
		this.float_5 = 6f;
		this.float_6 = 970f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x000D2C74 File Offset: 0x000D0E74
	private void method_54()
	{
		this.float_5 = 712f;
		this.float_6 = 888f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x000D2CC0 File Offset: 0x000D0EC0
	public void method_55(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 835f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 412f) * 1414f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 289f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x000D2DF0 File Offset: 0x000D0FF0
	public void method_56(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1938f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1821f) * 288f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1088f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x000D2F20 File Offset: 0x000D1120
	public void method_57(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1652f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 34f) * 1218f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 742f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x000D3050 File Offset: 0x000D1250
	private void method_58()
	{
		this.float_5 = 453f;
		this.float_6 = 1190f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x000D309C File Offset: 0x000D129C
	public void method_59(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 489f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1910f) * 1614f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 398f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x000D31CC File Offset: 0x000D13CC
	public void method_60(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 876f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 477f) * 1444f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1005f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x000D32FC File Offset: 0x000D14FC
	public void method_61(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 116f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 994f) * 814f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1478f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x000D342C File Offset: 0x000D162C
	public void method_62(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 213f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 4f) * 830f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1045f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x000D355C File Offset: 0x000D175C
	public void method_63(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(true);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1910f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 69f) * 959f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1409f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x000D368C File Offset: 0x000D188C
	public void method_64(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1693f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 574f) * 1121f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 742f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x000D37BC File Offset: 0x000D19BC
	private void method_65()
	{
		this.float_5 = 1722f;
		this.float_6 = 551f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x000D3808 File Offset: 0x000D1A08
	public void method_66(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 1498f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 666f) * 899f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1517f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x000D3938 File Offset: 0x000D1B38
	public void method_67(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(true);
		}
		if (float_7 >= 904f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 287f) * 1572f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1605f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x000D3A68 File Offset: 0x000D1C68
	private void method_68()
	{
		this.float_5 = 1016f;
		this.float_6 = 1704f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x000D3AB4 File Offset: 0x000D1CB4
	public void method_69(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 665f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1577f) * 1607f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1426f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x000D3BE4 File Offset: 0x000D1DE4
	private void method_70()
	{
		this.float_5 = 1612f;
		this.float_6 = 672f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x000D3C30 File Offset: 0x000D1E30
	public void method_71(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(false);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(true);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(true);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 169f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 1870f) * 1316f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 1280f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x000D3D60 File Offset: 0x000D1F60
	private void method_72()
	{
		this.float_5 = 605f;
		this.float_6 = 1747f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(false);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x000D3DAC File Offset: 0x000D1FAC
	private void method_73()
	{
		this.float_5 = 893f;
		this.float_6 = 42f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(true);
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x000D3DF8 File Offset: 0x000D1FF8
	public void method_74(float float_7)
	{
		if (float_7 == this.float_4)
		{
			return;
		}
		if (float_7 > this.float_6)
		{
			if (this.float_4 <= this.float_6)
			{
				this.gameObject_2.SetActive(true);
				this.gameObject_1.SetActive(true);
			}
		}
		else if (float_7 > this.float_5)
		{
			if (this.float_4 > this.float_6)
			{
				this.gameObject_2.SetActive(false);
				this.gameObject_1.SetActive(true);
			}
			else if (this.float_4 <= this.float_5)
			{
				this.gameObject_1.SetActive(false);
				this.gameObject_0.SetActive(false);
			}
		}
		else if (this.float_4 > this.float_5)
		{
			this.gameObject_1.SetActive(false);
			this.gameObject_0.SetActive(false);
		}
		if (float_7 >= 1558f)
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, (float_7 - 621f) * 537f);
		}
		else
		{
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, float_7 * 306f);
		}
		this.float_4 = float_7;
		this.transform_0.localPosition = this.vector3_0;
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x000D3F28 File Offset: 0x000D2128
	private void method_75()
	{
		this.float_5 = 1904f;
		this.float_6 = 968f;
		this.vector3_0 = this.transform_0.position;
		this.gameObject_0.SetActive(true);
		this.gameObject_2.SetActive(false);
	}

	// Token: 0x040003E2 RID: 994
	public GameObject gameObject_0;

	// Token: 0x040003E3 RID: 995
	public GameObject gameObject_1;

	// Token: 0x040003E4 RID: 996
	public GameObject gameObject_2;

	// Token: 0x040003E5 RID: 997
	public Transform transform_0;

	// Token: 0x040003E6 RID: 998
	public SpriteRenderer spriteRenderer_0;

	// Token: 0x040003E7 RID: 999
	public float float_0;

	// Token: 0x040003E8 RID: 1000
	public float float_1;

	// Token: 0x040003E9 RID: 1001
	public float float_2;

	// Token: 0x040003EA RID: 1002
	public float float_3;

	// Token: 0x040003EB RID: 1003
	private float float_4;

	// Token: 0x040003EC RID: 1004
	private float float_5;

	// Token: 0x040003ED RID: 1005
	private float float_6;

	// Token: 0x040003EE RID: 1006
	private Vector3 vector3_0;

	// Token: 0x040003EF RID: 1007
	public Color color_0;

	// Token: 0x040003F0 RID: 1008
	public Color color_1;

	// Token: 0x040003F1 RID: 1009
	public Color color_2;

	// Token: 0x040003F2 RID: 1010
	public Vector3 vector3_1;

	// Token: 0x040003F3 RID: 1011
	public Vector3 vector3_2;

	// Token: 0x040003F4 RID: 1012
	public Vector3 vector3_3;
}
