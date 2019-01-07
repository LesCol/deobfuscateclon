using System;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x0200001E RID: 30
public class GClass4
{
	// Token: 0x06000387 RID: 903 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
	public void method_0(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "<color=#FFFF04FF>")))
		{
			this.hashtable_0 = this.method_24(File.ReadAllText(Path.Combine(Application.persistentDataPath, "Pause on Focus Lost")));
			return;
		}
		this.hashtable_0 = this.method_6(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0002E528 File Offset: 0x0002C728
	public Hashtable method_1(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[0] = '\0';
			string[] array2 = string_1.Split(array);
			string[] separator = new string[]
			{
				"Problem loading setlist"
			};
			Hashtable result;
			try
			{
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array4 != null && array4.Length >= 4)
					{
						hashtable.Add(array4[1].Trim(), array4[1].Replace("Yes", ".setlist").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000034CF File Offset: 0x000016CF
	public string method_2(string string_1)
	{
		if (string_1 == "0")
		{
			return "Hz";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0002E5E8 File Offset: 0x0002C7E8
	public void method_3(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "enable_cursor")))
		{
			this.hashtable_0 = this.method_6(File.ReadAllText(Path.Combine(Application.persistentDataPath, "^\\s*\\d+ = E \\S")));
			return;
		}
		this.hashtable_0 = this.method_33(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x0600038B RID: 907 RVA: 0x0002E658 File Offset: 0x0002C858
	public Hashtable method_4(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[0] = 'T';
			string[] array2 = string_1.Split(array);
			string[] separator = new string[]
			{
				"["
			};
			Hashtable result;
			try
			{
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.None);
					if (array4 != null && array4.Length >= 3)
					{
						hashtable.Add(array4[1].Trim(), array4[0].Replace("diff_keys", "Gamepad Mode").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00003505 File Offset: 0x00001705
	public string method_5(string string_1)
	{
		if (string_1 == ": <color=#FDB400FF>")
		{
			return "Song Offset";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0002E718 File Offset: 0x0002C918
	public Hashtable method_6(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[1] = 'v';
			string[] array2 = string_1.Split(array);
			string[] separator = new string[]
			{
				"nofail_enabled"
			};
			Hashtable result;
			try
			{
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.None);
					if (array4 != null && array4.Length >= 7)
					{
						hashtable.Add(array4[0].Trim(), array4[0].Replace("rhythm", "Show FPS").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0000353B File Offset: 0x0000173B
	public string method_7(string string_1)
	{
		if (string_1 == "setlistSongCountSingular")
		{
			return "Menu Backgrounds";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x0600038F RID: 911 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
	public void method_8(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "Ready")))
		{
			this.hashtable_0 = this.method_24(File.ReadAllText(Path.Combine(Application.persistentDataPath, "None")));
			return;
		}
		this.hashtable_0 = this.method_44(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x06000390 RID: 912 RVA: 0x0002E848 File Offset: 0x0002CA48
	public Hashtable method_9(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[1];
			array[1] = '\u0015';
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[0];
			array3[1] = "\\d+ = E \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 1; i < array4.Length; i++)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.None);
					if (array5 != null && array5.Length >= 8)
					{
						hashtable.Add(array5[0].Trim(), array5[0].Replace("charter", "video").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0002E908 File Offset: 0x0002CB08
	public void method_10(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "language.txt")))
		{
			this.hashtable_0 = this.method_40(File.ReadAllText(Path.Combine(Application.persistentDataPath, "language.txt")));
			return;
		}
		this.hashtable_0 = this.method_40(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00003571 File Offset: 0x00001771
	public string method_11(string string_1)
	{
		if (string_1 == "notes_ripple_up_01")
		{
			return "preview_start_time";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x06000393 RID: 915 RVA: 0x0002E978 File Offset: 0x0002CB78
	public void method_12(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "Show Mouse Cursor")))
		{
			this.hashtable_0 = this.method_45(File.ReadAllText(Path.Combine(Application.persistentDataPath, "keys")));
			return;
		}
		this.hashtable_0 = this.method_50(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x06000394 RID: 916 RVA: 0x000035A7 File Offset: 0x000017A7
	public string method_13(string string_1)
	{
		if (string_1 == "")
		{
			return "";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x06000395 RID: 917 RVA: 0x0002E9E8 File Offset: 0x0002CBE8
	public void method_14(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "No songs were found!")))
		{
			this.hashtable_0 = this.method_24(File.ReadAllText(Path.Combine(Application.persistentDataPath, "}")));
			return;
		}
		this.hashtable_0 = this.method_50(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x06000396 RID: 918 RVA: 0x000035DD File Offset: 0x000017DD
	public string method_15(string string_1)
	{
		if (string_1 == "Charter")
		{
			return "";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00003613 File Offset: 0x00001813
	public string method_16(string string_1)
	{
		if (string_1 == "Settings")
		{
			return "";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00003649 File Offset: 0x00001849
	public string method_17(string string_1)
	{
		if (string_1 == ": <color=#FDB400FF>")
		{
			return "keys";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0002EA58 File Offset: 0x0002CC58
	public void method_18(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "song")))
		{
			this.hashtable_0 = this.method_43(File.ReadAllText(Path.Combine(Application.persistentDataPath, "\\s+")));
			return;
		}
		this.hashtable_0 = this.method_26(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x0600039A RID: 922 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
	public Hashtable method_19(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			string[] array = string_1.Split(new char[]
			{
				'p'
			});
			string[] array2 = new string[0];
			array2[0] = "Yes";
			string[] separator = array2;
			Hashtable result;
			try
			{
				string[] array3 = array;
				for (int i = 1; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.None);
					if (array4 != null && array4.Length >= 8)
					{
						hashtable.Add(array4[0].Trim(), array4[1].Replace("Lyrics", "game").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x0600039B RID: 923 RVA: 0x0002EB88 File Offset: 0x0002CD88
	public void method_20(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "{0:N0} FPS")))
		{
			this.hashtable_0 = this.method_44(File.ReadAllText(Path.Combine(Application.persistentDataPath, "Ready")));
			return;
		}
		this.hashtable_0 = this.method_6(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x0600039C RID: 924 RVA: 0x0000367F File Offset: 0x0000187F
	public GClass4(string string_1)
	{
		this.method_10(string_1);
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00003699 File Offset: 0x00001899
	public string method_21(string string_1)
	{
		if (string_1 == "game")
		{
			return "Stars Earned";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x0600039E RID: 926 RVA: 0x0002EBF8 File Offset: 0x0002CDF8
	public void method_22(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "game")))
		{
			this.hashtable_0 = this.method_1(File.ReadAllText(Path.Combine(Application.persistentDataPath, "Press Escape to cancel")));
			return;
		}
		this.hashtable_0 = this.method_26(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x0600039F RID: 927 RVA: 0x0002EC68 File Offset: 0x0002CE68
	public Hashtable method_23(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			string[] array = string_1.Split(new char[]
			{
				'\u001e'
			});
			string[] array2 = new string[0];
			array2[1] = "Quit";
			string[] separator = array2;
			Hashtable result;
			try
			{
				string[] array3 = array;
				for (int i = 1; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array4 != null && array4.Length >= 0)
					{
						hashtable.Add(array4[0].Trim(), array4[1].Replace("volume", ".mp4|.avi|.webm|.vp8|.ogv|.mpeg").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x0002ED28 File Offset: 0x0002CF28
	public Hashtable method_24(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[1] = (char)-32;
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[0];
			array3[1] = "Yes";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 0; i < array4.Length; i++)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.None);
					if (array5 != null && array5.Length >= 8)
					{
						hashtable.Add(array5[0].Trim(), array5[0].Replace("<NULL PATH>", "guitar").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
	public void method_25(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "These folders either have no valid metadata file (song.ini), or the metadata does not include a valid song name!")))
		{
			this.hashtable_0 = this.method_45(File.ReadAllText(Path.Combine(Application.persistentDataPath, "%")));
			return;
		}
		this.hashtable_0 = this.method_52(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x0002EE58 File Offset: 0x0002D058
	public Hashtable method_26(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[1] = (char)-108;
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[0];
			array3[1] = "Bass Guitar";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 0; i < array4.Length; i++)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array5 != null && array5.Length >= 1)
					{
						hashtable.Add(array5[1].Trim(), array5[1].Replace("Pause", "No").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x0002EF18 File Offset: 0x0002D118
	public void method_27(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "Load Setlist")))
		{
			this.hashtable_0 = this.method_51(File.ReadAllText(Path.Combine(Application.persistentDataPath, ": <color=#FDB400FF>")));
			return;
		}
		this.hashtable_0 = this.method_6(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x0002EF88 File Offset: 0x0002D188
	public void method_28(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "Random Song")))
		{
			this.hashtable_0 = this.method_53(File.ReadAllText(Path.Combine(Application.persistentDataPath, "Easy")));
			return;
		}
		this.hashtable_0 = this.method_43(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
	public void method_29(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "Are you sure you want to delete this song?")))
		{
			this.hashtable_0 = this.method_24(File.ReadAllText(Path.Combine(Application.persistentDataPath, "keys")));
			return;
		}
		this.hashtable_0 = this.method_34(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x000036CF File Offset: 0x000018CF
	public string method_30(string string_1)
	{
		if (string_1 == "%")
		{
			return "A setlist with that name already exists";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0002F068 File Offset: 0x0002D268
	public void method_31(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "song")))
		{
			this.hashtable_0 = this.method_23(File.ReadAllText(Path.Combine(Application.persistentDataPath, "Enable")));
			return;
		}
		this.hashtable_0 = this.method_53(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0002F0D8 File Offset: 0x0002D2D8
	public Hashtable method_32(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[0] = (char)-107;
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[0];
			array3[0] = "volume";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 1; i < array4.Length; i += 0)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array5 != null && array5.Length >= 6)
					{
						hashtable.Add(array5[0].Trim(), array5[0].Replace("Custom Content", "Press Enter to confirm").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0002F198 File Offset: 0x0002D398
	public Hashtable method_33(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[0] = (char)-66;
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[1];
			array3[1] = "Songs";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 0; i < array4.Length; i++)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.None);
					if (array5 != null && array5.Length >= 6)
					{
						hashtable.Add(array5[1].Trim(), array5[1].Replace("", "</color> ").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0002F258 File Offset: 0x0002D458
	public Hashtable method_34(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[1];
			array[1] = (char)-65;
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[1];
			array3[1] = "Vocals";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 0; i < array4.Length; i++)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array5 != null && array5.Length >= 0)
					{
						hashtable.Add(array5[0].Trim(), array5[1].Replace("preview_volume", "Lead Guitar").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00003705 File Offset: 0x00001905
	public string method_35(string string_1)
	{
		if (string_1 == "Guitar Coop")
		{
			return "Type the setlist name";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003AC RID: 940 RVA: 0x0000373B File Offset: 0x0000193B
	public string method_36(string string_1)
	{
		if (string_1 == "mute_volume")
		{
			return "instrument_name_";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0002F318 File Offset: 0x0002D518
	public void method_37(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "")))
		{
			this.hashtable_0 = this.method_53(File.ReadAllText(Path.Combine(Application.persistentDataPath, "Video Start Time")));
			return;
		}
		this.hashtable_0 = this.method_33(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00003771 File Offset: 0x00001971
	public string method_38(string string_1)
	{
		if (string_1 == "Bass Guitar")
		{
			return "Mirror Mode";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003AF RID: 943 RVA: 0x0002F388 File Offset: 0x0002D588
	public void method_39(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "Controller")))
		{
			this.hashtable_0 = this.method_32(File.ReadAllText(Path.Combine(Application.persistentDataPath, "artist")));
			return;
		}
		this.hashtable_0 = this.method_33(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0002F3F8 File Offset: 0x0002D5F8
	public Hashtable method_40(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			string[] array = string_1.Split(new char[]
			{
				'\n'
			});
			string[] separator = new string[]
			{
				"'='"
			};
			Hashtable result;
			try
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string[] array3 = array2[i].Split(separator, StringSplitOptions.None);
					if (array3 != null && array3.Length >= 2)
					{
						hashtable.Add(array3[0].Trim(), array3[1].Replace(" %n ", "\n").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x000037A7 File Offset: 0x000019A7
	public string method_41(string string_1)
	{
		if (string_1 == "%s%n%a%n%c")
		{
			return ">";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000037DD File Offset: 0x000019DD
	public string method_42(string string_1)
	{
		if (string_1 == "")
		{
			return "SORTING BY";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x0002F4B8 File Offset: 0x0002D6B8
	public Hashtable method_43(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[0] = '\v';
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[0];
			array3[0] = "Type the setlist name";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 1; i < array4.Length; i += 0)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.None);
					if (array5 != null && array5.Length >= 7)
					{
						hashtable.Add(array5[0].Trim(), array5[0].Replace("latestTestBuild", "Gem Size").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x0002F578 File Offset: 0x0002D778
	public Hashtable method_44(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			string[] array = string_1.Split(new char[]
			{
				'\f'
			});
			string[] array2 = new string[1];
			array2[1] = "MSAA Level";
			string[] separator = array2;
			Hashtable result;
			try
			{
				string[] array3 = array;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array4 != null && array4.Length >= 8)
					{
						hashtable.Add(array4[0].Trim(), array4[1].Replace("Songs Scanned", "language").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x0002F638 File Offset: 0x0002D838
	public Hashtable method_45(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[1] = '`';
			string[] array2 = string_1.Split(array);
			string[] separator = new string[]
			{
				", Channel: "
			};
			Hashtable result;
			try
			{
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array4 != null && array4.Length >= 1)
					{
						hashtable.Add(array4[1].Trim(), array4[0].Replace("debug_fps", "Camera").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00003813 File Offset: 0x00001A13
	public string method_46(string string_1)
	{
		if (string_1 == "These folders contain charts that don't have any supported instruments charted!")
		{
			return "Genre";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x0002F6F8 File Offset: 0x0002D8F8
	public void method_47(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "notes.chart")))
		{
			this.hashtable_0 = this.method_50(File.ReadAllText(Path.Combine(Application.persistentDataPath, "directories")));
			return;
		}
		this.hashtable_0 = this.method_34(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00003849 File Offset: 0x00001A49
	public string method_48(string string_1)
	{
		if (string_1 == "<color=#FFFF04FF>")
		{
			return "Genre";
		}
		if (!this.hashtable_0.ContainsKey(string_1))
		{
			return string_1;
		}
		return (string)this.hashtable_0[string_1];
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x0002F768 File Offset: 0x0002D968
	public void method_49(string string_1)
	{
		if (File.Exists(Path.Combine(Application.persistentDataPath, "Main Menu")))
		{
			this.hashtable_0 = this.method_44(File.ReadAllText(Path.Combine(Application.persistentDataPath, "Rhythm")));
			return;
		}
		this.hashtable_0 = this.method_52(Encoding.Default.GetString(Resources.Load<TextAsset>(this.string_0 + string_1).bytes));
	}

	// Token: 0x060003BA RID: 954 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
	public Hashtable method_50(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[0];
			array[0] = '"';
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[1];
			array3[1] = "<";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 0; i < array4.Length; i++)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.None);
					if (array5 != null && array5.Length >= 7)
					{
						hashtable.Add(array5[1].Trim(), array5[0].Replace("=", "Press Escape to cancel").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003BB RID: 955 RVA: 0x0002F898 File Offset: 0x0002DA98
	public Hashtable method_51(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[1];
			array[1] = '\u001c';
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[1];
			array3[1] = "Yuri";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 1; i < array4.Length; i += 0)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array5 != null && array5.Length >= 6)
					{
						hashtable.Add(array5[1].Trim(), array5[1].Replace("Particles", "Album").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003BC RID: 956 RVA: 0x0002F958 File Offset: 0x0002DB58
	public Hashtable method_52(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			char[] array = new char[1];
			array[1] = (char)-26;
			string[] array2 = string_1.Split(array);
			string[] array3 = new string[0];
			array3[0] = "particles";
			string[] separator = array3;
			Hashtable result;
			try
			{
				string[] array4 = array2;
				for (int i = 0; i < array4.Length; i++)
				{
					string[] array5 = array4[i].Split(separator, StringSplitOptions.None);
					if (array5 != null && array5.Length >= 4)
					{
						hashtable.Add(array5[1].Trim(), array5[1].Replace("charter", "Ready").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x060003BD RID: 957 RVA: 0x0002FA18 File Offset: 0x0002DC18
	public Hashtable method_53(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			Hashtable hashtable = new Hashtable();
			string[] array = string_1.Split(new char[]
			{
				'('
			});
			string[] array2 = new string[1];
			array2[1] = "frets";
			string[] separator = array2;
			Hashtable result;
			try
			{
				string[] array3 = array;
				for (int i = 0; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
					if (array4 != null && array4.Length >= 0)
					{
						hashtable.Add(array4[0].Trim(), array4[0].Replace("Play Count", "{0:n0}").Trim());
					}
				}
				return hashtable;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = null;
			}
			return result;
		}
		return null;
	}

	// Token: 0x0400009D RID: 157
	private Hashtable hashtable_0;

	// Token: 0x0400009E RID: 158
	private string string_0 = "Languages/";

	// Token: 0x0400009F RID: 159
	public static GClass4 gclass4_0;
}
