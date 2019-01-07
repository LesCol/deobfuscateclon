using System;
using System.IO;
using UnityEngine;

// Token: 0x02000043 RID: 67
public class CustomContentMenu : BaseMenu
{

	// Token: 0x06000BDB RID: 3035 RVA: 0x00006753 File Offset: 0x00004953
	public virtual void vmethod_82()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x0005FCB4 File Offset: 0x0005DEB4
	private void method_44()
	{
		string text = "MMMM dd, yyyy";
		if (!(this.string_0 == "particles") && !(this.string_0 == "EndOfSong"))
		{
			if (this.gclass5_0.CurrentValue >= 0)
			{
				string string_ = this.string_0;
				if (!(string_ == "/"))
				{
					if (string_ == "Delete Profile")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_5()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.CurrentValue]);
				}
			}
			else if (this.gclass5_0.CurrentValue == -1)
			{
				text = GClass4.gclass4_0.method_17("Songs");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "artist"))
				{
					if (string_ == "highway_placement" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_35("Charter = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_16("path");
				}
				if (text == "song")
				{
					text = GClass4.gclass4_0.method_21("highway_placement");
				}
			}
		}
		else
		{
			text = this.gclass5_0.String_0;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00006789 File Offset: 0x00004989
	public virtual void vmethod_83()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_50();
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x0005FE18 File Offset: 0x0005E018
	public override void vmethod_39()
	{
		if (this.string_0 == null)
		{
			string string_ = base.String_0;
			if (!(string_ == "Background Image"))
			{
				if (!(string_ == "Background Video"))
				{
					if (string_ == "Rescan Custom Content")
					{
						GlobalVariables.instance.method_68();
						this.method_59();
						return;
					}
					if (!(string_ == "Song Videos"))
					{
						if (string_ == "Use Song Backgrounds")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_18;
						}
					}
					else
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_36;
					}
				}
				else
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_19;
					if (!this.bool_13)
					{
						this.gclass5_0.CurrentValue = -2;
					}
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_17;
				if (!this.bool_12)
				{
					this.gclass5_0.CurrentValue = -2;
				}
			}
			this.string_0 = base.String_0;
			this.method_46();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00060038 File Offset: 0x0005E238
	private void method_45()
	{
		string text = "MSAA Level";
		if (!(this.string_0 == "") && !(this.string_0 == "PAUSED"))
		{
			if (this.gclass5_0.method_25() >= 1)
			{
				string string_ = this.string_0;
				if (!(string_ == "Unknown Charter"))
				{
					if (string_ == "Client connected")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_5()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.method_5()]);
				}
			}
			else if (this.gclass5_0.CurrentValue == -1)
			{
				text = GClass4.gclass4_0.method_48("guitar");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "%s"))
				{
					if (string_ == "offset" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_13("volume");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_21("");
				}
				if (text == "")
				{
					text = GClass4.gclass4_0.method_46("game");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00006753 File Offset: 0x00004953
	public virtual void vmethod_85()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x000067B7 File Offset: 0x000049B7
	public virtual void vmethod_86()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_44();
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x000067E5 File Offset: 0x000049E5
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00006813 File Offset: 0x00004A13
	public virtual void vmethod_87()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_46();
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x0006019C File Offset: 0x0005E39C
	private void method_46()
	{
		string text = "";
		if (!(this.string_0 == "Song Videos") && !(this.string_0 == "Use Song Backgrounds"))
		{
			if (this.gclass5_0.CurrentValue >= 0)
			{
				string string_ = this.string_0;
				if (!(string_ == "Background Image"))
				{
					if (string_ == "Background Video")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.CurrentValue]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.CurrentValue]);
				}
			}
			else if (this.gclass5_0.CurrentValue == -1)
			{
				text = GClass4.gclass4_0.method_13("*Random");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "Background Image"))
				{
					if (string_ == "Background Video" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_13("No Videos!");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_13("No Images!");
				}
				if (text == "")
				{
					text = GClass4.gclass4_0.method_13("None");
				}
			}
		}
		else
		{
			text = this.gclass5_0.String_0;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00060300 File Offset: 0x0005E500
	public virtual void vmethod_88()
	{
		if (this.string_0 == null)
		{
			string a = base.method_39();
			if (!(a == ""))
			{
				if (!(a == "language"))
				{
					if (a == "Bot")
					{
						GlobalVariables.instance.method_68();
						this.method_57();
						return;
					}
					if (!(a == "Song Settings"))
					{
						if (a == "song_backgrounds")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_18;
						}
					}
					else
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_36;
					}
				}
				else
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_19;
					if (!this.bool_13)
					{
						this.gclass5_0.CurrentValue = 0;
					}
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_17;
				if (!this.bool_12)
				{
					this.gclass5_0.method_3(-93);
				}
			}
			this.string_0 = base.String_0;
			this.method_50();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x00006841 File Offset: 0x00004A41
	protected virtual void vmethod_89()
	{
		base.OnEnable();
		this.method_53();
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x0000684F File Offset: 0x00004A4F
	public virtual void vmethod_90()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = false;
		this.method_44();
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x0000687D File Offset: 0x00004A7D
	public virtual void vmethod_91()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_45();
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00060410 File Offset: 0x0005E610
	private void method_47()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths == null || GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length > 1);
		GlobalVariables.instance.gclass5_17.Int32_0 = (this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 1) : -104);
		GlobalVariables.instance.gclass5_19.method_12(this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 0) : 105);
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x000604B8 File Offset: 0x0005E6B8
	public virtual void vmethod_92()
	{
		if (this.string_0 == null)
		{
			string string_ = base.String_0;
			if (!(string_ == "<color=#FFFF04FF>"))
			{
				if (!(string_ == "song_preview"))
				{
					if (string_ == "")
					{
						GlobalVariables.instance.method_68();
						this.method_49();
						return;
					}
					if (!(string_ == "Problem saving setlist"))
					{
						if (string_ == "")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_18;
						}
					}
					else
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_36;
					}
				}
				else
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_19;
					if (!this.bool_13)
					{
						this.gclass5_0.CurrentValue = 119;
					}
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_17;
				if (!this.bool_12)
				{
					this.gclass5_0.method_3(78);
				}
			}
			this.string_0 = base.String_0;
			this.method_60();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x000068AB File Offset: 0x00004AAB
	protected virtual void vmethod_94()
	{
		base.OnEnable();
		this.method_56();
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x000068B9 File Offset: 0x00004AB9
	public virtual void vmethod_95()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_52();
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x000068E7 File Offset: 0x00004AE7
	protected virtual void vmethod_96()
	{
		base.vmethod_9();
		this.method_61();
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x000068F5 File Offset: 0x00004AF5
	public virtual void vmethod_97()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_58();
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x00006923 File Offset: 0x00004B23
	protected virtual void vmethod_98()
	{
		base.OnEnable();
		this.method_51();
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x00006931 File Offset: 0x00004B31
	public virtual void vmethod_99()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x00006967 File Offset: 0x00004B67
	protected virtual void vmethod_100()
	{
		base.vmethod_9();
		this.method_64();
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00006753 File Offset: 0x00004953
	public virtual void vmethod_101()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x000606D8 File Offset: 0x0005E8D8
	private void method_48()
	{
		string text = "song";
		if (!(this.string_0 == "Video Start Time") && !(this.string_0 == "Show Bot Score"))
		{
			if (this.gclass5_0.method_5() >= 1)
			{
				string string_ = this.string_0;
				if (!(string_ == "background_video"))
				{
					if (string_ == "volume")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.CurrentValue]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.method_25()]);
				}
			}
			else if (this.gclass5_0.CurrentValue == -1)
			{
				text = GClass4.gclass4_0.method_46("beat");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "bad_note2"))
				{
					if (string_ == "Press Enter to confirm" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_2("Awesome Solo!");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_30("diff_bass");
				}
				if (text == "debug_fps")
				{
					text = GClass4.gclass4_0.method_15("Yes");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0006083C File Offset: 0x0005EA3C
	private void method_49()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths != null && GlobalVariables.instance.backgroundImagePaths.Length > 1);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length != 0);
		GlobalVariables.instance.gclass5_17.method_12(this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 0) : 106);
		GlobalVariables.instance.gclass5_19.method_12(this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 1) : -8);
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x000608E4 File Offset: 0x0005EAE4
	private void method_50()
	{
		string text = "Unknown Artist";
		if (!(this.string_0 == "song.ini") && !(this.string_0 == "bad_note5"))
		{
			if (this.gclass5_0.method_5() >= 1)
			{
				string string_ = this.string_0;
				if (!(string_ == " - "))
				{
					if (string_ == "enable_lyrics")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_5()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.method_25()]);
				}
			}
			else if (this.gclass5_0.method_5() == -1)
			{
				text = GClass4.gclass4_0.method_16("Mirror Mode");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "HUD"))
				{
					if (string_ == "Playlist" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_7("video");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_21("Couldn't load that song");
				}
				if (text == "ControlMapper")
				{
					text = GClass4.gclass4_0.method_15("No scores saved for this song on");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00006975 File Offset: 0x00004B75
	public virtual void vmethod_102()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_44();
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x000069A3 File Offset: 0x00004BA3
	public virtual void vmethod_103()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_62();
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x00060A48 File Offset: 0x0005EC48
	private void method_51()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths == null || GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length > 1);
		GlobalVariables.instance.gclass5_17.method_12(this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 0) : -48);
		GlobalVariables.instance.gclass5_19.Int32_0 = (this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 1) : 68);
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x000069D1 File Offset: 0x00004BD1
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00060AF0 File Offset: 0x0005ECF0
	private void method_52()
	{
		string text = "Game Manager";
		if (!(this.string_0 == "You must restart, settings were changed") && !(this.string_0 == "Resolution"))
		{
			if (this.gclass5_0.CurrentValue >= 0)
			{
				string string_ = this.string_0;
				if (!(string_ == "band"))
				{
					if (string_ == "Are you sure you want to quit?")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_5()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.method_25()]);
				}
			}
			else if (this.gclass5_0.method_25() == -1)
			{
				text = GClass4.gclass4_0.method_17("1");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "Scan Songs"))
				{
					if (string_ == "phrase_start" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_36("Continue");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_38("album");
				}
				if (text == "Lights Out")
				{
					text = GClass4.gclass4_0.method_46("song");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00060C54 File Offset: 0x0005EE54
	private void method_53()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths != null && GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length != 0);
		GlobalVariables.instance.gclass5_17.method_16(this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 0) : 71);
		GlobalVariables.instance.gclass5_19.Int32_0 = (this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 0) : 71);
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x00006753 File Offset: 0x00004953
	public virtual void vmethod_104()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x000069FF File Offset: 0x00004BFF
	public virtual void vmethod_105()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_54();
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00006A2D File Offset: 0x00004C2D
	public virtual void vmethod_106()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00060CFC File Offset: 0x0005EEFC
	private void method_54()
	{
		string text = "</color>";
		if (!(this.string_0 == "No Source") && !(this.string_0 == "graphics_api_version"))
		{
			if (this.gclass5_0.method_5() >= 1)
			{
				string string_ = this.string_0;
				if (!(string_ == "note_animation"))
				{
					if (string_ == "video")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_5()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.method_5()]);
				}
			}
			else if (this.gclass5_0.method_5() == -1)
			{
				text = GClass4.gclass4_0.method_48("Client disconnected");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "No"))
				{
					if (string_ == "backend" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_48("All Opens");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_5("volume");
				}
				if (text == "song")
				{
					text = GClass4.gclass4_0.method_36("");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00060E60 File Offset: 0x0005F060
	private void method_55()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths == null || GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length > 1);
		GlobalVariables.instance.gclass5_17.Int32_0 = (this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 1) : -113);
		GlobalVariables.instance.gclass5_19.Int32_0 = (this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 0) : 24);
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00060F08 File Offset: 0x0005F108
	private void method_56()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths != null && GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length != 0);
		GlobalVariables.instance.gclass5_17.method_12(this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 1) : 94);
		GlobalVariables.instance.gclass5_19.method_16(this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 1) : 25);
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00006A63 File Offset: 0x00004C63
	public virtual void vmethod_107()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_50();
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00006A91 File Offset: 0x00004C91
	protected virtual void vmethod_108()
	{
		base.OnEnable();
		this.method_47();
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00006A9F File Offset: 0x00004C9F
	public virtual void vmethod_109()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_60();
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00060FB0 File Offset: 0x0005F1B0
	private void method_57()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths == null || GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length != 0);
		GlobalVariables.instance.gclass5_17.method_16(this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 1) : 24);
		GlobalVariables.instance.gclass5_19.method_16(this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 1) : -95);
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00006931 File Offset: 0x00004B31
	public virtual void vmethod_110()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00061058 File Offset: 0x0005F258
	private void method_58()
	{
		string text = "A setlist with that name already exists";
		if (!(this.string_0 == "Songs") && !(this.string_0 == "Difficulty"))
		{
			if (this.gclass5_0.CurrentValue >= 0)
			{
				string string_ = this.string_0;
				if (!(string_ == "Bass Guitar"))
				{
					if (string_ == "{0:N0} FPS")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_5()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.CurrentValue]);
				}
			}
			else if (this.gclass5_0.CurrentValue == -1)
			{
				text = GClass4.gclass4_0.method_48("/");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "Create Profile"))
				{
					if (string_ == "Bass" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_17("Practice");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_35("Discord: error {0}: {1}");
				}
				if (text == "No Fail")
				{
					text = GClass4.gclass4_0.method_30("Problem loading setlist");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00006ACD File Offset: 0x00004CCD
	public virtual void vmethod_111()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_60();
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x000611BC File Offset: 0x0005F3BC
	private void method_59()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths != null && GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length != 0);
		GlobalVariables.instance.gclass5_17.Int32_0 = (this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 1) : -2);
		GlobalVariables.instance.gclass5_19.Int32_0 = (this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 1) : -2);
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00061264 File Offset: 0x0005F464
	private void method_60()
	{
		string text = "0%";
		if (!(this.string_0 == "Skip Song") && !(this.string_0 == "Keyboard"))
		{
			if (this.gclass5_0.method_25() >= 1)
			{
				string string_ = this.string_0;
				if (!(string_ == "6 Fret Lead Guitar"))
				{
					if (string_ == "solo")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.CurrentValue]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.method_5()]);
				}
			}
			else if (this.gclass5_0.method_25() == -1)
			{
				text = GClass4.gclass4_0.method_11("song");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == ""))
				{
					if (string_ == "has_bots" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_5("volume");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_42("Master Volume");
				}
				if (text == "")
				{
					text = GClass4.gclass4_0.method_13("Medium");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00006AFB File Offset: 0x00004CFB
	public virtual void vmethod_112()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_48();
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x000613C8 File Offset: 0x0005F5C8
	private void method_61()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths == null || GlobalVariables.instance.backgroundImagePaths.Length > 1);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length != 0);
		GlobalVariables.instance.gclass5_17.Int32_0 = (this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 0) : -81);
		GlobalVariables.instance.gclass5_19.method_16(this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 0) : 49);
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x000068F5 File Offset: 0x00004AF5
	public virtual void vmethod_113()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_58();
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00006B29 File Offset: 0x00004D29
	public virtual void vmethod_114()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_60();
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00061470 File Offset: 0x0005F670
	private void method_62()
	{
		string text = "Start typing...";
		if (!(this.string_0 == "msaa") && !(this.string_0 == "<"))
		{
			if (this.gclass5_0.method_25() >= 1)
			{
				string string_ = this.string_0;
				if (!(string_ == "game"))
				{
					if (string_ == "game")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_25()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.CurrentValue]);
				}
			}
			else if (this.gclass5_0.method_5() == -1)
			{
				text = GClass4.gclass4_0.method_36("Open Data Privacy Page");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "All HOPO's"))
				{
					if (string_ == "SORTING BY" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_36("Yo dawg, I heard you like lanes so this activates lanes!");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_2("song");
				}
				if (text == "Song Options")
				{
					text = GClass4.gclass4_0.method_7("en-US");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00006931 File Offset: 0x00004B31
	public virtual void vmethod_115()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x000615D4 File Offset: 0x0005F7D4
	private void method_63()
	{
		string text = "bad_note4";
		if (!(this.string_0 == "No") && !(this.string_0 == "volume"))
		{
			if (this.gclass5_0.CurrentValue >= 0)
			{
				string string_ = this.string_0;
				if (!(string_ == "MSAA Level"))
				{
					if (string_ == "drums")
					{
						text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroungVideoPaths[this.gclass5_0.method_5()]);
					}
				}
				else
				{
					text = Path.GetFileNameWithoutExtension(GlobalVariables.instance.backgroundImagePaths[this.gclass5_0.method_25()]);
				}
			}
			else if (this.gclass5_0.CurrentValue == -1)
			{
				text = GClass4.gclass4_0.method_11("streamer");
			}
			else
			{
				string string_ = this.string_0;
				if (!(string_ == "custom"))
				{
					if (string_ == "rhythm" && !this.bool_13)
					{
						text = GClass4.gclass4_0.method_42("Discord: error {0}: {1}");
					}
				}
				else if (!this.bool_12)
				{
					text = GClass4.gclass4_0.method_46("has_bots");
				}
				if (text == "Error reading profile file!")
				{
					text = GClass4.gclass4_0.method_41("...");
				}
			}
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00006753 File Offset: 0x00004953
	public virtual void vmethod_116()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00006B57 File Offset: 0x00004D57
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00006B8D File Offset: 0x00004D8D
	protected override void OnEnable()
	{
		base.OnEnable();
		this.method_59();
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00006753 File Offset: 0x00004953
	public virtual void vmethod_117()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00006B9B File Offset: 0x00004D9B
	public virtual void vmethod_118()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = false;
		this.method_46();
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00006BC9 File Offset: 0x00004DC9
	public virtual void vmethod_119()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = false;
		this.method_62();
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00061738 File Offset: 0x0005F938
	private void method_64()
	{
		this.bool_12 = (GlobalVariables.instance.backgroundImagePaths != null && GlobalVariables.instance.backgroundImagePaths.Length != 0);
		this.bool_13 = (GlobalVariables.instance.backgroungVideoPaths != null && GlobalVariables.instance.backgroungVideoPaths.Length > 1);
		GlobalVariables.instance.gclass5_17.method_12(this.bool_12 ? (GlobalVariables.instance.backgroundImagePaths.Length - 0) : 112);
		GlobalVariables.instance.gclass5_19.method_16(this.bool_13 ? (GlobalVariables.instance.backgroungVideoPaths.Length - 0) : -27);
	}

	// Token: 0x04000202 RID: 514
	private bool bool_12;

	// Token: 0x04000203 RID: 515
	private bool bool_13;

	// Token: 0x04000204 RID: 516
	[SerializeField]
	private BaseMenu optionsMenu;
}
