using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000051 RID: 81
public class VideoSettings : BaseMenu
{
	// Token: 0x06000F15 RID: 3861 RVA: 0x0006C568 File Offset: 0x0006A768
	public virtual void vmethod_81()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
		}
		else if (this.string_0 == "Continue")
		{
			if (this.int_4 > 0)
			{
				this.int_4--;
				this.method_55();
			}
		}
		else
		{
			this.gclass5_0.method_27();
			this.optionsMenu.bool_10 = false;
			this.method_48();
		}
		if (this.string_0 == "full_playlist" && this.gclass5_0.CurrentValue == 8)
		{
			this.gclass5_0.method_27();
			this.method_46();
		}
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x000088BC File Offset: 0x00006ABC
	public virtual void vmethod_82()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x0006C604 File Offset: 0x0006A804
	public virtual void vmethod_83()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
		}
		else if (this.string_0 == "No Fail")
		{
			if (this.int_4 > 0)
			{
				this.int_4--;
				this.method_52();
			}
		}
		else
		{
			this.gclass5_0.method_27();
			this.optionsMenu.bool_10 = false;
			this.method_50();
		}
		if (this.string_0 == "Tilt" && this.gclass5_0.method_5() == 4)
		{
			this.gclass5_0.method_19();
			this.method_46();
		}
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0006C6A0 File Offset: 0x0006A8A0
	private void method_44()
	{
		string text = "\"([^\"]*)\"";
		string string_ = this.string_0;
		if (!(string_ == "Songs Scanned"))
		{
			if (!(string_ == "Songs Scanned"))
			{
				if (!(string_ == "star_available"))
				{
					if (!(string_ == "0"))
					{
						if (!(string_ == "song.ini"))
						{
							text = this.gclass5_0.String_0;
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.Boolean_1;
						}
					}
					else if (this.gclass5_0.method_25() == 0)
					{
						text = "Unknown Charter";
					}
					else
					{
						text = this.gclass5_0.String_2 + "song_length";
					}
				}
				else if (this.gclass5_0.method_5() > -123)
				{
					text = GClass4.gclass4_0.method_13("genre");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_25())
				{
				case 0:
					text = "custom_song_export";
					break;
				case 1:
					text = "Export Song List";
					break;
				case 2:
					text = " %n ";
					break;
				}
				text = GClass4.gclass4_0.method_17(text);
			}
		}
		else
		{
			text = string.Format("Setlist", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x000088EB File Offset: 0x00006AEB
	public virtual void vmethod_84()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x0000891A File Offset: 0x00006B1A
	public virtual void vmethod_85()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0006C838 File Offset: 0x0006AA38
	public virtual void vmethod_86()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
		}
		else if (this.string_0 == "Are you sure you want to restart?")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4++;
				this.method_48();
			}
		}
		else
		{
			this.gclass5_0.method_7();
			this.optionsMenu.bool_10 = false;
			this.method_54();
		}
		if (this.string_0 == "=" && this.gclass5_0.method_5() == 5)
		{
			this.gclass5_0.method_29();
			this.method_51();
		}
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x000088BC File Offset: 0x00006ABC
	public virtual void vmethod_87()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0000891A File Offset: 0x00006B1A
	public virtual void vmethod_88()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0006C8E0 File Offset: 0x0006AAE0
	public virtual void vmethod_89()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
		}
		else if (this.string_0 == "")
		{
			if (this.int_4 > 0)
			{
				this.int_4 -= 0;
				this.method_49();
			}
		}
		else
		{
			this.gclass5_0.method_15();
			this.optionsMenu.bool_10 = true;
			this.method_55();
		}
		if (this.string_0 == "HOPO's to Taps" && this.gclass5_0.method_5() == 6)
		{
			this.gclass5_0.method_19();
			this.method_50();
		}
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x0006C97C File Offset: 0x0006AB7C
	public virtual void vmethod_90()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 118u)
			{
				if (num <= 116u)
				{
					if (num != 103u)
					{
						if (num != 164u)
						{
							if (num == 4294967261u)
							{
								if (string_ == "/Video Backgrounds")
								{
									Screen.SetResolution(Screen.width, Screen.height, !Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "/Image Backgrounds")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "Show Mouse Cursor")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 4294967158u)
				{
					if (num != 4294967177u)
					{
						if (num == 4294967184u)
						{
							if (string_ == "Yes")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "Lyrics")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "game")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 54u)
			{
				if (num != 187u)
				{
					if (num != 4294967266u)
					{
						if (num == 4294967125u)
						{
							if (string_ == "Genre = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "custom")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "%count%")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 115u)
			{
				if (num != 4294967290u)
				{
					if (num == 185u)
					{
						if (string_ == "")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "volume")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 0; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = false;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = true;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					resolutions = this.resolution_0;
					for (int i = 0; i < resolutions.Length; i += 0)
					{
						Resolution value = resolutions[i];
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 130u)
			{
				if (num == 164u)
				{
					if (string_ == "volume")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "song")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_54();
			return;
		}
		if (this.string_0 == "Bad file type")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "Export Song List")
		{
			QualitySettings.antiAliasing = this.gclass5_0.method_25();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_30();
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x0006CDD8 File Offset: 0x0006AFD8
	private void method_45()
	{
		string text = "charter";
		string string_ = this.string_0;
		if (!(string_ == "New Setlist"))
		{
			if (!(string_ == "crowd"))
			{
				if (!(string_ == "guitar"))
				{
					if (!(string_ == "Note Shuffle"))
					{
						if (!(string_ == "Continue"))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.method_10();
							Cursor.visible = this.gclass5_0.method_4();
						}
					}
					else if (this.gclass5_0.method_25() == 0)
					{
						text = "year";
					}
					else
					{
						text = this.gclass5_0.String_2 + "album";
					}
				}
				else if (this.gclass5_0.method_5() > 30)
				{
					text = GClass4.gclass4_0.method_5("song_length");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_5())
				{
				case 0:
					text = "custom";
					break;
				case 1:
					text = " (";
					break;
				case 2:
					text = "song";
					break;
				}
				text = GClass4.gclass4_0.method_46(text);
			}
		}
		else
		{
			text = string.Format(": <color=#FDB400FF>", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0006CF70 File Offset: 0x0006B170
	private void method_46()
	{
		string text = "Go to Discord";
		string string_ = this.string_0;
		if (!(string_ == "No"))
		{
			if (!(string_ == "6 Fret Bass Guitar"))
			{
				if (!(string_ == "Video Offset"))
				{
					if (!(string_ == "Highway Shake"))
					{
						if (!(string_ == "Yes"))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.method_4();
						}
					}
					else if (this.gclass5_0.method_5() == 0)
					{
						text = "Default Sort Filter";
					}
					else
					{
						text = this.gclass5_0.String_2 + "volume";
					}
				}
				else if (this.gclass5_0.method_25() > -80)
				{
					text = GClass4.gclass4_0.method_7("Yes");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_25())
				{
				case 0:
					text = "[^\\u0020-\\u007E]";
					break;
				case 1:
					text = "part guitar ghl";
					break;
				case 2:
					text = "Show in Finder";
					break;
				}
				text = GClass4.gclass4_0.method_41(text);
			}
		}
		else
		{
			text = string.Format("0%", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0006D108 File Offset: 0x0006B308
	public virtual void vmethod_91()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 4294967213u)
			{
				if (num <= 128u)
				{
					if (num != 41u)
					{
						if (num != 173u)
						{
							if (num == 69u)
							{
								if (string_ == "Bot")
								{
									Screen.SetResolution(Screen.width, Screen.height, Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "Has Lyrics")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == " ")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 88u)
				{
					if (num != 4294967218u)
					{
						if (num == 4294967227u)
						{
							if (string_ == "ts")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "ms")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "Highway Shake")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 4294967165u)
			{
				if (num != 186u)
				{
					if (num != 111u)
					{
						if (num == 94u)
						{
							if (string_ == "\"")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "Bad file type")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "A: 00:00:00")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 131u)
			{
				if (num != 137u)
				{
					if (num == 93u)
					{
						if (string_ == "Main Menu")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "Go to Discord")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 1; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = true;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = true;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					foreach (Resolution value in this.resolution_0)
					{
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 4294967129u)
			{
				if (num == 4294967250u)
				{
					if (string_ == "Random Song (Section)")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "No Playlist")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_50();
			return;
		}
		if (this.string_0 == "No Part")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == ")")
		{
			QualitySettings.antiAliasing = this.gclass5_0.method_5();
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_30();
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00008949 File Offset: 0x00006B49
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x0006D564 File Offset: 0x0006B764
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
		}
		else if (this.string_0 == "Resolution")
		{
			if (this.int_4 + 1 < this.resolution_0.Length)
			{
				this.int_4++;
				this.method_50();
			}
		}
		else
		{
			this.gclass5_0.method_7();
			this.optionsMenu.bool_10 = true;
			this.method_50();
		}
		if (this.string_0 == "MSAA Level" && this.gclass5_0.CurrentValue == 6)
		{
			this.gclass5_0.method_7();
			this.method_50();
		}
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x000088BC File Offset: 0x00006ABC
	public virtual void vmethod_92()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x0006D60C File Offset: 0x0006B80C
	public virtual void vmethod_93()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
		}
		else if (this.string_0 == "")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4 += 0;
				this.method_53();
			}
		}
		else
		{
			this.gclass5_0.method_7();
			this.optionsMenu.bool_10 = true;
			this.method_49();
		}
		if (this.string_0 == "Game Icons/" && this.gclass5_0.method_5() == 4)
		{
			this.gclass5_0.method_2();
			this.method_53();
		}
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0006D6B4 File Offset: 0x0006B8B4
	private void method_47()
	{
		string text = "bad_note3";
		string string_ = this.string_0;
		if (!(string_ == "game"))
		{
			if (!(string_ == "Genre"))
			{
				if (!(string_ == "year"))
				{
					if (!(string_ == "Unknown Album"))
					{
						if (!(string_ == "Mirror Mode"))
						{
							text = this.gclass5_0.method_9();
						}
						else
						{
							text = this.gclass5_0.method_10();
							Cursor.visible = this.gclass5_0.Boolean_1;
						}
					}
					else if (this.gclass5_0.CurrentValue == 0)
					{
						text = "Hard";
					}
					else
					{
						text = this.gclass5_0.String_2 + "Are you sure you want to quit?";
					}
				}
				else if (this.gclass5_0.method_25() > 159)
				{
					text = GClass4.gclass4_0.method_15("Rhythm");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.CurrentValue)
				{
				case 0:
					text = "Source";
					break;
				case 1:
					text = "album.png";
					break;
				case 2:
					text = "No";
					break;
				}
				text = GClass4.gclass4_0.method_46(text);
			}
		}
		else
		{
			text = string.Format("Language", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x0006D84C File Offset: 0x0006BA4C
	public virtual void vmethod_94()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 41u)
			{
				if (num <= 4294967154u)
				{
					if (num != 25u)
					{
						if (num != 188u)
						{
							if (num == 4294967135u)
							{
								if (string_ == "streamer")
								{
									Screen.SetResolution(Screen.width, Screen.height, Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "Main Menu")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "Song")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 182u)
				{
					if (num != 4294967190u)
					{
						if (num == 4294967204u)
						{
							if (string_ == "background_image")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "part")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "streamer")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 53u)
			{
				if (num != 4294967164u)
				{
					if (num != 64u)
					{
						if (num == 4294967218u)
						{
							if (string_ == "Options")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "%s")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "t1 gems")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 160u)
			{
				if (num != 4294967098u)
				{
					if (num == 4294967271u)
					{
						if (string_ == "%")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "Unknown Album")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 0; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = false;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = false;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					resolutions = this.resolution_0;
					for (int i = 1; i < resolutions.Length; i++)
					{
						Resolution value = resolutions[i];
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 4294967129u)
			{
				if (num == 4294967235u)
				{
					if (string_ == "phrase_end")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_46();
			return;
		}
		if (this.string_0 == "Skip Song")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "game_version")
		{
			QualitySettings.antiAliasing = this.gclass5_0.method_5();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_30();
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0006DCA8 File Offset: 0x0006BEA8
	public virtual void vmethod_95()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 127u)
			{
				if (num <= 166u)
				{
					if (num != 4294967256u)
					{
						if (num != 4294967257u)
						{
							if (num == 4294967262u)
							{
								if (string_ == ":\n")
								{
									Screen.SetResolution(Screen.width, Screen.height, Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "Resolution")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "setlistSongCountPlural")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 107u)
				{
					if (num != 120u)
					{
						if (num == 4294967113u)
						{
							if (string_ == "0%")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "\"([^\"]*)\"")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "%")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 4294967258u)
			{
				if (num != 4294967180u)
				{
					if (num != 5u)
					{
						if (num == 4294967172u)
						{
							if (string_ == "")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "0")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "icon")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 199u)
			{
				if (num != 4294967201u)
				{
					if (num == 65u)
					{
						if (string_ == "song")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "Enable")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 1; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = true;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = true;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					resolutions = this.resolution_0;
					for (int i = 1; i < resolutions.Length; i++)
					{
						Resolution value = resolutions[i];
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 137u)
			{
				if (num == 4294967125u)
				{
					if (string_ == "\\d+ = E \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "volume")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_55();
			return;
		}
		if (this.string_0 == "<color=#FF9C9CFF>")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "song_display")
		{
			QualitySettings.antiAliasing = this.gclass5_0.method_5();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0006E104 File Offset: 0x0006C304
	public virtual void vmethod_96()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
		}
		else if (this.string_0 == "Controller Poll Rate")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4++;
				this.method_45();
			}
		}
		else
		{
			this.gclass5_0.method_29();
			this.optionsMenu.bool_10 = true;
			this.method_47();
		}
		if (this.string_0 == "" && this.gclass5_0.method_5() == 0)
		{
			this.gclass5_0.method_7();
			this.method_49();
		}
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0006E1AC File Offset: 0x0006C3AC
	public virtual void vmethod_97()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 198u)
			{
				if (num <= 156u)
				{
					if (num != 4294967281u)
					{
						if (num != 4294967227u)
						{
							if (num == 61u)
							{
								if (string_ == "A: ")
								{
									Screen.SetResolution(Screen.width, Screen.height, !Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "Scan Songs")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 4294967099u)
				{
					if (num != 4294967132u)
					{
						if (num == 55u)
						{
							if (string_ == ".setlist")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "song")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "Prefabs/Gameplay/Notes/open_sustain_glow")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 4294967293u)
			{
				if (num != 4294967121u)
				{
					if (num != 4294967254u)
					{
						if (num == 4294967265u)
						{
							if (string_ == "Get Hardware Latency")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "\\d+ = E \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "song_length")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 191u)
			{
				if (num != 40u)
				{
					if (num == 4294967229u)
					{
						if (string_ == "name")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "...")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 1; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = false;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = true;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					resolutions = this.resolution_0;
					for (int i = 0; i < resolutions.Length; i += 0)
					{
						Resolution value = resolutions[i];
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 53u)
			{
				if (num == 137u)
				{
					if (string_ == "Gameplay")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "events")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_54();
			return;
		}
		if (this.string_0 == "Bass Guitar")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "Clear Setlist")
		{
			QualitySettings.antiAliasing = this.gclass5_0.CurrentValue;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0006E608 File Offset: 0x0006C808
	private void method_48()
	{
		string text = "Export Song List (JSON)";
		string string_ = this.string_0;
		if (!(string_ == "File does not exist"))
		{
			if (!(string_ == "game"))
			{
				if (!(string_ == "Length = [\\-\\+]?\\d+(\\.\\d+)?"))
				{
					if (!(string_ == "Open Data Privacy Page"))
					{
						if (!(string_ == "Not match flags previous {0} {1}"))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.method_30();
						}
					}
					else if (this.gclass5_0.method_25() == 0)
					{
						text = "Yo dawg, I heard you like lanes so this activates lanes!";
					}
					else
					{
						text = this.gclass5_0.String_2 + "album_track";
					}
				}
				else if (this.gclass5_0.method_25() > 37)
				{
					text = GClass4.gclass4_0.method_13("Setlist");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.CurrentValue)
				{
				case 0:
					text = ":";
					break;
				case 1:
					text = "vocals";
					break;
				case 2:
					text = "part";
					break;
				}
				text = GClass4.gclass4_0.method_16(text);
			}
		}
		else
		{
			text = string.Format("Error: ", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x0006E7A0 File Offset: 0x0006C9A0
	public virtual void vmethod_98()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
		}
		else if (this.string_0 == "No Part")
		{
			if (this.int_4 > 1)
			{
				this.int_4 -= 0;
				this.method_48();
			}
		}
		else
		{
			this.gclass5_0.method_15();
			this.optionsMenu.bool_10 = false;
			this.method_44();
		}
		if (this.string_0 == ": " && this.gclass5_0.method_5() == 0)
		{
			this.gclass5_0.method_19();
			this.method_44();
		}
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x0006E83C File Offset: 0x0006CA3C
	public virtual void vmethod_99()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 4294967195u)
			{
				if (num <= 4294967146u)
				{
					if (num != 4294967226u)
					{
						if (num != 4294967216u)
						{
							if (num == 39u)
							{
								if (string_ == " ")
								{
									Screen.SetResolution(Screen.width, Screen.height, Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "Menu Music")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "HOPO's to Taps")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 4294967234u)
				{
					if (num != 149u)
					{
						if (num == 125u)
						{
							if (string_ == "Rescan Custom Content")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "Listening on port: ")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "NowPlaying")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 174u)
			{
				if (num != 122u)
				{
					if (num != 67u)
					{
						if (num == 4294967262u)
						{
							if (string_ == "game")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "Easy")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "Hard")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 113u)
			{
				if (num != 4294967179u)
				{
					if (num == 39u)
					{
						if (string_ == "N/A")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "[")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 1; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = false;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = false;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					foreach (Resolution value in this.resolution_0)
					{
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 4294967271u)
			{
				if (num == 4294967220u)
				{
					if (string_ == "-")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "isHidden")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_49();
			return;
		}
		if (this.string_0 == "star_animation")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "custom")
		{
			QualitySettings.antiAliasing = this.gclass5_0.CurrentValue;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_30();
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0006EC98 File Offset: 0x0006CE98
	public virtual void vmethod_100()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 5u)
			{
				if (num <= 4294967220u)
				{
					if (num != 4294967167u)
					{
						if (num != 96u)
						{
							if (num == 4294967145u)
							{
								if (string_ == "</color>")
								{
									Screen.SetResolution(Screen.width, Screen.height, !Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "album_track")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "Keys")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 4294967104u)
				{
					if (num != 77u)
					{
						if (num == 4294967212u)
						{
							if (string_ == "Unknown Artist")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "song")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "None")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 4294967182u)
			{
				if (num != 4294967131u)
				{
					if (num != 174u)
					{
						if (num == 4294967238u)
						{
							if (string_ == "Song Offset")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "Genre")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "Setlist")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 68u)
			{
				if (num != 4294967138u)
				{
					if (num == 4294967168u)
					{
						if (string_ == "")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "{0} {1}")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 1; i < resolutions.Length; i++)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = false;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = true;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					resolutions = this.resolution_0;
					for (int i = 1; i < resolutions.Length; i += 0)
					{
						Resolution value = resolutions[i];
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 4294967152u)
			{
				if (num == 4294967127u)
				{
					if (string_ == "Rename Setlist")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "MSAA Level")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_53();
			return;
		}
		if (this.string_0 == "Drums")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "pause_on_focus_lost")
		{
			QualitySettings.antiAliasing = this.gclass5_0.method_25();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x0006F0F4 File Offset: 0x0006D2F4
	public virtual void vmethod_101()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
		}
		else if (this.string_0 == "framerate")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4++;
				this.method_49();
			}
		}
		else
		{
			this.gclass5_0.method_29();
			this.optionsMenu.bool_10 = true;
			this.method_52();
		}
		if (this.string_0 == "enable_cursor" && this.gclass5_0.CurrentValue == 2)
		{
			this.gclass5_0.method_29();
			this.method_49();
		}
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00008949 File Offset: 0x00006B49
	public virtual void vmethod_102()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x000088EB File Offset: 0x00006AEB
	public virtual void vmethod_103()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x000088EB File Offset: 0x00006AEB
	public virtual void vmethod_104()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00008949 File Offset: 0x00006B49
	public virtual void vmethod_105()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x0006F19C File Offset: 0x0006D39C
	public override void vmethod_39()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 1595303295u)
			{
				if (num <= 1026214520u)
				{
					if (num != 529548819u)
					{
						if (num != 948948777u)
						{
							if (num == 1026214520u)
							{
								if (string_ == "Fullscreen")
								{
									Screen.SetResolution(Screen.width, Screen.height, !Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "Flames")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "Show FPS")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 1093282225u)
				{
					if (num != 1539377232u)
					{
						if (num == 1595303295u)
						{
							if (string_ == "Show Mouse Cursor")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "SP Lightning")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "MSAA Level")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 2897502726u)
			{
				if (num != 2086318127u)
				{
					if (num != 2372057453u)
					{
						if (num == 2897502726u)
						{
							if (string_ == "Vsync")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "Highway SP Effects")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "Menu Backgrounds")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 3134466500u)
			{
				if (num != 2934446255u)
				{
					if (num == 3134466500u)
					{
						if (string_ == "Particles")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "Resolution")
				{
					List<Resolution> list = new List<Resolution>();
					foreach (Resolution item in Screen.resolutions)
					{
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = true;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = false;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					foreach (Resolution value in this.resolution_0)
					{
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 3200199300u)
			{
				if (num == 4135836962u)
				{
					if (string_ == "Song Display")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "Framerate")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_50();
			return;
		}
		if (this.string_0 == "Resolution")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "MSAA Level")
		{
			QualitySettings.antiAliasing = this.gclass5_0.CurrentValue;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x000088BC File Offset: 0x00006ABC
	public virtual void vmethod_106()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x0006F5F8 File Offset: 0x0006D7F8
	public virtual void vmethod_107()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
		}
		else if (this.string_0 == "Not match flags previous {0} {1}")
		{
			if (this.int_4 > 0)
			{
				this.int_4--;
				this.method_44();
			}
		}
		else
		{
			this.gclass5_0.method_15();
			this.optionsMenu.bool_10 = false;
			this.method_52();
		}
		if (this.string_0 == "track" && this.gclass5_0.CurrentValue == 5)
		{
			this.gclass5_0.method_27();
			this.method_47();
		}
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0006F694 File Offset: 0x0006D894
	public virtual void vmethod_108()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
		}
		else if (this.string_0 == "[\\-\\+]?\\d+(\\.\\d+)?")
		{
			if (this.int_4 + 1 < this.resolution_0.Length)
			{
				this.int_4 += 0;
				this.method_48();
			}
		}
		else
		{
			this.gclass5_0.method_29();
			this.optionsMenu.bool_10 = true;
			this.method_54();
		}
		if (this.string_0 == "\\D" && this.gclass5_0.method_25() == 7)
		{
			this.gclass5_0.method_29();
			this.method_54();
		}
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x0000891A File Offset: 0x00006B1A
	public virtual void vmethod_109()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x000088EB File Offset: 0x00006AEB
	public virtual void vmethod_110()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x0006F73C File Offset: 0x0006D93C
	public virtual void vmethod_111()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
		}
		else if (this.string_0 == "song")
		{
			if (this.int_4 + 1 < this.resolution_0.Length)
			{
				this.int_4++;
				this.method_52();
			}
		}
		else
		{
			this.gclass5_0.method_29();
			this.optionsMenu.bool_10 = true;
			this.method_44();
		}
		if (this.string_0 == "song" && this.gclass5_0.CurrentValue == 6)
		{
			this.gclass5_0.method_7();
			this.method_44();
		}
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x0006F7E4 File Offset: 0x0006D9E4
	private void method_49()
	{
		string text = "6 Fret Bass Guitar";
		string string_ = this.string_0;
		if (!(string_ == "All HOPO's"))
		{
			if (!(string_ == "errors.txt"))
			{
				if (!(string_ == " + "))
				{
					if (!(string_ == "Guitar Coop"))
					{
						if (!(string_ == "Songs are still scanning..."))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.method_4();
						}
					}
					else if (this.gclass5_0.method_25() == 0)
					{
						text = "game";
					}
					else
					{
						text = this.gclass5_0.String_2 + "6 Fret Lead Guitar";
					}
				}
				else if (this.gclass5_0.method_25() > 151)
				{
					text = GClass4.gclass4_0.method_35("highway_sp");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_25())
				{
				case 0:
					text = "offset";
					break;
				case 1:
					text = "Quit";
					break;
				case 2:
					text = "game";
					break;
				}
				text = GClass4.gclass4_0.method_38(text);
			}
		}
		else
		{
			text = string.Format("{0}: {1}", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x0006F97C File Offset: 0x0006DB7C
	private void method_50()
	{
		string text = "";
		string string_ = this.string_0;
		if (!(string_ == "Resolution"))
		{
			if (!(string_ == "Menu Backgrounds"))
			{
				if (!(string_ == "Framerate"))
				{
					if (!(string_ == "MSAA Level"))
					{
						if (!(string_ == "Show Mouse Cursor"))
						{
							text = this.gclass5_0.String_0;
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.Boolean_1;
						}
					}
					else if (this.gclass5_0.CurrentValue == 0)
					{
						text = "Disabled";
					}
					else
					{
						text = this.gclass5_0.String_2 + "x";
					}
				}
				else if (this.gclass5_0.CurrentValue > 2000)
				{
					text = GClass4.gclass4_0.method_13("Unlimited");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.CurrentValue)
				{
				case 0:
					text = "Static";
					break;
				case 1:
					text = "Animated";
					break;
				case 2:
					text = "Black";
					break;
				}
				text = GClass4.gclass4_0.method_13(text);
			}
		}
		else
		{
			text = string.Format("{0}x{1}", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x0006FB14 File Offset: 0x0006DD14
	private void method_51()
	{
		string text = "Date Added";
		string string_ = this.string_0;
		if (!(string_ == "Enable Lanes"))
		{
			if (!(string_ == "song"))
			{
				if (!(string_ == "\\d+"))
				{
					if (!(string_ == ""))
					{
						if (!(string_ == "Audio Backend"))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.method_9();
							Cursor.visible = this.gclass5_0.method_4();
						}
					}
					else if (this.gclass5_0.method_25() == 0)
					{
						text = "Mirror Mode";
					}
					else
					{
						text = this.gclass5_0.String_2 + "Visit Website";
					}
				}
				else if (this.gclass5_0.method_5() > -61)
				{
					text = GClass4.gclass4_0.method_35("game");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_5())
				{
				case 0:
					text = "diff_bass";
					break;
				case 1:
					text = "device";
					break;
				case 2:
					text = "";
					break;
				}
				text = GClass4.gclass4_0.method_17(text);
			}
		}
		else
		{
			text = string.Format("Name = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x0000891A File Offset: 0x00006B1A
	public virtual void vmethod_112()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x0006FCAC File Offset: 0x0006DEAC
	public virtual void vmethod_113()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
		}
		else if (this.string_0 == "game")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4 += 0;
				this.method_49();
			}
		}
		else
		{
			this.gclass5_0.method_7();
			this.optionsMenu.bool_10 = false;
			this.method_54();
		}
		if (this.string_0 == "preview_start_time" && this.gclass5_0.CurrentValue == 2)
		{
			this.gclass5_0.method_7();
			this.method_45();
		}
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x0006FD54 File Offset: 0x0006DF54
	public virtual void vmethod_114()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 4294967164u)
			{
				if (num <= 171u)
				{
					if (num != 164u)
					{
						if (num != 4294967239u)
						{
							if (num == 120u)
							{
								if (string_ == "")
								{
									Screen.SetResolution(Screen.width, Screen.height, !Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "\n")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "msaa")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 4294967098u)
				{
					if (num != 4294967166u)
					{
						if (num == 52u)
						{
							if (string_ == "Medium")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "has_bots")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "Song")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 64u)
			{
				if (num != 4294967260u)
				{
					if (num != 43u)
					{
						if (num == 4294967118u)
						{
							if (string_ == "Bot")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "phrase_start")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "6 Fret Lead Guitar")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 4294967288u)
			{
				if (num != 4294967280u)
				{
					if (num == 4294967165u)
					{
						if (string_ == "-")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "volume")
				{
					List<Resolution> list = new List<Resolution>();
					foreach (Resolution item in Screen.resolutions)
					{
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = false;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = true;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					foreach (Resolution value in this.resolution_0)
					{
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 4294967214u)
			{
				if (num == 177u)
				{
					if (string_ == "highway_placement")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "Bass Guitar")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_50();
			return;
		}
		if (this.string_0 == "Note Shuffle")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_30();
		}
		if (this.string_0 == "Tried to initialize the already initialized sound effects!")
		{
			QualitySettings.antiAliasing = this.gclass5_0.method_25();
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_30();
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x000701B0 File Offset: 0x0006E3B0
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
		}
		else if (this.string_0 == "Resolution")
		{
			if (this.int_4 > 0)
			{
				this.int_4--;
				this.method_50();
			}
		}
		else
		{
			this.gclass5_0.method_27();
			this.optionsMenu.bool_10 = true;
			this.method_50();
		}
		if (this.string_0 == "MSAA Level" && this.gclass5_0.CurrentValue == 6)
		{
			this.gclass5_0.method_27();
			this.method_50();
		}
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x0007024C File Offset: 0x0006E44C
	private void method_52()
	{
		string text = "Gameplay";
		string string_ = this.string_0;
		if (!(string_ == "song"))
		{
			if (!(string_ == ""))
			{
				if (!(string_ == "6 Fret Lead Guitar"))
				{
					if (!(string_ == "pause_on_focus_lost"))
					{
						if (!(string_ == "Song"))
						{
							text = this.gclass5_0.method_9();
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.method_14();
						}
					}
					else if (this.gclass5_0.CurrentValue == 0)
					{
						text = ")";
					}
					else
					{
						text = this.gclass5_0.String_2 + "No Images!";
					}
				}
				else if (this.gclass5_0.method_25() > 93)
				{
					text = GClass4.gclass4_0.method_48("/");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_5())
				{
				case 0:
					text = "<color=#FF9C9CFF>";
					break;
				case 1:
					text = "=";
					break;
				case 2:
					text = "Hard";
					break;
				}
				text = GClass4.gclass4_0.method_7(text);
			}
		}
		else
		{
			text = string.Format("All Taps", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00008949 File Offset: 0x00006B49
	public virtual void vmethod_115()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x000703E4 File Offset: 0x0006E5E4
	public virtual void vmethod_116()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
		}
		else if (this.string_0 == "/")
		{
			if (this.int_4 > 0)
			{
				this.int_4 -= 0;
				this.method_52();
			}
		}
		else
		{
			this.gclass5_0.method_27();
			this.optionsMenu.bool_10 = true;
			this.method_47();
		}
		if (this.string_0 == "Instrument" && this.gclass5_0.method_25() == 3)
		{
			this.gclass5_0.method_15();
			this.method_51();
		}
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00070480 File Offset: 0x0006E680
	private void method_53()
	{
		string text = "\r\n";
		string string_ = this.string_0;
		if (!(string_ == "MSAA Level"))
		{
			if (!(string_ == ""))
			{
				if (!(string_ == "cpu_count"))
				{
					if (!(string_ == "game"))
					{
						if (!(string_ == ""))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.method_4();
						}
					}
					else if (this.gclass5_0.method_25() == 0)
					{
						text = "";
					}
					else
					{
						text = this.gclass5_0.String_2 + "Type the setlist name";
					}
				}
				else if (this.gclass5_0.CurrentValue > -13)
				{
					text = GClass4.gclass4_0.method_48("Unlimited");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_5())
				{
				case 0:
					text = "None";
					break;
				case 1:
					text = "Rhythm Guitar";
					break;
				case 2:
					text = "Master Volume";
					break;
				}
				text = GClass4.gclass4_0.method_17(text);
			}
		}
		else
		{
			text = string.Format("Game Manager", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x0000891A File Offset: 0x00006B1A
	public virtual void vmethod_117()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00070618 File Offset: 0x0006E818
	private void method_54()
	{
		string text = "song";
		string string_ = this.string_0;
		if (!(string_ == "Hard"))
		{
			if (!(string_ == "There was an error deleting the file"))
			{
				if (!(string_ == "Show FPS"))
				{
					if (!(string_ == ""))
					{
						if (!(string_ == "isSupported"))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.method_30();
						}
					}
					else if (this.gclass5_0.method_25() == 0)
					{
						text = "";
					}
					else
					{
						text = this.gclass5_0.String_2 + "diff_bassghl";
					}
				}
				else if (this.gclass5_0.method_25() > 26)
				{
					text = GClass4.gclass4_0.method_35("Mirror Mode");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_25())
				{
				case 0:
					text = "Gamepad Mode";
					break;
				case 1:
					text = "song";
					break;
				case 2:
					text = "volume";
					break;
				}
				text = GClass4.gclass4_0.method_30(text);
			}
		}
		else
		{
			text = string.Format("Year", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x000707B0 File Offset: 0x0006E9B0
	public virtual void vmethod_118()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 199u)
			{
				if (num <= 174u)
				{
					if (num != 4294967127u)
					{
						if (num != 100u)
						{
							if (num == 162u)
							{
								if (string_ == "Press Escape to cancel")
								{
									Screen.SetResolution(Screen.width, Screen.height, Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "Unknown Artist")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "guitar")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 190u)
				{
					if (num != 4294967166u)
					{
						if (num == 4294967266u)
						{
							if (string_ == "</color>")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "Artist")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == " (")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 7u)
			{
				if (num != 90u)
				{
					if (num != 145u)
					{
						if (num == 35u)
						{
							if (string_ == "volume")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "Song Options")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "Menu Music")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 4294967285u)
			{
				if (num != 4294967277u)
				{
					if (num == 4294967199u)
					{
						if (string_ == "Highway")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "{0}")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 0; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = true;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = false;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					resolutions = this.resolution_0;
					for (int i = 1; i < resolutions.Length; i++)
					{
						Resolution value = resolutions[i];
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 4294967168u)
			{
				if (num == 4294967210u)
				{
					if (string_ == "settings.ini")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "Drums")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_51();
			return;
		}
		if (this.string_0 == "Highway Shake")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "delay")
		{
			QualitySettings.antiAliasing = this.gclass5_0.method_25();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_30();
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00070C0C File Offset: 0x0006EE0C
	public virtual void vmethod_119()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
		}
		else if (this.string_0 == "Note Shuffle")
		{
			if (this.int_4 > 1)
			{
				this.int_4--;
				this.method_45();
			}
		}
		else
		{
			this.gclass5_0.method_15();
			this.optionsMenu.bool_10 = true;
			this.method_45();
		}
		if (this.string_0 == "Continue" && this.gclass5_0.method_25() == 7)
		{
			this.gclass5_0.method_27();
			this.method_50();
		}
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00070CA8 File Offset: 0x0006EEA8
	public virtual void vmethod_120()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
		}
		else if (this.string_0 == "custom")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4 += 0;
				this.method_46();
			}
		}
		else
		{
			this.gclass5_0.method_7();
			this.optionsMenu.bool_10 = true;
			this.method_46();
		}
		if (this.string_0 == "..." && this.gclass5_0.CurrentValue == 4)
		{
			this.gclass5_0.method_7();
			this.method_48();
		}
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00070D50 File Offset: 0x0006EF50
	public virtual void vmethod_121()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
		}
		else if (this.string_0 == "vocals")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4 += 0;
				this.method_52();
			}
		}
		else
		{
			this.gclass5_0.method_2();
			this.optionsMenu.bool_10 = false;
			this.method_47();
		}
		if (this.string_0 == "flames" && this.gclass5_0.method_25() == 1)
		{
			this.gclass5_0.method_29();
			this.method_54();
		}
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00070DF8 File Offset: 0x0006EFF8
	private void method_55()
	{
		string text = "game";
		string string_ = this.string_0;
		if (!(string_ == ""))
		{
			if (!(string_ == "/currentsong.txt"))
			{
				if (!(string_ == "Game Manager"))
				{
					if (!(string_ == "Encountered exception while attempting to load {0}"))
					{
						if (!(string_ == "HUD"))
						{
							text = this.gclass5_0.method_10();
						}
						else
						{
							text = this.gclass5_0.String_0;
							Cursor.visible = this.gclass5_0.Boolean_1;
						}
					}
					else if (this.gclass5_0.CurrentValue == 0)
					{
						text = "Selection";
					}
					else
					{
						text = this.gclass5_0.String_2 + "Press Enter to confirm";
					}
				}
				else if (this.gclass5_0.CurrentValue > -199)
				{
					text = GClass4.gclass4_0.method_21("star_animation");
				}
				else
				{
					text = this.gclass5_0.String_2;
				}
			}
			else
			{
				switch (this.gclass5_0.method_25())
				{
				case 0:
					text = "highway_lightning";
					break;
				case 1:
					text = "artist";
					break;
				case 2:
					text = "Not match flags previous {0} {1}";
					break;
				}
				text = GClass4.gclass4_0.method_30(text);
			}
		}
		else
		{
			text = string.Format("multiplier_note", this.resolution_0[this.int_4].width, this.resolution_0[this.int_4].height);
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00070F90 File Offset: 0x0006F190
	public virtual void vmethod_122()
	{
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 27u)
			{
				if (num <= 164u)
				{
					if (num != 103u)
					{
						if (num != 4294967136u)
						{
							if (num == 4294967185u)
							{
								if (string_ == "Are you sure?")
								{
									Screen.SetResolution(Screen.width, Screen.height, Screen.fullScreen);
									this.string_0 = null;
									return;
								}
							}
						}
						else if (string_ == "Year")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_23;
						}
					}
					else if (string_ == "volume")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_32;
					}
				}
				else if (num != 70u)
				{
					if (num != 10u)
					{
						if (num == 4294967251u)
						{
							if (string_ == "...")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_44;
							}
						}
					}
					else if (string_ == "Lyrics")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_35;
					}
				}
				else if (string_ == "game")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_25;
				}
			}
			else if (num <= 4294967180u)
			{
				if (num != 76u)
				{
					if (num != 4294967101u)
					{
						if (num == 4294967176u)
						{
							if (string_ == "/Highways")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_24;
							}
						}
					}
					else if (string_ == "Drums - ")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_34;
					}
				}
				else if (string_ == "game")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_38;
				}
			}
			else if (num <= 161u)
			{
				if (num != 4294967096u)
				{
					if (num == 186u)
					{
						if (string_ == "WRITING CACHE...")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_22;
						}
					}
				}
				else if (string_ == "game")
				{
					List<Resolution> list = new List<Resolution>();
					Resolution[] resolutions = Screen.resolutions;
					for (int i = 0; i < resolutions.Length; i += 0)
					{
						Resolution item = resolutions[i];
						if (item.width <= Display.main.systemWidth && item.height <= Display.main.systemHeight)
						{
							bool flag = false;
							foreach (Resolution resolution in list)
							{
								if (item.width == resolution.width && item.height == resolution.height)
								{
									flag = false;
								}
							}
							if (flag)
							{
								list.Add(item);
							}
						}
					}
					this.resolution_0 = list.ToArray();
					resolutions = this.resolution_0;
					for (int i = 0; i < resolutions.Length; i += 0)
					{
						Resolution value = resolutions[i];
						if (value.width == Screen.width && value.height == Screen.height)
						{
							this.int_4 = Array.IndexOf<Resolution>(this.resolution_0, value);
						}
					}
				}
			}
			else if (num != 4294967234u)
			{
				if (num == 4294967105u)
				{
					if (string_ == "*Random")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_37;
					}
				}
			}
			else if (string_ == "Hard")
			{
				this.gclass5_0 = GlobalVariables.instance.targetFramerate;
			}
			this.method_45();
			return;
		}
		if (this.string_0 == "")
		{
			Resolution resolution2 = this.resolution_0[this.int_4];
			Screen.SetResolution(resolution2.width, resolution2.height, Screen.fullScreen);
			this.string_0 = null;
			this.vmethod_50();
		}
		if (this.string_0 == "Rocking in a band")
		{
			QualitySettings.antiAliasing = this.gclass5_0.CurrentValue;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x000713EC File Offset: 0x0006F5EC
	public virtual void vmethod_123()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
		}
		else if (this.string_0 == "Play Count")
		{
			if (this.int_4 > 0)
			{
				this.int_4 -= 0;
				this.method_44();
			}
		}
		else
		{
			this.gclass5_0.method_27();
			this.optionsMenu.bool_10 = false;
			this.method_51();
		}
		if (this.string_0 == "Unknown Charter" && this.gclass5_0.method_5() == 4)
		{
			this.gclass5_0.method_27();
			this.method_45();
		}
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x000088BC File Offset: 0x00006ABC
	public virtual void vmethod_124()
	{
		if (this.string_0 != null)
		{
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00071488 File Offset: 0x0006F688
	public virtual void vmethod_125()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
		}
		else if (this.string_0 == "notes.chart")
		{
			if (this.int_4 + 0 < this.resolution_0.Length)
			{
				this.int_4 += 0;
				this.method_45();
			}
		}
		else
		{
			this.gclass5_0.method_2();
			this.optionsMenu.bool_10 = true;
			this.method_54();
		}
		if (this.string_0 == "volume" && this.gclass5_0.method_25() == 7)
		{
			this.gclass5_0.method_29();
			this.method_45();
		}
	}

	// Token: 0x04000248 RID: 584
	[SerializeField]
	private BaseMenu optionsMenu;

	// Token: 0x04000249 RID: 585
	private Resolution[] resolution_0;

	// Token: 0x0400024A RID: 586
	private int int_4;
}
