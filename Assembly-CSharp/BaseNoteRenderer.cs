using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000067 RID: 103
[RequireComponent(typeof(BasePlayer))]
public abstract class BaseNoteRenderer : MonoBehaviour
{
	// Token: 0x06001498 RID: 5272 RVA: 0x0008E848 File Offset: 0x0008CA48
	protected virtual void Start()
	{
		this.gameManager_0 = GameObject.Find("Game Manager").GetComponent<GameManager>();
		this.float_0 = (float)this.basePlayer.player.gclass10_0.gclass5_0.CurrentValue;
		if (!GlobalVariables.instance.isPracticeEnabled)
		{
			this.list_0 = this.gameManager_0.method_39(this.basePlayer.player, true);
			this.list_1 = this.gameManager_0.method_71(this.basePlayer.player);
		}
		this.vmethod_1();
		if (this.basePlayer.player.gclass10_0.gclass5_2.Boolean_1)
		{
			this.vmethod_0();
		}
		this.float_12 = (this.float_1 - this.float_3) / this.float_0;
		this.bool_0 = (base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2 && !base.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_21(GClass6.GEnum6.ModPrep));
		this.float_9 = this.Sustains[0].border[3] / 2f / this.Sustains[0].rect.height;
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x0008E994 File Offset: 0x0008CB94
	protected virtual void vmethod_0()
	{
		this.firstNoteXPos *= -1f;
		this.firstSustainXPos *= -1f;
		this.float_10 *= -1f;
		this.float_7 *= -1f;
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x0008E9EC File Offset: 0x0008CBEC
	protected virtual void vmethod_1()
	{
		this.gameObject_3 = new GameObject[this.int_1];
		this.float_11 = this.gameObject_0.transform.position.y;
		float x = GlobalVariables.instance.gemSize.Single_0 * this.float_4;
		float num = GlobalVariables.instance.gemSize.Single_0 * this.float_5;
		Vector2 v = new Vector2(x, num);
		this.baseNoteContainer_0 = new BaseNoteContainer[this.int_1];
		for (int i = 0; i < this.int_1; i++)
		{
			this.gameObject_3[i] = UnityEngine.Object.Instantiate<GameObject>(this.gameObject_0, Vector3.zero, this.gameObject_0.transform.rotation);
			this.gameObject_3[i].SetActive(false);
			this.gameObject_3[i].transform.parent = base.transform;
			this.gameObject_3[i].transform.localScale = v;
			this.baseNoteContainer_0[i] = this.gameObject_3[i].GetComponent<BaseNoteContainer>();
			if (BaseMenu.bool_9 && UnityEngine.Random.Range(0, 2) == 1)
			{
				this.gameObject_3[i].transform.localScale = new Vector2(x, -num);
			}
		}
		this.gameObject_1 = new GameObject[this.int_2];
		GameObject gameObject = Resources.Load("Prefabs/Gameplay/Notes/Sustain") as GameObject;
		this.spriteRenderer_0 = new SpriteRenderer[this.int_2];
		this.gameObject_2 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load("Prefabs/Gameplay/Notes/open_sustain_glow") as GameObject, Vector3.zero, gameObject.transform.rotation);
		this.gameObject_2.SetActive(false);
		this.gameObject_2.transform.parent = base.transform;
		this.spriteRenderer_1 = this.gameObject_2.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1.sortingOrder = -1001;
		for (int j = 0; j < this.gameObject_1.Length; j++)
		{
			this.gameObject_1[j] = UnityEngine.Object.Instantiate<GameObject>(gameObject, Vector3.zero, gameObject.transform.rotation);
			this.gameObject_1[j].SetActive(false);
			this.gameObject_1[j].transform.parent = base.transform;
			this.spriteRenderer_0[j] = this.gameObject_1[j].GetComponent<SpriteRenderer>();
			this.spriteRenderer_0[j].sortingOrder = -1000;
		}
		this.basePlayer.list_0 = new List<GClass6>(5);
		this.basePlayer.list_1 = new List<GClass6>(5);
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x0008EC88 File Offset: 0x0008CE88
	public void method_0()
	{
		for (int i = this.int_0; i < this.list_0.Count; i++)
		{
			GClass6 gclass = this.list_0[i];
			if (gclass.Boolean_4)
			{
				while (gclass != null)
				{
					gclass.genum3_0 &= ~GClass6.GEnum3.STAR_POWER;
					gclass.genum3_0 &= ~GClass6.GEnum3.STAR_POWER_END;
					gclass = gclass.gclass6_1;
				}
				return;
			}
			if (gclass.Boolean_3)
			{
				gclass.genum3_0 &= ~GClass6.GEnum3.STAR_POWER;
			}
		}
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x0000AE3C File Offset: 0x0000903C
	public virtual void Reset()
	{
		this.int_0 = 0;
		this.basePlayer.method_12();
	}

	// Token: 0x0600149D RID: 5277
	protected abstract void Update();

	// Token: 0x040002CE RID: 718
	[SerializeField]
	protected BasePlayer basePlayer;

	// Token: 0x040002CF RID: 719
	protected GameManager gameManager_0;

	// Token: 0x040002D0 RID: 720
	public List<GClass6> list_0;

	// Token: 0x040002D1 RID: 721
	protected int int_0;

	// Token: 0x040002D2 RID: 722
	[HideInInspector]
	public float float_0;

	// Token: 0x040002D3 RID: 723
	public float float_1;

	// Token: 0x040002D4 RID: 724
	public float float_2;

	// Token: 0x040002D5 RID: 725
	public float float_3;

	// Token: 0x040002D6 RID: 726
	public float float_4;

	// Token: 0x040002D7 RID: 727
	public float float_5;

	// Token: 0x040002D8 RID: 728
	public float float_6;

	// Token: 0x040002D9 RID: 729
	[SerializeField]
	protected float firstSustainXPos;

	// Token: 0x040002DA RID: 730
	protected float float_7;

	// Token: 0x040002DB RID: 731
	public float float_8;

	// Token: 0x040002DC RID: 732
	protected bool bool_0;

	// Token: 0x040002DD RID: 733
	public List<GClass8> list_1;

	// Token: 0x040002DE RID: 734
	protected int int_1 = 500;

	// Token: 0x040002DF RID: 735
	protected int int_2 = 250;

	// Token: 0x040002E0 RID: 736
	public GameObject gameObject_0;

	// Token: 0x040002E1 RID: 737
	protected GameObject[] gameObject_1;

	// Token: 0x040002E2 RID: 738
	protected GameObject gameObject_2;

	// Token: 0x040002E3 RID: 739
	protected GameObject[] gameObject_3;

	// Token: 0x040002E4 RID: 740
	protected SpriteRenderer[] spriteRenderer_0;

	// Token: 0x040002E5 RID: 741
	protected SpriteRenderer spriteRenderer_1;

	// Token: 0x040002E6 RID: 742
	protected BaseNoteContainer[] baseNoteContainer_0;

	// Token: 0x040002E7 RID: 743
	[SerializeField]
	protected Sprite[] Sustains;

	// Token: 0x040002E8 RID: 744
	protected float float_9;

	// Token: 0x040002E9 RID: 745
	[Header("Note Positions")]
	[SerializeField]
	protected float firstNoteXPos;

	// Token: 0x040002EA RID: 746
	protected float float_10;

	// Token: 0x040002EB RID: 747
	protected float float_11;

	// Token: 0x040002EC RID: 748
	protected float float_12;
}
