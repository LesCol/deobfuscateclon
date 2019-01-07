using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200007A RID: 122
public abstract class BasePlayer : MonoBehaviour
{
	// Token: 0x0600169F RID: 5791 RVA: 0x000BA7F0 File Offset: 0x000B89F0
	private void Awake()
	{
		if (GlobalVariables.instance == null)
		{
			return;
		}
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			this.spBar.gameObject.SetActive(false);
			this.healthContainer.gameObject.SetActive(false);
			this.float_8 = 0f;
		}
		else if (GlobalVariables.instance.gclass5_21.Boolean_1)
		{
			this.float_8 = 0f;
			this.healthContainer.gameObject.SetActive(false);
		}
		this.gameManager = UnityEngine.Object.FindObjectOfType<GameManager>();
		this.float_0 = this.float_3 - this.gameManager.globalVariables_0.videoOffset.Single_2;
		this.float_1 = -this.float_3 - this.gameManager.globalVariables_0.videoOffset.Single_2;
		this.gclass6_0 = new GClass6[20];
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x000BA8D0 File Offset: 0x000B8AD0
	protected virtual void Start()
	{
		this.highwayScroll_0.method_7(this.player.gclass10_0.gclass5_6.CurrentValue);
		if (GameSetting.smethod_3(this.player.gclass10_0.gclass5_2))
		{
			this.neckController.vmethod_0();
		}
		if (this.player.gclass10_0.method_21(GClass6.GEnum6.LightsOut))
		{
			this.camera.enabled = false;
		}
		else
		{
			if (this.player.gclass10_0.method_21(GClass6.GEnum6.ModPrep))
			{
				this.neckController.vmethod_7();
				this.neckController.vmethod_8();
				this.highwayObjects[0].SetActive(false);
				this.highwayObjects[1].SetActive(false);
			}
			if (this.player.gclass10_0.method_21(GClass6.GEnum6.ModLite))
			{
				this.neckController.vmethod_8();
			}
			if (this.player.gclass10_0.method_21(GClass6.GEnum6.ModFull))
			{
				this.neckController.vmethod_8();
				this.highwayObjects[0].SetActive(false);
				this.highwayObjects[1].SetActive(false);
			}
		}
		if (GameSetting.smethod_3(this.player.gclass10_0.gclass5_5))
		{
			this.nameText.GetComponent<TextMesh>().text = this.player.gclass10_0.string_0;
			this.nameText.SetActive(true);
		}
		else
		{
			UnityEngine.Object.Destroy(this.nameText);
		}
		if (GameSetting.smethod_3(this.player.gclass10_0.gclass5_4))
		{
			this.float_0 = this.float_2;
			this.float_1 = -this.float_3;
			this.spBar.gameObject.SetActive(false);
			this.healthContainer.gameObject.SetActive(false);
			this.comboCounter.gameObject.SetActive(false);
		}
	}

	// Token: 0x060016A1 RID: 5793
	protected abstract void UpdateInput();

	// Token: 0x060016A2 RID: 5794
	protected abstract void UpdateAI();

	// Token: 0x060016A3 RID: 5795
	protected abstract bool vmethod_2(GClass6 gclass6_1, int int_10);

