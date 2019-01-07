using System;
using System.IO;
using UnityEngine;

// Token: 0x0200006B RID: 107
public class HighwayScroll : MonoBehaviour
{
	// Token: 0x0600152A RID: 5418 RVA: 0x0000B836 File Offset: 0x00009A36
	private void method_0()
	{
		if (this.float_0 > 654f)
		{
			this.float_0 -= 607f;
		}
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x000B0984 File Offset: 0x000AEB84
	private void method_1()
	{
		float num = (float)(this.gameManager_0.double_1 - this.double_0);
		this.float_0 += num * this.baseNoteRenderer_0.float_0 / 1769f;
		this.renderer_0.material.mainTextureOffset = new Vector2(1507f, this.float_0);
		this.double_0 = this.gameManager_0.double_1;
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x0000B857 File Offset: 0x00009A57
	private void method_2()
	{
		if (this.float_0 > 240f)
		{
			this.float_0 -= 552f;
		}
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x0000B878 File Offset: 0x00009A78
	private void method_3()
	{
		if (this.float_0 > 1569f)
		{
			this.float_0 -= 226f;
		}
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x000B09F8 File Offset: 0x000AEBF8
	private void Update()
	{
		float num = (float)(this.gameManager_0.double_1 - this.double_0);
		this.float_0 += num * this.baseNoteRenderer_0.float_0 / 6f;
		this.renderer_0.material.mainTextureOffset = new Vector2(0f, this.float_0);
		this.double_0 = this.gameManager_0.double_1;
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_4()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x000B0A6C File Offset: 0x000AEC6C
	private void method_5()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.gameObject.SetActive(true);
		}
		this.gameManager_0 = GameObject.Find("Hard").GetComponent<GameManager>();
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x000B0AD4 File Offset: 0x000AECD4
	private void method_6()
	{
		float num = (float)(this.gameManager_0.double_1 - this.double_0);
		this.float_0 += num * this.baseNoteRenderer_0.float_0 / 1437f;
		this.renderer_0.material.mainTextureOffset = new Vector2(982f, this.float_0);
		this.double_0 = this.gameManager_0.double_1;
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x000B0B48 File Offset: 0x000AED48
	public void method_7(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(2, 2);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x000B0BA8 File Offset: 0x000AEDA8
	private void method_8()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.gameObject.SetActive(true);
		}
		this.gameManager_0 = GameObject.Find("Open Data Privacy Page").GetComponent<GameManager>();
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x000B0C10 File Offset: 0x000AEE10
	public void method_9(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(1, 1);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_10()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_11()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x000B0C70 File Offset: 0x000AEE70
	private void method_12()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.gameObject.SetActive(false);
		}
		this.gameManager_0 = GameObject.Find("Set B Position").GetComponent<GameManager>();
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x000B0CD8 File Offset: 0x000AEED8
	private void method_13()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.gameObject.SetActive(true);
		}
		this.gameManager_0 = GameObject.Find("Gameplay").GetComponent<GameManager>();
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x000B0D40 File Offset: 0x000AEF40
	public void method_14(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(3, 8);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x000B0DA0 File Offset: 0x000AEFA0
	private void method_15()
	{
		float num = (float)(this.gameManager_0.double_1 - this.double_0);
		this.float_0 += num * this.baseNoteRenderer_0.float_0 / 1088f;
		this.renderer_0.material.mainTextureOffset = new Vector2(54f, this.float_0);
		this.double_0 = this.gameManager_0.double_1;
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x0000B8A7 File Offset: 0x00009AA7
	private void method_16()
	{
		if (this.float_0 > 1849f)
		{
			this.float_0 -= 574f;
		}
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x000B0E14 File Offset: 0x000AF014
	public void method_17(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(2, 3);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x000B0E74 File Offset: 0x000AF074
	public void method_18(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(5, 5);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x000B0ED4 File Offset: 0x000AF0D4
	private void method_19()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.gameObject.SetActive(false);
		}
		this.gameManager_0 = GameObject.Find("Client connected").GetComponent<GameManager>();
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x000B0F3C File Offset: 0x000AF13C
	private void method_20()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.gameObject.SetActive(true);
		}
		this.gameManager_0 = GameObject.Find("Yes").GetComponent<GameManager>();
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x0000B8C8 File Offset: 0x00009AC8
	private void FixedUpdate()
	{
		if (this.float_0 > 100f)
		{
			this.float_0 -= 100f;
		}
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_21()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x000B0FA4 File Offset: 0x000AF1A4
	public void method_22(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(1, 5);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_23()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x000B1004 File Offset: 0x000AF204
	private void method_24()
	{
		float num = (float)(this.gameManager_0.double_1 - this.double_0);
		this.float_0 += num * this.baseNoteRenderer_0.float_0 / 1108f;
		this.renderer_0.material.mainTextureOffset = new Vector2(106f, this.float_0);
		this.double_0 = this.gameManager_0.double_1;
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x0000B8E9 File Offset: 0x00009AE9
	private void method_25()
	{
		if (this.float_0 > 121f)
		{
			this.float_0 -= 140f;
		}
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x000B1078 File Offset: 0x000AF278
	public void method_26(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(4, 5);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_27()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x000B10D8 File Offset: 0x000AF2D8
	public void method_28(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(4, 0);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x000B1138 File Offset: 0x000AF338
	private void method_29()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.gameObject.SetActive(false);
		}
		this.gameManager_0 = GameObject.Find("volume").GetComponent<GameManager>();
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_30()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_31()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x0000B899 File Offset: 0x00009A99
	private void Awake()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x000B11A0 File Offset: 0x000AF3A0
	public void method_32(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(2, 1);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x000B1200 File Offset: 0x000AF400
	private void method_33()
	{
		float num = (float)(this.gameManager_0.double_1 - this.double_0);
		this.float_0 += num * this.baseNoteRenderer_0.float_0 / 1960f;
		this.renderer_0.material.mainTextureOffset = new Vector2(1218f, this.float_0);
		this.double_0 = this.gameManager_0.double_1;
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x000B1274 File Offset: 0x000AF474
	public void method_34(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(2, 6);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x0000B90A File Offset: 0x00009B0A
	private void method_35()
	{
		if (this.float_0 > 1793f)
		{
			this.float_0 -= 784f;
		}
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x000B12D4 File Offset: 0x000AF4D4
	private void method_36()
	{
		float num = (float)(this.gameManager_0.double_1 - this.double_0);
		this.float_0 += num * this.baseNoteRenderer_0.float_0 / 388f;
		this.renderer_0.material.mainTextureOffset = new Vector2(1526f, this.float_0);
		this.double_0 = this.gameManager_0.double_1;
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x0000B92B File Offset: 0x00009B2B
	private void method_37()
	{
		if (this.float_0 > 478f)
		{
			this.float_0 -= 1049f;
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x000B1348 File Offset: 0x000AF548
	private void method_38()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.gameObject.SetActive(false);
		}
		this.gameManager_0 = GameObject.Find("game").GetComponent<GameManager>();
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x000B13B0 File Offset: 0x000AF5B0
	public void method_39(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(5, 2);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x000B1410 File Offset: 0x000AF610
	private void Start()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.Boolean_2)
		{
			base.gameObject.SetActive(false);
		}
		this.gameManager_0 = GameObject.Find("Game Manager").GetComponent<GameManager>();
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x0000B899 File Offset: 0x00009A99
	private void method_40()
	{
		this.renderer_0 = base.GetComponent<Renderer>();
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x000B1478 File Offset: 0x000AF678
	public void method_41(int int_0)
	{
		if (GlobalVariables.instance.highwayPaths != null)
		{
			if (int_0 != -1)
			{
				string path = GlobalVariables.instance.highwayPaths[int_0];
				if (File.Exists(path))
				{
					Texture2D texture2D = new Texture2D(3, 4);
					byte[] data = File.ReadAllBytes(path);
					if (texture2D.LoadImage(data))
					{
						this.renderer_0.material.mainTexture = texture2D;
					}
				}
				return;
			}
		}
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x000B14D8 File Offset: 0x000AF6D8
	private void method_42()
	{
		this.baseNoteRenderer_0 = base.transform.parent.GetComponent<BaseNoteRenderer>();
		if (this.baseNoteRenderer_0.gameObject.GetComponent<BasePlayer>().player.gclass10_0.method_29())
		{
			base.gameObject.SetActive(true);
		}
		this.gameManager_0 = GameObject.Find("song").GetComponent<GameManager>();
	}

	// Token: 0x040002F5 RID: 757
	private BaseNoteRenderer baseNoteRenderer_0;

	// Token: 0x040002F6 RID: 758
	private Renderer renderer_0;

	// Token: 0x040002F7 RID: 759
	private float float_0;

	// Token: 0x040002F8 RID: 760
	private double double_0;

	// Token: 0x040002F9 RID: 761
	private float float_1;

	// Token: 0x040002FA RID: 762
	private GameManager gameManager_0;
}
