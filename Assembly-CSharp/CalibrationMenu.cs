using System;
using Un4seen.Bass;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000042 RID: 66
public class CalibrationMenu : BaseMenu
{
	// Token: 0x06000B90 RID: 2960 RVA: 0x00006149 File Offset: 0x00004349
	public virtual void vmethod_81()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0005E890 File Offset: 0x0005CA90
	private void method_44()
	{
		string text = "errors.txt";
		string string_ = this.string_0;
		if (!(string_ == "guitar") && !(string_ == "enable_cursor"))
		{
			if (string_ == "These folders contain charts that don't have any supported instruments charted!")
			{
				text = this.gclass5_1.method_9();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0000617F File Offset: 0x0000437F
	public virtual void vmethod_82()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_50();
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x000061AD File Offset: 0x000043AD
	public virtual void vmethod_83()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0005E900 File Offset: 0x0005CB00
	private void method_45()
	{
		string text = "drums";
		string string_ = this.string_0;
		if (!(string_ == "Current High Score") && !(string_ == "%p"))
		{
			if (string_ == "6 Fret Lead Guitar")
			{
				text = this.gclass5_1.method_10();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x000061E3 File Offset: 0x000043E3
	public virtual void vmethod_84()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x0005E970 File Offset: 0x0005CB70
	public override void vmethod_39()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			if (!(string_ == "Video Offset"))
			{
				if (!(string_ == "Audio Offset"))
				{
					if (string_ == "Get Hardware Latency")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "Show Hit Window")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_51();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_50();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x00006149 File Offset: 0x00004349
	public virtual void vmethod_85()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0005EA5C File Offset: 0x0005CC5C
	private void method_46()
	{
		string text = "Rhythm";
		string string_ = this.string_0;
		if (!(string_ == "Songs") && !(string_ == "Bot"))
		{
			if (string_ == " + ")
			{
				text = this.gclass5_1.method_9();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x00006219 File Offset: 0x00004419
	public virtual void vmethod_86()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_1.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_45();
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x000061AD File Offset: 0x000043AD
	public virtual void vmethod_87()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00006247 File Offset: 0x00004447
	public virtual void vmethod_88()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_1.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_51();
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x0005EACC File Offset: 0x0005CCCC
	private void method_47()
	{
		string text = "volume";
		string string_ = this.string_0;
		if (!(string_ == "game") && !(string_ == "["))
		{
			if (string_ == "sp_awarded")
			{
				text = this.gclass5_1.method_9();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00006275 File Offset: 0x00004475
	private void method_48()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_21("charter");
		}
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x000061E3 File Offset: 0x000043E3
	public virtual void vmethod_89()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0000629E File Offset: 0x0000449E
	private void method_49()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_35("Allow Duplicate Songs");
		}
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x000062C7 File Offset: 0x000044C7
	private void Awake()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_13("CALIBRATION");
		}
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x000062F0 File Offset: 0x000044F0
	public virtual void vmethod_90()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_52();
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x0005EB3C File Offset: 0x0005CD3C
	private void method_50()
	{
		string text = "Mirror Mode";
		string string_ = this.string_0;
		if (!(string_ == "Camera") && !(string_ == "Unknown Charter"))
		{
			if (string_ == "Prefabs/Gameplay/Players/Guitar Player ")
			{
				text = this.gclass5_1.String_0;
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0000631E File Offset: 0x0000451E
	public virtual void vmethod_91()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_1.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_54();
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x0000634C File Offset: 0x0000454C
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_51();
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x0005EBAC File Offset: 0x0005CDAC
	public virtual void vmethod_92()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == "Setlist was saved"))
			{
				if (!(string_ == "song"))
				{
					if (string_ == "streamer")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "video")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_57();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_50();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00006149 File Offset: 0x00004349
	public virtual void vmethod_93()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x0005EC98 File Offset: 0x0005CE98
	private void method_51()
	{
		string text = "";
		string string_ = this.string_0;
		if (!(string_ == "Video Offset") && !(string_ == "Audio Offset"))
		{
			if (string_ == "Show Hit Window")
			{
				text = this.gclass5_1.String_0;
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x0005ED08 File Offset: 0x0005CF08
	private void method_52()
	{
		string text = "\r\n";
		string string_ = this.string_0;
		if (!(string_ == "Prefabs/Gameplay/Notes/Beatline") && !(string_ == "game"))
		{
			if (string_ == "vocals")
			{
				text = this.gclass5_1.method_10();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x0005ED78 File Offset: 0x0005CF78
	public virtual void vmethod_94()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == "Rhythm Guitar"))
			{
				if (!(string_ == "_ENDOFSONG"))
				{
					if (string_ == "Monika")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "charter")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_54();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x0000637A File Offset: 0x0000457A
	public virtual void vmethod_95()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_1.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_47();
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x0005EE64 File Offset: 0x0005D064
	public virtual void vmethod_96()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == "Game Manager"))
			{
				if (!(string_ == "song"))
				{
					if (string_ == "part bass")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "part keys")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_62();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x000063A8 File Offset: 0x000045A8
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_51();
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x000063D6 File Offset: 0x000045D6
	private void method_53()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_16("+");
		}
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x0005EF50 File Offset: 0x0005D150
	public virtual void vmethod_97()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == "genre"))
			{
				if (!(string_ == "Attempted to load non-existant background index {0}.\n{1}"))
				{
					if (string_ == "Quit")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "diff_drums")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_50();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_50();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = false;
		}
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x0005F03C File Offset: 0x0005D23C
	public virtual void vmethod_98()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == "song"))
			{
				if (!(string_ == "Quickplay"))
				{
					if (string_ == "\"section")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.method_3(bass_INFO.latency);
						this.string_0 = null;
						return;
					}
					if (string_ == "Problem loading setlist")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_44();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00006149 File Offset: 0x00004349
	public virtual void vmethod_99()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x0005F128 File Offset: 0x0005D328
	public virtual void vmethod_100()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == "enable_lyrics"))
			{
				if (!(string_ == "Portuguese"))
				{
					if (string_ == "note_animation")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "volume")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_51();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_50();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = false;
		}
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x000063FF File Offset: 0x000045FF
	public virtual void vmethod_101()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_51();
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x0000642D File Offset: 0x0000462D
	public virtual void vmethod_102()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x00006149 File Offset: 0x00004349
	public virtual void vmethod_103()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00006149 File Offset: 0x00004349
	public virtual void vmethod_104()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00006463 File Offset: 0x00004663
	public virtual void vmethod_105()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x0005F214 File Offset: 0x0005D414
	private void method_54()
	{
		string text = "Song Length";
		string string_ = this.string_0;
		if (!(string_ == "[\\-\\+]?\\d+(\\.\\d+)?") && !(string_ == "Genre = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""))
		{
			if (string_ == "Rescan Custom Content")
			{
				text = this.gclass5_1.method_10();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00006491 File Offset: 0x00004691
	public virtual void vmethod_106()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_7();
		this.optionsMenu.bool_10 = false;
		this.method_44();
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x000064BF File Offset: 0x000046BF
	public virtual void vmethod_107()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_19();
		this.optionsMenu.bool_10 = false;
		this.method_62();
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x000064ED File Offset: 0x000046ED
	public virtual void vmethod_108()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_64();
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x0005F284 File Offset: 0x0005D484
	public virtual void vmethod_109()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == ""))
			{
				if (!(string_ == "No Videos!"))
				{
					if (string_ == "video")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.method_3(bass_INFO.latency);
						this.string_0 = null;
						return;
					}
					if (string_ == "")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_51();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = false;
		}
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x000061E3 File Offset: 0x000043E3
	public virtual void vmethod_110()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x0005F370 File Offset: 0x0005D570
	private void method_55()
	{
		string text = "Note: ";
		string string_ = this.string_0;
		if (!(string_ == "Artist") && !(string_ == ""))
		{
			if (string_ == "game")
			{
				text = this.gclass5_1.method_9();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0005F3E0 File Offset: 0x0005D5E0
	public virtual void vmethod_111()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == "Okay"))
			{
				if (!(string_ == "notes.chart"))
				{
					if (string_ == "Bad Songs")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "HOPO's to Taps")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_51();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = false;
		}
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x0000651B File Offset: 0x0000471B
	private void method_56()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_11("/Video Backgrounds");
		}
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00006544 File Offset: 0x00004744
	public virtual void vmethod_112()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_19();
		this.optionsMenu.bool_10 = true;
		this.method_62();
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00006149 File Offset: 0x00004349
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x0005F4CC File Offset: 0x0005D6CC
	public virtual void vmethod_113()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			if (!(string_ == ""))
			{
				if (!(string_ == "All Taps"))
				{
					if (string_ == "Language")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.method_3(bass_INFO.latency);
						this.string_0 = null;
						return;
					}
					if (string_ == "vocals")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_52();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x0000642D File Offset: 0x0000462D
	public virtual void vmethod_114()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0005F5B8 File Offset: 0x0005D7B8
	public virtual void vmethod_115()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			if (!(string_ == "game"))
			{
				if (!(string_ == "offsets"))
				{
					if (string_ == "year")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "framerate")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_54();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = false;
		}
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0005F6A4 File Offset: 0x0005D8A4
	public virtual void vmethod_116()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			if (!(string_ == "SCANNING FOLDERS..."))
			{
				if (!(string_ == "poll_rate"))
				{
					if (string_ == "Unknown Year")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "Songs are still scanning...")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_45();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_50();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00006572 File Offset: 0x00004772
	public virtual void vmethod_117()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_54();
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x0005F790 File Offset: 0x0005D990
	public virtual void vmethod_118()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			if (!(string_ == "Yes"))
			{
				if (!(string_ == "Unknown Charter"))
				{
					if (string_ == "song")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "Expert")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_45();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_50();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = false;
		}
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x000065A0 File Offset: 0x000047A0
	public virtual void vmethod_119()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_19();
		this.optionsMenu.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x0005F87C File Offset: 0x0005DA7C
	private void method_57()
	{
		string text = "nomodifiers";
		string string_ = this.string_0;
		if (!(string_ == "") && !(string_ == "settings.ini"))
		{
			if (string_ == "directories")
			{
				text = this.gclass5_1.method_9();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x000065CE File Offset: 0x000047CE
	public virtual void vmethod_120()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_29();
		this.optionsMenu.bool_10 = true;
		this.method_52();
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x000065FC File Offset: 0x000047FC
	public virtual void vmethod_121()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_29();
		this.optionsMenu.bool_10 = true;
		this.method_47();
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x0000662A File Offset: 0x0000482A
	public virtual void vmethod_122()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_1.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_45();
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x0005F8EC File Offset: 0x0005DAEC
	public virtual void vmethod_123()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			if (!(string_ == "Easy"))
			{
				if (!(string_ == "Song Offset"))
				{
					if (string_ == "Song Speed")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.method_3(bass_INFO.latency);
						this.string_0 = null;
						return;
					}
					if (string_ == "song")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_62();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = false;
		}
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00006658 File Offset: 0x00004858
	private void method_58()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_5("Full Song");
		}
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x000061AD File Offset: 0x000043AD
	public virtual void vmethod_124()
	{
		if (this.string_0 != null)
		{
			this.gclass5_1 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x0000634C File Offset: 0x0000454C
	public virtual void vmethod_125()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_51();
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00006681 File Offset: 0x00004881
	public virtual void vmethod_126()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_1.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_51();
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x000066AF File Offset: 0x000048AF
	private void method_59()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_30(" + ");
		}
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x000066D8 File Offset: 0x000048D8
	private void method_60()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_21("song");
		}
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00006701 File Offset: 0x00004901
	private void method_61()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_35("Show FPS");
		}
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x0005F9D8 File Offset: 0x0005DBD8
	private void method_62()
	{
		string text = "background_video";
		string string_ = this.string_0;
		if (!(string_ == "\\D") && !(string_ == "Guitar - "))
		{
			if (string_ == "song")
			{
				text = this.gclass5_1.String_0;
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x0005FA48 File Offset: 0x0005DC48
	public virtual void vmethod_127()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			if (!(string_ == "Song"))
			{
				if (!(string_ == "Lights Out"))
				{
					if (string_ == "Yes")
					{
						BASS_INFO bass_INFO = Bass.BASS_GetInfo();
						GlobalVariables.instance.songSpeed.CurrentValue = bass_INFO.latency;
						this.string_0 = null;
						return;
					}
					if (string_ == "Close")
					{
						this.gclass5_1 = GlobalVariables.instance.gclass5_33;
					}
				}
				else
				{
					this.gclass5_1 = GlobalVariables.instance.songSpeed;
				}
			}
			else
			{
				this.gclass5_1 = GlobalVariables.instance.videoOffset;
			}
			this.method_64();
			return;
		}
		this.gclass5_1 = null;
		this.string_0 = null;
		this.vmethod_30();
		if (this.pauseMenu != null)
		{
			this.pauseMenu.bool_12 = true;
		}
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0000672A File Offset: 0x0000492A
	private void method_63()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_15("Lefty Flip");
		}
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0005FB34 File Offset: 0x0005DD34
	private void method_64()
	{
		string text = "Gameplay";
		string string_ = this.string_0;
		if (!(string_ == "video") && !(string_ == ")"))
		{
			if (string_ == "Band")
			{
				text = this.gclass5_1.method_10();
			}
		}
		else
		{
			text = this.gclass5_1.String_3;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x040001FE RID: 510
	[SerializeField]
	private BaseMenu optionsMenu;

	// Token: 0x040001FF RID: 511
	[SerializeField]
	private PauseMenu pauseMenu;

	// Token: 0x04000200 RID: 512
	[SerializeField]
	private Text pausedText;

	// Token: 0x04000201 RID: 513
	private GameSetting gclass5_1;
}
