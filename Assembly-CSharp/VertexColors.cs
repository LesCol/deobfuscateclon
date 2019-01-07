using System;
using UnityEngine;

// Token: 0x020000C5 RID: 197
public class VertexColors : MonoBehaviour
{
	// Token: 0x0600273E RID: 10046 RVA: 0x0012B360 File Offset: 0x00129560
	private void method_0()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 665f;
		float num2 = 152f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(266f, 1908f, 815f, 1531f), num2);
				num2 += 1260f;
				if (num2 > 563f)
				{
					num2 = 657f;
				}
			}
			else
			{
				array[i] = new Color(1702f, 1861f, 1178f, 1684f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600273F RID: 10047 RVA: 0x0012B430 File Offset: 0x00129630
	private void method_1()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 675f;
		float num2 = 497f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1033f, 1812f, 1279f, 1687f), num2);
				num2 += 1546f;
				if (num2 > 286f)
				{
					num2 = 1141f;
				}
			}
			else
			{
				array[i] = new Color(220f, 210f, 464f, 6f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x0012B500 File Offset: 0x00129700
	private void method_2()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1665f;
		float num2 = 65f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(477f, 1747f, 398f, 1477f), num2);
				num2 += 1948f;
				if (num2 > 849f)
				{
					num2 = 964f;
				}
			}
			else
			{
				array[i] = new Color(506f, 1566f, 370f, 722f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x0012B5D0 File Offset: 0x001297D0
	private void method_3()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1137f;
		float num2 = 1103f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1529f, 667f, 193f, 1852f), num2);
				num2 += 1582f;
				if (num2 > 1680f)
				{
					num2 = 1612f;
				}
			}
			else
			{
				array[i] = new Color(1160f, 634f, 1180f, 1901f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x0012B6A0 File Offset: 0x001298A0
	private void method_4()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 111f;
		float num2 = 610f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(136f, 612f, 462f, 238f), num2);
				num2 += 200f;
				if (num2 > 806f)
				{
					num2 = 1602f;
				}
			}
			else
			{
				array[i] = new Color(1874f, 1981f, 79f, 1251f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x0012B770 File Offset: 0x00129970
	private void method_5()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 743f;
		float num2 = 1505f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1434f, 1481f, 49f, 612f), num2);
				num2 += 1656f;
				if (num2 > 1926f)
				{
					num2 = 1648f;
				}
			}
			else
			{
				array[i] = new Color(1969f, 528f, 1728f, 943f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x0012B840 File Offset: 0x00129A40
	private void method_6()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1711f;
		float num2 = 601f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1189f, 954f, 1417f, 255f), num2);
				num2 += 1878f;
				if (num2 > 443f)
				{
					num2 = 1429f;
				}
			}
			else
			{
				array[i] = new Color(13f, 1311f, 1961f, 1362f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002745 RID: 10053 RVA: 0x0012B910 File Offset: 0x00129B10
	private void method_7()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1148f;
		float num2 = 54f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(52f, 382f, 293f, 876f), num2);
				num2 += 615f;
				if (num2 > 1753f)
				{
					num2 = 1216f;
				}
			}
			else
			{
				array[i] = new Color(1021f, 1656f, 1856f, 1474f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x0012B9E0 File Offset: 0x00129BE0
	private void method_8()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 382f;
		float num2 = 1269f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1231f, 862f, 224f, 545f), num2);
				num2 += 446f;
				if (num2 > 1881f)
				{
					num2 = 1236f;
				}
			}
			else
			{
				array[i] = new Color(690f, 765f, 958f, 1603f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x0012BAB0 File Offset: 0x00129CB0
	private void method_9()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 379f;
		float num2 = 967f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1090f, 180f, 1880f, 1722f), num2);
				num2 += 532f;
				if (num2 > 299f)
				{
					num2 = 926f;
				}
			}
			else
			{
				array[i] = new Color(90f, 778f, 1185f, 1934f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x0012BB80 File Offset: 0x00129D80
	private void method_10()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1290f;
		float num2 = 883f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(261f, 480f, 1230f, 1703f), num2);
				num2 += 1681f;
				if (num2 > 984f)
				{
					num2 = 163f;
				}
			}
			else
			{
				array[i] = new Color(207f, 1026f, 648f, 1705f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x0012BC50 File Offset: 0x00129E50
	private void method_11()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1516f;
		float num2 = 764f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1493f, 1795f, 1065f, 620f), num2);
				num2 += 938f;
				if (num2 > 240f)
				{
					num2 = 1708f;
				}
			}
			else
			{
				array[i] = new Color(512f, 1345f, 651f, 7f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x0012BD20 File Offset: 0x00129F20
	private void method_12()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1368f;
		float num2 = 521f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(780f, 1382f, 1277f, 414f), num2);
				num2 += 647f;
				if (num2 > 1910f)
				{
					num2 = 1867f;
				}
			}
			else
			{
				array[i] = new Color(1076f, 1214f, 1919f, 961f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x0012BDF0 File Offset: 0x00129FF0
	private void method_13()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1725f;
		float num2 = 1569f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(976f, 1906f, 1178f, 1814f), num2);
				num2 += 201f;
				if (num2 > 1858f)
				{
					num2 = 638f;
				}
			}
			else
			{
				array[i] = new Color(659f, 1149f, 669f, 398f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x0012BEC0 File Offset: 0x0012A0C0
	private void method_14()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1726f;
		float num2 = 103f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(987f, 512f, 850f, 46f), num2);
				num2 += 1665f;
				if (num2 > 434f)
				{
					num2 = 750f;
				}
			}
			else
			{
				array[i] = new Color(1284f, 554f, 1643f, 12f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x0012BF90 File Offset: 0x0012A190
	private void method_15()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 349f;
		float num2 = 386f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1367f, 1328f, 672f, 1946f), num2);
				num2 += 1014f;
				if (num2 > 1178f)
				{
					num2 = 7f;
				}
			}
			else
			{
				array[i] = new Color(1138f, 479f, 1053f, 590f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x0012C060 File Offset: 0x0012A260
	private void method_16()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1272f;
		float num2 = 434f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(222f, 1186f, 1405f, 1644f), num2);
				num2 += 1564f;
				if (num2 > 1691f)
				{
					num2 = 514f;
				}
			}
			else
			{
				array[i] = new Color(1576f, 842f, 1390f, 1462f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x0012C130 File Offset: 0x0012A330
	private void method_17()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 621f;
		float num2 = 795f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1685f, 1574f, 1508f, 1202f), num2);
				num2 += 856f;
				if (num2 > 635f)
				{
					num2 = 1439f;
				}
			}
			else
			{
				array[i] = new Color(404f, 387f, 47f, 1311f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x0012C200 File Offset: 0x0012A400
	private void method_18()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 959f;
		float num2 = 1398f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(118f, 894f, 1725f, 919f), num2);
				num2 += 1069f;
				if (num2 > 1328f)
				{
					num2 = 1591f;
				}
			}
			else
			{
				array[i] = new Color(734f, 510f, 1455f, 550f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x0012C2D0 File Offset: 0x0012A4D0
	private void method_19()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 29f;
		float num2 = 404f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1626f, 725f, 767f, 132f), num2);
				num2 += 1824f;
				if (num2 > 629f)
				{
					num2 = 1208f;
				}
			}
			else
			{
				array[i] = new Color(119f, 1285f, 1100f, 129f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x0012C3A0 File Offset: 0x0012A5A0
	private void method_20()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1513f;
		float num2 = 766f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(761f, 679f, 229f, 1768f), num2);
				num2 += 1920f;
				if (num2 > 1625f)
				{
					num2 = 816f;
				}
			}
			else
			{
				array[i] = new Color(98f, 1372f, 1528f, 47f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x0012C470 File Offset: 0x0012A670
	private void method_21()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1117f;
		float num2 = 1466f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(638f, 1585f, 1776f, 1767f), num2);
				num2 += 1797f;
				if (num2 > 885f)
				{
					num2 = 439f;
				}
			}
			else
			{
				array[i] = new Color(738f, 378f, 1874f, 704f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x0012C540 File Offset: 0x0012A740
	private void Start()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 0.8f;
		float num2 = 0f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(0f, 0f, 0f, 0f), num2);
				num2 += 0.12f;
				if (num2 > 1f)
				{
					num2 = 1f;
				}
			}
			else
			{
				array[i] = new Color(1f, 1f, 1f, 1f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x0012C610 File Offset: 0x0012A810
	private void method_22()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1910f;
		float num2 = 1255f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1977f, 904f, 1256f, 1237f), num2);
				num2 += 1401f;
				if (num2 > 147f)
				{
					num2 = 489f;
				}
			}
			else
			{
				array[i] = new Color(1439f, 1569f, 126f, 958f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x0012C6E0 File Offset: 0x0012A8E0
	private void method_23()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1213f;
		float num2 = 189f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(561f, 1904f, 1173f, 132f), num2);
				num2 += 1811f;
				if (num2 > 100f)
				{
					num2 = 357f;
				}
			}
			else
			{
				array[i] = new Color(1118f, 872f, 1544f, 1544f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002758 RID: 10072 RVA: 0x0012C7B0 File Offset: 0x0012A9B0
	private void method_24()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 881f;
		float num2 = 1685f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1491f, 173f, 198f, 862f), num2);
				num2 += 728f;
				if (num2 > 1017f)
				{
					num2 = 1322f;
				}
			}
			else
			{
				array[i] = new Color(1541f, 1844f, 442f, 561f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x0012C880 File Offset: 0x0012AA80
	private void method_25()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 224f;
		float num2 = 1304f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(848f, 268f, 339f, 311f), num2);
				num2 += 236f;
				if (num2 > 26f)
				{
					num2 = 1542f;
				}
			}
			else
			{
				array[i] = new Color(1714f, 757f, 406f, 530f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x0012C950 File Offset: 0x0012AB50
	private void method_26()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 761f;
		float num2 = 68f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1716f, 1594f, 1283f, 1307f), num2);
				num2 += 721f;
				if (num2 > 1784f)
				{
					num2 = 1975f;
				}
			}
			else
			{
				array[i] = new Color(914f, 406f, 1012f, 1844f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x0012CA20 File Offset: 0x0012AC20
	private void method_27()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1588f;
		float num2 = 1016f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(303f, 893f, 1719f, 1878f), num2);
				num2 += 541f;
				if (num2 > 754f)
				{
					num2 = 1416f;
				}
			}
			else
			{
				array[i] = new Color(1190f, 1915f, 1612f, 566f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600275C RID: 10076 RVA: 0x0012CAF0 File Offset: 0x0012ACF0
	private void method_28()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1691f;
		float num2 = 1823f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1418f, 1798f, 1635f, 322f), num2);
				num2 += 1864f;
				if (num2 > 747f)
				{
					num2 = 1368f;
				}
			}
			else
			{
				array[i] = new Color(268f, 406f, 1378f, 469f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x0012CBC0 File Offset: 0x0012ADC0
	private void method_29()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 384f;
		float num2 = 934f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(996f, 941f, 631f, 1833f), num2);
				num2 += 537f;
				if (num2 > 468f)
				{
					num2 = 904f;
				}
			}
			else
			{
				array[i] = new Color(1088f, 597f, 299f, 1382f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600275E RID: 10078 RVA: 0x0012CC90 File Offset: 0x0012AE90
	private void method_30()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 661f;
		float num2 = 1703f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1398f, 695f, 1705f, 1705f), num2);
				num2 += 1571f;
				if (num2 > 943f)
				{
					num2 = 284f;
				}
			}
			else
			{
				array[i] = new Color(1951f, 1361f, 1541f, 479f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x0012CD60 File Offset: 0x0012AF60
	private void method_31()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1929f;
		float num2 = 1747f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(666f, 1275f, 1139f, 270f), num2);
				num2 += 620f;
				if (num2 > 1533f)
				{
					num2 = 765f;
				}
			}
			else
			{
				array[i] = new Color(1761f, 910f, 782f, 192f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x0012CE30 File Offset: 0x0012B030
	private void method_32()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 777f;
		float num2 = 1724f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(899f, 1586f, 752f, 544f), num2);
				num2 += 1338f;
				if (num2 > 1755f)
				{
					num2 = 583f;
				}
			}
			else
			{
				array[i] = new Color(378f, 346f, 881f, 1246f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002761 RID: 10081 RVA: 0x0012CF00 File Offset: 0x0012B100
	private void method_33()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 902f;
		float num2 = 490f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(234f, 983f, 1043f, 1513f), num2);
				num2 += 1269f;
				if (num2 > 852f)
				{
					num2 = 516f;
				}
			}
			else
			{
				array[i] = new Color(1342f, 1298f, 1702f, 844f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002762 RID: 10082 RVA: 0x0012CFD0 File Offset: 0x0012B1D0
	private void method_34()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1544f;
		float num2 = 549f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(105f, 501f, 144f, 422f), num2);
				num2 += 1202f;
				if (num2 > 1827f)
				{
					num2 = 1878f;
				}
			}
			else
			{
				array[i] = new Color(1670f, 144f, 524f, 1496f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002763 RID: 10083 RVA: 0x0012D0A0 File Offset: 0x0012B2A0
	private void method_35()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 213f;
		float num2 = 502f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1851f, 589f, 549f, 1703f), num2);
				num2 += 120f;
				if (num2 > 1787f)
				{
					num2 = 333f;
				}
			}
			else
			{
				array[i] = new Color(225f, 1651f, 1486f, 645f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002764 RID: 10084 RVA: 0x0012D170 File Offset: 0x0012B370
	private void method_36()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1080f;
		float num2 = 1866f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(266f, 1775f, 540f, 1698f), num2);
				num2 += 397f;
				if (num2 > 1184f)
				{
					num2 = 828f;
				}
			}
			else
			{
				array[i] = new Color(346f, 14f, 702f, 1564f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002765 RID: 10085 RVA: 0x0012D240 File Offset: 0x0012B440
	private void method_37()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1321f;
		float num2 = 876f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1421f, 1059f, 339f, 930f), num2);
				num2 += 472f;
				if (num2 > 300f)
				{
					num2 = 257f;
				}
			}
			else
			{
				array[i] = new Color(585f, 295f, 1655f, 897f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002766 RID: 10086 RVA: 0x0012D310 File Offset: 0x0012B510
	private void method_38()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1786f;
		float num2 = 180f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(609f, 1979f, 1681f, 1872f), num2);
				num2 += 1543f;
				if (num2 > 697f)
				{
					num2 = 156f;
				}
			}
			else
			{
				array[i] = new Color(309f, 850f, 1325f, 356f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002767 RID: 10087 RVA: 0x0012D3E0 File Offset: 0x0012B5E0
	private void method_39()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 175f;
		float num2 = 530f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(777f, 1754f, 413f, 954f), num2);
				num2 += 961f;
				if (num2 > 711f)
				{
					num2 = 263f;
				}
			}
			else
			{
				array[i] = new Color(646f, 750f, 1866f, 411f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002768 RID: 10088 RVA: 0x0012D4B0 File Offset: 0x0012B6B0
	private void method_40()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1595f;
		float num2 = 898f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(146f, 1859f, 434f, 534f), num2);
				num2 += 1464f;
				if (num2 > 1112f)
				{
					num2 = 530f;
				}
			}
			else
			{
				array[i] = new Color(792f, 1140f, 1791f, 1969f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x0012D580 File Offset: 0x0012B780
	private void method_41()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 64f;
		float num2 = 1911f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(133f, 1518f, 149f, 1579f), num2);
				num2 += 835f;
				if (num2 > 1493f)
				{
					num2 = 1347f;
				}
			}
			else
			{
				array[i] = new Color(593f, 694f, 715f, 825f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x0012D650 File Offset: 0x0012B850
	private void method_42()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1853f;
		float num2 = 1248f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1721f, 522f, 540f, 1916f), num2);
				num2 += 1457f;
				if (num2 > 1172f)
				{
					num2 = 1044f;
				}
			}
			else
			{
				array[i] = new Color(218f, 1059f, 219f, 1026f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x0012D720 File Offset: 0x0012B920
	private void method_43()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1271f;
		float num2 = 1488f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(702f, 740f, 1238f, 1495f), num2);
				num2 += 323f;
				if (num2 > 699f)
				{
					num2 = 865f;
				}
			}
			else
			{
				array[i] = new Color(683f, 441f, 815f, 770f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x0012D7F0 File Offset: 0x0012B9F0
	private void method_44()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 751f;
		float num2 = 1200f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1431f, 667f, 1764f, 1401f), num2);
				num2 += 799f;
				if (num2 > 1234f)
				{
					num2 = 31f;
				}
			}
			else
			{
				array[i] = new Color(1849f, 1640f, 527f, 1382f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600276D RID: 10093 RVA: 0x0012D8C0 File Offset: 0x0012BAC0
	private void method_45()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 146f;
		float num2 = 1223f;
		for (int i = 1; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1926f, 1545f, 544f, 433f), num2);
				num2 += 204f;
				if (num2 > 827f)
				{
					num2 = 930f;
				}
			}
			else
			{
				array[i] = new Color(1338f, 1684f, 405f, 1759f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x0012D990 File Offset: 0x0012BB90
	private void method_46()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 1241f;
		float num2 = 880f;
		for (int i = 0; i < vertices.Length; i++)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1678f, 1580f, 530f, 347f), num2);
				num2 += 256f;
				if (num2 > 255f)
				{
					num2 = 69f;
				}
			}
			else
			{
				array[i] = new Color(1180f, 1350f, 1827f, 1585f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x0012DA60 File Offset: 0x0012BC60
	private void method_47()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 154f;
		float num2 = 692f;
		for (int i = 1; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1195f, 152f, 504f, 1305f), num2);
				num2 += 1048f;
				if (num2 > 1888f)
				{
					num2 = 968f;
				}
			}
			else
			{
				array[i] = new Color(341f, 1949f, 715f, 879f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x0012DB30 File Offset: 0x0012BD30
	private void method_48()
	{
		Mesh mesh = base.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] array = new Color[vertices.Length];
		float num = 635f;
		float num2 = 392f;
		for (int i = 0; i < vertices.Length; i += 0)
		{
			if ((float)i / (float)vertices.Length > num)
			{
				array[i] = Color.Lerp(Color.white, new Color(1771f, 1680f, 1461f, 1539f), num2);
				num2 += 1058f;
				if (num2 > 669f)
				{
					num2 = 1056f;
				}
			}
			else
			{
				array[i] = new Color(48f, 824f, 539f, 527f);
			}
		}
		mesh.colors = array;
		UnityEngine.Object.Destroy(this);
	}
}
