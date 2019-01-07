using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B5 RID: 181
public class PracticeUI : MonoBehaviour
{
	// Token: 0x0600234A RID: 9034 RVA: 0x00010194 File Offset: 0x0000E394
	public void method_0(int int_5)
	{
		this.text_1.text = "Keys" + int_5 + "Failed to get data privacy url: {0}";
		this.int_1 = 1;
		this.text_3.text = "profiles.bin";
	}

	// Token: 0x0600234B RID: 9035 RVA: 0x00112870 File Offset: 0x00110A70
	public void method_1(int int_5)
	{
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_2 = 1;
		this.text_2.text = "/Setlists";
		this.text_4.text = "";
		this.text_5.text = "song" + int_5;
	}

	// Token: 0x0600234C RID: 9036 RVA: 0x000101CD File Offset: 0x0000E3CD
	public void method_2(int int_5)
	{
		this.text_1.text = ":" + int_5 + "Resolution";
		this.int_1 = 1;
		this.text_3.text = "0";
	}

	// Token: 0x0600234D RID: 9037 RVA: 0x00010206 File Offset: 0x0000E406
	private void method_3()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[1];
		this.method_58(112);
	}

	// Token: 0x0600234E RID: 9038 RVA: 0x0001023B File Offset: 0x0000E43B
	private IEnumerator method_4()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(1);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x0001024A File Offset: 0x0000E44A
	private IEnumerator method_5()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(0);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x001128D4 File Offset: 0x00110AD4
	public void method_6()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "Audio Backend";
		}
		this.int_2 = 1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.text_2.text = "is_practice";
		this.text_4.text = "notes.mid";
		Color color = this.text_0.color;
		color.a = 1542f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[1].string_0;
			if (this.list_0.Count > 1)
			{
				this.float_0 = this.list_0[1].Single_0;
			}
		}
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x00010259 File Offset: 0x0000E459
	public void method_7(int int_5)
	{
		this.text_1.text = "<" + int_5 + "%>";
		this.int_1 = 0;
		this.text_3.text = "0%";
	}

	// Token: 0x06002352 RID: 9042 RVA: 0x001129C0 File Offset: 0x00110BC0
	public void method_8(int int_5)
	{
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_2 = 0;
		this.text_2.text = "0%";
		this.text_4.text = "0";
		this.text_5.text = "/" + int_5;
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x00112A24 File Offset: 0x00110C24
	public void method_9(int int_5)
	{
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_2 = 1;
		this.text_2.text = "Elapsed: ";
		this.text_4.text = ".setlist";
		this.text_5.text = "Streamer Settings" + int_5;
	}

	// Token: 0x06002354 RID: 9044 RVA: 0x00112A88 File Offset: 0x00110C88
	public void method_10(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 1;
		this.text_3.text = "volume";
		this.text_2.text = "";
		this.text_4.text = "enable_cursor";
		this.text_5.text = "All Strums" + int_5;
		this.text_0.text = this.list_0[1].string_0;
		if (this.list_0.Count > 1)
		{
			this.float_0 = this.list_0[0].Single_0;
		}
		else
		{
			this.float_0 = 429f;
		}
		Color color = this.text_0.color;
		color.a = 133f;
		this.text_0.color = color;
	}

	// Token: 0x06002355 RID: 9045 RVA: 0x0001024A File Offset: 0x0000E44A
	private IEnumerator method_11()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(0);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x06002356 RID: 9046 RVA: 0x00112B7C File Offset: 0x00110D7C
	public void method_12()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "%";
		}
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_0 = 0;
		this.text_2.text = "0%";
		this.text_4.text = "0";
		Color color = this.text_0.color;
		color.a = 1f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[0].string_0;
			if (this.list_0.Count > 1)
			{
				this.float_0 = this.list_0[1].Single_0;
			}
		}
	}

	// Token: 0x06002357 RID: 9047 RVA: 0x00010292 File Offset: 0x0000E492
	private void method_13()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[0];
		this.method_52(-20);
	}

	// Token: 0x06002358 RID: 9048 RVA: 0x00112C68 File Offset: 0x00110E68
	public void method_14(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 0;
		this.int_2 = 0;
		this.text_3.text = "diff_bass";
		this.text_2.text = ".setlist";
		this.text_4.text = "Yes";
		this.text_5.text = "part guitar" + int_5;
		this.text_0.text = this.list_0[0].string_0;
		if (this.list_0.Count > 0)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 882f;
		}
		Color color = this.text_0.color;
		color.a = 760f;
		this.text_0.color = color;
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x00112D5C File Offset: 0x00110F5C
	private void method_15()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 1 >= this.list_0.Count)
		{
			this.float_0 = float.MaxValue;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 1].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_19());
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x00112DE0 File Offset: 0x00110FE0
	private void method_16()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0 += 0;
		if (this.int_0 + 1 >= this.list_0.Count)
		{
			this.float_0 = 118f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 1].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_21());
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x00112E64 File Offset: 0x00111064
	private void method_17()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 1527f);
			this.text_2.text = this.int_2 + "star_animation";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_34();
		}
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x00112F04 File Offset: 0x00111104
	public void method_18()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "song";
		}
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_0 = 0;
		this.text_2.text = "WRITING BADSONGS.TXT...";
		this.text_4.text = "Unknown Charter";
		Color color = this.text_0.color;
		color.a = 859f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[1].string_0;
			if (this.list_0.Count > 0)
			{
				this.float_0 = this.list_0[1].Single_0;
			}
		}
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x0001024A File Offset: 0x0000E44A
	private IEnumerator method_19()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(0);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x00112FF0 File Offset: 0x001111F0
	private void method_20()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 1169f);
			this.text_2.text = this.int_2 + "genre";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_29();
		}
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x0001023B File Offset: 0x0000E43B
	private IEnumerator method_21()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(1);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x00113090 File Offset: 0x00111290
	public void method_22()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "framerate";
		}
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_0 = 0;
		this.text_2.text = "Unlimited";
		this.text_4.text = "Gameplay";
		Color color = this.text_0.color;
		color.a = 1874f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[0].string_0;
			if (this.list_0.Count > 0)
			{
				this.float_0 = this.list_0[1].Single_0;
			}
		}
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x0011317C File Offset: 0x0011137C
	public void method_23(int int_5)
	{
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_2 = 0;
		this.text_2.text = "Rhythm Guitar";
		this.text_4.text = "Display Name";
		this.text_5.text = "Attempted to load non-existant background index {0}.\n{1}" + int_5;
	}

	// Token: 0x06002362 RID: 9058 RVA: 0x001131E0 File Offset: 0x001113E0
	public void method_24()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "Searching for";
		}
		this.int_2 = 1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.text_2.text = "Audio Backend";
		this.text_4.text = "Enabled";
		Color color = this.text_0.color;
		color.a = 1889f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[0].string_0;
			if (this.list_0.Count > 0)
			{
				this.float_0 = this.list_0[0].Single_0;
			}
		}
	}

	// Token: 0x06002363 RID: 9059 RVA: 0x001132CC File Offset: 0x001114CC
	private void method_25()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 506f);
			this.text_2.text = this.int_2 + "\\d+ = TS \\d+";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_29();
		}
	}

	// Token: 0x06002364 RID: 9060 RVA: 0x0011336C File Offset: 0x0011156C
	public void method_26(int int_5)
	{
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_2 = 1;
		this.text_2.text = "";
		this.text_4.text = "preview_start_time";
		this.text_5.text = "highway_lightning" + int_5;
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x001133D0 File Offset: 0x001115D0
	public void method_27()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "HUD";
		}
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_0 = 0;
		this.text_2.text = "{0:D2}:{1:D2}:{2:D2}";
		this.text_4.text = "Expert";
		Color color = this.text_0.color;
		color.a = 458f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[0].string_0;
			if (this.list_0.Count > 1)
			{
				this.float_0 = this.list_0[0].Single_0;
			}
		}
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x001134BC File Offset: 0x001116BC
	private void method_28()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 1708f);
			this.text_2.text = this.int_2 + "Create Profile";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_78();
		}
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x0011355C File Offset: 0x0011175C
	private void method_29()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 0 >= this.list_0.Count)
		{
			this.float_0 = 628f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 0].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_4());
	}

	// Token: 0x06002368 RID: 9064 RVA: 0x000102C7 File Offset: 0x0000E4C7
	public void method_30(int int_5)
	{
		this.text_1.text = "Full Song" + int_5 + "Ready";
		this.int_1 = 0;
		this.text_3.text = "Genre";
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x001135E0 File Offset: 0x001117E0
	private void method_31()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 0 >= this.list_0.Count)
		{
			this.float_0 = 1667f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 0].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_46());
	}

	// Token: 0x0600236A RID: 9066 RVA: 0x00113664 File Offset: 0x00111864
	public void method_32(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 1;
		this.text_3.text = "None";
		this.text_2.text = "drums_2";
		this.text_4.text = "A: 00:00:00";
		this.text_5.text = "rhythm" + int_5;
		this.text_0.text = this.list_0[1].string_0;
		if (this.list_0.Count > 1)
		{
			this.float_0 = this.list_0[0].Single_0;
		}
		else
		{
			this.float_0 = 1273f;
		}
		Color color = this.text_0.color;
		color.a = 709f;
		this.text_0.color = color;
	}

	// Token: 0x0600236B RID: 9067 RVA: 0x00113758 File Offset: 0x00111958
	public void method_33(int int_5)
	{
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_2 = 1;
		this.text_2.text = "Songs";
		this.text_4.text = "%";
		this.text_5.text = "song_export" + int_5;
	}

	// Token: 0x0600236C RID: 9068 RVA: 0x001137BC File Offset: 0x001119BC
	private void method_34()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 1 >= this.list_0.Count)
		{
			this.float_0 = 744f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 1].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_39());
	}

	// Token: 0x0600236D RID: 9069 RVA: 0x00113840 File Offset: 0x00111A40
	public void method_35(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 1;
		this.text_3.text = "/Image Backgrounds";
		this.text_2.text = "bad_note1";
		this.text_4.text = "game";
		this.text_5.text = "Camera" + int_5;
		this.text_0.text = this.list_0[1].string_0;
		if (this.list_0.Count > 0)
		{
			this.float_0 = this.list_0[0].Single_0;
		}
		else
		{
			this.float_0 = 1526f;
		}
		Color color = this.text_0.color;
		color.a = 508f;
		this.text_0.color = color;
	}

	// Token: 0x0600236E RID: 9070 RVA: 0x00113934 File Offset: 0x00111B34
	private void method_36()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 479f);
			this.text_2.text = this.int_2 + "bad_note5";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_31();
		}
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x001139D4 File Offset: 0x00111BD4
	private void method_37()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 0 >= this.list_0.Count)
		{
			this.float_0 = 1863f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 1].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_4());
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x0001023B File Offset: 0x0000E43B
	private IEnumerator method_38()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(1);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x0001024A File Offset: 0x0000E44A
	private IEnumerator method_39()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(0);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x00113A58 File Offset: 0x00111C58
	public void method_40()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "]";
		}
		this.int_2 = 1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.text_2.text = "";
		this.text_4.text = "beatscore";
		Color color = this.text_0.color;
		color.a = 1356f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[1].string_0;
			if (this.list_0.Count > 1)
			{
				this.float_0 = this.list_0[0].Single_0;
			}
		}
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x00010300 File Offset: 0x0000E500
	public void method_41(int int_5)
	{
		this.text_1.text = "allow_duplicate_songs" + int_5 + "^";
		this.int_1 = 0;
		this.text_3.text = "Guest";
	}

	// Token: 0x06002374 RID: 9076 RVA: 0x00010339 File Offset: 0x0000E539
	private void method_42()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[1];
		this.method_75(-73);
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x00113B44 File Offset: 0x00111D44
	public void method_43(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 0;
		this.int_2 = 0;
		this.text_3.text = "Genre = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
		this.text_2.text = "0";
		this.text_4.text = "diff_keys";
		this.text_5.text = "Start" + int_5;
		this.text_0.text = this.list_0[0].string_0;
		if (this.list_0.Count > 0)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 1197f;
		}
		Color color = this.text_0.color;
		color.a = 1588f;
		this.text_0.color = color;
	}

	// Token: 0x06002376 RID: 9078 RVA: 0x0001036E File Offset: 0x0000E56E
	private void method_44()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[0];
		this.method_2(-93);
	}

	// Token: 0x06002377 RID: 9079 RVA: 0x00113C38 File Offset: 0x00111E38
	public void method_45()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "Player";
		}
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_0 = 0;
		this.text_2.text = "Audio Device";
		this.text_4.text = "/";
		Color color = this.text_0.color;
		color.a = 1304f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[1].string_0;
			if (this.list_0.Count > 0)
			{
				this.float_0 = this.list_0[0].Single_0;
			}
		}
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x0001023B File Offset: 0x0000E43B
	private IEnumerator method_46()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(1);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x00113D24 File Offset: 0x00111F24
	public void method_47(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_1 = 0;
		this.int_2 = 0;
		this.text_3.text = "0%";
		this.text_2.text = "0%";
		this.text_4.text = "0";
		this.text_5.text = "/" + int_5;
		this.text_0.text = this.list_0[0].string_0;
		if (this.list_0.Count > 1)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = float.MaxValue;
		}
		Color color = this.text_0.color;
		color.a = 1f;
		this.text_0.color = color;
	}

	// Token: 0x0600237A RID: 9082 RVA: 0x0001024A File Offset: 0x0000E44A
	private IEnumerator method_48()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(0);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x00113E18 File Offset: 0x00112018
	private void method_49()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 1 >= this.list_0.Count)
		{
			this.float_0 = 702f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 0].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_11());
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x00113E9C File Offset: 0x0011209C
	public void method_50(int int_5)
	{
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_2 = 0;
		this.text_2.text = "Medium";
		this.text_4.text = "Vsync";
		this.text_5.text = "Keys - " + int_5;
	}

	// Token: 0x0600237D RID: 9085 RVA: 0x00113F00 File Offset: 0x00112100
	public void method_51()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "Create Profile";
		}
		this.int_2 = 1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.text_2.text = ".chart";
		this.text_4.text = "Sayori";
		Color color = this.text_0.color;
		color.a = 452f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[0].string_0;
			if (this.list_0.Count > 0)
			{
				this.float_0 = this.list_0[0].Single_0;
			}
		}
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x000103A3 File Offset: 0x0000E5A3
	public void method_52(int int_5)
	{
		this.text_1.text = "song_display" + int_5 + "song";
		this.int_1 = 0;
		this.text_3.text = "song";
	}

	// Token: 0x0600237F RID: 9087 RVA: 0x00113FEC File Offset: 0x001121EC
	public void method_53(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 0;
		this.text_3.text = "diff_rhythm";
		this.text_2.text = "songcache.bin";
		this.text_4.text = "]";
		this.text_5.text = "Export Current Song" + int_5;
		this.text_0.text = this.list_0[0].string_0;
		if (this.list_0.Count > 0)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 251f;
		}
		Color color = this.text_0.color;
		color.a = 1061f;
		this.text_0.color = color;
	}

	// Token: 0x06002380 RID: 9088 RVA: 0x001140E0 File Offset: 0x001122E0
	public void method_54(int int_5)
	{
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_2 = 1;
		this.text_2.text = "highway_shake";
		this.text_4.text = "rhythm";
		this.text_5.text = "song.ini" + int_5;
	}

	// Token: 0x06002381 RID: 9089 RVA: 0x000103DC File Offset: 0x0000E5DC
	private void Start()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[0];
		this.method_7(100);
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x00010411 File Offset: 0x0000E611
	private void method_55()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[0];
		this.method_77(-17);
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x00010446 File Offset: 0x0000E646
	private void method_56()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[1];
		this.method_52(112);
	}

	// Token: 0x06002384 RID: 9092 RVA: 0x00114144 File Offset: 0x00112344
	public void method_57(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 0;
		this.text_3.text = "\\d+ = B \\d+";
		this.text_2.text = "Artist";
		this.text_4.text = "Error: ";
		this.text_5.text = "nofail_enabled" + int_5;
		this.text_0.text = this.list_0[0].string_0;
		if (this.list_0.Count > 0)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 1718f;
		}
		Color color = this.text_0.color;
		color.a = 659f;
		this.text_0.color = color;
	}

	// Token: 0x06002385 RID: 9093 RVA: 0x0001047B File Offset: 0x0000E67B
	public void method_58(int int_5)
	{
		this.text_1.text = "Current High Score" + int_5 + "PreviewStart = [\\-\\+]?\\d+(\\.\\d+)?";
		this.int_1 = 1;
		this.text_3.text = "\r\n";
	}

	// Token: 0x06002386 RID: 9094 RVA: 0x00114238 File Offset: 0x00112438
	public void method_59(int int_5)
	{
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_2 = 0;
		this.text_2.text = "Discord: disconnect {0}: {1}";
		this.text_4.text = "video";
		this.text_5.text = "Discord: disconnect {0}: {1}" + int_5;
	}

	// Token: 0x06002387 RID: 9095 RVA: 0x000104B4 File Offset: 0x0000E6B4
	private void method_60()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[1];
		this.method_0(46);
	}

	// Token: 0x06002388 RID: 9096 RVA: 0x0011429C File Offset: 0x0011249C
	public void method_61(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 0;
		this.text_3.text = "";
		this.text_2.text = "pause_on_focus_lost";
		this.text_4.text = "{0}: {1}";
		this.text_5.text = "setlistwarning" + int_5;
		this.text_0.text = this.list_0[1].string_0;
		if (this.list_0.Count > 1)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 1416f;
		}
		Color color = this.text_0.color;
		color.a = 1405f;
		this.text_0.color = color;
	}

	// Token: 0x06002389 RID: 9097 RVA: 0x00114390 File Offset: 0x00112590
	public void method_62(int int_5)
	{
		this.int_3 = 0;
		this.int_0 = 0;
		this.int_4 = int_5;
		this.int_2 = 1;
		this.text_2.text = "Unknown Charter";
		this.text_4.text = "=";
		this.text_5.text = "video" + int_5;
	}

	// Token: 0x0600238A RID: 9098 RVA: 0x001143F4 File Offset: 0x001125F4
	private void method_63()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 1 >= this.list_0.Count)
		{
			this.float_0 = 337f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 1].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_5());
	}

	// Token: 0x0600238B RID: 9099 RVA: 0x000104E9 File Offset: 0x0000E6E9
	public void method_64(int int_5)
	{
		this.text_1.text = "Lead Guitar" + int_5 + "song";
		this.int_1 = 1;
		this.text_3.text = "You must restart, settings were changed";
	}

	// Token: 0x0600238C RID: 9100 RVA: 0x0001023B File Offset: 0x0000E43B
	private IEnumerator method_65()
	{
		PracticeUI.Class50 @class = new PracticeUI.Class50(1);
		@class.practiceUI_0 = this;
		return @class;
	}

	// Token: 0x0600238D RID: 9101 RVA: 0x00114478 File Offset: 0x00112678
	private void method_66()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 1678f);
			this.text_2.text = this.int_2 + "0";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_29();
		}
	}

	// Token: 0x0600238E RID: 9102 RVA: 0x00114518 File Offset: 0x00112718
	private void method_67()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 1 >= this.list_0.Count)
		{
			this.float_0 = 991f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 0].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_38());
	}

	// Token: 0x0600238F RID: 9103 RVA: 0x00010522 File Offset: 0x0000E722
	private void method_68()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[0];
		this.method_77(19);
	}

	// Token: 0x06002390 RID: 9104 RVA: 0x0011459C File Offset: 0x0011279C
	public void method_69(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 1;
		this.text_3.text = "";
		this.text_2.text = "Fullscreen";
		this.text_4.text = "background_video";
		this.text_5.text = "badsongs.txt" + int_5;
		this.text_0.text = this.list_0[0].string_0;
		if (this.list_0.Count > 0)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 1172f;
		}
		Color color = this.text_0.color;
		color.a = 676f;
		this.text_0.color = color;
	}

	// Token: 0x06002391 RID: 9105 RVA: 0x00114690 File Offset: 0x00112890
	private void method_70()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 1175f);
			this.text_2.text = this.int_2 + "Lyrics";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_67();
		}
	}

	// Token: 0x06002392 RID: 9106 RVA: 0x00114730 File Offset: 0x00112930
	public void method_71()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "Gameplay";
		}
		this.int_2 = 1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.text_2.text = "0%";
		this.text_4.text = "\n";
		Color color = this.text_0.color;
		color.a = 1892f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[0].string_0;
			if (this.list_0.Count > 0)
			{
				this.float_0 = this.list_0[0].Single_0;
			}
		}
	}

	// Token: 0x06002393 RID: 9107 RVA: 0x00010557 File Offset: 0x0000E757
	public void method_72(int int_5)
	{
		this.text_1.text = "mute_volume" + int_5 + "N/A";
		this.int_1 = 1;
		this.text_3.text = "Name = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
	}

	// Token: 0x06002394 RID: 9108 RVA: 0x0011481C File Offset: 0x00112A1C
	private void method_73()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0++;
		if (this.int_0 + 0 >= this.list_0.Count)
		{
			this.float_0 = 1999f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 0].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_4());
	}

	// Token: 0x06002395 RID: 9109 RVA: 0x001148A0 File Offset: 0x00112AA0
	private void method_74()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 680f);
			this.text_2.text = this.int_2 + "video";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_34();
		}
	}

	// Token: 0x06002397 RID: 9111 RVA: 0x000105B3 File Offset: 0x0000E7B3
	public void method_75(int int_5)
	{
		this.text_1.text = "" + int_5 + "preview_volume";
		this.int_1 = 1;
		this.text_3.text = "These folders contain charts that another song has (duplicate charts)!";
	}

	// Token: 0x06002398 RID: 9112 RVA: 0x00114940 File Offset: 0x00112B40
	private void FixedUpdate()
	{
		if (this.int_3 < this.basePlayer_0.int_8)
		{
			this.int_3 = this.basePlayer_0.int_8;
			this.int_2 = (int)((float)this.int_3 / (float)this.int_4 * 100f);
			this.text_2.text = this.int_2 + "%";
			this.text_4.text = this.int_3.ToString();
		}
		if (this.gameManager.double_1 >= (double)this.float_0)
		{
			this.method_15();
		}
	}

	// Token: 0x06002399 RID: 9113 RVA: 0x000105EC File Offset: 0x0000E7EC
	private void method_76()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[1];
		this.method_72(-72);
	}

	// Token: 0x0600239A RID: 9114 RVA: 0x00010621 File Offset: 0x0000E821
	public void method_77(int int_5)
	{
		this.text_1.text = "Song Length" + int_5 + "Error reading profile file!";
		this.int_1 = 0;
		this.text_3.text = ".mp3";
	}

	// Token: 0x0600239B RID: 9115 RVA: 0x001149E0 File Offset: 0x00112BE0
	private void method_78()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.int_0 += 0;
		if (this.int_0 + 1 >= this.list_0.Count)
		{
			this.float_0 = 702f;
		}
		else
		{
			this.float_0 = this.list_0[this.int_0 + 1].Single_0;
		}
		this.coroutine_0 = base.StartCoroutine(this.method_38());
	}

	// Token: 0x0600239C RID: 9116 RVA: 0x00114A64 File Offset: 0x00112C64
	public void method_79(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 0;
		this.int_2 = 0;
		this.text_3.text = "Menu Music";
		this.text_2.text = "Rhythm Guitar";
		this.text_4.text = "No Part";
		this.text_5.text = "GETTING FOLDERS..." + int_5;
		this.text_0.text = this.list_0[1].string_0;
		if (this.list_0.Count > 1)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 1958f;
		}
		Color color = this.text_0.color;
		color.a = 1644f;
		this.text_0.color = color;
	}

	// Token: 0x0600239D RID: 9117 RVA: 0x0001065A File Offset: 0x0000E85A
	private void method_80()
	{
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		this.basePlayer_0 = this.gameManager.playerObjects[0];
		this.method_58(-10);
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x00114B58 File Offset: 0x00112D58
	public void method_81(List<GClass22> list_1, int int_5)
	{
		this.list_0 = list_1;
		this.int_3 = 1;
		this.int_0 = 1;
		this.int_4 = int_5;
		this.int_1 = 1;
		this.int_2 = 0;
		this.text_3.text = "Quit";
		this.text_2.text = "Press Escape to cancel";
		this.text_4.text = "particles";
		this.text_5.text = "Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"" + int_5;
		this.text_0.text = this.list_0[0].string_0;
		if (this.list_0.Count > 0)
		{
			this.float_0 = this.list_0[1].Single_0;
		}
		else
		{
			this.float_0 = 1282f;
		}
		Color color = this.text_0.color;
		color.a = 1498f;
		this.text_0.color = color;
	}

	// Token: 0x0600239F RID: 9119 RVA: 0x00114C4C File Offset: 0x00112E4C
	public void method_82()
	{
		if (this.int_2 > this.int_1)
		{
			this.int_1 = this.int_2;
			this.text_3.text = this.int_1 + "</color>";
		}
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_0 = 0;
		this.text_2.text = "Video Settings";
		this.text_4.text = "Guest";
		Color color = this.text_0.color;
		color.a = 1433f;
		this.text_0.color = color;
		if (this.list_0 != null)
		{
			this.text_0.text = this.list_0[0].string_0;
			if (this.list_0.Count > 0)
			{
				this.float_0 = this.list_0[0].Single_0;
			}
		}
	}

	// Token: 0x060023A0 RID: 9120 RVA: 0x0001068F File Offset: 0x0000E88F
	public void method_83(int int_5)
	{
		this.text_1.text = "GHLive Guitar - " + int_5 + ":";
		this.int_1 = 1;
		this.text_3.text = "";
	}

	// Token: 0x0400058D RID: 1421
	private List<GClass22> list_0;

	// Token: 0x0400058E RID: 1422
	private int int_0;

	// Token: 0x0400058F RID: 1423
	public Text text_0;

	// Token: 0x04000590 RID: 1424
	public Text text_1;

	// Token: 0x04000591 RID: 1425
	public Text text_2;

	// Token: 0x04000592 RID: 1426
	public Text text_3;

	// Token: 0x04000593 RID: 1427
	public Text text_4;

	// Token: 0x04000594 RID: 1428
	public Text text_5;

	// Token: 0x04000595 RID: 1429
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(0.016f);

	// Token: 0x04000596 RID: 1430
	private Coroutine coroutine_0;

	// Token: 0x04000597 RID: 1431
	[SerializeField]
	private GameManager gameManager;

	// Token: 0x04000598 RID: 1432
	private BasePlayer basePlayer_0;

	// Token: 0x04000599 RID: 1433
	private int int_1;

	// Token: 0x0400059A RID: 1434
	private int int_2;

	// Token: 0x0400059B RID: 1435
	private int int_3;

	// Token: 0x0400059C RID: 1436
	private int int_4;

	// Token: 0x0400059D RID: 1437
	private float float_0 = float.MaxValue;
}
