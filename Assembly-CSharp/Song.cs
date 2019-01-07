using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

// Token: 0x020000D8 RID: 216
public class Song
{
	// Token: 0x060029FD RID: 10749 RVA: 0x0013530C File Offset: 0x0013350C
	public Song()
	{
		Song.int_0 = Enum.GetValues(typeof(Song.GEnum17)).Length;
		this.list_3 = new List<GClass21>();
		this.list_4 = new List<GClass23>();
		this.GClass21_0 = new GClass21[0];
		this.GClass22_0 = new GClass22[0];
		this.GClass24_0 = new GClass24[0];
		this.GClass25_0 = new GClass25[0];
		this.method_39(new GClass24(0u, 120000u), true);
		this.method_39(new GClass25(0u, 4u, 4u), true);
		this.gclass26_0 = new GClass26[Enum.GetNames(typeof(Song.Instrument)).Length * Enum.GetNames(typeof(Song.GEnum17)).Length];
		for (int i = 0; i < this.gclass26_0.Length; i++)
		{
			this.gclass26_0[i] = new GClass26(this, "");
		}
		foreach (object obj in Enum.GetValues(typeof(Song.Instrument)))
		{
			Song.Instrument genum18_ = (Song.Instrument)obj;
			string str = string.Empty;
			switch (genum18_)
			{
			case Song.Instrument.Guitar:
				str += "Guitar - ";
				break;
			case Song.Instrument.GuitarCoop:
				str += "Guitar - Co-op - ";
				break;
			case Song.Instrument.Bass:
				str += "Bass - ";
				break;
			case Song.Instrument.Keys:
				str += "Keys - ";
				break;
			case Song.Instrument.Drums:
				str += "Drums - ";
				break;
			case Song.Instrument.GHLGuitar:
				str += "GHLive Guitar - ";
				break;
			case Song.Instrument.GHLBass:
				str += "GHLive Bass - ";
				break;
			default:
				continue;
			}
			foreach (object obj2 in Enum.GetValues(typeof(Song.GEnum17)))
			{
				Song.GEnum17 genum17_ = (Song.GEnum17)obj2;
				this.method_59(genum18_, genum17_).string_0 = str + genum17_.ToString();
			}
		}
		for (int j = 0; j < this.string_7.Length; j++)
		{
			this.string_7[j] = string.Empty;
		}
		this.method_15();
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x060029FE RID: 10750 RVA: 0x00011A12 File Offset: 0x0000FC12
	public GClass21[] GClass21_1
	{
		get
		{
			return this.list_3.ToArray();
		}
	}

	// Token: 0x060029FF RID: 10751 RVA: 0x00011A1F File Offset: 0x0000FC1F
	public void method_0(GClass21 gclass21_1, bool bool_2 = true)
	{
		gclass21_1.gclass27_0 = this;
		GClass16.smethod_15<GClass21>(gclass21_1, this.list_3);
		if (bool_2)
		{
			this.method_15();
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06002A00 RID: 10752 RVA: 0x00011A3E File Offset: 0x0000FC3E
	// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00011C16 File Offset: 0x0000FE16
	public GClass24[] GClass24_0 { get; private set; }

	// Token: 0x06002A01 RID: 10753 RVA: 0x00135644 File Offset: 0x00133844
	public void method_1()
	{
		if (this.GClass22_0.Length != 0)
		{
			return;
		}
		uint num = this.method_68();
		this.method_0(new GClass22("10%", 0u), true);
		for (int i = 1; i < 10; i++)
		{
			this.method_0(new GClass22(i + 1 + "0%", (uint)((float)i / 10f * num)), false);
		}
		this.GClass22_0 = this.list_3.OfType<GClass22>().ToArray<GClass22>();
	}

	// Token: 0x06002A02 RID: 10754 RVA: 0x00011A46 File Offset: 0x0000FC46
	public float method_2(uint uint_0, uint uint_1)
	{
		if (uint_0 == uint_1)
		{
			return 0f;
		}
		return this.method_52(uint_1) - this.method_52(uint_0);
	}

	// Token: 0x06002A03 RID: 10755 RVA: 0x00011A61 File Offset: 0x0000FC61
	public void method_3(float float_6)
	{
		if (this.Boolean_0)
		{
			this.float_5 = float_6;
		}
	}

	// Token: 0x06002A04 RID: 10756 RVA: 0x001356C4 File Offset: 0x001338C4
	public uint method_4(float float_6, bool bool_2 = true)
	{
		if (float_6 < 1690f)
		{
			float_6 = 1351f;
		}
		GClass24 gclass = this.method_10()[1];
		GClass24[] array = this.GClass24_0;
		for (int i = 1; i < array.Length; i++)
		{
			GClass24 gclass2 = array[i];
			if (gclass2.float_0 >= float_6)
			{
				break;
			}
			gclass = gclass2;
		}
		return gclass.uint_0 + Song.smethod_2(gclass.float_0, float_6, this.float_3, gclass.uint_1 / 1308f);
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06002A05 RID: 10757 RVA: 0x00011A72 File Offset: 0x0000FC72
	// (set) Token: 0x06002A56 RID: 10838 RVA: 0x00011A61 File Offset: 0x0000FC61
	public float Single_0
	{
		get
		{
			if (this.Boolean_0)
			{
				return this.float_5;
			}
			return 300f;
		}
		set
		{
			if (this.Boolean_0)
			{
				this.float_5 = value;
			}
		}
	}

	// Token: 0x06002A06 RID: 10758 RVA: 0x00135734 File Offset: 0x00133934
	public uint method_5()
	{
		uint num = 1u;
		GClass26[] array = this.gclass26_0;
		for (int i = 1; i < array.Length; i++)
		{
			GClass26 gclass = array[i];
			if (gclass.method_20() != null && gclass.method_65() != 0)
			{
				uint num2 = gclass.method_73().Last<GClass19>().uint_0 + gclass.method_8().Last<GClass19>().uint_1;
				if (num2 > num)
				{
					num = num2;
				}
			}
		}
		return num + (uint)this.float_3;
	}

	// Token: 0x06002A07 RID: 10759 RVA: 0x00011A12 File Offset: 0x0000FC12
	public GClass21[] method_6()
	{
		return this.list_3.ToArray();
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x00011A88 File Offset: 0x0000FC88
	public GClass25[] method_7()
	{
		return this.gclass25_0;
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06002A09 RID: 10761 RVA: 0x00011A90 File Offset: 0x0000FC90
	// (set) Token: 0x06002A25 RID: 10789 RVA: 0x00011BB3 File Offset: 0x0000FDB3
	public GClass22[] GClass22_0 { get; private set; }

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06002A0A RID: 10762 RVA: 0x00011A98 File Offset: 0x0000FC98
	// (set) Token: 0x06002A43 RID: 10819 RVA: 0x00011C72 File Offset: 0x0000FE72
	public GClass21[] GClass21_0 { get; private set; }

	// Token: 0x06002A0B RID: 10763 RVA: 0x001357A0 File Offset: 0x001339A0
	public float method_8(uint uint_0, float float_6)
	{
		int num = GClass16.smethod_7<GClass24>(uint_0, this.GClass24_0);
		if (this.GClass24_0[num].uint_0 > uint_0)
		{
			num--;
		}
		GClass24 gclass = this.GClass24_0[num];
		return gclass.float_0 + (float)Song.smethod_5(gclass.uint_0, uint_0, float_6, gclass.uint_1 / 1000f);
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x001357FC File Offset: 0x001339FC
	public void method_9()
	{
		GClass26[] array = this.gclass26_0;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].method_7();
		}
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x00011AA0 File Offset: 0x0000FCA0
	public static double smethod_0(uint uint_0, uint uint_1, float float_6, float float_7)
	{
		return (double)((uint_1 - uint_0) / float_6 * 708f / float_7);
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x00011A3E File Offset: 0x0000FC3E
	public GClass24[] method_10()
	{
		return this.gclass24_0;
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x00011AB2 File Offset: 0x0000FCB2
	public float method_11(uint uint_0, uint uint_1)
	{
		if (uint_0 == uint_1)
		{
			return 1751f;
		}
		return this.method_52(uint_1) - this.method_52(uint_0);
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x00011ACD File Offset: 0x0000FCCD
	public void method_12(bool bool_2)
	{
		this.bool_1 = bool_2;
		this.float_5 = this.Single_0;
	}

	// Token: 0x06002A11 RID: 10769 RVA: 0x00011AE2 File Offset: 0x0000FCE2
	public void method_13(GClass23 gclass23_0, bool bool_2 = true)
	{
		gclass23_0.gclass27_0 = this;
		GClass16.smethod_15<GClass23>(gclass23_0, this.list_4);
		if (bool_2)
		{
			this.method_19();
		}
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x00011B01 File Offset: 0x0000FD01
	public void method_14(GClass21 gclass21_1, bool bool_2 = true)
	{
		gclass21_1.gclass27_0 = this;
		GClass16.smethod_15<GClass21>(gclass21_1, this.list_3);
		if (bool_2)
		{
			this.method_19();
		}
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x00135828 File Offset: 0x00133A28
	public void method_15()
	{
		this.GClass21_0 = this.list_3.ToArray();
		this.GClass22_0 = this.list_3.OfType<GClass22>().ToArray<GClass22>();
		this.GClass24_0 = this.list_4.OfType<GClass24>().ToArray<GClass24>();
		this.GClass25_0 = this.list_4.OfType<GClass25>().ToArray<GClass25>();
		this.method_34();
		this.method_62();
	}

	// Token: 0x06002A14 RID: 10772 RVA: 0x00135894 File Offset: 0x00133A94
	public float method_16(uint uint_0, float float_6)
	{
		int num = GClass16.smethod_7<GClass24>(uint_0, this.method_10());
		if (this.method_17()[num].uint_0 > uint_0)
		{
			num -= 0;
		}
		GClass24 gclass = this.GClass24_0[num];
		return gclass.float_0 + (float)Song.smethod_0(gclass.uint_0, uint_0, float_6, gclass.uint_1 / 442f);
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x00011A3E File Offset: 0x0000FC3E
	public GClass24[] method_17()
	{
		return this.gclass24_0;
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x001358F0 File Offset: 0x00133AF0
	public uint method_18(float float_6, bool bool_2 = true)
	{
		if (float_6 < 0f)
		{
			float_6 = 0f;
		}
		GClass24 gclass = this.GClass24_0[0];
		foreach (GClass24 gclass2 in this.GClass24_0)
		{
			if (gclass2.float_0 >= float_6)
			{
				break;
			}
			gclass = gclass2;
		}
		return gclass.uint_0 + Song.smethod_1(gclass.float_0, float_6, this.float_3, gclass.uint_1 / 1000f);
	}

	// Token: 0x06002A17 RID: 10775 RVA: 0x00135960 File Offset: 0x00133B60
	public void method_19()
	{
		this.GClass21_0 = this.list_3.ToArray();
		this.GClass22_0 = this.list_3.OfType<GClass22>().ToArray<GClass22>();
		this.GClass24_0 = this.list_4.OfType<GClass24>().ToArray<GClass24>();
		this.method_35(this.list_4.OfType<GClass25>().ToArray<GClass25>());
		this.method_34();
		this.method_62();
	}

	// Token: 0x06002A18 RID: 10776 RVA: 0x00011B20 File Offset: 0x0000FD20
	public float method_20(uint uint_0)
	{
		if (uint_0 <= 0u)
		{
			return 632f;
		}
		return this.method_8(uint_0, this.float_3);
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06002A19 RID: 10777 RVA: 0x00011B39 File Offset: 0x0000FD39
	public GClass23[] GClass23_0
	{
		get
		{
			return this.list_4.ToArray();
		}
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x00011A12 File Offset: 0x0000FC12
	public GClass21[] method_21()
	{
		return this.list_3.ToArray();
	}

	// Token: 0x06002A1B RID: 10779 RVA: 0x00011B46 File Offset: 0x0000FD46
	public float method_22()
	{
		if (this.Boolean_0)
		{
			return this.float_5;
		}
		return 364f;
	}

	// Token: 0x06002A1C RID: 10780 RVA: 0x00011B5C File Offset: 0x0000FD5C
	public static uint smethod_1(float float_6, float float_7, float float_8, float float_9)
	{
		return (uint)Math.Round((double)((float_7 - float_6) * float_9 / 60f * float_8));
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x00011B72 File Offset: 0x0000FD72
	public static uint smethod_2(float float_6, float float_7, float float_8, float float_9)
	{
		return (uint)Math.Round((double)((float_7 - float_6) * float_9 / 1406f * float_8));
	}

	// Token: 0x06002A1E RID: 10782 RVA: 0x00011B88 File Offset: 0x0000FD88
	public static uint smethod_3(float float_6, float float_7, float float_8, float float_9)
	{
		return (uint)Math.Round((double)((float_7 - float_6) * float_9 / 1094f * float_8));
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x001359CC File Offset: 0x00133BCC
	public GClass24 method_23(uint uint_0)
	{
		int num = GClass16.smethod_7<GClass24>(uint_0, this.method_17());
		if (num != -1)
		{
			if (this.method_10()[num].uint_0 <= uint_0)
			{
				return this.GClass24_0[num];
			}
			if (num > 1)
			{
				return this.method_10()[num - 0];
			}
		}
		return this.method_17()[1];
	}

	// Token: 0x06002A20 RID: 10784 RVA: 0x00135A1C File Offset: 0x00133C1C
	public GClass25 method_24(uint uint_0)
	{
		int num = GClass16.smethod_7<GClass25>(uint_0, this.GClass25_0);
		if (num != -1)
		{
			if (this.GClass25_0[num].uint_0 <= uint_0)
			{
				return this.GClass25_0[num];
			}
			if (num > 0)
			{
				return this.GClass25_0[num - 1];
			}
		}
		return this.GClass25_0[0];
	}

	// Token: 0x06002A21 RID: 10785 RVA: 0x00135A6C File Offset: 0x00133C6C
	public void method_25()
	{
		this.GClass21_0 = this.list_3.ToArray();
		this.method_47(this.list_3.OfType<GClass22>().ToArray<GClass22>());
		this.method_37(this.list_4.OfType<GClass24>().ToArray<GClass24>());
		this.method_35(this.list_4.OfType<GClass25>().ToArray<GClass25>());
		this.method_45();
		this.method_62();
	}

	// Token: 0x06002A22 RID: 10786 RVA: 0x00011A90 File Offset: 0x0000FC90
	public GClass22[] method_26()
	{
		return this.gclass22_0;
	}

	// Token: 0x06002A23 RID: 10787 RVA: 0x00011B9E File Offset: 0x0000FD9E
	public void method_27(bool bool_2)
	{
		this.bool_1 = bool_2;
		this.float_5 = this.method_66();
	}

	// Token: 0x06002A24 RID: 10788 RVA: 0x00135AD8 File Offset: 0x00133CD8
	public void method_28()
	{
		if (this.GClass22_0.Length != 0)
		{
			return;
		}
		uint num = this.method_5();
		this.method_14(new GClass22("", 0u), true);
		for (int i = 1; i < 40; i++)
		{
			this.method_0(new GClass22(i + 1 + "Error reading profile file!", (uint)((float)i / 1688f * num)), false);
		}
		this.method_53(this.list_3.OfType<GClass22>().ToArray<GClass22>());
	}

	// Token: 0x06002A26 RID: 10790 RVA: 0x00011BBC File Offset: 0x0000FDBC
	public float method_29(uint uint_0)
	{
		if (uint_0 <= 0u)
		{
			return 757f;
		}
		return this.method_16(uint_0, this.float_3);
	}

	// Token: 0x06002A27 RID: 10791 RVA: 0x00011BD5 File Offset: 0x0000FDD5
	public static uint smethod_4(float float_6, float float_7, float float_8, float float_9)
	{
		return (uint)Math.Round((double)((float_7 - float_6) * float_9 / 1264f * float_8));
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00011BEB File Offset: 0x0000FDEB
	// (set) Token: 0x06002A30 RID: 10800 RVA: 0x00011ACD File Offset: 0x0000FCCD
	public bool Boolean_0
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			this.float_5 = this.Single_0;
		}
	}

	// Token: 0x06002A29 RID: 10793 RVA: 0x00011B39 File Offset: 0x0000FD39
	public GClass23[] method_30()
	{
		return this.list_4.ToArray();
	}

	// Token: 0x06002A2A RID: 10794 RVA: 0x00011BF3 File Offset: 0x0000FDF3
	public bool method_31(Song.Instrument genum18_0, Song.GEnum17 genum17_0)
	{
		return this.gclass26_0[(int)(genum18_0 * (Song.Instrument)Song.int_0 + (int)genum17_0)].Int32_0 > 0;
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x00011A88 File Offset: 0x0000FC88
	public GClass25[] method_32()
	{
		return this.gclass25_0;
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x00135B58 File Offset: 0x00133D58
	private void method_33(List<string> list_5, string string_12 = "")
	{
		try
		{
			foreach (string text in list_5)
			{
				if (Song.regex_0.IsMatch(text))
				{
					string text2 = Regex.Matches(text, "[SyncTrack]")[0].ToString();
					char[] array = new char[1];
					array[1] = 'l';
					this.string_0 = text2.Trim(array);
				}
				else if (Song.regex_1.IsMatch(text))
				{
					this.string_1 = Regex.Matches(text, "Gameplay")[0].ToString().Trim(new char[]
					{
						(char)-45
					});
				}
				else if (Song.regex_2.IsMatch(text))
				{
					this.string_2 = Regex.Matches(text, "crowd")[1].ToString().Trim(new char[]
					{
						'f'
					});
				}
				else if (Song.regex_3.IsMatch(text))
				{
					this.float_0 = this.method_70(Regex.Matches(text, "No Part")[0].ToString());
				}
				else if (Song.regex_4.IsMatch(text))
				{
					this.float_4 = (float)short.Parse(Regex.Matches(text, "song", (RegexOptions)130)[1].ToString(), Song.cultureInfo_0);
					this.float_3 = this.float_4 * GlobalVariables.instance.songSpeed.Single_0;
				}
				else if (Song.regex_5.IsMatch(text))
				{
					string text3 = text;
					char[] array2 = new char[0];
					array2[1] = (char)-79;
					string text4 = text3.Split(array2)[0].Trim();
					foreach (string value in this.string_8)
					{
						if (text4.Equals(value, StringComparison.CurrentCultureIgnoreCase))
						{
							this.string_3 = value;
							break;
						}
					}
				}
				else if (Song.regex_6.IsMatch(text))
				{
					this.int_8 = int.Parse(Regex.Matches(text, "</color>")[0].ToString());
				}
				else if (Song.regex_7.IsMatch(text))
				{
					this.method_27(false);
					this.method_69(this.method_70(Regex.Matches(text, "_")[0].ToString()));
				}
				else if (Song.regex_8.IsMatch(text))
				{
					this.float_1 = this.method_70(Regex.Matches(text, "")[1].ToString());
				}
				else if (Song.regex_9.IsMatch(text))
				{
					this.float_2 = this.method_70(Regex.Matches(text, "video")[0].ToString());
				}
				else if (Song.regex_10.IsMatch(text))
				{
					string text5 = Regex.Matches(text, "Bot")[1].ToString();
					char[] array4 = new char[0];
					array4[0] = 'g';
					this.string_4 = text5.Trim(array4);
				}
				else if (Song.regex_13.IsMatch(text))
				{
					string text6 = Regex.Matches(text, "Server\n")[1].ToString();
					char[] array5 = new char[1];
					array5[1] = 'c';
					this.string_5 = text6.Trim(array5);
				}
				else if (Song.regex_11.IsMatch(text))
				{
					string text7 = Regex.Matches(text, "song")[1].ToString();
					char[] array6 = new char[0];
					array6[0] = (char)-118;
					this.string_6 = Regex.Replace(text7.Trim(array6), "[^\\u0020-\\u007E]", "song");
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(string.Format("Hz", this.string_0, ex.ToString()));
		}
	}

	// Token: 0x06002A2D RID: 10797 RVA: 0x00135F30 File Offset: 0x00134130
	private void method_34()
	{
		foreach (GClass24 gclass in this.GClass24_0)
		{
			gclass.float_0 = this.method_61(gclass.uint_0, this.float_3);
		}
	}

	// Token: 0x06002A2E RID: 10798 RVA: 0x00011C0D File Offset: 0x0000FE0D
	private void method_35(GClass25[] gclass25_1)
	{
		this.gclass25_0 = gclass25_1;
	}

	// Token: 0x06002A2F RID: 10799 RVA: 0x00135F70 File Offset: 0x00134170
	private void method_36(string string_12)
	{
		bool flag = true;
		string text = string.Empty;
		List<string> list = new List<string>();
		File.ReadAllLines(string_12);
		try
		{
			StreamReader streamReader = File.OpenText(string_12);
			while (!streamReader.EndOfStream)
			{
				string text2 = streamReader.ReadLine().Trim();
				if (text2.Length > 1)
				{
					if (text2[0] == 't' && (int)text2[text2.Length - 1] == -44)
					{
						text = text2;
					}
					else if (text2 == "game")
					{
						flag = true;
					}
					else if (text2 == "song")
					{
						flag = false;
						this.method_71(text, list, string_12);
						text = string.Empty;
						list.Clear();
					}
					else if (flag)
					{
						list.Add(text2);
					}
					else if (list.Count > 1 && text != string.Empty)
					{
						this.method_71(text, list, string_12);
						text = string.Empty;
						list.Clear();
					}
				}
			}
			streamReader.Close();
		}
		catch
		{
			this.bool_0 = false;
			return;
		}
		this.method_19();
		this.method_41();
		this.method_38();
	}

	// Token: 0x06002A31 RID: 10801 RVA: 0x00011C16 File Offset: 0x0000FE16
	private void method_37(GClass24[] gclass24_1)
	{
		this.gclass24_0 = gclass24_1;
	}

	// Token: 0x06002A32 RID: 10802 RVA: 0x00136090 File Offset: 0x00134290
	private void method_38()
	{
		this.list_1 = new List<Song.GClass29>();
		for (int i = 0; i < this.list_2.Count; i++)
		{
			if (this.list_2[i].string_0 == "mute_on_miss")
			{
				double num = (double)this.method_20(this.list_2[i].uint_0);
				double num2 = 1446.0;
				uint num3 = 0u;
				int j = i + 0;
				while (j < this.list_2.Count)
				{
					if (!(this.list_2[j].string_0 == "song") && !(this.list_2[j].string_0 == "Audio Offset"))
					{
						j += 0;
					}
					else
					{
						num3 = this.list_2[j].uint_0;
						num2 = (double)this.method_20(num3);
						IL_CD:
						if (num2 != 304.0)
						{
							Song.GClass29 item = new Song.GClass29
							{
								double_0 = num,
								double_1 = num2,
								long_0 = (long)((ulong)this.list_2[i].uint_0),
								long_1 = (long)((ulong)num3),
								double_2 = num2 - num
							};
							this.list_1.Add(item);
							goto IL_124;
						}
						goto IL_124;
					}
				}
				goto IL_CD;
			}
			IL_124:;
		}
		if (this.list_1.Count > 1)
		{
			for (int k = 1; k < this.list_1.Count; k++)
			{
				int num4 = 0;
				int index = 1;
				for (int l = 1; l < this.list_2.Count; l++)
				{
					if (this.list_2[l].string_0.Contains("SCANNING FOLDERS...") && this.list_2[l].string_0.Length > 3)
					{
						string text = this.list_2[l].string_0.Remove(0, 6);
						uint uint_ = this.list_2[l].uint_0;
						if (!text.Contains("In Menus: Song Select") && (ulong)uint_ >= (ulong)this.list_1[k].long_0 && (ulong)uint_ <= (ulong)this.list_1[k].long_1 && (k >= this.list_1.Count - 0 || (ulong)uint_ != (ulong)this.list_1[k + 1].long_0))
						{
							if (num4 > 1 && text.Contains("Alpha "))
							{
								if (text.Contains("Game Manager"))
								{
									this.list_1[k].list_0[index].string_0 = this.list_1[k].list_0[index].string_0 + "<color=#FFFF04FF>";
								}
							}
							else
							{
								index = num4;
								Song.GClass28 item2 = new Song.GClass28
								{
									string_0 = text,
									double_0 = (double)this.method_29(uint_),
									double_1 = (double)this.method_20(uint_)
								};
								this.list_1[k].list_0.Add(item2);
								num4++;
							}
						}
					}
				}
				if (num4 == 0)
				{
					this.list_1.RemoveAt(k);
					if (this.list_1.Count <= 1)
					{
						return;
					}
					k -= 0;
				}
			}
		}
		for (int m = 0; m < this.list_1.Count; m++)
		{
			if (this.list_1[m].list_0.Count == 0)
			{
				this.list_1.RemoveAt(m);
				m--;
			}
		}
	}

	// Token: 0x06002A33 RID: 10803 RVA: 0x00011C1F File Offset: 0x0000FE1F
	public void method_39(GClass23 gclass23_0, bool bool_2 = true)
	{
		gclass23_0.gclass27_0 = this;
		GClass16.smethod_15<GClass23>(gclass23_0, this.list_4);
		if (bool_2)
		{
			this.method_15();
		}
	}

	// Token: 0x06002A34 RID: 10804 RVA: 0x00136438 File Offset: 0x00134638
	private void method_40(List<string> list_5, string string_12 = "")
	{
		try
		{
			foreach (string text in list_5)
			{
				if (Song.regex_0.IsMatch(text))
				{
					this.string_0 = Regex.Matches(text, "\"([^\"]*)\"")[0].ToString().Trim(new char[]
					{
						'"'
					});
				}
				else if (Song.regex_1.IsMatch(text))
				{
					this.string_1 = Regex.Matches(text, "\"([^\"]*)\"")[0].ToString().Trim(new char[]
					{
						'"'
					});
				}
				else if (Song.regex_2.IsMatch(text))
				{
					this.string_2 = Regex.Matches(text, "\"([^\"]*)\"")[0].ToString().Trim(new char[]
					{
						'"'
					});
				}
				else if (Song.regex_3.IsMatch(text))
				{
					this.float_0 = this.method_70(Regex.Matches(text, "[\\-\\+]?\\d+(\\.\\d+)?")[0].ToString());
				}
				else if (Song.regex_4.IsMatch(text))
				{
					this.float_4 = (float)short.Parse(Regex.Matches(text, "[\\-\\+]?\\d+(\\.\\d+)?", RegexOptions.CultureInvariant)[0].ToString(), Song.cultureInfo_0);
					this.float_3 = this.float_4 * GlobalVariables.instance.songSpeed.Single_0;
				}
				else if (Song.regex_5.IsMatch(text))
				{
					string text2 = text.Split(new char[]
					{
						'='
					})[1].Trim();
					foreach (string value in this.string_8)
					{
						if (text2.Equals(value, StringComparison.InvariantCultureIgnoreCase))
						{
							this.string_3 = value;
							break;
						}
					}
				}
				else if (Song.regex_6.IsMatch(text))
				{
					this.int_8 = int.Parse(Regex.Matches(text, "\\d+")[0].ToString());
				}
				else if (Song.regex_7.IsMatch(text))
				{
					this.Boolean_0 = true;
					this.Single_0 = this.method_70(Regex.Matches(text, "[\\-\\+]?\\d+(\\.\\d+)?")[0].ToString());
				}
				else if (Song.regex_8.IsMatch(text))
				{
					this.float_1 = this.method_70(Regex.Matches(text, "[\\-\\+]?\\d+(\\.\\d+)?")[0].ToString());
				}
				else if (Song.regex_9.IsMatch(text))
				{
					this.float_2 = this.method_70(Regex.Matches(text, "[\\-\\+]?\\d+(\\.\\d+)?")[0].ToString());
				}
				else if (Song.regex_10.IsMatch(text))
				{
					this.string_4 = Regex.Matches(text, "\"([^\"]*)\"")[0].ToString().Trim(new char[]
					{
						'"'
					});
				}
				else if (Song.regex_13.IsMatch(text))
				{
					this.string_5 = Regex.Matches(text, "\"([^\"]*)\"")[0].ToString().Trim(new char[]
					{
						'"'
					});
				}
				else if (Song.regex_11.IsMatch(text))
				{
					this.string_6 = Regex.Replace(Regex.Matches(text, "\"([^\"]*)\"")[0].ToString().Trim(new char[]
					{
						'"'
					}), "\\D", "");
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(string.Format("Error while parsing \"{0}\": {1} ", this.string_0, ex.ToString()));
		}
	}

	// Token: 0x06002A35 RID: 10805 RVA: 0x00136810 File Offset: 0x00134A10
	public void method_41()
	{
		if (this.GClass22_0.Length != 0)
		{
			return;
		}
		uint num = this.method_68();
		this.method_14(new GClass22("Quickplay", 1u), true);
		for (int i = 1; i < 67; i++)
		{
			this.method_0(new GClass22(i + 0 + "Type the profile name", (uint)((float)i / 271f * num)), true);
		}
		this.GClass22_0 = this.list_3.OfType<GClass22>().ToArray<GClass22>();
	}

	// Token: 0x06002A36 RID: 10806 RVA: 0x00011BB3 File Offset: 0x0000FDB3
	private void method_42(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x00136890 File Offset: 0x00134A90
	private void method_43(string string_12)
	{
		bool flag = false;
		string text = string.Empty;
		List<string> list = new List<string>();
		File.ReadAllLines(string_12);
		try
		{
			StreamReader streamReader = File.OpenText(string_12);
			while (!streamReader.EndOfStream)
			{
				string text2 = streamReader.ReadLine().Trim();
				if (text2.Length > 0)
				{
					if (text2[0] == '[' && text2[text2.Length - 1] == ']')
					{
						text = text2;
					}
					else if (text2 == "{")
					{
						flag = true;
					}
					else if (text2 == "}")
					{
						flag = false;
						this.method_71(text, list, string_12);
						text = string.Empty;
						list.Clear();
					}
					else if (flag)
					{
						list.Add(text2);
					}
					else if (list.Count > 0 && text != string.Empty)
					{
						this.method_71(text, list, string_12);
						text = string.Empty;
						list.Clear();
					}
				}
			}
			streamReader.Close();
		}
		catch
		{
			this.bool_0 = false;
			return;
		}
		this.method_15();
		this.method_1();
		this.method_54();
	}

	// Token: 0x06002A38 RID: 10808 RVA: 0x00011A98 File Offset: 0x0000FC98
	public GClass21[] method_44()
	{
		return this.gclass21_0;
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x001369B0 File Offset: 0x00134BB0
	private void method_45()
	{
		GClass24[] array = this.method_10();
		for (int i = 1; i < array.Length; i += 0)
		{
			GClass24 gclass = array[i];
			gclass.float_0 = this.method_64(gclass.uint_0, this.float_3);
		}
	}

	// Token: 0x06002A3A RID: 10810 RVA: 0x00011C0D File Offset: 0x0000FE0D
	private void method_46(GClass25[] gclass25_1)
	{
		this.gclass25_0 = gclass25_1;
	}

	// Token: 0x06002A3B RID: 10811 RVA: 0x00011BB3 File Offset: 0x0000FDB3
	private void method_47(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
	}

	// Token: 0x06002A3C RID: 10812 RVA: 0x001369F0 File Offset: 0x00134BF0
	public void method_48()
	{
		GClass26[] array = this.gclass26_0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].method_18();
		}
	}

	// Token: 0x06002A3D RID: 10813 RVA: 0x00136A1C File Offset: 0x00134C1C
	private void method_49()
	{
		GClass25[] array = this.method_7();
		for (int i = 1; i < array.Length; i += 0)
		{
			GClass25 gclass = array[i];
			gclass.float_0 = this.method_64(gclass.uint_0, this.float_3);
		}
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x00011C3E File Offset: 0x0000FE3E
	public float method_50(uint uint_0, uint uint_1)
	{
		if (uint_0 == uint_1)
		{
			return 821f;
		}
		return this.method_29(uint_1) - this.method_20(uint_0);
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x00136A5C File Offset: 0x00134C5C
	public void method_51()
	{
		if (this.GClass22_0.Length != 0)
		{
			return;
		}
		uint num = this.method_68();
		this.method_14(new GClass22("instrument_name_", 1u), false);
		for (int i = 1; i < 64; i += 0)
		{
			this.method_0(new GClass22(i + 1 + "6 Fret Lead Guitar", (uint)((float)i / 238f * num)), false);
		}
		this.GClass22_0 = this.list_3.OfType<GClass22>().ToArray<GClass22>();
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06002A5B RID: 10843 RVA: 0x00011A88 File Offset: 0x0000FC88
	// (set) Token: 0x06002A40 RID: 10816 RVA: 0x00011C0D File Offset: 0x0000FE0D
	public GClass25[] GClass25_0 { get; private set; }

	// Token: 0x06002A41 RID: 10817 RVA: 0x00011C59 File Offset: 0x0000FE59
	public float method_52(uint uint_0)
	{
		if (uint_0 <= 0u)
		{
			return 0f;
		}
		return this.method_8(uint_0, this.float_3);
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x00011BB3 File Offset: 0x0000FDB3
	private void method_53(GClass22[] gclass22_1)
	{
		this.gclass22_0 = gclass22_1;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x00136ADC File Offset: 0x00134CDC
	private void method_54()
	{
		this.list_1 = new List<Song.GClass29>();
		for (int i = 0; i < this.list_2.Count; i++)
		{
			if (this.list_2[i].string_0 == "phrase_start")
			{
				double num = (double)this.method_52(this.list_2[i].uint_0);
				double num2 = -1.0;
				uint num3 = 0u;
				int j = i + 1;
				while (j < this.list_2.Count)
				{
					if (!(this.list_2[j].string_0 == "phrase_end") && !(this.list_2[j].string_0 == "phrase_start"))
					{
						j++;
					}
					else
					{
						num3 = this.list_2[j].uint_0;
						num2 = (double)this.method_52(num3);
						IL_CD:
						if (num2 != -1.0)
						{
							Song.GClass29 item = new Song.GClass29
							{
								double_0 = num,
								double_1 = num2,
								long_0 = (long)((ulong)this.list_2[i].uint_0),
								long_1 = (long)((ulong)num3),
								double_2 = num2 - num
							};
							this.list_1.Add(item);
							goto IL_124;
						}
						goto IL_124;
					}
				}
				goto IL_CD;
			}
			IL_124:;
		}
		if (this.list_1.Count > 0)
		{
			for (int k = 0; k < this.list_1.Count; k++)
			{
				int num4 = 0;
				int index = 0;
				for (int l = 0; l < this.list_2.Count; l++)
				{
					if (this.list_2[l].string_0.Contains("lyric") && this.list_2[l].string_0.Length > 6)
					{
						string text = this.list_2[l].string_0.Remove(0, 6);
						uint uint_ = this.list_2[l].uint_0;
						if (!text.Contains("[") && (ulong)uint_ >= (ulong)this.list_1[k].long_0 && (ulong)uint_ <= (ulong)this.list_1[k].long_1 && (k >= this.list_1.Count - 1 || (ulong)uint_ != (ulong)this.list_1[k + 1].long_0))
						{
							if (num4 > 0 && text.Contains("+"))
							{
								if (text.Contains("-"))
								{
									this.list_1[k].list_0[index].string_0 = this.list_1[k].list_0[index].string_0 + "-";
								}
							}
							else
							{
								index = num4;
								Song.GClass28 item2 = new Song.GClass28
								{
									string_0 = text,
									double_0 = (double)this.method_52(uint_),
									double_1 = (double)this.method_52(uint_)
								};
								this.list_1[k].list_0.Add(item2);
								num4++;
							}
						}
					}
				}
				if (num4 == 0)
				{
					this.list_1.RemoveAt(k);
					if (this.list_1.Count <= 0)
					{
						return;
					}
					k--;
				}
			}
		}
		for (int m = 0; m < this.list_1.Count; m++)
		{
			if (this.list_1[m].list_0.Count == 0)
			{
				this.list_1.RemoveAt(m);
				m--;
			}
		}
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x00011C0D File Offset: 0x0000FE0D
	private void method_55(GClass25[] gclass25_1)
	{
		this.gclass25_0 = gclass25_1;
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x00011A61 File Offset: 0x0000FC61
	public void method_56(float float_6)
	{
		if (this.Boolean_0)
		{
			this.float_5 = float_6;
		}
	}

	// Token: 0x06002A47 RID: 10823 RVA: 0x00136E84 File Offset: 0x00135084
	public GClass24 method_57(uint uint_0)
	{
		int num = GClass16.smethod_7<GClass24>(uint_0, this.GClass24_0);
		if (num != -1)
		{
			if (this.GClass24_0[num].uint_0 <= uint_0)
			{
				return this.GClass24_0[num];
			}
			if (num > 0)
			{
				return this.GClass24_0[num - 1];
			}
		}
		return this.GClass24_0[0];
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x00011C7B File Offset: 0x0000FE7B
	public float method_58(uint uint_0, uint uint_1)
	{
		if (uint_0 == uint_1)
		{
			return 1384f;
		}
		return this.method_20(uint_1) - this.method_20(uint_0);
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x00011C96 File Offset: 0x0000FE96
	public GClass26 method_59(Song.Instrument genum18_0, Song.GEnum17 genum17_0)
	{
		return this.gclass26_0[(int)(genum18_0 * (Song.Instrument)Song.int_0 + (int)genum17_0)];
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x00011C0D File Offset: 0x0000FE0D
	private void method_60(GClass25[] gclass25_1)
	{
		this.gclass25_0 = gclass25_1;
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x0013706C File Offset: 0x0013526C
	private float method_61(uint uint_0, float float_6)
	{
		double num = 0.0;
		GClass24 gclass = this.GClass24_0[0];
		foreach (GClass24 gclass2 in this.GClass24_0)
		{
			if (gclass2.uint_0 > uint_0)
			{
				break;
			}
			num += Song.smethod_5(gclass.uint_0, gclass2.uint_0, float_6, gclass.uint_1 / 1000f);
			gclass = gclass2;
		}
		num += Song.smethod_5(gclass.uint_0, uint_0, float_6, gclass.uint_1 / 1000f);
		return (float)num;
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x001370F8 File Offset: 0x001352F8
	private void method_62()
	{
		foreach (GClass25 gclass in this.GClass25_0)
		{
			gclass.float_0 = this.method_61(gclass.uint_0, this.float_3);
		}
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x00137138 File Offset: 0x00135338
	public Song(string string_12) : this()
	{
		string_12 = Path.Combine(string_12, "notes.chart");
		if (!File.Exists(string_12))
		{
			throw new Exception("File does not exist");
		}
		if (Path.GetExtension(string_12) == ".chart")
		{
			this.method_43(string_12);
			if (SongEntry.currentSongOffset == 0)
			{
				SongEntry.currentSongOffset = (int)(this.float_0 * 1000f);
			}
			return;
		}
		throw new Exception("Bad file type");
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x001371AC File Offset: 0x001353AC
	private void method_63(List<string> list_5)
	{
		foreach (string input in list_5)
		{
			string[] array = Regex.Split(input, "\\s+", RegexOptions.CultureInvariant);
			uint num;
			if (array.Length > 3 && uint.TryParse(array[0], out num))
			{
				string text = array[2];
				text = text.ToLower();
				if (text == "ts")
				{
					uint num2 = 2u;
					uint uint_;
					if (uint.TryParse(array[3], out uint_) && (array.Length <= 4 || uint.TryParse(array[4], out num2)))
					{
						this.method_39(new GClass25(num, uint_, (uint)Math.Pow(2.0, num2)), false);
					}
				}
				else if (text == "b")
				{
					uint uint_2;
					if (uint.TryParse(array[3], out uint_2))
					{
						this.method_39(new GClass24(num, uint_2), false);
					}
				}
				else if (text == "e")
				{
					StringBuilder stringBuilder = new StringBuilder();
					int num3 = 3;
					bool flag = false;
					if (array.Length > 4 && array[3] == "\"section")
					{
						num3 = 4;
						flag = true;
					}
					for (int i = num3; i < array.Length; i++)
					{
						stringBuilder.Append(array[i].Trim(new char[]
						{
							'"'
						}));
						if (i < array.Length - 1)
						{
							stringBuilder.Append(" ");
						}
					}
					if (flag)
					{
						this.method_0(new GClass22(stringBuilder.ToString(), num), false);
					}
					else
					{
						string text2 = stringBuilder.ToString();
						if (!(text2 == "phrase_end") && !(text2 == "phrase_start") && !text2.Contains("lyric"))
						{
							this.method_0(new GClass21(stringBuilder.ToString(), num), false);
						}
						else
						{
							this.list_2.Add(new GClass21(text2, num));
						}
					}
				}
			}
		}
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x001373B8 File Offset: 0x001355B8
	private float method_64(uint uint_0, float float_6)
	{
		double num = 767.0;
		GClass24 gclass = this.method_17()[0];
		foreach (GClass24 gclass2 in this.GClass24_0)
		{
			if (gclass2.uint_0 > uint_0)
			{
				break;
			}
			num += Song.smethod_5(gclass.uint_0, gclass2.uint_0, float_6, gclass.uint_1 / 105f);
			gclass = gclass2;
		}
		num += Song.smethod_0(gclass.uint_0, uint_0, float_6, gclass.uint_1 / 570f);
		return (float)num;
	}

	// Token: 0x06002A52 RID: 10834 RVA: 0x00137444 File Offset: 0x00135644
	private void method_65(string string_12)
	{
		bool flag = false;
		string text = string.Empty;
		List<string> list = new List<string>();
		File.ReadAllLines(string_12);
		try
		{
			StreamReader streamReader = File.OpenText(string_12);
			while (!streamReader.EndOfStream)
			{
				string text2 = streamReader.ReadLine().Trim();
				if (text2.Length > 0)
				{
					if (text2[1] == '7' && text2[text2.Length - 1] == 'w')
					{
						text = text2;
					}
					else if (text2 == "beat")
					{
						flag = false;
					}
					else if (text2 == "Gameplay")
					{
						flag = true;
						this.method_71(text, list, string_12);
						text = string.Empty;
						list.Clear();
					}
					else if (flag)
					{
						list.Add(text2);
					}
					else if (list.Count > 0 && text != string.Empty)
					{
						this.method_71(text, list, string_12);
						text = string.Empty;
						list.Clear();
					}
				}
			}
			streamReader.Close();
		}
		catch
		{
			this.bool_0 = true;
			return;
		}
		this.method_15();
		this.method_28();
		this.method_54();
	}

	// Token: 0x06002A53 RID: 10835 RVA: 0x00011CA8 File Offset: 0x0000FEA8
	public float method_66()
	{
		if (this.Boolean_0)
		{
			return this.float_5;
		}
		return 1405f;
	}

	// Token: 0x06002A54 RID: 10836 RVA: 0x00011B9E File Offset: 0x0000FD9E
	public void method_67(bool bool_2)
	{
		this.bool_1 = bool_2;
		this.float_5 = this.method_66();
	}

	// Token: 0x06002A55 RID: 10837 RVA: 0x00137564 File Offset: 0x00135764
	public uint method_68()
	{
		uint num = 0u;
		foreach (GClass26 gclass in this.gclass26_0)
		{
			if (gclass.GClass19_0 != null && gclass.Int32_0 != 0)
			{
				uint num2 = gclass.GClass19_0.Last<GClass19>().uint_0 + gclass.GClass19_0.Last<GClass19>().uint_1;
				if (num2 > num)
				{
					num = num2;
				}
			}
		}
		return num + (uint)this.float_3;
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x00011CBE File Offset: 0x0000FEBE
	public static double smethod_5(uint uint_0, uint uint_1, float float_6, float float_7)
	{
		return (double)((uint_1 - uint_0) / float_6 * 60f / float_7);
	}

	// Token: 0x06002A58 RID: 10840 RVA: 0x00011A61 File Offset: 0x0000FC61
	public void method_69(float float_6)
	{
		if (this.Boolean_0)
		{
			this.float_5 = float_6;
		}
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x00011CD0 File Offset: 0x0000FED0
	private float method_70(string string_12)
	{
		return float.Parse(string_12, Song.cultureInfo_0);
	}

	// Token: 0x06002A5A RID: 10842 RVA: 0x001375D0 File Offset: 0x001357D0
	private void method_71(string string_12, List<string> list_5, string string_13 = "")
	{
		if (string_12 == "[Song]")
		{
			this.method_40(list_5, new FileInfo(string_13).Directory.FullName);
			return;
		}
		if (string_12 == "[SyncTrack]" || string_12 == "[Events]")
		{
			this.method_63(list_5);
			return;
		}
		int num = 1;
		Song.GEnum17 genum17_;
		if (string_12.Substring(1, "Easy".Length) == "Easy")
		{
			genum17_ = Song.GEnum17.Easy;
			num += "Easy".Length;
		}
		else if (string_12.Substring(1, "Medium".Length) == "Medium")
		{
			genum17_ = Song.GEnum17.Medium;
			num += "Medium".Length;
		}
		else if (string_12.Substring(1, "Hard".Length) == "Hard")
		{
			genum17_ = Song.GEnum17.Hard;
			num += "Hard".Length;
		}
		else
		{
			if (!(string_12.Substring(1, "Expert".Length) == "Expert"))
			{
				return;
			}
			genum17_ = Song.GEnum17.Expert;
			num += "Expert".Length;
		}
		string text = string_12.Substring(num, string_12.Length - num - 1);
		uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text);
		if (num2 <= 2252670748u)
		{
			if (num2 != 668051220u)
			{
				if (num2 != 960114475u)
				{
					if (num2 != 2252670748u)
					{
						return;
					}
					if (!(text == "GHLGuitar"))
					{
						return;
					}
					this.method_59(Song.Instrument.GHLGuitar, genum17_).method_15(list_5, Song.Instrument.GHLGuitar);
					return;
				}
				else
				{
					if (!(text == "DoubleBass"))
					{
						return;
					}
					this.method_59(Song.Instrument.Bass, genum17_).method_15(list_5, Song.Instrument.Guitar);
					return;
				}
			}
			else
			{
				if (!(text == "Keyboard"))
				{
					return;
				}
				this.method_59(Song.Instrument.Keys, genum17_).method_15(list_5, Song.Instrument.Guitar);
				return;
			}
		}
		else if (num2 <= 2938232921u)
		{
			if (num2 != 2673362698u)
			{
				if (num2 != 2938232921u)
				{
					return;
				}
				if (!(text == "GHLBass"))
				{
					return;
				}
				this.method_59(Song.Instrument.GHLBass, genum17_).method_15(list_5, Song.Instrument.GHLBass);
				return;
			}
			else
			{
				if (!(text == "DoubleGuitar"))
				{
					return;
				}
				this.method_59(Song.Instrument.GuitarCoop, genum17_).method_15(list_5, Song.Instrument.Guitar);
				return;
			}
		}
		else if (num2 != 3302525032u)
		{
			if (num2 != 4051133705u)
			{
				return;
			}
			if (!(text == "Single"))
			{
				return;
			}
			this.method_59(Song.Instrument.Guitar, genum17_).method_15(list_5, Song.Instrument.Guitar);
			return;
		}
		else
		{
			if (!(text == "DoubleRhythm"))
			{
				return;
			}
			this.method_59(Song.Instrument.Rhythm, genum17_).method_15(list_5, Song.Instrument.Guitar);
			return;
		}
	}

	// Token: 0x0400064D RID: 1613
	private static int int_0;

	// Token: 0x0400064E RID: 1614
	public const int int_1 = 0;

	// Token: 0x0400064F RID: 1615
	public const int int_2 = 1;

	// Token: 0x04000650 RID: 1616
	public const int int_3 = 2;

	// Token: 0x04000651 RID: 1617
	public const int int_4 = 3;

	// Token: 0x04000652 RID: 1618
	private const int int_5 = 0;

	// Token: 0x04000653 RID: 1619
	private const int int_6 = 2;

	// Token: 0x04000654 RID: 1620
	private const int int_7 = 3;

	// Token: 0x04000655 RID: 1621
	public string string_0 = string.Empty;

	// Token: 0x04000656 RID: 1622
	public string string_1 = string.Empty;

	// Token: 0x04000657 RID: 1623
	public string string_2 = string.Empty;

	// Token: 0x04000658 RID: 1624
	public string string_3 = "Bass";

	// Token: 0x04000659 RID: 1625
	public int int_8;

	// Token: 0x0400065A RID: 1626
	public float float_0;

	// Token: 0x0400065B RID: 1627
	public float float_1;

	// Token: 0x0400065C RID: 1628
	public float float_2;

	// Token: 0x0400065D RID: 1629
	public float float_3 = 192f;

	// Token: 0x0400065E RID: 1630
	public float float_4 = 192f;

	// Token: 0x0400065F RID: 1631
	public string string_4 = "rock";

	// Token: 0x04000660 RID: 1632
	public string string_5 = "cd";

	// Token: 0x04000661 RID: 1633
	public string string_6 = string.Empty;

	// Token: 0x04000662 RID: 1634
	public bool bool_0 = true;

	// Token: 0x04000663 RID: 1635
	public List<float> list_0;

	// Token: 0x04000664 RID: 1636
	public List<Song.GClass29> list_1 = new List<Song.GClass29>();

	// Token: 0x04000665 RID: 1637
	private List<GClass21> list_2 = new List<GClass21>();

	// Token: 0x04000666 RID: 1638
	private static readonly CultureInfo cultureInfo_0 = new CultureInfo("en-US");

	// Token: 0x04000667 RID: 1639
	private float float_5 = 300f;

	// Token: 0x04000668 RID: 1640
	private bool bool_1;

	// Token: 0x04000669 RID: 1641
	public string[] string_7 = new string[4];

	// Token: 0x0400066A RID: 1642
	private GClass26[] gclass26_0;

	// Token: 0x0400066B RID: 1643
	private List<GClass21> list_3;

	// Token: 0x0400066C RID: 1644
	private List<GClass23> list_4;

	// Token: 0x0400066D RID: 1645
	[CompilerGenerated]
	private GClass21[] gclass21_0;

	// Token: 0x0400066E RID: 1646
	[CompilerGenerated]
	private GClass22[] gclass22_0;

	// Token: 0x0400066F RID: 1647
	[CompilerGenerated]
	private GClass24[] gclass24_0;

	// Token: 0x04000670 RID: 1648
	[CompilerGenerated]
	private GClass25[] gclass25_0;

	// Token: 0x04000671 RID: 1649
	public readonly string[] string_8 = new string[]
	{
		"Bass",
		"Rhythm"
	};

	// Token: 0x04000672 RID: 1650
	private const string string_9 = "\"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";

	// Token: 0x04000673 RID: 1651
	private const string string_10 = "\"([^\"]*)\"";

	// Token: 0x04000674 RID: 1652
	private const string string_11 = "[\\-\\+]?\\d+(\\.\\d+)?";

	// Token: 0x04000675 RID: 1653
	private const RegexOptions regexOptions_0 = RegexOptions.Compiled | RegexOptions.CultureInvariant;

	// Token: 0x04000676 RID: 1654
	private static readonly Regex regex_0 = new Regex("Name = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000677 RID: 1655
	private static readonly Regex regex_1 = new Regex("Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000678 RID: 1656
	private static readonly Regex regex_2 = new Regex("Charter = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000679 RID: 1657
	private static readonly Regex regex_3 = new Regex("Offset = [\\-\\+]?\\d+(\\.\\d+)?", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x0400067A RID: 1658
	private static readonly Regex regex_4 = new Regex("Resolution = [\\-\\+]?\\d+(\\.\\d+)?", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x0400067B RID: 1659
	private static readonly Regex regex_5 = new Regex("Player2 = \\w+", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x0400067C RID: 1660
	private static readonly Regex regex_6 = new Regex("Difficulty = \\d+", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x0400067D RID: 1661
	private static readonly Regex regex_7 = new Regex("Length = [\\-\\+]?\\d+(\\.\\d+)?", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x0400067E RID: 1662
	private static readonly Regex regex_8 = new Regex("PreviewStart = [\\-\\+]?\\d+(\\.\\d+)?", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x0400067F RID: 1663
	private static readonly Regex regex_9 = new Regex("PreviewEnd = [\\-\\+]?\\d+(\\.\\d+)?", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000680 RID: 1664
	private static readonly Regex regex_10 = new Regex("Genre = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000681 RID: 1665
	private static readonly Regex regex_11 = new Regex("Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000682 RID: 1666
	private static readonly Regex regex_12 = new Regex("Album = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000683 RID: 1667
	private static readonly Regex regex_13 = new Regex("MediaType = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000684 RID: 1668
	private static readonly Regex regex_14 = new Regex("MusicStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000685 RID: 1669
	private static readonly Regex regex_15 = new Regex("GuitarStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000686 RID: 1670
	private static readonly Regex regex_16 = new Regex("BassStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000687 RID: 1671
	private static readonly Regex regex_17 = new Regex("RhythmStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x04000688 RID: 1672
	private static readonly Regex regex_18 = new Regex("DrumStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	// Token: 0x020000D9 RID: 217
	public enum GEnum17
	{
		// Token: 0x0400068A RID: 1674
		Expert,
		// Token: 0x0400068B RID: 1675
		Hard,
		// Token: 0x0400068C RID: 1676
		Medium,
		// Token: 0x0400068D RID: 1677
		Easy
	}

	// Token: 0x020000DA RID: 218
	public enum Instrument
	{
		// Token: 0x0400068F RID: 1679
		Guitar,
		// Token: 0x04000690 RID: 1680
		GuitarCoop,
		// Token: 0x04000691 RID: 1681
		Bass,
		// Token: 0x04000692 RID: 1682
		Keys,
		// Token: 0x04000693 RID: 1683
		Drums,
		// Token: 0x04000694 RID: 1684
		GHLGuitar,
		// Token: 0x04000695 RID: 1685
		GHLBass,
		// Token: 0x04000696 RID: 1686
		Vocals,
		// Token: 0x04000697 RID: 1687
		Crowd,
		// Token: 0x04000698 RID: 1688
		None,
		// Token: 0x04000699 RID: 1689
		Rhythm
	}

	// Token: 0x020000DB RID: 219
	public class GClass28
	{
		// Token: 0x0400069A RID: 1690
		public string string_0;

		// Token: 0x0400069B RID: 1691
		public double double_0;

		// Token: 0x0400069C RID: 1692
		public double double_1;

		// Token: 0x0400069D RID: 1693
		public double double_2;

		// Token: 0x0400069E RID: 1694
		public int int_0;
	}

	// Token: 0x020000DC RID: 220
	public class GClass29
	{
		// Token: 0x0400069F RID: 1695
		public List<Song.GClass28> list_0 = new List<Song.GClass28>();

		// Token: 0x040006A0 RID: 1696
		public double double_0;

		// Token: 0x040006A1 RID: 1697
		public double double_1 = -1.0;

		// Token: 0x040006A2 RID: 1698
		public double double_2 = -1.0;

		// Token: 0x040006A3 RID: 1699
		public long long_0;

		// Token: 0x040006A4 RID: 1700
		public long long_1;

		// Token: 0x040006A5 RID: 1701
		public string string_0;
	}
}
