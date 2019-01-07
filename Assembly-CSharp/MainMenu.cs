using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Rewired.UI.ControlMapper;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000032 RID: 50
public class MainMenu : BaseMenu
{
	// Token: 0x060007CE RID: 1998 RVA: 0x0000480F File Offset: 0x00002A0F
	private IEnumerator method_44()
	{
		return new MainMenu.Class14(0);
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_45()
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00004817 File Offset: 0x00002A17
	public void method_46()
	{
		this.songScan.method_50();
		base.StartCoroutine(this.songScan.method_23(true));
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00004837 File Offset: 0x00002A37
	private void method_47()
	{
		base.StartCoroutine(this.method_44());
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00004837 File Offset: 0x00002A37
	private void method_48()
	{
		base.StartCoroutine(this.method_44());
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x000489A4 File Offset: 0x00046BA4
	public override void vmethod_39()
	{
		if (!GlobalVariables.isSaving && !this.songScan.bool_1)
		{
			string string_ = base.String_0;
			if (!(string_ == "Quickplay"))
			{
				if (!(string_ == "Practice"))
				{
					if (!(string_ == "Settings"))
					{
						if (string_ == "Quit")
						{
							this.confirmMenu.method_44("Are you sure you want to quit?", "Yes", "No", new ConfirmationMenu.GDelegate6(this.method_51), null, null);
							return;
						}
					}
					else
					{
						this.settingsMenu.SetActive(true);
					}
				}
				else
				{
					if (this.songScan.bool_0)
					{
						base.StartCoroutine(this.method_50());
						return;
					}
					if (SongDirectory.songEntries.Count == 0)
					{
						this.confirmMenu.method_44("No songs were found!", "Scan Songs", "Don't Scan Songs", new ConfirmationMenu.GDelegate6(this.method_59), null, null);
						return;
					}
					this.songSelect.SetActive(true);
					GlobalVariables.instance.wasInQuickplay = false;
					GlobalVariables.instance.isPracticeEnabled = true;
					BassAudioManager.instance.method_56(false);
				}
			}
			else
			{
				if (this.songScan.bool_0)
				{
					base.StartCoroutine(this.method_50());
					return;
				}
				if (SongDirectory.songEntries.Count == 0)
				{
					this.confirmMenu.method_44("No songs were found!", "Scan Songs", "Don't Scan Songs", new ConfirmationMenu.GDelegate6(this.method_59), null, null);
					return;
				}
				this.songSelect.SetActive(true);
				GlobalVariables.instance.wasInQuickplay = true;
				GlobalVariables.instance.isPracticeEnabled = false;
				BassAudioManager.instance.method_56(false);
			}
			base.gameObject.SetActive(false);
			return;
		}
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00004846 File Offset: 0x00002A46
	private void method_49()
	{
		PlayerPrefs.SetInt("song", 1);
		PlayerPrefs.Save();
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00048B50 File Offset: 0x00046D50
	public override void vmethod_6()
	{
		if (BassAudioManager.instance.songEntry_0 != null)
		{
			this.songSelect.SetActive(true);
			GlobalVariables.instance.wasInQuickplay = true;
			GlobalVariables.instance.isPracticeEnabled = false;
			GlobalVariables.instance.songEntry_1 = BassAudioManager.instance.songEntry_0;
			this.songSelect.GetComponent<SongSelect>().vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
			this.songSelect.GetComponent<SongSelect>().vmethod_39();
			BassAudioManager.instance.method_56(false);
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00048BF0 File Offset: 0x00046DF0
	protected override void Start()
	{
		base.Start();
		this.method_55();
		FadeBehaviour.fadeBehaviour_0.method_13(1f, 0f);
		if (GlobalVariables.instance.returnToSongSelect)
		{
			this.songSelect.SetActive(true);
			base.gameObject.SetActive(false);
		}
		else if (!this.songScan.bool_0)
		{
			BassAudioManager.instance.PlayMenuMusic();
		}
		if (!BassAudioManager.instance.isInitialized)
		{
			this.confirmMenu.method_44("bassinitfail", "Quit", null, new ConfirmationMenu.GDelegate6(this.method_60), new ConfirmationMenu.GDelegate6(this.method_60), null);
			return;
		}
		if (GlobalVariables.instance.returnToMainMenuError)
		{
			this.confirmMenu.method_44("Couldn't load that song", "Continue", null, null, null, null);
			GlobalVariables.instance.returnToMainMenuError = false;
		}
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00004858 File Offset: 0x00002A58
	private IEnumerator method_50()
	{
		MainMenu.Class13 @class = new MainMenu.Class13(0);
		@class.mainMenu_0 = this;
		return @class;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00004867 File Offset: 0x00002A67
	public override void vmethod_44()
	{
		if (this.songScan.bool_1)
		{
			return;
		}
		base.vmethod_44();
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0000487D File Offset: 0x00002A7D
	private void method_51()
	{
		Application.Quit();
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00004884 File Offset: 0x00002A84
	public void method_52()
	{
		this.songScan.method_61();
		base.StartCoroutine(this.songScan.method_8(true));
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00048CC8 File Offset: 0x00046EC8
	public virtual void vmethod_81()
	{
		if (!GlobalVariables.isSaving && !this.songScan.bool_1)
		{
			string string_ = base.String_0;
			if (!(string_ == "Client connected"))
			{
				if (!(string_ == "Vocals"))
				{
					if (!(string_ == "year"))
					{
						if (string_ == "song")
						{
							this.confirmMenu.method_52("/songs.json", "crowd", "songcache.bin", new ConfirmationMenu.GDelegate6(this.method_51), null, null);
							return;
						}
					}
					else
					{
						this.settingsMenu.SetActive(false);
					}
				}
				else
				{
					if (this.songScan.bool_0)
					{
						base.StartCoroutine(this.method_50());
						return;
					}
					if (SongDirectory.songEntries.Count == 0)
					{
						this.confirmMenu.method_49("No", "bad_note3", "album_track", new ConfirmationMenu.GDelegate6(this.method_46), null, null);
						return;
					}
					this.songSelect.SetActive(false);
					GlobalVariables.instance.wasInQuickplay = true;
					GlobalVariables.instance.isPracticeEnabled = false;
					BassAudioManager.instance.method_56(false);
				}
			}
			else
			{
				if (this.songScan.bool_0)
				{
					base.StartCoroutine(this.method_50());
					return;
				}
				if (SongDirectory.songEntries.Count == 0)
				{
					this.confirmMenu.method_47("highway_shake", " ", " (", new ConfirmationMenu.GDelegate6(this.method_46), null, null);
					return;
				}
				this.songSelect.SetActive(true);
				GlobalVariables.instance.wasInQuickplay = false;
				GlobalVariables.instance.isPracticeEnabled = true;
				BassAudioManager.instance.method_56(true);
			}
			base.gameObject.SetActive(true);
			return;
		}
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x000048A4 File Offset: 0x00002AA4
	protected virtual void vmethod_82()
	{
		this.buildVersion.text = "Tried to play sound for channel {0}[{1}] but handle was null!" + GlobalVariables.instance.string_0;
		base.vmethod_9();
		base.StartCoroutine(this.method_65());
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00048E74 File Offset: 0x00047074
	protected override void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !this.controlMapper.isOpen && this.controlMapper.enabled)
		{
			foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
			{
				if (gclass.Boolean_0)
				{
					gclass.playerProfileMenu_0.vmethod_43();
				}
			}
			this.controlMapper.Open();
		}
		if (!this.bool_13 && PlayerPrefs.GetInt("isEOL", 0) == 0)
		{
			for (int i = 0; i < GlobalVariables.instance.playerList.Count; i++)
			{
				if (GlobalVariables.instance.playerList[i].gclass10_0 != null && !this.notSupportedMenu.bool_11)
				{
					this.notSupportedMenu.method_44(this.string_2, "Visit Website", "OK", new ConfirmationMenu.GDelegate6(this.method_62), new ConfirmationMenu.GDelegate6(this.method_61), this.string_1);
					break;
				}
			}
		}
		if (this.bool_14 && GlobalVariables.instance.dokiArg)
		{
			for (int j = 0; j < GlobalVariables.instance.playerList.Count; j++)
			{
				if (GlobalVariables.instance.playerList[j].gclass10_0 != null && !this.notSupportedMenu.bool_11)
				{
					this.notSupportedMenu.method_44(this.string_2, "Go to Discord", "Quit", new ConfirmationMenu.GDelegate6(this.method_48), new ConfirmationMenu.GDelegate6(Application.Quit), this.string_1);
					this.bool_14 = false;
					break;
				}
			}
		}
		if (!this.controlMapper.isOpen && !this.confirmMenu.bool_11 && !this.notSupportedMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x000048D8 File Offset: 0x00002AD8
	public virtual void vmethod_83()
	{
		if (this.songScan.bool_1)
		{
			return;
		}
		base.vmethod_55();
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x000048EE File Offset: 0x00002AEE
	public void method_53()
	{
		this.songScan.method_22();
		base.StartCoroutine(this.songScan.method_32(true));
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void Awake()
	{
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x0000490E File Offset: 0x00002B0E
	private void method_54()
	{
		PlayerPrefs.SetInt("Disconnect", 1);
		PlayerPrefs.Save();
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00049060 File Offset: 0x00047260
	private void method_55()
	{
		this.bool_14 = (GlobalVariables.instance.float_0 < RemoteSettings.GetFloat("latestTestBuild", 0f));
		this.bool_13 = RemoteSettings.GetBool("isSupported", true);
		this.string_2 = RemoteSettings.GetString("notSupportedTitle_" + ((GlobalVariables.instance.gclass5_42.CurrentValue == 4) ? "Portuguese" : GlobalVariables.instance.languages[GlobalVariables.instance.gclass5_42.CurrentValue]), "This is a placeholder");
		this.string_1 = RemoteSettings.GetString("notSupportedBody_" + ((GlobalVariables.instance.gclass5_42.CurrentValue == 4) ? "Portuguese" : GlobalVariables.instance.languages[GlobalVariables.instance.gclass5_42.CurrentValue]), "This is a placeholder");
		this.string_3 = RemoteSettings.GetString("notSupportedLink", "This is a placeholder");
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x0000480F File Offset: 0x00002A0F
	private IEnumerator method_56()
	{
		return new MainMenu.Class14(0);
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00004920 File Offset: 0x00002B20
	public override void vmethod_26()
	{
		if (this.songScan.bool_1)
		{
			return;
		}
		base.vmethod_26();
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x0000480F File Offset: 0x00002A0F
	private IEnumerator method_57()
	{
		return new MainMenu.Class14(0);
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00004936 File Offset: 0x00002B36
	public void method_58()
	{
		this.songScan.method_61();
		base.StartCoroutine(this.songScan.method_54(true));
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00004956 File Offset: 0x00002B56
	public void method_59()
	{
		this.songScan.method_43();
		base.StartCoroutine(this.songScan.method_60(true));
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x0000487D File Offset: 0x00002A7D
	private void method_60()
	{
		Application.Quit();
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00004976 File Offset: 0x00002B76
	private void method_61()
	{
		PlayerPrefs.SetInt("isEOL", 1);
		PlayerPrefs.Save();
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00004988 File Offset: 0x00002B88
	protected virtual void vmethod_84()
	{
		this.buildVersion.text = "Song Length" + GlobalVariables.instance.string_0;
		base.OnEnable();
		base.StartCoroutine(this.method_65());
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x000049BC File Offset: 0x00002BBC
	private void method_62()
	{
		Application.OpenURL(this.string_3);
		this.method_61();
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00004858 File Offset: 0x00002A58
	private IEnumerator method_63()
	{
		MainMenu.Class13 @class = new MainMenu.Class13(0);
		@class.mainMenu_0 = this;
		return @class;
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x000049CF File Offset: 0x00002BCF
	private void method_64()
	{
		base.StartCoroutine(this.method_56());
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x000049DE File Offset: 0x00002BDE
	private IEnumerator method_65()
	{
		MainMenu.Class16 @class = new MainMenu.Class16(1);
		@class.mainMenu_0 = this;
		return @class;
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x000049ED File Offset: 0x00002BED
	protected override void OnEnable()
	{
		this.buildVersion.text = "Alpha " + GlobalVariables.instance.string_0;
		base.OnEnable();
		base.StartCoroutine(this.method_66());
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x000048D8 File Offset: 0x00002AD8
	public virtual void vmethod_85()
	{
		if (this.songScan.bool_1)
		{
			return;
		}
		base.vmethod_55();
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00004A21 File Offset: 0x00002C21
	private IEnumerator method_66()
	{
		MainMenu.Class16 @class = new MainMenu.Class16(0);
		@class.mainMenu_0 = this;
		return @class;
	}

	// Token: 0x04000191 RID: 401
	[SerializeField]
	private GameObject songSelect;

	// Token: 0x04000192 RID: 402
	[SerializeField]
	private GameObject settingsMenu;

	// Token: 0x04000193 RID: 403
	[SerializeField]
	private SongScan songScan;

	// Token: 0x04000194 RID: 404
	[SerializeField]
	private ControlMapper controlMapper;

	// Token: 0x04000195 RID: 405
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x04000196 RID: 406
	[SerializeField]
	private ConfirmationMenu notSupportedMenu;

	// Token: 0x04000197 RID: 407
	[SerializeField]
	private Text buildVersion;

	// Token: 0x04000198 RID: 408
	[SerializeField]
	private Text buildTag;

	// Token: 0x04000199 RID: 409
	[HideInInspector]
	public bool bool_12;

	// Token: 0x0400019A RID: 410
	private bool bool_13;

	// Token: 0x0400019B RID: 411
	private bool bool_14;

	// Token: 0x0400019C RID: 412
	private string string_1;

	// Token: 0x0400019D RID: 413
	private string string_2;

	// Token: 0x0400019E RID: 414
	private string string_3;

	// Token: 0x02000035 RID: 53
	[CompilerGenerated]
	private sealed class Class15
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_0(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_1(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_2(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_3(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_4(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_5(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_6(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_7(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_8(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_9(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_10(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_11(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_12(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_13(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_14(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_15(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_16(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_17(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_18(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_19(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_20(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_21(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_22(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_23(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_24(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_25(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_26(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_27(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_28(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_29(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_30(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_31(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_32(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_33(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_34(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_35(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_36(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_37(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_38(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00004A5E File Offset: 0x00002C5E
		internal int method_39(string string_0)
		{
			return this.random_0.Next();
		}

		// Token: 0x040001A4 RID: 420
		public System.Random random_0;
	}
}