	// Token: 0x060016A4 RID: 5796 RVA: 0x000BAAA4 File Offset: 0x000B8CA4
	protected bool method_0(GClass6 gclass6_1)
	{
		int num = (int)this.byte_0;
		if (this.list_0.Count > 0)
		{
			foreach (GClass6 gclass in this.list_0)
			{
				if (gclass.Boolean_5)
				{
					num &= (int)(~(int)gclass.byte_0);
				}
			}
			if (num != (int)this.byte_0 && this.vmethod_2(gclass6_1, num))
			{
				return true;
			}
		}
		int num2 = num;
		if (this.list_1.Count > 0)
		{
			foreach (GClass6 gclass2 in this.list_1)
			{
				if (gclass2.Boolean_5)
				{
					num2 &= (int)(~(int)gclass2.byte_0);
				}
			}
			if (num2 != num && this.vmethod_2(gclass6_1, num2))
			{
				return true;
			}
		}
		return this.vmethod_2(gclass6_1, (int)this.byte_0);
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x000BABAC File Offset: 0x000B8DAC
	public void method_1()
	{
		BassAudioManager.instance.method_17(this.player.gclass10_0.genum18_0, true);
		this.bool_4 = false;
		this.int_1 = 0;
		this.int_8 = 0;
		this.int_6 = 0;
		this.int_7 = 0;
		this.int_4 = 0;
		this.FCIndicator.SetActive(true);
		this.soloCounter_0.Reset();
		this.noteRenderer.Reset();
		this.method_9();
		this.comboCounter.method_53(this.int_4);
		this.canOverstrum = false;
		this.neckController.vmethod_4();
		this.bool_3 = false;
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x000BAC50 File Offset: 0x000B8E50
	protected void method_2(bool bool_6)
	{
		if (bool_6)
		{
			if (this.float_6 >= 1f)
			{
				return;
			}
			if (this.bool_1)
			{
				this.float_6 += this.float_9;
			}
			else
			{
				this.float_6 += this.float_7;
			}
		}
		else
		{
			this.float_6 -= this.float_8;
			if (this.float_6 < 0f && !GlobalVariables.instance.failed)
			{
				GlobalVariables.instance.failed = true;
				BassAudioManager.instance.method_20();
				this.gameManager.method_27();
			}
		}
		this.healthContainer.method_37(this.float_6);
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x0000C22D File Offset: 0x0000A42D
	protected void method_3(float float_10)
	{
		this.float_5 -= float_10;
		if (this.float_5 <= 0f)
		{
			this.method_6();
		}
		this.spBar.method_7(this.float_5, this.bool_1);
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x000BAD00 File Offset: 0x000B8F00
	protected void method_4(float float_10)
	{
		bool flag = this.float_5 < 0.5f && !this.bool_1;
		this.float_5 += float_10;
		if (float_10 > 0.24f)
		{
			this.int_3++;
			if (!this.player.gclass10_0.gclass5_4.Boolean_1)
			{
				BassAudioManager.instance.method_64();
			}
		}
		else if (flag && this.float_5 >= 0.5f)
		{
			BassAudioManager.instance.method_59();
		}
		if (this.float_5 >= 1f)
		{
			this.float_5 = 1f;
		}
		this.spBar.method_7(this.float_5, this.bool_1);
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x000BADBC File Offset: 0x000B8FBC
	protected void DeployStarPower()
	{
		this.bool_1 = true;
		this.comboCounter.method_73();
		BassAudioManager.instance.method_54();
		this.int_2 *= 2;
		if (!this.player.gclass10_0.Boolean_2)
		{
			this.spNeckRenderer.method_11();
		}
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x000BAE10 File Offset: 0x000B9010
	protected void method_6()
	{
		this.bool_1 = false;
		this.comboCounter.method_15();
		this.float_5 = 0f;
		BassAudioManager.instance.method_32();
		this.int_2 /= 2;
		this.spNeckRenderer.method_4();
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x000BAE60 File Offset: 0x000B9060
	public virtual void vmethod_3(GClass6 gclass6_1)
	{
		gclass6_1.bool_1 = true;
		if (gclass6_1.Boolean_2)
		{
			return;
		}
		this.bool_5 = gclass6_1.Boolean_3;
		this.vmethod_4(false);
		if (gclass6_1.Boolean_8)
		{
			this.method_10();
		}
		if (gclass6_1.Boolean_9)
		{
			this.method_11();
		}
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x000BAEAC File Offset: 0x000B90AC
	public virtual void vmethod_4(bool bool_6)
	{
		if (bool_6)
		{
			if (!this.canOverstrum && this.list_0.Count == 0)
			{
				return;
			}
			if (this.int_4 > 0 && this.int_5 > 0 && this.gclass6_0[0].Boolean_6)
			{
				return;
			}
			if (this.list_0.Count > 0)
			{
				foreach (GClass6 gclass in this.list_0)
				{
					gclass.bool_1 = true;
				}
				this.list_0.Clear();
				this.neckController.vmethod_4();
			}
			BassAudioManager.instance.method_62();
		}
		if (this.int_4 >= 10)
		{
			if (!bool_6)
			{
				BassAudioManager.instance.method_4();
			}
			this.cameraShake_0.method_38();
		}
		this.int_4 = 0;
		this.method_9();
		this.comboCounter.method_53(0);
		this.canOverstrum = true;
		this.method_2(false);
		if (!this.bool_2 && this.list_0.Count == 0)
		{
			BassAudioManager.instance.method_17(this.player.gclass10_0.genum18_0, false);
			this.bool_2 = true;
		}
		if (this.bool_5)
		{
			this.noteRenderer.method_0();
			this.bool_5 = false;
		}
		if (!this.bool_4)
		{
			this.FCIndicator.SetActive(false);
			this.bool_4 = true;
		}
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x0000C267 File Offset: 0x0000A467
	protected void method_7(int int_10)
	{
		this.int_6 += int_10 * this.int_2;
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x0000C27E File Offset: 0x0000A47E
	protected void method_8(GClass6 gclass6_1)
	{
		this.int_6 += (int)(Class3.smethod_1(gclass6_1.byte_0) * 50) * this.int_2;
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x0000C2A2 File Offset: 0x0000A4A2
	public void method_9()
	{
		if (this.int_4 > 30)
		{
			this.int_2 = 4;
		}
		else
		{
			this.int_2 = this.int_4 / 10 + 1;
		}
		if (this.bool_1)
		{
			this.int_2 *= 2;
		}
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x0000C2DE File Offset: 0x0000A4DE
	public void method_10()
	{
		this.soloCounter_0.method_34(this.noteRenderer.list_1[this.int_1]);
		this.bool_3 = true;
		this.int_1++;
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x0000C316 File Offset: 0x0000A516
	public void method_11()
	{
		this.bool_3 = false;
		this.soloCounter_0.method_48();
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x0000C32A File Offset: 0x0000A52A
	public void method_12()
	{
		this.list_0.Clear();
		this.list_1.Clear();
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x000BB020 File Offset: 0x000B9220
	protected virtual void Update()
	{
		if (!this.gameManager.isPaused && this.player.player_0.GetButtonDown(16))
		{
			this.gameManager.PauseSong(this.player);
		}
		if (this.bool_1)
		{
			this.method_3(this.gameManager.method_70());
		}
		if (this.gameManager.isPaused && this.bool_2)
		{
			this.bool_2 = false;
		}
	}

	// Token: 0x0400036B RID: 875
	protected GameManager gameManager;

	// Token: 0x0400036C RID: 876
	[SerializeField]
	protected BaseNeckController neckController;

	// Token: 0x0400036D RID: 877
	[SerializeField]
	public BaseNoteRenderer noteRenderer;

	// Token: 0x0400036E RID: 878
	[SerializeField]
	public Camera camera;

	// Token: 0x0400036F RID: 879
	[SerializeField]
	protected ComboColor comboCounter;

	// Token: 0x04000370 RID: 880
	[SerializeField]
	protected HealthContainer healthContainer;

	// Token: 0x04000371 RID: 881
	[SerializeField]
	private GameObject FCIndicator;

	// Token: 0x04000372 RID: 882
	[HideInInspector]
	public SoloCounter soloCounter_0;

	// Token: 0x04000373 RID: 883
	[HideInInspector]
	public CHPlayer player;

	// Token: 0x04000374 RID: 884
	[SerializeField]
	protected SPBar spBar;

	// Token: 0x04000375 RID: 885
	[SerializeField]
	public GameObject[] highwayObjects;

	// Token: 0x04000376 RID: 886
	private const int int_0 = 50;

	// Token: 0x04000377 RID: 887
	public HighwayScroll highwayScroll_0;

	// Token: 0x04000378 RID: 888
	public CameraShake cameraShake_0;

	// Token: 0x04000379 RID: 889
	public List<GClass6> list_0;

	// Token: 0x0400037A RID: 890
	public List<GClass6> list_1;

	// Token: 0x0400037B RID: 891
	public List<GClass8> list_2;

	// Token: 0x0400037C RID: 892
	public float float_0;

	// Token: 0x0400037D RID: 893
	public float float_1;

	// Token: 0x0400037E RID: 894
	protected float float_2;

	// Token: 0x0400037F RID: 895
	protected float float_3 = 0.07f;

	// Token: 0x04000380 RID: 896
	public float float_4;

	// Token: 0x04000381 RID: 897
	protected byte byte_0;

	// Token: 0x04000382 RID: 898
	protected byte byte_1;

	// Token: 0x04000383 RID: 899
	[HideInInspector]
	public bool canOverstrum;

	// Token: 0x04000384 RID: 900
	[HideInInspector]
	public bool bool_1;

	// Token: 0x04000385 RID: 901
	public bool bool_2;

	// Token: 0x04000386 RID: 902
	protected bool bool_3;

	// Token: 0x04000387 RID: 903
	protected bool bool_4;

	// Token: 0x04000388 RID: 904
	protected int int_1;

	// Token: 0x04000389 RID: 905
	[HideInInspector]
	public bool bool_5;

	// Token: 0x0400038A RID: 906
	protected int int_2;

	// Token: 0x0400038B RID: 907
	[HideInInspector]
	public int int_3;

	// Token: 0x0400038C RID: 908
	public GClass6[] gclass6_0;

	// Token: 0x0400038D RID: 909
	protected float float_5;

	// Token: 0x0400038E RID: 910
	protected float float_6 = 0.5f;

	// Token: 0x0400038F RID: 911
	protected float float_7 = 0.0069f;

	// Token: 0x04000390 RID: 912
	protected float float_8 = 0.0277f;

	// Token: 0x04000391 RID: 913
	protected float float_9 = 0.045f;

	// Token: 0x04000392 RID: 914
	[HideInInspector]
	public int int_4;

	// Token: 0x04000393 RID: 915
	[HideInInspector]
	public int int_5;

	// Token: 0x04000394 RID: 916
	[HideInInspector]
	public int int_6;

	// Token: 0x04000395 RID: 917
	[HideInInspector]
	public int int_7;

	// Token: 0x04000396 RID: 918
	[HideInInspector]
	public int int_8;

	// Token: 0x04000397 RID: 919
	[HideInInspector]
	public int int_9;

	// Token: 0x04000398 RID: 920
	[SerializeField]
	private GameObject nameText;

	// Token: 0x04000399 RID: 921
	[SerializeField]
	private SpNeckRenderer spNeckRenderer;
}
