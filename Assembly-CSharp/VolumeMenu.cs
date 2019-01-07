using System;
using Un4seen.Bass;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000052 RID: 82
public class VolumeMenu : BaseMenu
{
	// Token: 0x06000F53 RID: 3923 RVA: 0x00008978 File Offset: 0x00006B78
	public virtual void vmethod_81()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_69();
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x000089A6 File Offset: 0x00006BA6
	public virtual void vmethod_82()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_54();
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00071530 File Offset: 0x0006F730
	private void method_44()
	{
		if (this.string_0 == "volume")
		{
			BassAudioManager.instance.method_10();
			BassAudioManager.instance.method_1(GlobalVariables.instance.volume_MenuMusic.Int32_2);
			return;
		}
		if (this.string_0 == " (")
		{
			BassAudioManager.instance.method_10();
			return;
		}
		if (this.string_0 == "[^\\u0020-\\u007E]")
		{
			BassAudioManager.instance.method_40(this.gclass5_0.Int32_2);
			return;
		}
		if (this.string_0 == "particles")
		{
			BassAudioManager.instance.method_56(true);
			BassAudioManager.instance.PlayMenuMusic();
			return;
		}
		if (this.string_0 == "Song Length")
		{
			BassAudioManager.instance.method_56(false);
			BassAudioManager.instance.OnApplicationQuit();
			BassAudioManager.instance.method_48(-1);
			BassAudioManager.instance.PlayMenuMusic();
		}
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x000089C2 File Offset: 0x00006BC2
	public virtual void vmethod_83()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_29();
		this.optionsMenu.bool_10 = false;
		this.method_67();
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0007161C File Offset: 0x0006F81C
	private void method_45()
	{
		if (this.string_0 == "Yes")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[1].name;
			return;
		}
		if (this.string_0 == "crowd")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_10();
			BassAudioManager.instance.method_11(0);
			return;
		}
		if (this.string_0 == "delay")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_0(this.gclass5_0.method_5()).ToString();
			return;
		}
		string string_ = this.gclass5_0.String_1;
		this.textObjects[this.int_1].text = string_;
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x000089F0 File Offset: 0x00006BF0
	public virtual void vmethod_84()
	{
		if (this.string_0 != null)
		{
			this.method_71();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00008A25 File Offset: 0x00006C25
	public override void vmethod_68()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_52();
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00008A41 File Offset: 0x00006C41
	public virtual void vmethod_85()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = true;
		this.method_45();
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00008A6F File Offset: 0x00006C6F
	public virtual void vmethod_86()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_67();
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00008A8B File Offset: 0x00006C8B
	private void method_47()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_15("lyric");
		}
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00008AB4 File Offset: 0x00006CB4
	public virtual void vmethod_88()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_56();
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00008AD0 File Offset: 0x00006CD0
	public virtual void vmethod_89()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_29();
		this.optionsMenu.bool_10 = false;
		this.method_55();
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00008AFE File Offset: 0x00006CFE
	public virtual void vmethod_90()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_60();
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00008B2C File Offset: 0x00006D2C
	public virtual void vmethod_91()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_45();
	}
    
	// Token: 0x06000F64 RID: 3940 RVA: 0x00008B48 File Offset: 0x00006D48
	private void method_48()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_42("<");
		}
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00008B71 File Offset: 0x00006D71
	public virtual void vmethod_93()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_56();
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00071E7C File Offset: 0x0007007C
	private void method_49()
	{
		if (this.string_0 == "Master Volume")
		{
			BassAudioManager.instance.method_10();
			BassAudioManager.instance.SetGlobalVolume(GlobalVariables.instance.volume_MenuMusic.Int32_2);
			return;
		}
		if (this.string_0 == "Sound Effects")
		{
			BassAudioManager.instance.method_10();
			return;
		}
		if (this.string_0 == "Menu Music")
		{
			BassAudioManager.instance.SetGlobalVolume(this.gclass5_0.Int32_2);
			return;
		}
		if (this.string_0 == "Low Latency Mode")
		{
			BassAudioManager.instance.method_56(true);
			BassAudioManager.instance.PlayMenuMusic();
			return;
		}
		if (this.string_0 == "Audio Backend")
		{
			BassAudioManager.instance.method_56(true);
			BassAudioManager.instance.OnApplicationQuit();
			BassAudioManager.instance.Init(-1);
			BassAudioManager.instance.PlayMenuMusic();
		}
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00008B9F File Offset: 0x00006D9F
	public virtual void vmethod_94()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_60();
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00008BCD File Offset: 0x00006DCD
	public virtual void vmethod_95()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_63();
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00008BE9 File Offset: 0x00006DE9
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			this.method_49();
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00008C1E File Offset: 0x00006E1E
	public virtual void vmethod_96()
	{
		if (this.string_0 != null)
		{
			this.method_49();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00008C53 File Offset: 0x00006E53
	public virtual void vmethod_98()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_63();
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00008C81 File Offset: 0x00006E81
	public virtual void vmethod_100()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_29();
		this.optionsMenu.bool_10 = false;
		this.method_69();
	}
    
	// Token: 0x06000F73 RID: 3955 RVA: 0x000727D8 File Offset: 0x000709D8
	private void method_52()
	{
		if (this.string_0 == "Audio Device")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[1].name;
			return;
		}
		if (this.string_0 == "Low Latency Mode")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.String_0;
			BassAudioManager.instance.method_11(0);
			return;
		}
		if (this.string_0 == "Audio Backend")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.CurrentValue).ToString();
			return;
		}
		string string_ = this.gclass5_0.String_1;
		this.textObjects[this.int_1].text = string_;
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x000729A0 File Offset: 0x00070BA0
	private void method_54()
	{
		if (this.string_0 == "Export Song List")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[0].name;
			return;
		}
		if (this.string_0 == "")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.String_0;
			BassAudioManager.instance.method_2(0);
			return;
		}
		if (this.string_0 == "Song Speed")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.CurrentValue).ToString();
			return;
		}
		string text = this.gclass5_0.method_1();
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00072A7C File Offset: 0x00070C7C
	private void method_55()
	{
		if (this.string_0 == "Volume")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[1].name;
			return;
		}
		if (this.string_0 == "")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_9();
			BassAudioManager.instance.method_11(0);
			return;
		}
		if (this.string_0 == "</color>")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.method_25()).ToString();
			return;
		}
		string string_ = this.gclass5_0.String_1;
		this.textObjects[this.int_1].text = string_;
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00008D12 File Offset: 0x00006F12
	public virtual void vmethod_103()
	{
		if (this.string_0 != null)
		{
			this.method_57();
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00072B58 File Offset: 0x00070D58
	private void method_56()
	{
		if (this.string_0 == "Play Count")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[1].name;
			return;
		}
		if (this.string_0 == "No scores saved for this song on")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_9();
			BassAudioManager.instance.method_2(1);
			return;
		}
		if (this.string_0 == "debug_fps")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.CurrentValue).ToString();
			return;
		}
		string text = this.gclass5_0.method_28();
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00008D47 File Offset: 0x00006F47
	public virtual void vmethod_104()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_55();
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00008AB4 File Offset: 0x00006CB4
	public virtual void vmethod_105()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_56();
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00008D75 File Offset: 0x00006F75
	public virtual void vmethod_106()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_60();
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00008D91 File Offset: 0x00006F91
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_52();
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x00072C34 File Offset: 0x00070E34
	private void method_57()
	{
		if (this.string_0 == "game")
		{
			BassAudioManager.instance.method_10();
			BassAudioManager.instance.method_1(GlobalVariables.instance.volume_MenuMusic.method_8());
			return;
		}
		if (this.string_0 == "Song Offset")
		{
			BassAudioManager.instance.method_10();
			return;
		}
		if (this.string_0 == "lowlatency_enabled")
		{
			BassAudioManager.instance.SetGlobalVolume(this.gclass5_0.method_8());
			return;
		}
		if (this.string_0 == "Gameplay")
		{
			BassAudioManager.instance.method_56(false);
			BassAudioManager.instance.PlayMenuMusic();
			return;
		}
		if (this.string_0 == "Unknown Album")
		{
			BassAudioManager.instance.method_56(true);
			BassAudioManager.instance.OnApplicationQuit();
			BassAudioManager.instance.Init(-1);
			BassAudioManager.instance.PlayMenuMusic();
		}
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00008DF4 File Offset: 0x00006FF4
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_52();
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00008E22 File Offset: 0x00007022
	private void method_59()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_41("song");
		}
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00008E4B File Offset: 0x0000704B
	private void Awake()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_13("VOLUME");
		}
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00008E74 File Offset: 0x00007074
	public virtual void vmethod_109()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_69();
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00073158 File Offset: 0x00071358
	private void method_60()
	{
		if (this.string_0 == ".setlist")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[1].name;
			return;
		}
		if (this.string_0 == "Show in Finder")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_9();
			BassAudioManager.instance.method_2(1);
			return;
		}
		if (this.string_0 == "Bass Guitar")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.CurrentValue).ToString();
			return;
		}
		string string_ = this.gclass5_0.String_1;
		this.textObjects[this.int_1].text = string_;
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00008E90 File Offset: 0x00007090
	public virtual void vmethod_110()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = false;
		this.method_52();
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00008D75 File Offset: 0x00006F75
	public virtual void vmethod_111()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_60();
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00008EBE File Offset: 0x000070BE
	private void method_61()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_41("full_playlist");
		}
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00008EE7 File Offset: 0x000070E7
	private void method_62()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_16("Date Added");
		}
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x000738CC File Offset: 0x00071ACC
	private void method_63()
	{
		if (this.string_0 == "volume")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[0].name;
			return;
		}
		if (this.string_0 == "errors.txt")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.String_0;
			BassAudioManager.instance.method_11(0);
			return;
		}
		if (this.string_0 == "Menu Music")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.method_25()).ToString();
			return;
		}
		string text = this.gclass5_0.method_26();
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00008F10 File Offset: 0x00007110
	public virtual void vmethod_115()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_75();
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00008F2C File Offset: 0x0000712C
	private void method_65()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_11("custom_song_export");
		}
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00008F55 File Offset: 0x00007155
	public virtual void vmethod_117()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_55();
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00008F83 File Offset: 0x00007183
	public virtual void vmethod_118()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_55();
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00074564 File Offset: 0x00072764
	private void method_67()
	{
		if (this.string_0 == "=")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[0].name;
			return;
		}
		if (this.string_0 == "Set A Position")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_10();
			BassAudioManager.instance.method_11(1);
			return;
		}
		if (this.string_0 == "ui_rewind_highway_sound")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.CurrentValue).ToString();
			return;
		}
		string text = this.gclass5_0.method_1();
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00008A25 File Offset: 0x00006C25
	public virtual void vmethod_119()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_52();
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00008F9F File Offset: 0x0000719F
	public virtual void vmethod_120()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_52();
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00008FCD File Offset: 0x000071CD
	public virtual void vmethod_121()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = true;
		this.method_67();
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00008FFB File Offset: 0x000071FB
	public virtual void vmethod_124()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_29();
		this.optionsMenu.bool_10 = false;
		this.method_54();
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00009029 File Offset: 0x00007229
	public virtual void vmethod_126()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_56();
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x000089A6 File Offset: 0x00006BA6
	public virtual void vmethod_127()
	{
		if (this.gclass5_0 == null)
		{
			return;
		}
		this.gclass5_0.method_17();
		this.method_54();
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0000908C File Offset: 0x0000728C
	public virtual void vmethod_131()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_56();
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x000757A8 File Offset: 0x000739A8
	private void method_69()
	{
		if (this.string_0 == "Pause")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[0].name;
			return;
		}
		if (this.string_0 == "Create Setlist")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.String_0;
			BassAudioManager.instance.method_2(1);
			return;
		}
		if (this.string_0 == "Connecting to server...\nServer: ")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.method_5()).ToString();
			return;
		}
		string text = this.gclass5_0.method_1();
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x000090EF File Offset: 0x000072EF
	private void method_70()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_46("Controller");
		}
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00075884 File Offset: 0x00073A84
	private void method_71()
	{
		if (this.string_0 == "</color> ")
		{
			BassAudioManager.instance.method_10();
			BassAudioManager.instance.method_1(GlobalVariables.instance.volume_MenuMusic.method_18());
			return;
		}
		if (this.string_0 == "scores_backup.bin")
		{
			BassAudioManager.instance.method_10();
			return;
		}
		if (this.string_0 == "star_release")
		{
			BassAudioManager.instance.SetGlobalVolume(this.gclass5_0.method_18());
			return;
		}
		if (this.string_0 == "")
		{
			BassAudioManager.instance.method_56(false);
			BassAudioManager.instance.PlayMenuMusic();
			return;
		}
		if (this.string_0 == "Mirror Mode")
		{
			BassAudioManager.instance.method_56(false);
			BassAudioManager.instance.OnApplicationQuit();
			BassAudioManager.instance.method_26(-1);
			BassAudioManager.instance.PlayMenuMusic();
		}
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00009118 File Offset: 0x00007318
	public virtual void vmethod_133()
	{
		if (this.string_0 != null)
		{
			this.method_57();
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0000914D File Offset: 0x0000734D
	private void method_73()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_48("album.jpg");
		}
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00075A5C File Offset: 0x00073C5C
	private void method_74()
	{
		if (this.string_0 == "\"")
		{
			BassAudioManager.instance.method_10();
			BassAudioManager.instance.method_40(GlobalVariables.instance.volume_MenuMusic.Int32_2);
			return;
		}
		if (this.string_0 == "song_export")
		{
			BassAudioManager.instance.method_10();
			return;
		}
		if (this.string_0 == "song_preview")
		{
			BassAudioManager.instance.method_1(this.gclass5_0.Int32_2);
			return;
		}
		if (this.string_0 == "icon")
		{
			BassAudioManager.instance.method_56(true);
			BassAudioManager.instance.PlayMenuMusic();
			return;
		}
		if (this.string_0 == "")
		{
			BassAudioManager.instance.method_56(false);
			BassAudioManager.instance.OnApplicationQuit();
			BassAudioManager.instance.method_26(-1);
			BassAudioManager.instance.PlayMenuMusic();
		}
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00075B48 File Offset: 0x00073D48
	private void method_75()
	{
		if (this.string_0 == "volume")
		{
			this.textObjects[this.int_1].text = Bass.BASS_GetDeviceInfos()[1].name;
			return;
		}
		if (this.string_0 == "phrase_start")
		{
			this.textObjects[this.int_1].text = this.gclass5_0.method_10();
			BassAudioManager.instance.method_11(1);
			return;
		}
		if (this.string_0 == "")
		{
			this.textObjects[this.int_1].text = BassAudioManager.smethod_1(this.gclass5_0.method_25()).ToString();
			return;
		}
		string text = this.gclass5_0.method_28();
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x000091AB File Offset: 0x000073AB
	private void method_76()
	{
		if (this.pausedText)
		{
			this.pausedText.text = GClass4.gclass4_0.method_46("game");
		}
	}

	// Token: 0x0400024B RID: 587
	[SerializeField]
	private BaseMenu optionsMenu;

	// Token: 0x0400024C RID: 588
	[SerializeField]
	private Text pausedText;
}
