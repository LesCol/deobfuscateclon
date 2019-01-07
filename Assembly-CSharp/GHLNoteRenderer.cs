using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000069 RID: 105
public class GHLNoteRenderer : BaseNoteRenderer
{
	// Token: 0x060014AD RID: 5293 RVA: 0x0008FBFC File Offset: 0x0008DDFC
	protected virtual void vmethod_2()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(117f * single_, 1637f);
		Vector3 vector3_ = new Vector3(1169f, this.float_11, 715f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 725f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 747f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1177f)
					{
						num5 = 833f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 35 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 4);
				byte b2 = (byte_ & 6) | b;
				for (int i = 1; i < 4; i += 0)
				{
					if (((int)b2 & 1 << (i & 91)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_41(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 964f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 4);
				byte b4 = gclass2.byte_0 & 1;
				byte b5 = b3 | b4;
				for (int j = 0; j < 3; j += 0)
				{
					if (((int)b5 & 0 << (j & -26)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[3];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 0)
						{
							x2 = 1286f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 650f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 922f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5E7;
		}
		goto IL_5C6;
		IL_615:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_5C6:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_615;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_5E7:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_615;
		}
		goto IL_5C6;
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x00090270 File Offset: 0x0008E470
	protected virtual void vmethod_3()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 1;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1529f * single_, 4f);
		Vector3 vector3_ = new Vector3(1015f, this.float_11, 1739f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 463f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 1274f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 264f)
					{
						num5 = 618f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -5 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 2);
				byte b2 = (byte_ & 7) | b;
				for (int i = 1; i < 0; i += 0)
				{
					if (((int)b2 & 1 << (i & 54)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							if (byte_ == 62)
							{
								vector3_.x = 1971f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							}
							this.baseNoteContainer_0[num2].vmethod_63(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 457f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[7];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 5) | 0;
				for (int j = 1; j < 1; j++)
				{
					if (((int)b3 & 1 << (j & 15)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[7];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 3)
						{
							x2 = 1374f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 1499f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1329f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5F1;
		}
		goto IL_5D0;
		IL_61F:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_5D0:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_61F;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_5F1:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_61F;
		}
		goto IL_5D0;
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected override void vmethod_1()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x000908F0 File Offset: 0x0008EAF0
	protected virtual void vmethod_4()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1634f * single_, 1925f);
		Vector3 vector3_ = new Vector3(145f, this.float_11, 1224f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 222f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 800f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1622f)
					{
						num5 = 1010f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -13 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 7);
				byte b2 = (byte_ & 5) | b;
				for (int i = 1; i < 5; i++)
				{
					if (((int)b2 & 0 << (i & 87)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_69(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 1437f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[3];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 3);
				byte b4 = gclass2.byte_0 & 6;
				byte b5 = b3 | b4;
				for (int j = 1; j < 4; j++)
				{
					if (((int)b5 & 0 << (j & -128)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[6];
						gameObject2.SetActive(true);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 6)
						{
							x2 = 583f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 259f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 199f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3 += 0;
					}
				}
			}
			goto IL_5E7;
		}
		goto IL_5C6;
		IL_615:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5C6:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_615;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_5E7:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_615;
		}
		goto IL_5C6;
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x0000AF0E File Offset: 0x0000910E
	protected virtual void vmethod_5()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos * 1402f;
		this.float_10 = this.firstNoteXPos * 127f;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_6()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00090F64 File Offset: 0x0008F164
	protected virtual void vmethod_7()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(103f * single_, 1458f);
		Vector3 vector3_ = new Vector3(1152f, this.float_11, 123f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1346f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 1346f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 955f)
					{
						num5 = 654f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 93 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 1);
				byte b2 = (byte_ & 1) | b;
				for (int i = 0; i < 7; i++)
				{
					if (((int)b2 & 1 << (i & 82)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_15(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 615f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[1];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 1);
				byte b4 = gclass2.byte_0 & 8;
				byte b5 = b3 | b4;
				for (int j = 0; j < 7; j++)
				{
					if (((int)b5 & 0 << (j & -89)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[1];
						gameObject2.SetActive(true);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 8)
						{
							x2 = 348f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 1181f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1050f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3 += 0;
					}
				}
			}
			goto IL_5E7;
		}
		goto IL_5C6;
		IL_615:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_5C6:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_615;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_5E7:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_615;
		}
		goto IL_5C6;
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x000915D8 File Offset: 0x0008F7D8
	protected virtual void vmethod_8()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1248f * single_, 1822f);
		Vector3 vector3_ = new Vector3(1205f, this.float_11, 1713f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 165f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 853f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 304f)
					{
						num5 = 697f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 52 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 3);
				byte b2 = (byte_ & 6) | b;
				for (int i = 0; i < 5; i += 0)
				{
					if (((int)b2 & 0 << (i & 17)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_37(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 534f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[1];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 0);
				byte b4 = gclass2.byte_0 & 2;
				byte b5 = b3 | b4;
				for (int j = 0; j < 4; j += 0)
				{
					if (((int)b5 & 1 << (j & 79)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[0];
						gameObject2.SetActive(true);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 3)
						{
							x2 = 446f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 1725f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 240f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3 += 0;
					}
				}
			}
			goto IL_5E7;
		}
		goto IL_5C6;
		IL_615:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_5C6:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_615;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_5E7:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_615;
		}
		goto IL_5C6;
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_9()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00091C4C File Offset: 0x0008FE4C
	protected virtual void vmethod_10()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(792f * single_, 1999f);
		Vector3 vector3_ = new Vector3(1896f, this.float_11, 573f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 398f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 227f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1309f)
					{
						num5 = 1339f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -109 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 5);
				byte b2 = 0 | b;
				for (int i = 1; i < 3; i += 0)
				{
					if (((int)b2 & 1 << (i & 62)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_5(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 1582f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[3];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 3);
				byte b4 = gclass2.byte_0 & 5;
				byte b5 = b3 | b4;
				for (int j = 1; j < 8; j += 0)
				{
					if (((int)b5 & 0 << (j & -101)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[4];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 4)
						{
							x2 = 1673f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 1527f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1578f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3 += 0;
					}
				}
			}
			goto IL_5E3;
		}
		goto IL_5C2;
		IL_611:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5C2:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_611;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_5E3:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_611;
		}
		goto IL_5C2;
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x000922BC File Offset: 0x000904BC
	protected override void Update()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(0.13f * single_, 0f);
		Vector3 vector3_ = new Vector3(0f, this.float_11, 0f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 0f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 0f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 0f)
					{
						num5 = 0f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 20 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 3);
				byte b2 = (byte_ & 7) | b;
				for (int i = 0; i < 4; i++)
				{
					if (((int)b2 & 1 << i) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							if (byte_ == 64)
							{
								vector3_.x = 0f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							}
							this.baseNoteContainer_0[num2].vmethod_35(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = 0f;
							if (byte_ != 64)
							{
								x = this.firstSustainXPos + this.float_7 * (float)i;
							}
							gameObject.transform.localPosition = new Vector3(x, 0f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[2];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 3);
				byte b4 = gclass2.byte_0 & 7;
				byte b5 = b3 | b4;
				for (int j = 0; j < 4; j++)
				{
					if (((int)b5 & 1 << j) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[3];
						gameObject2.SetActive(true);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 3)
						{
							x2 = 0f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 0f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 0f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_604;
		}
		goto IL_5E3;
		IL_632:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_5E3:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_632;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_604:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_632;
		}
		goto IL_5E3;
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_11()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00092950 File Offset: 0x00090B50
	protected virtual void vmethod_12()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(147f * single_, 226f);
		Vector3 vector3_ = new Vector3(752f, this.float_11, 1002f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1499f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 754f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1410f)
					{
						num5 = 444f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 19 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 5);
				byte b2 = (byte_ & 6) | b;
				for (int i = 0; i < 7; i += 0)
				{
					if (((int)b2 & 1 << (i & -10)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_17(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = 686f;
							if (byte_ != 53)
							{
								x = this.firstSustainXPos + this.float_7 * (float)i;
							}
							gameObject.transform.localPosition = new Vector3(x, 632f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[3];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 4);
				byte b4 = gclass2.byte_0 & 3;
				byte b5 = b3 | b4;
				for (int j = 1; j < 8; j++)
				{
					if (((int)b5 & 1 << (j & 28)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[1];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 5)
						{
							x2 = 1739f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 802f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 441f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3 += 0;
					}
				}
			}
			goto IL_5ED;
		}
		goto IL_5CC;
		IL_61B:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5CC:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_61B;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_5ED:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_61B;
		}
		goto IL_5CC;
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x0000AF42 File Offset: 0x00009142
	protected virtual void vmethod_13()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos * 1662f;
		this.float_10 = this.firstNoteXPos * 1102f;
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x0000AF6E File Offset: 0x0000916E
	protected virtual void vmethod_14()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos * 113f;
		this.float_10 = this.firstNoteXPos * 459f;
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x00092FCC File Offset: 0x000911CC
	protected virtual void vmethod_15()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1726f * single_, 1283f);
		Vector3 vector3_ = new Vector3(161f, this.float_11, 672f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1203f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 726f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 354f)
					{
						num5 = 1543f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -75 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 0);
				byte b2 = (byte_ & 5) | b;
				for (int i = 1; i < 4; i++)
				{
					if (((int)b2 & 1 << (i & -76)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							if (byte_ == 66)
							{
								vector3_.x = 1855f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							}
							this.baseNoteContainer_0[num2].vmethod_33(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 634f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[7];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 1) | 0;
				for (int j = 0; j < 4; j++)
				{
					if (((int)b3 & 1 << (j & -110)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[5];
						gameObject2.SetActive(true);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 2)
						{
							x2 = 30f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 118f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1707f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5F1;
		}
		goto IL_5D0;
		IL_61F:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5D0:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_61F;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_5F1:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_61F;
		}
		goto IL_5D0;
	}

	// Token: 0x060014BE RID: 5310 RVA: 0x0009364C File Offset: 0x0009184C
	protected virtual void vmethod_16()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(192f * single_, 1460f);
		Vector3 vector3_ = new Vector3(455f, this.float_11, 1398f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1418f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 1749f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1697f)
					{
						num5 = 1762f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -59 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte_ & 7) | 0;
				for (int i = 1; i < 1; i += 0)
				{
					if (((int)b & 0 << (i & -20)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_58(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = 594f;
							if (byte_ != 63)
							{
								x = this.firstSustainXPos + this.float_7 * (float)i;
							}
							gameObject.transform.localPosition = new Vector3(x, 1030f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b2 = 0;
				for (int j = 1; j < 7; j++)
				{
					if (((int)b2 & 1 << (j & 55)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[0];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 5)
						{
							x2 = 900f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 350f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1433f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3 += 0;
					}
				}
			}
			goto IL_5CC;
		}
		goto IL_5AB;
		IL_5FA:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5AB:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_5FA;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_5CC:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_5FA;
		}
		goto IL_5AB;
	}

	// Token: 0x060014BF RID: 5311 RVA: 0x00093CA8 File Offset: 0x00091EA8
	protected virtual void vmethod_17()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1926f * single_, 754f);
		Vector3 vector3_ = new Vector3(382f, this.float_11, 1755f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 99f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 1713f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 872f)
					{
						num5 = 793f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 109 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 4);
				byte b2 = 0 | b;
				for (int i = 1; i < 3; i++)
				{
					if (((int)b2 & 0 << (i & -59)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_73(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 1218f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 0);
				byte b4 = gclass2.byte_0 & 3;
				byte b5 = b3 | b4;
				for (int j = 0; j < 4; j++)
				{
					if (((int)b5 & 1 << (j & 41)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[4];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 1)
						{
							x2 = 1476f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 734f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1169f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5E3;
		}
		goto IL_5C2;
		IL_611:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5C2:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_611;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_5E3:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_611;
		}
		goto IL_5C2;
	}

	// Token: 0x060014C0 RID: 5312 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_18()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014C1 RID: 5313 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_19()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_20()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x00094318 File Offset: 0x00092518
	protected virtual void vmethod_21()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1048f * single_, 461f);
		Vector3 vector3_ = new Vector3(96f, this.float_11, 6f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1032f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 1219f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1753f)
					{
						num5 = 1857f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 68 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte_ & 1) | 0;
				for (int i = 0; i < 1; i += 0)
				{
					if (((int)b & 1 << (i & -78)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							if (byte_ == 66)
							{
								vector3_.x = 1090f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							}
							this.baseNoteContainer_0[num2].vmethod_69(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2 += 0;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 710f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b2 = (byte)(gclass2.byte_0 >> 6);
				byte b3 = gclass2.byte_0 & 4;
				byte b4 = b2 | b3;
				for (int j = 1; j < 8; j += 0)
				{
					if (((int)b4 & 1 << (j & 10)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[0];
						gameObject2.SetActive(true);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 1)
						{
							x2 = 1995f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 1121f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 883f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5F6;
		}
		goto IL_5D5;
		IL_624:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_5D5:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_624;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_5F6:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_624;
		}
		goto IL_5D5;
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_22()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x0009499C File Offset: 0x00092B9C
	protected virtual void vmethod_23()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1976f * single_, 1219f);
		Vector3 vector3_ = new Vector3(652f, this.float_11, 932f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1459f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 1647f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 783f)
					{
						num5 = 967f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -9 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 5);
				byte b2 = (byte_ & 7) | b;
				for (int i = 1; i < 2; i++)
				{
					if (((int)b2 & 0 << (i & -71)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_73(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 504f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[1];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 7);
				byte b4 = gclass2.byte_0 & 6;
				byte b5 = b3 | b4;
				for (int j = 0; j < 8; j += 0)
				{
					if (((int)b5 & 0 << (j & 40)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[8];
						gameObject2.SetActive(true);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 7)
						{
							x2 = 968f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 1965f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1796f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5E7;
		}
		goto IL_5C6;
		IL_615:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5C6:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_615;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_5E7:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_615;
		}
		goto IL_5C6;
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x00095010 File Offset: 0x00093210
	protected virtual void vmethod_24()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1501f * single_, 981f);
		Vector3 vector3_ = new Vector3(923f, this.float_11, 1650f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1149f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 16f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1082f)
					{
						num5 = 1522f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -114 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte_ & 1) | 0;
				for (int i = 0; i < 7; i++)
				{
					if (((int)b & 0 << (i & -98)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_15(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = 1077f;
							if (byte_ != 8)
							{
								x = this.firstSustainXPos + this.float_7 * (float)i;
							}
							gameObject.transform.localPosition = new Vector3(x, 11f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[1];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[0];
								}
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b2 = 0;
				byte b3 = gclass2.byte_0 & 7;
				byte b4 = b2 | b3;
				for (int j = 0; j < 8; j++)
				{
					if (((int)b4 & 1 << (j & -61)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[0];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 3)
						{
							x2 = 1402f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 670f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1914f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5DC;
		}
		goto IL_5BB;
		IL_60A:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5BB:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_60A;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_5DC:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_60A;
		}
		goto IL_5BB;
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x0009567C File Offset: 0x0009387C
	protected virtual void vmethod_25()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1461f * single_, 1483f);
		Vector3 vector3_ = new Vector3(594f, this.float_11, 1756f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 689f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 473f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 1349f)
					{
						num5 = 1331f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 116 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte_ & 2) | 0;
				for (int i = 0; i < 2; i++)
				{
					if (((int)b & 0 << (i & 17)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(this.bool_0);
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							this.baseNoteContainer_0[num2].vmethod_45(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 511f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[7];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b2 = (byte)(gclass2.byte_0 >> 0);
				byte b3 = gclass2.byte_0 & 3;
				byte b4 = b2 | b3;
				for (int j = 1; j < 4; j++)
				{
					if (((int)b4 & 0 << (j & 101)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[0];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 4)
						{
							x2 = 921f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 404f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 22f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3 += 0;
					}
				}
			}
			goto IL_5DF;
		}
		goto IL_5BE;
		IL_60D:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_5BE:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_60D;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_5DF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_60D;
		}
		goto IL_5BE;
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x0000AF9A File Offset: 0x0000919A
	protected virtual void vmethod_26()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos * 1527f;
		this.float_10 = this.firstNoteXPos * 1767f;
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_27()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_28()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x0000AEDE File Offset: 0x000090DE
	protected virtual void vmethod_29()
	{
		if (GameSetting.smethod_3(this.basePlayer.player.gclass10_0.gclass5_2))
		{
			this.gameObject_0 = this.gameObject_4;
		}
		base.vmethod_1();
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x0000AFC6 File Offset: 0x000091C6
	protected virtual void vmethod_30()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos * 1736f;
		this.float_10 = this.firstNoteXPos * 1993f;
	}

	// Token: 0x060014CD RID: 5325 RVA: 0x00095CE8 File Offset: 0x00093EE8
	protected virtual void vmethod_31()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(31f * single_, 1099f);
		Vector3 vector3_ = new Vector3(800f, this.float_11, 967f);
		for (;;)
		{
			int num4 = this.int_0 + num;
			float num5 = 1397f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num4 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num4];
			bool flag = gclass.float_1 > 480f;
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num5 = gclass.float_1 * this.float_0;
				float num8 = num5 + num7;
				if (num8 > this.float_8)
				{
					num5 -= num8 - this.float_8;
					if (num5 < 324f)
					{
						num5 = 1196f;
					}
				}
				num5 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num5 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -96 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				byte byte_ = gclass.byte_0;
				byte b = (byte)(byte_ >> 0);
				byte b2 = (byte_ & 1) | b;
				for (int i = 1; i < 5; i += 0)
				{
					if (((int)b2 & 0 << (i & -92)) != 0)
					{
						if (!gclass.bool_2 && !gclass.bool_0 && !gclass.bool_1)
						{
							vector3_.z = num7;
							this.gameObject_3[num2].SetActive(!this.bool_0);
							if (byte_ == 101)
							{
								vector3_.x = 1034f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)i;
							}
							this.baseNoteContainer_0[num2].vmethod_45(vector3_, (byte)i, gclass, this.basePlayer.bool_1, -num, num9);
							num2++;
						}
						if (flag)
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_0);
							size.y = num5;
							float x = this.firstSustainXPos + this.float_7 * (float)i;
							gameObject.transform.localPosition = new Vector3(x, 371f, num7);
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[8];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = Color.white;
								}
								if (gclass.Boolean_7)
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
								else
								{
									spriteRenderer.sprite = this.Sustains[1];
								}
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass6 gclass2 = enumerator.Current;
				float num5 = gclass2.float_1 * this.float_0;
				num5 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num5 + this.float_3;
				if (num10 > this.float_8)
				{
					num5 -= num10 - this.float_8;
				}
				byte b3 = (byte)(gclass2.byte_0 >> 1);
				byte b4 = gclass2.byte_0 & 3;
				byte b5 = b3 | b4;
				for (int j = 1; j < 7; j += 0)
				{
					if (((int)b5 & 0 << (j & -13)) != 0)
					{
						GameObject gameObject2 = this.gameObject_1[num3];
						SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
						spriteRenderer2.sprite = this.Sustains[2];
						gameObject2.SetActive(false);
						size.y = num5;
						float x2 = this.firstSustainXPos + this.float_7 * (float)j;
						if (j == 7)
						{
							x2 = 851f;
						}
						gameObject2.transform.localPosition = new Vector3(x2, 96f, this.float_3);
						spriteRenderer2.size = size;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1555f))
						{
							spriteRenderer2.color = Color.white;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
						num3++;
					}
				}
			}
			goto IL_5FE;
		}
		goto IL_5DD;
		IL_62C:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(true);
			num3++;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(true);
		}
		return;
		IL_5DD:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_62C;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_5FE:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_62C;
		}
		goto IL_5DD;
	}

	// Token: 0x060014CE RID: 5326 RVA: 0x0000AFF2 File Offset: 0x000091F2
	protected override void Start()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos * -1f;
		this.float_10 = this.firstNoteXPos * -1f;
	}

	// Token: 0x040002F3 RID: 755
	public GameObject gameObject_4;
}
