using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

// Token: 0x020000B2 RID: 178
public class MusicVideo : MonoBehaviour
{
	// Token: 0x0600228B RID: 8843 RVA: 0x0000FA37 File Offset: 0x0000DC37
	public void method_0(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1166f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x0000FA75 File Offset: 0x0000DC75
	public void method_1()
	{
		this.method_37(543f);
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_2()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x0000FAAC File Offset: 0x0000DCAC
	public void method_3()
	{
		this.method_30(320f);
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_4()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_5()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x0000FAB9 File Offset: 0x0000DCB9
	public void method_6(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 223f + float_1;
			this.method_73();
			return;
		}
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x0000FAEA File Offset: 0x0000DCEA
	public void method_7()
	{
		this.method_81(759f);
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_8()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x0000FAF7 File Offset: 0x0000DCF7
	public void method_9()
	{
		this.method_34(1675f);
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x0000FB04 File Offset: 0x0000DD04
	private IEnumerator method_10(float float_1)
	{
		MusicVideo.Class49 @class = new MusicVideo.Class49(0);
		@class.musicVideo_0 = this;
		@class.float_0 = float_1;
		return @class;
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x0010F9EC File Offset: 0x0010DBEC
	public void method_11()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 1389f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_48(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x0010FA48 File Offset: 0x0010DC48
	private void method_12()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = false;
		string[] array = GlobalVariables.smethod_3(GlobalVariables.instance.currentSongEntry.folderPath, "Keys - ", SearchOption.TopDirectoryOnly);
		if (GlobalVariables.instance.gclass5_36.method_14() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_0())
		{
			text = array[1];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_0())
		{
			if (GlobalVariables.instance.gclass5_19.method_25() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(0, -173));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(1, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.CurrentValue];
			}
			isLooping = true;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = true;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = true;
	}

	// Token: 0x06002298 RID: 8856 RVA: 0x0000FB1A File Offset: 0x0000DD1A
	public void method_13(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1596f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x0010FB6C File Offset: 0x0010DD6C
	private void method_14()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = true;
		string[] array = GlobalVariables.GetFiles(GlobalVariables.instance.currentSongEntry.folderPath, "drums_2", SearchOption.TopDirectoryOnly);
		if (GlobalVariables.instance.gclass5_36.method_4() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_0())
		{
			text = array[0];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_6())
		{
			if (GlobalVariables.instance.gclass5_19.method_25() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(1, 116));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(0, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.method_25()];
			}
			isLooping = false;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = false;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = false;
	}

	// Token: 0x0600229A RID: 8858 RVA: 0x0010FC90 File Offset: 0x0010DE90
	private void method_15()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = true;
		string[] array = GlobalVariables.smethod_4(GlobalVariables.instance.currentSongEntry.folderPath, "Lefty Flip", SearchOption.AllDirectories);
		if (GlobalVariables.instance.gclass5_36.method_30() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_6())
		{
			text = array[1];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_0())
		{
			if (GlobalVariables.instance.gclass5_19.CurrentValue == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(1, -137));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(1, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.method_25()];
			}
			isLooping = true;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = false;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = true;
	}

	// Token: 0x0600229B RID: 8859 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_16()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x0600229C RID: 8860 RVA: 0x0000FB58 File Offset: 0x0000DD58
	public void method_17()
	{
		this.method_41(395f);
	}

	// Token: 0x0600229D RID: 8861 RVA: 0x0000FB65 File Offset: 0x0000DD65
	private IEnumerator method_18(float float_1)
	{
		MusicVideo.Class49 @class = new MusicVideo.Class49(1);
		@class.musicVideo_0 = this;
		@class.float_0 = float_1;
		return @class;
	}

	// Token: 0x0600229E RID: 8862 RVA: 0x0000FB7B File Offset: 0x0000DD7B
	public void method_19(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 922f + float_1;
			this.method_50();
			return;
		}
	}

	// Token: 0x060022A0 RID: 8864 RVA: 0x0000FB04 File Offset: 0x0000DD04
	private IEnumerator method_21(float float_1)
	{
		MusicVideo.Class49 @class = new MusicVideo.Class49(0);
		@class.musicVideo_0 = this;
		@class.float_0 = float_1;
		return @class;
	}

	// Token: 0x060022A1 RID: 8865 RVA: 0x0000FBAC File Offset: 0x0000DDAC
	public void method_22()
	{
		this.method_81(1451f);
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x0000FB65 File Offset: 0x0000DD65
	private IEnumerator method_23(float float_1)
	{
		MusicVideo.Class49 @class = new MusicVideo.Class49(1);
		@class.musicVideo_0 = this;
		@class.float_0 = float_1;
		return @class;
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x0010FED8 File Offset: 0x0010E0D8
	public void method_24()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 1965f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_48(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x0010FF34 File Offset: 0x0010E134
	private void method_25()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = true;
		string[] array = GlobalVariables.smethod_5(GlobalVariables.instance.currentSongEntry.folderPath, "Song", SearchOption.AllDirectories);
		if (GlobalVariables.instance.gclass5_36.Boolean_1 && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = array[0];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_0())
		{
			if (GlobalVariables.instance.gclass5_19.CurrentValue == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(1, 155));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(0, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.method_25()];
			}
			isLooping = false;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = false;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = true;
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x00110058 File Offset: 0x0010E258
	private void method_26()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = false;
		string[] array = GlobalVariables.GetFiles(GlobalVariables.instance.currentSongEntry.folderPath, "volume", SearchOption.TopDirectoryOnly);
		if (GlobalVariables.instance.gclass5_36.method_30() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_0())
		{
			text = array[0];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_0())
		{
			if (GlobalVariables.instance.gclass5_19.method_25() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(1, 99));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(0, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.CurrentValue];
			}
			isLooping = true;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = false;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = false;
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x0000FBB9 File Offset: 0x0000DDB9
	public void method_27(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 239f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_28()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x0000FBF7 File Offset: 0x0000DDF7
	public void method_29(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1000f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x0000FC35 File Offset: 0x0000DE35
	public void method_30(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 1854f + float_1;
			this.method_50();
			return;
		}
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x0000FC66 File Offset: 0x0000DE66
	public void method_31()
	{
		this.method_41(339f);
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x0011017C File Offset: 0x0010E37C
	public void method_32()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 703f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_10(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x0000FC73 File Offset: 0x0000DE73
	public void method_33(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 712f + float_1;
			this.method_11();
			return;
		}
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
	public void method_34(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 1850f + float_1;
			this.method_43();
			return;
		}
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x0000FB65 File Offset: 0x0000DD65
	private IEnumerator method_35(float float_1)
	{
		MusicVideo.Class49 @class = new MusicVideo.Class49(1);
		@class.musicVideo_0 = this;
		@class.float_0 = float_1;
		return @class;
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x001101D8 File Offset: 0x0010E3D8
	public void method_36()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 1247f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_35(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x0000FCD5 File Offset: 0x0000DED5
	public void method_37(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 1000f + float_1;
			this.method_56();
			return;
		}
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_38()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x0000FD06 File Offset: 0x0000DF06
	public void method_39(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 722f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x0000FD44 File Offset: 0x0000DF44
	public void method_40()
	{
		this.method_80(1773f);
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x0000FD51 File Offset: 0x0000DF51
	public void method_41(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 1184f + float_1;
			this.method_86();
			return;
		}
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x00110358 File Offset: 0x0010E558
	public void method_43()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 855f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_48(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x0000FD82 File Offset: 0x0000DF82
	public void method_44(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 680f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
	public void method_45(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 1124f + float_1;
			this.method_56();
			return;
		}
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x0000FDF1 File Offset: 0x0000DFF1
	public void method_46(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1270f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022BA RID: 8890 RVA: 0x0000FE2F File Offset: 0x0000E02F
	public void method_47()
	{
		this.method_84(1724f);
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x0000FB04 File Offset: 0x0000DD04
	private IEnumerator method_48(float float_1)
	{
		MusicVideo.Class49 @class = new MusicVideo.Class49(0);
		@class.musicVideo_0 = this;
		@class.float_0 = float_1;
		return @class;
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_49()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x001103B4 File Offset: 0x0010E5B4
	public void method_50()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 1107f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_48(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022BE RID: 8894 RVA: 0x00110410 File Offset: 0x0010E610
	public void method_51()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 1059f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_48(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022BF RID: 8895 RVA: 0x0000FE3C File Offset: 0x0000E03C
	public void method_52()
	{
		this.method_80(337f);
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x0000FB04 File Offset: 0x0000DD04
	private IEnumerator method_53(float float_1)
	{
		MusicVideo.Class49 @class = new MusicVideo.Class49(0);
		@class.musicVideo_0 = this;
		@class.float_0 = float_1;
		return @class;
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x0011046C File Offset: 0x0010E66C
	private void method_54()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = true;
		string[] array = GlobalVariables.smethod_5(GlobalVariables.instance.currentSongEntry.folderPath, "Stars Earned", SearchOption.AllDirectories);
		if (GlobalVariables.instance.gclass5_36.method_30() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_23())
		{
			text = array[1];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_6())
		{
			if (GlobalVariables.instance.gclass5_19.method_5() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(1, 151));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(1, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.CurrentValue];
			}
			isLooping = false;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = true;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = true;
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x0000FE49 File Offset: 0x0000E049
	public void method_55(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 465f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x00110590 File Offset: 0x0010E790
	public void method_56()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 0f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_53(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x001105EC File Offset: 0x0010E7EC
	public void method_57()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 886f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_48(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x0000FE87 File Offset: 0x0000E087
	public void method_58()
	{
		this.method_71(127f);
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x00110648 File Offset: 0x0010E848
	public void method_59()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 648f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_21(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x001106A4 File Offset: 0x0010E8A4
	private void method_60()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = true;
		string[] array = GlobalVariables.smethod_3(GlobalVariables.instance.currentSongEntry.folderPath, "events", SearchOption.TopDirectoryOnly);
		if (GlobalVariables.instance.gclass5_36.method_4() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_6())
		{
			text = array[0];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_23())
		{
			if (GlobalVariables.instance.gclass5_19.method_25() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(0, -72));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(1, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.CurrentValue];
			}
			isLooping = true;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = true;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = false;
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x001107C8 File Offset: 0x0010E9C8
	public void method_61()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 1865f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_35(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x0000FE94 File Offset: 0x0000E094
	public void method_62()
	{
		this.method_41(170f);
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x00110824 File Offset: 0x0010EA24
	public void method_63()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 400f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_35(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_64()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x001109A4 File Offset: 0x0010EBA4
	private void method_66()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = false;
		string[] array = GlobalVariables.smethod_3(GlobalVariables.instance.currentSongEntry.folderPath, "Quit", SearchOption.TopDirectoryOnly);
		if (GlobalVariables.instance.gclass5_36.method_14() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_23())
		{
			text = array[1];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_23())
		{
			if (GlobalVariables.instance.gclass5_19.method_5() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(0, -8));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(0, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.CurrentValue];
			}
			isLooping = false;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = true;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = true;
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x0000FEA1 File Offset: 0x0000E0A1
	public void method_67(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1677f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x0000FEDF File Offset: 0x0000E0DF
	public void method_68(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1119f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x0000FF1D File Offset: 0x0000E11D
	public void method_69(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 157f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x00110AC8 File Offset: 0x0010ECC8
	private void method_70()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = true;
		string[] array = GlobalVariables.smethod_4(GlobalVariables.instance.currentSongEntry.folderPath, "Medium", SearchOption.AllDirectories);
		if (GlobalVariables.instance.gclass5_36.method_4() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = array[0];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_23())
		{
			if (GlobalVariables.instance.gclass5_19.method_25() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(1, -168));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(1, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.method_25()];
			}
			isLooping = true;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = false;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = true;
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x0000FF5B File Offset: 0x0000E15B
	public void method_71(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 604f + float_1;
			this.method_57();
			return;
		}
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x00110BEC File Offset: 0x0010EDEC
	private void method_72()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = false;
		string[] array = GlobalVariables.smethod_3(GlobalVariables.instance.currentSongEntry.folderPath, ".ogg", SearchOption.TopDirectoryOnly);
		if (GlobalVariables.instance.gclass5_36.method_30() && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.method_23())
		{
			text = array[1];
		}
		else if (!GlobalVariables.instance.gclass5_19.method_23())
		{
			if (GlobalVariables.instance.gclass5_19.method_5() == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(0, -107));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(1, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.method_5()];
			}
			isLooping = false;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = false;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = false;
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x00110D10 File Offset: 0x0010EF10
	public void method_73()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 954f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_18(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x0000FF8C File Offset: 0x0000E18C
	public void method_74(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1250f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x00110D6C File Offset: 0x0010EF6C
	private void Start()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			return;
		}
		string text = null;
		bool isLooping = false;
		string[] array = GlobalVariables.smethod_4(GlobalVariables.instance.currentSongEntry.folderPath, ".mp4|.avi|.webm|.vp8|.ogv|.mpeg", SearchOption.AllDirectories);
		if (GlobalVariables.instance.gclass5_36.Boolean_1 && array != null && array.Length != 0 && GlobalVariables.instance.songSpeed.Boolean_0)
		{
			text = array[0];
		}
		else if (!GlobalVariables.instance.gclass5_19.Boolean_0)
		{
			if (GlobalVariables.instance.gclass5_19.CurrentValue == -1)
			{
				UnityEngine.Random.InitState(UnityEngine.Random.Range(0, int.MaxValue));
				text = GlobalVariables.instance.backgroungVideoPaths[UnityEngine.Random.Range(0, GlobalVariables.instance.backgroungVideoPaths.Length)];
			}
			else
			{
				text = GlobalVariables.instance.backgroungVideoPaths[GlobalVariables.instance.gclass5_19.CurrentValue];
			}
			isLooping = true;
		}
		if (!File.Exists(text))
		{
			return;
		}
		base.GetComponent<Image>().enabled = false;
		this.videoPlayer_0 = base.GetComponent<VideoPlayer>();
		this.videoPlayer_0.url = text;
		this.videoPlayer_0.Prepare();
		this.videoPlayer_0.isLooping = isLooping;
		this.bool_0 = true;
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void method_75()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x00110FB4 File Offset: 0x0010F1B4
	public void method_77()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 248f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_10(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x00111010 File Offset: 0x0010F210
	public void method_78()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 634f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_35(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x0011106C File Offset: 0x0010F26C
	public void method_79()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 163f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_21(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x0000FFCA File Offset: 0x0000E1CA
	public void method_80(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 771f + float_1;
			this.method_77();
			return;
		}
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x0000FFFB File Offset: 0x0000E1FB
	public void method_81(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 155f + float_1;
			this.method_59();
			return;
		}
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x0000FA82 File Offset: 0x0000DC82
	public void Pause()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.videoPlayer_0.Pause();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x0001002C File Offset: 0x0000E22C
	public void method_84(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 498f + float_1;
			this.method_79();
			return;
		}
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x0001005D File Offset: 0x0000E25D
	public void method_85(float float_1)
	{
		if (this.bool_0 && !GlobalVariables.instance.isPracticeEnabled)
		{
			this.float_0 = (float)SongEntry.videoStart / 307f + float_1;
			this.method_61();
			return;
		}
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x001111EC File Offset: 0x0010F3EC
	public void method_86()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.float_0 < 637f)
		{
			this.coroutine_0 = base.StartCoroutine(this.method_35(this.float_0));
			return;
		}
		this.videoPlayer_0.time = (double)this.float_0;
		this.videoPlayer_0.Play();
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x0001008E File Offset: 0x0000E28E
	public void method_87()
	{
		this.method_37(1801f);
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x0001009B File Offset: 0x0000E29B
	public void method_88()
	{
		this.method_37(0f);
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x000100A8 File Offset: 0x0000E2A8
	public void method_89(float float_1)
	{
		if (this.bool_0 && !this.videoPlayer_0.isLooping)
		{
			this.float_0 = (float)SongEntry.videoStart / 1377f + float_1;
			this.videoPlayer_0.time = (double)this.float_0;
			return;
		}
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x000100E6 File Offset: 0x0000E2E6
	public void method_90()
	{
		this.method_45(963f);
	}

	// Token: 0x0400057B RID: 1403
	private VideoPlayer videoPlayer_0;

	// Token: 0x0400057C RID: 1404
	private bool bool_0;

	// Token: 0x0400057D RID: 1405
	private float float_0;

	// Token: 0x0400057E RID: 1406
	private Coroutine coroutine_0;
}
