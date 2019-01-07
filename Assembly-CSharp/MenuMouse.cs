using System;
using Rewired.UI.ControlMapper;
using UnityEngine;

// Token: 0x020000B1 RID: 177
public class MenuMouse : MonoBehaviour
{
	// Token: 0x06002242 RID: 8770 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_0()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x0000F69F File Offset: 0x0000D89F
	private void method_1()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_48;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_30;
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_2()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_3()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_4()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_5()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_6()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_7()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_8()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_9()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_10()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_11()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_12()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_13()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_14()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_15()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x0000F6D7 File Offset: 0x0000D8D7
	private void method_16()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_60;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_9;
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_17()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_18()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_19()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_20()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x0000F707 File Offset: 0x0000D907
	private void method_21()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_48;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_45;
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x0000F737 File Offset: 0x0000D937
	private void method_22()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_62;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_45;
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_23()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_24()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_25()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_26()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_27()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_28()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_29()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002261 RID: 8801 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_30()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_31()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x0000F767 File Offset: 0x0000D967
	private void method_32()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_44;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_31;
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_33()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x0000F797 File Offset: 0x0000D997
	private void Awake()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_35;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_45;
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x0000F7C7 File Offset: 0x0000D9C7
	private void method_34()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_48;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_53;
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_35()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_36()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x0000F7F7 File Offset: 0x0000D9F7
	private void method_37()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_29;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_57;
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_38()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_39()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_40()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x0000F827 File Offset: 0x0000DA27
	private void method_41()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_36;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_3;
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x0000F857 File Offset: 0x0000DA57
	private void method_42()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_26;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_31;
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_43()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_44()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_45()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_46()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x0000F887 File Offset: 0x0000DA87
	private void method_47()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_2;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_11;
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_48()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_49()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x0000F8B7 File Offset: 0x0000DAB7
	private void method_50()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_55;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_64;
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x0000F8E7 File Offset: 0x0000DAE7
	private void method_51()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_58;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_0;
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_52()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_53()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x0000F917 File Offset: 0x0000DB17
	private void method_54()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_13;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_10;
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_55()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_56()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_57()
	{
		Cursor.visible = true;
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_58()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x0000F947 File Offset: 0x0000DB47
	private void method_59()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_7;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_0;
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_60()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x0000F977 File Offset: 0x0000DB77
	private void method_61()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_12;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_0;
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_62()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x0000F9A7 File Offset: 0x0000DBA7
	private void method_63()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_23;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_66;
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_64()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x0000F9D7 File Offset: 0x0000DBD7
	private void method_65()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_17;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_45;
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_66()
	{
		Cursor.visible = true;
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_67()
	{
		Cursor.visible = false;
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x0000FA07 File Offset: 0x0000DC07
	private void method_68()
	{
		base.GetComponent<ControlMapper>().ScreenOpenedEvent += this.method_26;
		base.GetComponent<ControlMapper>().ScreenClosedEvent += this.method_53;
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x0000F6CF File Offset: 0x0000D8CF
	private void method_69()
	{
		Cursor.visible = false;
	}

	// Token: 0x0600228A RID: 8842 RVA: 0x0000F697 File Offset: 0x0000D897
	private void method_70()
	{
		Cursor.visible = true;
	}
}
