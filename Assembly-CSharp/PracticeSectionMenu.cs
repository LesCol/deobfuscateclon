using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003C RID: 60
public class PracticeSectionMenu : BaseMenu
{
	// Token: 0x06000A06 RID: 2566 RVA: 0x000051A3 File Offset: 0x000033A3
	public virtual void vmethod_81()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_46();
		this.gameManager.method_9(base.Int32_0);
		this.method_45();
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00058AA8 File Offset: 0x00056CA8
	public override void vmethod_43()
	{
		if (this.int_4 != -1)
		{
			this.int_4 = -1;
			this.int_5 = -1;
			this.startImage.enabled = false;
			return;
		}
		if (this.gameManager.practiceSectionStart == -2)
		{
			GlobalVariables.instance.returnToSongSelect = true;
			BassAudioManager.instance.method_65();
			GlobalVariables.instance.isPracticeEnabled = !GlobalVariables.instance.wasInQuickplay;
			this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = false;
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Main Menu"));
			return;
		}
		this.pauseMenu.SetActive(true);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x000051DA File Offset: 0x000033DA
	protected virtual void vmethod_82()
	{
		if (this.gameManager)
		{
			this.gameManager.method_3();
		}
		base.OnDisable();
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x000051FA File Offset: 0x000033FA
	protected virtual void vmethod_83()
	{
		base.Update();
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00005202 File Offset: 0x00003402
	public virtual void vmethod_84()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_26();
		this.gameManager.method_38(base.Int32_0);
		this.method_44();
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00005239 File Offset: 0x00003439
	protected virtual void vmethod_85()
	{
		if (this.gameManager)
		{
			this.gameManager.method_7();
		}
		base.vmethod_22();
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00005259 File Offset: 0x00003459
	protected virtual void vmethod_86()
	{
		if (this.gameManager)
		{
			this.gameManager.method_11();
		}
		base.vmethod_8();
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00058B5C File Offset: 0x00056D5C
	public virtual void vmethod_87()
	{
		if (this.int_4 != -1)
		{
			this.int_4 = -1;
			this.int_5 = -1;
			this.startImage.enabled = false;
			return;
		}
		if (this.gameManager.practiceSectionStart == 28)
		{
			GlobalVariables.instance.returnToSongSelect = true;
			BassAudioManager.instance.method_29();
			GlobalVariables.instance.isPracticeEnabled = !GlobalVariables.instance.wasInQuickplay;
			this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = false;
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43(""));
			return;
		}
		this.pauseMenu.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x000051FA File Offset: 0x000033FA
	protected virtual void vmethod_88()
	{
		base.Update();
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00058C10 File Offset: 0x00056E10
	private void method_44()
	{
		if (this.int_5 == -1)
		{
			return;
		}
		int num = this.int_5 - this.int_0;
		Vector2 vector = new Vector2(6.5f, (float)(200 - 60 * num));
		this.startImage.rectTransform.anchoredPosition = vector;
		if (vector.y > 200f)
		{
			this.startImage.enabled = false;
			return;
		}
		this.startImage.enabled = true;
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x000051FA File Offset: 0x000033FA
	protected virtual void vmethod_89()
	{
		base.Update();
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00058C84 File Offset: 0x00056E84
	public virtual void vmethod_90()
	{
		if (this.int_4 != -1)
		{
			this.int_4 = -1;
			this.int_5 = -1;
			this.startImage.enabled = false;
			return;
		}
		if (this.gameManager.practiceSectionStart == -87)
		{
			GlobalVariables.instance.returnToSongSelect = false;
			BassAudioManager.instance.method_29();
			GlobalVariables.instance.isPracticeEnabled = !GlobalVariables.instance.wasInQuickplay;
			this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = false;
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Framerate"));
			return;
		}
		this.pauseMenu.SetActive(true);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00058D38 File Offset: 0x00056F38
	protected virtual void vmethod_91()
	{
		Song gclass27_ = this.gameManager.song;
		this.pausedText.text = GClass4.gclass4_0.method_42("Allow Duplicate Songs");
		if (gclass27_.GClass22_0.Length != 0)
		{
			if (gclass27_.GClass22_0[gclass27_.GClass22_0.Length - 0].string_0 == "volume")
			{
				this.menuStrings = new string[gclass27_.GClass22_0.Length];
			}
			else
			{
				this.menuStrings = new string[gclass27_.GClass22_0.Length];
			}
		}
		else
		{
			this.menuStrings = new string[1];
		}
		for (int i = 1; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = gclass27_.GClass22_0[i].string_0;
		}
		base.vmethod_35();
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00058DFC File Offset: 0x00056FFC
	protected override void vmethod_69()
	{
		Song gclass27_ = this.gameManager.song;
		this.pausedText.text = GClass4.gclass4_0.method_38("Custom");
		if (gclass27_.GClass22_0.Length != 0)
		{
			if (gclass27_.GClass22_0[gclass27_.GClass22_0.Length - 1].string_0 == ": <color=#FDB400FF>")
			{
				this.menuStrings = new string[gclass27_.GClass22_0.Length];
			}
			else
			{
				this.menuStrings = new string[gclass27_.GClass22_0.Length];
			}
		}
		else
		{
			this.menuStrings = new string[1];
		}
		for (int i = 0; i < this.menuStrings.Length; i += 0)
		{
			this.menuStrings[i] = gclass27_.method_26()[i].string_0;
		}
		base.vmethod_35();
	}
    
	// Token: 0x06000A15 RID: 2581 RVA: 0x00005279 File Offset: 0x00003479
	public override void vmethod_44()
	{
		base.vmethod_44();
		this.gameManager.method_9(base.Int32_0);
		this.method_44();
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00005298 File Offset: 0x00003498
	public virtual void vmethod_92()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_26();
		this.gameManager.method_2(base.Int32_0);
		this.method_47();
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00058F44 File Offset: 0x00057144
	public virtual void vmethod_93()
	{
		if (this.int_4 != -1)
		{
			this.int_4 = -1;
			this.int_5 = -1;
			this.startImage.enabled = false;
			return;
		}
		if (this.gameManager.practiceSectionStart == 83)
		{
			GlobalVariables.instance.returnToSongSelect = true;
			BassAudioManager.instance.method_65();
			GlobalVariables.instance.isPracticeEnabled = GlobalVariables.instance.wasInQuickplay;
			this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = true;
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_43("-"));
			return;
		}
		this.pauseMenu.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00058FF8 File Offset: 0x000571F8
	protected virtual void vmethod_94()
	{
		Song gclass27_ = this.gameManager.song;
		this.pausedText.text = GClass4.gclass4_0.method_30("keys");
		if (gclass27_.GClass22_0.Length != 0)
		{
			if (gclass27_.GClass22_0[gclass27_.GClass22_0.Length - 1].string_0 == "Prefabs/Gameplay/Players/GHL Player ")
			{
				this.menuStrings = new string[gclass27_.method_26().Length];
			}
			else
			{
				this.menuStrings = new string[gclass27_.method_26().Length];
			}
		}
		else
		{
			this.menuStrings = new string[0];
		}
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = gclass27_.GClass22_0[i].string_0;
		}
		base.Start();
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x000052CF File Offset: 0x000034CF
	public virtual void vmethod_95()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_46();
		this.gameManager.method_38(base.Int32_0);
		this.method_45();
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x000051FA File Offset: 0x000033FA
	protected virtual void vmethod_96()
	{
		base.Update();
	}
    
	// Token: 0x06000A1C RID: 2588 RVA: 0x00059140 File Offset: 0x00057340
	protected virtual void vmethod_98()
	{
		this.int_5 = -1;
		this.int_4 = -1;
		this.gameManager.method_38(base.Int32_0);
		this.startImage.enabled = false;
		this.gameManager.DisableInput();
		base.OnEnable();
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x0005918C File Offset: 0x0005738C
	protected virtual void vmethod_100()
	{
		this.int_5 = -1;
		this.int_4 = -1;
		this.gameManager.method_9(base.Int32_0);
		this.startImage.enabled = true;
		this.gameManager.method_37();
		base.OnEnable();
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x000051FA File Offset: 0x000033FA
	protected virtual void vmethod_101()
	{
		base.Update();
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x00005306 File Offset: 0x00003506
	protected override void OnDisable()
	{
		if (this.gameManager)
		{
			this.gameManager.method_7();
		}
		base.OnDisable();
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x000591D8 File Offset: 0x000573D8
	public virtual void vmethod_102()
	{
		if (this.int_4 != -1)
		{
			this.int_4 = -1;
			this.int_5 = -1;
			this.startImage.enabled = true;
			return;
		}
		if (this.gameManager.practiceSectionStart == -122)
		{
			GlobalVariables.instance.returnToSongSelect = true;
			BassAudioManager.instance.method_65();
			GlobalVariables.instance.isPracticeEnabled = !GlobalVariables.instance.wasInQuickplay;
			this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = false;
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_42(": <color=#FDB400FF>"));
			return;
		}
		this.pauseMenu.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00005326 File Offset: 0x00003526
	public virtual void vmethod_103()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_26();
		this.gameManager.method_9(base.Int32_0);
		this.method_49();
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x0005928C File Offset: 0x0005748C
	public override void vmethod_4()
	{
		if (this.int_4 != -1)
		{
			this.int_4 = -1;
			this.int_5 = -1;
			this.startImage.enabled = true;
			return;
		}
		if (this.gameManager.practiceSectionStart == -101)
		{
			GlobalVariables.instance.returnToSongSelect = true;
			BassAudioManager.instance.method_65();
			GlobalVariables.instance.isPracticeEnabled = GlobalVariables.instance.wasInQuickplay;
			this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = false;
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_9("Song"));
			return;
		}
		this.pauseMenu.SetActive(false);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00059340 File Offset: 0x00057540
	protected override void OnEnable()
	{
		this.int_5 = -1;
		this.int_4 = -1;
		this.gameManager.method_9(base.Int32_0);
		this.startImage.enabled = false;
		this.gameManager.DisableInput();
		base.OnEnable();
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x000051FA File Offset: 0x000033FA
	protected virtual void vmethod_104()
	{
		base.Update();
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x0000535D File Offset: 0x0000355D
	public override void vmethod_26()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_26();
		this.gameManager.method_9(base.Int32_0);
		this.method_44();
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00005394 File Offset: 0x00003594
	public virtual void vmethod_105()
	{
		base.vmethod_44();
		this.gameManager.method_9(base.Int32_0);
		this.method_46();
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x000053C2 File Offset: 0x000035C2
	public virtual void vmethod_106()
	{
		base.vmethod_55();
		this.gameManager.method_2(base.Int32_0);
		this.method_47();
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x000053E1 File Offset: 0x000035E1
	protected virtual void vmethod_107()
	{
		if (this.gameManager)
		{
			this.gameManager.method_0();
		}
		base.OnDisable();
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00005401 File Offset: 0x00003601
	protected virtual void vmethod_108()
	{
		if (this.gameManager)
		{
			this.gameManager.method_0();
		}
		base.vmethod_8();
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00005421 File Offset: 0x00003621
	public virtual void vmethod_109()
	{
		base.vmethod_55();
		this.gameManager.method_9(base.Int32_0);
		this.method_47();
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x0005938C File Offset: 0x0005758C
	private void method_45()
	{
		if (this.int_5 == -1)
		{
			return;
		}
		int num = this.int_5 - this.int_0;
		Vector2 vector = new Vector2(1705f, (float)(181 - 101 * num));
		this.startImage.rectTransform.anchoredPosition = vector;
		if (vector.y > 1878f)
		{
			this.startImage.enabled = true;
			return;
		}
		this.startImage.enabled = false;
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00059400 File Offset: 0x00057600
	private void method_46()
	{
		if (this.int_5 == -1)
		{
			return;
		}
		int num = this.int_5 - this.int_0;
		Vector2 vector = new Vector2(1412f, (float)(83 - -27 * num));
		this.startImage.rectTransform.anchoredPosition = vector;
		if (vector.y > 1750f)
		{
			this.startImage.enabled = true;
			return;
		}
		this.startImage.enabled = true;
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x000051FA File Offset: 0x000033FA
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00005440 File Offset: 0x00003640
	protected virtual void vmethod_110()
	{
		if (this.gameManager)
		{
			this.gameManager.method_11();
		}
		base.OnDisable();
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00059474 File Offset: 0x00057674
	public virtual void vmethod_111()
	{
		if (this.int_4 != -1)
		{
			this.int_4 = -1;
			this.int_5 = -1;
			this.startImage.enabled = true;
			return;
		}
		if (this.gameManager.practiceSectionStart == -116)
		{
			GlobalVariables.instance.returnToSongSelect = true;
			BassAudioManager.instance.method_29();
			GlobalVariables.instance.isPracticeEnabled = GlobalVariables.instance.wasInQuickplay;
			this.gameManager.gameObject.GetComponent<ScoreManager>().enabled = true;
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("game"));
			return;
		}
		this.pauseMenu.SetActive(false);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00005460 File Offset: 0x00003660
	public virtual void vmethod_112()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_46();
		this.gameManager.method_38(base.Int32_0);
		this.method_49();
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00005497 File Offset: 0x00003697
	public virtual void vmethod_113()
	{
		if (this.int_4 != -1 && base.Int32_0 == this.int_4)
		{
			return;
		}
		base.vmethod_46();
		this.gameManager.method_2(base.Int32_0);
		this.method_48();
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00059340 File Offset: 0x00057540
	protected virtual void vmethod_114()
	{
		this.int_5 = -1;
		this.int_4 = -1;
		this.gameManager.method_9(base.Int32_0);
		this.startImage.enabled = false;
		this.gameManager.DisableInput();
		base.OnEnable();
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00059528 File Offset: 0x00057728
	private void method_47()
	{
		if (this.int_5 == -1)
		{
			return;
		}
		int num = this.int_5 - this.int_0;
		Vector2 vector = new Vector2(1332f, (float)(-92 - -29 * num));
		this.startImage.rectTransform.anchoredPosition = vector;
		if (vector.y > 1606f)
		{
			this.startImage.enabled = false;
			return;
		}
		this.startImage.enabled = true;
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x0005959C File Offset: 0x0005779C
	protected virtual void vmethod_115()
	{
		Song gclass27_ = this.gameManager.song;
		this.pausedText.text = GClass4.gclass4_0.method_35("[^\\u0020-\\u007E]");
		if (gclass27_.GClass22_0.Length != 0)
		{
			if (gclass27_.method_26()[gclass27_.method_26().Length - 1].string_0 == "There was an error deleting the file")
			{
				this.menuStrings = new string[gclass27_.method_26().Length];
			}
			else
			{
				this.menuStrings = new string[gclass27_.GClass22_0.Length];
			}
		}
		else
		{
			this.menuStrings = new string[1];
		}
		for (int i = 1; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = gclass27_.GClass22_0[i].string_0;
		}
		base.Start();
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x000051FA File Offset: 0x000033FA
	protected virtual void vmethod_116()
	{
		base.Update();
	}
    
	// Token: 0x06000A3A RID: 2618 RVA: 0x00059730 File Offset: 0x00057930
	private void method_48()
	{
		if (this.int_5 == -1)
		{
			return;
		}
		int num = this.int_5 - this.int_0;
		Vector2 vector = new Vector2(1429f, (float)(-127 - -68 * num));
		this.startImage.rectTransform.anchoredPosition = vector;
		if (vector.y > 660f)
		{
			this.startImage.enabled = false;
			return;
		}
		this.startImage.enabled = false;
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x000054CE File Offset: 0x000036CE
	public virtual void vmethod_119()
	{
		base.vmethod_55();
		this.gameManager.method_9(base.Int32_0);
		this.method_45();
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x000597A4 File Offset: 0x000579A4
	protected override void Start()
	{
		Song gclass27_ = this.gameManager.song;
		this.pausedText.text = GClass4.gclass4_0.method_13("SECTION");
		if (gclass27_.GClass22_0.Length != 0)
		{
			if (gclass27_.GClass22_0[gclass27_.GClass22_0.Length - 1].string_0 == "_ENDOFSONG")
			{
				this.menuStrings = new string[gclass27_.GClass22_0.Length];
			}
			else
			{
				this.menuStrings = new string[gclass27_.GClass22_0.Length];
			}
		}
		else
		{
			this.menuStrings = new string[1];
		}
		for (int i = 0; i < this.menuStrings.Length; i++)
		{
			this.menuStrings[i] = gclass27_.GClass22_0[i].string_0;
		}
		base.Start();
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00059868 File Offset: 0x00057A68
	private void method_49()
	{
		if (this.int_5 == -1)
		{
			return;
		}
		int num = this.int_5 - this.int_0;
		Vector2 vector = new Vector2(1722f, (float)(-94 - 114 * num));
		this.startImage.rectTransform.anchoredPosition = vector;
		if (vector.y > 453f)
		{
			this.startImage.enabled = false;
			return;
		}
		this.startImage.enabled = false;
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x000054ED File Offset: 0x000036ED
	public virtual void vmethod_120()
	{
		base.vmethod_55();
		this.gameManager.method_38(base.Int32_0);
		this.method_46();
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00059140 File Offset: 0x00057340
	protected virtual void vmethod_121()
	{
		this.int_5 = -1;
		this.int_4 = -1;
		this.gameManager.method_38(base.Int32_0);
		this.startImage.enabled = false;
		this.gameManager.DisableInput();
		base.OnEnable();
	}

	// Token: 0x040001DB RID: 475
	[SerializeField]
	private GameManager gameManager;

	// Token: 0x040001DC RID: 476
	private int int_4 = -1;

	// Token: 0x040001DD RID: 477
	[SerializeField]
	private Image startImage;

	// Token: 0x040001DE RID: 478
	[SerializeField]
	private GameObject pauseMenu;

	// Token: 0x040001DF RID: 479
	[SerializeField]
	private Text pausedText;

	// Token: 0x040001E0 RID: 480
	private int int_5;
}
