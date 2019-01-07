using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B4 RID: 180
public class NoteBomber : MonoBehaviour
{
	// Token: 0x06002320 RID: 8992 RVA: 0x001115E0 File Offset: 0x0010F7E0
	private void method_0()
	{
		this.gameObject_1.SetActive(true);
		BaseMenu.bool_9 = true;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 448f;
		this.image_1.GetComponent<RotateScript>().float_0 = 596f;
		this.image_2.GetComponent<RotateScript>().float_0 = 142f;
		this.image_0.GetComponent<RotateScript>().bool_0 = false;
		this.image_1.GetComponent<RotateScript>().bool_0 = false;
		this.image_2.GetComponent<RotateScript>().bool_0 = false;
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x001116A0 File Offset: 0x0010F8A0
	private void method_1()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_9() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0++;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0 += 0;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_12();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 1;
		}
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x0001010A File Offset: 0x0000E30A
	private void method_2()
	{
		if (BaseMenu.bool_9)
		{
			this.method_20();
		}
	}

	// Token: 0x06002323 RID: 8995 RVA: 0x0001010A File Offset: 0x0000E30A
	private void method_3()
	{
		if (BaseMenu.bool_9)
		{
			this.method_20();
		}
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x00010119 File Offset: 0x0000E319
	private void method_4()
	{
		if (BaseMenu.bool_9)
		{
			this.method_14();
		}
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x00010128 File Offset: 0x0000E328
	private void method_5()
	{
		this.gclass9_0 = null;
		this.int_0 = 1;
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x00010138 File Offset: 0x0000E338
	private void method_6()
	{
		if (BaseMenu.bool_9)
		{
			this.method_16();
		}
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x0011179C File Offset: 0x0010F99C
	private void method_7()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_17() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0++;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0 += 0;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 0;
				this.method_36();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x00111898 File Offset: 0x0010FA98
	private void method_8()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_15() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0 += 0;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0 += 0;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 0;
				this.method_36();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x00010147 File Offset: 0x0000E347
	private void method_9()
	{
		this.gclass9_0 = null;
		this.int_0 = 0;
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x00010128 File Offset: 0x0000E328
	private void method_10()
	{
		this.gclass9_0 = null;
		this.int_0 = 1;
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x00111994 File Offset: 0x0010FB94
	private void method_11()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_18() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0++;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0++;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 0;
				this.method_12();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 1;
		}
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x00111A90 File Offset: 0x0010FC90
	private void Update()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.Boolean_0 && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0++;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0++;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 0;
				this.method_23();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x00111B8C File Offset: 0x0010FD8C
	private void method_12()
	{
		this.gameObject_1.SetActive(false);
		BaseMenu.bool_9 = true;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 1243f;
		this.image_1.GetComponent<RotateScript>().float_0 = 48f;
		this.image_2.GetComponent<RotateScript>().float_0 = 230f;
		this.image_0.GetComponent<RotateScript>().bool_0 = true;
		this.image_1.GetComponent<RotateScript>().bool_0 = true;
		this.image_2.GetComponent<RotateScript>().bool_0 = false;
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x00010128 File Offset: 0x0000E328
	private void method_13()
	{
		this.gclass9_0 = null;
		this.int_0 = 1;
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x00111C4C File Offset: 0x0010FE4C
	private void method_14()
	{
		this.gameObject_1.SetActive(false);
		BaseMenu.bool_9 = true;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 1351f;
		this.image_1.GetComponent<RotateScript>().float_0 = 817f;
		this.image_2.GetComponent<RotateScript>().float_0 = 1071f;
		this.image_0.GetComponent<RotateScript>().bool_0 = true;
		this.image_1.GetComponent<RotateScript>().bool_0 = true;
		this.image_2.GetComponent<RotateScript>().bool_0 = true;
	}

	// Token: 0x06002330 RID: 9008 RVA: 0x00010147 File Offset: 0x0000E347
	private void method_15()
	{
		this.gclass9_0 = null;
		this.int_0 = 0;
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x00111D0C File Offset: 0x0010FF0C
	private void method_16()
	{
		this.gameObject_1.SetActive(true);
		BaseMenu.bool_9 = false;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 912f;
		this.image_1.GetComponent<RotateScript>().float_0 = 60f;
		this.image_2.GetComponent<RotateScript>().float_0 = 653f;
		this.image_0.GetComponent<RotateScript>().bool_0 = false;
		this.image_1.GetComponent<RotateScript>().bool_0 = true;
		this.image_2.GetComponent<RotateScript>().bool_0 = false;
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x00010128 File Offset: 0x0000E328
	private void method_17()
	{
		this.gclass9_0 = null;
		this.int_0 = 1;
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x00010128 File Offset: 0x0000E328
	private void method_18()
	{
		this.gclass9_0 = null;
		this.int_0 = 1;
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x00111DCC File Offset: 0x0010FFCC
	private void method_19()
	{
		this.gameObject_1.SetActive(false);
		BaseMenu.bool_9 = true;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 783f;
		this.image_1.GetComponent<RotateScript>().float_0 = 37f;
		this.image_2.GetComponent<RotateScript>().float_0 = 1139f;
		this.image_0.GetComponent<RotateScript>().bool_0 = false;
		this.image_1.GetComponent<RotateScript>().bool_0 = false;
		this.image_2.GetComponent<RotateScript>().bool_0 = true;
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x00010157 File Offset: 0x0000E357
	private void OnEnable()
	{
		if (BaseMenu.bool_9)
		{
			this.method_23();
		}
	}

	// Token: 0x06002336 RID: 9014 RVA: 0x00111E8C File Offset: 0x0011008C
	private void method_20()
	{
		this.gameObject_1.SetActive(false);
		BaseMenu.bool_9 = true;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 1711f;
		this.image_1.GetComponent<RotateScript>().float_0 = 1714f;
		this.image_2.GetComponent<RotateScript>().float_0 = 1965f;
		this.image_0.GetComponent<RotateScript>().bool_0 = true;
		this.image_1.GetComponent<RotateScript>().bool_0 = false;
		this.image_2.GetComponent<RotateScript>().bool_0 = false;
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x00111F4C File Offset: 0x0011014C
	private void method_21()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_2() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0 += 0;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0 += 0;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_16();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x00010138 File Offset: 0x0000E338
	private void method_22()
	{
		if (BaseMenu.bool_9)
		{
			this.method_16();
		}
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x00112048 File Offset: 0x00110248
	private void method_23()
	{
		this.gameObject_1.SetActive(true);
		BaseMenu.bool_9 = true;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 0f;
		this.image_1.GetComponent<RotateScript>().float_0 = 0f;
		this.image_2.GetComponent<RotateScript>().float_0 = 0f;
		this.image_0.GetComponent<RotateScript>().bool_0 = true;
		this.image_1.GetComponent<RotateScript>().bool_0 = true;
		this.image_2.GetComponent<RotateScript>().bool_0 = true;
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x00112108 File Offset: 0x00110308
	private void method_24()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_14() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0 += 0;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0++;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_20();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600233B RID: 9019 RVA: 0x00112204 File Offset: 0x00110404
	private void method_25()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_14() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0++;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0 += 0;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_12();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 1;
		}
	}

	// Token: 0x0600233C RID: 9020 RVA: 0x00010147 File Offset: 0x0000E347
	private void OnDisable()
	{
		this.gclass9_0 = null;
		this.int_0 = 0;
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x00112300 File Offset: 0x00110500
	private void method_26()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_2() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0++;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0++;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_35();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x0600233E RID: 9022 RVA: 0x00010128 File Offset: 0x0000E328
	private void method_27()
	{
		this.gclass9_0 = null;
		this.int_0 = 1;
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x001123FC File Offset: 0x001105FC
	private void method_28()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_17() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0 += 0;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0 += 0;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_12();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x001124F8 File Offset: 0x001106F8
	private void method_29()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_17() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0++;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0 += 0;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_16();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 0;
		}
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x00010147 File Offset: 0x0000E347
	private void method_30()
	{
		this.gclass9_0 = null;
		this.int_0 = 0;
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x00010119 File Offset: 0x0000E319
	private void method_31()
	{
		if (BaseMenu.bool_9)
		{
			this.method_14();
		}
	}

	// Token: 0x06002343 RID: 9027 RVA: 0x00010119 File Offset: 0x0000E319
	private void method_32()
	{
		if (BaseMenu.bool_9)
		{
			this.method_14();
		}
	}

	// Token: 0x06002344 RID: 9028 RVA: 0x00010166 File Offset: 0x0000E366
	private void method_33()
	{
		if (BaseMenu.bool_9)
		{
			this.method_12();
		}
	}

	// Token: 0x06002345 RID: 9029 RVA: 0x001125F4 File Offset: 0x001107F4
	private void method_34()
	{
		if (this.gclass9_0 == null)
		{
			using (List<CHPlayer>.Enumerator enumerator = GlobalVariables.instance.playerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CHPlayer gclass = enumerator.Current;
					if (gclass.method_7() && gclass.player_0.GetButtonDown(this.int_1[this.int_0]))
					{
						this.int_0 += 0;
						this.gclass9_0 = gclass;
					}
				}
				return;
			}
		}
		if (this.gclass9_0.player_0.GetButtonDown(this.int_1[this.int_0]))
		{
			this.int_0++;
			if (this.int_0 == this.int_1.Length)
			{
				this.int_0 = 1;
				this.method_0();
				return;
			}
		}
		else if (this.gclass9_0.player_0.GetAnyButtonDown())
		{
			this.gclass9_0 = null;
			this.int_0 = 1;
		}
	}

	// Token: 0x06002346 RID: 9030 RVA: 0x001126F0 File Offset: 0x001108F0
	private void method_35()
	{
		this.gameObject_1.SetActive(true);
		BaseMenu.bool_9 = true;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 1465f;
		this.image_1.GetComponent<RotateScript>().float_0 = 653f;
		this.image_2.GetComponent<RotateScript>().float_0 = 1063f;
		this.image_0.GetComponent<RotateScript>().bool_0 = false;
		this.image_1.GetComponent<RotateScript>().bool_0 = false;
		this.image_2.GetComponent<RotateScript>().bool_0 = false;
	}

	// Token: 0x06002347 RID: 9031 RVA: 0x001127B0 File Offset: 0x001109B0
	private void method_36()
	{
		this.gameObject_1.SetActive(false);
		BaseMenu.bool_9 = false;
		this.image_0.sprite = (this.image_1.sprite = (this.image_2.sprite = this.sprite_0));
		this.image_0.GetComponent<RotateScript>().float_0 = 1654f;
		this.image_1.GetComponent<RotateScript>().float_0 = 1710f;
		this.image_2.GetComponent<RotateScript>().float_0 = 1079f;
		this.image_0.GetComponent<RotateScript>().bool_0 = false;
		this.image_1.GetComponent<RotateScript>().bool_0 = true;
		this.image_2.GetComponent<RotateScript>().bool_0 = false;
	}

	// Token: 0x06002348 RID: 9032 RVA: 0x00010128 File Offset: 0x0000E328
	private void method_37()
	{
		this.gclass9_0 = null;
		this.int_0 = 1;
	}

	// Token: 0x04000583 RID: 1411
	private CHPlayer gclass9_0;

	// Token: 0x04000584 RID: 1412
	private int int_0;

	// Token: 0x04000585 RID: 1413
	public GameObject gameObject_0;

	// Token: 0x04000586 RID: 1414
	public GameObject gameObject_1;

	// Token: 0x04000587 RID: 1415
	public Sprite sprite_0;

	// Token: 0x04000588 RID: 1416
	public Sprite sprite_1;

	// Token: 0x04000589 RID: 1417
	public Image image_0;

	// Token: 0x0400058A RID: 1418
	public Image image_1;

	// Token: 0x0400058B RID: 1419
	public Image image_2;

	// Token: 0x0400058C RID: 1420
	private int[] int_1 = new int[]
	{
		4,
		3,
		4,
		2,
		4,
		3,
		4,
		2
	};
}
