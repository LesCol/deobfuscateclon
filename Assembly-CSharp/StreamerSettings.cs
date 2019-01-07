using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200004F RID: 79
public class StreamerSettings : BaseMenu
{
	// Token: 0x06000E7B RID: 3707 RVA: 0x000084A6 File Offset: 0x000066A6
	public virtual void vmethod_81()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x000084A6 File Offset: 0x000066A6
	public virtual void vmethod_82()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x0006A57C File Offset: 0x0006877C
	private void method_44()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "Mirror Mode") && !(string_ == "Start") && !(string_ == "Game Manager"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x0006A5EC File Offset: 0x000687EC
	public virtual void vmethod_83()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.string_0 = base.method_39();
		string string_ = this.string_0;
		if (string_ == "album_track")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_46("{0:n0}", "Easy", null, null, null, null);
			}
			base.StartCoroutine(this.method_64(false));
			this.string_0 = null;
			return;
		}
		if (!(string_ == "Note Shuffle"))
		{
			if (!(string_ == "Band"))
			{
				if (string_ == "Source")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_60();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_46("Expert", "volume", null, null, null, null);
		}
		base.StartCoroutine(this.method_62(true));
		this.string_0 = null;
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x000084DC File Offset: 0x000066DC
	public virtual void vmethod_84()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_51();
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x0000850A File Offset: 0x0000670A
	private IEnumerator method_45(bool bool_12)
	{
		StreamerSettings.Class22 @class = new StreamerSettings.Class22(1);
		@class.streamerSettings_0 = this;
		@class.bool_0 = bool_12;
		return @class;
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00008520 File Offset: 0x00006720
	protected virtual void vmethod_85()
	{
		if (!this.confirmMenu.bool_11 && !this.exportSongList.bool_0)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x0006A704 File Offset: 0x00068904
	private void method_46()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "No") && !(string_ == "\"") && !(string_ == "Gameplay"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.String_0;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x0006A774 File Offset: 0x00068974
	public virtual void vmethod_86()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		if (string_ == "Are you sure?")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_47("Song Offset", "", null, null, null, null);
			}
			base.StartCoroutine(this.method_59(false));
			this.string_0 = null;
			return;
		}
		if (!(string_ == "lowlatency_enabled"))
		{
			if (!(string_ == ":"))
			{
				if (string_ == "No Videos!")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_65();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_49("Hard", "volume", null, null, null, null);
		}
		base.StartCoroutine(this.method_58(true));
		this.string_0 = null;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00008543 File Offset: 0x00006743
	public virtual void vmethod_87()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_56();
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x000084A6 File Offset: 0x000066A6
	public virtual void vmethod_88()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0006A88C File Offset: 0x00068A8C
	private void method_47()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "No") && !(string_ == "Random Song (Section)") && !(string_ == "sources"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00008571 File Offset: 0x00006771
	public virtual void vmethod_89()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_60();
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x0006A8FC File Offset: 0x00068AFC
	public virtual void vmethod_90()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		if (string_ == "Menu Music")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_47("bad_note2", "song", null, null, null, null);
			}
			base.StartCoroutine(this.method_58(true));
			this.string_0 = null;
			return;
		}
		if (!(string_ == "Choose a Profile"))
		{
			if (!(string_ == "Game Manager"))
			{
				if (string_ == "")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_54();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_44("Get Hardware Latency", "Okay", null, null, null, null);
		}
		base.StartCoroutine(this.method_53(false));
		this.string_0 = null;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x0006AA14 File Offset: 0x00068C14
	private void method_48()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == ")") && !(string_ == "No") && !(string_ == "multiplier_note"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x0000859F File Offset: 0x0000679F
	public virtual void vmethod_91()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_49(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_50(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x0006AA84 File Offset: 0x00068C84
	public virtual void vmethod_92()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		if (string_ == "Artist")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_50("low_latency_mode", " ", null, null, null, null);
			}
			base.StartCoroutine(this.method_57(false));
			this.string_0 = null;
			return;
		}
		if (!(string_ == " + "))
		{
			if (!(string_ == "artist"))
			{
				if (string_ == "Random Song")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_48();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_48("game", "No Part", null, null, null, null);
		}
		base.StartCoroutine(this.method_50(true));
		this.string_0 = null;
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x000085E3 File Offset: 0x000067E3
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x0006AB9C File Offset: 0x00068D9C
	private void method_51()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "Offset = [\\-\\+]?\\d+(\\.\\d+)?") && !(string_ == "Guitar Coop") && !(string_ == "video"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.String_0;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00008619 File Offset: 0x00006819
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_66();
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x0006AC0C File Offset: 0x00068E0C
	public virtual void vmethod_93()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		if (string_ == "Export Current Song")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_51("custom", " + ", null, null, null, null);
			}
			base.StartCoroutine(this.method_53(true));
			this.string_0 = null;
			return;
		}
		if (!(string_ == "Quickplay"))
		{
			if (!(string_ == "6 Fret Bass Guitar"))
			{
				if (string_ == "")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_47();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_46("", "READING CACHE...", null, null, null, null);
		}
		base.StartCoroutine(this.method_50(false));
		this.string_0 = null;
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x0006AD24 File Offset: 0x00068F24
	private void method_52()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "streamer") && !(string_ == "...") && !(string_ == "Language"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.String_0;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x0000850A File Offset: 0x0000670A
	private IEnumerator method_53(bool bool_12)
	{
		StreamerSettings.Class22 @class = new StreamerSettings.Class22(1);
		@class.streamerSettings_0 = this;
		@class.bool_0 = bool_12;
		return @class;
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x0006AD94 File Offset: 0x00068F94
	public virtual void vmethod_94()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.method_39();
		string string_ = this.string_0;
		if (string_ == "HOPO's to Taps")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_54("song", "year", null, null, null, null);
			}
			base.StartCoroutine(this.method_45(true));
			this.string_0 = null;
			return;
		}
		if (!(string_ == "All Opens"))
		{
			if (!(string_ == "Scan Songs"))
			{
				if (string_ == "GHLGuitar")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_47();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_50("Language", "Note Animation FPS", null, null, null, null);
		}
		base.StartCoroutine(this.method_62(true));
		this.string_0 = null;
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00008647 File Offset: 0x00006847
	public virtual void vmethod_95()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0000867D File Offset: 0x0000687D
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_66();
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0006AEAC File Offset: 0x000690AC
	private void method_54()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "Static") && !(string_ == "Delete Setlist") && !(string_ == "Song Speed"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x000086AB File Offset: 0x000068AB
	public virtual void vmethod_96()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_65();
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x000086D9 File Offset: 0x000068D9
	public virtual void vmethod_97()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = false;
		this.method_44();
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00008707 File Offset: 0x00006907
	public override void vmethod_46()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_55();
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00008520 File Offset: 0x00006720
	protected virtual void vmethod_98()
	{
		if (!this.confirmMenu.bool_11 && !this.exportSongList.bool_0)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x0006AF1C File Offset: 0x0006911C
	public override void vmethod_39()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		if (string_ == "Export Song List")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_44("Songs are still scanning...", "Okay", null, null, null, null);
			}
			base.StartCoroutine(this.method_63(false));
			this.string_0 = null;
			return;
		}
		if (!(string_ == "Export Song List (JSON)"))
		{
			if (!(string_ == "Export Current Song"))
			{
				if (string_ == "Highway Placement")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_66();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_44("Songs are still scanning...", "Okay", null, null, null, null);
		}
		base.StartCoroutine(this.method_63(true));
		this.string_0 = null;
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x000084A6 File Offset: 0x000066A6
	public virtual void vmethod_99()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x0006B034 File Offset: 0x00069234
	private void method_55()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == ", Pos: ") && !(string_ == "No") && !(string_ == "player_count"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.method_10();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00008735 File Offset: 0x00006935
	public virtual void vmethod_100()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_65();
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x0006B0A4 File Offset: 0x000692A4
	private void method_56()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "") && !(string_ == "0%") && !(string_ == "Mirror Mode"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00008520 File Offset: 0x00006720
	protected virtual void vmethod_101()
	{
		if (!this.confirmMenu.bool_11 && !this.exportSongList.bool_0)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x000084A6 File Offset: 0x000066A6
	public virtual void vmethod_102()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_57(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_58(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00008763 File Offset: 0x00006963
	public virtual void vmethod_103()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_51();
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00008791 File Offset: 0x00006991
	public virtual void vmethod_104()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = true;
		this.method_60();
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x000087BF File Offset: 0x000069BF
	public virtual void vmethod_105()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_55();
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00008520 File Offset: 0x00006720
	protected virtual void vmethod_106()
	{
		if (!this.confirmMenu.bool_11 && !this.exportSongList.bool_0)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00008520 File Offset: 0x00006720
	protected virtual void vmethod_107()
	{
		if (!this.confirmMenu.bool_11 && !this.exportSongList.bool_0)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_59(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x0006B114 File Offset: 0x00069314
	public virtual void vmethod_108()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		if (string_ == "song")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_47("volume", "Couldn't write badsongs.txt", null, null, null, null);
			}
			base.StartCoroutine(this.method_45(false));
			this.string_0 = null;
			return;
		}
		if (!(string_ == "Mirror Mode"))
		{
			if (!(string_ == "No"))
			{
				if (string_ == "song_display")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_44();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_44("low_latency_mode", "directories", null, null, null, null);
		}
		base.StartCoroutine(this.method_61(false));
		this.string_0 = null;
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x0006B22C File Offset: 0x0006942C
	private void method_60()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "Yes") && !(string_ == "sp_awarded") && !(string_ == "Practice"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.String_0;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_61(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_62(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_63(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x0006B29C File Offset: 0x0006949C
	public virtual void vmethod_109()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.method_39();
		string string_ = this.string_0;
		if (string_ == "Perfect Solo!")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_49("preview_volume", "", null, null, null, null);
			}
			base.StartCoroutine(this.method_59(true));
			this.string_0 = null;
			return;
		}
		if (!(string_ == ""))
		{
			if (!(string_ == "Song Offset"))
			{
				if (string_ == "Keys")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_65();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_50("Connected to server", "volume", null, null, null, null);
		}
		base.StartCoroutine(this.method_59(true));
		this.string_0 = null;
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x000085CD File Offset: 0x000067CD
	private IEnumerator method_64(bool bool_12)
	{
		if (SongDirectory.songEntries != null && SongDirectory.songEntries.Count != 0)
		{
			this.exportSongList.gameObject.SetActive(true);
			if (bool_12)
			{
				base.StartCoroutine(this.exportSongList.method_16());
			}
			else
			{
				base.StartCoroutine(this.exportSongList.method_13());
			}
			while (this.exportSongList.bool_0)
			{
				yield return null;
			}
			SongDirectory.sortCounter = -1;
			SongDirectory.smethod_15(null);
			this.songSelect.method_66();
			this.exportSongList.gameObject.SetActive(false);
			yield break;
		}
		yield break;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x0006B3B4 File Offset: 0x000695B4
	private void method_65()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "All Taps") && !(string_ == "Natsuki") && !(string_ == ""))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.method_9();
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00008520 File Offset: 0x00006720
	protected virtual void vmethod_110()
	{
		if (!this.confirmMenu.bool_11 && !this.exportSongList.bool_0)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x000087ED File Offset: 0x000069ED
	public virtual void vmethod_111()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_54();
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x0006B424 File Offset: 0x00069624
	private void method_66()
	{
		string string_ = this.string_0;
		string text;
		if (!(string_ == "Streamer Mode") && !(string_ == "Black Backgrounds") && !(string_ == "Export Current Song"))
		{
			text = this.gclass5_0.String_2;
		}
		else
		{
			text = this.gclass5_0.String_0;
		}
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x0000881B File Offset: 0x00006A1B
	public virtual void vmethod_112()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_65();
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00008849 File Offset: 0x00006A49
	public virtual void vmethod_113()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_47();
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x0006B494 File Offset: 0x00069694
	public virtual void vmethod_114()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		if (string_ == "\"([^\"]*)\"")
		{
			if (this.songScan.bool_0)
			{
				this.confirmMenu.method_54("Lead Guitar", "album", null, null, null, null);
			}
			base.StartCoroutine(this.method_61(false));
			this.string_0 = null;
			return;
		}
		if (!(string_ == ""))
		{
			if (!(string_ == "Bot"))
			{
				if (string_ == "[section ")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_5;
				}
			}
			else
			{
				this.gclass5_0 = GlobalVariables.instance.gclass5_20;
			}
			this.method_46();
			return;
		}
		if (this.songScan.bool_0)
		{
			this.confirmMenu.method_49("Date Added", "diff_guitar", null, null, null, null);
		}
		base.StartCoroutine(this.method_50(false));
		this.string_0 = null;
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00008619 File Offset: 0x00006819
	public virtual void vmethod_115()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_66();
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00008877 File Offset: 0x00006A77
	public virtual void vmethod_116()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_44();
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00008520 File Offset: 0x00006720
	protected override void Update()
	{
		if (!this.confirmMenu.bool_11 && !this.exportSongList.bool_0)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x0400023F RID: 575
	[SerializeField]
	private BaseMenu optionsMenu;

	// Token: 0x04000240 RID: 576
	[SerializeField]
	private ExportSongList exportSongList;

	// Token: 0x04000241 RID: 577
	[SerializeField]
	private SongSelect songSelect;

	// Token: 0x04000242 RID: 578
	[SerializeField]
	private SongScan songScan;

	// Token: 0x04000243 RID: 579
	[SerializeField]
	private ConfirmationMenu confirmMenu;
}
