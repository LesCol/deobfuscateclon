using System;
using UnityEngine;

// Token: 0x02000073 RID: 115
public class NoteContainer : BaseNoteContainer
{
	// Token: 0x060015E3 RID: 5603 RVA: 0x000B2914 File Offset: 0x000B0B14
	public virtual void vmethod_77(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -117;
		if (gclass6_1.byte_0 == 109)
		{
			this.Body.sprite = this.sprite_0[4];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[7];
			this.Head.color = GClass7.color_0[3];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 6;
			this.Head.sortingOrder = int_0 - 1;
			this.Anim.sortingOrder = int_0 - 0;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[5];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 0;
			this.Body.sortingOrder = int_0 - 3;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[6];
				}
				else
				{
					this.Head.sprite = this.sprite_0[3];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[8];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[2];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x000B2D68 File Offset: 0x000B0F68
	public virtual void vmethod_78(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -96;
		if (gclass6_1.byte_0 == 51)
		{
			this.Body.sprite = this.sprite_0[1];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[1];
			this.Head.color = GClass7.color_0[3];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 4;
			this.Head.sortingOrder = int_0 - 8;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.Boolean_6)
			{
				this.Open_HOPO.sprite = this.sprite_0[4];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 0;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[5];
				}
				else
				{
					this.Head.sprite = this.sprite_0[4];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[7];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_8())
					{
						this.Head.sprite = this.sprite_0[8];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x000B31BC File Offset: 0x000B13BC
	public override void vmethod_58(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 66;
		if (gclass6_1.byte_0 == 15)
		{
			this.Body.sprite = this.sprite_0[3];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[5];
			this.Head.color = GClass7.color_0[6];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 1;
			this.Head.sortingOrder = int_0 - 4;
			this.Anim.sortingOrder = int_0 - 0;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[6];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 8;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Head.sprite = this.sprite_0[8];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[2];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[0];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x000B3610 File Offset: 0x000B1810
	public virtual void vmethod_79(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -12;
		if (gclass6_1.byte_0 == 85)
		{
			this.Body.sprite = this.sprite_0[6];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[8];
			this.Head.color = GClass7.color_0[4];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 3;
			this.Head.sortingOrder = int_0 - 6;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.Boolean_6)
			{
				this.Open_HOPO.sprite = this.sprite_0[2];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 8;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Head.sprite = this.sprite_0[2];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[3];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[8];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x000B3A64 File Offset: 0x000B1C64
	public virtual void vmethod_80(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 42;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 1;
		this.Body.sortingOrder = int_0 - 0;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_8() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[4];
			}
			else
			{
				this.Head.sprite = this.sprite_0[2];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[3];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[0];
			}
			else
			{
				this.Body.sprite = this.sprite_0[0];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.Boolean_6)
				{
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015E8 RID: 5608 RVA: 0x000B3D54 File Offset: 0x000B1F54
	public virtual void vmethod_81(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -58;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 1;
		this.Body.sortingOrder = int_0 - 6;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[2];
			}
			else
			{
				this.Head.sprite = this.sprite_0[8];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[5];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[1];
			}
			else
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.method_8())
				{
					this.Head.sprite = this.sprite_0[2];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015E9 RID: 5609 RVA: 0x000B4044 File Offset: 0x000B2244
	public override void vmethod_35(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -4;
		if (gclass6_1.byte_0 == 64)
		{
			this.Body.sprite = this.sprite_0[6];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[7];
			this.Head.color = GClass7.color_0[5];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 3;
			this.Head.sortingOrder = int_0 - 2;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.Boolean_6)
			{
				this.Open_HOPO.sprite = this.sprite_0[8];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 2;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[5];
				}
				else
				{
					this.Head.sprite = this.sprite_0[4];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[2];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[3];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x000B4498 File Offset: 0x000B2698
	public virtual void vmethod_82(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -45;
		if (gclass6_1.byte_0 == 99)
		{
			this.Body.sprite = this.sprite_0[7];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[1];
			this.Head.color = GClass7.color_0[7];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 2;
			this.Head.sortingOrder = int_0 - 4;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.Boolean_6)
			{
				this.Open_HOPO.sprite = this.sprite_0[0];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 0;
			this.Body.sortingOrder = int_0 - 3;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Head.sprite = this.sprite_0[0];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[3];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_8())
					{
						this.Head.sprite = this.sprite_0[6];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x000B48EC File Offset: 0x000B2AEC
	public virtual void vmethod_83(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 119;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 1;
		this.Body.sortingOrder = int_0 - 5;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_8() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[6];
			}
			else
			{
				this.Head.sprite = this.sprite_0[3];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[7];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[1];
			}
			else
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.Boolean_6)
				{
					this.Head.sprite = this.sprite_0[8];
				}
				else
				{
					this.Head.sprite = this.sprite_0[0];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x000B4BDC File Offset: 0x000B2DDC
	public virtual void vmethod_84(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -76;
		if (gclass6_1.byte_0 == 36)
		{
			this.Body.sprite = this.sprite_0[6];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[0];
			this.Head.color = GClass7.color_0[0];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 7;
			this.Head.sortingOrder = int_0 - 2;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[2];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 3;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[3];
				}
				else
				{
					this.Head.sprite = this.sprite_0[0];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_15())
					{
						this.Head.sprite = this.sprite_0[8];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x000B5030 File Offset: 0x000B3230
	public virtual void vmethod_85(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -113;
		if (gclass6_1.byte_0 == 97)
		{
			this.Body.sprite = this.sprite_0[6];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[5];
			this.Head.color = GClass7.color_0[6];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 0;
			this.Head.sortingOrder = int_0 - 2;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.Boolean_6)
			{
				this.Open_HOPO.sprite = this.sprite_0[6];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 6;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Head.sprite = this.sprite_0[0];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[4];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_15())
					{
						this.Head.sprite = this.sprite_0[7];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x000B5484 File Offset: 0x000B3684
	public virtual void vmethod_86(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -81;
		if (gclass6_1.byte_0 == 41)
		{
			this.Body.sprite = this.sprite_0[8];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[8];
			this.Head.color = GClass7.color_0[4];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 4;
			this.Head.sortingOrder = int_0 - 5;
			this.Anim.sortingOrder = int_0 - 0;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.Boolean_6)
			{
				this.Open_HOPO.sprite = this.sprite_0[1];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 2;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[6];
				}
				else
				{
					this.Head.sprite = this.sprite_0[7];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[8];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_8())
					{
						this.Head.sprite = this.sprite_0[1];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x000B58D8 File Offset: 0x000B3AD8
	public virtual void vmethod_87(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 70;
		if (gclass6_1.byte_0 == 89)
		{
			this.Body.sprite = this.sprite_0[8];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[8];
			this.Head.color = GClass7.color_0[6];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 2;
			this.Head.sortingOrder = int_0 - 1;
			this.Anim.sortingOrder = int_0 - 0;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[0];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 0;
			this.Body.sortingOrder = int_0 - 4;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[5];
				}
				else
				{
					this.Head.sprite = this.sprite_0[0];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[8];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_15())
					{
						this.Head.sprite = this.sprite_0[2];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x000B5D2C File Offset: 0x000B3F2C
	public virtual void vmethod_88(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -94;
		if (gclass6_1.byte_0 == 109)
		{
			this.Body.sprite = this.sprite_0[3];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[0];
			this.Head.color = GClass7.color_0[8];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 5;
			this.Head.sortingOrder = int_0 - 6;
			this.Anim.sortingOrder = int_0 - 0;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[8];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 0;
			this.Body.sortingOrder = int_0 - 2;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[7];
				}
				else
				{
					this.Head.sprite = this.sprite_0[7];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[8];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_8())
					{
						this.Head.sprite = this.sprite_0[1];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x000B6180 File Offset: 0x000B4380
	public virtual void vmethod_89(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 124;
		if (gclass6_1.byte_0 == 58)
		{
			this.Body.sprite = this.sprite_0[1];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[3];
			this.Head.color = GClass7.color_0[2];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 3;
			this.Head.sortingOrder = int_0 - 3;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[4];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 1;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_8() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Head.sprite = this.sprite_0[7];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[6];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_8())
					{
						this.Head.sprite = this.sprite_0[2];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x000B65D4 File Offset: 0x000B47D4
	public virtual void vmethod_90(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -21;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 1;
		this.Body.sortingOrder = int_0 - 2;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[8];
			}
			else
			{
				this.Head.sprite = this.sprite_0[4];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[6];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[0];
			}
			else
			{
				this.Body.sprite = this.sprite_0[0];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.method_8())
				{
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x000B68C4 File Offset: 0x000B4AC4
	public virtual void vmethod_91(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 35;
		if (gclass6_1.byte_0 == 97)
		{
			this.Body.sprite = this.sprite_0[1];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[5];
			this.Head.color = GClass7.color_0[7];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 0;
			this.Head.sortingOrder = int_0 - 8;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[5];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 8;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[3];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[7];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[8];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x000B6D18 File Offset: 0x000B4F18
	public virtual void vmethod_92(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 17;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 1;
		this.Body.sortingOrder = int_0 - 6;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_8() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[1];
			}
			else
			{
				this.Head.sprite = this.sprite_0[3];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[7];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[1];
			}
			else
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.method_8())
				{
					this.Head.sprite = this.sprite_0[7];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x000B7008 File Offset: 0x000B5208
	public virtual void vmethod_93(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 23;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 0;
		this.Body.sortingOrder = int_0 - 0;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[2];
			}
			else
			{
				this.Head.sprite = this.sprite_0[3];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[4];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[0];
			}
			else
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.Boolean_6)
				{
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x000B72F8 File Offset: 0x000B54F8
	public virtual void vmethod_94(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 76;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 1;
		this.Body.sortingOrder = int_0 - 2;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_8() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[2];
			}
			else
			{
				this.Head.sprite = this.sprite_0[8];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[1];
			}
			else
			{
				this.Body.sprite = this.sprite_0[0];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.Boolean_6)
				{
					this.Head.sprite = this.sprite_0[4];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x000B75E8 File Offset: 0x000B57E8
	public virtual void vmethod_95(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -75;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 0;
		this.Body.sortingOrder = int_0 - 8;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[8];
			}
			else
			{
				this.Head.sprite = this.sprite_0[5];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[8];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[0];
			}
			else
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.method_8())
				{
					this.Head.sprite = this.sprite_0[7];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x000B78D8 File Offset: 0x000B5AD8
	public override void vmethod_5(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 42;
		if (gclass6_1.byte_0 == 22)
		{
			this.Body.sprite = this.sprite_0[8];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[7];
			this.Head.color = GClass7.color_0[6];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 5;
			this.Head.sortingOrder = int_0 - 1;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[7];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 0;
			this.Body.sortingOrder = int_0 - 8;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[2];
				}
				else
				{
					this.Head.sprite = this.sprite_0[2];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[5];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[8];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x000B7D2C File Offset: 0x000B5F2C
	public override void vmethod_8(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 79;
		if (gclass6_1.byte_0 == 18)
		{
			this.Body.sprite = this.sprite_0[7];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[4];
			this.Head.color = GClass7.color_0[3];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 8;
			this.Head.sortingOrder = int_0 - 7;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_15())
			{
				this.Open_HOPO.sprite = this.sprite_0[1];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 2;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_8() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[5];
				}
				else
				{
					this.Head.sprite = this.sprite_0[3];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[7];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[4];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x000B8180 File Offset: 0x000B6380
	public override void vmethod_30(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -67;
		this.Head.sortingOrder = int_0;
		this.Anim.sortingOrder = int_0 - 1;
		this.Body.sortingOrder = int_0 - 3;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[2];
			}
			else
			{
				this.Head.sprite = this.sprite_0[7];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[4];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[0];
			}
			else
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.method_8())
				{
					this.Head.sprite = this.sprite_0[5];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x000B8470 File Offset: 0x000B6670
	public virtual void vmethod_96(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -57;
		if (gclass6_1.byte_0 == 29)
		{
			this.Body.sprite = this.sprite_0[1];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[1];
			this.Head.color = GClass7.color_0[4];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 7;
			this.Head.sortingOrder = int_0 - 7;
			this.Anim.sortingOrder = int_0 - 1;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.Boolean_6)
			{
				this.Open_HOPO.sprite = this.sprite_0[0];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 8;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[4];
				}
				else
				{
					this.Head.sprite = this.sprite_0[3];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_15())
					{
						this.Head.sprite = this.sprite_0[0];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x000B88C4 File Offset: 0x000B6AC4
	public virtual void vmethod_97(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 0;
		this.Head.sortingOrder = 0;
		this.Anim.sortingOrder = 0;
		this.Body.sortingOrder = -2;
		if (gclass6_1.Boolean_3)
		{
			if (gclass6_1.method_15() && !gclass6_1.Boolean_7)
			{
				this.Head.sprite = this.sprite_0[4];
			}
			else
			{
				this.Head.sprite = this.sprite_0[2];
			}
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
			}
			else
			{
				this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
			}
			this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
			this.Anim.color = GClass7.color_5;
			if (bool_0)
			{
				this.Body.color = GClass7.color_4;
			}
			else
			{
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		else
		{
			this.Head.color = Color.white;
			if (gclass6_1.Boolean_7)
			{
				this.Body.sprite = this.sprite_0[3];
				this.Anim.sprite = null;
				this.Head.sprite = this.sprite_0[1];
			}
			else
			{
				this.Body.sprite = this.sprite_0[1];
				this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
				if (gclass6_1.method_15())
				{
					this.Head.sprite = this.sprite_0[5];
				}
				else
				{
					this.Head.sprite = this.sprite_0[0];
				}
			}
			if (bool_0)
			{
				this.Anim.color = (this.Body.color = GClass7.color_5);
			}
			else
			{
				this.Anim.color = GClass7.color_1[(int)byte_0];
				this.Body.color = GClass7.color_0[(int)byte_0];
			}
		}
		this.Head.color = Color.white;
		this.Open_HOPO.sprite = null;
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x000B8BB0 File Offset: 0x000B6DB0
	public override void vmethod_63(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= 89;
		if (gclass6_1.byte_0 == 53)
		{
			this.Body.sprite = this.sprite_0[0];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[3];
			this.Head.color = GClass7.color_0[6];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 7;
			this.Head.sortingOrder = int_0 - 3;
			this.Anim.sortingOrder = int_0 - 0;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_8())
			{
				this.Open_HOPO.sprite = this.sprite_0[5];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 1;
			this.Body.sortingOrder = int_0 - 4;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.Boolean_6 && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[6];
				}
				else
				{
					this.Head.sprite = this.sprite_0[2];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[7];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[1];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.method_15())
					{
						this.Head.sprite = this.sprite_0[8];
					}
					else
					{
						this.Head.sprite = this.sprite_0[1];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x000B9004 File Offset: 0x000B7204
	public virtual void vmethod_98(Vector3 vector3_0, byte byte_0, GClass6 gclass6_1, bool bool_0, int int_0, float float_0)
	{
		this.transform_0.localPosition = vector3_0;
		int_0 *= -66;
		if (gclass6_1.byte_0 == 5)
		{
			this.Body.sprite = this.sprite_0[1];
			this.Body.color = Color.white;
			this.Head.sprite = this.sprite_0[4];
			this.Head.color = GClass7.color_0[8];
			this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
			this.Body.sortingOrder = int_0 - 6;
			this.Head.sortingOrder = int_0 - 3;
			this.Anim.sortingOrder = int_0 - 0;
			this.Open_HOPO.sortingOrder = int_0;
			if (gclass6_1.Boolean_3)
			{
				this.Anim.sprite = this.sprite_4[NoteAnimator.int_2];
				this.Body.color = (this.Anim.color = GClass7.color_4);
			}
			else
			{
				this.Anim.sprite = this.sprite_2[NoteAnimator.int_1];
				this.Body.color = (this.Anim.color = Color.white);
			}
			if (gclass6_1.method_15())
			{
				this.Open_HOPO.sprite = this.sprite_0[7];
			}
			else
			{
				this.Open_HOPO.sprite = null;
			}
			if (bool_0)
			{
				this.Head.color = GClass7.color_4;
			}
		}
		else
		{
			this.Head.sortingOrder = int_0;
			this.Anim.sortingOrder = int_0 - 0;
			this.Body.sortingOrder = int_0 - 0;
			if (gclass6_1.Boolean_3)
			{
				if (gclass6_1.method_8() && !gclass6_1.Boolean_7)
				{
					this.Head.sprite = this.sprite_0[6];
				}
				else
				{
					this.Head.sprite = this.sprite_0[1];
				}
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_5[NoteAnimator.int_2];
				}
				else
				{
					this.Body.sprite = this.sprite_3[NoteAnimator.int_2];
				}
				this.Anim.sprite = this.sprite_6[NoteAnimator.int_2];
				this.Anim.color = GClass7.color_5;
				if (bool_0)
				{
					this.Body.color = GClass7.color_4;
				}
				else
				{
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			else
			{
				this.Head.color = Color.white;
				if (gclass6_1.Boolean_7)
				{
					this.Body.sprite = this.sprite_0[0];
					this.Anim.sprite = null;
					this.Head.sprite = this.sprite_0[0];
				}
				else
				{
					this.Body.sprite = this.sprite_0[1];
					this.Anim.sprite = this.sprite_1[NoteAnimator.int_1];
					if (gclass6_1.Boolean_6)
					{
						this.Head.sprite = this.sprite_0[6];
					}
					else
					{
						this.Head.sprite = this.sprite_0[0];
					}
				}
				if (bool_0)
				{
					this.Anim.color = (this.Body.color = GClass7.color_5);
				}
				else
				{
					this.Anim.color = GClass7.color_1[(int)byte_0];
					this.Body.color = GClass7.color_0[(int)byte_0];
				}
			}
			this.Head.color = Color.white;
			this.Open_HOPO.sprite = null;
		}
		this.color_0 = this.Head.color;
		this.color_0.a = float_0;
		this.Head.color = this.color_0;
		this.color_0 = this.Open_HOPO.color;
		this.color_0.a = float_0;
		this.Open_HOPO.color = this.color_0;
		this.color_0 = this.Body.color;
		this.color_0.a = float_0;
		this.Body.color = this.color_0;
		this.color_0 = this.Anim.color;
		this.color_0.a = float_0;
		this.Anim.color = this.color_0;
	}

	// Token: 0x04000339 RID: 825
	public Sprite[] sprite_0;

	// Token: 0x0400033A RID: 826
	public Sprite[] sprite_1;

	// Token: 0x0400033B RID: 827
	public Sprite[] sprite_2;

	// Token: 0x0400033C RID: 828
	public Sprite[] sprite_3;

	// Token: 0x0400033D RID: 829
	public Sprite[] sprite_4;

	// Token: 0x0400033E RID: 830
	public Sprite[] sprite_5;

	// Token: 0x0400033F RID: 831
	public Sprite[] sprite_6;

	// Token: 0x04000340 RID: 832
	[SerializeField]
	private SpriteRenderer Head;

	// Token: 0x04000341 RID: 833
	[SerializeField]
	private SpriteRenderer Body;

	// Token: 0x04000342 RID: 834
	[SerializeField]
	private SpriteRenderer Anim;

	// Token: 0x04000343 RID: 835
	[SerializeField]
	private SpriteRenderer Open_HOPO;

	// Token: 0x04000344 RID: 836
	private Color color_0;

	// Token: 0x04000345 RID: 837
	public GClass6 gclass6_0;
}
