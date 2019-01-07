using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200006A RID: 106
public class GuitarNoteRenderer : BaseNoteRenderer
{
	// Token: 0x060014CF RID: 5327 RVA: 0x00096374 File Offset: 0x00094574
	protected virtual void vmethod_2()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1697f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(775f * single_, 953f);
		Vector2 size2 = new Vector2(371f * single_, 893f);
		Vector2 size3 = new Vector2(1951f * single_, 1996f);
		Vector3 vector3_ = new Vector3(1682f, this.float_11, 1128f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1584f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 377f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 222f)
					{
						num4 = 1019f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
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
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_61(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_69(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_91(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 79)
							{
								gameObject.transform.localPosition = new Vector3(1653f, 1060f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[2];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 83f, num7 + 342f);
								size.y = num4 - 335f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_49(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 8)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(1534f, 1182f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[6];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1494f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 469f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[3];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 758f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_7BF;
		}
		goto IL_79E;
		IL_7ED:
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
		IL_79E:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_7ED;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_7BF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_7ED;
		}
		goto IL_79E;
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x00096C08 File Offset: 0x00094E08
	protected virtual void vmethod_3()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		float num4 = 506f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1692f * single_, 1411f);
		Vector2 size2 = new Vector2(1602f * single_, 1348f);
		Vector2 size3 = new Vector2(101f * single_, 1874f);
		Vector3 vector3_ = new Vector3(1310f, this.float_11, 1500f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 336f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1000f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 209f)
					{
						num4 = 1747f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 71 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_55(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_5(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_70(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 39)
							{
								gameObject.transform.localPosition = new Vector3(1985f, 850f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[8];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1437f, num7 + 549f);
								size.y = num4 - 735f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_13(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 11)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1418f, 1452f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[7];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1543f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 460f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[0];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 753f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_7BF;
		}
		goto IL_79E;
		IL_7ED:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_79E:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_7ED;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_7BF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_7ED;
		}
		goto IL_79E;
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x0000B01E File Offset: 0x0000921E
	protected virtual void vmethod_4()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1164f * 996f;
		this.float_10 = this.firstNoteXPos / 1086f * 1182f;
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x0000B056 File Offset: 0x00009256
	protected virtual void vmethod_5()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 573f * 1701f;
		this.float_10 = this.firstNoteXPos / 71f * 294f;
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x0000B08E File Offset: 0x0000928E
	protected virtual void vmethod_6()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1002f * 1339f;
		this.float_10 = this.firstNoteXPos / 241f * 1293f;
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x0000B0C6 File Offset: 0x000092C6
	protected virtual void vmethod_7()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1898f * 375f;
		this.float_10 = this.firstNoteXPos / 1945f * 617f;
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x0000B0FE File Offset: 0x000092FE
	protected virtual void vmethod_8()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1388f * 593f;
		this.float_10 = this.firstNoteXPos / 1691f * 1874f;
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x0009749C File Offset: 0x0009569C
	protected virtual void vmethod_9()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		float num4 = 789f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(514f * single_, 111f);
		Vector2 size2 = new Vector2(1828f * single_, 1879f);
		Vector2 size3 = new Vector2(665f * single_, 1175f);
		Vector3 vector3_ = new Vector3(1205f, this.float_11, 303f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 411f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1583f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1051f)
					{
						num4 = 49f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 65 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_35(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 25)
							{
								vector3_.x = 741f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_17(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_91(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1959f, num7 + 1182f);
							size.y = num4 - 1968f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_29(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 60)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1048f, 1295f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[0];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1555f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1446f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[8];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1917f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x00097CC0 File Offset: 0x00095EC0
	protected virtual void vmethod_10()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 773f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(257f * single_, 1651f);
		Vector2 vector = new Vector2(944f * single_, 376f);
		Vector2 vector2 = new Vector2(802f * single_, 94f);
		Vector3 vector3_ = new Vector3(1584f, this.float_11, 1594f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1873f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 709f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 28f)
					{
						num4 = 1511f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -110 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_11(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 15)
							{
								vector3_.x = 162f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_76(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_61(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 718f, num7 + 1568f);
							size.y = num4 - 1099f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_70(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1256f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[6];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 654f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_677;
		}
		goto IL_656;
		IL_6A5:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_656:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_6A5;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_677:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_6A5;
		}
		goto IL_656;
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x0009840C File Offset: 0x0009660C
	protected virtual void vmethod_11()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 1780f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1537f * single_, 1730f);
		Vector2 size2 = new Vector2(72f * single_, 1767f);
		Vector2 size3 = new Vector2(81f * single_, 1917f);
		Vector3 vector3_ = new Vector3(125f, this.float_11, 1233f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 660f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1422f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1074f)
					{
						num4 = 673f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 27 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_53(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_69(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_73(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 73)
							{
								gameObject.transform.localPosition = new Vector3(1770f, 660f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[1];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1901f, num7 + 333f);
								size.y = num4 - 135f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[6];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_85(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 25)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(52f, 993f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[6];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1620f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 501f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[7];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 516f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7BF;
		}
		goto IL_79E;
		IL_7ED:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_79E:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_7ED;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_7BF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_7ED;
		}
		goto IL_79E;
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x00098CA0 File Offset: 0x00096EA0
	protected virtual void vmethod_12()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		float num4 = 143f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(981f * single_, 388f);
		Vector2 size2 = new Vector2(1412f * single_, 1007f);
		Vector2 size3 = new Vector2(1142f * single_, 1963f);
		Vector3 vector3_ = new Vector3(209f, this.float_11, 1869f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1967f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1737f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1804f)
					{
						num4 = 1164f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -6 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_64(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 112)
							{
								vector3_.x = 1918f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_30(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_66(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 87)
							{
								gameObject.transform.localPosition = new Vector3(905f, 439f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[8];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1796f, num7 + 625f);
								size.y = num4 - 1919f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_13(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 98)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(260f, 1643f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[8];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 304f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 973f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[1];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 122f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
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
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x00099550 File Offset: 0x00097750
	protected virtual void vmethod_13()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		float num4 = 900f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1465f * single_, 808f);
		Vector2 size2 = new Vector2(759f * single_, 589f);
		Vector2 vector = new Vector2(274f * single_, 1648f);
		Vector3 vector3_ = new Vector3(629f, this.float_11, 1903f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 11f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 521f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1285f)
					{
						num4 = 754f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 102 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_75(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 122)
							{
								vector3_.x = 825f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_5(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_64(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 72)
							{
								gameObject.transform.localPosition = new Vector3(483f, 1556f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[1];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 642f, num7 + 936f);
								size.y = num4 - 1029f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_4(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 310f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[2];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 386f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_706;
		}
		goto IL_6E5;
		IL_734:
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
		IL_6E5:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_734;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_706:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_734;
		}
		goto IL_6E5;
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x00099D2C File Offset: 0x00097F2C
	protected virtual void vmethod_14()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		float num4 = 256f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(60f * single_, 113f);
		Vector2 size2 = new Vector2(253f * single_, 1186f);
		Vector2 size3 = new Vector2(1465f * single_, 1295f);
		Vector3 vector3_ = new Vector3(822f, this.float_11, 843f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1698f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1614f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1073f)
					{
						num4 = 570f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 82 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_43(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 90)
							{
								vector3_.x = 111f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_37(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_49(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 59)
							{
								gameObject.transform.localPosition = new Vector3(842f, 466f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[7];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 416f, num7 + 1445f);
								size.y = num4 - 1989f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_61(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 0)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(312f, 1182f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[4];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 40f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1465f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[7];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 374f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x0009A5DC File Offset: 0x000987DC
	protected virtual void vmethod_15()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 330f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(953f * single_, 1393f);
		Vector2 size2 = new Vector2(184f * single_, 1219f);
		Vector2 size3 = new Vector2(536f * single_, 547f);
		Vector3 vector3_ = new Vector3(203f, this.float_11, 4f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 908f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1840f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1999f)
					{
						num4 = 441f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 26 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_37(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 73)
							{
								vector3_.x = 289f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_73(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_35(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1134f, num7 + 1117f);
							size.y = num4 - 912f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[5];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_52(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 104)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(727f, 1576f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[7];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1763f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1211f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[3];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1835f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x0000B136 File Offset: 0x00009336
	protected virtual void vmethod_16()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1070f * 1573f;
		this.float_10 = this.firstNoteXPos / 1857f * 1715f;
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x0000B16E File Offset: 0x0000936E
	protected virtual void vmethod_17()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 72f * 254f;
		this.float_10 = this.firstNoteXPos / 1598f * 425f;
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x0000B1A6 File Offset: 0x000093A6
	protected virtual void vmethod_18()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 353f * 1f;
		this.float_10 = this.firstNoteXPos / 1380f * 1965f;
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x0009AE00 File Offset: 0x00099000
	protected virtual void vmethod_19()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1418f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(976f * single_, 1432f);
		Vector2 size2 = new Vector2(981f * single_, 570f);
		Vector2 size3 = new Vector2(1407f * single_, 1598f);
		Vector3 vector3_ = new Vector3(1240f, this.float_11, 1555f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1658f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1863f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 613f)
					{
						num4 = 615f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -78 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_49(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 124)
							{
								vector3_.x = 1187f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_41(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_31(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 949f, num7 + 1699f);
							size.y = num4 - 878f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_91(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 13)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1863f, 700f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[3];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1198f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1137f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[4];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1909f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x0000B1DE File Offset: 0x000093DE
	protected virtual void vmethod_20()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1100f * 470f;
		this.float_10 = this.firstNoteXPos / 584f * 1527f;
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x0009B624 File Offset: 0x00099824
	protected virtual void vmethod_21()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		float num4 = 107f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1996f * single_, 1009f);
		Vector2 size2 = new Vector2(346f * single_, 19f);
		Vector2 size3 = new Vector2(920f * single_, 903f);
		Vector3 vector3_ = new Vector3(1462f, this.float_11, 947f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 923f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1065f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 827f)
					{
						num4 = 547f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -36 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_35(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 103)
							{
								vector3_.x = 1632f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_35(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_22(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1869f, num7 + 1521f);
							size.y = num4 - 963f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[6];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_75(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 32)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1167f, 1934f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[0];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 181f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 123f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[8];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 306f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x0000B216 File Offset: 0x00009416
	protected virtual void vmethod_22()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1509f * 1983f;
		this.float_10 = this.firstNoteXPos / 541f * 1178f;
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x0009BE48 File Offset: 0x0009A048
	protected virtual void vmethod_23()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 1625f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1226f * single_, 1983f);
		Vector2 size2 = new Vector2(844f * single_, 903f);
		Vector2 size3 = new Vector2(1793f * single_, 492f);
		Vector3 vector3_ = new Vector3(1446f, this.float_11, 882f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1449f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 622f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1861f)
					{
						num4 = 1644f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 8 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_62(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_45(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_12(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 123)
							{
								gameObject.transform.localPosition = new Vector3(1874f, 256f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[8];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 675f, num7 + 333f);
								size.y = num4 - 1117f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_26(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 120)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(1907f, 506f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[8];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 464f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 461f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[8];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 362f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_7BF;
		}
		goto IL_79E;
		IL_7ED:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_79E:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_7ED;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_7BF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_7ED;
		}
		goto IL_79E;
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x0000B24E File Offset: 0x0000944E
	protected virtual void vmethod_24()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1109f * 1459f;
		this.float_10 = this.firstNoteXPos / 940f * 1356f;
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x0009C6DC File Offset: 0x0009A8DC
	protected virtual void vmethod_25()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 50f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1653f * single_, 1927f);
		Vector2 vector = new Vector2(982f * single_, 181f);
		Vector2 vector2 = new Vector2(1938f * single_, 1078f);
		Vector3 vector3_ = new Vector3(1844f, this.float_11, 1658f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1492f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 164f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 209f)
					{
						num4 = 508f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -30 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_90(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 66)
							{
								vector3_.x = 33f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_63(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_73(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 423f, num7 + 1520f);
							size.y = num4 - 1506f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[6];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_5(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 373f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[1];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 406f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_677;
		}
		goto IL_656;
		IL_6A5:
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
		IL_656:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_6A5;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_677:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_6A5;
		}
		goto IL_656;
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x0009CE28 File Offset: 0x0009B028
	protected virtual void vmethod_26()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 1069f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(451f * single_, 1734f);
		Vector2 vector = new Vector2(1944f * single_, 1772f);
		Vector2 vector2 = new Vector2(874f * single_, 780f);
		Vector3 vector3_ = new Vector3(1225f, this.float_11, 129f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 506f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1776f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1805f)
					{
						num4 = 141f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -50 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_53(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 59)
							{
								vector3_.x = 1417f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_5(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_61(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1382f, num7 + 1438f);
							size.y = num4 - 241f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[5];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_91(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1931f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[1];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1236f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_677;
		}
		goto IL_656;
		IL_6A5:
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
		IL_656:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_6A5;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_677:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_6A5;
		}
		goto IL_656;
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x0009D574 File Offset: 0x0009B774
	protected virtual void vmethod_27()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		float num4 = 1587f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1979f * single_, 987f);
		Vector2 vector = new Vector2(152f * single_, 157f);
		Vector2 vector2 = new Vector2(1928f * single_, 1567f);
		Vector3 vector3_ = new Vector3(785f, this.float_11, 1718f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1308f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1954f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 253f)
					{
						num4 = 602f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 6 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_64(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_69(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_38(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 962f, num7 + 1974f);
							size.y = num4 - 866f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[0];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_36(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 177f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[2];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 881f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x0009DCA4 File Offset: 0x0009BEA4
	protected virtual void vmethod_28()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		float num4 = 1799f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1454f * single_, 1302f);
		Vector2 vector = new Vector2(674f * single_, 687f);
		Vector2 vector2 = new Vector2(2f * single_, 147f);
		Vector3 vector3_ = new Vector3(588f, this.float_11, 539f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1875f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 350f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 308f)
					{
						num4 = 206f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -34 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_52(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_30(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_89(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1503f, num7 + 1447f);
							size.y = num4 - 682f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_55(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1021f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[5];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 310f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x0000B286 File Offset: 0x00009486
	protected virtual void vmethod_29()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1964f * 334f;
		this.float_10 = this.firstNoteXPos / 1607f * 836f;
	}

	// Token: 0x060014EB RID: 5355 RVA: 0x0009E3D4 File Offset: 0x0009C5D4
	protected override void Update()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 0f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(0.13f * single_, 0f);
		Vector2 size2 = new Vector2(0.9f * single_, 0f);
		Vector2 size3 = new Vector2(0.85f * single_, 0f);
		Vector3 vector3_ = new Vector3(0f, this.float_11, 0f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 0f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 0f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 0f)
					{
						num4 = 0f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
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
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_67(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 64)
							{
								vector3_.x = 0f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_35(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_67(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 64)
							{
								gameObject.transform.localPosition = new Vector3(0f, 0f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 0f, num7 + 0.3f);
								size.y = num4 - 0.3f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_67(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 64)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(0f, 0f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[4];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 0f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 0f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[3];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 0f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
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
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x0000B2BE File Offset: 0x000094BE
	protected virtual void vmethod_30()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1429f * 997f;
		this.float_10 = this.firstNoteXPos / 1289f * 1441f;
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x0000B2F6 File Offset: 0x000094F6
	protected virtual void vmethod_31()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 305f * 297f;
		this.float_10 = this.firstNoteXPos / 1925f * 1363f;
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x0009EC84 File Offset: 0x0009CE84
	protected virtual void vmethod_32()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		float num4 = 1255f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1141f * single_, 699f);
		Vector2 size2 = new Vector2(636f * single_, 491f);
		Vector2 vector = new Vector2(1295f * single_, 1134f);
		Vector3 vector3_ = new Vector3(756f, this.float_11, 1165f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 932f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1670f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1684f)
					{
						num4 = 753f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 53 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_31(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_38(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_2(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 25)
							{
								gameObject.transform.localPosition = new Vector3(1248f, 1427f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[0];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1542f, num7 + 1514f);
								size.y = num4 - 450f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_38(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1326f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[1];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1828f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_6EA;
		}
		goto IL_6C9;
		IL_718:
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
		IL_6C9:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_718;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_6EA:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_718;
		}
		goto IL_6C9;
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x0000B32E File Offset: 0x0000952E
	protected virtual void vmethod_33()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1943f * 1425f;
		this.float_10 = this.firstNoteXPos / 1507f * 1072f;
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x0000B366 File Offset: 0x00009566
	protected virtual void vmethod_34()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 136f * 1894f;
		this.float_10 = this.firstNoteXPos / 1438f * 1012f;
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x0009F444 File Offset: 0x0009D644
	protected virtual void vmethod_35()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1113f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1873f * single_, 206f);
		Vector2 size2 = new Vector2(1623f * single_, 563f);
		Vector2 size3 = new Vector2(983f * single_, 1511f);
		Vector3 vector3_ = new Vector3(1634f, this.float_11, 1337f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1218f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 855f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 725f)
					{
						num4 = 213f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 43 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_40(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 90)
							{
								vector3_.x = 1955f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_76(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_2(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 40)
							{
								gameObject.transform.localPosition = new Vector3(1651f, 874f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[3];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 551f, num7 + 1670f);
								size.y = num4 - 1792f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_67(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 66)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(991f, 779f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[8];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 813f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1506f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[5];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 845f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
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
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x0009FCF4 File Offset: 0x0009DEF4
	protected virtual void vmethod_36()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1840f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1228f * single_, 1450f);
		Vector2 vector = new Vector2(1677f * single_, 1644f);
		Vector2 vector2 = new Vector2(1180f * single_, 1011f);
		Vector3 vector3_ = new Vector3(1307f, this.float_11, 1351f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 945f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1057f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 267f)
					{
						num4 = 1302f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -99 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_70(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_69(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_4(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1070f, num7 + 205f);
							size.y = num4 - 237f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_43(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 635f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[2];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 15f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x0000B39E File Offset: 0x0000959E
	protected override void Start()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 2f * -1f;
		this.float_10 = this.firstNoteXPos / 2f * -1f;
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x000A0424 File Offset: 0x0009E624
	protected virtual void vmethod_37()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		float num4 = 1026f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(613f * single_, 247f);
		Vector2 size2 = new Vector2(853f * single_, 510f);
		Vector2 size3 = new Vector2(910f * single_, 141f);
		Vector3 vector3_ = new Vector3(1708f, this.float_11, 1681f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 655f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 930f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1591f)
					{
						num4 = 1625f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 81 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_70(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 57)
							{
								vector3_.x = 1098f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_69(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_64(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 42)
							{
								gameObject.transform.localPosition = new Vector3(1331f, 1718f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[5];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1030f, num7 + 1134f);
								size.y = num4 - 56f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_52(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 107)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(665f, 760f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[3];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 780f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1059f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[6];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1687f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
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
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x000A0CD4 File Offset: 0x0009EED4
	protected virtual void vmethod_38()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 1922f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1580f * single_, 634f);
		Vector2 vector = new Vector2(1299f * single_, 1373f);
		Vector2 vector2 = new Vector2(1915f * single_, 1947f);
		Vector3 vector3_ = new Vector3(273f, this.float_11, 1612f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 248f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1951f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 94f)
					{
						num4 = 471f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -27 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_10(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_30(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_27(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1226f, num7 + 1828f);
							size.y = num4 - 377f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_26(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 567f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[3];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 702f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x000A1404 File Offset: 0x0009F604
	protected virtual void vmethod_39()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 1998f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(788f * single_, 39f);
		Vector2 size2 = new Vector2(1420f * single_, 1218f);
		Vector2 vector = new Vector2(1568f * single_, 932f);
		Vector3 vector3_ = new Vector3(1697f, this.float_11, 823f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 532f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1218f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 403f)
					{
						num4 = 1887f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -78 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_91(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 89)
							{
								vector3_.x = 1014f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_30(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_18(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 88)
							{
								gameObject.transform.localPosition = new Vector3(1631f, 242f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[6];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1857f, num7 + 1355f);
								size.y = num4 - 234f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_91(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 200f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[4];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1974f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_706;
		}
		goto IL_6E5;
		IL_734:
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
		IL_6E5:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_734;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_706:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_734;
		}
		goto IL_6E5;
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x000A1BE0 File Offset: 0x0009FDE0
	protected virtual void vmethod_40()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		float num4 = 248f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1802f * single_, 1987f);
		Vector2 vector = new Vector2(1617f * single_, 75f);
		Vector2 vector2 = new Vector2(235f * single_, 1866f);
		Vector3 vector3_ = new Vector3(38f, this.float_11, 1582f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1208f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1931f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1548f)
					{
						num4 = 883f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 33 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_61(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 67)
							{
								vector3_.x = 1001f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_32(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_75(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1136f, num7 + 976f);
							size.y = num4 - 560f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_40(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1284f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[0];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 227f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_677;
		}
		goto IL_656;
		IL_6A5:
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
		IL_656:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_6A5;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_677:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_6A5;
		}
		goto IL_656;
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x0000B3D6 File Offset: 0x000095D6
	protected virtual void vmethod_41()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 550f * 1135f;
		this.float_10 = this.firstNoteXPos / 25f * 647f;
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x000A232C File Offset: 0x000A052C
	protected virtual void vmethod_42()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1672f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1304f * single_, 177f);
		Vector2 size2 = new Vector2(757f * single_, 464f);
		Vector2 size3 = new Vector2(897f * single_, 1928f);
		Vector3 vector3_ = new Vector3(684f, this.float_11, 217f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1226f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1938f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 177f)
					{
						num4 = 1256f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 15 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_18(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 71)
							{
								vector3_.x = 1769f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_36(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_89(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 109)
							{
								gameObject.transform.localPosition = new Vector3(100f, 810f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[0];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1603f, num7 + 1246f);
								size.y = num4 - 1867f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[6];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_60(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 9)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(689f, 603f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[6];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1349f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 500f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[2];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 116f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
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
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x000A2BDC File Offset: 0x000A0DDC
	protected virtual void vmethod_43()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 1;
		float num4 = 1494f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1455f * single_, 1233f);
		Vector2 size2 = new Vector2(765f * single_, 255f);
		Vector2 size3 = new Vector2(1069f * single_, 1351f);
		Vector3 vector3_ = new Vector3(1059f, this.float_11, 192f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 406f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 521f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 231f)
					{
						num4 = 280f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 67 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_66(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 9)
							{
								vector3_.x = 753f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_5(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_10(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 949f, num7 + 1560f);
							size.y = num4 - 1490f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_18(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 8)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1064f, 742f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[8];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1548f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1590f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[1];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1107f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x000A3400 File Offset: 0x000A1600
	protected virtual void vmethod_44()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		float num4 = 1585f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1602f * single_, 1588f);
		Vector2 size2 = new Vector2(1505f * single_, 1332f);
		Vector2 vector = new Vector2(1088f * single_, 941f);
		Vector3 vector3_ = new Vector3(506f, this.float_11, 1818f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1180f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1093f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1161f)
					{
						num4 = 1217f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -25 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_4(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_58(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_62(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 51)
							{
								gameObject.transform.localPosition = new Vector3(1185f, 1717f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[8];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1759f, num7 + 1064f);
								size.y = num4 - 465f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_82(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 235f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[1];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 850f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_6EA;
		}
		goto IL_6C9;
		IL_718:
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
		IL_6C9:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_718;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_6EA:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_718;
		}
		goto IL_6C9;
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
	protected virtual void vmethod_45()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1595f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1123f * single_, 248f);
		Vector2 size2 = new Vector2(864f * single_, 28f);
		Vector2 vector = new Vector2(401f * single_, 1463f);
		Vector3 vector3_ = new Vector3(437f, this.float_11, 897f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 289f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 864f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1432f)
					{
						num4 = 1870f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -37 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_60(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_32(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_35(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 79)
							{
								gameObject.transform.localPosition = new Vector3(979f, 538f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[6];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 853f, num7 + 178f);
								size.y = num4 - 1339f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_13(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1005f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[3];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 935f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_6EA;
		}
		goto IL_6C9;
		IL_718:
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
		IL_6C9:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_718;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_6EA:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_718;
		}
		goto IL_6C9;
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x000A4380 File Offset: 0x000A2580
	protected virtual void vmethod_46()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 1884f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1525f * single_, 824f);
		Vector2 size2 = new Vector2(665f * single_, 601f);
		Vector2 vector = new Vector2(257f * single_, 1308f);
		Vector3 vector3_ = new Vector3(1540f, this.float_11, 687f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 2f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 665f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 753f)
					{
						num4 = 1141f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -90 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_22(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_58(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_90(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 77)
							{
								gameObject.transform.localPosition = new Vector3(1701f, 452f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[3];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1266f, num7 + 441f);
								size.y = num4 - 109f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_75(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 994f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[2];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 691f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_6EA;
		}
		goto IL_6C9;
		IL_718:
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
		IL_6C9:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_718;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_6EA:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_718;
		}
		goto IL_6C9;
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x000A4B40 File Offset: 0x000A2D40
	protected virtual void vmethod_47()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 1281f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1879f * single_, 947f);
		Vector2 vector = new Vector2(190f * single_, 328f);
		Vector2 vector2 = new Vector2(533f * single_, 281f);
		Vector3 vector3_ = new Vector3(606f, this.float_11, 391f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1462f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1579f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1850f)
					{
						num4 = 467f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 1 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_13(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 114)
							{
								vector3_.x = 37f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_8(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_4(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1957f, num7 + 29f);
							size.y = num4 - 1668f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[5];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_60(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1596f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[8];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 385f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_677;
		}
		goto IL_656;
		IL_6A5:
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
		IL_656:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_6A5;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_677:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_6A5;
		}
		goto IL_656;
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x0000B40E File Offset: 0x0000960E
	protected virtual void vmethod_48()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1148f * 761f;
		this.float_10 = this.firstNoteXPos / 1758f * 451f;
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x0000B446 File Offset: 0x00009646
	protected virtual void vmethod_49()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 986f * 316f;
		this.float_10 = this.firstNoteXPos / 1860f * 1228f;
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x0000B47E File Offset: 0x0000967E
	protected virtual void vmethod_50()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 338f * 1875f;
		this.float_10 = this.firstNoteXPos / 228f * 810f;
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x000A528C File Offset: 0x000A348C
	protected virtual void vmethod_51()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 1;
		float num4 = 1562f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1329f * single_, 1108f);
		Vector2 vector = new Vector2(1389f * single_, 699f);
		Vector2 vector2 = new Vector2(612f * single_, 170f);
		Vector3 vector3_ = new Vector3(342f, this.float_11, 1521f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1963f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1068f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1903f)
					{
						num4 = 1101f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 6 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_87(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 49)
							{
								vector3_.x = 1682f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_66(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_5(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 123f, num7 + 438f);
							size.y = num4 - 1219f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[0];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_32(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 822f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[1];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 824f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_677;
		}
		goto IL_656;
		IL_6A5:
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
		IL_656:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_6A5;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_677:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_6A5;
		}
		goto IL_656;
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x0000B4B6 File Offset: 0x000096B6
	protected virtual void vmethod_52()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1166f * 1149f;
		this.float_10 = this.firstNoteXPos / 1865f * 985f;
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x0000B4EE File Offset: 0x000096EE
	protected virtual void vmethod_53()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1314f * 1369f;
		this.float_10 = this.firstNoteXPos / 587f * 967f;
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x000A59D8 File Offset: 0x000A3BD8
	protected virtual void vmethod_54()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 573f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(423f * single_, 1426f);
		Vector2 size2 = new Vector2(534f * single_, 185f);
		Vector2 size3 = new Vector2(1115f * single_, 1231f);
		Vector3 vector3_ = new Vector3(1366f, this.float_11, 417f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 638f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 625f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 673f)
					{
						num4 = 671f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 12 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_53(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_41(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_40(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 120)
							{
								gameObject.transform.localPosition = new Vector3(1872f, 389f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1657f, num7 + 1849f);
								size.y = num4 - 377f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_10(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 86)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1094f, 1211f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[1];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1762f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 513f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[4];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 255f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7BF;
		}
		goto IL_79E;
		IL_7ED:
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
		IL_79E:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_7ED;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_7BF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_7ED;
		}
		goto IL_79E;
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x000A626C File Offset: 0x000A446C
	protected virtual void vmethod_55()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		float num4 = 1884f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(573f * single_, 843f);
		Vector2 size2 = new Vector2(1468f * single_, 769f);
		Vector2 vector = new Vector2(1872f * single_, 1496f);
		Vector3 vector3_ = new Vector3(769f, this.float_11, 322f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1571f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1661f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1187f)
					{
						num4 = 1134f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -49 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_85(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_35(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_61(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 82)
							{
								gameObject.transform.localPosition = new Vector3(923f, 1068f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[1];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1277f, num7 + 1169f);
								size.y = num4 - 1759f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_57(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 413f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[5];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 806f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_6EA;
		}
		goto IL_6C9;
		IL_718:
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
		IL_6C9:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_718;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_6EA:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_718;
		}
		goto IL_6C9;
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x0000B526 File Offset: 0x00009726
	protected virtual void vmethod_56()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1493f * 441f;
		this.float_10 = this.firstNoteXPos / 607f * 482f;
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x0000B55E File Offset: 0x0000975E
	protected virtual void vmethod_57()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 964f * 1899f;
		this.float_10 = this.firstNoteXPos / 154f * 361f;
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x000A6A2C File Offset: 0x000A4C2C
	protected virtual void vmethod_58()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		float num4 = 597f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1308f * single_, 999f);
		Vector2 size2 = new Vector2(641f * single_, 533f);
		Vector2 size3 = new Vector2(330f * single_, 565f);
		Vector3 vector3_ = new Vector3(1972f, this.float_11, 1359f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1215f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1786f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 320f)
					{
						num4 = 594f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -81 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_77(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 15)
							{
								vector3_.x = 594f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_39(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_64(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 233f, num7 + 469f);
							size.y = num4 - 335f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[5];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_13(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 100)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1874f, 365f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[2];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1998f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 576f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[7];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 809f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x000A7250 File Offset: 0x000A5450
	protected virtual void vmethod_59()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1689f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(760f * single_, 482f);
		Vector2 vector = new Vector2(667f * single_, 1570f);
		Vector2 vector2 = new Vector2(1129f * single_, 1055f);
		Vector3 vector3_ = new Vector3(1170f, this.float_11, 39f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 329f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 235f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1204f)
					{
						num4 = 1814f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 74 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_67(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_30(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_20(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 144f, num7 + 1272f);
							size.y = num4 - 1096f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_58(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 354f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[4];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1581f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x0000B596 File Offset: 0x00009796
	protected virtual void vmethod_60()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 5f * 944f;
		this.float_10 = this.firstNoteXPos / 1388f * 885f;
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x000A7980 File Offset: 0x000A5B80
	protected virtual void vmethod_61()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 801f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(983f * single_, 1864f);
		Vector2 size2 = new Vector2(1456f * single_, 612f);
		Vector2 vector = new Vector2(1532f * single_, 1214f);
		Vector3 vector3_ = new Vector3(672f, this.float_11, 1195f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1307f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 979f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1166f)
					{
						num4 = 1137f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -118 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_37(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_66(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_67(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 66)
							{
								gameObject.transform.localPosition = new Vector3(1109f, 1548f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 443f, num7 + 931f);
								size.y = num4 - 335f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_82(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1060f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[6];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 310f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_6EA;
		}
		goto IL_6C9;
		IL_718:
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
		IL_6C9:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_718;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_6EA:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_718;
		}
		goto IL_6C9;
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x000A8140 File Offset: 0x000A6340
	protected virtual void vmethod_62()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 0;
		float num4 = 890f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1221f * single_, 1273f);
		Vector2 size2 = new Vector2(896f * single_, 1307f);
		Vector2 size3 = new Vector2(1791f * single_, 321f);
		Vector3 vector3_ = new Vector3(384f, this.float_11, 290f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1571f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1626f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1078f)
					{
						num4 = 69f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 124 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_87(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_35(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_22(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 49)
							{
								gameObject.transform.localPosition = new Vector3(62f, 564f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[3];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 744f, num7 + 1789f);
								size.y = num4 - 1445f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_2(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 31)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(706f, 1429f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[0];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 196f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1958f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[1];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 436f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7BF;
		}
		goto IL_79E;
		IL_7ED:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_79E:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_7ED;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_7BF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_7ED;
		}
		goto IL_79E;
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x000A89D4 File Offset: 0x000A6BD4
	protected virtual void vmethod_63()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		float num4 = 1187f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1474f * single_, 741f);
		Vector2 size2 = new Vector2(1155f * single_, 592f);
		Vector2 size3 = new Vector2(1949f * single_, 767f);
		Vector3 vector3_ = new Vector3(1582f, this.float_11, 136f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1742f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 109f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1593f)
					{
						num4 = 58f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
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
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_0(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_72(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_87(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 797f, num7 + 1844f);
							size.y = num4 - 153f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_0(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 39)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1885f, 517f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[0];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1014f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1451f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[4];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 472f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_730;
		}
		goto IL_70F;
		IL_75E:
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
		IL_70F:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_75E;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_730:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_75E;
		}
		goto IL_70F;
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x000A91DC File Offset: 0x000A73DC
	protected virtual void vmethod_64()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 734f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1820f * single_, 1528f);
		Vector2 size2 = new Vector2(827f * single_, 247f);
		Vector2 size3 = new Vector2(384f * single_, 1667f);
		Vector3 vector3_ = new Vector3(38f, this.float_11, 665f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1559f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1739f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 411f)
					{
						num4 = 186f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -91 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_4(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 118)
							{
								vector3_.x = 1153f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_66(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_4(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 532f, num7 + 488f);
							size.y = num4 - 1545f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_31(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 73)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(347f, 1771f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[4];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1682f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 405f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[4];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 685f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x000A9A00 File Offset: 0x000A7C00
	protected virtual void vmethod_65()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 945f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1940f * single_, 1360f);
		Vector2 vector = new Vector2(264f * single_, 1370f);
		Vector2 vector2 = new Vector2(148f * single_, 848f);
		Vector3 vector3_ = new Vector3(807f, this.float_11, 1802f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1562f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1669f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1537f)
					{
						num4 = 1399f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 66 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_91(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_35(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_20(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 150f, num7 + 1817f);
							size.y = num4 - 1111f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_5(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 910f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[2];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1512f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x000AA130 File Offset: 0x000A8330
	protected virtual void vmethod_66()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 506f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(56f * single_, 1841f);
		Vector2 size2 = new Vector2(1101f * single_, 1817f);
		Vector2 size3 = new Vector2(1271f * single_, 949f);
		Vector3 vector3_ = new Vector3(529f, this.float_11, 797f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1985f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1930f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 931f)
					{
						num4 = 494f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -28 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_55(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 26)
							{
								vector3_.x = 1927f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_17(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_55(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1387f, num7 + 1886f);
							size.y = num4 - 300f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_64(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 56)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(798f, 1461f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[4];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1729f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 457f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[8];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 363f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x0000B5CE File Offset: 0x000097CE
	protected virtual void vmethod_67()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 342f * 622f;
		this.float_10 = this.firstNoteXPos / 668f * 1500f;
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x000AA954 File Offset: 0x000A8B54
	protected virtual void vmethod_68()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 1393f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1888f * single_, 1558f);
		Vector2 size2 = new Vector2(1054f * single_, 1373f);
		Vector2 vector = new Vector2(1994f * single_, 1889f);
		Vector3 vector3_ = new Vector3(1396f, this.float_11, 1431f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1534f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 862f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1584f)
					{
						num4 = 1747f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -45 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_66(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_17(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_87(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							if (gclass.byte_0 == 73)
							{
								gameObject.transform.localPosition = new Vector3(243f, 1594f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[6];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1916f, num7 + 1003f);
								size.y = num4 - 1495f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_0(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1111f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[4];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 376f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_6EA;
		}
		goto IL_6C9;
		IL_718:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_6C9:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_718;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_6EA:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_718;
		}
		goto IL_6C9;
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x0000B606 File Offset: 0x00009806
	protected virtual void vmethod_69()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1606f * 1088f;
		this.float_10 = this.firstNoteXPos / 1832f * 735f;
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x0000B63E File Offset: 0x0000983E
	protected virtual void vmethod_70()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 18f * 1558f;
		this.float_10 = this.firstNoteXPos / 1529f * 1989f;
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x000AB114 File Offset: 0x000A9314
	protected virtual void vmethod_71()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 277f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(115f * single_, 603f);
		Vector2 size2 = new Vector2(253f * single_, 1517f);
		Vector2 size3 = new Vector2(1891f * single_, 238f);
		Vector3 vector3_ = new Vector3(1598f, this.float_11, 1537f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1459f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1713f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 376f)
					{
						num4 = 1593f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
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
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_0(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_32(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_70(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1990f, num7 + 374f);
							size.y = num4 - 190f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[6];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_55(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 81)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1728f, 184f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[8];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 893f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 25f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[7];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 541f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_730;
		}
		goto IL_70F;
		IL_75E:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_70F:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_75E;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_730:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_75E;
		}
		goto IL_70F;
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x0000B676 File Offset: 0x00009876
	protected virtual void vmethod_72()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1977f * 416f;
		this.float_10 = this.firstNoteXPos / 22f * 1123f;
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x0000B6AE File Offset: 0x000098AE
	protected virtual void vmethod_73()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 256f * 1779f;
		this.float_10 = this.firstNoteXPos / 1248f * 223f;
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x0000B6E6 File Offset: 0x000098E6
	protected virtual void vmethod_74()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 850f * 1913f;
		this.float_10 = this.firstNoteXPos / 158f * 595f;
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x000AB91C File Offset: 0x000A9B1C
	protected virtual void vmethod_75()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 195f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(99f * single_, 557f);
		Vector2 size2 = new Vector2(1021f * single_, 1325f);
		Vector2 size3 = new Vector2(1311f * single_, 325f);
		Vector3 vector3_ = new Vector3(34f, this.float_11, 1628f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 565f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1309f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1080f)
					{
						num4 = 154f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 96 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_20(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 12)
							{
								vector3_.x = 1218f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_66(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_52(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 32)
							{
								gameObject.transform.localPosition = new Vector3(1361f, 135f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[6];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 203f, num7 + 396f);
								size.y = num4 - 26f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3++;
						}
					}
				}
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_4(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 32)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(836f, 1073f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[2];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1784f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1674f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[2];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 368f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
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
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x000AC1CC File Offset: 0x000AA3CC
	protected virtual void vmethod_76()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 274f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1340f * single_, 1453f);
		Vector2 vector = new Vector2(661f * single_, 609f);
		Vector2 vector2 = new Vector2(166f * single_, 585f);
		Vector3 vector3_ = new Vector3(1433f, this.float_11, 1105f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 522f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1540f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1085f)
					{
						num4 = 1587f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -124 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_70(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_45(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_36(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1765f, num7 + 225f);
							size.y = num4 - 94f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[0];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
				num++;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_73(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1971f, this.float_3);
					this.gameObject_2.SetActive(true);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[6];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 820f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x0000B71E File Offset: 0x0000991E
	protected virtual void vmethod_77()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1375f * 1103f;
		this.float_10 = this.firstNoteXPos / 1150f * 726f;
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x000AC8FC File Offset: 0x000AAAFC
	protected virtual void vmethod_78()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		float num4 = 1599f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(789f * single_, 923f);
		Vector2 size2 = new Vector2(617f * single_, 1178f);
		Vector2 size3 = new Vector2(407f * single_, 1186f);
		Vector3 vector3_ = new Vector3(1186f, this.float_11, 1794f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1926f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 730f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1915f)
					{
						num4 = 693f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -43 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_87(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 14)
							{
								vector3_.x = 1324f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_38(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_87(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 68)
							{
								gameObject.transform.localPosition = new Vector3(1562f, 1964f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[2];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1029f, num7 + 1256f);
								size.y = num4 - 317f;
								spriteRenderer.size = size;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.white;
									spriteRenderer.sprite = this.Sustains[0];
								}
								else
								{
									if (this.basePlayer.bool_1)
									{
										spriteRenderer.color = GClass7.color_4;
									}
									else
									{
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_60(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 77)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(183f, 792f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[4];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1587f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1039f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[4];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1720f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x0000B756 File Offset: 0x00009956
	protected virtual void vmethod_79()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1888f * 460f;
		this.float_10 = this.firstNoteXPos / 1628f * 899f;
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x0000B78E File Offset: 0x0000998E
	protected virtual void vmethod_80()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 372f * 1327f;
		this.float_10 = this.firstNoteXPos / 258f * 918f;
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x000AD1AC File Offset: 0x000AB3AC
	protected virtual void vmethod_81()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		float num4 = 171f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1831f * single_, 1328f);
		Vector2 size2 = new Vector2(70f * single_, 920f);
		Vector2 size3 = new Vector2(1701f * single_, 733f);
		Vector3 vector3_ = new Vector3(2f, this.float_11, 657f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 92f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 574f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1346f)
					{
						num4 = 783f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 86 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_38(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_30(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_29(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 489f, num7 + 1673f);
							size.y = num4 - 1804f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_82(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 4)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(1811f, 526f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[3];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 981f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1194f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[3];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 953f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_730;
		}
		goto IL_70F;
		IL_75E:
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
		IL_70F:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_75E;
		}
		this.gameObject_3[num2].SetActive(false);
		num2++;
		IL_730:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_75E;
		}
		goto IL_70F;
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x000AD9B4 File Offset: 0x000ABBB4
	protected virtual void vmethod_82()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 1;
		float num4 = 360f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(244f * single_, 174f);
		Vector2 size2 = new Vector2(381f * single_, 1735f);
		Vector2 size3 = new Vector2(949f * single_, 1010f);
		Vector3 vector3_ = new Vector3(1797f, this.float_11, 1411f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 372f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 350f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1755f)
					{
						num4 = 1121f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -86 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_62(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 14)
							{
								vector3_.x = 893f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_66(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_36(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 34)
							{
								gameObject.transform.localPosition = new Vector3(1806f, 655f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[3];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1736f, num7 + 994f);
								size.y = num4 - 1227f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_91(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					if (gclass2.byte_0 == 90)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1290f, 420f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[1];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1273f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1483f, this.float_3);
						this.gameObject_2.SetActive(true);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[6];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 534f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7DB;
		}
		goto IL_7BA;
		IL_809:
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
		IL_7BA:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_809;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_7DB:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_809;
		}
		goto IL_7BA;
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x000AE264 File Offset: 0x000AC464
	protected virtual void vmethod_83()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1774f;
		bool flag = true;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(22f * single_, 1966f);
		Vector2 size2 = new Vector2(641f * single_, 586f);
		Vector2 size3 = new Vector2(575f * single_, 458f);
		Vector3 vector3_ = new Vector3(389f, this.float_11, 1716f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 362f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 1].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1004f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 243f)
					{
						num4 = 337f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -96 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_85(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							if (gclass.byte_0 == 32)
							{
								vector3_.x = 1173f;
							}
							else
							{
								vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							}
							vector3_.z = num7;
							baseNoteContainer.vmethod_66(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_55(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 108f, num7 + 1535f);
							size.y = num4 - 1955f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_61(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 32)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(1506f, 1409f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[7];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1161f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 1528f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[5];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1722f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3++;
				}
			}
			goto IL_74C;
		}
		goto IL_72B;
		IL_77A:
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
		IL_72B:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_77A;
		}
		this.gameObject_3[num2].SetActive(false);
		num2 += 0;
		IL_74C:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_77A;
		}
		goto IL_72B;
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x000AEA88 File Offset: 0x000ACC88
	protected virtual void vmethod_84()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		float num4 = 699f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1899f * single_, 1481f);
		Vector2 vector = new Vector2(1435f * single_, 474f);
		Vector2 vector2 = new Vector2(929f * single_, 678f);
		Vector3 vector3_ = new Vector3(1878f, this.float_11, 364f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1769f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1089f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1385f)
					{
						num4 = 665f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -70 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5 += 0;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_87(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_29(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_73(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1121f, num7 + 1888f);
							size.y = num4 - 798f;
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
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_35(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 891f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[4];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 832f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3++;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x0000B7C6 File Offset: 0x000099C6
	protected virtual void vmethod_85()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 298f * 1913f;
		this.float_10 = this.firstNoteXPos / 251f * 881f;
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x000AF1B8 File Offset: 0x000AD3B8
	protected virtual void vmethod_86()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		float num4 = 698f;
		bool flag = false;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(498f * single_, 32f);
		Vector2 size2 = new Vector2(709f * single_, 899f);
		Vector2 size3 = new Vector2(1974f * single_, 126f);
		Vector3 vector3_ = new Vector3(1138f, this.float_11, 1745f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 833f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 0].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 977f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 916f)
					{
						num4 = 1206f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num += 0;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -61 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_60(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_69(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2 += 0;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_11(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(!this.bool_1);
							if (gclass.byte_0 == 109)
							{
								gameObject.transform.localPosition = new Vector3(173f, 1557f, num7);
								size2.y = num4;
								spriteRenderer.size = size2;
								if (gclass.bool_1)
								{
									spriteRenderer.color = Color.gray;
								}
								else if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_6;
								}
								spriteRenderer.sprite = this.Sustains[4];
							}
							else
							{
								gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 1534f, num7 + 1963f);
								size.y = num4 - 492f;
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
										spriteRenderer.color = GClass7.color_0[(int)b2];
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
							}
							num3 += 0;
						}
					}
				}
				num += 0;
			}
		}
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_37(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 20)
					{
						this.gameObject_2.SetActive(true);
						Vector3 localPosition = new Vector3(1904f, 164f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[7];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1595f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 56f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[6];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1352f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_7BF;
		}
		goto IL_79E;
		IL_7ED:
		while (num3 < this.gameObject_1.Length && this.gameObject_1[num3].activeSelf)
		{
			this.gameObject_1[num3].SetActive(false);
			num3 += 0;
		}
		if (this.basePlayer.list_0.Count == 0 && this.gameObject_2.activeSelf)
		{
			this.gameObject_2.SetActive(false);
		}
		return;
		IL_79E:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_7ED;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_7BF:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_7ED;
		}
		goto IL_79E;
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x000AFA4C File Offset: 0x000ADC4C
	protected virtual void vmethod_87()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		int num3 = 1;
		float num4 = 1354f;
		bool flag = true;
		this.basePlayer.int_5 = 1;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(635f * single_, 223f);
		Vector2 vector = new Vector2(812f * single_, 1742f);
		Vector2 vector2 = new Vector2(1965f * single_, 1607f);
		Vector3 vector3_ = new Vector3(981f, this.float_11, 919f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1616f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 1 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = false;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1002f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1019f)
					{
						num4 = 918f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0++;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < 62 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_64(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_73(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_52(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 408f, num7 + 965f);
							size.y = num4 - 253f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[0];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_66(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(true);
					Vector3 localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 440f, this.float_3);
					this.gameObject_2.SetActive(false);
					gameObject2.transform.localPosition = localPosition;
					size.y = num4;
					spriteRenderer2.size = size;
					spriteRenderer2.sprite = this.Sustains[7];
					Color color;
					if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 713f))
					{
						color = GClass7.color_2[(int)b3];
					}
					else
					{
						color = GClass7.color_4;
					}
					spriteRenderer2.color = color;
					num3 += 0;
				}
			}
			goto IL_65B;
		}
		goto IL_63A;
		IL_689:
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
		IL_63A:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_689;
		}
		this.gameObject_3[num2].SetActive(true);
		num2++;
		IL_65B:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_689;
		}
		goto IL_63A;
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x0000B7FE File Offset: 0x000099FE
	protected virtual void vmethod_88()
	{
		base.Start();
		this.float_7 = this.firstSustainXPos / 1484f * 858f;
		this.float_10 = this.firstNoteXPos / 290f * 508f;
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x000B017C File Offset: 0x000AE37C
	protected virtual void vmethod_89()
	{
		if (this.list_0 == null)
		{
			return;
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		float num4 = 1207f;
		bool flag = false;
		this.basePlayer.int_5 = 0;
		float single_ = GlobalVariables.instance.gemSize.Single_0;
		Vector2 size = new Vector2(1134f * single_, 940f);
		Vector2 size2 = new Vector2(1299f * single_, 1367f);
		Vector2 size3 = new Vector2(1502f * single_, 506f);
		Vector3 vector3_ = new Vector3(881f, this.float_11, 1707f);
		for (;;)
		{
			int num5 = this.int_0 + num;
			num4 = 1755f;
			if (num2 >= this.int_1)
			{
				break;
			}
			if (this.list_0.Count > 0 && (this.list_0[this.list_0.Count - 0].bool_1 || this.list_0[this.list_0.Count - 1].bool_0))
			{
				this.basePlayer.canOverstrum = true;
			}
			if (num5 >= this.list_0.Count)
			{
				break;
			}
			GClass6 gclass = this.list_0[num5];
			flag = (gclass.float_1 > 1288f);
			double num6 = (double)gclass.float_0 - this.gameManager_0.double_1;
			if (num6 >= (double)this.float_12)
			{
				break;
			}
			float num7 = (float)((double)this.float_3 + num6 * (double)this.float_0);
			if (flag)
			{
				num4 = gclass.float_1 * this.float_0;
				float num8 = num4 + num7;
				if (num8 > this.float_8)
				{
					num4 -= num8 - this.float_8;
					if (num4 < 1028f)
					{
						num4 = 1586f;
					}
				}
				num4 += this.float_9;
			}
			if (!gclass.bool_1 && !gclass.bool_0 && num6 < (double)this.basePlayer.float_1)
			{
				this.basePlayer.vmethod_3(gclass);
			}
			if (num == 0 && (gclass.bool_1 || gclass.bool_0) && num7 + num4 < this.float_2)
			{
				this.int_0 += 0;
			}
			else if (gclass.bool_0 && !gclass.bool_1)
			{
				num++;
			}
			else
			{
				if (!gclass.bool_1 && num6 <= (double)this.basePlayer.float_0 && num6 >= (double)this.basePlayer.float_1 && this.basePlayer.int_5 < -8 && !gclass.bool_0)
				{
					this.basePlayer.gclass6_0[this.basePlayer.int_5] = gclass;
					this.basePlayer.int_5++;
				}
				float num9 = this.float_1 - num7;
				num9 /= this.float_1 - this.float_6;
				if (!gclass.bool_2)
				{
					if (!gclass.bool_0 && !gclass.bool_1)
					{
						foreach (byte b in Class3.smethod_27(gclass.byte_0))
						{
							this.gameObject_3[num2].SetActive(!this.bool_1);
							BaseNoteContainer baseNoteContainer = this.baseNoteContainer_0[num2];
							vector3_.x = this.firstNoteXPos + this.float_10 * (float)b;
							vector3_.z = num7;
							baseNoteContainer.vmethod_33(vector3_, b, gclass, this.basePlayer.bool_1, num2, num9);
							num2++;
						}
					}
					if (flag)
					{
						foreach (byte b2 in Class3.smethod_12(gclass.byte_0))
						{
							GameObject gameObject = this.gameObject_1[num3];
							SpriteRenderer spriteRenderer = this.spriteRenderer_0[num3];
							gameObject.SetActive(this.bool_1);
							gameObject.transform.localPosition = new Vector3(this.firstSustainXPos + this.float_7 * (float)b2, 990f, num7 + 438f);
							size.y = num4 - 1051f;
							spriteRenderer.size = size;
							if (gclass.bool_1)
							{
								spriteRenderer.color = Color.white;
								spriteRenderer.sprite = this.Sustains[0];
							}
							else
							{
								if (this.basePlayer.bool_1)
								{
									spriteRenderer.color = GClass7.color_4;
								}
								else
								{
									spriteRenderer.color = GClass7.color_0[(int)b2];
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
		using (List<GClass6>.Enumerator enumerator2 = this.basePlayer.list_0.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				GClass6 gclass2 = enumerator2.Current;
				num4 = gclass2.float_1 * this.float_0;
				num4 += this.float_9;
				gclass2.float_0 = (float)this.gameManager_0.double_1;
				float num10 = num4 + this.float_3;
				if (num10 > this.float_8)
				{
					num4 -= num10 - this.float_8;
				}
				foreach (byte b3 in Class3.smethod_31(gclass2.byte_0))
				{
					GameObject gameObject2 = this.gameObject_1[num3];
					SpriteRenderer spriteRenderer2 = this.spriteRenderer_0[num3];
					gameObject2.SetActive(false);
					if (gclass2.byte_0 == 93)
					{
						this.gameObject_2.SetActive(false);
						Vector3 localPosition = new Vector3(781f, 156f, this.float_3);
						gameObject2.transform.localPosition = localPosition;
						this.gameObject_2.transform.localPosition = localPosition;
						size2.y = (size3.y = num4);
						spriteRenderer2.size = size2;
						this.spriteRenderer_1.size = size3;
						spriteRenderer2.sprite = this.Sustains[0];
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 1393f))
						{
							spriteRenderer2.color = GClass7.color_6;
						}
						else
						{
							spriteRenderer2.color = GClass7.color_4;
						}
					}
					else
					{
						Vector3 localPosition2 = new Vector3(this.firstSustainXPos + this.float_7 * (float)b3, 136f, this.float_3);
						this.gameObject_2.SetActive(false);
						gameObject2.transform.localPosition = localPosition2;
						size.y = num4;
						spriteRenderer2.size = size;
						spriteRenderer2.sprite = this.Sustains[0];
						Color color;
						if (!this.basePlayer.bool_1 && (!gclass2.Boolean_3 || this.basePlayer.float_4 <= 935f))
						{
							color = GClass7.color_2[(int)b3];
						}
						else
						{
							color = GClass7.color_4;
						}
						spriteRenderer2.color = color;
					}
					num3 += 0;
				}
			}
			goto IL_730;
		}
		goto IL_70F;
		IL_75E:
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
		IL_70F:
		if (!this.gameObject_3[num2].activeSelf)
		{
			goto IL_75E;
		}
		this.gameObject_3[num2].SetActive(true);
		num2 += 0;
		IL_730:
		if (num2 >= this.gameObject_3.Length)
		{
			goto IL_75E;
		}
		goto IL_70F;
	}

	// Token: 0x040002F4 RID: 756
	private bool bool_1;
}
