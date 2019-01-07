using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000018 RID: 24
public class EndOfSong : MonoBehaviour
{
	// Token: 0x06000237 RID: 567 RVA: 0x0001FB58 File Offset: 0x0001DD58
	private void method_0()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1441f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_5())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Song Offset"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Client connected"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("charter"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("menu_volume"));
				}
				else if (gclass.player_0.GetButtonDown(1) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("PRESS START"));
				}
				else if (gclass.player_0.GetButtonDown(6) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Mirror Mode"));
				}
			}
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0001FD64 File Offset: 0x0001DF64
	private void method_1()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 338f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_9())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38(": {0:hh:mm:ss}"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("star_release"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Gameplay"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Hard"));
				}
				else if (gclass.player_0.GetButtonDown(6) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Error: "));
				}
				else if (gclass.player_0.GetButtonDown(8) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Camera"));
				}
			}
		}
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0001FF70 File Offset: 0x0001E170
	private void method_2()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1417f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_18())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("%s%n%a%n%c"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("menu_background"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("video_start_time"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("Gameplay"));
				}
				else if (gclass.player_0.GetButtonDown(5) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Note Shuffle"));
				}
				else if (gclass.player_0.GetButtonDown(0) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("ModChart Full"));
				}
			}
		}
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0002017C File Offset: 0x0001E37C
	private void method_3()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1639f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_19())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("song"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("sort_filter"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38(".setlist"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("score"));
				}
				else if (gclass.player_0.GetButtonDown(5) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9(", "));
				}
				else if (gclass.player_0.GetButtonDown(7) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Save Playlist"));
				}
			}
		}
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00020388 File Offset: 0x0001E588
	private void method_4()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 681f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_19())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Song Length"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Audio Settings"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Quit"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Rescan Custom Content"));
				}
				else if (gclass.player_0.GetButtonDown(4) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Guitar Coop"));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("is_practice"));
				}
			}
		}
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00020594 File Offset: 0x0001E794
	private void method_5()
	{
		FadeBehaviour.fadeBehaviour_0.method_13(875f, 1025f);
		GlobalVariables.instance.method_11(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_21(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_0())
		{
			text = text + "Bass Guitar" + GlobalVariables.instance.songSpeed.method_28() + "Medium";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("This is permanent! Are you still sure?", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 0 || GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_5("6 Fret Bass Guitar");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 1 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_97())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_41("Bass Guitar");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 0; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_14())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_70(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_37(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_7(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_42("Song Options");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Easy;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_17() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)4;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Rhythm, genum12_, this.songStats_0.method_31(), this.songStats_0.method_8(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_21("6 Fret Lead Guitar");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00020A48 File Offset: 0x0001EC48
	private void method_6()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 396f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("song"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Guitar Coop"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0(""));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("ModChart Full"));
				}
				else if (gclass.player_0.GetButtonDown(6) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Easy"));
				}
				else if (gclass.player_0.GetButtonDown(6) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("6 Fret Lead Guitar"));
				}
			}
		}
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00020C54 File Offset: 0x0001EE54
	private void method_7()
	{
		FadeBehaviour.fadeBehaviour_0.method_21(704f, 878f);
		GlobalVariables.instance.method_108(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_33(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + "/Video Backgrounds" + GlobalVariables.instance.songSpeed.method_1() + "Unknown Genre";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("no_fail", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 1 && !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_11("Gameplay");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 6 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_22())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_35("streamer");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 0; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_4())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_17(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_7(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_42("Easy");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Expert;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_11() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Hard;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Bass, genum12_, this.songStats_0.method_43(), this.songStats_0.method_1(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_19(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_17("Unknown Artist");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00021108 File Offset: 0x0001F308
	private void method_8()
	{
		FadeBehaviour.fadeBehaviour_0.method_26(1981f, 436f);
		GlobalVariables.instance.method_37(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_21(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_23())
		{
			text = text + "Keys" + GlobalVariables.instance.songSpeed.String_1 + "Save Playlist";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Resume", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 0 || GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_38("Connected to client");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 3 - this.songStats_0.int_10; i >= 1; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_97())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_16("Note Shuffle");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 1; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_17())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_73(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_13(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_35(" (");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)8;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_4() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)4;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Hard;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Band, genum12_, this.songStats_0.method_30(), this.songStats_0.method_11(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_40(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_5("Connect to:");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x000215BC File Offset: 0x0001F7BC
	private void Update()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.Boolean_0)
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Main Menu"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Gameplay"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Main Menu"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Main Menu"));
				}
				else if (gclass.player_0.GetButtonDown(2) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Gameplay"));
				}
				else if (gclass.player_0.GetButtonDown(3) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Gameplay"));
				}
			}
		}
	}

	// Token: 0x06000242 RID: 578 RVA: 0x000217C8 File Offset: 0x0001F9C8
	private void method_9()
	{
		FadeBehaviour.fadeBehaviour_0.method_21(1879f, 533f);
		GlobalVariables.instance.method_49(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_14(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_6())
		{
			text = text + "volume" + GlobalVariables.instance.songSpeed.String_1 + "Gem Size";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("=", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 1 || !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_13("audio");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 8 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_22())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_41("os_family");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 1; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_7())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_70(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_37(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_20(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_30("?");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)4;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_7() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)5;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GHLBass, genum12_, this.songStats_0.method_25(), this.songStats_0.method_23(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_13(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_17("gh3_sudden_death");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00021C7C File Offset: 0x0001FE7C
	private void method_10()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 166f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_14())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Yes"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Restart"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("menu_volume"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Low Latency Mode"));
				}
				else if (gclass.player_0.GetButtonDown(0) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Game Manager"));
				}
				else if (gclass.player_0.GetButtonDown(2) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("part"));
				}
			}
		}
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00021E88 File Offset: 0x00020088
	private void method_11()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1980f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_18())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Date Added"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("0%"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("charter"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("diff_band"));
				}
				else if (gclass.player_0.GetButtonDown(2) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("song"));
				}
				else if (gclass.player_0.GetButtonDown(1) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("Genre"));
				}
			}
		}
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00022094 File Offset: 0x00020294
	private void method_12()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1178f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_19())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42(""));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24(".mp4|.avi|.webm|.vp8|.ogv|.mpeg"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9(" + "));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("volume"));
				}
				else if (gclass.player_0.GetButtonDown(2) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Game Manager"));
				}
				else if (gclass.player_0.GetButtonDown(6) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Practicing..."));
				}
			}
		}
	}

	// Token: 0x06000246 RID: 582 RVA: 0x000222A0 File Offset: 0x000204A0
	private void method_13()
	{
		FadeBehaviour.fadeBehaviour_0.method_11(1261f, 85f);
		GlobalVariables.instance.method_49(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_14(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_6())
		{
			text = text + "No Fail" + GlobalVariables.instance.songSpeed.String_1 + "game";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("%p", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 0 && !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_42("]");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 3 - this.songStats_0.int_10; i >= 1; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_71())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_48("Unknown Genre");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 6; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.Boolean_0)
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_17(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_10(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_20(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_48("Lead Guitar");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)4;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_9() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)6;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)4;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Drums, genum12_, this.songStats_0.method_7(), this.songStats_0.method_19(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_25(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_36("\"([^\"]*)\"");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00022754 File Offset: 0x00020954
	private void method_14()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 702f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_14())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("There was a problem saving the file"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("song"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Songs"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("No"));
				}
				else if (gclass.player_0.GetButtonDown(6) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("^"));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Practicing..."));
				}
			}
		}
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00022960 File Offset: 0x00020B60
	private void method_15()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1477f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("song"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("song"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Camera"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Video Offset"));
				}
				else if (gclass.player_0.GetButtonDown(0) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("</color>"));
				}
				else if (gclass.player_0.GetButtonDown(4) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Unknown Artist"));
				}
			}
		}
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00022B6C File Offset: 0x00020D6C
	private void method_16()
	{
		FadeBehaviour.fadeBehaviour_0.method_26(1476f, 1879f);
		GlobalVariables.instance.method_37(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_38(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_6())
		{
			text = text + "Lyrics" + GlobalVariables.instance.songSpeed.method_1() + "HOPO's to Taps";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 0 && GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_42("game");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 4 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_71())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_17("Are you sure you want to quit?");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 3; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_14())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_29(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_7(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_2("All Strums");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)5;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_18() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)7;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Guitar, genum12_, this.songStats_0.method_5(), this.songStats_0.method_8(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_35("0");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00023020 File Offset: 0x00021220
	private void method_17()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 233f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_18())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Problem saving setlist"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Guitar Coop"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("song"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("volume"));
				}
				else if (gclass.player_0.GetButtonDown(5) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("sounds"));
				}
				else if (gclass.player_0.GetButtonDown(4) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("album.png"));
				}
			}
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0002322C File Offset: 0x0002142C
	private void method_18()
	{
		FadeBehaviour.fadeBehaviour_0.method_26(1268f, 1900f);
		GlobalVariables.instance.method_11(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_14(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + "background_video" + GlobalVariables.instance.songSpeed.method_1() + "Unknown Album";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("language.txt", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 0 || !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_21("Low Latency Mode");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 0 - this.songStats_0.int_10; i >= 0; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_22())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_46("All Taps");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 5; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_14())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_13(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_11("%)");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)6;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_18() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)5;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Hard;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Band, genum12_, this.songStats_0.method_5(), this.songStats_0.method_8(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_40(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_48("Instrument");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x0600024C RID: 588 RVA: 0x000236E0 File Offset: 0x000218E0
	private void method_19()
	{
		FadeBehaviour.fadeBehaviour_0.method_21(1024f, 1129f);
		GlobalVariables.instance.method_49(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_14(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_23())
		{
			text = text + "" + GlobalVariables.instance.songSpeed.method_28() + ".png|.jpg";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("custom", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 1 || !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_41("");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 2 - this.songStats_0.int_10; i >= 1; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_71())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_35("low_latency_mode");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 3; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_5())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_37(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_38("No Part");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)8;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_17() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)6;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Drums, genum12_, this.songStats_0.method_43(), this.songStats_0.method_42(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_36("Bad file type");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00023B94 File Offset: 0x00021D94
	private void method_20()
	{
		FadeBehaviour.fadeBehaviour_0.method_21(485f, 974f);
		GlobalVariables.instance.method_92(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_36(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_0())
		{
			text = text + "Lead Guitar" + GlobalVariables.instance.songSpeed.method_28() + "Source";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Songs", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 0 || !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_15("target_framerate");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 6 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_97())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_2("directories");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 7; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_19())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_13(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_7(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_13("Lead Guitar");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)4;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_5() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)6;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)5;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Bass, genum12_, this.songStats_0.method_5(), this.songStats_0.method_33(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_25(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_11("name");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00024048 File Offset: 0x00022248
	private void method_21()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 2f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Yes"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("flames"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42(""));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Expert"));
				}
				else if (gclass.player_0.GetButtonDown(5) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("volume"));
				}
				else if (gclass.player_0.GetButtonDown(7) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("0%"));
				}
			}
		}
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00024254 File Offset: 0x00022454
	private void method_22()
	{
		FadeBehaviour.fadeBehaviour_0.method_11(1976f, 935f);
		GlobalVariables.instance.method_37(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_9(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_23())
		{
			text = text + "particles" + GlobalVariables.instance.songSpeed.method_1() + "No Part";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("-", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 1 && GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_17("0%");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 6 - this.songStats_0.int_10; i >= 1; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_22())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_15("Don't Scan Songs");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 0; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_19())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_17(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_16(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_20(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_15("Client disconnected");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)8;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_5() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)7;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Expert;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Keys, genum12_, this.songStats_0.method_22(), this.songStats_0.method_20(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_19(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_21("custom");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00024708 File Offset: 0x00022908
	private void method_23()
	{
		FadeBehaviour.fadeBehaviour_0.method_26(83f, 1409f);
		GlobalVariables.instance.method_92(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_33(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_0())
		{
			text = text + "year" + GlobalVariables.instance.songSpeed.String_1 + "custom";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Note: ", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 0 || GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_16("drums");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 1 - this.songStats_0.int_10; i >= 1; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_22())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_7("");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 0; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_18())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_73(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_17(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_25(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_38("Bass Guitar");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)6;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_15() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)4;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GHLGuitar, genum12_, this.songStats_0.method_22(), this.songStats_0.method_21(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_20(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_17("^\\s*\\d+ = S 2 \\d+$");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00024BBC File Offset: 0x00022DBC
	private void Start()
	{
		FadeBehaviour.fadeBehaviour_0.method_13(1f, 0f);
		GlobalVariables.instance.method_18(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_33(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + " (" + GlobalVariables.instance.songSpeed.String_1 + ")";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("{0:n0}", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 1 && !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_13("savewarning");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 6 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_62())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_13("botnosave");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 4; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.Boolean_0)
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_73(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_10(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_19(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_13("beatscore");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Easy;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.Boolean_0 && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Expert;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Hard;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Band, genum12_, this.songStats_0.method_31(), this.songStats_0.method_33(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_19(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_13("beatscore");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00025070 File Offset: 0x00023270
	private void method_24()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 990f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_18())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Unknown Year"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Practicing..."));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("Rhythm Guitar"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("There was an error deleting the file"));
				}
				else if (gclass.player_0.GetButtonDown(6) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("beatscore"));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("show_hit_window"));
				}
			}
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0002527C File Offset: 0x0002347C
	private void method_25()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1434f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_2())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Main Menu"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("language.txt"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("sp_awarded"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Client\nServer IP: "));
				}
				else if (gclass.player_0.GetButtonDown(2) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25(" %n "));
				}
				else if (gclass.player_0.GetButtonDown(4) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Calibration"));
				}
			}
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00025488 File Offset: 0x00023688
	private void method_26()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 700f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_2())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Unknown Genre"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("\\D+"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("volume"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Mirror Mode"));
				}
				else if (gclass.player_0.GetButtonDown(8) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("This is a placeholder"));
				}
				else if (gclass.player_0.GetButtonDown(7) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("SongScan"));
				}
			}
		}
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00025694 File Offset: 0x00023894
	private void method_27()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 889f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_2())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Searching for"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("album"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0(""));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38(""));
				}
				else if (gclass.player_0.GetButtonDown(1) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("+"));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("No NetworkStartPositions exist!"));
				}
			}
		}
	}

	// Token: 0x06000256 RID: 598 RVA: 0x000258A0 File Offset: 0x00023AA0
	private void method_28()
	{
		FadeBehaviour.fadeBehaviour_0.method_13(1224f, 713f);
		GlobalVariables.instance.method_37(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_33(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + "\\d+ = TS \\d+" + GlobalVariables.instance.songSpeed.method_28() + "Lead Guitar";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Tilt", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 1 && !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_38("Awesome Solo!");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 6 - this.songStats_0.int_10; i >= 0; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_71())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_35("debug_fps");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 4; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_14())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_63(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_27(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_25(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_5("charter");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Medium;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_9() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)8;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GHLBass, genum12_, this.songStats_0.method_25(), this.songStats_0.method_11(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_7(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_35("keys");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00025D54 File Offset: 0x00023F54
	private void method_29()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1461f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_7())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Guitar Coop"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Tried to play sound for channel {0}[{1}] but handle was null!"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("MSAA Level"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("NowPlaying"));
				}
				else if (gclass.player_0.GetButtonDown(8) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("_ENDOFSONG"));
				}
				else if (gclass.player_0.GetButtonDown(2) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17(" ("));
				}
			}
		}
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00025F60 File Offset: 0x00024160
	private void method_30()
	{
		FadeBehaviour.fadeBehaviour_0.method_11(193f, 1487f);
		GlobalVariables.instance.method_92(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_9(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + "Charter" + GlobalVariables.instance.songSpeed.String_1 + "";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Problem deleting profile file", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 0 || !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_16("/");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 8 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_62())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_17("Problem writing score file: ");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 7; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_17())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_29(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_13(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_21("song");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)4;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_7() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)8;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)6;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Rhythm, genum12_, this.songStats_0.method_34(), this.songStats_0.method_44(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_25(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_35("%g");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00026414 File Offset: 0x00024614
	private void method_31()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1392f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_17())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("lyric"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("game"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("B: 00:00:00"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("None"));
				}
				else if (gclass.player_0.GetButtonDown(8) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("diff_guitar"));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0(" "));
				}
			}
		}
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00026620 File Offset: 0x00024820
	private void method_32()
	{
		FadeBehaviour.fadeBehaviour_0.method_6(373f, 1824f);
		GlobalVariables.instance.method_108(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_33(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_23())
		{
			text = text + "?" + GlobalVariables.instance.songSpeed.method_26() + "Error reading profile file!";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("-", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 0 && GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_42("path");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 6 - this.songStats_0.int_10; i >= 0; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_22())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_11("READING CACHE...");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 5; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_19())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_37(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_7(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_35("guitar");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)6;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_14() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)5;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Guitar, genum12_, this.songStats_0.method_2(), this.songStats_0.method_33(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_7(", ");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00026AD4 File Offset: 0x00024CD4
	private void method_33()
	{
		FadeBehaviour.fadeBehaviour_0.method_26(576f, 116f);
		GlobalVariables.instance.method_37(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_33(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_6())
		{
			text = text + "has_bots" + GlobalVariables.instance.songSpeed.method_1() + "playlist_track";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Default", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 0 && !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_38("master_volume");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 1 - this.songStats_0.int_10; i >= 1; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_62())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_17("Press Enter to confirm");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 7; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_4())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_70(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_10(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_19(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_17("[Events]");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Hard;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_4() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Expert;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)6;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Band, genum12_, this.songStats_0.method_5(), this.songStats_0.method_1(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_20(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_38("rhythm");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00026F88 File Offset: 0x00025188
	private void method_34()
	{
		FadeBehaviour.fadeBehaviour_0.method_26(532f, 76f);
		GlobalVariables.instance.method_92(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_21(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_0())
		{
			text = text + "" + GlobalVariables.instance.songSpeed.method_28() + "Artist";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("Lyrics", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 1 && GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_2("Expert");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 6 - this.songStats_0.int_10; i >= 1; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_62())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_36("drums");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 4; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_9())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_33(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_13(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_40(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_16("Video Start Time");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)7;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_7() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)4;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)6;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Guitar, genum12_, this.songStats_0.method_30(), this.songStats_0.method_23(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_19(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_46("Rhythm Guitar");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0002743C File Offset: 0x0002563C
	private void method_35()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 18f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_19())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("lowlatency_enabled"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Main Menu"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Audio Backend"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Menu Music"));
				}
				else if (gclass.player_0.GetButtonDown(5) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25(""));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("menu_volume"));
				}
			}
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00027648 File Offset: 0x00025848
	private void method_36()
	{
		FadeBehaviour.fadeBehaviour_0.method_13(1235f, 112f);
		GlobalVariables.instance.method_108(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_21(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + "MMMM dd, yyyy" + GlobalVariables.instance.songSpeed.method_28() + "</color>";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("[", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 0 && GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_11("PreviewStart = [\\-\\+]?\\d+(\\.\\d+)?");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 5 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_71())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_2("OK");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 0)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 6; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_2())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_73(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_12(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_30(" - ");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)5;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_18() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Expert;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)7;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GuitarCoop, genum12_, this.songStats_0.method_5(), this.songStats_0.method_23(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_13("Type the setlist name");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00027AFC File Offset: 0x00025CFC
	private void method_37()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1219f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_11())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("volume"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("gem_size"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Tried to play sound for channel {0}[{1}] but handle was null!"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("/songs.txt"));
				}
				else if (gclass.player_0.GetButtonDown(2) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("None"));
				}
				else if (gclass.player_0.GetButtonDown(0) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24(" ("));
				}
			}
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00027D08 File Offset: 0x00025F08
	private void method_38()
	{
		FadeBehaviour.fadeBehaviour_0.method_6(1771f, 116f);
		GlobalVariables.instance.method_108(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_36(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_23())
		{
			text = text + "Discord: disconnect {0}: {1}" + GlobalVariables.instance.songSpeed.method_1() + "Instrument";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("'='", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 1 || GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_15("<color=#FFFF04FF>");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(true);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 8 - this.songStats_0.int_10; i >= 0; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_22())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_30("Streamer Settings");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 2; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_18())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_17(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_16(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_35("enable_lyrics");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Medium;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_15() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)5;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)8;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Keys, genum12_, this.songStats_0.method_43(), this.songStats_0.method_21(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_41("Close");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x000281BC File Offset: 0x000263BC
	private void method_39()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1687f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_5())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = true;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Genre"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Unknown Year"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Name = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Quit"));
				}
				else if (gclass.player_0.GetButtonDown(8) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Tried to play sound for channel {0}[{1}] but handle was null!"));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Enable Lanes"));
				}
			}
		}
	}

	// Token: 0x06000262 RID: 610 RVA: 0x000283C8 File Offset: 0x000265C8
	private void method_40()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 143f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_5())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("6 Fret Lead Guitar"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("%p"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("\r\n"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Expert"));
				}
				else if (gclass.player_0.GetButtonDown(6) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("Easy"));
				}
				else if (gclass.player_0.GetButtonDown(4) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("^"));
				}
			}
		}
	}

	// Token: 0x06000263 RID: 611 RVA: 0x000285D4 File Offset: 0x000267D4
	private void method_41()
	{
		FadeBehaviour.fadeBehaviour_0.method_6(1203f, 294f);
		GlobalVariables.instance.method_108(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_38(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + "Song Videos" + GlobalVariables.instance.songSpeed.String_1 + "%p";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("drums_1", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 1 && !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_46("Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 8 - this.songStats_0.int_10; i >= 1; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_62())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_5("Medium");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 4; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_9())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_70(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_16(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_2("No");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)6;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_7() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Expert;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)7;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GHLBass, genum12_, this.songStats_0.method_34(), this.songStats_0.method_1(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_13(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_5("Create Setlist");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00028A88 File Offset: 0x00026C88
	private void method_42()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1293f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.Boolean_0)
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Ready"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24(""));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("album.jpg"));
					}
				}
				else if (gclass.player_0.GetButtonDown(0) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("bad_note3"));
				}
				else if (gclass.player_0.GetButtonDown(3) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24(""));
				}
				else if (gclass.player_0.GetButtonDown(2) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("%g"));
				}
			}
		}
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00028C94 File Offset: 0x00026E94
	private void method_43()
	{
		FadeBehaviour.fadeBehaviour_0.method_26(214f, 1569f);
		GlobalVariables.instance.method_92(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_1(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_6())
		{
			text = text + "Controller Poll Rate" + GlobalVariables.instance.songSpeed.method_1() + "volume";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("song", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 0 && GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_2("There was a problem saving the file");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 3 - this.songStats_0.int_10; i >= 1; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_97())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_38("6 Fret Lead Guitar");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 0; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_9())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_73(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_10(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_13(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_5("Rhythm Guitar");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)4;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_18() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)5;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)4;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GHLBass, genum12_, this.songStats_0.method_30(), this.songStats_0.method_33(), (byte)this.songStats_0.int_10, 0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_7(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_16("part bass");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = false;
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00029148 File Offset: 0x00027348
	private void method_44()
	{
		FadeBehaviour.fadeBehaviour_0.method_6(1818f, 1719f);
		GlobalVariables.instance.method_49(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_33(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_6())
		{
			text = text + "Press ENTER to search" + GlobalVariables.instance.songSpeed.method_28() + "Album";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("{{ Chunk = {0}, Number = {1} }}", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 1 || GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_2("Bot");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = true;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 7 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_97())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_5("0%");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 6; j++)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_17())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_33(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_12(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.CurrentValue);
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_42("drums");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Expert;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_17() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GHLGuitar, genum12_, this.songStats_0.method_22(), this.songStats_0.method_33(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_13(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_15("");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x06000267 RID: 615 RVA: 0x000295FC File Offset: 0x000277FC
	private void method_45()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1848f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_4())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Main Menu"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Prefabs/Gameplay/Notes/open_sustain_glow"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("flames"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("song"));
				}
				else if (gclass.player_0.GetButtonDown(7) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("setlistwarning"));
				}
				else if (gclass.player_0.GetButtonDown(6) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Error while parsing \"{0}\": {1} "));
				}
			}
		}
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00029808 File Offset: 0x00027A08
	private void method_46()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 976f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = true;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("6 Fret Guitar"));
						}
						else
						{
							GlobalVariables.instance.int_3 += 0;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("FULL COMBO"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("background_video"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Couldn't write badsongs.txt"));
				}
				else if (gclass.player_0.GetButtonDown(7) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Discord: error {0}: {1}"));
				}
				else if (gclass.player_0.GetButtonDown(5) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("Percentage"));
				}
			}
		}
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00029A14 File Offset: 0x00027C14
	private void method_47()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 1180f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_7())
			{
				if (gclass.player_0.GetButtonDown(0))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Practicing..."));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("{0}"));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = true;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("Unknown Album"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("isEOL"));
				}
				else if (gclass.player_0.GetButtonDown(6) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17(""));
				}
				else if (gclass.player_0.GetButtonDown(3) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42(""));
				}
			}
		}
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00029C20 File Offset: 0x00027E20
	private void method_48()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.float_0 < 432f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15())
			{
				if (gclass.player_0.GetButtonDown(1))
				{
					if (GlobalVariables.instance.isPlayingSetlist)
					{
						if (this.bool_1)
						{
							GlobalVariables.instance.returnToSongSelect = false;
							GlobalVariables.instance.isPlayingSetlist = false;
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Quit"));
						}
						else
						{
							GlobalVariables.instance.int_3++;
							GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
							base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9(""));
						}
					}
					else
					{
						GlobalVariables.instance.returnToSongSelect = false;
						base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Play Count"));
					}
				}
				else if (gclass.player_0.GetButtonDown(1) && GlobalVariables.instance.isPlayingSetlist)
				{
					GlobalVariables.instance.returnToSongSelect = true;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("song"));
				}
				else if (gclass.player_0.GetButtonDown(1) && !GlobalVariables.instance.isPlayingSetlist)
				{
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("<color=#FFA300>"));
				}
				else if (gclass.player_0.GetButtonDown(6) && this.bool_0)
				{
					GlobalVariables.instance.isPracticeEnabled = false;
					base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("Enable"));
				}
			}
		}
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00029E2C File Offset: 0x0002802C
	private void method_49()
	{
		FadeBehaviour.fadeBehaviour_0.method_13(760f, 333f);
		GlobalVariables.instance.method_49(false);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_29(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = text + ".mp3" + GlobalVariables.instance.songSpeed.method_26() + "Are you sure you want to quit?";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("PreviewEnd = [\\-\\+]?\\d+(\\.\\d+)?", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 == 0 && !GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_35("Star Animation FPS");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 1)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(false);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(false);
		}
		else
		{
			this.quickplay.SetActive(true);
		}
		for (int i = 4 - this.songStats_0.int_10; i >= 0; i--)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_71())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_5("No");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 1; j < 8; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_4())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_34(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_16(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_16("_");
				}
			}
			else
			{
				Song.GEnum17 genum = Song.GEnum17.Medium;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Medium;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_11() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)7;
					break;
				case Song.GEnum17.Hard:
					genum12_ = (GStruct2.GEnum12)4;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.GHLBass, genum12_, this.songStats_0.method_43(), this.songStats_0.method_44(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_25());
				if (GlobalVariables.instance.currentSongEntry.method_18(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_2("No");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0002A2E0 File Offset: 0x000284E0
	private void method_50()
	{
		FadeBehaviour.fadeBehaviour_0.method_13(496f, 1168f);
		GlobalVariables.instance.method_11(true);
		this.songStats_0 = GlobalVariables.instance.GetComponent<SongStats>();
		DiscordController.discordController_0.method_29(this.songStats_0.int_10);
		string text = GlobalVariables.instance.currentSongEntry.songName;
		if (!GlobalVariables.instance.songSpeed.method_6())
		{
			text = text + "</color>" + GlobalVariables.instance.songSpeed.method_1() + "%";
		}
		this.songName.text = text;
		this.artistName.text = GlobalVariables.instance.currentSongEntry.artistName;
		this.score.text = string.Format("guitar", this.songStats_0.int_0);
		this.bool_0 = (GlobalVariables.instance.int_1 != 0 || GlobalVariables.instance.isPlayingSetlist);
		this.savingText.text = GClass4.gclass4_0.method_21("Rename Setlist");
		if (GlobalVariables.instance.currentSongEntry.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.iconName))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.iconName];
		}
		else if (GlobalVariables.instance.currentSongEntry.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(GlobalVariables.instance.currentSongEntry.charterName.ToLower()))
		{
			this.icon.sprite = GlobalVariables.instance.gameIcon_Sprites[GlobalVariables.instance.currentSongEntry.charterName.ToLower()];
		}
		else
		{
			this.icon.sprite = this.defaultAlbumArt;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count - 0)
			{
				this.bool_1 = false;
				this.setlist_end.SetActive(true);
			}
			else
			{
				this.setlist.SetActive(false);
			}
		}
		else if (this.bool_0)
		{
			this.quickplayPractice.SetActive(true);
		}
		else
		{
			this.quickplay.SetActive(false);
		}
		for (int i = 4 - this.songStats_0.int_10; i >= 1; i -= 0)
		{
			UnityEngine.Object.Destroy(this.starObjects[i]);
		}
		if (GlobalVariables.instance.method_71())
		{
			this.botSaveWarning.text = GClass4.gclass4_0.method_16("");
		}
		else if (!GlobalVariables.instance.failed)
		{
			if (GlobalVariables.instance.int_1 == 1)
			{
				CHPlayer gclass = null;
				int j;
				for (j = 0; j < 8; j += 0)
				{
					gclass = GlobalVariables.instance.playerList[j];
					if (gclass.method_4())
					{
						break;
					}
				}
				GStruct3 gstruct3_ = new GStruct3(GlobalVariables.instance.method_33(), (GStruct2.GEnum12)gclass.gclass10_0.genum17_0, (byte)this.songStats_0.int_2[j], this.songStats_0.method_37(j), (byte)this.songStats_0.int_10, (byte)gclass.gclass10_0.genum6_0, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_15(".jpg");
				}
			}
			else
			{
				Song.GEnum17 genum = (Song.GEnum17)5;
				GStruct2.GEnum12 genum12_ = GStruct2.GEnum12.Easy;
				foreach (CHPlayer gclass2 in GlobalVariables.instance.playerList)
				{
					if (gclass2.method_19() && gclass2.gclass10_0.genum17_0 < genum)
					{
						genum = gclass2.gclass10_0.genum17_0;
					}
				}
				switch (genum)
				{
				case Song.GEnum17.Expert:
					genum12_ = (GStruct2.GEnum12)6;
					break;
				case Song.GEnum17.Hard:
					genum12_ = GStruct2.GEnum12.Easy;
					break;
				case Song.GEnum17.Medium:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				case Song.GEnum17.Easy:
					genum12_ = GStruct2.GEnum12.Medium;
					break;
				}
				GStruct3 gstruct3_2 = new GStruct3(GStruct2.GEnum11.Drums, genum12_, this.songStats_0.method_2(), this.songStats_0.method_42(), (byte)this.songStats_0.int_10, 1, this.songStats_0.int_0, (short)GlobalVariables.instance.songSpeed.method_5());
				if (GlobalVariables.instance.currentSongEntry.method_30(gstruct3_2))
				{
					this.botSaveWarning.text = GClass4.gclass4_0.method_42(" (");
				}
			}
		}
		SongDirectory.smethod_15(SongDirectory.String_0);
		this.savingText.enabled = true;
	}

	// Token: 0x0400006D RID: 109
	public GameObject gameObject_0;

	// Token: 0x0400006E RID: 110
	private SongStats songStats_0;

	// Token: 0x0400006F RID: 111
	private float float_0;

	// Token: 0x04000070 RID: 112
	[SerializeField]
	private Text songName;

	// Token: 0x04000071 RID: 113
	[SerializeField]
	private Text artistName;

	// Token: 0x04000072 RID: 114
	[SerializeField]
	private Text score;

	// Token: 0x04000073 RID: 115
	[SerializeField]
	private Text botSaveWarning;

	// Token: 0x04000074 RID: 116
	[SerializeField]
	private Text savingText;

	// Token: 0x04000075 RID: 117
	[SerializeField]
	private Image icon;

	// Token: 0x04000076 RID: 118
	[SerializeField]
	private Sprite defaultAlbumArt;

	// Token: 0x04000077 RID: 119
	[SerializeField]
	private GameObject[] starObjects;

	// Token: 0x04000078 RID: 120
	private bool bool_0;

	// Token: 0x04000079 RID: 121
	private bool bool_1;

	// Token: 0x0400007A RID: 122
	[SerializeField]
	private GameObject quickplay;

	// Token: 0x0400007B RID: 123
	[SerializeField]
	private GameObject quickplayPractice;

	// Token: 0x0400007C RID: 124
	[SerializeField]
	private GameObject setlist;

	// Token: 0x0400007D RID: 125
	[SerializeField]
	private GameObject setlist_end;
}
