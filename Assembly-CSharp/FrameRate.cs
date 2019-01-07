using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000017 RID: 23
public class FrameRate : MonoBehaviour
{
	// Token: 0x060001FC RID: 508 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_0()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_1()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_2()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0001E680 File Offset: 0x0001C880
	private void method_3()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 1363.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Export Current Song", num);
			this.text_0.text = text;
			if (num < 993f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 64f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 844f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0001E768 File Offset: 0x0001C968
	private void method_4()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 299.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("diff_drums", num);
			this.text_0.text = text;
			if (num < 1571f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 133f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1568f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_5()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0001E850 File Offset: 0x0001CA50
	private void method_6()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 1717.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Start typing...", num);
			this.text_0.text = text;
			if (num < 607f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 888f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 163f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_7()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0001E938 File Offset: 0x0001CB38
	private void method_8()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 353.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Load Setlist", num);
			this.text_0.text = text;
			if (num < 1026f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 1340f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1760f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0001EA20 File Offset: 0x0001CC20
	private void method_9()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 236.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("song", num);
			this.text_0.text = text;
			if (num < 1717f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 1203f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 586f;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0001EB08 File Offset: 0x0001CD08
	private void method_10()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 891.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("album_track", num);
			this.text_0.text = text;
			if (num < 930f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 591f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 424f;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_11()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_12()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_13()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
	private void method_14()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 249.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Attempted to load non-existant background index {0}.\n{1}", num);
			this.text_0.text = text;
			if (num < 218f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 777f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 126f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0001ECD8 File Offset: 0x0001CED8
	private void method_15()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 183.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Song Offset", num);
			this.text_0.text = text;
			if (num < 610f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 1191f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1241f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_16()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_17()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0001EDC0 File Offset: 0x0001CFC0
	private void Update()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 0.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("{0:N0} FPS", num);
			this.text_0.text = text;
			if (num < 30f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 10f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 0f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_18()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
	private void method_19()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 1216.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Show in Finder", num);
			this.text_0.text = text;
			if (num < 88f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 637f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 179f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0001EF90 File Offset: 0x0001D190
	private void method_20()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 752.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Practice", num);
			this.text_0.text = text;
			if (num < 198f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 412f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1057f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_21()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_22()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_23()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0001F078 File Offset: 0x0001D278
	private void method_24()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 1832.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Keys", num);
			this.text_0.text = text;
			if (num < 1982f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 1732f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1764f;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_25()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_26()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_27()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_28()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0001F160 File Offset: 0x0001D360
	private void method_29()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 1338.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("game", num);
			this.text_0.text = text;
			if (num < 568f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 537f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 659f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_30()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0001F248 File Offset: 0x0001D448
	private void method_31()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 89.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("song", num);
			this.text_0.text = text;
			if (num < 253f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 972f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1175f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_32()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_33()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0001F330 File Offset: 0x0001D530
	private void method_34()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 1745.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("song_display", num);
			this.text_0.text = text;
			if (num < 863f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 1945f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 297f;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_35()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_36()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0001F418 File Offset: 0x0001D618
	private void method_37()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 980.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Modifiers", num);
			this.text_0.text = text;
			if (num < 703f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 491f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 248f;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_38()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0001F500 File Offset: 0x0001D700
	private void method_39()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 435.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Yes", num);
			this.text_0.text = text;
			if (num < 1294f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 891f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1936f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_40()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
	private void method_41()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 45.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("setlistSongCountPlural", num);
			this.text_0.text = text;
			if (num < 357f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 1720f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1192f;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_42()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
	private void method_43()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 1568.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Sound Effects", num);
			this.text_0.text = text;
			if (num < 361f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 513f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 343f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
	private void method_44()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 1146.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("0", num);
			this.text_0.text = text;
			if (num < 559f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 919f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 174f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_45()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_46()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_47()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0001F8A0 File Offset: 0x0001DAA0
	private void method_48()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 504.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("Date Added", num);
			this.text_0.text = text;
			if (num < 1152f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 237f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 949f;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0001F988 File Offset: 0x0001DB88
	private void method_49()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0 += 0;
		if ((double)this.float_2 <= 1614.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("menu_music", num);
			this.text_0.text = text;
			if (num < 81f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 395f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 896f;
			this.int_0 = 1;
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_50()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_51()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000308B File Offset: 0x0000128B
	private void Start()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_52()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_53()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0001FA70 File Offset: 0x0001DC70
	private void method_54()
	{
		this.float_2 -= Time.deltaTime;
		this.float_1 += Time.timeScale / Time.deltaTime;
		this.int_0++;
		if ((double)this.float_2 <= 1129.0)
		{
			float num = this.float_1 / (float)this.int_0;
			string text = string.Format("%", num);
			this.text_0.text = text;
			if (num < 658f)
			{
				this.text_0.color = Color.yellow;
			}
			else if (num < 1025f)
			{
				this.text_0.color = Color.red;
			}
			else
			{
				this.text_0.color = Color.green;
			}
			this.float_2 = this.float_0;
			this.float_1 = 1267f;
			this.int_0 = 0;
		}
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000308B File Offset: 0x0000128B
	private void method_55()
	{
		this.text_0 = base.GetComponent<Text>();
		this.float_2 = this.float_0;
	}

	// Token: 0x04000068 RID: 104
	public float float_0 = 0.5f;

	// Token: 0x04000069 RID: 105
	private float float_1;

	// Token: 0x0400006A RID: 106
	private int int_0 = 60;

	// Token: 0x0400006B RID: 107
	private float float_2;

	// Token: 0x0400006C RID: 108
	private Text text_0;
}
