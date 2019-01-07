using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

// Token: 0x020000AC RID: 172
public class BlackMenu : MonoBehaviour
{
	// Token: 0x0600210E RID: 8462 RVA: 0x0000F1EE File Offset: 0x0000D3EE
	private void method_0()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_37(false);
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x0000F20F File Offset: 0x0000D40F
	private void method_1()
	{
		this.method_63(true);
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x00109B0C File Offset: 0x00107D0C
	public void method_2(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x0000F218 File Offset: 0x0000D418
	private void method_3()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_16(false);
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x0000F239 File Offset: 0x0000D439
	private void method_4()
	{
		this.method_14(false);
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x00109BE8 File Offset: 0x00107DE8
	public void method_5(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x0000F242 File Offset: 0x0000D442
	private void method_6()
	{
		this.method_55(false);
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x00109CC4 File Offset: 0x00107EC4
	public void method_7(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x00109DA0 File Offset: 0x00107FA0
	public void method_8(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x00109E7C File Offset: 0x0010807C
	public void method_9(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x0000F24B File Offset: 0x0000D44B
	private void method_10()
	{
		this.method_15(false);
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x0000F254 File Offset: 0x0000D454
	private void method_11()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_81(false);
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x0000F275 File Offset: 0x0000D475
	private void method_12()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_65(true);
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x00109F58 File Offset: 0x00108158
	public void method_13(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x0010A034 File Offset: 0x00108234
	public void method_14(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x0010A110 File Offset: 0x00108310
	public void method_15(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x0010A1EC File Offset: 0x001083EC
	public void method_16(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x0000F218 File Offset: 0x0000D418
	private void method_17()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_16(false);
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x0000F296 File Offset: 0x0000D496
	private void method_18()
	{
		this.method_9(true);
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x0000F29F File Offset: 0x0000D49F
	private void method_19()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_43(true);
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
	private void method_20()
	{
		this.method_81(false);
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x0000F2C9 File Offset: 0x0000D4C9
	private void method_21()
	{
		this.method_15(true);
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x0000F2D2 File Offset: 0x0000D4D2
	private void method_22()
	{
		this.method_65(true);
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x0000F2DB File Offset: 0x0000D4DB
	private void Start()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_9(true);
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x0000F2FC File Offset: 0x0000D4FC
	private void method_23()
	{
		this.method_9(false);
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x0000F20F File Offset: 0x0000D40F
	private void method_24()
	{
		this.method_63(true);
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x0000F1EE File Offset: 0x0000D3EE
	private void method_25()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_37(false);
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x0000F305 File Offset: 0x0000D505
	private void method_26()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_9(false);
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x0000F326 File Offset: 0x0000D526
	private void method_27()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_62(true);
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x0000F347 File Offset: 0x0000D547
	private void method_28()
	{
		this.method_16(true);
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x0000F350 File Offset: 0x0000D550
	private void method_29()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_77(true);
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x0000F371 File Offset: 0x0000D571
	private void method_30()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_54(true);
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x0010A2C8 File Offset: 0x001084C8
	public void method_31(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x0000F392 File Offset: 0x0000D592
	private void method_32()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_33(true);
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x0010A3A4 File Offset: 0x001085A4
	public void method_33(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x0010A480 File Offset: 0x00108680
	public void method_34(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x0010A55C File Offset: 0x0010875C
	public void method_35(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x0000F3B3 File Offset: 0x0000D5B3
	private void method_36()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_69(false);
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x0010A638 File Offset: 0x00108838
	public void method_37(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
	private void method_38()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_39(true);
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x0010A714 File Offset: 0x00108914
	public void method_39(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x0000F3F5 File Offset: 0x0000D5F5
	private void method_40()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_2(true);
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x0000F416 File Offset: 0x0000D616
	private void method_41()
	{
		this.method_31(true);
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x0000F41F File Offset: 0x0000D61F
	private void method_42()
	{
		this.method_77(false);
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x0010A7F0 File Offset: 0x001089F0
	public void method_43(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x0000F428 File Offset: 0x0000D628
	private void method_44()
	{
		this.method_47(false);
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x0000F431 File Offset: 0x0000D631
	private void method_45()
	{
		this.method_43(false);
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x0000F43A File Offset: 0x0000D63A
	private void method_46()
	{
		this.method_37(true);
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x0010A8CC File Offset: 0x00108ACC
	public void method_47(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x0000F443 File Offset: 0x0000D643
	private void method_48()
	{
		this.method_5(false);
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x0000F254 File Offset: 0x0000D454
	private void method_49()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_81(false);
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x0000F44C File Offset: 0x0000D64C
	private void method_50()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_13(true);
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x0000F46D File Offset: 0x0000D66D
	private void method_51()
	{
		this.method_39(true);
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x0000F476 File Offset: 0x0000D676
	private void method_52()
	{
		this.method_74(true);
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x0000F2DB File Offset: 0x0000D4DB
	private void method_53()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_9(true);
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x0010A9A8 File Offset: 0x00108BA8
	public void method_54(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x0010AA84 File Offset: 0x00108C84
	public void method_55(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x0010AB60 File Offset: 0x00108D60
	public void method_56(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x0000F47F File Offset: 0x0000D67F
	private void method_57()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_35(false);
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
	private void method_58()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_69(true);
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x0000F4C1 File Offset: 0x0000D6C1
	private void method_59()
	{
		this.method_33(false);
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x0000F4CA File Offset: 0x0000D6CA
	private void method_60()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_54(false);
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x0000F4EB File Offset: 0x0000D6EB
	private void method_61()
	{
		this.method_14(true);
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x0010AC3C File Offset: 0x00108E3C
	public void method_62(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x0010AD18 File Offset: 0x00108F18
	public void method_63(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
	private void method_64()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_7(false);
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x0010ADF4 File Offset: 0x00108FF4
	public void method_65(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x0010AED0 File Offset: 0x001090D0
	public void method_66(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_5())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_25();
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x0000F2FC File Offset: 0x0000D4FC
	private void FixedUpdate()
	{
		this.method_9(false);
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x0010AFAC File Offset: 0x001091AC
	public void method_67(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_25())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x0000F515 File Offset: 0x0000D715
	private void method_68()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_35(true);
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x0010B088 File Offset: 0x00109288
	public void method_69(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x0000F536 File Offset: 0x0000D736
	private void method_70()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_66(false);
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x0000F557 File Offset: 0x0000D757
	private void method_71()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_8(false);
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x0000F578 File Offset: 0x0000D778
	private void method_72()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_82(true);
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x0000F47F File Offset: 0x0000D67F
	private void method_73()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_35(false);
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x0010B164 File Offset: 0x00109364
	public void method_74(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.method_25())
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.method_5())
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x0000F599 File Offset: 0x0000D799
	private void method_75()
	{
		this.method_7(true);
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x0000F5A2 File Offset: 0x0000D7A2
	private void method_76()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_67(true);
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x0010B240 File Offset: 0x00109440
	public void method_77(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = false;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.method_5();
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
	private void method_78()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_7(false);
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x0000F5C3 File Offset: 0x0000D7C3
	private void method_79()
	{
		this.method_34(true);
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x0000F5CC File Offset: 0x0000D7CC
	private void method_80()
	{
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.image_0 = base.GetComponent<Image>();
		this.method_47(true);
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x0010B31C File Offset: 0x0010951C
	public void method_81(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x0010B3F8 File Offset: 0x001095F8
	public void method_82(bool bool_0)
	{
		if (!bool_0 && this.int_0 == GlobalVariables.instance.gclass5_38.CurrentValue)
		{
			return;
		}
		switch (GlobalVariables.instance.gclass5_38.CurrentValue)
		{
		case 0:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = true;
			}
			break;
		case 1:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		case 2:
			if (this.videoPlayer_0)
			{
				this.videoPlayer_0.enabled = true;
			}
			else
			{
				this.image_0.enabled = false;
			}
			break;
		}
		this.int_0 = GlobalVariables.instance.gclass5_38.CurrentValue;
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x0000F4C1 File Offset: 0x0000D6C1
	private void method_83()
	{
		this.method_33(false);
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x0000F5ED File Offset: 0x0000D7ED
	private void method_84()
	{
		this.method_67(true);
	}

	// Token: 0x04000559 RID: 1369
	private VideoPlayer videoPlayer_0;

	// Token: 0x0400055A RID: 1370
	private Image image_0;

	// Token: 0x0400055B RID: 1371
	private int int_0;
}
