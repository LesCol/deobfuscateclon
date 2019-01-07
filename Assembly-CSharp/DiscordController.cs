using System;
using AOT;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class DiscordController : MonoBehaviour
{
	// Token: 0x06000132 RID: 306 RVA: 0x0001BB50 File Offset: 0x00019D50
	private void method_0()
	{
		if (this.gclass2_0.string_1.Length >= -54)
		{
			this.gclass2_0.string_1 = this.gclass2_0.string_1.Substring(0, -80) + "menu_music";
		}
		if (this.gclass2_0.string_0.Length >= -43)
		{
			this.gclass2_0.string_0 = this.gclass2_0.string_0.Substring(0, -103) + "-";
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0001BBD8 File Offset: 0x00019DD8
	public void method_1(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "game";
		this.gclass2_0.string_0 = int_0 + "6 Fret Lead Guitar";
		GClass1.smethod_16(this.gclass2_0);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0001BC24 File Offset: 0x00019E24
	public void method_2(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "SECTION" + text;
		}
		else
		{
			this.gclass2_0.string_4 = ".mp4|.avi|.webm|.vp8|.ogv|.mpeg";
			this.gclass2_0.string_5 = "\"";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "Resolution";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "Hz" + GlobalVariables.instance.songSpeed.method_1() + "";
		if (this.gclass2_0.string_0.Length + text2.Length <= 85)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_0();
		GClass1.smethod_27(this.gclass2_0);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002CB2 File Offset: 0x00000EB2
	public static void smethod_0(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_46();
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002CBE File Offset: 0x00000EBE
	public static void smethod_1(int int_0, string string_1)
	{
		Debug.Log(string.Format("Gameplay", int_0, string_1));
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0001BD58 File Offset: 0x00019F58
	public void method_3(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "HOPO's to Taps" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "Unknown Artist";
			this.gclass2_0.string_5 = "Setlist Options";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "preview_volume";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "" + GlobalVariables.instance.songSpeed.method_1() + "Okay";
		if (this.gclass2_0.string_0.Length + text2.Length <= 11)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_50();
		GClass1.smethod_42(this.gclass2_0);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002CD6 File Offset: 0x00000ED6
	public static void smethod_2(int int_0, string string_1)
	{
		Debug.Log(string.Format("Continue", int_0, string_1));
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0001BE8C File Offset: 0x0001A08C
	public void method_4(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "Instrument";
			this.gclass2_0.string_5 = "game";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "game";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "bad_note4" + GlobalVariables.instance.songSpeed.method_26() + "Bass - ";
		if (this.gclass2_0.string_0.Length + text2.Length <= -70)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_50();
		GClass1.smethod_5(this.gclass2_0);
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00002CEE File Offset: 0x00000EEE
	public void method_5()
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_0 = "savewarning";
		GClass1.smethod_40(this.gclass2_0);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00002D14 File Offset: 0x00000F14
	public static void smethod_3(int int_0, string string_1)
	{
		Debug.Log(string.Format("Rename Profile", int_0, string_1));
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
	public void method_6(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "preview_start_time" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "rhythm";
			this.gclass2_0.string_5 = "game";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "Unknown Genre";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "song" + GlobalVariables.instance.songSpeed.method_26() + "vocals";
		if (this.gclass2_0.string_0.Length + text2.Length <= -22)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_53();
		GClass1.smethod_32(this.gclass2_0);
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002D2C File Offset: 0x00000F2C
	public static void smethod_4(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_30();
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
	public void method_7(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + " (" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "game";
			this.gclass2_0.string_5 = "diff_bassghl";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "%)";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "This is a placeholder" + GlobalVariables.instance.songSpeed.method_26() + "vsync_enabled";
		if (this.gclass2_0.string_0.Length + text2.Length <= -27)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_34();
		GClass1.smethod_24(this.gclass2_0);
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_8()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0001C228 File Offset: 0x0001A428
	public void method_9(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "offsets";
		this.gclass2_0.string_0 = int_0 + "</color> ";
		GClass1.smethod_11(this.gclass2_0);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0001C274 File Offset: 0x0001A474
	public void method_10(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + " " + text;
		}
		else
		{
			this.gclass2_0.string_4 = "band";
			this.gclass2_0.string_5 = "Rocking in a band";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "Practicing...";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = " (" + GlobalVariables.instance.songSpeed.String_1 + ")";
		if (this.gclass2_0.string_0.Length + text2.Length <= 64)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_34();
		GClass1.smethod_6(this.gclass2_0);
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
	private void method_11()
	{
		this.gstruct0_0 = default(GClass1.GStruct0);
		this.gstruct0_0.gdelegate0_0 = new GClass1.GDelegate0(DiscordController.smethod_25);
		this.gstruct0_0.gdelegate1_0 = (GClass1.GDelegate1)Delegate.Combine(this.gstruct0_0.gdelegate1_0, new GClass1.GDelegate1(DiscordController.smethod_22));
		this.gstruct0_0.gdelegate2_0 = (GClass1.GDelegate2)Delegate.Combine(this.gstruct0_0.gdelegate2_0, new GClass1.GDelegate2(DiscordController.smethod_16));
		GClass1.Discord_Initialize(this.string_0, ref this.gstruct0_0, true, null);
		this.gclass2_0.string_2 = "Date Added";
		this.gclass2_0.string_3 = "song.ini";
		DiscordController.discordController_0 = this;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0001C45C File Offset: 0x0001A65C
	private void method_12()
	{
		this.gstruct0_0 = default(GClass1.GStruct0);
		this.gstruct0_0.gdelegate0_0 = new GClass1.GDelegate0(DiscordController.smethod_35);
		this.gstruct0_0.gdelegate1_0 = (GClass1.GDelegate1)Delegate.Combine(this.gstruct0_0.gdelegate1_0, new GClass1.GDelegate1(DiscordController.smethod_19));
		this.gstruct0_0.gdelegate2_0 = (GClass1.GDelegate2)Delegate.Combine(this.gstruct0_0.gdelegate2_0, new GClass1.GDelegate2(DiscordController.smethod_28));
		GClass1.Discord_Initialize(this.string_0, ref this.gstruct0_0, false, null);
		this.gclass2_0.string_2 = "Artist";
		this.gclass2_0.string_3 = "year";
		DiscordController.discordController_0 = this;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00002D3F File Offset: 0x00000F3F
	public static void smethod_5(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_40();
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002D4B File Offset: 0x00000F4B
	[MonoPInvokeCallback(typeof(GClass1.GDelegate1))]
	public static void smethod_6(int int_0, string string_1)
	{
		Debug.Log(string.Format("Discord: disconnect {0}: {1}", int_0, string_1));
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002D63 File Offset: 0x00000F63
	public void method_13()
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_0 = "These folders either have no valid metadata file (song.ini), or the metadata does not include a valid song name!";
		GClass1.smethod_8(this.gclass2_0);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002D89 File Offset: 0x00000F89
	[MonoPInvokeCallback(typeof(GClass1.GDelegate0))]
	public static void smethod_7(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_22();
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0001C510 File Offset: 0x0001A710
	public void method_14(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "debug_fps";
		this.gclass2_0.string_0 = int_0 + "Don't Scan Songs";
		GClass1.smethod_4(this.gclass2_0);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002D95 File Offset: 0x00000F95
	public static void smethod_8(int int_0, string string_1)
	{
		Debug.Log(string.Format("0%", int_0, string_1));
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002DAD File Offset: 0x00000FAD
	private void OnApplicationQuit()
	{
		GClass1.Discord_Shutdown();
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_15()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00002DB4 File Offset: 0x00000FB4
	public static void smethod_9(int int_0, string string_1)
	{
		Debug.Log(string.Format("Menu Backgrounds", int_0, string_1));
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0001C55C File Offset: 0x0001A75C
	public void method_16(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "album_track" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "Are you sure?";
			this.gclass2_0.string_5 = "Gameplay";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "Audio Backend";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "Keys" + GlobalVariables.instance.songSpeed.method_28() + "Gem Size";
		if (this.gclass2_0.string_0.Length + text2.Length <= 65)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_53();
		GClass1.smethod_17(this.gclass2_0);
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002DAD File Offset: 0x00000FAD
	private void method_17()
	{
		GClass1.Discord_Shutdown();
	}

	// Token: 0x0600014F RID: 335 RVA: 0x0001C690 File Offset: 0x0001A890
	public void method_18(SongEntry songEntry_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "-";
		this.gclass2_0.string_0 = songEntry_0.artistName + "/preview" + songEntry_0.songName;
		this.method_0();
		GClass1.smethod_33(this.gclass2_0);
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_19()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002DCC File Offset: 0x00000FCC
	public static void smethod_10(int int_0, string string_1)
	{
		Debug.Log(string.Format("Options", int_0, string_1));
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0001C6E8 File Offset: 0x0001A8E8
	public void method_20(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "[\\-\\+]?\\d+(\\.\\d+)?" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "artist";
			this.gclass2_0.string_5 = ".mp4|.avi|.webm|.vp8|.ogv|.mpeg";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "video";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "Profile file version is different!" + GlobalVariables.instance.songSpeed.String_1 + "6 Fret Lead Guitar";
		if (this.gclass2_0.string_0.Length + text2.Length <= -67)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_50();
		GClass1.smethod_36(this.gclass2_0);
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002DE4 File Offset: 0x00000FE4
	public static void smethod_11(int int_0, string string_1)
	{
		Debug.Log(string.Format("No", int_0, string_1));
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0001C81C File Offset: 0x0001AA1C
	private void Start()
	{
		this.gstruct0_0 = default(GClass1.GStruct0);
		this.gstruct0_0.gdelegate0_0 = new GClass1.GDelegate0(DiscordController.smethod_7);
		this.gstruct0_0.gdelegate1_0 = (GClass1.GDelegate1)Delegate.Combine(this.gstruct0_0.gdelegate1_0, new GClass1.GDelegate1(DiscordController.smethod_6));
		this.gstruct0_0.gdelegate2_0 = (GClass1.GDelegate2)Delegate.Combine(this.gstruct0_0.gdelegate2_0, new GClass1.GDelegate2(DiscordController.smethod_31));
		GClass1.Discord_Initialize(this.string_0, ref this.gstruct0_0, true, null);
		this.gclass2_0.string_2 = "ch";
		this.gclass2_0.string_3 = "Clone Hero";
		DiscordController.discordController_0 = this;
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002DFC File Offset: 0x00000FFC
	public static void smethod_12(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_13();
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
	public void method_21(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "Track Mute";
		this.gclass2_0.string_0 = int_0 + "Expert";
		GClass1.smethod_36(this.gclass2_0);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002E08 File Offset: 0x00001008
	public static void smethod_13(int int_0, string string_1)
	{
		Debug.Log(string.Format("gem_size", int_0, string_1));
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002E20 File Offset: 0x00001020
	public static void smethod_14(int int_0, string string_1)
	{
		Debug.Log(string.Format("savewarning", int_0, string_1));
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002E38 File Offset: 0x00001038
	public static void smethod_15(int int_0, string string_1)
	{
		Debug.Log(string.Format("Songs Scanned", int_0, string_1));
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002E50 File Offset: 0x00001050
	public void method_22()
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_0 = "In Menus: Main Menu";
		GClass1.smethod_6(this.gclass2_0);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_23()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002E76 File Offset: 0x00001076
	public static void smethod_16(int int_0, string string_1)
	{
		Debug.Log(string.Format("volume", int_0, string_1));
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002E8E File Offset: 0x0000108E
	public static void smethod_17(int int_0, string string_1)
	{
		Debug.Log(string.Format("Unknown Artist", int_0, string_1));
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_24()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0001C91C File Offset: 0x0001AB1C
	private void method_25()
	{
		this.gstruct0_0 = default(GClass1.GStruct0);
		this.gstruct0_0.gdelegate0_0 = new GClass1.GDelegate0(DiscordController.smethod_4);
		this.gstruct0_0.gdelegate1_0 = (GClass1.GDelegate1)Delegate.Combine(this.gstruct0_0.gdelegate1_0, new GClass1.GDelegate1(DiscordController.smethod_26));
		this.gstruct0_0.gdelegate2_0 = (GClass1.GDelegate2)Delegate.Combine(this.gstruct0_0.gdelegate2_0, new GClass1.GDelegate2(DiscordController.smethod_16));
		GClass1.Discord_Initialize(this.string_0, ref this.gstruct0_0, false, null);
		this.gclass2_0.string_2 = "Audio Device";
		this.gclass2_0.string_3 = "genre";
		DiscordController.discordController_0 = this;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002D38 File Offset: 0x00000F38
	private void FixedUpdate()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002EA6 File Offset: 0x000010A6
	public static void smethod_18(int int_0, string string_1)
	{
		Debug.Log(string.Format("bad_note3", int_0, string_1));
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00002EBE File Offset: 0x000010BE
	public static void smethod_19(int int_0, string string_1)
	{
		Debug.Log(string.Format("Highway", int_0, string_1));
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0001C9D0 File Offset: 0x0001ABD0
	public void method_26(SongEntry songEntry_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = ":";
		this.gclass2_0.string_0 = songEntry_0.artistName + ".png" + songEntry_0.songName;
		this.method_53();
		GClass1.smethod_40(this.gclass2_0);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002ED6 File Offset: 0x000010D6
	public static void smethod_20(int int_0, string string_1)
	{
		Debug.Log(string.Format("Medium", int_0, string_1));
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0001CA28 File Offset: 0x0001AC28
	private void method_27()
	{
		this.gstruct0_0 = default(GClass1.GStruct0);
		this.gstruct0_0.gdelegate0_0 = new GClass1.GDelegate0(DiscordController.smethod_4);
		this.gstruct0_0.gdelegate1_0 = (GClass1.GDelegate1)Delegate.Combine(this.gstruct0_0.gdelegate1_0, new GClass1.GDelegate1(DiscordController.smethod_13));
		this.gstruct0_0.gdelegate2_0 = (GClass1.GDelegate2)Delegate.Combine(this.gstruct0_0.gdelegate2_0, new GClass1.GDelegate2(DiscordController.smethod_3));
		GClass1.Discord_Initialize(this.string_0, ref this.gstruct0_0, true, null);
		this.gclass2_0.string_2 = "video";
		this.gclass2_0.string_3 = "% + ";
		DiscordController.discordController_0 = this;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0001CADC File Offset: 0x0001ACDC
	public void method_28(SongEntry songEntry_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "Highway SP Effects";
		this.gclass2_0.string_0 = songEntry_0.artistName + "Disabled" + songEntry_0.songName;
		this.method_34();
		GClass1.smethod_33(this.gclass2_0);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0001CB34 File Offset: 0x0001AD34
	public void method_29(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = " ";
		this.gclass2_0.string_0 = int_0 + "Background Video";
		GClass1.smethod_3(this.gclass2_0);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002EEE File Offset: 0x000010EE
	public void method_30()
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_0 = "Default Sort Filter";
		GClass1.smethod_7(this.gclass2_0);
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002CB2 File Offset: 0x00000EB2
	public static void smethod_21(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_46();
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0001CB80 File Offset: 0x0001AD80
	public void method_31(SongEntry songEntry_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "In Menus: Song Select";
		this.gclass2_0.string_0 = songEntry_0.artistName + " - " + songEntry_0.songName;
		this.method_34();
		GClass1.smethod_6(this.gclass2_0);
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00002F14 File Offset: 0x00001114
	public static void smethod_22(int int_0, string string_1)
	{
		Debug.Log(string.Format("Resolution", int_0, string_1));
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_32()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00002F2C File Offset: 0x0000112C
	public static void smethod_23(int int_0, string string_1)
	{
		Debug.Log(string.Format("song", int_0, string_1));
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00002F44 File Offset: 0x00001144
	public static void smethod_24(int int_0, string string_1)
	{
		Debug.Log(string.Format("Are you sure you want to delete this setlist?", int_0, string_1));
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
	public void method_33(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "In Menus: Stats";
		this.gclass2_0.string_0 = int_0 + " Stars Earned";
		GClass1.smethod_6(this.gclass2_0);
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0001CC24 File Offset: 0x0001AE24
	private void method_34()
	{
		if (this.gclass2_0.string_1.Length >= 64)
		{
			this.gclass2_0.string_1 = this.gclass2_0.string_1.Substring(0, 61) + "...";
		}
		if (this.gclass2_0.string_0.Length >= 64)
		{
			this.gclass2_0.string_0 = this.gclass2_0.string_0.Substring(0, 61) + "...";
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002D3F File Offset: 0x00000F3F
	public static void smethod_25(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_40();
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002F5C File Offset: 0x0000115C
	public static void smethod_26(int int_0, string string_1)
	{
		Debug.Log(string.Format("Okay", int_0, string_1));
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0001CCAC File Offset: 0x0001AEAC
	public void method_35(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "Difficulty" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "volume";
			this.gclass2_0.string_5 = "note_animation";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "custom";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "No songs were found!" + GlobalVariables.instance.songSpeed.String_1 + "Game Manager";
		if (this.gclass2_0.string_0.Length + text2.Length <= -53)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_53();
		GClass1.smethod_11(this.gclass2_0);
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
	public void method_36(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "%y";
		this.gclass2_0.string_0 = int_0 + "B: ";
		GClass1.smethod_28(this.gclass2_0);
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0001CE2C File Offset: 0x0001B02C
	public void method_37(SongEntry songEntry_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "Songs Scanned";
		this.gclass2_0.string_0 = songEntry_0.artistName + "No Part" + songEntry_0.songName;
		this.method_50();
		GClass1.smethod_12(this.gclass2_0);
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0001CE84 File Offset: 0x0001B084
	public void method_38(int int_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "isHidden";
		this.gclass2_0.string_0 = int_0 + "full_playlist";
		GClass1.smethod_20(this.gclass2_0);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00002CB2 File Offset: 0x00000EB2
	public static void smethod_27(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_46();
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002F74 File Offset: 0x00001174
	public static void smethod_28(int int_0, string string_1)
	{
		Debug.Log(string.Format("lyric", int_0, string_1));
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0001CED0 File Offset: 0x0001B0D0
	public void method_39(SongEntry songEntry_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "volume";
		this.gclass2_0.string_0 = songEntry_0.artistName + "+" + songEntry_0.songName;
		this.method_53();
		GClass1.smethod_14(this.gclass2_0);
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002F8C File Offset: 0x0000118C
	public void method_40()
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_0 = "In Menus: Stats";
		GClass1.smethod_13(this.gclass2_0);
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002DAD File Offset: 0x00000FAD
	private void method_41()
	{
		GClass1.Discord_Shutdown();
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002F2C File Offset: 0x0000112C
	public static void smethod_29(int int_0, string string_1)
	{
		Debug.Log(string.Format("song", int_0, string_1));
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0001CF28 File Offset: 0x0001B128
	public void method_42(SongEntry songEntry_0)
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_1 = "Gameplay";
		this.gclass2_0.string_0 = songEntry_0.artistName + "setlistSongCountSingular" + songEntry_0.songName;
		this.method_0();
		GClass1.smethod_4(this.gclass2_0);
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_43()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0001CF80 File Offset: 0x0001B180
	private void method_44()
	{
		this.gstruct0_0 = default(GClass1.GStruct0);
		this.gstruct0_0.gdelegate0_0 = new GClass1.GDelegate0(DiscordController.smethod_12);
		this.gstruct0_0.gdelegate1_0 = (GClass1.GDelegate1)Delegate.Combine(this.gstruct0_0.gdelegate1_0, new GClass1.GDelegate1(DiscordController.smethod_30));
		this.gstruct0_0.gdelegate2_0 = (GClass1.GDelegate2)Delegate.Combine(this.gstruct0_0.gdelegate2_0, new GClass1.GDelegate2(DiscordController.smethod_34));
		GClass1.Discord_Initialize(this.string_0, ref this.gstruct0_0, false, null);
		this.gclass2_0.string_2 = "Easy";
		this.gclass2_0.string_3 = "All Strums";
		DiscordController.discordController_0 = this;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x0001D034 File Offset: 0x0001B234
	private void method_45()
	{
		this.gstruct0_0 = default(GClass1.GStruct0);
		this.gstruct0_0.gdelegate0_0 = new GClass1.GDelegate0(DiscordController.smethod_12);
		this.gstruct0_0.gdelegate1_0 = (GClass1.GDelegate1)Delegate.Combine(this.gstruct0_0.gdelegate1_0, new GClass1.GDelegate1(DiscordController.smethod_22));
		this.gstruct0_0.gdelegate2_0 = (GClass1.GDelegate2)Delegate.Combine(this.gstruct0_0.gdelegate2_0, new GClass1.GDelegate2(DiscordController.smethod_16));
		GClass1.Discord_Initialize(this.string_0, ref this.gstruct0_0, true, null);
		this.gclass2_0.string_2 = "notes.chart";
		this.gclass2_0.string_3 = "video";
		DiscordController.discordController_0 = this;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002FD0 File Offset: 0x000011D0
	public static void smethod_30(int int_0, string string_1)
	{
		Debug.Log(string.Format("Audio Device", int_0, string_1));
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002FE8 File Offset: 0x000011E8
	public void method_46()
	{
		if (!base.enabled)
		{
			return;
		}
		this.gclass2_0.string_0 = "Animated";
		GClass1.smethod_22(this.gclass2_0);
	}

	// Token: 0x06000184 RID: 388 RVA: 0x0000300E File Offset: 0x0000120E
	[MonoPInvokeCallback(typeof(GClass1.GDelegate2))]
	public static void smethod_31(int int_0, string string_1)
	{
		Debug.Log(string.Format("Discord: error {0}: {1}", int_0, string_1));
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00003026 File Offset: 0x00001226
	public static void smethod_32(int int_0, string string_1)
	{
		Debug.Log(string.Format("'='", int_0, string_1));
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
	public void method_47(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "Resume" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
			this.gclass2_0.string_5 = "No";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "has_bots";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "Prefabs/Gameplay/Players/Guitar Player " + GlobalVariables.instance.songSpeed.String_1 + " + ";
		if (this.gclass2_0.string_0.Length + text2.Length <= -104)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_53();
		GClass1.smethod_10(this.gclass2_0);
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_48()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002DAD File Offset: 0x00000FAD
	private void method_49()
	{
		GClass1.Discord_Shutdown();
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0000303E File Offset: 0x0000123E
	public static void smethod_33(int int_0, string string_1)
	{
		Debug.Log(string.Format("", int_0, string_1));
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0001D21C File Offset: 0x0001B41C
	private void method_50()
	{
		if (this.gclass2_0.string_1.Length >= -98)
		{
			this.gclass2_0.string_1 = this.gclass2_0.string_1.Substring(1, 76) + "part guitar";
		}
		if (this.gclass2_0.string_0.Length >= 98)
		{
			this.gclass2_0.string_0 = this.gclass2_0.string_0.Substring(1, 114) + "Note: ";
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_51()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00003056 File Offset: 0x00001256
	public static void smethod_34(int int_0, string string_1)
	{
		Debug.Log(string.Format(":\n", int_0, string_1));
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_52()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
	private void method_53()
	{
		if (this.gclass2_0.string_1.Length >= -58)
		{
			this.gclass2_0.string_1 = this.gclass2_0.string_1.Substring(0, -9) + "Create Profile";
		}
		if (this.gclass2_0.string_0.Length >= -49)
		{
			this.gclass2_0.string_0 = this.gclass2_0.string_0.Substring(1, 82) + "e";
		}
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002DFC File Offset: 0x00000FFC
	public static void smethod_35(ref GClass1.DiscordUser discordUser_0)
	{
		DiscordController.discordController_0.method_13();
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002D38 File Offset: 0x00000F38
	private void method_54()
	{
		GClass1.Discord_RunCallbacks();
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0001D32C File Offset: 0x0001B52C
	public void method_55(bool bool_0, bool bool_1, SongEntry songEntry_0, CHPlayer gclass9_0)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!bool_1)
		{
			string text = gclass9_0.gclass10_0.genum18_0.ToString();
			string str = gclass9_0.gclass10_0.genum17_0.ToString();
			this.gclass2_0.string_4 = (str + text).ToLower();
			this.gclass2_0.string_5 = str + "Prefabs/Gameplay/Notes/Sustain" + text;
		}
		else
		{
			this.gclass2_0.string_4 = "Restart";
			this.gclass2_0.string_5 = "streamer";
		}
		if (bool_0)
		{
			this.gclass2_0.string_1 = "album_track";
		}
		else
		{
			this.gclass2_0.string_1 = songEntry_0.artistName;
		}
		this.gclass2_0.string_0 = songEntry_0.songName;
		string text2 = "Sound Effects" + GlobalVariables.instance.songSpeed.method_28() + "Year";
		if (this.gclass2_0.string_0.Length + text2.Length <= -20)
		{
			GClass1.GClass2 gclass = this.gclass2_0;
			gclass.string_0 += text2;
		}
		this.method_0();
		GClass1.smethod_41(this.gclass2_0);
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002DAD File Offset: 0x00000FAD
	private void method_56()
	{
		GClass1.Discord_Shutdown();
	}

	// Token: 0x04000036 RID: 54
	public GClass1.GClass2 gclass2_0 = new GClass1.GClass2();

	// Token: 0x04000037 RID: 55
	public string string_0 = "378347429537251328";

	// Token: 0x04000038 RID: 56
	private GClass1.GStruct0 gstruct0_0;

	// Token: 0x04000039 RID: 57
	public static DiscordController discordController_0;
}
