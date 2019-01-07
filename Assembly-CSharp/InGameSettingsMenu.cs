using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000046 RID: 70
public class InGameSettingsMenu : BaseMenu
{
	// Token: 0x06000C8A RID: 3210 RVA: 0x000073CB File Offset: 0x000055CB
	public virtual void vmethod_81()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00064810 File Offset: 0x00062A10
	public override void vmethod_0()
	{
		string a = base.method_39();
		if (a == "Ready")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(a == "Playlist"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00007403 File Offset: 0x00005603
	public virtual void vmethod_82()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0000743B File Offset: 0x0000563B
	public virtual void vmethod_83()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0006487C File Offset: 0x00062A7C
	public virtual void vmethod_84()
	{
		string string_ = base.String_0;
		if (string_ == "star_deployed")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "No Videos!"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00007473 File Offset: 0x00005673
	private void method_44()
	{
		this.pausedText.text = GClass4.gclass4_0.method_17("0");
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0000748F File Offset: 0x0000568F
	public virtual void vmethod_85()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x000648E8 File Offset: 0x00062AE8
	public virtual void vmethod_86()
	{
		string a = base.method_39();
		if (a == "Gem Size")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(a == "6 Fret Bass Guitar"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x000074C7 File Offset: 0x000056C7
	public virtual void vmethod_87()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x000074FF File Offset: 0x000056FF
	private void method_45()
	{
		this.pausedText.text = GClass4.gclass4_0.method_15("game");
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00064954 File Offset: 0x00062B54
	public override void vmethod_39()
	{
		string string_ = base.String_0;
		if (string_ == "Volume")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "Calibration"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x000074C7 File Offset: 0x000056C7
	public virtual void vmethod_88()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0000748F File Offset: 0x0000568F
	public virtual void vmethod_89()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0000748F File Offset: 0x0000568F
	public virtual void vmethod_90()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x000649C0 File Offset: 0x00062BC0
	public virtual void vmethod_91()
	{
		string string_ = base.String_0;
		if (string_ == "volume")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "Press Enter to confirm"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00064A2C File Offset: 0x00062C2C
	public virtual void vmethod_92()
	{
		string a = base.method_39();
		if (a == "offsets")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == "diff_guitar"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00064A98 File Offset: 0x00062C98
	public virtual void vmethod_93()
	{
		string string_ = base.String_0;
		if (string_ == "Practice")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "There are no saved setlists"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x0000751B File Offset: 0x0000571B
	public virtual void vmethod_94()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00064B04 File Offset: 0x00062D04
	public virtual void vmethod_95()
	{
		string a = base.method_39();
		if (a == "Date Added")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == "\\d+"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00007553 File Offset: 0x00005753
	private void method_46()
	{
		this.pausedText.text = GClass4.gclass4_0.method_35("Visit Website");
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00064B70 File Offset: 0x00062D70
	public virtual void vmethod_96()
	{
		string a = base.method_39();
		if (a == "MediaType = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(a == "vsync"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00064BDC File Offset: 0x00062DDC
	public virtual void vmethod_97()
	{
		string string_ = base.String_0;
		if (string_ == "0")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(string_ == "Camera"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x0000756F File Offset: 0x0000576F
	public virtual void vmethod_98()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0000751B File Offset: 0x0000571B
	public virtual void vmethod_99()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x000075A7 File Offset: 0x000057A7
	private void method_47()
	{
		this.pausedText.text = GClass4.gclass4_0.method_15("Continue");
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x000074C7 File Offset: 0x000056C7
	public override void vmethod_43()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x000075C3 File Offset: 0x000057C3
	private void method_48()
	{
		this.pausedText.text = GClass4.gclass4_0.method_30("Choose a Profile");
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x000075DF File Offset: 0x000057DF
	private void method_49()
	{
		this.pausedText.text = GClass4.gclass4_0.method_36("Restart");
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00064C48 File Offset: 0x00062E48
	public virtual void vmethod_100()
	{
		string a = base.method_39();
		if (a == "sort_filter")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == "Bot"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00064CB4 File Offset: 0x00062EB4
	public virtual void vmethod_101()
	{
		string string_ = base.String_0;
		if (string_ == "Searching for")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(string_ == "Track Mute"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x000075FB File Offset: 0x000057FB
	private void Awake()
	{
		this.pausedText.text = GClass4.gclass4_0.method_13("OPTIONS");
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x000073CB File Offset: 0x000055CB
	public virtual void vmethod_102()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x00007617 File Offset: 0x00005817
	private void method_50()
	{
		this.pausedText.text = GClass4.gclass4_0.method_7("video");
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00064D20 File Offset: 0x00062F20
	public virtual void vmethod_103()
	{
		string string_ = base.String_0;
		if (string_ == "Language")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "isEOL"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00007633 File Offset: 0x00005833
	private void method_51()
	{
		this.pausedText.text = GClass4.gclass4_0.method_38("Video Start Time");
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00064D8C File Offset: 0x00062F8C
	public virtual void vmethod_104()
	{
		string a = base.method_39();
		if (a == "No Part")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == "streamer"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x0000764F File Offset: 0x0000584F
	public virtual void vmethod_105()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00007687 File Offset: 0x00005887
	private void method_52()
	{
		this.pausedText.text = GClass4.gclass4_0.method_17("star_animation");
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x000076A3 File Offset: 0x000058A3
	public virtual void vmethod_106()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x000076DB File Offset: 0x000058DB
	private void method_53()
	{
		this.pausedText.text = GClass4.gclass4_0.method_36("Options");
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x00064DF8 File Offset: 0x00062FF8
	public virtual void vmethod_107()
	{
		string a = base.method_39();
		if (a == "guitar")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == " + "))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x0000748F File Offset: 0x0000568F
	public virtual void vmethod_108()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x000076F7 File Offset: 0x000058F7
	private void method_54()
	{
		this.pausedText.text = GClass4.gclass4_0.method_35("Charter");
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00064E64 File Offset: 0x00063064
	public virtual void vmethod_109()
	{
		string a = base.method_39();
		if (a == "Yes")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == "game"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00064ED0 File Offset: 0x000630D0
	public virtual void vmethod_110()
	{
		string a = base.method_39();
		if (a == "-")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == "6 Fret Bass Guitar"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00007713 File Offset: 0x00005913
	private void method_55()
	{
		this.pausedText.text = GClass4.gclass4_0.method_46("nomodifiers");
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00064F3C File Offset: 0x0006313C
	public virtual void vmethod_111()
	{
		string string_ = base.String_0;
		if (string_ == "full_playlist")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(string_ == "Prefabs/Gameplay/Players/GHL Player "))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x0000772F File Offset: 0x0000592F
	private void method_56()
	{
		this.pausedText.text = GClass4.gclass4_0.method_30("<color=#FFFF04FF>");
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x0000774B File Offset: 0x0000594B
	private void method_57()
	{
		this.pausedText.text = GClass4.gclass4_0.method_36("bass");
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00064FA8 File Offset: 0x000631A8
	public virtual void vmethod_112()
	{
		string string_ = base.String_0;
		if (string_ == "File does not exist")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "mute_volume"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00007403 File Offset: 0x00005603
	public virtual void vmethod_113()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00007767 File Offset: 0x00005967
	public virtual void vmethod_114()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x0000743B File Offset: 0x0000563B
	public virtual void vmethod_115()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00065014 File Offset: 0x00063214
	public virtual void vmethod_116()
	{
		string string_ = base.String_0;
		if (string_ == "/")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "In Menus: Stats"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00065080 File Offset: 0x00063280
	public virtual void vmethod_117()
	{
		string string_ = base.String_0;
		if (string_ == "Show in File Explorer")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(string_ == "Hard"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x0000779F File Offset: 0x0000599F
	private void method_58()
	{
		this.pausedText.text = GClass4.gclass4_0.method_7("Disabled");
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x0000743B File Offset: 0x0000563B
	public virtual void vmethod_118()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x0000756F File Offset: 0x0000576F
	public virtual void vmethod_119()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x000077BB File Offset: 0x000059BB
	private void method_59()
	{
		this.pausedText.text = GClass4.gclass4_0.method_11("Fullscreen");
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x000077D7 File Offset: 0x000059D7
	private void method_60()
	{
		this.pausedText.text = GClass4.gclass4_0.method_46("Game Modifiers");
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x000076A3 File Offset: 0x000058A3
	public virtual void vmethod_120()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x000077F3 File Offset: 0x000059F3
	public virtual void vmethod_121()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0000782B File Offset: 0x00005A2B
	private void method_61()
	{
		this.pausedText.text = GClass4.gclass4_0.method_2("diff_guitar");
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00007847 File Offset: 0x00005A47
	public virtual void vmethod_122()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x0000787F File Offset: 0x00005A7F
	public virtual void vmethod_123()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x000650EC File Offset: 0x000632EC
	public virtual void vmethod_124()
	{
		string string_ = base.String_0;
		if (string_ == "Settings")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "crowd"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x000078B7 File Offset: 0x00005AB7
	private void method_62()
	{
		this.pausedText.text = GClass4.gclass4_0.method_15("vsync_enabled");
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x000078D3 File Offset: 0x00005AD3
	private void method_63()
	{
		this.pausedText.text = GClass4.gclass4_0.method_46("");
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x00065158 File Offset: 0x00063358
	public virtual void vmethod_125()
	{
		string string_ = base.String_0;
		if (string_ == "Scan Songs")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "Pause on Focus Lost"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x000077F3 File Offset: 0x000059F3
	public virtual void vmethod_126()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x000651C4 File Offset: 0x000633C4
	public virtual void vmethod_127()
	{
		string a = base.method_39();
		if (a == "Genre")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == " + "))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x0000743B File Offset: 0x0000563B
	public virtual void vmethod_128()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x000078EF File Offset: 0x00005AEF
	public virtual void vmethod_129()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00007927 File Offset: 0x00005B27
	private void method_64()
	{
		this.pausedText.text = GClass4.gclass4_0.method_7("Problem loading setlist");
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00007767 File Offset: 0x00005967
	public virtual void vmethod_130()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00007943 File Offset: 0x00005B43
	private void method_65()
	{
		this.pausedText.text = GClass4.gclass4_0.method_38("Natsuki");
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x0000795F File Offset: 0x00005B5F
	private void method_66()
	{
		this.pausedText.text = GClass4.gclass4_0.method_7("You must restart, settings were changed");
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00007847 File Offset: 0x00005A47
	public virtual void vmethod_131()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x0000797B File Offset: 0x00005B7B
	public virtual void vmethod_132()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x000079B3 File Offset: 0x00005BB3
	private void method_67()
	{
		this.pausedText.text = GClass4.gclass4_0.method_38(".png");
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x000079CF File Offset: 0x00005BCF
	private void method_68()
	{
		this.pausedText.text = GClass4.gclass4_0.method_2("Ultra Greatness Mode");
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00065230 File Offset: 0x00063430
	public virtual void vmethod_133()
	{
		string string_ = base.String_0;
		if (string_ == "0")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "video"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x0000764F File Offset: 0x0000584F
	public virtual void vmethod_134()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x0000787F File Offset: 0x00005A7F
	public virtual void vmethod_135()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x000079EB File Offset: 0x00005BEB
	public virtual void vmethod_136()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0006529C File Offset: 0x0006349C
	public override void vmethod_48()
	{
		string a = base.method_39();
		if (a == "Unknown Genre")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(a == "Hard"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00065308 File Offset: 0x00063508
	public virtual void vmethod_137()
	{
		string string_ = base.String_0;
		if (string_ == "volume")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "Resolution"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00007403 File Offset: 0x00005603
	public virtual void vmethod_138()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x00065374 File Offset: 0x00063574
	public virtual void vmethod_139()
	{
		string string_ = base.String_0;
		if (string_ == "directories")
		{
			base.gameObject.SetActive(false);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(string_ == "Not match flags previous {0} {1}"))
		{
			return;
		}
		base.gameObject.SetActive(true);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x000653E0 File Offset: 0x000635E0
	public virtual void vmethod_140()
	{
		string string_ = base.String_0;
		if (string_ == "None")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(false);
			return;
		}
		if (!(string_ == "Artist"))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(true);
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x0006544C File Offset: 0x0006364C
	public virtual void vmethod_141()
	{
		string a = base.method_39();
		if (a == "/")
		{
			base.gameObject.SetActive(true);
			this.volumeMenu_0.gameObject.SetActive(true);
			return;
		}
		if (!(a == ""))
		{
			return;
		}
		base.gameObject.SetActive(false);
		this.calibrationMenu_0.gameObject.SetActive(false);
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00007403 File Offset: 0x00005603
	public virtual void vmethod_142()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00007A23 File Offset: 0x00005C23
	private void method_69()
	{
		this.pausedText.text = GClass4.gclass4_0.method_42("");
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x000074C7 File Offset: 0x000056C7
	public virtual void vmethod_143()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x000074C7 File Offset: 0x000056C7
	public virtual void vmethod_144()
	{
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
		}
		this.pauseMenu_0.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x0400020B RID: 523
	public PauseMenu pauseMenu_0;

	// Token: 0x0400020C RID: 524
	public VolumeMenu volumeMenu_0;

	// Token: 0x0400020D RID: 525
	public CalibrationMenu calibrationMenu_0;

	// Token: 0x0400020E RID: 526
	[SerializeField]
	private Text pausedText;
}
