using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000053 RID: 83
public class SongOptions : BaseMenu
{
	// Token: 0x06000FB2 RID: 4018 RVA: 0x00075F70 File Offset: 0x00074170
	private void method_44()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 0)
		{
			i -= 0;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num += 0;
				}
				this.songSelect.vmethod_23(UnityEngine.Random.Range(i + 0, num));
				this.vmethod_38();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0007600C File Offset: 0x0007420C
	private void method_45()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			Process.Start("Play Setlist", "volume" + folderPath + "Has Lyrics");
		}
		else
		{
			Application.OpenURL(folderPath);
		}
		this.vmethod_4();
		this.vmethod_43();
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x000091D4 File Offset: 0x000073D4
	private void method_46()
	{
		GClass12.smethod_30(base.method_39());
		this.method_61(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x000091F4 File Offset: 0x000073F4
	private void method_47()
	{
		this.confirmMenu.method_47("video", ":", "", new ConfirmationMenu.GDelegate6(this.method_79), null, null);
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0000921E File Offset: 0x0000741E
	public virtual void vmethod_81()
	{
		this.int_5 = 1;
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.method_59();
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0007606C File Offset: 0x0007426C
	protected override void OnEnable()
	{
		string artistName = SongDirectory.songEntries[this.songSelect.Int32_0].artistName;
		base.OnEnable();
		this.method_68(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x000760BC File Offset: 0x000742BC
	private void method_48(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 0;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 1;
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
				this.menuStrings[0] = "Stopped broadcast.";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 8;
		}
		this.vmethod_67();
		this.vmethod_23(0);
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00076134 File Offset: 0x00074334
	private void method_49()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		bool flag = false;
		if (BassAudioManager.instance.isSongPlaying)
		{
			BassAudioManager.instance.method_29();
		}
		try
		{
			Directory.Delete(folderPath, true);
		}
		catch
		{
			flag = true;
		}
		SongDirectory.songEntries.RemoveAt(this.songSelect.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.songSelect.vmethod_3();
		if (SongDirectory.songEntries.Count == 0)
		{
			SongDirectory.songEntries.Clear();
			this.songSelect.vmethod_4();
		}
		else if (this.songSelect.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.songSelect.vmethod_25(0);
		}
		else
		{
			this.songSelect.vmethod_25(this.songSelect.Int32_0);
		}
		this.songSelect.method_58();
		base.gameObject.SetActive(false);
		if (flag)
		{
			this.confirmMenu.method_45("=", "botnosave", null, null, null, null);
		}
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00009247 File Offset: 0x00007447
	public virtual void vmethod_82()
	{
		this.int_5 = 1;
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_19();
		this.method_52();
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00009270 File Offset: 0x00007470
	private void method_50()
	{
		this.confirmMenu.method_44("This is permanent! Are you still sure?", "Get rid of it!", "Cancel!", new ConfirmationMenu.GDelegate6(this.method_79), null, null);
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00076250 File Offset: 0x00074450
	private void method_51()
	{
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		int index;
		do
		{
			index = UnityEngine.Random.Range(0, SongDirectory.songEntries.Count);
		}
		while (SongDirectory.songEntries[index].isHeader);
		this.songSelect.vmethod_23(index);
		this.vmethod_38();
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x000762AC File Offset: 0x000744AC
	public virtual void vmethod_83()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = false;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.int_4 == 0)
		{
			this.vmethod_23(0);
			base.gameObject.SetActive(false);
			return;
		}
		this.method_93(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
		base.method_43((this.int_4 == 1) ? "Unknown Artist" : "song");
		this.int_4 = 1;
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x00076344 File Offset: 0x00074544
	private void method_52()
	{
		string string_ = this.string_0;
		if (string_ == "Lead Guitar")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_1();
		}
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x00076384 File Offset: 0x00074584
	public virtual void vmethod_84()
	{
		if (this.gclass5_0 != null)
		{
			this.gclass5_0.method_17();
			this.method_59();
			return;
		}
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == -1)
		{
			this.int_5++;
		}
		else
		{
			this.int_5 = 1;
		}
		if (this.int_5 == 8)
		{
			this.method_98(this.extraOptions);
		}
		if (this.int_5 == 110)
		{
			this.method_98(this.extraOptions2);
		}
		if (this.int_5 == this.int_6.Length)
		{
			this.method_48(this.extraOptions3);
		}
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x00076434 File Offset: 0x00074634
	private void method_53()
	{
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		int index;
		do
		{
			index = UnityEngine.Random.Range(0, SongDirectory.songEntries.Count);
		}
		while (SongDirectory.songEntries[index].isHeader);
		this.songSelect.vmethod_23(index);
		this.vmethod_43();
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x0000929A File Offset: 0x0000749A
	public virtual void vmethod_85()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == 82)
		{
			this.int_5 += 0;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x00076490 File Offset: 0x00074690
	private void method_54()
	{
		if (GClass12.smethod_20(GClass12.string_2))
		{
			this.confirmMenu.method_44("Setlist was saved", "Continue", null, null, null, null);
			return;
		}
		this.confirmMenu.method_44("Problem saving setlist", "Continue", null, null, null, null);
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x000764DC File Offset: 0x000746DC
	public virtual void vmethod_86()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = false;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.int_4 == 8)
		{
			this.confirmMenu.method_48("low_latency_mode", "</color>", "Song Speed", new ConfirmationMenu.GDelegate6(this.method_46), null, null);
			return;
		}
		if (this.int_4 != 5)
		{
			string string_ = base.String_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 4294967191u)
			{
				if (num <= 4294967152u)
				{
					if (num <= 4u)
					{
						if (num != 4294967188u)
						{
							if (num != 4294967248u)
							{
								goto IL_61A;
							}
							if (string_ == "Lefty Flip")
							{
								this.method_71(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(string_ == "Disabled"))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = true;
							this.method_85(GClass12.smethod_8());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 4;
								return;
							}
							this.confirmMenu.method_49("All Strums", "Artist", null, null, null, null);
							this.method_71(this.setlistOptions);
							return;
						}
					}
					else if (num != 43u)
					{
						if (num != 4294967246u)
						{
							goto IL_61A;
						}
						if (!(string_ == "Rhythm Guitar"))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (string_ == "song")
						{
							this.method_51();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 108u)
				{
					if (num != 4294967292u)
					{
						if (num != 95u)
						{
							goto IL_61A;
						}
						if (string_ == "Stopped broadcast.")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_36("Delete Song");
							GClass12.string_3 = null;
							GClass12.bool_0 = false;
							this.setlistMenu.method_55(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "Lead Guitar"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[0];
							this.vmethod_3();
							this.vmethod_42();
							base.method_32();
							this.bool_12 = true;
							this.bool_13 = true;
							this.textObjects[0].text = GClass12.string_2;
							this.textObjects[1].text = GClass4.gclass4_0.method_42("genre");
							this.textObjects[0].text = GClass4.gclass4_0.method_21("Menu Music");
							this.textObjects[6].text = GClass4.gclass4_0.method_2("Great Solo!");
							CHPlayer.smethod_3();
							return;
						}
						if (GClass12.smethod_0(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_46("Unknown Genre", "Game Manager", "song", new ConfirmationMenu.GDelegate6(this.method_81), null, null);
							return;
						}
						this.method_82();
						return;
					}
				}
				else if (num != 137u)
				{
					if (num != 4294967250u)
					{
						goto IL_61A;
					}
					if (string_ == "Game Manager")
					{
						this.confirmMenu.method_44("Audio Offset", "msaa", " (", new ConfirmationMenu.GDelegate6(this.method_89), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "Gameplay")
					{
						this.menuStrings = new string[0];
						this.vmethod_67();
						this.vmethod_42();
						base.method_32();
						this.bool_13 = true;
						this.bool_12 = true;
						this.textObjects[0].text = GClass12.string_2;
						this.textObjects[0].text = GClass4.gclass4_0.method_5("Clone Hero");
						this.textObjects[4].text = GClass4.gclass4_0.method_21("song");
						this.textObjects[1].text = GClass4.gclass4_0.method_17("<color=#FFFF04FF>");
						this.setlistMenu.method_49();
						this.setlistMenu.float_0 = 995f;
						CHPlayer.smethod_12();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 106u)
			{
				if (num <= 4294967189u)
				{
					if (num != 4294967165u)
					{
						if (num != 4294967258u)
						{
							goto IL_61A;
						}
						if (string_ == "")
						{
							this.confirmMenu.method_46("mute_volume", "Unlimited", "Drop Out", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "path1"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_98(this.setlistOptionsActive);
							return;
						}
						this.method_68(this.setlistOptions);
						return;
					}
				}
				else if (num != 33u)
				{
					if (num != 4294967152u)
					{
						goto IL_61A;
					}
					if (string_ == "cpu_name")
					{
						this.method_72();
						return;
					}
					goto IL_61A;
				}
				else if (!(string_ == "0%"))
				{
					goto IL_61A;
				}
			}
			else if (num <= 188u)
			{
				if (num != 190u)
				{
					if (num != 188u)
					{
						goto IL_61A;
					}
					if (string_ == "Yes")
					{
						this.songSelect.method_89();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(string_ == "Stopped broadcast."))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = true;
					this.method_93(GClass12.smethod_5());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 5;
						return;
					}
					this.confirmMenu.method_52("video", "There was a problem saving the file", null, null, null, null);
					this.method_48(this.setlistOptions);
					return;
				}
			}
			else if (num != 35u)
			{
				if (num != 4294967224u)
				{
					if (num != 4294967159u)
					{
						goto IL_61A;
					}
					if (string_ == "All Opens")
					{
						this.setlistMenu.method_53(false);
						this.method_61(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "volume")
					{
						this.confirmMenu.method_53("[\\-\\+]?\\d+(\\.\\d+)?", "EndOfSong", "Year", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (string_ == "Main Menu")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_56();
			return;
			IL_61A:
			this.string_0 = base.String_0;
			this.method_62();
			return;
		}
		if (GClass12.smethod_41(base.String_0))
		{
			this.setlistMenu.method_62();
			this.method_48(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_53(" + ", "diff_guitar", null, null, null, null);
		this.method_71(this.setlistOptions);
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00076B2C File Offset: 0x00074D2C
	public virtual void vmethod_87()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = true;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.int_4 == 0)
		{
			this.vmethod_25(0);
			base.gameObject.SetActive(false);
			return;
		}
		this.method_61(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
		base.method_0((this.int_4 == 0) ? "" : "Note Shuffle");
		this.int_4 = 1;
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x000092DA File Offset: 0x000074DA
	public override void vmethod_12()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == 29)
		{
			this.int_5++;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00076BC4 File Offset: 0x00074DC4
	private void method_55()
	{
		bool flag = true;
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\b')
			{
				if (this.textObjects[0].text.Length > 0)
				{
					this.textObjects[0].text = this.textObjects[1].text.Substring(1, this.textObjects[1].text.Length - 1);
				}
			}
			else
			{
				if (c != '\'')
				{
					if (c != 'r')
					{
						if ((this.textObjects[0].text.Length == 0 && c == 'u') || this.textObjects[1].text.Length == 88)
						{
							goto IL_11E;
						}
						Text text = this.textObjects[1];
						text.text += c.ToString();
						this.textObjects[1].text = Regex.Replace(this.textObjects[0].text, "New Section", string.Empty);
						if (string.IsNullOrEmpty(this.textObjects[0].text))
						{
							this.textObjects[1].text = "song";
							goto IL_11E;
						}
						goto IL_11E;
					}
				}
				flag = true;
				IL_132:
				if (!Input.GetKeyDown((KeyCode)80) && !Input.GetKeyDown((KeyCode)(-112)) && !flag)
				{
					if (Input.GetKeyDown((KeyCode)11))
					{
						this.bool_12 = true;
						this.method_68(this.setlistOptionsActive);
						this.setlistMenu.float_0 = 1149f;
						base.method_0(this.bool_13 ? "" : "Go to Discord");
						CHPlayer.smethod_19();
					}
					return;
				}
				if (this.textObjects[0].text.Length == 0)
				{
					return;
				}
				string text2 = this.textObjects[0].text.Trim();
				if (this.bool_13)
				{
					GClass12.smethod_36(text2);
				}
				else
				{
					GClass12.string_2 = text2;
					if (GClass12.smethod_18(GClass12.string_2))
					{
						this.confirmMenu.method_44("Cancel", "song", "backend", new ConfirmationMenu.GDelegate6(this.method_106), null, null);
					}
					else
					{
						this.method_81();
					}
				}
				this.setlistMenu.method_57();
				this.bool_12 = true;
				this.method_101(this.setlistOptionsActive);
				base.method_0(this.bool_13 ? "game" : "\n");
				CHPlayer.smethod_4();
				return;
			}
			IL_11E:;
		}
		goto IL_132;
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00076E28 File Offset: 0x00075028
	private void method_56()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			Process.Start("Cancel LAN Search", "guitar" + folderPath + "Unknown Year");
		}
		else
		{
			Application.OpenURL(folderPath);
		}
		this.vmethod_43();
		this.vmethod_4();
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x00076E88 File Offset: 0x00075088
	private void method_57()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 0)
		{
			i -= 0;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num += 0;
				}
				this.songSelect.vmethod_23(UnityEngine.Random.Range(i + 1, num));
				this.vmethod_43();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x0000931A File Offset: 0x0000751A
	private void method_58()
	{
		this.confirmMenu.method_54("song", "game", "song", new ConfirmationMenu.GDelegate6(this.method_77), null, null);
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x00076F24 File Offset: 0x00075124
	protected virtual void vmethod_88()
	{
		string artistName = SongDirectory.songEntries[this.songSelect.Int32_0].artistName;
		base.vmethod_9();
		this.method_101(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x00009344 File Offset: 0x00007544
	protected virtual void vmethod_89()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		if (this.bool_12)
		{
			this.method_55();
			return;
		}
		base.Update();
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x00076F74 File Offset: 0x00075174
	private void method_59()
	{
		string string_ = this.string_0;
		if (string_ == "Song Speed")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.String_1;
		}
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x00076FB4 File Offset: 0x000751B4
	private void method_60()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			Process.Start("album", "Rhythm Guitar" + folderPath + "You must restart, settings were changed");
		}
		else
		{
			Application.OpenURL(folderPath);
		}
		this.vmethod_43();
		this.vmethod_38();
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x00077014 File Offset: 0x00075214
	private void method_61(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 0;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 0;
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
				this.menuStrings[0] = "PRESS START";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 4;
		}
		this.vmethod_3();
		this.vmethod_25(1);
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x0007708C File Offset: 0x0007528C
	public virtual void vmethod_90()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = true;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.int_4 == 0)
		{
			this.vmethod_25(1);
			base.gameObject.SetActive(false);
			return;
		}
		this.method_68(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
		base.method_0((this.int_4 == 1) ? "Song Offset" : "Guest");
		this.int_4 = 1;
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x00077124 File Offset: 0x00075324
	private void method_62()
	{
		string string_ = this.string_0;
		if (string_ == "SORTING BY")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_28();
		}
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x00009369 File Offset: 0x00007569
	protected virtual void vmethod_91()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		if (this.bool_12)
		{
			this.method_94();
			return;
		}
		base.Update();
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x00077164 File Offset: 0x00075364
	protected virtual void vmethod_92()
	{
		string artistName = SongDirectory.songEntries[this.songSelect.Int32_0].artistName;
		base.vmethod_9();
		this.method_93(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x0000938E File Offset: 0x0000758E
	public override void vmethod_7()
	{
		if (this.string_0 == "Song Speed")
		{
			this.method_59();
		}
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x000093A8 File Offset: 0x000075A8
	public virtual void vmethod_93()
	{
		this.int_5 = 0;
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_29();
		this.method_59();
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x000771B4 File Offset: 0x000753B4
	private void method_63()
	{
		if (GClass12.smethod_37(GClass12.string_2))
		{
			this.confirmMenu.method_45("Create Profile", "graphics_api_version", null, null, null, null);
			return;
		}
		this.confirmMenu.method_47("No scores saved for this song on", "settings.ini", null, null, null, null);
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00077200 File Offset: 0x00075400
	private void method_64()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		if (Application.platform == RuntimePlatform.OSXPlayer)
		{
			Process.Start("Mirror Mode", "-" + folderPath + "diff_drums");
		}
		else
		{
			Application.OpenURL(folderPath);
		}
		this.vmethod_4();
		this.vmethod_4();
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00077260 File Offset: 0x00075460
	private void method_65()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 0)
		{
			i--;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num += 0;
				}
				this.songSelect.vmethod_23(UnityEngine.Random.Range(i + 1, num));
				this.vmethod_38();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x000772FC File Offset: 0x000754FC
	private void method_66()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 1)
		{
			i -= 0;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num += 0;
				}
				this.songSelect.vmethod_23(UnityEngine.Random.Range(i + 1, num));
				this.vmethod_38();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x000093D1 File Offset: 0x000075D1
	private void method_67()
	{
		this.confirmMenu.method_44("volume", "Folders", "Press Escape to cancel", new ConfirmationMenu.GDelegate6(this.method_49), null, null);
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00009344 File Offset: 0x00007544
	protected virtual void vmethod_94()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		if (this.bool_12)
		{
			this.method_55();
			return;
		}
		base.Update();
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x000093FB File Offset: 0x000075FB
	public virtual void vmethod_95()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == -87)
		{
			this.int_5++;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x00077398 File Offset: 0x00075598
	public override void vmethod_43()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = true;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.int_4 == 0)
		{
			this.vmethod_23(0);
			base.gameObject.SetActive(false);
			return;
		}
		this.method_68(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
		base.method_0((this.int_4 == 1) ? "Song Options" : "Setlist");
		this.int_4 = 0;
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00077430 File Offset: 0x00075630
	private void method_68(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 0;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 1;
			if (Application.platform == RuntimePlatform.OSXPlayer)
			{
				this.menuStrings[1] = "Show in Finder";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 2;
		}
		this.vmethod_67();
		this.vmethod_23(0);
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x000774A8 File Offset: 0x000756A8
	private void method_69()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		bool flag = true;
		if (BassAudioManager.instance.isSongPlaying)
		{
			BassAudioManager.instance.method_29();
		}
		try
		{
			Directory.Delete(folderPath, true);
		}
		catch
		{
			flag = true;
		}
		SongDirectory.songEntries.RemoveAt(this.songSelect.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.songSelect.vmethod_67();
		if (SongDirectory.songEntries.Count == 0)
		{
			SongDirectory.songEntries.Clear();
			this.songSelect.vmethod_43();
		}
		else if (this.songSelect.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.songSelect.vmethod_25(1);
		}
		else
		{
			this.songSelect.vmethod_25(this.songSelect.Int32_0);
		}
		this.songSelect.method_58();
		base.gameObject.SetActive(true);
		if (flag)
		{
			this.confirmMenu.method_49("volume", "Folders", null, null, null, null);
		}
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x0000943B File Offset: 0x0000763B
	private void method_70()
	{
		GClass12.smethod_31(base.String_0);
		this.method_61(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0000945B File Offset: 0x0000765B
	public virtual void vmethod_96()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 1;
		}
		if (this.int_6[this.int_5] == -106)
		{
			this.int_5 += 0;
			return;
		}
		this.int_5 = 1;
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x000775C4 File Offset: 0x000757C4
	private void method_71(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 0;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 0;
			if (Application.platform == RuntimePlatform.OSXPlayer)
			{
				this.menuStrings[1] = "";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 3;
		}
		this.vmethod_67();
		this.vmethod_25(1);
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0007763C File Offset: 0x0007583C
	private void method_72()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 0)
		{
			i--;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num++;
				}
				this.songSelect.vmethod_23(UnityEngine.Random.Range(i + 1, num));
				this.vmethod_43();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x000776D8 File Offset: 0x000758D8
	private void method_73()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 0)
		{
			i -= 0;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num++;
				}
				this.songSelect.vmethod_25(UnityEngine.Random.Range(i + 1, num));
				this.vmethod_4();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0000949B File Offset: 0x0000769B
	private void method_74()
	{
		GClass12.smethod_9(base.method_39());
		this.method_71(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00077774 File Offset: 0x00075974
	public virtual void vmethod_97()
	{
		this.int_5 = 1;
		this.allowMultiLanguage = false;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.int_4 == 7)
		{
			this.confirmMenu.method_54("video", "custom_song_export", "You must restart, settings were changed", new ConfirmationMenu.GDelegate6(this.method_88), null, null);
			return;
		}
		if (this.int_4 != 3)
		{
			string text = base.method_39();
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 60u)
			{
				if (num <= 94u)
				{
					if (num <= 56u)
					{
						if (num != 77u)
						{
							if (num != 90u)
							{
								goto IL_61A;
							}
							if (text == "Guitar Coop")
							{
								this.method_61(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(text == "phrase_start"))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = true;
							this.method_61(GClass12.smethod_8());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 5;
								return;
							}
							this.confirmMenu.method_45("Resolution", "Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", null, null, null, null);
							this.method_101(this.setlistOptions);
							return;
						}
					}
					else if (num != 4294967242u)
					{
						if (num != 4294967203u)
						{
							goto IL_61A;
						}
						if (!(text == "album"))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (text == "notes.mid")
						{
							this.method_53();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 173u)
				{
					if (num != 49u)
					{
						if (num != 122u)
						{
							goto IL_61A;
						}
						if (text == "Play Setlist")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_17("...");
							GClass12.string_3 = null;
							GClass12.bool_0 = true;
							this.setlistMenu.method_50(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "Song Speed"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[0];
							this.vmethod_3();
							this.vmethod_42();
							base.method_5();
							this.bool_12 = false;
							this.bool_13 = false;
							this.textObjects[0].text = GClass12.string_2;
							this.textObjects[1].text = GClass4.gclass4_0.method_15(" ");
							this.textObjects[5].text = GClass4.gclass4_0.method_5("");
							this.textObjects[4].text = GClass4.gclass4_0.method_15("game");
							CHPlayer.smethod_12();
							return;
						}
						if (GClass12.smethod_13(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_54("Show in Finder", "pause_on_focus_lost", "star_release", new ConfirmationMenu.GDelegate6(this.method_63), null, null);
							return;
						}
						this.method_106();
						return;
					}
				}
				else if (num != 19u)
				{
					if (num != 4294967284u)
					{
						goto IL_61A;
					}
					if (text == "graphics_api")
					{
						this.confirmMenu.method_50(", Pos: ", "Black", "=", new ConfirmationMenu.GDelegate6(this.method_50), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == " + ")
					{
						this.menuStrings = new string[1];
						this.vmethod_67();
						this.vmethod_42();
						base.method_1();
						this.bool_13 = false;
						this.bool_12 = false;
						this.textObjects[1].text = GClass12.string_2;
						this.textObjects[0].text = GClass4.gclass4_0.method_16("Perfect Solo!");
						this.textObjects[2].text = GClass4.gclass4_0.method_15("{{ Chunk = {0}, Number = {1} }}");
						this.textObjects[7].text = GClass4.gclass4_0.method_7("Song");
						this.setlistMenu.method_49();
						this.setlistMenu.float_0 = 975f;
						CHPlayer.smethod_15();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 128u)
			{
				if (num <= 171u)
				{
					if (num != 183u)
					{
						if (num != 86u)
						{
							goto IL_61A;
						}
						if (text == "Menu Music")
						{
							this.confirmMenu.method_54("Guest", "6 Fret Guitar", "{0}", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "Charter"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_93(this.setlistOptionsActive);
							return;
						}
						this.method_93(this.setlistOptions);
						return;
					}
				}
				else if (num != 41u)
				{
					if (num != 151u)
					{
						goto IL_61A;
					}
					if (text == "song")
					{
						this.method_91();
						return;
					}
					goto IL_61A;
				}
				else if (!(text == "song"))
				{
					goto IL_61A;
				}
			}
			else if (num <= 168u)
			{
				if (num != 4294967129u)
				{
					if (num != 160u)
					{
						goto IL_61A;
					}
					if (text == "show_hit_window")
					{
						this.songSelect.method_52();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(text == "Yes"))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = true;
					this.method_61(GClass12.smethod_29());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 8;
						return;
					}
					this.confirmMenu.method_52("Practice", "album", null, null, null, null);
					this.method_71(this.setlistOptions);
					return;
				}
			}
			else if (num != 4294967294u)
			{
				if (num != 92u)
				{
					if (num != 133u)
					{
						goto IL_61A;
					}
					if (text == "song")
					{
						this.setlistMenu.method_53(false);
						this.method_101(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == "\"([^\"]*)\"")
					{
						this.confirmMenu.method_51("Stars Earned", ".png|.jpg", "track", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (text == "")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_64();
			return;
			IL_61A:
			this.string_0 = base.String_0;
			this.method_59();
			return;
		}
		if (GClass12.smethod_41(base.method_39()))
		{
			this.setlistMenu.method_66();
			this.method_48(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_54("volume", "No", null, null, null, null);
		this.method_101(this.setlistOptions);
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x000094BB File Offset: 0x000076BB
	public virtual void vmethod_98()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 1;
		}
		if (this.int_6[this.int_5] == -38)
		{
			this.int_5 += 0;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00077DC4 File Offset: 0x00075FC4
	private void method_75()
	{
		bool flag = true;
		foreach (char c in Input.inputString)
		{
			if (c == '\u0004')
			{
				if (this.textObjects[1].text.Length > 1)
				{
					this.textObjects[0].text = this.textObjects[0].text.Substring(0, this.textObjects[0].text.Length - 1);
				}
			}
			else
			{
				if (c != 'z')
				{
					if (c != '9')
					{
						if ((this.textObjects[1].text.Length == 0 && c == '\u0019') || this.textObjects[0].text.Length == 103)
						{
							goto IL_11E;
						}
						Text text = this.textObjects[0];
						text.text += c.ToString();
						this.textObjects[1].text = Regex.Replace(this.textObjects[0].text, "", string.Empty);
						if (string.IsNullOrEmpty(this.textObjects[0].text))
						{
							this.textObjects[0].text = "part bass";
							goto IL_11E;
						}
						goto IL_11E;
					}
				}
				flag = false;
				IL_132:
				if ((Input.GetKeyDown((KeyCode)(-17)) || !Input.GetKeyDown((KeyCode)(-34))) && !flag)
				{
					if (Input.GetKeyDown((KeyCode)(-78)))
					{
						this.bool_12 = true;
						this.method_71(this.setlistOptionsActive);
						this.setlistMenu.float_0 = 1427f;
						base.method_43(this.bool_13 ? "-" : "%");
						CHPlayer.smethod_7();
					}
					return;
				}
				if (this.textObjects[1].text.Length == 0)
				{
					return;
				}
				string text2 = this.textObjects[1].text.Trim();
				if (this.bool_13)
				{
					GClass12.smethod_36(text2);
				}
				else
				{
					GClass12.string_2 = text2;
					if (GClass12.smethod_0(GClass12.string_2))
					{
						this.confirmMenu.method_46("song", "Default", "cpu_count", new ConfirmationMenu.GDelegate6(this.method_106), null, null);
					}
					else
					{
						this.method_106();
					}
				}
				this.setlistMenu.method_54();
				this.bool_12 = false;
				this.method_101(this.setlistOptionsActive);
				base.method_0(this.bool_13 ? "OPTIONS" : "GHLive Guitar - ");
				CHPlayer.smethod_23();
				return;
			}
			IL_11E:;
		}
		goto IL_132;
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x000094FB File Offset: 0x000076FB
	public virtual void vmethod_99()
	{
		if (this.string_0 == "Menu Backgrounds")
		{
			this.method_62();
		}
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x00078028 File Offset: 0x00076228
	private void method_76()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		bool flag = true;
		if (BassAudioManager.instance.isSongPlaying)
		{
			BassAudioManager.instance.method_65();
		}
		try
		{
			Directory.Delete(folderPath, true);
		}
		catch
		{
			flag = true;
		}
		SongDirectory.songEntries.RemoveAt(this.songSelect.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.songSelect.vmethod_67();
		if (SongDirectory.songEntries.Count == 0)
		{
			SongDirectory.songEntries.Clear();
			this.songSelect.vmethod_4();
		}
		else if (this.songSelect.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.songSelect.vmethod_23(1);
		}
		else
		{
			this.songSelect.vmethod_23(this.songSelect.Int32_0);
		}
		this.songSelect.method_58();
		base.gameObject.SetActive(true);
		if (flag)
		{
			this.confirmMenu.method_45("", "Gameplay", null, null, null, null);
		}
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00009515 File Offset: 0x00007715
	public override void vmethod_18()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == 33)
		{
			this.int_5++;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00078144 File Offset: 0x00076344
	public virtual void vmethod_100()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = false;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.int_4 == 7)
		{
			this.confirmMenu.method_50("flames", "audio", "song", new ConfirmationMenu.GDelegate6(this.method_46), null, null);
			return;
		}
		if (this.int_4 != 0)
		{
			string text = base.method_39();
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 36u)
			{
				if (num <= 96u)
				{
					if (num <= 8u)
					{
						if (num != 4294967197u)
						{
							if (num != 4294967243u)
							{
								goto IL_61A;
							}
							if (text == "setlistSongCountPlural")
							{
								this.method_71(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(text == "Alpha "))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = true;
							this.method_93(GClass12.smethod_29());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 6;
								return;
							}
							this.confirmMenu.method_45("Medium", "Low Latency Mode", null, null, null, null);
							this.method_93(this.setlistOptions);
							return;
						}
					}
					else if (num != 4294967108u)
					{
						if (num != 188u)
						{
							goto IL_61A;
						}
						if (!(text == ""))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (text == "Quit")
						{
							this.method_51();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 1u)
				{
					if (num != 4294967208u)
					{
						if (num != 4294967098u)
						{
							goto IL_61A;
						}
						if (text == "song")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_7("song");
							GClass12.string_3 = null;
							GClass12.bool_0 = false;
							this.setlistMenu.method_46(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "Yo dawg, I heard you like lanes so this activates lanes!"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[1];
							this.vmethod_67();
							this.vmethod_42();
							base.method_36();
							this.bool_12 = false;
							this.bool_13 = false;
							this.textObjects[1].text = GClass12.string_2;
							this.textObjects[0].text = GClass4.gclass4_0.method_7("Good Solo");
							this.textObjects[4].text = GClass4.gclass4_0.method_41("You must restart, settings were changed");
							this.textObjects[3].text = GClass4.gclass4_0.method_36("No");
							CHPlayer.smethod_3();
							return;
						}
						if (GClass12.smethod_13(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_45("video", "streamer", "Show Lyrics", new ConfirmationMenu.GDelegate6(this.method_54), null, null);
							return;
						}
						this.method_106();
						return;
					}
				}
				else if (num != 4294967154u)
				{
					if (num != 132u)
					{
						goto IL_61A;
					}
					if (text == "<color=#FFFF04FF>")
					{
						this.confirmMenu.method_54(" (", "bad_note2", "notSupportedLink", new ConfirmationMenu.GDelegate6(this.method_104), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == "Gameplay")
					{
						this.menuStrings = new string[1];
						this.vmethod_67();
						this.vmethod_42();
						base.method_5();
						this.bool_13 = false;
						this.bool_12 = false;
						this.textObjects[0].text = GClass12.string_2;
						this.textObjects[1].text = GClass4.gclass4_0.method_41("SECTION");
						this.textObjects[4].text = GClass4.gclass4_0.method_38("year");
						this.textObjects[6].text = GClass4.gclass4_0.method_46("GHLBass");
						this.setlistMenu.method_64();
						this.setlistMenu.float_0 = 991f;
						CHPlayer.smethod_10();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 122u)
			{
				if (num <= 4294967114u)
				{
					if (num != 2u)
					{
						if (num != 4294967287u)
						{
							goto IL_61A;
						}
						if (text == "isEOL")
						{
							this.confirmMenu.method_47("show_hit_window", "A: ", "Difficulty", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "video"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_61(this.setlistOptionsActive);
							return;
						}
						this.method_85(this.setlistOptions);
						return;
					}
				}
				else if (num != 92u)
				{
					if (num != 17u)
					{
						goto IL_61A;
					}
					if (text == " (")
					{
						this.method_65();
						return;
					}
					goto IL_61A;
				}
				else if (!(text == "Keys - "))
				{
					goto IL_61A;
				}
			}
			else if (num <= 101u)
			{
				if (num != 193u)
				{
					if (num != 104u)
					{
						goto IL_61A;
					}
					if (text == "no_fail")
					{
						this.songSelect.method_89();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(text == "Are you sure?"))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = true;
					this.method_61(GClass12.smethod_39());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 1;
						return;
					}
					this.confirmMenu.method_52("Scan Songs", "rhythm", null, null, null, null);
					this.method_71(this.setlistOptions);
					return;
				}
			}
			else if (num != 4294967244u)
			{
				if (num != 4294967217u)
				{
					if (num != 56u)
					{
						goto IL_61A;
					}
					if (text == "song")
					{
						this.setlistMenu.method_53(false);
						this.method_48(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == "game")
					{
						this.confirmMenu.method_48("part rhythm", "Stars", "Mirror Mode", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (text == "Album")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_107();
			return;
			IL_61A:
			this.string_0 = base.method_39();
			this.method_52();
			return;
		}
		if (GClass12.smethod_38(base.String_0))
		{
			this.setlistMenu.method_44();
			this.method_93(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_44("A: ", "Hard", null, null, null, null);
		this.method_48(this.setlistOptions);
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00078794 File Offset: 0x00076994
	private void method_77()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		bool flag = true;
		if (BassAudioManager.instance.isSongPlaying)
		{
			BassAudioManager.instance.method_65();
		}
		try
		{
			Directory.Delete(folderPath, true);
		}
		catch
		{
			flag = false;
		}
		SongDirectory.songEntries.RemoveAt(this.songSelect.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.songSelect.vmethod_3();
		if (SongDirectory.songEntries.Count == 0)
		{
			SongDirectory.songEntries.Clear();
			this.songSelect.vmethod_4();
		}
		else if (this.songSelect.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.songSelect.vmethod_23(0);
		}
		else
		{
			this.songSelect.vmethod_25(this.songSelect.Int32_0);
		}
		this.songSelect.method_86();
		base.gameObject.SetActive(false);
		if (flag)
		{
			this.confirmMenu.method_52("/songs.json", "song", null, null, null, null);
		}
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x000788B0 File Offset: 0x00076AB0
	private void method_78()
	{
		bool flag = true;
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\u0005')
			{
				if (this.textObjects[0].text.Length > 0)
				{
					this.textObjects[0].text = this.textObjects[0].text.Substring(1, this.textObjects[0].text.Length - 1);
				}
			}
			else
			{
				if (c != '~')
				{
					if ((int)c != -29)
					{
						if ((this.textObjects[1].text.Length == 0 && c == '!') || this.textObjects[1].text.Length == 72)
						{
							goto IL_11E;
						}
						Text text = this.textObjects[1];
						text.text += c.ToString();
						this.textObjects[0].text = Regex.Replace(this.textObjects[1].text, "enable_cursor", string.Empty);
						if (string.IsNullOrEmpty(this.textObjects[1].text))
						{
							this.textObjects[0].text = "Continue";
							goto IL_11E;
						}
						goto IL_11E;
					}
				}
				flag = true;
				IL_132:
				if (!Input.GetKeyDown((KeyCode)(-9)) && !Input.GetKeyDown((KeyCode)(-150)) && !flag)
				{
					if (Input.GetKeyDown((KeyCode)83))
					{
						this.bool_12 = true;
						this.method_93(this.setlistOptionsActive);
						this.setlistMenu.float_0 = 1919f;
						base.method_43(this.bool_13 ? "{0}x{1}" : "<color=#FFA300>");
						CHPlayer.smethod_19();
					}
					return;
				}
				if (this.textObjects[0].text.Length == 0)
				{
					return;
				}
				string text2 = this.textObjects[1].text.Trim();
				if (this.bool_13)
				{
					GClass12.smethod_32(text2);
				}
				else
				{
					GClass12.string_2 = text2;
					if (GClass12.smethod_33(GClass12.string_2))
					{
						this.confirmMenu.method_45("song", "sort_filter", "[^\\u0020-\\u007E]", new ConfirmationMenu.GDelegate6(this.method_54), null, null);
					}
					else
					{
						this.method_54();
					}
				}
				this.setlistMenu.method_57();
				this.bool_12 = true;
				this.method_93(this.setlistOptionsActive);
				base.method_0(this.bool_13 ? ".setlist" : "No");
				CHPlayer.smethod_26();
				return;
			}
			IL_11E:;
		}
		goto IL_132;
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00078B14 File Offset: 0x00076D14
	protected virtual void vmethod_101()
	{
		string artistName = SongDirectory.songEntries[this.songSelect.Int32_0].artistName;
		base.vmethod_9();
		this.method_68(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00078B64 File Offset: 0x00076D64
	public virtual void vmethod_102()
	{
		this.int_5 = 1;
		this.allowMultiLanguage = false;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.int_4 == 7)
		{
			this.confirmMenu.method_50("Sound Effects", "song", "/", new ConfirmationMenu.GDelegate6(this.method_88), null, null);
			return;
		}
		if (this.int_4 != 4)
		{
			string text = base.method_39();
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 161u)
			{
				if (num <= 4294967256u)
				{
					if (num <= 20u)
					{
						if (num != 4294967207u)
						{
							if (num != 80u)
							{
								goto IL_61A;
							}
							if (text == "Are you sure you want to quit?")
							{
								this.method_93(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(text == "song"))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = false;
							this.method_101(GClass12.smethod_5());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 4;
								return;
							}
							this.confirmMenu.method_49("setlistSongCountPlural", "Create Profile", null, null, null, null);
							this.method_71(this.setlistOptions);
							return;
						}
					}
					else if (num != 40u)
					{
						if (num != 89u)
						{
							goto IL_61A;
						}
						if (!(text == "Controller"))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (text == "playlist_track")
						{
							this.method_97();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 79u)
				{
					if (num != 4294967115u)
					{
						if (num != 4294967294u)
						{
							goto IL_61A;
						}
						if (text == "Rhythm Guitar")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_15("Delete Profile");
							GClass12.string_3 = null;
							GClass12.bool_0 = false;
							this.setlistMenu.method_50(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "notes.chart"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[0];
							this.vmethod_3();
							this.vmethod_42();
							base.method_36();
							this.bool_12 = true;
							this.bool_13 = false;
							this.textObjects[0].text = GClass12.string_2;
							this.textObjects[1].text = GClass4.gclass4_0.method_42("No");
							this.textObjects[6].text = GClass4.gclass4_0.method_15("");
							this.textObjects[8].text = GClass4.gclass4_0.method_16("[prc_");
							CHPlayer.smethod_15();
							return;
						}
						if (GClass12.smethod_18(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_49("Artist", "diff_rhythm", "Go to Discord", new ConfirmationMenu.GDelegate6(this.method_63), null, null);
							return;
						}
						this.method_54();
						return;
					}
				}
				else if (num != 55u)
				{
					if (num != 4294967252u)
					{
						goto IL_61A;
					}
					if (text == "Resolution")
					{
						this.confirmMenu.method_53("volume", "album_track", "Visit Website", new ConfirmationMenu.GDelegate6(this.method_83), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == "6 Fret Bass Guitar")
					{
						this.menuStrings = new string[1];
						this.vmethod_67();
						this.vmethod_42();
						base.method_1();
						this.bool_13 = false;
						this.bool_12 = false;
						this.textObjects[1].text = GClass12.string_2;
						this.textObjects[0].text = GClass4.gclass4_0.method_30("Unknown Album");
						this.textObjects[8].text = GClass4.gclass4_0.method_48("Game Manager");
						this.textObjects[5].text = GClass4.gclass4_0.method_17("Medium");
						this.setlistMenu.method_49();
						this.setlistMenu.float_0 = 1125f;
						CHPlayer.smethod_22();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 123u)
			{
				if (num <= 50u)
				{
					if (num != 4294967207u)
					{
						if (num != 4294967181u)
						{
							goto IL_61A;
						}
						if (text == "-")
						{
							this.confirmMenu.method_45("graphics_venid", "All Opens", "Pause on Focus Lost", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "<color=#FFFF04FF>"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_98(this.setlistOptionsActive);
							return;
						}
						this.method_101(this.setlistOptions);
						return;
					}
				}
				else if (num != 4294967152u)
				{
					if (num != 156u)
					{
						goto IL_61A;
					}
					if (text == "highway_shake")
					{
						this.method_99();
						return;
					}
					goto IL_61A;
				}
				else if (!(text == "vocals_1"))
				{
					goto IL_61A;
				}
			}
			else if (num <= 47u)
			{
				if (num != 4294967141u)
				{
					if (num != 83u)
					{
						goto IL_61A;
					}
					if (text == "Streamer Settings")
					{
						this.songSelect.method_89();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(text == "SETLIST LENGTH"))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = true;
					this.method_101(GClass12.smethod_40());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 6;
						return;
					}
					this.confirmMenu.method_45("song", "Song", null, null, null, null);
					this.method_101(this.setlistOptions);
					return;
				}
			}
			else if (num != 4294967130u)
			{
				if (num != 4294967143u)
				{
					if (num != 115u)
					{
						goto IL_61A;
					}
					if (text == "video")
					{
						this.setlistMenu.method_61(true);
						this.method_61(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == "mute_on_miss")
					{
						this.confirmMenu.method_44("Video Offset", "volume", " (", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (text == "Unknown Artist")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_45();
			return;
			IL_61A:
			this.string_0 = base.method_39();
			this.method_59();
			return;
		}
		if (GClass12.smethod_41(base.String_0))
		{
			this.setlistMenu.method_66();
			this.method_85(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_52("video", "Medium", null, null, null, null);
		this.method_93(this.setlistOptions);
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x000791B4 File Offset: 0x000773B4
	private void method_79()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		bool flag = false;
		if (BassAudioManager.instance.isSongPlaying)
		{
			BassAudioManager.instance.method_65();
		}
		try
		{
			Directory.Delete(folderPath, true);
		}
		catch
		{
			flag = true;
		}
		SongDirectory.songEntries.RemoveAt(this.songSelect.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.songSelect.vmethod_67();
		if (SongDirectory.songEntries.Count == 1)
		{
			SongDirectory.songEntries.Clear();
			this.songSelect.vmethod_43();
		}
		else if (this.songSelect.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.songSelect.vmethod_23(1);
		}
		else
		{
			this.songSelect.vmethod_23(this.songSelect.Int32_0);
		}
		this.songSelect.method_50();
		base.gameObject.SetActive(false);
		if (flag)
		{
			this.confirmMenu.method_44("There was an error deleting the file", "Continue", null, null, null, null);
		}
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x00009555 File Offset: 0x00007755
	private void method_80()
	{
		GClass12.smethod_21(base.String_0);
		this.method_101(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x000792D0 File Offset: 0x000774D0
	private void method_81()
	{
		if (GClass12.smethod_12(GClass12.string_2))
		{
			this.confirmMenu.method_46("MSAA Level", "No scores saved for this song on", null, null, null, null);
			return;
		}
		this.confirmMenu.method_50("Get Hardware Latency", "song", null, null, null, null);
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x0007931C File Offset: 0x0007751C
	private void method_82()
	{
		if (GClass12.smethod_12(GClass12.string_2))
		{
			this.confirmMenu.method_47("Save Playlist", "low_latency_mode", null, null, null, null);
			return;
		}
		this.confirmMenu.method_44("graphics_devid", "Game Manager", null, null, null, null);
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00009575 File Offset: 0x00007775
	public virtual void vmethod_103()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 1;
		}
		if (this.int_6[this.int_5] == 36)
		{
			this.int_5++;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x000095B5 File Offset: 0x000077B5
	private void method_83()
	{
		this.confirmMenu.method_51("5 Fret Guitar", "songcache.bin", "RhythmStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", new ConfirmationMenu.GDelegate6(this.method_76), null, null);
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x000095DF File Offset: 0x000077DF
	public virtual void vmethod_104()
	{
		this.int_5 = 1;
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.method_52();
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00009608 File Offset: 0x00007808
	public override void vmethod_44()
	{
		this.int_5 = 0;
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.method_59();
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00079368 File Offset: 0x00077568
	private void method_84()
	{
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		int index;
		do
		{
			index = UnityEngine.Random.Range(1, SongDirectory.songEntries.Count);
		}
		while (SongDirectory.songEntries[index].isHeader);
		this.songSelect.vmethod_25(index);
		this.vmethod_43();
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00009631 File Offset: 0x00007831
	public virtual void vmethod_105()
	{
		if (this.string_0 == "Lead Guitar")
		{
			this.method_59();
		}
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x0000964B File Offset: 0x0000784B
	public virtual void vmethod_106()
	{
		if (this.string_0 == "Quit")
		{
			this.method_59();
		}
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00009665 File Offset: 0x00007865
	public virtual void vmethod_107()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 1;
		}
		if (this.int_6[this.int_5] == -104)
		{
			this.int_5 += 0;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x000793C4 File Offset: 0x000775C4
	private void method_85(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 1;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 1;
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
				this.menuStrings[0] = "Guitar Coop";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 1;
		}
		this.vmethod_3();
		this.vmethod_25(0);
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x0007943C File Offset: 0x0007763C
	private void method_86()
	{
		bool flag = true;
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i++)
		{
			char c = inputString[i];
			if (c == '\u0004')
			{
				if (this.textObjects[1].text.Length > 0)
				{
					this.textObjects[0].text = this.textObjects[0].text.Substring(1, this.textObjects[0].text.Length - 0);
				}
			}
			else
			{
				if (c != '&')
				{
					if ((int)c != -78)
					{
						if ((this.textObjects[0].text.Length == 0 && c == '~') || this.textObjects[0].text.Length == -12)
						{
							goto IL_11E;
						}
						Text text = this.textObjects[0];
						text.text += c.ToString();
						this.textObjects[1].text = Regex.Replace(this.textObjects[0].text, "part keys", string.Empty);
						if (string.IsNullOrEmpty(this.textObjects[1].text))
						{
							this.textObjects[0].text = "crowd";
							goto IL_11E;
						}
						goto IL_11E;
					}
				}
				flag = false;
				IL_132:
				if ((Input.GetKeyDown((KeyCode)11) || !Input.GetKeyDown((KeyCode)89)) && !flag)
				{
					if (Input.GetKeyDown(KeyCode.Percent))
					{
						this.bool_12 = false;
						this.method_85(this.setlistOptionsActive);
						this.setlistMenu.float_0 = 1730f;
						base.method_43(this.bool_13 ? "notes.chart" : "highway_placement");
						CHPlayer.smethod_4();
					}
					return;
				}
				if (this.textObjects[0].text.Length == 0)
				{
					return;
				}
				string text2 = this.textObjects[0].text.Trim();
				if (this.bool_13)
				{
					GClass12.smethod_32(text2);
				}
				else
				{
					GClass12.string_2 = text2;
					if (GClass12.smethod_10(GClass12.string_2))
					{
						this.confirmMenu.method_47("volume", "Okay Solo...", "0%", new ConfirmationMenu.GDelegate6(this.method_106), null, null);
					}
					else
					{
						this.method_81();
					}
				}
				this.setlistMenu.method_57();
				this.bool_12 = false;
				this.method_48(this.setlistOptionsActive);
				base.method_0(this.bool_13 ? "No Part" : "highway_shake");
				CHPlayer.smethod_5();
				return;
			}
			IL_11E:;
		}
		goto IL_132;
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x000096A5 File Offset: 0x000078A5
	private void method_87()
	{
		GClass12.smethod_21(base.method_39());
		this.method_93(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x000096C5 File Offset: 0x000078C5
	public virtual void vmethod_108()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == 115)
		{
			this.int_5++;
			return;
		}
		this.int_5 = 0;
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x000796A0 File Offset: 0x000778A0
	public override void vmethod_39()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = true;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.int_4 == 3)
		{
			this.confirmMenu.method_44("Are you sure you want to delete this setlist?", "Yes", "No", new ConfirmationMenu.GDelegate6(this.method_108), null, null);
			return;
		}
		if (this.int_4 != 4)
		{
			string string_ = base.String_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 2287133007u)
			{
				if (num <= 600350426u)
				{
					if (num <= 194375842u)
					{
						if (num != 142991090u)
						{
							if (num != 194375842u)
							{
								goto IL_61A;
							}
							if (string_ == "Song Options")
							{
								this.method_68(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(string_ == "Delete Setlist"))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = false;
							this.method_68(GClass12.smethod_8());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 3;
								return;
							}
							this.confirmMenu.method_44("There are no saved setlists", "Continue", null, null, null, null);
							this.method_68(this.setlistOptions);
							return;
						}
					}
					else if (num != 351440407u)
					{
						if (num != 600350426u)
						{
							goto IL_61A;
						}
						if (!(string_ == "Show in File Explorer"))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (string_ == "Random Song")
						{
							this.method_53();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 1569119161u)
				{
					if (num != 911050688u)
					{
						if (num != 1569119161u)
						{
							goto IL_61A;
						}
						if (string_ == "Create Setlist")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_13("New Setlist");
							GClass12.string_3 = null;
							GClass12.bool_0 = false;
							this.setlistMenu.method_55(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "Save Setlist"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[0];
							this.vmethod_67();
							this.vmethod_42();
							base.method_5();
							this.bool_12 = true;
							this.bool_13 = false;
							this.textObjects[0].text = GClass12.string_2;
							this.textObjects[1].text = GClass4.gclass4_0.method_13("Type the setlist name");
							this.textObjects[2].text = GClass4.gclass4_0.method_13("Press Enter to confirm");
							this.textObjects[3].text = GClass4.gclass4_0.method_13("Press Escape to cancel");
							CHPlayer.smethod_15();
							return;
						}
						if (GClass12.smethod_0(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_44("A setlist with that name already exists", "Overwrite", "Cancel", new ConfirmationMenu.GDelegate6(this.method_54), null, null);
							return;
						}
						this.method_54();
						return;
					}
				}
				else if (num != 1939545255u)
				{
					if (num != 2287133007u)
					{
						goto IL_61A;
					}
					if (string_ == "Delete Song")
					{
						this.confirmMenu.method_44("Are you sure you want to delete this song?", "Yes", "No", new ConfirmationMenu.GDelegate6(this.method_50), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "Rename Setlist")
					{
						this.menuStrings = new string[0];
						this.vmethod_67();
						this.vmethod_42();
						base.method_5();
						this.bool_13 = true;
						this.bool_12 = true;
						this.textObjects[0].text = GClass12.string_2;
						this.textObjects[1].text = GClass4.gclass4_0.method_13("Type the setlist name");
						this.textObjects[2].text = GClass4.gclass4_0.method_13("Press Enter to confirm");
						this.textObjects[3].text = GClass4.gclass4_0.method_13("Press Escape to cancel");
						this.setlistMenu.method_64();
						this.setlistMenu.float_0 = -1f;
						CHPlayer.smethod_15();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 2877564881u)
			{
				if (num <= 2685117737u)
				{
					if (num != 2636738313u)
					{
						if (num != 2685117737u)
						{
							goto IL_61A;
						}
						if (string_ == "Enable Lanes")
						{
							this.confirmMenu.method_44("Yo dawg, I heard you like lanes so this activates lanes!", "Enable", "Cancel", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "Setlist Options"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_68(this.setlistOptionsActive);
							return;
						}
						this.method_68(this.setlistOptions);
						return;
					}
				}
				else if (num != 2839816873u)
				{
					if (num != 2877564881u)
					{
						goto IL_61A;
					}
					if (string_ == "Random Song (Section)")
					{
						this.method_72();
						return;
					}
					goto IL_61A;
				}
				else if (!(string_ == "Show in Finder"))
				{
					goto IL_61A;
				}
			}
			else if (num <= 3509721975u)
			{
				if (num != 3249228965u)
				{
					if (num != 3509721975u)
					{
						goto IL_61A;
					}
					if (string_ == "Play Setlist")
					{
						this.songSelect.method_52();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(string_ == "Load Setlist"))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = false;
					this.method_68(GClass12.smethod_8());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 4;
						return;
					}
					this.confirmMenu.method_44("There are no saved setlists", "Continue", null, null, null, null);
					this.method_68(this.setlistOptions);
					return;
				}
			}
			else if (num != 3558350423u)
			{
				if (num != 3703297810u)
				{
					if (num != 4003674922u)
					{
						goto IL_61A;
					}
					if (string_ == "Clear Setlist")
					{
						this.setlistMenu.method_61(true);
						this.method_68(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "Ultra Greatness Mode")
					{
						this.confirmMenu.method_44("This mode is so secret, no one knows what it does!", "Enable", "Cancel", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (string_ == "Song Speed")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_107();
			return;
			IL_61A:
			this.string_0 = base.String_0;
			this.method_59();
			return;
		}
		if (GClass12.smethod_38(base.String_0))
		{
			this.setlistMenu.method_62();
			this.method_68(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_44("Problem loading setlist", "Continue", null, null, null, null);
		this.method_68(this.setlistOptions);
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00009705 File Offset: 0x00007905
	public virtual void vmethod_109()
	{
		if (this.string_0 == "Songs Scanned")
		{
			this.method_52();
		}
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x0000971F File Offset: 0x0000791F
	private void method_88()
	{
		GClass12.smethod_30(base.String_0);
		this.method_85(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x0000973F File Offset: 0x0000793F
	public virtual void vmethod_110()
	{
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == -71)
		{
			this.int_5 += 0;
			return;
		}
		this.int_5 = 1;
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x0000977F File Offset: 0x0000797F
	private void method_89()
	{
		this.confirmMenu.method_50("Cancel", "<color=#FFA300>", "WRITING BADSONGS.TXT...", new ConfirmationMenu.GDelegate6(this.method_49), null, null);
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x000097A9 File Offset: 0x000079A9
	private void method_90()
	{
		GClass12.smethod_9(base.method_39());
		this.method_98(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00079CF0 File Offset: 0x00077EF0
	public virtual void vmethod_111()
	{
		this.int_5 = 1;
		this.allowMultiLanguage = false;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.int_4 == 7)
		{
			this.confirmMenu.method_47("Listening on port: ", "\\D", "%", new ConfirmationMenu.GDelegate6(this.method_74), null, null);
			return;
		}
		if (this.int_4 != 5)
		{
			string string_ = base.String_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 135u)
			{
				if (num <= 176u)
				{
					if (num <= 4294967138u)
					{
						if (num != 4294967251u)
						{
							if (num != 4294967129u)
							{
								goto IL_61A;
							}
							if (string_ == "[Events]")
							{
								this.method_93(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(string_ == "Enabled"))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = false;
							this.method_98(GClass12.smethod_5());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 4;
								return;
							}
							this.confirmMenu.method_53("Cancel", "/songs.json", null, null, null, null);
							this.method_98(this.setlistOptions);
							return;
						}
					}
					else if (num != 169u)
					{
						if (num != 126u)
						{
							goto IL_61A;
						}
						if (!(string_ == "Bad file type"))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (string_ == "SORTING BY")
						{
							this.method_51();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 4294967114u)
				{
					if (num != 4294967244u)
					{
						if (num != 4294967208u)
						{
							goto IL_61A;
						}
						if (string_ == "song")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_30("");
							GClass12.string_3 = null;
							GClass12.bool_0 = true;
							this.setlistMenu.method_50(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "volume"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[1];
							this.vmethod_3();
							this.vmethod_42();
							base.method_5();
							this.bool_12 = true;
							this.bool_13 = false;
							this.textObjects[1].text = GClass12.string_2;
							this.textObjects[0].text = GClass4.gclass4_0.method_41("Hz");
							this.textObjects[2].text = GClass4.gclass4_0.method_13("low_latency_mode");
							this.textObjects[2].text = GClass4.gclass4_0.method_21("gh3_sudden_death");
							CHPlayer.smethod_6();
							return;
						}
						if (GClass12.smethod_33(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_44("Restart Section", "game", "These folders contain charts that another song has (duplicate charts)!", new ConfirmationMenu.GDelegate6(this.method_81), null, null);
							return;
						}
						this.method_81();
						return;
					}
				}
				else if (num != 128u)
				{
					if (num != 4294967111u)
					{
						goto IL_61A;
					}
					if (string_ == "")
					{
						this.confirmMenu.method_50("You must restart, settings were changed", "diff_band", "None", new ConfirmationMenu.GDelegate6(this.method_58), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "Sound Effects")
					{
						this.menuStrings = new string[1];
						this.vmethod_3();
						this.vmethod_42();
						base.method_5();
						this.bool_13 = false;
						this.bool_12 = false;
						this.textObjects[1].text = GClass12.string_2;
						this.textObjects[1].text = GClass4.gclass4_0.method_15("6 Fret Lead Guitar");
						this.textObjects[4].text = GClass4.gclass4_0.method_7("Audio Offset");
						this.textObjects[7].text = GClass4.gclass4_0.method_21("Ready");
						this.setlistMenu.method_64();
						this.setlistMenu.float_0 = 859f;
						CHPlayer.smethod_29();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 27u)
			{
				if (num <= 40u)
				{
					if (num != 97u)
					{
						if (num != 4294967175u)
						{
							goto IL_61A;
						}
						if (string_ == "Mirror Mode")
						{
							this.confirmMenu.method_47("Songs", "_ENDOFSONG", ".png|.jpg", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "Create Profile"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_68(this.setlistOptionsActive);
							return;
						}
						this.method_101(this.setlistOptions);
						return;
					}
				}
				else if (num != 58u)
				{
					if (num != 9u)
					{
						goto IL_61A;
					}
					if (string_ == "Song Length")
					{
						this.method_44();
						return;
					}
					goto IL_61A;
				}
				else if (!(string_ == "Framerate"))
				{
					goto IL_61A;
				}
			}
			else if (num <= 4294967227u)
			{
				if (num != 4294967185u)
				{
					if (num != 4294967220u)
					{
						goto IL_61A;
					}
					if (string_ == "custom")
					{
						this.songSelect.method_52();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(string_ == "Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = true;
					this.method_61(GClass12.smethod_29());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 2;
						return;
					}
					this.confirmMenu.method_53("Cancel!", "Single", null, null, null, null);
					this.method_93(this.setlistOptions);
					return;
				}
			}
			else if (num != 67u)
			{
				if (num != 4294967180u)
				{
					if (num != 4294967204u)
					{
						goto IL_61A;
					}
					if (string_ == "Guitar")
					{
						this.setlistMenu.method_61(true);
						this.method_61(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "")
					{
						this.confirmMenu.method_52("Clear Setlist", "BassStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "game", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (string_ == "\n")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_107();
			return;
			IL_61A:
			this.string_0 = base.method_39();
			this.method_59();
			return;
		}
		if (GClass12.smethod_7(base.method_39()))
		{
			this.setlistMenu.method_62();
			this.method_48(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_51("volume", "</color>", null, null, null, null);
		this.method_68(this.setlistOptions);
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x0007A340 File Offset: 0x00078540
	private void method_91()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 0)
		{
			i--;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num++;
				}
				this.songSelect.vmethod_25(UnityEngine.Random.Range(i + 1, num));
				this.vmethod_43();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x000097C9 File Offset: 0x000079C9
	public virtual void vmethod_112()
	{
		this.int_5 = 1;
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.method_62();
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x000097F2 File Offset: 0x000079F2
	public virtual void vmethod_113()
	{
		if (this.string_0 == "\\D+")
		{
			this.method_59();
		}
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x0000980C File Offset: 0x00007A0C
	public override void vmethod_26()
	{
		this.int_5 = 0;
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.method_59();
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00009344 File Offset: 0x00007544
	protected virtual void vmethod_114()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		if (this.bool_12)
		{
			this.method_55();
			return;
		}
		base.Update();
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00009835 File Offset: 0x00007A35
	private void method_92()
	{
		this.confirmMenu.method_47("This is a placeholder", "PreviewEnd = [\\-\\+]?\\d+(\\.\\d+)?", "video", new ConfirmationMenu.GDelegate6(this.method_49), null, null);
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x0000985F File Offset: 0x00007A5F
	public virtual void vmethod_115()
	{
		if (this.string_0 == "6 Fret Bass Guitar")
		{
			this.method_52();
		}
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x0007A3DC File Offset: 0x000785DC
	public virtual void vmethod_116()
	{
		this.int_5 = 1;
		this.allowMultiLanguage = false;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		if (this.int_4 == 7)
		{
			this.confirmMenu.method_54("streamer", "\n", ": <color=#FDB400FF>", new ConfirmationMenu.GDelegate6(this.method_108), null, null);
			return;
		}
		if (this.int_4 != 0)
		{
			string text = base.method_39();
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 139u)
			{
				if (num <= 191u)
				{
					if (num <= 35u)
					{
						if (num != 4294967150u)
						{
							if (num != 4294967149u)
							{
								goto IL_61A;
							}
							if (text == "%b")
							{
								this.method_101(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(text == "Sound Effects"))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = false;
							this.method_85(GClass12.smethod_40());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 1;
								return;
							}
							this.confirmMenu.method_47("<color=#FFFF04FF>", "Monika", null, null, null, null);
							this.method_85(this.setlistOptions);
							return;
						}
					}
					else if (num != 4294967217u)
					{
						if (num != 4294967168u)
						{
							goto IL_61A;
						}
						if (!(text == "Genre"))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (text == "")
						{
							this.method_97();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 4294967233u)
				{
					if (num != 4294967223u)
					{
						if (num != 4294967141u)
						{
							goto IL_61A;
						}
						if (text == "No")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_13("video_start_time");
							GClass12.string_3 = null;
							GClass12.bool_0 = true;
							this.setlistMenu.method_47(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "Guitar Coop"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[0];
							this.vmethod_67();
							this.vmethod_42();
							base.method_32();
							this.bool_12 = false;
							this.bool_13 = true;
							this.textObjects[1].text = GClass12.string_2;
							this.textObjects[0].text = GClass4.gclass4_0.method_15("{0}");
							this.textObjects[2].text = GClass4.gclass4_0.method_30("Song");
							this.textObjects[2].text = GClass4.gclass4_0.method_35("/songs.txt");
							CHPlayer.smethod_3();
							return;
						}
						if (GClass12.smethod_18(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_51("Unknown Genre", "Not match flags next {0} {1}", "6 Fret Guitar", new ConfirmationMenu.GDelegate6(this.method_82), null, null);
							return;
						}
						this.method_54();
						return;
					}
				}
				else if (num != 168u)
				{
					if (num != 8u)
					{
						goto IL_61A;
					}
					if (text == "<color=#FFA300>")
					{
						this.confirmMenu.method_45("%s%n%a%n%c", "Song Speed", "gem_size", new ConfirmationMenu.GDelegate6(this.method_102), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == "</color> ")
					{
						this.menuStrings = new string[0];
						this.vmethod_3();
						this.vmethod_42();
						base.method_36();
						this.bool_13 = true;
						this.bool_12 = true;
						this.textObjects[0].text = GClass12.string_2;
						this.textObjects[0].text = GClass4.gclass4_0.method_7("No Fail");
						this.textObjects[6].text = GClass4.gclass4_0.method_15("Hz");
						this.textObjects[5].text = GClass4.gclass4_0.method_15("beatscore");
						this.setlistMenu.method_49();
						this.setlistMenu.float_0 = 1343f;
						CHPlayer.smethod_12();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 4294967099u)
			{
				if (num <= 4u)
				{
					if (num != 4294967267u)
					{
						if (num != 4294967258u)
						{
							goto IL_61A;
						}
						if (text == "%")
						{
							this.confirmMenu.method_54(":", " ", "diff_bassghl", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(text == "diff_keys"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_61(this.setlistOptionsActive);
							return;
						}
						this.method_61(this.setlistOptions);
						return;
					}
				}
				else if (num != 99u)
				{
					if (num != 141u)
					{
						goto IL_61A;
					}
					if (text == "Quit")
					{
						this.method_73();
						return;
					}
					goto IL_61A;
				}
				else if (!(text == ""))
				{
					goto IL_61A;
				}
			}
			else if (num <= 122u)
			{
				if (num != 101u)
				{
					if (num != 4294967101u)
					{
						goto IL_61A;
					}
					if (text == "volume")
					{
						this.songSelect.method_89();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(text == "song"))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = true;
					this.method_98(GClass12.smethod_8());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 5;
						return;
					}
					this.confirmMenu.method_47("Date Added", "Artist", null, null, null, null);
					this.method_101(this.setlistOptions);
					return;
				}
			}
			else if (num != 174u)
			{
				if (num != 50u)
				{
					if (num != 4294967220u)
					{
						goto IL_61A;
					}
					if (text == "Genre")
					{
						this.setlistMenu.method_61(false);
						this.method_68(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (text == "Game Icons/")
					{
						this.confirmMenu.method_53("Are you sure you want to quit?", ".chart", "[SyncTrack]", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (text == "Rhythm Guitar")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_60();
			return;
			IL_61A:
			this.string_0 = base.method_39();
			this.method_59();
			return;
		}
		if (GClass12.smethod_7(base.method_39()))
		{
			this.setlistMenu.method_66();
			this.method_101(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_44("drums_1", "album", null, null, null, null);
		this.method_68(this.setlistOptions);
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x0007AA2C File Offset: 0x00078C2C
	private void method_93(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 0;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 0;
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
				this.menuStrings[1] = "Play Count";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 6;
		}
		this.vmethod_3();
		this.vmethod_25(0);
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x0007AAA4 File Offset: 0x00078CA4
	private void method_94()
	{
		bool flag = false;
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i++)
		{
			char c = inputString[i];
			if (c == '\u0001')
			{
				if (this.textObjects[1].text.Length > 0)
				{
					this.textObjects[0].text = this.textObjects[0].text.Substring(0, this.textObjects[1].text.Length - 0);
				}
			}
			else
			{
				if (c != 'h')
				{
					if ((int)c != -98)
					{
						if ((this.textObjects[1].text.Length == 0 && (int)c == -53) || this.textObjects[0].text.Length == 85)
						{
							goto IL_11E;
						}
						Text text = this.textObjects[1];
						text.text += c.ToString();
						this.textObjects[0].text = Regex.Replace(this.textObjects[1].text, "streamer", string.Empty);
						if (string.IsNullOrEmpty(this.textObjects[1].text))
						{
							this.textObjects[1].text = "Don't Scan Songs";
							goto IL_11E;
						}
						goto IL_11E;
					}
				}
				flag = false;
				IL_132:
				if ((Input.GetKeyDown((KeyCode)(-49)) || !Input.GetKeyDown(KeyCode.Space)) && !flag)
				{
					if (Input.GetKeyDown((KeyCode)(-74)))
					{
						this.bool_12 = false;
						this.method_98(this.setlistOptionsActive);
						this.setlistMenu.float_0 = 1803f;
						base.method_43(this.bool_13 ? "song_backgrounds" : "Play Count");
						CHPlayer.smethod_19();
					}
					return;
				}
				if (this.textObjects[1].text.Length == 0)
				{
					return;
				}
				string text2 = this.textObjects[0].text.Trim();
				if (this.bool_13)
				{
					GClass12.smethod_24(text2);
				}
				else
				{
					GClass12.string_2 = text2;
					if (GClass12.smethod_33(GClass12.string_2))
					{
						this.confirmMenu.method_45("", "{0:n0}", ")", new ConfirmationMenu.GDelegate6(this.method_63), null, null);
					}
					else
					{
						this.method_63();
					}
				}
				this.setlistMenu.method_57();
				this.bool_12 = true;
				this.method_61(this.setlistOptionsActive);
				base.method_43(this.bool_13 ? "player_count" : "");
				CHPlayer.smethod_26();
				return;
			}
			IL_11E:;
		}
		goto IL_132;
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x0000938E File Offset: 0x0000758E
	public override void vmethod_36()
	{
		if (this.string_0 == "Song Speed")
		{
			this.method_59();
		}
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x00009899 File Offset: 0x00007A99
	public virtual void vmethod_117()
	{
		if (this.string_0 == "stars")
		{
			this.method_52();
		}
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x0007AD08 File Offset: 0x00078F08
	public virtual void vmethod_118()
	{
		this.int_5 = 0;
		this.allowMultiLanguage = true;
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.int_4 == 1)
		{
			this.confirmMenu.method_52("[^\\u0020-\\u007E]", "Guitar - ", "no_fail", new ConfirmationMenu.GDelegate6(this.method_95), null, null);
			return;
		}
		if (this.int_4 != 6)
		{
			string string_ = base.String_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 71u)
			{
				if (num <= 71u)
				{
					if (num <= 59u)
					{
						if (num != 42u)
						{
							if (num != 4294967194u)
							{
								goto IL_61A;
							}
							if (string_ == "\r\n")
							{
								this.method_93(this.songOptions);
								return;
							}
							goto IL_61A;
						}
						else
						{
							if (!(string_ == "path1"))
							{
								goto IL_61A;
							}
							this.allowMultiLanguage = false;
							this.method_98(GClass12.smethod_35());
							if (this.menuStrings != null && this.menuStrings.Length != 0)
							{
								this.int_4 = 8;
								return;
							}
							this.confirmMenu.method_45("diff_rhythm", "Tilt", null, null, null, null);
							this.method_98(this.setlistOptions);
							return;
						}
					}
					else if (num != 4294967110u)
					{
						if (num != 4294967142u)
						{
							goto IL_61A;
						}
						if (!(string_ == ""))
						{
							goto IL_61A;
						}
					}
					else
					{
						if (string_ == "song_display")
						{
							this.method_84();
							return;
						}
						goto IL_61A;
					}
				}
				else if (num <= 4294967179u)
				{
					if (num != 4294967281u)
					{
						if (num != 54u)
						{
							goto IL_61A;
						}
						if (string_ == "%")
						{
							GClass12.string_2 = GClass4.gclass4_0.method_38("");
							GClass12.string_3 = null;
							GClass12.bool_0 = false;
							this.setlistMenu.method_47(SongDirectory.songEntries[this.songSelect.Int32_0]);
							this.vmethod_15();
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "Song Options"))
						{
							goto IL_61A;
						}
						if (GClass12.string_2 == null)
						{
							this.menuStrings = new string[1];
							this.vmethod_3();
							this.vmethod_42();
							base.method_1();
							this.bool_12 = false;
							this.bool_13 = true;
							this.textObjects[0].text = GClass12.string_2;
							this.textObjects[0].text = GClass4.gclass4_0.method_36("audio");
							this.textObjects[7].text = GClass4.gclass4_0.method_21("No Videos!");
							this.textObjects[8].text = GClass4.gclass4_0.method_17("Player");
							CHPlayer.smethod_30();
							return;
						}
						if (GClass12.smethod_0(GClass12.string_2) && GClass12.string_3 != null)
						{
							this.confirmMenu.method_45("All Strums", "song_length", "star_animation", new ConfirmationMenu.GDelegate6(this.method_54), null, null);
							return;
						}
						this.method_106();
						return;
					}
				}
				else if (num != 4294967203u)
				{
					if (num != 31u)
					{
						goto IL_61A;
					}
					if (string_ == "bass")
					{
						this.confirmMenu.method_46("All Opens", "scores.bin", "Continue", new ConfirmationMenu.GDelegate6(this.method_58), null, null);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "gem_size")
					{
						this.menuStrings = new string[1];
						this.vmethod_67();
						this.vmethod_42();
						base.method_32();
						this.bool_13 = true;
						this.bool_12 = true;
						this.textObjects[1].text = GClass12.string_2;
						this.textObjects[0].text = GClass4.gclass4_0.method_21("Menu Music");
						this.textObjects[0].text = GClass4.gclass4_0.method_13("No scores saved for this song on");
						this.textObjects[3].text = GClass4.gclass4_0.method_15("graphics_devid");
						this.setlistMenu.method_64();
						this.setlistMenu.float_0 = 765f;
						CHPlayer.smethod_12();
						return;
					}
					goto IL_61A;
				}
			}
			else if (num <= 4294967222u)
			{
				if (num <= 87u)
				{
					if (num != 4294967131u)
					{
						if (num != 4294967203u)
						{
							goto IL_61A;
						}
						if (string_ == "volume")
						{
							this.confirmMenu.method_50("name", "Song Speed", "part", null, null, null);
							return;
						}
						goto IL_61A;
					}
					else
					{
						if (!(string_ == "audio"))
						{
							goto IL_61A;
						}
						if (this.setlistMenu.isActiveAndEnabled)
						{
							this.method_48(this.setlistOptionsActive);
							return;
						}
						this.method_48(this.setlistOptions);
						return;
					}
				}
				else if (num != 4294967114u)
				{
					if (num != 113u)
					{
						goto IL_61A;
					}
					if (string_ == "game")
					{
						this.method_72();
						return;
					}
					goto IL_61A;
				}
				else if (!(string_ == "bass"))
				{
					goto IL_61A;
				}
			}
			else if (num <= 82u)
			{
				if (num != 4294967130u)
				{
					if (num != 4294967184u)
					{
						goto IL_61A;
					}
					if (string_ == "Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
					{
						this.songSelect.method_52();
						this.vmethod_15();
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (!(string_ == ""))
					{
						goto IL_61A;
					}
					this.allowMultiLanguage = false;
					this.method_71(GClass12.smethod_5());
					if (this.menuStrings != null && this.menuStrings.Length != 0)
					{
						this.int_4 = 4;
						return;
					}
					this.confirmMenu.method_44("", "year", null, null, null, null);
					this.method_101(this.setlistOptions);
					return;
				}
			}
			else if (num != 114u)
			{
				if (num != 25u)
				{
					if (num != 111u)
					{
						goto IL_61A;
					}
					if (string_ == "hi")
					{
						this.setlistMenu.method_53(false);
						this.method_61(this.setlistOptions);
						return;
					}
					goto IL_61A;
				}
				else
				{
					if (string_ == "volume")
					{
						this.confirmMenu.method_44("Discord: error {0}: {1}", "Cancel", "Unknown Album", null, null, null);
						return;
					}
					goto IL_61A;
				}
			}
			else
			{
				if (string_ == "")
				{
					this.gclass5_0 = GlobalVariables.instance.songSpeed;
					goto IL_61A;
				}
				goto IL_61A;
			}
			this.method_45();
			return;
			IL_61A:
			this.string_0 = base.String_0;
			this.method_59();
			return;
		}
		if (GClass12.smethod_41(base.method_39()))
		{
			this.setlistMenu.method_66();
			this.method_93(this.setlistOptionsActive);
			return;
		}
		this.confirmMenu.method_45("custom", "\\d+ = B \\d+", null, null, null, null);
		this.method_61(this.setlistOptions);
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x000098B3 File Offset: 0x00007AB3
	private void method_95()
	{
		GClass12.smethod_4(base.method_39());
		this.method_48(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x000098D3 File Offset: 0x00007AD3
	public virtual void vmethod_119()
	{
		if (this.string_0 == "{0:N0} FPS")
		{
			this.method_59();
		}
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x000098ED File Offset: 0x00007AED
	private void method_96()
	{
		GClass12.smethod_15(base.method_39());
		this.method_61(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x0007606C File Offset: 0x0007426C
	protected virtual void vmethod_120()
	{
		string artistName = SongDirectory.songEntries[this.songSelect.Int32_0].artistName;
		base.OnEnable();
		this.method_68(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x0007B358 File Offset: 0x00079558
	private void method_97()
	{
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		int index;
		do
		{
			index = UnityEngine.Random.Range(1, SongDirectory.songEntries.Count);
		}
		while (SongDirectory.songEntries[index].isHeader);
		this.songSelect.vmethod_23(index);
		this.vmethod_43();
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x0007B3B4 File Offset: 0x000795B4
	private void method_98(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 0;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 1;
			if (Application.platform == RuntimePlatform.OSXPlayer)
			{
				this.menuStrings[1] = "Messy Solo...";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 5;
		}
		this.vmethod_3();
		this.vmethod_25(1);
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x0007B42C File Offset: 0x0007962C
	private void method_99()
	{
		int i = this.songSelect.Int32_0;
		int num = this.songSelect.Int32_0;
		UnityEngine.Random.InitState((int)Time.time + DateTime.Now.Millisecond);
		while (i >= 0)
		{
			i -= 0;
			if (SongDirectory.songEntries[i].isHeader)
			{
				IL_65:
				while (num < SongDirectory.songEntries.Count && !SongDirectory.songEntries[num].isHeader)
				{
					num += 0;
				}
				this.songSelect.vmethod_23(UnityEngine.Random.Range(i + 1, num));
				this.vmethod_4();
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x0000990D File Offset: 0x00007B0D
	public virtual void vmethod_121()
	{
		if (this.string_0 == ")")
		{
			this.method_62();
		}
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x0007B4C8 File Offset: 0x000796C8
	private void method_100()
	{
		bool flag = false;
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\0')
			{
				if (this.textObjects[1].text.Length > 0)
				{
					this.textObjects[1].text = this.textObjects[0].text.Substring(0, this.textObjects[1].text.Length - 1);
				}
			}
			else
			{
				if ((int)c != -87)
				{
					if ((int)c != -15)
					{
						if ((this.textObjects[1].text.Length == 0 && (int)c == -27) || this.textObjects[1].text.Length == -61)
						{
							goto IL_11E;
						}
						Text text = this.textObjects[1];
						text.text += c.ToString();
						this.textObjects[1].text = Regex.Replace(this.textObjects[1].text, "volume", string.Empty);
						if (string.IsNullOrEmpty(this.textObjects[0].text))
						{
							this.textObjects[0].text = "Yes";
							goto IL_11E;
						}
						goto IL_11E;
					}
				}
				flag = false;
				IL_132:
				if ((Input.GetKeyDown((KeyCode)75) || !Input.GetKeyDown((KeyCode)(-128))) && !flag)
				{
					if (Input.GetKeyDown((KeyCode)(-125)))
					{
						this.bool_12 = true;
						this.method_101(this.setlistOptionsActive);
						this.setlistMenu.float_0 = 358f;
						base.method_43(this.bool_13 ? "device" : "Player2 = \\w+");
						CHPlayer.smethod_5();
					}
					return;
				}
				if (this.textObjects[0].text.Length == 0)
				{
					return;
				}
				string text2 = this.textObjects[0].text.Trim();
				if (this.bool_13)
				{
					GClass12.smethod_36(text2);
				}
				else
				{
					GClass12.string_2 = text2;
					if (GClass12.smethod_13(GClass12.string_2))
					{
						this.confirmMenu.method_47("Prefabs/Gameplay/Notes/Sustain", "no_fail", "</color>", new ConfirmationMenu.GDelegate6(this.method_63), null, null);
					}
					else
					{
						this.method_54();
					}
				}
				this.setlistMenu.method_57();
				this.bool_12 = true;
				this.method_61(this.setlistOptionsActive);
				base.method_0(this.bool_13 ? "Rhythm Guitar" : "Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
				CHPlayer.smethod_11();
				return;
			}
			IL_11E:;
		}
		goto IL_132;
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x0007B72C File Offset: 0x0007992C
	private void method_101(string[] string_1)
	{
		this.menuStrings = string_1;
		if (string_1 == this.mainOptions || string_1 == this.mainOptionsPractice)
		{
			this.int_4 = 1;
		}
		if (string_1 == this.songOptions)
		{
			this.int_4 = 0;
			if (Application.platform == RuntimePlatform.OSXPlayer)
			{
				this.menuStrings[0] = "Press ENTER to search";
			}
		}
		if (string_1 == this.setlistOptions || string_1 == this.setlistOptionsActive)
		{
			this.int_4 = 5;
		}
		this.vmethod_3();
		this.vmethod_23(0);
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00009927 File Offset: 0x00007B27
	private void method_102()
	{
		this.confirmMenu.method_53("%l", "volume", "UPDATING METADATA...", new ConfirmationMenu.GDelegate6(this.method_49), null, null);
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x0007B7A4 File Offset: 0x000799A4
	private void method_103()
	{
		bool flag = false;
		foreach (char c in Input.inputString)
		{
			if (c == '\b')
			{
				if (this.textObjects[0].text.Length > 0)
				{
					this.textObjects[0].text = this.textObjects[0].text.Substring(0, this.textObjects[0].text.Length - 1);
				}
			}
			else
			{
				if (c != '\n')
				{
					if (c != '\r')
					{
						if ((this.textObjects[0].text.Length == 0 && c == ' ') || this.textObjects[0].text.Length == 15)
						{
							goto IL_11E;
						}
						Text text = this.textObjects[0];
						text.text += c.ToString();
						this.textObjects[0].text = Regex.Replace(this.textObjects[0].text, "[^\\u0020-\\u007E]", string.Empty);
						if (string.IsNullOrEmpty(this.textObjects[0].text))
						{
							this.textObjects[0].text = "";
							goto IL_11E;
						}
						goto IL_11E;
					}
				}
				flag = true;
				IL_132:
				if (!Input.GetKeyDown(KeyCode.Return) && !Input.GetKeyDown(KeyCode.KeypadEnter) && !flag)
				{
					if (Input.GetKeyDown(KeyCode.Escape))
					{
						this.bool_12 = false;
						this.method_68(this.setlistOptionsActive);
						this.setlistMenu.float_0 = 0f;
						base.method_0(this.bool_13 ? "Rename Setlist" : "Save Playlist");
						CHPlayer.smethod_23();
					}
					return;
				}
				if (this.textObjects[0].text.Length == 0)
				{
					return;
				}
				string text2 = this.textObjects[0].text.Trim();
				if (this.bool_13)
				{
					GClass12.smethod_32(text2);
				}
				else
				{
					GClass12.string_2 = text2;
					if (GClass12.smethod_0(GClass12.string_2))
					{
						this.confirmMenu.method_44("A setlist with that name already exists", "Overwrite", "Cancel", new ConfirmationMenu.GDelegate6(this.method_54), null, null);
					}
					else
					{
						this.method_54();
					}
				}
				this.setlistMenu.method_57();
				this.bool_12 = false;
				this.method_68(this.setlistOptionsActive);
				base.method_0(this.bool_13 ? "Rename Setlist" : "Save Playlist");
				CHPlayer.smethod_23();
				return;
			}
			IL_11E:;
		}
		goto IL_132;
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00009951 File Offset: 0x00007B51
	private void method_104()
	{
		this.confirmMenu.method_48("charter", "Continue", "Expert", new ConfirmationMenu.GDelegate6(this.method_79), null, null);
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x0007BA08 File Offset: 0x00079C08
	private void method_105()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		bool flag = false;
		if (BassAudioManager.instance.isSongPlaying)
		{
			BassAudioManager.instance.method_29();
		}
		try
		{
			Directory.Delete(folderPath, true);
		}
		catch
		{
			flag = false;
		}
		SongDirectory.songEntries.RemoveAt(this.songSelect.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.songSelect.vmethod_67();
		if (SongDirectory.songEntries.Count == 0)
		{
			SongDirectory.songEntries.Clear();
			this.songSelect.vmethod_38();
		}
		else if (this.songSelect.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.songSelect.vmethod_23(1);
		}
		else
		{
			this.songSelect.vmethod_23(this.songSelect.Int32_0);
		}
		this.songSelect.method_77();
		base.gameObject.SetActive(false);
		if (flag)
		{
			this.confirmMenu.method_46("Profile file version is different!", "flames", null, null, null, null);
		}
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x0007BB24 File Offset: 0x00079D24
	private void method_106()
	{
		if (GClass12.smethod_20(GClass12.string_2))
		{
			this.confirmMenu.method_50("Custom Content", "Bass Guitar", null, null, null, null);
			return;
		}
		this.confirmMenu.method_45("game", "Continue", null, null, null, null);
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x0007BB70 File Offset: 0x00079D70
	public override void vmethod_68()
	{
		if (this.gclass5_0 != null)
		{
			this.gclass5_0.method_17();
			this.method_59();
			return;
		}
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 0;
		}
		if (this.int_6[this.int_5] == 23)
		{
			this.int_5++;
		}
		else
		{
			this.int_5 = 0;
		}
		if (this.int_5 == 5)
		{
			this.method_68(this.extraOptions);
		}
		if (this.int_5 == 10)
		{
			this.method_68(this.extraOptions2);
		}
		if (this.int_5 == this.int_6.Length)
		{
			this.method_68(this.extraOptions3);
		}
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0007BC20 File Offset: 0x00079E20
	public virtual void vmethod_122()
	{
		if (this.gclass5_0 != null)
		{
			this.gclass5_0.method_17();
			this.method_52();
			return;
		}
		if (this.int_5 == this.int_6.Length)
		{
			this.int_5 = 1;
		}
		if (this.int_6[this.int_5] == 60)
		{
			this.int_5 += 0;
		}
		else
		{
			this.int_5 = 1;
		}
		if (this.int_5 == 0)
		{
			this.method_93(this.extraOptions);
		}
		if (this.int_5 == 123)
		{
			this.method_71(this.extraOptions2);
		}
		if (this.int_5 == this.int_6.Length)
		{
			this.method_98(this.extraOptions3);
		}
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x0000997B File Offset: 0x00007B7B
	protected override void Update()
	{
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		if (this.bool_12)
		{
			this.method_103();
			return;
		}
		base.Update();
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x0007BCD0 File Offset: 0x00079ED0
	private void method_107()
	{
		string folderPath = SongDirectory.songEntries[this.songSelect.Int32_0].folderPath;
		if (Application.platform == RuntimePlatform.OSXPlayer)
		{
			Process.Start("open", "\"" + folderPath + "\"");
		}
		else
		{
			Application.OpenURL(folderPath);
		}
		this.vmethod_43();
		this.vmethod_43();
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x0007BD30 File Offset: 0x00079F30
	protected virtual void vmethod_123()
	{
		string artistName = SongDirectory.songEntries[this.songSelect.Int32_0].artistName;
		base.vmethod_9();
		this.method_61(GlobalVariables.instance.isPracticeEnabled ? this.mainOptionsPractice : this.mainOptions);
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x000099A0 File Offset: 0x00007BA0
	private void method_108()
	{
		GClass12.smethod_1(base.String_0);
		this.method_68(this.setlistOptions);
		GClass12.string_2 = null;
	}

	// Token: 0x0400024D RID: 589
	[SerializeField]
	private SongSelect songSelect;

	// Token: 0x0400024E RID: 590
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x0400024F RID: 591
	[SerializeField]
	private SetlistMenu setlistMenu;

	// Token: 0x04000250 RID: 592
	[SerializeField]
	private string[] mainOptions;

	// Token: 0x04000251 RID: 593
	[SerializeField]
	private string[] mainOptionsPractice;

	// Token: 0x04000252 RID: 594
	[SerializeField]
	private string[] dokiOptions;

	// Token: 0x04000253 RID: 595
	[SerializeField]
	private string[] dokiOptionsPractice;

	// Token: 0x04000254 RID: 596
	[SerializeField]
	private string[] setlistOptions;

	// Token: 0x04000255 RID: 597
	[SerializeField]
	private string[] setlistOptionsActive;

	// Token: 0x04000256 RID: 598
	[SerializeField]
	private string[] songOptions;

	// Token: 0x04000257 RID: 599
	[SerializeField]
	private string[] extraOptions;

	// Token: 0x04000258 RID: 600
	[SerializeField]
	private string[] extraOptions2;

	// Token: 0x04000259 RID: 601
	[SerializeField]
	private string[] extraOptions3;

	// Token: 0x0400025A RID: 602
	private int int_4;

	// Token: 0x0400025B RID: 603
	private int int_5;

	// Token: 0x0400025C RID: 604
	private bool bool_12;

	// Token: 0x0400025D RID: 605
	private bool bool_13;

	// Token: 0x0400025E RID: 606
	private int[] int_6 = new int[]
	{
		3,
		4,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3,
		3
	};
}
