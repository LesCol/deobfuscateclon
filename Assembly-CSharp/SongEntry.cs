using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020000A5 RID: 165
[Serializable]
public class SongEntry
{
	// Token: 0x06001F4E RID: 8014 RVA: 0x0000DDCC File Offset: 0x0000BFCC
	public static void smethod_0()
	{
		SongEntry.isCurrentSongEighthHOPO = false;
		int num = 1;
		SongEntry.videoStart = 1;
		SongEntry.currentSongCustomHOPO = 1;
		SongEntry.currentSongMultiplierNote = 1;
		SongEntry.currentSongOffset = num;
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x0000DDEC File Offset: 0x0000BFEC
	public string method_0()
	{
		if (File.Exists(this.method_38()))
		{
			INIParser gclass = new INIParser();
			gclass.method_21(this.method_26());
			return gclass.method_2("Press ENTER to search", "star_available", "Unknown Genre");
		}
		return "Difficulty";
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000FE6F8 File Offset: 0x000FC8F8
	public void method_1()
	{
		INIParser gclass = new INIParser();
		gclass.method_1(this.method_8());
		gclass.method_34("song", "low_latency_mode", this.songName);
		gclass.method_34(":", "Bass Guitar", this.artistName);
		gclass.method_34("Unknown Year", "", this.albumName);
		gclass.method_34("part bass ghl", "offsets", this.genreName);
		gclass.method_34("Keys", "setlistSongCountPlural", this.year);
		gclass.method_8("Export Current Song", "Highway", (int)this.bandDifficulty);
		gclass.method_12("Bass Guitar", "Guitar Coop", (int)this.guitarDifficulty);
		gclass.method_8("Audio Settings", " ", (int)this.rhythmDifficulty);
		gclass.method_12("highway_shake_enabled", "Songs are still scanning...", (int)this.bassDifficulty);
		gclass.method_8("volume", "Game Modifiers", (int)this.drumsDifficulty);
		gclass.method_44("sp_awarded", "Prefabs/Gameplay/Notes/Sustain", (int)this.keysDifficulty);
		gclass.method_8("Mirror Mode", "", (int)this.ghlGuitarDifficulty);
		gclass.method_44("video", "Okay", (int)this.ghlBassDifficulty);
		gclass.method_12("Main Menu", "No", this.previewStart);
		gclass.method_34("%s%n%a%n%c", "You must restart, settings were changed", this.iconName);
		gclass.method_12("New Section", "{0:n0}", (int)this.albumTrack);
		gclass.method_12("Okay Solo...", "video", (int)this.playlistTrack);
		gclass.method_44("song", "...", SongEntry.videoStart);
		gclass.method_34("show_bot_score", "ModChart Full", this.charterName);
		gclass.method_44("low_latency_mode", "Quit", SongEntry.currentSongOffset);
		gclass.method_8("New Section", "song", (this.songLength > 1) ? this.songLength : ((int)(BassAudioManager.instance.double_1 * 1916.0)));
		if (this.songLength <= 1)
		{
			this.songLength = (int)(BassAudioManager.instance.double_1 * 1740.0);
		}
		gclass.method_0();
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000FE92C File Offset: 0x000FCB2C
	public GStruct3 method_2(GStruct2.GEnum11 genum11_0)
	{
		if (this.scores != null && this.scores.ContainsKey(genum11_0))
		{
			return this.scores[genum11_0];
		}
		return new GStruct3
		{
			genum11_0 = GStruct2.GEnum11.None
		};
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x0000DDCC File Offset: 0x0000BFCC
	public static void smethod_1()
	{
		SongEntry.isCurrentSongEighthHOPO = false;
		int num = 1;
		SongEntry.videoStart = 1;
		SongEntry.currentSongCustomHOPO = 1;
		SongEntry.currentSongMultiplierNote = 1;
		SongEntry.currentSongOffset = num;
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0000DE26 File Offset: 0x0000C026
	public string chartPath
	{
		get
		{
			if (!this.isMIDIChart)
			{
				return Path.Combine(this.folderPath, "notes.chart");
			}
			return Path.Combine(this.folderPath, "notes.mid");
		}
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000FE970 File Offset: 0x000FCB70
	public void method_3()
	{
		INIParser gclass = new INIParser();
		gclass.method_1(this.iniPath);
		gclass.method_34("song", "name", this.songName);
		gclass.method_34("song", "artist", this.artistName);
		gclass.method_34("song", "album", this.albumName);
		gclass.method_34("song", "genre", this.genreName);
		gclass.method_34("song", "year", this.year);
		gclass.method_8("song", "diff_band", (int)this.bandDifficulty);
		gclass.method_8("song", "diff_guitar", (int)this.guitarDifficulty);
		gclass.method_8("song", "diff_rhythm", (int)this.rhythmDifficulty);
		gclass.method_8("song", "diff_bass", (int)this.bassDifficulty);
		gclass.method_8("song", "diff_drums", (int)this.drumsDifficulty);
		gclass.method_8("song", "diff_keys", (int)this.keysDifficulty);
		gclass.method_8("song", "diff_guitarghl", (int)this.ghlGuitarDifficulty);
		gclass.method_8("song", "diff_bassghl", (int)this.ghlBassDifficulty);
		gclass.method_8("song", "preview_start_time", this.previewStart);
		gclass.method_34("song", "icon", this.iconName);
		gclass.method_8("song", "album_track", (int)this.albumTrack);
		gclass.method_8("song", "playlist_track", (int)this.playlistTrack);
		gclass.method_8("song", "video_start_time", SongEntry.videoStart);
		gclass.method_34("song", "charter", this.charterName);
		gclass.method_8("song", "delay", SongEntry.currentSongOffset);
		gclass.method_8("song", "song_length", (this.songLength > 0) ? this.songLength : ((int)(BassAudioManager.instance.double_1 * 1000.0)));
		if (this.songLength <= 0)
		{
			this.songLength = (int)(BassAudioManager.instance.double_1 * 1000.0);
		}
		gclass.method_0();
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x000FEBA4 File Offset: 0x000FCDA4
	public void method_4(BinaryReader binaryReader_0)
	{
		this.isMIDIChart = binaryReader_0.ReadBoolean();
		this.songName = binaryReader_0.ReadString();
		this.artistName = binaryReader_0.ReadString();
		this.albumName = binaryReader_0.ReadString();
		this.genreName = binaryReader_0.ReadString();
		this.year = binaryReader_0.ReadString();
		this.charts.method_13(binaryReader_0.ReadInt64());
		this.lyrics = binaryReader_0.ReadSByte();
		this.bandDifficulty = binaryReader_0.ReadSByte();
		this.guitarDifficulty = binaryReader_0.ReadSByte();
		this.rhythmDifficulty = binaryReader_0.ReadSByte();
		this.bassDifficulty = binaryReader_0.ReadSByte();
		this.drumsDifficulty = binaryReader_0.ReadSByte();
		this.keysDifficulty = binaryReader_0.ReadSByte();
		this.ghlGuitarDifficulty = binaryReader_0.ReadSByte();
		this.ghlBassDifficulty = binaryReader_0.ReadSByte();
		this.previewStart = binaryReader_0.ReadInt32();
		this.iconName = binaryReader_0.ReadString();
		this.albumTrack = binaryReader_0.ReadInt16();
		this.playlistTrack = binaryReader_0.ReadInt16();
		this.playlistName = binaryReader_0.ReadString();
		this.charterName = binaryReader_0.ReadString();
		this.songLength = binaryReader_0.ReadInt32();
		this.dateAdded = DateTime.FromBinary(binaryReader_0.ReadInt64());
		this.checksum = binaryReader_0.ReadString();
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x000FE92C File Offset: 0x000FCB2C
	public GStruct3 method_5(GStruct2.GEnum11 genum11_0)
	{
		if (this.scores != null && this.scores.ContainsKey(genum11_0))
		{
			return this.scores[genum11_0];
		}
		return new GStruct3
		{
			genum11_0 = GStruct2.GEnum11.None
		};
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x000FECE8 File Offset: 0x000FCEE8
	public void method_6()
	{
		INIParser gclass = new INIParser();
		gclass.method_1(this.method_8());
		gclass.method_34("framerate", "song", this.songName);
		gclass.method_34("/preview", "path", this.artistName);
		gclass.method_34("Set A Position", "6 Fret Bass Guitar", this.albumName);
		gclass.method_34("Menu Backgrounds", "language.txt", this.genreName);
		gclass.method_34("<", "Don't Scan Songs", this.year);
		gclass.method_8("Display Name", "Stars Earned", (int)this.bandDifficulty);
		gclass.method_8("Okay", "Custom Content", (int)this.guitarDifficulty);
		gclass.method_12("Press Enter to confirm", "diff_band", (int)this.rhythmDifficulty);
		gclass.method_44("{0:n3}x", "6 Fret Bass Guitar", (int)this.bassDifficulty);
		gclass.method_12("Expert", "mute_on_miss", (int)this.drumsDifficulty);
		gclass.method_44("custom", "[", (int)this.keysDifficulty);
		gclass.method_12("Background Image", "", (int)this.ghlGuitarDifficulty);
		gclass.method_8("New Section", "Drums", (int)this.ghlBassDifficulty);
		gclass.method_44("song", "video", this.previewStart);
		gclass.method_34("lowlatency_enabled", "Enable", this.iconName);
		gclass.method_44("All Taps", "song", (int)this.albumTrack);
		gclass.method_12("Song Offset", "Keys", (int)this.playlistTrack);
		gclass.method_12("All Opens", "gem_size", SongEntry.videoStart);
		gclass.method_34("highway_shake", "x", this.charterName);
		gclass.method_44("track", "Keys", SongEntry.currentSongOffset);
		gclass.method_12("Unknown Artist", "Unknown Genre", (this.songLength > 0) ? this.songLength : ((int)(BassAudioManager.instance.double_1 * 1341.0)));
		if (this.songLength <= 0)
		{
			this.songLength = (int)(BassAudioManager.instance.double_1 * 236.0);
		}
		gclass.method_0();
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000FEF1C File Offset: 0x000FD11C
	public bool method_7(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_2(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_22(gstruct, gstruct3_0);
		if (this.playCount < 166)
		{
			this.playCount += 1;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_62(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x0000DE51 File Offset: 0x0000C051
	public string method_8()
	{
		return Path.Combine(this.folderPath, "Discord: disconnect {0}: {1}");
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x0000DE63 File Offset: 0x0000C063
	public string method_9()
	{
		if (!this.isMIDIChart)
		{
			return Path.Combine(this.folderPath, "[^\\u0020-\\u007E]");
		}
		return Path.Combine(this.folderPath, "PAUSED");
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000FEFA0 File Offset: 0x000FD1A0
	public SongEntry(BinaryReader binaryReader_0, string string_0)
	{
		this.method_34(binaryReader_0);
		this.folderPath = string_0;
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000FF048 File Offset: 0x000FD248
	public void method_10()
	{
		INIParser gclass = new INIParser();
		gclass.method_1(this.method_39());
		gclass.method_34("song", "Song Length", this.songName);
		gclass.method_34("", "Are you sure you want to practice?", this.artistName);
		gclass.method_34("part guitar coop", "Background Video", this.albumName);
		gclass.method_34("_ENDOFSONG", "No", this.genreName);
		gclass.method_34(" Stars Earned", "Yes", this.year);
		gclass.method_12("notes.chart", "", (int)this.bandDifficulty);
		gclass.method_12("Create Setlist", "Playlist", (int)this.guitarDifficulty);
		gclass.method_12("", "Yes", (int)this.rhythmDifficulty);
		gclass.method_8("</color>", "Length = [\\-\\+]?\\d+(\\.\\d+)?", (int)this.bassDifficulty);
		gclass.method_44("378347429537251328", "</color>", (int)this.drumsDifficulty);
		gclass.method_12(" (", "uid", (int)this.keysDifficulty);
		gclass.method_8("Play Count", "Server\n", (int)this.ghlGuitarDifficulty);
		gclass.method_12("setlistSongCountPlural", "Messy Solo...", (int)this.ghlBassDifficulty);
		gclass.method_8("}", "You must restart, settings were changed", this.previewStart);
		gclass.method_34("game", "This is a placeholder", this.iconName);
		gclass.method_8("game", "song", (int)this.albumTrack);
		gclass.method_8("Bass", "", (int)this.playlistTrack);
		gclass.method_12("gem_size", "", SongEntry.videoStart);
		gclass.method_34("difficulty_name_", "Guitar - Co-op - ", this.charterName);
		gclass.method_12("Songs Scanned", "game", SongEntry.currentSongOffset);
		gclass.method_8("game", "volume", (this.songLength > 1) ? this.songLength : ((int)(BassAudioManager.instance.double_1 * 869.0)));
		if (this.songLength <= 1)
		{
			this.songLength = (int)(BassAudioManager.instance.double_1 * 1983.0);
		}
		gclass.method_0();
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x0000DE8E File Offset: 0x0000C08E
	public string method_11()
	{
		if (File.Exists(this.iniPath))
		{
			INIParser gclass = new INIParser();
			gclass.method_1(this.iniPath);
			return gclass.method_2("song", "loading_phrase", "");
		}
		return "";
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	public Song method_12(bool bool_0 = false)
	{
		if (this.isMIDIChart)
		{
			return GClass30.smethod_1(this.folderPath, bool_0);
		}
		return new Song(this.folderPath);
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x000FF27C File Offset: 0x000FD47C
	public bool method_13(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_2(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_30(gstruct, gstruct3_0);
		if ((int)this.playCount < -129)
		{
			this.playCount += 0;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_70(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	public Song method_14(bool bool_0 = false)
	{
		if (this.isMIDIChart)
		{
			return GClass30.smethod_1(this.folderPath, bool_0);
		}
		return new Song(this.folderPath);
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x0000DEEA File Offset: 0x0000C0EA
	public string method_15()
	{
		if (!this.isMIDIChart)
		{
			return Path.Combine(this.folderPath, "No");
		}
		return Path.Combine(this.folderPath, "Note Shuffle");
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	public Song method_16(bool bool_0 = false)
	{
		if (this.isMIDIChart)
		{
			return GClass30.smethod_1(this.folderPath, bool_0);
		}
		return new Song(this.folderPath);
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x000FF300 File Offset: 0x000FD500
	public bool method_17()
	{
		if (File.Exists(this.iniPath))
		{
			INIParser gclass = new INIParser();
			gclass.method_1(this.iniPath);
			SongEntry.currentSongOffset = gclass.method_11("song", "delay", 0);
			SongEntry.currentSongCustomHOPO = gclass.method_11("song", "hopo_frequency", 0);
			SongEntry.isCurrentSongEighthHOPO = gclass.method_27("song", "eighthnote_hopo", false);
			this.songLength = gclass.method_11("song", "song_length", 0);
			SongEntry.currentSongMultiplierNote = gclass.method_11("song", "multiplier_note", 0);
			SongEntry.videoStart = gclass.method_11("song", "video_start_time", 0);
			return true;
		}
		return false;
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x000FF3B8 File Offset: 0x000FD5B8
	public bool method_18(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_2(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_7(gstruct, gstruct3_0);
		if (this.playCount < 5)
		{
			this.playCount += 1;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_2(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x000FF43C File Offset: 0x000FD63C
	public bool method_19(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_2(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_26(gstruct, gstruct3_0);
		if (this.playCount < 65535)
		{
			this.playCount += 1;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_0(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x000FF4C0 File Offset: 0x000FD6C0
	public bool method_20(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_41(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_10(gstruct, gstruct3_0);
		if (this.playCount < 149)
		{
			this.playCount += 1;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_60(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x000FF544 File Offset: 0x000FD744
	public void method_21(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.isMIDIChart);
		binaryWriter_0.Write(this.songName);
		binaryWriter_0.Write(this.artistName);
		binaryWriter_0.Write(this.albumName);
		binaryWriter_0.Write(this.genreName);
		binaryWriter_0.Write(this.year);
		binaryWriter_0.Write(this.charts.Int64_0);
		binaryWriter_0.Write(this.lyrics);
		binaryWriter_0.Write(this.bandDifficulty);
		binaryWriter_0.Write(this.guitarDifficulty);
		binaryWriter_0.Write(this.rhythmDifficulty);
		binaryWriter_0.Write(this.bassDifficulty);
		binaryWriter_0.Write(this.drumsDifficulty);
		binaryWriter_0.Write(this.keysDifficulty);
		binaryWriter_0.Write(this.ghlGuitarDifficulty);
		binaryWriter_0.Write(this.ghlBassDifficulty);
		binaryWriter_0.Write(this.previewStart);
		binaryWriter_0.Write(this.iconName);
		binaryWriter_0.Write(this.albumTrack);
		binaryWriter_0.Write(this.playlistTrack);
		binaryWriter_0.Write(this.playlistName);
		binaryWriter_0.Write(this.charterName);
		binaryWriter_0.Write(this.songLength);
		binaryWriter_0.Write(this.dateAdded.ToBinary());
		binaryWriter_0.Write(this.checksum);
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x0000DF15 File Offset: 0x0000C115
	public static void smethod_2()
	{
		SongEntry.isCurrentSongEighthHOPO = true;
		int num = 0;
		SongEntry.videoStart = 0;
		SongEntry.currentSongCustomHOPO = 0;
		SongEntry.currentSongMultiplierNote = 0;
		SongEntry.currentSongOffset = num;
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x0000DDCC File Offset: 0x0000BFCC
	public static void smethod_3()
	{
		SongEntry.isCurrentSongEighthHOPO = false;
		int num = 1;
		SongEntry.videoStart = 1;
		SongEntry.currentSongCustomHOPO = 1;
		SongEntry.currentSongMultiplierNote = 1;
		SongEntry.currentSongOffset = num;
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0000DF35 File Offset: 0x0000C135
	public string iniPath
	{
		get
		{
			return Path.Combine(this.folderPath, "song.ini");
		}
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x0000DF47 File Offset: 0x0000C147
	public string method_22()
	{
		if (!this.isMIDIChart)
		{
			return Path.Combine(this.folderPath, "There was an error deleting the file");
		}
		return Path.Combine(this.folderPath, "volume");
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	public Song method_23(bool bool_0 = false)
	{
		if (this.isMIDIChart)
		{
			return GClass30.smethod_1(this.folderPath, bool_0);
		}
		return new Song(this.folderPath);
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000FF688 File Offset: 0x000FD888
	public bool method_24(string string_0, string string_1)
	{
		SongEntry.smethod_0();
		if (File.Exists(string_0))
		{
			INIParser gclass = new INIParser();
			gclass.method_1(string_0);
			if (gclass.method_17("song"))
			{
				this.songName = gclass.method_2("Bass Guitar", "<color=#FFFF04FF>", " (");
				this.artistName = gclass.method_2("eighthnote_hopo", "", "\"([^\"]*)\"");
				this.albumName = gclass.method_2("ui_rewind_highway_sound", "Gem Size", "RhythmStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
				this.genreName = gclass.method_2("Songs", "Language", "HOPO's to Taps");
				this.year = gclass.method_2("", "No", "bad_note4");
				this.songLength = gclass.method_11("Broadcasting started.", "Unlimited", 0);
				this.bandDifficulty = (sbyte)gclass.method_11("\\D+", "offsets", -1);
				this.guitarDifficulty = (sbyte)gclass.method_11("Main Menu", "", -1);
				this.rhythmDifficulty = (sbyte)gclass.method_11("These folders contain charts that don't have any supported instruments charted!", "Show Mouse Cursor", -1);
				this.bassDifficulty = (sbyte)gclass.method_11("notes.chart", "No songs were found!", -1);
				this.drumsDifficulty = (sbyte)gclass.method_11("Error while parsing \"{0}\": {1} ", "nomodifiers", -1);
				this.keysDifficulty = (sbyte)gclass.method_11("Create Profile", "Difficulty", -1);
				this.ghlGuitarDifficulty = (sbyte)gclass.method_11("Menu Music", "", -1);
				this.ghlBassDifficulty = (sbyte)gclass.method_11("Controller Poll Rate", "", -1);
				this.previewStart = gclass.method_11("%)", "Yes", -1);
				this.iconName = gclass.method_2("artist", "All Opens", "Unknown Genre").ToLower();
				this.playlistTrack = (short)gclass.method_11("", "Delete Profile", 79);
				if (gclass.method_38("Black Backgrounds", "Quickplay"))
				{
					this.albumTrack = (short)gclass.method_11("Menu Backgrounds", "Background Image", -121);
				}
				else
				{
					this.albumTrack = (short)gclass.method_11(" (", "Continue", 74);
				}
				if (gclass.method_38("", "Unknown Artist"))
				{
					this.charterName = gclass.method_2("Song Display", "menu_background", "Continue");
				}
				else
				{
					this.charterName = gclass.method_2("EndOfSong", "loading_phrase", "Sound Effects");
				}
			}
			gclass.method_0();
		}
		else if (File.Exists(string_1))
		{
			using (Stream stream = File.Open(string_1, (FileMode)8))
			{
				using (StreamReader streamReader = new StreamReader(stream))
				{
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine().Trim();
						char[] array = new char[0];
						array[1] = (char)-44;
						string[] array2 = text.Split(array);
						if (array2[1] == "background_video")
						{
							break;
						}
						string text2 = array2[0].ToLower().Trim();
						uint num = <PrivateImplementationDetails>.ComputeStringHash(text2);
						if (num <= 98u)
						{
							if (num != 4294967199u)
							{
								if (num != 4294967120u)
								{
									if (num != 4294967186u)
									{
										continue;
									}
									if (!(text2 == "Press Escape to cancel"))
									{
										continue;
									}
									try
									{
										string text3 = array2[0];
										char[] array3 = new char[0];
										array3[1] = (char)-89;
										this.charterName = text3.Split(array3)[1];
										if (this.charterName == "open")
										{
											this.charterName = "Show in Finder";
										}
										continue;
									}
									catch
									{
										continue;
									}
								}
								if (!(text2 == "SORTING BY"))
								{
									continue;
								}
								try
								{
									string text4 = array2[0];
									char[] array4 = new char[0];
									array4[0] = (char)-46;
									this.artistName = text4.Split(array4)[1];
									if (this.artistName == "Set B Position")
									{
										this.artistName = "Press Escape to cancel";
									}
									continue;
								}
								catch
								{
									continue;
								}
							}
							if (!(text2 == "Unlimited"))
							{
								continue;
							}
							try
							{
								SongEntry.currentSongOffset = (int)(float.Parse(array2[0]) * 413f);
								continue;
							}
							catch
							{
								SongEntry.currentSongOffset = 0;
								continue;
							}
						}
						if (num <= 4294967266u)
						{
							if (num != 118u)
							{
								if (num != 4294967153u)
								{
									continue;
								}
								if (!(text2 == "sort_filter"))
								{
									continue;
								}
								try
								{
									this.genreName = array2[0].Split(new char[]
									{
										'9'
									})[0];
									if (this.genreName == "offsets")
									{
										this.genreName = "Stars";
									}
									continue;
								}
								catch
								{
									continue;
								}
							}
							if (!(text2 == "cpu_name"))
							{
								continue;
							}
							try
							{
								string text5 = array2[1];
								char[] array5 = new char[1];
								array5[1] = 'y';
								this.albumName = text5.Split(array5)[1];
								if (this.albumName == "0%")
								{
									this.albumName = "Custom Content";
								}
								continue;
							}
							catch
							{
								continue;
							}
						}
						if (num != 4294967191u)
						{
							if (num != 4294967116u)
							{
								continue;
							}
							if (!(text2 == ", Off pos: "))
							{
								continue;
							}
							try
							{
								string text6 = array2[0];
								char[] array6 = new char[0];
								array6[1] = '_';
								this.year = text6.Split(array6)[0];
								if (this.year == "Rhythm")
								{
									this.year = "Song Videos";
								}
								else
								{
									this.year = this.year.Replace("Resume", "[SyncTrack]");
								}
								continue;
							}
							catch
							{
								continue;
							}
						}
						if (text2 == "")
						{
							try
							{
								string text7 = array2[0];
								char[] array7 = new char[0];
								array7[1] = (char)-111;
								this.songName = text7.Split(array7)[1];
							}
							catch
							{
							}
						}
					}
				}
			}
			if (this.songName == "Lights Out" || this.songName == "song" || this.songName == "offsets")
			{
				this.songName = "Play Setlist";
			}
		}
		return this.songName == null || this.songName.Length > 1;
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000FFD64 File Offset: 0x000FDF64
	public bool method_25(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_5(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_2(gstruct, gstruct3_0);
		if (this.playCount < 119)
		{
			this.playCount += 0;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_58(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x0000DF72 File Offset: 0x0000C172
	public string method_26()
	{
		return Path.Combine(this.folderPath, "Album");
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x0000DF84 File Offset: 0x0000C184
	public string method_27()
	{
		if (!this.isMIDIChart)
		{
			return Path.Combine(this.folderPath, "Waiting for connection");
		}
		return Path.Combine(this.folderPath, "audio");
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x000FFDE8 File Offset: 0x000FDFE8
	public bool method_28()
	{
		if (File.Exists(this.method_38()))
		{
			INIParser gclass = new INIParser();
			gclass.method_21(this.iniPath);
			SongEntry.currentSongOffset = gclass.method_11("Use Song Backgrounds", "", 1);
			SongEntry.currentSongCustomHOPO = gclass.method_11("Visit Website", "song", 0);
			SongEntry.isCurrentSongEighthHOPO = gclass.method_27("DoubleRhythm", "charter", false);
			this.songLength = gclass.method_11("Discord: error {0}: {1}", "%", 1);
			SongEntry.currentSongMultiplierNote = gclass.method_11("Practice", "Quit", 1);
			SongEntry.videoStart = gclass.method_11("Resolution", " ", 0);
			return false;
		}
		return true;
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x000FFEA0 File Offset: 0x000FE0A0
	public SongEntry(string string_0)
	{
		string string_ = Path.Combine(string_0, "song.ini");
		string string_2 = Path.Combine(string_0, "notes.chart");
		this.folderPath = string_0;
		this.method_37(string_, string_2);
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x000FFF60 File Offset: 0x000FE160
	public SongEntry()
	{
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x0000DFAF File Offset: 0x0000C1AF
	public string method_29()
	{
		if (File.Exists(this.method_26()))
		{
			INIParser gclass = new INIParser();
			gclass.method_21(this.method_39());
			return gclass.method_2("Lead Guitar", "Stars Earned", "");
		}
		return "Encountered exception while attempting to load {0}";
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x000FFFF8 File Offset: 0x000FE1F8
	public bool method_30(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_31(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_30(gstruct, gstruct3_0);
		if (this.playCount < 124)
		{
			this.playCount += 1;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_66(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x000FE92C File Offset: 0x000FCB2C
	public GStruct3 method_31(GStruct2.GEnum11 genum11_0)
	{
		if (this.scores != null && this.scores.ContainsKey(genum11_0))
		{
			return this.scores[genum11_0];
		}
		return new GStruct3
		{
			genum11_0 = GStruct2.GEnum11.None
		};
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
	public Song method_32(bool bool_0 = false)
	{
		if (this.isMIDIChart)
		{
			return GClass30.smethod_1(this.folderPath, bool_0);
		}
		return new Song(this.folderPath);
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x0010007C File Offset: 0x000FE27C
	public bool method_33()
	{
		if (File.Exists(this.method_26()))
		{
			INIParser gclass = new INIParser();
			gclass.method_1(this.method_39());
			SongEntry.currentSongOffset = gclass.method_11("...", "Scan Songs", 1);
			SongEntry.currentSongCustomHOPO = gclass.method_11("{0}", "album", 0);
			SongEntry.isCurrentSongEighthHOPO = gclass.method_27("Menu Music", "Gameplay", true);
			this.songLength = gclass.method_11("", "custom", 1);
			SongEntry.currentSongMultiplierNote = gclass.method_11("There was a problem saving the file", "Delete Song", 1);
			SongEntry.videoStart = gclass.method_11("allow_duplicate_songs", "", 0);
			return true;
		}
		return true;
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x00100134 File Offset: 0x000FE334
	public void method_34(BinaryReader binaryReader_0)
	{
		this.isMIDIChart = binaryReader_0.ReadBoolean();
		this.songName = binaryReader_0.ReadString();
		this.artistName = binaryReader_0.ReadString();
		this.albumName = binaryReader_0.ReadString();
		this.genreName = binaryReader_0.ReadString();
		this.year = binaryReader_0.ReadString();
		this.charts.Int64_0 = binaryReader_0.ReadInt64();
		this.lyrics = binaryReader_0.ReadSByte();
		this.bandDifficulty = binaryReader_0.ReadSByte();
		this.guitarDifficulty = binaryReader_0.ReadSByte();
		this.rhythmDifficulty = binaryReader_0.ReadSByte();
		this.bassDifficulty = binaryReader_0.ReadSByte();
		this.drumsDifficulty = binaryReader_0.ReadSByte();
		this.keysDifficulty = binaryReader_0.ReadSByte();
		this.ghlGuitarDifficulty = binaryReader_0.ReadSByte();
		this.ghlBassDifficulty = binaryReader_0.ReadSByte();
		this.previewStart = binaryReader_0.ReadInt32();
		this.iconName = binaryReader_0.ReadString();
		this.albumTrack = binaryReader_0.ReadInt16();
		this.playlistTrack = binaryReader_0.ReadInt16();
		this.playlistName = binaryReader_0.ReadString();
		this.charterName = binaryReader_0.ReadString();
		this.songLength = binaryReader_0.ReadInt32();
		this.dateAdded = DateTime.FromBinary(binaryReader_0.ReadInt64());
		this.checksum = binaryReader_0.ReadString();
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x000FF544 File Offset: 0x000FD744
	public void method_35(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.isMIDIChart);
		binaryWriter_0.Write(this.songName);
		binaryWriter_0.Write(this.artistName);
		binaryWriter_0.Write(this.albumName);
		binaryWriter_0.Write(this.genreName);
		binaryWriter_0.Write(this.year);
		binaryWriter_0.Write(this.charts.Int64_0);
		binaryWriter_0.Write(this.lyrics);
		binaryWriter_0.Write(this.bandDifficulty);
		binaryWriter_0.Write(this.guitarDifficulty);
		binaryWriter_0.Write(this.rhythmDifficulty);
		binaryWriter_0.Write(this.bassDifficulty);
		binaryWriter_0.Write(this.drumsDifficulty);
		binaryWriter_0.Write(this.keysDifficulty);
		binaryWriter_0.Write(this.ghlGuitarDifficulty);
		binaryWriter_0.Write(this.ghlBassDifficulty);
		binaryWriter_0.Write(this.previewStart);
		binaryWriter_0.Write(this.iconName);
		binaryWriter_0.Write(this.albumTrack);
		binaryWriter_0.Write(this.playlistTrack);
		binaryWriter_0.Write(this.playlistName);
		binaryWriter_0.Write(this.charterName);
		binaryWriter_0.Write(this.songLength);
		binaryWriter_0.Write(this.dateAdded.ToBinary());
		binaryWriter_0.Write(this.checksum);
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x00100278 File Offset: 0x000FE478
	public void method_36()
	{
		INIParser gclass = new INIParser();
		gclass.method_21(this.method_26());
		gclass.method_34("video_start_time", "Static", this.songName);
		gclass.method_34("*Random", "Hard", this.artistName);
		gclass.method_34("No Part", "Game Manager", this.albumName);
		gclass.method_34("Song Length", "MSAA Level", this.genreName);
		gclass.method_34("game", "HUD", this.year);
		gclass.method_44("highway_placement", "Medium", (int)this.bandDifficulty);
		gclass.method_12("multiplier_note", "background_video", (int)this.guitarDifficulty);
		gclass.method_12("Play Count", "</color>", (int)this.rhythmDifficulty);
		gclass.method_8("", ".ogg", (int)this.bassDifficulty);
		gclass.method_12("Overwrite", "5 Fret Guitar", (int)this.drumsDifficulty);
		gclass.method_44("botnosave", "^", (int)this.keysDifficulty);
		gclass.method_8("", " ", (int)this.ghlGuitarDifficulty);
		gclass.method_44("Bot", "playlist_track", (int)this.ghlBassDifficulty);
		gclass.method_12("Alpha ", "Artist", this.previewStart);
		gclass.method_34("Couldn't write badsongs.txt", "multiplier_note", this.iconName);
		gclass.method_44("Show Mouse Cursor", "diff_guitar", (int)this.albumTrack);
		gclass.method_12("Song Speed", "Current Instrument", (int)this.playlistTrack);
		gclass.method_8("Songs are still scanning...", "cpu_name", SongEntry.videoStart);
		gclass.method_34("diff_bass", "All HOPO's", this.charterName);
		gclass.method_8("game", "volume", SongEntry.currentSongOffset);
		gclass.method_44("%points%", "", (this.songLength > 1) ? this.songLength : ((int)(BassAudioManager.instance.double_1 * 1438.0)));
		if (this.songLength <= 1)
		{
			this.songLength = (int)(BassAudioManager.instance.double_1 * 1992.0);
		}
		gclass.method_0();
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x001004AC File Offset: 0x000FE6AC
	public bool method_37(string string_0, string string_1)
	{
		SongEntry.smethod_5();
		if (File.Exists(string_0))
		{
			INIParser gclass = new INIParser();
			gclass.method_1(string_0);
			if (gclass.method_17("song"))
			{
				this.songName = gclass.method_2("song", "name", "");
				this.artistName = gclass.method_2("song", "artist", "Unknown Artist");
				this.albumName = gclass.method_2("song", "album", "Unknown Album");
				this.genreName = gclass.method_2("song", "genre", "Unknown Genre");
				this.year = gclass.method_2("song", "year", "Unknown Year");
				this.songLength = gclass.method_11("song", "song_length", 0);
				this.bandDifficulty = (sbyte)gclass.method_11("song", "diff_band", -1);
				this.guitarDifficulty = (sbyte)gclass.method_11("song", "diff_guitar", -1);
				this.rhythmDifficulty = (sbyte)gclass.method_11("song", "diff_rhythm", -1);
				this.bassDifficulty = (sbyte)gclass.method_11("song", "diff_bass", -1);
				this.drumsDifficulty = (sbyte)gclass.method_11("song", "diff_drums", -1);
				this.keysDifficulty = (sbyte)gclass.method_11("song", "diff_keys", -1);
				this.ghlGuitarDifficulty = (sbyte)gclass.method_11("song", "diff_guitarghl", -1);
				this.ghlBassDifficulty = (sbyte)gclass.method_11("song", "diff_bassghl", -1);
				this.previewStart = gclass.method_11("song", "preview_start_time", -1);
				this.iconName = gclass.method_2("song", "icon", "").ToLower();
				this.playlistTrack = (short)gclass.method_11("song", "playlist_track", 16000);
				if (gclass.method_28("song", "album_track"))
				{
					this.albumTrack = (short)gclass.method_11("song", "album_track", 16000);
				}
				else
				{
					this.albumTrack = (short)gclass.method_11("song", "track", 16000);
				}
				if (gclass.method_28("song", "charter"))
				{
					this.charterName = gclass.method_2("song", "charter", "Unknown Charter");
				}
				else
				{
					this.charterName = gclass.method_2("song", "frets", "Unknown Charter");
				}
			}
			gclass.method_0();
		}
		else if (File.Exists(string_1))
		{
			using (Stream stream = File.Open(string_1, FileMode.Open))
			{
				using (StreamReader streamReader = new StreamReader(stream))
				{
					while (!streamReader.EndOfStream)
					{
						string[] array = streamReader.ReadLine().Trim().Split(new char[]
						{
							'='
						});
						if (array[0] == "}")
						{
							break;
						}
						string text = array[0].ToLower().Trim();
						uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
						if (num <= 1387596744u)
						{
							if (num != 348705738u)
							{
								if (num != 572804318u)
								{
									if (num != 1387596744u)
									{
										continue;
									}
									if (!(text == "charter"))
									{
										continue;
									}
									try
									{
										this.charterName = array[1].Split(new char[]
										{
											'"'
										})[1];
										if (this.charterName == "")
										{
											this.charterName = "Unknown Charter";
										}
										continue;
									}
									catch
									{
										continue;
									}
								}
								if (!(text == "artist"))
								{
									continue;
								}
								try
								{
									this.artistName = array[1].Split(new char[]
									{
										'"'
									})[1];
									if (this.artistName == "")
									{
										this.artistName = "Unknown Artist";
									}
									continue;
								}
								catch
								{
									continue;
								}
							}
							if (!(text == "offset"))
							{
								continue;
							}
							try
							{
								SongEntry.currentSongOffset = (int)(float.Parse(array[1]) * 1000f);
								continue;
							}
							catch
							{
								SongEntry.currentSongOffset = 0;
								continue;
							}
						}
						if (num <= 1986820544u)
						{
							if (num != 1694181484u)
							{
								if (num != 1986820544u)
								{
									continue;
								}
								if (!(text == "genre"))
								{
									continue;
								}
								try
								{
									this.genreName = array[1].Split(new char[]
									{
										'"'
									})[1];
									if (this.genreName == "")
									{
										this.genreName = "Unknown Genre";
									}
									continue;
								}
								catch
								{
									continue;
								}
							}
							if (!(text == "album"))
							{
								continue;
							}
							try
							{
								this.albumName = array[1].Split(new char[]
								{
									'"'
								})[1];
								if (this.albumName == "")
								{
									this.albumName = "Unknown Album";
								}
								continue;
							}
							catch
							{
								continue;
							}
						}
						if (num != 2369371622u)
						{
							if (num != 2927578396u)
							{
								continue;
							}
							if (!(text == "year"))
							{
								continue;
							}
							try
							{
								this.year = array[1].Split(new char[]
								{
									'"'
								})[1];
								if (this.year == "")
								{
									this.year = "Unknown Year";
								}
								else
								{
									this.year = this.year.Replace(", ", "");
								}
								continue;
							}
							catch
							{
								continue;
							}
						}
						if (text == "name")
						{
							try
							{
								this.songName = array[1].Split(new char[]
								{
									'"'
								})[1];
							}
							catch
							{
							}
						}
					}
				}
			}
			if (this.songName == "TEMPO TRACK" || this.songName == "" || this.songName == "midi_export")
			{
				this.songName = "";
			}
		}
		return this.songName != null && this.songName.Length > 0;
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x0000DFE9 File Offset: 0x0000C1E9
	public string method_38()
	{
		return Path.Combine(this.folderPath, "");
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x0000DFFB File Offset: 0x0000C1FB
	public static void smethod_4()
	{
		SongEntry.isCurrentSongEighthHOPO = true;
		int num = 1;
		SongEntry.videoStart = 1;
		SongEntry.currentSongCustomHOPO = 1;
		SongEntry.currentSongMultiplierNote = 1;
		SongEntry.currentSongOffset = num;
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x0000E01B File Offset: 0x0000C21B
	public string method_39()
	{
		return Path.Combine(this.folderPath, "Lead Guitar");
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x0000E02D File Offset: 0x0000C22D
	public static void smethod_5()
	{
		SongEntry.isCurrentSongEighthHOPO = false;
		int num = 0;
		SongEntry.videoStart = 0;
		SongEntry.currentSongCustomHOPO = 0;
		SongEntry.currentSongMultiplierNote = 0;
		SongEntry.currentSongOffset = num;
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x00100B88 File Offset: 0x000FED88
	public bool method_40(GStruct3 gstruct3_0)
	{
		if (this.scores == null)
		{
			this.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
		}
		GStruct3 gstruct = this.method_5(gstruct3_0.genum11_0);
		GStruct3 gstruct2 = GStruct3.smethod_3(gstruct, gstruct3_0);
		if ((int)this.playCount < -139)
		{
			this.playCount += 0;
		}
		this.scores[gstruct2.genum11_0] = gstruct2;
		Class41.smethod_0(this.checksum, gstruct2, this.rating);
		return gstruct3_0.int_0 > gstruct.int_0;
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x000FE92C File Offset: 0x000FCB2C
	public GStruct3 method_41(GStruct2.GEnum11 genum11_0)
	{
		if (this.scores != null && this.scores.ContainsKey(genum11_0))
		{
			return this.scores[genum11_0];
		}
		return new GStruct3
		{
			genum11_0 = GStruct2.GEnum11.None
		};
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x00100C0C File Offset: 0x000FEE0C
	public bool method_42()
	{
		if (File.Exists(this.iniPath))
		{
			INIParser gclass = new INIParser();
			gclass.method_1(this.method_38());
			SongEntry.currentSongOffset = gclass.method_11("Hard", "offset", 0);
			SongEntry.currentSongCustomHOPO = gclass.method_11("Rhythm Guitar", "%count%", 0);
			SongEntry.isCurrentSongEighthHOPO = gclass.method_27("", "Particles", false);
			this.songLength = gclass.method_11("Highway", "game", 1);
			SongEntry.currentSongMultiplierNote = gclass.method_11("Lead Guitar", "song", 0);
			SongEntry.videoStart = gclass.method_11("Resolution = [\\-\\+]?\\d+(\\.\\d+)?", "artist", 1);
			return false;
		}
		return true;
	}

	// Token: 0x040004E0 RID: 1248
	[NonSerialized]
	public GStruct2 charts;

	// Token: 0x040004E1 RID: 1249
	[NonSerialized]
	public string iconName = "";

	// Token: 0x040004E2 RID: 1250
	[NonSerialized]
	public string folderPath;

	// Token: 0x040004E3 RID: 1251
	[NonSerialized]
	public string checksum;

	// Token: 0x040004E4 RID: 1252
	[NonSerialized]
	public string playlistName = "";

	// Token: 0x040004E5 RID: 1253
	[NonSerialized]
	public short playlistTrack;

	// Token: 0x040004E6 RID: 1254
	[NonSerialized]
	public short albumTrack;

	// Token: 0x040004E7 RID: 1255
	[NonSerialized]
	public int previewStart;

	// Token: 0x040004E8 RID: 1256
	[NonSerialized]
	public ushort playCount;

	// Token: 0x040004E9 RID: 1257
	[NonSerialized]
	public bool isHeader;

	// Token: 0x040004EA RID: 1258
	[NonSerialized]
	public bool isMIDIChart;

	// Token: 0x040004EB RID: 1259
	[NonSerialized]
	public DateTime dateAdded;

	// Token: 0x040004EC RID: 1260
	[NonSerialized]
	public Dictionary<GStruct2.GEnum11, GStruct3> scores;

	// Token: 0x040004ED RID: 1261
	[NonSerialized]
	public byte rating;

	// Token: 0x040004EE RID: 1262
	public string songName;

	// Token: 0x040004EF RID: 1263
	public string artistName = "Unknown Artist";

	// Token: 0x040004F0 RID: 1264
	public string albumName = "Unknown Album";

	// Token: 0x040004F1 RID: 1265
	public string genreName = "Unknown Genre";

	// Token: 0x040004F2 RID: 1266
	public string charterName = "Unknown Charter";

	// Token: 0x040004F3 RID: 1267
	public string year = "Unknown Year";

	// Token: 0x040004F4 RID: 1268
	public sbyte lyrics;

	// Token: 0x040004F5 RID: 1269
	public sbyte bandDifficulty = -1;

	// Token: 0x040004F6 RID: 1270
	public sbyte guitarDifficulty = -1;

	// Token: 0x040004F7 RID: 1271
	public sbyte bassDifficulty = -1;

	// Token: 0x040004F8 RID: 1272
	public sbyte rhythmDifficulty = -1;

	// Token: 0x040004F9 RID: 1273
	public sbyte drumsDifficulty = -1;

	// Token: 0x040004FA RID: 1274
	public sbyte keysDifficulty = -1;

	// Token: 0x040004FB RID: 1275
	public sbyte ghlGuitarDifficulty = -1;

	// Token: 0x040004FC RID: 1276
	public sbyte ghlBassDifficulty = -1;

	// Token: 0x040004FD RID: 1277
	public int songLength;

	// Token: 0x040004FE RID: 1278
	public static bool isCurrentSongEighthHOPO;

	// Token: 0x040004FF RID: 1279
	public static int currentSongOffset;

	// Token: 0x04000500 RID: 1280
	public static int currentSongMultiplierNote;

	// Token: 0x04000501 RID: 1281
	public static int currentSongCustomHOPO;

	// Token: 0x04000502 RID: 1282
	public static int videoStart;
}
