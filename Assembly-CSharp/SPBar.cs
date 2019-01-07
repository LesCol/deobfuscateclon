using System;
using UnityEngine;

// Token: 0x02000093 RID: 147
public class SPBar : MonoBehaviour
{
	// Token: 0x06001C7D RID: 7293 RVA: 0x000E2558 File Offset: 0x000E0758
	public void method_0(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1123f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1466f, 1113f, 76f);
			this.transform_0.position = new Vector3(34f, 649f, 1142f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 954f)
		{
			float num = (float_3 - 690f) * 403f;
			this.vector2_0.y = 217f;
			this.vector2_1.y = 1758f * num + 1855f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 742f + 1331f;
		}
		else if (float_3 >= 1848f)
		{
			float num = (float_3 - 272f) * 951f;
			this.vector2_0.y = 1002f;
			this.vector2_1.y = 181f * num + 1027f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1340f + 533f;
		}
		else if (float_3 >= 1846f)
		{
			float num = (float_3 - 346f) * 745f;
			this.vector2_0.y = 619f * num + 1690f;
			this.vector2_1.y = 1957f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1907f + 1546f;
			}
			else
			{
				this.vector3_0.z = 437f;
				y = 1909f;
			}
		}
		else
		{
			float num = float_3 * 1737f;
			this.vector2_0.y = 1009f * num + 1375f;
			this.vector2_1.y = 82f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 58f;
			}
			else
			{
				this.vector3_0.z = 264f;
				y = 913f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(446f, y, 837f);
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x000E2808 File Offset: 0x000E0A08
	public void method_1(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1912f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(1389f, 219f, 472f);
			this.transform_0.position = new Vector3(1544f, 1482f, 424f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 103f)
		{
			float num = (float_3 - 81f) * 262f;
			this.vector2_0.y = 380f;
			this.vector2_1.y = 635f * num + 1829f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 535f + 908f;
		}
		else if (float_3 >= 957f)
		{
			float num = (float_3 - 392f) * 1209f;
			this.vector2_0.y = 1509f;
			this.vector2_1.y = 1298f * num + 82f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1557f + 1116f;
		}
		else if (float_3 >= 1846f)
		{
			float num = (float_3 - 927f) * 1795f;
			this.vector2_0.y = 126f * num + 75f;
			this.vector2_1.y = 1266f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1759f + 1135f;
			}
			else
			{
				this.vector3_0.z = 1573f;
				y = 222f;
			}
		}
		else
		{
			float num = float_3 * 878f;
			this.vector2_0.y = 1690f * num + 1780f;
			this.vector2_1.y = 1756f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1886f;
			}
			else
			{
				this.vector3_0.z = 1312f;
				y = 520f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1278f, y, 1460f);
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x0000D493 File Offset: 0x0000B693
	private void method_2()
	{
		this.method_66(1550f, true);
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x000E2AB8 File Offset: 0x000E0CB8
	public void method_3(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1237f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1894f, 1756f, 1866f);
			this.transform_0.position = new Vector3(276f, 936f, 1840f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 417f)
		{
			float num = (float_3 - 882f) * 1540f;
			this.vector2_0.y = 1196f;
			this.vector2_1.y = 642f * num + 1210f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 673f + 127f;
		}
		else if (float_3 >= 30f)
		{
			float num = (float_3 - 1845f) * 250f;
			this.vector2_0.y = 1431f;
			this.vector2_1.y = 125f * num + 539f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 687f + 1310f;
		}
		else if (float_3 >= 946f)
		{
			float num = (float_3 - 416f) * 15f;
			this.vector2_0.y = 1763f * num + 125f;
			this.vector2_1.y = 1462f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1520f + 820f;
			}
			else
			{
				this.vector3_0.z = 495f;
				y = 122f;
			}
		}
		else
		{
			float num = float_3 * 1870f;
			this.vector2_0.y = 457f * num + 820f;
			this.vector2_1.y = 1813f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 798f;
			}
			else
			{
				this.vector3_0.z = 348f;
				y = 123f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1158f, y, 1232f);
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x000E2D68 File Offset: 0x000E0F68
	public void method_4(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 65f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(1671f, 1688f, 1708f);
			this.transform_0.position = new Vector3(1499f, 1427f, 1327f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1800f)
		{
			float num = (float_3 - 354f) * 1592f;
			this.vector2_0.y = 531f;
			this.vector2_1.y = 1883f * num + 450f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 466f + 872f;
		}
		else if (float_3 >= 1712f)
		{
			float num = (float_3 - 1805f) * 778f;
			this.vector2_0.y = 1030f;
			this.vector2_1.y = 1525f * num + 1484f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1594f + 359f;
		}
		else if (float_3 >= 1540f)
		{
			float num = (float_3 - 1985f) * 791f;
			this.vector2_0.y = 1073f * num + 726f;
			this.vector2_1.y = 806f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 610f + 1809f;
			}
			else
			{
				this.vector3_0.z = 745f;
				y = 1979f;
			}
		}
		else
		{
			float num = float_3 * 1395f;
			this.vector2_0.y = 859f * num + 1481f;
			this.vector2_1.y = 144f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1319f;
			}
			else
			{
				this.vector3_0.z = 1130f;
				y = 575f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1346f, y, 459f);
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x0000D4A1 File Offset: 0x0000B6A1
	private void method_5()
	{
		this.method_40(1197f, false);
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x000E3018 File Offset: 0x000E1218
	public void method_6(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1403f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(441f, 632f, 461f);
			this.transform_0.position = new Vector3(345f, 730f, 1587f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1296f)
		{
			float num = (float_3 - 1072f) * 191f;
			this.vector2_0.y = 777f;
			this.vector2_1.y = 413f * num + 1634f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1131f + 224f;
		}
		else if (float_3 >= 1894f)
		{
			float num = (float_3 - 473f) * 1746f;
			this.vector2_0.y = 1305f;
			this.vector2_1.y = 97f * num + 1280f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 372f + 699f;
		}
		else if (float_3 >= 1399f)
		{
			float num = (float_3 - 1656f) * 1191f;
			this.vector2_0.y = 1738f * num + 602f;
			this.vector2_1.y = 741f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1546f + 342f;
			}
			else
			{
				this.vector3_0.z = 1540f;
				y = 1366f;
			}
		}
		else
		{
			float num = float_3 * 1360f;
			this.vector2_0.y = 1062f * num + 113f;
			this.vector2_1.y = 852f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 986f;
			}
			else
			{
				this.vector3_0.z = 960f;
				y = 1037f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(186f, y, 1026f);
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x000E32C8 File Offset: 0x000E14C8
	public void method_7(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 0f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(0.3f, 0f, 1f);
			this.transform_0.position = new Vector3(-99f, -99f, -99f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 0.75f)
		{
			float num = (float_3 - 0.75f) * 4f;
			this.vector2_0.y = 0.196f;
			this.vector2_1.y = 0.075f * num + 0.115f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 0.075f + 0.24f;
		}
		else if (float_3 >= 0.5f)
		{
			float num = (float_3 - 0.5f) * 4f;
			this.vector2_0.y = 0.196f;
			this.vector2_1.y = 0.08f * num + 0.035f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 0.08f + 0.16f;
		}
		else if (float_3 >= 0.25f)
		{
			float num = (float_3 - 0.25f) * 4f;
			this.vector2_0.y = 0.091f * num + 0.105f;
			this.vector2_1.y = 0f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 0.09f + 0.07f;
			}
			else
			{
				this.vector3_0.z = 999f;
				y = 0f;
			}
		}
		else
		{
			float num = float_3 * 4f;
			this.vector2_0.y = 0.07f * num + 0.035f;
			this.vector2_1.y = 0f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 0.07f;
			}
			else
			{
				this.vector3_0.z = 999f;
				y = 0f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(0.3f, y, 1f);
	}

	// Token: 0x06001C85 RID: 7301 RVA: 0x000E3578 File Offset: 0x000E1778
	public void method_8(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1674f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(429f, 213f, 223f);
			this.transform_0.position = new Vector3(1679f, 1460f, 964f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1547f)
		{
			float num = (float_3 - 1438f) * 661f;
			this.vector2_0.y = 105f;
			this.vector2_1.y = 295f * num + 924f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 484f + 1919f;
		}
		else if (float_3 >= 1486f)
		{
			float num = (float_3 - 638f) * 941f;
			this.vector2_0.y = 1062f;
			this.vector2_1.y = 1212f * num + 1207f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1318f + 823f;
		}
		else if (float_3 >= 1883f)
		{
			float num = (float_3 - 482f) * 681f;
			this.vector2_0.y = 1550f * num + 847f;
			this.vector2_1.y = 1042f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 956f + 1551f;
			}
			else
			{
				this.vector3_0.z = 1173f;
				y = 1683f;
			}
		}
		else
		{
			float num = float_3 * 37f;
			this.vector2_0.y = 784f * num + 1671f;
			this.vector2_1.y = 1110f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1218f;
			}
			else
			{
				this.vector3_0.z = 1540f;
				y = 1774f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1349f, y, 555f);
	}

	// Token: 0x06001C86 RID: 7302 RVA: 0x0000D4AF File Offset: 0x0000B6AF
	private void method_9()
	{
		this.method_52(1755f, true);
	}

	// Token: 0x06001C87 RID: 7303 RVA: 0x000E3828 File Offset: 0x000E1A28
	public void method_10(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 289f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(1461f, 1131f, 1396f);
			this.transform_0.position = new Vector3(45f, 1147f, 684f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 507f)
		{
			float num = (float_3 - 429f) * 1591f;
			this.vector2_0.y = 1236f;
			this.vector2_1.y = 958f * num + 1702f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1721f + 322f;
		}
		else if (float_3 >= 1437f)
		{
			float num = (float_3 - 825f) * 799f;
			this.vector2_0.y = 1091f;
			this.vector2_1.y = 190f * num + 293f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1727f + 853f;
		}
		else if (float_3 >= 1603f)
		{
			float num = (float_3 - 515f) * 222f;
			this.vector2_0.y = 1839f * num + 160f;
			this.vector2_1.y = 919f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1043f + 1021f;
			}
			else
			{
				this.vector3_0.z = 1939f;
				y = 1886f;
			}
		}
		else
		{
			float num = float_3 * 1510f;
			this.vector2_0.y = 943f * num + 1908f;
			this.vector2_1.y = 1802f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1694f;
			}
			else
			{
				this.vector3_0.z = 574f;
				y = 1197f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1716f, y, 547f);
	}

	// Token: 0x06001C88 RID: 7304 RVA: 0x0000D4BD File Offset: 0x0000B6BD
	private void method_11()
	{
		this.method_10(73f, true);
	}

	// Token: 0x06001C89 RID: 7305 RVA: 0x000E3AD8 File Offset: 0x000E1CD8
	public void method_12(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1494f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(819f, 954f, 1231f);
			this.transform_0.position = new Vector3(1280f, 558f, 1306f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 1604f)
		{
			float num = (float_3 - 958f) * 760f;
			this.vector2_0.y = 824f;
			this.vector2_1.y = 59f * num + 903f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1611f + 1112f;
		}
		else if (float_3 >= 1601f)
		{
			float num = (float_3 - 1923f) * 529f;
			this.vector2_0.y = 109f;
			this.vector2_1.y = 1482f * num + 1833f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 342f + 1947f;
		}
		else if (float_3 >= 740f)
		{
			float num = (float_3 - 1481f) * 1792f;
			this.vector2_0.y = 61f * num + 1719f;
			this.vector2_1.y = 1762f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1784f + 1767f;
			}
			else
			{
				this.vector3_0.z = 1301f;
				y = 416f;
			}
		}
		else
		{
			float num = float_3 * 1485f;
			this.vector2_0.y = 607f * num + 535f;
			this.vector2_1.y = 1140f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1344f;
			}
			else
			{
				this.vector3_0.z = 485f;
				y = 1914f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(991f, y, 1954f);
	}

	// Token: 0x06001C8A RID: 7306 RVA: 0x0000D4CB File Offset: 0x0000B6CB
	private void method_13()
	{
		this.method_42(1110f, false);
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x000E3D88 File Offset: 0x000E1F88
	public void method_14(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1785f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(675f, 1075f, 1876f);
			this.transform_0.position = new Vector3(1161f, 475f, 1720f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 891f)
		{
			float num = (float_3 - 1237f) * 558f;
			this.vector2_0.y = 1337f;
			this.vector2_1.y = 1631f * num + 1016f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1165f + 789f;
		}
		else if (float_3 >= 306f)
		{
			float num = (float_3 - 604f) * 1771f;
			this.vector2_0.y = 1266f;
			this.vector2_1.y = 122f * num + 1837f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 128f + 1150f;
		}
		else if (float_3 >= 73f)
		{
			float num = (float_3 - 1715f) * 1124f;
			this.vector2_0.y = 271f * num + 299f;
			this.vector2_1.y = 782f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1906f + 1693f;
			}
			else
			{
				this.vector3_0.z = 1146f;
				y = 519f;
			}
		}
		else
		{
			float num = float_3 * 1458f;
			this.vector2_0.y = 1578f * num + 515f;
			this.vector2_1.y = 1199f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1187f;
			}
			else
			{
				this.vector3_0.z = 966f;
				y = 1040f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(610f, y, 376f);
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x0000D4D9 File Offset: 0x0000B6D9
	private void method_15()
	{
		this.method_62(1612f, false);
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x0000D4E7 File Offset: 0x0000B6E7
	private void method_16()
	{
		this.method_76(1050f, true);
	}

	// Token: 0x06001C8F RID: 7311 RVA: 0x0000D4F5 File Offset: 0x0000B6F5
	private void method_17()
	{
		this.method_45(1546f, false);
	}

	// Token: 0x06001C90 RID: 7312 RVA: 0x000E40B0 File Offset: 0x000E22B0
	public void method_18(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1755f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(884f, 1597f, 1008f);
			this.transform_0.position = new Vector3(908f, 1419f, 238f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1208f)
		{
			float num = (float_3 - 1484f) * 1362f;
			this.vector2_0.y = 856f;
			this.vector2_1.y = 416f * num + 1279f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1726f + 1458f;
		}
		else if (float_3 >= 1501f)
		{
			float num = (float_3 - 277f) * 1587f;
			this.vector2_0.y = 28f;
			this.vector2_1.y = 759f * num + 688f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 206f + 1525f;
		}
		else if (float_3 >= 1094f)
		{
			float num = (float_3 - 1142f) * 921f;
			this.vector2_0.y = 978f * num + 337f;
			this.vector2_1.y = 636f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 173f + 1048f;
			}
			else
			{
				this.vector3_0.z = 1880f;
				y = 1743f;
			}
		}
		else
		{
			float num = float_3 * 496f;
			this.vector2_0.y = 217f * num + 1695f;
			this.vector2_1.y = 233f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1755f;
			}
			else
			{
				this.vector3_0.z = 973f;
				y = 961f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1911f, y, 788f);
	}

	// Token: 0x06001C91 RID: 7313 RVA: 0x000E4360 File Offset: 0x000E2560
	public void method_19(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 43f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(670f, 930f, 1653f);
			this.transform_0.position = new Vector3(1015f, 1905f, 780f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 1434f)
		{
			float num = (float_3 - 985f) * 611f;
			this.vector2_0.y = 1284f;
			this.vector2_1.y = 540f * num + 1076f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1514f + 1476f;
		}
		else if (float_3 >= 1769f)
		{
			float num = (float_3 - 1842f) * 1174f;
			this.vector2_0.y = 992f;
			this.vector2_1.y = 1522f * num + 1642f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1418f + 1004f;
		}
		else if (float_3 >= 577f)
		{
			float num = (float_3 - 460f) * 578f;
			this.vector2_0.y = 44f * num + 194f;
			this.vector2_1.y = 490f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1879f + 393f;
			}
			else
			{
				this.vector3_0.z = 1903f;
				y = 1616f;
			}
		}
		else
		{
			float num = float_3 * 810f;
			this.vector2_0.y = 861f * num + 408f;
			this.vector2_1.y = 704f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1856f;
			}
			else
			{
				this.vector3_0.z = 1004f;
				y = 1077f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1916f, y, 982f);
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x000E4610 File Offset: 0x000E2810
	public void method_20(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1828f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1648f, 1723f, 1844f);
			this.transform_0.position = new Vector3(942f, 1291f, 1920f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 511f)
		{
			float num = (float_3 - 716f) * 811f;
			this.vector2_0.y = 136f;
			this.vector2_1.y = 151f * num + 389f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1149f + 1834f;
		}
		else if (float_3 >= 1342f)
		{
			float num = (float_3 - 607f) * 1494f;
			this.vector2_0.y = 1674f;
			this.vector2_1.y = 1400f * num + 619f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 130f + 1688f;
		}
		else if (float_3 >= 1095f)
		{
			float num = (float_3 - 895f) * 1862f;
			this.vector2_0.y = 896f * num + 90f;
			this.vector2_1.y = 1703f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1261f + 273f;
			}
			else
			{
				this.vector3_0.z = 11f;
				y = 1859f;
			}
		}
		else
		{
			float num = float_3 * 1173f;
			this.vector2_0.y = 105f * num + 1442f;
			this.vector2_1.y = 964f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1499f;
			}
			else
			{
				this.vector3_0.z = 602f;
				y = 1713f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(521f, y, 1927f);
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x0000D503 File Offset: 0x0000B703
	private void method_21()
	{
		this.method_66(702f, false);
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x000E48C0 File Offset: 0x000E2AC0
	public void method_22(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 827f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(861f, 1291f, 362f);
			this.transform_0.position = new Vector3(53f, 1178f, 1342f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 1014f)
		{
			float num = (float_3 - 62f) * 1357f;
			this.vector2_0.y = 552f;
			this.vector2_1.y = 1236f * num + 1652f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1114f + 1744f;
		}
		else if (float_3 >= 1067f)
		{
			float num = (float_3 - 410f) * 1655f;
			this.vector2_0.y = 1400f;
			this.vector2_1.y = 1582f * num + 815f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1049f + 562f;
		}
		else if (float_3 >= 1698f)
		{
			float num = (float_3 - 1585f) * 810f;
			this.vector2_0.y = 886f * num + 1067f;
			this.vector2_1.y = 547f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1189f + 1644f;
			}
			else
			{
				this.vector3_0.z = 746f;
				y = 458f;
			}
		}
		else
		{
			float num = float_3 * 621f;
			this.vector2_0.y = 1588f * num + 259f;
			this.vector2_1.y = 1472f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 51f;
			}
			else
			{
				this.vector3_0.z = 114f;
				y = 1414f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(791f, y, 1741f);
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x0000D511 File Offset: 0x0000B711
	private void method_23()
	{
		this.method_10(756f, false);
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x000E4B70 File Offset: 0x000E2D70
	public void method_24(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1805f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1355f, 1068f, 555f);
			this.transform_0.position = new Vector3(1329f, 520f, 1825f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 954f)
		{
			float num = (float_3 - 1362f) * 720f;
			this.vector2_0.y = 701f;
			this.vector2_1.y = 519f * num + 1339f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 215f + 1307f;
		}
		else if (float_3 >= 217f)
		{
			float num = (float_3 - 1046f) * 1902f;
			this.vector2_0.y = 1308f;
			this.vector2_1.y = 966f * num + 1306f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1955f + 1764f;
		}
		else if (float_3 >= 453f)
		{
			float num = (float_3 - 1966f) * 244f;
			this.vector2_0.y = 1416f * num + 1520f;
			this.vector2_1.y = 1175f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1037f + 1773f;
			}
			else
			{
				this.vector3_0.z = 689f;
				y = 414f;
			}
		}
		else
		{
			float num = float_3 * 515f;
			this.vector2_0.y = 1388f * num + 265f;
			this.vector2_1.y = 484f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 278f;
			}
			else
			{
				this.vector3_0.z = 522f;
				y = 1668f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1024f, y, 277f);
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x0000D51F File Offset: 0x0000B71F
	private void method_25()
	{
		this.method_8(56f, true);
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x0000D52D File Offset: 0x0000B72D
	private void method_26()
	{
		this.method_22(1728f, true);
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x0000D53B File Offset: 0x0000B73B
	private void method_27()
	{
		this.method_4(1108f, false);
	}

	// Token: 0x06001C9A RID: 7322 RVA: 0x000E4E20 File Offset: 0x000E3020
	public void method_28(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 241f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1925f, 186f, 50f);
			this.transform_0.position = new Vector3(1076f, 381f, 1753f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 28f)
		{
			float num = (float_3 - 252f) * 1617f;
			this.vector2_0.y = 1597f;
			this.vector2_1.y = 1173f * num + 1322f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1140f + 569f;
		}
		else if (float_3 >= 1134f)
		{
			float num = (float_3 - 68f) * 597f;
			this.vector2_0.y = 499f;
			this.vector2_1.y = 1503f * num + 26f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 816f + 1456f;
		}
		else if (float_3 >= 543f)
		{
			float num = (float_3 - 132f) * 368f;
			this.vector2_0.y = 1933f * num + 71f;
			this.vector2_1.y = 1810f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1977f + 1061f;
			}
			else
			{
				this.vector3_0.z = 1179f;
				y = 142f;
			}
		}
		else
		{
			float num = float_3 * 1362f;
			this.vector2_0.y = 1677f * num + 601f;
			this.vector2_1.y = 684f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 951f;
			}
			else
			{
				this.vector3_0.z = 1444f;
				y = 1085f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1763f, y, 1794f);
	}

	// Token: 0x06001C9B RID: 7323 RVA: 0x0000D549 File Offset: 0x0000B749
	private void method_29()
	{
		this.method_34(1507f, false);
	}

	// Token: 0x06001C9C RID: 7324 RVA: 0x000E50D0 File Offset: 0x000E32D0
	public void method_30(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 335f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1509f, 193f, 1146f);
			this.transform_0.position = new Vector3(337f, 102f, 17f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 269f)
		{
			float num = (float_3 - 240f) * 1151f;
			this.vector2_0.y = 1818f;
			this.vector2_1.y = 1181f * num + 667f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 267f + 458f;
		}
		else if (float_3 >= 1072f)
		{
			float num = (float_3 - 532f) * 1105f;
			this.vector2_0.y = 1260f;
			this.vector2_1.y = 4f * num + 348f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1717f + 1426f;
		}
		else if (float_3 >= 1572f)
		{
			float num = (float_3 - 303f) * 1126f;
			this.vector2_0.y = 749f * num + 1691f;
			this.vector2_1.y = 931f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 608f + 134f;
			}
			else
			{
				this.vector3_0.z = 653f;
				y = 391f;
			}
		}
		else
		{
			float num = float_3 * 360f;
			this.vector2_0.y = 1663f * num + 686f;
			this.vector2_1.y = 1805f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 409f;
			}
			else
			{
				this.vector3_0.z = 1268f;
				y = 1131f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(854f, y, 274f);
	}

	// Token: 0x06001C9D RID: 7325 RVA: 0x000E5380 File Offset: 0x000E3580
	public void method_31(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1534f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(5f, 49f, 492f);
			this.transform_0.position = new Vector3(1872f, 660f, 1541f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1452f)
		{
			float num = (float_3 - 800f) * 1414f;
			this.vector2_0.y = 1245f;
			this.vector2_1.y = 686f * num + 1431f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1416f + 1150f;
		}
		else if (float_3 >= 1912f)
		{
			float num = (float_3 - 445f) * 1177f;
			this.vector2_0.y = 959f;
			this.vector2_1.y = 1415f * num + 521f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 687f + 1636f;
		}
		else if (float_3 >= 1455f)
		{
			float num = (float_3 - 1380f) * 1815f;
			this.vector2_0.y = 703f * num + 1142f;
			this.vector2_1.y = 1174f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1212f + 1386f;
			}
			else
			{
				this.vector3_0.z = 485f;
				y = 1997f;
			}
		}
		else
		{
			float num = float_3 * 1224f;
			this.vector2_0.y = 1890f * num + 55f;
			this.vector2_1.y = 769f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1523f;
			}
			else
			{
				this.vector3_0.z = 199f;
				y = 622f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(778f, y, 347f);
	}

	// Token: 0x06001C9E RID: 7326 RVA: 0x0000D557 File Offset: 0x0000B757
	private void method_32()
	{
		this.method_51(1221f, false);
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x000E5630 File Offset: 0x000E3830
	public void method_33(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1331f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(91f, 93f, 173f);
			this.transform_0.position = new Vector3(193f, 1303f, 1866f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 445f)
		{
			float num = (float_3 - 1161f) * 259f;
			this.vector2_0.y = 1761f;
			this.vector2_1.y = 946f * num + 1074f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 396f + 1647f;
		}
		else if (float_3 >= 1967f)
		{
			float num = (float_3 - 554f) * 1526f;
			this.vector2_0.y = 1848f;
			this.vector2_1.y = 1237f * num + 1047f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 274f + 69f;
		}
		else if (float_3 >= 111f)
		{
			float num = (float_3 - 1041f) * 1486f;
			this.vector2_0.y = 786f * num + 268f;
			this.vector2_1.y = 1910f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 253f + 1301f;
			}
			else
			{
				this.vector3_0.z = 1368f;
				y = 1737f;
			}
		}
		else
		{
			float num = float_3 * 1564f;
			this.vector2_0.y = 1097f * num + 1564f;
			this.vector2_1.y = 409f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1438f;
			}
			else
			{
				this.vector3_0.z = 1679f;
				y = 921f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1441f, y, 920f);
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x000E58E0 File Offset: 0x000E3AE0
	public void method_34(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1726f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(940f, 929f, 821f);
			this.transform_0.position = new Vector3(1421f, 293f, 455f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1871f)
		{
			float num = (float_3 - 1951f) * 1414f;
			this.vector2_0.y = 755f;
			this.vector2_1.y = 358f * num + 415f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1364f + 1664f;
		}
		else if (float_3 >= 1398f)
		{
			float num = (float_3 - 1563f) * 560f;
			this.vector2_0.y = 937f;
			this.vector2_1.y = 955f * num + 484f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 995f + 989f;
		}
		else if (float_3 >= 434f)
		{
			float num = (float_3 - 1679f) * 401f;
			this.vector2_0.y = 1194f * num + 1672f;
			this.vector2_1.y = 1423f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 389f + 88f;
			}
			else
			{
				this.vector3_0.z = 113f;
				y = 1587f;
			}
		}
		else
		{
			float num = float_3 * 143f;
			this.vector2_0.y = 1815f * num + 845f;
			this.vector2_1.y = 45f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 334f;
			}
			else
			{
				this.vector3_0.z = 96f;
				y = 1244f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1919f, y, 1917f);
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x0000D565 File Offset: 0x0000B765
	private void method_35()
	{
		this.method_18(1522f, false);
	}

	// Token: 0x06001CA2 RID: 7330 RVA: 0x000E5B90 File Offset: 0x000E3D90
	public void method_36(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1085f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(79f, 1256f, 272f);
			this.transform_0.position = new Vector3(1575f, 981f, 1975f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 978f)
		{
			float num = (float_3 - 1121f) * 1249f;
			this.vector2_0.y = 1399f;
			this.vector2_1.y = 17f * num + 1754f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1079f + 1058f;
		}
		else if (float_3 >= 1487f)
		{
			float num = (float_3 - 50f) * 467f;
			this.vector2_0.y = 1794f;
			this.vector2_1.y = 324f * num + 1712f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 98f + 1760f;
		}
		else if (float_3 >= 858f)
		{
			float num = (float_3 - 169f) * 1839f;
			this.vector2_0.y = 1286f * num + 822f;
			this.vector2_1.y = 1828f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1287f + 1906f;
			}
			else
			{
				this.vector3_0.z = 791f;
				y = 522f;
			}
		}
		else
		{
			float num = float_3 * 80f;
			this.vector2_0.y = 1679f * num + 439f;
			this.vector2_1.y = 1357f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 362f;
			}
			else
			{
				this.vector3_0.z = 1371f;
				y = 899f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(462f, y, 815f);
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x0000D573 File Offset: 0x0000B773
	private void method_37()
	{
		this.method_73(857f, false);
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x0000D581 File Offset: 0x0000B781
	private void method_38()
	{
		this.method_39(1770f, false);
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x000E5E40 File Offset: 0x000E4040
	public void method_39(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 765f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(185f, 1878f, 593f);
			this.transform_0.position = new Vector3(1603f, 1830f, 1465f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1796f)
		{
			float num = (float_3 - 1627f) * 1285f;
			this.vector2_0.y = 1667f;
			this.vector2_1.y = 58f * num + 474f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 797f + 1349f;
		}
		else if (float_3 >= 579f)
		{
			float num = (float_3 - 1202f) * 1162f;
			this.vector2_0.y = 1617f;
			this.vector2_1.y = 1448f * num + 0f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 987f + 85f;
		}
		else if (float_3 >= 1174f)
		{
			float num = (float_3 - 239f) * 229f;
			this.vector2_0.y = 416f * num + 972f;
			this.vector2_1.y = 75f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1305f + 1847f;
			}
			else
			{
				this.vector3_0.z = 841f;
				y = 1258f;
			}
		}
		else
		{
			float num = float_3 * 1382f;
			this.vector2_0.y = 607f * num + 1055f;
			this.vector2_1.y = 851f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 348f;
			}
			else
			{
				this.vector3_0.z = 1559f;
				y = 1101f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1225f, y, 161f);
	}

	// Token: 0x06001CA6 RID: 7334 RVA: 0x000E60F0 File Offset: 0x000E42F0
	public void method_40(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1658f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1820f, 782f, 1802f);
			this.transform_0.position = new Vector3(561f, 1701f, 412f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 940f)
		{
			float num = (float_3 - 127f) * 783f;
			this.vector2_0.y = 919f;
			this.vector2_1.y = 316f * num + 7f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 671f + 473f;
		}
		else if (float_3 >= 541f)
		{
			float num = (float_3 - 1095f) * 1011f;
			this.vector2_0.y = 1744f;
			this.vector2_1.y = 1421f * num + 50f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 362f + 408f;
		}
		else if (float_3 >= 746f)
		{
			float num = (float_3 - 1569f) * 414f;
			this.vector2_0.y = 1811f * num + 1434f;
			this.vector2_1.y = 1873f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 272f + 699f;
			}
			else
			{
				this.vector3_0.z = 1497f;
				y = 523f;
			}
		}
		else
		{
			float num = float_3 * 477f;
			this.vector2_0.y = 1631f * num + 1289f;
			this.vector2_1.y = 1225f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1218f;
			}
			else
			{
				this.vector3_0.z = 243f;
				y = 1585f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(485f, y, 1339f);
	}

	// Token: 0x06001CA7 RID: 7335 RVA: 0x000E63A0 File Offset: 0x000E45A0
	public void method_41(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1491f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(4f, 1902f, 1728f);
			this.transform_0.position = new Vector3(500f, 1993f, 1018f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1003f)
		{
			float num = (float_3 - 1221f) * 894f;
			this.vector2_0.y = 1400f;
			this.vector2_1.y = 1795f * num + 977f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 282f + 1849f;
		}
		else if (float_3 >= 1162f)
		{
			float num = (float_3 - 505f) * 481f;
			this.vector2_0.y = 1109f;
			this.vector2_1.y = 931f * num + 612f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 887f + 1699f;
		}
		else if (float_3 >= 248f)
		{
			float num = (float_3 - 375f) * 1420f;
			this.vector2_0.y = 1400f * num + 1288f;
			this.vector2_1.y = 1863f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 651f + 1760f;
			}
			else
			{
				this.vector3_0.z = 1332f;
				y = 1198f;
			}
		}
		else
		{
			float num = float_3 * 478f;
			this.vector2_0.y = 779f * num + 1822f;
			this.vector2_1.y = 346f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1049f;
			}
			else
			{
				this.vector3_0.z = 1938f;
				y = 977f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(562f, y, 679f);
	}

	// Token: 0x06001CA8 RID: 7336 RVA: 0x000E6650 File Offset: 0x000E4850
	public void method_42(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 819f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1818f, 875f, 1922f);
			this.transform_0.position = new Vector3(771f, 1279f, 75f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1085f)
		{
			float num = (float_3 - 1565f) * 328f;
			this.vector2_0.y = 15f;
			this.vector2_1.y = 1666f * num + 648f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 569f + 330f;
		}
		else if (float_3 >= 1919f)
		{
			float num = (float_3 - 256f) * 1064f;
			this.vector2_0.y = 1118f;
			this.vector2_1.y = 1163f * num + 500f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 212f + 981f;
		}
		else if (float_3 >= 644f)
		{
			float num = (float_3 - 496f) * 1156f;
			this.vector2_0.y = 1960f * num + 298f;
			this.vector2_1.y = 414f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1092f + 1786f;
			}
			else
			{
				this.vector3_0.z = 919f;
				y = 655f;
			}
		}
		else
		{
			float num = float_3 * 903f;
			this.vector2_0.y = 1148f * num + 279f;
			this.vector2_1.y = 1557f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1848f;
			}
			else
			{
				this.vector3_0.z = 318f;
				y = 1548f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(748f, y, 688f);
	}

	// Token: 0x06001CA9 RID: 7337 RVA: 0x0000D58F File Offset: 0x0000B78F
	private void method_43()
	{
		this.method_0(1431f, false);
	}

	// Token: 0x06001CAA RID: 7338 RVA: 0x0000D59D File Offset: 0x0000B79D
	private void method_44()
	{
		this.method_0(1430f, false);
	}

	// Token: 0x06001CAB RID: 7339 RVA: 0x000E6900 File Offset: 0x000E4B00
	public void method_45(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1592f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(1846f, 396f, 58f);
			this.transform_0.position = new Vector3(1470f, 1068f, 808f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 124f)
		{
			float num = (float_3 - 291f) * 1215f;
			this.vector2_0.y = 1044f;
			this.vector2_1.y = 392f * num + 378f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1107f + 892f;
		}
		else if (float_3 >= 1960f)
		{
			float num = (float_3 - 879f) * 691f;
			this.vector2_0.y = 1489f;
			this.vector2_1.y = 138f * num + 1859f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 147f + 1789f;
		}
		else if (float_3 >= 1230f)
		{
			float num = (float_3 - 1916f) * 989f;
			this.vector2_0.y = 272f * num + 1870f;
			this.vector2_1.y = 1857f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1833f + 143f;
			}
			else
			{
				this.vector3_0.z = 512f;
				y = 1286f;
			}
		}
		else
		{
			float num = float_3 * 1118f;
			this.vector2_0.y = 1103f * num + 543f;
			this.vector2_1.y = 242f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1453f;
			}
			else
			{
				this.vector3_0.z = 1119f;
				y = 1186f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1011f, y, 1110f);
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x0000D5AB File Offset: 0x0000B7AB
	private void method_46()
	{
		this.method_52(631f, true);
	}

	// Token: 0x06001CAD RID: 7341 RVA: 0x0000D5B9 File Offset: 0x0000B7B9
	private void method_47()
	{
		this.method_33(802f, false);
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x0000D5C7 File Offset: 0x0000B7C7
	private void method_48()
	{
		this.method_6(1176f, true);
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x0000D5D5 File Offset: 0x0000B7D5
	private void method_49()
	{
		this.method_24(154f, false);
	}

	// Token: 0x06001CB0 RID: 7344 RVA: 0x0000D5E3 File Offset: 0x0000B7E3
	private void Awake()
	{
		this.method_7(0f, false);
	}

	// Token: 0x06001CB1 RID: 7345 RVA: 0x0000D5F1 File Offset: 0x0000B7F1
	private void method_50()
	{
		this.method_4(1165f, false);
	}

	// Token: 0x06001CB2 RID: 7346 RVA: 0x000E6BB0 File Offset: 0x000E4DB0
	public void method_51(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1512f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(437f, 1444f, 202f);
			this.transform_0.position = new Vector3(645f, 1190f, 944f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1380f)
		{
			float num = (float_3 - 923f) * 266f;
			this.vector2_0.y = 652f;
			this.vector2_1.y = 1067f * num + 1065f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1985f + 170f;
		}
		else if (float_3 >= 1915f)
		{
			float num = (float_3 - 1606f) * 660f;
			this.vector2_0.y = 918f;
			this.vector2_1.y = 1008f * num + 1326f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1860f + 310f;
		}
		else if (float_3 >= 1074f)
		{
			float num = (float_3 - 1756f) * 1268f;
			this.vector2_0.y = 1767f * num + 1618f;
			this.vector2_1.y = 852f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 16f + 1782f;
			}
			else
			{
				this.vector3_0.z = 1349f;
				y = 1759f;
			}
		}
		else
		{
			float num = float_3 * 266f;
			this.vector2_0.y = 411f * num + 801f;
			this.vector2_1.y = 432f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 725f;
			}
			else
			{
				this.vector3_0.z = 38f;
				y = 1392f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1777f, y, 1870f);
	}

	// Token: 0x06001CB3 RID: 7347 RVA: 0x000E6E60 File Offset: 0x000E5060
	public void method_52(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1065f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1231f, 741f, 17f);
			this.transform_0.position = new Vector3(304f, 566f, 1276f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 16f)
		{
			float num = (float_3 - 1769f) * 420f;
			this.vector2_0.y = 1394f;
			this.vector2_1.y = 1815f * num + 132f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1997f + 1506f;
		}
		else if (float_3 >= 1228f)
		{
			float num = (float_3 - 1067f) * 1854f;
			this.vector2_0.y = 83f;
			this.vector2_1.y = 1422f * num + 1793f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1529f + 1039f;
		}
		else if (float_3 >= 1183f)
		{
			float num = (float_3 - 1316f) * 1877f;
			this.vector2_0.y = 768f * num + 159f;
			this.vector2_1.y = 936f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 711f + 932f;
			}
			else
			{
				this.vector3_0.z = 1343f;
				y = 1347f;
			}
		}
		else
		{
			float num = float_3 * 337f;
			this.vector2_0.y = 1673f * num + 1794f;
			this.vector2_1.y = 1129f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1306f;
			}
			else
			{
				this.vector3_0.z = 995f;
				y = 1914f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1582f, y, 506f);
	}

	// Token: 0x06001CB4 RID: 7348 RVA: 0x000E7110 File Offset: 0x000E5310
	public void method_53(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1725f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(631f, 411f, 498f);
			this.transform_0.position = new Vector3(1044f, 1880f, 1780f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 1303f)
		{
			float num = (float_3 - 255f) * 336f;
			this.vector2_0.y = 668f;
			this.vector2_1.y = 1764f * num + 856f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 799f + 1019f;
		}
		else if (float_3 >= 527f)
		{
			float num = (float_3 - 1853f) * 214f;
			this.vector2_0.y = 516f;
			this.vector2_1.y = 1767f * num + 1750f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 389f + 672f;
		}
		else if (float_3 >= 723f)
		{
			float num = (float_3 - 317f) * 1817f;
			this.vector2_0.y = 432f * num + 356f;
			this.vector2_1.y = 551f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1567f + 124f;
			}
			else
			{
				this.vector3_0.z = 1042f;
				y = 438f;
			}
		}
		else
		{
			float num = float_3 * 1008f;
			this.vector2_0.y = 1530f * num + 530f;
			this.vector2_1.y = 1540f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1057f;
			}
			else
			{
				this.vector3_0.z = 880f;
				y = 211f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(205f, y, 1983f);
	}

	// Token: 0x06001CB5 RID: 7349 RVA: 0x0000D5FF File Offset: 0x0000B7FF
	private void method_54()
	{
		this.method_62(301f, true);
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x000E73C0 File Offset: 0x000E55C0
	public void method_55(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 458f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1531f, 340f, 1275f);
			this.transform_0.position = new Vector3(1449f, 42f, 1283f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 1380f)
		{
			float num = (float_3 - 187f) * 93f;
			this.vector2_0.y = 1348f;
			this.vector2_1.y = 1958f * num + 1441f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 536f + 972f;
		}
		else if (float_3 >= 1515f)
		{
			float num = (float_3 - 993f) * 1743f;
			this.vector2_0.y = 1783f;
			this.vector2_1.y = 1786f * num + 1903f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1055f + 1607f;
		}
		else if (float_3 >= 1391f)
		{
			float num = (float_3 - 1568f) * 485f;
			this.vector2_0.y = 1648f * num + 454f;
			this.vector2_1.y = 178f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1025f + 476f;
			}
			else
			{
				this.vector3_0.z = 1900f;
				y = 1958f;
			}
		}
		else
		{
			float num = float_3 * 454f;
			this.vector2_0.y = 450f * num + 1798f;
			this.vector2_1.y = 1276f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 764f;
			}
			else
			{
				this.vector3_0.z = 1327f;
				y = 811f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1711f, y, 598f);
	}

	// Token: 0x06001CB7 RID: 7351 RVA: 0x0000D60D File Offset: 0x0000B80D
	private void method_56()
	{
		this.method_31(1889f, false);
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x0000D61B File Offset: 0x0000B81B
	private void method_57()
	{
		this.method_53(286f, false);
	}

	// Token: 0x06001CB9 RID: 7353 RVA: 0x0000D629 File Offset: 0x0000B829
	private void method_58()
	{
		this.method_1(1479f, true);
	}

	// Token: 0x06001CBA RID: 7354 RVA: 0x0000D637 File Offset: 0x0000B837
	private void method_59()
	{
		this.method_22(144f, false);
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x0000D645 File Offset: 0x0000B845
	private void method_60()
	{
		this.method_6(1995f, true);
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x0000D653 File Offset: 0x0000B853
	private void method_61()
	{
		this.method_40(427f, false);
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x000E7670 File Offset: 0x000E5870
	public void method_62(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 820f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1757f, 1716f, 1778f);
			this.transform_0.position = new Vector3(1432f, 1059f, 865f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 979f)
		{
			float num = (float_3 - 358f) * 1172f;
			this.vector2_0.y = 1827f;
			this.vector2_1.y = 818f * num + 1031f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 54f + 260f;
		}
		else if (float_3 >= 837f)
		{
			float num = (float_3 - 258f) * 290f;
			this.vector2_0.y = 1620f;
			this.vector2_1.y = 781f * num + 1066f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1312f + 1561f;
		}
		else if (float_3 >= 1673f)
		{
			float num = (float_3 - 1204f) * 122f;
			this.vector2_0.y = 1451f * num + 117f;
			this.vector2_1.y = 707f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1407f + 169f;
			}
			else
			{
				this.vector3_0.z = 1645f;
				y = 1791f;
			}
		}
		else
		{
			float num = float_3 * 1690f;
			this.vector2_0.y = 1520f * num + 414f;
			this.vector2_1.y = 490f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1513f;
			}
			else
			{
				this.vector3_0.z = 1671f;
				y = 1929f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(823f, y, 1159f);
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x000E7920 File Offset: 0x000E5B20
	public void method_63(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 527f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(352f, 243f, 473f);
			this.transform_0.position = new Vector3(1163f, 1277f, 69f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 953f)
		{
			float num = (float_3 - 195f) * 1390f;
			this.vector2_0.y = 1482f;
			this.vector2_1.y = 1814f * num + 276f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1317f + 1446f;
		}
		else if (float_3 >= 237f)
		{
			float num = (float_3 - 572f) * 1310f;
			this.vector2_0.y = 314f;
			this.vector2_1.y = 975f * num + 673f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 783f + 1508f;
		}
		else if (float_3 >= 1763f)
		{
			float num = (float_3 - 1267f) * 522f;
			this.vector2_0.y = 613f * num + 1066f;
			this.vector2_1.y = 848f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1899f + 466f;
			}
			else
			{
				this.vector3_0.z = 997f;
				y = 1894f;
			}
		}
		else
		{
			float num = float_3 * 789f;
			this.vector2_0.y = 678f * num + 505f;
			this.vector2_1.y = 1174f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1359f;
			}
			else
			{
				this.vector3_0.z = 103f;
				y = 996f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(152f, y, 790f);
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x0000D661 File Offset: 0x0000B861
	private void method_64()
	{
		this.method_41(275f, true);
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x000E7BD0 File Offset: 0x000E5DD0
	public void method_65(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 295f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(370f, 1284f, 135f);
			this.transform_0.position = new Vector3(1214f, 37f, 238f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1967f)
		{
			float num = (float_3 - 838f) * 946f;
			this.vector2_0.y = 726f;
			this.vector2_1.y = 1087f * num + 760f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 595f + 494f;
		}
		else if (float_3 >= 1500f)
		{
			float num = (float_3 - 109f) * 1331f;
			this.vector2_0.y = 865f;
			this.vector2_1.y = 190f * num + 1112f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1558f + 1587f;
		}
		else if (float_3 >= 274f)
		{
			float num = (float_3 - 1107f) * 1416f;
			this.vector2_0.y = 805f * num + 225f;
			this.vector2_1.y = 1511f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1461f + 234f;
			}
			else
			{
				this.vector3_0.z = 854f;
				y = 1136f;
			}
		}
		else
		{
			float num = float_3 * 1345f;
			this.vector2_0.y = 1840f * num + 135f;
			this.vector2_1.y = 1084f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 744f;
			}
			else
			{
				this.vector3_0.z = 1667f;
				y = 1466f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(627f, y, 551f);
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x000E7E80 File Offset: 0x000E6080
	public void method_66(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1844f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(696f, 403f, 1265f);
			this.transform_0.position = new Vector3(1307f, 661f, 1356f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 628f)
		{
			float num = (float_3 - 918f) * 1744f;
			this.vector2_0.y = 837f;
			this.vector2_1.y = 321f * num + 1126f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 806f + 413f;
		}
		else if (float_3 >= 951f)
		{
			float num = (float_3 - 844f) * 1127f;
			this.vector2_0.y = 1201f;
			this.vector2_1.y = 506f * num + 1896f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 988f + 20f;
		}
		else if (float_3 >= 621f)
		{
			float num = (float_3 - 1230f) * 1940f;
			this.vector2_0.y = 547f * num + 642f;
			this.vector2_1.y = 183f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1740f + 784f;
			}
			else
			{
				this.vector3_0.z = 1422f;
				y = 1800f;
			}
		}
		else
		{
			float num = float_3 * 439f;
			this.vector2_0.y = 1170f * num + 957f;
			this.vector2_1.y = 1570f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1029f;
			}
			else
			{
				this.vector3_0.z = 424f;
				y = 58f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1331f, y, 683f);
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x0000D66F File Offset: 0x0000B86F
	private void method_67()
	{
		this.method_63(344f, false);
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x0000D67D File Offset: 0x0000B87D
	private void method_68()
	{
		this.method_55(1486f, true);
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x0000D68B File Offset: 0x0000B88B
	private void method_69()
	{
		this.method_52(826f, false);
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x000E8130 File Offset: 0x000E6330
	public void method_70(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 826f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(1930f, 431f, 130f);
			this.transform_0.position = new Vector3(1297f, 69f, 1436f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 741f)
		{
			float num = (float_3 - 48f) * 1113f;
			this.vector2_0.y = 791f;
			this.vector2_1.y = 875f * num + 553f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1581f + 1037f;
		}
		else if (float_3 >= 612f)
		{
			float num = (float_3 - 1778f) * 324f;
			this.vector2_0.y = 946f;
			this.vector2_1.y = 11f * num + 105f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 823f + 827f;
		}
		else if (float_3 >= 1041f)
		{
			float num = (float_3 - 1733f) * 767f;
			this.vector2_0.y = 1379f * num + 1640f;
			this.vector2_1.y = 1941f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1029f + 585f;
			}
			else
			{
				this.vector3_0.z = 937f;
				y = 661f;
			}
		}
		else
		{
			float num = float_3 * 36f;
			this.vector2_0.y = 1813f * num + 1286f;
			this.vector2_1.y = 223f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1106f;
			}
			else
			{
				this.vector3_0.z = 1601f;
				y = 629f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(193f, y, 1673f);
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x0000D699 File Offset: 0x0000B899
	private void method_71()
	{
		this.method_0(714f, false);
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x000E83E0 File Offset: 0x000E65E0
	public void method_72(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1116f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(731f, 1658f, 929f);
			this.transform_0.position = new Vector3(598f, 975f, 887f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1581f)
		{
			float num = (float_3 - 439f) * 1772f;
			this.vector2_0.y = 1542f;
			this.vector2_1.y = 188f * num + 302f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 397f + 636f;
		}
		else if (float_3 >= 1509f)
		{
			float num = (float_3 - 996f) * 782f;
			this.vector2_0.y = 857f;
			this.vector2_1.y = 1779f * num + 1848f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 117f + 1732f;
		}
		else if (float_3 >= 1955f)
		{
			float num = (float_3 - 1765f) * 213f;
			this.vector2_0.y = 686f * num + 89f;
			this.vector2_1.y = 1735f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 189f + 340f;
			}
			else
			{
				this.vector3_0.z = 1417f;
				y = 1649f;
			}
		}
		else
		{
			float num = float_3 * 1614f;
			this.vector2_0.y = 1087f * num + 1689f;
			this.vector2_1.y = 1092f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 981f;
			}
			else
			{
				this.vector3_0.z = 1019f;
				y = 732f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(317f, y, 328f);
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x000E8690 File Offset: 0x000E6890
	public void method_73(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(1370f, 156f, 126f);
			this.transform_0.position = new Vector3(605f, 1135f, 1994f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(false);
		float y;
		if (float_3 >= 1640f)
		{
			float num = (float_3 - 1111f) * 1584f;
			this.vector2_0.y = 1891f;
			this.vector2_1.y = 1571f * num + 1434f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1675f + 1339f;
		}
		else if (float_3 >= 599f)
		{
			float num = (float_3 - 528f) * 907f;
			this.vector2_0.y = 483f;
			this.vector2_1.y = 1303f * num + 1308f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 799f + 1574f;
		}
		else if (float_3 >= 1368f)
		{
			float num = (float_3 - 1482f) * 880f;
			this.vector2_0.y = 622f * num + 1526f;
			this.vector2_1.y = 1230f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1456f + 183f;
			}
			else
			{
				this.vector3_0.z = 309f;
				y = 756f;
			}
		}
		else
		{
			float num = float_3 * 385f;
			this.vector2_0.y = 1112f * num + 1640f;
			this.vector2_1.y = 1013f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1717f;
			}
			else
			{
				this.vector3_0.z = 21f;
				y = 1416f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(755f, y, 118f);
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x000E8940 File Offset: 0x000E6B40
	public void method_74(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 769f)
		{
			this.gameObject_0.SetActive(false);
			this.transform_1.localScale = new Vector3(864f, 1336f, 873f);
			this.transform_0.position = new Vector3(1448f, 1747f, 1620f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 1173f)
		{
			float num = (float_3 - 880f) * 22f;
			this.vector2_0.y = 1826f;
			this.vector2_1.y = 321f * num + 1562f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 1963f + 1392f;
		}
		else if (float_3 >= 1251f)
		{
			float num = (float_3 - 751f) * 687f;
			this.vector2_0.y = 211f;
			this.vector2_1.y = 1626f * num + 1326f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 1847f + 1269f;
		}
		else if (float_3 >= 489f)
		{
			float num = (float_3 - 987f) * 796f;
			this.vector2_0.y = 1334f * num + 304f;
			this.vector2_1.y = 1562f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 1767f + 421f;
			}
			else
			{
				this.vector3_0.z = 1902f;
				y = 1791f;
			}
		}
		else
		{
			float num = float_3 * 1453f;
			this.vector2_0.y = 480f * num + 1558f;
			this.vector2_1.y = 908f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 804f;
			}
			else
			{
				this.vector3_0.z = 1947f;
				y = 730f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(1834f, y, 1264f);
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x0000D6A7 File Offset: 0x0000B8A7
	private void method_75()
	{
		this.method_30(1211f, true);
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x000E8BF0 File Offset: 0x000E6DF0
	public void method_76(float float_3, bool bool_0)
	{
		if (float_3 == this.float_2)
		{
			return;
		}
		this.float_2 = float_3;
		if (float_3 <= 1239f)
		{
			this.gameObject_0.SetActive(true);
			this.transform_1.localScale = new Vector3(245f, 755f, 202f);
			this.transform_0.position = new Vector3(717f, 1742f, 1754f);
			this.spriteRenderer_0.size = (this.spriteRenderer_1.size = Vector2.zero);
			return;
		}
		this.gameObject_0.SetActive(true);
		float y;
		if (float_3 >= 594f)
		{
			float num = (float_3 - 532f) * 248f;
			this.vector2_0.y = 1385f;
			this.vector2_1.y = 1459f * num + 943f;
			this.vector3_0 = Vector3.Lerp(this.vector3_2, this.vector3_1, num);
			y = num * 218f + 275f;
		}
		else if (float_3 >= 556f)
		{
			float num = (float_3 - 418f) * 1031f;
			this.vector2_0.y = 1960f;
			this.vector2_1.y = 1463f * num + 1968f;
			this.vector3_0 = Vector3.Lerp(this.vector3_3, this.vector3_2, num);
			y = num * 449f + 1117f;
		}
		else if (float_3 >= 1152f)
		{
			float num = (float_3 - 1413f) * 1739f;
			this.vector2_0.y = 232f * num + 722f;
			this.vector2_1.y = 24f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_4, this.vector3_3, num);
				y = num * 202f + 328f;
			}
			else
			{
				this.vector3_0.z = 1128f;
				y = 394f;
			}
		}
		else
		{
			float num = float_3 * 1825f;
			this.vector2_0.y = 1054f * num + 1774f;
			this.vector2_1.y = 343f;
			if (bool_0)
			{
				this.vector3_0 = Vector3.Lerp(this.vector3_5, this.vector3_4, num);
				y = num * 1436f;
			}
			else
			{
				this.vector3_0.z = 387f;
				y = 1463f;
			}
		}
		this.spriteRenderer_0.size = this.vector2_0;
		this.spriteRenderer_1.size = this.vector2_1;
		this.transform_0.localPosition = this.vector3_0;
		this.transform_1.localScale = new Vector3(307f, y, 7f);
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x0000D6B5 File Offset: 0x0000B8B5
	private void method_77()
	{
		this.method_31(267f, false);
	}

	// Token: 0x04000471 RID: 1137
	public GameObject gameObject_0;

	// Token: 0x04000472 RID: 1138
	public Transform transform_0;

	// Token: 0x04000473 RID: 1139
	public Transform transform_1;

	// Token: 0x04000474 RID: 1140
	public SpriteRenderer spriteRenderer_0;

	// Token: 0x04000475 RID: 1141
	public SpriteRenderer spriteRenderer_1;

	// Token: 0x04000476 RID: 1142
	private Vector2 vector2_0 = new Vector2(0.04f, 0f);

	// Token: 0x04000477 RID: 1143
	private Vector2 vector2_1 = new Vector2(0.044f, 0f);

	// Token: 0x04000478 RID: 1144
	private Vector3 vector3_0 = new Vector3(0.52f, 0f, 0f);

	// Token: 0x04000479 RID: 1145
	public Vector3 vector3_1;

	// Token: 0x0400047A RID: 1146
	public Vector3 vector3_2;

	// Token: 0x0400047B RID: 1147
	public Vector3 vector3_3;

	// Token: 0x0400047C RID: 1148
	public Vector3 vector3_4;

	// Token: 0x0400047D RID: 1149
	public Vector3 vector3_5;

	// Token: 0x0400047E RID: 1150
	private float float_0 = 0.17f;

	// Token: 0x0400047F RID: 1151
	private float float_1 = 0.32f;

	// Token: 0x04000480 RID: 1152
	private float float_2 = -1f;
}
