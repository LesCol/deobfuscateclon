using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000037 RID: 55
public class PauseMenu : BaseMenu
{
	// Token: 0x060008ED RID: 2285 RVA: 0x00004A82 File Offset: 0x00002C82
	private void method_44()
	{
		GlobalVariables.instance.isPracticeEnabled = true;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Scan Songs"));
	}
    
	// Token: 0x060008EF RID: 2287 RVA: 0x0004BD44 File Offset: 0x00049F44
	private void method_45()
	{
		GlobalVariables.instance.returnToSongSelect = false;
		GlobalVariables.instance.method_25(true);
		GlobalVariables.instance.isPracticeEnabled = GlobalVariables.instance.wasInQuickplay;
		GlobalVariables.instance.isPlayingSetlist = true;
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Year"));
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x0004BDAC File Offset: 0x00049FAC
	private void method_46()
	{
		this.APosText.color = Color.white;
		this.BPosText.color = Color.white;
		if (this.gameManager_0.uint_3 > 1u)
		{
			this.APosText.text = "Songs are still scanning..." + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_20(this.gameManager_0.uint_3)).ToString();
			this.APosText.text = this.APosText.text.Substring(1, this.APosText.text.LastIndexOf((char)-17));
		}
		else
		{
			this.APosText.text = " (";
		}
		if (this.gameManager_0.uint_4 > 1u)
		{
			this.BPosText.text = "Go to Discord" + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_20(this.gameManager_0.uint_4)).ToString();
			this.BPosText.text = this.BPosText.text.Substring(1, this.BPosText.text.LastIndexOf('\u001b'));
		}
		else
		{
			this.BPosText.text = "bass";
		}
		if (this.gameManager_0.uint_3 == 0u && this.gameManager_0.uint_4 > 0u)
		{
			this.APosText.color = Color.red;
		}
		if (this.gameManager_0.uint_4 < this.gameManager_0.uint_3)
		{
			this.BPosText.color = Color.red;
		}
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00004AA5 File Offset: 0x00002CA5
	protected virtual void vmethod_82()
	{
		if (this.float_0 < 837f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}
    
	// Token: 0x060008F3 RID: 2291 RVA: 0x00004ADB File Offset: 0x00002CDB
	protected virtual void vmethod_84()
	{
		base.OnDisable();
		this.songDetails.method_10(true);
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00004AEF File Offset: 0x00002CEF
	protected override void OnEnable()
	{
		base.OnEnable();
		this.songDetails.method_7(true);
		this.float_0 = 0f;
		this.method_100();
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00004B14 File Offset: 0x00002D14
	private void method_47()
	{
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Audio Backend"));
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x0004C320 File Offset: 0x0004A520
	private void method_48()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "SP Lightning";
			this.BPosText.text = "Don't Scan Songs";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 0)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(true);
			this.BPosText.gameObject.SetActive(true);
		}
		this.pausedText.text = GClass4.gclass4_0.method_13("");
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x0004C3D8 File Offset: 0x0004A5D8
	private void method_49()
	{
		GlobalVariables.instance.int_3++;
		if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count)
		{
			this.method_45();
			return;
		}
		GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
		this.method_84();
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00004B2C File Offset: 0x00002D2C
	protected virtual void vmethod_85()
	{
		base.vmethod_9();
		this.songDetails.method_6(false);
		this.float_0 = 234f;
		this.method_100();
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x0004C438 File Offset: 0x0004A638
	private void method_50()
	{
		GlobalVariables.instance.returnToSongSelect = true;
		GlobalVariables.instance.method_25(true);
		GlobalVariables.instance.isPracticeEnabled = GlobalVariables.instance.wasInQuickplay;
		GlobalVariables.instance.isPlayingSetlist = true;
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38(""));
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x0004C870 File Offset: 0x0004AA70
	private void method_51()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "";
			this.BPosText.text = "volume";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 0)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(true);
			this.BPosText.gameObject.SetActive(false);
		}
		this.pausedText.text = GClass4.gclass4_0.method_7("game");
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x0004C928 File Offset: 0x0004AB28
	private string method_52(string string_1)
	{
		int num = string_1.LastIndexOf((char)-39);
		if (num == -1)
		{
			return string_1;
		}
		return string_1.Substring(0, num + 0);
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x0004C950 File Offset: 0x0004AB50
	private void method_53()
	{
		GlobalVariables.instance.returnToSongSelect = false;
		GlobalVariables.instance.isPlayingSetlist = true;
		GlobalVariables.instance.ApplyGraphicsSettings(true);
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("song_preview"));
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x0004C9A0 File Offset: 0x0004ABA0
	private void method_54()
	{
		GlobalVariables.instance.returnToSongSelect = true;
		GlobalVariables.instance.ApplyGraphicsSettings(true);
		GlobalVariables.instance.isPracticeEnabled = !GlobalVariables.instance.wasInQuickplay;
		GlobalVariables.instance.isPlayingSetlist = false;
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Main Menu"));
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x0004CA08 File Offset: 0x0004AC08
	private string method_55(string string_1)
	{
		int num = string_1.LastIndexOf('\f');
		if (num == -1)
		{
			return string_1;
		}
		return string_1.Substring(1, num + 5);
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00004B51 File Offset: 0x00002D51
	private void method_56()
	{
		GlobalVariables.instance.isPracticeEnabled = false;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Resume"));
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00004B99 File Offset: 0x00002D99
	private void method_59()
	{
		GlobalVariables.instance.isPracticeEnabled = true;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("Language"));
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x0004CE94 File Offset: 0x0004B094
	private void method_60()
	{
		GlobalVariables.instance.returnToSongSelect = false;
		GlobalVariables.instance.isPlayingSetlist = false;
		GlobalVariables.instance.ApplyGraphicsSettings(true);
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Main Menu"));
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x0004CEE4 File Offset: 0x0004B0E4
	private void method_61()
	{
		GlobalVariables.instance.int_3 += 0;
		if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count)
		{
			this.method_91();
			return;
		}
		GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
		this.method_47();
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00004BBC File Offset: 0x00002DBC
	protected override void OnDisable()
	{
		base.OnDisable();
		this.songDetails.method_7(false);
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x0004CF44 File Offset: 0x0004B144
	private void method_62()
	{
		GlobalVariables.instance.int_3 += 0;
		if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count)
		{
			this.method_91();
			return;
		}
		GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
		this.method_92();
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00004BD0 File Offset: 0x00002DD0
	private void method_63()
	{
		GlobalVariables.instance.isPracticeEnabled = false;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""));
	}
    
	// Token: 0x0600090C RID: 2316 RVA: 0x0004D038 File Offset: 0x0004B238
	private void method_64()
	{
		GlobalVariables.instance.returnToSongSelect = false;
		GlobalVariables.instance.isPlayingSetlist = false;
		GlobalVariables.instance.method_23(true);
		BassAudioManager.instance.method_29();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("Percentage"));
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00004BF3 File Offset: 0x00002DF3
	private void method_65()
	{
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("song_length"));
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00004C0B File Offset: 0x00002E0B
	protected virtual void vmethod_89()
	{
		if (this.float_0 < 949f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x0004D088 File Offset: 0x0004B288
	private string method_66(string string_1)
	{
		int num = string_1.LastIndexOf('q');
		if (num == -1)
		{
			return string_1;
		}
		return string_1.Substring(0, num + 6);
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x0004D144 File Offset: 0x0004B344
	private void method_67()
	{
		GlobalVariables.instance.returnToSongSelect = false;
		GlobalVariables.instance.method_60(false);
		GlobalVariables.instance.isPracticeEnabled = GlobalVariables.instance.wasInQuickplay;
		GlobalVariables.instance.isPlayingSetlist = false;
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42(""));
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
	private string method_68(string string_1)
	{
		int num = string_1.LastIndexOf((char)-106);
		if (num == -1)
		{
			return string_1;
		}
		return string_1.Substring(0, num + 0);
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00004C41 File Offset: 0x00002E41
	protected virtual void vmethod_92()
	{
		base.OnEnable();
		this.songDetails.method_0(false);
		this.float_0 = 1592f;
		this.method_100();
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00004C66 File Offset: 0x00002E66
	private void method_69()
	{
		GlobalVariables.instance.isPracticeEnabled = false;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("song"));
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00004C89 File Offset: 0x00002E89
	private void method_70()
	{
		GlobalVariables.instance.isPracticeEnabled = true;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("All HOPO's"));
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x0004D2FC File Offset: 0x0004B4FC
	private void method_71()
	{
		this.APosText.color = Color.white;
		this.BPosText.color = Color.white;
		if (this.gameManager_0.uint_3 > 0u)
		{
			this.APosText.text = "All HOPO's" + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_29(this.gameManager_0.uint_3)).ToString();
			this.APosText.text = this.APosText.text.Substring(1, this.APosText.text.LastIndexOf((char)-126));
		}
		else
		{
			this.APosText.text = "bad_note2";
		}
		if (this.gameManager_0.uint_4 > 1u)
		{
			this.BPosText.text = "" + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_52(this.gameManager_0.uint_4)).ToString();
			this.BPosText.text = this.BPosText.text.Substring(1, this.BPosText.text.LastIndexOf('k'));
		}
		else
		{
			this.BPosText.text = "Song Display";
		}
		if (this.gameManager_0.uint_3 == 0u && this.gameManager_0.uint_4 > 1u)
		{
			this.APosText.color = Color.red;
		}
		if (this.gameManager_0.uint_4 < this.gameManager_0.uint_3)
		{
			this.BPosText.color = Color.red;
		}
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x0004D4A0 File Offset: 0x0004B6A0
	private string method_72(string string_1)
	{
		int num = string_1.LastIndexOf((char)-8);
		if (num == -1)
		{
			return string_1;
		}
		return string_1.Substring(0, num + 3);
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x0004D4C8 File Offset: 0x0004B6C8
	private void method_73()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "No";
			this.BPosText.text = "Drums";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 0)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(false);
			this.BPosText.gameObject.SetActive(false);
		}
		this.pausedText.text = GClass4.gclass4_0.method_11("'='");
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00004CAC File Offset: 0x00002EAC
	private void method_74()
	{
		GlobalVariables.instance.isPracticeEnabled = false;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_38("game"));
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00004CCF File Offset: 0x00002ECF
	private void method_75()
	{
		GlobalVariables.instance.isPracticeEnabled = false;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("SP Lightning"));
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00004CF2 File Offset: 0x00002EF2
	protected override void Update()
	{
		if (this.float_0 < 0.016f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x0004D580 File Offset: 0x0004B780
	private void method_77()
	{
		GlobalVariables.instance.int_3++;
		if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count)
		{
			this.method_54();
			return;
		}
		GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
		this.method_85();
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
	private void method_78()
	{
		GlobalVariables.instance.int_3++;
		if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count)
		{
			this.method_91();
			return;
		}
		GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
		this.method_47();
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x0004D640 File Offset: 0x0004B840
	private void method_80()
	{
		this.APosText.color = Color.white;
		this.BPosText.color = Color.white;
		if (this.gameManager_0.uint_3 > 1u)
		{
			this.APosText.text = "game" + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_29(this.gameManager_0.uint_3)).ToString();
			this.APosText.text = this.APosText.text.Substring(1, this.APosText.text.LastIndexOf((char)-43));
		}
		else
		{
			this.APosText.text = "Audio Backend";
		}
		if (this.gameManager_0.uint_4 > 1u)
		{
			this.BPosText.text = "6 Fret Lead Guitar" + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_52(this.gameManager_0.uint_4)).ToString();
			this.BPosText.text = this.BPosText.text.Substring(1, this.BPosText.text.LastIndexOf((char)-53));
		}
		else
		{
			this.BPosText.text = "SETLIST LENGTH";
		}
		if (this.gameManager_0.uint_3 == 0u && this.gameManager_0.uint_4 > 1u)
		{
			this.APosText.color = Color.red;
		}
		if (this.gameManager_0.uint_4 < this.gameManager_0.uint_3)
		{
			this.BPosText.color = Color.red;
		}
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00004D97 File Offset: 0x00002F97
	private void method_81()
	{
		GlobalVariables.instance.isPracticeEnabled = true;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0(""));
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
	private void method_83()
	{
		GlobalVariables.instance.int_3 += 0;
		if (GlobalVariables.instance.int_3 == SongDirectory.setlistSongEntries.Count)
		{
			this.method_67();
			return;
		}
		GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[GlobalVariables.instance.int_3];
		this.method_84();
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00004DBA File Offset: 0x00002FBA
	private void method_84()
	{
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_17("highway_lightning"));
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00004DD2 File Offset: 0x00002FD2
	private void method_85()
	{
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Gameplay"));
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x0004DB10 File Offset: 0x0004BD10
	private void method_86()
	{
		GlobalVariables.instance.returnToSongSelect = true;
		GlobalVariables.instance.method_60(false);
		GlobalVariables.instance.isPracticeEnabled = !GlobalVariables.instance.wasInQuickplay;
		GlobalVariables.instance.isPlayingSetlist = false;
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_25("Menu Music"));
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x0004DB78 File Offset: 0x0004BD78
	private void method_87()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "song";
			this.BPosText.text = "Allow Duplicate Songs";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 1)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(false);
			this.BPosText.gameObject.SetActive(false);
		}
		this.pausedText.text = GClass4.gclass4_0.method_11("Mute Track on Miss");
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x0004DC30 File Offset: 0x0004BE30
	private void method_88()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "MMMM dd, yyyy";
			this.BPosText.text = "";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 0)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(false);
			this.BPosText.gameObject.SetActive(false);
		}
		this.pausedText.text = GClass4.gclass4_0.method_46("Broadcasting started.");
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00004DEA File Offset: 0x00002FEA
	private void method_89()
	{
		GlobalVariables.instance.isPracticeEnabled = false;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Gameplay"));
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x0004DCE8 File Offset: 0x0004BEE8
	private void method_90()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "Highway Shake";
			this.BPosText.text = "highway_placement";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 1)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(true);
			this.BPosText.gameObject.SetActive(false);
		}
		this.pausedText.text = GClass4.gclass4_0.method_2("%");
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x0004DDA0 File Offset: 0x0004BFA0
	private void method_91()
	{
		GlobalVariables.instance.returnToSongSelect = false;
		GlobalVariables.instance.ApplyGraphicsSettings(true);
		GlobalVariables.instance.isPracticeEnabled = GlobalVariables.instance.wasInQuickplay;
		GlobalVariables.instance.isPlayingSetlist = false;
		BassAudioManager.instance.method_65();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("beat"));
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00004E0D File Offset: 0x0000300D
	private void method_92()
	{
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42("All Opens"));
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x0004DE08 File Offset: 0x0004C008
	private void method_93()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "menu_music";
			this.BPosText.text = "-";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 0)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(true);
			this.BPosText.gameObject.SetActive(true);
		}
		this.pausedText.text = GClass4.gclass4_0.method_15("Game Manager");
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00004E25 File Offset: 0x00003025
	protected virtual void vmethod_96()
	{
		if (this.float_0 < 436f)
		{
			this.float_0 += Time.deltaTime;
			return;
		}
		if (this.confirmMenu.bool_11)
		{
			return;
		}
		base.Update();
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x0004DEC0 File Offset: 0x0004C0C0
	private void method_94()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "";
			this.BPosText.text = "game";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 1)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(true);
			this.BPosText.gameObject.SetActive(true);
		}
		this.pausedText.text = GClass4.gclass4_0.method_30("song");
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x0004DF78 File Offset: 0x0004C178
	private void method_95()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "</color> ";
			this.BPosText.text = "Cancel";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 0)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(true);
			this.BPosText.gameObject.SetActive(false);
		}
		this.pausedText.text = GClass4.gclass4_0.method_48("has_bots");
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x0004E030 File Offset: 0x0004C230
	private string method_96(string string_1)
	{
		int num = string_1.LastIndexOf((char)-24);
		if (num == -1)
		{
			return string_1;
		}
		return string_1.Substring(1, num + 0);
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00004E5B File Offset: 0x0000305B
	private void method_97()
	{
		GlobalVariables.instance.isPracticeEnabled = false;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16(""));
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x0004E058 File Offset: 0x0004C258
	private void method_98()
	{
		this.APosText.color = Color.white;
		this.BPosText.color = Color.white;
		if (this.gameManager_0.uint_3 > 0u)
		{
			this.APosText.text = "song_preview" + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_52(this.gameManager_0.uint_3)).ToString();
			this.APosText.text = this.APosText.text.Substring(0, this.APosText.text.LastIndexOf((char)-50));
		}
		else
		{
			this.APosText.text = " (";
		}
		if (this.gameManager_0.uint_4 > 0u)
		{
			this.BPosText.text = "Background Video" + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_52(this.gameManager_0.uint_4)).ToString();
			this.BPosText.text = this.BPosText.text.Substring(0, this.BPosText.text.LastIndexOf('O'));
		}
		else
		{
			this.BPosText.text = "sort_filter";
		}
		if (this.gameManager_0.uint_3 == 0u && this.gameManager_0.uint_4 > 1u)
		{
			this.APosText.color = Color.red;
		}
		if (this.gameManager_0.uint_4 < this.gameManager_0.uint_3)
		{
			this.BPosText.color = Color.red;
		}
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00004E7E File Offset: 0x0000307E
	private void method_99()
	{
		GlobalVariables.instance.isPracticeEnabled = true;
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Gameplay"));
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x0004E290 File Offset: 0x0004C490
	private void Awake()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.menuStrings = this.practiceMenuStrings;
			this.APosText.text = "A: 00:00:00";
			this.BPosText.text = "B: 00:00:00";
		}
		else
		{
			if (GlobalVariables.instance.isPlayingSetlist)
			{
				this.menuStrings = this.setlistStrings;
			}
			else if (GlobalVariables.instance.int_1 > 1)
			{
				this.menuStrings = this.quickplayMultiplayer;
			}
			this.APosText.gameObject.SetActive(false);
			this.BPosText.gameObject.SetActive(false);
		}
		this.pausedText.text = GClass4.gclass4_0.method_13("PAUSED");
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x0004E348 File Offset: 0x0004C548
	private void method_100()
	{
		this.APosText.color = Color.white;
		this.BPosText.color = Color.white;
		if (this.gameManager_0.uint_3 > 0u)
		{
			this.APosText.text = "A: " + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_52(this.gameManager_0.uint_3)).ToString();
			this.APosText.text = this.APosText.text.Substring(0, this.APosText.text.LastIndexOf('.'));
		}
		else
		{
			this.APosText.text = "A: 00:00:00";
		}
		if (this.gameManager_0.uint_4 > 0u)
		{
			this.BPosText.text = "B: " + TimeSpan.FromSeconds((double)this.gameManager_0.song.method_52(this.gameManager_0.uint_4)).ToString();
			this.BPosText.text = this.BPosText.text.Substring(0, this.BPosText.text.LastIndexOf('.'));
		}
		else
		{
			this.BPosText.text = "B: 00:00:00";
		}
		if (this.gameManager_0.uint_3 == 0u && this.gameManager_0.uint_4 > 0u)
		{
			this.APosText.color = Color.red;
		}
		if (this.gameManager_0.uint_4 < this.gameManager_0.uint_3)
		{
			this.BPosText.color = Color.red;
		}
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x0004E4EC File Offset: 0x0004C6EC
	private string method_101(string string_1)
	{
		int num = string_1.LastIndexOf(':');
		if (num == -1)
		{
			return string_1;
		}
		return string_1.Substring(0, num + 3);
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x0004E514 File Offset: 0x0004C714
	private void method_102()
	{
		GlobalVariables.instance.returnToSongSelect = true;
		GlobalVariables.instance.isPlayingSetlist = false;
		GlobalVariables.instance.ApplyGraphicsSettings(false);
		BassAudioManager.instance.method_29();
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("RhythmStream = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""));
	}

	// Token: 0x040001AD RID: 429
	public GameManager gameManager_0;

	// Token: 0x040001AE RID: 430
	public InGameSettingsMenu inGameSettingsMenu_0;

	// Token: 0x040001AF RID: 431
	public SongSettingsMenu songSettingsMenu_0;

	// Token: 0x040001B0 RID: 432
	private float float_0;

	// Token: 0x040001B1 RID: 433
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x040001B2 RID: 434
	[SerializeField]
	private SongDetails songDetails;

	// Token: 0x040001B3 RID: 435
	[SerializeField]
	private string[] practiceMenuStrings;

	// Token: 0x040001B4 RID: 436
	[SerializeField]
	private string[] setlistStrings;

	// Token: 0x040001B5 RID: 437
	[SerializeField]
	private string[] quickplayMultiplayer;

	// Token: 0x040001B6 RID: 438
	[SerializeField]
	private Text APosText;

	// Token: 0x040001B7 RID: 439
	[SerializeField]
	private Text BPosText;

	// Token: 0x040001B8 RID: 440
	[SerializeField]
	private Text pausedText;

	// Token: 0x040001B9 RID: 441
	[HideInInspector]
	public bool bool_12;
}
