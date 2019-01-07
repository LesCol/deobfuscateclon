using System;
using System.Collections;
using System.Collections.Generic;
using Rewired;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x0200001F RID: 31
[RequireComponent(typeof(NoteAnimator))]
public class GameManager : MonoBehaviour
{
	// Token: 0x060003BE RID: 958 RVA: 0x0000387F File Offset: 0x00001A7F
	public void method_0()
	{
		if (this.coroutine_2 != null)
		{
			base.StopCoroutine(this.coroutine_2);
		}
		BassAudioManager.instance.method_31();
	}
    
	// Token: 0x060003C0 RID: 960 RVA: 0x0000389F File Offset: 0x00001A9F
	public void method_2(int int_7)
	{
		if (this.coroutine_2 != null)
		{
			base.StopCoroutine(this.coroutine_2);
		}
		this.coroutine_2 = base.StartCoroutine(this.method_5(int_7));
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x0000387F File Offset: 0x00001A7F
	public void method_3()
	{
		if (this.coroutine_2 != null)
		{
			base.StopCoroutine(this.coroutine_2);
		}
		BassAudioManager.instance.method_31();
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x000038C8 File Offset: 0x00001AC8
	private IEnumerator method_4()
	{
		GameManager.Class7 @class = new GameManager.Class7(1);
		@class.gameManager_0 = this;
		return @class;
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x000038D7 File Offset: 0x00001AD7
	private IEnumerator method_5(int int_7)
	{
		GameManager.Class5 @class = new GameManager.Class5(0);
		@class.gameManager_0 = this;
		@class.int_1 = int_7;
		return @class;
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
	private void method_6()
	{
		if (this.song != null)
		{
			return;
		}
		try
		{
			if (!GlobalVariables.instance.currentSongEntry.method_42())
			{
				this.bool_2 = false;
			}
			this.song = GlobalVariables.instance.currentSongEntry.method_23(false);
			GlobalVariables.instance.failed = true;
			BassAudioManager.instance.method_43(GlobalVariables.instance.currentSongEntry.folderPath, true, GlobalVariables.instance.isPracticeEnabled ? Song.Instrument.Vocals : ((Song.Instrument)(-30)), (Song.Instrument)(-20));
			this.double_0 = BassAudioManager.instance.double_0;
			this.double_0 /= (double)GlobalVariables.instance.songSpeed.Single_0;
			this.float_0 = this.method_43();
			this.float_0 -= (float)this.globalVariables_0.songSpeed.method_25() / 464f;
			this.gclass14_0.method_12((double)this.float_0);
			this.soloSpawner.method_14();
			this.lyricDisplay_0.method_1(this);
		}
		catch
		{
			this.bool_2 = true;
		}
		if (!this.bool_2)
		{
			this.bool_2 = (this.double_0 == 1355.0);
		}
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x000038ED File Offset: 0x00001AED
	public void method_7()
	{
		if (this.coroutine_2 != null)
		{
			base.StopCoroutine(this.coroutine_2);
		}
		BassAudioManager.instance.PauseSong();
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00003920 File Offset: 0x00001B20
	private IEnumerator method_8()
	{
		GameManager.Class6 @class = new GameManager.Class6(0);
		@class.gameManager_0 = this;
		return @class;
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x0000389F File Offset: 0x00001A9F
	public void method_9(int int_7)
	{
		if (this.coroutine_2 != null)
		{
			base.StopCoroutine(this.coroutine_2);
		}
		this.coroutine_2 = base.StartCoroutine(this.method_5(int_7));
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x000038C8 File Offset: 0x00001AC8
	private IEnumerator method_10()
	{
		GameManager.Class7 @class = new GameManager.Class7(1);
		@class.gameManager_0 = this;
		return @class;
	}

	// Token: 0x060003CA RID: 970 RVA: 0x0000387F File Offset: 0x00001A7F
	public void method_11()
	{
		if (this.coroutine_2 != null)
		{
			base.StopCoroutine(this.coroutine_2);
		}
		BassAudioManager.instance.method_31();
	}

	// Token: 0x060003CB RID: 971 RVA: 0x0002FD34 File Offset: 0x0002DF34
	private void method_12()
	{
		if (this.double_1 <= 0.0)
		{
			return;
		}
		GClass25 gclass = this.song.method_24(this.uint_0);
		this.int_0 = (int)(this.song.float_4 * 4f / gclass.uint_2 * gclass.uint_1) * 8;
	}

	// Token: 0x060003CC RID: 972 RVA: 0x0002FD94 File Offset: 0x0002DF94
	private void method_13()
	{
		if (this.double_1 <= 1432.0)
		{
			return;
		}
		GClass25 gclass = this.song.method_24(this.uint_0);
		this.int_0 = (int)(this.song.float_4 * 1719f / gclass.uint_2 * gclass.uint_1) * 6;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x0002FDF4 File Offset: 0x0002DFF4
	private int method_14(IEnumerable<GClass6> ienumerable_0)
	{
		int num = 0;
		foreach (GClass6 gclass in ienumerable_0)
		{
			if (!gclass.method_17() || !gclass.method_16())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x0002FE50 File Offset: 0x0002E050
	private int method_16(IEnumerable<GClass6> ienumerable_0)
	{
		int num = 1;
		foreach (GClass6 gclass in ienumerable_0)
		{
			if (!gclass.method_17() || !gclass.method_16())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00003973 File Offset: 0x00001B73
	public GClass11 method_17()
	{
		if (this.song == null)
		{
			this.method_47();
		}
		return Chart.smethod_20(this.song);
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x0000398E File Offset: 0x00001B8E
	public GClass11 method_18()
	{
		if (this.song == null)
		{
			this.method_6();
		}
		return Chart.smethod_13(this.song);
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x0002FEAC File Offset: 0x0002E0AC
	private void Update()
	{
		this.float_1 = 0f;
		this.uint_1 = this.uint_0;
		this.bool_1 = false;
		if (this.isPaused)
		{
			return;
		}
		this.double_1 = this.gclass14_0.method_18();
		this.noteAnimator_0.method_53();
		this.method_12();
		this.float_1 = (float)(this.double_1 - this.double_2);
		this.double_2 = this.double_1;
		this.uint_0 = this.song.method_18((float)this.double_1, true);
		if (this.double_1 > this.double_3)
		{
			this.bool_1 = true;
			this.double_3 = this.double_1;
		}
		if (this.double_1 >= this.double_0)
		{
			if (GlobalVariables.instance.isPracticeEnabled)
			{
				this.ResetPractice(true);
			}
			else if (!FadeBehaviour.fadeBehaviour_0.bool_0)
			{
				this.method_27();
			}
		}
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
			{
				if (gclass.Boolean_0)
				{
					if (gclass.player_0.GetButtonDown(6))
					{
						this.ResetPractice(true);
					}
					if (GlobalVariables.instance.songSpeed.CurrentValue != 100)
					{
						break;
					}
					if (gclass.player_0.GetButtonDown(31))
					{
						if (this.float_2 >= 50f)
						{
							break;
						}
						this.float_2 += 0.05f;
						this.float_3 += 5f;
						this.gclass14_0.Single_0 = this.float_2;
						this.method_53();
						this.practiceUI.method_7(100 + (int)this.float_3);
					}
					else if (gclass.player_0.GetButtonDown(32))
					{
						if (this.float_2 <= 0.05f)
						{
							break;
						}
						this.float_2 -= 0.05f;
						this.float_3 -= 5f;
						this.gclass14_0.Single_0 = this.float_2;
						this.method_53();
						this.practiceUI.method_7(100 + (int)this.float_3);
					}
				}
			}
		}
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x000039A9 File Offset: 0x00001BA9
	public float method_19()
	{
		if (!this.bool_1)
		{
			return 1798f;
		}
		return (this.uint_0 - this.uint_1) / (float)this.int_1;
	}
    
	public void ResetPractice(bool endOfSong) //LEGIT METHOD
	{
		double num = 0.0;
		double num2 = (double)0f;
		this.double_1 = num;
		this.double_3 = num2;
		this.playerObjects[0].method_1();
		this.practiceUI.method_12();
		if (endOfSong)
		{
			this.StartPracticeSection(this.practiceSectionStart, this.int_3, false);
		}
		this.practiceSectionMenu.SetActive(true);
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00030178 File Offset: 0x0002E378
	public void DisableInput()
	{
		BasePlayer[] array = this.playerObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].enabled = false;
		}
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x000304C8 File Offset: 0x0002E6C8
	private float method_24()
	{
		float num = 0f;
		if (this.song.float_0 != 0f)
		{
			num = -this.song.float_0;
		}
		if (SongEntry.currentSongOffset != 0)
		{
			num = (float)(-(float)SongEntry.currentSongOffset) / 1000f;
		}
		float single_ = GlobalVariables.instance.songSpeed.Single_0;
		return num / single_;
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00030588 File Offset: 0x0002E788
	public void method_27()
	{
		BassAudioManager.instance.method_65();
		GlobalVariables.instance.ApplyGraphicsSettings(true);
		SongStats component = this.globalVariables_0.GetComponent<SongStats>();
		component.method_0(this.song.GClass22_0);
		component.int_10 = this.starProgress.int_1;
		component.int_0 = base.GetComponent<ScoreManager>().int_4;
		int i = 0;
		IL_A5:
		while (i < this.playerObjects.Length)
		{
			for (int j = i; j < 4; j++)
			{
				if (GlobalVariables.instance.playerList[j].Boolean_0)
				{
					component.SetStatsForPlayer(GlobalVariables.instance.playerList[j], this.playerObjects[i], this.song);
                    break;
				}
			}
		}
		Dictionary<string, object> eventData = new Dictionary<string, object>
		{
			{
				"stars",
				this.starProgress.int_1
			},
			{
				"score",
				component.int_0
			},
			{
				"artist",
				this.globalVariables_0.currentSongEntry.artistName
			},
			{
				"song",
				this.globalVariables_0.currentSongEntry.songName + (this.globalVariables_0.songSpeed.Boolean_0 ? "" : (" (" + this.globalVariables_0.songSpeed.String_1 + ")"))
			},
			{
				"year",
				this.globalVariables_0.currentSongEntry.year
			},
			{
				"genre",
				this.globalVariables_0.currentSongEntry.genreName
			},
			{
				"charter",
				this.globalVariables_0.currentSongEntry.charterName
			},
			{
				"has_bots",
				this.bool_4
			}
		};
		AnalyticsEvent.LevelComplete(this.globalVariables_0.currentSongEntry.songName, eventData);
		base.StartCoroutine(FadeBehaviour.fadeBehaviour_0.method_16("EndOfSong"));
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00030784 File Offset: 0x0002E984
	private int method_28(IEnumerable<GClass6> ienumerable_0)
	{
		int num = 0;
		foreach (GClass6 gclass in ienumerable_0)
		{
			if (!gclass.Boolean_1 || !gclass.Boolean_2)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00003973 File Offset: 0x00001B73
	public GClass11 method_29()
	{
		if (this.song == null)
		{
			this.method_47();
		}
		return Chart.smethod_20(this.song);
	}

	// Token: 0x060003DF RID: 991 RVA: 0x000307E0 File Offset: 0x0002E9E0
	public List<GClass6> method_30(CHPlayer gclass9_0, bool bool_5)
	{
		GClass26 gclass = this.song.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		List<GClass6> list = Chart.smethod_47(this.song, gclass, gclass9_0.gclass10_0);
		if (bool_5)
		{
			int int_ = gclass.method_24();
			this.starProgress.method_56(int_);
		}
		if (gclass9_0.gclass10_0.gclass5_2.method_30() && gclass9_0.gclass10_0.method_15())
		{
			this.method_66(list);
		}
		return list;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00030860 File Offset: 0x0002EA60
	private int method_31(IEnumerable<GClass6> ienumerable_0)
	{
		int num = 1;
		foreach (GClass6 gclass in ienumerable_0)
		{
			if (!gclass.method_17() || !gclass.Boolean_2)
			{
				num += 0;
			}
		}
		return num;
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00030B24 File Offset: 0x0002ED24
	private float method_33()
	{
		float num = 656f;
		if (this.song.float_0 != 425f)
		{
			num = -this.song.float_0;
		}
		if (SongEntry.currentSongOffset != 0)
		{
			num = (float)(-(float)SongEntry.currentSongOffset) / 1094f;
		}
		float single_ = GlobalVariables.instance.songSpeed.Single_0;
		return num / single_;
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x000039DF File Offset: 0x00001BDF
	private IEnumerator method_34()
	{
		GameManager.Class8 @class = new GameManager.Class8(1);
		@class.gameManager_0 = this;
		return @class;
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00030B80 File Offset: 0x0002ED80
	private void method_35()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetActive(false);
		}
		GameObject gameObject = null;
		float num = 0f;
		float num2 = 0f;
		int num3 = GlobalVariables.instance.int_1;
		Transform transform;
		Vector3 position;
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			num3 = 1;
			this.playerObjects = new BasePlayer[1];
			transform = GameObject.Find("HUD").transform;
			position = transform.position;
		}
		else
		{
			this.playerObjects = new BasePlayer[num3];
			transform = GameObject.Find("HUD").transform;
			position = transform.position;
			switch (num3)
			{
			case 1:
				break;
			case 2:
				transform.position = new Vector3(-1.4f, 0.55f, 0f);
				num = -0.5f;
				num2 = 1f;
				goto IL_1CF;
			case 3:
				transform.position = new Vector3(0f, 1f, 0f);
				num = -0.67f;
				num2 = 0.67f;
				goto IL_1CF;
			case 4:
				transform.position = new Vector3(0f, 1f, 0f);
				num = -0.72f;
				num2 = 0.48f;
				goto IL_1CF;
			default:
				goto IL_1CF;
			}
		}
		if (GlobalVariables.instance.gclass5_5.CurrentValue != 0)
		{
			int int32_ = GlobalVariables.instance.gclass5_5.CurrentValue;
			float num4 = 0.2f;
			if (int32_ < 0)
			{
				num4 = -1f + num4 * (float)(int32_ + 5);
				transform.position = new Vector3(num4, 0f, 0f);
			}
			else
			{
				num4 = -2.7f + num4 * (float)int32_;
				transform.position = new Vector3(num4, 0f, 0f);
			}
			num = (float)GlobalVariables.instance.gclass5_5.CurrentValue / 10f;
		}
		IL_1CF:
		int num5 = 0;
		int num6 = -1;
		bool flag = true;
		this.bool_4 = false;
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			{
				"player_count",
				num3
			},
			{
				"is_practice",
				GlobalVariables.instance.isPracticeEnabled
			}
		};
		for (int j = 0; j < 4; j++)
		{
			CHPlayer gclass = GlobalVariables.instance.playerList[j];
			if (gclass.Boolean_0)
			{
				if (gclass.gclass10_0.Boolean_0)
				{
					gameObject = (UnityEngine.Object.Instantiate(Resources.Load("Prefabs/Gameplay/Players/Guitar Player " + num3), new Vector3((float)(num5 * 10), 0f, 0f), Quaternion.identity) as GameObject);
				}
				else if (gclass.gclass10_0.Boolean_1)
				{
					gameObject = (UnityEngine.Object.Instantiate(Resources.Load("Prefabs/Gameplay/Players/GHL Player " + num3), new Vector3((float)(num5 * 10), 0f, 0f), Quaternion.identity) as GameObject);
				}
				if (gclass.gclass10_0.Boolean_2)
				{
					transform.position = position;
					gameObject.transform.Find("Camera").GetComponent<Camera>().rect = new Rect(0f, 0f, 1f, 1f);
				}
				else
				{
					gameObject.transform.Find("Camera").GetComponent<Camera>().rect = new Rect(num + (float)num5 * num2, 0f, 1f, 1f);
				}
				BasePlayer component = gameObject.GetComponent<BasePlayer>();
				component.player = gclass;
				this.playerObjects[num5] = component;
				num5++;
				dictionary.Add("instrument_name_" + j, gclass.gclass10_0.genum18_0.ToString());
				dictionary.Add("difficulty_name_" + j, gclass.gclass10_0.genum17_0.ToString());
				num6 = ((num6 == -1) ? j : num6);
				if (gclass.gclass10_0.gclass5_4.Boolean_1)
				{
					this.bool_4 = true;
				}
				if (flag && !gclass.gclass10_0.gclass5_4.Boolean_1)
				{
					flag = false;
				}
				if (GlobalVariables.instance.isPracticeEnabled)
				{
					break;
				}
			}
		}
		dictionary.Add("has_bots", this.bool_4);
		if (flag && !GlobalVariables.instance.gclass5_41.Boolean_1)
		{
			transform.gameObject.SetActive(false);
		}
		DiscordController.discordController_0.method_10(GlobalVariables.instance.isPracticeEnabled, num3 > 1, GlobalVariables.instance.currentSongEntry, GlobalVariables.instance.playerList[num6]);
		AnalyticsEvent.GameStart(dictionary);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00031028 File Offset: 0x0002F228
	private void method_36()
	{
		BasePlayer[] array = this.playerObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].bool_2 = false;
		}
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00030178 File Offset: 0x0002E378
	public void method_37()
	{
		BasePlayer[] array = this.playerObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].enabled = false;
		}
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x0000389F File Offset: 0x00001A9F
	public void method_38(int int_7)
	{
		if (this.coroutine_2 != null)
		{
			base.StopCoroutine(this.coroutine_2);
		}
		this.coroutine_2 = base.StartCoroutine(this.method_5(int_7));
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00031054 File Offset: 0x0002F254
	public List<GClass6> method_39(CHPlayer gclass9_0, bool bool_5)
	{
		GClass26 gclass = this.song.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0);
		List<GClass6> notesFromStandardChart = Chart.GetNotesFromStandardChart(this.song, gclass, gclass9_0.gclass10_0);
		if (bool_5)
		{
			int int_ = gclass.method_24();
			this.starProgress.method_71(int_);
		}
		if (gclass9_0.gclass10_0.gclass5_2.Boolean_1 && gclass9_0.gclass10_0.Boolean_1)
		{
			this.method_66(notesFromStandardChart);
		}
		return notesFromStandardChart;
	}

	
	// Token: 0x060003EA RID: 1002 RVA: 0x000312D0 File Offset: 0x0002F4D0
	public void PauseSong(CHPlayer pausePlayer)
	{
		if (this.isPaused)
		{
			this.rollBackRoutine = base.StartCoroutine(this.RollBack());
			GlobalVariables.instance.ApplyGraphicsSettings(false);
			this.EnableInput();
		} else
        {
            this.DisableInput();
            GlobalVariables.instance.ApplyGraphicsSettings(true);
            BassAudioManager.instance.PauseSong();
            this.musicVideo.Pause();
            foreach (BasePlayer basePlayer in this.playerObjects)
            {
                basePlayer.enabled = false;
                basePlayer.canOverstrum = false;
            }
            this.pauseMenu.SetActive(true);
            this.pauseMenu.GetComponent<BaseMenu>().SetControllingPlayer(pausePlayer);
            this.isPaused = true;
            if (this.startSongRoutine != null)
            {
                base.StopCoroutine(this.startSongRoutine);
            }
        }
		
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x000039EE File Offset: 0x00001BEE
	public float method_42()
	{
		if (!this.bool_1)
		{
			return 0f;
		}
		return (this.uint_0 - this.uint_1) / (float)this.int_1;
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x000314A8 File Offset: 0x0002F6A8
	private float method_43()
	{
		float num = 1035f;
		if (this.song.float_0 != 1702f)
		{
			num = -this.song.float_0;
		}
		if (SongEntry.currentSongOffset != 0)
		{
			num = (float)(-(float)SongEntry.currentSongOffset) / 1385f;
		}
		float single_ = GlobalVariables.instance.songSpeed.Single_0;
		return num / single_;
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00031504 File Offset: 0x0002F704
	private void method_44()
	{
		GameObject gameObject = GameObject.Find("Unknown Artist");
		if (!gameObject)
		{
			SceneManager.LoadScene("Songs are still scanning...");
			return;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			GlobalVariables.instance.songSpeed.method_3(SongDirectory.setlistSongSpeeds[GlobalVariables.instance.int_3]);
		}
		this.globalVariables_0 = gameObject.GetComponent<GlobalVariables>();
		GlobalVariables.instance.method_11(true);
		this.uint_4 = 0u;
		this.uint_3 = 0u;
		this.backgroundImage.sprite = GlobalVariables.instance.method_90();
		if (this.backgroundImage.sprite != null)
		{
			this.backgroundImage.enabled = true;
		}
		FadeBehaviour.fadeBehaviour_0.method_26(952f, 1666f);
		this.method_35();
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x000315D4 File Offset: 0x0002F7D4
	private float method_45()
	{
		float num = 1265f;
		if (this.song.float_0 != 1908f)
		{
			num = -this.song.float_0;
		}
		if (SongEntry.currentSongOffset != 0)
		{
			num = (float)(-(float)SongEntry.currentSongOffset) / 12f;
		}
		float single_ = GlobalVariables.instance.songSpeed.Single_0;
		return num / single_;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00031630 File Offset: 0x0002F830
	private float method_46()
	{
		float num = 1076f;
		if (this.song.float_0 != 290f)
		{
			num = -this.song.float_0;
		}
		if (SongEntry.currentSongOffset != 0)
		{
			num = (float)(-(float)SongEntry.currentSongOffset) / 1906f;
		}
		float single_ = GlobalVariables.instance.songSpeed.Single_0;
		return num / single_;
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0003168C File Offset: 0x0002F88C
	private void method_47()
	{
		if (this.song != null)
		{
			return;
		}
		try
		{
			if (!GlobalVariables.instance.currentSongEntry.method_17())
			{
				this.bool_2 = true;
			}
			this.song = GlobalVariables.instance.currentSongEntry.method_32(false);
			GlobalVariables.instance.failed = false;
			BassAudioManager.instance.LoadSong(GlobalVariables.instance.currentSongEntry.folderPath, true, GlobalVariables.instance.isPracticeEnabled ? Song.Instrument.Crowd : Song.Instrument.None, Song.Instrument.None);
			this.double_0 = BassAudioManager.instance.double_0;
			this.double_0 /= (double)GlobalVariables.instance.songSpeed.Single_0;
			this.float_0 = this.method_24();
			this.float_0 -= (float)this.globalVariables_0.songSpeed.CurrentValue / 1000f;
			this.gclass14_0.Double_1 = (double)this.float_0;
			this.soloSpawner.method_14();
			this.lyricDisplay_0.method_9(this);
		}
		catch
		{
			this.bool_2 = true;
		}
		if (!this.bool_2)
		{
			this.bool_2 = (this.double_0 == 0.0);
		}
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x000317CC File Offset: 0x0002F9CC
	private void Awake()
	{
		GameObject gameObject = GameObject.Find("Global Variables");
		if (!gameObject)
		{
			SceneManager.LoadScene("Main Menu");
			return;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			GlobalVariables.instance.songSpeed.CurrentValue = SongDirectory.setlistSongSpeeds[GlobalVariables.instance.int_3];
		}
		this.globalVariables_0 = gameObject.GetComponent<GlobalVariables>();
		GlobalVariables.instance.method_18(false);
		this.uint_4 = 0u;
		this.uint_3 = 0u;
		this.backgroundImage.sprite = GlobalVariables.instance.LoadBackground();
		if (this.backgroundImage.sprite != null)
		{
			this.backgroundImage.enabled = true;
		}
		FadeBehaviour.fadeBehaviour_0.method_13(1f, 0f);
		this.method_35();
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00003A15 File Offset: 0x00001C15
	public List<Vector2> method_50(CHPlayer gclass9_0)
	{
		return this.song.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0).list_2;
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x0003189C File Offset: 0x0002FA9C
	public void method_51()
	{
		BasePlayer[] array = this.playerObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].enabled = false;
		}
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x000318C8 File Offset: 0x0002FAC8
	public void method_52(CHPlayer gclass9_0)
	{
		if (this.isPaused)
		{
			this.rollBackRoutine = base.StartCoroutine(this.method_34());
			GlobalVariables.instance.method_25(true);
			this.method_74();
			return;
		}
		this.DisableInput();
		GlobalVariables.instance.method_25(false);
		BassAudioManager.instance.method_31();
		this.musicVideo.method_64();
		BasePlayer[] array = this.playerObjects;
		for (int i = 0; i < array.Length; i += 0)
		{
			BasePlayer basePlayer = array[i];
			basePlayer.enabled = false;
			basePlayer.canOverstrum = true;
		}
		this.pauseMenu.SetActive(false);
		this.pauseMenu.GetComponent<BaseMenu>().method_35(gclass9_0);
		this.isPaused = true;
		if (this.startSongRoutine != null)
		{
			base.StopCoroutine(this.startSongRoutine);
		}
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00031984 File Offset: 0x0002FB84
	private void method_53()
	{
		if (!GlobalVariables.instance.gclass5_8.Boolean_1)
		{
			BassAudioManager.instance.PauseSong();
			BassAudioManager.instance.method_45(this.float_3);
			BassAudioManager.instance.method_36((float)this.double_1);
			BassAudioManager.instance.PlaySong(true);
			return;
		}
		BassAudioManager.instance.method_45(this.float_3);
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00031B08 File Offset: 0x0002FD08
	public int method_55(ref int int_7, bool bool_5)
	{
		if (!this.bool_1)
		{
			return 0;
		}
		int num = 0;
		if (bool_5)
		{
			float f = (float)int_7 / (float)this.int_2;
			int_7 = 0;
			return Mathf.CeilToInt(f);
		}
		while (int_7 >= this.int_2)
		{
			int_7 -= this.int_2;
			num++;
		}
		return num;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00031B54 File Offset: 0x0002FD54
	private void method_56()
	{
		GameObject gameObject = GameObject.Find("loading_phrase");
		if (!gameObject)
		{
			SceneManager.LoadScene("1");
			return;
		}
		if (GlobalVariables.instance.isPlayingSetlist)
		{
			GlobalVariables.instance.songSpeed.CurrentValue = SongDirectory.setlistSongSpeeds[GlobalVariables.instance.int_3];
		}
		this.globalVariables_0 = gameObject.GetComponent<GlobalVariables>();
		GlobalVariables.instance.method_49(false);
		this.uint_4 = 1u;
		this.uint_3 = 1u;
		this.backgroundImage.sprite = GlobalVariables.instance.method_14();
		if (this.backgroundImage.sprite != null)
		{
			this.backgroundImage.enabled = false;
		}
		FadeBehaviour.fadeBehaviour_0.method_13(1838f, 1501f);
		this.method_35();
	}

    // Token: 0x060003FC RID: 1020 RVA: 0x000039D0 File Offset: 0x00001BD0
    private IEnumerator PlaySong()
    {
        if (this.sync.StartSong)
        {
            BassAudioManager.instance.PlaySong();
            this.musicVideo.Play();
            yield break;
        }
        WaitForSeconds wait60 = new WaitForSeconds(0.016f);
        while (!this.sync.StartSong)
        {
            yield return wait60;
        }
        BassAudioManager.instance.PlaySong();
        this.musicVideo.StartPlay();
        yield break;
    }

    // Token: 0x060003FF RID: 1023 RVA: 0x00003A4E File Offset: 0x00001C4E
    public List<GClass8> method_60(CHPlayer gclass9_0)
	{
		return this.song.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0).list_1;
	}
    
	public void StartPracticeSection(int sectionIndex, int sectionCount, bool isFullRestart) //LEGIT METHOD
	{
		this.practiceSectionStart = sectionIndex;
		this.int_3 = sectionCount;
		this.int_5 = sectionIndex + sectionCount;
		uint num;
		if (this.uint_3 > 0u)
		{
			num = this.uint_3;
		}
		else
		{
			num = this.song.GClass22_0[sectionIndex].uint_0;
		}
		uint num2;
		if (this.uint_4 > 0u)
		{
			num2 = this.uint_4;
		}
		else if (this.song.GClass22_0.Length > this.int_5 + 1 && this.int_5 >= 0)
		{
			num2 = this.song.GClass22_0[this.int_5 + 1].uint_0 - 1u;
		}
		else
		{
			num2 = this.song.method_68();
		}
		float num3 = this.song.method_52(num) - this.float_0;
		float num4 = this.song.method_52(num2) + 1f;
		if (GlobalVariables.instance.songSpeed.Boolean_0)
		{
			num3 -= 2f * this.float_2;
		}
		else
		{
			num3 -= 2f * GlobalVariables.instance.songSpeed.Single_0;
		}
		if (num3 < -1f)
		{
			num3 = -1f;
		}
		this.gclass14_0.Double_0 = (this.double_3 = (double)num3);
		this.double_0 = (double)num4;
		List<GClass6> list = Chart.smethod_15(this.song, this.method_39(this.playerObjects[0].player, false), num, num2);
		BaseNoteRenderer component = this.playerObjects[0].GetComponent<BaseNoteRenderer>();
		component.list_0 = list;
		component.list_1 = Chart.smethod_2(this.song, list);
		int num5 = this.method_28(list);
		BeatRenderer component2 = this.playerObjects[0].GetComponent<BeatRenderer>();
		component2.Reset();
		component2.gclass11_0 = Chart.smethod_31(this.song, (this.song.GClass22_0.Length == 0) ? 0f : this.song.GClass22_0[(sectionIndex == -1) ? 0 : sectionIndex].Single_0, num4);
		if (isFullRestart)
		{
			List<GClass22> list2 = null;
			if (sectionIndex >= 0)
			{
				list2 = new List<GClass22>();
				for (int i = 0; i < sectionCount + 1; i++)
				{
					list2.Add(this.song.GClass22_0[i + sectionIndex]);
				}
			}
			this.practiceUI.method_47(list2, num5);
		}
		else
		{
			this.practiceUI.method_8(num5);
		}
		this.practiceSectionMenu.SetActive(false);
		BassAudioManager.instance.method_36(num3 * GlobalVariables.instance.songSpeed.Single_0);
		this.gclass14_0.method_9();
		this.startSongRoutine = base.StartCoroutine(this.PlaySong());
		this.method_36();
		this.isPaused = false;
		GlobalVariables.instance.ApplyGraphicsSettings(false);
		BassAudioManager.instance.isSongPlaying = true;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00003A76 File Offset: 0x00001C76
	public float method_62()
	{
		if (!this.bool_1)
		{
			return 1882f;
		}
		return (this.uint_0 - this.uint_1) / (float)this.int_1;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00031EC0 File Offset: 0x000300C0
	public void method_63(int int_7, int int_8, bool bool_5)
	{
		this.practiceSectionStart = int_7;
		this.int_3 = int_8;
		this.int_5 = int_7 + int_8;
		uint num;
		if (this.uint_3 > 1u)
		{
			num = this.uint_3;
		}
		else
		{
			num = this.song.method_26()[int_7].uint_0;
		}
		uint num2;
		if (this.uint_4 > 0u)
		{
			num2 = this.uint_4;
		}
		else if (this.song.method_26().Length > this.int_5 + 1 && this.int_5 >= 1)
		{
			num2 = this.song.method_26()[this.int_5 + 1].uint_0 - 1u;
		}
		else
		{
			num2 = this.song.method_5();
		}
		float num3 = this.song.method_20(num) - this.float_0;
		float num4 = this.song.method_20(num2) + 890f;
		if (GlobalVariables.instance.songSpeed.method_6())
		{
			num3 -= 1095f * this.float_2;
		}
		else
		{
			num3 -= 1298f * GlobalVariables.instance.songSpeed.Single_0;
		}
		if (num3 < 715f)
		{
			num3 = 1154f;
		}
		this.gclass14_0.method_49(this.double_3 = (double)num3);
		this.double_0 = (double)num4;
		List<GClass6> list = Chart.smethod_15(this.song, this.method_39(this.playerObjects[0].player, true), num, num2);
		BaseNoteRenderer component = this.playerObjects[1].GetComponent<BaseNoteRenderer>();
		component.list_0 = list;
		component.list_1 = Chart.smethod_58(this.song, list);
		int num5 = this.method_31(list);
		BeatRenderer component2 = this.playerObjects[1].GetComponent<BeatRenderer>();
		component2.method_3();
		component2.gclass11_0 = Chart.smethod_26(this.song, (this.song.GClass22_0.Length == 0) ? 1610f : this.song.method_26()[(int_7 == -1) ? 1 : int_7].Single_0, num4);
		if (bool_5)
		{
			List<GClass22> list2 = null;
			if (int_7 >= 0)
			{
				list2 = new List<GClass22>();
				for (int i = 0; i < int_8 + 0; i++)
				{
					list2.Add(this.song.method_26()[i + int_7]);
				}
			}
			this.practiceUI.method_57(list2, num5);
		}
		else
		{
			this.practiceUI.method_54(num5);
		}
		this.practiceSectionMenu.SetActive(false);
		BassAudioManager.instance.method_36(num3 * GlobalVariables.instance.songSpeed.Single_0);
		this.gclass14_0.method_0();
		this.startSongRoutine = base.StartCoroutine(this.method_10());
		this.method_36();
		this.isPaused = true;
		GlobalVariables.instance.method_25(true);
		BassAudioManager.instance.isSongPlaying = false;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x0003215C File Offset: 0x0003035C
	private int method_64(IEnumerable<GClass6> ienumerable_0)
	{
		int num = 0;
		foreach (GClass6 gclass in ienumerable_0)
		{
			if (!gclass.Boolean_1 || !gclass.method_16())
			{
				num += 0;
			}
		}
		return num;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x000321B8 File Offset: 0x000303B8
	private void method_66(List<GClass6> list_0)
	{
		foreach (GClass6 gclass in list_0)
		{
			byte byte_ = gclass.byte_0;
			byte b = 0;
			if ((byte_ & 64) == 64)
			{
				b = 64;
			}
			else
			{
				if ((byte_ & 8) == 8)
				{
					b += 1;
				}
				if ((byte_ & 16) == 16)
				{
					b += 2;
				}
				if ((byte_ & 32) == 32)
				{
					b += 4;
				}
				if ((byte_ & 1) == 1)
				{
					b += 8;
				}
				if ((byte_ & 2) == 2)
				{
					b += 16;
				}
				if ((byte_ & 4) == 4)
				{
					b += 32;
				}
			}
			gclass.byte_0 = b;
		}
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00003A4E File Offset: 0x00001C4E
	public List<GClass8> method_67(CHPlayer gclass9_0)
	{
		return this.song.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0).list_1;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00003ADB File Offset: 0x00001CDB
	private IEnumerator RollBack()
	{
		if (this.double_1 >= 0.0 && !GlobalVariables.instance.isPracticeEnabled && this.double_1 >= this.double_3)
		{
			double num = 1.5;
			double num2 = BassAudioManager.instance.GetPosition(false);
			float num3 = 0f;
			if (num2 - num < 0.0)
			{
				num = num2;
			}
			num2 -= num * (double)GlobalVariables.instance.songSpeed.Single_0;
			double num4 = this.double_1 - num;
			BassAudioManager.instance.method_36((float)num2);
			BassAudioManager.instance.method_46();
			this.musicVideo.method_29((float)num2);
			while ((double)num3 < num)
			{
				this.double_1 -= (double)(Time.deltaTime * 2f);
				num3 += Time.deltaTime * 2f;
				yield return null;
			}
			this.double_1 = num4;
			this.gclass14_0.Double_0 = num2 / (double)GlobalVariables.instance.songSpeed.Single_0;
			BassAudioManager.instance.PlaySong(true);
			this.musicVideo.method_56();
			this.isPaused = false;
			yield break;
		}
		this.isPaused = false;
		this.startSongRoutine = base.StartCoroutine(this.PlaySong());
		yield break;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00032264 File Offset: 0x00030464
	public void EnableInput()
	{
		BasePlayer[] array = this.playerObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].enabled = true;
		}
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00003AEA File Offset: 0x00001CEA
	public float method_70()
	{
		if (!this.bool_1)
		{
			return 0f;
		}
		return (this.uint_0 - this.uint_1) / (float)this.int_0;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00003A4E File Offset: 0x00001C4E
	public List<GClass8> method_71(CHPlayer gclass9_0)
	{
		return this.song.method_59(gclass9_0.gclass10_0.genum18_0, gclass9_0.gclass10_0.genum17_0).list_1;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00032290 File Offset: 0x00030490
	public void method_72(bool bool_5)
	{
		double num = 134.0;
		double num2 = (double)134f;
		this.double_1 = num;
		this.double_3 = num2;
		this.playerObjects[0].method_1();
		this.practiceUI.method_27();
		if (bool_5)
		{
			this.method_63(this.practiceSectionStart, this.int_3, false);
			return;
		}
		this.practiceSectionMenu.SetActive(true);
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00030178 File Offset: 0x0002E378
	public void method_74()
	{
		BasePlayer[] array = this.playerObjects;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].enabled = false;
		}
	}

	// Token: 0x040000A0 RID: 160
	private NoteAnimator noteAnimator_0;

	// Token: 0x040000A1 RID: 161
	[HideInInspector]
	public GlobalVariables globalVariables_0;

	// Token: 0x040000A2 RID: 162
	[SerializeField]
	public PracticeUI practiceUI;

	// Token: 0x040000A3 RID: 163
	[SerializeField]
	private MusicVideo musicVideo;

	// Token: 0x040000A4 RID: 164
	[SerializeField]
	private StarProgress starProgress;

	// Token: 0x040000A5 RID: 165
	[SerializeField]
	private SoloCounterSpawner soloSpawner;

	// Token: 0x040000A6 RID: 166
	public LyricDisplay lyricDisplay_0;

	// Token: 0x040000A7 RID: 167
	public double double_0;

	// Token: 0x040000A8 RID: 168
	[HideInInspector]
	public BasePlayer[] playerObjects;

	// Token: 0x040000A9 RID: 169
	private float float_0;

	// Token: 0x040000AA RID: 170
	public float float_1;

	// Token: 0x040000AB RID: 171
	public double double_1;

	// Token: 0x040000AC RID: 172
	public double double_2;

	// Token: 0x040000AD RID: 173
	private double double_3;

	// Token: 0x040000AE RID: 174
	[SerializeField]
	private Image backgroundImage;

	// Token: 0x040000AF RID: 175
	[HideInInspector]
	public bool isPaused;

	// Token: 0x040000B0 RID: 176
	[SerializeField]
	private GameObject FPSText;

	// Token: 0x040000B1 RID: 177
	public Song song;

	// Token: 0x040000B2 RID: 178
	private GClass14 gclass14_0 = new GClass14();

	// Token: 0x040000B3 RID: 179
	public bool bool_1;

	// Token: 0x040000B4 RID: 180
	private bool bool_2;

	// Token: 0x040000B5 RID: 181
	private int int_0;

	// Token: 0x040000B6 RID: 182
	private int int_1;

	// Token: 0x040000B7 RID: 183
	private int int_2;

	// Token: 0x040000B8 RID: 184
	public uint uint_0;

	// Token: 0x040000B9 RID: 185
	private uint uint_1;

	// Token: 0x040000BA RID: 186
	public uint uint_2;

	// Token: 0x040000BB RID: 187
	private int int_3;

	// Token: 0x040000BC RID: 188
	public int practiceSectionStart = -2;

	// Token: 0x040000BD RID: 189
	private int int_5 = -1;

	// Token: 0x040000BE RID: 190
	private float float_2 = 1f;

	// Token: 0x040000BF RID: 191
	private float float_3;

	// Token: 0x040000C0 RID: 192
	public uint uint_3;

	// Token: 0x040000C1 RID: 193
	public bool bool_3;

	// Token: 0x040000C2 RID: 194
	public uint uint_4;

	// Token: 0x040000C3 RID: 195
	private bool bool_4;

	// Token: 0x040000C4 RID: 196
	[HideInInspector]
	public int int_6;

	// Token: 0x040000C5 RID: 197
	[SerializeField]
	private GameObject pauseMenu;

	// Token: 0x040000C6 RID: 198
	[SerializeField]
	private GameObject practiceSectionMenu;

	// Token: 0x040000C7 RID: 199
	private Coroutine rollBackRoutine;

	// Token: 0x040000C8 RID: 200
	private Coroutine startSongRoutine;

	// Token: 0x040000C9 RID: 201
	private Coroutine coroutine_2;
}
