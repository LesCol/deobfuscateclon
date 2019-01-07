using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000BC RID: 188
public class SongDetails : MonoBehaviour
{
	// Token: 0x060024B4 RID: 9396 RVA: 0x0011BAF8 File Offset: 0x00119CF8
	public void method_0(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 1792f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(false);
			return;
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x0011BB84 File Offset: 0x00119D84
	private void method_1()
	{
		if (!GlobalVariables.instance.gclass5_37.method_14())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.Boolean_0 ? "preview_start_time" : ("note_animation" + GlobalVariables.instance.songSpeed.method_1() + "isHidden"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_25());
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x00010799 File Offset: 0x0000E999
	public IEnumerator method_2()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(0);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024B7 RID: 9399 RVA: 0x0011BC4C File Offset: 0x00119E4C
	private void method_3()
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_6() ? "No Source" : ("*Random" + GlobalVariables.instance.songSpeed.method_1() + "EndOfSong"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_4());
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x000107A8 File Offset: 0x0000E9A8
	public IEnumerator method_4()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(1);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x0011BD14 File Offset: 0x00119F14
	private void method_5()
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.Boolean_0 ? "HOPO's to Taps" : ("A: 00:00:00" + GlobalVariables.instance.songSpeed.method_1() + "6 Fret Lead Guitar"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_18());
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x0011BDDC File Offset: 0x00119FDC
	public void method_6(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_14())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 298f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(true);
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x0011BE68 File Offset: 0x0011A068
	public void method_7(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.Boolean_1)
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 1f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(true);
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060024BC RID: 9404 RVA: 0x00010799 File Offset: 0x0000E999
	public IEnumerator method_8()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(0);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x0011BEF4 File Offset: 0x0011A0F4
	public void method_9(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 3f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(false);
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x0011BF80 File Offset: 0x0011A180
	public void method_10(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 1216f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(true);
			return;
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x0011C00C File Offset: 0x0011A20C
	public void method_11(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 1434f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(false);
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x0011C098 File Offset: 0x0011A298
	private void method_12()
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_23() ? "Error writing metadata" : ("Lefty Flip" + GlobalVariables.instance.songSpeed.method_26() + "Gameplay"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_13());
	}

	// Token: 0x060024C1 RID: 9409 RVA: 0x000107A8 File Offset: 0x0000E9A8
	public IEnumerator method_13()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(1);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024C2 RID: 9410 RVA: 0x000107A8 File Offset: 0x0000E9A8
	public IEnumerator method_14()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(1);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024C3 RID: 9411 RVA: 0x0011C160 File Offset: 0x0011A360
	public void method_15(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 1448f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(false);
			return;
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x00010799 File Offset: 0x0000E999
	public IEnumerator method_16()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(0);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x0011C1EC File Offset: 0x0011A3EC
	private void method_17()
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_6() ? "" : ("No" + GlobalVariables.instance.songSpeed.method_1() + "Unknown Genre"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_14());
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x000107A8 File Offset: 0x0000E9A8
	public IEnumerator method_18()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(1);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x0011C2B4 File Offset: 0x0011A4B4
	private void method_19()
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_6() ? "game" : ("star_available" + GlobalVariables.instance.songSpeed.method_26() + "beatscore"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_13());
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x0011C37C File Offset: 0x0011A57C
	private void method_20()
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_0() ? "diff_band" : ("Profile file version is different!" + GlobalVariables.instance.songSpeed.method_1() + "Unknown Charter"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_21());
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x00010799 File Offset: 0x0000E999
	public IEnumerator method_21()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(0);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x0011C444 File Offset: 0x0011A644
	private void method_22()
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_6() ? "song" : ("debug_fps" + GlobalVariables.instance.songSpeed.method_26() + "graphics_name"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_16());
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x0011C50C File Offset: 0x0011A70C
	private void method_23()
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_23() ? "song" : ("Unknown Year" + GlobalVariables.instance.songSpeed.method_28() + "-"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_13());
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x0011C5D4 File Offset: 0x0011A7D4
	private void method_24()
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_0() ? "\"([^\"]*)\"" : ("guitar" + GlobalVariables.instance.songSpeed.method_1() + "Unknown Album"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_4());
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x00010799 File Offset: 0x0000E999
	public IEnumerator method_25()
	{
		SongDetails.Class53 @class = new SongDetails.Class53(0);
		@class.songDetails_0 = this;
		return @class;
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x0011C69C File Offset: 0x0011A89C
	private void Start()
	{
		if (!GlobalVariables.instance.gclass5_37.Boolean_1)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.Boolean_0 ? "" : (" (" + GlobalVariables.instance.songSpeed.String_1 + ")"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_8());
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x0011C764 File Offset: 0x0011A964
	private void method_26()
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_6() ? "In Menus: Main Menu" : ("song" + GlobalVariables.instance.songSpeed.method_26() + "All Strums"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_21());
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x0011C82C File Offset: 0x0011AA2C
	public void method_27(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_14())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 1857f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(true);
			return;
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060024D2 RID: 9426 RVA: 0x0011C8B8 File Offset: 0x0011AAB8
	private void method_28()
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_0() ? "Current High Score" : ("Highway Shake" + GlobalVariables.instance.songSpeed.method_1() + "Unknown Charter"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_2());
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x0011C980 File Offset: 0x0011AB80
	public void method_29(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_30())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 77f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(true);
			return;
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060024D4 RID: 9428 RVA: 0x0011CA0C File Offset: 0x0011AC0C
	private void method_30()
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_23() ? "highway_shake" : ("album.png" + GlobalVariables.instance.songSpeed.String_1 + "Guitar Coop"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_25());
	}

	// Token: 0x060024D5 RID: 9429 RVA: 0x0011CAD4 File Offset: 0x0011ACD4
	public void method_31(bool bool_0)
	{
		if (!GlobalVariables.instance.gclass5_37.method_4())
		{
			return;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		if (bool_0)
		{
			this.color_0.a = 1474f;
			this.text.color = (this.text2.color = (this.background.color = this.color_0));
			base.gameObject.SetActive(true);
			return;
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060024D6 RID: 9430 RVA: 0x0011CB60 File Offset: 0x0011AD60
	private void method_32()
	{
		if (!GlobalVariables.instance.gclass5_37.Boolean_1)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.text.text = GlobalVariables.instance.currentSongEntry.songName + (GlobalVariables.instance.songSpeed.method_23() ? "game" : ("New Section" + GlobalVariables.instance.songSpeed.method_28() + "Not match flags next {0} {1}"));
		this.text2.text = GlobalVariables.instance.currentSongEntry.artistName;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			base.gameObject.SetActive(true);
			return;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_4());
	}

	// Token: 0x040005C9 RID: 1481
	[SerializeField]
	private Text text;

	// Token: 0x040005CA RID: 1482
	[SerializeField]
	private Text text2;

	// Token: 0x040005CB RID: 1483
	[SerializeField]
	private Image background;

	// Token: 0x040005CC RID: 1484
	private Color color_0 = new Color(1f, 1f, 1f, 1f);

	// Token: 0x040005CD RID: 1485
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(0.016f);

	// Token: 0x040005CE RID: 1486
	private Coroutine coroutine_0;
}
