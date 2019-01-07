using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003E RID: 62
public class ScoringPanel : MonoBehaviour
{
	// Token: 0x06000AA5 RID: 2725 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_0()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00005E6F File Offset: 0x0000406F
	private void OnEnable()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x000598DC File Offset: 0x00057ADC
	private void method_1()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.Boolean_0 || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0005995C File Offset: 0x00057B5C
	private void method_2()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_4() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x000599DC File Offset: 0x00057BDC
	public void method_3(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_16("Yes") + "[\\-\\+]?\\d+(\\.\\d+)?";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Song Offset", GClass4.gclass4_0.method_30(""), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_2("song") + "Discord: disconnect {0}: {1}" + GClass4.gclass4_0.method_7(GlobalVariables.instance.method_17().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "profiles.bin" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x00059B2C File Offset: 0x00057D2C
	private void method_4()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_15() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_5()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00059BAC File Offset: 0x00057DAC
	private void method_6()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_18() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_7()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00059C2C File Offset: 0x00057E2C
	private void method_8()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_18() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00059CAC File Offset: 0x00057EAC
	private void method_9()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_19() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00059D2C File Offset: 0x00057F2C
	private void method_10()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_9() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00059DAC File Offset: 0x00057FAC
	private void Update()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.Boolean_0 || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00059E2C File Offset: 0x0005802C
	public void method_11(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_21("song") + "Rhythm Guitar";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("volume", GClass4.gclass4_0.method_11(" + "), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_30("Rhythm") + "Gameplay" + GClass4.gclass4_0.method_2(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_3(gstruct3_0);
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00059F7C File Offset: 0x0005817C
	private void method_12()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_17() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00059FFC File Offset: 0x000581FC
	public void method_13(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_17("</color>") + "Keys";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("", GClass4.gclass4_0.method_2("</color> "), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_2("HOPO's to Taps") + "Elapsed: " + GClass4.gclass4_0.method_48(GlobalVariables.instance.method_73().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "badsongs.txt" + GClass10.smethod_7((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_8(gstruct3_0);
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_14()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x0005A14C File Offset: 0x0005834C
	public void method_15(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_21("") + "song";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Controller", GClass4.gclass4_0.method_2("Mute Track on Miss"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_16("/") + "No Videos!" + GClass4.gclass4_0.method_35(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "B: 00:00:00" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x0005A29C File Offset: 0x0005849C
	public void method_16(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_36("highway_sp") + "Unknown Artist";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("guitar", GClass4.gclass4_0.method_15("In Menus: Main Menu"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_11("Enable Lanes") + "6 Fret Lead Guitar" + GClass4.gclass4_0.method_41(GlobalVariables.instance.method_17().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "[\\-\\+]?\\d+(\\.\\d+)?" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_17()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_18()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0005A3EC File Offset: 0x000585EC
	public void method_19(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_7("song") + "Playlist";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Keys", GClass4.gclass4_0.method_17("Rename Setlist"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_42("%s%n%a%n%c") + "song_length" + GClass4.gclass4_0.method_13(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Alpha " + GClass10.smethod_4((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_20()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_21()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00005E66 File Offset: 0x00004066
	private void OnDisable()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_22()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x0005A53C File Offset: 0x0005873C
	public void method_23(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_35("track") + "pause_on_focus_lost";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Save Setlist", GClass4.gclass4_0.method_21("Main Menu"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_48("Are you sure you want to quit?") + "Build: " + GClass4.gclass4_0.method_46(GlobalVariables.instance.method_70().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Camera" + GClass10.smethod_4((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_1(gstruct3_0);
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x0005A68C File Offset: 0x0005888C
	public void method_24(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_7("\"([^\"]*)\"") + "Resolution = [\\-\\+]?\\d+(\\.\\d+)?";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Expert", GClass4.gclass4_0.method_36(""), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_7("game_version") + "Lead Guitar" + GClass4.gclass4_0.method_21(GlobalVariables.instance.method_33().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "allow_duplicate_songs" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_8(gstruct3_0);
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x0005A7DC File Offset: 0x000589DC
	public void method_25(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_17(" + ") + "*Random";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Song Previews", GClass4.gclass4_0.method_38(""), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_46("Restart") + "WRITING CACHE..." + GClass4.gclass4_0.method_11(GlobalVariables.instance.method_73().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "song" + GClass10.smethod_7((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x0005A92C File Offset: 0x00058B2C
	public void method_26(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_5("Solid Solo") + "song";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Use Song Backgrounds", GClass4.gclass4_0.method_46("-"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_42("Gameplay") + "*.setlist" + GClass4.gclass4_0.method_35(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + " (" + GClass10.smethod_7((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_0(gstruct3_0);
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_27()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_28()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_29()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_30()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x0005AA7C File Offset: 0x00058C7C
	private void method_31()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_19() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x0005AAFC File Offset: 0x00058CFC
	public void method_32(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_42("None") + "Gameplay";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Highway", GClass4.gclass4_0.method_41("Unknown Album"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_21("Set A Position") + "Lefty Flip" + GClass4.gclass4_0.method_30(GlobalVariables.instance.method_33().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Cancel" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x0005AC4C File Offset: 0x00058E4C
	private void method_33()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_9() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_34()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_35()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x0005ACCC File Offset: 0x00058ECC
	private void method_36()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_7() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x0005AD4C File Offset: 0x00058F4C
	private void method_37()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_19() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x0005ADCC File Offset: 0x00058FCC
	public void method_38(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_5(".") + "Unknown Genre";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Unknown Artist", GClass4.gclass4_0.method_42(""), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_38("Artist") + "diff_drums" + GClass4.gclass4_0.method_41(GlobalVariables.instance.method_70().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Delete Setlist" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_3(gstruct3_0);
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x0005AF1C File Offset: 0x0005911C
	private void method_39()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_17() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00059CAC File Offset: 0x00057EAC
	private void method_40()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_19() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_41()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_42()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0005AF9C File Offset: 0x0005919C
	public void method_43(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_11("Cancel") + "song";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("song", GClass4.gclass4_0.method_48("Unknown Album"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_21("Continue") + "\\s+" + GClass4.gclass4_0.method_46(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "year" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_1(gstruct3_0);
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x0005B0EC File Offset: 0x000592EC
	public void method_44(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_5("ControlMapper") + "diff_keys";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("sort_filter", GClass4.gclass4_0.method_15("Ultra Greatness Mode"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_15("custom") + "%" + GClass4.gclass4_0.method_5(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Menu Backgrounds" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_3(gstruct3_0);
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_45()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x0005B23C File Offset: 0x0005943C
	public void method_46(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_30("SETLIST LENGTH") + "charter";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Song Speed", GClass4.gclass4_0.method_5(": "), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_15("Song Speed") + "volume" + GClass4.gclass4_0.method_15(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Keys" + GClass10.smethod_7((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0005B38C File Offset: 0x0005958C
	private void method_47()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_14() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_48()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x0005B40C File Offset: 0x0005960C
	public void method_49(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_30("Practice") + "Gamepad Mode";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("", GClass4.gclass4_0.method_17(""), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_11("Percentage") + "game_version" + GClass4.gclass4_0.method_46(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "A setlist with that name already exists" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_3(gstruct3_0);
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x0005B55C File Offset: 0x0005975C
	public void method_50(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_46("loading_phrase") + "Animated";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Note: ", GClass4.gclass4_0.method_16("A setlist with that name already exists"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_46("6 Fret Lead Guitar") + "Percentage" + GClass4.gclass4_0.method_16(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Streamer Mode" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_1(gstruct3_0);
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_51()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x0005B6AC File Offset: 0x000598AC
	private void method_52()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_7() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_53()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_54()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_55()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0005B72C File Offset: 0x0005992C
	public void method_56(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_13("Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"") + "diff_guitar";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("artist", GClass4.gclass4_0.method_11("song"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_46("volume") + "%p" + GClass4.gclass4_0.method_46(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Restart Section" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_57()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0005B87C File Offset: 0x00059A7C
	public void method_58(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_42("/") + "vocals_2";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("volume", GClass4.gclass4_0.method_16("game"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_7("year") + "background" + GClass4.gclass4_0.method_15(GlobalVariables.instance.method_70().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Player" + GClass10.smethod_7((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_0(gstruct3_0);
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0005B9CC File Offset: 0x00059BCC
	public void method_59(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_36("") + "Yes";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Gamepad Mode", GClass4.gclass4_0.method_15("GuitarStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_21(" ") + "Great Solo!" + GClass4.gclass4_0.method_46(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "notes.mid" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_60()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_61()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_62()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_63()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_64()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x0005BB1C File Offset: 0x00059D1C
	public void method_65(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_48("% + ") + "Unknown Genre";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Clear Setlist", GClass4.gclass4_0.method_21("Clear Setlist"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_35("language.txt") + "song" + GClass4.gclass4_0.method_38(GlobalVariables.instance.method_34().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Disconnect" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_0(gstruct3_0);
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_66()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_67()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x0005BC6C File Offset: 0x00059E6C
	public void method_68(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_48("Language") + "guitar";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Continue", GClass4.gclass4_0.method_13("Artist"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_46("song") + "Guest" + GClass4.gclass4_0.method_11(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "isHidden" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_8(gstruct3_0);
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0005BDBC File Offset: 0x00059FBC
	public void method_69(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_30("song") + "No";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Perfect Solo!", GClass4.gclass4_0.method_16("Song Offset"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_5("Ready") + "video" + GClass4.gclass4_0.method_36(GlobalVariables.instance.method_33().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Flames" + GClass10.smethod_7((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_1(gstruct3_0);
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0005BF0C File Offset: 0x0005A10C
	public void method_70(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_16("Rescan Custom Content") + "<";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Bass Guitar", GClass4.gclass4_0.method_36("song"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_2("video_start_time") + ":" + GClass4.gclass4_0.method_2(GlobalVariables.instance.method_33().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "video" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_1(gstruct3_0);
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_71()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0005C05C File Offset: 0x0005A25C
	private void method_72()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_14() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_73()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_74()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_75()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0005C0DC File Offset: 0x0005A2DC
	public void method_76(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_15("Audio Offset") + ": {0:hh:mm:ss}";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("</color> songs exported", GClass4.gclass4_0.method_38("Easy"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_35("Gameplay") + "MMMM dd, yyyy" + GClass4.gclass4_0.method_35(GlobalVariables.instance.method_73().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_77()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_78()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_79()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_80()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0005C22C File Offset: 0x0005A42C
	public void method_81(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_17("nofail_enabled") + "crowd";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Album = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", GClass4.gclass4_0.method_42("video_start_time"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_16("sort_filter") + "Song Videos" + GClass4.gclass4_0.method_17(GlobalVariables.instance.method_34().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Percentage" + GClass10.smethod_7((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_3(gstruct3_0);
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x0005C37C File Offset: 0x0005A57C
	public void method_82(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_13("-") + "Medium";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format(")", GClass4.gclass4_0.method_36("Black Backgrounds"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_41("Note Shuffle") + "icon" + GClass4.gclass4_0.method_46(GlobalVariables.instance.method_63().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Background Image" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_0(gstruct3_0);
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_83()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_84()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00059F7C File Offset: 0x0005817C
	private void method_85()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_17() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_86()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0005C4CC File Offset: 0x0005A6CC
	public void method_87(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_15("ui_rewind_highway_sound") + "setlistwarning";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Length = [\\-\\+]?\\d+(\\.\\d+)?", GClass4.gclass4_0.method_16("Restart"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_36("MSAA Level") + "%" + GClass4.gclass4_0.method_21(GlobalVariables.instance.method_73().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = true;
			behaviour.enabled = true;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = false;
		behaviour3.enabled = false;
		behaviour2.enabled = false;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "custom" + GClass10.smethod_6((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_8(gstruct3_0);
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x0005C61C File Offset: 0x0005A81C
	public void method_88(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_36("%)") + "video";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("device", GClass4.gclass4_0.method_41("game"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_16(" ") + "offsets" + GClass4.gclass4_0.method_21(GlobalVariables.instance.method_73().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Bass Guitar" + GClass10.smethod_5((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_0(gstruct3_0);
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_89()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00005E66 File Offset: 0x00004066
	private void method_90()
	{
		this.bool_0 = false;
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0005C76C File Offset: 0x0005A96C
	private void method_91()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.method_4() || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(0))
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0005C7EC File Offset: 0x0005A9EC
	public void method_92(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_13("Current High Score") + ":";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("{0}: {1}", GClass4.gclass4_0.method_13("Play Count"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_13("No scores saved for this song on") + " " + GClass4.gclass4_0.method_13(GlobalVariables.instance.method_73().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "% + " + GClass10.smethod_4((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_2(gstruct3_0);
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0005C93C File Offset: 0x0005AB3C
	private void method_93()
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (!gclass.Boolean_0 || gclass.bool_0)
			{
				break;
			}
			if (gclass.player_0.GetButtonDown(1))
			{
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00005E6F File Offset: 0x0000406F
	private void method_94()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x0005C9BC File Offset: 0x0005ABBC
	public void method_95(SongEntry songEntry_0, GStruct3 gstruct3_0)
	{
		this.highScoreTitle.text = GClass4.gclass4_0.method_38("Alpha ") + "bad_note4";
		this.songTitle.text = songEntry_0.songName;
		this.playCount.text = string.Format("Hard", GClass4.gclass4_0.method_7("<OOB PATH>"), songEntry_0.playCount);
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.currentScore.text = GClass4.gclass4_0.method_2("") + " + " + GClass4.gclass4_0.method_21(GlobalVariables.instance.method_33().ToString());
			Behaviour behaviour = this.currentModifiers;
			this.currentInstrument.enabled = false;
			behaviour.enabled = false;
			return;
		}
		Behaviour behaviour2 = this.currentScore;
		Behaviour behaviour3 = this.currentModifiers;
		this.currentInstrument.enabled = true;
		behaviour3.enabled = true;
		behaviour2.enabled = true;
		this.currentScore.text = gstruct3_0.int_0.ToString();
		this.currentModifiers.text = gstruct3_0.short_0 + "Video Settings" + GClass10.smethod_4((GClass6.GEnum6)gstruct3_0.byte_1);
		this.currentInstrument.text = GClass10.smethod_8(gstruct3_0);
	}

	// Token: 0x040001E4 RID: 484
	[SerializeField]
	private Text highScoreTitle;

	// Token: 0x040001E5 RID: 485
	[SerializeField]
	private Text top3ScoreTitle;

	// Token: 0x040001E6 RID: 486
	[SerializeField]
	private Text songTitle;

	// Token: 0x040001E7 RID: 487
	[SerializeField]
	private Text currentScore;

	// Token: 0x040001E8 RID: 488
	[SerializeField]
	private Text currentInstrument;

	// Token: 0x040001E9 RID: 489
	[SerializeField]
	private Text currentModifiers;

	// Token: 0x040001EA RID: 490
	[SerializeField]
	private Text playCount;

	// Token: 0x040001EB RID: 491
	[SerializeField]
	private Text lastScore1;

	// Token: 0x040001EC RID: 492
	[SerializeField]
	private Text lastScore2;

	// Token: 0x040001ED RID: 493
	[SerializeField]
	private Text lastScore3;

	// Token: 0x040001EE RID: 494
	public bool bool_0;
}
