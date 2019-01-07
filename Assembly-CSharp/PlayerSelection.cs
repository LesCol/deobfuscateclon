using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000038 RID: 56
public class PlayerSelection : BaseMenu
{
	// Token: 0x06000940 RID: 2368 RVA: 0x0004E564 File Offset: 0x0004C764
	public override void vmethod_39()
	{
		switch (this.enum1_0)
		{
		case PlayerSelection.Enum1.ChoosingInstrument:
			this.method_80();
			return;
		case PlayerSelection.Enum1.ChoosingDifficulty:
			this.method_79();
			return;
		case PlayerSelection.Enum1.ChoosingModifier:
			this.method_56();
			return;
		default:
			return;
		}
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
	protected virtual void vmethod_81()
	{
		base.method_30(GlobalVariables.instance.playerList[this.playerIndex]);
		if (this.gclass9_0.gclass10_0 == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.songEntry_0 = GlobalVariables.instance.currentSongEntry;
		this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.method_11();
		this.method_78();
		this.method_84();
		base.OnEnable();
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x0004E620 File Offset: 0x0004C820
	private void method_44()
	{
		this.header.text = GClass4.gclass4_0.method_15("song");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingDifficulty;
		this.method_103();
		this.method_49();
		GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)Enum.Parse(typeof(GStruct2.GEnum11), this.gclass9_0.gclass10_0.genum18_0.ToString());
		if (this.songEntry_0.charts.method_36(genum11_, GStruct2.GEnum12.Expert))
		{
			this.method_54("Disconnected from server.");
		}
		if (this.songEntry_0.charts.method_19(genum11_, (GStruct2.GEnum12)4))
		{
			this.method_54("</color> ");
		}
		if (this.songEntry_0.charts.method_36(genum11_, GStruct2.GEnum12.Medium))
		{
			this.method_81("Mirror Mode");
		}
		if (this.songEntry_0.charts.method_7(genum11_, GStruct2.GEnum12.Medium))
		{
			this.method_81("year");
		}
		this.vmethod_67();
		base.method_43(this.gclass9_0.gclass10_0.genum17_0.ToString());
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x0004E730 File Offset: 0x0004C930
	protected override void OnEnable()
	{
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		if (this.gclass9_0.gclass10_0 == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.songEntry_0 = GlobalVariables.instance.currentSongEntry;
		this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
		this.method_60();
		this.method_73();
		base.OnEnable();
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x0004E7B0 File Offset: 0x0004C9B0
	protected virtual void vmethod_82()
	{
		base.SetControllingPlayer(GlobalVariables.instance.playerList[this.playerIndex]);
		if (this.gclass9_0.gclass10_0 == null)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.songEntry_0 = GlobalVariables.instance.currentSongEntry;
		this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.method_11();
		this.method_78();
		this.method_73();
		base.vmethod_9();
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00004EA1 File Offset: 0x000030A1
	private void method_45()
	{
		this.header.text = GClass4.gclass4_0.method_11("Song Offset");
		this.enum1_0 = (PlayerSelection.Enum1)6;
		this.method_95();
		this.method_98();
		this.vmethod_3();
		base.method_23();
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x0004E830 File Offset: 0x0004CA30
	private void method_46()
	{
		this.header.text = GClass4.gclass4_0.method_13("Difficulty");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingDifficulty;
		this.method_73();
		this.method_96();
		GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)Enum.Parse(typeof(GStruct2.GEnum11), this.gclass9_0.gclass10_0.genum18_0.ToString());
		if (this.songEntry_0.charts.method_36(genum11_, GStruct2.GEnum12.Expert))
		{
			this.method_83("Expert");
		}
		if (this.songEntry_0.charts.method_36(genum11_, GStruct2.GEnum12.Hard))
		{
			this.method_83("Hard");
		}
		if (this.songEntry_0.charts.method_36(genum11_, GStruct2.GEnum12.Medium))
		{
			this.method_83("Medium");
		}
		if (this.songEntry_0.charts.method_36(genum11_, GStruct2.GEnum12.Easy))
		{
			this.method_83("Easy");
		}
		this.vmethod_67();
		base.method_0(this.gclass9_0.gclass10_0.genum17_0.ToString());
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00004EDC File Offset: 0x000030DC
	private void method_47()
	{
		this.header.text = GClass4.gclass4_0.method_5("pause_on_focus_lost");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingModifier;
		this.method_103();
		this.method_98();
		this.vmethod_3();
		base.method_23();
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00004F17 File Offset: 0x00003117
	protected override void vmethod_50()
	{
		base.vmethod_50();
		if (this.enum1_0 == PlayerSelection.Enum1.ChoosingModifier)
		{
			this.method_53();
		}
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x0004E940 File Offset: 0x0004CB40
	public override void vmethod_43()
	{
		switch (this.enum1_0)
		{
		case PlayerSelection.Enum1.ChoosingInstrument:
			this.playerSelectionCanvas.method_4();
			return;
		case PlayerSelection.Enum1.ChoosingDifficulty:
			this.method_60();
			return;
		case PlayerSelection.Enum1.ChoosingModifier:
			this.method_46();
			return;
		case PlayerSelection.Enum1.Ready:
			if (this.gclass9_0.gclass10_0.genum18_0 == Song.Instrument.None)
			{
				this.method_60();
				return;
			}
			this.method_72();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x0004E9A8 File Offset: 0x0004CBA8
	private void method_48()
	{
		this.header.text = GClass4.gclass4_0.method_42("Main Menu");
		this.enum1_0 = (PlayerSelection.Enum1)4;
		this.method_98();
		this.method_54("game");
		this.method_54("Camera");
		this.method_81("Unknown Charter");
		this.method_51("Menu Backgrounds");
		this.method_81("sounds");
		this.method_81("No NetworkStartPositions exist!");
		this.method_51("Lead Guitar");
		this.method_51("song");
		this.method_81("6 Fret Lead Guitar");
		this.vmethod_67();
		base.method_0("Playlist");
		this.method_101();
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00004F2E File Offset: 0x0000312E
	private void method_49()
	{
		this.menuStrings = new string[113];
		this.int_4 = 1;
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x0004EA58 File Offset: 0x0004CC58
	protected virtual void vmethod_83()
	{
		if (!this.gclass9_0.method_18())
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.genum7_0 != this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0)
		{
			this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
			this.method_88();
			this.vmethod_23(1);
		}
		base.Update();
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x0004EACC File Offset: 0x0004CCCC
	private void method_50()
	{
		string string_ = base.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 4294967194u)
		{
			if (num <= 199u)
			{
				if (num != 4294967256u)
				{
					if (num == 109u)
					{
						if (string_ == "streamer")
						{
							this.gclass9_0.gclass10_0.genum18_0 = (Song.Instrument)14;
						}
					}
				}
				else if (string_ == "Messy Solo...")
				{
					this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Drums;
				}
			}
			else if (num != 4294967252u)
			{
				if (num == 4294967168u)
				{
					if (string_ == "{0:N0} FPS")
					{
						this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Guitar;
					}
				}
			}
			else if (string_ == "Rename Setlist")
			{
				this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Guitar;
			}
		}
		else if (num <= 5u)
		{
			if (num != 4u)
			{
				if (num == 119u)
				{
					if (string_ == "")
					{
						this.gclass9_0.gclass10_0.genum18_0 = (Song.Instrument)103;
						this.method_45();
						return;
					}
				}
			}
			else if (string_ == "Yes")
			{
				this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Guitar;
			}
		}
		else if (num != 88u)
		{
			if (num == 197u)
			{
				if (string_ == "Cancel")
				{
					this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.GHLGuitar;
				}
			}
		}
		else if (string_ == "PreviewStart = [\\-\\+]?\\d+(\\.\\d+)?")
		{
			this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Guitar;
		}
		this.method_44();
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00004F44 File Offset: 0x00003144
	private void method_51(string string_1)
	{
		this.menuStrings[this.int_4] = string_1;
		this.int_4++;
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00004F62 File Offset: 0x00003162
	protected virtual void vmethod_84()
	{
		base.vmethod_50();
		if (this.enum1_0 == PlayerSelection.Enum1.Ready)
		{
			this.method_66();
		}
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00004F79 File Offset: 0x00003179
	private void method_52()
	{
		this.header.text = GClass4.gclass4_0.method_48("highway_sp");
		this.enum1_0 = PlayerSelection.Enum1.Ready;
		this.method_69();
		this.method_49();
		this.vmethod_3();
		base.method_31();
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x0004EC7C File Offset: 0x0004CE7C
	private void method_53()
	{
		for (int i = 0; i < this.int_3; i++)
		{
			Image image = this.modifiersChosen[i];
			string text = this.menuStrings[this.int_0 + i];
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 969047638u)
			{
				if (num <= 519672717u)
				{
					if (num != 197800596u)
					{
						if (num == 519672717u)
						{
							if (text == "Mirror Mode")
							{
								image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.MirrorMode);
							}
						}
					}
					else if (text == "Ready")
					{
						image.enabled = false;
					}
				}
				else if (num != 810547195u)
				{
					if (num == 969047638u)
					{
						if (text == "All Taps")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.AllTaps);
						}
					}
				}
				else if (text == "None")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.None);
				}
			}
			else if (num <= 2943505970u)
			{
				if (num != 2280494478u)
				{
					if (num == 2943505970u)
					{
						if (text == "All Strums")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.AllStrums);
						}
					}
				}
				else if (text == "HOPO's to Taps")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.HOPOsToTaps);
				}
			}
			else if (num != 3568313485u)
			{
				if (num != 3721017608u)
				{
					if (num == 3729395942u)
					{
						if (text == "All HOPO's")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == "Note Shuffle")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.Shuffle);
				}
			}
			else if (text == "All Opens")
			{
				image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.AllOpens);
			}
		}
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x0004EEA4 File Offset: 0x0004D0A4
	public virtual void vmethod_85()
	{
		this.int_2 = 0;
		this.int_0 = 0;
		this.int_1 = 0;
		this.int_3 = this.int_4;
		if (this.int_4 > 7)
		{
			this.int_3 = 2;
			this.int_2 = this.int_4 - this.int_3;
			return;
		}
		for (int i = this.int_4; i < this.textObjects.Length; i++)
		{
			this.textObjects[i].text = "Lyrics";
		}
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x0004EF20 File Offset: 0x0004D120
	public virtual void vmethod_86()
	{
		switch (this.enum1_0)
		{
		case PlayerSelection.Enum1.ChoosingInstrument:
			this.playerSelectionCanvas.method_4();
			return;
		case PlayerSelection.Enum1.ChoosingDifficulty:
			this.method_55();
			return;
		case PlayerSelection.Enum1.ChoosingModifier:
			this.method_86();
			return;
		case PlayerSelection.Enum1.Ready:
			if (this.gclass9_0.gclass10_0.genum18_0 == (Song.Instrument)115)
			{
				this.method_62();
				return;
			}
			this.method_77();
			return;
		default:
			return;
		}
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00004FB4 File Offset: 0x000031B4
	protected virtual void vmethod_87()
	{
		base.vmethod_30();
		if (this.enum1_0 == PlayerSelection.Enum1.ChoosingDifficulty)
		{
			this.method_99();
		}
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00004FCB File Offset: 0x000031CB
	private void method_54(string string_1)
	{
		this.menuStrings[this.int_4] = string_1;
		this.int_4 += 0;
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x0004EF88 File Offset: 0x0004D188
	private void method_55()
	{
		this.header.text = GClass4.gclass4_0.method_13("Don't Scan Songs");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingDifficulty;
		this.method_98();
		GClass10.GEnum7 genum = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
		if (genum != GClass10.GEnum7.Guitar)
		{
			if (genum == GClass10.GEnum7.Guitar)
			{
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GHLBass))
				{
					this.method_54(")");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.GuitarCoop))
				{
					this.method_83("song");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Guitar))
				{
					this.method_83("video");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Bass))
				{
					this.method_54("Background Image");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Drums))
				{
					this.method_54("song_preview");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.GuitarCoop))
				{
					this.method_81("Note Shuffle");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.GHLGuitar))
				{
					this.method_51("GHLive Bass - ");
				}
			}
		}
		else
		{
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Guitar))
			{
				this.method_51("volume");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Bass))
			{
				this.method_51("GuitarStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Keys))
			{
				this.method_51("song");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Guitar))
			{
				this.method_51("Lead Guitar");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Drums))
			{
				this.method_54("game_version");
			}
		}
		if (this.int_4 == 0)
		{
			this.method_83("video");
		}
		this.vmethod_67();
		switch (this.gclass9_0.gclass10_0.genum18_0)
		{
		case Song.Instrument.Guitar:
			base.method_0("Bass Guitar");
			return;
		case Song.Instrument.GuitarCoop:
			base.method_43("charter");
			return;
		case Song.Instrument.Bass:
			base.method_43("");
			return;
		case Song.Instrument.Keys:
			base.method_43("Artist");
			return;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
			break;
		case Song.Instrument.GHLGuitar:
			base.method_43("menu_background");
			return;
		case Song.Instrument.GHLBass:
			base.method_0(" + ");
			return;
		case Song.Instrument.None:
			base.method_0("master_volume");
			break;
		case Song.Instrument.Rhythm:
			base.method_43("song_display");
			return;
		default:
			return;
		}
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x0004F210 File Offset: 0x0004D410
	private void method_56()
	{
		string string_ = base.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 969047638u)
		{
			if (num <= 519672717u)
			{
				if (num != 197800596u)
				{
					if (num == 519672717u)
					{
						if (string_ == "Mirror Mode")
						{
							this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.MirrorMode);
						}
					}
				}
				else if (string_ == "Ready")
				{
					this.method_100();
					return;
				}
			}
			else if (num != 810547195u)
			{
				if (num == 969047638u)
				{
					if (string_ == "All Taps")
					{
						this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllTaps);
					}
				}
			}
			else if (string_ == "None")
			{
				this.gclass9_0.gclass10_0.genum6_0 = GClass6.GEnum6.None;
			}
		}
		else if (num <= 2943505970u)
		{
			if (num != 2280494478u)
			{
				if (num == 2943505970u)
				{
					if (string_ == "All Strums")
					{
						this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllStrums);
					}
				}
			}
			else if (string_ == "HOPO's to Taps")
			{
				this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.HOPOsToTaps);
			}
		}
		else if (num != 3568313485u)
		{
			if (num != 3721017608u)
			{
				if (num == 3729395942u)
				{
					if (string_ == "All HOPO's")
					{
						this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllHOPOs);
					}
				}
			}
			else if (string_ == "Note Shuffle")
			{
				this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.Shuffle);
			}
		}
		else if (string_ == "All Opens")
		{
			this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllOpens);
		}
		this.method_53();
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00004FE9 File Offset: 0x000031E9
	protected virtual void vmethod_88()
	{
		base.vmethod_50();
		if (this.enum1_0 == (PlayerSelection.Enum1)5)
		{
			this.method_99();
		}
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x0004F3DC File Offset: 0x0004D5DC
	private void method_57()
	{
		for (int i = 0; i < this.modifiersChosen.Length; i += 0)
		{
			this.modifiersChosen[i].enabled = true;
		}
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x0004F40C File Offset: 0x0004D60C
	private void method_58()
	{
		string string_ = base.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 4294967171u)
		{
			if (num <= 14u)
			{
				if (num != 4294967225u)
				{
					if (num == 154u)
					{
						if (string_ == "")
						{
							this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle);
						}
					}
				}
				else if (string_ == "Continue")
				{
					this.method_45();
					return;
				}
			}
			else if (num != 4294967192u)
			{
				if (num == 4294967206u)
				{
					if (string_ == "Language")
					{
						this.gclass9_0.gclass10_0.method_9((GClass6.GEnum6)0);
					}
				}
			}
			else if (string_ == "Create Profile")
			{
				this.gclass9_0.gclass10_0.genum6_0 = (GClass6.GEnum6)0;
			}
		}
		else if (num <= 15u)
		{
			if (num != 184u)
			{
				if (num == 181u)
				{
					if (string_ == "volume")
					{
						this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllStrums);
					}
				}
			}
			else if (string_ == "0%")
			{
				this.gclass9_0.gclass10_0.method_1(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode));
			}
		}
		else if (num != 4294967192u)
		{
			if (num != 4294967244u)
			{
				if (num == 99u)
				{
					if (string_ == "Guitar Coop")
					{
						this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.None);
					}
				}
			}
			else if (string_ == "Ready")
			{
				this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.Shuffle);
			}
		}
		else if (string_ == "has_bots")
		{
			this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps);
		}
		this.method_66();
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00005000 File Offset: 0x00003200
	public bool method_59()
	{
		return this.enum1_0 == PlayerSelection.Enum1.ChoosingInstrument;
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
	public override void vmethod_67()
	{
		this.int_2 = 0;
		this.int_0 = 0;
		this.int_1 = 0;
		this.int_3 = this.int_4;
		if (this.int_4 > 6)
		{
			this.int_3 = 6;
			this.int_2 = this.int_4 - this.int_3;
			return;
		}
		for (int i = this.int_4; i < this.textObjects.Length; i++)
		{
			this.textObjects[i].text = "";
		}
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x0004F654 File Offset: 0x0004D854
	public virtual void vmethod_89()
	{
		this.int_2 = 0;
		this.int_0 = 1;
		this.int_1 = 0;
		this.int_3 = this.int_4;
		if (this.int_4 > 1)
		{
			this.int_3 = 0;
			this.int_2 = this.int_4 - this.int_3;
			return;
		}
		for (int i = this.int_4; i < this.textObjects.Length; i++)
		{
			this.textObjects[i].text = "song";
		}
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x0004F6D0 File Offset: 0x0004D8D0
	private void method_60()
	{
		this.header.text = GClass4.gclass4_0.method_13("Instrument");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingInstrument;
		this.method_96();
		GClass10.GEnum7 genum = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
		if (genum != GClass10.GEnum7.Guitar)
		{
			if (genum == GClass10.GEnum7.GHLGuitar)
			{
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GHLGuitar))
				{
					this.method_83("6 Fret Lead Guitar");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GHLBass))
				{
					this.method_83("6 Fret Bass Guitar");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Guitar))
				{
					this.method_83("Lead Guitar");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
				{
					this.method_83("Bass Guitar");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Rhythm))
				{
					this.method_83("Rhythm Guitar");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GuitarCoop))
				{
					this.method_83("Guitar Coop");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Keys))
				{
					this.method_83("Keys");
				}
			}
		}
		else
		{
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Guitar))
			{
				this.method_83("Lead Guitar");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
			{
				this.method_83("Bass Guitar");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Rhythm))
			{
				this.method_83("Rhythm Guitar");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GuitarCoop))
			{
				this.method_83("Guitar Coop");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Keys))
			{
				this.method_83("Keys");
			}
		}
		if (this.int_4 == 0)
		{
			this.method_83("No Part");
		}
		this.vmethod_67();
		switch (this.gclass9_0.gclass10_0.genum18_0)
		{
		case Song.Instrument.Guitar:
			base.method_0("Lead Guitar");
			return;
		case Song.Instrument.GuitarCoop:
			base.method_0("Guitar Coop");
			return;
		case Song.Instrument.Bass:
			base.method_0("Bass Guitar");
			return;
		case Song.Instrument.Keys:
			base.method_0("Keys");
			return;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
			break;
		case Song.Instrument.GHLGuitar:
			base.method_0("6 Fret Guitar");
			return;
		case Song.Instrument.GHLBass:
			base.method_0("6 Fret Bass Guitar");
			return;
		case Song.Instrument.None:
			base.method_0("No Part");
			break;
		case Song.Instrument.Rhythm:
			base.method_0("Rhythm Guitar");
			return;
		default:
			return;
		}
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x0000500B File Offset: 0x0000320B
	protected virtual void vmethod_90()
	{
		base.vmethod_30();
		if (this.enum1_0 == (PlayerSelection.Enum1)6)
		{
			this.method_85();
		}
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x0004F958 File Offset: 0x0004DB58
	private void method_61()
	{
		this.header.text = GClass4.gclass4_0.method_11("Language");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingInstrument;
		this.method_98();
		GClass10.GEnum7 genum = this.gclass9_0.gclass10_0.gclass5_7.method_11();
		if (genum != GClass10.GEnum7.Guitar)
		{
			if (genum == GClass10.GEnum7.GHLGuitar)
			{
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Drums))
				{
					this.method_51("Songs are still scanning...");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Guitar))
				{
					this.method_54("%");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
				{
					this.method_83("song");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
				{
					this.method_54("Album = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Guitar))
				{
					this.method_81("custom");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Band))
				{
					this.method_83("album");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GHLBass))
				{
					this.method_51("Rename Setlist");
				}
			}
		}
		else
		{
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Guitar))
			{
				this.method_51("Lights Out");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
			{
				this.method_81("Date Added");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Keys))
			{
				this.method_81("Lyrics");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Keys))
			{
				this.method_51("song");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.GHLBass))
			{
				this.method_51("_ENDOFSONG");
			}
		}
		if (this.int_4 == 0)
		{
			this.method_81("\\d+ = TS \\d+");
		}
		this.vmethod_3();
		switch (this.gclass9_0.gclass10_0.genum18_0)
		{
		case Song.Instrument.Guitar:
			base.method_0("Bass Guitar");
			return;
		case Song.Instrument.GuitarCoop:
			base.method_0("]");
			return;
		case Song.Instrument.Bass:
			base.method_43("Connect to:");
			return;
		case Song.Instrument.Keys:
			base.method_0(")");
			return;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
			break;
		case Song.Instrument.GHLGuitar:
			base.method_43("song");
			return;
		case Song.Instrument.GHLBass:
			base.method_43(" ");
			return;
		case Song.Instrument.None:
			base.method_0("Connecting to server...\nServer: ");
			break;
		case Song.Instrument.Rhythm:
			base.method_0("Type the setlist name");
			return;
		default:
			return;
		}
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
	private void method_62()
	{
		this.header.text = GClass4.gclass4_0.method_21("Songs");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingDifficulty;
		this.method_96();
		GClass10.GEnum7 genum = this.gclass9_0.gclass10_0.gclass5_7.method_11();
		if (genum != GClass10.GEnum7.Guitar)
		{
			if (genum == GClass10.GEnum7.Guitar)
			{
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Keys))
				{
					this.method_51(" ");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Drums))
				{
					this.method_51("genre");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Guitar))
				{
					this.method_51("Full Song");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Guitar))
				{
					this.method_54("volume");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.GHLBass))
				{
					this.method_54("sort_filter");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GHLBass))
				{
					this.method_54("custom");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
				{
					this.method_83("highway_placement");
				}
			}
		}
		else
		{
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Bass))
			{
				this.method_51("");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Guitar))
			{
				this.method_83("instrument_name_");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
			{
				this.method_51("Custom Content");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Rhythm))
			{
				this.method_83("song");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Keys))
			{
				this.method_83("Yes");
			}
		}
		if (this.int_4 == 0)
		{
			this.method_51("<color=#FFFF04FF>");
		}
		this.vmethod_3();
		switch (this.gclass9_0.gclass10_0.genum18_0)
		{
		case Song.Instrument.Guitar:
			base.method_43("multiplier_note");
			return;
		case Song.Instrument.GuitarCoop:
			base.method_0("Mute Track on Miss");
			return;
		case Song.Instrument.Bass:
			base.method_0("Open Data Privacy Page");
			return;
		case Song.Instrument.Keys:
			base.method_0("Genre = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
			return;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
			break;
		case Song.Instrument.GHLGuitar:
			base.method_0("Save Playlist");
			return;
		case Song.Instrument.GHLBass:
			base.method_0("Yes");
			return;
		case Song.Instrument.None:
			base.method_43("No Fail");
			break;
		case Song.Instrument.Rhythm:
			base.method_43("-");
			return;
		default:
			return;
		}
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x0004FE68 File Offset: 0x0004E068
	private void method_63()
	{
		this.header.text = GClass4.gclass4_0.method_5("preview_start_time");
		this.enum1_0 = (PlayerSelection.Enum1)7;
		this.method_49();
		this.method_81("charter");
		this.method_51("Ready");
		this.method_83(">");
		this.method_51("custom");
		this.method_54("Particles");
		this.method_51("0");
		this.method_83("-");
		this.method_83(".");
		this.method_51("star_animation");
		this.vmethod_3();
		base.method_0("uid");
		this.method_53();
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x0004FF18 File Offset: 0x0004E118
	private void method_64()
	{
		string a = base.method_39();
		if (!(a == "</color> "))
		{
			if (!(a == "Album"))
			{
				if (!(a == "Play Setlist"))
				{
					if (a == "Language")
					{
						this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Hard;
					}
				}
				else
				{
					this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Hard;
				}
			}
			else
			{
				this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Easy;
			}
		}
		else
		{
			this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Easy;
		}
		this.method_48();
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x0004FFB0 File Offset: 0x0004E1B0
	private void method_65()
	{
		string text = base.method_39();
		uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
		if (num <= 4294967135u)
		{
			if (num <= 4294967150u)
			{
				if (num != 183u)
				{
					if (num == 4294967279u)
					{
						if (text == "/")
						{
							this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle);
						}
					}
				}
				else if (text == "settings.ini")
				{
					this.method_45();
					return;
				}
			}
			else if (num != 4294967282u)
			{
				if (num == 153u)
				{
					if (text == "Press Enter to confirm")
					{
						this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
					}
				}
			}
			else if (text == "Unknown Album")
			{
				this.gclass9_0.gclass10_0.genum6_0 = (GClass6.GEnum6)0;
			}
		}
		else if (num <= 4294967180u)
		{
			if (num != 42u)
			{
				if (num == 134u)
				{
					if (text == "Don't Scan Songs")
					{
						this.gclass9_0.gclass10_0.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs);
					}
				}
			}
			else if (text == "Continue")
			{
				this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.AllOpens | GClass6.GEnum6.HOPOsToTaps);
			}
		}
		else if (num != 67u)
		{
			if (num != 4294967286u)
			{
				if (num == 4294967287u)
				{
					if (text == "[prc_")
					{
						this.gclass9_0.gclass10_0.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
					}
				}
			}
			else if (text == "song")
			{
				this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle);
			}
		}
		else if (text == "Close")
		{
			this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode);
		}
		this.method_101();
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x0005017C File Offset: 0x0004E37C
	private void method_66()
	{
		for (int i = 0; i < this.int_3; i++)
		{
			Image image = this.modifiersChosen[i];
			string text = this.menuStrings[this.int_0 + i];
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 4294967239u)
			{
				if (num <= 108u)
				{
					if (num != 69u)
					{
						if (num == 172u)
						{
							if (text == "Error: ")
							{
								image.enabled = this.gclass9_0.gclass10_0.method_7(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode);
							}
						}
					}
					else if (text == "Use Song Backgrounds")
					{
						image.enabled = false;
					}
				}
				else if (num != 84u)
				{
					if (num == 4294967118u)
					{
						if (text == "Connected to client")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_7(GClass6.GEnum6.AllTaps);
						}
					}
				}
				else if (text == "song")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_7((GClass6.GEnum6)0);
				}
			}
			else if (num <= 4294967237u)
			{
				if (num != 4294967276u)
				{
					if (num == 4294967212u)
					{
						if (text == "WRITING BADSONGS.TXT...")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_7(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == "Calibration")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_35(GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.HOPOsToTaps);
				}
			}
			else if (num != 88u)
			{
				if (num != 20u)
				{
					if (num == 4294967188u)
					{
						if (text == "song_preview")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_19(GClass6.GEnum6.None);
						}
					}
				}
				else if (text == "")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle);
				}
			}
			else if (text == "Gameplay")
			{
				image.enabled = this.gclass9_0.gclass10_0.method_7(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle));
			}
		}
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x000503A4 File Offset: 0x0004E5A4
	private void method_67()
	{
		string string_ = base.String_0;
		if (!(string_ == ".mp4|.avi|.webm|.vp8|.ogv|.mpeg"))
		{
			if (!(string_ == "part vocals"))
			{
				if (!(string_ == "Bass Guitar"))
				{
					if (string_ == "Keys")
					{
						this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Hard;
					}
				}
				else
				{
					this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Hard;
				}
			}
			else
			{
				this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Expert;
			}
		}
		else
		{
			this.gclass9_0.gclass10_0.genum17_0 = (Song.GEnum17)7;
		}
		this.method_97();
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00005022 File Offset: 0x00003222
	private void method_68()
	{
		this.header.text = GClass4.gclass4_0.method_48("");
		this.enum1_0 = (PlayerSelection.Enum1)7;
		this.method_73();
		this.method_98();
		this.vmethod_67();
		base.method_2();
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x0005043C File Offset: 0x0004E63C
	protected virtual void vmethod_91()
	{
		if (!this.gclass9_0.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.genum7_0 != this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0)
		{
			this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
			this.method_55();
			this.vmethod_25(1);
		}
		base.Update();
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x000504B0 File Offset: 0x0004E6B0
	private void method_69()
	{
		for (int i = 1; i < this.modifiersChosen.Length; i++)
		{
			this.modifiersChosen[i].enabled = false;
		}
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x000504E0 File Offset: 0x0004E6E0
	public virtual void vmethod_92()
	{
		switch (this.enum1_0)
		{
		case PlayerSelection.Enum1.ChoosingInstrument:
			this.playerSelectionCanvas.method_1();
			return;
		case PlayerSelection.Enum1.ChoosingDifficulty:
			this.method_60();
			return;
		case PlayerSelection.Enum1.ChoosingModifier:
			this.method_44();
			return;
		case PlayerSelection.Enum1.Ready:
			if (this.gclass9_0.gclass10_0.genum18_0 == (Song.Instrument)119)
			{
				this.method_78();
				return;
			}
			this.method_77();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00050548 File Offset: 0x0004E748
	private void method_70()
	{
		for (int i = 1; i < this.int_3; i++)
		{
			Image image = this.modifiersChosen[i];
			string text = this.menuStrings[this.int_0 + i];
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 4294967190u)
			{
				if (num <= 4294967195u)
				{
					if (num != 95u)
					{
						if (num == 4294967264u)
						{
							if (text == "Camera")
							{
								image.enabled = this.gclass9_0.gclass10_0.method_7(~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens));
							}
						}
					}
					else if (text == "Yes")
					{
						image.enabled = true;
					}
				}
				else if (num != 4294967249u)
				{
					if (num == 154u)
					{
						if (text == "audio")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_32(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == "%")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.None);
				}
			}
			else if (num <= 4294967156u)
			{
				if (num != 81u)
				{
					if (num == 4294967149u)
					{
						if (text == "game")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_19(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == "beat")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps));
				}
			}
			else if (num != 4294967174u)
			{
				if (num != 87u)
				{
					if (num == 4294967272u)
					{
						if (text == "{0:n3}x")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_19(GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == "_ENDOFSONG")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_19(~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.Shuffle));
				}
			}
			else if (text == "Yes")
			{
				image.enabled = this.gclass9_0.gclass10_0.method_35(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode);
			}
		}
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x0000505D File Offset: 0x0000325D
	public bool method_71()
	{
		return this.enum1_0 == (PlayerSelection.Enum1)7;
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00050770 File Offset: 0x0004E970
	private void method_72()
	{
		this.header.text = GClass4.gclass4_0.method_13("Modifiers");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingModifier;
		this.method_96();
		this.method_83("Ready");
		this.method_83("None");
		this.method_83("All Strums");
		this.method_83("All HOPO's");
		this.method_83("All Taps");
		this.method_83("All Opens");
		this.method_83("HOPO's to Taps");
		this.method_83("Mirror Mode");
		this.method_83("Note Shuffle");
		this.vmethod_67();
		base.method_0("Ready");
		this.method_53();
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00050820 File Offset: 0x0004EA20
	private void method_73()
	{
		for (int i = 0; i < this.modifiersChosen.Length; i++)
		{
			this.modifiersChosen[i].enabled = false;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600096F RID: 2415 RVA: 0x00005068 File Offset: 0x00003268
	public bool Boolean_0
	{
		get
		{
			return this.enum1_0 == PlayerSelection.Enum1.Ready;
		}
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00050850 File Offset: 0x0004EA50
	private void method_74()
	{
		string string_ = base.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 4294967097u)
		{
			if (num <= 4294967243u)
			{
				if (num != 4294967121u)
				{
					if (num == 33u)
					{
						if (string_ == "No")
						{
							this.gclass9_0.gclass10_0.genum18_0 = (Song.Instrument)(-86);
						}
					}
				}
				else if (string_ == "/Video Backgrounds")
				{
					this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Bass;
				}
			}
			else if (num != 28u)
			{
				if (num == 107u)
				{
					if (string_ == "All HOPO's")
					{
						this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Guitar;
					}
				}
			}
			else if (string_ == "WRITING CACHE...")
			{
				this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.GuitarCoop;
			}
		}
		else if (num <= 4294967236u)
		{
			if (num != 11u)
			{
				if (num == 45u)
				{
					if (string_ == "Video Offset")
					{
						this.gclass9_0.gclass10_0.genum18_0 = (Song.Instrument)63;
						this.method_47();
						return;
					}
				}
			}
			else if (string_ == "Press Enter to confirm")
			{
				this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.GuitarCoop;
			}
		}
		else if (num != 177u)
		{
			if (num == 4294967162u)
			{
				if (string_ == "cd")
				{
					this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Vocals;
				}
			}
		}
		else if (string_ == "pause_on_focus_lost")
		{
			this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Drums;
		}
		this.method_44();
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00050A00 File Offset: 0x0004EC00
	private void method_75()
	{
		string a = base.method_39();
		if (!(a == "Keys"))
		{
			if (!(a == "Continue"))
			{
				if (!(a == "</color> songs exported"))
				{
					if (a == "Awesome Solo!")
					{
						this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Expert;
					}
				}
				else
				{
					this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Expert;
				}
			}
			else
			{
				this.gclass9_0.gclass10_0.genum17_0 = (Song.GEnum17)4;
			}
		}
		else
		{
			this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Expert;
		}
		this.method_48();
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00050A98 File Offset: 0x0004EC98
	private void method_76()
	{
		string text = base.method_39();
		uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
		if (num <= 19u)
		{
			if (num <= 179u)
			{
				if (num != 21u)
				{
					if (num == 4294967145u)
					{
						if (text == "flames")
						{
							this.gclass9_0.gclass10_0.method_9(~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps));
						}
					}
				}
				else if (text == "No")
				{
					this.method_47();
					return;
				}
			}
			else if (num != 4294967211u)
			{
				if (num == 4294967154u)
				{
					if (text == "Song Speed")
					{
						this.gclass9_0.gclass10_0.method_33((GClass6.GEnum6)0);
					}
				}
			}
			else if (text == "language")
			{
				this.gclass9_0.gclass10_0.genum6_0 = GClass6.GEnum6.None;
			}
		}
		else if (num <= 4294967237u)
		{
			if (num != 4294967137u)
			{
				if (num == 35u)
				{
					if (text == "pause_on_focus_lost")
					{
						this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
					}
				}
			}
			else if (text == "-")
			{
				this.gclass9_0.gclass10_0.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode);
			}
		}
		else if (num != 161u)
		{
			if (num != 183u)
			{
				if (num == 60u)
				{
					if (text == "Create Profile")
					{
						this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.AllStrums);
					}
				}
			}
			else if (text == "background_image")
			{
				this.gclass9_0.gclass10_0.method_9(GClass6.GEnum6.None | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode);
			}
		}
		else if (text == "Song Speed")
		{
			this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle);
		}
		this.method_53();
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00050C64 File Offset: 0x0004EE64
	private void method_77()
	{
		this.header.text = GClass4.gclass4_0.method_5("game");
		this.enum1_0 = PlayerSelection.Enum1.Ready;
		this.method_49();
		this.method_54("VOLUME");
		this.method_54("PreviewStart = [\\-\\+]?\\d+(\\.\\d+)?");
		this.method_51("No Source");
		this.method_81("Rhythm Guitar");
		this.method_51("Resolution");
		this.method_81("volume");
		this.method_81("streamer");
		this.method_51("custom");
		this.method_51("pause_on_focus_lost");
		this.vmethod_67();
		base.method_43("Main Menu");
		this.method_53();
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00050D14 File Offset: 0x0004EF14
	private void method_78()
	{
		this.header.text = GClass4.gclass4_0.method_13("");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingInstrument;
		this.method_98();
		GClass10.GEnum7 genum = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
		if (genum != GClass10.GEnum7.Guitar)
		{
			if (genum == GClass10.GEnum7.GHLGuitar)
			{
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
				{
					this.method_83("stars");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.GHLGuitar))
				{
					this.method_81("Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
				{
					this.method_54("Lyrics");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
				{
					this.method_51("\"([^\"]*)\"");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Bass))
				{
					this.method_83("Load Setlist");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Guitar))
				{
					this.method_81("Create Profile");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Guitar))
				{
					this.method_83("charter");
				}
			}
		}
		else
		{
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Guitar))
			{
				this.method_83("There was a problem saving the file");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Guitar))
			{
				this.method_81("part keys");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Keys))
			{
				this.method_81("song");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Rhythm))
			{
				this.method_51("Yes");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Guitar))
			{
				this.method_81("Keys");
			}
		}
		if (this.int_4 == 0)
		{
			this.method_81("Current Instrument");
		}
		this.vmethod_67();
		switch (this.gclass9_0.gclass10_0.genum18_0)
		{
		case Song.Instrument.Guitar:
			base.method_43("Are you sure you want to quit?");
			return;
		case Song.Instrument.GuitarCoop:
			base.method_43("^");
			return;
		case Song.Instrument.Bass:
			base.method_0("GHLGuitar");
			return;
		case Song.Instrument.Keys:
			base.method_0("Lead Guitar");
			return;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
			break;
		case Song.Instrument.GHLGuitar:
			base.method_0("Custom Content");
			return;
		case Song.Instrument.GHLBass:
			base.method_0("Visit Website");
			return;
		case Song.Instrument.None:
			base.method_0("You must restart, settings were changed");
			break;
		case Song.Instrument.Rhythm:
			base.method_0("custom");
			return;
		default:
			return;
		}
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00050F9C File Offset: 0x0004F19C
	private void method_79()
	{
		string string_ = base.String_0;
		if (!(string_ == "Easy"))
		{
			if (!(string_ == "Medium"))
			{
				if (!(string_ == "Hard"))
				{
					if (string_ == "Expert")
					{
						this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Expert;
					}
				}
				else
				{
					this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Hard;
				}
			}
			else
			{
				this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Medium;
			}
		}
		else
		{
			this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Easy;
		}
		this.method_72();
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00051034 File Offset: 0x0004F234
	private void method_80()
	{
		string string_ = base.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 1647809847u)
		{
			if (num <= 1422873973u)
			{
				if (num != 5829013u)
				{
					if (num == 1422873973u)
					{
						if (string_ == "Rhythm Guitar")
						{
							this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Rhythm;
						}
					}
				}
				else if (string_ == "6 Fret Bass Guitar")
				{
					this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.GHLBass;
				}
			}
			else if (num != 1613443821u)
			{
				if (num == 1647809847u)
				{
					if (string_ == "Lead Guitar")
					{
						this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Guitar;
					}
				}
			}
			else if (string_ == "Keys")
			{
				this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Keys;
			}
		}
		else if (num <= 2024374535u)
		{
			if (num != 1934333424u)
			{
				if (num == 2024374535u)
				{
					if (string_ == "No Part")
					{
						this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.None;
						this.method_100();
						return;
					}
				}
			}
			else if (string_ == "Guitar Coop")
			{
				this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.GuitarCoop;
			}
		}
		else if (num != 2027408576u)
		{
			if (num == 2590799002u)
			{
				if (string_ == "6 Fret Lead Guitar")
				{
					this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.GHLGuitar;
				}
			}
		}
		else if (string_ == "Bass Guitar")
		{
			this.gclass9_0.gclass10_0.genum18_0 = Song.Instrument.Bass;
		}
		this.method_46();
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00004FCB File Offset: 0x000031CB
	private void method_81(string string_1)
	{
		this.menuStrings[this.int_4] = string_1;
		this.int_4 += 0;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x000511E4 File Offset: 0x0004F3E4
	private void method_82()
	{
		string string_ = base.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 25u)
		{
			if (num <= 132u)
			{
				if (num != 4294967204u)
				{
					if (num == 34u)
					{
						if (string_ == "Overwrite")
						{
							this.gclass9_0.gclass10_0.method_9(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle));
						}
					}
				}
				else if (string_ == "backend")
				{
					this.method_47();
					return;
				}
			}
			else if (num != 4294967205u)
			{
				if (num == 38u)
				{
					if (string_ == "Resolution")
					{
						this.gclass9_0.gclass10_0.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
					}
				}
			}
			else if (string_ == "Master Volume")
			{
				this.gclass9_0.gclass10_0.genum6_0 = GClass6.GEnum6.None;
			}
		}
		else if (num <= 4294967126u)
		{
			if (num != 11u)
			{
				if (num == 163u)
				{
					if (string_ == "is_practice")
					{
						this.gclass9_0.gclass10_0.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs);
					}
				}
			}
			else if (string_ == "These folders contain charts that another song has (duplicate charts)!")
			{
				this.gclass9_0.gclass10_0.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps);
			}
		}
		else if (num != 4294967191u)
		{
			if (num != 4294967248u)
			{
				if (num == 4294967222u)
				{
					if (string_ == "Profile file version is different!")
					{
						this.gclass9_0.gclass10_0.method_33((GClass6.GEnum6)0);
					}
				}
			}
			else if (string_ == "All Opens")
			{
				this.gclass9_0.gclass10_0.method_1(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle);
			}
		}
		else if (string_ == "\"([^\"]*)\"")
		{
			this.gclass9_0.gclass10_0.method_1(~(GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle));
		}
		this.method_101();
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x000513B0 File Offset: 0x0004F5B0
	public virtual void vmethod_93()
	{
		this.int_2 = 0;
		this.int_0 = 1;
		this.int_1 = 1;
		this.int_3 = this.int_4;
		if (this.int_4 > 4)
		{
			this.int_3 = 1;
			this.int_2 = this.int_4 - this.int_3;
			return;
		}
		for (int i = this.int_4; i < this.textObjects.Length; i++)
		{
			this.textObjects[i].text = "<OOB PATH>";
		}
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00004F44 File Offset: 0x00003144
	private void method_83(string string_1)
	{
		this.menuStrings[this.int_4] = string_1;
		this.int_4++;
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x000504B0 File Offset: 0x0004E6B0
	private void method_84()
	{
		for (int i = 1; i < this.modifiersChosen.Length; i++)
		{
			this.modifiersChosen[i].enabled = false;
		}
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x0005142C File Offset: 0x0004F62C
	private void method_85()
	{
		for (int i = 1; i < this.int_3; i += 0)
		{
			Image image = this.modifiersChosen[i];
			string text = this.menuStrings[this.int_0 + i];
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 4294967273u)
			{
				if (num <= 190u)
				{
					if (num != 158u)
					{
						if (num == 4294967254u)
						{
							if (text == "0%")
							{
								image.enabled = this.gclass9_0.gclass10_0.method_19(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode));
							}
						}
					}
					else if (text == "vocals")
					{
						image.enabled = false;
					}
				}
				else if (num != 4294967268u)
				{
					if (num == 170u)
					{
						if (text == "Are you sure you want to delete this setlist?")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_19(GClass6.GEnum6.AllStrums);
						}
					}
				}
				else if (text == "Ready")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.None);
				}
			}
			else if (num <= 106u)
			{
				if (num != 4294967170u)
				{
					if (num == 4294967111u)
					{
						if (text == "directories")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_32(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == "Album")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(~(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle));
				}
			}
			else if (num != 4294967183u)
			{
				if (num != 132u)
				{
					if (num == 4294967270u)
					{
						if (text == "song")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_7(GClass6.GEnum6.AllStrums);
						}
					}
				}
				else if (text == "song")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_35(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.MirrorMode));
				}
			}
			else if (text == "Yes")
			{
				image.enabled = this.gclass9_0.gclass10_0.method_7(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs));
			}
		}
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00051654 File Offset: 0x0004F854
	private void method_86()
	{
		this.header.text = GClass4.gclass4_0.method_36("Video Start Time");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingDifficulty;
		this.method_57();
		this.method_49();
		GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)Enum.Parse(typeof(GStruct2.GEnum11), this.gclass9_0.gclass10_0.genum18_0.ToString());
		if (this.songEntry_0.charts.method_19(genum11_, (GStruct2.GEnum12)4))
		{
			this.method_81("There was a problem saving the file");
		}
		if (this.songEntry_0.charts.method_34(genum11_, (GStruct2.GEnum12)4))
		{
			this.method_54("offsets");
		}
		if (this.songEntry_0.charts.method_11(genum11_, GStruct2.GEnum12.Easy))
		{
			this.method_51("song");
		}
		if (this.songEntry_0.charts.method_37(genum11_, GStruct2.GEnum12.Easy))
		{
			this.method_83("Quit");
		}
		this.vmethod_3();
		base.method_0(this.gclass9_0.gclass10_0.genum17_0.ToString());
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00051764 File Offset: 0x0004F964
	private void method_87()
	{
		this.header.text = GClass4.gclass4_0.method_2("Bass Guitar");
		this.enum1_0 = (PlayerSelection.Enum1)4;
		this.method_96();
		this.method_51("custom_song_export");
		this.method_81("highway_shake");
		this.method_51("Songs are still scanning...");
		this.method_54("{0}");
		this.method_51("diff_rhythm");
		this.method_51("<color=#FFFF04FF>");
		this.method_54("");
		this.method_54("system_ram");
		this.method_81("Song Display");
		this.vmethod_3();
		base.method_0("song");
		this.method_101();
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00051814 File Offset: 0x0004FA14
	private void method_88()
	{
		this.header.text = GClass4.gclass4_0.method_46("Song Speed");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingInstrument;
		this.method_49();
		GClass10.GEnum7 genum = this.gclass9_0.gclass10_0.gclass5_7.method_11();
		if (genum != GClass10.GEnum7.Guitar)
		{
			if (genum == GClass10.GEnum7.GHLGuitar)
			{
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.GHLGuitar))
				{
					this.method_54("=");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Keys))
				{
					this.method_51("Show Lyrics");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
				{
					this.method_51("Main Menu");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
				{
					this.method_81("Low Latency Mode");
				}
				if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Rhythm))
				{
					this.method_81("Keys");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.GHLGuitar))
				{
					this.method_54("Audio Backend");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Guitar))
				{
					this.method_54("mute_volume");
				}
			}
		}
		else
		{
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
			{
				this.method_81("Rename Profile");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
			{
				this.method_81("Client connected");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GHLGuitar))
			{
				this.method_54("Open Data Privacy Page");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Rhythm))
			{
				this.method_83("game");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Bass))
			{
				this.method_51(".chart");
			}
		}
		if (this.int_4 == 0)
		{
			this.method_83("volume");
		}
		this.vmethod_3();
		switch (this.gclass9_0.gclass10_0.genum18_0)
		{
		case Song.Instrument.Guitar:
			base.method_0("Rhythm Guitar");
			return;
		case Song.Instrument.GuitarCoop:
			base.method_43("CALIBRATION");
			return;
		case Song.Instrument.Bass:
			base.method_0("Name = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
			return;
		case Song.Instrument.Keys:
			base.method_43("No Videos!");
			return;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
			break;
		case Song.Instrument.GHLGuitar:
			base.method_0("[");
			return;
		case Song.Instrument.GHLBass:
			base.method_43("Display Name");
			return;
		case Song.Instrument.None:
			base.method_0(" + ");
			break;
		case Song.Instrument.Rhythm:
			base.method_43("");
			return;
		default:
			return;
		}
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00051A9C File Offset: 0x0004FC9C
	private void method_89()
	{
		this.header.text = GClass4.gclass4_0.method_35("game");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingDifficulty;
		this.method_73();
		this.method_98();
		GStruct2.GEnum11 genum11_ = (GStruct2.GEnum11)Enum.Parse(typeof(GStruct2.GEnum11), this.gclass9_0.gclass10_0.genum18_0.ToString());
		if (this.songEntry_0.charts.method_34(genum11_, (GStruct2.GEnum12)6))
		{
			this.method_51("Calibration");
		}
		if (this.songEntry_0.charts.method_14(genum11_, (GStruct2.GEnum12)6))
		{
			this.method_54("Cancel");
		}
		if (this.songEntry_0.charts.method_36(genum11_, GStruct2.GEnum12.Medium))
		{
			this.method_51("Expert");
		}
		if (this.songEntry_0.charts.method_7(genum11_, GStruct2.GEnum12.Easy))
		{
			this.method_81("");
		}
		this.vmethod_3();
		base.method_0(this.gclass9_0.gclass10_0.genum17_0.ToString());
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00051BAC File Offset: 0x0004FDAC
	public virtual void vmethod_94()
	{
		this.int_2 = 0;
		this.int_0 = 0;
		this.int_1 = 0;
		this.int_3 = this.int_4;
		if (this.int_4 > 3)
		{
			this.int_3 = 6;
			this.int_2 = this.int_4 - this.int_3;
			return;
		}
		for (int i = this.int_4; i < this.textObjects.Length; i += 0)
		{
			this.textObjects[i].text = "Yes";
		}
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x00051C28 File Offset: 0x0004FE28
	protected virtual void vmethod_95()
	{
		if (!this.gclass9_0.method_9())
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.genum7_0 != this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0)
		{
			this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.method_11();
			this.method_60();
			this.vmethod_23(0);
		}
		base.Update();
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00051C9C File Offset: 0x0004FE9C
	private void method_90()
	{
		this.header.text = GClass4.gclass4_0.method_7("video");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingModifier;
		this.method_98();
		this.method_81("</color> songs exported");
		this.method_51("A: 00:00:00");
		this.method_54("Prefabs/Gameplay/Notes/Beatline");
		this.method_54("Song Offset");
		this.method_51("Has Lyrics");
		this.method_81("song");
		this.method_51("playlist_track");
		this.method_54("Unknown Charter");
		this.method_81("Show Mouse Cursor");
		this.vmethod_67();
		base.method_43(".ogg");
		this.method_85();
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00051D4C File Offset: 0x0004FF4C
	private void method_91()
	{
		for (int i = 1; i < this.modifiersChosen.Length; i += 0)
		{
			this.modifiersChosen[i].enabled = true;
		}
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00005073 File Offset: 0x00003273
	protected virtual void vmethod_96()
	{
		base.vmethod_50();
		if (this.enum1_0 == (PlayerSelection.Enum1)6)
		{
			this.method_66();
		}
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x0000508A File Offset: 0x0000328A
	public bool method_92()
	{
		return this.enum1_0 == PlayerSelection.Enum1.ChoosingDifficulty;
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00051D7C File Offset: 0x0004FF7C
	public virtual void vmethod_97()
	{
		this.int_2 = 0;
		this.int_0 = 1;
		this.int_1 = 0;
		this.int_3 = this.int_4;
		if (this.int_4 > 2)
		{
			this.int_3 = 4;
			this.int_2 = this.int_4 - this.int_3;
			return;
		}
		for (int i = this.int_4; i < this.textObjects.Length; i += 0)
		{
			this.textObjects[i].text = "Unknown Charter";
		}
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00051DF8 File Offset: 0x0004FFF8
	protected virtual void vmethod_98()
	{
		base.method_35(GlobalVariables.instance.playerList[this.playerIndex]);
		if (this.gclass9_0.gclass10_0 == null)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.songEntry_0 = GlobalVariables.instance.currentSongEntry;
		this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.method_11();
		this.method_60();
		this.method_95();
		base.vmethod_9();
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00005095 File Offset: 0x00003295
	protected virtual void vmethod_99()
	{
		base.vmethod_30();
		if (this.enum1_0 == (PlayerSelection.Enum1)6)
		{
			this.method_101();
		}
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00051E78 File Offset: 0x00050078
	private void method_93()
	{
		this.header.text = GClass4.gclass4_0.method_21("bad_note2");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingInstrument;
		this.method_96();
		GClass10.GEnum7 genum = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
		if (genum != GClass10.GEnum7.Guitar)
		{
			if (genum == GClass10.GEnum7.Guitar)
			{
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Band))
				{
					this.method_83("6 Fret Lead Guitar");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Drums))
				{
					this.method_83("Hard");
				}
				if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.Bass))
				{
					this.method_81("Artist");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Guitar))
				{
					this.method_81("Songs are still scanning...");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Band))
				{
					this.method_54("MSAA Level");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Drums))
				{
					this.method_54("[Events]");
				}
				if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Guitar))
				{
					this.method_83("Vsync");
				}
			}
		}
		else
		{
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Bass))
			{
				this.method_83("song");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.Guitar))
			{
				this.method_83("Are you sure you want to practice?");
			}
			if (this.songEntry_0.charts.method_40(GStruct2.GEnum11.Keys))
			{
				this.method_81("...");
			}
			if (this.songEntry_0.charts.method_10(GStruct2.GEnum11.GHLBass))
			{
				this.method_83("A: 00:00:00");
			}
			if (this.songEntry_0.charts.method_4(GStruct2.GEnum11.GHLBass))
			{
				this.method_83("score");
			}
		}
		if (this.int_4 == 0)
		{
			this.method_54("");
		}
		this.vmethod_67();
		switch (this.gclass9_0.gclass10_0.genum18_0)
		{
		case Song.Instrument.Guitar:
			base.method_43("ControlMapper");
			return;
		case Song.Instrument.GuitarCoop:
			base.method_43("No Part");
			return;
		case Song.Instrument.Bass:
			base.method_43("diff_band");
			return;
		case Song.Instrument.Keys:
			base.method_43("Player2 = \\w+");
			return;
		case Song.Instrument.Drums:
		case Song.Instrument.Vocals:
		case Song.Instrument.Crowd:
			break;
		case Song.Instrument.GHLGuitar:
			base.method_43("Pause on Focus Lost");
			return;
		case Song.Instrument.GHLBass:
			base.method_43("");
			return;
		case Song.Instrument.None:
			base.method_43("rhythm");
			break;
		case Song.Instrument.Rhythm:
			base.method_0("Sound Effects");
			return;
		default:
			return;
		}
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00052100 File Offset: 0x00050300
	private void method_94()
	{
		string a = base.method_39();
		if (!(a == "full_playlist"))
		{
			if (!(a == "ms"))
			{
				if (!(a == "No"))
				{
					if (a == "flames")
					{
						this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Expert;
					}
				}
				else
				{
					this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Hard;
				}
			}
			else
			{
				this.gclass9_0.gclass10_0.genum17_0 = (Song.GEnum17)7;
			}
		}
		else
		{
			this.gclass9_0.gclass10_0.genum17_0 = (Song.GEnum17)4;
		}
		this.method_97();
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00052198 File Offset: 0x00050398
	private void method_95()
	{
		for (int i = 0; i < this.modifiersChosen.Length; i += 0)
		{
			this.modifiersChosen[i].enabled = false;
		}
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x000521C8 File Offset: 0x000503C8
	protected virtual void vmethod_100()
	{
		if (!this.gclass9_0.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		if (this.genum7_0 != this.gclass9_0.gclass10_0.gclass5_7.method_11())
		{
			this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
			this.method_60();
			this.vmethod_23(0);
		}
		base.Update();
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x0005223C File Offset: 0x0005043C
	public virtual void vmethod_101()
	{
		switch (this.enum1_0)
		{
		case PlayerSelection.Enum1.ChoosingInstrument:
			this.playerSelectionCanvas.method_0();
			return;
		case PlayerSelection.Enum1.ChoosingDifficulty:
			this.method_62();
			return;
		case PlayerSelection.Enum1.ChoosingModifier:
			this.method_86();
			return;
		case PlayerSelection.Enum1.Ready:
			if (this.gclass9_0.gclass10_0.genum18_0 == (Song.Instrument)(-97))
			{
				this.method_93();
				return;
			}
			this.method_90();
			return;
		default:
			return;
		}
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x000050AC File Offset: 0x000032AC
	private void method_96()
	{
		this.menuStrings = new string[13];
		this.int_4 = 0;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x000522A4 File Offset: 0x000504A4
	private void method_97()
	{
		this.header.text = GClass4.gclass4_0.method_17("Ultra Greatness Mode");
		this.enum1_0 = PlayerSelection.Enum1.ChoosingDifficulty;
		this.method_49();
		this.method_54("hardware_info");
		this.method_54("0");
		this.method_54("beatscore");
		this.method_54("diff_guitar");
		this.method_81("There was a problem saving the file");
		this.method_81("No");
		this.method_54("artist");
		this.method_81("Easy");
		this.method_83("HOPO's to Taps");
		this.vmethod_3();
		base.method_43("Prefabs/Gameplay/Notes/Beatline");
		this.method_66();
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x000050C2 File Offset: 0x000032C2
	protected virtual void vmethod_102()
	{
		base.vmethod_30();
		if (this.enum1_0 == (PlayerSelection.Enum1)8)
		{
			this.method_85();
		}
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x000050D9 File Offset: 0x000032D9
	private void method_98()
	{
		this.menuStrings = new string[-128];
		this.int_4 = 1;
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00052354 File Offset: 0x00050554
	private void method_99()
	{
		for (int i = 1; i < this.int_3; i += 0)
		{
			Image image = this.modifiersChosen[i];
			string text = this.menuStrings[this.int_0 + i];
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 106u)
			{
				if (num <= 149u)
				{
					if (num != 9u)
					{
						if (num == 4294967250u)
						{
							if (text == "\0\0")
							{
								image.enabled = this.gclass9_0.gclass10_0.method_35(~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.MirrorMode));
							}
						}
					}
					else if (text == "Video Offset")
					{
						image.enabled = true;
					}
				}
				else if (num != 4294967132u)
				{
					if (num == 4294967104u)
					{
						if (text == "")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_7(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums);
						}
					}
				}
				else if (text == "ms")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.None);
				}
			}
			else if (num <= 18u)
			{
				if (num != 42u)
				{
					if (num == 54u)
					{
						if (text == "0%")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.AllTaps);
						}
					}
				}
				else if (text == "Song Settings")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_19(~(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle));
				}
			}
			else if (num != 4294967289u)
			{
				if (num != 19u)
				{
					if (num == 104u)
					{
						if (text == "<")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_35(GClass6.GEnum6.AllTaps);
						}
					}
				}
				else if (text == "Easy")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode);
				}
			}
			else if (text == "game_version")
			{
				image.enabled = this.gclass9_0.gclass10_0.method_32(GClass6.GEnum6.None);
			}
		}
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x0005257C File Offset: 0x0005077C
	protected override void Update()
	{
		if (!this.gclass9_0.Boolean_0)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.genum7_0 != this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0)
		{
			this.genum7_0 = this.gclass9_0.gclass10_0.gclass5_7.GEnum7_0;
			this.method_60();
			this.vmethod_23(0);
		}
		base.Update();
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x000050EF File Offset: 0x000032EF
	private void method_100()
	{
		this.header.text = GClass4.gclass4_0.method_13("Ready");
		this.enum1_0 = PlayerSelection.Enum1.Ready;
		this.method_73();
		this.method_96();
		this.vmethod_67();
		base.method_2();
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x000525F0 File Offset: 0x000507F0
	public virtual void vmethod_103()
	{
		switch (this.enum1_0)
		{
		case PlayerSelection.Enum1.ChoosingInstrument:
			this.method_50();
			return;
		case PlayerSelection.Enum1.ChoosingDifficulty:
			this.method_94();
			return;
		case PlayerSelection.Enum1.ChoosingModifier:
			this.method_76();
			return;
		default:
			return;
		}
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0005262C File Offset: 0x0005082C
	private void method_101()
	{
		for (int i = 1; i < this.int_3; i++)
		{
			Image image = this.modifiersChosen[i];
			string text = this.menuStrings[this.int_0 + i];
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 4294967185u)
			{
				if (num <= 185u)
				{
					if (num != 123u)
					{
						if (num == 38u)
						{
							if (text == "vocals")
							{
								image.enabled = this.gclass9_0.gclass10_0.method_35(GClass6.GEnum6.None | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode);
							}
						}
					}
					else if (text == "All HOPO's")
					{
						image.enabled = false;
					}
				}
				else if (num != 4294967116u)
				{
					if (num == 51u)
					{
						if (text == "directories")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_7(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums);
						}
					}
				}
				else if (text == "/")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_35((GClass6.GEnum6)0);
				}
			}
			else if (num <= 4294967097u)
			{
				if (num != 4294967255u)
				{
					if (num == 165u)
					{
						if (text == "=")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_32(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == " + ")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_35(~(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle));
				}
			}
			else if (num != 4294967180u)
			{
				if (num != 197u)
				{
					if (num == 158u)
					{
						if (text == "^\\s*\\d+ = S 2 \\d+$")
						{
							image.enabled = this.gclass9_0.gclass10_0.method_21(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs);
						}
					}
				}
				else if (text == "Gameplay")
				{
					image.enabled = this.gclass9_0.gclass10_0.method_7(~(GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle));
				}
			}
			else if (text == "game")
			{
				image.enabled = this.gclass9_0.gclass10_0.method_35(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.MirrorMode);
			}
		}
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00052854 File Offset: 0x00050A54
	private void method_102()
	{
		string a = base.method_39();
		if (!(a == "device"))
		{
			if (!(a == "bad_note3"))
			{
				if (!(a == "show_hit_window"))
				{
					if (a == "Year")
					{
						this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Hard;
					}
				}
				else
				{
					this.gclass9_0.gclass10_0.genum17_0 = Song.GEnum17.Expert;
				}
			}
			else
			{
				this.gclass9_0.gclass10_0.genum17_0 = (Song.GEnum17)8;
			}
		}
		else
		{
			this.gclass9_0.gclass10_0.genum17_0 = (Song.GEnum17)5;
		}
		this.method_87();
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x000528EC File Offset: 0x00050AEC
	private void method_103()
	{
		for (int i = 0; i < this.modifiersChosen.Length; i++)
		{
			this.modifiersChosen[i].enabled = true;
		}
	}

	// Token: 0x040001BA RID: 442
	[SerializeField]
	private int playerIndex;

	// Token: 0x040001BB RID: 443
	[SerializeField]
	private Text header;

	// Token: 0x040001BC RID: 444
	private int int_4;

	// Token: 0x040001BD RID: 445
	private GClass10.GEnum7 genum7_0;

	// Token: 0x040001BE RID: 446
	[SerializeField]
	private PlayerSelectionCanvas playerSelectionCanvas;

	// Token: 0x040001BF RID: 447
	private SongEntry songEntry_0;

	// Token: 0x040001C0 RID: 448
	private PlayerSelection.Enum1 enum1_0;

	// Token: 0x040001C1 RID: 449
	[SerializeField]
	private Image[] modifiersChosen;

	// Token: 0x02000039 RID: 57
	private enum Enum1
	{
		// Token: 0x040001C3 RID: 451
		ChoosingInstrument,
		// Token: 0x040001C4 RID: 452
		ChoosingDifficulty,
		// Token: 0x040001C5 RID: 453
		ChoosingModifier,
		// Token: 0x040001C6 RID: 454
		Ready
	}
}
