using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003B RID: 59
public class PlayerStats : BaseMenu
{
	// Token: 0x060009AA RID: 2474 RVA: 0x00052E9C File Offset: 0x0005109C
	private void method_44()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_2())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_11(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00052F40 File Offset: 0x00051140
	private void method_45()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_19())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_35(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00052FE4 File Offset: 0x000511E4
	protected virtual void vmethod_81()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "phrase_start" : (num2 + "backend"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "sounds";
			}
		}
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x0005309C File Offset: 0x0005129C
	protected virtual void vmethod_82()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "In Menus: Song Select" : (num2 + "Search LAN"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "Expert";
			}
		}
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00053154 File Offset: 0x00051354
	protected virtual void vmethod_83()
	{
		base.vmethod_69();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("custom", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Bass Guitar" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "lowlatency_enabled";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "graphics_venid" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("diff_band", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00053328 File Offset: 0x00051528
	protected virtual void vmethod_84()
	{
		base.vmethod_69();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Black Backgrounds", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Delete Profile" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Unknown Charter";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Monika" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("^\\s*\\d+ = E \\S", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x000534FC File Offset: 0x000516FC
	protected virtual void vmethod_85()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Main Menu" : (num2 + "Animated"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "";
			}
		}
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x000535B4 File Offset: 0x000517B4
	protected virtual void vmethod_86()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "delay" : (num2 + "Unknown Charter"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Hard";
			}
		}
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x0005366C File Offset: 0x0005186C
	protected override void vmethod_50()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "N/A" : (num2 + "%"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "";
			}
		}
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00053724 File Offset: 0x00051924
	private void method_46()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_35(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x000537C8 File Offset: 0x000519C8
	private void method_47()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].Boolean_0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0005386C File Offset: 0x00051A6C
	protected virtual void vmethod_87()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "/songs.json" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "song_export";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "game" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00053A40 File Offset: 0x00051C40
	protected virtual void vmethod_88()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "You must restart, settings were changed" : (num2 + "streamer"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "Continue";
			}
		}
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00053AF8 File Offset: 0x00051CF8
	protected virtual void vmethod_89()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Show Bot Score" : (num2 + "Easy"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "highway_placement";
			}
		}
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00053BB0 File Offset: 0x00051DB0
	protected virtual void vmethod_90()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "en-US" : (num2 + "isHidden"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Gamepad Mode";
			}
		}
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00053C68 File Offset: 0x00051E68
	protected virtual void vmethod_91()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Guitar - ", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Songs" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + " + ";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "artist" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Medium", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00053E3C File Offset: 0x0005203C
	private void method_48()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_9())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_35(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00053EE0 File Offset: 0x000520E0
	private void method_49()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_7())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00053F84 File Offset: 0x00052184
	protected virtual void vmethod_92()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Resolution" : (num2 + ""));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "loading_phrase";
			}
		}
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x0005403C File Offset: 0x0005223C
	private void method_50()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_15())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x000540E0 File Offset: 0x000522E0
	private void method_51()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_11())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00054184 File Offset: 0x00052384
	protected virtual void vmethod_93()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "/Game Icons" : (num2 + "diff_rhythm"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "volume";
			}
		}
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0005423C File Offset: 0x0005243C
	private void method_52()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_9())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x000542E0 File Offset: 0x000524E0
	protected virtual void vmethod_94()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? " + " : (num2 + "All Taps"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "song_length";
			}
		}
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00054398 File Offset: 0x00052598
	protected override void Start()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("{0:n0}", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "/" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "%";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "/" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("{0:n3}x", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x0005456C File Offset: 0x0005276C
	protected virtual void vmethod_95()
	{
		base.vmethod_77();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("song", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "HUD" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "volume";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "offsets" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("%", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00054740 File Offset: 0x00052940
	protected virtual void vmethod_96()
	{
		base.vmethod_69();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("diff_drums", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "en-US" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Guitar Coop";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "\\d+" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00054914 File Offset: 0x00052B14
	protected virtual void vmethod_97()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Charter" : (num2 + "delay"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "Bot";
			}
		}
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x000549CC File Offset: 0x00052BCC
	private void method_53()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_11())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00054A70 File Offset: 0x00052C70
	protected virtual void vmethod_98()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "bad_note1" : (num2 + "cd"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Show in Finder";
			}
		}
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00054B28 File Offset: 0x00052D28
	private void method_54()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_18())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00054BCC File Offset: 0x00052DCC
	protected virtual void vmethod_99()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? " + " : (num2 + "song"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "volume";
			}
		}
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00054C84 File Offset: 0x00052E84
	private void method_55()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00054D28 File Offset: 0x00052F28
	protected virtual void vmethod_100()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "BassStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"" : (num2 + "No Lyrics"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Master Volume";
			}
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00054DE0 File Offset: 0x00052FE0
	protected virtual void vmethod_101()
	{
		base.vmethod_35();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Low Latency Mode", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "0%" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("GHLive Guitar - ", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00054FB4 File Offset: 0x000531B4
	private void method_56()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_2())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00055058 File Offset: 0x00053258
	private void method_57()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_35(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x000550FC File Offset: 0x000532FC
	private void method_58()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_17())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x000551A0 File Offset: 0x000533A0
	private void Awake()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].Boolean_0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00055244 File Offset: 0x00053444
	private void method_59()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_17())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_35(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x000552E8 File Offset: 0x000534E8
	protected virtual void vmethod_102()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "6 Fret Lead Guitar" : (num2 + " "));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "{0:n0}";
			}
		}
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x000553A0 File Offset: 0x000535A0
	protected virtual void vmethod_103()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Main Menu" : (num2 + "SongScan"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "";
			}
		}
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x0005403C File Offset: 0x0005223C
	private void method_60()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_15())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00055458 File Offset: 0x00053658
	protected virtual void vmethod_104()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Expert" : (num2 + "</color> songs exported"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "This mode is so secret, no one knows what it does!";
			}
		}
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00055510 File Offset: 0x00053710
	protected virtual void vmethod_105()
	{
		base.vmethod_35();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("-", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Practicing..." + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Percentage";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Drop Out" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x000556E4 File Offset: 0x000538E4
	protected virtual void vmethod_106()
	{
		base.vmethod_35();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("song", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "cpu_name" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Language";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "</color>" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format(" + ", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x000558B8 File Offset: 0x00053AB8
	protected virtual void vmethod_107()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "song_preview" : (num2 + "A: 00:00:00"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "<";
			}
		}
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00055970 File Offset: 0x00053B70
	private void method_61()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_11())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_35(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00055A14 File Offset: 0x00053C14
	protected virtual void vmethod_108()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "game" : (num2 + ", "));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Audio Backend";
			}
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00055ACC File Offset: 0x00053CCC
	protected virtual void vmethod_109()
	{
		base.vmethod_77();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Disabled", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + " " + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "[\\-\\+]?\\d+(\\.\\d+)?";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "enable_lyrics" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("song", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00054B28 File Offset: 0x00052D28
	private void method_62()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_18())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00055CA0 File Offset: 0x00053EA0
	private void method_63()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_17())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00055D44 File Offset: 0x00053F44
	private void method_64()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_5())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_11(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00055DE8 File Offset: 0x00053FE8
	protected virtual void vmethod_110()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "All Strums" : (num2 + "SCANNING FOLDERS..."));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "part guitar";
			}
		}
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00055EA0 File Offset: 0x000540A0
	private void method_65()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_15())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00055F44 File Offset: 0x00054144
	protected virtual void vmethod_111()
	{
		base.vmethod_69();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Sound Effects", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "song" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Lights Out";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "These folders have corrupt (or broken) notes.mid or notes.chart files! Type !midifix in the CH Discord for MIDIFix!" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("<color=#FFFF04FF>", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00056118 File Offset: 0x00054318
	private void method_66()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_18())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x000561BC File Offset: 0x000543BC
	protected virtual void vmethod_112()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Client\nServer IP: " : (num2 + "Lyrics"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Press Enter to confirm";
			}
		}
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00056274 File Offset: 0x00054474
	private void method_67()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_14())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_11(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00056318 File Offset: 0x00054518
	protected virtual void vmethod_113()
	{
		base.vmethod_77();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Genre", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Sayori" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "graphics_name";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Song" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Restart", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x000564EC File Offset: 0x000546EC
	protected virtual void vmethod_114()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Song Speed" : (num2 + "highway_shake"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = " - ";
			}
		}
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x000565A4 File Offset: 0x000547A4
	private void method_68()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00056648 File Offset: 0x00054848
	protected virtual void vmethod_115()
	{
		base.vmethod_77();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("0", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Quit" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "sounds";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Songs are still scanning..." + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Main Menu", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x0005681C File Offset: 0x00054A1C
	protected override void vmethod_35()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Hz", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "%>" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "-";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + ", Vel: " + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("game", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x000569F0 File Offset: 0x00054BF0
	protected virtual void vmethod_116()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "%b" : (num2 + "Unknown Genre"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "Yes";
			}
		}
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00056AA8 File Offset: 0x00054CA8
	protected virtual void vmethod_117()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("cpu_count", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Medium" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Rhythm Guitar";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Lyrics" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("\"([^\"]*)\"", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00056C7C File Offset: 0x00054E7C
	private void method_69()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_17())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_11(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00056D20 File Offset: 0x00054F20
	protected virtual void vmethod_118()
	{
		base.vmethod_77();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Length = [\\-\\+]?\\d+(\\.\\d+)?", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "song" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "soloend";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "star_animation" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Medium", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00056EF4 File Offset: 0x000550F4
	protected virtual void vmethod_119()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Lefty Flip", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "errors.txt" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "isHidden";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "game" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Play Count", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x000570C8 File Offset: 0x000552C8
	protected virtual void vmethod_120()
	{
		base.vmethod_69();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("{0:n0}", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Song" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "setlistSongCountSingular";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + ": <color=#FDB400FF>" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format(" (", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x0005729C File Offset: 0x0005549C
	protected virtual void vmethod_121()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Guitar Coop", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Overwrite" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "video";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "bad_note3" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Guitar Coop", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00057470 File Offset: 0x00055670
	protected virtual void vmethod_122()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "highway_sp" : (num2 + "Unknown Artist"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "show_bot_score";
			}
		}
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00057528 File Offset: 0x00055728
	private void method_70()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_14())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x000575CC File Offset: 0x000557CC
	protected virtual void vmethod_123()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Delete Profile" : (num2 + "Problem loading setlist"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "rhythm";
			}
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00057684 File Offset: 0x00055884
	protected virtual void vmethod_124()
	{
		base.vmethod_77();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Song Speed", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "%c";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("part guitar coop", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00057858 File Offset: 0x00055A58
	protected virtual void vmethod_125()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Choose a Profile" : (num2 + "{{ Chunk = {0}, Number = {1} }}"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Quickplay";
			}
		}
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00057910 File Offset: 0x00055B10
	protected virtual void vmethod_126()
	{
		base.vmethod_35();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Not match flags previous {0} {1}", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "backend" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Star Animation FPS";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Play Setlist" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Bass Guitar", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00057AE4 File Offset: 0x00055CE4
	protected virtual void vmethod_127()
	{
		base.vmethod_35();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("/songs.json", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "%" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "game";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Couldn't load that song" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Gem Size", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00057CB8 File Offset: 0x00055EB8
	protected virtual void vmethod_128()
	{
		base.vmethod_69();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("-", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Bad Songs" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Song Previews";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "Language" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Set A Position", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00054B28 File Offset: 0x00052D28
	private void method_71()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_18())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00057E8C File Offset: 0x0005608C
	protected virtual void vmethod_129()
	{
		base.vmethod_35();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("diff_drums", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "Show Bot Score" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "master_volume";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "No Part" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Audio Offset", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00058060 File Offset: 0x00056260
	private void method_72()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.method_11(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00058104 File Offset: 0x00056304
	protected virtual void vmethod_130()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i++)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "is_practice" : (num2 + "File does not exist"));
			num += 0;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "keys";
			}
		}
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x000581BC File Offset: 0x000563BC
	protected virtual void vmethod_131()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Star Animation FPS" : (num2 + "Song"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j += 0)
			{
				this.sectionPercents[j].text = "volume";
			}
		}
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00058274 File Offset: 0x00056474
	private void method_73()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].Boolean_0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00058318 File Offset: 0x00056518
	protected virtual void vmethod_132()
	{
		base.vmethod_35();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Elapsed: ", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "No Lyrics" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Awesome Choke!";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "drums" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("video", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x000584EC File Offset: 0x000566EC
	protected virtual void vmethod_133()
	{
		base.Start();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("Okay", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "video_start_time" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "Song Settings";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "sounds" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("Current Instrument", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x000586C0 File Offset: 0x000568C0
	protected virtual void vmethod_134()
	{
		base.vmethod_77();
		this.profile.text = GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.string_0;
		if (GameSetting.smethod_3(GlobalVariables.instance.playerList[this.playerIndex].gclass10_0.gclass5_4))
		{
			this.profile.color = Color.cyan;
		}
		this.score.text = string.Format("song", this.songStats_0.int_8[this.playerIndex]);
		this.accuracy.text = this.songStats_0.int_4[this.playerIndex] + "No Images!" + this.songStats_0.int_5[this.playerIndex];
		this.accuracyPercent.text = this.songStats_0.int_2[this.playerIndex] + "language";
		this.combo.text = this.songStats_0.int_3[this.playerIndex].ToString();
		this.spPhrases.text = this.songStats_0.int_6[this.playerIndex] + "All Strums" + this.songStats_0.int_7[this.playerIndex];
		this.fullCombo.enabled = (this.songStats_0.int_5[this.playerIndex] == this.songStats_0.int_3[this.playerIndex]);
		this.avgMultiplier.text = string.Format("6 Fret Bass Guitar", this.songStats_0.float_0[this.playerIndex]);
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00058894 File Offset: 0x00056A94
	protected virtual void vmethod_135()
	{
		base.vmethod_50();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 0; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "system_ram" : (num2 + "Go to Discord"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "/";
			}
		}
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x0005894C File Offset: 0x00056B4C
	protected override void vmethod_30()
	{
		base.vmethod_30();
		int num = this.int_0 + this.songStats_0.int_9 * this.playerIndex;
		for (int i = 1; i < this.int_3; i += 0)
		{
			int num2 = this.songStats_0.int_1[num];
			this.sectionPercents[i].text = ((num2 == -1) ? "Custom Content" : (num2 + "OPTIONS"));
			num++;
		}
		if (this.menuStrings.Length < this.sectionPercents.Length)
		{
			for (int j = this.menuStrings.Length; j < this.sectionPercents.Length; j++)
			{
				this.sectionPercents[j].text = "Year";
			}
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00058A04 File Offset: 0x00056C04
	private void method_74()
	{
		if (!GlobalVariables.instance.playerList[this.playerIndex].method_4())
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		this.menuStrings = new string[this.songStats_0.int_9];
		for (int i = 1; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = this.songStats_0.gclass22_0[i].string_0;
		}
	}

	// Token: 0x040001CD RID: 461
	[SerializeField]
	private int playerIndex;

	// Token: 0x040001CE RID: 462
	[SerializeField]
	private Text score;

	// Token: 0x040001CF RID: 463
	[SerializeField]
	private Text accuracy;

	// Token: 0x040001D0 RID: 464
	[SerializeField]
	private Text accuracyPercent;

	// Token: 0x040001D1 RID: 465
	[SerializeField]
	private Text combo;

	// Token: 0x040001D2 RID: 466
	[SerializeField]
	private Text spPhrases;

	// Token: 0x040001D3 RID: 467
	[SerializeField]
	private Text avgMultiplier;

	// Token: 0x040001D4 RID: 468
	[SerializeField]
	private Text profile;

	// Token: 0x040001D5 RID: 469
	[SerializeField]
	private Text fullCombo;

	// Token: 0x040001D6 RID: 470
	[SerializeField]
	private Text[] sectionPercents;

	// Token: 0x040001D7 RID: 471
	[SerializeField]
	private Color greenColor;

	// Token: 0x040001D8 RID: 472
	[SerializeField]
	private Color redColor;

	// Token: 0x040001D9 RID: 473
	[SerializeField]
	private Color yellowColor;

	// Token: 0x040001DA RID: 474
	private SongStats songStats_0;
}
