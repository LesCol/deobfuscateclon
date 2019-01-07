using System;
using UnityEngine;

// Token: 0x020000A9 RID: 169
public class NoteAnimator : MonoBehaviour
{
	// Token: 0x0600202E RID: 8238 RVA: 0x0000E75B File Offset: 0x0000C95B
	private void method_0()
	{
		this.float_0 = 591f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 985f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x00103900 File Offset: 0x00101B00
	public void method_1()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x0000E795 File Offset: 0x0000C995
	private void method_2()
	{
		this.float_0 = 655f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 1478f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x001039B8 File Offset: 0x00101BB8
	public void method_3()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x00103A70 File Offset: 0x00101C70
	public void method_4()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x0000E7CF File Offset: 0x0000C9CF
	private void method_5()
	{
		this.float_0 = 1656f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1373f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x00103900 File Offset: 0x00101B00
	public void method_6()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x00103B28 File Offset: 0x00101D28
	public void method_7()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x00103BE0 File Offset: 0x00101DE0
	public void method_8()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x00103C98 File Offset: 0x00101E98
	public void method_9()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x0000E809 File Offset: 0x0000CA09
	private void method_10()
	{
		this.float_0 = 343f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 1210f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x0000E843 File Offset: 0x0000CA43
	private void method_11()
	{
		this.float_0 = 463f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 1626f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x0000E87D File Offset: 0x0000CA7D
	private void method_12()
	{
		this.float_0 = 479f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 1023f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x00103D50 File Offset: 0x00101F50
	public void method_13()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x00103E08 File Offset: 0x00102008
	public void method_14()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x00103E08 File Offset: 0x00102008
	public void method_15()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x00103EC0 File Offset: 0x001020C0
	public void method_16()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x00103A70 File Offset: 0x00101C70
	public void method_17()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x00103F78 File Offset: 0x00102178
	public void method_18()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x0000E8B7 File Offset: 0x0000CAB7
	private void method_19()
	{
		this.float_0 = 494f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 673f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x0000E8F1 File Offset: 0x0000CAF1
	private void method_20()
	{
		this.float_0 = 1431f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 222f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x0000E92B File Offset: 0x0000CB2B
	private void method_21()
	{
		this.float_0 = 106f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 1728f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x0000E965 File Offset: 0x0000CB65
	private void method_22()
	{
		this.float_0 = 631f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 261f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x0000E99F File Offset: 0x0000CB9F
	private void method_23()
	{
		this.float_0 = 1354f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1252f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x00103C98 File Offset: 0x00101E98
	public void method_24()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x001039B8 File Offset: 0x00101BB8
	public void method_25()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x0000E9D9 File Offset: 0x0000CBD9
	private void Start()
	{
		this.float_0 = 1f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 1f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x00104030 File Offset: 0x00102230
	public void method_26()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x0000EA13 File Offset: 0x0000CC13
	private void method_27()
	{
		this.float_0 = 1717f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1895f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x0600204B RID: 8267 RVA: 0x0000EA4D File Offset: 0x0000CC4D
	private void method_28()
	{
		this.float_0 = 1420f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 1561f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x00103E08 File Offset: 0x00102008
	public void method_29()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x0000EA87 File Offset: 0x0000CC87
	private void method_30()
	{
		this.float_0 = 1359f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1091f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x0000EAC1 File Offset: 0x0000CCC1
	private void method_31()
	{
		this.float_0 = 1122f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1514f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x001040E8 File Offset: 0x001022E8
	public void method_32()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x001041A0 File Offset: 0x001023A0
	public void method_33()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x0000EAFB File Offset: 0x0000CCFB
	private void method_34()
	{
		this.float_0 = 473f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 515f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x001039B8 File Offset: 0x00101BB8
	public void method_35()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x0000EB35 File Offset: 0x0000CD35
	private void method_36()
	{
		this.float_0 = 1335f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 1540f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x00104258 File Offset: 0x00102458
	public void method_37()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x0000EB6F File Offset: 0x0000CD6F
	private void method_38()
	{
		this.float_0 = 1783f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 1907f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x00103D50 File Offset: 0x00101F50
	public void method_39()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x00103EC0 File Offset: 0x001020C0
	public void method_40()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x00104258 File Offset: 0x00102458
	public void method_41()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x00103D50 File Offset: 0x00101F50
	public void method_42()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x0000EBA9 File Offset: 0x0000CDA9
	private void method_43()
	{
		this.float_0 = 836f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1769f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x0000EBE3 File Offset: 0x0000CDE3
	private void method_44()
	{
		this.float_0 = 1000f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 1361f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x0000EC1D File Offset: 0x0000CE1D
	private void method_45()
	{
		this.float_0 = 1195f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 675f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x00103A70 File Offset: 0x00101C70
	public void method_46()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x0600205E RID: 8286 RVA: 0x0000EC57 File Offset: 0x0000CE57
	private void method_47()
	{
		this.float_0 = 874f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1050f / (float)GlobalVariables.instance.gclass5_40.method_25();
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x00103E08 File Offset: 0x00102008
	public void method_48()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002061 RID: 8289 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	private void method_49()
	{
		this.float_0 = 1469f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 1645f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002062 RID: 8290 RVA: 0x00104258 File Offset: 0x00102458
	public void method_50()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x0000ECDB File Offset: 0x0000CEDB
	private void method_51()
	{
		this.float_0 = 413f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 21f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x00103C98 File Offset: 0x00101E98
	public void method_52()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x00103900 File Offset: 0x00101B00
	public void method_53()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x00103A70 File Offset: 0x00101C70
	public void method_54()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x0000ED15 File Offset: 0x0000CF15
	private void method_55()
	{
		this.float_0 = 1165f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 143f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x00104258 File Offset: 0x00102458
	public void method_56()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002069 RID: 8297 RVA: 0x001041A0 File Offset: 0x001023A0
	public void method_57()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x0000ED4F File Offset: 0x0000CF4F
	private void method_58()
	{
		this.float_0 = 1607f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 1066f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x0000ED89 File Offset: 0x0000CF89
	private void method_59()
	{
		this.float_0 = 565f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 733f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x00103D50 File Offset: 0x00101F50
	public void method_60()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2++;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x0000EDC3 File Offset: 0x0000CFC3
	private void method_61()
	{
		this.float_0 = 1092f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1804f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x00103E08 File Offset: 0x00102008
	public void method_62()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 0;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 0;
			}
		}
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x00103A70 File Offset: 0x00101C70
	public void method_63()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1 += 0;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x0000EDFD File Offset: 0x0000CFFD
	private void method_64()
	{
		this.float_0 = 1002f / (float)GlobalVariables.instance.gclass5_39.CurrentValue;
		this.float_1 = 355f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x00103C98 File Offset: 0x00101E98
	public void method_65()
	{
		this.float_3 += Time.deltaTime;
		this.float_2 += Time.deltaTime;
		while (this.float_3 >= this.float_0)
		{
			this.float_3 -= this.float_0;
			NoteAnimator.int_1++;
			if (NoteAnimator.int_1 == this.int_0)
			{
				NoteAnimator.int_1 = 1;
			}
		}
		while (this.float_2 >= this.float_1)
		{
			this.float_2 -= this.float_1;
			NoteAnimator.int_2 += 0;
			if (NoteAnimator.int_2 == this.int_0)
			{
				NoteAnimator.int_2 = 1;
			}
		}
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x0000EE37 File Offset: 0x0000D037
	private void method_66()
	{
		this.float_0 = 1571f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 197f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x0000EE71 File Offset: 0x0000D071
	private void method_67()
	{
		this.float_0 = 1586f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 910f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x0000EEAB File Offset: 0x0000D0AB
	private void method_68()
	{
		this.float_0 = 289f / (float)GlobalVariables.instance.gclass5_39.method_5();
		this.float_1 = 1484f / (float)GlobalVariables.instance.gclass5_40.method_5();
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x0000EEE5 File Offset: 0x0000D0E5
	private void method_69()
	{
		this.float_0 = 1818f / (float)GlobalVariables.instance.gclass5_39.method_25();
		this.float_1 = 92f / (float)GlobalVariables.instance.gclass5_40.CurrentValue;
	}

	// Token: 0x04000527 RID: 1319
	private int int_0 = 16;

	// Token: 0x04000528 RID: 1320
	private float float_0;

	// Token: 0x04000529 RID: 1321
	private float float_1;

	// Token: 0x0400052A RID: 1322
	private float float_2;

	// Token: 0x0400052B RID: 1323
	private float float_3;

	// Token: 0x0400052C RID: 1324
	public static int int_1;

	// Token: 0x0400052D RID: 1325
	public static int int_2;
}
