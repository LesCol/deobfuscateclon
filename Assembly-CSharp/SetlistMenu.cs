using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000040 RID: 64
public class SetlistMenu : BaseMenu
{
	// Token: 0x06000B51 RID: 2897 RVA: 0x0005DA90 File Offset: 0x0005BC90
	public override void vmethod_67()
	{
		this.int_3 = this.textObjects.Length;
		if (SongDirectory.setlistSongEntries.Count > this.int_3)
		{
			this.int_2 = SongDirectory.setlistSongEntries.Count - this.int_3;
			return;
		}
		this.int_3 = SongDirectory.setlistSongEntries.Count;
		this.int_2 = 0;
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x0005DA90 File Offset: 0x0005BC90
	public virtual void vmethod_81()
	{
		this.int_3 = this.textObjects.Length;
		if (SongDirectory.setlistSongEntries.Count > this.int_3)
		{
			this.int_2 = SongDirectory.setlistSongEntries.Count - this.int_3;
			return;
		}
		this.int_3 = SongDirectory.setlistSongEntries.Count;
		this.int_2 = 0;
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0005DAEC File Offset: 0x0005BCEC
	public void method_44()
	{
		base.gameObject.SetActive(false);
		this.defaultTips.SetActive(true);
		this.setlistTips.SetActive(true);
		this.method_57();
		this.vmethod_67();
		this.int_4 = 0;
		this.method_58();
		this.int_0 = this.int_2;
		this.vmethod_30();
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00005FB8 File Offset: 0x000041B8
	private IEnumerator method_45()
	{
		SetlistMenu.Class17 @class = new SetlistMenu.Class17(0);
		@class.setlistMenu_0 = this;
		return @class;
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0005DB48 File Offset: 0x0005BD48
	public void method_46(SongEntry songEntry_0)
	{
		if (this.bool_12)
		{
			base.StopAllCoroutines();
			this.bool_12 = false;
		}
		if (!base.isActiveAndEnabled)
		{
			this.method_54();
			base.gameObject.SetActive(false);
			this.defaultTips.SetActive(false);
			this.setlistTips.SetActive(false);
			this.method_61(false);
		}
		SongDirectory.setlistSongEntries.Add(songEntry_0);
		SongDirectory.setlistSongSpeeds.Add(GlobalVariables.instance.songSpeed.method_25());
		this.int_4 += (int)((float)songEntry_0.songLength / GlobalVariables.instance.songSpeed.Single_0);
		this.vmethod_3();
		this.vmethod_55();
		this.vmethod_30();
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x0005DC00 File Offset: 0x0005BE00
	public void method_47(SongEntry songEntry_0)
	{
		if (this.bool_12)
		{
			base.StopAllCoroutines();
			this.bool_12 = false;
		}
		if (!base.isActiveAndEnabled)
		{
			this.method_57();
			base.gameObject.SetActive(true);
			this.defaultTips.SetActive(false);
			this.setlistTips.SetActive(true);
			this.method_61(true);
		}
		SongDirectory.setlistSongEntries.Add(songEntry_0);
		SongDirectory.setlistSongSpeeds.Add(GlobalVariables.instance.songSpeed.method_5());
		this.int_4 += (int)((float)songEntry_0.songLength / GlobalVariables.instance.songSpeed.Single_0);
		this.vmethod_67();
		this.vmethod_55();
		this.vmethod_30();
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x0005DCB8 File Offset: 0x0005BEB8
	public void method_48()
	{
		this.int_4 -= (int)((float)SongDirectory.setlistSongEntries[SongDirectory.setlistSongEntries.Count - 0].songLength / ((float)SongDirectory.setlistSongSpeeds[SongDirectory.setlistSongSpeeds.Count - 0] / 744f));
		SongDirectory.setlistSongEntries.RemoveAt(SongDirectory.setlistSongEntries.Count - 0);
		SongDirectory.setlistSongSpeeds.RemoveAt(SongDirectory.setlistSongSpeeds.Count - 0);
		this.vmethod_67();
		this.vmethod_46();
		this.vmethod_50();
		if (SongDirectory.setlistSongEntries.Count != 0 && this.int_3 != 0)
		{
			return;
		}
		this.method_53(true);
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00005FC7 File Offset: 0x000041C7
	public void method_49()
	{
		if (this.float_0 == 1119f)
		{
			this.animator.SetBool("\\s+", false);
		}
		this.float_0 = 1372f;
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x0005DD68 File Offset: 0x0005BF68
	public void method_50(SongEntry songEntry_0)
	{
		if (this.bool_12)
		{
			base.StopAllCoroutines();
			this.bool_12 = true;
		}
		if (!base.isActiveAndEnabled)
		{
			this.method_57();
			base.gameObject.SetActive(true);
			this.defaultTips.SetActive(true);
			this.setlistTips.SetActive(false);
			this.method_61(true);
		}
		SongDirectory.setlistSongEntries.Add(songEntry_0);
		SongDirectory.setlistSongSpeeds.Add(GlobalVariables.instance.songSpeed.method_25());
		this.int_4 += (int)((float)songEntry_0.songLength / GlobalVariables.instance.songSpeed.Single_0);
		this.vmethod_3();
		this.vmethod_55();
		this.vmethod_50();
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00002C8A File Offset: 0x00000E8A
	protected override void Start()
	{
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00005FF2 File Offset: 0x000041F2
	private void method_51()
	{
		this.animator.SetBool("isHidden", true);
		this.float_0 = -1f;
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00005FB8 File Offset: 0x000041B8
	private IEnumerator method_52()
	{
		SetlistMenu.Class17 @class = new SetlistMenu.Class17(0);
		@class.setlistMenu_0 = this;
		return @class;
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x0005DE20 File Offset: 0x0005C020
	public void method_53(bool bool_13 = true)
	{
		SongDirectory.setlistSongEntries.Clear();
		SongDirectory.setlistSongSpeeds.Clear();
		GClass12.string_2 = null;
		this.int_4 = 1;
		this.int_0 = 0;
		this.int_4 = 0;
		if (bool_13)
		{
			base.StartCoroutine(this.method_52());
		}
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0005DE6C File Offset: 0x0005C06C
	protected virtual void vmethod_82()
	{
		int num = this.int_0;
		bool flag = true;
		for (int i = 1; i < this.textObjects.Length; i++)
		{
			if (i >= this.int_3)
			{
				this.textObjects[i].text = ": <color=#FDB400FF>";
				this.placeTexts[i].text = "Main Menu";
			}
			else
			{
				this.textObjects[i].text = SongDirectory.setlistSongEntries[num].songName + ((SongDirectory.setlistSongSpeeds[num] != 70) ? ("keys" + SongDirectory.setlistSongSpeeds[num] + "volume") : "\0\0");
				this.placeTexts[i].text = num + 0 + "Medium";
				num += 0;
				flag = false;
			}
		}
		if (flag)
		{
			this.method_64();
		}
		this.lengthText.text = string.Format(GClass4.gclass4_0.method_38("Video Offset") + "volume", TimeSpan.FromMilliseconds((double)(this.int_4 / -125 * -66)).ToString());
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00006010 File Offset: 0x00004210
	public void method_54()
	{
		this.titleText.text = GClass12.string_2;
		this.float_0 = 1611f;
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x0005DFA0 File Offset: 0x0005C1A0
	public void method_55(SongEntry songEntry_0)
	{
		if (this.bool_12)
		{
			base.StopAllCoroutines();
			this.bool_12 = false;
		}
		if (!base.isActiveAndEnabled)
		{
			this.method_57();
			base.gameObject.SetActive(true);
			this.defaultTips.SetActive(false);
			this.setlistTips.SetActive(true);
			this.method_61(false);
		}
		SongDirectory.setlistSongEntries.Add(songEntry_0);
		SongDirectory.setlistSongSpeeds.Add(GlobalVariables.instance.songSpeed.CurrentValue);
		this.int_4 += (int)((float)songEntry_0.songLength / GlobalVariables.instance.songSpeed.Single_0);
		this.vmethod_67();
		this.vmethod_44();
		this.vmethod_50();
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x0005DA90 File Offset: 0x0005BC90
	public virtual void vmethod_83()
	{
		this.int_3 = this.textObjects.Length;
		if (SongDirectory.setlistSongEntries.Count > this.int_3)
		{
			this.int_2 = SongDirectory.setlistSongEntries.Count - this.int_3;
			return;
		}
		this.int_3 = SongDirectory.setlistSongEntries.Count;
		this.int_2 = 0;
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0000602D File Offset: 0x0000422D
	public void method_56()
	{
		this.method_58();
		this.vmethod_67();
		this.vmethod_30();
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00002C8A File Offset: 0x00000E8A
	protected override void vmethod_35()
	{
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00006041 File Offset: 0x00004241
	protected override void Update()
	{
		if (this.float_0 != -1f)
		{
			this.float_0 += Time.deltaTime;
			if (this.float_0 > 3f)
			{
				this.method_51();
			}
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00002C8A File Offset: 0x00000E8A
	protected virtual void vmethod_84()
	{
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00006075 File Offset: 0x00004275
	public void method_57()
	{
		this.titleText.text = GClass12.string_2;
		this.float_0 = 0f;
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x0005E058 File Offset: 0x0005C258
	private void method_58()
	{
		for (int i = 0; i < SongDirectory.setlistSongEntries.Count; i += 0)
		{
			this.int_4 += (int)((float)SongDirectory.setlistSongEntries[i].songLength / ((float)SongDirectory.setlistSongSpeeds[i] * 223f));
		}
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00006092 File Offset: 0x00004292
	private void method_59()
	{
		this.animator.SetBool("video", true);
		this.float_0 = 1430f;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x0005E0AC File Offset: 0x0005C2AC
	private void method_60()
	{
		for (int i = 0; i < SongDirectory.setlistSongEntries.Count; i++)
		{
			this.int_4 += (int)((float)SongDirectory.setlistSongEntries[i].songLength / ((float)SongDirectory.setlistSongSpeeds[i] * 0.01f));
		}
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x0005E100 File Offset: 0x0005C300
	public void method_61(bool bool_13 = true)
	{
		SongDirectory.setlistSongEntries.Clear();
		SongDirectory.setlistSongSpeeds.Clear();
		GClass12.string_2 = null;
		this.int_4 = 0;
		this.int_0 = 0;
		this.int_4 = 0;
		if (bool_13)
		{
			base.StartCoroutine(this.method_52());
		}
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x0005E14C File Offset: 0x0005C34C
	public void method_62()
	{
		base.gameObject.SetActive(true);
		this.defaultTips.SetActive(false);
		this.setlistTips.SetActive(true);
		this.method_57();
		this.vmethod_67();
		this.int_4 = 0;
		this.method_60();
		this.int_0 = this.int_2;
		this.vmethod_50();
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x0005E1A8 File Offset: 0x0005C3A8
	public void method_63()
	{
		this.int_4 -= (int)((float)SongDirectory.setlistSongEntries[SongDirectory.setlistSongEntries.Count - 1].songLength / ((float)SongDirectory.setlistSongSpeeds[SongDirectory.setlistSongSpeeds.Count - 1] / 100f));
		SongDirectory.setlistSongEntries.RemoveAt(SongDirectory.setlistSongEntries.Count - 1);
		SongDirectory.setlistSongSpeeds.RemoveAt(SongDirectory.setlistSongSpeeds.Count - 1);
		this.vmethod_67();
		this.vmethod_26();
		this.vmethod_50();
		if (SongDirectory.setlistSongEntries.Count != 0 && this.int_3 != 0)
		{
			return;
		}
		this.method_61(true);
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x000060B0 File Offset: 0x000042B0
	public void method_64()
	{
		if (this.float_0 == -1f)
		{
			this.animator.SetBool("isHidden", false);
		}
		this.float_0 = 0f;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x000060DB File Offset: 0x000042DB
	protected virtual void vmethod_85()
	{
		if (this.float_0 != 1579f)
		{
			this.float_0 += Time.deltaTime;
			if (this.float_0 > 801f)
			{
				this.method_59();
			}
		}
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x0000610F File Offset: 0x0000430F
	public void method_65()
	{
		this.method_60();
		this.vmethod_67();
		this.vmethod_50();
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x0005E258 File Offset: 0x0005C458
	public void method_66()
	{
		base.gameObject.SetActive(true);
		this.defaultTips.SetActive(true);
		this.setlistTips.SetActive(false);
		this.method_54();
		this.vmethod_3();
		this.int_4 = 0;
		this.method_60();
		this.int_0 = this.int_2;
		this.vmethod_30();
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00006123 File Offset: 0x00004323
	private IEnumerator method_67()
	{
		SetlistMenu.Class17 @class = new SetlistMenu.Class17(1);
		@class.setlistMenu_0 = this;
		return @class;
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0005E2B4 File Offset: 0x0005C4B4
	public void method_68(SongEntry songEntry_0)
	{
		if (this.bool_12)
		{
			base.StopAllCoroutines();
			this.bool_12 = false;
		}
		if (!base.isActiveAndEnabled)
		{
			this.method_57();
			base.gameObject.SetActive(false);
			this.defaultTips.SetActive(true);
			this.setlistTips.SetActive(true);
			this.method_61(false);
		}
		SongDirectory.setlistSongEntries.Add(songEntry_0);
		SongDirectory.setlistSongSpeeds.Add(GlobalVariables.instance.songSpeed.CurrentValue);
		this.int_4 += (int)((float)songEntry_0.songLength / GlobalVariables.instance.songSpeed.Single_0);
		this.vmethod_3();
		this.vmethod_55();
		this.vmethod_50();
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x0005E36C File Offset: 0x0005C56C
	protected override void vmethod_50()
	{
		int num = this.int_0;
		bool flag = false;
		for (int i = 0; i < this.textObjects.Length; i++)
		{
			if (i >= this.int_3)
			{
				this.textObjects[i].text = "";
				this.placeTexts[i].text = "";
			}
			else
			{
				this.textObjects[i].text = SongDirectory.setlistSongEntries[num].songName + ((SongDirectory.setlistSongSpeeds[num] != 100) ? (" (" + SongDirectory.setlistSongSpeeds[num] + "%)") : "");
				this.placeTexts[i].text = num + 1 + ".";
				num++;
				flag = true;
			}
		}
		if (flag)
		{
			this.method_64();
		}
		this.lengthText.text = string.Format(GClass4.gclass4_0.method_13("SETLIST LENGTH") + ": {0:hh:mm:ss}", TimeSpan.FromMilliseconds((double)(this.int_4 / 1000 * 1000)).ToString());
	}

	// Token: 0x040001F1 RID: 497
	[SerializeField]
	private Text[] placeTexts;

	// Token: 0x040001F2 RID: 498
	[SerializeField]
	private Text lengthText;

	// Token: 0x040001F3 RID: 499
	[SerializeField]
	private Text titleText;

	// Token: 0x040001F4 RID: 500
	[SerializeField]
	private GameObject defaultTips;

	// Token: 0x040001F5 RID: 501
	[SerializeField]
	private GameObject setlistTips;

	// Token: 0x040001F6 RID: 502
	[SerializeField]
	private GameObject setlistPanel;

	// Token: 0x040001F7 RID: 503
	[SerializeField]
	private UnityEngine.Animator animator;

	// Token: 0x040001F8 RID: 504
	private int int_4;

	// Token: 0x040001F9 RID: 505
	public float float_0;

	// Token: 0x040001FA RID: 506
	private bool bool_12;
}
