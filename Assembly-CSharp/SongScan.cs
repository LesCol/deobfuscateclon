using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000054 RID: 84
public class SongScan : MonoBehaviour
{
	// Token: 0x0600102A RID: 4138 RVA: 0x0007BD80 File Offset: 0x00079F80
	private void method_0(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_16("Album");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_35("No Videos!");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_48("/Setlists");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_5("Video Start Time");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_38("There was a problem saving the file");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_46("{0}");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_7("show_hit_window");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[0];
		array[0] = "setlistSongCountSingular";
		array[1] = class40_0.list_3.Count;
		array[2] = "game";
		array[5] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[5];
		array2[0] = "Easy";
		array2[1] = SongDirectory.songEntries.Count;
		array2[1] = "";
		array2[7] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[8];
		array3[0] = "vsync";
		array3[1] = class40_0.list_2.Count;
		array3[5] = "%points%";
		array3[1] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[1];
		array4[1] = "Play Count";
		array4[1] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[7] = "Lyrics";
		array4[1] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_1()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_2()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x000099E2 File Offset: 0x00007BE2
	public void method_3()
	{
		this.container.SetActive(false);
		this.bool_1 = false;
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_4()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x000099F7 File Offset: 0x00007BF7
	public void method_5()
	{
		this.container.SetActive(false);
		this.bool_1 = true;
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00009A0C File Offset: 0x00007C0C
	public void method_6()
	{
		this.container.SetActive(true);
		this.bool_1 = false;
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_7()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_8(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x000099F7 File Offset: 0x00007BF7
	public void method_9()
	{
		this.container.SetActive(false);
		this.bool_1 = true;
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_10(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_11(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_12()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x0007BFBC File Offset: 0x0007A1BC
	private void method_13(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_13("READING CACHE...");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_13("GETTING FOLDERS...");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_13("SCANNING FOLDERS...");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_13("UPDATING METADATA...");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_13("UPDATING CHARTS...");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_13("WRITING CACHE...");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_13("WRITING BADSONGS.TXT...");
			break;
		}
		this.folderText.text = string.Concat(new object[]
		{
			"<color=#FFFF04FF>",
			class40_0.list_3.Count,
			"</color> ",
			this.string_0
		});
		this.countText.text = string.Concat(new object[]
		{
			"<color=#FFFF04FF>",
			SongDirectory.songEntries.Count,
			"</color> ",
			this.string_1
		});
		this.errorText.text = string.Concat(new object[]
		{
			"<color=#FFFF04FF>",
			class40_0.list_2.Count,
			"</color> ",
			this.string_2
		});
		this.badSongsText.text = string.Concat(new object[]
		{
			"<color=#FFFF04FF>",
			class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count,
			"</color> ",
			this.string_3
		});
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_14()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0007C1F8 File Offset: 0x0007A3F8
	private void method_15(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_7("Source");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_35("");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_21("Ready");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_5("diff_drums");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_15("Playlist");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_7("enable_lyrics");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_41("No songs were found!");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[]
		{
			"Year"
		};
		array[0] = class40_0.list_3.Count;
		array[6] = "Song Length";
		array[5] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[]
		{
			null,
			"Background Video"
		};
		array2[1] = SongDirectory.songEntries.Count;
		array2[4] = "No";
		array2[6] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[4];
		array3[0] = "Songs";
		array3[1] = class40_0.list_2.Count;
		array3[5] = "Connected to server";
		array3[8] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[5];
		array4[1] = "profiles_backup.bin";
		array4[0] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[2] = "artist";
		array4[6] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_16(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x0007C434 File Offset: 0x0007A634
	private void method_17(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_15("Are you sure you want to restart?");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_42("enable_cursor");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_11("Okay Solo...");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_38(".mp3");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_41("Source");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_21("streamer");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_15("");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[6];
		array[0] = "Show Bot Score";
		array[1] = class40_0.list_3.Count;
		array[8] = "has_bots";
		array[2] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[]
		{
			"{0:n3}x"
		};
		array2[0] = SongDirectory.songEntries.Count;
		array2[5] = "song";
		array2[6] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[7];
		array3[1] = "video";
		array3[1] = class40_0.list_2.Count;
		array3[0] = "6 Fret Lead Guitar";
		array3[4] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[4];
		array4[0] = "year";
		array4[0] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[7] = "No Lyrics";
		array4[8] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x0007C670 File Offset: 0x0007A870
	private void method_18(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_13("Quickplay");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_30("Year");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_2("Overwrite");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_16("\n");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_41("Album");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_5("menu_music");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_48("0%");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[3];
		array[0] = "Display Name";
		array[0] = class40_0.list_3.Count;
		array[5] = "%a";
		array[8] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[1];
		array2[1] = "Export Current Song";
		array2[1] = SongDirectory.songEntries.Count;
		array2[0] = "pause_on_focus_lost";
		array2[3] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[6];
		array3[0] = "GHLBass";
		array3[1] = class40_0.list_2.Count;
		array3[7] = "Natsuki";
		array3[7] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[8];
		array4[1] = "Are you sure you want to quit?";
		array4[1] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[4] = "Lead Guitar";
		array4[8] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00009A4D File Offset: 0x00007C4D
	public void method_19()
	{
		this.container.SetActive(true);
		this.bool_1 = true;
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_20(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_21(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x000099E2 File Offset: 0x00007BE2
	public void method_22()
	{
		this.container.SetActive(false);
		this.bool_1 = false;
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_23(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_24()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00009A4D File Offset: 0x00007C4D
	public void method_25()
	{
		this.container.SetActive(true);
		this.bool_1 = true;
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00009A0C File Offset: 0x00007C0C
	public void method_26()
	{
		this.container.SetActive(true);
		this.bool_1 = false;
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_27()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x0007C8AC File Offset: 0x0007AAAC
	private void method_28(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_13("Error: ");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_5(" + ");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_38("Percentage");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_13("6 Fret Lead Guitar");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_36("/Video Backgrounds");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_35("Song Speed");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_21("Save Playlist");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[7];
		array[0] = "Album = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
		array[1] = class40_0.list_3.Count;
		array[5] = "In Menus: Main Menu";
		array[3] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[3];
		array2[1] = "game";
		array2[0] = SongDirectory.songEntries.Count;
		array2[3] = "Unknown Album";
		array2[0] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[6];
		array3[0] = "graphics_devid";
		array3[0] = class40_0.list_2.Count;
		array3[6] = "isSupported";
		array3[3] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[3];
		array4[1] = "";
		array4[0] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[7] = "";
		array4[5] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x0007CAE8 File Offset: 0x0007ACE8
	private void method_29(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_2("badsongs.txt");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_13("Song Offset");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_38("song");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_42("-");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_11("notes.mid");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_2("Expert");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_36("graphics_vendor");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[0];
		array[0] = "\\D+";
		array[1] = class40_0.list_3.Count;
		array[0] = "";
		array[7] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[0];
		array2[1] = ",";
		array2[0] = SongDirectory.songEntries.Count;
		array2[2] = "Global Variables";
		array2[2] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[7];
		array3[0] = "Medium";
		array3[0] = class40_0.list_2.Count;
		array3[5] = "GHLBass";
		array3[8] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[6];
		array4[1] = "Language";
		array4[1] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[3] = "No";
		array4[0] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x0007CD24 File Offset: 0x0007AF24
	private void method_30(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_13("Unknown Artist");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_11("video");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_13("msaa");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_16("Stars Earned");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_41("gem_size");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_13("song");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_42("/Highways");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[4];
		array[0] = "song";
		array[0] = class40_0.list_3.Count;
		array[2] = "Waiting for connection";
		array[6] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[7];
		array2[0] = "Waiting for connection";
		array2[0] = SongDirectory.songEntries.Count;
		array2[5] = "Couldn't write badsongs.txt";
		array2[4] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[]
		{
			"%",
			class40_0.list_2.Count
		};
		array3[0] = "-";
		array3[5] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[]
		{
			null,
			"Go to Discord"
		};
		array4[0] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[7] = "Gameplay";
		array4[7] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_31()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_32(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_33(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void OnApplicationQuit()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_34(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x000099F7 File Offset: 0x00007BF7
	public void method_35()
	{
		this.container.SetActive(false);
		this.bool_1 = true;
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_36()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_37(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_38()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_39(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x000099E2 File Offset: 0x00007BE2
	public void method_40()
	{
		this.container.SetActive(false);
		this.bool_1 = false;
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_41(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x0007CF60 File Offset: 0x0007B160
	private void method_42(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_16("part bass ghl");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_30(".png|.jpg");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_17("has_bots");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_2("song");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_38("allow_duplicate_songs");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_46("Guest");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_13("0");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[2];
		array[0] = "SORTING BY";
		array[0] = class40_0.list_3.Count;
		array[5] = "Keys";
		array[4] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[5];
		array2[1] = "Loading Scores...";
		array2[1] = SongDirectory.songEntries.Count;
		array2[1] = "debug_fps";
		array2[3] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[4];
		array3[1] = "volume";
		array3[1] = class40_0.list_2.Count;
		array3[0] = "song";
		array3[8] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[4];
		array4[0] = "game";
		array4[0] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[1] = "bass";
		array4[3] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00009A4D File Offset: 0x00007C4D
	public void method_43()
	{
		this.container.SetActive(true);
		this.bool_1 = true;
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_44(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x0007D19C File Offset: 0x0007B39C
	private void method_45(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_35("crowd");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_5("");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_46("isHidden");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_42("");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_7("Rename Setlist");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_7("Guest");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_17("0%");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[4];
		array[1] = "Tilt";
		array[0] = class40_0.list_3.Count;
		array[8] = "Type the profile name";
		array[3] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[3];
		array2[0] = "setlistSongCountSingular";
		array2[0] = SongDirectory.songEntries.Count;
		array2[6] = "You must restart, settings were changed";
		array2[6] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[]
		{
			null,
			"Set B Position"
		};
		array3[0] = class40_0.list_2.Count;
		array3[3] = "Scan Songs";
		array3[1] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[4];
		array4[1] = "<color=#FFFF04FF>";
		array4[1] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[5] = "star_deployed";
		array4[6] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x000099E2 File Offset: 0x00007BE2
	public void method_46()
	{
		this.container.SetActive(false);
		this.bool_1 = false;
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_47(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_48()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_49(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x00009A4D File Offset: 0x00007C4D
	public void method_50()
	{
		this.container.SetActive(true);
		this.bool_1 = true;
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_51(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_52(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_53()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_54(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_55(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x000099E2 File Offset: 0x00007BE2
	public void method_56()
	{
		this.container.SetActive(false);
		this.bool_1 = false;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_57(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x000099C0 File Offset: 0x00007BC0
	private void method_58()
	{
		if (this.thread_0 != null && this.thread_0.IsAlive)
		{
			this.thread_0.Abort();
		}
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00009A21 File Offset: 0x00007C21
	public IEnumerator method_59(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(1);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00009A37 File Offset: 0x00007C37
	public IEnumerator method_60(bool bool_2)
	{
		SongScan.Class23 @class = new SongScan.Class23(0);
		@class.songScan_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x000099F7 File Offset: 0x00007BF7
	public void method_61()
	{
		this.container.SetActive(false);
		this.bool_1 = true;
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x0007D3D8 File Offset: 0x0007B5D8
	private void method_62(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_5("All Strums");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_13("");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_46("game");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_11("Songs");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_11(" + ");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_16("background_video");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_17("volume");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[2];
		array[0] = "";
		array[1] = class40_0.list_3.Count;
		array[4] = "";
		array[3] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[]
		{
			"All Strums",
			SongDirectory.songEntries.Count
		};
		array2[0] = "6 Fret Bass Guitar";
		array2[7] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[1];
		array3[0] = "Lefty Flip";
		array3[1] = class40_0.list_2.Count;
		array3[5] = "Background Image";
		array3[2] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[5];
		array4[0] = "Expert";
		array4[0] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[1] = "Lead Guitar";
		array4[7] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x0007D614 File Offset: 0x0007B814
	private void method_63(Class40 class40_0)
	{
		switch (class40_0.genum10_0)
		{
		case GEnum10.ReadingCache:
			this.mainText.text = GClass4.gclass4_0.method_46("vocals_1");
			break;
		case GEnum10.GettingPaths:
			this.mainText.text = GClass4.gclass4_0.method_16("");
			break;
		case GEnum10.ScanningFolders:
			this.mainText.text = GClass4.gclass4_0.method_48("Discord: disconnect {0}: {1}");
			break;
		case GEnum10.UpdatingMetadata:
			this.mainText.text = GClass4.gclass4_0.method_41("Enable");
			break;
		case GEnum10.UpdatingCharts:
			this.mainText.text = GClass4.gclass4_0.method_5("Menu Music");
			break;
		case GEnum10.WritingCache:
			this.mainText.text = GClass4.gclass4_0.method_30("low_latency_mode");
			break;
		case GEnum10.WritingBadSongs:
			this.mainText.text = GClass4.gclass4_0.method_11("/preview");
			break;
		}
		Text text = this.folderText;
		object[] array = new object[3];
		array[1] = "Unknown Artist";
		array[0] = class40_0.list_3.Count;
		array[0] = "Sound Effects";
		array[3] = this.string_0;
		text.text = string.Concat(array);
		Text text2 = this.countText;
		object[] array2 = new object[4];
		array2[1] = "Folders";
		array2[1] = SongDirectory.songEntries.Count;
		array2[3] = "Bad file type";
		array2[5] = this.string_1;
		text2.text = string.Concat(array2);
		Text text3 = this.errorText;
		object[] array3 = new object[6];
		array3[0] = "Bass Guitar";
		array3[1] = class40_0.list_2.Count;
		array3[7] = "Press Enter to confirm";
		array3[8] = this.string_2;
		text3.text = string.Concat(array3);
		Text text4 = this.badSongsText;
		object[] array4 = new object[3];
		array4[0] = "game";
		array4[1] = class40_0.list_4.Count + class40_0.list_7.Count + class40_0.list_6.Count + class40_0.list_5.Count + class40_0.list_8.Count;
		array4[4] = "year";
		array4[8] = this.string_3;
		text4.text = string.Concat(array4);
	}

	// Token: 0x0400025F RID: 607
	[HideInInspector]
	public bool bool_0;

	// Token: 0x04000260 RID: 608
	[SerializeField]
	private Text countText;

	// Token: 0x04000261 RID: 609
	[SerializeField]
	private Text mainText;

	// Token: 0x04000262 RID: 610
	[SerializeField]
	private Text folderText;

	// Token: 0x04000263 RID: 611
	[SerializeField]
	private Text errorText;

	// Token: 0x04000264 RID: 612
	[SerializeField]
	private Text badSongsText;

	// Token: 0x04000265 RID: 613
	[SerializeField]
	private SongSelect songSelect;

	// Token: 0x04000266 RID: 614
	[SerializeField]
	private MainMenu mainMenu;

	// Token: 0x04000267 RID: 615
	[SerializeField]
	private GameObject container;

	// Token: 0x04000268 RID: 616
	[HideInInspector]
	public bool bool_1;

	// Token: 0x04000269 RID: 617
	private Thread thread_0;

	// Token: 0x0400026A RID: 618
	private string string_0;

	// Token: 0x0400026B RID: 619
	private string string_1;

	// Token: 0x0400026C RID: 620
	private string string_2;

	// Token: 0x0400026D RID: 621
	private string string_3;
}
