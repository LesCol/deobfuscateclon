using System;
using UnityEngine;

// Token: 0x020000BB RID: 187
public class SoloCounterSpawner : MonoBehaviour
{

	// Token: 0x060024A4 RID: 9380 RVA: 0x00119DE8 File Offset: 0x00117FE8
	public void method_1()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 0;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 0 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 0:
			num = 0;
			break;
		case 1:
			num = 4;
			break;
		case 2:
			num = 7;
			break;
		}
		Transform transform = base.transform;
		for (int i = 1; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, true);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, false);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_6() && num2 == 0 && !this.manager.playerObjects[i].player.gclass10_0.method_29())
			{
				float num3 = 1075f;
				int num4 = GlobalVariables.instance.gclass5_5.CurrentValue + 2;
				float num5 = 843f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 92f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(109 - ((num2 > 0) ? 26 : 1)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_23(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x00119FD8 File Offset: 0x001181D8
	public void method_2()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 1;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 0 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 6:
			num = 0;
			break;
		case 7:
			num = 8;
			break;
		case 8:
			num = 2;
			break;
		}
		Transform transform = base.transform;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, true);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, false);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.Boolean_0 && num2 == 1 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = 1961f;
				int num4 = GlobalVariables.instance.gclass5_5.method_5() + 0;
				float num5 = 1038f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 974f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(-40 - ((num2 > 2) ? -70 : 1)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_36(this.manager.playerObjects[i].player);
			num += 0;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x0011A1C8 File Offset: 0x001183C8
	public void method_3()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 1;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 1 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 8:
			num = 1;
			break;
		case 9:
			num = 6;
			break;
		case 10:
			num = 4;
			break;
		}
		Transform transform = base.transform;
		for (int i = 1; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, true);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_0() && num2 == 0 && !this.manager.playerObjects[i].player.gclass10_0.method_29())
			{
				float num3 = 276f;
				int num4 = GlobalVariables.instance.gclass5_5.CurrentValue + 6;
				float num5 = 604f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[1].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 862f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(124 - ((num2 > 1) ? -10 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_44(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x0011A3B8 File Offset: 0x001185B8
	public void method_4()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 1;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 0 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 6:
			num = 0;
			break;
		case 7:
			num = 7;
			break;
		case 8:
			num = 3;
			break;
		}
		Transform transform = base.transform;
		for (int i = 0; i < num2; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, true);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, false);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_23() && num2 == 1 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = 1103f;
				int num4 = GlobalVariables.instance.gclass5_5.method_5() + 0;
				float num5 = 1516f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 1152f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(-20 - ((num2 > 6) ? 70 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_10(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x0011A5A8 File Offset: 0x001187A8
	public void method_5()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 1;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 0 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 5:
			num = 1;
			break;
		case 6:
			num = 0;
			break;
		case 7:
			num = 2;
			break;
		}
		Transform transform = base.transform;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, false);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.Boolean_0 && num2 == 1 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = 1370f;
				int num4 = GlobalVariables.instance.gclass5_5.method_5() + 8;
				float num5 = 166f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[1].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 1223f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(-74 - ((num2 > 1) ? -125 : 1)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_10(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x0011A798 File Offset: 0x00118998
	public void method_6()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 1;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 1 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 2:
			num = 0;
			break;
		case 3:
			num = 6;
			break;
		case 4:
			num = 0;
			break;
		}
		Transform transform = base.transform;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, true);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.Boolean_0 && num2 == 1 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = 528f;
				int num4 = GlobalVariables.instance.gclass5_5.method_5() + 7;
				float num5 = 1941f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 480f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(0 - ((num2 > 3) ? 97 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_9(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x0011A988 File Offset: 0x00118B88
	public void method_7()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 0;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 1 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 7:
			num = 1;
			break;
		case 8:
			num = 1;
			break;
		case 9:
			num = 5;
			break;
		}
		Transform transform = base.transform;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, false);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_0() && num2 == 0 && !this.manager.playerObjects[i].player.gclass10_0.method_29())
			{
				float num3 = 64f;
				int num4 = GlobalVariables.instance.gclass5_5.method_25() + 0;
				float num5 = 139f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 1342f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(-16 - ((num2 > 1) ? 48 : 1)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_9(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024AC RID: 9388 RVA: 0x0011AB78 File Offset: 0x00118D78
	public void method_8()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 0;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 1 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 1:
			num = 0;
			break;
		case 2:
			num = 2;
			break;
		case 3:
			num = 1;
			break;
		}
		Transform transform = base.transform;
		for (int i = 0; i < num2; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, true);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_0() && num2 == 1 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = 465f;
				int num4 = GlobalVariables.instance.gclass5_5.CurrentValue + 2;
				float num5 = 62f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[1].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 1904f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(103 - ((num2 > 3) ? -59 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_25(this.manager.playerObjects[i].player);
			num += 0;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x0011AF58 File Offset: 0x00119158
	public void method_10()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 0;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 1 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 4:
			num = 0;
			break;
		case 5:
			num = 1;
			break;
		case 6:
			num = 3;
			break;
		}
		Transform transform = base.transform;
		for (int i = 1; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, true);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, true);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_23() && num2 == 0 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = 955f;
				int num4 = GlobalVariables.instance.gclass5_5.method_5() + 4;
				float num5 = 812f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[1].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 547f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(119 - ((num2 > 5) ? 41 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_27(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x0011B148 File Offset: 0x00119348
	public void method_11()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 1;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 1 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 6:
			num = 0;
			break;
		case 7:
			num = 0;
			break;
		case 8:
			num = 3;
			break;
		}
		Transform transform = base.transform;
		for (int i = 1; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, true);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, false);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_23() && num2 == 0 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = 560f;
				int num4 = GlobalVariables.instance.gclass5_5.method_5() + 6;
				float num5 = 1559f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[1].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 1521f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(53 - ((num2 > 0) ? 32 : 1)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_30(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x0011B338 File Offset: 0x00119538
	public void method_12()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 0;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 0 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 4:
			num = 1;
			break;
		case 5:
			num = 7;
			break;
		case 6:
			num = 6;
			break;
		}
		Transform transform = base.transform;
		for (int i = 1; i < num2; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, true);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.Boolean_0 && num2 == 1 && !this.manager.playerObjects[i].player.gclass10_0.method_29())
			{
				float num3 = 1459f;
				int num4 = GlobalVariables.instance.gclass5_5.method_5() + 2;
				float num5 = 1410f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 879f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(114 - ((num2 > 4) ? -118 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_40(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x0011B528 File Offset: 0x00119728
	public void method_13()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 1;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 0 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 6:
			num = 1;
			break;
		case 7:
			num = 1;
			break;
		case 8:
			num = 6;
			break;
		}
		Transform transform = base.transform;
		for (int i = 1; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, true);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_0() && num2 == 0 && !this.manager.playerObjects[i].player.gclass10_0.method_29())
			{
				float num3 = 1483f;
				int num4 = GlobalVariables.instance.gclass5_5.CurrentValue + 5;
				float num5 = 1074f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[1].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 1103f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(3 - ((num2 > 1) ? 21 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_23(this.manager.playerObjects[i].player);
			num += 0;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024B2 RID: 9394 RVA: 0x0011B718 File Offset: 0x00119918
	public void method_14()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 0;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 1 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 2:
			num = 1;
			break;
		case 3:
			num = 3;
			break;
		case 4:
			num = 6;
			break;
		}
		Transform transform = base.transform;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, false);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.Boolean_0 && num2 == 1 && !this.manager.playerObjects[i].player.gclass10_0.Boolean_2)
			{
				float num3 = -480f;
				int num4 = GlobalVariables.instance.gclass5_5.CurrentValue + 5;
				float num5 = 96f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, -75f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(-75 - ((num2 > 2) ? 50 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_23(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x0011B908 File Offset: 0x00119B08
	public void method_15()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		int num = 0;
		int num2 = GlobalVariables.instance.isPracticeEnabled ? 0 : GlobalVariables.instance.int_1;
		switch (num2)
		{
		case 8:
			num = 1;
			break;
		case 9:
			num = 8;
			break;
		case 10:
			num = 4;
			break;
		}
		Transform transform = base.transform;
		for (int i = 1; i < num2; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SoloCounter, transform, false);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.Countdown, transform, true);
			if (i == 0 && !GlobalVariables.instance.gclass5_5.method_0() && num2 == 0 && !this.manager.playerObjects[i].player.gclass10_0.method_29())
			{
				float num3 = 548f;
				int num4 = GlobalVariables.instance.gclass5_5.method_25() + 0;
				float num5 = 711f * (float)num4;
				num3 += num5;
				gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, this.vector2_0[0].y);
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(num3, 788f);
			}
			else
			{
				gameObject.GetComponent<RectTransform>().anchoredPosition = this.vector2_0[num];
				gameObject2.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.vector2_0[num].x, (float)(103 - ((num2 > 2) ? 33 : 0)));
			}
			SoloCounter component = gameObject.GetComponent<SoloCounter>();
			Countdown component2 = gameObject2.GetComponent<Countdown>();
			component.basePlayer_0 = this.manager.playerObjects[i];
			component.gameManager_0 = this.manager;
			component2.gameManager_0 = this.manager;
			this.manager.playerObjects[i].soloCounter_0 = component;
			component2.method_4(this.manager.playerObjects[i].player);
			num++;
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x040005C5 RID: 1477
	[SerializeField]
	private GameObject SoloCounter;

	// Token: 0x040005C6 RID: 1478
	[SerializeField]
	private GameObject Countdown;

	// Token: 0x040005C7 RID: 1479
	[SerializeField]
	private GameManager manager;

	// Token: 0x040005C8 RID: 1480
	public Vector2[] vector2_0;
}
