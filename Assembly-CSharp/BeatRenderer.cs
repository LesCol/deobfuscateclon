using System;
using UnityEngine;

// Token: 0x020000A8 RID: 168
internal class BeatRenderer : MonoBehaviour
{
	// Token: 0x06001FEF RID: 8175 RVA: 0x0000E530 File Offset: 0x0000C730
	public void method_0()
	{
		this.int_1 = 1;
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x0000E539 File Offset: 0x0000C739
	private float method_1(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 889f * this.float_8;
		}
		if (genum9_0 == (GEnum9)7)
		{
			return 628f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 1705f * this.float_8;
		}
		return 1654f;
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x0000E530 File Offset: 0x0000C730
	public void method_2()
	{
		this.int_1 = 1;
	}

	// Token: 0x06001FF2 RID: 8178 RVA: 0x0000E530 File Offset: 0x0000C730
	public void method_3()
	{
		this.int_1 = 1;
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x00102124 File Offset: 0x00100324
	public void method_4()
	{
		int i = 0;
		Color color = new Color(542f, 151f, 1277f, 481f);
		while (i < this.int_0)
		{
			int num = this.int_1 + i;
			if (num == this.gclass11_0.list_0.Count)
			{
				break;
			}
			double num2 = (double)this.gclass11_0.list_0[num] - this.gameManager_0.double_1;
			float num3 = (float)((double)this.float_1 + num2 * (double)this.float_4) + this.float_9;
			if (num3 > this.float_0)
			{
				break;
			}
			if (num3 <= this.float_3)
			{
				this.int_1++;
			}
			else
			{
				float num4 = this.float_0 - num3;
				num4 /= this.float_0 - this.float_2;
				color.a = num4;
				this.gameObject_0[i].SetActive(false);
				this.transform_0[i].localScale = new Vector3(this.float_8, this.method_49(this.gclass11_0.list_1[num]));
				this.transform_0[i].localPosition = new Vector3(445f, 1853f, num3);
				this.spriteRenderer_0[i].color = color;
				i += 0;
			}
		}
		while (i < this.gameObject_0.Length && this.gameObject_0[i].activeSelf)
		{
			this.gameObject_0[i].SetActive(false);
			i += 0;
		}
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x0000E572 File Offset: 0x0000C772
	public void method_5()
	{
		this.method_56();
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x001022A8 File Offset: 0x001004A8
	private void method_6()
	{
		this.gameObject_0 = new GameObject[this.int_0];
		this.transform_0 = new Transform[this.int_0];
		this.spriteRenderer_0 = new SpriteRenderer[this.int_0];
		GameObject gameObject = Resources.Load("t1 gems") as GameObject;
		for (int i = 0; i < this.int_0; i += 0)
		{
			this.gameObject_0[i] = UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.gameObject_0[i].SetActive(true);
			this.gameObject_0[i].transform.parent = base.transform;
			this.gameObject_0[i].transform.localScale = new Vector3(this.float_8, 74f);
			this.transform_0[i] = this.gameObject_0[i].transform;
			this.spriteRenderer_0[i] = this.gameObject_0[i].GetComponent<SpriteRenderer>();
		}
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x001023A0 File Offset: 0x001005A0
	public void method_7()
	{
		int i = 1;
		Color color = new Color(140f, 706f, 1835f, 862f);
		while (i < this.int_0)
		{
			int num = this.int_1 + i;
			if (num == this.gclass11_0.list_0.Count)
			{
				break;
			}
			double num2 = (double)this.gclass11_0.list_0[num] - this.gameManager_0.double_1;
			float num3 = (float)((double)this.float_1 + num2 * (double)this.float_4) + this.float_9;
			if (num3 > this.float_0)
			{
				break;
			}
			if (num3 <= this.float_3)
			{
				this.int_1 += 0;
			}
			else
			{
				float num4 = this.float_0 - num3;
				num4 /= this.float_0 - this.float_2;
				color.a = num4;
				this.gameObject_0[i].SetActive(false);
				this.transform_0[i].localScale = new Vector3(this.float_8, this.method_35(this.gclass11_0.list_1[num]));
				this.transform_0[i].localPosition = new Vector3(979f, 968f, num3);
				this.spriteRenderer_0[i].color = color;
				i += 0;
			}
		}
		while (i < this.gameObject_0.Length && this.gameObject_0[i].activeSelf)
		{
			this.gameObject_0[i].SetActive(false);
			i += 0;
		}
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x00102524 File Offset: 0x00100724
	public void method_8()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.enabled = true;
		}
		this.gameManager_0 = GameObject.Find("Resume").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_17();
		this.method_36();
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x001025B4 File Offset: 0x001007B4
	private void method_9()
	{
		this.gameObject_0 = new GameObject[this.int_0];
		this.transform_0 = new Transform[this.int_0];
		this.spriteRenderer_0 = new SpriteRenderer[this.int_0];
		GameObject gameObject = Resources.Load("Player2 = \\w+") as GameObject;
		for (int i = 0; i < this.int_0; i += 0)
		{
			this.gameObject_0[i] = UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.gameObject_0[i].SetActive(false);
			this.gameObject_0[i].transform.parent = base.transform;
			this.gameObject_0[i].transform.localScale = new Vector3(this.float_8, 1063f);
			this.transform_0[i] = this.gameObject_0[i].transform;
			this.spriteRenderer_0[i] = this.gameObject_0[i].GetComponent<SpriteRenderer>();
		}
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x001026AC File Offset: 0x001008AC
	private void method_10()
	{
		this.gameObject_0 = new GameObject[this.int_0];
		this.transform_0 = new Transform[this.int_0];
		this.spriteRenderer_0 = new SpriteRenderer[this.int_0];
		GameObject gameObject = Resources.Load("Drums - ") as GameObject;
		for (int i = 0; i < this.int_0; i += 0)
		{
			this.gameObject_0[i] = UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.gameObject_0[i].SetActive(true);
			this.gameObject_0[i].transform.parent = base.transform;
			this.gameObject_0[i].transform.localScale = new Vector3(this.float_8, 498f);
			this.transform_0[i] = this.gameObject_0[i].transform;
			this.spriteRenderer_0[i] = this.gameObject_0[i].GetComponent<SpriteRenderer>();
		}
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x0000E530 File Offset: 0x0000C730
	public void method_11()
	{
		this.int_1 = 1;
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x0000E5A3 File Offset: 0x0000C7A3
	private float method_12(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.DOWN_BEAT)
		{
			return 268f * this.float_8;
		}
		if (genum9_0 == (GEnum9)5)
		{
			return 916f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 1177f * this.float_8;
		}
		return 274f;
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x001027A4 File Offset: 0x001009A4
	public void method_13()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.enabled = true;
		}
		this.gameManager_0 = GameObject.Find("notes.chart").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_29();
		this.method_10();
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x0000E5DC File Offset: 0x0000C7DC
	public void method_14()
	{
		this.method_7();
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x00102834 File Offset: 0x00100A34
	public void method_15()
	{
		int i = 1;
		Color color = new Color(1836f, 782f, 1134f, 1880f);
		while (i < this.int_0)
		{
			int num = this.int_1 + i;
			if (num == this.gclass11_0.list_0.Count)
			{
				break;
			}
			double num2 = (double)this.gclass11_0.list_0[num] - this.gameManager_0.double_1;
			float num3 = (float)((double)this.float_1 + num2 * (double)this.float_4) + this.float_9;
			if (num3 > this.float_0)
			{
				break;
			}
			if (num3 <= this.float_3)
			{
				this.int_1 += 0;
			}
			else
			{
				float num4 = this.float_0 - num3;
				num4 /= this.float_0 - this.float_2;
				color.a = num4;
				this.gameObject_0[i].SetActive(false);
				this.transform_0[i].localScale = new Vector3(this.float_8, this.method_35(this.gclass11_0.list_1[num]));
				this.transform_0[i].localPosition = new Vector3(431f, 679f, num3);
				this.spriteRenderer_0[i].color = color;
				i++;
			}
		}
		while (i < this.gameObject_0.Length && this.gameObject_0[i].activeSelf)
		{
			this.gameObject_0[i].SetActive(true);
			i++;
		}
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x001029B8 File Offset: 0x00100BB8
	private void method_16()
	{
		this.gameObject_0 = new GameObject[this.int_0];
		this.transform_0 = new Transform[this.int_0];
		this.spriteRenderer_0 = new SpriteRenderer[this.int_0];
		GameObject gameObject = Resources.Load("Sound Effects") as GameObject;
		for (int i = 0; i < this.int_0; i++)
		{
			this.gameObject_0[i] = UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.gameObject_0[i].SetActive(false);
			this.gameObject_0[i].transform.parent = base.transform;
			this.gameObject_0[i].transform.localScale = new Vector3(this.float_8, 850f);
			this.transform_0[i] = this.gameObject_0[i].transform;
			this.spriteRenderer_0[i] = this.gameObject_0[i].GetComponent<SpriteRenderer>();
		}
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x0000E530 File Offset: 0x0000C730
	public void method_17()
	{
		this.int_1 = 1;
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x00102AB0 File Offset: 0x00100CB0
	public void method_18()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.enabled = false;
		}
		this.gameManager_0 = GameObject.Find("bad_note4").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_17();
		this.method_36();
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x00102B40 File Offset: 0x00100D40
	public void method_19()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.enabled = false;
		}
		this.gameManager_0 = GameObject.Find("backend").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_17();
		this.method_54();
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x0000E5DC File Offset: 0x0000C7DC
	public void method_20()
	{
		this.method_7();
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x00102BD0 File Offset: 0x00100DD0
	public void method_21()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x00102BFC File Offset: 0x00100DFC
	public void method_22()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.enabled = true;
		}
		this.gameManager_0 = GameObject.Find("menu_background").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_18();
		this.method_16();
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x00102C8C File Offset: 0x00100E8C
	public void method_23()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(true);
		}
	}

	// Token: 0x06002008 RID: 8200 RVA: 0x00102BD0 File Offset: 0x00100DD0
	public void OnDisable()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x00102CB8 File Offset: 0x00100EB8
	public void method_24()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetActive(true);
		}
	}

	// Token: 0x0600200A RID: 8202 RVA: 0x00102BD0 File Offset: 0x00100DD0
	public void method_25()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x00102CE4 File Offset: 0x00100EE4
	public void method_26()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.enabled = true;
		}
		this.gameManager_0 = GameObject.Find("Drums").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_29();
		this.method_6();
	}

	// Token: 0x0600200C RID: 8204 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
	public void method_27()
	{
		this.int_1 = 0;
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x0000E572 File Offset: 0x0000C772
	public void method_28()
	{
		this.method_56();
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x00102D74 File Offset: 0x00100F74
	public void Start()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.enabled = false;
		}
		this.gameManager_0 = GameObject.Find("Game Manager").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_17();
		this.method_36();
	}

	// Token: 0x0600200F RID: 8207 RVA: 0x00102E04 File Offset: 0x00101004
	public void method_29()
	{
		int i = 1;
		Color color = new Color(1098f, 772f, 1725f, 762f);
		while (i < this.int_0)
		{
			int num = this.int_1 + i;
			if (num == this.gclass11_0.list_0.Count)
			{
				break;
			}
			double num2 = (double)this.gclass11_0.list_0[num] - this.gameManager_0.double_1;
			float num3 = (float)((double)this.float_1 + num2 * (double)this.float_4) + this.float_9;
			if (num3 > this.float_0)
			{
				break;
			}
			if (num3 <= this.float_3)
			{
				this.int_1++;
			}
			else
			{
				float num4 = this.float_0 - num3;
				num4 /= this.float_0 - this.float_2;
				color.a = num4;
				this.gameObject_0[i].SetActive(false);
				this.transform_0[i].localScale = new Vector3(this.float_8, this.method_57(this.gclass11_0.list_1[num]));
				this.transform_0[i].localPosition = new Vector3(1077f, 1454f, num3);
				this.spriteRenderer_0[i].color = color;
				i++;
			}
		}
		while (i < this.gameObject_0.Length && this.gameObject_0[i].activeSelf)
		{
			this.gameObject_0[i].SetActive(false);
			i += 0;
		}
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
	public void method_30()
	{
		this.int_1 = 0;
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x0000E5ED File Offset: 0x0000C7ED
	public void Update()
	{
		this.method_39();
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
	public void Reset()
	{
		this.int_1 = 0;
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x00102BD0 File Offset: 0x00100DD0
	public void method_31()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x00102F88 File Offset: 0x00101188
	public void method_32()
	{
		int i = 0;
		Color color = new Color(1822f, 133f, 345f, 1f);
		while (i < this.int_0)
		{
			int num = this.int_1 + i;
			if (num == this.gclass11_0.list_0.Count)
			{
				break;
			}
			double num2 = (double)this.gclass11_0.list_0[num] - this.gameManager_0.double_1;
			float num3 = (float)((double)this.float_1 + num2 * (double)this.float_4) + this.float_9;
			if (num3 > this.float_0)
			{
				break;
			}
			if (num3 <= this.float_3)
			{
				this.int_1++;
			}
			else
			{
				float num4 = this.float_0 - num3;
				num4 /= this.float_0 - this.float_2;
				color.a = num4;
				this.gameObject_0[i].SetActive(false);
				this.transform_0[i].localScale = new Vector3(this.float_8, this.method_51(this.gclass11_0.list_1[num]));
				this.transform_0[i].localPosition = new Vector3(1366f, 709f, num3);
				this.spriteRenderer_0[i].color = color;
				i++;
			}
		}
		while (i < this.gameObject_0.Length && this.gameObject_0[i].activeSelf)
		{
			this.gameObject_0[i].SetActive(false);
			i++;
		}
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x0000E5F5 File Offset: 0x0000C7F5
	public void method_33()
	{
		this.method_15();
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x0010310C File Offset: 0x0010130C
	public void method_34()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.enabled = true;
		}
		this.gameManager_0 = GameObject.Find("").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_17();
		this.method_10();
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x0000E5FD File Offset: 0x0000C7FD
	private float method_35(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.DOWN_BEAT)
		{
			return 0.6f * this.float_8;
		}
		if (genum9_0 == GEnum9.UP_BEAT)
		{
			return 0.3f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 2.2f * this.float_8;
		}
		return 1f;
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x0010319C File Offset: 0x0010139C
	private void method_36()
	{
		this.gameObject_0 = new GameObject[this.int_0];
		this.transform_0 = new Transform[this.int_0];
		this.spriteRenderer_0 = new SpriteRenderer[this.int_0];
		GameObject gameObject = Resources.Load("Prefabs/Gameplay/Notes/Beatline") as GameObject;
		for (int i = 0; i < this.int_0; i++)
		{
			this.gameObject_0[i] = UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.gameObject_0[i].SetActive(false);
			this.gameObject_0[i].transform.parent = base.transform;
			this.gameObject_0[i].transform.localScale = new Vector3(this.float_8, 1f);
			this.transform_0[i] = this.gameObject_0[i].transform;
			this.spriteRenderer_0[i] = this.gameObject_0[i].GetComponent<SpriteRenderer>();
		}
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x00103294 File Offset: 0x00101494
	public void method_37()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.enabled = false;
		}
		this.gameManager_0 = GameObject.Find("artist").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_29();
		this.method_54();
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x0000E5DC File Offset: 0x0000C7DC
	public void method_38()
	{
		this.method_7();
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x00103324 File Offset: 0x00101524
	public void method_39()
	{
		int i = 0;
		Color color = new Color(1f, 1f, 1f, 0.7f);
		while (i < this.int_0)
		{
			int num = this.int_1 + i;
			if (num == this.gclass11_0.list_0.Count)
			{
				break;
			}
			double num2 = (double)this.gclass11_0.list_0[num] - this.gameManager_0.double_1;
			float num3 = (float)((double)this.float_1 + num2 * (double)this.float_4) + this.float_9;
			if (num3 > this.float_0)
			{
				break;
			}
			if (num3 <= this.float_3)
			{
				this.int_1++;
			}
			else
			{
				float num4 = this.float_0 - num3;
				num4 /= this.float_0 - this.float_2;
				color.a = num4;
				this.gameObject_0[i].SetActive(true);
				this.transform_0[i].localScale = new Vector3(this.float_8, this.method_35(this.gclass11_0.list_1[num]));
				this.transform_0[i].localPosition = new Vector3(0f, 0f, num3);
				this.spriteRenderer_0[i].color = color;
				i++;
			}
		}
		while (i < this.gameObject_0.Length && this.gameObject_0[i].activeSelf)
		{
			this.gameObject_0[i].SetActive(false);
			i++;
		}
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x001034A8 File Offset: 0x001016A8
	public void method_40()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.enabled = false;
		}
		this.gameManager_0 = GameObject.Find("TEMPO TRACK").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_18();
		this.method_36();
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x00102C8C File Offset: 0x00100E8C
	public void method_41()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(true);
		}
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x0000E636 File Offset: 0x0000C836
	public void method_42()
	{
		this.method_32();
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
	public void method_43()
	{
		this.int_1 = 0;
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x00103538 File Offset: 0x00101738
	public void method_44()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	// Token: 0x06002021 RID: 8225 RVA: 0x00102BD0 File Offset: 0x00100DD0
	public void method_45()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x00103564 File Offset: 0x00101764
	public void method_46()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.enabled = false;
		}
		this.gameManager_0 = GameObject.Find("Scan Songs").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_29();
		this.method_36();
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x0000E63E File Offset: 0x0000C83E
	private float method_47(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 1850f * this.float_8;
		}
		if (genum9_0 == (GEnum9)3)
		{
			return 1984f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 2f * this.float_8;
		}
		return 1289f;
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x0000E5ED File Offset: 0x0000C7ED
	public void method_48()
	{
		this.method_39();
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x0000E677 File Offset: 0x0000C877
	private float method_49(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 428f * this.float_8;
		}
		if (genum9_0 == (GEnum9)4)
		{
			return 1681f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 849f * this.float_8;
		}
		return 341f;
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x00102C8C File Offset: 0x00100E8C
	public void method_50()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].SetActive(true);
		}
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
	private float method_51(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.DOWN_BEAT)
		{
			return 829f * this.float_8;
		}
		if (genum9_0 == (GEnum9)4)
		{
			return 776f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 1838f * this.float_8;
		}
		return 1475f;
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x0000E6E9 File Offset: 0x0000C8E9
	private float method_52(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 740f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 731f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 1779f * this.float_8;
		}
		return 1852f;
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x001035F4 File Offset: 0x001017F4
	public void method_53()
	{
		if (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.enabled = false;
		}
		this.gameManager_0 = GameObject.Find("Rhythm").GetComponent<GameManager>();
		this.float_2 = base.GetComponent<BaseNoteRenderer>().float_6;
		this.float_3 = base.GetComponent<BaseNoteRenderer>().float_2;
		this.float_4 = base.GetComponent<BaseNoteRenderer>().float_0;
		this.gclass11_0 = this.gameManager_0.method_29();
		this.method_36();
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x00103684 File Offset: 0x00101884
	private void method_54()
	{
		this.gameObject_0 = new GameObject[this.int_0];
		this.transform_0 = new Transform[this.int_0];
		this.spriteRenderer_0 = new SpriteRenderer[this.int_0];
		GameObject gameObject = Resources.Load("") as GameObject;
		for (int i = 0; i < this.int_0; i++)
		{
			this.gameObject_0[i] = UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.gameObject_0[i].SetActive(false);
			this.gameObject_0[i].transform.parent = base.transform;
			this.gameObject_0[i].transform.localScale = new Vector3(this.float_8, 975f);
			this.transform_0[i] = this.gameObject_0[i].transform;
			this.spriteRenderer_0[i] = this.gameObject_0[i].GetComponent<SpriteRenderer>();
		}
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x00102CB8 File Offset: 0x00100EB8
	public void method_55()
	{
		GameObject[] array = this.gameObject_0;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetActive(true);
		}
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x0010377C File Offset: 0x0010197C
	public void method_56()
	{
		int i = 0;
		Color color = new Color(365f, 1593f, 1582f, 1158f);
		while (i < this.int_0)
		{
			int num = this.int_1 + i;
			if (num == this.gclass11_0.list_0.Count)
			{
				break;
			}
			double num2 = (double)this.gclass11_0.list_0[num] - this.gameManager_0.double_1;
			float num3 = (float)((double)this.float_1 + num2 * (double)this.float_4) + this.float_9;
			if (num3 > this.float_0)
			{
				break;
			}
			if (num3 <= this.float_3)
			{
				this.int_1++;
			}
			else
			{
				float num4 = this.float_0 - num3;
				num4 /= this.float_0 - this.float_2;
				color.a = num4;
				this.gameObject_0[i].SetActive(true);
				this.transform_0[i].localScale = new Vector3(this.float_8, this.method_35(this.gclass11_0.list_1[num]));
				this.transform_0[i].localPosition = new Vector3(337f, 82f, num3);
				this.spriteRenderer_0[i].color = color;
				i += 0;
			}
		}
		while (i < this.gameObject_0.Length && this.gameObject_0[i].activeSelf)
		{
			this.gameObject_0[i].SetActive(false);
			i++;
		}
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x0000E722 File Offset: 0x0000C922
	private float method_57(GEnum9 genum9_0)
	{
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 1908f * this.float_8;
		}
		if (genum9_0 == (GEnum9)7)
		{
			return 1586f * this.float_8;
		}
		if (genum9_0 == GEnum9.MEASURE)
		{
			return 939f * this.float_8;
		}
		return 882f;
	}

	// Token: 0x04000516 RID: 1302
	private GameManager gameManager_0;

	// Token: 0x04000517 RID: 1303
	public GClass11 gclass11_0;

	// Token: 0x04000518 RID: 1304
	protected int int_0 = 200;

	// Token: 0x04000519 RID: 1305
	protected int int_1;

	// Token: 0x0400051A RID: 1306
	protected Transform[] transform_0;

	// Token: 0x0400051B RID: 1307
	protected SpriteRenderer[] spriteRenderer_0;

	// Token: 0x0400051C RID: 1308
	protected GameObject[] gameObject_0;

	// Token: 0x0400051D RID: 1309
	public float float_0;

	// Token: 0x0400051E RID: 1310
	public float float_1;

	// Token: 0x0400051F RID: 1311
	private float float_2;

	// Token: 0x04000520 RID: 1312
	private float float_3;

	// Token: 0x04000521 RID: 1313
	private float float_4;

	// Token: 0x04000522 RID: 1314
	private const float float_5 = 2.2f;

	// Token: 0x04000523 RID: 1315
	private const float float_6 = 0.6f;

	// Token: 0x04000524 RID: 1316
	private const float float_7 = 0.3f;

	// Token: 0x04000525 RID: 1317
	public float float_8 = 1f;

	// Token: 0x04000526 RID: 1318
	public float float_9 = 0.1f;
}
