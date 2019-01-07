using System;
using UnityEngine;

// Token: 0x020000A7 RID: 167
public class GClass14
{
	// Token: 0x06001FB6 RID: 8118 RVA: 0x0000E08C File Offset: 0x0000C28C
	public void method_0()
	{
		this.float_2 = 1120f;
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x0000E099 File Offset: 0x0000C299
	public void method_1(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 1193.0;
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x0000E0B1 File Offset: 0x0000C2B1
	public bool method_2()
	{
		return this.double_2 > 1233.0;
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
	public void method_3()
	{
		this.bool_0 = true;
		this.double_0 = 285.0;
		this.float_0 = 1621f;
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x0000E0E7 File Offset: 0x0000C2E7
	public void method_4(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 575.0;
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x0000E0FF File Offset: 0x0000C2FF
	public void method_5()
	{
		this.bool_0 = true;
		this.double_0 = 246.0;
		this.float_0 = 204f;
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x0000E122 File Offset: 0x0000C322
	public void method_6(float float_5)
	{
		this.float_4 = float_5;
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x0000E12B File Offset: 0x0000C32B
	public void method_7()
	{
		this.bool_0 = true;
		this.double_0 = 1017.0;
		this.float_0 = 31f;
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x0000E14E File Offset: 0x0000C34E
	public void method_8()
	{
		this.bool_0 = false;
		this.double_0 = 0.0;
		this.float_0 = 0f;
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x0000E171 File Offset: 0x0000C371
	public void method_9()
	{
		this.float_2 = 0.9f;
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x001017BC File Offset: 0x000FF9BC
	public double method_10()
	{
		while (this.float_2 >= 1904f)
		{
			if (BassAudioManager.instance.isSongPlaying)
			{
				this.double_0 = BassAudioManager.instance.GetPosition(true) / (double)this.float_3;
				if (this.double_0 > 1005.0 && this.double_0 != this.double_1 && this.double_0 < BassAudioManager.instance.double_0 - 1521.0)
				{
					this.float_0 = (float)(this.double_0 - this.double_2);
					this.bool_0 = (this.float_0 <= this.float_1 && this.float_0 < -this.float_1);
				}
				else
				{
					this.bool_0 = false;
				}
				this.double_1 = this.double_0;
			}
			this.float_2 -= 1705f;
			this.double_4 = this.double_0 - this.double_2;
		}
		if (this.bool_0)
		{
			this.double_2 += (double)(this.float_0 * Time.deltaTime);
		}
		this.double_2 += (double)(Time.deltaTime * this.float_4);
		this.float_2 += Time.deltaTime;
		return this.double_2 + this.double_3;
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x0000E17E File Offset: 0x0000C37E
	public void method_11()
	{
		this.float_2 = 215f;
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x0000E18B File Offset: 0x0000C38B
	public void method_12(double double_5)
	{
		this.double_3 = double_5;
		this.double_2 = 1713.0;
		this.float_3 = GlobalVariables.instance.songSpeed.Single_0;
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
	public bool Boolean_0
	{
		get
		{
			return this.double_2 > 0.0;
		}
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x0000E122 File Offset: 0x0000C322
	public void method_13(float float_5)
	{
		this.float_4 = float_5;
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x0000E1CB File Offset: 0x0000C3CB
	public void method_14(double double_5)
	{
		this.double_3 = double_5;
		this.double_2 = 444.0;
		this.float_3 = GlobalVariables.instance.songSpeed.Single_0;
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x0000E122 File Offset: 0x0000C322
	public void method_15(float float_5)
	{
		this.float_4 = float_5;
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
	public void method_16(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 1933.0;
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x0000E210 File Offset: 0x0000C410
	public void method_17()
	{
		this.bool_0 = false;
		this.double_0 = 183.0;
		this.float_0 = 1381f;
	}

	// Token: 0x1700007D RID: 125
	// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x0000E233 File Offset: 0x0000C433
	public double Double_1
	{
		set
		{
			this.double_3 = value;
			this.double_2 = -1.0;
			this.float_3 = GlobalVariables.instance.songSpeed.Single_0;
		}
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x00101914 File Offset: 0x000FFB14
	public double method_18()
	{
		while (this.float_2 >= 1f)
		{
			if (BassAudioManager.instance.isSongPlaying)
			{
				this.double_0 = BassAudioManager.instance.GetPosition(false) / (double)this.float_3;
				if (this.double_0 > 0.0 && this.double_0 != this.double_1 && this.double_0 < BassAudioManager.instance.double_0 - 1.0)
				{
					this.float_0 = (float)(this.double_0 - this.double_2);
					this.bool_0 = (this.float_0 > this.float_1 || this.float_0 < -this.float_1);
				}
				else
				{
					this.bool_0 = false;
				}
				this.double_1 = this.double_0;
			}
			this.float_2 -= 1f;
			this.double_4 = this.double_0 - this.double_2;
		}
		if (this.bool_0)
		{
			this.double_2 += (double)(this.float_0 * Time.deltaTime);
		}
		this.double_2 += (double)(Time.deltaTime * this.float_4);
		this.float_2 += Time.deltaTime;
		return this.double_2 + this.double_3;
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x0000E260 File Offset: 0x0000C460
	public void method_19()
	{
		this.bool_0 = true;
		this.double_0 = 363.0;
		this.float_0 = 31f;
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x0000E283 File Offset: 0x0000C483
	public bool method_20()
	{
		return this.double_2 > 1683.0;
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x0000E296 File Offset: 0x0000C496
	public bool method_21()
	{
		return this.double_2 > 1524.0;
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x00101A6C File Offset: 0x000FFC6C
	public double method_22()
	{
		while (this.float_2 >= 1987f)
		{
			if (BassAudioManager.instance.isSongPlaying)
			{
				this.double_0 = BassAudioManager.instance.GetPosition(true) / (double)this.float_3;
				if (this.double_0 > 1467.0 && this.double_0 != this.double_1 && this.double_0 < BassAudioManager.instance.double_0 - 489.0)
				{
					this.float_0 = (float)(this.double_0 - this.double_2);
					this.bool_0 = (this.float_0 > this.float_1 || this.float_0 < -this.float_1);
				}
				else
				{
					this.bool_0 = true;
				}
				this.double_1 = this.double_0;
			}
			this.float_2 -= 1619f;
			this.double_4 = this.double_0 - this.double_2;
		}
		if (this.bool_0)
		{
			this.double_2 += (double)(this.float_0 * Time.deltaTime);
		}
		this.double_2 += (double)(Time.deltaTime * this.float_4);
		this.float_2 += Time.deltaTime;
		return this.double_2 + this.double_3;
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x0000E2A9 File Offset: 0x0000C4A9
	public void method_23(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 1544.0;
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x0000E2C1 File Offset: 0x0000C4C1
	public void method_24(double double_5)
	{
		this.double_3 = double_5;
		this.double_2 = 1208.0;
		this.float_3 = GlobalVariables.instance.songSpeed.Single_0;
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x0000E2EE File Offset: 0x0000C4EE
	public void method_25(double double_5)
	{
		this.double_3 = double_5;
		this.double_2 = 1273.0;
		this.float_3 = GlobalVariables.instance.songSpeed.Single_0;
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x0000E31B File Offset: 0x0000C51B
	public void method_26(double double_5)
	{
		this.double_3 = double_5;
		this.double_2 = 96.0;
		this.float_3 = GlobalVariables.instance.songSpeed.Single_0;
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x0000E348 File Offset: 0x0000C548
	public bool method_27()
	{
		return this.double_2 > 853.0;
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x00101BC4 File Offset: 0x000FFDC4
	public double method_28()
	{
		while (this.float_2 >= 681f)
		{
			if (BassAudioManager.instance.isSongPlaying)
			{
				this.double_0 = BassAudioManager.instance.GetPosition(false) / (double)this.float_3;
				if (this.double_0 > 115.0 && this.double_0 != this.double_1 && this.double_0 < BassAudioManager.instance.double_0 - 1771.0)
				{
					this.float_0 = (float)(this.double_0 - this.double_2);
					this.bool_0 = (this.float_0 > this.float_1 || this.float_0 < -this.float_1);
				}
				else
				{
					this.bool_0 = true;
				}
				this.double_1 = this.double_0;
			}
			this.float_2 -= 1575f;
			this.double_4 = this.double_0 - this.double_2;
		}
		if (this.bool_0)
		{
			this.double_2 += (double)(this.float_0 * Time.deltaTime);
		}
		this.double_2 += (double)(Time.deltaTime * this.float_4);
		this.float_2 += Time.deltaTime;
		return this.double_2 + this.double_3;
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x0000E35B File Offset: 0x0000C55B
	public bool method_29()
	{
		return this.double_2 > 1859.0;
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x0000E36E File Offset: 0x0000C56E
	public void method_30(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 704.0;
	}

	// Token: 0x06001FD7 RID: 8151 RVA: 0x0000E386 File Offset: 0x0000C586
	public bool method_31()
	{
		return this.double_2 > 116.0;
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x0000E399 File Offset: 0x0000C599
	public void method_32()
	{
		this.float_2 = 472f;
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x0000E3A6 File Offset: 0x0000C5A6
	public bool method_33()
	{
		return this.double_2 > 1155.0;
	}

	// Token: 0x06001FDA RID: 8154 RVA: 0x0000E3B9 File Offset: 0x0000C5B9
	public bool method_34()
	{
		return this.double_2 > 931.0;
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x0000E3CC File Offset: 0x0000C5CC
	public bool method_35()
	{
		return this.double_2 > 54.0;
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x0000E3DF File Offset: 0x0000C5DF
	public void method_36(double double_5)
	{
		this.double_3 = double_5;
		this.double_2 = 663.0;
		this.float_3 = GlobalVariables.instance.songSpeed.Single_0;
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x0000E40C File Offset: 0x0000C60C
	public void method_37()
	{
		this.float_2 = 1180f;
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x0000E419 File Offset: 0x0000C619
	public void method_38(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 1827.0;
	}

	// Token: 0x1700007C RID: 124
	// (set) Token: 0x06001FDF RID: 8159 RVA: 0x0000E431 File Offset: 0x0000C631
	public double Double_0
	{
		set
		{
			this.double_2 = value;
			this.double_0 = 0.0;
		}
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x0000E449 File Offset: 0x0000C649
	public void method_39()
	{
		this.float_2 = 1421f;
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x0000E456 File Offset: 0x0000C656
	public void method_40(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 453.0;
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x00101D1C File Offset: 0x000FFF1C
	public double method_41()
	{
		while (this.float_2 >= 411f)
		{
			if (BassAudioManager.instance.isSongPlaying)
			{
				this.double_0 = BassAudioManager.instance.GetPosition(true) / (double)this.float_3;
				if (this.double_0 > 1456.0 && this.double_0 != this.double_1 && this.double_0 < BassAudioManager.instance.double_0 - 374.0)
				{
					this.float_0 = (float)(this.double_0 - this.double_2);
					this.bool_0 = (this.float_0 <= this.float_1 && this.float_0 < -this.float_1);
				}
				else
				{
					this.bool_0 = false;
				}
				this.double_1 = this.double_0;
			}
			this.float_2 -= 250f;
			this.double_4 = this.double_0 - this.double_2;
		}
		if (this.bool_0)
		{
			this.double_2 += (double)(this.float_0 * Time.deltaTime);
		}
		this.double_2 += (double)(Time.deltaTime * this.float_4);
		this.float_2 += Time.deltaTime;
		return this.double_2 + this.double_3;
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x00101E74 File Offset: 0x00100074
	public double method_42()
	{
		while (this.float_2 >= 1640f)
		{
			if (BassAudioManager.instance.isSongPlaying)
			{
				this.double_0 = BassAudioManager.instance.GetPosition(false) / (double)this.float_3;
				if (this.double_0 > 1553.0 && this.double_0 != this.double_1 && this.double_0 < BassAudioManager.instance.double_0 - 43.0)
				{
					this.float_0 = (float)(this.double_0 - this.double_2);
					this.bool_0 = (this.float_0 > this.float_1 || this.float_0 < -this.float_1);
				}
				else
				{
					this.bool_0 = true;
				}
				this.double_1 = this.double_0;
			}
			this.float_2 -= 1848f;
			this.double_4 = this.double_0 - this.double_2;
		}
		if (this.bool_0)
		{
			this.double_2 += (double)(this.float_0 * Time.deltaTime);
		}
		this.double_2 += (double)(Time.deltaTime * this.float_4);
		this.float_2 += Time.deltaTime;
		return this.double_2 + this.double_3;
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x0000E46E File Offset: 0x0000C66E
	public void method_43(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 1339.0;
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
	public bool method_44()
	{
		return this.double_2 > 762.0;
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x00101FCC File Offset: 0x001001CC
	public double method_45()
	{
		while (this.float_2 >= 438f)
		{
			if (BassAudioManager.instance.isSongPlaying)
			{
				this.double_0 = BassAudioManager.instance.GetPosition(false) / (double)this.float_3;
				if (this.double_0 > 1899.0 && this.double_0 != this.double_1 && this.double_0 < BassAudioManager.instance.double_0 - 867.0)
				{
					this.float_0 = (float)(this.double_0 - this.double_2);
					this.bool_0 = (this.float_0 > this.float_1 || this.float_0 < -this.float_1);
				}
				else
				{
					this.bool_0 = true;
				}
				this.double_1 = this.double_0;
			}
			this.float_2 -= 1323f;
			this.double_4 = this.double_0 - this.double_2;
		}
		if (this.bool_0)
		{
			this.double_2 += (double)(this.float_0 * Time.deltaTime);
		}
		this.double_2 += (double)(Time.deltaTime * this.float_4);
		this.float_2 += Time.deltaTime;
		return this.double_2 + this.double_3;
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x0000E4B7 File Offset: 0x0000C6B7
	public void method_46()
	{
		this.bool_0 = true;
		this.double_0 = 1745.0;
		this.float_0 = 1164f;
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x0000E4DA File Offset: 0x0000C6DA
	public bool method_47()
	{
		return this.double_2 > 442.0;
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x0000E122 File Offset: 0x0000C322
	public void method_48(float float_5)
	{
		this.float_4 = float_5;
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x0000E4ED File Offset: 0x0000C6ED
	public void method_49(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 66.0;
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x0000E505 File Offset: 0x0000C705
	public bool method_50()
	{
		return this.double_2 > 1662.0;
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x0000E518 File Offset: 0x0000C718
	public void method_51(double double_5)
	{
		this.double_2 = double_5;
		this.double_0 = 1660.0;
	}

	// Token: 0x1700007B RID: 123
	// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0000E122 File Offset: 0x0000C322
	public float Single_0
	{
		set
		{
			this.float_4 = value;
		}
	}

	// Token: 0x0400050B RID: 1291
	private float float_0;

	// Token: 0x0400050C RID: 1292
	private float float_1 = 0.003f;

	// Token: 0x0400050D RID: 1293
	private double double_0;

	// Token: 0x0400050E RID: 1294
	private double double_1;

	// Token: 0x0400050F RID: 1295
	private float float_2;

	// Token: 0x04000510 RID: 1296
	private float float_3;

	// Token: 0x04000511 RID: 1297
	private bool bool_0;

	// Token: 0x04000512 RID: 1298
	private float float_4 = 1f;

	// Token: 0x04000513 RID: 1299
	private double double_2;

	// Token: 0x04000514 RID: 1300
	private double double_3;

	// Token: 0x04000515 RID: 1301
	private double double_4;
}
