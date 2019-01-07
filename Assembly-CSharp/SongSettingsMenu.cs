using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200004E RID: 78
public class SongSettingsMenu : BaseMenu
{
	// Token: 0x06000E4B RID: 3659 RVA: 0x000081BA File Offset: 0x000063BA
	public virtual void vmethod_81()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 110, 186, 64);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x000696E8 File Offset: 0x000678E8
	public override void vmethod_48()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string_ = this.string_0;
			if (!(string_ == "no_fail"))
			{
				if (string_ == "Bad file type")
				{
					this.int_4 = SongEntry.currentSongOffset;
				}
			}
			else
			{
				this.int_4 = SongEntry.videoStart;
			}
			this.method_44();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == ": <color=#FDB400FF>"))
		{
			if (string_ == "artist")
			{
				SongEntry.currentSongOffset = this.int_4;
			}
		}
		else
		{
			SongEntry.videoStart = this.int_4;
		}
		this.string_0 = null;
		this.vmethod_30();
		this.pauseMenu.bool_12 = this.bool_12;
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x000081EF File Offset: 0x000063EF
	private void Awake()
	{
		this.pausedText.text = GClass4.gclass4_0.method_13("SONG SETTINGS");
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x0000820B File Offset: 0x0000640B
	protected virtual void vmethod_82()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x0000820B File Offset: 0x0000640B
	protected override void Update()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00008221 File Offset: 0x00006421
	public virtual void vmethod_83()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 74, -17, -161);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00008256 File Offset: 0x00006456
	public virtual void vmethod_84()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 13, 23, 124);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x0000828B File Offset: 0x0000648B
	public override void vmethod_36()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 + 100, -2147483647, int.MaxValue);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x000697A0 File Offset: 0x000679A0
	private void method_44()
	{
		string text = "";
		string string_ = this.string_0;
		if (string_ == "Video Start Time" || string_ == "Song Offset")
		{
			text = this.int_4.ToString() + "ms";
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00069800 File Offset: 0x00067A00
	public virtual void vmethod_85()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string_ = this.string_0;
			if (!(string_ == "ui_lose_multiplier"))
			{
				if (string_ == "directories")
				{
					this.int_4 = SongEntry.currentSongOffset;
				}
			}
			else
			{
				this.int_4 = SongEntry.videoStart;
			}
			this.method_44();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "HOPO's to Taps"))
		{
			if (string_ == "")
			{
				SongEntry.currentSongOffset = this.int_4;
			}
		}
		else
		{
			SongEntry.videoStart = this.int_4;
		}
		this.string_0 = null;
		this.vmethod_30();
		this.pauseMenu.bool_12 = this.bool_12;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x000082C0 File Offset: 0x000064C0
	private void method_45()
	{
		this.pausedText.text = GClass4.gclass4_0.method_5("playlist_track");
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x000698B8 File Offset: 0x00067AB8
	public virtual void vmethod_86()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "Song Offset" || string_ == "\\s+")
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 0, -88, 79);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00069920 File Offset: 0x00067B20
	public virtual void vmethod_87()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "graphics_api_version" || string_ == "Yes")
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 1, -121, 173);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00069988 File Offset: 0x00067B88
	public virtual void vmethod_88()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.bool_12)
		{
			try
			{
				GlobalVariables.instance.currentSongEntry.method_3();
				this.vmethod_15();
				this.pauseMenu.gameObject.SetActive(true);
			}
			catch
			{
				this.pauseMenu.bool_12 = true;
				this.confirmMenu.method_45("Resolution", "ms", null, null, null, null);
			}
			this.bool_12 = false;
			return;
		}
		this.vmethod_15();
		this.pauseMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00069A34 File Offset: 0x00067C34
	public virtual void vmethod_89()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string_ = this.string_0;
			if (!(string_ == " "))
			{
				if (string_ == "song")
				{
					this.int_4 = SongEntry.currentSongOffset;
				}
			}
			else
			{
				this.int_4 = SongEntry.videoStart;
			}
			this.method_44();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "Not match flags next {0} {1}"))
		{
			if (string_ == "New Section")
			{
				SongEntry.currentSongOffset = this.int_4;
			}
		}
		else
		{
			SongEntry.videoStart = this.int_4;
		}
		this.string_0 = null;
		this.vmethod_50();
		this.pauseMenu.bool_12 = this.bool_12;
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x000082DC File Offset: 0x000064DC
	private void method_46()
	{
		this.pausedText.text = GClass4.gclass4_0.method_36("0%");
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00069AEC File Offset: 0x00067CEC
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "Video Start Time" || string_ == "Song Offset")
		{
			this.int_4 = Mathf.Clamp(this.int_4 + 1, -2147483647, int.MaxValue);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x000082F8 File Offset: 0x000064F8
	public virtual void vmethod_90()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - -77, 124, -139);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00069B54 File Offset: 0x00067D54
	public virtual void vmethod_91()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "There are no saved setlists" || string_ == "ui_lose_multiplier")
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 0, 54, 184);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00069BBC File Offset: 0x00067DBC
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.bool_12)
		{
			try
			{
				GlobalVariables.instance.currentSongEntry.method_3();
				this.vmethod_15();
				this.pauseMenu.gameObject.SetActive(true);
			}
			catch
			{
				this.pauseMenu.bool_12 = false;
				this.confirmMenu.method_44("Error writing metadata", "Okay", null, null, null, null);
			}
			this.bool_12 = false;
			return;
		}
		this.vmethod_15();
		this.pauseMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x0000832D File Offset: 0x0000652D
	private void method_47()
	{
		this.pausedText.text = GClass4.gclass4_0.method_16("Menu Music");
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00069C68 File Offset: 0x00067E68
	public virtual void vmethod_92()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "Tilt" || string_ == "Default Sort Filter")
		{
			this.int_4 = Mathf.Clamp(this.int_4 + 0, -77, -192);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00008349 File Offset: 0x00006549
	private void method_48()
	{
		this.pausedText.text = GClass4.gclass4_0.method_35("Enable");
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00008365 File Offset: 0x00006565
	private void method_49()
	{
		this.pausedText.text = GClass4.gclass4_0.method_35("framerate");
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00069CD0 File Offset: 0x00067ED0
	public virtual void vmethod_93()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string_ = this.string_0;
			if (!(string_ == "None"))
			{
				if (string_ == "\\d+ = E \"section [^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
				{
					this.int_4 = SongEntry.currentSongOffset;
				}
			}
			else
			{
				this.int_4 = SongEntry.videoStart;
			}
			this.method_44();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "vocals_1"))
		{
			if (string_ == "GETTING FOLDERS...")
			{
				SongEntry.currentSongOffset = this.int_4;
			}
		}
		else
		{
			SongEntry.videoStart = this.int_4;
		}
		this.string_0 = null;
		this.vmethod_30();
		this.pauseMenu.bool_12 = this.bool_12;
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00069D88 File Offset: 0x00067F88
	public virtual void vmethod_94()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string_ = this.string_0;
			if (!(string_ == "Hard"))
			{
				if (string_ == "Get rid of it!")
				{
					this.int_4 = SongEntry.currentSongOffset;
				}
			}
			else
			{
				this.int_4 = SongEntry.videoStart;
			}
			this.method_44();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "Unknown Charter"))
		{
			if (string_ == "Go to Discord")
			{
				SongEntry.currentSongOffset = this.int_4;
			}
		}
		else
		{
			SongEntry.videoStart = this.int_4;
		}
		this.string_0 = null;
		this.vmethod_30();
		this.pauseMenu.bool_12 = this.bool_12;
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00008381 File Offset: 0x00006581
	public virtual void vmethod_95()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 8, 175, 71);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00069E40 File Offset: 0x00068040
	public virtual void vmethod_96()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string_ = this.string_0;
			if (!(string_ == "Unknown Year"))
			{
				if (string_ == "\\D+")
				{
					this.int_4 = SongEntry.currentSongOffset;
				}
			}
			else
			{
				this.int_4 = SongEntry.videoStart;
			}
			this.method_44();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "Flames"))
		{
			if (string_ == "These folders either have no audio files, the audio files are named incorrectly or the audio files are in the wrong format!")
			{
				SongEntry.currentSongOffset = this.int_4;
			}
		}
		else
		{
			SongEntry.videoStart = this.int_4;
		}
		this.string_0 = null;
		this.vmethod_50();
		this.pauseMenu.bool_12 = this.bool_12;
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x000083B6 File Offset: 0x000065B6
	public virtual void vmethod_97()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - -33, -70, -73);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x0000820B File Offset: 0x0000640B
	protected virtual void vmethod_98()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00069EF8 File Offset: 0x000680F8
	public virtual void vmethod_99()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "Year" || string_ == "game")
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 1, -84, -89);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00069F60 File Offset: 0x00068160
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "Video Start Time" || string_ == "Song Offset")
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 1, -2147483647, int.MaxValue);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x000083EB File Offset: 0x000065EB
	private void method_50()
	{
		this.pausedText.text = GClass4.gclass4_0.method_15("t1 gems");
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00069FC8 File Offset: 0x000681C8
	public override void vmethod_39()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string_ = this.string_0;
			if (!(string_ == "Video Start Time"))
			{
				if (string_ == "Song Offset")
				{
					this.int_4 = SongEntry.currentSongOffset;
				}
			}
			else
			{
				this.int_4 = SongEntry.videoStart;
			}
			this.method_44();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "Video Start Time"))
		{
			if (string_ == "Song Offset")
			{
				SongEntry.currentSongOffset = this.int_4;
			}
		}
		else
		{
			SongEntry.videoStart = this.int_4;
		}
		this.string_0 = null;
		this.vmethod_50();
		this.pauseMenu.bool_12 = this.bool_12;
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00008407 File Offset: 0x00006607
	public override void vmethod_7()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 100, -2147483647, int.MaxValue);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x0000843C File Offset: 0x0000663C
	public virtual void vmethod_100()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 23, 68, 20);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0006A080 File Offset: 0x00068280
	public virtual void vmethod_101()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "delay" || string_ == "Ready")
		{
			this.int_4 = Mathf.Clamp(this.int_4 - 0, -128, 106);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x0006A0E8 File Offset: 0x000682E8
	public virtual void vmethod_102()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		string string_ = this.string_0;
		if (string_ == ": " || string_ == "diff_rhythm")
		{
			this.int_4 = Mathf.Clamp(this.int_4 + 0, -5, -59);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00008471 File Offset: 0x00006671
	public virtual void vmethod_103()
	{
		if (this.string_0 != null)
		{
			this.int_4 = Mathf.Clamp(this.int_4 + 16, -11, -39);
		}
		this.bool_12 = false;
		this.method_44();
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x0006A150 File Offset: 0x00068350
	public virtual void vmethod_104()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.bool_12)
		{
			try
			{
				GlobalVariables.instance.currentSongEntry.method_1();
				this.vmethod_15();
				this.pauseMenu.gameObject.SetActive(false);
			}
			catch
			{
				this.pauseMenu.bool_12 = true;
				this.confirmMenu.method_45("Audio Offset", "No", null, null, null, null);
			}
			this.bool_12 = true;
			return;
		}
		this.vmethod_15();
		this.pauseMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x0006A1FC File Offset: 0x000683FC
	public virtual void vmethod_105()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.bool_12)
		{
			try
			{
				GlobalVariables.instance.currentSongEntry.method_3();
				this.vmethod_15();
				this.pauseMenu.gameObject.SetActive(false);
			}
			catch
			{
				this.pauseMenu.bool_12 = false;
				this.confirmMenu.method_45("Vsync", "Guitar Coop", null, null, null, null);
			}
			this.bool_12 = true;
			return;
		}
		this.vmethod_15();
		this.pauseMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x0006A2A8 File Offset: 0x000684A8
	public virtual void vmethod_106()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.bool_12)
		{
			try
			{
				GlobalVariables.instance.currentSongEntry.method_10();
				this.vmethod_15();
				this.pauseMenu.gameObject.SetActive(false);
			}
			catch
			{
				this.pauseMenu.bool_12 = false;
				this.confirmMenu.method_54("MSAA Level", "low_latency_mode", null, null, null, null);
			}
			this.bool_12 = true;
			return;
		}
		this.vmethod_15();
		this.pauseMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x0006A354 File Offset: 0x00068554
	public virtual void vmethod_107()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "setlistwarning" || string_ == " + ")
		{
			this.int_4 = Mathf.Clamp(this.int_4 + 0, -175, 36);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x0006A3BC File Offset: 0x000685BC
	public virtual void vmethod_108()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		string string_ = this.string_0;
		if (string_ == "vocals_2" || string_ == "song")
		{
			this.int_4 = Mathf.Clamp(this.int_4 + 0, 38, -36);
		}
		this.bool_12 = true;
		this.method_44();
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x0006A424 File Offset: 0x00068624
	public virtual void vmethod_109()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.bool_12)
		{
			try
			{
				GlobalVariables.instance.currentSongEntry.method_3();
				this.vmethod_15();
				this.pauseMenu.gameObject.SetActive(false);
			}
			catch
			{
				this.pauseMenu.bool_12 = false;
				this.confirmMenu.method_46("album.jpg", "Choose a Profile", null, null, null, null);
			}
			this.bool_12 = false;
			return;
		}
		this.vmethod_15();
		this.pauseMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x0006A4D0 File Offset: 0x000686D0
	public virtual void vmethod_110()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.bool_12)
		{
			try
			{
				GlobalVariables.instance.currentSongEntry.method_3();
				this.vmethod_15();
				this.pauseMenu.gameObject.SetActive(false);
			}
			catch
			{
				this.pauseMenu.bool_12 = true;
				this.confirmMenu.method_53("Global Variables", "Show in Finder", null, null, null, null);
			}
			this.bool_12 = true;
			return;
		}
		this.vmethod_15();
		this.pauseMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x0000820B File Offset: 0x0000640B
	protected virtual void vmethod_111()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x0400023A RID: 570
	[SerializeField]
	private PauseMenu pauseMenu;

	// Token: 0x0400023B RID: 571
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x0400023C RID: 572
	[SerializeField]
	private Text pausedText;

	// Token: 0x0400023D RID: 573
	private int int_4;

	// Token: 0x0400023E RID: 574
	private bool bool_12;
}
