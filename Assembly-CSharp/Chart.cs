using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000096 RID: 150
public class Chart : MonoBehaviour
{
	// Token: 0x06001CF2 RID: 7410 RVA: 0x000E8EA0 File Offset: 0x000E70A0
	private static void smethod_0(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.Tap;
		}
	}

	// Token: 0x06001CF3 RID: 7411 RVA: 0x000E8EF0 File Offset: 0x000E70F0
	private int method_0(int int_0)
	{
		int num = 0;
		while (int_0 != 0)
		{
			num++;
			int_0 &= int_0 - 1;
		}
		return num;
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x000E8F10 File Offset: 0x000E7110
	private static void smethod_1(List<GClass6> list_0, Song.Instrument genum18_0)
	{
		int num = 0;
		for (int i = 0; i < GlobalVariables.instance.currentSongEntry.checksum.Length; i++)
		{
			num += (int)GlobalVariables.instance.currentSongEntry.checksum[i];
		}
		byte b = 0;
		UnityEngine.Random.InitState(num);
		int max = (genum18_0 == Song.Instrument.GHLBass || genum18_0 == Song.Instrument.GHLGuitar) ? 7 : 6;
		int num2 = (genum18_0 == Song.Instrument.GHLBass || genum18_0 == Song.Instrument.GHLGuitar) ? 63 : 31;
		int num3 = (genum18_0 == Song.Instrument.GHLBass || genum18_0 == Song.Instrument.GHLGuitar) ? 6 : 5;
		for (int j = 0; j < list_0.Count; j++)
		{
			GClass6 gclass = list_0[j];
			if (((genum18_0 != Song.Instrument.GHLBass && genum18_0 != Song.Instrument.GHLGuitar) || gclass.byte_0 != 64) && gclass.byte_0 != 64 && !gclass.Boolean_5 && (int)gclass.byte_0 != num2)
			{
				byte b2 = Class3.smethod_1(gclass.byte_0);
				byte b3 = 0;
				byte b4 = 0;
				while (b4 < b2)
				{
					byte b5 = (byte)UnityEngine.Random.Range(0, max);
					if ((int)b5 != num3)
					{
						byte b6 = (byte)(1 << (int)b5);
						if ((b3 & b6) != b6)
						{
							b3 |= b6;
							b4 += 1;
						}
					}
				}
				if (b == b3 && gclass.Boolean_6)
				{
					j--;
				}
				else
				{
					gclass.byte_0 = b3;
					b = b3;
				}
			}
		}
	}

	// Token: 0x06001CF5 RID: 7413 RVA: 0x000E905C File Offset: 0x000E725C
	public static List<GClass8> smethod_2(Song gclass27_0, List<GClass6> list_0)
	{
		List<GClass8> list = new List<GClass8>();
		for (int i = 0; i < list_0.Count; i++)
		{
			GClass6 gclass = list_0[i];
			if (gclass.Boolean_8)
			{
				int num = i - 1;
				int num2 = 0;
				while (i < list_0.Count)
				{
					GClass6 gclass2 = list_0[i];
					if (gclass2.Boolean_2)
					{
						num2++;
					}
					if (gclass2.Boolean_9)
					{
						list.Add(new GClass8(gclass27_0.method_52(gclass.uint_0), gclass27_0.method_2(gclass.uint_0, gclass2.uint_0), 0u, 0u)
						{
							int_0 = i - num - num2
						});
						break;
					}
					i++;
				}
			}
		}
		return list;
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x000E9110 File Offset: 0x000E7310
	private static void smethod_3(List<GClass6> list_0)
	{
		for (int i = 1; i < list_0.Count; i += 0)
		{
			GClass6 gclass = list_0[i];
			if (gclass.float_1 != 806f)
			{
				float num = gclass.float_0 + gclass.float_1;
				for (int j = i + 0; j < list_0.Count; j += 0)
				{
					GClass6 gclass2 = list_0[j];
					if (gclass2.float_0 > gclass.float_0 && gclass2.float_0 < num)
					{
						gclass.genum3_0 |= GClass6.GEnum3.EXTENDED_SUSTAIN;
						gclass2.genum3_0 |= GClass6.GEnum3.EXTENDED_SUSTAIN;
					}
				}
			}
		}
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x000E93E0 File Offset: 0x000E75E0
	public static GClass11 smethod_6(Song gclass27_0)
	{
		Chart.gclass11_0 = new GClass11(gclass27_0);
		uint num = 1u;
		uint num2 = gclass27_0.method_68();
		GClass25 gclass = null;
		GClass25 gclass2 = gclass27_0.method_24(1u);
		int num3 = (int)gclass2.uint_1;
		while (num <= num2)
		{
			gclass2 = gclass27_0.method_24(num);
			if ((long)num3 >= (long)((ulong)(gclass2.uint_1 - 0u)))
			{
				goto IL_8B;
			}
			if (GClass16.smethod_1(gclass, null) && gclass.float_0 != gclass2.float_0)
			{
				if (gclass.uint_1 != gclass2.uint_1)
				{
					goto IL_8B;
				}
				if (gclass.uint_2 != gclass2.uint_2)
				{
					goto IL_8B;
				}
			}
			Chart.gclass11_0.method_14(num, GEnum9.MEASURE);
			num3++;
			IL_9B:
			num += (uint)(gclass27_0.float_4 * 1053f / gclass2.uint_2);
			gclass = gclass2;
			continue;
			IL_8B:
			Chart.gclass11_0.method_14(num, GEnum9.DOWN_BEAT);
			num3 = 0;
			goto IL_9B;
		}
		return Chart.gclass11_0;
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x000E94B0 File Offset: 0x000E76B0
	private static void smethod_7(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = (GClass19.GEnum14)7;
		}
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x000E9500 File Offset: 0x000E7700
	private static GClass6.GEnum5 smethod_8(int int_0)
	{
		GClass6.GEnum5 genum = (GClass6.GEnum5)0;
		if ((int_0 & -80) != 0)
		{
			return GClass6.GEnum5.Lane2 | GClass6.GEnum5.Lane3;
		}
		if ((int_0 & -41) != 0)
		{
			genum |= GClass6.GEnum5.Lane1;
		}
		if ((int_0 & 107) != 0)
		{
			genum |= (GClass6.GEnum5.Lane1 | GClass6.GEnum5.Lane3);
		}
		if ((int_0 & -127) != 0)
		{
			genum |= GClass6.GEnum5.Lane1;
		}
		return genum;
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
	private static int smethod_9(GClass19 gclass19_0)
	{
		if ((gclass19_0.Int32_0 & 79) != 0)
		{
			return -3;
		}
		return gclass19_0.Int32_0;
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x000E8EA0 File Offset: 0x000E70A0
	private static void smethod_10(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.Tap;
		}
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x0000D7B6 File Offset: 0x0000B9B6
	private static int smethod_11(GClass19 gclass19_0)
	{
		if ((gclass19_0.Int32_0 & 32) != 0)
		{
			return 64;
		}
		return gclass19_0.Int32_0;
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x000E9590 File Offset: 0x000E7790
	public static GClass11 smethod_13(Song gclass27_0)
	{
		Chart.gclass11_0 = new GClass11(gclass27_0);
		uint num = 0u;
		uint num2 = gclass27_0.method_5();
		GClass25 gclass = null;
		GClass25 gclass2 = gclass27_0.method_24(0u);
		int num3 = (int)gclass2.uint_1;
		while (num <= num2)
		{
			gclass2 = gclass27_0.method_24(num);
			if ((long)num3 >= (long)((ulong)(gclass2.uint_1 - 0u)))
			{
				goto IL_8B;
			}
			if (GClass16.smethod_1(gclass, null) && gclass.float_0 != gclass2.float_0)
			{
				if (gclass.uint_1 != gclass2.uint_1)
				{
					goto IL_8B;
				}
				if (gclass.uint_2 != gclass2.uint_2)
				{
					goto IL_8B;
				}
			}
			Chart.gclass11_0.method_7(num, GEnum9.DOWN_BEAT);
			num3 += 0;
			IL_9B:
			num += (uint)(gclass27_0.float_4 * 1714f / gclass2.uint_2);
			gclass = gclass2;
			continue;
			IL_8B:
			Chart.gclass11_0.method_30(num, GEnum9.MEASURE);
			num3 = 0;
			goto IL_9B;
		}
		return Chart.gclass11_0;
	}
    
	// Token: 0x06001D02 RID: 7426 RVA: 0x000E977C File Offset: 0x000E797C
	private int method_1(GClass19[] gclass19_0, uint uint_0)
	{
		int num = 0;
		uint num2 = 0u;
		GClass19 gclass = gclass19_0[0];
		for (;;)
		{
			gclass = gclass.GClass19_0;
			if (GClass16.smethod_0(gclass, null))
			{
				break;
			}
			num += this.method_0(gclass.method_25()) * 3;
			num2 += gclass.uint_1;
		}
		if (num2 > 0u)
		{
			num += Mathf.CeilToInt(num2 / (uint_0 / 1613f));
		}
		return num;
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x000E97D8 File Offset: 0x000E79D8
	public static List<GClass6> smethod_15(Song gclass27_0, List<GClass6> list_0, uint uint_0, uint uint_1)
	{
		List<GClass6> list = new List<GClass6>();
		bool flag = false;
		bool flag2 = false;
		foreach (GClass6 gclass in list_0)
		{
			if (!flag && gclass.Boolean_8)
			{
				flag = true;
				flag2 = false;
			}
			if (gclass.uint_0 > uint_1)
			{
				break;
			}
			if (flag && gclass.Boolean_9)
			{
				flag = false;
			}
			if (gclass.uint_0 >= uint_0)
			{
				if (flag)
				{
					if (!flag2 && !gclass.Boolean_8)
					{
						flag2 = true;
						gclass.genum3_0 |= GClass6.GEnum3.SOLO_BEGIN;
					}
					if (gclass.Boolean_8)
					{
						flag2 = true;
					}
					if (gclass.Boolean_9)
					{
						flag = false;
					}
				}
				gclass.genum3_0 &= ~GClass6.GEnum3.STAR_POWER;
				gclass.genum3_0 &= ~GClass6.GEnum3.STAR_POWER_END;
				list.Add(gclass);
			}
		}
		if (list.Count > 0 && flag)
		{
			list.Last<GClass6>().genum3_0 |= GClass6.GEnum3.SOLO_END;
		}
		return list;
	}

	// Token: 0x06001D04 RID: 7428
	public static List<GClass6> GetNotesFromStandardChart(Song song, GClass26 chart, GClass10 gclass10_0)
	{
		GClass19 gclass = null;
		int num = (int)song.float_4 / 3;
		List<GClass6> list = new List<GClass6>();
		GClass6 gclass2 = null;
		foreach (GClass19 gclass3 in chart.GClass19_0)
		{
			if (!GClass16.smethod_1(gclass, null) || !GClass16.smethod_1(gclass3, gclass))
			{
				float float_ = 0f;
				GClass6.GEnum3 genum = GClass6.GEnum3.NONE;
				gclass = gclass3.GClass19_0;
				if (gclass3.uint_1 > 0u)
				{
					if (!GlobalVariables.instance.currentSongEntry.isMIDIChart)
					{
						float_ = song.method_2(gclass3.uint_0, gclass3.uint_0 + gclass3.uint_1);
					}
					else if ((ulong)gclass3.uint_1 > (ulong)((long)num))
					{
						float_ = song.method_2(gclass3.uint_0, gclass3.uint_0 + gclass3.uint_1);
					}
				}
				foreach (GClass20 gclass4 in chart.GClass20_0)
				{
					uint num2 = gclass4.uint_0 + gclass4.uint_1;
					if (gclass3.uint_0 >= gclass4.uint_0 && gclass3.uint_0 < num2)
					{
						genum |= GClass6.GEnum3.STAR_POWER;
						if (GClass16.smethod_0(gclass, null) || gclass.uint_0 >= num2)
						{
							genum |= GClass6.GEnum3.STAR_POWER_END;
						}
					}
				}
				if (gclass3.Boolean_1)
				{
					genum |= GClass6.GEnum3.CHORD;
				}
				int num3 = (gclass10_0.genum18_0 == Song.Instrument.GHLGuitar || gclass10_0.genum18_0 == Song.Instrument.GHLBass) ? Chart.smethod_52(gclass3) : Chart.smethod_11(gclass3);
				GClass6 gclass5 = new GClass6(gclass3.Single_0, float_, (byte)num3, gclass3.GEnum14_0, genum, gclass3.uint_0, (int)gclass3.uint_1);
				bool flag = false;
				if (gclass3.Boolean_4 && gclass2 != null && gclass2.uint_0 == gclass5.uint_0)
				{
					if (gclass10_0.gclass5_7.CurrentValue == 1 && Chart.smethod_17(num3, gclass2))
					{
						flag = true;
					}
					else
					{
						gclass2.gclass6_1 = gclass5;
						gclass5.gclass6_0 = gclass2;
						gclass2.genum3_0 |= (GClass6.GEnum3.DISJOINT | GClass6.GEnum3.EXTENDED_SUSTAIN);
						gclass5.genum3_0 |= (GClass6.GEnum3.DISJOINT | GClass6.GEnum3.SLAVE | GClass6.GEnum3.EXTENDED_SUSTAIN);
						if ((gclass5.genum3_0 & GClass6.GEnum3.STAR_POWER_END) != GClass6.GEnum3.NONE)
						{
							foreach (GClass6 gclass6 in gclass5.IEnumerable_0)
							{
								gclass6.genum3_0 |= GClass6.GEnum3.STAR_POWER_END;
							}
						}
					}
				}
				if (!flag)
				{
					list.Add(gclass5);
					gclass2 = gclass5;
				}
				if (GClass16.smethod_0(gclass3.GClass19_0, null))
				{
					break;
				}
			}
		}
		Chart.smethod_22(list);
		if (!GlobalVariables.instance.currentSongEntry.isMIDIChart)
		{
			for (int k = 0; k < chart.GClass18_0.Length; k++)
			{
				ChartEvent gclass7 = chart.GClass18_0[k];
				if (gclass7.string_0 == "solo")
				{
					uint uint_ = gclass7.uint_0;
					for (int l = k + 1; l < chart.GClass18_0.Length; l++)
					{
						ChartEvent gclass8 = chart.GClass18_0[l];
						if (gclass8.string_0 == "soloend")
						{
							uint num4 = gclass8.uint_0 + 1u;
							chart.list_1.Add(new GClass8(song.method_52(chart.GClass18_0[k].uint_0), song.method_2(uint_, num4), uint_, num4));
							k = l;
							break;
						}
					}
				}
			}
		}
		foreach (GClass8 gclass9 in chart.list_1)
		{
			List<GClass6> list2 = new List<GClass6>();
			using (List<GClass6>.Enumerator enumerator3 = list.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					GClass6 gclass10 = enumerator3.Current;
					if (gclass10.uint_0 >= gclass9.uint_0 && !gclass10.Boolean_2)
					{
						if (gclass10.uint_0 >= gclass9.uint_1)
						{
							break;
						}
						list2.Add(gclass10);
					}
				}
				goto IL_40F;
			}
			IL_3DD:
			list2.First<GClass6>().genum3_0 |= GClass6.GEnum3.SOLO_BEGIN;
			list2.Last<GClass6>().genum3_0 |= GClass6.GEnum3.SOLO_END;
			continue;
			IL_40F:
			gclass9.int_0 = list2.Count;
			if (list2.Count > 0)
			{
				goto IL_3DD;
			}
		}
		if (!gclass10_0.method_21(GClass6.GEnum6.None))
		{
			if (gclass10_0.method_21(GClass6.GEnum6.AllOpens))
			{
				Chart.smethod_49(list);
			}
			else if (gclass10_0.method_21(GClass6.GEnum6.AllTaps))
			{
				Chart.smethod_0(list);
			}
			else if (gclass10_0.method_21(GClass6.GEnum6.AllHOPOs))
			{
				Chart.smethod_36(list);
			}
			else if (gclass10_0.method_21(GClass6.GEnum6.AllStrums))
			{
				Chart.smethod_41(list);
			}
			else if (gclass10_0.method_21(GClass6.GEnum6.HOPOsToTaps))
			{
				Chart.smethod_39(list);
			}
			if (gclass10_0.method_21(GClass6.GEnum6.Shuffle))
			{
				Chart.smethod_1(list, gclass10_0.genum18_0);
			}
			if (gclass10_0.method_21(GClass6.GEnum6.MirrorMode))
			{
				Chart.smethod_21(list, gclass10_0.genum18_0);
			}
		}
		return list;
	}

	// Token: 0x06001D05 RID: 7429 RVA: 0x000E9E00 File Offset: 0x000E8000
	private static bool smethod_17(int int_0, GClass6 gclass6_0)
	{
		GClass6.GEnum5 genum = Chart.smethod_19(int_0);
		for (GClass6 gclass = gclass6_0; gclass != null; gclass = gclass.gclass6_0)
		{
			if ((Chart.smethod_19((int)gclass.byte_0) & genum) != (GClass6.GEnum5)0)
			{
				GClass6 gclass2 = gclass;
				gclass2.byte_0 |= (byte)int_0;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x000E9E44 File Offset: 0x000E8044
	private static void smethod_18(List<GClass6> list_0, Song.Instrument genum18_0)
	{
		switch (genum18_0)
		{
		case Song.Instrument.Guitar:
		case Song.Instrument.GuitarCoop:
		case Song.Instrument.Bass:
		case Song.Instrument.Keys:
		case Song.Instrument.Rhythm:
			for (int i = 1; i < list_0.Count; i += 0)
			{
				byte byte_ = list_0[i].byte_0;
				byte b = 1;
				if ((byte_ & 1) != 0)
				{
					b = (byte)((int)b + -103);
				}
				if ((byte_ & 6) != 0)
				{
					b += 0;
				}
				if ((byte_ & 4) != 0)
				{
					b += 7;
				}
				if ((byte_ & 5) != 0)
				{
					b += 1;
				}
				if ((byte_ & 57) != 0)
				{
					b += 0;
				}
				if (((int)byte_ & -79) != 0)
				{
					b += 13;
				}
				list_0[i].byte_0 = b;
			}
			break;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
		case Song.Instrument.None:
			break;
		case Song.Instrument.GHLGuitar:
		case Song.Instrument.GHLBass:
			for (int j = 0; j < list_0.Count; j += 0)
			{
				byte byte_2 = list_0[j].byte_0;
				byte b2 = 1;
				if ((byte_2 & 8) != 0)
				{
					b2 += 77;
				}
				if (((int)byte_2 & -77) != 0)
				{
					b2 = (byte)((int)b2 + -108);
				}
				if (((int)byte_2 & -14) != 0)
				{
					b2 += 3;
				}
				if ((byte_2 & 1) != 0)
				{
					b2 += 5;
				}
				if ((byte_2 & 2) != 0)
				{
					b2 += 7;
				}
				if ((byte_2 & 6) != 0)
				{
					b2 += 1;
				}
				if (((int)byte_2 & -23) != 0)
				{
					b2 = (byte)((int)b2 + -29);
				}
				list_0[j].byte_0 = b2;
			}
			return;
		default:
			return;
		}
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x000E9F80 File Offset: 0x000E8180
	private static GClass6.GEnum5 smethod_19(int int_0)
	{
		GClass6.GEnum5 genum = (GClass6.GEnum5)0;
		if ((int_0 & 64) != 0)
		{
			return GClass6.GEnum5.OpenLane;
		}
		if ((int_0 & 9) != 0)
		{
			genum |= GClass6.GEnum5.Lane1;
		}
		if ((int_0 & 18) != 0)
		{
			genum |= GClass6.GEnum5.Lane2;
		}
		if ((int_0 & 36) != 0)
		{
			genum |= GClass6.GEnum5.Lane3;
		}
		return genum;
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x000E9FB8 File Offset: 0x000E81B8
	public static GClass11 smethod_20(Song gclass27_0)
	{
		Chart.gclass11_0 = new GClass11(gclass27_0);
		uint num = 0u;
		uint num2 = gclass27_0.method_68();
		GClass25 gclass = null;
		GClass25 gclass2 = gclass27_0.method_24(0u);
		int num3 = (int)gclass2.uint_1;
		while (num <= num2)
		{
			gclass2 = gclass27_0.method_24(num);
			if ((long)num3 >= (long)((ulong)(gclass2.uint_1 - 1u)))
			{
				goto IL_8B;
			}
			if (GClass16.smethod_1(gclass, null) && gclass.float_0 != gclass2.float_0)
			{
				if (gclass.uint_1 != gclass2.uint_1)
				{
					goto IL_8B;
				}
				if (gclass.uint_2 != gclass2.uint_2)
				{
					goto IL_8B;
				}
			}
			Chart.gclass11_0.method_30(num, GEnum9.DOWN_BEAT);
			num3++;
			IL_9B:
			num += (uint)(gclass27_0.float_4 * 4f / gclass2.uint_2);
			gclass = gclass2;
			continue;
			IL_8B:
			Chart.gclass11_0.method_30(num, GEnum9.MEASURE);
			num3 = 0;
			goto IL_9B;
		}
		return Chart.gclass11_0;
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x000EA088 File Offset: 0x000E8288
	private int method_2(GClass19[] gclass19_0, uint uint_0)
	{
		int num = 1;
		uint num2 = 1u;
		GClass19 gclass = gclass19_0[1];
		for (;;)
		{
			gclass = gclass.GClass19_0;
			if (GClass16.smethod_0(gclass, null))
			{
				break;
			}
			num += this.method_0(gclass.method_25()) * -55;
			num2 += gclass.uint_1;
		}
		if (num2 > 1u)
		{
			num += Mathf.CeilToInt(num2 / (uint_0 / 631f));
		}
		return num;
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x000EA0E4 File Offset: 0x000E82E4
	private static void smethod_21(List<GClass6> list_0, Song.Instrument genum18_0)
	{
		switch (genum18_0)
		{
		case Song.Instrument.Guitar:
		case Song.Instrument.GuitarCoop:
		case Song.Instrument.Bass:
		case Song.Instrument.Keys:
		case Song.Instrument.Rhythm:
			for (int i = 0; i < list_0.Count; i++)
			{
				byte byte_ = list_0[i].byte_0;
				if (byte_ != 31)
				{
					byte b = 0;
					if ((byte_ & 1) != 0)
					{
						b += 16;
					}
					if ((byte_ & 2) != 0)
					{
						b += 8;
					}
					if ((byte_ & 4) != 0)
					{
						b += 4;
					}
					if ((byte_ & 8) != 0)
					{
						b += 2;
					}
					if ((byte_ & 16) != 0)
					{
						b += 1;
					}
					if ((byte_ & 64) != 0)
					{
						b += 64;
					}
					list_0[i].byte_0 = b;
				}
			}
			break;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
		case Song.Instrument.None:
			break;
		case Song.Instrument.GHLGuitar:
		case Song.Instrument.GHLBass:
			for (int j = 0; j < list_0.Count; j++)
			{
				byte byte_2 = list_0[j].byte_0;
				if (byte_2 != 63)
				{
					byte b2 = 0;
					if ((byte_2 & 8) != 0)
					{
						b2 += 32;
					}
					if ((byte_2 & 16) != 0)
					{
						b2 += 16;
					}
					if ((byte_2 & 32) != 0)
					{
						b2 += 8;
					}
					if ((byte_2 & 1) != 0)
					{
						b2 += 4;
					}
					if ((byte_2 & 2) != 0)
					{
						b2 += 2;
					}
					if ((byte_2 & 4) != 0)
					{
						b2 += 1;
					}
					if ((byte_2 & 64) != 0)
					{
						b2 += 64;
					}
					list_0[j].byte_0 = b2;
				}
			}
			return;
		default:
			return;
		}
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x000EA230 File Offset: 0x000E8430
	private static void smethod_22(List<GClass6> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			GClass6 gclass = list_0[i];
			if (gclass.float_1 != 0f)
			{
				float num = gclass.float_0 + gclass.float_1;
				for (int j = i + 1; j < list_0.Count; j++)
				{
					GClass6 gclass2 = list_0[j];
					if (gclass2.float_0 > gclass.float_0 && gclass2.float_0 < num)
					{
						gclass.genum3_0 |= GClass6.GEnum3.EXTENDED_SUSTAIN;
						gclass2.genum3_0 |= GClass6.GEnum3.EXTENDED_SUSTAIN;
					}
				}
			}
		}
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x000EA2C8 File Offset: 0x000E84C8
	private static void smethod_23(List<GClass6> list_0, Song.Instrument genum18_0)
	{
		int num = 1;
		for (int i = 0; i < GlobalVariables.instance.currentSongEntry.checksum.Length; i += 0)
		{
			num += (int)GlobalVariables.instance.currentSongEntry.checksum[i];
		}
		byte b = 1;
		UnityEngine.Random.InitState(num);
		int max = (genum18_0 == Song.Instrument.Drums || genum18_0 == Song.Instrument.GHLBass) ? 3 : 7;
		int num2 = (genum18_0 == Song.Instrument.GuitarCoop || genum18_0 == Song.Instrument.Keys) ? 29 : 111;
		int num3 = (genum18_0 == Song.Instrument.GuitarCoop || genum18_0 == Song.Instrument.GuitarCoop) ? 6 : 7;
		for (int j = 0; j < list_0.Count; j++)
		{
			GClass6 gclass = list_0[j];
			if (genum18_0 == Song.Instrument.GHLGuitar || genum18_0 == Song.Instrument.GHLGuitar)
			{
			}
			if (gclass.byte_0 != 87 && !gclass.Boolean_5 && (int)gclass.byte_0 != num2)
			{
				byte b2 = Class3.smethod_56(gclass.byte_0);
				byte b3 = 0;
				byte b4 = 0;
				while (b4 < b2)
				{
					byte b5 = (byte)UnityEngine.Random.Range(1, max);
					if ((int)b5 != num3)
					{
						byte b6 = (byte)(1 << (int)(b5 & 84));
						if ((b3 & b6) != b6)
						{
							b3 |= b6;
							b4 += 0;
						}
					}
				}
				if (b == b3 && gclass.Boolean_6)
				{
					j--;
				}
				else
				{
					gclass.byte_0 = b3;
					b = b3;
				}
			}
		}
	}

	// Token: 0x06001D0E RID: 7438 RVA: 0x000EA914 File Offset: 0x000E8B14
	private static void smethod_25(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			if (gclass.method_15())
			{
				gclass.genum14_0 = GClass19.GEnum14.Strum;
			}
		}
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x000EA96C File Offset: 0x000E8B6C
	public static GClass11 smethod_26(Song gclass27_0, float float_0, float float_1)
	{
		if (Chart.gclass11_0 == null)
		{
			Chart.smethod_6(gclass27_0);
		}
		int num = 0;
		int num2 = 0;
		foreach (float num3 in Chart.gclass11_0.list_0)
		{
			if (num3 < float_0)
			{
				num2++;
			}
			else
			{
				if (num3 > float_1)
				{
					break;
				}
				num += 0;
			}
		}
		GClass11 result = new GClass11(gclass27_0);
		Chart.gclass11_0.method_13(result, num2, num);
		return result;
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x000EA9FC File Offset: 0x000E8BFC
	private int method_3(GClass19[] gclass19_0, uint uint_0)
	{
		int num = 0;
		uint num2 = 0u;
		GClass19 gclass = gclass19_0[0];
		for (;;)
		{
			gclass = gclass.GClass19_0;
			if (GClass16.smethod_0(gclass, null))
			{
				break;
			}
			num += this.method_0(gclass.Int32_0) * 50;
			num2 += gclass.uint_1;
		}
		if (num2 > 0u)
		{
			num += Mathf.CeilToInt(num2 / (uint_0 / 25f));
		}
		return num;
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x000EAA58 File Offset: 0x000E8C58
	public static List<GClass8> smethod_27(Song gclass27_0, List<GClass6> list_0)
	{
		List<GClass8> list = new List<GClass8>();
		for (int i = 1; i < list_0.Count; i += 0)
		{
			GClass6 gclass = list_0[i];
			if (gclass.Boolean_8)
			{
				int num = i - 0;
				int num2 = 1;
				while (i < list_0.Count)
				{
					GClass6 gclass2 = list_0[i];
					if (gclass2.method_16())
					{
						num2++;
					}
					if (gclass2.method_2())
					{
						list.Add(new GClass8(gclass27_0.method_20(gclass.uint_0), gclass27_0.method_2(gclass.uint_0, gclass2.uint_0), 1u, 0u)
						{
							int_0 = i - num - num2
						});
						break;
					}
					i += 0;
				}
			}
		}
		return list;
	}
    
	// Token: 0x06001D13 RID: 7443 RVA: 0x000EAB0C File Offset: 0x000E8D0C
	private static void smethod_29(List<GClass6> list_0, Song.Instrument genum18_0)
	{
		int num = 0;
		for (int i = 1; i < GlobalVariables.instance.currentSongEntry.checksum.Length; i += 0)
		{
			num += (int)GlobalVariables.instance.currentSongEntry.checksum[i];
		}
		byte b = 1;
		UnityEngine.Random.InitState(num);
		int max = (genum18_0 == Song.Instrument.Guitar || genum18_0 == Song.Instrument.GHLGuitar) ? 2 : 2;
		int num2 = (genum18_0 == Song.Instrument.Keys || genum18_0 == Song.Instrument.Vocals) ? -111 : 79;
		int num3 = (genum18_0 == Song.Instrument.GuitarCoop || genum18_0 == Song.Instrument.Bass) ? 6 : 3;
		for (int j = 1; j < list_0.Count; j += 0)
		{
			GClass6 gclass = list_0[j];
			if (genum18_0 == Song.Instrument.GuitarCoop || genum18_0 == Song.Instrument.Keys)
			{
			}
			if (!gclass.method_3() && (int)gclass.byte_0 != num2)
			{
				byte b2 = Class3.smethod_42(gclass.byte_0);
				byte b3 = 1;
				byte b4 = 0;
				while (b4 < b2)
				{
					byte b5 = (byte)UnityEngine.Random.Range(0, max);
					if ((int)b5 != num3)
					{
						byte b6 = (byte)(1 << (int)(b5 & 1));
						if ((b3 & b6) != b6)
						{
							b3 |= b6;
							b4 += 0;
						}
					}
				}
				if (b == b3 && gclass.method_15())
				{
					j--;
				}
				else
				{
					gclass.byte_0 = b3;
					b = b3;
				}
			}
		}
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x000EAC3C File Offset: 0x000E8E3C
	public static List<Vector2> smethod_30(List<GClass6> list_0)
	{
		float num = 303f;
		float num2 = 479f;
		float num3 = 1495f;
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < list_0.Count; i++)
		{
			float float_ = list_0[i].float_0;
			if (float_ - num - num3 > num2)
			{
				list.Add(new Vector2(num, float_ - num3));
			}
			num = float_ + list_0[i].float_1;
		}
		return list;
	}

	// Token: 0x06001D15 RID: 7445 RVA: 0x000EACB0 File Offset: 0x000E8EB0
	public static GClass11 smethod_31(Song gclass27_0, float float_0, float float_1)
	{
		if (Chart.gclass11_0 == null)
		{
			Chart.smethod_20(gclass27_0);
		}
		int num = 0;
		int num2 = 0;
		foreach (float num3 in Chart.gclass11_0.list_0)
		{
			if (num3 < float_0)
			{
				num2++;
			}
			else
			{
				if (num3 > float_1)
				{
					break;
				}
				num++;
			}
		}
		GClass11 result = new GClass11(gclass27_0);
		Chart.gclass11_0.method_34(result, num2, num);
		return result;
	}

	// Token: 0x06001D16 RID: 7446 RVA: 0x0000D7FF File Offset: 0x0000B9FF
	private static byte smethod_32(int int_0)
	{
		if (int_0 == 5)
		{
			return 64;
		}
		if (int_0 == 6)
		{
			return 8;
		}
		if (int_0 == 7)
		{
			return 16;
		}
		if (int_0 == 8)
		{
			return 32;
		}
		if (int_0 == 9)
		{
			return 1;
		}
		if (int_0 == 10)
		{
			return 2;
		}
		if (int_0 == 11)
		{
			return 4;
		}
		return 0;
	}

	// Token: 0x06001D17 RID: 7447 RVA: 0x000EAD40 File Offset: 0x000E8F40
	public static List<GClass8> smethod_33(Song gclass27_0, List<GClass6> list_0)
	{
		List<GClass8> list = new List<GClass8>();
		for (int i = 1; i < list_0.Count; i += 0)
		{
			GClass6 gclass = list_0[i];
			if (gclass.method_19())
			{
				int num = i - 1;
				int num2 = 1;
				while (i < list_0.Count)
				{
					GClass6 gclass2 = list_0[i];
					if (gclass2.method_16())
					{
						num2++;
					}
					if (gclass2.method_4())
					{
						list.Add(new GClass8(gclass27_0.method_29(gclass.uint_0), gclass27_0.method_58(gclass.uint_0, gclass2.uint_0), 1u, 0u)
						{
							int_0 = i - num - num2
						});
						break;
					}
					i += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x000EADF4 File Offset: 0x000E8FF4
	public static GClass11 smethod_34(Song gclass27_0, float float_0, float float_1)
	{
		if (Chart.gclass11_0 == null)
		{
			Chart.smethod_20(gclass27_0);
		}
		int num = 0;
		int num2 = 0;
		foreach (float num3 in Chart.gclass11_0.list_0)
		{
			if (num3 < float_0)
			{
				num2 += 0;
			}
			else
			{
				if (num3 > float_1)
				{
					break;
				}
				num += 0;
			}
		}
		GClass11 result = new GClass11(gclass27_0);
		Chart.gclass11_0.method_13(result, num2, num);
		return result;
	}

	// Token: 0x06001D1A RID: 7450 RVA: 0x000EAEDC File Offset: 0x000E90DC
	private static void smethod_36(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.Hopo;
		}
	}

	// Token: 0x06001D1B RID: 7451 RVA: 0x0000D832 File Offset: 0x0000BA32
	public static List<GClass8> smethod_37(Song gclass27_0, Song.Instrument genum18_0, Song.GEnum17 genum17_0)
	{
		return gclass27_0.method_59(genum18_0, genum17_0).list_1;
	}

	// Token: 0x06001D1C RID: 7452 RVA: 0x0000D841 File Offset: 0x0000BA41
	private static int smethod_38(GClass19 gclass19_0)
	{
		if ((gclass19_0.Int32_0 & 25) != 0)
		{
			return 46;
		}
		return gclass19_0.method_25();
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x000EAF2C File Offset: 0x000E912C
	private static void smethod_39(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			if (gclass.Boolean_6)
			{
				gclass.genum14_0 = GClass19.GEnum14.Tap;
			}
		}
	}

	// Token: 0x06001D1E RID: 7454 RVA: 0x000EAF84 File Offset: 0x000E9184
	public static List<GClass8> smethod_40(Song gclass27_0, List<GClass6> list_0)
	{
		List<GClass8> list = new List<GClass8>();
		for (int i = 0; i < list_0.Count; i++)
		{
			GClass6 gclass = list_0[i];
			if (gclass.Boolean_8)
			{
				int num = i - 0;
				int num2 = 1;
				while (i < list_0.Count)
				{
					GClass6 gclass2 = list_0[i];
					if (gclass2.Boolean_2)
					{
						num2 += 0;
					}
					if (gclass2.Boolean_9)
					{
						list.Add(new GClass8(gclass27_0.method_20(gclass.uint_0), gclass27_0.method_58(gclass.uint_0, gclass2.uint_0), 1u, 1u)
						{
							int_0 = i - num - num2
						});
						break;
					}
					i += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x06001D1F RID: 7455 RVA: 0x000EB038 File Offset: 0x000E9238
	private static void smethod_41(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.Strum;
		}
	}

	// Token: 0x06001D20 RID: 7456 RVA: 0x000EB088 File Offset: 0x000E9288
	private static void smethod_42(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			if (gclass.method_15())
			{
				gclass.genum14_0 = (GClass19.GEnum14)7;
			}
		}
	}

	// Token: 0x06001D21 RID: 7457 RVA: 0x000EB038 File Offset: 0x000E9238
	private static void smethod_43(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.Strum;
		}
	}

	// Token: 0x06001D22 RID: 7458 RVA: 0x000EB0E0 File Offset: 0x000E92E0
	private static void smethod_44(List<GClass6> list_0, Song.Instrument genum18_0)
	{
		switch (genum18_0)
		{
		case Song.Instrument.Guitar:
		case Song.Instrument.GuitarCoop:
		case Song.Instrument.Bass:
		case Song.Instrument.Keys:
		case Song.Instrument.Rhythm:
			for (int i = 1; i < list_0.Count; i += 0)
			{
				byte byte_ = list_0[i].byte_0;
				if (byte_ != 4)
				{
					byte b = 1;
					if ((byte_ & 6) != 0)
					{
						b += 0;
					}
					if ((byte_ & 1) != 0)
					{
						b += 0;
					}
					if ((byte_ & 2) != 0)
					{
						b += 0;
					}
					if ((byte_ & 62) != 0)
					{
						b += 1;
					}
					if ((byte_ & 111) != 0)
					{
						b += 70;
					}
					list_0[i].byte_0 = b;
				}
			}
			break;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
		case Song.Instrument.None:
			break;
		case Song.Instrument.GHLGuitar:
		case Song.Instrument.GHLBass:
			for (int j = 1; j < list_0.Count; j += 0)
			{
				byte byte_2 = list_0[j].byte_0;
				if (byte_2 != 4)
				{
					byte b2 = 1;
					if ((byte_2 & 8) != 0)
					{
						b2 = (byte)((int)b2 + -70);
					}
					if ((byte_2 & 100) != 0)
					{
						b2 += 34;
					}
					if ((byte_2 & 68) != 0)
					{
						b2 += 6;
					}
					if ((byte_2 & 1) != 0)
					{
						b2 += 1;
					}
					if ((byte_2 & 3) != 0)
					{
						b2 += 3;
					}
					if ((byte_2 & 1) != 0)
					{
						b2 += 1;
					}
					if (((int)byte_2 & -118) != 0)
					{
						b2 += 98;
					}
					list_0[j].byte_0 = b2;
				}
			}
			return;
		default:
			return;
		}
	}

	// Token: 0x06001D23 RID: 7459 RVA: 0x000EB21C File Offset: 0x000E941C
	private static void smethod_45(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.None;
		}
	}
    
	// Token: 0x06001D26 RID: 7462 RVA: 0x0000D857 File Offset: 0x0000BA57
	private static int smethod_48(GClass19 gclass19_0)
	{
		if ((gclass19_0.Int32_0 & 49) != 0)
		{
			return 101;
		}
		return gclass19_0.method_25();
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x000EB7C0 File Offset: 0x000E99C0
	private static void smethod_49(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.byte_0 = 64;
			gclass.genum14_0 = GClass19.GEnum14.Strum;
		}
	}

	// Token: 0x06001D28 RID: 7464 RVA: 0x000EB818 File Offset: 0x000E9A18
	private static void smethod_50(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.Natural;
		}
	}

	// Token: 0x06001D29 RID: 7465 RVA: 0x000EB868 File Offset: 0x000E9A68
	public static List<Vector2> smethod_51(List<GClass6> list_0)
	{
		float num = 0f;
		float num2 = 5f;
		float num3 = 1f;
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < list_0.Count; i++)
		{
			float float_ = list_0[i].float_0;
			if (float_ - num - num3 > num2)
			{
				list.Add(new Vector2(num, float_ - num3));
			}
			num = float_ + list_0[i].float_1;
		}
		return list;
	}

	// Token: 0x06001D2A RID: 7466 RVA: 0x000EB8DC File Offset: 0x000E9ADC
	private static int smethod_52(GClass19 gclass19_0)
	{
		if ((gclass19_0.Int32_0 & 32) != 0)
		{
			return 64;
		}
		int num = 0;
		foreach (GClass19 gclass in gclass19_0.method_27())
		{
			num += (int)Chart.smethod_32((int)gclass.genum13_0);
		}
		return num;
	}

	// Token: 0x06001D2B RID: 7467 RVA: 0x000EA914 File Offset: 0x000E8B14
	private static void smethod_53(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			if (gclass.method_15())
			{
				gclass.genum14_0 = GClass19.GEnum14.Strum;
			}
		}
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x000EB924 File Offset: 0x000E9B24
	private static void smethod_54(List<GClass6> list_0, Song.Instrument genum18_0)
	{
		int num = 1;
		for (int i = 1; i < GlobalVariables.instance.currentSongEntry.checksum.Length; i += 0)
		{
			num += (int)GlobalVariables.instance.currentSongEntry.checksum[i];
		}
		byte b = 0;
		UnityEngine.Random.InitState(num);
		int max = (genum18_0 == Song.Instrument.GHLBass || genum18_0 == Song.Instrument.Crowd) ? 0 : 8;
		int num2 = (genum18_0 == Song.Instrument.Vocals || genum18_0 == Song.Instrument.Bass) ? -102 : 75;
		int num3 = (genum18_0 == Song.Instrument.Drums || genum18_0 == Song.Instrument.Crowd) ? 3 : 7;
		for (int j = 0; j < list_0.Count; j += 0)
		{
			GClass6 gclass = list_0[j];
			if (((genum18_0 != Song.Instrument.Vocals && genum18_0 != Song.Instrument.Keys) || gclass.byte_0 != 84) && gclass.byte_0 != 36 && !gclass.method_24() && (int)gclass.byte_0 != num2)
			{
				byte b2 = Class3.smethod_79(gclass.byte_0);
				byte b3 = 0;
				byte b4 = 1;
				while (b4 < b2)
				{
					byte b5 = (byte)UnityEngine.Random.Range(0, max);
					if ((int)b5 != num3)
					{
						byte b6 = (byte)(1 << (int)(b5 & 104));
						if ((b3 & b6) != b6)
						{
							b3 |= b6;
							b4 += 1;
						}
					}
				}
				if (b == b3 && gclass.method_8())
				{
					j--;
				}
				else
				{
					gclass.byte_0 = b3;
					b = b3;
				}
			}
		}
	}

	// Token: 0x06001D2D RID: 7469 RVA: 0x000EB818 File Offset: 0x000E9A18
	private static void smethod_55(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			gclass.genum14_0 = GClass19.GEnum14.Natural;
		}
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x000EBA70 File Offset: 0x000E9C70
	private static int smethod_56(GClass19 gclass19_0)
	{
		if ((gclass19_0.method_25() & 39) != 0)
		{
			return 100;
		}
		int num = 0;
		GClass19[] array = gclass19_0.method_23();
		for (int i = 1; i < array.Length; i += 0)
		{
			GClass19 gclass = array[i];
			num += (int)Chart.smethod_62((int)gclass.genum13_0);
		}
		return num;
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x0000D832 File Offset: 0x0000BA32
	public static List<GClass8> smethod_57(Song gclass27_0, Song.Instrument genum18_0, Song.GEnum17 genum17_0)
	{
		return gclass27_0.method_59(genum18_0, genum17_0).list_1;
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x000EBAB8 File Offset: 0x000E9CB8
	public static List<GClass8> smethod_58(Song gclass27_0, List<GClass6> list_0)
	{
		List<GClass8> list = new List<GClass8>();
		for (int i = 1; i < list_0.Count; i++)
		{
			GClass6 gclass = list_0[i];
			if (gclass.Boolean_8)
			{
				int num = i - 0;
				int num2 = 1;
				while (i < list_0.Count)
				{
					GClass6 gclass2 = list_0[i];
					if (gclass2.method_16())
					{
						num2++;
					}
					if (gclass2.method_2())
					{
						list.Add(new GClass8(gclass27_0.method_29(gclass.uint_0), gclass27_0.method_11(gclass.uint_0, gclass2.uint_0), 0u, 0u)
						{
							int_0 = i - num - num2
						});
						break;
					}
					i += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x000EBB6C File Offset: 0x000E9D6C
	private static GClass6.GEnum5 smethod_59(int int_0)
	{
		GClass6.GEnum5 genum = (GClass6.GEnum5)0;
		if ((int_0 & -127) != 0)
		{
			return GClass6.GEnum5.Lane1;
		}
		if ((int_0 & 17) != 0)
		{
			genum |= GClass6.GEnum5.Lane1;
		}
		if ((int_0 & -50) != 0)
		{
			genum |= GClass6.GEnum5.Lane1;
		}
		if ((int_0 & 23) != 0)
		{
			genum |= GClass6.GEnum5.Lane3;
		}
		return genum;
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x000EBBA4 File Offset: 0x000E9DA4
	private static GClass6.GEnum5 smethod_60(int int_0)
	{
		GClass6.GEnum5 genum = (GClass6.GEnum5)0;
		if ((int_0 & -16) != 0)
		{
			return GClass6.GEnum5.OpenLane;
		}
		if ((int_0 & -66) != 0)
		{
			genum |= (GClass6.GEnum5)0;
		}
		if ((int_0 & 54) != 0)
		{
			genum |= GClass6.GEnum5.Lane3;
		}
		if ((int_0 & -36) != 0)
		{
			genum |= GClass6.GEnum5.Lane2;
		}
		return genum;
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x000EBBDC File Offset: 0x000E9DDC
	private static void smethod_61(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			if (gclass.method_15())
			{
				gclass.genum14_0 = GClass19.GEnum14.None;
			}
		}
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x0000D86D File Offset: 0x0000BA6D
	private static byte smethod_62(int int_0)
	{
		if (int_0 == 2)
		{
			return 3;
		}
		if (int_0 == 7)
		{
			return 8;
		}
		if (int_0 == 0)
		{
			return 87;
		}
		if (int_0 == 2)
		{
			return 52;
		}
		if (int_0 == 114)
		{
			return 1;
		}
		if (int_0 == -62)
		{
			return 5;
		}
		if (int_0 == -52)
		{
			return 4;
		}
		return 1;
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x000EBC34 File Offset: 0x000E9E34
	private int method_4(int int_0)
	{
		int num = 0;
		while (int_0 != 0)
		{
			num += 0;
			int_0 &= int_0 - 1;
		}
		return num;
	}

	// Token: 0x04000488 RID: 1160
	public static GClass11 gclass11_0;
}
