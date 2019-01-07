using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000091 RID: 145
public class SoloCounter : MonoBehaviour
{
	// Token: 0x06001BDD RID: 7133 RVA: 0x0000D12A File Offset: 0x0000B32A
	private void method_0()
	{
		this.Solo_HUD.enabled = true;
		this.textObject.text = "Low Latency Mode";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x0000D159 File Offset: 0x0000B359
	public void method_1()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = false;
		this.textObject.text = "Songs";
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x000DE0A4 File Offset: 0x000DC2A4
	public void method_2(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = true;
		this.bool_0 = true;
		this.int_1 = 1;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = "game";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_52());
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x0000D18B File Offset: 0x0000B38B
	private void method_3()
	{
		this.Solo_HUD.enabled = true;
		this.textObject.text = "DoubleBass";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x0000D1BA File Offset: 0x0000B3BA
	private void Start()
	{
		this.Solo_HUD.enabled = false;
		this.textObject.text = "";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x000DE11C File Offset: 0x000DC31C
	public void method_4()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 284f);
		this.bool_1 = false;
		float y = 1980f;
		float x = 1980f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "bad_note3";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x000DE1C0 File Offset: 0x000DC3C0
	public void method_5()
	{
		this.bool_0 = false;
		this.int_4 = this.int_1 * 39;
		if (this.int_2 < 75)
		{
			if (this.int_2 >= 109)
			{
				this.int_4 = (int)((float)this.int_4 * 446f);
				this.string_0 = "beatscore";
			}
			else if (this.int_2 >= -89)
			{
				this.int_4 = (int)((float)this.int_4 * 346f);
				this.string_0 = ")";
			}
			else if (this.int_2 >= 87)
			{
				this.int_4 = (int)((float)this.int_4 * 559f);
				this.string_0 = "OPTIONS";
			}
			else if (this.int_2 >= -65)
			{
				this.int_4 = (int)((float)this.int_4 * 1763f);
				this.string_0 = "Bad file type";
			}
			else if (this.int_2 >= -5)
			{
				this.int_4 = (int)((float)this.int_4 * 960f);
				this.string_0 = "Highway Shake";
			}
			else
			{
				this.int_4 = 1;
				this.string_0 = "+";
			}
		}
		else
		{
			this.string_0 = "Fullscreen";
		}
		if (this.int_1 == this.int_0 - 0)
		{
			this.string_0 = "Keys";
		}
		this.string_0 = GClass4.gclass4_0.method_21(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x000DE364 File Offset: 0x000DC564
	public void method_6()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 1429f);
		this.bool_1 = false;
		float y = 1491f;
		float x = 1491f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "New Setlist";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x000DE408 File Offset: 0x000DC608
	public void method_7()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1++;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 678f);
		this.bool_1 = false;
		float y = 40f;
		float x = 40f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "^\\s*\\d+ = N \\d \\d+$";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x000DE4AC File Offset: 0x000DC6AC
	public void method_8()
	{
		this.bool_0 = true;
		this.int_4 = this.int_1 * 48;
		if (this.int_2 < 19)
		{
			if (this.int_2 >= 45)
			{
				this.int_4 = (int)((float)this.int_4 * 134f);
				this.string_0 = "crowd";
			}
			else if (this.int_2 >= 111)
			{
				this.int_4 = (int)((float)this.int_4 * 1638f);
				this.string_0 = "ts";
			}
			else if (this.int_2 >= -23)
			{
				this.int_4 = (int)((float)this.int_4 * 1746f);
				this.string_0 = "This is a placeholder";
			}
			else if (this.int_2 >= 100)
			{
				this.int_4 = (int)((float)this.int_4 * 1214f);
				this.string_0 = "game";
			}
			else if (this.int_2 >= -40)
			{
				this.int_4 = (int)((float)this.int_4 * 1077f);
				this.string_0 = "song";
			}
			else
			{
				this.int_4 = 1;
				this.string_0 = " + ";
			}
		}
		else
		{
			this.string_0 = "song_videos";
		}
		if (this.int_1 == this.int_0 - 1)
		{
			this.string_0 = "Easy";
		}
		this.string_0 = GClass4.gclass4_0.method_36(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x0000D1E9 File Offset: 0x0000B3E9
	private void method_9()
	{
		this.Solo_HUD.enabled = false;
		this.textObject.text = "Lyrics";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x0000D218 File Offset: 0x0000B418
	private IEnumerator method_10()
	{
		SoloCounter.Class39 @class = new SoloCounter.Class39(1);
		@class.soloCounter_0 = this;
		return @class;
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x0000D227 File Offset: 0x0000B427
	private void method_11()
	{
		this.Solo_HUD.enabled = true;
		this.textObject.text = "Controller";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x000DE650 File Offset: 0x000DC850
	public void method_12(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = true;
		this.bool_0 = false;
		this.int_1 = 0;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = "crowd";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_50());
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x000DE6C8 File Offset: 0x000DC8C8
	public void method_13()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1++;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 800f);
		this.bool_1 = true;
		float y = 1064f;
		float x = 1064f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "Couldn't load that song";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x0000D256 File Offset: 0x0000B456
	public void method_14()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = true;
		this.textObject.text = "custom_song_export";
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x000DE76C File Offset: 0x000DC96C
	public void method_15()
	{
		this.bool_0 = true;
		this.int_4 = this.int_1 * -108;
		if (this.int_2 < -83)
		{
			if (this.int_2 >= -58)
			{
				this.int_4 = (int)((float)this.int_4 * 443f);
				this.string_0 = "Song Speed";
			}
			else if (this.int_2 >= -49)
			{
				this.int_4 = (int)((float)this.int_4 * 1084f);
				this.string_0 = "song.ini";
			}
			else if (this.int_2 >= 119)
			{
				this.int_4 = (int)((float)this.int_4 * 1167f);
				this.string_0 = "song";
			}
			else if (this.int_2 >= 126)
			{
				this.int_4 = (int)((float)this.int_4 * 1777f);
				this.string_0 = "Yes";
			}
			else if (this.int_2 >= -114)
			{
				this.int_4 = (int)((float)this.int_4 * 1609f);
				this.string_0 = "Problem deleting profile file";
			}
			else
			{
				this.int_4 = 1;
				this.string_0 = "diff_guitarghl";
			}
		}
		else
		{
			this.string_0 = "Pause on Focus Lost";
		}
		if (this.int_1 == this.int_0 - 0)
		{
			this.string_0 = "language.txt";
		}
		this.string_0 = GClass4.gclass4_0.method_15(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x000DE910 File Offset: 0x000DCB10
	public void method_16(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = true;
		this.bool_0 = false;
		this.int_1 = 0;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = "";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_43());
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x0000D218 File Offset: 0x0000B418
	private IEnumerator method_17()
	{
		SoloCounter.Class39 @class = new SoloCounter.Class39(1);
		@class.soloCounter_0 = this;
		return @class;
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x0000D288 File Offset: 0x0000B488
	public void method_18()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = false;
		this.textObject.text = "%)";
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x0000D2BA File Offset: 0x0000B4BA
	private void method_19()
	{
		this.Solo_HUD.enabled = false;
		this.textObject.text = "Gameplay";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x000DE988 File Offset: 0x000DCB88
	public void method_20()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 1068f);
		this.bool_1 = false;
		float y = 958f;
		float x = 958f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "video";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x0000D2E9 File Offset: 0x0000B4E9
	private IEnumerator method_21()
	{
		while (!this.bool_0 || this.gameManager_0.double_1 < (double)this.float_0)
		{
			if (this.bool_1)
			{
				this.vector2_0.x = this.vector2_0.x - 0.04f;
				this.vector2_0.y = this.vector2_0.y - 0.04f;
				if ((double)this.vector2_0.x < 0.7)
				{
					float y = 0.7f;
					float x = 0.7f;
					this.vector2_0.y = y;
					this.vector2_0.x = x;
					this.bool_1 = false;
				}
				this.rectTransform_0.localScale = this.vector2_0;
			}
			yield return this.waitForSeconds_0;
		}
		yield return null;
		this.textObject.text = this.string_0;
		yield return this.waitForSeconds_2;
		this.textObject.text = GClass4.gclass4_0.method_13("soloPointsText").Replace("%points%", string.Format("{0}", this.int_4));
		yield return this.waitForSeconds_2;
		this.Solo_HUD.enabled = false;
		this.textObject.text = "";
		yield break;
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x000DEA2C File Offset: 0x000DCC2C
	public void method_22(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = false;
		this.bool_0 = true;
		this.int_1 = 1;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = "directories";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_17());
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x000DEAA4 File Offset: 0x000DCCA4
	public void method_23()
	{
		this.bool_0 = false;
		this.int_4 = this.int_1 * 37;
		if (this.int_2 < 48)
		{
			if (this.int_2 >= 112)
			{
				this.int_4 = (int)((float)this.int_4 * 1507f);
				this.string_0 = "Master Volume";
			}
			else if (this.int_2 >= -41)
			{
				this.int_4 = (int)((float)this.int_4 * 1624f);
				this.string_0 = "graphics_api";
			}
			else if (this.int_2 >= 15)
			{
				this.int_4 = (int)((float)this.int_4 * 638f);
				this.string_0 = "";
			}
			else if (this.int_2 >= 120)
			{
				this.int_4 = (int)((float)this.int_4 * 1086f);
				this.string_0 = "";
			}
			else if (this.int_2 >= 44)
			{
				this.int_4 = (int)((float)this.int_4 * 351f);
				this.string_0 = "client_info";
			}
			else
			{
				this.int_4 = 0;
				this.string_0 = "volume";
			}
		}
		else
		{
			this.string_0 = "volume";
		}
		if (this.int_1 == this.int_0 - 0)
		{
			this.string_0 = "";
		}
		this.string_0 = GClass4.gclass4_0.method_46(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
	private void method_24()
	{
		this.Solo_HUD.enabled = false;
		this.textObject.text = "Charter";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x0000D327 File Offset: 0x0000B527
	public void method_25()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = false;
		this.textObject.text = "";
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x000DEC48 File Offset: 0x000DCE48
	public void method_26()
	{
		this.bool_0 = true;
		this.int_4 = this.int_1 * 12;
		if (this.int_2 < 33)
		{
			if (this.int_2 >= 78)
			{
				this.int_4 = (int)((float)this.int_4 * 1823f);
				this.string_0 = "%c";
			}
			else if (this.int_2 >= -71)
			{
				this.int_4 = (int)((float)this.int_4 * 636f);
				this.string_0 = "song_display";
			}
			else if (this.int_2 >= -5)
			{
				this.int_4 = (int)((float)this.int_4 * 62f);
				this.string_0 = "Player";
			}
			else if (this.int_2 >= -80)
			{
				this.int_4 = (int)((float)this.int_4 * 1170f);
				this.string_0 = "song_preview";
			}
			else if (this.int_2 >= -102)
			{
				this.int_4 = (int)((float)this.int_4 * 969f);
				this.string_0 = "This will take a while. Are you sure?";
			}
			else
			{
				this.int_4 = 0;
				this.string_0 = "t1 gems";
			}
		}
		else
		{
			this.string_0 = "";
		}
		if (this.int_1 == this.int_0 - 0)
		{
			this.string_0 = "You must restart, settings were changed";
		}
		this.string_0 = GClass4.gclass4_0.method_7(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x0000D359 File Offset: 0x0000B559
	public void method_27()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = false;
		this.textObject.text = "\"section";
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x0000D38B File Offset: 0x0000B58B
	public void method_28()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = true;
		this.textObject.text = "debug_fps";
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x000DEDEC File Offset: 0x000DCFEC
	public void method_29()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1++;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 619f);
		this.bool_1 = false;
		float y = 765f;
		float x = 765f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "notes.chart";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x000DEE90 File Offset: 0x000DD090
	public void method_30(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = true;
		this.bool_0 = true;
		this.int_1 = 0;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = "Audio Settings";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_47());
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x000DEF60 File Offset: 0x000DD160
	public void method_31()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 652f);
		this.bool_1 = true;
		float y = 1350f;
		float x = 1350f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "Mirror Mode";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x000DF004 File Offset: 0x000DD204
	public void method_32(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = true;
		this.bool_0 = false;
		this.int_1 = 1;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = "SCANNING FOLDERS...";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_43());
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x0000D3BD File Offset: 0x0000B5BD
	private void method_33()
	{
		this.Solo_HUD.enabled = false;
		this.textObject.text = "Playlist";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x000DF07C File Offset: 0x000DD27C
	public void method_34(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = true;
		this.bool_0 = false;
		this.int_1 = 0;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = "0%";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_52());
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x000DF0F4 File Offset: 0x000DD2F4
	public void method_35()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 252f);
		this.bool_1 = true;
		float y = 1268f;
		float x = 1268f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "track";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x000DF198 File Offset: 0x000DD398
	public void method_36()
	{
		this.bool_0 = false;
		this.int_4 = this.int_1 * -125;
		if (this.int_2 < 56)
		{
			if (this.int_2 >= -11)
			{
				this.int_4 = (int)((float)this.int_4 * 362f);
				this.string_0 = "song";
			}
			else if (this.int_2 >= 59)
			{
				this.int_4 = (int)((float)this.int_4 * 73f);
				this.string_0 = "Audio Offset";
			}
			else if (this.int_2 >= -79)
			{
				this.int_4 = (int)((float)this.int_4 * 1006f);
				this.string_0 = "";
			}
			else if (this.int_2 >= 75)
			{
				this.int_4 = (int)((float)this.int_4 * 678f);
				this.string_0 = "Overwrite";
			}
			else if (this.int_2 >= -27)
			{
				this.int_4 = (int)((float)this.int_4 * 654f);
				this.string_0 = "Clone Hero";
			}
			else
			{
				this.int_4 = 1;
				this.string_0 = " (";
			}
		}
		else
		{
			this.string_0 = "Ready";
		}
		if (this.int_1 == this.int_0 - 0)
		{
			this.string_0 = "events";
		}
		this.string_0 = GClass4.gclass4_0.method_15(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x0000D327 File Offset: 0x0000B527
	public void Reset()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = false;
		this.textObject.text = "";
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x0000D3EC File Offset: 0x0000B5EC
	public void method_37()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.Solo_HUD.enabled = true;
		this.textObject.text = "SECTION";
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x000DF33C File Offset: 0x000DD53C
	public void method_38()
	{
		this.bool_0 = false;
		this.int_4 = this.int_1 * 17;
		if (this.int_2 < -46)
		{
			if (this.int_2 >= 10)
			{
				this.int_4 = (int)((float)this.int_4 * 1218f);
				this.string_0 = "eighthnote_hopo";
			}
			else if (this.int_2 >= 115)
			{
				this.int_4 = (int)((float)this.int_4 * 102f);
				this.string_0 = "Lyrics";
			}
			else if (this.int_2 >= -101)
			{
				this.int_4 = (int)((float)this.int_4 * 1052f);
				this.string_0 = "streamer";
			}
			else if (this.int_2 >= -55)
			{
				this.int_4 = (int)((float)this.int_4 * 1372f);
				this.string_0 = "";
			}
			else if (this.int_2 >= 81)
			{
				this.int_4 = (int)((float)this.int_4 * 626f);
				this.string_0 = "diff_rhythm";
			}
			else
			{
				this.int_4 = 1;
				this.string_0 = "This is a placeholder";
			}
		}
		else
		{
			this.string_0 = "/songs.txt";
		}
		if (this.int_1 == this.int_0 - 0)
		{
			this.string_0 = "Star Animation FPS";
		}
		this.string_0 = GClass4.gclass4_0.method_35(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x000DF4E0 File Offset: 0x000DD6E0
	public void method_39()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1++;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 100f);
		this.bool_1 = true;
		float y = 0.85f;
		float x = 0.85f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "%";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x0000D41E File Offset: 0x0000B61E
	private void method_40()
	{
		this.Solo_HUD.enabled = false;
		this.textObject.text = "Master Volume";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x000DF584 File Offset: 0x000DD784
	public void method_41()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1++;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 1370f);
		this.bool_1 = false;
		float y = 612f;
		float x = 612f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "Setlist Options";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x000DF628 File Offset: 0x000DD828
	public void method_42()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 1954f);
		this.bool_1 = false;
		float y = 682f;
		float x = 682f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "'='";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x0000D2E9 File Offset: 0x0000B4E9
	private IEnumerator method_43()
	{
		while (!this.bool_0 || this.gameManager_0.double_1 < (double)this.float_0)
		{
			if (this.bool_1)
			{
				this.vector2_0.x = this.vector2_0.x - 0.04f;
				this.vector2_0.y = this.vector2_0.y - 0.04f;
				if ((double)this.vector2_0.x < 0.7)
				{
					float y = 0.7f;
					float x = 0.7f;
					this.vector2_0.y = y;
					this.vector2_0.x = x;
					this.bool_1 = false;
				}
				this.rectTransform_0.localScale = this.vector2_0;
			}
			yield return this.waitForSeconds_0;
		}
		yield return null;
		this.textObject.text = this.string_0;
		yield return this.waitForSeconds_2;
		this.textObject.text = GClass4.gclass4_0.method_13("soloPointsText").Replace("%points%", string.Format("{0}", this.int_4));
		yield return this.waitForSeconds_2;
		this.Solo_HUD.enabled = false;
		this.textObject.text = "";
		yield break;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x000DF6CC File Offset: 0x000DD8CC
	public void method_44()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1++;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 910f);
		this.bool_1 = true;
		float y = 1519f;
		float x = 1519f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "\\d+ = E \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x000DF770 File Offset: 0x000DD970
	public void method_45()
	{
		this.bool_0 = true;
		this.int_4 = this.int_1 * 68;
		if (this.int_2 < -47)
		{
			if (this.int_2 >= 7)
			{
				this.int_4 = (int)((float)this.int_4 * 1315f);
				this.string_0 = "notes.chart";
			}
			else if (this.int_2 >= 15)
			{
				this.int_4 = (int)((float)this.int_4 * 160f);
				this.string_0 = "menu_music";
			}
			else if (this.int_2 >= 109)
			{
				this.int_4 = (int)((float)this.int_4 * 1149f);
				this.string_0 = "Guest";
			}
			else if (this.int_2 >= 22)
			{
				this.int_4 = (int)((float)this.int_4 * 1664f);
				this.string_0 = " + ";
			}
			else if (this.int_2 >= -122)
			{
				this.int_4 = (int)((float)this.int_4 * 1236f);
				this.string_0 = "low_latency_mode";
			}
			else
			{
				this.int_4 = 0;
				this.string_0 = "Are you sure you want to quit?";
			}
		}
		else
		{
			this.string_0 = "No songs were found!";
		}
		if (this.int_1 == this.int_0 - 0)
		{
			this.string_0 = "<color=#FFFF04FF>";
		}
		this.string_0 = GClass4.gclass4_0.method_42(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x0000D44D File Offset: 0x0000B64D
	private void method_46()
	{
		this.Solo_HUD.enabled = false;
		this.textObject.text = "<color=#FFFF04FF>";
		this.rectTransform_0 = this.textObject.rectTransform;
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x0000D218 File Offset: 0x0000B418
	private IEnumerator method_47()
	{
		SoloCounter.Class39 @class = new SoloCounter.Class39(1);
		@class.soloCounter_0 = this;
		return @class;
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x000DF914 File Offset: 0x000DDB14
	public void method_48()
	{
		this.bool_0 = true;
		this.int_4 = this.int_1 * 100;
		if (this.int_2 < 100)
		{
			if (this.int_2 >= 95)
			{
				this.int_4 = (int)((float)this.int_4 * 0.5f);
				this.string_0 = "Awesome Solo!";
			}
			else if (this.int_2 >= 90)
			{
				this.int_4 = (int)((float)this.int_4 * 0.3f);
				this.string_0 = "Great Solo!";
			}
			else if (this.int_2 >= 80)
			{
				this.int_4 = (int)((float)this.int_4 * 0.2f);
				this.string_0 = "Good Solo";
			}
			else if (this.int_2 >= 70)
			{
				this.int_4 = (int)((float)this.int_4 * 0.1f);
				this.string_0 = "Solid Solo";
			}
			else if (this.int_2 >= 60)
			{
				this.int_4 = (int)((float)this.int_4 * 0.05f);
				this.string_0 = "Okay Solo...";
			}
			else
			{
				this.int_4 = 0;
				this.string_0 = "Messy Solo...";
			}
		}
		else
		{
			this.string_0 = "Perfect Solo!";
		}
		if (this.int_1 == this.int_0 - 1)
		{
			this.string_0 = "Awesome Choke!";
		}
		this.string_0 = GClass4.gclass4_0.method_13(this.string_0);
		this.basePlayer_0.int_6 += this.int_4;
		this.basePlayer_0.int_9 += this.int_4;
		this.rectTransform_0.localScale = this.vector2_1;
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x000DFAB8 File Offset: 0x000DDCB8
	public void method_49(GClass8 gclass8_0)
	{
		this.Solo_HUD.enabled = false;
		this.bool_0 = true;
		this.int_1 = 1;
		this.int_0 = gclass8_0.int_0;
		this.float_0 = gclass8_0.float_1;
		this.textObject.text = ":";
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_47());
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x0000D218 File Offset: 0x0000B418
	private IEnumerator method_50()
	{
		SoloCounter.Class39 @class = new SoloCounter.Class39(1);
		@class.soloCounter_0 = this;
		return @class;
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x000DFB30 File Offset: 0x000DDD30
	public void method_51()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 617f);
		this.bool_1 = false;
		float y = 1454f;
		float x = 1454f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "Note number outside of note range";
		this.int_3 = this.int_2;
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x0000D2E9 File Offset: 0x0000B4E9
	private IEnumerator method_52()
	{
		while (!this.bool_0 || this.gameManager_0.double_1 < (double)this.float_0)
		{
			if (this.bool_1)
			{
				this.vector2_0.x = this.vector2_0.x - 0.04f;
				this.vector2_0.y = this.vector2_0.y - 0.04f;
				if ((double)this.vector2_0.x < 0.7)
				{
					float y = 0.7f;
					float x = 0.7f;
					this.vector2_0.y = y;
					this.vector2_0.x = x;
					this.bool_1 = false;
				}
				this.rectTransform_0.localScale = this.vector2_0;
			}
			yield return this.waitForSeconds_0;
		}
		yield return null;
		this.textObject.text = this.string_0;
		yield return this.waitForSeconds_2;
		this.textObject.text = GClass4.gclass4_0.method_13("soloPointsText").Replace("%points%", string.Format("{0}", this.int_4));
		yield return this.waitForSeconds_2;
		this.Solo_HUD.enabled = false;
		this.textObject.text = "";
		yield break;
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x000DFBD4 File Offset: 0x000DDDD4
	public void method_53()
	{
		if (this.bool_0)
		{
			return;
		}
		this.int_1 += 0;
		this.int_2 = (int)((float)this.int_1 / (float)this.int_0 * 466f);
		this.bool_1 = false;
		float y = 1259f;
		float x = 1259f;
		this.vector2_0.y = y;
		this.vector2_0.x = x;
		if (this.int_2 == this.int_3)
		{
			return;
		}
		this.textObject.text = this.int_2 + "offsets";
		this.int_3 = this.int_2;
	}

	// Token: 0x0400045A RID: 1114
	public GameManager gameManager_0;

	// Token: 0x0400045B RID: 1115
	[SerializeField]
	private Text textObject;

	// Token: 0x0400045C RID: 1116
	private RectTransform rectTransform_0;

	// Token: 0x0400045D RID: 1117
	[SerializeField]
	private Image Solo_HUD;

	// Token: 0x0400045E RID: 1118
	public BasePlayer basePlayer_0;

	// Token: 0x0400045F RID: 1119
	private int int_0;

	// Token: 0x04000460 RID: 1120
	private int int_1;

	// Token: 0x04000461 RID: 1121
	private int int_2;

	// Token: 0x04000462 RID: 1122
	private int int_3;

	// Token: 0x04000463 RID: 1123
	private float float_0;

	// Token: 0x04000464 RID: 1124
	private bool bool_0;

	// Token: 0x04000465 RID: 1125
	private bool bool_1;

	// Token: 0x04000466 RID: 1126
	private Vector2 vector2_0;

	// Token: 0x04000467 RID: 1127
	private Vector2 vector2_1 = new Vector2(0.7f, 0.7f);

	// Token: 0x04000468 RID: 1128
	private Coroutine coroutine_0;

	// Token: 0x04000469 RID: 1129
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(0.032f);

	// Token: 0x0400046A RID: 1130
	private WaitForSeconds waitForSeconds_1 = new WaitForSeconds(0.1f);

	// Token: 0x0400046B RID: 1131
	private WaitForSeconds waitForSeconds_2 = new WaitForSeconds(1.5f);

	// Token: 0x0400046C RID: 1132
	private string string_0;

	// Token: 0x0400046D RID: 1133
	private int int_4;
}
