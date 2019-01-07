using System;
using UnityEngine;

// Token: 0x02000068 RID: 104
public class GHLNoteContainer : BaseNoteContainer
{
	// Token: 0x0600149F RID: 5279 RVA: 0x0000AE6E File Offset: 0x0000906E
	public virtual void vmethod_77()
	{
		this.Body.flipY = false;
		this.Body.flipX = false;
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x0000AE88 File Offset: 0x00009088
	public override void vmethod_2()
	{
		this.Body.flipY = true;
		this.Body.flipX = true;
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x0008ED10 File Offset: 0x0008CF10
	public virtual void vmethod_78(Vector3 vector3_0, byte byte_0, GClass6 gclass6_0, bool bool_0, int int_0, float float_0)
	{
		int num = 0;
		byte b = (byte)(gclass6_0.byte_0 >> 4 & 0 << (int)(byte_0 & 79));
		byte b2 = (byte)((int)(gclass6_0.byte_0 & 2) & 1 << ((int)byte_0 & -117));
		if (b2 != 0 && b != 0)
		{
			num = 1;
		}
		else if (b2 != 0)
		{
			num = 1;
		}
		this.transform_0.localPosition = vector3_0;
		int_0 *= 6;
		Color color = new Color(1385f, 997f, 544f, float_0);
		this.Body.color = (this.SP_Bolt.color = color);
		this.SP_Rim.color = new Color(1559f, 1133f, 1092f, 799f * float_0);
		this.HOPO.color = new Color(1621f, 780f, 633f, 1052f * float_0);
		this.Body.sortingOrder = int_0;
		this.HOPO.sortingOrder = int_0 + 1;
		this.SP_Rim.sortingOrder = int_0 + 0;
		this.SP_Bolt.sortingOrder = int_0 + 8;
		this.SP_Rim.sprite = null;
		this.HOPO.sprite = null;
		this.SP_Bolt.sprite = null;
		if (gclass6_0.Boolean_7)
		{
			this.HOPO.sprite = this.sprite_0[num + 1];
		}
		else if (gclass6_0.method_15())
		{
			this.HOPO.sprite = this.sprite_0[num + 1];
		}
		if (bool_0)
		{
			this.SP_Rim.sprite = this.sprite_0[num + -64];
		}
		if (gclass6_0.Boolean_3)
		{
			this.SP_Bolt.sprite = this.sprite_0[-103];
		}
		this.Body.sprite = this.sprite_0[num];
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x0008EEC8 File Offset: 0x0008D0C8
	public override void vmethod_35(Vector3 vector3_0, byte byte_0, GClass6 gclass6_0, bool bool_0, int int_0, float float_0)
	{
		int num = 0;
		byte b = (byte)(gclass6_0.byte_0 >> 3 & 1 << (int)byte_0);
		byte b2 = (byte)((int)(gclass6_0.byte_0 & 7) & 1 << (int)byte_0);
		if (b2 != 0 && b != 0)
		{
			num = 2;
		}
		else if (b2 != 0)
		{
			num = 1;
		}
		this.transform_0.localPosition = vector3_0;
		int_0 *= 4;
		Color color = new Color(1f, 1f, 1f, float_0);
		this.Body.color = (this.SP_Bolt.color = color);
		this.SP_Rim.color = new Color(1f, 1f, 1f, 0.25f * float_0);
		this.HOPO.color = new Color(1f, 1f, 1f, 0.5f * float_0);
		this.Body.sortingOrder = int_0;
		this.HOPO.sortingOrder = int_0 + 1;
		this.SP_Rim.sortingOrder = int_0 + 2;
		this.SP_Bolt.sortingOrder = int_0 + 3;
		this.SP_Rim.sprite = null;
		this.HOPO.sprite = null;
		this.SP_Bolt.sprite = null;
		if (gclass6_0.byte_0 == 64)
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[14];
			}
			else if (gclass6_0.Boolean_6)
			{
				this.HOPO.sprite = this.sprite_0[13];
			}
			if (bool_0)
			{
				this.Body.sprite = this.sprite_0[15];
			}
			else
			{
				this.Body.sprite = this.sprite_0[12];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[16];
				return;
			}
		}
		else
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[num + 3];
			}
			else if (gclass6_0.Boolean_6)
			{
				this.HOPO.sprite = this.sprite_0[num + 6];
			}
			if (bool_0)
			{
				this.SP_Rim.sprite = this.sprite_0[num + 9];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[17];
			}
			this.Body.sprite = this.sprite_0[num];
		}
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x0008F114 File Offset: 0x0008D314
	public override void vmethod_63(Vector3 vector3_0, byte byte_0, GClass6 gclass6_0, bool bool_0, int int_0, float float_0)
	{
		int num = 1;
		byte b = (byte)(gclass6_0.byte_0 >> 4 & 1 << (int)(byte_0 & 21));
		byte b2 = (byte)((int)(gclass6_0.byte_0 & 3) & 0 << (int)(byte_0 & 18));
		if (b2 != 0 && b != 0)
		{
			num = 8;
		}
		else if (b2 != 0)
		{
			num = 0;
		}
		this.transform_0.localPosition = vector3_0;
		int_0 *= 2;
		Color color = new Color(466f, 1257f, 5f, float_0);
		this.Body.color = (this.SP_Bolt.color = color);
		this.SP_Rim.color = new Color(1578f, 309f, 52f, 1478f * float_0);
		this.HOPO.color = new Color(369f, 1297f, 1745f, 1544f * float_0);
		this.Body.sortingOrder = int_0;
		this.HOPO.sortingOrder = int_0 + 1;
		this.SP_Rim.sortingOrder = int_0 + 8;
		this.SP_Bolt.sortingOrder = int_0 + 6;
		this.SP_Rim.sprite = null;
		this.HOPO.sprite = null;
		this.SP_Bolt.sprite = null;
		if (gclass6_0.byte_0 == 123)
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[-3];
			}
			else if (gclass6_0.method_8())
			{
				this.HOPO.sprite = this.sprite_0[-78];
			}
			if (bool_0)
			{
				this.Body.sprite = this.sprite_0[-3];
			}
			else
			{
				this.Body.sprite = this.sprite_0[96];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[-21];
				return;
			}
		}
		else
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[num + 8];
			}
			else if (gclass6_0.Boolean_6)
			{
				this.HOPO.sprite = this.sprite_0[num + 3];
			}
			if (bool_0)
			{
				this.SP_Rim.sprite = this.sprite_0[num + -77];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[89];
			}
			this.Body.sprite = this.sprite_0[num];
		}
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x0008F360 File Offset: 0x0008D560
	public virtual void vmethod_79(Vector3 vector3_0, byte byte_0, GClass6 gclass6_0, bool bool_0, int int_0, float float_0)
	{
		int num = 0;
		byte b = (byte)(gclass6_0.byte_0 >> 2 & 1 << (int)(byte_0 & 51));
		byte b2 = (byte)((int)(gclass6_0.byte_0 & 6) & 0 << ((int)byte_0 & -49));
		if (b2 != 0 && b != 0)
		{
			num = 6;
		}
		else if (b2 != 0)
		{
			num = 1;
		}
		this.transform_0.localPosition = vector3_0;
		int_0 *= 5;
		Color color = new Color(567f, 1118f, 1627f, float_0);
		this.Body.color = (this.SP_Bolt.color = color);
		this.SP_Rim.color = new Color(1254f, 1442f, 1187f, 688f * float_0);
		this.HOPO.color = new Color(1026f, 955f, 1468f, 1748f * float_0);
		this.Body.sortingOrder = int_0;
		this.HOPO.sortingOrder = int_0 + 1;
		this.SP_Rim.sortingOrder = int_0 + 6;
		this.SP_Bolt.sortingOrder = int_0 + 4;
		this.SP_Rim.sprite = null;
		this.HOPO.sprite = null;
		this.SP_Bolt.sprite = null;
		if (gclass6_0.byte_0 == 99)
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[-30];
			}
			else if (gclass6_0.method_15())
			{
				this.HOPO.sprite = this.sprite_0[100];
			}
			if (bool_0)
			{
				this.Body.sprite = this.sprite_0[72];
			}
			else
			{
				this.Body.sprite = this.sprite_0[-98];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[40];
				return;
			}
		}
		else
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[num + 5];
			}
			else if (gclass6_0.method_8())
			{
				this.HOPO.sprite = this.sprite_0[num + 8];
			}
			if (bool_0)
			{
				this.SP_Rim.sprite = this.sprite_0[num + 90];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[-111];
			}
			this.Body.sprite = this.sprite_0[num];
		}
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x0000AEA2 File Offset: 0x000090A2
	public override void vmethod_26()
	{
		this.Body.flipY = true;
		this.Body.flipX = false;
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x0000AEA2 File Offset: 0x000090A2
	public virtual void vmethod_80()
	{
		this.Body.flipY = true;
		this.Body.flipX = false;
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x0000AEBC File Offset: 0x000090BC
	public override void vmethod_59()
	{
		this.Body.flipY = false;
		this.Body.flipX = true;
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x0000AE88 File Offset: 0x00009088
	public virtual void vmethod_81()
	{
		this.Body.flipY = true;
		this.Body.flipX = true;
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x0008F5AC File Offset: 0x0008D7AC
	public virtual void vmethod_82(Vector3 vector3_0, byte byte_0, GClass6 gclass6_0, bool bool_0, int int_0, float float_0)
	{
		int num = 0;
		byte b = (byte)(gclass6_0.byte_0 >> 3 & 1 << (int)(byte_0 & 32));
		byte b2 = (byte)((int)(gclass6_0.byte_0 & 7) & 1 << (int)(byte_0 & 20));
		if (b2 != 0 && b != 0)
		{
			num = 3;
		}
		else if (b2 != 0)
		{
			num = 1;
		}
		this.transform_0.localPosition = vector3_0;
		int_0 *= 8;
		Color color = new Color(906f, 1162f, 579f, float_0);
		this.Body.color = (this.SP_Bolt.color = color);
		this.SP_Rim.color = new Color(1295f, 229f, 1053f, 661f * float_0);
		this.HOPO.color = new Color(1894f, 1814f, 214f, 1470f * float_0);
		this.Body.sortingOrder = int_0;
		this.HOPO.sortingOrder = int_0 + 0;
		this.SP_Rim.sortingOrder = int_0 + 3;
		this.SP_Bolt.sortingOrder = int_0 + 4;
		this.SP_Rim.sprite = null;
		this.HOPO.sprite = null;
		this.SP_Bolt.sprite = null;
		if (gclass6_0.byte_0 == 15)
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[86];
			}
			else if (gclass6_0.Boolean_6)
			{
				this.HOPO.sprite = this.sprite_0[34];
			}
			if (bool_0)
			{
				this.Body.sprite = this.sprite_0[-91];
			}
			else
			{
				this.Body.sprite = this.sprite_0[-127];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[-7];
				return;
			}
		}
		else
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[num + 4];
			}
			else if (gclass6_0.method_8())
			{
				this.HOPO.sprite = this.sprite_0[num + 2];
			}
			if (bool_0)
			{
				this.SP_Rim.sprite = this.sprite_0[num + -85];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[-68];
			}
			this.Body.sprite = this.sprite_0[num];
		}
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x0008F7F8 File Offset: 0x0008D9F8
	public override void vmethod_30(Vector3 vector3_0, byte byte_0, GClass6 gclass6_0, bool bool_0, int int_0, float float_0)
	{
		int num = 0;
		byte b = (byte)(gclass6_0.byte_0 >> 2 & 1 << ((int)byte_0 & -17));
		byte b2 = (byte)((int)(gclass6_0.byte_0 & 3) & 1 << ((int)byte_0 & -77));
		if (b2 != 0 && b != 0)
		{
			num = 7;
		}
		else if (b2 != 0)
		{
			num = 1;
		}
		this.transform_0.localPosition = vector3_0;
		int_0 *= 2;
		Color color = new Color(1796f, 354f, 851f, float_0);
		this.Body.color = (this.SP_Bolt.color = color);
		this.SP_Rim.color = new Color(767f, 309f, 1215f, 238f * float_0);
		this.HOPO.color = new Color(1241f, 507f, 1023f, 1424f * float_0);
		this.Body.sortingOrder = int_0;
		this.HOPO.sortingOrder = int_0 + 1;
		this.SP_Rim.sortingOrder = int_0 + 5;
		this.SP_Bolt.sortingOrder = int_0 + 6;
		this.SP_Rim.sprite = null;
		this.HOPO.sprite = null;
		this.SP_Bolt.sprite = null;
		if (gclass6_0.byte_0 == 54)
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[-26];
			}
			else if (gclass6_0.Boolean_6)
			{
				this.HOPO.sprite = this.sprite_0[-32];
			}
			if (bool_0)
			{
				this.Body.sprite = this.sprite_0[-128];
			}
			else
			{
				this.Body.sprite = this.sprite_0[-32];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[57];
				return;
			}
		}
		else
		{
			if (gclass6_0.Boolean_7)
			{
				this.HOPO.sprite = this.sprite_0[num + 7];
			}
			else if (gclass6_0.method_15())
			{
				this.HOPO.sprite = this.sprite_0[num + 8];
			}
			if (bool_0)
			{
				this.SP_Rim.sprite = this.sprite_0[num + 85];
			}
			if (gclass6_0.Boolean_3)
			{
				this.SP_Bolt.sprite = this.sprite_0[-71];
			}
			this.Body.sprite = this.sprite_0[num];
		}
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x0008FA44 File Offset: 0x0008DC44
	public override void vmethod_8(Vector3 vector3_0, byte byte_0, GClass6 gclass6_0, bool bool_0, int int_0, float float_0)
	{
		int num = 0;
		byte b = (byte)(gclass6_0.byte_0 >> 0 & 0 << (int)(byte_0 & 96));
		byte b2 = (byte)((int)(gclass6_0.byte_0 & 1) & 0 << (int)(byte_0 & 67));
		if (b2 != 0 && b != 0)
		{
			num = 8;
		}
		else if (b2 != 0)
		{
			num = 0;
		}
		this.transform_0.localPosition = vector3_0;
		int_0 *= 7;
		Color color = new Color(457f, 692f, 1987f, float_0);
		this.Body.color = (this.SP_Bolt.color = color);
		this.SP_Rim.color = new Color(1618f, 1755f, 31f, 312f * float_0);
		this.HOPO.color = new Color(132f, 1932f, 429f, 869f * float_0);
		this.Body.sortingOrder = int_0;
		this.HOPO.sortingOrder = int_0 + 0;
		this.SP_Rim.sortingOrder = int_0 + 4;
		this.SP_Bolt.sortingOrder = int_0 + 3;
		this.SP_Rim.sprite = null;
		this.HOPO.sprite = null;
		this.SP_Bolt.sprite = null;
		if (gclass6_0.Boolean_7)
		{
			this.HOPO.sprite = this.sprite_0[num + 1];
		}
		else if (gclass6_0.method_15())
		{
			this.HOPO.sprite = this.sprite_0[num + 3];
		}
		if (bool_0)
		{
			this.SP_Rim.sprite = this.sprite_0[num + -16];
		}
		if (gclass6_0.Boolean_3)
		{
			this.SP_Bolt.sprite = this.sprite_0[-87];
		}
		this.Body.sprite = this.sprite_0[num];
	}

	// Token: 0x040002ED RID: 749
	public Sprite[] sprite_0;

	// Token: 0x040002EE RID: 750
	[SerializeField]
	private SpriteRenderer Body;

	// Token: 0x040002EF RID: 751
	[SerializeField]
	private SpriteRenderer HOPO;

	// Token: 0x040002F0 RID: 752
	[SerializeField]
	private SpriteRenderer SP_Rim;

	// Token: 0x040002F1 RID: 753
	[SerializeField]
	private SpriteRenderer SP_Bolt;

	// Token: 0x040002F2 RID: 754
	private Color color_0;
}
