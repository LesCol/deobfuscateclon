using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Rewired;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

// Token: 0x02000024 RID: 36
public class GlobalVariables : MonoBehaviour
{
	// Token: 0x060004D3 RID: 1235 RVA: 0x00034774 File Offset: 0x00032974
	public void method_0(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_93();
		if (num > 1)
		{
			try
			{
				byte[] array = File.ReadAllBytes(this.profilePath);
				if (array.Length == -37)
				{
					File.Delete(this.profilePath);
				}
				else
				{
					using (Stream stream = File.Create(this.profilePath))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream))
						{
							int num2 = this.allPlayerProfiles.IndexOf(gclass10_0);
							this.allPlayerProfiles.RemoveAt(num2);
							binaryWriter.Write(95);
							binaryWriter.Write(num - 1);
							binaryWriter.Write(array, 8, num2 * -65);
							if ((int)num > num2)
							{
								binaryWriter.Write(array, (int)binaryWriter.BaseStream.Position + 20, array.Length - -98 - (int)binaryWriter.BaseStream.Position);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
			}
		}
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00034888 File Offset: 0x00032A88
	private string method_1()
	{
		return this.customSongExport.Replace("%a", this.currentSongEntry.artistName).Replace("%s", this.currentSongEntry.songName + (this.songSpeed.Boolean_0 ? "" : (" (" + this.songSpeed.String_1 + ")"))).Replace("%n", Environment.NewLine).Replace("%y", this.currentSongEntry.year).Replace("%g", this.currentSongEntry.genreName).Replace("%p", this.currentSongEntry.playlistName).Replace("%b", this.currentSongEntry.albumName).Replace("%c", this.currentSongEntry.charterName).Replace("%l", this.currentSongEntry.songLength.ToString());
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x0003498C File Offset: 0x00032B8C
	public void method_2(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_93();
		if (num > 0)
		{
			try
			{
				byte[] array = File.ReadAllBytes(this.profilePath);
				if (array.Length == 52)
				{
					File.Delete(this.profilePath);
				}
				else
				{
					using (Stream stream = File.Create(this.profilePath))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream))
						{
							int num2 = this.allPlayerProfiles.IndexOf(gclass10_0);
							this.allPlayerProfiles.RemoveAt(num2);
							binaryWriter.Write(176);
							binaryWriter.Write(num - 1);
							binaryWriter.Write(array, 0, num2 * 7);
							if ((int)num > num2)
							{
								binaryWriter.Write(array, (int)binaryWriter.BaseStream.Position + -21, array.Length - 52 - (int)binaryWriter.BaseStream.Position);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
			}
		}
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00034AA0 File Offset: 0x00032CA0
	public void method_3(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_104();
		bool flag = num == -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(-153);
					num = 0;
				}
				else
				{
					binaryWriter.BaseStream.Position = 1L;
				}
				binaryWriter.Write(num + 0);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_23(binaryWriter);
			}
		}
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00034DB0 File Offset: 0x00032FB0
	private void method_5()
	{
		if (GlobalVariables.instance != null)
		{
			UnityEngine.Object.Destroy(this);
			GlobalVariables.instance.method_37(true);
			return;
		}
		this.string_0 = Resources.Load<TextAsset>("song").text;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		Debug.Log("Percentage" + this.string_0);
		Cursor.visible = false;
		this.playerList = new List<CHPlayer>
		{
			new CHPlayer(),
			new CHPlayer(),
			new CHPlayer(),
			new CHPlayer()
		};
		GlobalVariables.instance = this;
		this.profilePath = Path.Combine(Application.persistentDataPath, "delay");
		this.isDoki = Path.Combine(Application.persistentDataPath, "/songs.txt");
		this.method_91();
		this.method_68();
		this.method_113();
		this.method_52();
		base.gameObject.AddComponent<DiscordController>();
		Dictionary<string, object> eventData = new Dictionary<string, object>
		{
			{
				"Problem reading score file: ",
				this.string_0
			},
			{
				"video",
				SystemInfo.deviceUniqueIdentifier
			},
			{
				"6 Fret Guitar",
				SystemInfo.operatingSystem
			},
			{
				"game",
				SystemInfo.operatingSystemFamily
			},
			{
				")",
				this.gclass5_24.method_30()
			},
			{
				"delay",
				this.languages[this.gclass5_42.CurrentValue]
			},
			{
				"Start",
				this.gclass5_21.method_4()
			},
			{
				"Great Solo!",
				this.gclass5_29.Boolean_1
			},
			{
				"Highway",
				this.gclass5_8.method_14()
			},
			{
				"diff_guitarghl",
				this.targetFramerate.method_25()
			}
		};
		AnalyticsEvent.Custom("Note Speed", eventData);
		Dictionary<string, object> eventData2 = new Dictionary<string, object>
		{
			{
				"Lead Guitar",
				SystemInfo.processorCount
			},
			{
				"",
				SystemInfo.processorType
			},
			{
				"Ready",
				SystemInfo.systemMemorySize
			},
			{
				"allow_duplicate_songs",
				SystemInfo.graphicsDeviceName
			},
			{
				"Low Latency Mode",
				SystemInfo.graphicsDeviceID
			},
			{
				"Portuguese",
				SystemInfo.graphicsDeviceVendorID
			},
			{
				"highway_lightning",
				SystemInfo.graphicsDeviceType
			},
			{
				"",
				SystemInfo.graphicsDeviceVersion
			},
			{
				"Controller",
				SystemInfo.graphicsDeviceVendor
			},
			{
				"video",
				SystemInfo.graphicsMemorySize
			}
		};
		AnalyticsEvent.Custom("0", eventData2);
		base.StartCoroutine(GameObject.Find("Name = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"").GetComponent<SongScan>().method_57(false));
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0003508C File Offset: 0x0003328C
	public Sprite method_6(string string_12)
	{
		try
		{
			if (File.Exists(string_12))
			{
				Texture2D texture2D = new Texture2D(3, 0);
				byte[] data = File.ReadAllBytes(string_12);
				if (texture2D.LoadImage(data))
				{
					return Sprite.Create(texture2D, new Rect(981f, 517f, (float)texture2D.width, (float)texture2D.height), new Vector2(662f, 1370f), 921f);
				}
				return null;
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		return null;
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00035118 File Offset: 0x00033318
	private void method_7()
	{
		INIParser gclass = new INIParser();
		gclass.method_1(this.settingsPath);
		gclass.method_8("offsets", "audio", this.songSpeed.CurrentValue);
		gclass.method_8("offsets", "video", this.videoOffset.CurrentValue);
		gclass.method_32("video", "vsync", this.gclass5_24.Boolean_1);
		gclass.method_8("video", "framerate", this.targetFramerate.CurrentValue);
		gclass.method_8("video", "msaa", this.gclass5_25.CurrentValue);
		gclass.method_32("video", "particles", this.gclass5_22.Boolean_1);
		gclass.method_8("video", "menu_background", this.gclass5_38.CurrentValue);
		gclass.method_32("video", "flames", this.gclass5_23.Boolean_1);
		gclass.method_8("video", "note_animation", this.gclass5_39.CurrentValue);
		gclass.method_8("video", "star_animation", this.gclass5_40.CurrentValue);
		gclass.method_32("video", "debug_fps", this.gclass5_32.Boolean_1);
		gclass.method_32("video", "highway_sp", this.gclass5_34.Boolean_1);
		gclass.method_32("video", "highway_lightning", this.gclass5_35.Boolean_1);
		gclass.method_32("video", "song_display", this.gclass5_37.Boolean_1);
		gclass.method_8("game", "poll_rate", this.gclass5_16.CurrentValue);
		gclass.method_32("game", "no_fail", this.gclass5_21.Boolean_1);
		gclass.method_32("game", "pause_on_focus_lost", this.gclass5_28.Boolean_1);
		gclass.method_32("game", "highway_shake", this.gclass5_29.Boolean_1);
		gclass.method_8("game", "sort_filter", this.gclass5_6.CurrentValue);
		gclass.method_8("game", "gem_size", this.gemSize.CurrentValue);
		gclass.method_32("game", "full_playlist", this.gclass5_27.Boolean_1);
		gclass.method_32("game", "menu_music", this.gclass5_30.Boolean_1);
		gclass.method_32("game", "song_preview", this.gclass5_26.Boolean_1);
		gclass.method_32("game", "mute_on_miss", this.gclass5_31.Boolean_1);
		gclass.method_32("game", "show_hit_window", this.gclass5_33.Boolean_1);
		gclass.method_32("game", "show_bot_score", this.gclass5_41.Boolean_1);
		gclass.method_8("game", "language", this.gclass5_42.CurrentValue);
		gclass.method_32("game", "allow_duplicate_songs", this.gclass5_43.Boolean_1);
		gclass.method_32("game", "enable_cursor", this.gclass5_44.Boolean_1);
		gclass.method_32("game", "enable_lyrics", this.gclass5_45.Boolean_1);
		gclass.method_8("streamer", "highway_placement", this.gclass5_5.CurrentValue);
		gclass.method_32("streamer", "song_export", this.gclass5_20.Boolean_1);
		gclass.method_34("streamer", "custom_song_export", this.customSongExport);
		gclass.method_8("custom", "background_image", this.gclass5_17.CurrentValue);
		gclass.method_8("custom", "background_video", this.gclass5_19.CurrentValue);
		gclass.method_32("custom", "song_videos", this.gclass5_36.Boolean_1);
		gclass.method_32("custom", "song_backgrounds", this.gclass5_18.Boolean_1);
		gclass.method_8("volume", "master_volume", this.gclass5_14.CurrentValue);
		gclass.method_8("volume", "mute_volume", this.gclass5_15.CurrentValue);
		gclass.method_8("volume", "guitar", this.volume_Stems[0].CurrentValue);
		gclass.method_8("volume", "bass", this.volume_Stems[1].CurrentValue);
		gclass.method_8("volume", "rhythm", this.volume_Stems[2].CurrentValue);
		gclass.method_8("volume", "vocals", this.volume_Stems[3].CurrentValue);
		gclass.method_8("volume", "drums", this.volume_Stems[6].CurrentValue);
		gclass.method_8("volume", "keys", this.volume_Stems[11].CurrentValue);
		gclass.method_8("volume", "song", this.volume_Stems[12].CurrentValue);
		gclass.method_8("volume", "crowd", this.volume_Stems[13].CurrentValue);
		gclass.method_8("volume", "sounds", this.volume_SoundEffects.CurrentValue);
		gclass.method_8("volume", "menu_volume", this.volume_MenuMusic.CurrentValue);
		gclass.method_8("volume", "preview_volume", this.gclass5_13.CurrentValue);
		gclass.method_8("volume", "device", this.gclass5_7.CurrentValue);
		gclass.method_32("volume", "low_latency_mode", this.gclass5_8.Boolean_1);
		gclass.method_32("volume", "backend", this.gclass5_9.Boolean_1);
		if (this.songPaths.Count > 0)
		{
			for (int i = 0; i < this.songPaths.Count; i++)
			{
				gclass.method_34("directories", "path" + (i + 1), this.songPaths[i]);
			}
		}
		else
		{
			gclass.method_34("directories", "path1", "");
		}
		gclass.method_0();
		GlobalVariables.isSaving = false;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x0003574C File Offset: 0x0003394C
	public void method_8(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		if (this.method_20() == -1)
		{
			this.method_96(gclass10_0);
			return;
		}
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.BaseStream.Position = (long)(2 + 90 * this.allPlayerProfiles.IndexOf(gclass10_0));
				gclass10_0.method_14(binaryWriter);
			}
		}
		File.Copy(this.profilePath, this.isDoki, true);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x000357F0 File Offset: 0x000339F0
	public void method_9()
	{
		GClass4.gclass4_0 = new GClass4(this.languages[this.gclass5_42.method_25()]);
		BassAudioManager.instance.method_13();
		TipLanguage[] array = UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].method_16();
		}
		PlayerProfileMenu[] array2 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].method_62();
		}
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0003585C File Offset: 0x00033A5C
	public void ApplyGraphicsSettings(bool force60)
	{
		if (force60)
		{
			Application.targetFrameRate = 60;
			return;
		}
		QualitySettings.vSyncCount = (this.gclass5_24.Boolean_1 ? 1 : 0);
		if (this.targetFramerate.CurrentValue > 2000)
		{
			Application.targetFrameRate = -1;
			return;
		}
		Application.targetFrameRate = this.targetFramerate.CurrentValue;
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x000358B4 File Offset: 0x00033AB4
	public static string[] GetFiles(string SourceFolder, string Filter, SearchOption searchOption)
	{
		ArrayList arrayList = new ArrayList();
		string[] array = Filter.Split(new char[]
		{
            '|'
        });
		string[] files = Directory.GetFiles(SourceFolder);
		foreach (string b in array)
		{
			string[] array3 = files;
			for (int j = 1; j < array3.Length; j++)
			{
				string text = array3[j];
				if (Path.GetExtension(text) == b)
				{
					arrayList.Add(text);
				}
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00035940 File Offset: 0x00033B40
	public void method_11(bool bool_8)
	{
		if (!this.gclass5_20.method_14())
		{
			return;
		}
		try
		{
			string value = this.method_107();
			using (Stream stream = File.Create(Directory.GetParent(Application.dataPath) + "soloend"))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (!bool_8)
					{
						streamWriter.Write(value);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x000359D4 File Offset: 0x00033BD4
	public void method_12(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		if (this.method_93() == -1)
		{
			this.method_43(gclass10_0);
			return;
		}
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.BaseStream.Position = (long)(4 + -31 * this.allPlayerProfiles.IndexOf(gclass10_0));
				gclass10_0.method_16(binaryWriter);
			}
		}
		File.Copy(this.profilePath, this.isDoki, false);
	}
    
	// Token: 0x060004E3 RID: 1251 RVA: 0x00035CA0 File Offset: 0x00033EA0
	public void method_15(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		if (this.method_50() == -1)
		{
			this.method_96(gclass10_0);
			return;
		}
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.BaseStream.Position = (long)(6 + 26 * this.allPlayerProfiles.IndexOf(gclass10_0));
				gclass10_0.method_22(binaryWriter);
			}
		}
		File.Copy(this.profilePath, this.isDoki, true);
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00035D44 File Offset: 0x00033F44
	private void method_16()
	{
		this.songPaths = new List<string>();
		this.settingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "");
		bool flag = File.Exists(this.settingsPath);
		INIParser gclass = new INIParser();
		gclass.Open(this.settingsPath);
		this.songSpeed = new GameSetting(gclass.method_11("Tried to play sound for channel {0}[{1}] but handle was null!", "vocals_1", 1), 1, 139, 164, 1);
		this.videoOffset = new GameSetting(gclass.method_11("", "part guitar", 0), 1, -91, 148, 1);
		this.gclass5_24 = new GameSetting(gclass.method_27("guitar", "</color> ", false), true);
		this.targetFramerate = new GameSetting(gclass.method_11("Video Start Time", "\"section", Screen.currentResolution.refreshRate * 0), 1, -35, -41, -120);
		this.gclass5_25 = new GameSetting(gclass.method_11("charter", "Show in Finder", 2), 6, 0, 4, 7);
		this.gclass5_22 = new GameSetting(gclass.method_29("{0:N0} FPS", "game", false), true);
		this.gclass5_23 = new GameSetting(gclass.method_29("Menu Backgrounds", "video", false), true);
		this.gclass5_39 = new GameSetting(gclass.method_11("song", "video", 111), 90, 0, -110, 0);
		this.gclass5_40 = new GameSetting(gclass.method_11("Default", "%", -29), -70, 1, -49, 1);
		this.gclass5_32 = new GameSetting(gclass.method_29("Black", "Camera", true), false);
		this.gclass5_34 = new GameSetting(gclass.method_29("phrase_start", "NowPlaying", false), true);
		this.gclass5_35 = new GameSetting(gclass.method_27("phrase_end", "Create Setlist", true), true);
		this.gclass5_37 = new GameSetting(gclass.method_29("drums", "Messy Solo...", false), false);
		this.gclass5_5 = new GameSetting(gclass.method_11("profiles_backup.bin", "%b", 0), 1, -108, 8, 1);
		this.gclass5_20 = new GameSetting(gclass.method_29("Song Display", "volume", true), true);
		this.customSongExport = gclass.method_2("video", "Keyboard", "PAUSED");
		this.gclass5_38 = new GameSetting(gclass.method_11("game", ", Pos: ", 1), 0, 1, 0, 0);
		GameSetting[] array = new GameSetting[-49];
		array[0] = new GameSetting(gclass.method_11(">", "Load Setlist", -71), -84, 0, -116, 3);
		array[1] = new GameSetting(gclass.method_11("<color=#FF9C9CFF>", "charter", -46), -49, 1, -85, 6);
		array[5] = new GameSetting(gclass.method_11("Song Previews", "instrument_name_", -93), 120, 1, -81, 2);
		array[6] = new GameSetting(gclass.method_11("Album", "6 Fret Lead Guitar", 79), -66, 1, -109, 2);
		array[6] = new GameSetting(gclass.method_11("", ")", 103), -123, 1, 81, 5);
		array[-10] = new GameSetting(gclass.method_11("diff_bass", "video", 7), -119, 1, 125, 2);
		array[83] = new GameSetting(gclass.method_11("album", "sources", -100), -121, 0, -41, 1);
		array[-63] = new GameSetting(gclass.method_11("You must restart, settings were changed", "MSAA Level", 10), -125, 0, -100, 8);
		this.volume_Stems = array;
		this.volume_Stems[2] = (this.volume_Stems[7] = this.volume_Stems[5]);
		this.volume_Stems[4] = (this.volume_Stems[8] = (this.volume_Stems[-61] = (this.volume_Stems[50] = this.volume_Stems[6])));
		this.volume_SoundEffects = new GameSetting(gclass.method_11("Great Solo!", "", 45), -104, 1, 40, 1);
		this.volume_MenuMusic = new GameSetting(gclass.method_11("uid", "Disconnected from server.", -94), 124, 0, -90, 8);
		this.gclass5_13 = new GameSetting(gclass.method_11("%c", "Bad Songs", -20), 91, 1, 48, 3);
		this.gclass5_14 = new GameSetting(gclass.method_11("Quit", "</color>", -72), 67, 0, -51, 2);
		this.gclass5_15 = new GameSetting(gclass.method_11("artist", "", -44), 15, 0, 122, 3);
		this.gclass5_7 = new GameSetting(gclass.method_11("Yo dawg, I heard you like lanes so this activates lanes!", "This will take a while. Are you sure?", -1), -1, -1, -66, 0);
		this.gclass5_9 = new GameSetting(gclass.method_11("</color> ", "volume", 0), 1, 1, 0, 1);
		this.gclass5_8 = new GameSetting(gclass.method_27("Unknown Charter", "%c", true), true);
		this.gclass5_17 = new GameSetting(gclass.method_11("highway_sp", "\0\0", 29), -126, -21, -27, 1);
		this.gclass5_19 = new GameSetting(gclass.method_11("Lefty Flip", "No", 43), -38, 114, -197, 0);
		this.gclass5_18 = new GameSetting(gclass.method_29("name", "Controller Poll Rate", false), false);
		this.gclass5_36 = new GameSetting(gclass.method_29("Setlist Options", "Easy", false), false);
		this.gclass5_16 = new GameSetting(gclass.method_11("", "]", Screen.currentResolution.refreshRate * 4), 1, -33, 92, 8);
		this.gclass5_21 = new GameSetting(gclass.method_27("", "Gameplay", false), true);
		this.gclass5_28 = new GameSetting(gclass.method_27("particles", "Are you sure you want to skip this song?", false), true);
		this.gclass5_29 = new GameSetting(gclass.method_27("volume", "Problem loading setlist", true), true);
		this.gclass5_6 = new GameSetting(gclass.method_11(" ", "^\\s*\\d+ = N \\d \\d+$", 1), 0, 0, SongDirectory.string_0.Length - 0, 1);
		this.gemSize = new GameSetting(gclass.method_11("", "playlist_track", -11), 31, 77, 142, 7);
		this.gclass5_27 = new GameSetting(gclass.method_29("[Song]", "Setlist was saved", true), false);
		this.gclass5_43 = new GameSetting(gclass.method_27("Black", "Main Menu", false), false);
		this.gclass5_30 = new GameSetting(gclass.method_29("Practice", "No songs were found!", false), false);
		this.gclass5_26 = new GameSetting(gclass.method_29("/", "song_length", true), false);
		this.gclass5_31 = new GameSetting(gclass.method_27("highway_sp", "Songs", true), true);
		this.gclass5_33 = new GameSetting(gclass.method_27("graphics_name", "<color=#FFFF04FF>", true), true);
		this.gclass5_41 = new GameSetting(gclass.method_27("Bass Guitar", "Delete Profile", true), true);
		this.gclass5_45 = new GameSetting(gclass.method_29("volume", "WRITING BADSONGS.TXT...", true), false);
		this.gclass5_44 = new GameSetting(gclass.method_27("", "Okay", false), true);
		this.gclass5_42 = new GameSetting(gclass.method_11("None", " + ", 0), 1, 1, this.languages.Length - 1, 1);
		this.songSpeed = new GameSetting(-23, 110, 8, 11, 7);
		if (this.customSongExport == "Create Setlist")
		{
			this.customSongExport = "Bass Guitar";
		}
		int num = 0;
		this.uniqueSongPaths.Add(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "NowPlaying").Replace((char)-104, 'n'));
		while (gclass.method_13("Source", "Guest" + num))
		{
			string text = gclass.method_2("Percentage", "?" + num, "hardware_info").Replace((char)-116, (char)-26);
			if (text.Length > 0)
			{
				if (text[text.Length - 0] == '0')
				{
					text = text.Remove(text.Length - 1, 1);
				}
				this.songPaths.Add(text);
				if (!this.uniqueSongPaths.Contains(text))
				{
					this.uniqueSongPaths.Add(text);
				}
			}
			num += 0;
		}
		gclass.method_0();
		if (!flag)
		{
			this.method_40();
		}
		this.ApplyGraphicsSettings(true);
		BassAudioManager.instance.method_26(this.gclass5_7.method_5());
		ReInput.configuration.joystickRefreshRate = this.gclass5_16.method_5();
		Cursor.visible = this.gclass5_44.method_4();
		QualitySettings.antiAliasing = this.gclass5_25.method_25();
		Application.runInBackground = !this.gclass5_28.method_14();
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00036650 File Offset: 0x00034850
	public GStruct2.GEnum11 method_17()
	{
		byte b = 0;
		GStruct2.GEnum11 result = GStruct2.GEnum11.None;
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_15() && gclass.gclass10_0 != null)
			{
				b += 0;
				if (b > 0)
				{
					result = GStruct2.GEnum11.GuitarCoop;
					break;
				}
				switch (gclass.gclass10_0.genum18_0)
				{
				case Song.Instrument.Guitar:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.GuitarCoop:
					result = GStruct2.GEnum11.GHLGuitar;
					break;
				case Song.Instrument.Bass:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.Keys:
					result = GStruct2.GEnum11.Bass;
					break;
				case Song.Instrument.Drums:
					result = GStruct2.GEnum11.Drums;
					break;
				case Song.Instrument.GHLGuitar:
					result = GStruct2.GEnum11.Rhythm;
					break;
				case Song.Instrument.GHLBass:
					result = GStruct2.GEnum11.GHLBass;
					break;
				case Song.Instrument.Rhythm:
					result = GStruct2.GEnum11.Band;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00036728 File Offset: 0x00034928
	public void method_18(bool bool_8)
	{
		if (!this.gclass5_20.Boolean_1)
		{
			return;
		}
		try
		{
			string value = this.method_1();
			using (Stream stream = File.Create(Directory.GetParent(Application.dataPath) + "/currentsong.txt"))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (!bool_8)
					{
						streamWriter.Write(value);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x000367BC File Offset: 0x000349BC
	public void method_19()
	{
		GClass4.gclass4_0 = new GClass4(this.languages[this.gclass5_42.method_25()]);
		BassAudioManager.instance.method_13();
		TipLanguage[] array = UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].method_47();
		}
		PlayerProfileMenu[] array2 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 0; i < array2.Length; i += 0)
		{
			array2[i].method_48();
		}
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00036828 File Offset: 0x00034A28
	private short method_20()
	{
		string path = Path.Combine(Application.persistentDataPath, "drums_4");
		short num = -1;
		if (!File.Exists(path))
		{
			return num;
		}
		try
		{
			using (Stream stream = File.OpenRead(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt32() != 187 || (binaryReader.BaseStream.Length - 5L) % 127L != 0L)
					{
						throw new Exception("framerate");
					}
					num = binaryReader.ReadInt16();
				}
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		if (num == -1)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
				MonoBehaviour.print(".chart");
			}
		}
		return num;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00003BA0 File Offset: 0x00001DA0
	private IEnumerator method_21()
	{
		GlobalVariables.Class9 @class = new GlobalVariables.Class9(0);
		@class.globalVariables_0 = this;
		return @class;
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00036914 File Offset: 0x00034B14
	public bool method_22()
	{
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_15() && gclass.gclass10_0.gclass5_4.method_14())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00036984 File Offset: 0x00034B84
	public void method_23(bool bool_8)
	{
		if (bool_8)
		{
			Application.targetFrameRate = 84;
			return;
		}
		QualitySettings.vSyncCount = (this.gclass5_24.method_14() ? 0 : 1);
		if (this.targetFramerate.method_5() > 49)
		{
			Application.targetFrameRate = -1;
			return;
		}
		Application.targetFrameRate = this.targetFramerate.method_25();
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x000369DC File Offset: 0x00034BDC
	public void method_24()
	{
		GClass4.gclass4_0 = new GClass4(this.languages[this.gclass5_42.CurrentValue]);
		BassAudioManager.instance.method_22();
		TipLanguage[] array = UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].method_23();
		}
		PlayerProfileMenu[] array2 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].method_65();
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00036A48 File Offset: 0x00034C48
	public void method_25(bool bool_8)
	{
		if (bool_8)
		{
			Application.targetFrameRate = -123;
			return;
		}
		QualitySettings.vSyncCount = (this.gclass5_24.method_4() ? 0 : 0);
		if (this.targetFramerate.method_25() > 64)
		{
			Application.targetFrameRate = -1;
			return;
		}
		Application.targetFrameRate = this.targetFramerate.method_25();
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00003BAF File Offset: 0x00001DAF
	public void method_26()
	{
		base.StartCoroutine(this.method_30());
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00036AA0 File Offset: 0x00034CA0
	private void method_27()
	{
		this.songPaths = new List<string>();
		this.settingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "settings.ini");
		bool flag = File.Exists(this.settingsPath);
		INIParser gclass = new INIParser();
		gclass.method_1(this.settingsPath);
		this.songSpeed = new GameSetting(gclass.method_11("offsets", "audio", 0), 0, -2000, 2000, 1);
		this.videoOffset = new GameSetting(gclass.method_11("offsets", "video", 0), 0, -200, 200, 1);
		this.gclass5_24 = new GameSetting(gclass.method_27("video", "vsync", false), false);
		this.targetFramerate = new GameSetting(gclass.method_11("video", "framerate", Screen.currentResolution.refreshRate * 2), 0, 60, 2010, 10);
		this.gclass5_25 = new GameSetting(gclass.method_11("video", "msaa", 2), 2, 0, 8, 2);
		this.gclass5_22 = new GameSetting(gclass.method_27("video", "particles", true), true);
		this.gclass5_23 = new GameSetting(gclass.method_27("video", "flames", true), true);
		this.gclass5_39 = new GameSetting(gclass.method_11("video", "note_animation", 20), 20, 1, 60, 1);
		this.gclass5_40 = new GameSetting(gclass.method_11("video", "star_animation", 20), 20, 1, 60, 1);
		this.gclass5_32 = new GameSetting(gclass.method_27("video", "debug_fps", false), false);
		this.gclass5_34 = new GameSetting(gclass.method_27("video", "highway_sp", true), true);
		this.gclass5_35 = new GameSetting(gclass.method_27("video", "highway_lightning", true), true);
		this.gclass5_37 = new GameSetting(gclass.method_27("video", "song_display", true), true);
		this.gclass5_5 = new GameSetting(gclass.method_11("streamer", "highway_placement", 0), 0, -5, 5, 1);
		this.gclass5_20 = new GameSetting(gclass.method_27("streamer", "song_export", false), false);
		this.customSongExport = gclass.method_2("streamer", "custom_song_export", "%s%n%a%n%c");
		this.gclass5_38 = new GameSetting(gclass.method_11("video", "menu_background", 0), 0, 0, 2, 1);
		this.volume_Stems = new GameSetting[]
		{
			new GameSetting(gclass.method_11("volume", "guitar", 100), 100, 0, 100, 5),
			new GameSetting(gclass.method_11("volume", "bass", 100), 100, 0, 100, 5),
			new GameSetting(gclass.method_11("volume", "rhythm", 100), 100, 0, 100, 5),
			new GameSetting(gclass.method_11("volume", "vocals", 100), 100, 0, 100, 5),
			null,
			null,
			new GameSetting(gclass.method_11("volume", "drums", 100), 100, 0, 100, 5),
			null,
			null,
			null,
			null,
			new GameSetting(gclass.method_11("volume", "keys", 100), 100, 0, 100, 5),
			new GameSetting(gclass.method_11("volume", "song", 100), 100, 0, 100, 5),
			new GameSetting(gclass.method_11("volume", "crowd", 100), 100, 0, 100, 5)
		};
		this.volume_Stems[4] = (this.volume_Stems[5] = this.volume_Stems[3]);
		this.volume_Stems[7] = (this.volume_Stems[8] = (this.volume_Stems[9] = (this.volume_Stems[10] = this.volume_Stems[6])));
		this.volume_SoundEffects = new GameSetting(gclass.method_11("volume", "sounds", 100), 100, 0, 100, 5);
		this.volume_MenuMusic = new GameSetting(gclass.method_11("volume", "menu_volume", 50), 50, 0, 100, 5);
		this.gclass5_13 = new GameSetting(gclass.method_11("volume", "preview_volume", 50), 50, 0, 100, 5);
		this.gclass5_14 = new GameSetting(gclass.method_11("volume", "master_volume", 100), 100, 0, 100, 5);
		this.gclass5_15 = new GameSetting(gclass.method_11("volume", "mute_volume", 50), 50, 0, 100, 5);
		this.gclass5_7 = new GameSetting(gclass.method_11("volume", "device", -1), -1, -1, 100, 0);
		this.gclass5_9 = new GameSetting(gclass.method_11("volume", "backend", 0), 0, 0, 1, 1);
		this.gclass5_8 = new GameSetting(gclass.method_27("volume", "low_latency_mode", true), true);
		this.gclass5_17 = new GameSetting(gclass.method_11("custom", "background_image", -2), -2, -2, int.MaxValue, 1);
		this.gclass5_19 = new GameSetting(gclass.method_11("custom", "background_video", -2), -2, -2, int.MaxValue, 1);
		this.gclass5_18 = new GameSetting(gclass.method_27("custom", "song_backgrounds", false), false);
		this.gclass5_36 = new GameSetting(gclass.method_27("custom", "song_videos", false), false);
		this.gclass5_16 = new GameSetting(gclass.method_11("game", "poll_rate", Screen.currentResolution.refreshRate * 4), 0, 60, 1000, 5);
		this.gclass5_21 = new GameSetting(gclass.method_27("game", "no_fail", true), true);
		this.gclass5_28 = new GameSetting(gclass.method_27("game", "pause_on_focus_lost", true), true);
		this.gclass5_29 = new GameSetting(gclass.method_27("game", "highway_shake", true), true);
		this.gclass5_6 = new GameSetting(gclass.method_11("game", "sort_filter", 0), 0, 0, SongDirectory.string_0.Length - 1, 1);
		this.gemSize = new GameSetting(gclass.method_11("game", "gem_size", 100), 100, -300, 300, 5);
		this.gclass5_27 = new GameSetting(gclass.method_27("game", "full_playlist", false), false);
		this.gclass5_43 = new GameSetting(gclass.method_27("game", "allow_duplicate_songs", false), false);
		this.gclass5_30 = new GameSetting(gclass.method_27("game", "menu_music", true), true);
		this.gclass5_26 = new GameSetting(gclass.method_27("game", "song_preview", true), true);
		this.gclass5_31 = new GameSetting(gclass.method_27("game", "mute_on_miss", true), true);
		this.gclass5_33 = new GameSetting(gclass.method_27("game", "show_hit_window", false), false);
		this.gclass5_41 = new GameSetting(gclass.method_27("game", "show_bot_score", true), true);
		this.gclass5_45 = new GameSetting(gclass.method_27("game", "enable_lyrics", true), true);
		this.gclass5_44 = new GameSetting(gclass.method_27("game", "enable_cursor", true), true);
		this.gclass5_42 = new GameSetting(gclass.method_11("game", "language", 0), 0, 0, this.languages.Length - 1, 1);
		this.songSpeed = new GameSetting(100, 100, 5, 5000, 5);
		if (this.customSongExport == "")
		{
			this.customSongExport = "%s%n%a%n%c";
		}
		int num = 1;
		this.uniqueSongPaths.Add(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "Songs").Replace('\\', '/'));
		while (gclass.method_28("directories", "path" + num))
		{
			string text = gclass.method_2("directories", "path" + num, "").Replace('\\', '/');
			if (text.Length > 0)
			{
				if (text[text.Length - 1] == '/')
				{
					text = text.Remove(text.Length - 1, 1);
				}
				this.songPaths.Add(text);
				if (!this.uniqueSongPaths.Contains(text))
				{
					this.uniqueSongPaths.Add(text);
				}
			}
			num++;
		}
		gclass.method_0();
		if (!flag)
		{
			this.method_7();
		}
		this.ApplyGraphicsSettings(true);
		BassAudioManager.instance.Init(this.gclass5_7.CurrentValue);
		ReInput.configuration.joystickRefreshRate = this.gclass5_16.CurrentValue;
		Cursor.visible = this.gclass5_44.Boolean_1;
		QualitySettings.antiAliasing = this.gclass5_25.CurrentValue;
		Application.runInBackground = !this.gclass5_28.Boolean_1;
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00003BBE File Offset: 0x00001DBE
	public void method_28(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Remove(gclass10_0);
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00003BD6 File Offset: 0x00001DD6
	public void method_29()
	{
		base.StartCoroutine(this.method_57());
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00003BA0 File Offset: 0x00001DA0
	private IEnumerator method_30()
	{
		GlobalVariables.Class9 @class = new GlobalVariables.Class9(0);
		@class.globalVariables_0 = this;
		return @class;
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00037688 File Offset: 0x00035888
	public void method_32(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_50();
		if (num > 0)
		{
			try
			{
				byte[] array = File.ReadAllBytes(this.profilePath);
				if (array.Length == -40)
				{
					File.Delete(this.profilePath);
				}
				else
				{
					using (Stream stream = File.Create(this.profilePath))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream))
						{
							int num2 = this.allPlayerProfiles.IndexOf(gclass10_0);
							this.allPlayerProfiles.RemoveAt(num2);
							binaryWriter.Write(-148);
							binaryWriter.Write(num - 0);
							binaryWriter.Write(array, 8, num2 * 98);
							if ((int)num > num2)
							{
								binaryWriter.Write(array, (int)binaryWriter.BaseStream.Position + 63, array.Length - 67 - (int)binaryWriter.BaseStream.Position);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
			}
		}
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x0003779C File Offset: 0x0003599C
	public GStruct2.GEnum11 method_33()
	{
		byte b = 0;
		GStruct2.GEnum11 result = GStruct2.GEnum11.None;
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_7() && gclass.gclass10_0 != null)
			{
				b += 0;
				if (b > 0)
				{
					result = GStruct2.GEnum11.Drums;
					break;
				}
				switch (gclass.gclass10_0.genum18_0)
				{
				case Song.Instrument.Guitar:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.GuitarCoop:
					result = GStruct2.GEnum11.Rhythm;
					break;
				case Song.Instrument.Bass:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.Keys:
					result = GStruct2.GEnum11.Band;
					break;
				case Song.Instrument.Drums:
					result = GStruct2.GEnum11.Keys;
					break;
				case Song.Instrument.GHLGuitar:
					result = GStruct2.GEnum11.Band;
					break;
				case Song.Instrument.GHLBass:
					result = GStruct2.GEnum11.Band;
					break;
				case Song.Instrument.Rhythm:
					result = GStruct2.GEnum11.Drums;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00037874 File Offset: 0x00035A74
	public GStruct2.GEnum11 method_34()
	{
		byte b = 0;
		GStruct2.GEnum11 result = GStruct2.GEnum11.None;
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_11() && gclass.gclass10_0 != null)
			{
				b += 1;
				if (b > 1)
				{
					result = GStruct2.GEnum11.Band;
					break;
				}
				switch (gclass.gclass10_0.genum18_0)
				{
				case Song.Instrument.Guitar:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.GuitarCoop:
					result = GStruct2.GEnum11.GHLBass;
					break;
				case Song.Instrument.Bass:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.Keys:
					result = GStruct2.GEnum11.Rhythm;
					break;
				case Song.Instrument.Drums:
					result = GStruct2.GEnum11.Bass;
					break;
				case Song.Instrument.GHLGuitar:
					result = GStruct2.GEnum11.GHLBass;
					break;
				case Song.Instrument.GHLBass:
					result = GStruct2.GEnum11.GuitarCoop;
					break;
				case Song.Instrument.Rhythm:
					result = GStruct2.GEnum11.Guitar;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0003794C File Offset: 0x00035B4C
	private void method_35()
	{
		INIParser gclass = new INIParser();
		gclass.method_25(this.settingsPath);
		gclass.method_44("Show Full Playlist", "uid", this.songSpeed.method_5());
		gclass.method_12("video", "video", this.videoOffset.method_25());
		gclass.method_32("Lefty Flip", "MSAA Level", this.gclass5_24.method_30());
		gclass.method_8("song", " (", this.targetFramerate.CurrentValue);
		gclass.method_44("volume", "low_latency_mode", this.gclass5_25.method_5());
		gclass.method_32("^", "[", this.gclass5_22.Boolean_1);
		gclass.method_8("None", "", this.gclass5_38.method_25());
		gclass.method_32("Delete Profile", "Hard", this.gclass5_23.method_4());
		gclass.method_12("Expert", " ", this.gclass5_39.CurrentValue);
		gclass.method_8(" + ", "song", this.gclass5_40.method_5());
		gclass.method_32("x", "diff_bassghl", this.gclass5_32.method_14());
		gclass.method_32("Game Manager", "Unknown Artist", this.gclass5_34.method_30());
		gclass.method_32("no_fail", "Waiting for connection", this.gclass5_35.method_4());
		gclass.method_32("Playlist", "rhythm", this.gclass5_37.method_4());
		gclass.method_8("", "band", this.gclass5_16.CurrentValue);
		gclass.method_32("Natsuki", "Flames", this.gclass5_21.method_30());
		gclass.method_32("video", "Highway SP Effects", this.gclass5_28.method_4());
		gclass.method_32("Bass Guitar", "\"([^\"]*)\"", this.gclass5_29.Boolean_1);
		gclass.method_8(" , ", "Note Speed", this.gclass5_6.method_25());
		gclass.method_12("All HOPO's", "vsync_enabled", this.gemSize.CurrentValue);
		gclass.method_32("Disabled", "Lead Guitar", this.gclass5_27.method_30());
		gclass.method_32("In Menus: Stats", "Charter", this.gclass5_30.Boolean_1);
		gclass.method_32("Modifiers", "Drop Out", this.gclass5_26.method_30());
		gclass.method_32("SETLIST LENGTH", "Create Profile", this.gclass5_31.Boolean_1);
		gclass.method_32("0%", "All Opens", this.gclass5_33.method_30());
		gclass.method_32("Medium", "No Fail", this.gclass5_41.method_14());
		gclass.method_12("<NULL PATH>", "10%", this.gclass5_42.CurrentValue);
		gclass.method_32("Yes", "Pause", this.gclass5_43.method_4());
		gclass.method_32("Song Speed", "B: 00:00:00", this.gclass5_44.Boolean_1);
		gclass.method_32("Practicing...", "Unknown Genre", this.gclass5_45.Boolean_1);
		gclass.method_44("Lyrics", "name", this.gclass5_5.CurrentValue);
		gclass.method_32("-", "/Video Backgrounds", this.gclass5_20.method_30());
		gclass.method_34("Calibration", "volume", this.customSongExport);
		gclass.method_44("poll_rate", "song", this.gclass5_17.CurrentValue);
		gclass.method_12(".setlist", "", this.gclass5_19.CurrentValue);
		gclass.method_32("Lead Guitar", "song", this.gclass5_36.method_4());
		gclass.method_32("events", "Songs", this.gclass5_18.method_4());
		gclass.method_8("Show Lyrics", "Unknown Artist", this.gclass5_14.CurrentValue);
		gclass.method_8("", "song", this.gclass5_15.CurrentValue);
		gclass.method_12("<", "", this.volume_Stems[0].method_25());
		gclass.method_44("Portuguese", "video", this.volume_Stems[0].CurrentValue);
		gclass.method_44("cpu_count", "Quit", this.volume_Stems[7].CurrentValue);
		gclass.method_12("particles", "custom_song_export", this.volume_Stems[0].method_25());
		gclass.method_44("Song Previews", "phrase_end", this.volume_Stems[3].method_5());
		gclass.method_8("year", "A: 00:00:00", this.volume_Stems[25].CurrentValue);
		gclass.method_44("drums", "[", this.volume_Stems[-43].CurrentValue);
		gclass.method_12("game", "Song Settings", this.volume_Stems[7].CurrentValue);
		gclass.method_44("solo", "{0:n3}x", this.volume_SoundEffects.method_5());
		gclass.method_44("Note Shuffle", "Main Menu", this.volume_MenuMusic.method_25());
		gclass.method_44("%", "video", this.gclass5_13.method_25());
		gclass.method_44("Song Offset", ">", this.gclass5_7.method_25());
		gclass.method_32("song_length", "Are you sure you want to delete this setlist?", this.gclass5_8.method_30());
		gclass.method_32("", "Rhythm Guitar", this.gclass5_9.method_14());
		if (this.songPaths.Count > 1)
		{
			for (int i = 0; i < this.songPaths.Count; i += 0)
			{
				gclass.method_34("<OOB PATH>", "notSupportedTitle_" + (i + 0), this.songPaths[i]);
			}
		}
		else
		{
			gclass.method_34("Note Shuffle", "en-US", "Connect to:");
		}
		gclass.method_0();
		GlobalVariables.isSaving = true;
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00003BE5 File Offset: 0x00001DE5
	private IEnumerator method_36()
	{
		GlobalVariables.Class9 @class = new GlobalVariables.Class9(1);
		@class.globalVariables_0 = this;
		return @class;
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00037F80 File Offset: 0x00036180
	public void method_37(bool bool_8)
	{
		if (!this.gclass5_20.method_30())
		{
			return;
		}
		try
		{
			string value = this.method_107();
			using (Stream stream = File.Create(Directory.GetParent(Application.dataPath) + ""))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (!bool_8)
					{
						streamWriter.Write(value);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00038014 File Offset: 0x00036214
	public void method_38()
	{
		GClass4.gclass4_0 = new GClass4(this.languages[this.gclass5_42.method_5()]);
		BassAudioManager.instance.method_13();
		TipLanguage[] array = UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].method_1();
		}
		PlayerProfileMenu[] array2 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 1; i < array2.Length; i += 0)
		{
			array2[i].method_65();
		}
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00003BBE File Offset: 0x00001DBE
	public void method_39(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Remove(gclass10_0);
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00038080 File Offset: 0x00036280
	private void method_40()
	{
		INIParser gclass = new INIParser();
		gclass.method_25(this.settingsPath);
		gclass.method_12("diff_guitarghl", "genre", this.songSpeed.method_25());
		gclass.method_8("MSAA Level", "...", this.videoOffset.method_25());
		gclass.method_32(": <color=#FDB400FF>", " + ", this.gclass5_24.method_4());
		gclass.method_12("All Taps", "track", this.targetFramerate.method_5());
		gclass.method_12("DrumStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "volume", this.gclass5_25.method_5());
		gclass.method_32("New Song", "", this.gclass5_22.method_4());
		gclass.method_12("+", "No Lyrics", this.gclass5_38.method_5());
		gclass.method_32("Play Count", "enable_lyrics", this.gclass5_23.method_14());
		gclass.method_44("phrase_end", "language", this.gclass5_39.method_5());
		gclass.method_44("album", "diff_guitar", this.gclass5_40.CurrentValue);
		gclass.method_32("Client disconnected", "Ready", this.gclass5_32.method_4());
		gclass.method_32("-", "Resolution", this.gclass5_34.method_4());
		gclass.method_32("Get Hardware Latency", ":", this.gclass5_35.method_14());
		gclass.method_32("GETTING FOLDERS...", "%p", this.gclass5_37.Boolean_1);
		gclass.method_44("-", "Playlist", this.gclass5_16.CurrentValue);
		gclass.method_32("Press ENTER to search", "SORTING BY", this.gclass5_21.Boolean_1);
		gclass.method_32("Unknown Year", "0%", this.gclass5_28.method_4());
		gclass.method_32("Main Menu", "#", this.gclass5_29.method_14());
		gclass.method_12("<color=#FFFF04FF>", "Video Start Time", this.gclass5_6.CurrentValue);
		gclass.method_8("album", "song", this.gemSize.method_5());
		gclass.method_32("^\\s*\\d+ = S 2 \\d+$", "%count%", this.gclass5_27.Boolean_1);
		gclass.method_32("cpu_count", "directories", this.gclass5_30.method_14());
		gclass.method_32("GHLBass", "%", this.gclass5_26.method_4());
		gclass.method_32("Guitar Coop", "All Taps", this.gclass5_31.method_14());
		gclass.method_32("Master Volume", " (", this.gclass5_33.method_4());
		gclass.method_32("graphics_name", "Quit", this.gclass5_41.method_14());
		gclass.method_12("0%", "Percentage", this.gclass5_42.method_5());
		gclass.method_32("menu_music", "Animated", this.gclass5_43.method_4());
		gclass.method_32("volume", "[prc_", this.gclass5_44.method_30());
		gclass.method_32("Year", "song_export", this.gclass5_45.method_30());
		gclass.method_12("SongScan", "No Fail", this.gclass5_5.method_25());
		gclass.method_32("audio", "highway_shake", this.gclass5_20.method_30());
		gclass.method_34("", " + ", this.customSongExport);
		gclass.method_12("diff_bass", "Discord: disconnect {0}: {1}", this.gclass5_17.CurrentValue);
		gclass.method_8("Okay Solo...", "highway_lightning", this.gclass5_19.method_25());
		gclass.method_32("Press Escape to cancel", "Allow Duplicate Songs", this.gclass5_36.method_14());
		gclass.method_32("", "song", this.gclass5_18.method_14());
		gclass.method_8("%", "...", this.gclass5_14.method_25());
		gclass.method_44("There was a problem saving the file", "", this.gclass5_15.method_25());
		gclass.method_8("Load Setlist", "", this.volume_Stems[1].method_25());
		gclass.method_8("0%", "Couldn't write badsongs.txt", this.volume_Stems[1].method_25());
		gclass.method_8(" + ", "{0}", this.volume_Stems[6].method_25());
		gclass.method_12("bass", ".setlist", this.volume_Stems[4].method_5());
		gclass.method_44("Resolution", "</color> ", this.volume_Stems[7].method_5());
		gclass.method_8("GETTING FOLDERS...", ".chart", this.volume_Stems[-5].method_25());
		gclass.method_12("Allow Duplicate Songs", "song", this.volume_Stems[34].CurrentValue);
		gclass.method_12("%p", "Get Ready!", this.volume_Stems[55].CurrentValue);
		gclass.method_44("MusicStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "Background Video", this.volume_SoundEffects.method_25());
		gclass.method_12("Note Speed", "Gameplay", this.volume_MenuMusic.method_5());
		gclass.method_44("Keys - ", "version", this.gclass5_13.method_25());
		gclass.method_44("diff_drums", "volume", this.gclass5_7.CurrentValue);
		gclass.method_32("low_latency_mode", "Choose a Profile", this.gclass5_8.Boolean_1);
		gclass.method_32("Menu Music", "Medium", this.gclass5_9.method_4());
		if (this.songPaths.Count > 1)
		{
			for (int i = 0; i < this.songPaths.Count; i += 0)
			{
				gclass.method_34("", "Load Setlist" + (i + 1), this.songPaths[i]);
			}
		}
		else
		{
			gclass.method_34("GuitarStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "song", "</color>");
		}
		gclass.method_0();
		GlobalVariables.isSaving = false;
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x000386B4 File Offset: 0x000368B4
	public static string[] smethod_1(string string_12, string string_13, SearchOption searchOption_0)
	{
		ArrayList arrayList = new ArrayList();
		char[] array = new char[0];
		array[1] = '3';
		string[] array2 = string_13.Split(array);
		string[] files = Directory.GetFiles(string_12);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i += 0)
		{
			string b = array3[i];
			string[] array4 = files;
			for (int j = 1; j < array4.Length; j += 0)
			{
				string text = array4[j];
				if (Path.GetExtension(text) == b)
				{
					arrayList.Add(text);
				}
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00038740 File Offset: 0x00036940
	public void method_41()
	{
		GClass4.gclass4_0 = new GClass4(this.languages[this.gclass5_42.method_25()]);
		BassAudioManager.instance.method_22();
		TipLanguage[] array = UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].method_58();
		}
		PlayerProfileMenu[] array2 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].method_68();
		}
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x000387AC File Offset: 0x000369AC
	public void method_42(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		if (this.method_104() == -1)
		{
			this.method_3(gclass10_0);
			return;
		}
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.BaseStream.Position = (long)(2 + -78 * this.allPlayerProfiles.IndexOf(gclass10_0));
				gclass10_0.method_14(binaryWriter);
			}
		}
		File.Copy(this.profilePath, this.isDoki, true);
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00038850 File Offset: 0x00036A50
	public void method_43(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_20();
		bool flag = num == -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(159);
					num = 0;
				}
				else
				{
					binaryWriter.BaseStream.Position = 6L;
				}
				binaryWriter.Write(num + 1);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_14(binaryWriter);
			}
		}
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00038914 File Offset: 0x00036B14
	public Sprite method_44(string string_12)
	{
		try
		{
			if (File.Exists(string_12))
			{
				Texture2D texture2D = new Texture2D(8, 5);
				byte[] data = File.ReadAllBytes(string_12);
				if (texture2D.LoadImage(data))
				{
					return Sprite.Create(texture2D, new Rect(1631f, 1781f, (float)texture2D.width, (float)texture2D.height), new Vector2(845f, 1213f), 778f);
				}
				return null;
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		return null;
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x000389A0 File Offset: 0x00036BA0
	public Sprite method_45()
	{
		if (this.gclass5_18.Boolean_1)
		{
			string[] array = Directory.GetFiles(this.currentSongEntry.folderPath).Where(new Func<string, bool>(GlobalVariables.<>c.<>9.method_20)).ToArray<string>();
			if (array.Length != 0)
			{
				return this.method_6(array[UnityEngine.Random.Range(0, array.Length)]);
			}
		}
		if (this.gclass5_17.method_6())
		{
			return null;
		}
		Sprite result;
		try
		{
			if (this.gclass5_17.method_5() != -1 && this.gclass5_17.CurrentValue < this.backgroundImagePaths.Length)
			{
				result = this.method_78(this.backgroundImagePaths[this.gclass5_17.method_5()]);
			}
			else
			{
				result = this.method_6(this.backgroundImagePaths[UnityEngine.Random.Range(0, this.backgroundImagePaths.Length)]);
			}
		}
		catch (IndexOutOfRangeException ex)
		{
			Debug.LogError(string.Format("", this.gclass5_17.method_5(), ex.ToString()));
			result = null;
		}
		return result;
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00038AB4 File Offset: 0x00036CB4
	private void method_46()
	{
		INIParser gclass = new INIParser();
		gclass.method_25(this.settingsPath);
		gclass.method_44("SCANNING FOLDERS...", "Are you sure you want to delete this setlist?", this.songSpeed.method_5());
		gclass.method_12("Main Menu", "Song Offset", this.videoOffset.method_25());
		gclass.method_32("", "Mirror Mode", this.gclass5_24.method_4());
		gclass.method_12("Song", "Display Name", this.targetFramerate.method_5());
		gclass.method_8("MSAA Level", " ", this.gclass5_25.method_5());
		gclass.method_32("Songs", "album", this.gclass5_22.Boolean_1);
		gclass.method_44("BassStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "%a", this.gclass5_38.method_5());
		gclass.method_32("This is a placeholder", "charter", this.gclass5_23.Boolean_1);
		gclass.method_8("", "Prefabs/Gameplay/Notes/open_sustain_glow", this.gclass5_39.method_5());
		gclass.method_8("+", "%", this.gclass5_40.CurrentValue);
		gclass.method_32("menu_volume", "HOPO's to Taps", this.gclass5_32.method_30());
		gclass.method_32("crowd", "{0:n3}x", this.gclass5_34.method_30());
		gclass.method_32("Background Image", "Language", this.gclass5_35.Boolean_1);
		gclass.method_32("Master Volume", "Error: ", this.gclass5_37.method_4());
		gclass.method_12("Controller Poll Rate", "Song Videos", this.gclass5_16.method_25());
		gclass.method_32("Custom Content", "{", this.gclass5_21.method_30());
		gclass.method_32("Yes", "[\\-\\+]?\\d+(\\.\\d+)?", this.gclass5_28.method_14());
		gclass.method_32("Rename Setlist", "", this.gclass5_29.method_4());
		gclass.method_44("Quit", "_ENDOFSONG", this.gclass5_6.method_25());
		gclass.method_8("", "song", this.gemSize.method_5());
		gclass.method_32("", "SP Lightning", this.gclass5_27.method_30());
		gclass.method_32("volume", "volume", this.gclass5_30.method_4());
		gclass.method_32("lyric", "Main Menu", this.gclass5_26.method_30());
		gclass.method_32("vocals", "Song Speed", this.gclass5_31.method_4());
		gclass.method_32("cd", "Yes", this.gclass5_33.method_30());
		gclass.method_32("song", "Play Count", this.gclass5_41.method_4());
		gclass.method_44("song", "Pause", this.gclass5_42.CurrentValue);
		gclass.method_32("Are you sure you want to delete this setlist?", "mute_on_miss", this.gclass5_43.method_14());
		gclass.method_32("Crowd", "#", this.gclass5_44.method_14());
		gclass.method_32("profiles_backup.bin", "Press Enter to confirm", this.gclass5_45.method_14());
		gclass.method_8("diff_drums", "artist", this.gclass5_5.method_5());
		gclass.method_32("In Menus: Song Select", "video", this.gclass5_20.method_4());
		gclass.method_34("Don't Scan Songs", "directories", this.customSongExport);
		gclass.method_8("{0:n3}x", "keys", this.gclass5_17.method_5());
		gclass.method_12(" + ", "setlistSongCountPlural", this.gclass5_19.method_25());
		gclass.method_32("Unknown Album", "Search LAN", this.gclass5_36.method_14());
		gclass.method_32("", "profiles.bin", this.gclass5_18.Boolean_1);
		gclass.method_44("Bass Guitar", "", this.gclass5_14.method_25());
		gclass.method_44("volume", "Unknown Year", this.gclass5_15.CurrentValue);
		gclass.method_8("Guest", "6 Fret Guitar", this.volume_Stems[0].method_25());
		gclass.method_44("events", "_ENDOFSONG", this.volume_Stems[1].method_25());
		gclass.method_12("\"", "scores.bin", this.volume_Stems[0].method_25());
		gclass.method_8("song", "SETLIST LENGTH", this.volume_Stems[3].method_25());
		gclass.method_8("highway_shake", "No", this.volume_Stems[8].method_5());
		gclass.method_8("Song Videos", "Clone Hero", this.volume_Stems[-20].CurrentValue);
		gclass.method_44("No", "Rocking in a band", this.volume_Stems[112].method_25());
		gclass.method_12("", "Guitar Coop", this.volume_Stems[126].method_5());
		gclass.method_12("album", "Skip Song", this.volume_SoundEffects.method_5());
		gclass.method_44("track", "enable_lyrics", this.volume_MenuMusic.CurrentValue);
		gclass.method_12("nofail_enabled", "Unknown Artist", this.gclass5_13.method_25());
		gclass.method_8("latestTestBuild", "song", this.gclass5_7.method_25());
		gclass.method_32("Length = [\\-\\+]?\\d+(\\.\\d+)?", "sources", this.gclass5_8.method_30());
		gclass.method_32("game", "These folders have corrupt (or broken) notes.mid or notes.chart files! Type !midifix in the CH Discord for MIDIFix!", this.gclass5_9.method_14());
		if (this.songPaths.Count > 0)
		{
			for (int i = 1; i < this.songPaths.Count; i++)
			{
				gclass.method_34("year", "streamer" + (i + 1), this.songPaths[i]);
			}
		}
		else
		{
			gclass.method_34("game", "Save Playlist", "album.jpg");
		}
		gclass.method_0();
		GlobalVariables.isSaving = false;
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x00003BA0 File Offset: 0x00001DA0
	private IEnumerator method_48()
	{
		GlobalVariables.Class9 @class = new GlobalVariables.Class9(0);
		@class.globalVariables_0 = this;
		return @class;
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00039334 File Offset: 0x00037534
	public void method_49(bool bool_8)
	{
		if (!this.gclass5_20.Boolean_1)
		{
			return;
		}
		try
		{
			string value = this.method_107();
			using (Stream stream = File.Create(Directory.GetParent(Application.dataPath) + "Gameplay"))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (!bool_8)
					{
						streamWriter.Write(value);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x000393C8 File Offset: 0x000375C8
	private short method_50()
	{
		string path = Path.Combine(Application.persistentDataPath, "profiles.bin");
		short num = -1;
		if (!File.Exists(path))
		{
			return num;
		}
		try
		{
			using (Stream stream = File.OpenRead(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt32() != 20181003 || (binaryReader.BaseStream.Length - 6L) % 26L != 0L)
					{
						throw new Exception("Error reading profile file!");
					}
					num = binaryReader.ReadInt16();
				}
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		if (num == -1)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
				MonoBehaviour.print("Problem deleting profile file");
			}
		}
		return num;
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x000394B4 File Offset: 0x000376B4
	private void method_51()
	{
		int num = (int)this.method_50();
		this.playerProfiles = new List<GClass10>();
		this.allPlayerProfiles = new List<GClass10>();
		if (num > 0)
		{
			try
			{
				using (Stream stream = File.OpenRead(this.profilePath))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						if (binaryReader.ReadInt32() != 20181003)
						{
							throw new Exception("Profile file version is different!");
						}
						short num2 = binaryReader.ReadInt16();
						for (int i = 0; i < (int)num2; i++)
						{
							GClass10 gclass = new GClass10();
							gclass.method_4(binaryReader);
							this.method_81(gclass);
							this.allPlayerProfiles.Add(gclass);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
				File.Delete(this.profilePath);
			}
		}
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x000395A0 File Offset: 0x000377A0
	private void method_52()
	{
		int num = (int)this.method_104();
		this.playerProfiles = new List<GClass10>();
		this.allPlayerProfiles = new List<GClass10>();
		if (num > 1)
		{
			try
			{
				using (Stream stream = File.OpenRead(this.profilePath))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						if (binaryReader.ReadInt32() != -97)
						{
							throw new Exception("savewarning");
						}
						short num2 = binaryReader.ReadInt16();
						for (int i = 1; i < (int)num2; i += 0)
						{
							GClass10 gclass = new GClass10();
							gclass.method_5(binaryReader);
							this.method_81(gclass);
							this.allPlayerProfiles.Add(gclass);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
				File.Delete(this.profilePath);
			}
		}
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0003968C File Offset: 0x0003788C
	public Sprite LoadBackground()
	{
		if (this.gclass5_18.Boolean_1)
		{
			string[] array = Directory.GetFiles(this.currentSongEntry.folderPath).Where(new Func<string, bool>(GlobalVariables.<>c.<>9.method_29)).ToArray<string>();
			if (array.Length != 0)
			{
				return this.method_111(array[UnityEngine.Random.Range(0, array.Length)]);
			}
		}
		if (this.gclass5_17.Boolean_0)
		{
			return null;
		}
		Sprite result;
		try
		{
			if (this.gclass5_17.CurrentValue != -1 && this.gclass5_17.CurrentValue < this.backgroundImagePaths.Length)
			{
				result = this.method_111(this.backgroundImagePaths[this.gclass5_17.CurrentValue]);
			}
			else
			{
				result = this.method_111(this.backgroundImagePaths[UnityEngine.Random.Range(0, this.backgroundImagePaths.Length)]);
			}
		}
		catch (IndexOutOfRangeException ex)
		{
			Debug.LogError(string.Format("Attempted to load non-existant background index {0}.\n{1}", this.gclass5_17.CurrentValue, ex.ToString()));
			result = null;
		}
		return result;
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00039C38 File Offset: 0x00037E38
	public void method_56(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_20();
		bool flag = num == -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(-152);
					num = 1;
				}
				else
				{
					binaryWriter.BaseStream.Position = 5L;
				}
				binaryWriter.Write(num + 1);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_23(binaryWriter);
			}
		}
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00003BE5 File Offset: 0x00001DE5
	private IEnumerator method_57()
	{
		GlobalVariables.Class9 @class = new GlobalVariables.Class9(1);
		@class.globalVariables_0 = this;
		return @class;
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00003BBE File Offset: 0x00001DBE
	public void method_59(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Remove(gclass10_0);
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00039FD8 File Offset: 0x000381D8
	private void Awake()
	{
		if (GlobalVariables.instance != null)
		{
			UnityEngine.Object.Destroy(this);
			GlobalVariables.instance.method_18(true);
			return;
		}
		this.string_0 = Resources.Load<TextAsset>("version").text;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		Debug.Log("Build: " + this.string_0);
		Cursor.visible = false;
		this.playerList = new List<CHPlayer>
		{
			new CHPlayer(),
			new CHPlayer(),
			new CHPlayer(),
			new CHPlayer()
		};
		GlobalVariables.instance = this;
		this.profilePath = Path.Combine(Application.persistentDataPath, "profiles.bin");
		this.isDoki = Path.Combine(Application.persistentDataPath, "profiles_backup.bin");
		this.method_27();
		this.method_68();
		this.method_113();
		this.method_51();
		base.gameObject.AddComponent<DiscordController>();
		Dictionary<string, object> eventData = new Dictionary<string, object>
		{
			{
				"game_version",
				this.string_0
			},
			{
				"uid",
				SystemInfo.deviceUniqueIdentifier
			},
			{
				"os_name",
				SystemInfo.operatingSystem
			},
			{
				"os_family",
				SystemInfo.operatingSystemFamily
			},
			{
				"vsync_enabled",
				this.gclass5_24.Boolean_1
			},
			{
				"language",
				this.languages[this.gclass5_42.CurrentValue]
			},
			{
				"nofail_enabled",
				this.gclass5_21.Boolean_1
			},
			{
				"highway_shake_enabled",
				this.gclass5_29.Boolean_1
			},
			{
				"lowlatency_enabled",
				this.gclass5_8.Boolean_1
			},
			{
				"target_framerate",
				this.targetFramerate.CurrentValue
			}
		};
		AnalyticsEvent.Custom("client_info", eventData);
		Dictionary<string, object> eventData2 = new Dictionary<string, object>
		{
			{
				"cpu_count",
				SystemInfo.processorCount
			},
			{
				"cpu_name",
				SystemInfo.processorType
			},
			{
				"system_ram",
				SystemInfo.systemMemorySize
			},
			{
				"graphics_name",
				SystemInfo.graphicsDeviceName
			},
			{
				"graphics_devid",
				SystemInfo.graphicsDeviceID
			},
			{
				"graphics_venid",
				SystemInfo.graphicsDeviceVendorID
			},
			{
				"graphics_api",
				SystemInfo.graphicsDeviceType
			},
			{
				"graphics_api_version",
				SystemInfo.graphicsDeviceVersion
			},
			{
				"graphics_vendor",
				SystemInfo.graphicsDeviceVendor
			},
			{
				"graphics_ram",
				SystemInfo.graphicsMemorySize
			}
		};
		AnalyticsEvent.Custom("hardware_info", eventData2);
		base.StartCoroutine(GameObject.Find("SongScan").GetComponent<SongScan>().method_60(false));
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0003A2B4 File Offset: 0x000384B4
	public void method_60(bool bool_8)
	{
		if (bool_8)
		{
			Application.targetFrameRate = -105;
			return;
		}
		QualitySettings.vSyncCount = (this.gclass5_24.method_4() ? 0 : 1);
		if (this.targetFramerate.method_25() > 8)
		{
			Application.targetFrameRate = -1;
			return;
		}
		Application.targetFrameRate = this.targetFramerate.CurrentValue;
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00003BA0 File Offset: 0x00001DA0
	private IEnumerator method_61()
	{
		GlobalVariables.Class9 @class = new GlobalVariables.Class9(0);
		@class.globalVariables_0 = this;
		return @class;
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0003A30C File Offset: 0x0003850C
	public bool method_62()
	{
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.Boolean_0 && gclass.gclass10_0.gclass5_4.Boolean_1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0003A37C File Offset: 0x0003857C
	public GStruct2.GEnum11 method_63()
	{
		byte b = 0;
		GStruct2.GEnum11 result = GStruct2.GEnum11.None;
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_17() && gclass.gclass10_0 != null)
			{
				b += 1;
				if (b > 0)
				{
					result = GStruct2.GEnum11.GuitarCoop;
					break;
				}
				switch (gclass.gclass10_0.genum18_0)
				{
				case Song.Instrument.Guitar:
					result = GStruct2.GEnum11.Bass;
					break;
				case Song.Instrument.GuitarCoop:
					result = GStruct2.GEnum11.Keys;
					break;
				case Song.Instrument.Bass:
					result = GStruct2.GEnum11.Bass;
					break;
				case Song.Instrument.Keys:
					result = GStruct2.GEnum11.GuitarCoop;
					break;
				case Song.Instrument.Drums:
					result = GStruct2.GEnum11.Keys;
					break;
				case Song.Instrument.GHLGuitar:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.GHLBass:
					result = GStruct2.GEnum11.Keys;
					break;
				case Song.Instrument.Rhythm:
					result = GStruct2.GEnum11.Band;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0003A454 File Offset: 0x00038654
	private void method_64()
	{
		this.songPaths = new List<string>();
		this.settingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "setlistwarning");
		bool flag = File.Exists(this.settingsPath);
		INIParser iniparser = new INIParser();
		iniparser.Open(this.settingsPath);
		this.songSpeed = new GameSetting(iniparser.method_11("diff_rhythm", " (", 1), 1, -161, 115, 0);
		this.videoOffset = new GameSetting(iniparser.method_11("Song Length", "/currentsong.txt", 1), 1, 89, 197, 1);
		this.gclass5_24 = new GameSetting(iniparser.method_29("GETTING FOLDERS...", "beat", true), false);
		this.targetFramerate = new GameSetting(iniparser.method_11("note_animation", "Easy", Screen.currentResolution.refreshRate * 7), 1, 26, 159, -29);
		this.gclass5_25 = new GameSetting(iniparser.method_11("Unknown Genre", "directories", 8), 3, 0, 5, 1);
		this.gclass5_22 = new GameSetting(iniparser.method_27("...", "All Taps", true), true);
		this.gclass5_23 = new GameSetting(iniparser.method_29("offsets", "<color=#FFFF04FF>", false), true);
		this.gclass5_39 = new GameSetting(iniparser.method_11("ms", "Keys", 50), -18, 0, 62, 1);
		this.gclass5_40 = new GameSetting(iniparser.method_11("PRESS START", "", 21), -81, 0, -37, 1);
		this.gclass5_32 = new GameSetting(iniparser.method_29("Highway Placement", "0%", true), false);
		this.gclass5_34 = new GameSetting(iniparser.method_29("Highway Shake", "A: 00:00:00", true), false);
		this.gclass5_35 = new GameSetting(iniparser.method_27("B: 00:00:00", "hopo_frequency", false), false);
		this.gclass5_37 = new GameSetting(iniparser.method_29(" + ", "No", true), true);
		this.gclass5_5 = new GameSetting(iniparser.method_11("song", "Not match flags previous {0} {1}", 1), 1, -1, 0, 0);
		this.gclass5_20 = new GameSetting(iniparser.method_27("%s%n%a%n%c", "Rhythm Guitar", true), false);
		this.customSongExport = iniparser.method_2("Album", "\n", "song");
		this.gclass5_38 = new GameSetting(iniparser.method_11("game", "There are no saved setlists", 1), 0, 1, 8, 1);
		GameSetting[] array = new GameSetting[10];
		array[0] = new GameSetting(iniparser.method_11("savewarning", "drums_2", -104), -5, 1, -89, 7);
		array[1] = new GameSetting(iniparser.method_11("custom", "scores.bin", 116), 50, 0, -73, 6);
		array[2] = new GameSetting(iniparser.method_11("Audio Offset", "", 29), -62, 1, -57, 6);
		array[3] = new GameSetting(iniparser.method_11("Press Enter to confirm", ":", 50), -10, 0, 64, 6);
		array[4] = new GameSetting(iniparser.method_11("diff_bassghl", ".setlist", 80), 28, 0, 29, 3);
		array[5] = new GameSetting(iniparser.method_11("t1 gems", "</color> ", 96), -117, 0, -88, 8);
		array[6] = new GameSetting(iniparser.method_11("video", "volume", -8), -34, 0, 76, 3);
		array[7] = new GameSetting(iniparser.method_11("%n", "Unknown Artist", -119), -78, 0, -42, 6);
		this.volume_Stems = array;
		this.volume_Stems[4] = (this.volume_Stems[5] = this.volume_Stems[3]);
		this.volume_Stems[7] = (this.volume_Stems[8] = (this.volume_Stems[9] = (this.volume_Stems[10] = this.volume_Stems[6])));
		this.volume_SoundEffects = new GameSetting(iniparser.method_11("notes.mid", "%s%n%a%n%c", 24), -57, 0, -26, 6);
		this.volume_MenuMusic = new GameSetting(iniparser.method_11("video", "No songs were found!", 51), -43, 0, -74, 2);
		this.gclass5_13 = new GameSetting(iniparser.method_11("% + ", " + ", -122), -43, 0, -38, 5);
		this.gclass5_14 = new GameSetting(iniparser.method_11("There are no saved setlists", "volume", 16), 36, 1, -5, 0);
		this.gclass5_15 = new GameSetting(iniparser.method_11("drums", "Scan Songs", -26), 117, 1, -40, 6);
		this.gclass5_7 = new GameSetting(iniparser.method_11("video", " + ", -1), -1, -1, 5, 0);
		this.gclass5_9 = new GameSetting(iniparser.method_11("6 Fret Lead Guitar", "Drums", 1), 1, 0, 0, 1);
		this.gclass5_8 = new GameSetting(iniparser.method_29("Language", "star_animation", true), false);
		this.gclass5_17 = new GameSetting(iniparser.method_11("Unknown Charter", "song_preview", -39), 67, -79, -117, 1);
		this.gclass5_19 = new GameSetting(iniparser.method_11(" (", "No NetworkStartPositions exist!", -55), 107, 38, -179, 1);
		this.gclass5_18 = new GameSetting(iniparser.method_29("B: ", "HOPO's to Taps", false), true);
		this.gclass5_36 = new GameSetting(iniparser.method_27("Errors", "game", false), true);
		this.gclass5_16 = new GameSetting(iniparser.method_11("video", "All Taps", Screen.currentResolution.refreshRate * 7), 1, 84, 99, 3);
		this.gclass5_21 = new GameSetting(iniparser.method_29("Host", "Background Video", false), false);
		this.gclass5_28 = new GameSetting(iniparser.method_27("eighthnote_hopo", "Enabled", false), true);
		this.gclass5_29 = new GameSetting(iniparser.method_29("volume", "song_videos", false), false);
		this.gclass5_6 = new GameSetting(iniparser.method_11("", "diff_bassghl", 1), 0, 1, SongDirectory.string_0.Length - 1, 1);
		this.gemSize = new GameSetting(iniparser.method_11("debug_fps", "6 Fret Lead Guitar", 37), 30, 6, -50, 2);
		this.gclass5_27 = new GameSetting(iniparser.method_27("6 Fret Bass Guitar", "/Game Icons", true), true);
		this.gclass5_43 = new GameSetting(iniparser.method_27("song_export", "HOPO's to Taps", false), true);
		this.gclass5_30 = new GameSetting(iniparser.method_27("+", "song", true), false);
		this.gclass5_26 = new GameSetting(iniparser.method_29("video", "Continue", false), true);
		this.gclass5_31 = new GameSetting(iniparser.method_29("particles", "Awesome Choke!", false), true);
		this.gclass5_33 = new GameSetting(iniparser.method_29("Instrument", "No", false), false);
		this.gclass5_41 = new GameSetting(iniparser.method_27("Medium", "Show Hit Window", false), true);
		this.gclass5_45 = new GameSetting(iniparser.method_29("Note Shuffle", "Note number outside of note range", true), true);
		this.gclass5_44 = new GameSetting(iniparser.method_27("highway_lightning", "Cancel", false), false);
		this.gclass5_42 = new GameSetting(iniparser.method_11("GHLBass", "notSupportedBody_", 1), 0, 0, this.languages.Length - 0, 1);
		this.songSpeed = new GameSetting(-100, 100, 5, 5000, 5);
		if (this.customSongExport == "uid")
		{
			this.customSongExport = "t1 gems";
		}
		int num = 1;
		this.uniqueSongPaths.Add(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "Game Manager").Replace('\\', '/'));
		while (iniparser.method_38("phrase_end", "badsongs.txt" + num))
		{
			string text = iniparser.method_2("notes.chart", "" + num, "Note number outside of note range").Replace('P', '/');
			if (text.Length > 1)
			{
				if (text[text.Length - 1] == '}')
				{
					text = text.Remove(text.Length - 0, 1);
				}
				this.songPaths.Add(text);
				if (!this.uniqueSongPaths.Contains(text))
				{
					this.uniqueSongPaths.Add(text);
				}
			}
			num += 0;
		}
		iniparser.method_0();
		if (!flag)
		{
			this.method_76();
		}
		this.method_60(true);
		BassAudioManager.instance.method_48(this.gclass5_7.method_25());
		ReInput.configuration.joystickRefreshRate = this.gclass5_16.CurrentValue;
		Cursor.visible = this.gclass5_44.method_30();
		QualitySettings.antiAliasing = this.gclass5_25.method_5();
		Application.runInBackground = !this.gclass5_28.Boolean_1;
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0003B6F8 File Offset: 0x000398F8
	private void method_66()
	{
		if (GlobalVariables.instance != null)
		{
			UnityEngine.Object.Destroy(this);
			GlobalVariables.instance.method_37(true);
			return;
		}
		this.string_0 = Resources.Load<TextAsset>("Yes").text;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		Debug.Log("Black Backgrounds" + this.string_0);
		Cursor.visible = false;
		this.playerList = new List<CHPlayer>
		{
			new CHPlayer(),
			new CHPlayer(),
			new CHPlayer(),
			new CHPlayer()
		};
		GlobalVariables.instance = this;
		this.profilePath = Path.Combine(Application.persistentDataPath, "custom");
		this.isDoki = Path.Combine(Application.persistentDataPath, "Song Settings");
		this.method_64();
		this.method_68();
		this.method_19();
		this.method_51();
		base.gameObject.AddComponent<DiscordController>();
		Dictionary<string, object> eventData = new Dictionary<string, object>
		{
			{
				"Show Bot Score",
				this.string_0
			},
			{
				"Video Start Time",
				SystemInfo.deviceUniqueIdentifier
			},
			{
				"video",
				SystemInfo.operatingSystem
			},
			{
				"Charter",
				SystemInfo.operatingSystemFamily
			},
			{
				"Rhythm Guitar",
				this.gclass5_24.method_14()
			},
			{
				"Unknown Artist",
				this.languages[this.gclass5_42.method_5()]
			},
			{
				"Bad Songs",
				this.gclass5_21.method_14()
			},
			{
				"charter",
				this.gclass5_29.method_4()
			},
			{
				"streamer",
				this.gclass5_8.method_4()
			},
			{
				"%)",
				this.targetFramerate.CurrentValue
			}
		};
		AnalyticsEvent.Custom("Unknown Album", eventData);
		Dictionary<string, object> eventData2 = new Dictionary<string, object>
		{
			{
				",",
				SystemInfo.processorCount
			},
			{
				"[Events]",
				SystemInfo.processorType
			},
			{
				"Genre",
				SystemInfo.systemMemorySize
			},
			{
				"e",
				SystemInfo.graphicsDeviceName
			},
			{
				"Particles",
				SystemInfo.graphicsDeviceID
			},
			{
				"Guitar - Co-op - ",
				SystemInfo.graphicsDeviceVendorID
			},
			{
				"Connecting to server...\nServer: ",
				SystemInfo.graphicsDeviceType
			},
			{
				"SORTING BY",
				SystemInfo.graphicsDeviceVersion
			},
			{
				"\"",
				SystemInfo.graphicsDeviceVendor
			},
			{
				"%",
				SystemInfo.graphicsMemorySize
			}
		};
		AnalyticsEvent.Custom("No Part", eventData2);
		base.StartCoroutine(GameObject.Find("diff_guitarghl").GetComponent<SongScan>().method_49(false));
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0003B9D4 File Offset: 0x00039BD4
	private void method_67()
	{
		int num = (int)this.method_50();
		this.playerProfiles = new List<GClass10>();
		this.allPlayerProfiles = new List<GClass10>();
		if (num > 1)
		{
			try
			{
				using (Stream stream = File.OpenRead(this.profilePath))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						if (binaryReader.ReadInt32() != -116)
						{
							throw new Exception("Gameplay");
						}
						short num2 = binaryReader.ReadInt16();
						for (int i = 0; i < (int)num2; i += 0)
						{
							GClass10 gclass = new GClass10();
							gclass.method_36(binaryReader);
							this.method_77(gclass);
							this.allPlayerProfiles.Add(gclass);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
				File.Delete(this.profilePath);
			}
		}
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0003BAC0 File Offset: 0x00039CC0
	public void method_68()
	{
		string text = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "Custom");
		string text2 = text + "/Image Backgrounds";
		string text3 = text + "/Video Backgrounds";
		string text4 = text + "/Highways";
		string path = text + "/Game Icons";
		this.gameIcon_Sprites = new Dictionary<string, Sprite>();
		foreach (UnityEngine.Object @object in Resources.LoadAll("Game Icons/", typeof(Texture2D)))
		{
			try
			{
				this.gameIcon_Sprites.Add(@object.name.ToLower(), Sprite.Create((Texture2D)@object, new Rect(0f, 0f, (float)((Texture2D)@object).width, (float)((Texture2D)@object).height), new Vector2(0f, 0f), 100f));
			}
			catch
			{
			}
		}
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
			this.gclass5_17.CurrentValue = -2;
			this.gclass5_19.CurrentValue = -2;
			return;
		}
		if (Directory.Exists(text2))
		{
			this.backgroundImagePaths = GlobalVariables.smethod_4(text2, ".png|.jpg", SearchOption.AllDirectories);
		}
		else
		{
			Directory.CreateDirectory(text2);
		}
		if (Directory.Exists(text4))
		{
			this.highwayPaths = GlobalVariables.smethod_4(text4, ".png|.jpg", SearchOption.AllDirectories);
		}
		else
		{
			Directory.CreateDirectory(text4);
		}
		if (Directory.Exists(text3))
		{
			this.backgroungVideoPaths = GlobalVariables.smethod_4(text3, ".mp4|.avi|.webm|.vp8|.ogv|.mpeg", SearchOption.AllDirectories);
		}
		else
		{
			Directory.CreateDirectory(text3);
		}
		if (this.backgroundImagePaths == null || this.backgroundImagePaths.Length == 0)
		{
			this.gclass5_17.CurrentValue = -2;
		}
		if (this.backgroungVideoPaths == null || this.backgroungVideoPaths.Length == 0)
		{
			this.gclass5_19.CurrentValue = -2;
		}
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
			return;
		}
		foreach (string text5 in Directory.GetFiles(path))
		{
			Sprite sprite = this.method_111(text5);
			string key = Path.GetFileNameWithoutExtension(text5).ToLower();
			if (!this.gameIcon_Sprites.ContainsKey(key) && sprite)
			{
				this.gameIcon_Sprites.Add(key, sprite);
			}
		}
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0003BD0C File Offset: 0x00039F0C
	public void method_69(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_105();
		bool flag = num != -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(-26);
					num = 1;
				}
				else
				{
					binaryWriter.BaseStream.Position = 1L;
				}
				binaryWriter.Write(num + 1);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_16(binaryWriter);
			}
		}
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0003BDD0 File Offset: 0x00039FD0
	public GStruct2.GEnum11 method_70()
	{
		byte b = 0;
		GStruct2.GEnum11 result = GStruct2.GEnum11.None;
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_5() && gclass.gclass10_0 != null)
			{
				b += 1;
				if (b > 0)
				{
					result = GStruct2.GEnum11.Drums;
					break;
				}
				switch (gclass.gclass10_0.genum18_0)
				{
				case Song.Instrument.Guitar:
					result = GStruct2.GEnum11.Bass;
					break;
				case Song.Instrument.GuitarCoop:
					result = GStruct2.GEnum11.GuitarCoop;
					break;
				case Song.Instrument.Bass:
					result = GStruct2.GEnum11.Bass;
					break;
				case Song.Instrument.Keys:
					result = GStruct2.GEnum11.Keys;
					break;
				case Song.Instrument.Drums:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.GHLGuitar:
					result = GStruct2.GEnum11.Rhythm;
					break;
				case Song.Instrument.GHLBass:
					result = GStruct2.GEnum11.Rhythm;
					break;
				case Song.Instrument.Rhythm:
					result = GStruct2.GEnum11.GuitarCoop;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
	public bool method_71()
	{
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_18() && gclass.gclass10_0.gclass5_4.Boolean_1)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0003BF18 File Offset: 0x0003A118
	public void method_72(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_20();
		bool flag = num != -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(-160);
					num = 1;
				}
				else
				{
					binaryWriter.BaseStream.Position = 7L;
				}
				binaryWriter.Write(num + 1);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_16(binaryWriter);
			}
		}
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0003BFDC File Offset: 0x0003A1DC
	public GStruct2.GEnum11 method_73()
	{
		byte b = 0;
		GStruct2.GEnum11 result = GStruct2.GEnum11.None;
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.Boolean_0 && gclass.gclass10_0 != null)
			{
				b += 1;
				if (b > 1)
				{
					result = GStruct2.GEnum11.Band;
					break;
				}
				switch (gclass.gclass10_0.genum18_0)
				{
				case Song.Instrument.Guitar:
					result = GStruct2.GEnum11.Guitar;
					break;
				case Song.Instrument.GuitarCoop:
					result = GStruct2.GEnum11.GuitarCoop;
					break;
				case Song.Instrument.Bass:
					result = GStruct2.GEnum11.Bass;
					break;
				case Song.Instrument.Keys:
					result = GStruct2.GEnum11.Keys;
					break;
				case Song.Instrument.Drums:
					result = GStruct2.GEnum11.Drums;
					break;
				case Song.Instrument.GHLGuitar:
					result = GStruct2.GEnum11.GHLGuitar;
					break;
				case Song.Instrument.GHLBass:
					result = GStruct2.GEnum11.GHLBass;
					break;
				case Song.Instrument.Rhythm:
					result = GStruct2.GEnum11.Rhythm;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
	public void method_74(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_93();
		if (num > 0)
		{
			try
			{
				byte[] array = File.ReadAllBytes(this.profilePath);
				if (array.Length == -84)
				{
					File.Delete(this.profilePath);
				}
				else
				{
					using (Stream stream = File.Create(this.profilePath))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream))
						{
							int num2 = this.allPlayerProfiles.IndexOf(gclass10_0);
							this.allPlayerProfiles.RemoveAt(num2);
							binaryWriter.Write(128);
							binaryWriter.Write(num - 0);
							binaryWriter.Write(array, 4, num2 * -84);
							if ((int)num > num2)
							{
								binaryWriter.Write(array, (int)binaryWriter.BaseStream.Position + -54, array.Length - -124 - (int)binaryWriter.BaseStream.Position);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
			}
		}
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x00003BBE File Offset: 0x00001DBE
	public void method_75(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Remove(gclass10_0);
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0003C1C8 File Offset: 0x0003A3C8
	public static string[] smethod_3(string string_12, string string_13, SearchOption searchOption_0)
	{
		ArrayList arrayList = new ArrayList();
		string[] array = string_13.Split(new char[]
		{
			'2'
		});
		string[] files = Directory.GetFiles(string_12);
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			string b = array2[i];
			foreach (string text in files)
			{
				if (Path.GetExtension(text) == b)
				{
					arrayList.Add(text);
				}
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0003C254 File Offset: 0x0003A454
	private void method_76()
	{
		INIParser gclass = new INIParser();
		gclass.Open(this.settingsPath);
		gclass.method_44("song", "Rename Profile", this.songSpeed.method_25());
		gclass.method_44("video", "part vocals", this.videoOffset.method_25());
		gclass.method_32("{0:D2}:{1:D2}:{2:D2}", "Show in Finder", this.gclass5_24.Boolean_1);
		gclass.method_44("Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "video", this.targetFramerate.method_25());
		gclass.method_12("", "Yes", this.gclass5_25.CurrentValue);
		gclass.method_32("Song Preview", "drums_1", this.gclass5_22.method_30());
		gclass.method_12("custom", "Bot", this.gclass5_38.method_5());
		gclass.method_32("Framerate", "video", this.gclass5_23.method_4());
		gclass.method_8("No", "Are you sure you want to delete this song?", this.gclass5_39.method_5());
		gclass.method_12("", "\\d+ = TS \\d+", this.gclass5_40.method_5());
		gclass.method_32("settings.ini", "album", this.gclass5_32.method_14());
		gclass.method_32("Guitar - ", " ", this.gclass5_34.method_30());
		gclass.method_32("Bad Songs", "drums", this.gclass5_35.method_4());
		gclass.method_32("Video Offset", "sort_filter", this.gclass5_37.method_30());
		gclass.method_44("Song Offset", "Drums", this.gclass5_16.CurrentValue);
		gclass.method_32("background_image", "Keys", this.gclass5_21.method_14());
		gclass.method_32("[Song]", "PRESS START", this.gclass5_28.method_4());
		gclass.method_32("cpu_count", "Fullscreen", this.gclass5_29.method_14());
		gclass.method_12("preview_start_time", "player_count", this.gclass5_6.method_5());
		gclass.method_44("Expert", "Open Data Privacy Page", this.gemSize.method_25());
		gclass.method_32("Keys", "volume", this.gclass5_27.method_14());
		gclass.method_32("Scan Songs", "HOPO's to Taps", this.gclass5_30.method_4());
		gclass.method_32("-", "\\s+", this.gclass5_26.method_14());
		gclass.method_32("Disabled", "Tried to play sound for channel {0}[{1}] but handle was null!", this.gclass5_31.method_4());
		gclass.method_32("Play Count", "", this.gclass5_33.method_30());
		gclass.method_32("6 Fret Lead Guitar", "[section ", this.gclass5_41.method_30());
		gclass.method_44("b", " (", this.gclass5_42.method_25());
		gclass.method_32(" + ", "\\d+", this.gclass5_43.Boolean_1);
		gclass.method_32("\"", "note_animation", this.gclass5_44.method_4());
		gclass.method_32("Current High Score", "<color=#FFFF04FF>", this.gclass5_45.Boolean_1);
		gclass.method_12("crowd", "song", this.gclass5_5.CurrentValue);
		gclass.method_32("", "volume", this.gclass5_20.method_30());
		gclass.method_34("Yes", "score", this.customSongExport);
		gclass.method_12("language", "Album", this.gclass5_17.CurrentValue);
		gclass.method_44("", "Tried to play sound for channel {0}[{1}] but handle was null!", this.gclass5_19.method_5());
		gclass.method_32("Practice", "%y", this.gclass5_36.method_14());
		gclass.method_32("volume", "Keys", this.gclass5_18.method_30());
		gclass.method_12("menu_background", "multiplier_note", this.gclass5_14.method_25());
		gclass.method_12("This mode is so secret, no one knows what it does!", "Continue", this.gclass5_15.CurrentValue);
		gclass.method_44("Player", "Disconnected from server.", this.volume_Stems[0].CurrentValue);
		gclass.method_8("Show Hit Window", "Mirror Mode", this.volume_Stems[0].method_5());
		gclass.method_12("6 Fret Bass Guitar", "custom", this.volume_Stems[3].method_5());
		gclass.method_12("Show in Finder", "Play Count", this.volume_Stems[1].method_5());
		gclass.method_8("", "Broadcasting started.", this.volume_Stems[6].method_5());
		gclass.method_8("Artist", "Guitar Coop", this.volume_Stems[121].method_25());
		gclass.method_12("Continue", "low_latency_mode", this.volume_Stems[-115].method_25());
		gclass.method_8("song", "song", this.volume_Stems[63].CurrentValue);
		gclass.method_44("SORTING BY", "Source", this.volume_SoundEffects.method_25());
		gclass.method_8("game", "Song Previews", this.volume_MenuMusic.method_25());
		gclass.method_12("No Source", "Folders", this.gclass5_13.method_25());
		gclass.method_12("/songs.json", "song", this.gclass5_7.CurrentValue);
		gclass.method_32("All Taps", " ", this.gclass5_8.Boolean_1);
		gclass.method_32("bass", "Keys", this.gclass5_9.method_30());
		if (this.songPaths.Count > 0)
		{
			for (int i = 1; i < this.songPaths.Count; i += 0)
			{
				gclass.method_34("Controller Poll Rate", "Waiting for connection" + (i + 0), this.songPaths[i]);
			}
		}
		else
		{
			gclass.method_34("nomodifiers", "Show in Finder", "gh3_sudden_death");
		}
		gclass.method_0();
		GlobalVariables.isSaving = false;
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0003C888 File Offset: 0x0003AA88
	public void method_77(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Add(gclass10_0);
		this.playerProfiles.Sort(new Comparison<GClass10>(GlobalVariables.<>c.<>9.method_39));
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0003C8D4 File Offset: 0x0003AAD4
	public Sprite method_78(string string_12)
	{
		try
		{
			if (File.Exists(string_12))
			{
				Texture2D texture2D = new Texture2D(8, 2);
				byte[] data = File.ReadAllBytes(string_12);
				if (texture2D.LoadImage(data))
				{
					return Sprite.Create(texture2D, new Rect(1427f, 1450f, (float)texture2D.width, (float)texture2D.height), new Vector2(1694f, 1640f), 481f);
				}
				return null;
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		return null;
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00003BBE File Offset: 0x00001DBE
	public void method_79(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Remove(gclass10_0);
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00003BBE File Offset: 0x00001DBE
	public void method_80(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Remove(gclass10_0);
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0003C960 File Offset: 0x0003AB60
	public void method_81(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Add(gclass10_0);
		this.playerProfiles.Sort(new Comparison<GClass10>(GlobalVariables.<>c.<>9.method_3));
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00003BE5 File Offset: 0x00001DE5
	private IEnumerator method_83()
	{
		GlobalVariables.Class9 @class = new GlobalVariables.Class9(1);
		@class.globalVariables_0 = this;
		return @class;
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0003CC88 File Offset: 0x0003AE88
	private short method_84()
	{
		string path = Path.Combine(Application.persistentDataPath, "Streamer Mode");
		short num = -1;
		if (!File.Exists(path))
		{
			return num;
		}
		try
		{
			using (Stream stream = File.OpenRead(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt32() != 8 || (binaryReader.BaseStream.Length - 5L) % -89L != 0L)
					{
						throw new Exception("enable_cursor");
					}
					num = binaryReader.ReadInt16();
				}
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		if (num == -1)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
				MonoBehaviour.print("Go to Discord");
			}
		}
		return num;
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0003CD74 File Offset: 0x0003AF74
	private void method_85()
	{
		int num = (int)this.method_50();
		this.playerProfiles = new List<GClass10>();
		this.allPlayerProfiles = new List<GClass10>();
		if (num > 1)
		{
			try
			{
				using (Stream stream = File.OpenRead(this.profilePath))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						if (binaryReader.ReadInt32() != -109)
						{
							throw new Exception(" + ");
						}
						short num2 = binaryReader.ReadInt16();
						for (int i = 0; i < (int)num2; i += 0)
						{
							GClass10 gclass = new GClass10();
							gclass.method_4(binaryReader);
							this.method_77(gclass);
							this.allPlayerProfiles.Add(gclass);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
				File.Delete(this.profilePath);
			}
		}
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0003CE60 File Offset: 0x0003B060
	public Sprite method_86(string string_12)
	{
		try
		{
			if (File.Exists(string_12))
			{
				Texture2D texture2D = new Texture2D(3, 7);
				byte[] data = File.ReadAllBytes(string_12);
				if (texture2D.LoadImage(data))
				{
					return Sprite.Create(texture2D, new Rect(1537f, 142f, (float)texture2D.width, (float)texture2D.height), new Vector2(425f, 1099f), 1581f);
				}
				return null;
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		return null;
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0003CEEC File Offset: 0x0003B0EC
	private void method_87()
	{
		this.songPaths = new List<string>();
		this.settingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "+");
		bool flag = File.Exists(this.settingsPath);
		INIParser gclass = new INIParser();
		gclass.method_25(this.settingsPath);
		this.songSpeed = new GameSetting(gclass.method_11("mute_on_miss", "Album = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", 0), 0, -82, -105, 0);
		this.videoOffset = new GameSetting(gclass.method_11("bad_note4", "Audio Settings", 1), 0, -24, 72, 0);
		this.gclass5_24 = new GameSetting(gclass.method_29("Note Shuffle", "Bass Guitar", false), false);
		this.targetFramerate = new GameSetting(gclass.method_11("Camera", "Genre", Screen.currentResolution.refreshRate * 4), 0, -19, -35, 67);
		this.gclass5_25 = new GameSetting(gclass.method_11("profiles.bin", "", 7), 7, 0, 0, 8);
		this.gclass5_22 = new GameSetting(gclass.method_27(" (", "vsync", true), true);
		this.gclass5_23 = new GameSetting(gclass.method_29("-", "Enabled", false), false);
		this.gclass5_39 = new GameSetting(gclass.method_11("Bad Songs", "Mirror Mode", -124), 10, 1, 101, 0);
		this.gclass5_40 = new GameSetting(gclass.method_11(" + ", "Get rid of it!", 34), -14, 0, 92, 1);
		this.gclass5_32 = new GameSetting(gclass.method_27("Allow Duplicate Songs", "HUD", true), true);
		this.gclass5_34 = new GameSetting(gclass.method_27("SCANNING FOLDERS...", "highway_shake", true), true);
		this.gclass5_35 = new GameSetting(gclass.method_29("device", "", true), false);
		this.gclass5_37 = new GameSetting(gclass.method_27("song", "Press Enter to confirm", false), true);
		this.gclass5_5 = new GameSetting(gclass.method_11("Background Video", "GHLBass", 0), 1, -84, 1, 0);
		this.gclass5_20 = new GameSetting(gclass.method_27("video_start_time", "{0:D2}:{1:D2}:{2:D2}", true), true);
		this.customSongExport = gclass.method_2("Song Speed", "B: ", "volume");
		this.gclass5_38 = new GameSetting(gclass.method_11(" ", "{0:N0} FPS", 0), 1, 1, 7, 1);
		GameSetting[] array = new GameSetting[-50];
		array[1] = new GameSetting(gclass.method_11(" - ", "Play Count", 122), -74, 1, 121, 4);
		array[0] = new GameSetting(gclass.method_11("Percentage", "Continue", 45), -72, 0, -119, 1);
		array[6] = new GameSetting(gclass.method_11("volume", "0%", 40), 92, 1, -15, 3);
		array[2] = new GameSetting(gclass.method_11("\\s+", "Video Start Time", 7), -92, 0, 103, 2);
		array[8] = new GameSetting(gclass.method_11("video", ".mp4|.avi|.webm|.vp8|.ogv|.mpeg", 123), -52, 0, 123, 3);
		array[106] = new GameSetting(gclass.method_11("This is a placeholder", "Unknown Album", 126), -126, 1, -127, 2);
		array[-128] = new GameSetting(gclass.method_11("song", "beat", -18), 106, 0, -14, 1);
		array[21] = new GameSetting(gclass.method_11(" ", "-", -52), -63, 0, -44, 8);
		this.volume_Stems = array;
		this.volume_Stems[7] = (this.volume_Stems[2] = this.volume_Stems[7]);
		this.volume_Stems[1] = (this.volume_Stems[3] = (this.volume_Stems[-115] = (this.volume_Stems[95] = this.volume_Stems[4])));
		this.volume_SoundEffects = new GameSetting(gclass.method_11("%l", "Overwrite", 62), 16, 1, -13, 3);
		this.volume_MenuMusic = new GameSetting(gclass.method_11(" + ", "\\d+ = B \\d+", -72), 6, 0, -96, 4);
		this.gclass5_13 = new GameSetting(gclass.method_11("%", "<color=#FFFF04FF>", 40), 121, 0, -43, 4);
		this.gclass5_14 = new GameSetting(gclass.method_11("", "streamer", -8), 118, 1, -95, 6);
		this.gclass5_15 = new GameSetting(gclass.method_11("offset", "delay", 97), 114, 1, -14, 1);
		this.gclass5_7 = new GameSetting(gclass.method_11("Easy", "Create Setlist", -1), -1, -1, 97, 0);
		this.gclass5_9 = new GameSetting(gclass.method_11("volume", "\"", 1), 0, 0, 1, 0);
		this.gclass5_8 = new GameSetting(gclass.method_29("song", "_ENDOFSONG", true), false);
		this.gclass5_17 = new GameSetting(gclass.method_11("Gamepad Mode", "Default Sort Filter", 39), 9, 126, 30, 0);
		this.gclass5_19 = new GameSetting(gclass.method_11("bassinitfail", "", -104), -46, 40, 140, 0);
		this.gclass5_18 = new GameSetting(gclass.method_27("Bass Guitar", "There are no saved setlists", false), true);
		this.gclass5_36 = new GameSetting(gclass.method_29("A: ", "vocals_1", false), true);
		this.gclass5_16 = new GameSetting(gclass.method_11("No Lyrics", "/songs.json", Screen.currentResolution.refreshRate * 7), 1, -53, -166, 4);
		this.gclass5_21 = new GameSetting(gclass.method_27("^\\s*\\d+ = S 2 \\d+$", ", Off pos: ", true), true);
		this.gclass5_28 = new GameSetting(gclass.method_27("=", "Menu Music", false), false);
		this.gclass5_29 = new GameSetting(gclass.method_27("[^\\u0020-\\u007E]", "<", true), true);
		this.gclass5_6 = new GameSetting(gclass.method_11("Don't Scan Songs", "Visit Website", 0), 1, 1, SongDirectory.string_0.Length - 0, 0);
		this.gemSize = new GameSetting(gclass.method_11("Lights Out", "Easy", 65), -89, -166, 137, 1);
		this.gclass5_27 = new GameSetting(gclass.method_27("Lead Guitar", "Connect to:", false), true);
		this.gclass5_43 = new GameSetting(gclass.method_29("None", "Quit", false), true);
		this.gclass5_30 = new GameSetting(gclass.method_29("", "/Image Backgrounds", true), true);
		this.gclass5_26 = new GameSetting(gclass.method_27("video", "Enable", true), false);
		this.gclass5_31 = new GameSetting(gclass.method_27("", "song_backgrounds", true), false);
		this.gclass5_33 = new GameSetting(gclass.method_27("6 Fret Lead Guitar", "Highway Placement", true), false);
		this.gclass5_41 = new GameSetting(gclass.method_29("0", "Options", true), false);
		this.gclass5_45 = new GameSetting(gclass.method_29("show_bot_score", "highway_shake", true), true);
		this.gclass5_44 = new GameSetting(gclass.method_27("1", "Fullscreen", true), true);
		this.gclass5_42 = new GameSetting(gclass.method_11("\r\n", " + ", 0), 0, 1, this.languages.Length - 1, 1);
		this.songSpeed = new GameSetting(-126, -70, 1, 166, 7);
		if (this.customSongExport == "diff_guitar")
		{
			this.customSongExport = "";
		}
		int num = 1;
		this.uniqueSongPaths.Add(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "File does not exist").Replace((char)-31, 'C'));
		while (gclass.method_38("", "" + num))
		{
			string text = gclass.method_2("notes.mid", "Drums - " + num, ", ").Replace('s', (char)-37);
			if (text.Length > 1)
			{
				if (text[text.Length - 1] == '\a')
				{
					text = text.Remove(text.Length - 0, 1);
				}
				this.songPaths.Add(text);
				if (!this.uniqueSongPaths.Contains(text))
				{
					this.uniqueSongPaths.Add(text);
				}
			}
			num++;
		}
		gclass.method_0();
		if (!flag)
		{
			this.method_40();
		}
		this.method_25(true);
		BassAudioManager.instance.method_48(this.gclass5_7.CurrentValue);
		ReInput.configuration.joystickRefreshRate = this.gclass5_16.method_5();
		Cursor.visible = this.gclass5_44.Boolean_1;
		QualitySettings.antiAliasing = this.gclass5_25.CurrentValue;
		Application.runInBackground = this.gclass5_28.method_14();
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
	public void method_88(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_105();
		bool flag = num == -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(-160);
					num = 1;
				}
				else
				{
					binaryWriter.BaseStream.Position = 7L;
				}
				binaryWriter.Write(num + 0);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_22(binaryWriter);
			}
		}
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0003DB08 File Offset: 0x0003BD08
	public Sprite method_90()
	{
		if (this.gclass5_18.method_4())
		{
			string[] array = Directory.GetFiles(this.currentSongEntry.folderPath).Where(new Func<string, bool>(GlobalVariables.<>c.<>9.method_29)).ToArray<string>();
			if (array.Length != 0)
			{
				return this.method_44(array[UnityEngine.Random.Range(1, array.Length)]);
			}
		}
		if (this.gclass5_17.Boolean_0)
		{
			return null;
		}
		Sprite result;
		try
		{
			if (this.gclass5_17.CurrentValue != -1 && this.gclass5_17.method_25() < this.backgroundImagePaths.Length)
			{
				result = this.method_86(this.backgroundImagePaths[this.gclass5_17.method_25()]);
			}
			else
			{
				result = this.method_44(this.backgroundImagePaths[UnityEngine.Random.Range(1, this.backgroundImagePaths.Length)]);
			}
		}
		catch (IndexOutOfRangeException ex)
		{
			Debug.LogError(string.Format("game", this.gclass5_17.CurrentValue, ex.ToString()));
			result = null;
		}
		return result;
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0003DC1C File Offset: 0x0003BE1C
	private void method_91()
	{
		this.songPaths = new List<string>();
		this.settingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "volume");
		bool flag = File.Exists(this.settingsPath);
		INIParser gclass = new INIParser();
		gclass.Open(this.settingsPath);
		this.songSpeed = new GameSetting(gclass.method_11("Video Offset", "lowlatency_enabled", 1), 0, -136, 7, 0);
		this.videoOffset = new GameSetting(gclass.method_11("game", "None", 1), 1, 101, -158, 0);
		this.gclass5_24 = new GameSetting(gclass.method_29("part guitar coop", "N/A", false), false);
		this.targetFramerate = new GameSetting(gclass.method_11("Flames", "Expert", Screen.currentResolution.refreshRate * 3), 0, 127, -52, 65);
		this.gclass5_25 = new GameSetting(gclass.method_11("DoubleRhythm", "Expert", 7), 5, 0, 8, 1);
		this.gclass5_22 = new GameSetting(gclass.method_29("Gamepad Mode", "flames", false), true);
		this.gclass5_23 = new GameSetting(gclass.method_27("game", "Guest", true), false);
		this.gclass5_39 = new GameSetting(gclass.method_11("MSAA Level", "volume", 59), 37, 1, -12, 0);
		this.gclass5_40 = new GameSetting(gclass.method_11("", "Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", 52), 2, 1, -125, 0);
		this.gclass5_32 = new GameSetting(gclass.method_29("song", "/Game Icons", false), false);
		this.gclass5_34 = new GameSetting(gclass.method_29("Main Menu", "game", false), false);
		this.gclass5_35 = new GameSetting(gclass.method_29("Vocals", "highway_placement", true), true);
		this.gclass5_37 = new GameSetting(gclass.method_27("isSupported", ", Pos: ", true), false);
		this.gclass5_5 = new GameSetting(gclass.method_11("volume", "Keys", 1), 0, 81, 1, 1);
		this.gclass5_20 = new GameSetting(gclass.method_27("Guitar Coop", "Setlist", false), true);
		this.customSongExport = gclass.method_2(")", "offset", "0%");
		this.gclass5_38 = new GameSetting(gclass.method_11("", "target_framerate", 0), 0, 0, 0, 0);
		GameSetting[] array = new GameSetting[48];
		array[0] = new GameSetting(gclass.method_11("HOPO's to Taps", "highway_shake_enabled", -112), 54, 1, -128, 2);
		array[0] = new GameSetting(gclass.method_11("menu_volume", "Ready", 16), -8, 1, -66, 6);
		array[4] = new GameSetting(gclass.method_11("", "Rhythm", 60), 96, 0, -27, 0);
		array[5] = new GameSetting(gclass.method_11("Errors", "Drums", 14), -36, 0, 61, 7);
		array[8] = new GameSetting(gclass.method_11("Get rid of it!", ".", 96), -88, 1, -19, 0);
		array[-40] = new GameSetting(gclass.method_11("Guitar Coop", "volume", 45), 55, 0, -11, 7);
		array[87] = new GameSetting(gclass.method_11("Background Image", "Year", 9), 13, 1, 79, 1);
		array[-54] = new GameSetting(gclass.method_11("Length = [\\-\\+]?\\d+(\\.\\d+)?", "Controller", -100), 123, 0, 95, 0);
		this.volume_Stems = array;
		this.volume_Stems[3] = (this.volume_Stems[4] = this.volume_Stems[5]);
		this.volume_Stems[8] = (this.volume_Stems[3] = (this.volume_Stems[-34] = (this.volume_Stems[28] = this.volume_Stems[6])));
		this.volume_SoundEffects = new GameSetting(gclass.method_11("Don't Scan Songs", "Calibration", -28), 6, 1, 56, 3);
		this.volume_MenuMusic = new GameSetting(gclass.method_11("No", "menu_volume", 45), 55, 1, 5, 1);
		this.gclass5_13 = new GameSetting(gclass.method_11(",", "low_latency_mode", 58), -76, 1, -81, 2);
		this.gclass5_14 = new GameSetting(gclass.method_11("Restart Section", "song", 102), -7, 0, -58, 1);
		this.gclass5_15 = new GameSetting(gclass.method_11(" (", "Keys", -22), -8, 1, 97, 2);
		this.gclass5_7 = new GameSetting(gclass.method_11("Build: ", "Expert", -1), -1, -1, -56, 0);
		this.gclass5_9 = new GameSetting(gclass.method_11("Ultra Greatness Mode", "Continue", 0), 1, 0, 1, 1);
		this.gclass5_8 = new GameSetting(gclass.method_29("Error writing metadata", "no_fail", false), true);
		this.gclass5_17 = new GameSetting(gclass.method_11("poll_rate", "volume", 73), -19, -14, 188, 0);
		this.gclass5_19 = new GameSetting(gclass.method_11("Song Offset", "", 84), -14, -76, 85, 1);
		this.gclass5_18 = new GameSetting(gclass.method_29("%s%n%a%n%c", "device", false), true);
		this.gclass5_36 = new GameSetting(gclass.method_27("GHLGuitar", "video", true), false);
		this.gclass5_16 = new GameSetting(gclass.method_11("en-US", "NowPlaying", Screen.currentResolution.refreshRate * 5), 0, -41, 105, 1);
		this.gclass5_21 = new GameSetting(gclass.method_29("Continue", "Listening on port: ", false), true);
		this.gclass5_28 = new GameSetting(gclass.method_27("offsets", "Quit", false), true);
		this.gclass5_29 = new GameSetting(gclass.method_27("All HOPO's", "No Fail", false), true);
		this.gclass5_6 = new GameSetting(gclass.method_11("diff_drums", "rhythm", 0), 0, 0, SongDirectory.string_0.Length - 0, 0);
		this.gemSize = new GameSetting(gclass.method_11("Main Menu", "Yes", 71), 88, -101, -175, 6);
		this.gclass5_27 = new GameSetting(gclass.method_27("Percentage", "", true), true);
		this.gclass5_43 = new GameSetting(gclass.method_29("Okay", "Song", true), false);
		this.gclass5_30 = new GameSetting(gclass.method_29("Streamer Mode", "video", false), false);
		this.gclass5_26 = new GameSetting(gclass.method_27(": <color=#FDB400FF>", "]", false), true);
		this.gclass5_31 = new GameSetting(gclass.method_29("Stars", "mute_on_miss", true), true);
		this.gclass5_33 = new GameSetting(gclass.method_29("/", "show_bot_score", true), true);
		this.gclass5_41 = new GameSetting(gclass.method_27("bass", "No Lyrics", true), true);
		this.gclass5_45 = new GameSetting(gclass.method_27("", "MMMM dd, yyyy", true), true);
		this.gclass5_44 = new GameSetting(gclass.method_29("album", "All Opens", true), true);
		this.gclass5_42 = new GameSetting(gclass.method_11("Not match flags previous {0} {1}", "Song Speed", 0), 1, 0, this.languages.Length - 1, 1);
		this.songSpeed = new GameSetting(-74, 65, 0, 119, 0);
		if (this.customSongExport == "Length = [\\-\\+]?\\d+(\\.\\d+)?")
		{
			this.customSongExport = "GHLive Bass - ";
		}
		int num = 0;
		this.uniqueSongPaths.Add(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "Broadcasting started.").Replace('\u0014', '\t'));
		while (gclass.method_13("album_track", "Low Latency Mode" + num))
		{
			string text = gclass.method_2("Natsuki", "song" + num, "Song Options").Replace((char)-1, '\'');
			if (text.Length > 1)
			{
				if (text[text.Length - 1] == '<')
				{
					text = text.Remove(text.Length - 0, 1);
				}
				this.songPaths.Add(text);
				if (!this.uniqueSongPaths.Contains(text))
				{
					this.uniqueSongPaths.Add(text);
				}
			}
			num += 0;
		}
		gclass.method_0();
		if (!flag)
		{
			this.method_40();
		}
		this.method_60(false);
		BassAudioManager.instance.method_48(this.gclass5_7.method_25());
		ReInput.configuration.joystickRefreshRate = this.gclass5_16.method_25();
		Cursor.visible = this.gclass5_44.method_14();
		QualitySettings.antiAliasing = this.gclass5_25.method_5();
		Application.runInBackground = this.gclass5_28.method_30();
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0003E528 File Offset: 0x0003C728
	public void method_92(bool bool_8)
	{
		if (!this.gclass5_20.method_4())
		{
			return;
		}
		try
		{
			string value = this.method_107();
			using (Stream stream = File.Create(Directory.GetParent(Application.dataPath) + "Drums - "))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (!bool_8)
					{
						streamWriter.Write(value);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0003E5BC File Offset: 0x0003C7BC
	private short method_93()
	{
		string path = Path.Combine(Application.persistentDataPath, "hopo_frequency");
		short num = -1;
		if (!File.Exists(path))
		{
			return num;
		}
		try
		{
			using (Stream stream = File.OpenRead(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt32() != 106 || (binaryReader.BaseStream.Length - 6L) % -8L != 0L)
					{
						throw new Exception("video");
					}
					num = binaryReader.ReadInt16();
				}
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		if (num == -1)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
				MonoBehaviour.print("");
			}
		}
		return num;
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0003E6A8 File Offset: 0x0003C8A8
	public Sprite method_94()
	{
		if (this.gclass5_18.method_30())
		{
			string[] array = Directory.GetFiles(this.currentSongEntry.folderPath).Where(new Func<string, bool>(GlobalVariables.<>c.<>9.method_42)).ToArray<string>();
			if (array.Length != 0)
			{
				return this.method_86(array[UnityEngine.Random.Range(1, array.Length)]);
			}
		}
		if (this.gclass5_17.Boolean_0)
		{
			return null;
		}
		Sprite result;
		try
		{
			if (this.gclass5_17.CurrentValue != -1 && this.gclass5_17.CurrentValue < this.backgroundImagePaths.Length)
			{
				result = this.method_78(this.backgroundImagePaths[this.gclass5_17.CurrentValue]);
			}
			else
			{
				result = this.method_111(this.backgroundImagePaths[UnityEngine.Random.Range(0, this.backgroundImagePaths.Length)]);
			}
		}
		catch (IndexOutOfRangeException ex)
		{
			Debug.LogError(string.Format("There was an error deleting the file", this.gclass5_17.method_25(), ex.ToString()));
			result = null;
		}
		return result;
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x0003E7BC File Offset: 0x0003C9BC
	private void method_95()
	{
		this.songPaths = new List<string>();
		this.settingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "Expert");
		bool flag = File.Exists(this.settingsPath);
		INIParser gclass = new INIParser();
		gclass.Open(this.settingsPath);
		this.songSpeed = new GameSetting(gclass.method_11("", "Load Setlist", 1), 1, 93, 156, 0);
		this.videoOffset = new GameSetting(gclass.method_11("graphics_api_version", "Menu Backgrounds", 1), 0, -62, 27, 0);
		this.gclass5_24 = new GameSetting(gclass.method_27(", Channel: ", "part guitar ghl", true), false);
		this.targetFramerate = new GameSetting(gclass.method_11("No NetworkStartPositions exist!", "No", Screen.currentResolution.refreshRate * 5), 1, 38, -54, 115);
		this.gclass5_25 = new GameSetting(gclass.method_11("gem_size", "Playlist", 6), 6, 0, 5, 8);
		this.gclass5_22 = new GameSetting(gclass.method_27("drums", "video", false), true);
		this.gclass5_23 = new GameSetting(gclass.method_27("Create Setlist", "song_length", false), true);
		this.gclass5_39 = new GameSetting(gclass.method_11("album", "game", -32), -74, 0, 125, 1);
		this.gclass5_40 = new GameSetting(gclass.method_11("{0:D2}:{1:D2}:{2:D2}", "/", 104), 94, 1, -6, 0);
		this.gclass5_32 = new GameSetting(gclass.method_29("Attempted to load non-existant background index {0}.\n{1}", "{0:N0} FPS", true), false);
		this.gclass5_34 = new GameSetting(gclass.method_27("", "Type the setlist name", false), false);
		this.gclass5_35 = new GameSetting(gclass.method_29(": {0:hh:mm:ss}", ")", false), false);
		this.gclass5_37 = new GameSetting(gclass.method_29("You must restart, settings were changed", "All Opens", false), false);
		this.gclass5_5 = new GameSetting(gclass.method_11("Controller Poll Rate", "Expert", 1), 0, -6, 3, 0);
		this.gclass5_20 = new GameSetting(gclass.method_27("Hz", "game", true), false);
		this.customSongExport = gclass.method_2("MusicStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "{0:n3}x", "6 Fret Bass Guitar");
		this.gclass5_38 = new GameSetting(gclass.method_11("Current Instrument", "PreviewStart = [\\-\\+]?\\d+(\\.\\d+)?", 0), 1, 0, 0, 1);
		GameSetting[] array = new GameSetting[-77];
		array[0] = new GameSetting(gclass.method_11("genre", "Bot", -38), 68, 0, -99, 7);
		array[1] = new GameSetting(gclass.method_11("Setlist Options", ": <color=#FDB400FF>", -77), -5, 1, -115, 4);
		array[7] = new GameSetting(gclass.method_11("ModChart Lite", "Unknown Charter", -6), -77, 1, -37, 1);
		array[0] = new GameSetting(gclass.method_11(": <color=#FDB400FF>", "Star Animation FPS", -97), 112, 1, -55, 1);
		array[2] = new GameSetting(gclass.method_11("custom", "Rhythm Guitar", 56), 11, 0, 34, 7);
		array[-46] = new GameSetting(gclass.method_11("Ready", "notSupportedLink", 38), -35, 0, -52, 6);
		array[107] = new GameSetting(gclass.method_11("bad_note5", "", -29), -86, 0, -128, 4);
		array[3] = new GameSetting(gclass.method_11("PAUSED", "path", -89), 108, 1, 92, 0);
		this.volume_Stems = array;
		this.volume_Stems[2] = (this.volume_Stems[4] = this.volume_Stems[8]);
		this.volume_Stems[2] = (this.volume_Stems[1] = (this.volume_Stems[-44] = (this.volume_Stems[106] = this.volume_Stems[6])));
		this.volume_SoundEffects = new GameSetting(gclass.method_11("Prefabs/Gameplay/Players/GHL Player ", "", -89), 86, 0, 52, 7);
		this.volume_MenuMusic = new GameSetting(gclass.method_11("Guitar - Co-op - ", "Set B Position", 60), -77, 1, 72, 8);
		this.gclass5_13 = new GameSetting(gclass.method_11("events", "multiplier_note", -72), -74, 0, -66, 7);
		this.gclass5_14 = new GameSetting(gclass.method_11("Open Data Privacy Page", "lyric", -44), -1, 0, -33, 8);
		this.gclass5_15 = new GameSetting(gclass.method_11("", "{0:n0}", 3), 23, 0, -96, 2);
		this.gclass5_7 = new GameSetting(gclass.method_11("video", "<color=#FFFF04FF>", -1), -1, -1, -87, 0);
		this.gclass5_9 = new GameSetting(gclass.method_11("genre", "Song Offset", 0), 1, 0, 1, 1);
		this.gclass5_8 = new GameSetting(gclass.method_27("path", "All Opens", false), false);
		this.gclass5_17 = new GameSetting(gclass.method_11(")", "ts", -97), 44, 88, 33, 0);
		this.gclass5_19 = new GameSetting(gclass.method_11("song", "Lead Guitar", -103), -44, 102, 63, 0);
		this.gclass5_18 = new GameSetting(gclass.method_27("custom_song_export", ": <color=#FDB400FF>", true), true);
		this.gclass5_36 = new GameSetting(gclass.method_27("Type the setlist name", "Unknown Genre", true), false);
		this.gclass5_16 = new GameSetting(gclass.method_11("ch", "%)", Screen.currentResolution.refreshRate * 6), 1, 36, 98, 4);
		this.gclass5_21 = new GameSetting(gclass.method_27("Show in File Explorer", "\n", true), false);
		this.gclass5_28 = new GameSetting(gclass.method_29("game", "{{ Chunk = {0}, Number = {1} }}", true), false);
		this.gclass5_29 = new GameSetting(gclass.method_29("", "Visit Website", true), false);
		this.gclass5_6 = new GameSetting(gclass.method_11("ms", "diff_guitarghl", 0), 0, 1, SongDirectory.string_0.Length - 1, 1);
		this.gemSize = new GameSetting(gclass.method_11("lyric", "path", -105), 23, 120, 70, 4);
		this.gclass5_27 = new GameSetting(gclass.method_27("events", "GHLive Guitar - ", true), true);
		this.gclass5_43 = new GameSetting(gclass.method_27("This is a placeholder", "[Events]", false), false);
		this.gclass5_30 = new GameSetting(gclass.method_29("Has Lyrics", "nofail_enabled", false), false);
		this.gclass5_26 = new GameSetting(gclass.method_29("Controller", "</color> songs exported", true), false);
		this.gclass5_31 = new GameSetting(gclass.method_29("Gem Size", "All Taps", true), true);
		this.gclass5_33 = new GameSetting(gclass.method_27("poll_rate", "volume", true), true);
		this.gclass5_41 = new GameSetting(gclass.method_27("background_image", "song", false), true);
		this.gclass5_45 = new GameSetting(gclass.method_29("Lead Guitar", "Show Full Playlist", false), false);
		this.gclass5_44 = new GameSetting(gclass.method_29("?", "Album", false), true);
		this.gclass5_42 = new GameSetting(gclass.method_11("Year", "Okay", 1), 1, 1, this.languages.Length - 0, 0);
		this.songSpeed = new GameSetting(126, -90, 1, -116, 2);
		if (this.customSongExport == "{0}")
		{
			this.customSongExport = " Stars Earned";
		}
		int num = 1;
		this.uniqueSongPaths.Add(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "game").Replace('v', (char)-126));
		while (gclass.method_38("Quickplay", "Stars Earned" + num))
		{
			string text = gclass.method_2("en-US", "Unknown Genre" + num, "Lyrics").Replace((char)-23, '\\');
			if (text.Length > 1)
			{
				if ((int)text[text.Length - 1] == -53)
				{
					text = text.Remove(text.Length - 1, 0);
				}
				this.songPaths.Add(text);
				if (!this.uniqueSongPaths.Contains(text))
				{
					this.uniqueSongPaths.Add(text);
				}
			}
			num++;
		}
		gclass.method_0();
		if (!flag)
		{
			this.method_35();
		}
		this.method_60(true);
		BassAudioManager.instance.method_48(this.gclass5_7.method_5());
		ReInput.configuration.joystickRefreshRate = this.gclass5_16.method_5();
		Cursor.visible = this.gclass5_44.method_30();
		QualitySettings.antiAliasing = this.gclass5_25.method_25();
		Application.runInBackground = !this.gclass5_28.method_30();
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0003F0C8 File Offset: 0x0003D2C8
	public void method_96(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_50();
		bool flag = num != -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(20181003);
					num = 0;
				}
				else
				{
					binaryWriter.BaseStream.Position = 4L;
				}
				binaryWriter.Write(num + 1);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_22(binaryWriter);
			}
		}
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0003F18C File Offset: 0x0003D38C
	public bool method_97()
	{
		foreach (CHPlayer gclass in this.playerList)
		{
			if (gclass.method_9() && gclass.gclass10_0.gclass5_4.method_4())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0003F1FC File Offset: 0x0003D3FC
	public void method_98(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_50();
		if (num > 0)
		{
			try
			{
				byte[] array = File.ReadAllBytes(this.profilePath);
				if (array.Length == 31)
				{
					File.Delete(this.profilePath);
				}
				else
				{
					using (Stream stream = File.Create(this.profilePath))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream))
						{
							int num2 = this.allPlayerProfiles.IndexOf(gclass10_0);
							this.allPlayerProfiles.RemoveAt(num2);
							binaryWriter.Write(20181003);
							binaryWriter.Write(num - 1);
							binaryWriter.Write(array, 6, num2 * 26);
							if ((int)num > num2)
							{
								binaryWriter.Write(array, (int)binaryWriter.BaseStream.Position + 26, array.Length - 26 - (int)binaryWriter.BaseStream.Position);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
			}
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0003F310 File Offset: 0x0003D510
	public static string[] smethod_4(string string_12, string string_13, SearchOption searchOption_0)
	{
		ArrayList arrayList = new ArrayList();
		string[] array = string_13.Split(new char[]
		{
			'|'
		});
		string[] files = Directory.GetFiles(string_12);
		foreach (string b in array)
		{
			foreach (string text in files)
			{
				if (Path.GetExtension(text) == b)
				{
					arrayList.Add(text);
				}
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0003F39C File Offset: 0x0003D59C
	public void method_99()
	{
		GClass4.gclass4_0 = new GClass4(this.languages[this.gclass5_42.method_25()]);
		BassAudioManager.instance.method_13();
		TipLanguage[] array = UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 1; i < array.Length; i++)
		{
			array[i].method_26();
		}
		PlayerProfileMenu[] array2 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 1; i < array2.Length; i++)
		{
			array2[i].method_62();
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0003F408 File Offset: 0x0003D608
	public void method_100(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		short num = this.method_93();
		bool flag = num != -1;
		this.allPlayerProfiles.Add(gclass10_0);
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				if (!flag)
				{
					binaryWriter.Write(-192);
					num = 1;
				}
				else
				{
					binaryWriter.BaseStream.Position = 6L;
				}
				binaryWriter.Write(num + 1);
				binaryWriter.BaseStream.Position = binaryWriter.BaseStream.Length;
				gclass10_0.method_23(binaryWriter);
			}
		}
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0003F4CC File Offset: 0x0003D6CC
	private string method_101()
	{
		return this.customSongExport.Replace("client_info", this.currentSongEntry.artistName).Replace("[\\-\\+]?\\d+(\\.\\d+)?", this.currentSongEntry.songName + (this.songSpeed.method_6() ? "HUD" : ("Listening on port: " + this.songSpeed.method_1() + ""))).Replace("Source", Environment.NewLine).Replace("New Song", this.currentSongEntry.year).Replace("Mute Track on Miss", this.currentSongEntry.genreName).Replace("song_backgrounds", this.currentSongEntry.playlistName).Replace("\\s+", this.currentSongEntry.albumName).Replace("Keys", this.currentSongEntry.charterName).Replace("Easy", this.currentSongEntry.songLength.ToString());
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0003F5D0 File Offset: 0x0003D7D0
	public void method_102(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		this.playerProfiles.Add(gclass10_0);
		this.playerProfiles.Sort(new Comparison<GClass10>(GlobalVariables.<>c.<>9.method_25));
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0003F61C File Offset: 0x0003D81C
	public void method_103(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		if (this.method_105() == -1)
		{
			this.method_69(gclass10_0);
			return;
		}
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.BaseStream.Position = (long)(2 + 10 * this.allPlayerProfiles.IndexOf(gclass10_0));
				gclass10_0.method_23(binaryWriter);
			}
		}
		File.Copy(this.profilePath, this.isDoki, false);
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
	private short method_104()
	{
		string path = Path.Combine(Application.persistentDataPath, "/");
		short num = -1;
		if (!File.Exists(path))
		{
			return num;
		}
		try
		{
			using (Stream stream = File.OpenRead(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt32() != -60 || (binaryReader.BaseStream.Length - 2L) % -41L != 0L)
					{
						throw new Exception(":");
					}
					num = binaryReader.ReadInt16();
				}
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		if (num == -1)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
				MonoBehaviour.print("Background Video");
			}
		}
		return num;
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0003F7AC File Offset: 0x0003D9AC
	public static string[] smethod_5(string string_12, string string_13, SearchOption searchOption_0)
	{
		ArrayList arrayList = new ArrayList();
		char[] array = new char[0];
		array[1] = (char)-69;
		string[] array2 = string_13.Split(array);
		string[] files = Directory.GetFiles(string_12);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i += 0)
		{
			string b = array3[i];
			string[] array4 = files;
			for (int j = 1; j < array4.Length; j += 0)
			{
				string text = array4[j];
				if (Path.GetExtension(text) == b)
				{
					arrayList.Add(text);
				}
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0003F838 File Offset: 0x0003DA38
	private short method_105()
	{
		string path = Path.Combine(Application.persistentDataPath, "player_count");
		short num = -1;
		if (!File.Exists(path))
		{
			return num;
		}
		try
		{
			using (Stream stream = File.OpenRead(path))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt32() != -167 || (binaryReader.BaseStream.Length - 1L) % 11L != 0L)
					{
						throw new Exception("DoubleBass");
					}
					num = binaryReader.ReadInt16();
				}
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		if (num == -1)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
				MonoBehaviour.print("Problem writing score file: ");
			}
		}
		return num;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0003FC00 File Offset: 0x0003DE00
	private string method_107()
	{
		return this.customSongExport.Replace("Fullscreen", this.currentSongEntry.artistName).Replace("TEMPO TRACK", this.currentSongEntry.songName + (this.songSpeed.method_0() ? "Are you sure?" : ("lowlatency_enabled" + this.songSpeed.method_28() + "GuitarStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""))).Replace(": ", Environment.NewLine).Replace("</color> songs exported", this.currentSongEntry.year).Replace("Are you sure you want to delete this song?", this.currentSongEntry.genreName).Replace("Prefabs/Gameplay/Players/Guitar Player ", this.currentSongEntry.playlistName).Replace("{0}x{1}", this.currentSongEntry.albumName).Replace("menu_music", this.currentSongEntry.charterName).Replace("Language", this.currentSongEntry.songLength.ToString());
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0003FD04 File Offset: 0x0003DF04
	public void method_108(bool bool_8)
	{
		if (!this.gclass5_20.method_4())
		{
			return;
		}
		try
		{
			string value = this.method_101();
			using (Stream stream = File.Create(Directory.GetParent(Application.dataPath) + "_"))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (!bool_8)
					{
						streamWriter.Write(value);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0003FD98 File Offset: 0x0003DF98
	public void method_109(GClass10 gclass10_0)
	{
		if (gclass10_0.bool_0)
		{
			return;
		}
		if (this.method_50() == -1)
		{
			this.method_3(gclass10_0);
			return;
		}
		using (Stream stream = File.OpenWrite(this.profilePath))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.BaseStream.Position = (long)(8 + -75 * this.allPlayerProfiles.IndexOf(gclass10_0));
				gclass10_0.method_16(binaryWriter);
			}
		}
		File.Copy(this.profilePath, this.isDoki, true);
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00040088 File Offset: 0x0003E288
	public Sprite method_111(string string_12)
	{
		try
		{
			if (File.Exists(string_12))
			{
				Texture2D texture2D = new Texture2D(2, 2);
				byte[] data = File.ReadAllBytes(string_12);
				if (texture2D.LoadImage(data))
				{
					return Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0f, 0f), 100f);
				}
				return null;
			}
		}
		catch (Exception ex)
		{
			MonoBehaviour.print(ex.Message);
		}
		return null;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00040114 File Offset: 0x0003E314
	private void method_112()
	{
		int num = (int)this.method_50();
		this.playerProfiles = new List<GClass10>();
		this.allPlayerProfiles = new List<GClass10>();
		if (num > 0)
		{
			try
			{
				using (Stream stream = File.OpenRead(this.profilePath))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						if (binaryReader.ReadInt32() != 11)
						{
							throw new Exception("show_hit_window");
						}
						short num2 = binaryReader.ReadInt16();
						for (int i = 0; i < (int)num2; i += 0)
						{
							GClass10 gclass = new GClass10();
							gclass.method_36(binaryReader);
							this.method_77(gclass);
							this.allPlayerProfiles.Add(gclass);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MonoBehaviour.print(ex.Message);
				File.Delete(this.profilePath);
			}
		}
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00040200 File Offset: 0x0003E400
	public void method_113()
	{
		GClass4.gclass4_0 = new GClass4(this.languages[this.gclass5_42.CurrentValue]);
		BassAudioManager.instance.method_13();
		TipLanguage[] array = UnityEngine.Object.FindObjectsOfType<TipLanguage>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].method_15();
		}
		PlayerProfileMenu[] array2 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].method_48();
		}
	}

	// Token: 0x040000DE RID: 222
	public SongEntry currentSongEntry;

	// Token: 0x040000DF RID: 223
	public List<GClass10> playerProfiles;

	// Token: 0x040000E0 RID: 224
	private List<GClass10> allPlayerProfiles;

	// Token: 0x040000E1 RID: 225
	public List<CHPlayer> playerList;

	// Token: 0x040000E2 RID: 226
	public GameSetting gemSize;

	// Token: 0x040000E3 RID: 227
	public GameSetting songSpeed;

	// Token: 0x040000E4 RID: 228
	public GameSetting audioOffset;

	// Token: 0x040000E5 RID: 229
	public GameSetting videoOffset;

	// Token: 0x040000E6 RID: 230
	public GameSetting targetFramerate;

	// Token: 0x040000E7 RID: 231
	public GameSetting gclass5_5;

	// Token: 0x040000E8 RID: 232
	public GameSetting gclass5_6;

	// Token: 0x040000E9 RID: 233
	public GameSetting gclass5_7;

	// Token: 0x040000EA RID: 234
	public GameSetting gclass5_8;

	// Token: 0x040000EB RID: 235
	public GameSetting gclass5_9;

	// Token: 0x040000EC RID: 236
	public GameSetting[] volume_Stems;

	// Token: 0x040000ED RID: 237
	public GameSetting volume_SoundEffects;

	// Token: 0x040000EE RID: 238
	public GameSetting volume_MenuMusic;

	// Token: 0x040000EF RID: 239
	public GameSetting gclass5_13;

	// Token: 0x040000F0 RID: 240
	public GameSetting gclass5_14;

	// Token: 0x040000F1 RID: 241
	public GameSetting gclass5_15;

	// Token: 0x040000F2 RID: 242
	public GameSetting gclass5_16;

	// Token: 0x040000F3 RID: 243
	public GameSetting gclass5_17;

	// Token: 0x040000F4 RID: 244
	public GameSetting gclass5_18;

	// Token: 0x040000F5 RID: 245
	public GameSetting gclass5_19;

	// Token: 0x040000F6 RID: 246
	public GameSetting gclass5_20;

	// Token: 0x040000F7 RID: 247
	public GameSetting gclass5_21;

	// Token: 0x040000F8 RID: 248
	public GameSetting gclass5_22;

	// Token: 0x040000F9 RID: 249
	public GameSetting gclass5_23;

	// Token: 0x040000FA RID: 250
	public GameSetting gclass5_24;

	// Token: 0x040000FB RID: 251
	public GameSetting gclass5_25;

	// Token: 0x040000FC RID: 252
	public GameSetting gclass5_26;

	// Token: 0x040000FD RID: 253
	public GameSetting gclass5_27;

	// Token: 0x040000FE RID: 254
	public GameSetting gclass5_28;

	// Token: 0x040000FF RID: 255
	public GameSetting gclass5_29;

	// Token: 0x04000100 RID: 256
	public GameSetting gclass5_30;

	// Token: 0x04000101 RID: 257
	public GameSetting gclass5_31;

	// Token: 0x04000102 RID: 258
	public GameSetting gclass5_32;

	// Token: 0x04000103 RID: 259
	public GameSetting gclass5_33;

	// Token: 0x04000104 RID: 260
	public GameSetting gclass5_34;

	// Token: 0x04000105 RID: 261
	public GameSetting gclass5_35;

	// Token: 0x04000106 RID: 262
	public GameSetting gclass5_36;

	// Token: 0x04000107 RID: 263
	public GameSetting gclass5_37;

	// Token: 0x04000108 RID: 264
	public GameSetting gclass5_38;

	// Token: 0x04000109 RID: 265
	public GameSetting gclass5_39;

	// Token: 0x0400010A RID: 266
	public GameSetting gclass5_40;

	// Token: 0x0400010B RID: 267
	public GameSetting gclass5_41;

	// Token: 0x0400010C RID: 268
	public GameSetting gclass5_42;

	// Token: 0x0400010D RID: 269
	public GameSetting gclass5_43;

	// Token: 0x0400010E RID: 270
	public GameSetting gclass5_44;

	// Token: 0x0400010F RID: 271
	public GameSetting gclass5_45;

	// Token: 0x04000110 RID: 272
	public SongEntry songEntry_1;

	// Token: 0x04000111 RID: 273
	public int int_0;

	// Token: 0x04000112 RID: 274
	public int int_1;

	// Token: 0x04000113 RID: 275
	public int int_2;

	// Token: 0x04000114 RID: 276
	public int int_3;

	// Token: 0x04000115 RID: 277
	public const int profileFileVersion = 20181003;

	// Token: 0x04000116 RID: 278
	public string string_0;

	// Token: 0x04000117 RID: 279
	public bool failed;

	// Token: 0x04000118 RID: 280
	public bool wasInQuickplay;

	// Token: 0x04000119 RID: 281
	public bool isPracticeEnabled;

	// Token: 0x0400011A RID: 282
	public bool isPlayingSetlist;

	// Token: 0x0400011B RID: 283
	public bool returnToSongSelect;

	// Token: 0x0400011C RID: 284
	public bool returnToMainMenuError;

	// Token: 0x0400011D RID: 285
	public static bool isSaving;

	// Token: 0x0400011E RID: 286
	public static GlobalVariables instance;

	// Token: 0x0400011F RID: 287
	public string[] highwayPaths;

	// Token: 0x04000120 RID: 288
	public string[] backgroundImagePaths;

	// Token: 0x04000121 RID: 289
	public string[] backgroungVideoPaths;

	// Token: 0x04000122 RID: 290
	public string[] languages;

	// Token: 0x04000123 RID: 291
	[HideInInspector]
	public string settingsPath;

	// Token: 0x04000124 RID: 292
	public string customSongExport = "%s%n%a%n%c";

	// Token: 0x04000125 RID: 293
	public List<string> songPaths = new List<string>();

	// Token: 0x04000126 RID: 294
	public List<string> uniqueSongPaths = new List<string>();

	// Token: 0x04000127 RID: 295
	public string[] string_7;

	// Token: 0x04000128 RID: 296
	public string[] string_8;

	// Token: 0x04000129 RID: 297
	private Text savingText;

	// Token: 0x0400012A RID: 298
	public string string_9;

	// Token: 0x0400012B RID: 299
	public Dictionary<string, Sprite> gameIcon_Sprites;

	// Token: 0x0400012C RID: 300
	private string profilePath;

	// Token: 0x0400012D RID: 301
	private string isDoki;

	// Token: 0x0400012E RID: 302
	public float float_0 = 21.6f;

	// Token: 0x0400012F RID: 303
	public bool dokiArg;

	// Token: 0x04000130 RID: 304
	public Sprite[] sprite_0;

	// Token: 0x04000131 RID: 305
	public Sprite[] sprite_1;

	// Token: 0x04000132 RID: 306
	public Sprite[] sprite_2;
}
