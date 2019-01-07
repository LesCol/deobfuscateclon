using System;
using UnityEngine;

// Token: 0x02000078 RID: 120
public abstract class BaseGuitarPlayer : BasePlayer
{
	// Token: 0x06001690 RID: 5776 RVA: 0x000BA1A0 File Offset: 0x000B83A0
	protected void method_13()
	{
		if (this.list_0.Count == 0)
		{
			this.float_4 = 0f;
			if (this.list_1.Count == 0)
			{
				return;
			}
		}
		bool flag = false;
		for (int i = this.list_0.Count - 1; i >= 0; i--)
		{
			GClass6 gclass = this.list_0[i];
			if (gclass == null)
			{
				return;
			}
			if (!flag)
			{
				flag = gclass.Boolean_3;
			}
			bool flag2 = false;
			if (gclass.int_0 == 0 && gclass.float_1 <= 0f)
			{
				base.method_2(true);
				flag2 = true;
				gclass.float_1 = 0f;
			}
			bool flag3 = false;
			if (this.gameManager.uint_0 > gclass.uint_0 && gclass.int_0 > 0)
			{
				int num;
				if (!flag2 && (long)gclass.int_0 > (long)((ulong)this.gameManager.uint_2))
				{
					num = (int)(this.gameManager.uint_0 - gclass.uint_0);
					gclass.int_0 -= num;
					if (gclass.int_0 < 0)
					{
						num += gclass.int_0;
						gclass.int_0 = 0;
					}
				}
				else
				{
					num = gclass.int_0;
					flag3 = true;
					gclass.int_0 = 0;
				}
				base.method_7(this.gameManager.method_55(ref num, flag3));
				if (flag3)
				{
					gclass.int_0 = 0;
				}
				else
				{
					gclass.int_0 += num;
				}
				gclass.uint_0 = this.gameManager.uint_0 - (uint)num;
			}
			if ((!base.method_0(gclass) && !gclass.Boolean_5) || (gclass.byte_0 & this.byte_0) != gclass.byte_0 || flag2)
			{
				this.neckController.vmethod_3(gclass.byte_0);
				gclass.bool_1 = true;
				this.list_0.RemoveAt(i);
				if (gclass.int_0 == 0)
				{
					this.list_1.Add(gclass);
				}
				if ((long)gclass.int_0 > (long)((ulong)this.gameManager.uint_2) && this.list_0.Count == 0)
				{
					BassAudioManager.instance.method_17(this.player.gclass10_0.genum18_0, false);
					this.bool_2 = true;
				}
			}
			else
			{
				gclass.float_1 -= this.gameManager.float_1;
			}
		}
		for (int j = this.list_1.Count - 1; j >= 0; j--)
		{
			GClass6 gclass2 = this.list_1[j];
			if (this.gameManager.double_1 > (double)(gclass2.Single_0 + this.float_3))
			{
				this.list_1.RemoveAt(j);
			}
		}
		if (flag && this.float_4 > 0f)
		{
			base.method_4(this.gameManager.method_42());
		}
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x000BA44C File Offset: 0x000B864C
	protected void method_14(GClass6 gclass6_1)
	{
		foreach (GClass6 gclass in this.gclass6_0)
		{
			if (gclass == gclass6_1)
			{
				break;
			}
			this.vmethod_3(gclass);
		}
		if (this.bool_2)
		{
			BassAudioManager.instance.method_17(this.player.gclass10_0.genum18_0, true);
			this.bool_2 = false;
		}
		if (!gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
		{
			this.byte_2 = 0;
			this.float_10 = 0f;
		}
		else
		{
			this.byte_2 = this.byte_0;
			if (this.int_4 > 0 && this.float_10 > 0f)
			{
				this.float_13 = 0.096f;
				this.float_10 = this.float_12;
				this.bool_7 = true;
			}
			else
			{
				this.float_10 = 0f;
				this.float_13 = 0.096f;
			}
		}
		this.int_4++;
		this.int_8++;
		base.method_2(true);
		base.method_9();
		if (gclass6_1.Boolean_8)
		{
			base.method_10();
		}
		if (this.bool_3)
		{
			this.soloCounter_0.method_39();
			if (gclass6_1.Boolean_9)
			{
				this.soloCounter_0.method_48();
			}
		}
		this.bool_5 = gclass6_1.Boolean_3;
		bool bool_ = false;
		if (gclass6_1.Boolean_4)
		{
			gclass6_1.genum3_0 &= ~GClass6.GEnum3.STAR_POWER_END;
			base.method_4(0.25f);
			bool_ = true;
			this.bool_5 = false;
		}
		if (this.list_0.Count > 0 && !gclass6_1.Boolean_5)
		{
			foreach (GClass6 gclass2 in this.list_0)
			{
				if ((long)gclass2.int_0 <= (long)((ulong)this.gameManager.uint_2))
				{
					gclass2.float_1 = 0f;
				}
				gclass2.bool_1 = true;
				this.list_1.Add(gclass2);
			}
			this.list_0.Clear();
			this.neckController.vmethod_4();
		}
		foreach (GClass6 gclass3 in gclass6_1.IEnumerable_0)
		{
			gclass3.bool_0 = true;
			base.method_8(gclass3);
			this.neckController.vmethod_1(gclass3.byte_0, gclass3.float_1 > 0f, bool_, this.bool_1);
			if (gclass3.float_1 > 0f)
			{
				this.method_15(gclass3);
			}
		}
		this.comboCounter.method_53(this.int_4);
		if (this.int_4 > this.int_7)
		{
			this.int_7 = this.int_4;
		}
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x000BA718 File Offset: 0x000B8918
	private void method_15(GClass6 gclass6_1)
	{
		this.list_0.Add(gclass6_1);
		float num = (float)((double)gclass6_1.float_0 - this.gameManager.double_1);
		gclass6_1.float_1 += num;
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x0000C1D5 File Offset: 0x0000A3D5
	protected override void Update()
	{
		if (this.float_4 > 0f)
		{
			this.float_4 -= Time.deltaTime;
		}
		base.Update();
	}

	// Token: 0x0400035D RID: 861
	protected float float_10;

	// Token: 0x0400035E RID: 862
	protected float float_11 = 0.084f;

	// Token: 0x0400035F RID: 863
	protected float float_12 = 0.048f;

	// Token: 0x04000360 RID: 864
	protected float float_13;

	// Token: 0x04000361 RID: 865
	protected byte byte_2;

	// Token: 0x04000362 RID: 866
	protected bool bool_6;

	// Token: 0x04000363 RID: 867
	protected bool bool_7;

	// Token: 0x04000364 RID: 868
	protected float float_14;

	// Token: 0x04000365 RID: 869
	[HideInInspector]
	public float float_15;
}
