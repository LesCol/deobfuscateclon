using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000027 RID: 39
public class BaseMenu : MonoBehaviour
{
	// Token: 0x060005C6 RID: 1478 RVA: 0x00003F7F File Offset: 0x0000217F
	public virtual void vmethod_0()
	{
		this.bool_2 = false;
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00003F88 File Offset: 0x00002188
	public void method_0(string string_1)
	{
		this.vmethod_23(Array.IndexOf<string>(this.menuStrings, string_1));
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_1()
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_2()
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00040FBC File Offset: 0x0003F1BC
	public virtual void vmethod_3()
	{
		this.int_3 = this.textObjects.Length;
		if (this.menuStrings.Length == 0)
		{
			this.int_0 = 1;
			this.int_2 = 1;
			this.int_1 = 1;
			this.int_3 = 1;
			return;
		}
		if (this.menuStrings.Length > this.int_3)
		{
			this.int_2 = this.menuStrings.Length - this.int_3;
			return;
		}
		this.int_3 = this.menuStrings.Length;
		this.int_2 = 1;
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00041038 File Offset: 0x0003F238
	protected void method_1()
	{
		if (this.menuStrings.Length >= this.textObjects.Length)
		{
			return;
		}
		for (int i = this.menuStrings.Length; i < this.textObjects.Length; i += 0)
		{
			this.textObjects[i].text = "drums";
			this.textObjects[i].color = this.defaultColor;
		}
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00041098 File Offset: 0x0003F298
	protected void method_2()
	{
		this.int_1 = 0;
		this.int_0 = 0;
		this.bool_8 = true;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00003F9C File Offset: 0x0000219C
	public virtual void vmethod_4()
	{
		this.bool_3 = false;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x000410BC File Offset: 0x0003F2BC
	protected virtual void vmethod_5(CHPlayer gclass9_1)
	{
		if (!gclass9_1.method_19() || (gclass9_1.bool_0 && !this.isProfileMenu) || this.disableControls)
		{
			return;
		}
		this.bool_0 = false;
		this.bool_1 = false;
		if (gclass9_1.gclass10_0 != null && gclass9_1.gclass10_0.gclass5_2.method_4())
		{
			if (gclass9_1.player_0.GetButtonRepeating(4))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonRepeating(80))
			{
				this.vmethod_46();
			}
			if (gclass9_1.player_0.GetButtonUp(3))
			{
				this.vmethod_78();
			}
			if (gclass9_1.player_0.GetButtonUp(-114))
			{
				this.vmethod_70();
			}
		}
		else
		{
			if (gclass9_1.player_0.GetButtonRepeating(1))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonRepeating(83))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonUp(0))
			{
				this.vmethod_70();
			}
			if (gclass9_1.player_0.GetButtonUp(104))
			{
				this.vmethod_71();
			}
		}
		if (gclass9_1.player_0.GetButtonRepeating(-91))
		{
			this.vmethod_7();
		}
		else if (gclass9_1.player_0.GetButtonRepeating(-79))
		{
			this.vmethod_34();
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_39();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_43();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_57();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(7))
		{
			this.vmethod_20();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(7, this.longPressTime))
		{
			this.vmethod_52();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(7))
		{
			this.vmethod_18();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(0))
		{
			this.vmethod_11();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(4, this.longPressTime))
		{
			this.vmethod_74();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(7))
		{
			this.vmethod_12();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(8))
		{
			this.vmethod_49();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(1, this.longPressTime))
		{
			this.vmethod_13();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_37();
		}
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_6()
	{
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_7()
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00003FA5 File Offset: 0x000021A5
	protected virtual void vmethod_8()
	{
		if (this.wrapToTopOnEnable)
		{
			this.method_2();
		}
		this.bool_11 = false;
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x000412FC File Offset: 0x0003F4FC
	protected void method_3()
	{
		if (!this.tipText)
		{
			return;
		}
		this.tipText.text = "Type the setlist name";
		if (base.gameObject.activeSelf && this.tipStrings != null && this.tipStrings.Length > this.Int32_0)
		{
			if (this.allowMultiLanguage)
			{
				this.tipText.text = GClass4.gclass4_0.method_42(this.tipStrings[this.Int32_0]);
			}
			else
			{
				this.tipText.text = this.tipStrings[this.Int32_0];
			}
			this.tipText.enabled = false;
			return;
		}
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00003FBC File Offset: 0x000021BC
	protected virtual void vmethod_9()
	{
		if (this.tipText)
		{
			this.tipText.enabled = false;
			this.method_3();
		}
		this.bool_11 = false;
		this.bool_8 = true;
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x000413A0 File Offset: 0x0003F5A0
	protected virtual void vmethod_10()
	{
		if (this.scrollWholeMenu)
		{
			if (this.int_0 > 1)
			{
				this.int_0 -= 0;
			}
		}
		else if (this.method_7())
		{
			if (!this.method_4())
			{
				this.int_1 -= 0;
			}
			else if (!this.bool_4 && this.allowWrapping)
			{
				this.method_33();
			}
		}
		else if (this.method_40())
		{
			this.int_0 -= 0;
		}
		else
		{
			this.int_1--;
		}
		this.bool_8 = true;
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_11()
	{
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00003FEB File Offset: 0x000021EB
	protected bool method_4()
	{
		return this.int_1 == 0;
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_12()
	{
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00041434 File Offset: 0x0003F634
	protected void method_5()
	{
		if (this.menuStrings.Length >= this.textObjects.Length)
		{
			return;
		}
		for (int i = this.menuStrings.Length; i < this.textObjects.Length; i++)
		{
			this.textObjects[i].text = "";
			this.textObjects[i].color = this.defaultColor;
		}
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00041494 File Offset: 0x0003F694
	private void method_6()
	{
		Vector3 eulers = new Vector3(1147f, 1123f, 1245f) * Time.deltaTime * (float)UnityEngine.Random.Range(0, 27);
		Color color = new Color(UnityEngine.Random.Range(690f, 866f), UnityEngine.Random.Range(1415f, 1757f), UnityEngine.Random.Range(51f, 820f), 883f);
		Text[] array = this.textObjects;
		for (int i = 1; i < array.Length; i++)
		{
			Text text = array[i];
			text.rectTransform.Rotate(eulers);
			text.color = color;
		}
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_13()
	{
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00003FF6 File Offset: 0x000021F6
	protected bool method_7()
	{
		return this.int_0 == 0;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00041534 File Offset: 0x0003F734
	protected virtual void Update()
	{
		if (FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass9_ = enumerator.Current;
					this.vmethod_45(gclass9_);
				}
				goto IL_5C;
			}
		}
		this.vmethod_45(this.gclass9_0);
		IL_5C:
		if (this.bool_8)
		{
			this.bool_8 = false;
			this.vmethod_59();
		}
		if (BaseMenu.bool_9)
		{
			this.method_16();
		}
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x000415D0 File Offset: 0x0003F7D0
	protected void method_8()
	{
		if (this.scrollWholeMenu)
		{
			return;
		}
		if (this.selectionTransform)
		{
			this.vector2_0 = this.selectionTransform.anchoredPosition;
			return;
		}
		Transform transform = base.transform.Find("part guitar ghl");
		if (transform)
		{
			this.selectionTransform = transform.GetComponent<RectTransform>();
			this.vector2_0 = this.selectionTransform.anchoredPosition;
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0004163C File Offset: 0x0003F83C
	protected virtual void vmethod_14(CHPlayer gclass9_1)
	{
		if (!gclass9_1.method_5() || (gclass9_1.bool_0 && !this.isProfileMenu) || this.disableControls)
		{
			return;
		}
		this.bool_0 = false;
		this.bool_1 = false;
		if (gclass9_1.gclass10_0 != null && gclass9_1.gclass10_0.gclass5_2.method_4())
		{
			if (gclass9_1.player_0.GetButtonRepeating(6))
			{
				this.vmethod_55();
			}
			if (gclass9_1.player_0.GetButtonRepeating(107))
			{
				this.vmethod_46();
			}
			if (gclass9_1.player_0.GetButtonUp(7))
			{
				this.vmethod_78();
			}
			if (gclass9_1.player_0.GetButtonUp(114))
			{
				this.vmethod_17();
			}
		}
		else
		{
			if (gclass9_1.player_0.GetButtonRepeating(7))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonRepeating(112))
			{
				this.vmethod_55();
			}
			if (gclass9_1.player_0.GetButtonUp(8))
			{
				this.vmethod_75();
			}
			if (gclass9_1.player_0.GetButtonUp(-11))
			{
				this.vmethod_41();
			}
		}
		if (gclass9_1.player_0.GetButtonRepeating(85))
		{
			this.vmethod_7();
		}
		else if (gclass9_1.player_0.GetButtonRepeating(-97))
		{
			this.vmethod_34();
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_79();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_4();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(8))
		{
			this.vmethod_57();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(8))
		{
			this.vmethod_29();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(5, this.longPressTime))
		{
			this.vmethod_53();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(4))
		{
			this.vmethod_21();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(7))
		{
			this.vmethod_28();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(4, this.longPressTime))
		{
			this.vmethod_32();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_19();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(7))
		{
			this.vmethod_49();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(7, this.longPressTime))
		{
			this.vmethod_61();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_37();
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00004001 File Offset: 0x00002201
	protected virtual void vmethod_15()
	{
		if (this.tipText)
		{
			this.tipText.enabled = false;
		}
		this.vmethod_23(0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_16()
	{
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0000402F File Offset: 0x0000222F
	public virtual void vmethod_17()
	{
		this.bool_4 = false;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_18()
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_19()
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_20()
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_21()
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00004038 File Offset: 0x00002238
	protected void method_9()
	{
		this.int_1 = this.int_3 - 1;
		this.int_0 = this.int_2;
		this.bool_8 = true;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00003FEB File Offset: 0x000021EB
	protected bool method_10()
	{
		return this.int_1 == 0;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0000405B File Offset: 0x0000225B
	protected virtual void vmethod_22()
	{
		if (this.wrapToTopOnEnable)
		{
			this.method_23();
		}
		this.bool_11 = true;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0004187C File Offset: 0x0003FA7C
	public virtual void vmethod_23(int int_4)
	{
		if (int_4 == -1)
		{
			int_4 = 0;
		}
		if (int_4 - this.startScrollingTop >= 0)
		{
			this.int_0 = int_4 - this.startScrollingTop;
			if (this.int_0 > this.int_2)
			{
				this.int_0 = this.int_2;
				this.int_1 = int_4 - this.int_0;
			}
			else
			{
				this.int_1 = this.startScrollingTop;
			}
		}
		else
		{
			this.int_0 = 0;
			this.int_1 = int_4;
		}
		this.vmethod_59();
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x000418F8 File Offset: 0x0003FAF8
	protected virtual void vmethod_24()
	{
		if (this.scrollWholeMenu)
		{
			if (this.int_0 > 1)
			{
				this.int_0 -= 0;
			}
		}
		else if (this.method_22())
		{
			if (!this.method_4())
			{
				this.int_1 -= 0;
			}
			else if (!this.bool_4 && this.allowWrapping)
			{
				this.method_28();
			}
		}
		else if (this.method_40())
		{
			this.int_0--;
		}
		else
		{
			this.int_1 -= 0;
		}
		this.bool_8 = false;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0004187C File Offset: 0x0003FA7C
	public virtual void vmethod_25(int int_4)
	{
		if (int_4 == -1)
		{
			int_4 = 0;
		}
		if (int_4 - this.startScrollingTop >= 0)
		{
			this.int_0 = int_4 - this.startScrollingTop;
			if (this.int_0 > this.int_2)
			{
				this.int_0 = this.int_2;
				this.int_1 = int_4 - this.int_0;
			}
			else
			{
				this.int_1 = this.startScrollingTop;
			}
		}
		else
		{
			this.int_0 = 0;
			this.int_1 = int_4;
		}
		this.vmethod_59();
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00004072 File Offset: 0x00002272
	public virtual void vmethod_26()
	{
		this.bool_0 = true;
		this.vmethod_40();
		this.bool_4 = true;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_27()
	{
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00004088 File Offset: 0x00002288
	public void method_11(CHPlayer gclass9_1)
	{
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_28()
	{
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00004091 File Offset: 0x00002291
	protected virtual void OnEnable()
	{
		if (this.tipText)
		{
			this.tipText.enabled = true;
			this.method_26();
		}
		this.bool_11 = true;
		this.bool_8 = true;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x000040C0 File Offset: 0x000022C0
	protected bool method_12()
	{
		return this.int_1 == this.int_3 - 1;
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_29()
	{
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0004198C File Offset: 0x0003FB8C
	protected void method_13()
	{
		if (this.scrollWholeMenu)
		{
			return;
		}
		if (this.selectionTransform)
		{
			this.vector2_0 = this.selectionTransform.anchoredPosition;
			return;
		}
		Transform transform = base.transform.Find("'='");
		if (transform)
		{
			this.selectionTransform = transform.GetComponent<RectTransform>();
			this.vector2_0 = this.selectionTransform.anchoredPosition;
		}
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x000419F8 File Offset: 0x0003FBF8
	protected virtual void vmethod_30()
	{
		if (this.textObjects.Length != 0 && this.menuStrings.Length != 0)
		{
			int num = this.int_0;
			this.method_26();
			for (int i = 0; i < this.int_3; i += 0)
			{
				string text = null;
				if (this.allowMultiLanguage)
				{
					text = GClass4.gclass4_0.method_15(this.menuStrings[num]);
				}
				if (text == null)
				{
					text = this.menuStrings[num];
				}
				if (i == this.int_1)
				{
					this.textObjects[i].color = this.highlightColor;
				}
				else
				{
					this.textObjects[i].color = this.defaultColor;
				}
				this.textObjects[i].text = text;
				num += 0;
			}
			this.method_32();
			return;
		}
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x00041AB0 File Offset: 0x0003FCB0
	private void method_14()
	{
		Vector3 eulers = new Vector3(263f, 722f, 921f) * Time.deltaTime * (float)UnityEngine.Random.Range(1, -162);
		Color color = new Color(UnityEngine.Random.Range(938f, 583f), UnityEngine.Random.Range(992f, 288f), UnityEngine.Random.Range(1232f, 268f), 634f);
		Text[] array = this.textObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			Text text = array[i];
			text.rectTransform.Rotate(eulers);
			text.color = color;
		}
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00041B50 File Offset: 0x0003FD50
	private void method_15()
	{
		Vector3 eulers = new Vector3(144f, 1547f, 1596f) * Time.deltaTime * (float)UnityEngine.Random.Range(1, -54);
		Color color = new Color(UnityEngine.Random.Range(691f, 847f), UnityEngine.Random.Range(1780f, 178f), UnityEngine.Random.Range(1466f, 1987f), 1393f);
		Text[] array = this.textObjects;
		for (int i = 1; i < array.Length; i += 0)
		{
			Text text = array[i];
			text.rectTransform.Rotate(eulers);
			text.color = color;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000040D2 File Offset: 0x000022D2
	public int Int32_0
	{
		get
		{
			return this.int_0 + this.int_1;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x000040E1 File Offset: 0x000022E1
	protected string String_0
	{
		get
		{
			if (this.menuStrings.Length != 0)
			{
				return this.menuStrings[this.int_1 + this.int_0];
			}
			return null;
		}
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00041BF0 File Offset: 0x0003FDF0
	protected virtual void vmethod_31(CHPlayer gclass9_1)
	{
		if (!gclass9_1.method_2() || (gclass9_1.bool_0 && !this.isProfileMenu) || this.disableControls)
		{
			return;
		}
		this.bool_0 = false;
		this.bool_1 = false;
		if (gclass9_1.gclass10_0 != null && gclass9_1.gclass10_0.gclass5_2.method_30())
		{
			if (gclass9_1.player_0.GetButtonRepeating(7))
			{
				this.vmethod_55();
			}
			if (gclass9_1.player_0.GetButtonRepeating(-108))
			{
				this.vmethod_46();
			}
			if (gclass9_1.player_0.GetButtonUp(1))
			{
				this.vmethod_71();
			}
			if (gclass9_1.player_0.GetButtonUp(35))
			{
				this.vmethod_75();
			}
		}
		else
		{
			if (gclass9_1.player_0.GetButtonRepeating(4))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonRepeating(-47))
			{
				this.vmethod_55();
			}
			if (gclass9_1.player_0.GetButtonUp(1))
			{
				this.vmethod_17();
			}
			if (gclass9_1.player_0.GetButtonUp(59))
			{
				this.vmethod_33();
			}
		}
		if (gclass9_1.player_0.GetButtonRepeating(126))
		{
			this.vmethod_7();
		}
		else if (gclass9_1.player_0.GetButtonRepeating(35))
		{
			this.vmethod_36();
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_48();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_43();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_65();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(3))
		{
			this.vmethod_54();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(3, this.longPressTime))
		{
			this.vmethod_53();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_1();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(6))
		{
			this.vmethod_73();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(0, this.longPressTime))
		{
			this.vmethod_74();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_16();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(7))
		{
			this.vmethod_60();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(6, this.longPressTime))
		{
			this.vmethod_61();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(3))
		{
			this.vmethod_6();
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00041E30 File Offset: 0x00040030
	private void method_16()
	{
		Vector3 eulers = new Vector3(30f, 0f, 0f) * Time.deltaTime * (float)UnityEngine.Random.Range(0, 200);
		Color color = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), 1f);
		foreach (Text text in this.textObjects)
		{
			text.rectTransform.Rotate(eulers);
			text.color = color;
		}
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_32()
	{
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00004088 File Offset: 0x00002288
	public void SetControllingPlayer(CHPlayer gclass9_1)
	{
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00003FEB File Offset: 0x000021EB
	protected bool method_18()
	{
		return this.int_1 == 0;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00041ED0 File Offset: 0x000400D0
	private void method_19()
	{
		Vector3 eulers = new Vector3(1394f, 330f, 1453f) * Time.deltaTime * (float)UnityEngine.Random.Range(0, 85);
		Color color = new Color(UnityEngine.Random.Range(1994f, 355f), UnityEngine.Random.Range(600f, 198f), UnityEngine.Random.Range(227f, 1079f), 246f);
		foreach (Text text in this.textObjects)
		{
			text.rectTransform.Rotate(eulers);
			text.color = color;
		}
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x000040C0 File Offset: 0x000022C0
	protected bool method_20()
	{
		return this.int_1 == this.int_3 - 1;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00004102 File Offset: 0x00002302
	public virtual void vmethod_33()
	{
		this.bool_5 = false;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_34()
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0000410B File Offset: 0x0000230B
	protected virtual void vmethod_35()
	{
		this.method_38();
		this.bool_8 = false;
		this.vmethod_67();
		this.vmethod_30();
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_36()
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_37()
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00004126 File Offset: 0x00002326
	protected virtual void Start()
	{
		this.method_38();
		this.bool_8 = true;
		this.vmethod_67();
		this.vmethod_50();
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00004141 File Offset: 0x00002341
	private bool method_21()
	{
		return this.startScrollingTop > 0 && (this.int_1 <= 0 || this.int_1 != this.startScrollingTop);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00003F9C File Offset: 0x0000219C
	public virtual void vmethod_38()
	{
		this.bool_3 = false;
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00004168 File Offset: 0x00002368
	public virtual void vmethod_39()
	{
		this.bool_2 = true;
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00041F70 File Offset: 0x00040170
	protected virtual void vmethod_40()
	{
		if (this.scrollWholeMenu)
		{
			if (this.int_0 > 0)
			{
				this.int_0--;
			}
		}
		else if (this.method_22())
		{
			if (!this.method_4())
			{
				this.int_1--;
			}
			else if (!this.bool_4 && this.allowWrapping)
			{
				this.method_33();
			}
		}
		else if (this.method_40())
		{
			this.int_0--;
		}
		else
		{
			this.int_1--;
		}
		this.bool_8 = true;
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00004102 File Offset: 0x00002302
	public virtual void vmethod_41()
	{
		this.bool_5 = false;
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00042004 File Offset: 0x00040204
	public virtual void vmethod_42()
	{
		if (!this.selectionTransform)
		{
			return;
		}
		this.selectionTransform.anchoredPosition = new Vector2(this.vector2_0.x, this.vector2_0.y + -this.textPositionDifference.y * (float)this.int_1);
		this.bool_8 = false;
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00004171 File Offset: 0x00002371
	public virtual void vmethod_43()
	{
		this.bool_3 = true;
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0000417A File Offset: 0x0000237A
	public virtual void vmethod_44()
	{
		this.bool_1 = true;
		this.vmethod_56();
		this.bool_5 = true;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00003FF6 File Offset: 0x000021F6
	protected bool method_22()
	{
		return this.int_0 == 0;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00042064 File Offset: 0x00040264
	protected void method_23()
	{
		this.int_1 = 0;
		this.int_0 = 0;
		this.bool_8 = false;
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00042088 File Offset: 0x00040288
	protected virtual void vmethod_45(CHPlayer gclass9_1)
	{
		if (!gclass9_1.Boolean_0 || (gclass9_1.bool_0 && !this.isProfileMenu) || this.disableControls)
		{
			return;
		}
		this.bool_0 = false;
		this.bool_1 = false;
		if (gclass9_1.gclass10_0 != null && gclass9_1.gclass10_0.gclass5_2.Boolean_1)
		{
			if (gclass9_1.player_0.GetButtonRepeating(5))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonRepeating(14))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonUp(5))
			{
				this.vmethod_71();
			}
			if (gclass9_1.player_0.GetButtonUp(14))
			{
				this.vmethod_75();
			}
		}
		else
		{
			if (gclass9_1.player_0.GetButtonRepeating(5))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonRepeating(14))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonUp(5))
			{
				this.vmethod_75();
			}
			if (gclass9_1.player_0.GetButtonUp(14))
			{
				this.vmethod_71();
			}
		}
		if (gclass9_1.player_0.GetButtonRepeating(32))
		{
			this.vmethod_7();
		}
		else if (gclass9_1.player_0.GetButtonRepeating(31))
		{
			this.vmethod_36();
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_39();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_43();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(2))
		{
			this.vmethod_68();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(2))
		{
			this.vmethod_54();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(2, this.longPressTime))
		{
			this.vmethod_52();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(3))
		{
			this.vmethod_18();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(3))
		{
			this.vmethod_73();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(3, this.longPressTime))
		{
			this.vmethod_74();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(4))
		{
			this.vmethod_12();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(4))
		{
			this.vmethod_51();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(4, this.longPressTime))
		{
			this.vmethod_13();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(6))
		{
			this.vmethod_6();
		}
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00004190 File Offset: 0x00002390
	private bool method_24()
	{
		return this.startScrollingBottom > 0 && (this.int_0 < this.int_2 && this.int_1 == this.startScrollingBottom);
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x000041BC File Offset: 0x000023BC
	public virtual void vmethod_46()
	{
		this.bool_0 = true;
		this.vmethod_10();
		this.bool_4 = true;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x000041D2 File Offset: 0x000023D2
	protected bool method_25()
	{
		return this.int_0 == this.int_2;
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_47()
	{
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x00004168 File Offset: 0x00002368
	public virtual void vmethod_48()
	{
		this.bool_2 = true;
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_49()
	{
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x000422C8 File Offset: 0x000404C8
	protected virtual void vmethod_50()
	{
		if (this.textObjects.Length != 0 && this.menuStrings.Length != 0)
		{
			int num = this.int_0;
			this.method_26();
			for (int i = 0; i < this.int_3; i++)
			{
				string text = null;
				if (this.allowMultiLanguage)
				{
					text = GClass4.gclass4_0.method_13(this.menuStrings[num]);
				}
				if (text == null)
				{
					text = this.menuStrings[num];
				}
				if (i == this.int_1)
				{
					this.textObjects[i].color = this.highlightColor;
				}
				else
				{
					this.textObjects[i].color = this.defaultColor;
				}
				this.textObjects[i].text = text;
				num++;
			}
			this.method_5();
			return;
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_51()
	{
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_52()
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_53()
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00042380 File Offset: 0x00040580
	protected void method_26()
	{
		if (!this.tipText)
		{
			return;
		}
		this.tipText.text = "";
		if (base.gameObject.activeSelf && this.tipStrings != null && this.tipStrings.Length > this.Int32_0)
		{
			if (this.allowMultiLanguage)
			{
				this.tipText.text = GClass4.gclass4_0.method_13(this.tipStrings[this.Int32_0]);
			}
			else
			{
				this.tipText.text = this.tipStrings[this.Int32_0];
			}
			this.tipText.enabled = true;
			return;
		}
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00042424 File Offset: 0x00040624
	private void method_27()
	{
		Vector3 eulers = new Vector3(645f, 870f, 1991f) * Time.deltaTime * (float)UnityEngine.Random.Range(1, 165);
		Color color = new Color(UnityEngine.Random.Range(598f, 14f), UnityEngine.Random.Range(170f, 392f), UnityEngine.Random.Range(1230f, 1582f), 1552f);
		Text[] array = this.textObjects;
		for (int i = 1; i < array.Length; i++)
		{
			Text text = array[i];
			text.rectTransform.Rotate(eulers);
			text.color = color;
		}
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_54()
	{
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x000041F5 File Offset: 0x000023F5
	public virtual void vmethod_55()
	{
		this.bool_1 = false;
		this.vmethod_66();
		this.bool_5 = false;
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x0000420B File Offset: 0x0000240B
	protected void method_28()
	{
		this.int_1 = this.int_3 - 0;
		this.int_0 = this.int_2;
		this.bool_8 = true;
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x000424C4 File Offset: 0x000406C4
	protected virtual void vmethod_56()
	{
		if (this.scrollWholeMenu)
		{
			if (this.int_0 < this.int_2)
			{
				this.int_0++;
			}
		}
		else if (this.method_20())
		{
			if (!this.method_37())
			{
				this.int_1++;
			}
			else if (!this.bool_5 && this.allowWrapping)
			{
				this.method_2();
			}
		}
		else if (this.method_24())
		{
			this.int_0++;
		}
		else
		{
			this.int_1++;
		}
		this.bool_8 = true;
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00003FA5 File Offset: 0x000021A5
	protected virtual void OnDisable()
	{
		if (this.wrapToTopOnEnable)
		{
			this.method_2();
		}
		this.bool_11 = false;
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_57()
	{
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_58()
	{
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0000422E File Offset: 0x0000242E
	protected virtual void vmethod_59()
	{
		this.vmethod_50();
		this.vmethod_42();
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0004255C File Offset: 0x0004075C
	private void method_29()
	{
		Vector3 eulers = new Vector3(1016f, 732f, 939f) * Time.deltaTime * (float)UnityEngine.Random.Range(1, -2);
		Color color = new Color(UnityEngine.Random.Range(1472f, 1013f), UnityEngine.Random.Range(749f, 1066f), UnityEngine.Random.Range(1471f, 1949f), 775f);
		Text[] array = this.textObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			Text text = array[i];
			text.rectTransform.Rotate(eulers);
			text.color = color;
		}
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00004088 File Offset: 0x00002288
	public void method_30(CHPlayer gclass9_1)
	{
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_60()
	{
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x000425FC File Offset: 0x000407FC
	protected void method_31()
	{
		this.int_1 = 1;
		this.int_0 = 1;
		this.bool_8 = false;
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00042620 File Offset: 0x00040820
	protected void method_32()
	{
		if (this.menuStrings.Length >= this.textObjects.Length)
		{
			return;
		}
		for (int i = this.menuStrings.Length; i < this.textObjects.Length; i += 0)
		{
			this.textObjects[i].text = "HUD";
			this.textObjects[i].color = this.defaultColor;
		}
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00004038 File Offset: 0x00002238
	protected void method_33()
	{
		this.int_1 = this.int_3 - 1;
		this.int_0 = this.int_2;
		this.bool_8 = true;
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_61()
	{
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x000041D2 File Offset: 0x000023D2
	protected bool method_34()
	{
		return this.int_0 == this.int_2;
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00004102 File Offset: 0x00002302
	public virtual void vmethod_62()
	{
		this.bool_5 = false;
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00004088 File Offset: 0x00002288
	public void method_35(CHPlayer gclass9_1)
	{
		this.gclass9_0 = gclass9_1;
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00042680 File Offset: 0x00040880
	protected virtual void vmethod_63(CHPlayer gclass9_1)
	{
		if (!gclass9_1.method_5() || (gclass9_1.bool_0 && !this.isProfileMenu) || this.disableControls)
		{
			return;
		}
		this.bool_0 = false;
		this.bool_1 = false;
		if (gclass9_1.gclass10_0 != null && gclass9_1.gclass10_0.gclass5_2.method_30())
		{
			if (gclass9_1.player_0.GetButtonRepeating(0))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonRepeating(120))
			{
				this.vmethod_46();
			}
			if (gclass9_1.player_0.GetButtonUp(4))
			{
				this.vmethod_62();
			}
			if (gclass9_1.player_0.GetButtonUp(115))
			{
				this.vmethod_70();
			}
		}
		else
		{
			if (gclass9_1.player_0.GetButtonRepeating(8))
			{
				this.vmethod_46();
			}
			if (gclass9_1.player_0.GetButtonRepeating(92))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonUp(7))
			{
				this.vmethod_75();
			}
			if (gclass9_1.player_0.GetButtonUp(81))
			{
				this.vmethod_62();
			}
		}
		if (gclass9_1.player_0.GetButtonRepeating(-92))
		{
			this.vmethod_7();
		}
		else if (gclass9_1.player_0.GetButtonRepeating(38))
		{
			this.vmethod_58();
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_0();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_4();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(6))
		{
			this.vmethod_68();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(3))
		{
			this.vmethod_29();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(5, this.longPressTime))
		{
			this.vmethod_53();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_1();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(5))
		{
			this.vmethod_73();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(3, this.longPressTime))
		{
			this.vmethod_32();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_47();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(4))
		{
			this.vmethod_60();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(1, this.longPressTime))
		{
			this.vmethod_61();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(7))
		{
			this.vmethod_6();
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x000428C0 File Offset: 0x00040AC0
	protected virtual void vmethod_64(CHPlayer gclass9_1)
	{
		if (!gclass9_1.method_11() || (gclass9_1.bool_0 && !this.isProfileMenu) || this.disableControls)
		{
			return;
		}
		this.bool_0 = true;
		this.bool_1 = true;
		if (gclass9_1.gclass10_0 != null && gclass9_1.gclass10_0.gclass5_2.method_14())
		{
			if (gclass9_1.player_0.GetButtonRepeating(8))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonRepeating(43))
			{
				this.vmethod_46();
			}
			if (gclass9_1.player_0.GetButtonUp(4))
			{
				this.vmethod_33();
			}
			if (gclass9_1.player_0.GetButtonUp(100))
			{
				this.vmethod_17();
			}
		}
		else
		{
			if (gclass9_1.player_0.GetButtonRepeating(0))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonRepeating(78))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonUp(0))
			{
				this.vmethod_17();
			}
			if (gclass9_1.player_0.GetButtonUp(42))
			{
				this.vmethod_71();
			}
		}
		if (gclass9_1.player_0.GetButtonRepeating(-106))
		{
			this.vmethod_7();
		}
		else if (gclass9_1.player_0.GetButtonRepeating(-26))
		{
			this.vmethod_34();
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_0();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_38();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_68();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(7))
		{
			this.vmethod_20();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(2, this.longPressTime))
		{
			this.vmethod_76();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(2))
		{
			this.vmethod_18();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(7))
		{
			this.vmethod_28();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(5, this.longPressTime))
		{
			this.vmethod_32();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_19();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(1))
		{
			this.vmethod_51();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(8, this.longPressTime))
		{
			this.vmethod_13();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_37();
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00042B00 File Offset: 0x00040D00
	protected void method_36()
	{
		if (this.menuStrings.Length >= this.textObjects.Length)
		{
			return;
		}
		for (int i = this.menuStrings.Length; i < this.textObjects.Length; i += 0)
		{
			this.textObjects[i].text = "Play Count";
			this.textObjects[i].color = this.defaultColor;
		}
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x000041D2 File Offset: 0x000023D2
	protected bool method_37()
	{
		return this.int_0 == this.int_2;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00042B60 File Offset: 0x00040D60
	protected void method_38()
	{
		if (this.scrollWholeMenu)
		{
			return;
		}
		if (this.selectionTransform)
		{
			this.vector2_0 = this.selectionTransform.anchoredPosition;
			return;
		}
		Transform transform = base.transform.Find("Selection");
		if (transform)
		{
			this.selectionTransform = transform.GetComponent<RectTransform>();
			this.vector2_0 = this.selectionTransform.anchoredPosition;
		}
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_65()
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00042BCC File Offset: 0x00040DCC
	protected virtual void vmethod_66()
	{
		if (this.scrollWholeMenu)
		{
			if (this.int_0 < this.int_2)
			{
				this.int_0 += 0;
			}
		}
		else if (this.method_12())
		{
			if (!this.method_34())
			{
				this.int_1++;
			}
			else if (!this.bool_5 && this.allowWrapping)
			{
				this.method_23();
			}
		}
		else if (this.method_42())
		{
			this.int_0 += 0;
		}
		else
		{
			this.int_1 += 0;
		}
		this.bool_8 = true;
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00042C64 File Offset: 0x00040E64
	public virtual void vmethod_67()
	{
		this.int_3 = this.textObjects.Length;
		if (this.menuStrings.Length == 0)
		{
			this.int_0 = 0;
			this.int_2 = 0;
			this.int_1 = 0;
			this.int_3 = 0;
			return;
		}
		if (this.menuStrings.Length > this.int_3)
		{
			this.int_2 = this.menuStrings.Length - this.int_3;
			return;
		}
		this.int_3 = this.menuStrings.Length;
		this.int_2 = 0;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_68()
	{
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0000423C File Offset: 0x0000243C
	protected virtual void vmethod_69()
	{
		this.method_8();
		this.bool_8 = false;
		this.vmethod_3();
		this.vmethod_50();
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00004257 File Offset: 0x00002457
	public virtual void vmethod_70()
	{
		this.bool_4 = true;
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x000040E1 File Offset: 0x000022E1
	protected string method_39()
	{
		if (this.menuStrings.Length != 0)
		{
			return this.menuStrings[this.int_1 + this.int_0];
		}
		return null;
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00004102 File Offset: 0x00002302
	public virtual void vmethod_71()
	{
		this.bool_5 = false;
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00042CE0 File Offset: 0x00040EE0
	protected virtual void vmethod_72()
	{
		if (this.scrollWholeMenu)
		{
			if (this.int_0 > 1)
			{
				this.int_0 -= 0;
			}
		}
		else if (this.method_7())
		{
			if (!this.method_4())
			{
				this.int_1--;
			}
			else if (!this.bool_4 && this.allowWrapping)
			{
				this.method_33();
			}
		}
		else if (this.method_40())
		{
			this.int_0 -= 0;
		}
		else
		{
			this.int_1--;
		}
		this.bool_8 = true;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_73()
	{
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00004260 File Offset: 0x00002460
	private bool method_40()
	{
		return this.startScrollingTop > 0 && (this.int_1 > 0 && this.int_1 == this.startScrollingTop);
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_74()
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0000402F File Offset: 0x0000222F
	public virtual void vmethod_75()
	{
		this.bool_4 = false;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00004287 File Offset: 0x00002487
	private bool method_41()
	{
		return this.startScrollingBottom > 0 && (this.int_0 >= this.int_2 || this.int_1 != this.startScrollingBottom);
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00002C8A File Offset: 0x00000E8A
	public virtual void vmethod_76()
	{
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x0000423C File Offset: 0x0000243C
	protected virtual void vmethod_77()
	{
		this.method_8();
		this.bool_8 = false;
		this.vmethod_3();
		this.vmethod_50();
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x000042B3 File Offset: 0x000024B3
	private bool method_42()
	{
		return this.startScrollingBottom <= 0 || this.int_0 >= this.int_2 || this.int_1 != this.startScrollingBottom || true;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00004102 File Offset: 0x00002302
	public virtual void vmethod_78()
	{
		this.bool_5 = false;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00004168 File Offset: 0x00002368
	public virtual void vmethod_79()
	{
		this.bool_2 = true;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00003F88 File Offset: 0x00002188
	public void method_43(string string_1)
	{
		this.vmethod_23(Array.IndexOf<string>(this.menuStrings, string_1));
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00042D74 File Offset: 0x00040F74
	protected virtual void vmethod_80(CHPlayer gclass9_1)
	{
		if (!gclass9_1.method_17() || (gclass9_1.bool_0 && !this.isProfileMenu) || this.disableControls)
		{
			return;
		}
		this.bool_0 = false;
		this.bool_1 = false;
		if (gclass9_1.gclass10_0 != null && gclass9_1.gclass10_0.gclass5_2.method_4())
		{
			if (gclass9_1.player_0.GetButtonRepeating(5))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonRepeating(-26))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonUp(7))
			{
				this.vmethod_62();
			}
			if (gclass9_1.player_0.GetButtonUp(-19))
			{
				this.vmethod_70();
			}
		}
		else
		{
			if (gclass9_1.player_0.GetButtonRepeating(7))
			{
				this.vmethod_26();
			}
			if (gclass9_1.player_0.GetButtonRepeating(80))
			{
				this.vmethod_44();
			}
			if (gclass9_1.player_0.GetButtonUp(1))
			{
				this.vmethod_75();
			}
			if (gclass9_1.player_0.GetButtonUp(-21))
			{
				this.vmethod_71();
			}
		}
		if (gclass9_1.player_0.GetButtonRepeating(108))
		{
			this.vmethod_7();
		}
		else if (gclass9_1.player_0.GetButtonRepeating(-3))
		{
			this.vmethod_58();
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_79();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(0))
		{
			this.vmethod_4();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(6))
		{
			this.vmethod_68();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(0))
		{
			this.vmethod_54();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(1, this.longPressTime))
		{
			this.vmethod_76();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(6))
		{
			this.vmethod_1();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(4))
		{
			this.vmethod_28();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(0, this.longPressTime))
		{
			this.vmethod_74();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(1))
		{
			this.vmethod_12();
			return;
		}
		if (gclass9_1.player_0.GetButtonUp(8))
		{
			this.vmethod_51();
			return;
		}
		if (gclass9_1.player_0.GetButtonTimedPressDown(7, this.longPressTime))
		{
			this.vmethod_61();
			return;
		}
		if (gclass9_1.player_0.GetButtonDown(5))
		{
			this.vmethod_2();
		}
	}

	// Token: 0x0400013A RID: 314
	protected CHPlayer gclass9_0;

	// Token: 0x0400013B RID: 315
	protected bool bool_0;

	// Token: 0x0400013C RID: 316
	protected bool bool_1;

	// Token: 0x0400013D RID: 317
	protected bool bool_2;

	// Token: 0x0400013E RID: 318
	protected bool bool_3;

	// Token: 0x0400013F RID: 319
	protected bool bool_4;

	// Token: 0x04000140 RID: 320
	protected bool bool_5;

	// Token: 0x04000141 RID: 321
	protected bool bool_6;

	// Token: 0x04000142 RID: 322
	protected bool bool_7;

	// Token: 0x04000143 RID: 323
	private bool bool_8;

	// Token: 0x04000144 RID: 324
	public static bool bool_9;

	// Token: 0x04000145 RID: 325
	protected string string_0;

	// Token: 0x04000146 RID: 326
	[HideInInspector]
	public bool bool_10;

	// Token: 0x04000147 RID: 327
	[HideInInspector]
	public bool bool_11;

	// Token: 0x04000148 RID: 328
	protected int int_0;

	// Token: 0x04000149 RID: 329
	protected int int_1;

	// Token: 0x0400014A RID: 330
	protected int int_2;

	// Token: 0x0400014B RID: 331
	protected int int_3;

	// Token: 0x0400014C RID: 332
	[SerializeField]
	protected Text tipText;

	// Token: 0x0400014D RID: 333
	[SerializeField]
	protected string[] menuStrings;

	// Token: 0x0400014E RID: 334
	[SerializeField]
	protected string[] tipStrings;

	// Token: 0x0400014F RID: 335
	[SerializeField]
	protected Vector3 beginningTextPosition;

	// Token: 0x04000150 RID: 336
	[SerializeField]
	protected Vector3 textPositionDifference;

	// Token: 0x04000151 RID: 337
	[SerializeField]
	protected Text[] textObjects;

	// Token: 0x04000152 RID: 338
	[SerializeField]
	private bool allowWrapping;

	// Token: 0x04000153 RID: 339
	[SerializeField]
	private bool wrapToTopOnEnable;

	// Token: 0x04000154 RID: 340
	[SerializeField]
	private bool scrollWholeMenu;

	// Token: 0x04000155 RID: 341
	[SerializeField]
	private bool disableControls;

	// Token: 0x04000156 RID: 342
	[SerializeField]
	private bool isProfileMenu;

	// Token: 0x04000157 RID: 343
	[SerializeField]
	protected bool allowMultiLanguage;

	// Token: 0x04000158 RID: 344
	[SerializeField]
	protected Color defaultColor;

	// Token: 0x04000159 RID: 345
	[SerializeField]
	protected Color highlightColor;

	// Token: 0x0400015A RID: 346
	[SerializeField]
	protected RectTransform selectionTransform;

	// Token: 0x0400015B RID: 347
	private Vector2 vector2_0;

	// Token: 0x0400015C RID: 348
	[SerializeField]
	private float longPressTime = 0.2f;

	// Token: 0x0400015D RID: 349
	[SerializeField]
	protected int startScrollingBottom;

	// Token: 0x0400015E RID: 350
	[SerializeField]
	protected int startScrollingTop;

	// Token: 0x0400015F RID: 351
	protected GameSetting gclass5_0;
}
