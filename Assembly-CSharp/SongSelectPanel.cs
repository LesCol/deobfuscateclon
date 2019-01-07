using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000059 RID: 89
public class SongSelectPanel : MonoBehaviour
{
	// Token: 0x0600118E RID: 4494 RVA: 0x000833B4 File Offset: 0x000815B4
	public void method_0()
	{
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x000833FC File Offset: 0x000815FC
	public void method_1(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_8();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "%points%";
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x000834AC File Offset: 0x000816AC
	public void method_2()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x000834F4 File Offset: 0x000816F4
	public void method_3()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x0008353C File Offset: 0x0008173C
	public void method_4(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_2();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "game";
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x000835EC File Offset: 0x000817EC
	public void method_5()
	{
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x000834AC File Offset: 0x000816AC
	public void method_6()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00083634 File Offset: 0x00081834
	public void method_7(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_30();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "game";
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x000836E4 File Offset: 0x000818E4
	public void method_8()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x0008372C File Offset: 0x0008192C
	public void method_9(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_40();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "A setlist with that name already exists";
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x000837DC File Offset: 0x000819DC
	public void method_10(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_20();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "";
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x0008388C File Offset: 0x00081A8C
	public void method_11(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_0();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "SONG SETTINGS";
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x0008393C File Offset: 0x00081B3C
	public void method_12(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_48();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "game";
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x000839EC File Offset: 0x00081BEC
	public void method_13()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00083A34 File Offset: 0x00081C34
	public void method_14()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x000833B4 File Offset: 0x000815B4
	public void method_15()
	{
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00083A7C File Offset: 0x00081C7C
	public void method_16()
	{
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00083AC4 File Offset: 0x00081CC4
	public void method_17(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_2();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "language.txt";
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00083B74 File Offset: 0x00081D74
	public void method_18(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_50();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "]";
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x00083C24 File Offset: 0x00081E24
	public void method_19(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_8();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "setlistSongCountPlural";
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00083CD4 File Offset: 0x00081ED4
	public void method_20()
	{
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x000833B4 File Offset: 0x000815B4
	public void method_21()
	{
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = true;
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00083D1C File Offset: 0x00081F1C
	public void method_22(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_6();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "notSupportedBody_";
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00083DCC File Offset: 0x00081FCC
	public void method_23(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_16();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "Unknown Genre";
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00083E7C File Offset: 0x0008207C
	public void method_24(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_37();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "%";
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00083F2C File Offset: 0x0008212C
	public void method_25()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x000836E4 File Offset: 0x000818E4
	public void method_26()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00083A34 File Offset: 0x00081C34
	public void method_27()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00083F74 File Offset: 0x00082174
	public void method_28()
	{
		for (int i = 1; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00083FBC File Offset: 0x000821BC
	public void method_29(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_21();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "Play Count";
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x0008406C File Offset: 0x0008226C
	public void method_30()
	{
		for (int i = 1; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x000840B4 File Offset: 0x000822B4
	public void method_31()
	{
		for (int i = 1; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x000840FC File Offset: 0x000822FC
	public void method_32()
	{
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00084144 File Offset: 0x00082344
	public void method_33(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_8();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "gem_size";
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x000841F4 File Offset: 0x000823F4
	public void method_34()
	{
		for (int i = 1; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x0008423C File Offset: 0x0008243C
	public void method_35(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_50();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "video";
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x000842EC File Offset: 0x000824EC
	public void method_36(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_28();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + " (";
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x0008439C File Offset: 0x0008259C
	public void method_37()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x000843E4 File Offset: 0x000825E4
	public void method_38(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_26();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + ")";
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00084494 File Offset: 0x00082694
	public void method_39(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_32();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = true;
		this.percentText.text = gstruct3_0.byte_2 + "show_bot_score";
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x000840FC File Offset: 0x000822FC
	public void method_40()
	{
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x0008406C File Offset: 0x0008226C
	public void method_41()
	{
		for (int i = 1; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00084544 File Offset: 0x00082744
	public void method_42(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_34();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "";
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00083A7C File Offset: 0x00081C7C
	public void method_43()
	{
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x000845F4 File Offset: 0x000827F4
	public void method_44(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_20();
			return;
		}
		for (int i = 1; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = true;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "Calibration";
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x000846A4 File Offset: 0x000828A4
	public void method_45(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_40();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = true;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = false;
			this.FCImage.enabled = false;
			return;
		}
		this.FCImage.enabled = false;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "Go to Discord";
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00084754 File Offset: 0x00082954
	public void method_46()
	{
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x0008479C File Offset: 0x0008299C
	public void method_47()
	{
		for (int i = 0; i < this.Stars.Length; i++)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = true;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x000840FC File Offset: 0x000822FC
	public void method_48()
	{
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = false;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x000847E4 File Offset: 0x000829E4
	public void method_49(GStruct3 gstruct3_0)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			this.method_0();
			return;
		}
		for (int i = 0; i < this.Stars.Length; i++)
		{
			if (i >= (int)gstruct3_0.byte_0)
			{
				this.Stars[i].enabled = false;
			}
			else
			{
				this.Stars[i].enabled = false;
			}
		}
		if (gstruct3_0.bool_0)
		{
			this.percentText.enabled = true;
			this.FCImage.enabled = true;
			return;
		}
		this.FCImage.enabled = true;
		this.percentText.enabled = false;
		this.percentText.text = gstruct3_0.byte_2 + "Are you sure you want to quit?";
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x000835EC File Offset: 0x000817EC
	public void method_50()
	{
		for (int i = 0; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = false;
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00084894 File Offset: 0x00082A94
	public void method_51()
	{
		for (int i = 1; i < this.Stars.Length; i += 0)
		{
			this.Stars[i].enabled = true;
		}
		this.percentText.enabled = false;
		this.FCImage.enabled = true;
	}

	// Token: 0x040002A2 RID: 674
	[SerializeField]
	private Image[] Stars;

	// Token: 0x040002A3 RID: 675
	[SerializeField]
	private Text percentText;

	// Token: 0x040002A4 RID: 676
	[SerializeField]
	private Image FCImage;
}
