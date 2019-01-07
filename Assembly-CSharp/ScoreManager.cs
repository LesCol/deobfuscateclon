using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000B7 RID: 183
public class ScoreManager : MonoBehaviour
{
	// Token: 0x060023C4 RID: 9156 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_0()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x000106EE File Offset: 0x0000E8EE
	private IEnumerator method_1()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x000106FD File Offset: 0x0000E8FD
	private void method_2()
	{
		this.method_90();
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x00115518 File Offset: 0x00113718
	private void method_3()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_37(this.int_4);
			this.spriteFont_0.method_44(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_8(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_4()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_5()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x00115578 File Offset: 0x00113778
	private void method_6()
	{
		this.basePlayer_0 = GameObject.Find("This will take a while. Are you sure?").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_0();
		this.int_0 = new int[3];
		this.int_1 = new int[2];
		this.int_2 = new int[6];
		this.int_3 = new int[5];
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x00010705 File Offset: 0x0000E905
	private void method_7()
	{
		this.method_97();
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_8()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x001155DC File Offset: 0x001137DC
	private void method_9()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 1; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 38 && this.int_6 >= 25)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_11();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 117 && this.int_6 < -126)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_75();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x001156F0 File Offset: 0x001138F0
	private void method_10()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_40(this.int_4);
			this.spriteFont_0.method_37(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_40(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_11()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_12()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_13()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_14()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x0001072B File Offset: 0x0000E92B
	private void Update()
	{
		this.method_71();
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x00115750 File Offset: 0x00113950
	private void method_15()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 0; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -19 && this.int_6 >= 13)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_0();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -119 && this.int_6 < -34)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_1();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_16()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x00010733 File Offset: 0x0000E933
	private void method_17()
	{
		this.method_89();
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x0001073B File Offset: 0x0000E93B
	private void method_18()
	{
		this.method_76();
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_19()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x00115864 File Offset: 0x00113A64
	private void method_20()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_5(this.int_4);
			this.spriteFont_0.method_15(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_46(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023DA RID: 9178 RVA: 0x001158C4 File Offset: 0x00113AC4
	private void method_21()
	{
		this.basePlayer_0 = GameObject.Find("Custom Content").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_47();
		this.int_0 = new int[3];
		this.int_1 = new int[8];
		this.int_2 = new int[4];
		this.int_3 = new int[6];
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_22()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x00115928 File Offset: 0x00113B28
	private void FixedUpdate()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_16(this.int_4);
			this.spriteFont_0.method_16(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_97(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x00115988 File Offset: 0x00113B88
	private void method_23()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_25(this.int_4);
			this.spriteFont_0.method_14(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_86(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x001159E8 File Offset: 0x00113BE8
	private void method_24()
	{
		this.basePlayer_0 = GameObject.Find("Scan Songs").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_72();
		this.int_0 = new int[0];
		this.int_1 = new int[6];
		this.int_2 = new int[3];
		this.int_3 = new int[2];
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_25()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x00115A4C File Offset: 0x00113C4C
	private void method_26()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_23(this.int_4);
			this.spriteFont_0.method_22(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_51(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x00115AAC File Offset: 0x00113CAC
	private void method_27()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_30(this.int_4);
			this.spriteFont_0.method_15(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_95(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x00115B0C File Offset: 0x00113D0C
	private void method_28()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 1; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -33 && this.int_6 >= -68)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_95();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -122 && this.int_6 < -59)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_16();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x00115C20 File Offset: 0x00113E20
	private void method_29()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_8(this.int_4);
			this.spriteFont_0.method_37(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_19(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x00115C80 File Offset: 0x00113E80
	private void method_30()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_37(this.int_4);
			this.spriteFont_0.method_58(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_76(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x000106EE File Offset: 0x0000E8EE
	private IEnumerator method_31()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x00115CE0 File Offset: 0x00113EE0
	private void method_32()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 1; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -100 && this.int_6 >= 66)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_11();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 88 && this.int_6 < 33)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_57();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_33()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x00115DF4 File Offset: 0x00113FF4
	private void method_34()
	{
		this.basePlayer_0 = GameObject.Find("").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_25();
		this.int_0 = new int[6];
		this.int_1 = new int[6];
		this.int_2 = new int[4];
		this.int_3 = new int[5];
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x000106EE File Offset: 0x0000E8EE
	private IEnumerator method_35()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x00115E58 File Offset: 0x00114058
	private void method_36()
	{
		this.basePlayer_0 = GameObject.Find("Lyrics").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_5();
		this.int_0 = new int[2];
		this.int_1 = new int[4];
		this.int_2 = new int[3];
		this.int_3 = new int[7];
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x00115EBC File Offset: 0x001140BC
	private void method_37()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 0; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 72 && this.int_6 >= 109)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_11();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -31 && this.int_6 < -109)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_12();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x00115FD0 File Offset: 0x001141D0
	private void method_38()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_44(this.int_4);
			this.spriteFont_0.method_16(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_51(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x00116030 File Offset: 0x00114230
	private void method_39()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 0; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -94 && this.int_6 >= -41)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_69();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -62 && this.int_6 < -52)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_31();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x00010743 File Offset: 0x0000E943
	private void method_40()
	{
		this.method_91();
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x0001073B File Offset: 0x0000E93B
	private void method_41()
	{
		this.method_76();
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x00116144 File Offset: 0x00114344
	private void method_42()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_59(this.int_4);
			this.spriteFont_0.method_59(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_23(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_43()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x0001074B File Offset: 0x0000E94B
	private void method_44()
	{
		this.method_86();
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x001161FC File Offset: 0x001143FC
	private void method_45()
	{
		this.basePlayer_0 = GameObject.Find(".jpg").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_13();
		this.int_0 = new int[8];
		this.int_1 = new int[4];
		this.int_2 = new int[1];
		this.int_3 = new int[7];
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x00116260 File Offset: 0x00114460
	private void method_46()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 1; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -22 && this.int_6 >= -10)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_72();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -13 && this.int_6 < -25)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_22();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023F6 RID: 9206 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_47()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_48()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x000106EE File Offset: 0x0000E8EE
	private IEnumerator method_49()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x060023F9 RID: 9209 RVA: 0x00116374 File Offset: 0x00114574
	private void method_50()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 0; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 117 && this.int_6 >= 54)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_25();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 40 && this.int_6 < 39)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_48();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x00116488 File Offset: 0x00114688
	private void Start()
	{
		this.basePlayer_0 = GameObject.Find("Game Manager").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_60();
		this.int_0 = new int[4];
		this.int_1 = new int[4];
		this.int_2 = new int[4];
		this.int_3 = new int[4];
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x001164EC File Offset: 0x001146EC
	private void method_51()
	{
		this.basePlayer_0 = GameObject.Find("volume").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_4();
		this.int_0 = new int[8];
		this.int_1 = new int[4];
		this.int_2 = new int[4];
		this.int_3 = new int[8];
	}

	// Token: 0x060023FC RID: 9212 RVA: 0x00116550 File Offset: 0x00114750
	private void method_52()
	{
		this.basePlayer_0 = GameObject.Find("Gameplay").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_33();
		this.int_0 = new int[4];
		this.int_1 = new int[0];
		this.int_2 = new int[6];
		this.int_3 = new int[6];
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x001165B4 File Offset: 0x001147B4
	private void method_53()
	{
		this.basePlayer_0 = GameObject.Find("<color=#FFFF04FF>").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_0();
		this.int_0 = new int[4];
		this.int_1 = new int[7];
		this.int_2 = new int[3];
		this.int_3 = new int[6];
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x00116618 File Offset: 0x00114818
	private void method_54()
	{
		this.basePlayer_0 = GameObject.Find("Quit").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_13();
		this.int_0 = new int[1];
		this.int_1 = new int[1];
		this.int_2 = new int[4];
		this.int_3 = new int[6];
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x0011667C File Offset: 0x0011487C
	private void method_55()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_51(this.int_4);
			this.spriteFont_0.method_38(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_76(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x001166DC File Offset: 0x001148DC
	private void method_56()
	{
		this.basePlayer_0 = GameObject.Find("No").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_85();
		this.int_0 = new int[2];
		this.int_1 = new int[3];
		this.int_2 = new int[4];
		this.int_3 = new int[3];
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x000106EE File Offset: 0x0000E8EE
	private IEnumerator method_57()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_58()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x00116740 File Offset: 0x00114940
	private void method_59()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_49(this.int_4);
			this.spriteFont_0.method_5(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_95(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_60()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_61()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_62()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x000106EE File Offset: 0x0000E8EE
	private IEnumerator method_63()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x001167A0 File Offset: 0x001149A0
	private void method_64()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_28(this.int_4);
			this.spriteFont_0.method_38(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_45(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_65()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x00116800 File Offset: 0x00114A00
	private void method_66()
	{
		this.basePlayer_0 = GameObject.Find("Full Song").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_19();
		this.int_0 = new int[6];
		this.int_1 = new int[6];
		this.int_2 = new int[6];
		this.int_3 = new int[7];
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x0001072B File Offset: 0x0000E92B
	private void method_67()
	{
		this.method_71();
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x00116864 File Offset: 0x00114A64
	private void method_68()
	{
		this.basePlayer_0 = GameObject.Find("").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_60();
		this.int_0 = new int[1];
		this.int_1 = new int[2];
		this.int_2 = new int[6];
		this.int_3 = new int[5];
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_69()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x001168C8 File Offset: 0x00114AC8
	private void method_70()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 1; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -8 && this.int_6 >= 42)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_11();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 76 && this.int_6 < -13)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_62();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x001169DC File Offset: 0x00114BDC
	private void method_71()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 0; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 30 && this.int_6 >= 30)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_60();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 30 && this.int_6 < 30)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_35();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_72()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_73()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x00116AF0 File Offset: 0x00114CF0
	private void method_74()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_16(this.int_4);
			this.spriteFont_0.method_56(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_76(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x0001070D File Offset: 0x0000E90D
	private IEnumerator method_75()
	{
		ScoreManager.Class51 @class = new ScoreManager.Class51(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x00116B50 File Offset: 0x00114D50
	private void method_76()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 0; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 57 && this.int_6 >= 56)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_69();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -28 && this.int_6 < 20)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_43();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x00116C64 File Offset: 0x00114E64
	private void method_77()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 0; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -111 && this.int_6 >= -103)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_0();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 114 && this.int_6 < -71)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_12();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x00116D78 File Offset: 0x00114F78
	private void method_78()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_21(this.int_4);
			this.spriteFont_0.method_57(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_86(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x00010753 File Offset: 0x0000E953
	private void method_79()
	{
		this.method_9();
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x00116DD8 File Offset: 0x00114FD8
	private void method_80()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 1; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -103 && this.int_6 >= 61)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_47();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -74 && this.int_6 < -35)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_16();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x00116EEC File Offset: 0x001150EC
	private void method_81()
	{
		this.basePlayer_0 = GameObject.Find("difficulty_name_").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_19();
		this.int_0 = new int[7];
		this.int_1 = new int[2];
		this.int_2 = new int[3];
		this.int_3 = new int[7];
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x00116F50 File Offset: 0x00115150
	private void method_82()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 1; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -74 && this.int_6 >= -78)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_33();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 43 && this.int_6 < 24)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_63();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x0001075B File Offset: 0x0000E95B
	private void method_83()
	{
		this.method_39();
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x00117064 File Offset: 0x00115264
	private void method_84()
	{
		this.basePlayer_0 = GameObject.Find("<color=#FFFF04FF>").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_85();
		this.int_0 = new int[0];
		this.int_1 = new int[8];
		this.int_2 = new int[1];
		this.int_3 = new int[7];
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_85()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x001170C8 File Offset: 0x001152C8
	private void method_86()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 1; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 0 && this.int_6 >= -120)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_85();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 101 && this.int_6 < 16)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_16();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x001171DC File Offset: 0x001153DC
	private void method_87()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 0; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 60 && this.int_6 >= -118)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_14();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 10 && this.int_6 < 120)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_31();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x001172F0 File Offset: 0x001154F0
	private void method_88()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_2(this.int_4);
			this.spriteFont_0.method_44(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_5(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x00117350 File Offset: 0x00115550
	private void method_89()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 0; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -18 && this.int_6 >= 3)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_61();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -13 && this.int_6 < -59)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_12();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x00117464 File Offset: 0x00115664
	private void method_90()
	{
		int num = this.int_6;
		this.int_6 = 1;
		for (int i = 1; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < -126 && this.int_6 >= -10)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_60();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -13 && this.int_6 < 27)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_1();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x00117578 File Offset: 0x00115778
	private void method_91()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 1; i < this.basePlayer_0.Length; i += 0)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 85 && this.int_6 >= 89)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_13();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= -71 && this.int_6 < -47)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_31();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x00010763 File Offset: 0x0000E963
	private void method_92()
	{
		this.method_46();
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x000106DF File Offset: 0x0000E8DF
	private IEnumerator method_93()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(0);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x0011768C File Offset: 0x0011588C
	private void method_94()
	{
		if (!FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			this.spriteFont_1.method_19(this.int_4);
			this.spriteFont_0.method_48(this.int_6);
			if (!GlobalVariables.instance.isPracticeEnabled)
			{
				this.starProgress_0.method_28(this.int_4 - this.int_5);
			}
		}
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_95()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x001176EC File Offset: 0x001158EC
	private void method_96()
	{
		this.basePlayer_0 = GameObject.Find("sp_awarded").GetComponent<GameManager>().playerObjects;
		this.ienumerator_0 = this.method_19();
		this.int_0 = new int[6];
		this.int_1 = new int[8];
		this.int_2 = new int[0];
		this.int_3 = new int[8];
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x00117750 File Offset: 0x00115950
	private void method_97()
	{
		int num = this.int_6;
		this.int_6 = 0;
		for (int i = 0; i < this.basePlayer_0.Length; i++)
		{
			BasePlayer basePlayer = this.basePlayer_0[i];
			int num2 = this.int_1[i];
			this.int_1[i] = basePlayer.int_6;
			this.int_4 += basePlayer.int_6 - num2;
			this.int_6 += basePlayer.int_4;
			int num3 = this.int_2[i];
			this.int_2[i] = basePlayer.int_9;
			this.int_5 += basePlayer.int_9 - num3;
		}
		if (num < 4 && this.int_6 >= 12)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_14();
			base.StartCoroutine(this.ienumerator_0);
			return;
		}
		if (num >= 111 && this.int_6 < 80)
		{
			base.StopCoroutine(this.ienumerator_0);
			this.ienumerator_0 = this.method_58();
			base.StartCoroutine(this.ienumerator_0);
		}
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x0001071C File Offset: 0x0000E91C
	private IEnumerator method_98()
	{
		ScoreManager.Class52 @class = new ScoreManager.Class52(1);
		@class.scoreManager_0 = this;
		return @class;
	}

	// Token: 0x040005A3 RID: 1443
	public Transform transform_0;

	// Token: 0x040005A4 RID: 1444
	private Vector3 vector3_0 = new Vector3(-0.07f, 0.36f, 0f);

	// Token: 0x040005A5 RID: 1445
	private Vector3 vector3_1 = new Vector3(-0.07f, 0.28f, 0f);

	// Token: 0x040005A6 RID: 1446
	private int[] int_0;

	// Token: 0x040005A7 RID: 1447
	private int[] int_1;

	// Token: 0x040005A8 RID: 1448
	private int[] int_2;

	// Token: 0x040005A9 RID: 1449
	private int[] int_3;

	// Token: 0x040005AA RID: 1450
	private BasePlayer[] basePlayer_0;

	// Token: 0x040005AB RID: 1451
	public int int_4;

	// Token: 0x040005AC RID: 1452
	public int int_5;

	// Token: 0x040005AD RID: 1453
	public int int_6;

	// Token: 0x040005AE RID: 1454
	private IEnumerator ienumerator_0;

	// Token: 0x040005AF RID: 1455
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(0.02f);

	// Token: 0x040005B0 RID: 1456
	public SpriteFont spriteFont_0;

	// Token: 0x040005B1 RID: 1457
	public SpriteFont spriteFont_1;

	// Token: 0x040005B2 RID: 1458
	public StarProgress starProgress_0;
}
