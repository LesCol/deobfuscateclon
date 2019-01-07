using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000D1 RID: 209
public abstract class GClass16
{
	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06002886 RID: 10374
	public abstract int Int32_1 { get; }

	// Token: 0x06002887 RID: 10375 RVA: 0x00011429 File Offset: 0x0000F629
	public GClass16(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06002888 RID: 10376 RVA: 0x00011438 File Offset: 0x0000F638
	public float Single_0
	{
		get
		{
			return this.gclass27_0.method_8(this.uint_0, this.gclass27_0.float_3);
		}
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x00011456 File Offset: 0x0000F656
	public static bool smethod_0(GClass16 gclass16_0, GClass16 gclass16_1)
	{
		if (gclass16_0 != null && gclass16_1 != null)
		{
			return gclass16_0.vmethod_0(gclass16_1);
		}
		return (gclass16_0 == null && gclass16_1 == null) || (gclass16_0 != null && gclass16_1 != null);
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x00011477 File Offset: 0x0000F677
	protected virtual bool vmethod_0(GClass16 gclass16_0)
	{
		return this.uint_0 == gclass16_0.uint_0 && this.Int32_1 == gclass16_0.Int32_1;
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x00011498 File Offset: 0x0000F698
	public static bool smethod_1(GClass16 gclass16_0, GClass16 gclass16_1)
	{
		return !GClass16.smethod_0(gclass16_0, gclass16_1);
	}

	// Token: 0x0600288C RID: 10380 RVA: 0x000114A4 File Offset: 0x0000F6A4
	protected virtual bool vmethod_1(GClass16 gclass16_0)
	{
		return this.uint_0 < gclass16_0.uint_0 || (this.uint_0 == gclass16_0.uint_0 && this.Int32_1 < gclass16_0.Int32_1);
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x000114D5 File Offset: 0x0000F6D5
	public static bool smethod_2(GClass16 gclass16_0, GClass16 gclass16_1)
	{
		return gclass16_0.vmethod_1(gclass16_1);
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x000114DE File Offset: 0x0000F6DE
	public static bool smethod_3(GClass16 gclass16_0, GClass16 gclass16_1)
	{
		return GClass16.smethod_1(gclass16_0, gclass16_1) && !GClass16.smethod_2(gclass16_0, gclass16_1);
	}

	// Token: 0x0600288F RID: 10383 RVA: 0x000114F5 File Offset: 0x0000F6F5
	public static bool smethod_4(GClass16 gclass16_0, GClass16 gclass16_1)
	{
		return GClass16.smethod_2(gclass16_0, gclass16_1) || GClass16.smethod_0(gclass16_0, gclass16_1);
	}

	// Token: 0x06002890 RID: 10384 RVA: 0x00011509 File Offset: 0x0000F709
	public static bool smethod_5(GClass16 gclass16_0, GClass16 gclass16_1)
	{
		return GClass16.smethod_3(gclass16_0, gclass16_1) || GClass16.smethod_0(gclass16_0, gclass16_1);
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x0001151D File Offset: 0x0000F71D
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	// Token: 0x06002892 RID: 10386 RVA: 0x00011526 File Offset: 0x0000F726
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x0012F6E8 File Offset: 0x0012D8E8
	public static int smethod_6<T>(T gparam_0, T[] gparam_1) where T : GClass16
	{
		int i = 0;
		int num = gparam_1.Length - 1;
		int result = -1;
		while (i <= num)
		{
			int num2 = (i + num) / 2;
			result = num2;
			if (GClass16.smethod_0(gparam_1[num2], gparam_0))
			{
				break;
			}
			if (GClass16.smethod_2(gparam_1[num2], gparam_0))
			{
				i = num2 + 1;
			}
			else
			{
				num = num2 - 1;
			}
		}
		return result;
	}

	// Token: 0x06002894 RID: 10388 RVA: 0x0012F74C File Offset: 0x0012D94C
	public static int smethod_7<T>(uint uint_1, T[] gparam_0) where T : GClass16
	{
		int i = 0;
		int num = gparam_0.Length - 1;
		int result = -1;
		while (i <= num)
		{
			int num2 = (i + num) / 2;
			result = num2;
			if (gparam_0[num2].uint_0 == uint_1)
			{
				break;
			}
			if (gparam_0[num2].uint_0 < uint_1)
			{
				i = num2 + 1;
			}
			else
			{
				num = num2 - 1;
			}
		}
		return result;
	}

	// Token: 0x06002895 RID: 10389 RVA: 0x0012F7A8 File Offset: 0x0012D9A8
	public static T[] smethod_8<T>(uint uint_1, T[] gparam_0) where T : GClass16
	{
		int num = GClass16.smethod_7<T>(uint_1, gparam_0);
		if (num != -1 && gparam_0[num].uint_0 == uint_1)
		{
			int i = num;
			int j = num;
			while (i > 0)
			{
				if (gparam_0[num].uint_0 != gparam_0[i - 1].uint_0)
				{
					break;
				}
				i--;
			}
			while (j < gparam_0.Length - 1)
			{
				if (gparam_0[num].uint_0 != gparam_0[j + 1].uint_0)
				{
					break;
				}
				j++;
			}
			int num2 = j - i + 1;
			T[] array = new T[num2];
			Array.Copy(gparam_0, i, array, 0, num2);
			return array;
		}
		return new T[0];
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x0012F86C File Offset: 0x0012DA6C
	public static int smethod_9<T>(T gparam_0, T[] gparam_1) where T : GClass16
	{
		int num = GClass16.smethod_6<T>(gparam_0, gparam_1);
		if (num != -1 && GClass16.smethod_1(gparam_1[num], gparam_0))
		{
			num = -1;
		}
		return num;
	}

	// Token: 0x06002897 RID: 10391 RVA: 0x0012F8A4 File Offset: 0x0012DAA4
	public static int smethod_10<T>(uint uint_1, T[] gparam_0) where T : GClass16
	{
		int num = GClass16.smethod_7<T>(uint_1, gparam_0);
		if (num != -1 && gparam_0[num].uint_0 != uint_1)
		{
			num = -1;
		}
		return num;
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x0001152E File Offset: 0x0000F72E
	private static int smethod_11<T>(Type type_0, int int_1, List<T> list_0) where T : GClass16
	{
		if (int_1 >= 0 && int_1 <= list_0.Count - 1)
		{
			for (int_1--; int_1 >= 0; int_1--)
			{
				if (list_0[int_1].GetType() == type_0)
				{
					return int_1;
				}
			}
			return -1;
		}
		return -1;
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x0012F8D4 File Offset: 0x0012DAD4
	private static T smethod_12<T>(Type type_0, int int_1, List<T> list_0) where T : GClass16
	{
		int num = GClass16.smethod_11<T>(type_0, int_1, list_0);
		if (num == -1)
		{
			return default(T);
		}
		return list_0[num];
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x0012F900 File Offset: 0x0012DB00
	private static int smethod_13<T>(Type type_0, int int_1, List<T> list_0) where T : GClass16
	{
		if (int_1 >= 0 && int_1 <= list_0.Count - 1)
		{
			for (int_1++; int_1 < list_0.Count; int_1++)
			{
				if (list_0[int_1].GetType() == type_0)
				{
					return int_1;
				}
			}
			return -1;
		}
		return -1;
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x0012F950 File Offset: 0x0012DB50
	private static T smethod_14<T>(Type type_0, int int_1, List<T> list_0) where T : GClass16
	{
		int num = GClass16.smethod_13<T>(type_0, int_1, list_0);
		if (num == -1)
		{
			return default(T);
		}
		return list_0[num];
	}

	// Token: 0x0600289C RID: 10396 RVA: 0x0012F97C File Offset: 0x0012DB7C
	public static int smethod_15<T>(T gparam_0, List<T> list_0) where T : GClass16
	{
		int num = -1;
		if (list_0.Count > 0)
		{
			if (GClass16.smethod_2(list_0[list_0.Count - 1], gparam_0))
			{
				num = list_0.Count;
				list_0.Insert(num, gparam_0);
			}
			else
			{
				num = GClass16.smethod_6<T>(gparam_0, list_0.ToArray());
				if (num != -1)
				{
					if (GClass16.smethod_0(list_0[num], gparam_0) && gparam_0.Int32_1 == list_0[num].Int32_1)
					{
						list_0[num] = gparam_0;
					}
					else
					{
						if (GClass16.smethod_3(gparam_0, list_0[num]))
						{
							num++;
						}
						list_0.Insert(num, gparam_0);
					}
				}
			}
		}
		if (num == -1)
		{
			list_0.Add(gparam_0);
			num = list_0.Count - 1;
		}
		if (gparam_0.Int32_1 == 4)
		{
			GClass19 gclass = list_0[num] as GClass19;
			GClass19 gclass2 = GClass16.smethod_12<T>(typeof(GClass19), num, list_0) as GClass19;
			GClass19 gclass3 = GClass16.smethod_14<T>(typeof(GClass19), num, list_0) as GClass19;
			gclass.gclass19_0 = gclass2;
			if (GClass16.smethod_1(gclass2, null))
			{
				gclass2.gclass19_1 = gclass;
			}
			gclass.gclass19_1 = gclass3;
			if (GClass16.smethod_1(gclass3, null))
			{
				gclass3.gclass19_0 = gclass;
			}
			GClass19.GEnum15 genum = gclass.genum15_0;
			gclass2 = gclass.gclass19_0;
			gclass3 = gclass.gclass19_1;
			GClass19 gclass16_ = null;
			bool flag = false;
			while (GClass16.smethod_1(gclass2, null))
			{
				if (gclass2.uint_0 != gclass.uint_0)
				{
					break;
				}
				if (gclass2.genum13_0 == GClass19.GEnum13.OPEN)
				{
					gclass16_ = gclass2;
				}
				else
				{
					flag = true;
				}
				genum |= gclass2.genum15_0;
				gclass2 = gclass2.gclass19_0;
			}
			while (GClass16.smethod_1(gclass3, null))
			{
				if (gclass3.uint_0 != gclass.uint_0)
				{
					break;
				}
				if (gclass3.genum13_0 == GClass19.GEnum13.OPEN)
				{
					gclass16_ = gclass3;
				}
				else
				{
					flag = true;
				}
				genum |= gclass3.genum15_0;
				gclass3 = gclass3.gclass19_1;
			}
			if ((gclass.genum13_0 == GClass19.GEnum13.OPEN || !GClass16.smethod_1(gclass16_, null)) && (gclass.genum13_0 != GClass19.GEnum13.OPEN || !flag))
			{
				gclass.genum15_0 = genum;
				gclass2 = gclass.gclass19_0;
				gclass3 = gclass.gclass19_1;
				while (GClass16.smethod_1(gclass2, null))
				{
					if (gclass2.uint_0 != gclass.uint_0)
					{
						break;
					}
					if (gclass2.genum15_0 != genum)
					{
						Debug.Log(string.Format("Not match flags previous {0} {1}", num, gparam_0.GetType()));
					}
					gclass2.genum15_0 = genum;
					gclass2 = gclass2.gclass19_0;
				}
				while (GClass16.smethod_1(gclass3, null))
				{
					if (gclass3.uint_0 != gclass.uint_0)
					{
						break;
					}
					if (gclass3.genum15_0 != genum)
					{
						Debug.Log(string.Format("Not match flags next {0} {1}", num, gparam_0.GetType()));
					}
					gclass3.genum15_0 = genum;
					gclass3 = gclass3.gclass19_1;
				}
			}
		}
		return num;
	}

	// Token: 0x0600289D RID: 10397 RVA: 0x0012FC60 File Offset: 0x0012DE60
	public static bool smethod_16<T>(T gparam_0, List<T> list_0, bool bool_0 = true) where T : GClass16
	{
		int num = GClass16.smethod_9<T>(gparam_0, list_0.ToArray());
		if (num != -1)
		{
			if (bool_0 && gparam_0.GetType() == typeof(GClass19))
			{
				GClass19 gclass = GClass16.smethod_12<T>(gparam_0.GetType(), num, list_0) as GClass19;
				GClass19 gclass2 = GClass16.smethod_14<T>(gparam_0.GetType(), num, list_0) as GClass19;
				if (GClass16.smethod_1(gclass, null))
				{
					gclass.gclass19_1 = gclass2;
				}
				if (GClass16.smethod_1(gclass2, null))
				{
					gclass2.gclass19_0 = gclass;
				}
			}
			list_0.RemoveAt(num);
			return true;
		}
		return false;
	}

	// Token: 0x0600289E RID: 10398 RVA: 0x0012FD04 File Offset: 0x0012DF04
	public static T[] smethod_17<T>(T[] gparam_0, uint uint_1, uint uint_2) where T : GClass16
	{
		int sourceIndex;
		int num;
		GClass16.smethod_18<T>(gparam_0, uint_1, uint_2, out sourceIndex, out num);
		T[] array = new T[num];
		Array.Copy(gparam_0, sourceIndex, array, 0, array.Length);
		return array;
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x0012FD34 File Offset: 0x0012DF34
	public static void smethod_18<T>(T[] gparam_0, uint uint_1, uint uint_2, out int int_1, out int int_2) where T : GClass16
	{
		int_1 = 0;
		int_2 = 0;
		if (uint_1 <= uint_2 && gparam_0.Length >= 1)
		{
			int num = GClass16.smethod_7<T>(uint_1, gparam_0);
			int num2 = GClass16.smethod_7<T>(uint_2, gparam_0);
			if (num != -1)
			{
				if (num2 != -1)
				{
					while (num < gparam_0.Length && gparam_0[num].uint_0 < uint_1)
					{
						num++;
					}
					if (num > gparam_0.Length - 1)
					{
						return;
					}
					while (num - 1 >= 0 && gparam_0[num - 1].uint_0 >= uint_1)
					{
						num--;
					}
					while (num2 >= 0 && gparam_0[num2].uint_0 > uint_2)
					{
						num2--;
					}
					if (num2 < 0)
					{
						return;
					}
					while (num2 + 1 < gparam_0.Length && gparam_0[num2 + 1].uint_0 <= uint_2)
					{
						num2++;
					}
					if (num > num2)
					{
						return;
					}
					int_1 = num;
					int_2 = num2 - num + 1;
					return;
				}
			}
			return;
		}
	}

	// Token: 0x0400062D RID: 1581
	[NonSerialized]
	public Song gclass27_0;

	// Token: 0x0400062E RID: 1582
	public uint uint_0;

	// Token: 0x0400062F RID: 1583
	public const int int_0 = -1;

	// Token: 0x020000D2 RID: 210
	public enum GEnum16
	{
		// Token: 0x04000631 RID: 1585
		TimeSignature,
		// Token: 0x04000632 RID: 1586
		BPM,
		// Token: 0x04000633 RID: 1587
		Event,
		// Token: 0x04000634 RID: 1588
		Section,
		// Token: 0x04000635 RID: 1589
		Note,
		// Token: 0x04000636 RID: 1590
		Starpower,
		// Token: 0x04000637 RID: 1591
		ChartEvent
	}
}
