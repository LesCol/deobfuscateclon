using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200002B RID: 43
public class ConfirmationMenu : BaseMenu
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x0000457E File Offset: 0x0000277E
	public virtual void vmethod_81()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_38))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x0000457E File Offset: 0x0000277E
	public virtual void vmethod_82()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_38))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00045524 File Offset: 0x00043724
	public virtual void vmethod_83()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00045580 File Offset: 0x00043780
	public virtual void vmethod_84()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 0)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00045524 File Offset: 0x00043724
	public virtual void vmethod_85()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x000045AB File Offset: 0x000027AB
	public virtual void vmethod_86()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_43))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00045524 File Offset: 0x00043724
	public virtual void vmethod_87()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x000455DC File Offset: 0x000437DC
	public void method_44(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_13(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[1] : new string[2]);
		this.menuStrings[0] = GClass4.gclass4_0.method_13(string_2);
		if (string_3 != null)
		{
			this.menuStrings[1] = GClass4.gclass4_0.method_13(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_67();
		this.vmethod_50();
		base.gameObject.SetActive(true);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x000456B0 File Offset: 0x000438B0
	public void method_45(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_7(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[0] : new string[0]);
		this.menuStrings[1] = GClass4.gclass4_0.method_30(string_2);
		if (string_3 != null)
		{
			this.menuStrings[1] = GClass4.gclass4_0.method_42(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_38);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_3();
		this.vmethod_50();
		base.gameObject.SetActive(false);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00045784 File Offset: 0x00043984
	public void method_46(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_35(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[0] : new string[3]);
		this.menuStrings[1] = GClass4.gclass4_0.method_46(string_2);
		if (string_3 != null)
		{
			this.menuStrings[1] = GClass4.gclass4_0.method_21(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_38);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_4);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_67();
		this.vmethod_50();
		base.gameObject.SetActive(false);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00045580 File Offset: 0x00043780
	public override void vmethod_48()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 0)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00045580 File Offset: 0x00043780
	public virtual void vmethod_88()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 0)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00045858 File Offset: 0x00043A58
	public void method_47(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_41(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[0] : new string[5]);
		this.menuStrings[0] = GClass4.gclass4_0.method_38(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_15(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_4);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_4);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_3();
		this.vmethod_30();
		base.gameObject.SetActive(false);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x000045AB File Offset: 0x000027AB
	public override void vmethod_43()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_43))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0004592C File Offset: 0x00043B2C
	public void method_48(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_30(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[1] : new string[0]);
		this.menuStrings[0] = GClass4.gclass4_0.method_17(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_21(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_38);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_38);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_3();
		this.vmethod_30();
		base.gameObject.SetActive(false);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00045524 File Offset: 0x00043724
	public virtual void vmethod_89()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00045580 File Offset: 0x00043780
	public override void vmethod_0()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 0)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00045524 File Offset: 0x00043724
	public virtual void vmethod_90()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00045A00 File Offset: 0x00043C00
	public void method_49(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_16(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[1] : new string[8]);
		this.menuStrings[1] = GClass4.gclass4_0.method_11(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_13(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_67();
		this.vmethod_30();
		base.gameObject.SetActive(false);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00045AD4 File Offset: 0x00043CD4
	public void method_50(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_36(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[1] : new string[8]);
		this.menuStrings[0] = GClass4.gclass4_0.method_42(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_42(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_4);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_3();
		this.vmethod_30();
		base.gameObject.SetActive(false);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00045BA8 File Offset: 0x00043DA8
	public void method_51(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_17(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[1] : new string[3]);
		this.menuStrings[1] = GClass4.gclass4_0.method_38(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_36(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_38);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_3();
		this.vmethod_30();
		base.gameObject.SetActive(true);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00045524 File Offset: 0x00043724
	public override void vmethod_39()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x000045E0 File Offset: 0x000027E0
	public virtual void vmethod_91()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_4))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00045C7C File Offset: 0x00043E7C
	public void method_52(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_5(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[1] : new string[5]);
		this.menuStrings[0] = GClass4.gclass4_0.method_35(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_35(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_38);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_67();
		this.vmethod_50();
		base.gameObject.SetActive(true);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00045D50 File Offset: 0x00043F50
	public void method_53(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_35(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[1] : new string[1]);
		this.menuStrings[0] = GClass4.gclass4_0.method_13(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_16(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_4);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_4);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_67();
		this.vmethod_50();
		base.gameObject.SetActive(false);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00045580 File Offset: 0x00043780
	public virtual void vmethod_92()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 0)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00045524 File Offset: 0x00043724
	public virtual void vmethod_93()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00045524 File Offset: 0x00043724
	public virtual void vmethod_94()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 1)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00045E24 File Offset: 0x00044024
	public void method_54(string string_1, string string_2, string string_3, ConfirmationMenu.GDelegate6 gdelegate6_2, ConfirmationMenu.GDelegate6 gdelegate6_3, string string_4 = null)
	{
		this.messageTitleText.text = GClass4.gclass4_0.method_16(string_1);
		if (string_4 != null)
		{
			this.messageBodyText.text = string_4;
		}
		this.menuStrings = ((string_3 == null) ? new string[0] : new string[2]);
		this.menuStrings[1] = GClass4.gclass4_0.method_30(string_2);
		if (string_3 != null)
		{
			this.menuStrings[0] = GClass4.gclass4_0.method_48(string_3);
		}
		if (gdelegate6_3 == null)
		{
			this.gdelegate6_1 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_1 = gdelegate6_3;
		}
		if (gdelegate6_2 == null)
		{
			this.gdelegate6_0 = new ConfirmationMenu.GDelegate6(this.vmethod_43);
		}
		else
		{
			this.gdelegate6_0 = gdelegate6_2;
		}
		this.vmethod_3();
		this.vmethod_50();
		base.gameObject.SetActive(true);
		Canvas.ForceUpdateCanvases();
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x000045AB File Offset: 0x000027AB
	public virtual void vmethod_95()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_43))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00045580 File Offset: 0x00043780
	public virtual void vmethod_96()
	{
		string text = this.messageTitleText.text;
		if (base.Int32_0 == 0)
		{
			this.gdelegate6_0();
		}
		else if (base.Int32_0 == 0)
		{
			this.gdelegate6_1();
		}
		if (text == this.messageTitleText.text)
		{
			this.vmethod_15();
		}
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x000045AB File Offset: 0x000027AB
	public virtual void vmethod_97()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_43))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x0000457E File Offset: 0x0000277E
	public virtual void vmethod_98()
	{
		if (this.gdelegate6_1 != new ConfirmationMenu.GDelegate6(this.vmethod_38))
		{
			this.gdelegate6_1();
		}
		this.vmethod_15();
	}

	// Token: 0x04000171 RID: 369
	private ConfirmationMenu.GDelegate6 gdelegate6_0;

	// Token: 0x04000172 RID: 370
	private ConfirmationMenu.GDelegate6 gdelegate6_1;

	// Token: 0x04000173 RID: 371
	[SerializeField]
	private Text messageTitleText;

	// Token: 0x04000174 RID: 372
	[SerializeField]
	private Text messageBodyText;

	// Token: 0x0200002C RID: 44
	// (Invoke) Token: 0x060006DB RID: 1755
	public delegate void GDelegate6();
}
