using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

// Token: 0x020000D6 RID: 214
public class GClass26
{
	// Token: 0x06002956 RID: 10582 RVA: 0x00011856 File Offset: 0x0000FA56
	public Song method_0()
	{
		return this.gclass27_0;
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x0001185E File Offset: 0x0000FA5E
	private void method_1(GClass20[] gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x00011867 File Offset: 0x0000FA67
	public GClass20[] method_2()
	{
		return this.gclass20_0;
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x00011867 File Offset: 0x0000FA67
	public GClass20[] method_3()
	{
		return this.gclass20_0;
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x0013286C File Offset: 0x00130A6C
	public void method_4()
	{
		this.GClass19_0 = this.list_0.OfType<GClass19>().ToArray<GClass19>();
		this.method_39(this.list_0.OfType<GClass20>().ToArray<GClass20>());
		this.method_79(this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>());
		this.int_0 = this.method_66();
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x0001186F File Offset: 0x0000FA6F
	public int method_5()
	{
		return this.int_0;
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600295D RID: 10589 RVA: 0x00011887 File Offset: 0x0000FA87
	public GClass17[] GClass17_0
	{
		get
		{
			return this.list_0.ToArray();
		}
	}

	// Token: 0x0600295E RID: 10590 RVA: 0x001328C8 File Offset: 0x00130AC8
	public void method_7()
	{
		this.GClass19_0 = this.list_0.OfType<GClass19>().ToArray<GClass19>();
		this.method_1(this.list_0.OfType<GClass20>().ToArray<GClass20>());
		this.method_61(this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>());
		this.int_0 = this.method_30();
	}

	// Token: 0x0600295F RID: 10591 RVA: 0x00011894 File Offset: 0x0000FA94
	public GClass19[] method_8()
	{
		return this.gclass19_0;
	}

	// Token: 0x06002960 RID: 10592 RVA: 0x0001189C File Offset: 0x0000FA9C
	private void method_9(ChartEvent[] gclass18_1)
	{
		this.gclass18_0 = gclass18_1;
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06002982 RID: 10626 RVA: 0x00011894 File Offset: 0x0000FA94
	// (set) Token: 0x06002961 RID: 10593 RVA: 0x000118A5 File Offset: 0x0000FAA5
	public GClass19[] GClass19_0 { get; private set; }

	// Token: 0x06002962 RID: 10594 RVA: 0x00132924 File Offset: 0x00130B24
	public void method_10()
	{
		this.GClass19_0 = this.list_0.OfType<GClass19>().ToArray<GClass19>();
		this.method_41(this.list_0.OfType<GClass20>().ToArray<GClass20>());
		this.method_79(this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>());
		this.int_0 = this.method_78();
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x00132980 File Offset: 0x00130B80
	public void method_11(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("<");
		Regex regex2 = new Regex("{0}");
		Regex regex3 = new Regex("Create Profile");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			for (int i = 0; i < string_1.Length; i += 0)
			{
				string text = string_1[i];
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "VOLUME");
					if (array.Length == 7)
					{
						uint uint_ = uint.Parse(array[1]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[4]);
						GClass19.GEnum13 genum = GClass19.GEnum13.W3;
						if (genum18_0 != Song.Instrument.Bass)
						{
							if (genum18_0 != Song.Instrument.Guitar)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.NONE);
									this.method_38(gclass17_, true);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.YELLOW, uint_2, GClass19.GEnum15.FORCED);
									this.method_72(gclass17_2, false);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.W2;
							break;
						case 1:
							genum = GClass19.GEnum13.W1;
							break;
						case 2:
							genum = GClass19.GEnum13.YELLOW;
							break;
						case 3:
							genum = (GClass19.GEnum13)102;
							break;
						case 4:
							genum = (GClass19.GEnum13)(-98);
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.ORANGE;
							break;
						case 8:
							genum = (GClass19.GEnum13)(-67);
							break;
						}
						if (genum != GClass19.GEnum13.GREEN)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.NONE);
							this.method_12(gclass17_3, false);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "Continue");
					uint uint_3 = uint.Parse(array2[1]);
					uint uint_4 = uint.Parse(array2[4]);
					this.method_72(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "allow_duplicate_songs");
					uint uint_5 = uint.Parse(array3[0]);
					string string_2 = array3[2];
					this.method_72(new ChartEvent(uint_5, string_2), true);
				}
				IL_209:;
			}
			this.method_23();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "Calibration");
					if (array4.Length == 1)
					{
						uint uint_6 = uint.Parse(array4[1]);
						int num = int.Parse(array4[1]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.method_40());
						if (num != 6)
						{
							if (num == 3)
							{
								GClass19.smethod_19(gclass19_, (GClass19.GEnum15)8);
							}
						}
						else
						{
							GClass19.smethod_19(gclass19_, GClass19.GEnum15.NONE);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("/songs.txt" + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x000118AE File Offset: 0x0000FAAE
	public int method_12(GClass17 gclass17_0, bool bool_0 = true)
	{
		gclass17_0.gclass27_0 = this.gclass27_0;
		int result = GClass16.smethod_15<GClass17>(gclass17_0, this.list_0);
		if (bool_0)
		{
			this.method_18();
		}
		return result;
	}

	// Token: 0x06002965 RID: 10597 RVA: 0x0001185E File Offset: 0x0000FA5E
	private void method_13(GClass20[] gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x00011856 File Offset: 0x0000FA56
	public Song method_14()
	{
		return this.gclass27_0;
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x000118D1 File Offset: 0x0000FAD1
	public void method_15(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_68(list_3.ToArray(), genum18_0);
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x00011867 File Offset: 0x0000FA67
	public GClass20[] method_16()
	{
		return this.gclass20_0;
	}

	// Token: 0x06002969 RID: 10601 RVA: 0x00011887 File Offset: 0x0000FA87
	public GClass17[] method_17()
	{
		return this.list_0.ToArray();
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x00132C98 File Offset: 0x00130E98
	public void method_18()
	{
		this.GClass19_0 = this.list_0.OfType<GClass19>().ToArray<GClass19>();
		this.GClass20_0 = this.list_0.OfType<GClass20>().ToArray<GClass20>();
		this.GClass18_0 = this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>();
		this.int_0 = this.method_66();
	}

	// Token: 0x0600296B RID: 10603 RVA: 0x000118E0 File Offset: 0x0000FAE0
	public ChartEvent[] method_19()
	{
		return this.gclass18_0;
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600296C RID: 10604 RVA: 0x000118E0 File Offset: 0x0000FAE0
	// (set) Token: 0x06002989 RID: 10633 RVA: 0x0001189C File Offset: 0x0000FA9C
	public ChartEvent[] GClass18_0 { get; private set; }

	// Token: 0x0600296D RID: 10605 RVA: 0x00011894 File Offset: 0x0000FA94
	public GClass19[] method_20()
	{
		return this.gclass19_0;
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x0600296E RID: 10606 RVA: 0x000118E8 File Offset: 0x0000FAE8
	private IEnumerable<GClass19> IEnumerable_0
	{
		get
		{
			if (this.GClass19_0.Length != 0)
			{
				GClass19 gclass = this.GClass19_0[0];
				while (GClass16.smethod_1(gclass, null))
				{
					yield return gclass;
					gclass = gclass.GClass19_0;
				}
				gclass = null;
			}
			yield break;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x0600296F RID: 10607 RVA: 0x00011867 File Offset: 0x0000FA67
	// (set) Token: 0x060029A6 RID: 10662 RVA: 0x0001185E File Offset: 0x0000FA5E
	public GClass20[] GClass20_0 { get; private set; }

	// Token: 0x06002970 RID: 10608 RVA: 0x00132CF4 File Offset: 0x00130EF4
	public int method_21()
	{
		if (this.int_1 > 1)
		{
			return this.int_1;
		}
		int num = 1;
		uint num2 = 0u;
		GClass19[] array = this.method_46();
		for (int i = 1; i < array.Length; i++)
		{
			num += -58;
		}
		foreach (GClass19 gclass in this.method_6())
		{
			num2 += gclass.uint_1;
		}
		if (num2 > 1u)
		{
			num += Mathf.CeilToInt(num2 / (this.GClass27_0.float_4 / 261f));
		}
		this.int_1 = num;
		return this.int_1;
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x00132DA8 File Offset: 0x00130FA8
	public void method_22(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("\\D");
		Regex regex2 = new Regex("Are you sure you want to quit?");
		Regex regex3 = new Regex("loading_phrase");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			foreach (string text in string_1)
			{
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "album_track");
					if (array.Length == 5)
					{
						uint uint_ = uint.Parse(array[1]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[1]);
						GClass19.GEnum13 genum = GClass19.GEnum13.W1;
						if (genum18_0 != Song.Instrument.Guitar)
						{
							if (genum18_0 != Song.Instrument.GuitarCoop)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.FORCED);
									this.method_12(gclass17_, true);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.W3, uint_2, GClass19.GEnum15.FORCED);
									this.method_12(gclass17_2, false);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.ORANGE;
							break;
						case 1:
							genum = GClass19.GEnum13.GREEN;
							break;
						case 2:
							genum = GClass19.GEnum13.W1;
							break;
						case 3:
							genum = (GClass19.GEnum13)112;
							break;
						case 4:
							genum = (GClass19.GEnum13)(-8);
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.W2;
							break;
						case 8:
							genum = (GClass19.GEnum13)82;
							break;
						}
						if (genum != GClass19.GEnum13.BLUE)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.NONE);
							this.method_12(gclass17_3, true);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "game");
					uint uint_3 = uint.Parse(array2[1]);
					uint uint_4 = uint.Parse(array2[2]);
					this.method_38(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "^\\s*\\d+ = N \\d \\d+$");
					uint uint_5 = uint.Parse(array3[0]);
					string string_2 = array3[5];
					this.method_38(new ChartEvent(uint_5, string_2), false);
				}
				IL_209:;
			}
			this.method_7();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "song");
					if (array4.Length == 2)
					{
						uint uint_6 = uint.Parse(array4[0]);
						int num = int.Parse(array4[0]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.method_54());
						if (num != 7)
						{
							if (num == 8)
							{
								GClass19.smethod_19(gclass19_, GClass19.GEnum15.TAP);
							}
						}
						else
						{
							GClass19.smethod_19(gclass19_, GClass19.GEnum15.FORCED);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("song" + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x001330C0 File Offset: 0x001312C0
	public void method_23()
	{
		this.method_44(this.list_0.OfType<GClass19>().ToArray<GClass19>());
		this.method_1(this.list_0.OfType<GClass20>().ToArray<GClass20>());
		this.method_43(this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>());
		this.int_0 = this.method_25();
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x0013311C File Offset: 0x0013131C
	public int method_24()
	{
		if (this.int_1 > 0)
		{
			return this.int_1;
		}
		int num = 0;
		uint num2 = 0u;
		GClass19[] array = this.GClass19_0;
		for (int i = 0; i < array.Length; i++)
		{
			num += 50;
		}
		foreach (GClass19 gclass in this.IEnumerable_0)
		{
			num2 += gclass.uint_1;
		}
		if (num2 > 0u)
		{
			num += Mathf.CeilToInt(num2 / (this.GClass27_0.float_4 / 25f));
		}
		this.int_1 = num;
		return this.int_1;
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x001331D0 File Offset: 0x001313D0
	private int method_25()
	{
		if (this.method_73().Length <= 0)
		{
			return this.method_8().Length;
		}
		int num = 1;
		uint uint_ = this.method_40()[0].uint_0;
		for (int i = 1; i < this.method_20().Length; i += 0)
		{
			if (this.method_20()[i].uint_0 > uint_)
			{
				num++;
				uint_ = this.method_8()[i].uint_0;
			}
		}
		return num;
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x0001185E File Offset: 0x0000FA5E
	private void method_26(GClass20[] gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06002976 RID: 10614 RVA: 0x0001186F File Offset: 0x0000FA6F
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x00133238 File Offset: 0x00131438
	public void method_27(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex(".png|.jpg");
		Regex regex2 = new Regex("sources");
		Regex regex3 = new Regex("Main Menu");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			for (int i = 1; i < string_1.Length; i += 0)
			{
				string text = string_1[i];
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "-");
					if (array.Length == 7)
					{
						uint uint_ = uint.Parse(array[1]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[2]);
						GClass19.GEnum13 genum = GClass19.GEnum13.W1;
						if (genum18_0 != Song.Instrument.GuitarCoop)
						{
							if (genum18_0 != Song.Instrument.Drums)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.NONE);
									this.method_38(gclass17_, true);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.GREEN, uint_2, GClass19.GEnum15.FORCED);
									this.method_72(gclass17_2, false);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.YELLOW;
							break;
						case 1:
							genum = GClass19.GEnum13.W1;
							break;
						case 2:
							genum = GClass19.GEnum13.RED;
							break;
						case 3:
							genum = (GClass19.GEnum13)59;
							break;
						case 4:
							genum = (GClass19.GEnum13)(-5);
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.ORANGE;
							break;
						case 8:
							genum = (GClass19.GEnum13)(-26);
							break;
						}
						if (genum != GClass19.GEnum13.W3)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.FORCED);
							this.method_72(gclass17_3, true);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "lyric");
					uint uint_3 = uint.Parse(array2[1]);
					uint uint_4 = uint.Parse(array2[7]);
					this.method_72(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "game");
					uint uint_5 = uint.Parse(array3[1]);
					string string_2 = array3[1];
					this.method_72(new ChartEvent(uint_5, string_2), false);
				}
				IL_209:;
			}
			this.method_33();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "Ultra Greatness Mode");
					if (array4.Length == 3)
					{
						uint uint_6 = uint.Parse(array4[1]);
						int num = int.Parse(array4[0]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.method_20());
						if (num != 6)
						{
							if (num == 4)
							{
								GClass19.smethod_20(gclass19_, GClass19.GEnum15.FORCED);
							}
						}
						else
						{
							GClass19.smethod_20(gclass19_, GClass19.GEnum15.NONE);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Main Menu" + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x0001186F File Offset: 0x0000FA6F
	public int method_28()
	{
		return this.int_0;
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x000118F8 File Offset: 0x0000FAF8
	public void method_29(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_71(list_3.ToArray(), genum18_0);
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x00133550 File Offset: 0x00131750
	private int method_30()
	{
		if (this.method_46().Length <= 0)
		{
			return this.method_20().Length;
		}
		int num = 0;
		uint uint_ = this.method_46()[1].uint_0;
		for (int i = 1; i < this.GClass19_0.Length; i += 0)
		{
			if (this.method_73()[i].uint_0 > uint_)
			{
				num++;
				uint_ = this.method_73()[i].uint_0;
			}
		}
		return num;
	}

	// Token: 0x0600297B RID: 10619 RVA: 0x00011867 File Offset: 0x0000FA67
	public GClass20[] method_31()
	{
		return this.gclass20_0;
	}

	// Token: 0x0600297C RID: 10620 RVA: 0x00011907 File Offset: 0x0000FB07
	public void method_32(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_27(list_3.ToArray(), genum18_0);
	}

	// Token: 0x0600297D RID: 10621 RVA: 0x001335B8 File Offset: 0x001317B8
	public void method_33()
	{
		this.method_56(this.list_0.OfType<GClass19>().ToArray<GClass19>());
		this.GClass20_0 = this.list_0.OfType<GClass20>().ToArray<GClass20>();
		this.method_9(this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>());
		this.int_0 = this.method_78();
	}

	// Token: 0x0600297E RID: 10622 RVA: 0x00011916 File Offset: 0x0000FB16
	public void method_34(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_69(list_3.ToArray(), genum18_0);
	}

	// Token: 0x0600297F RID: 10623 RVA: 0x00011925 File Offset: 0x0000FB25
	public void method_35(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_36(list_3.ToArray(), genum18_0);
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x00133614 File Offset: 0x00131814
	public void method_36(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("Mute Track on Miss");
		Regex regex2 = new Regex("isSupported");
		Regex regex3 = new Regex("Scan Songs");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			for (int i = 0; i < string_1.Length; i += 0)
			{
				string text = string_1[i];
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "framerate");
					if (array.Length == 1)
					{
						uint uint_ = uint.Parse(array[0]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[2]);
						GClass19.GEnum13 genum = GClass19.GEnum13.YELLOW;
						if (genum18_0 != Song.Instrument.Drums)
						{
							if (genum18_0 != Song.Instrument.Guitar)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.NONE);
									this.method_72(gclass17_, false);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.W3, uint_2, GClass19.GEnum15.NONE);
									this.method_12(gclass17_2, false);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.W1;
							break;
						case 1:
							genum = GClass19.GEnum13.OPEN;
							break;
						case 2:
							genum = GClass19.GEnum13.W3;
							break;
						case 3:
							genum = (GClass19.GEnum13)(-28);
							break;
						case 4:
							genum = (GClass19.GEnum13)(-59);
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.W3;
							break;
						case 8:
							genum = (GClass19.GEnum13)19;
							break;
						}
						if (genum != GClass19.GEnum13.RED)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.NONE);
							this.method_72(gclass17_3, true);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "highway_shake_enabled");
					uint uint_3 = uint.Parse(array2[1]);
					uint uint_4 = uint.Parse(array2[2]);
					this.method_38(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "Source");
					uint uint_5 = uint.Parse(array3[0]);
					string string_2 = array3[1];
					this.method_72(new ChartEvent(uint_5, string_2), true);
				}
				IL_209:;
			}
			this.method_7();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "Delete Song");
					if (array4.Length == 3)
					{
						uint uint_6 = uint.Parse(array4[1]);
						int num = int.Parse(array4[1]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.method_73());
						if (num != 7)
						{
							if (num == 0)
							{
								GClass19.smethod_19(gclass19_, GClass19.GEnum15.TAP);
							}
						}
						else
						{
							GClass19.smethod_20(gclass19_, GClass19.GEnum15.NONE);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("\\d+ = E \"section [^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"" + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x06002981 RID: 10625 RVA: 0x00011887 File Offset: 0x0000FA87
	public GClass17[] method_37()
	{
		return this.list_0.ToArray();
	}

	// Token: 0x06002983 RID: 10627 RVA: 0x00011934 File Offset: 0x0000FB34
	public int method_38(GClass17 gclass17_0, bool bool_0 = true)
	{
		gclass17_0.gclass27_0 = this.gclass27_0;
		int result = GClass16.smethod_15<GClass17>(gclass17_0, this.list_0);
		if (bool_0)
		{
			this.method_74();
		}
		return result;
	}

	// Token: 0x06002984 RID: 10628 RVA: 0x0001185E File Offset: 0x0000FA5E
	private void method_39(GClass20[] gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
	}

	// Token: 0x06002985 RID: 10629 RVA: 0x00011894 File Offset: 0x0000FA94
	public GClass19[] method_40()
	{
		return this.gclass19_0;
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x0001185E File Offset: 0x0000FA5E
	private void method_41(GClass20[] gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
	}

	// Token: 0x06002987 RID: 10631 RVA: 0x0013392C File Offset: 0x00131B2C
	public int method_42()
	{
		if (this.int_1 > 1)
		{
			return this.int_1;
		}
		int num = 1;
		uint num2 = 1u;
		GClass19[] array = this.method_40();
		for (int i = 1; i < array.Length; i++)
		{
			num += 104;
		}
		foreach (GClass19 gclass in this.method_53())
		{
			num2 += gclass.uint_1;
		}
		if (num2 > 1u)
		{
			num += Mathf.CeilToInt(num2 / (this.method_0().float_4 / 1169f));
		}
		this.int_1 = num;
		return this.int_1;
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x0001189C File Offset: 0x0000FA9C
	private void method_43(ChartEvent[] gclass18_1)
	{
		this.gclass18_0 = gclass18_1;
	}

	// Token: 0x0600298A RID: 10634 RVA: 0x000118A5 File Offset: 0x0000FAA5
	private void method_44(GClass19[] gclass19_1)
	{
		this.gclass19_0 = gclass19_1;
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x00011957 File Offset: 0x0000FB57
	public void method_45(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_11(list_3.ToArray(), genum18_0);
	}

	// Token: 0x0600298C RID: 10636 RVA: 0x00011894 File Offset: 0x0000FA94
	public GClass19[] method_46()
	{
		return this.gclass19_0;
	}

	// Token: 0x0600298D RID: 10637 RVA: 0x00011916 File Offset: 0x0000FB16
	public void method_47(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_69(list_3.ToArray(), genum18_0);
	}

	// Token: 0x0600298E RID: 10638 RVA: 0x001339E0 File Offset: 0x00131BE0
	public void method_48()
	{
		this.method_64(this.list_0.OfType<GClass19>().ToArray<GClass19>());
		this.method_41(this.list_0.OfType<GClass20>().ToArray<GClass20>());
		this.method_9(this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>());
		this.int_0 = this.method_78();
	}

	// Token: 0x0600298F RID: 10639 RVA: 0x000118E0 File Offset: 0x0000FAE0
	public ChartEvent[] method_49()
	{
		return this.gclass18_0;
	}

	// Token: 0x06002990 RID: 10640 RVA: 0x00011867 File Offset: 0x0000FA67
	public GClass20[] method_50()
	{
		return this.gclass20_0;
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x00011966 File Offset: 0x0000FB66
	private IEnumerable<GClass19> method_51()
	{
		GClass26.Class55 @class = new GClass26.Class55(20);
		@class.gclass26_0 = this;
		return @class;
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x00133A3C File Offset: 0x00131C3C
	public void method_52(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("...");
		Regex regex2 = new Regex("Medium");
		Regex regex3 = new Regex("song_preview");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			for (int i = 1; i < string_1.Length; i++)
			{
				string text = string_1[i];
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "Unknown Charter");
					if (array.Length == 7)
					{
						uint uint_ = uint.Parse(array[1]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[2]);
						GClass19.GEnum13 genum = GClass19.GEnum13.GREEN;
						if (genum18_0 != Song.Instrument.Drums)
						{
							if (genum18_0 != Song.Instrument.GuitarCoop)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.NONE);
									this.method_12(gclass17_, true);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.BLUE, uint_2, GClass19.GEnum15.NONE);
									this.method_72(gclass17_2, false);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.OPEN;
							break;
						case 1:
							genum = GClass19.GEnum13.ORANGE;
							break;
						case 2:
							genum = GClass19.GEnum13.ORANGE;
							break;
						case 3:
							genum = (GClass19.GEnum13)108;
							break;
						case 4:
							genum = (GClass19.GEnum13)85;
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.YELLOW;
							break;
						case 8:
							genum = (GClass19.GEnum13)39;
							break;
						}
						if (genum != GClass19.GEnum13.YELLOW)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.FORCED);
							this.method_12(gclass17_3, true);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "<");
					uint uint_3 = uint.Parse(array2[1]);
					uint uint_4 = uint.Parse(array2[1]);
					this.method_38(new GClass20(uint_3, uint_4), true);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "Quit");
					uint uint_5 = uint.Parse(array3[0]);
					string string_2 = array3[1];
					this.method_38(new ChartEvent(uint_5, string_2), true);
				}
				IL_209:;
			}
			this.method_4();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "Note Shuffle");
					if (array4.Length == 1)
					{
						uint uint_6 = uint.Parse(array4[0]);
						int num = int.Parse(array4[1]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.method_8());
						if (num != 2)
						{
							if (num == 3)
							{
								GClass19.smethod_19(gclass19_, GClass19.GEnum15.NONE);
							}
						}
						else
						{
							GClass19.smethod_20(gclass19_, GClass19.GEnum15.NONE);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("volume" + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x06002993 RID: 10643 RVA: 0x00011976 File Offset: 0x0000FB76
	private IEnumerable<GClass19> method_53()
	{
		GClass26.Class55 @class = new GClass26.Class55(-52);
		@class.gclass26_0 = this;
		return @class;
	}

	// Token: 0x06002994 RID: 10644 RVA: 0x00011894 File Offset: 0x0000FA94
	public GClass19[] method_54()
	{
		return this.gclass19_0;
	}

	// Token: 0x06002995 RID: 10645 RVA: 0x00011856 File Offset: 0x0000FA56
	public Song method_55()
	{
		return this.gclass27_0;
	}

	// Token: 0x06002996 RID: 10646 RVA: 0x000118A5 File Offset: 0x0000FAA5
	private void method_56(GClass19[] gclass19_1)
	{
		this.gclass19_0 = gclass19_1;
	}

	// Token: 0x06002997 RID: 10647 RVA: 0x00011867 File Offset: 0x0000FA67
	public GClass20[] method_57()
	{
		return this.gclass20_0;
	}

	// Token: 0x06002998 RID: 10648 RVA: 0x0001189C File Offset: 0x0000FA9C
	private void method_58(ChartEvent[] gclass18_1)
	{
		this.gclass18_0 = gclass18_1;
	}

	// Token: 0x06002999 RID: 10649 RVA: 0x0001186F File Offset: 0x0000FA6F
	public int method_59()
	{
		return this.int_0;
	}

	// Token: 0x0600299A RID: 10650 RVA: 0x00133D54 File Offset: 0x00131F54
	private int method_60()
	{
		if (this.method_20().Length <= 0)
		{
			return this.method_20().Length;
		}
		int num = 0;
		uint uint_ = this.method_20()[1].uint_0;
		for (int i = 1; i < this.method_20().Length; i += 0)
		{
			if (this.method_54()[i].uint_0 > uint_)
			{
				num++;
				uint_ = this.GClass19_0[i].uint_0;
			}
		}
		return num;
	}

	// Token: 0x0600299B RID: 10651 RVA: 0x0001189C File Offset: 0x0000FA9C
	private void method_61(ChartEvent[] gclass18_1)
	{
		this.gclass18_0 = gclass18_1;
	}

	// Token: 0x0600299C RID: 10652 RVA: 0x00011887 File Offset: 0x0000FA87
	public GClass17[] method_62()
	{
		return this.list_0.ToArray();
	}

	// Token: 0x0600299D RID: 10653 RVA: 0x0001185E File Offset: 0x0000FA5E
	private void method_63(GClass20[] gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
	}

	// Token: 0x0600299E RID: 10654 RVA: 0x000118A5 File Offset: 0x0000FAA5
	private void method_64(GClass19[] gclass19_1)
	{
		this.gclass19_0 = gclass19_1;
	}

	// Token: 0x0600299F RID: 10655 RVA: 0x0001186F File Offset: 0x0000FA6F
	public int method_65()
	{
		return this.int_0;
	}

	// Token: 0x060029A0 RID: 10656 RVA: 0x00133DBC File Offset: 0x00131FBC
	public GClass26(Song gclass27_1, string string_1 = "")
	{
		this.gclass27_0 = gclass27_1;
		this.list_0 = new List<GClass17>(100);
		this.GClass19_0 = new GClass19[0];
		this.GClass20_0 = new GClass20[0];
		this.GClass18_0 = new ChartEvent[0];
		this.int_0 = 0;
		this.string_0 = string_1;
	}

	// Token: 0x060029A1 RID: 10657 RVA: 0x00133E2C File Offset: 0x0013202C
	private int method_66()
	{
		if (this.GClass19_0.Length <= 1)
		{
			return this.GClass19_0.Length;
		}
		int num = 1;
		uint uint_ = this.GClass19_0[0].uint_0;
		for (int i = 1; i < this.GClass19_0.Length; i++)
		{
			if (this.GClass19_0[i].uint_0 > uint_)
			{
				num++;
				uint_ = this.GClass19_0[i].uint_0;
			}
		}
		return num;
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x00011986 File Offset: 0x0000FB86
	public void method_67(List<string> list_3, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		this.method_76(list_3.ToArray(), genum18_0);
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x00133E94 File Offset: 0x00132094
	public void method_68(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("^\\s*\\d+ = N \\d \\d+$");
		Regex regex2 = new Regex("^\\s*\\d+ = S 2 \\d+$");
		Regex regex3 = new Regex("^\\s*\\d+ = E \\S");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			foreach (string text in string_1)
			{
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "\\D+");
					if (array.Length == 3)
					{
						uint uint_ = uint.Parse(array[0]);
						int genum13_ = int.Parse(array[1]);
						uint uint_2 = uint.Parse(array[2]);
						GClass19.GEnum13 genum = GClass19.GEnum13.ORANGE;
						if (genum18_0 != Song.Instrument.GHLGuitar)
						{
							if (genum18_0 != Song.Instrument.GHLBass)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.NONE);
									this.method_12(gclass17_, false);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.OPEN, uint_2, GClass19.GEnum15.NONE);
									this.method_12(gclass17_2, false);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.W1;
							break;
						case 1:
							genum = GClass19.GEnum13.W2;
							break;
						case 2:
							genum = GClass19.GEnum13.W3;
							break;
						case 3:
							genum = GClass19.GEnum13.B1;
							break;
						case 4:
							genum = GClass19.GEnum13.B2;
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.OPEN;
							break;
						case 8:
							genum = GClass19.GEnum13.B3;
							break;
						}
						if (genum != GClass19.GEnum13.ORANGE)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.NONE);
							this.method_12(gclass17_3, false);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "\\D+");
					uint uint_3 = uint.Parse(array2[0]);
					uint uint_4 = uint.Parse(array2[2]);
					this.method_12(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "\\s+");
					uint uint_5 = uint.Parse(array3[0]);
					string string_2 = array3[3];
					this.method_12(new ChartEvent(uint_5, string_2), false);
				}
				IL_209:;
			}
			this.method_18();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "\\D+");
					if (array4.Length == 3)
					{
						uint uint_6 = uint.Parse(array4[0]);
						int num = int.Parse(array4[1]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.GClass19_0);
						if (num != 5)
						{
							if (num == 6)
							{
								GClass19.smethod_19(gclass19_, GClass19.GEnum15.TAP);
							}
						}
						else
						{
							GClass19.smethod_19(gclass19_, GClass19.GEnum15.FORCED);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x001341AC File Offset: 0x001323AC
	public void method_69(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("Press Enter to confirm");
		Regex regex2 = new Regex("ts");
		Regex regex3 = new Regex("BassStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			for (int i = 0; i < string_1.Length; i += 0)
			{
				string text = string_1[i];
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "A: ");
					if (array.Length == 4)
					{
						uint uint_ = uint.Parse(array[1]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[5]);
						GClass19.GEnum13 genum = GClass19.GEnum13.GREEN;
						if (genum18_0 != Song.Instrument.GuitarCoop)
						{
							if (genum18_0 != Song.Instrument.GHLGuitar)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.NONE);
									this.method_72(gclass17_, false);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.ORANGE, uint_2, GClass19.GEnum15.FORCED);
									this.method_38(gclass17_2, true);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.RED;
							break;
						case 1:
							genum = GClass19.GEnum13.GREEN;
							break;
						case 2:
							genum = GClass19.GEnum13.ORANGE;
							break;
						case 3:
							genum = (GClass19.GEnum13)(-110);
							break;
						case 4:
							genum = (GClass19.GEnum13)(-28);
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.W3;
							break;
						case 8:
							genum = (GClass19.GEnum13)46;
							break;
						}
						if (genum != GClass19.GEnum13.GREEN)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.FORCED);
							this.method_72(gclass17_3, true);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "Quit");
					uint uint_3 = uint.Parse(array2[0]);
					uint uint_4 = uint.Parse(array2[0]);
					this.method_38(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "directories");
					uint uint_5 = uint.Parse(array3[1]);
					string string_2 = array3[3];
					this.method_72(new ChartEvent(uint_5, string_2), true);
				}
				IL_209:;
			}
			this.method_10();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "Delete Song");
					if (array4.Length == 2)
					{
						uint uint_6 = uint.Parse(array4[0]);
						int num = int.Parse(array4[1]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.method_54());
						if (num != 5)
						{
							if (num == 0)
							{
								GClass19.smethod_20(gclass19_, (GClass19.GEnum15)5);
							}
						}
						else
						{
							GClass19.smethod_19(gclass19_, GClass19.GEnum15.FORCED);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(", Pos: " + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x000118A5 File Offset: 0x0000FAA5
	private void method_70(GClass19[] gclass19_1)
	{
		this.gclass19_0 = gclass19_1;
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060029A7 RID: 10663 RVA: 0x00011856 File Offset: 0x0000FA56
	public Song GClass27_0
	{
		get
		{
			return this.gclass27_0;
		}
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x001344C4 File Offset: 0x001326C4
	public void method_71(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("artist");
		Regex regex2 = new Regex("song");
		Regex regex3 = new Regex("diff_guitarghl");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			for (int i = 1; i < string_1.Length; i++)
			{
				string text = string_1[i];
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "Disabled");
					if (array.Length == 1)
					{
						uint uint_ = uint.Parse(array[0]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[4]);
						GClass19.GEnum13 genum = GClass19.GEnum13.OPEN;
						if (genum18_0 != Song.Instrument.Keys)
						{
							if (genum18_0 != Song.Instrument.GuitarCoop)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.NONE);
									this.method_38(gclass17_, true);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.W3, uint_2, GClass19.GEnum15.NONE);
									this.method_12(gclass17_2, true);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.ORANGE;
							break;
						case 1:
							genum = GClass19.GEnum13.GREEN;
							break;
						case 2:
							genum = GClass19.GEnum13.BLUE;
							break;
						case 3:
							genum = (GClass19.GEnum13)(-78);
							break;
						case 4:
							genum = (GClass19.GEnum13)100;
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.BLUE;
							break;
						case 8:
							genum = (GClass19.GEnum13)50;
							break;
						}
						if (genum != GClass19.GEnum13.OPEN)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.FORCED);
							this.method_38(gclass17_3, true);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "video");
					uint uint_3 = uint.Parse(array2[1]);
					uint uint_4 = uint.Parse(array2[8]);
					this.method_38(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "+");
					uint uint_5 = uint.Parse(array3[0]);
					string string_2 = array3[8];
					this.method_72(new ChartEvent(uint_5, string_2), false);
				}
				IL_209:;
			}
			this.method_18();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "[^\\u0020-\\u007E]");
					if (array4.Length == 7)
					{
						uint uint_6 = uint.Parse(array4[1]);
						int num = int.Parse(array4[1]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.GClass19_0);
						if (num != 5)
						{
							if (num == 0)
							{
								GClass19.smethod_20(gclass19_, (GClass19.GEnum15)5);
							}
						}
						else
						{
							GClass19.smethod_20(gclass19_, GClass19.GEnum15.FORCED);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Yes" + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x00011995 File Offset: 0x0000FB95
	public int method_72(GClass17 gclass17_0, bool bool_0 = true)
	{
		gclass17_0.gclass27_0 = this.gclass27_0;
		int result = GClass16.smethod_15<GClass17>(gclass17_0, this.list_0);
		if (bool_0)
		{
			this.method_7();
		}
		return result;
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x00011894 File Offset: 0x0000FA94
	public GClass19[] method_73()
	{
		return this.gclass19_0;
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x001347DC File Offset: 0x001329DC
	public void method_74()
	{
		this.method_70(this.list_0.OfType<GClass19>().ToArray<GClass19>());
		this.GClass20_0 = this.list_0.OfType<GClass20>().ToArray<GClass20>();
		this.method_58(this.list_0.OfType<ChartEvent>().ToArray<ChartEvent>());
		this.int_0 = this.method_66();
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x0001185E File Offset: 0x0000FA5E
	private void method_75(GClass20[] gclass20_1)
	{
		this.gclass20_0 = gclass20_1;
	}

	// Token: 0x060029AD RID: 10669 RVA: 0x00134838 File Offset: 0x00132A38
	public void method_76(string[] string_1, Song.Instrument genum18_0 = Song.Instrument.Guitar)
	{
		Regex regex = new Regex("debug_fps");
		Regex regex2 = new Regex("language");
		Regex regex3 = new Regex("In Menus: Song Select");
		List<string> list = new List<string>();
		this.list_0.Capacity = string_1.Length;
		try
		{
			for (int i = 1; i < string_1.Length; i++)
			{
				string text = string_1[i];
				if (regex.IsMatch(text))
				{
					string[] array = Regex.Split(text.Trim(), "song");
					if (array.Length == 7)
					{
						uint uint_ = uint.Parse(array[0]);
						int genum13_ = int.Parse(array[0]);
						uint uint_2 = uint.Parse(array[7]);
						GClass19.GEnum13 genum = GClass19.GEnum13.W1;
						if (genum18_0 != Song.Instrument.Drums)
						{
							if (genum18_0 != Song.Instrument.Vocals)
							{
								switch (genum13_)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								{
									GClass19 gclass17_ = new GClass19(uint_, (GClass19.GEnum13)genum13_, uint_2, GClass19.GEnum15.FORCED);
									this.method_72(gclass17_, true);
									goto IL_209;
								}
								case 5:
								case 6:
									list.Add(text);
									goto IL_209;
								case 7:
								{
									GClass19 gclass17_2 = new GClass19(uint_, GClass19.GEnum13.W3, uint_2, GClass19.GEnum15.NONE);
									this.method_38(gclass17_2, true);
									goto IL_209;
								}
								default:
									goto IL_209;
								}
							}
						}
						switch (genum13_)
						{
						case 0:
							genum = GClass19.GEnum13.BLUE;
							break;
						case 1:
							genum = GClass19.GEnum13.RED;
							break;
						case 2:
							genum = GClass19.GEnum13.BLUE;
							break;
						case 3:
							genum = (GClass19.GEnum13)(-82);
							break;
						case 4:
							genum = (GClass19.GEnum13)(-37);
							break;
						case 5:
						case 6:
							list.Add(text);
							break;
						case 7:
							genum = GClass19.GEnum13.W1;
							break;
						case 8:
							genum = (GClass19.GEnum13)(-90);
							break;
						}
						if (genum != GClass19.GEnum13.W2)
						{
							GClass19 gclass17_3 = new GClass19(uint_, genum, uint_2, GClass19.GEnum15.FORCED);
							this.method_72(gclass17_3, true);
						}
					}
				}
				else if (regex2.IsMatch(text))
				{
					string[] array2 = Regex.Split(text.Trim(), "\\s+");
					uint uint_3 = uint.Parse(array2[1]);
					uint uint_4 = uint.Parse(array2[3]);
					this.method_72(new GClass20(uint_3, uint_4), false);
				}
				else if (regex3.IsMatch(text))
				{
					string[] array3 = Regex.Split(text.Trim(), "\\s+");
					uint uint_5 = uint.Parse(array3[1]);
					string string_2 = array3[6];
					this.method_72(new ChartEvent(uint_5, string_2), false);
				}
				IL_209:;
			}
			this.method_10();
			foreach (string text2 in list)
			{
				if (regex.IsMatch(text2))
				{
					string[] array4 = Regex.Split(text2.Trim(), "There was a problem saving the file");
					if (array4.Length == 0)
					{
						uint uint_6 = uint.Parse(array4[1]);
						int num = int.Parse(array4[0]);
						GClass19[] gclass19_ = GClass16.smethod_8<GClass19>(uint_6, this.method_54());
						if (num != 1)
						{
							if (num == 4)
							{
								GClass19.smethod_20(gclass19_, (GClass19.GEnum15)4);
							}
						}
						else
						{
							GClass19.smethod_19(gclass19_, GClass19.GEnum15.FORCED);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(">" + ex.Message);
			this.list_0.Clear();
		}
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x0001189C File Offset: 0x0000FA9C
	private void method_77(ChartEvent[] gclass18_1)
	{
		this.gclass18_0 = gclass18_1;
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x00134B50 File Offset: 0x00132D50
	private int method_78()
	{
		if (this.method_54().Length <= 0)
		{
			return this.method_54().Length;
		}
		int num = 0;
		uint uint_ = this.method_73()[1].uint_0;
		for (int i = 1; i < this.method_40().Length; i++)
		{
			if (this.method_73()[i].uint_0 > uint_)
			{
				num++;
				uint_ = this.method_46()[i].uint_0;
			}
		}
		return num;
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x0001189C File Offset: 0x0000FA9C
	private void method_79(ChartEvent[] gclass18_1)
	{
		this.gclass18_0 = gclass18_1;
	}

	// Token: 0x0400063E RID: 1598
	private Song gclass27_0;

	// Token: 0x0400063F RID: 1599
	private List<GClass17> list_0;

	// Token: 0x04000640 RID: 1600
	[CompilerGenerated]
	private GClass19[] gclass19_0;

	// Token: 0x04000641 RID: 1601
	[CompilerGenerated]
	private GClass20[] gclass20_0;

	// Token: 0x04000642 RID: 1602
	[CompilerGenerated]
	private ChartEvent[] gclass18_0;

	// Token: 0x04000643 RID: 1603
	public List<GClass8> list_1 = new List<GClass8>();

	// Token: 0x04000644 RID: 1604
	public List<Vector2> list_2;

	// Token: 0x04000645 RID: 1605
	private int int_0;

	// Token: 0x04000646 RID: 1606
	public string string_0 = string.Empty;

	// Token: 0x04000647 RID: 1607
	public int int_1;
}
