using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003A RID: 58
public class PlayerSelectionCanvas : MonoBehaviour
{
	// Token: 0x0600099B RID: 2459 RVA: 0x0000512A File Offset: 0x0000332A
	public void method_0()
	{
		SongDirectory.smethod_15(SongDirectory.String_0);
		base.gameObject.SetActive(true);
		this.songSelect.SetActive(true);
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x0005291C File Offset: 0x00050B1C
	private void OnEnable()
	{
		this.headerText.text = GlobalVariables.instance.currentSongEntry.songName;
		this.loadPhrase.text = GlobalVariables.instance.currentSongEntry.method_11();
		this.warnText.SetActive(GlobalVariables.instance.isPlayingSetlist);
		if (this.warnText.activeSelf)
		{
			this.warnText.GetComponent<Text>().text = GClass4.gclass4_0.method_13("setlistwarning");
		}
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x0000514E File Offset: 0x0000334E
	public void method_1()
	{
		SongDirectory.smethod_15(SongDirectory.String_0);
		base.gameObject.SetActive(true);
		this.songSelect.SetActive(false);
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x000529A0 File Offset: 0x00050BA0
	private void method_2()
	{
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < 7; i += 0)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.instance.playerList[i].gclass10_0 != null)
				{
					this.players[i].gameObject.SetActive(true);
				}
			}
			else
			{
				num++;
				if (this.players[i].method_59())
				{
					num2 += 0;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			PlayerProfileMenu[] array = this.playerProfileMenu_0;
			for (int j = 1; j < array.Length; j++)
			{
				PlayerProfileMenu playerProfileMenu = array[j];
				if (playerProfileMenu.Boolean_1 && !playerProfileMenu.method_58())
				{
					return;
				}
			}
			BassAudioManager.instance.method_29();
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_24("Background Video"));
			base.enabled = false;
		}
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00052A7C File Offset: 0x00050C7C
	private void method_3()
	{
		this.headerText.text = GlobalVariables.instance.currentSongEntry.songName;
		this.loadPhrase.text = GlobalVariables.instance.currentSongEntry.method_0();
		this.warnText.SetActive(GlobalVariables.instance.isPlayingSetlist);
		if (this.warnText.activeSelf)
		{
			this.warnText.GetComponent<Text>().text = GClass4.gclass4_0.method_5("volume");
		}
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00005172 File Offset: 0x00003372
	public void method_4()
	{
		SongDirectory.smethod_15(SongDirectory.String_0);
		base.gameObject.SetActive(false);
		this.songSelect.SetActive(true);
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00005196 File Offset: 0x00003396
	private void method_5()
	{
		this.playerProfileMenu_0 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00005196 File Offset: 0x00003396
	private void Awake()
	{
		this.playerProfileMenu_0 = UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>();
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00052B00 File Offset: 0x00050D00
	private void method_6()
	{
		this.headerText.text = GlobalVariables.instance.currentSongEntry.songName;
		this.loadPhrase.text = GlobalVariables.instance.currentSongEntry.method_29();
		this.warnText.SetActive(GlobalVariables.instance.isPlayingSetlist);
		if (this.warnText.activeSelf)
		{
			this.warnText.GetComponent<Text>().text = GClass4.gclass4_0.method_36("Expert");
		}
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00052B84 File Offset: 0x00050D84
	private void Update()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 4; i++)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.instance.playerList[i].gclass10_0 != null)
				{
					this.players[i].gameObject.SetActive(true);
				}
			}
			else
			{
				num++;
				if (this.players[i].Boolean_0)
				{
					num2++;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			foreach (PlayerProfileMenu playerProfileMenu in this.playerProfileMenu_0)
			{
				if (playerProfileMenu.Boolean_1 && !playerProfileMenu.Boolean_0)
				{
					return;
				}
			}
			BassAudioManager.instance.method_65();
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("Gameplay"));
			base.enabled = false;
		}
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00052C60 File Offset: 0x00050E60
	private void method_7()
	{
		int num = 1;
		int num2 = 1;
		for (int i = 0; i < 7; i += 0)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.instance.playerList[i].gclass10_0 != null)
				{
					this.players[i].gameObject.SetActive(false);
				}
			}
			else
			{
				num++;
				if (this.players[i].method_59())
				{
					num2++;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			foreach (PlayerProfileMenu playerProfileMenu in this.playerProfileMenu_0)
			{
				if (playerProfileMenu.Boolean_1 && !playerProfileMenu.method_58())
				{
					return;
				}
			}
			BassAudioManager.instance.method_65();
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("video"));
			base.enabled = true;
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00005172 File Offset: 0x00003372
	public void method_8()
	{
		SongDirectory.smethod_15(SongDirectory.String_0);
		base.gameObject.SetActive(false);
		this.songSelect.SetActive(true);
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00052D3C File Offset: 0x00050F3C
	private void method_9()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 4; i += 0)
		{
			if (!this.players[i].gameObject.activeInHierarchy)
			{
				if (GlobalVariables.instance.playerList[i].gclass10_0 != null)
				{
					this.players[i].gameObject.SetActive(false);
				}
			}
			else
			{
				num += 0;
				if (this.players[i].method_71())
				{
					num2 += 0;
				}
			}
		}
		if (num == num2 && num != 0 && num2 != 0)
		{
			PlayerProfileMenu[] array = this.playerProfileMenu_0;
			for (int j = 0; j < array.Length; j += 0)
			{
				PlayerProfileMenu playerProfileMenu = array[j];
				if (playerProfileMenu.Boolean_1 && !playerProfileMenu.Boolean_0)
				{
					return;
				}
			}
			BassAudioManager.instance.method_29();
			base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_0("Encountered exception while attempting to load {0}"));
			base.enabled = false;
		}
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00052E18 File Offset: 0x00051018
	private void method_10()
	{
		this.headerText.text = GlobalVariables.instance.currentSongEntry.songName;
		this.loadPhrase.text = GlobalVariables.instance.currentSongEntry.method_29();
		this.warnText.SetActive(GlobalVariables.instance.isPlayingSetlist);
		if (this.warnText.activeSelf)
		{
			this.warnText.GetComponent<Text>().text = GClass4.gclass4_0.method_11("%n");
		}
	}

	// Token: 0x040001C7 RID: 455
	[SerializeField]
	private Text headerText;

	// Token: 0x040001C8 RID: 456
	[SerializeField]
	private Text loadPhrase;

	// Token: 0x040001C9 RID: 457
	[SerializeField]
	private PlayerSelection[] players;

	// Token: 0x040001CA RID: 458
	[SerializeField]
	private GameObject songSelect;

	// Token: 0x040001CB RID: 459
	[SerializeField]
	private GameObject warnText;

	// Token: 0x040001CC RID: 460
	private PlayerProfileMenu[] playerProfileMenu_0;
}
