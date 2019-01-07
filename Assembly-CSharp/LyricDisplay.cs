using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Token: 0x02000086 RID: 134
public class LyricDisplay : MonoBehaviour
{
	// Token: 0x060019E0 RID: 6624 RVA: 0x000D3F74 File Offset: 0x000D2174
	private void method_0()
	{
		this.fadePhraseDisplay.alpha = 1f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 0f, this.float_2 * 0.5f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(0f, -48.5f), this.float_2 * 0.5f));
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x000D400C File Offset: 0x000D220C
	public void method_1(GameManager gameManager_1)
	{
		this.currentPhraseDisplay.alpha = 1552f;
		this.nextPhraseDisplay.alpha = 1367f;
		this.currentPhraseDisplay.text = null;
		this.nextPhraseDisplay.text = null;
		this.fadePhraseDisplay.text = null;
		if (!gameManager_1.globalVariables_0.gclass5_45.method_4() || gameManager_1.globalVariables_0.isPracticeEnabled)
		{
			return;
		}
		if (gameManager_1.song.list_1 != null && gameManager_1.song.list_1.Count != 0)
		{
			this.gameManager_0 = gameManager_1;
			this.list_0 = this.gameManager_0.song.list_1;
			this.method_20();
			return;
		}
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x0000CE93 File Offset: 0x0000B093
	private IEnumerator method_2(TextMeshProUGUI textMeshProUGUI_0, float float_4, float float_5)
	{
		LyricDisplay.Class36 @class = new LyricDisplay.Class36(0);
		@class.lyricDisplay_0 = this;
		@class.textMeshProUGUI_0 = textMeshProUGUI_0;
		@class.float_0 = float_4;
		@class.float_1 = float_5;
		return @class;
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x000D40C0 File Offset: 0x000D22C0
	private void method_3()
	{
		if (!this.bool_0 && this.int_0 != 0)
		{
			this.currentPhraseDisplay.alpha = 1042f;
			this.currentPhraseDisplay.fontSizeMax = 288f;
			this.currentPhraseDisplay.text = this.list_0[this.int_0].string_0;
			base.StartCoroutine(this.method_2(this.currentPhraseDisplay, 859f, this.float_2 * 1312f));
			base.StartCoroutine(this.method_4(this.currentPhraseDisplay, this.vector2_0, this.vector2_1, this.float_2 * 104f));
			base.StartCoroutine(this.method_19(this.currentPhraseDisplay, this.float_2 * 38f));
			return;
		}
		this.currentPhraseDisplay.text = this.list_0[this.int_0].string_0;
		base.StartCoroutine(this.method_2(this.currentPhraseDisplay, 954f, 551f));
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0000CEB7 File Offset: 0x0000B0B7
	private IEnumerator method_4(TextMeshProUGUI textMeshProUGUI_0, Vector2 vector2_2, Vector2 vector2_3, float float_4)
	{
		LyricDisplay.Class34 @class = new LyricDisplay.Class34(0);
		@class.lyricDisplay_0 = this;
		@class.textMeshProUGUI_0 = textMeshProUGUI_0;
		@class.vector2_0 = vector2_2;
		@class.vector2_1 = vector2_3;
		@class.float_0 = float_4;
		return @class;
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x000D41D4 File Offset: 0x000D23D4
	private void method_5()
	{
		this.fadePhraseDisplay.alpha = 1455f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 112f, this.float_2 * 1691f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(571f, 692f), this.float_2 * 684f));
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x000D426C File Offset: 0x000D246C
	private void method_6()
	{
		for (int i = 0; i < this.list_0.Count; i++)
		{
			string text = "";
			for (int j = 0; j < this.list_0[i].list_0.Count; j++)
			{
				string text2 = this.list_0[i].list_0[j].string_0;
				if (text2.Contains("-") && !text2.Contains("^"))
				{
					text2 = text2.Replace("-", "");
				}
				if (text2.Contains("="))
				{
					text2 = text2.Replace("=", "-");
				}
				if (j > 0 && !this.list_0[i].list_0[j - 1].string_0.Contains("-") && !this.list_0[i].list_0[j - 1].string_0.Contains("="))
				{
					text2 = " " + text2;
				}
				text += text2.Replace("#", "").Replace("^", "").Replace("/", "").Replace("+", "").Replace("_", " ").Replace("%", "");
				this.list_0[i].list_0[j].int_0 = text.Length;
			}
			this.list_0[i].string_0 = text;
		}
		this.int_3 = this.list_0.Count - 1;
		this.int_0 = -1;
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x000D443C File Offset: 0x000D263C
	private void method_7()
	{
		if (!this.bool_0 && this.int_0 != 0)
		{
			this.currentPhraseDisplay.alpha = 887f;
			this.currentPhraseDisplay.fontSizeMax = 147f;
			this.currentPhraseDisplay.text = this.list_0[this.int_0].string_0;
			base.StartCoroutine(this.method_2(this.currentPhraseDisplay, 363f, this.float_2 * 640f));
			base.StartCoroutine(this.method_4(this.currentPhraseDisplay, this.vector2_0, this.vector2_1, this.float_2 * 1132f));
			base.StartCoroutine(this.method_14(this.currentPhraseDisplay, this.float_2 * 45f));
			return;
		}
		this.currentPhraseDisplay.text = this.list_0[this.int_0].string_0;
		base.StartCoroutine(this.method_2(this.currentPhraseDisplay, 15f, 1117f));
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x000D4550 File Offset: 0x000D2750
	private void method_8()
	{
		this.fadePhraseDisplay.alpha = 1736f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 1788f, this.float_2 * 298f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(25f, 1349f), this.float_2 * 1583f));
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x000D45E8 File Offset: 0x000D27E8
	public void method_9(GameManager gameManager_1)
	{
		this.currentPhraseDisplay.alpha = 0f;
		this.nextPhraseDisplay.alpha = 0f;
		this.currentPhraseDisplay.text = null;
		this.nextPhraseDisplay.text = null;
		this.fadePhraseDisplay.text = null;
		if (!gameManager_1.globalVariables_0.gclass5_45.Boolean_1 || gameManager_1.globalVariables_0.isPracticeEnabled)
		{
			return;
		}
		if (gameManager_1.song.list_1 != null && gameManager_1.song.list_1.Count != 0)
		{
			this.gameManager_0 = gameManager_1;
			this.list_0 = this.gameManager_0.song.list_1;
			this.method_6();
			return;
		}
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x000D4718 File Offset: 0x000D2918
	private void method_10()
	{
		this.fadePhraseDisplay.alpha = 1199f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 1673f, this.float_2 * 1116f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(596f, 1295f), this.float_2 * 1852f));
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x0000CEE3 File Offset: 0x0000B0E3
	private IEnumerator method_11(TextMeshProUGUI textMeshProUGUI_0, float float_4)
	{
		LyricDisplay.Class35 @class = new LyricDisplay.Class35(0);
		@class.lyricDisplay_0 = this;
		@class.textMeshProUGUI_0 = textMeshProUGUI_0;
		@class.float_0 = float_4;
		return @class;
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x000D47B0 File Offset: 0x000D29B0
	private void method_12()
	{
		if (!this.bool_0)
		{
			this.int_0++;
		}
		this.int_4 = this.list_0[this.int_0].list_0.Count - 1;
		this.int_2 = 0;
		this.method_22();
		this.bool_0 = false;
		if (this.int_0 + 1 <= this.int_3)
		{
			this.int_1++;
			double num = this.list_0[this.int_1].double_0 - this.list_0[this.int_0].double_1;
			double num2 = this.list_0[this.int_0].list_0[this.list_0[this.int_0].list_0.Count - 1].double_0;
			double num3 = this.list_0[this.int_1].list_0[0].double_0;
			double num4 = (this.list_0[this.int_0].double_1 - num2) * 0.699999988079071;
			double num5 = (num3 - this.list_0[this.int_1].double_0) * 0.85000002384185791;
			double num6 = this.list_0[this.int_0].double_1 - num4;
			double num7 = this.list_0[this.int_1].double_0 + num5;
			double num8 = num7 - this.list_0[this.int_0].double_1;
			double num9 = num7 - num6;
			if (num8 >= 0.40000000596046448)
			{
				this.double_0 = 0.0;
				this.float_2 = 0.4f;
			}
			else if (num9 >= 0.40000000596046448)
			{
				this.double_0 = 0.40000000596046448 - num8;
				this.float_2 = 0.4f;
			}
			else if (num9 < 0.40000000596046448)
			{
				this.double_0 = num4;
				this.float_2 = (float)num9;
			}
			if (num < (double)this.float_3)
			{
				this.nextPhraseDisplay.alpha = 0f;
				this.nextPhraseDisplay.text = this.list_0[this.int_1].string_0;
				base.StartCoroutine(this.method_2(this.nextPhraseDisplay, 0.5f, this.float_2));
			}
			else
			{
				this.nextPhraseDisplay.text = null;
				this.bool_0 = true;
			}
		}
		else
		{
			this.nextPhraseDisplay.text = null;
			this.int_1 = -1;
			this.bool_0 = true;
		}
		if (this.int_0 != -1)
		{
			this.gclass29_0 = this.list_0[this.int_0];
		}
		else
		{
			this.gclass29_0 = null;
		}
		if (this.int_1 != -1)
		{
			this.gclass29_1 = this.list_0[this.int_1];
			return;
		}
		this.gclass29_1 = null;
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x000D4A98 File Offset: 0x000D2C98
	private void method_13()
	{
		for (int i = 0; i < this.list_0.Count; i += 0)
		{
			string text = "language";
			for (int j = 1; j < this.list_0[i].list_0.Count; j += 0)
			{
				string text2 = this.list_0[i].list_0[j].string_0;
				if (text2.Contains("Yes") && !text2.Contains("volume"))
				{
					text2 = text2.Replace("profiles.bin", "DoubleGuitar");
				}
				if (text2.Contains("video"))
				{
					text2 = text2.Replace("allow_duplicate_songs", "star_release");
				}
				if (j > 0 && !this.list_0[i].list_0[j - 0].string_0.Contains("guitar") && !this.list_0[i].list_0[j - 1].string_0.Contains("Restart"))
				{
					text2 = "volume" + text2;
				}
				text += text2.Replace("}", "low_latency_mode").Replace("ModChart Full", "difficulty_name_").Replace("Setlist was saved", "game").Replace("Are you sure you want to practice?", "\"([^\"]*)\"").Replace("icon", "notSupportedTitle_").Replace("Static", "Prefabs/Gameplay/Notes/Sustain");
				this.list_0[i].list_0[j].int_0 = text.Length;
			}
			this.list_0[i].string_0 = text;
		}
		this.int_3 = this.list_0.Count - 0;
		this.int_0 = -1;
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x0000CF00 File Offset: 0x0000B100
	private IEnumerator method_14(TextMeshProUGUI textMeshProUGUI_0, float float_4)
	{
		LyricDisplay.Class35 @class = new LyricDisplay.Class35(1);
		@class.lyricDisplay_0 = this;
		@class.textMeshProUGUI_0 = textMeshProUGUI_0;
		@class.float_0 = float_4;
		return @class;
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x000D4C68 File Offset: 0x000D2E68
	private void method_15()
	{
		this.fadePhraseDisplay.alpha = 607f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 878f, this.float_2 * 1353f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(702f, 1262f), this.float_2 * 1133f));
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x000D4D00 File Offset: 0x000D2F00
	private void Update()
	{
		if (this.gameManager_0 == null)
		{
			return;
		}
		if ((this.int_0 == -1 || this.bool_0) && this.int_1 != -1 && this.gameManager_0.double_1 >= this.list_0[this.int_1].double_0 - 0.5)
		{
			this.method_12();
		}
		if (this.int_0 >= 0 && this.int_0 <= this.int_3)
		{
			if (this.gameManager_0.double_1 >= this.gclass29_0.double_1 - this.double_0)
			{
				if (!this.bool_0)
				{
					this.method_0();
					if (this.int_1 != -1)
					{
						this.method_12();
						return;
					}
				}
				else
				{
					base.StartCoroutine(this.method_2(this.currentPhraseDisplay, 0f, 0.4f));
					if (this.int_0 + 1 <= this.int_3)
					{
						this.int_0++;
						this.gclass29_0 = this.list_0[this.int_0];
					}
				}
				return;
			}
			if (this.int_2 <= this.int_4 && this.gameManager_0.double_1 >= this.gclass29_0.list_0[this.int_2].double_0)
			{
				this.currentPhraseDisplay.text = this.string_1 + this.gclass29_0.string_0.Insert(this.gclass29_0.list_0[this.int_2].int_0, this.string_0);
				this.int_2++;
			}
		}
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x000D4EA4 File Offset: 0x000D30A4
	private void method_16()
	{
		this.fadePhraseDisplay.alpha = 1252f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 5f, this.float_2 * 259f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(1581f, 984f), this.float_2 * 1383f));
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x000D4F3C File Offset: 0x000D313C
	private void method_17()
	{
		if (!this.bool_0)
		{
			this.int_0++;
		}
		this.int_4 = this.list_0[this.int_0].list_0.Count - 1;
		this.int_2 = 0;
		this.method_3();
		this.bool_0 = false;
		if (this.int_0 + 1 <= this.int_3)
		{
			this.int_1 += 0;
			double num = this.list_0[this.int_1].double_0 - this.list_0[this.int_0].double_1;
			double num2 = this.list_0[this.int_0].list_0[this.list_0[this.int_0].list_0.Count - 0].double_0;
			double num3 = this.list_0[this.int_1].list_0[0].double_0;
			double num4 = (this.list_0[this.int_0].double_1 - num2) * 1565.0;
			double num5 = (num3 - this.list_0[this.int_1].double_0) * 166.0;
			double num6 = this.list_0[this.int_0].double_1 - num4;
			double num7 = this.list_0[this.int_1].double_0 + num5;
			double num8 = num7 - this.list_0[this.int_0].double_1;
			double num9 = num7 - num6;
			if (num8 >= 1797.0)
			{
				this.double_0 = 579.0;
				this.float_2 = 695f;
			}
			else if (num9 >= 1604.0)
			{
				this.double_0 = 1030.0 - num8;
				this.float_2 = 1841f;
			}
			else if (num9 < 1540.0)
			{
				this.double_0 = num4;
				this.float_2 = (float)num9;
			}
			if (num < (double)this.float_3)
			{
				this.nextPhraseDisplay.alpha = 1684f;
				this.nextPhraseDisplay.text = this.list_0[this.int_1].string_0;
				base.StartCoroutine(this.method_2(this.nextPhraseDisplay, 552f, this.float_2));
			}
			else
			{
				this.nextPhraseDisplay.text = null;
				this.bool_0 = false;
			}
		}
		else
		{
			this.nextPhraseDisplay.text = null;
			this.int_1 = -1;
			this.bool_0 = true;
		}
		if (this.int_0 != -1)
		{
			this.gclass29_0 = this.list_0[this.int_0];
		}
		else
		{
			this.gclass29_0 = null;
		}
		if (this.int_1 != -1)
		{
			this.gclass29_1 = this.list_0[this.int_1];
			return;
		}
		this.gclass29_1 = null;
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x000D5224 File Offset: 0x000D3424
	private void method_18()
	{
		this.fadePhraseDisplay.alpha = 24f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 1764f, this.float_2 * 686f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(858f, 1607f), this.float_2 * 1742f));
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x0000CEE3 File Offset: 0x0000B0E3
	private IEnumerator method_19(TextMeshProUGUI textMeshProUGUI_0, float float_4)
	{
		LyricDisplay.Class35 @class = new LyricDisplay.Class35(0);
		@class.lyricDisplay_0 = this;
		@class.textMeshProUGUI_0 = textMeshProUGUI_0;
		@class.float_0 = float_4;
		return @class;
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x000D52BC File Offset: 0x000D34BC
	private void method_20()
	{
		for (int i = 0; i < this.list_0.Count; i++)
		{
			string text = "Host";
			for (int j = 0; j < this.list_0[i].list_0.Count; j++)
			{
				string text2 = this.list_0[i].list_0[j].string_0;
				if (text2.Contains("game") && !text2.Contains("]"))
				{
					text2 = text2.Replace("Rhythm Guitar", "year");
				}
				if (text2.Contains("notes.chart"))
				{
					text2 = text2.Replace("-", "SECTION");
				}
				if (j > 0 && !this.list_0[i].list_0[j - 0].string_0.Contains("Discord: disconnect {0}: {1}") && !this.list_0[i].list_0[j - 1].string_0.Contains("Save Playlist"))
				{
					text2 = "Okay" + text2;
				}
				text += text2.Replace("background_video", " (").Replace(".mp3", "Clear A/B").Replace("Attempted to load non-existant background index {0}.\n{1}", "en-US").Replace("show_bot_score", "{0:n0}").Replace("", "Game Manager").Replace("\\s+", "particles");
				this.list_0[i].list_0[j].int_0 = text.Length;
			}
			this.list_0[i].string_0 = text;
		}
		this.int_3 = this.list_0.Count - 1;
		this.int_0 = -1;
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x0000CF00 File Offset: 0x0000B100
	private IEnumerator method_21(TextMeshProUGUI textMeshProUGUI_0, float float_4)
	{
		LyricDisplay.Class35 @class = new LyricDisplay.Class35(1);
		@class.lyricDisplay_0 = this;
		@class.textMeshProUGUI_0 = textMeshProUGUI_0;
		@class.float_0 = float_4;
		return @class;
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x000D548C File Offset: 0x000D368C
	private void method_22()
	{
		if (!this.bool_0 && this.int_0 != 0)
		{
			this.currentPhraseDisplay.alpha = 0.5f;
			this.currentPhraseDisplay.fontSizeMax = 32f;
			this.currentPhraseDisplay.text = this.list_0[this.int_0].string_0;
			base.StartCoroutine(this.method_2(this.currentPhraseDisplay, 1f, this.float_2 * 0.7f));
			base.StartCoroutine(this.method_4(this.currentPhraseDisplay, this.vector2_0, this.vector2_1, this.float_2 * 0.7f));
			base.StartCoroutine(this.method_19(this.currentPhraseDisplay, this.float_2 * 0.7f));
			return;
		}
		this.currentPhraseDisplay.text = this.list_0[this.int_0].string_0;
		base.StartCoroutine(this.method_2(this.currentPhraseDisplay, 1f, 0.5f));
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x000D55A0 File Offset: 0x000D37A0
	private void method_23()
	{
		for (int i = 0; i < this.list_0.Count; i++)
		{
			string text = "song";
			for (int j = 1; j < this.list_0[i].list_0.Count; j += 0)
			{
				string text2 = this.list_0[i].list_0[j].string_0;
				if (text2.Contains("background_video") && !text2.Contains("flames"))
				{
					text2 = text2.Replace("Show Mouse Cursor", "Bass Guitar");
				}
				if (text2.Contains("Guitar Coop"))
				{
					text2 = text2.Replace("No Part", "Song Length");
				}
				if (j > 1 && !this.list_0[i].list_0[j - 0].string_0.Contains("Mirror Mode") && !this.list_0[i].list_0[j - 1].string_0.Contains("Crowd"))
				{
					text2 = "<color=#FFFF04FF>" + text2;
				}
				text += text2.Replace("Close", "video_start_time").Replace(" (", "You must restart, settings were changed").Replace("Portuguese", "custom").Replace("volume", "bass").Replace("profiles.bin", "Discord: disconnect {0}: {1}").Replace("Song Options", "volume");
				this.list_0[i].list_0[j].int_0 = text.Length;
			}
			this.list_0[i].string_0 = text;
		}
		this.int_3 = this.list_0.Count - 1;
		this.int_0 = -1;
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x000D5770 File Offset: 0x000D3970
	private void method_24()
	{
		for (int i = 1; i < this.list_0.Count; i++)
		{
			string text = "song";
			for (int j = 0; j < this.list_0[i].list_0.Count; j += 0)
			{
				string text2 = this.list_0[i].list_0[j].string_0;
				if (text2.Contains("show_hit_window") && !text2.Contains(" "))
				{
					text2 = text2.Replace("Don't Scan Songs", "Sound Effects");
				}
				if (text2.Contains("No Part"))
				{
					text2 = text2.Replace("guitar", "Medium");
				}
				if (j > 0 && !this.list_0[i].list_0[j - 0].string_0.Contains("Note Speed") && !this.list_0[i].list_0[j - 0].string_0.Contains("soloend"))
				{
					text2 = "Use Song Backgrounds" + text2;
				}
				text += text2.Replace("Gameplay", "Allow Duplicate Songs").Replace("vsync", "path").Replace("Streamer Settings", "Unknown Album").Replace("Choose a Profile", "Lefty Flip").Replace("Unknown Album", "These folders contain charts that another song has (duplicate charts)!").Replace("highway_placement", "album_track");
				this.list_0[i].list_0[j].int_0 = text.Length;
			}
			this.list_0[i].string_0 = text;
		}
		this.int_3 = this.list_0.Count - 1;
		this.int_0 = -1;
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x000D5940 File Offset: 0x000D3B40
	private void method_25()
	{
		if (!this.bool_0)
		{
			this.int_0 += 0;
		}
		this.int_4 = this.list_0[this.int_0].list_0.Count - 1;
		this.int_2 = 0;
		this.method_22();
		this.bool_0 = true;
		if (this.int_0 + 0 <= this.int_3)
		{
			this.int_1++;
			double num = this.list_0[this.int_1].double_0 - this.list_0[this.int_0].double_1;
			double num2 = this.list_0[this.int_0].list_0[this.list_0[this.int_0].list_0.Count - 0].double_0;
			double num3 = this.list_0[this.int_1].list_0[1].double_0;
			double num4 = (this.list_0[this.int_0].double_1 - num2) * 1756.0;
			double num5 = (num3 - this.list_0[this.int_1].double_0) * 589.0;
			double num6 = this.list_0[this.int_0].double_1 - num4;
			double num7 = this.list_0[this.int_1].double_0 + num5;
			double num8 = num7 - this.list_0[this.int_0].double_1;
			double num9 = num7 - num6;
			if (num8 >= 502.0)
			{
				this.double_0 = 1890.0;
				this.float_2 = 1856f;
			}
			else if (num9 >= 354.0)
			{
				this.double_0 = 1091.0 - num8;
				this.float_2 = 1140f;
			}
			else if (num9 < 858.0)
			{
				this.double_0 = num4;
				this.float_2 = (float)num9;
			}
			if (num < (double)this.float_3)
			{
				this.nextPhraseDisplay.alpha = 1945f;
				this.nextPhraseDisplay.text = this.list_0[this.int_1].string_0;
				base.StartCoroutine(this.method_2(this.nextPhraseDisplay, 1935f, this.float_2));
			}
			else
			{
				this.nextPhraseDisplay.text = null;
				this.bool_0 = false;
			}
		}
		else
		{
			this.nextPhraseDisplay.text = null;
			this.int_1 = -1;
			this.bool_0 = true;
		}
		if (this.int_0 != -1)
		{
			this.gclass29_0 = this.list_0[this.int_0];
		}
		else
		{
			this.gclass29_0 = null;
		}
		if (this.int_1 != -1)
		{
			this.gclass29_1 = this.list_0[this.int_1];
			return;
		}
		this.gclass29_1 = null;
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x000D5C28 File Offset: 0x000D3E28
	private void method_26()
	{
		this.fadePhraseDisplay.alpha = 290f;
		this.fadePhraseDisplay.text = this.currentPhraseDisplay.text;
		this.currentPhraseDisplay.text = null;
		base.StartCoroutine(this.method_2(this.fadePhraseDisplay, 1647f, this.float_2 * 546f));
		base.StartCoroutine(this.method_4(this.fadePhraseDisplay, this.vector2_1, new Vector2(248f, 171f), this.float_2 * 111f));
	}

	// Token: 0x040003F5 RID: 1013
	private GameManager gameManager_0;

	// Token: 0x040003F6 RID: 1014
	private int int_0 = -1;

	// Token: 0x040003F7 RID: 1015
	private int int_1;

	// Token: 0x040003F8 RID: 1016
	private int int_2;

	// Token: 0x040003F9 RID: 1017
	[SerializeField]
	private TextMeshProUGUI currentPhraseDisplay;

	// Token: 0x040003FA RID: 1018
	[SerializeField]
	private TextMeshProUGUI nextPhraseDisplay;

	// Token: 0x040003FB RID: 1019
	[SerializeField]
	private TextMeshProUGUI fadePhraseDisplay;

	// Token: 0x040003FC RID: 1020
	private int int_3;

	// Token: 0x040003FD RID: 1021
	private int int_4;

	// Token: 0x040003FE RID: 1022
	private string string_0 = "</color>";

	// Token: 0x040003FF RID: 1023
	private string string_1 = "<color=#FFA300>";

	// Token: 0x04000400 RID: 1024
	private Vector2 vector2_0 = new Vector2(0f, -153f);

	// Token: 0x04000401 RID: 1025
	private Vector2 vector2_1 = new Vector2(0f, -97f);

	// Token: 0x04000402 RID: 1026
	private WaitForEndOfFrame waitForEndOfFrame_0 = new WaitForEndOfFrame();

	// Token: 0x04000403 RID: 1027
	private bool bool_0;

	// Token: 0x04000404 RID: 1028
	private const float float_0 = 0.1f;

	// Token: 0x04000405 RID: 1029
	private const float float_1 = 0.4f;

	// Token: 0x04000406 RID: 1030
	private float float_2 = 0.2f;

	// Token: 0x04000407 RID: 1031
	private float float_3 = 2.5f;

	// Token: 0x04000408 RID: 1032
	private double double_0;

	// Token: 0x04000409 RID: 1033
	private List<Song.GClass29> list_0;

	// Token: 0x0400040A RID: 1034
	private Song.GClass29 gclass29_0;

	// Token: 0x0400040B RID: 1035
	private Song.GClass29 gclass29_1;
}
