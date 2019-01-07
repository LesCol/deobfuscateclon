using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000056 RID: 86
public class SongSelect : BaseMenu
{
	// Token: 0x060010B2 RID: 4274 RVA: 0x00009A79 File Offset: 0x00007C79
	private IEnumerator method_44()
	{
		SongSelect.Class24 @class = new SongSelect.Class24(0);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x0007FC50 File Offset: 0x0007DE50
	public void method_45()
	{
		Text text = this.songCount;
		object[] array = new object[4];
		array[1] = GClass4.gclass4_0.method_11("Setlist Options");
		array[0] = "year";
		array[4] = GlobalVariables.instance.int_2;
		array[8] = "full_playlist";
		text.text = string.Concat(array);
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0007FCA8 File Offset: 0x0007DEA8
	public override void vmethod_43()
	{
		if (this.setlistMenu.isActiveAndEnabled)
		{
			this.setlistMenu.method_63();
			return;
		}
		DiscordController.discordController_0.method_22();
		BassAudioManager.instance.Song_FadeOutAndEnd();
		BassAudioManager.instance.PlayMenuMusic();
		this.mainMenu.SetActive(true);
		base.gameObject.SetActive(false);
		GlobalVariables.instance.songEntry_1 = SongDirectory.songEntries[base.Int32_0];
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x0007FD20 File Offset: 0x0007DF20
	private int method_46(SongEntry songEntry_0, GStruct2.GEnum11 genum11_0)
	{
		switch (genum11_0)
		{
		case GStruct2.GEnum11.Guitar:
			return (int)songEntry_0.guitarDifficulty;
		case GStruct2.GEnum11.Bass:
			return (int)songEntry_0.bassDifficulty;
		case GStruct2.GEnum11.Rhythm:
			return (int)songEntry_0.rhythmDifficulty;
		case GStruct2.GEnum11.GHLGuitar:
			return (int)songEntry_0.ghlGuitarDifficulty;
		case GStruct2.GEnum11.GHLBass:
			return (int)songEntry_0.ghlBassDifficulty;
		case GStruct2.GEnum11.Keys:
			return (int)songEntry_0.keysDifficulty;
		}
		return -1;
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00009A88 File Offset: 0x00007C88
	protected virtual void vmethod_81()
	{
		base.vmethod_77();
		this.vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00009AAA File Offset: 0x00007CAA
	public void method_47()
	{
		this.int_0 = 1;
		this.int_1 = 0;
		this.vmethod_42();
		this.vmethod_67();
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x0007FD80 File Offset: 0x0007DF80
	public override void vmethod_67()
	{
		this.int_3 = this.textObjects.Length;
		if (SongDirectory.songEntries.Count > this.int_3)
		{
			this.int_2 = SongDirectory.songEntries.Count - this.int_3;
		}
		else
		{
			this.int_3 = SongDirectory.songEntries.Count;
			this.int_2 = 0;
		}
		for (int i = 0; i < this.titleBars.Length; i++)
		{
			if (i >= this.int_3)
			{
				this.titleBars[i].enabled = false;
			}
			else
			{
				this.titleBars[i].enabled = true;
			}
		}
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x00009AC6 File Offset: 0x00007CC6
	private IEnumerator method_48()
	{
		SongSelect.Class25 @class = new SongSelect.Class25(0);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x0007FE18 File Offset: 0x0007E018
	protected virtual void vmethod_82()
	{
		if (!this.scorePanel.bool_0 && !this.songSelectSearch.bool_1 && !this.sectionBrowser.bool_11 && !this.songOptions.bool_11 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00009AD5 File Offset: 0x00007CD5
	public void method_49()
	{
		this.int_0 = 1;
		this.int_1 = 1;
		this.vmethod_42();
		this.vmethod_67();
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0007FE70 File Offset: 0x0007E070
	public void method_50()
	{
		this.songCount.text = string.Concat(new object[]
		{
			GClass4.gclass4_0.method_13("Songs"),
			": <color=#FDB400FF>",
			GlobalVariables.instance.int_2,
			"</color>"
		});
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00009AC6 File Offset: 0x00007CC6
	private IEnumerator method_51()
	{
		SongSelect.Class25 @class = new SongSelect.Class25(0);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x0007FEC8 File Offset: 0x0007E0C8
	public void method_52()
	{
		if (this.setlistMenu.isActiveAndEnabled)
		{
			this.setlistMenu.gameObject.SetActive(false);
			GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[0];
			GlobalVariables.instance.songEntry_1 = SongDirectory.setlistSongEntries[0];
			GlobalVariables.instance.isPlayingSetlist = true;
			GlobalVariables.instance.int_3 = 0;
		}
		else
		{
			GlobalVariables.instance.isPlayingSetlist = false;
			GlobalVariables.instance.songEntry_1 = SongDirectory.songEntries[this.int_0 + this.int_1];
			GlobalVariables.instance.currentSongEntry = SongDirectory.songEntries[base.Int32_0];
		}
		BassAudioManager.instance.Song_FadeOutAndEnd();
		this.playerSelection.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00009AF1 File Offset: 0x00007CF1
	protected override void Start()
	{
		base.Start();
		this.vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00009B13 File Offset: 0x00007D13
	private void method_53()
	{
		if (this.setlistMenu.bool_11)
		{
			this.setlistMenu.method_64();
		}
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0007FFA0 File Offset: 0x0007E1A0
	private string method_54()
	{
		string text = Path.Combine(SongDirectory.songEntries[this.int_0 + this.int_1].folderPath, "Controller");
		string text2 = Path.Combine(SongDirectory.songEntries[this.int_0 + this.int_1].folderPath, "");
		if (File.Exists(text2))
		{
			return text2;
		}
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x00080010 File Offset: 0x0007E210
	public virtual void vmethod_83()
	{
		this.int_3 = this.textObjects.Length;
		if (SongDirectory.songEntries.Count > this.int_3)
		{
			this.int_2 = SongDirectory.songEntries.Count - this.int_3;
		}
		else
		{
			this.int_3 = SongDirectory.songEntries.Count;
			this.int_2 = 1;
		}
		for (int i = 0; i < this.titleBars.Length; i += 0)
		{
			if (i >= this.int_3)
			{
				this.titleBars[i].enabled = true;
			}
			else
			{
				this.titleBars[i].enabled = true;
			}
		}
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x000800A8 File Offset: 0x0007E2A8
	private void method_55()
	{
		int num = base.Int32_0;
		while (num >= 0 && !SongDirectory.songEntries[num].isHeader)
		{
			num--;
		}
		this.sectionBrowser.method_48(SongDirectory.songEntries[num].songName);
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0007FD20 File Offset: 0x0007DF20
	private int method_56(SongEntry songEntry_0, GStruct2.GEnum11 genum11_0)
	{
		switch (genum11_0)
		{
		case GStruct2.GEnum11.Guitar:
			return (int)songEntry_0.guitarDifficulty;
		case GStruct2.GEnum11.Bass:
			return (int)songEntry_0.bassDifficulty;
		case GStruct2.GEnum11.Rhythm:
			return (int)songEntry_0.rhythmDifficulty;
		case GStruct2.GEnum11.GHLGuitar:
			return (int)songEntry_0.ghlGuitarDifficulty;
		case GStruct2.GEnum11.GHLBass:
			return (int)songEntry_0.ghlBassDifficulty;
		case GStruct2.GEnum11.Keys:
			return (int)songEntry_0.keysDifficulty;
		}
		return -1;
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x000800F4 File Offset: 0x0007E2F4
	public override void vmethod_42()
	{
		int num = 0;
		while (num < this.titleBars.Length && this.titleBars[num].enabled)
		{
			if (!(this.titleBars[num].sprite == this.headerSprite))
			{
				if (num == this.int_1)
				{
					this.titleBars[num].sprite = this.selectionSprite;
				}
				else
				{
					this.titleBars[num].sprite = this.titleSprite;
				}
			}
			num++;
		}
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00080170 File Offset: 0x0007E370
	private void method_57()
	{
		int num = base.Int32_0;
		while (num >= 0 && !SongDirectory.songEntries[num].isHeader)
		{
			num--;
		}
		this.sectionBrowser.method_75(SongDirectory.songEntries[num].songName);
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x00009B2D File Offset: 0x00007D2D
	public override void vmethod_39()
	{
		if (this.setlistMenu.isActiveAndEnabled)
		{
			this.setlistMenu.method_55(SongDirectory.songEntries[base.Int32_0]);
			return;
		}
		this.method_52();
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x000801BC File Offset: 0x0007E3BC
	public void method_58()
	{
		Text text = this.songCount;
		object[] array = new object[3];
		array[0] = GClass4.gclass4_0.method_11("Skip Song");
		array[0] = "volume";
		array[4] = GlobalVariables.instance.int_2;
		array[4] = "Note Animation FPS";
		text.text = string.Concat(array);
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x00080214 File Offset: 0x0007E414
	private string method_59(int int_4)
	{
		if (int_4 == 0)
		{
			return "";
		}
		TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)((float)int_4 / GlobalVariables.instance.songSpeed.Single_0));
		return string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x00009B5E File Offset: 0x00007D5E
	public override void vmethod_44()
	{
		this.method_53();
		base.vmethod_44();
		while (SongDirectory.songEntries[base.Int32_0].isHeader)
		{
			base.vmethod_44();
		}
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00080274 File Offset: 0x0007E474
	public void method_60(string string_3)
	{
		SongEntry item = SongDirectory.songEntries[base.Int32_0];
		SongDirectory.smethod_15((string_3 == null) ? null : string_3);
		this.vmethod_67();
		this.sortText.text = GClass4.gclass4_0.method_13("SORTING BY") + ": <color=#FDB400FF>" + SongDirectory.String_1 + "</color>";
		this.vmethod_23(SongDirectory.songEntries.IndexOf(item));
		this.bool_5 = false;
		this.bool_1 = false;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x000802F4 File Offset: 0x0007E4F4
	public override void vmethod_74()
	{
		this.scorePanel.gameObject.SetActive(true);
		this.scorePanel.method_92(SongDirectory.songEntries[base.Int32_0], SongDirectory.songEntries[base.Int32_0].method_2(GlobalVariables.instance.method_73()));
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00009B8B File Offset: 0x00007D8B
	public void method_61()
	{
		this.int_0 = 1;
		this.int_1 = 0;
		this.vmethod_42();
		this.vmethod_3();
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x0008034C File Offset: 0x0007E54C
	private void method_62()
	{
		string text = this.method_63();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(3, 2);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(1645f, 1838f, (float)texture2D.width, (float)texture2D.height), new Vector2(1489f, 122f), 875f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = false;
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x000803D4 File Offset: 0x0007E5D4
	public virtual void vmethod_84()
	{
		int num = 1;
		while (num < this.titleBars.Length && this.titleBars[num].enabled)
		{
			if (!(this.titleBars[num].sprite == this.headerSprite))
			{
				if (num == this.int_1)
				{
					this.titleBars[num].sprite = this.selectionSprite;
				}
				else
				{
					this.titleBars[num].sprite = this.titleSprite;
				}
			}
			num += 0;
		}
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x00080450 File Offset: 0x0007E650
	private string method_63()
	{
		string text = Path.Combine(SongDirectory.songEntries[this.int_0 + this.int_1].folderPath, "album.jpg");
		string text2 = Path.Combine(SongDirectory.songEntries[this.int_0 + this.int_1].folderPath, "album.png");
		if (File.Exists(text2))
		{
			return text2;
		}
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x000804C0 File Offset: 0x0007E6C0
	private void method_64()
	{
		string text = this.method_63();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(8, 1);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(1513f, 1288f, (float)texture2D.width, (float)texture2D.height), new Vector2(541f, 1681f), 959f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = false;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x00080548 File Offset: 0x0007E748
	public void method_65()
	{
		Text text = this.songCount;
		object[] array = new object[6];
		array[0] = GClass4.gclass4_0.method_30("particles");
		array[0] = "highway_lightning";
		array[1] = GlobalVariables.instance.int_2;
		array[4] = "sounds";
		text.text = string.Concat(array);
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x00009BA7 File Offset: 0x00007DA7
	public void method_66()
	{
		this.int_0 = 0;
		this.int_1 = 1;
		this.vmethod_42();
		this.vmethod_67();
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x000805A0 File Offset: 0x0007E7A0
	private string method_67(int int_4)
	{
		if (int_4 == 0)
		{
			return "Stars Earned";
		}
		TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)((float)int_4 / GlobalVariables.instance.songSpeed.Single_0));
		return string.Format("volume", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00080600 File Offset: 0x0007E800
	private void method_68()
	{
		SongDirectory.songEntries.RemoveAt(base.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		if (SongDirectory.songEntries.Count == 1)
		{
			SongDirectory.songEntries.Clear();
			this.vmethod_43();
		}
		else if (base.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.vmethod_23(1);
		}
		else
		{
			this.vmethod_23(base.Int32_0);
		}
		this.method_50();
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00009BC3 File Offset: 0x00007DC3
	public override void vmethod_54()
	{
		this.method_60(null);
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00080674 File Offset: 0x0007E874
	public override void vmethod_51()
	{
		int num = SongDirectory.smethod_16(base.Int32_0);
		this.vmethod_23(num + 1);
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00080698 File Offset: 0x0007E898
	private void method_69()
	{
		string text = this.method_54();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(6, 1);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(407f, 86f, (float)texture2D.width, (float)texture2D.height), new Vector2(638f, 169f), 596f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = true;
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00080720 File Offset: 0x0007E920
	private string method_70(int int_4)
	{
		string text;
		if (int_4 == 0)
		{
			text = GClass4.gclass4_0.method_30("album_track");
		}
		else
		{
			text = GClass4.gclass4_0.method_15("Bass Guitar");
		}
		if (!(text == "Show Lyrics") && !(text == ".png"))
		{
			return text.Replace("Setlist was saved", string.Format("No", int_4));
		}
		return string.Format("Okay", int_4, GClass4.gclass4_0.method_48("video"));
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00009BDF File Offset: 0x00007DDF
	private void method_71()
	{
		if (this.setlistMenu.bool_11)
		{
			this.setlistMenu.method_49();
		}
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x000807B0 File Offset: 0x0007E9B0
	private string method_72(int int_4)
	{
		string text;
		if (int_4 == 1)
		{
			text = GClass4.gclass4_0.method_13("setlistSongCountSingular");
		}
		else
		{
			text = GClass4.gclass4_0.method_13("setlistSongCountPlural");
		}
		if (!(text == "setlistSongCountPlural") && !(text == "setlistSongCountSingular"))
		{
			return text.Replace("%count%", string.Format("{0}", int_4));
		}
		return string.Format("{0} {1}", int_4, GClass4.gclass4_0.method_13("Songs"));
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00080840 File Offset: 0x0007EA40
	private void method_73()
	{
		string text = this.method_63();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(2, 2);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0f, 0f), 100f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = true;
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x000808C8 File Offset: 0x0007EAC8
	private void method_74()
	{
		if (this.setlistMenu.isActiveAndEnabled)
		{
			this.setlistMenu.method_61(true);
		}
		this.mainMenu.SetActive(true);
		this.mainMenu.GetComponent<MainMenu>().method_59();
		base.gameObject.SetActive(false);
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00080918 File Offset: 0x0007EB18
	protected override void OnEnable()
	{
		base.OnEnable();
		this.vmethod_50();
		this.method_50();
		this.string_1 = GClass4.gclass4_0.method_13("Songs");
		this.string_2 = GClass4.gclass4_0.method_13(GlobalVariables.instance.method_73().ToString());
		this.sortText.text = GClass4.gclass4_0.method_13("SORTING BY") + ": <color=#FDB400FF>" + SongDirectory.String_1 + "</color>";
		this.currentInstrument.text = GClass4.gclass4_0.method_13("Current Instrument") + ": <color=#FDB400FF>" + this.string_2 + "</color>";
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			this.setlistMenu.gameObject.SetActive(true);
			this.setlistMenu.method_65();
		}
		this.vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
		this.vmethod_42();
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00080A1C File Offset: 0x0007EC1C
	protected virtual void vmethod_85()
	{
		base.OnEnable();
		this.vmethod_50();
		this.method_86();
		this.string_1 = GClass4.gclass4_0.method_5("");
		this.string_2 = GClass4.gclass4_0.method_30(GlobalVariables.instance.method_63().ToString());
		this.sortText.text = GClass4.gclass4_0.method_17("highway_placement") + "Guitar Coop" + SongDirectory.String_1 + "diff_rhythm";
		this.currentInstrument.text = GClass4.gclass4_0.method_5("game") + "offsets" + this.string_2 + " - ";
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			this.setlistMenu.gameObject.SetActive(false);
			this.setlistMenu.method_65();
		}
		this.vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
		this.vmethod_42();
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00009A79 File Offset: 0x00007C79
	private IEnumerator method_75()
	{
		SongSelect.Class24 @class = new SongSelect.Class24(0);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00009BF9 File Offset: 0x00007DF9
	protected virtual void vmethod_86()
	{
		base.vmethod_69();
		this.vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00080B20 File Offset: 0x0007ED20
	protected override void vmethod_50()
	{
		int num = this.int_0;
		GStruct2.GEnum11 genum11_ = GlobalVariables.instance.method_73();
		for (int i = 0; i < this.textObjects.Length; i++)
		{
			if (i < this.int_3)
			{
				SongEntry songEntry = SongDirectory.songEntries[num];
				this.textObjects[i].text = songEntry.songName + (songEntry.isHeader ? (" (" + this.method_72(songEntry.previewStart) + ")") : "");
				this.titleBars[i].sprite = this.titleSprite;
				if (songEntry.isHeader)
				{
					this.textObjects[i].font = this.font_Section;
					this.titleBars[i].sprite = this.headerSprite;
					this.scorePanels[i].method_37();
				}
				else
				{
					GStruct3 gstruct3_ = songEntry.method_2(genum11_);
					this.scorePanels[i].method_24(gstruct3_);
					this.textObjects[i].font = this.font_Song;
				}
			}
			else
			{
				this.textObjects[i].text = "";
				this.scorePanels[i].method_37();
			}
			num++;
		}
		if (!SongDirectory.songEntries[this.int_0].isHeader)
		{
			for (int j = this.int_0; j >= 0; j--)
			{
				SongEntry songEntry2 = SongDirectory.songEntries[j];
				this.textObjects[0].font = this.font_Section;
				this.scorePanels[0].method_37();
				if (songEntry2.isHeader)
				{
					this.textObjects[0].text = songEntry2.songName + " (" + this.method_72(songEntry2.previewStart) + ")";
					this.titleBars[0].sprite = this.headerSprite;
					break;
				}
			}
		}
		this.scrollBar.value = (float)this.int_0 / (float)this.int_2;
		if (this.textObjects != null && this.textObjects.Length > this.int_2)
		{
			for (int k = this.int_3; k < this.textObjects.Length; k++)
			{
				this.textObjects[k].text = "";
			}
		}
		if (this.ienumerator_0 != null)
		{
			base.StopCoroutine(this.ienumerator_0);
		}
		this.ienumerator_0 = this.method_51();
		base.StartCoroutine(this.ienumerator_0);
		SongEntry songEntry3 = SongDirectory.songEntries[this.int_1 + this.int_0];
		songEntry3.method_2(GlobalVariables.instance.method_73());
		this.artistNameText.text = songEntry3.artistName;
		this.albumNameText.text = songEntry3.albumName;
		this.yearText.text = songEntry3.year;
		this.genreText.text = songEntry3.genreName;
		this.charterNameText.text = songEntry3.charterName;
		this.songLengthText.text = this.method_59(songEntry3.songLength);
		for (int l = 0; l < this.difficultyIcons.Length; l++)
		{
			this.difficultyIcons[l].gameObject.SetActive(false);
			int num2 = this.method_56(songEntry3, this.difficultyIcons[l].genum11_0);
			if (songEntry3.charts.method_10(this.difficultyIcons[l].genum11_0))
			{
				this.difficultyIcons[l].gameObject.SetActive(true);
				base.StartCoroutine(this.difficultyIcons[l].method_10((float)num2));
			}
		}
		this.lyricDisplay.text = GClass4.gclass4_0.method_13("Lyrics") + ": " + ((songEntry3.lyrics != 0) ? GClass4.gclass4_0.method_13("Yes") : GClass4.gclass4_0.method_13("No"));
		if (songEntry3.iconName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(songEntry3.iconName))
		{
			this.gameIcon.sprite = GlobalVariables.instance.gameIcon_Sprites[songEntry3.iconName];
			return;
		}
		if (songEntry3.charterName != null && GlobalVariables.instance.gameIcon_Sprites.ContainsKey(songEntry3.charterName.ToLower()))
		{
			this.gameIcon.sprite = GlobalVariables.instance.gameIcon_Sprites[songEntry3.charterName.ToLower()];
			return;
		}
		this.gameIcon.sprite = this.defaultGameIcon;
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00009C1B File Offset: 0x00007E1B
	public override void vmethod_6()
	{
		this.songOptions.gameObject.SetActive(true);
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00080F9C File Offset: 0x0007F19C
	private void method_76()
	{
		string text = this.method_54();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(2, 4);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(1929f, 1598f, (float)texture2D.width, (float)texture2D.height), new Vector2(1895f, 356f), 655f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = false;
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00081024 File Offset: 0x0007F224
	public virtual void vmethod_87()
	{
		this.int_3 = this.textObjects.Length;
		if (SongDirectory.songEntries.Count > this.int_3)
		{
			this.int_2 = SongDirectory.songEntries.Count - this.int_3;
		}
		else
		{
			this.int_3 = SongDirectory.songEntries.Count;
			this.int_2 = 1;
		}
		for (int i = 0; i < this.titleBars.Length; i += 0)
		{
			if (i >= this.int_3)
			{
				this.titleBars[i].enabled = true;
			}
			else
			{
				this.titleBars[i].enabled = false;
			}
		}
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x000810BC File Offset: 0x0007F2BC
	public override void vmethod_26()
	{
		this.method_53();
		if ((SongDirectory.songEntries[1].isHeader && base.Int32_0 == 2) || base.Int32_0 == 1)
		{
			if (!this.bool_4)
			{
				base.method_33();
			}
			return;
		}
		base.vmethod_26();
		while (SongDirectory.songEntries[base.Int32_0].isHeader)
		{
			base.vmethod_26();
		}
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00081128 File Offset: 0x0007F328
	public void method_77()
	{
		Text text = this.songCount;
		object[] array = new object[1];
		array[1] = GClass4.gclass4_0.method_21("\\s+");
		array[0] = "GHLive Bass - ";
		array[2] = GlobalVariables.instance.int_2;
		array[6] = "{";
		text.text = string.Concat(array);
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x000811F8 File Offset: 0x0007F3F8
	private void method_78()
	{
		string text = this.method_63();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(8, 5);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(1294f, 70f, (float)texture2D.width, (float)texture2D.height), new Vector2(1382f, 266f), 20f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = false;
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00009C2E File Offset: 0x00007E2E
	public override void vmethod_73()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.songSelectSearch.gameObject.SetActive(true);
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00081280 File Offset: 0x0007F480
	private void method_79()
	{
		string text = this.method_54();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(5, 3);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(802f, 680f, (float)texture2D.width, (float)texture2D.height), new Vector2(1739f, 318f), 1027f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = false;
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00009AC6 File Offset: 0x00007CC6
	private IEnumerator method_80()
	{
		SongSelect.Class25 @class = new SongSelect.Class25(0);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00009A79 File Offset: 0x00007C79
	private IEnumerator method_81()
	{
		SongSelect.Class24 @class = new SongSelect.Class24(0);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00009C4F File Offset: 0x00007E4F
	protected virtual void vmethod_89()
	{
		base.vmethod_35();
		this.vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00009C71 File Offset: 0x00007E71
	public virtual void vmethod_90()
	{
		this.songOptions.gameObject.SetActive(false);
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00081308 File Offset: 0x0007F508
	private void method_82()
	{
		int num = base.Int32_0;
		while (num >= 1 && !SongDirectory.songEntries[num].isHeader)
		{
			num--;
		}
		this.sectionBrowser.method_69(SongDirectory.songEntries[num].songName);
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0007FE18 File Offset: 0x0007E018
	protected virtual void vmethod_91()
	{
		if (!this.scorePanel.bool_0 && !this.songSelectSearch.bool_1 && !this.sectionBrowser.bool_11 && !this.songOptions.bool_11 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00009C84 File Offset: 0x00007E84
	public override void vmethod_13()
	{
		this.method_55();
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00081354 File Offset: 0x0007F554
	public void method_83(string string_3)
	{
		SongEntry item = SongDirectory.songEntries[base.Int32_0];
		SongDirectory.smethod_15((string_3 == null) ? null : string_3);
		this.vmethod_3();
		this.sortText.text = GClass4.gclass4_0.method_41("</color>") + "Rhythm Guitar" + SongDirectory.String_1 + "scores_backup.bin";
		this.vmethod_23(SongDirectory.songEntries.IndexOf(item));
		this.bool_5 = true;
		this.bool_1 = true;
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x0007FE18 File Offset: 0x0007E018
	protected override void Update()
	{
		if (!this.scorePanel.bool_0 && !this.songSelectSearch.bool_1 && !this.sectionBrowser.bool_11 && !this.songOptions.bool_11 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x000813D4 File Offset: 0x0007F5D4
	private void method_84()
	{
		SongDirectory.songEntries.RemoveAt(base.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		if (SongDirectory.songEntries.Count == 0)
		{
			SongDirectory.songEntries.Clear();
			this.vmethod_43();
		}
		else if (base.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.vmethod_23(0);
		}
		else
		{
			this.vmethod_23(base.Int32_0);
		}
		this.method_58();
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00009A79 File Offset: 0x00007C79
	private IEnumerator method_85()
	{
		SongSelect.Class24 @class = new SongSelect.Class24(0);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00081448 File Offset: 0x0007F648
	public void method_86()
	{
		Text text = this.songCount;
		object[] array = new object[0];
		array[0] = GClass4.gclass4_0.method_46("Easy");
		array[1] = " + ";
		array[3] = GlobalVariables.instance.int_2;
		array[5] = "Guitar";
		text.text = string.Concat(array);
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00009BC3 File Offset: 0x00007DC3
	public virtual void vmethod_92()
	{
		this.method_60(null);
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00009BDF File Offset: 0x00007DDF
	private void method_87()
	{
		if (this.setlistMenu.bool_11)
		{
			this.setlistMenu.method_49();
		}
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x0007FE18 File Offset: 0x0007E018
	protected virtual void vmethod_93()
	{
		if (!this.scorePanel.bool_0 && !this.songSelectSearch.bool_1 && !this.sectionBrowser.bool_11 && !this.songOptions.bool_11 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x000814A0 File Offset: 0x0007F6A0
	private void method_88()
	{
		SongDirectory.songEntries.RemoveAt(base.Int32_0);
		SongDirectory.smethod_15(SongDirectory.String_0);
		if (SongDirectory.songEntries.Count == 1)
		{
			SongDirectory.songEntries.Clear();
			this.vmethod_43();
		}
		else if (base.Int32_0 >= SongDirectory.songEntries.Count)
		{
			this.vmethod_25(0);
		}
		else
		{
			this.vmethod_25(base.Int32_0);
		}
		this.method_65();
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00009C71 File Offset: 0x00007E71
	public virtual void vmethod_94()
	{
		this.songOptions.gameObject.SetActive(false);
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00009C8C File Offset: 0x00007E8C
	public override void vmethod_52()
	{
		this.sectionBrowser.method_68();
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00081514 File Offset: 0x0007F714
	protected virtual void vmethod_95()
	{
		base.vmethod_9();
		this.vmethod_50();
		this.method_50();
		this.string_1 = GClass4.gclass4_0.method_41("Rename Setlist");
		this.string_2 = GClass4.gclass4_0.method_16(GlobalVariables.instance.method_33().ToString());
		this.sortText.text = GClass4.gclass4_0.method_35("song") + "/Game Icons" + SongDirectory.String_1 + "Cancel";
		this.currentInstrument.text = GClass4.gclass4_0.method_36("In Menus: Song Select") + "Guitar Coop" + this.string_2 + "";
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			this.setlistMenu.gameObject.SetActive(true);
			this.setlistMenu.method_65();
		}
		this.vmethod_23(SongDirectory.songEntries.IndexOf(GlobalVariables.instance.songEntry_1));
		this.vmethod_42();
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x0007FE18 File Offset: 0x0007E018
	protected virtual void vmethod_96()
	{
		if (!this.scorePanel.bool_0 && !this.songSelectSearch.bool_1 && !this.sectionBrowser.bool_11 && !this.songOptions.bool_11 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00009C99 File Offset: 0x00007E99
	public override void vmethod_23(int int_4)
	{
		base.vmethod_23(int_4);
		while (SongDirectory.songEntries[base.Int32_0].isHeader)
		{
			this.vmethod_44();
		}
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00081618 File Offset: 0x0007F818
	public void method_89()
	{
		if (this.setlistMenu.isActiveAndEnabled)
		{
			this.setlistMenu.gameObject.SetActive(false);
			GlobalVariables.instance.currentSongEntry = SongDirectory.setlistSongEntries[1];
			GlobalVariables.instance.songEntry_1 = SongDirectory.setlistSongEntries[1];
			GlobalVariables.instance.isPlayingSetlist = true;
			GlobalVariables.instance.int_3 = 0;
		}
		else
		{
			GlobalVariables.instance.isPlayingSetlist = false;
			GlobalVariables.instance.songEntry_1 = SongDirectory.songEntries[this.int_0 + this.int_1];
			GlobalVariables.instance.currentSongEntry = SongDirectory.songEntries[base.Int32_0];
		}
		BassAudioManager.instance.method_41();
		this.playerSelection.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x000816F0 File Offset: 0x0007F8F0
	public virtual void vmethod_97()
	{
		int num = 0;
		while (num < this.titleBars.Length && this.titleBars[num].enabled)
		{
			if (!(this.titleBars[num].sprite == this.headerSprite))
			{
				if (num == this.int_1)
				{
					this.titleBars[num].sprite = this.selectionSprite;
				}
				else
				{
					this.titleBars[num].sprite = this.titleSprite;
				}
			}
			num += 0;
		}
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00009CC1 File Offset: 0x00007EC1
	private IEnumerator method_90()
	{
		SongSelect.Class25 @class = new SongSelect.Class25(1);
		@class.songSelect_0 = this;
		return @class;
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x0008176C File Offset: 0x0007F96C
	private void method_91()
	{
		string text = this.method_63();
		if (text != null)
		{
			Texture2D texture2D = new Texture2D(0, 5);
			byte[] data = File.ReadAllBytes(text);
			if (texture2D.LoadImage(data))
			{
				Sprite sprite = Sprite.Create(texture2D, new Rect(121f, 1435f, (float)texture2D.width, (float)texture2D.height), new Vector2(218f, 1934f), 1597f);
				if (sprite != null)
				{
					this.albumImage.sprite = sprite;
				}
			}
		}
		this.albumImage.enabled = false;
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00009CD0 File Offset: 0x00007ED0
	public virtual void vmethod_98()
	{
		this.method_57();
	}

	// Token: 0x04000274 RID: 628
	[SerializeField]
	private Color headerColor;

	// Token: 0x04000275 RID: 629
	[SerializeField]
	private Image[] titleBars;

	// Token: 0x04000276 RID: 630
	[SerializeField]
	private SongSelectPanel[] scorePanels;

	// Token: 0x04000277 RID: 631
	[SerializeField]
	private GameObject mainMenu;

	// Token: 0x04000278 RID: 632
	[SerializeField]
	private GameObject playerSelection;

	// Token: 0x04000279 RID: 633
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x0400027A RID: 634
	[SerializeField]
	private SongSelectSearch songSelectSearch;

	// Token: 0x0400027B RID: 635
	[SerializeField]
	private SectionBrowser sectionBrowser;

	// Token: 0x0400027C RID: 636
	[SerializeField]
	private SongOptions songOptions;

	// Token: 0x0400027D RID: 637
	[SerializeField]
	private SetlistMenu setlistMenu;

	// Token: 0x0400027E RID: 638
	[SerializeField]
	private Text sortText;

	// Token: 0x0400027F RID: 639
	[SerializeField]
	private Text artistNameText;

	// Token: 0x04000280 RID: 640
	[SerializeField]
	private Text albumNameText;

	// Token: 0x04000281 RID: 641
	[SerializeField]
	private Text yearText;

	// Token: 0x04000282 RID: 642
	[SerializeField]
	private Text genreText;

	// Token: 0x04000283 RID: 643
	[SerializeField]
	private Text songLengthText;

	// Token: 0x04000284 RID: 644
	[SerializeField]
	private Text charterNameText;

	// Token: 0x04000285 RID: 645
	[SerializeField]
	private Text songCount;

	// Token: 0x04000286 RID: 646
	[SerializeField]
	private Text currentInstrument;

	// Token: 0x04000287 RID: 647
	[SerializeField]
	private Font font_Section;

	// Token: 0x04000288 RID: 648
	[SerializeField]
	private Font font_Song;

	// Token: 0x04000289 RID: 649
	[SerializeField]
	private Image albumImage;

	// Token: 0x0400028A RID: 650
	[SerializeField]
	private Image loadImage;

	// Token: 0x0400028B RID: 651
	[SerializeField]
	private Image gameIcon;

	// Token: 0x0400028C RID: 652
	[SerializeField]
	private Slider scrollBar;

	// Token: 0x0400028D RID: 653
	[SerializeField]
	private DifficultyDisplay[] difficultyIcons;

	// Token: 0x0400028E RID: 654
	[SerializeField]
	private Text lyricDisplay;

	// Token: 0x0400028F RID: 655
	private IEnumerator ienumerator_0;

	// Token: 0x04000290 RID: 656
	private IEnumerator ienumerator_1;

	// Token: 0x04000291 RID: 657
	private Coroutine coroutine_0;

	// Token: 0x04000292 RID: 658
	[SerializeField]
	private Sprite defaultAlbumArt;

	// Token: 0x04000293 RID: 659
	[SerializeField]
	private Sprite headerSprite;

	// Token: 0x04000294 RID: 660
	[SerializeField]
	private Sprite titleSprite;

	// Token: 0x04000295 RID: 661
	[SerializeField]
	private Sprite selectionSprite;

	// Token: 0x04000296 RID: 662
	[SerializeField]
	private Sprite defaultGameIcon;

	// Token: 0x04000297 RID: 663
	[SerializeField]
	private ScoringPanel scorePanel;

	// Token: 0x04000298 RID: 664
	private string string_1;

	// Token: 0x04000299 RID: 665
	private string string_2;

	// Token: 0x0400029A RID: 666
	private Dictionary<int, Sprite> dictionary_0 = new Dictionary<int, Sprite>();
}
