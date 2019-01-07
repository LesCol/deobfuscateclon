using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000029 RID: 41
public class ButtonTipIcons : MonoBehaviour
{
	// Token: 0x06000657 RID: 1623 RVA: 0x0004328C File Offset: 0x0004148C
	private void method_0()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-110))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)107];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x000042ED File Offset: 0x000024ED
	private void method_1()
	{
		this.method_15(false);
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00043304 File Offset: 0x00041504
	private void method_2(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_19() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_46();
				}
			}
		}
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x000042F6 File Offset: 0x000024F6
	private void method_3()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_67(false);
		this.method_41();
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x000433C4 File Offset: 0x000415C4
	private void method_4()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-55))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)(-101)];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0004343C File Offset: 0x0004163C
	private void method_5()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)63)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)69];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x000434B4 File Offset: 0x000416B4
	private void method_6()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-120))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)36];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0004352C File Offset: 0x0004172C
	private void method_7(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_9() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_8();
				}
			}
		}
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x000435EC File Offset: 0x000417EC
	private void method_8()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)38)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Orange];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00043664 File Offset: 0x00041864
	private void method_9(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_2() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_70();
				}
			}
		}
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00043724 File Offset: 0x00041924
	private void method_10(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_19() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_92();
				}
			}
		}
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00004311 File Offset: 0x00002511
	private void method_11()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_32(true);
		this.method_44();
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x000437E4 File Offset: 0x000419E4
	private void method_12()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-119))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)(-128)];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0004385C File Offset: 0x00041A5C
	private void method_13(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_18();
				}
			}
		}
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0000432C File Offset: 0x0000252C
	private void method_14()
	{
		this.method_87(false);
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0004391C File Offset: 0x00041B1C
	private void method_15(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_5() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_68();
				}
			}
		}
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x000439DC File Offset: 0x00041BDC
	private void method_16()
	{
		if (this.buttonType >= ButtonTipIcons.Enum0.Start)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Start];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00043A54 File Offset: 0x00041C54
	private void method_17(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_4() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_20();
				}
			}
		}
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00043B14 File Offset: 0x00041D14
	private void method_18()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-101))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)109];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00043B8C File Offset: 0x00041D8C
	private void method_19(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_19() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_8();
				}
			}
		}
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00043C4C File Offset: 0x00041E4C
	private void method_20()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)24)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)46];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00043CC4 File Offset: 0x00041EC4
	private void method_21()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-18))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)(-37)];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00004335 File Offset: 0x00002535
	private void method_22()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_57(false);
		this.method_83();
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00004350 File Offset: 0x00002550
	private void method_23()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_87(false);
		this.method_18();
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00043D3C File Offset: 0x00041F3C
	private void method_24()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)55)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Blue];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00043DB4 File Offset: 0x00041FB4
	private void method_25(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_2() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_18();
				}
			}
		}
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00043E74 File Offset: 0x00042074
	private void method_26(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_14() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_79();
				}
			}
		}
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x0000436B File Offset: 0x0000256B
	private void method_27()
	{
		this.method_57(false);
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00043F34 File Offset: 0x00042134
	private void method_28(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_9() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_42();
				}
			}
		}
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00004374 File Offset: 0x00002574
	private void method_29()
	{
		this.method_87(true);
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00043FF4 File Offset: 0x000421F4
	private void method_30(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_11() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_76();
				}
			}
		}
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x000440B4 File Offset: 0x000422B4
	private void method_31()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-87))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)51];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x0004412C File Offset: 0x0004232C
	private void method_32(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_4() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_83();
				}
			}
		}
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x000441EC File Offset: 0x000423EC
	private void method_33()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-125))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)(-14)];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x0000437D File Offset: 0x0000257D
	private void method_34()
	{
		this.method_82(false);
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00004386 File Offset: 0x00002586
	private void method_35()
	{
		this.method_85(false);
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0000438F File Offset: 0x0000258F
	private void method_36()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_51(false);
		this.method_68();
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00044264 File Offset: 0x00042464
	private void method_37(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_4() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_60();
				}
			}
		}
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00044324 File Offset: 0x00042524
	private void method_38()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-91))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)(-41)];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00004374 File Offset: 0x00002574
	private void method_39()
	{
		this.method_87(true);
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x000043AA File Offset: 0x000025AA
	private void method_40()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_90(true);
		this.method_24();
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x0004439C File Offset: 0x0004259C
	private void method_41()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-51))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)(-81)];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00044414 File Offset: 0x00042614
	private void method_42()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)106)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)7];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000043C5 File Offset: 0x000025C5
	private void method_43()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_15(true);
		this.method_45();
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x0004448C File Offset: 0x0004268C
	private void method_44()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-110))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)76];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00044504 File Offset: 0x00042704
	private void method_45()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-126))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Spacebar];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x0004457C File Offset: 0x0004277C
	private void method_46()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-38))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)70];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x000043E0 File Offset: 0x000025E0
	private void method_47()
	{
		this.method_30(true);
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x000043E9 File Offset: 0x000025E9
	private void method_48()
	{
		this.method_32(true);
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x000043F2 File Offset: 0x000025F2
	private void method_49()
	{
		this.method_80(true);
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x000445F4 File Offset: 0x000427F4
	private void method_50()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)59)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Blue];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x0004466C File Offset: 0x0004286C
	private void method_51(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.Boolean_0 && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_16();
				}
			}
		}
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0000436B File Offset: 0x0000256B
	private void method_52()
	{
		this.method_57(false);
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x0004472C File Offset: 0x0004292C
	private void method_53(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_11() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_38();
				}
			}
		}
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x000043FB File Offset: 0x000025FB
	private void method_54()
	{
		this.method_19(true);
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00004404 File Offset: 0x00002604
	private void method_55()
	{
		this.method_80(false);
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0000440D File Offset: 0x0000260D
	private void method_56()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_89(false);
		this.method_68();
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x000447EC File Offset: 0x000429EC
	private void method_57(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_4() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_0();
				}
			}
		}
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00004428 File Offset: 0x00002628
	private void method_58()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_9(false);
		this.method_20();
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00004443 File Offset: 0x00002643
	private void method_59()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_89(false);
		this.method_50();
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x000448AC File Offset: 0x00042AAC
	private void method_60()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)18)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Select];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00044924 File Offset: 0x00042B24
	private void method_61()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-73))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)47];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x0004499C File Offset: 0x00042B9C
	private void method_62(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_17() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_46();
				}
			}
		}
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x0000445E File Offset: 0x0000265E
	private void method_63()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_82(true);
		this.method_83();
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00004479 File Offset: 0x00002679
	private void method_64()
	{
		this.method_10(true);
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00044A5C File Offset: 0x00042C5C
	private void method_65(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_14() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_70();
				}
			}
		}
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00004482 File Offset: 0x00002682
	private void Start()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_51(true);
		this.method_16();
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x0000449D File Offset: 0x0000269D
	private void method_66()
	{
		this.method_77(true);
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00044B1C File Offset: 0x00042D1C
	private void method_67(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_11() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_61();
				}
			}
		}
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00044BDC File Offset: 0x00042DDC
	private void method_68()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-21))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Orange];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x000044A6 File Offset: 0x000026A6
	private void method_69()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_80(true);
		this.method_42();
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00044C54 File Offset: 0x00042E54
	private void method_70()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)47)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)34];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x000044C1 File Offset: 0x000026C1
	private void method_71()
	{
		this.method_81(false);
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00044CCC File Offset: 0x00042ECC
	private void method_72()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)87)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - ButtonTipIcons.Enum0.Esc];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x000044CA File Offset: 0x000026CA
	private void method_73()
	{
		this.method_51(true);
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x000044D3 File Offset: 0x000026D3
	private void method_74()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_62(true);
		this.method_44();
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x000044EE File Offset: 0x000026EE
	private void method_75()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_82(true);
		this.method_79();
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00044D44 File Offset: 0x00042F44
	private void method_76()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-32))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)(-102)];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00044DBC File Offset: 0x00042FBC
	private void method_77(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.Boolean_0 && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_41();
				}
			}
		}
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00004509 File Offset: 0x00002709
	private void method_78()
	{
		this.method_67(true);
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00044E7C File Offset: 0x0004307C
	private void method_79()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)108)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)26];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00044EF4 File Offset: 0x000430F4
	private void method_80(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_17() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_6();
				}
			}
		}
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00044FB4 File Offset: 0x000431B4
	private void method_81(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_9() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_41();
				}
			}
		}
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00045074 File Offset: 0x00043274
	private void method_82(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_14() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_72();
				}
			}
		}
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00045134 File Offset: 0x00043334
	private void method_83()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-34))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)33];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00004512 File Offset: 0x00002712
	private void method_84()
	{
		this.method_77(false);
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x000451AC File Offset: 0x000433AC
	private void method_85(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_38();
				}
			}
		}
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x0000451B File Offset: 0x0000271B
	private void method_86()
	{
		this.method_37(true);
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x0004526C File Offset: 0x0004346C
	private void method_87(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_15() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_70();
				}
			}
		}
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00004524 File Offset: 0x00002724
	private void method_88()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_85(false);
		this.method_20();
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x0004532C File Offset: 0x0004352C
	private void method_89(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_5() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.GEnum7_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					this.method_6();
				}
			}
		}
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x000453EC File Offset: 0x000435EC
	private void method_90(bool bool_0 = false)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass.method_5() && gclass.gclass10_0 != null)
			{
				if (bool_0)
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.GEnum7_0;
					break;
				}
				if (gclass.player_0.GetAnyButton() && this.genum7_0 != gclass.gclass10_0.gclass5_7.method_11())
				{
					this.genum7_0 = gclass.gclass10_0.gclass5_7.method_11();
					this.method_61();
				}
			}
		}
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x0000453F File Offset: 0x0000273F
	private void Update()
	{
		this.method_51(false);
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00004548 File Offset: 0x00002748
	private void method_91()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_17(true);
		this.method_12();
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000454AC File Offset: 0x000436AC
	private void method_92()
	{
		if (this.buttonType >= (ButtonTipIcons.Enum0)(-64))
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_2[this.buttonType - (ButtonTipIcons.Enum0)100];
			return;
		}
		if (this.genum7_0 == GClass10.GEnum7.Guitar)
		{
			this.image_0.sprite = GlobalVariables.instance.sprite_0[(int)this.buttonType];
			return;
		}
		this.image_0.sprite = GlobalVariables.instance.sprite_1[(int)this.buttonType];
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00004563 File Offset: 0x00002763
	private void method_93()
	{
		this.image_0 = base.GetComponent<Image>();
		this.method_2(false);
		this.method_6();
	}

	// Token: 0x04000163 RID: 355
	private GClass10.GEnum7 genum7_0;

	// Token: 0x04000164 RID: 356
	private Image image_0;

	// Token: 0x04000165 RID: 357
	[SerializeField]
	private ButtonTipIcons.Enum0 buttonType;

	// Token: 0x0200002A RID: 42
	private enum Enum0
	{
		// Token: 0x04000167 RID: 359
		Green,
		// Token: 0x04000168 RID: 360
		Red,
		// Token: 0x04000169 RID: 361
		Yellow,
		// Token: 0x0400016A RID: 362
		Blue,
		// Token: 0x0400016B RID: 363
		Orange,
		// Token: 0x0400016C RID: 364
		W3,
		// Token: 0x0400016D RID: 365
		Start = 11,
		// Token: 0x0400016E RID: 366
		Select,
		// Token: 0x0400016F RID: 367
		Spacebar,
		// Token: 0x04000170 RID: 368
		Esc
	}
}
