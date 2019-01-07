using System;
using System.Collections;
using System.IO;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000004 RID: 4
public class BassAudioManager : MonoBehaviour
{
	
	// Token: 0x0600008E RID: 142 RVA: 0x0000298D File Offset: 0x00000B8D
	public void method_1(int int_2)
	{
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATEPERIOD, GlobalVariables.instance.gclass5_14.CurrentValue * ((int_2 != -1) ? int_2 : -25));
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000029AF File Offset: 0x00000BAF
	public void method_2(int int_2 = 0)
	{
		if (!GlobalVariables.instance.gclass5_8.method_30())
		{
			Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATEPERIOD, 21);
		}
		else
		{
			Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_BUFFER, -164);
		}
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_SRC_SAMPLE, int_2);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x000029E5 File Offset: 0x00000BE5
	public void method_4()
	{
		this.method_34(BassAudioManager.GEnum0.LoseMultiplier);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00019990 File Offset: 0x00017B90
	public void method_6(float float_1)
	{
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if (this.stemChannels[i] != 0)
			{
				Bass.BASS_ChannelSetAttribute(this.stemChannels[i], (BASSAttribute)(-41), float_1);
			}
		}
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000029EF File Offset: 0x00000BEF
	public void method_7()
	{
		this.method_34(BassAudioManager.GEnum0.Beginning);
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00019AF8 File Offset: 0x00017CF8
	public double GetPosition()
	{
		if (this.isSongLoaded)
		{
		    long pos = Bass.BASS_ChannelGetPosition(this.linkedChannel);
			return Bass.BASS_ChannelBytes2Seconds(this.linkedChannel, pos);
		}
		return 0.0;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00019B50 File Offset: 0x00017D50
	public void method_10()
	{
		int newvalue = (int)(GlobalVariables.instance.gclass5_14.Single_0 * GlobalVariables.instance.volume_SoundEffects.Single_0 * 10000f);
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_SAMPLE, newvalue);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000029F8 File Offset: 0x00000BF8
	public void OnApplicationQuit()
	{
		this.method_16();
		this.method_47();
		Bass.BASS_Free();
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002A0C File Offset: 0x00000C0C
	public void method_11(int int_2 = 0)
	{
		if (!GlobalVariables.instance.gclass5_8.Boolean_1)
		{
			Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_BUFFER, 4410);
		}
		else
		{
			Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_BUFFER, 341);
		}
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_ASYNCFILE_BUFFER, int_2);
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00019B8C File Offset: 0x00017D8C
	public void Init(int audioDevice = -1)
	{
		Debug.Log(Bass.BASS_GetVersion());
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_DEV_DEFAULT, true);
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, 1);
		Debug.Log(BassAudioManager.smethod_1(GlobalVariables.instance.gclass5_9.CurrentValue));
		if (!Bass.BASS_Init(audioDevice, 44100, (BASSInit)((BassAudioManager.GEnum1)256 | BassAudioManager.smethod_1(GlobalVariables.instance.gclass5_9.CurrentValue)), IntPtr.Zero))
		{
			Debug.Log(Bass.BASS_ErrorGetCode());
		}
		else
		{
			this.isInitialized = true;
		}
		this.method_11(524288);
		this.stemChannels = new int[BassAudioManager.stemPaths.Length];
		this.method_57();
		this.SetGlobalVolume(-1);
		this.method_10();
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00019C4C File Offset: 0x00017E4C
	public void method_13()
	{
		if (this.songEntry_0 == null)
		{
			return;
		}
		GameObject.Find("NowPlaying").GetComponent<Text>().text = string.Concat(new string[]
		{
			GClass4.gclass4_0.method_13("Now Playing (Press Select to play)"),
			":\n",
			this.songEntry_0.songName,
			"\n",
			this.songEntry_0.artistName
		});
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00019D14 File Offset: 0x00017F14
	public string method_15(string fileName, int specificContainer)
	{
		for (int i = (specificContainer == -1) ? 0 : specificContainer; i < BassAudioManager.containerTypes.Length; i++)
		{
			string text = fileName + BassAudioManager.containerTypes[i];
			if (File.Exists(text))
			{
				return text;
			}
			if (specificContainer != -1)
			{
                break;
			}
		}
        return null;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00019D5C File Offset: 0x00017F5C
	private void method_16()
	{
		this.bool_1 = false;
		for (int i = 0; i < this.struct0_0.Length; i++)
		{
			if (this.struct0_0[i].int_0 != 0)
			{
				Bass.BASS_SampleFree(this.struct0_0[i].int_0);
			}
		}
		this.struct0_0 = null;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00019DB4 File Offset: 0x00017FB4
	public void method_17(Song.Instrument genum18_0, bool bool_11)
	{
		if (!this.bool_7 || !GlobalVariables.instance.gclass5_31.Boolean_1)
		{
			return;
		}
		GStruct1 gstruct = this.method_38(genum18_0);
		if (gstruct.int_0 == -1)
		{
			return;
		}
		while (gstruct.int_0 <= gstruct.int_1)
		{
			int num = this.stemChannels[gstruct.int_0];
			float value = bool_11 ? GlobalVariables.instance.volume_Stems[gstruct.int_0].Single_0 : GlobalVariables.instance.gclass5_15.Single_0;
			if (num != 0)
			{
				Bass.BASS_ChannelSetAttribute(num, BASSAttribute.BASS_ATTRIB_VOL, value);
			}
			gstruct.int_0++;
		}
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00019E50 File Offset: 0x00018050
	public void PlaySong()
	{
		if (this.isSongLoaded && !this.bool_2)
		{
			return;
		}
        this.SetGlobalVolume(-1);
        this.method_50(-1);
        Bass.BASS_ChannelPlay(this.linkedChannel, false);
        this.isSongPlaying = true;
        this.isSongFading = false;
        this.isSongPaused = false;
    }

	// Token: 0x060000A4 RID: 164 RVA: 0x00002A5A File Offset: 0x00000C5A
	public void method_20()
	{
		this.method_34(BassAudioManager.GEnum0.SongFail);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00019EF8 File Offset: 0x000180F8
	public void method_21()
	{
		BASS_DX8_REVERB par = new BASS_DX8_REVERB(608f, 929f, 250f, 1615f);
		Bass.BASS_FXSetParameters(this.stemChannels[1], par);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00019F30 File Offset: 0x00018130
	public void method_22()
	{
		if (this.songEntry_0 == null)
		{
			return;
		}
		Text component = GameObject.Find("Medium").GetComponent<Text>();
		string[] array = new string[4];
		array[1] = GClass4.gclass4_0.method_16("");
		array[1] = "Low Latency Mode";
		array[0] = this.songEntry_0.songName;
		array[2] = "song";
		array[8] = this.songEntry_0.artistName;
		component.text = string.Concat(array);
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002A64 File Offset: 0x00000C64
	public void method_23()
	{
		this.method_34(BassAudioManager.GEnum0.OverStrum1);
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00019FA4 File Offset: 0x000181A4
	private void method_24()
	{
		if (this.struct0_0 != null)
		{
			Debug.LogError("Tried to initialize the already initialized sound effects!");
			return;
		}
		this.struct0_0 = new BassAudioManager.Struct0[Enum.GetNames(typeof(BassAudioManager.GEnum0)).Length];
		this.struct0_0[0] = new BassAudioManager.Struct0("notes_ripple_up_01", 1f);
		this.struct0_0[1] = new BassAudioManager.Struct0("sp_awarded", 0.5f);
		this.struct0_0[2] = new BassAudioManager.Struct0("star_available", 0.5f);
		this.struct0_0[3] = new BassAudioManager.Struct0("star_deployed", 0.2f);
		this.struct0_0[4] = new BassAudioManager.Struct0("star_release", 0.5f);
		this.struct0_0[5] = new BassAudioManager.Struct0("bad_note1", 0.5f);
		this.struct0_0[6] = new BassAudioManager.Struct0("bad_note2", 0.5f);
		this.struct0_0[7] = new BassAudioManager.Struct0("bad_note3", 0.5f);
		this.struct0_0[8] = new BassAudioManager.Struct0("bad_note4", 0.5f);
		this.struct0_0[9] = new BassAudioManager.Struct0("bad_note5", 0.5f);
		this.struct0_0[10] = new BassAudioManager.Struct0("ui_lose_multiplier", 0.7f);
		this.struct0_0[11] = new BassAudioManager.Struct0("ui_rewind_highway_sound", 1f);
		this.struct0_0[12] = new BassAudioManager.Struct0("gh3_sudden_death", 1f);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0001A144 File Offset: 0x00018344
	public void LoadSong(string songFolder, bool isSpedUp, Song.Instrument excludedInstruments = Song.Instrument.None, Song.Instrument excludedInstruments2 = Song.Instrument.None)
	{
		this.method_47();
		if (!Directory.Exists(songFolder))
		{
			return;
		}
		int num = 0;
		this.bool_7 = false;
		this.bool_2 = false;
		GStruct1 gstruct = this.method_38(excludedInstruments);
		GStruct1 gstruct2 = this.method_38(excludedInstruments2);
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if ((i < gstruct.int_0 || i > gstruct.int_1) && (i < gstruct2.int_0 || i > gstruct2.int_1))
			{
				string text = this.method_15(Path.Combine(songFolder, BassAudioManager.stemPaths[i]), -1);
				if (text != null)
				{
					int num2 = Bass.BASS_StreamCreateFile(text, 0L, 0L, BASSFlag.BASS_STREAM_PRESCAN | BASSFlag.BASS_STREAM_DECODE | BASSFlag.BASS_ASYNCFILE);
					if (num2 == 0)
					{
						this.stemChannels[i] = 0;
					}
					else
					{
						if (i < BassAudioManager.stemPaths.Length - 1)
						{
							num++;
						}
						this.stemChannels[i] = BassFx.BASS_FX_TempoCreate(num2, BASSFlag.BASS_SAMPLE_OVER_VOL);
						Bass.BASS_ChannelSetAttribute(this.stemChannels[i], BASSAttribute.BASS_ATTRIB_TEMPO, (float)(isSpedUp ? (GlobalVariables.instance.songSpeed.CurrentValue - 100) : 1));
						long pos = Bass.BASS_ChannelGetLength(this.stemChannels[i]);
						double num3 = Bass.BASS_ChannelBytes2Seconds(this.stemChannels[i], pos);
						if (num3 > this.double_0)
						{
							this.linkedChannel = this.stemChannels[i];
							this.double_0 = num3;
						}
					}
				}
			}
		}
		for (int j = 0; j < this.stemChannels.Length; j++)
		{
			if (this.stemChannels[j] != this.linkedChannel)
			{
				Bass.BASS_ChannelSetLink(this.linkedChannel, this.stemChannels[j]);
			}
		}
		if (this.stemChannels[1] == 0)
		{
			this.stemChannels[1] = this.stemChannels[2];
			this.stemChannels[2] = 0;
		}
		if (num > 1)
		{
			this.bool_7 = true;
		}
		this.isSongLoaded = true;
		this.double_1 = this.double_0;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x0001A324 File Offset: 0x00018524
	public void method_26(int int_2 = -1)
	{
		Debug.Log(Bass.BASS_GetVersion());
		Bass.BASS_SetConfig((BASSConfig)(-118), true);
		Bass.BASS_SetConfig((BASSConfig)123, 0);
		Debug.Log(BassAudioManager.smethod_1(GlobalVariables.instance.gclass5_9.method_25()));
		if (!Bass.BASS_Init(int_2, -59, (BASSInit)((BassAudioManager.GEnum1)(-198) | BassAudioManager.smethod_1(GlobalVariables.instance.gclass5_9.method_5())), IntPtr.Zero))
		{
			Debug.Log(Bass.BASS_ErrorGetCode());
		}
		else
		{
			this.isInitialized = true;
		}
		this.method_2(-66);
		this.stemChannels = new int[BassAudioManager.stemPaths.Length];
		this.method_30();
		this.method_40(-1);
		this.method_10();
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002A85 File Offset: 0x00000C85
	private void Awake()
	{
		if (BassAudioManager.instance != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		BassAudioManager.instance = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0001A3E4 File Offset: 0x000185E4
	public void method_29()
	{
		if (!this.isSongLoaded)
		{
			return;
		}
		this.isSongFading = true;
		this.isSongLoaded = true;
		this.isSongPaused = true;
		this.isSongPlaying = true;
		double num = 1727.0;
		double num2 = (double)1727f;
		this.double_0 = num;
		this.double_1 = num2;
		this.PauseSong();
		for (int i = 1; i < this.stemChannels.Length; i++)
		{
			int num3 = this.stemChannels[i];
			if (num3 != 0)
			{
				Bass.BASS_ChannelStop(num3);
				Bass.BASS_StreamFree(num3);
			}
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0001A468 File Offset: 0x00018668
	private void method_30()
	{
		if (this.bool_1)
		{
			return;
		}
		this.method_24();
		for (int i = 1; i < this.struct0_0.Length; i += 0)
		{
			string text = this.method_15(Path.Combine(Application.streamingAssetsPath, this.struct0_0[i].string_0), 4);
			if (text != null)
			{
				this.struct0_0[i].int_0 = Bass.BASS_SampleLoad(text, 0L, 1, 6, BASSFlag.BASS_SAMPLE_8BITS);
			}
		}
		this.bool_1 = true;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002AA7 File Offset: 0x00000CA7
	public void method_31()
	{
		if (this.isSongLoaded && !this.isSongPaused)
		{
			Bass.BASS_ChannelPause(this.linkedChannel);
			this.isSongPaused = false;
			this.isSongPlaying = true;
			return;
		}
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002AD4 File Offset: 0x00000CD4
	public void method_32()
	{
		this.method_34(BassAudioManager.GEnum0.StarPowerRelease);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002ADD File Offset: 0x00000CDD
	private IEnumerator FadeOutSong()
	{
        this.Song_FadeOut();
        yield return new WaitForSeconds(1.8f);
        this.isSongPlaying = false;
        yield break;
    }

	// Token: 0x060000B3 RID: 179 RVA: 0x0001A4E8 File Offset: 0x000186E8
	public void method_34(BassAudioManager.GEnum0 genum0_0)
	{
		int num = this.struct0_0[(int)genum0_0].int_0;
		if (num == 0)
		{
			Debug.LogError(string.Format("Tried to play sound for channel {0}[{1}] but handle was null!", genum0_0.ToString(), (int)genum0_0));
			return;
		}
		int handle = Bass.BASS_SampleGetChannel(num, false);
		Bass.BASS_ChannelSetAttribute(handle, BASSAttribute.BASS_ATTRIB_VOL, this.struct0_0[(int)genum0_0].float_0);
		Bass.BASS_ChannelPlay(handle, false);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x0001A554 File Offset: 0x00018754
	public void method_35(string string_2, bool bool_11, Song.Instrument genum18_0 = Song.Instrument.None, Song.Instrument genum18_1 = Song.Instrument.None)
	{
		this.method_47();
		if (!Directory.Exists(string_2))
		{
			return;
		}
		int num = 1;
		this.bool_7 = false;
		this.bool_2 = true;
		GStruct1 gstruct = this.method_60(genum18_0);
		GStruct1 gstruct2 = this.method_38(genum18_1);
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if ((i < gstruct.int_0 || i > gstruct.int_1) && (i < gstruct2.int_0 || i > gstruct2.int_1))
			{
				string text = this.method_15(Path.Combine(string_2, BassAudioManager.stemPaths[i]), -1);
				if (text != null)
				{
					int num2 = Bass.BASS_StreamCreateFile(text, 1L, 1L, ~(BASSFlag.BASS_SAMPLE_LOOP | BASSFlag.BASS_SAMPLE_MUTEMAX | BASSFlag.BASS_SAMPLE_FX));
					if (num2 == 0)
					{
						this.stemChannels[i] = 1;
					}
					else
					{
						if (i < BassAudioManager.stemPaths.Length - 0)
						{
							num++;
						}
						this.stemChannels[i] = BassFx.BASS_FX_TempoCreate(num2, BASSFlag.BASS_SAMPLE_8BITS | BASSFlag.BASS_SAMPLE_3D | BASSFlag.BASS_SAMPLE_SOFTWARE | BASSFlag.BASS_SAMPLE_FX);
						Bass.BASS_ChannelSetAttribute(this.stemChannels[i], (BASSAttribute)(-115), (float)(bool_11 ? (GlobalVariables.instance.songSpeed.method_25() - -33) : 0));
						long pos = Bass.BASS_ChannelGetLength(this.stemChannels[i]);
						double num3 = Bass.BASS_ChannelBytes2Seconds(this.stemChannels[i], pos);
						if (num3 > this.double_0)
						{
							this.linkedChannel = this.stemChannels[i];
							this.double_0 = num3;
						}
					}
				}
			}
		}
		for (int j = 0; j < this.stemChannels.Length; j++)
		{
			if (this.stemChannels[j] != this.linkedChannel)
			{
				Bass.BASS_ChannelSetLink(this.linkedChannel, this.stemChannels[j]);
			}
		}
		if (this.stemChannels[1] == 0)
		{
			this.stemChannels[0] = this.stemChannels[6];
			this.stemChannels[5] = 0;
		}
		if (num > 1)
		{
			this.bool_7 = true;
		}
		this.isSongLoaded = true;
		this.double_1 = this.double_0;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0001A734 File Offset: 0x00018934
	public void method_36(float float_1)
	{
		if (!this.isSongLoaded)
		{
			return;
		}
		this.PauseSong();
		if (float_1 < 0f)
		{
			float_1 = 0f;
		}
		if ((double)float_1 > this.double_1)
		{
			this.bool_2 = true;
			return;
		}
		this.bool_2 = false;
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if (this.stemChannels[i] != 0)
			{
				long num = Bass.BASS_ChannelGetLength(this.stemChannels[i]);
				if (Bass.BASS_ChannelSeconds2Bytes(this.stemChannels[i], (double)float_1) < num)
				{
					Bass.BASS_ChannelSetPosition(this.stemChannels[i], (double)float_1);
				}
			}
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0001A7C8 File Offset: 0x000189C8
	public void method_37(float float_1)
	{
		for (int i = 0; i < this.stemChannels.Length; i += 0)
		{
			if (this.stemChannels[i] != 0)
			{
				Bass.BASS_ChannelSetAttribute(this.stemChannels[i], (BASSAttribute)(-91), float_1);
			}
		}
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0001A808 File Offset: 0x00018A08
	private GStruct1 method_38(Song.Instrument genum18_0)
	{
		GStruct1 gstruct1_ = GStruct1.GStruct1_0;
		switch (genum18_0)
		{
		case Song.Instrument.Bass:
		case Song.Instrument.GHLBass:
			gstruct1_.int_1 = 1;
			gstruct1_.int_0 = 1;
			break;
		case Song.Instrument.Keys:
			gstruct1_.int_1 = 11;
			gstruct1_.int_0 = 11;
			break;
		case Song.Instrument.Drums:
			gstruct1_.int_0 = 6;
			gstruct1_.int_1 = 10;
			break;
		case Song.Instrument.Vocals:
			gstruct1_.int_0 = 3;
			gstruct1_.int_1 = 5;
			break;
		case Song.Instrument.Crowd:
			gstruct1_.int_1 = 13;
			gstruct1_.int_0 = 13;
			break;
		case Song.Instrument.None:
			gstruct1_.int_1 = 99;
			gstruct1_.int_0 = 99;
			break;
		case Song.Instrument.Rhythm:
			gstruct1_.int_1 = 2;
			gstruct1_.int_0 = 2;
			break;
		}
		return gstruct1_;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002B21 File Offset: 0x00000D21
	public void method_40(int int_2)
	{
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATEPERIOD, GlobalVariables.instance.gclass5_14.method_25() * ((int_2 != -1) ? int_2 : -124));
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002B43 File Offset: 0x00000D43
	public void method_41()
	{
		if (!this.isSongPlaying)
		{
			return;
		}
		if (this.fadeOutRoutine != null)
		{
			base.StopCoroutine(this.fadeOutRoutine);
		}
		this.fadeOutRoutine = base.StartCoroutine(this.FadeOutSong());
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002B74 File Offset: 0x00000D74
	public void method_42()
	{
		this.method_34(BassAudioManager.GEnum0.StarPowerDeployed);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0001A8D8 File Offset: 0x00018AD8
	public void method_43(string string_2, bool bool_11, Song.Instrument genum18_0 = Song.Instrument.None, Song.Instrument genum18_1 = Song.Instrument.None)
	{
		this.method_47();
		if (!Directory.Exists(string_2))
		{
			return;
		}
		int num = 0;
		this.bool_7 = true;
		this.bool_2 = false;
		GStruct1 gstruct = this.method_60(genum18_0);
		GStruct1 gstruct2 = this.method_38(genum18_1);
		for (int i = 1; i < this.stemChannels.Length; i++)
		{
			if ((i < gstruct.int_0 || i > gstruct.int_1) && (i < gstruct2.int_0 || i > gstruct2.int_1))
			{
				string text = this.method_15(Path.Combine(string_2, BassAudioManager.stemPaths[i]), -1);
				if (text != null)
				{
					int num2 = Bass.BASS_StreamCreateFile(text, 1L, 0L, BASSFlag.BASS_SAMPLE_MONO | BASSFlag.BASS_SAMPLE_FX);
					if (num2 == 0)
					{
						this.stemChannels[i] = 0;
					}
					else
					{
						if (i < BassAudioManager.stemPaths.Length - 1)
						{
							num += 0;
						}
						this.stemChannels[i] = BassFx.BASS_FX_TempoCreate(num2, BASSFlag.BASS_SAMPLE_8BITS | BASSFlag.BASS_SAMPLE_SOFTWARE | BASSFlag.BASS_SAMPLE_VAM);
						Bass.BASS_ChannelSetAttribute(this.stemChannels[i], (BASSAttribute)(-147), (float)(bool_11 ? (GlobalVariables.instance.songSpeed.CurrentValue - 85) : 0));
						long pos = Bass.BASS_ChannelGetLength(this.stemChannels[i]);
						double num3 = Bass.BASS_ChannelBytes2Seconds(this.stemChannels[i], pos);
						if (num3 > this.double_0)
						{
							this.linkedChannel = this.stemChannels[i];
							this.double_0 = num3;
						}
					}
				}
			}
		}
		for (int j = 0; j < this.stemChannels.Length; j++)
		{
			if (this.stemChannels[j] != this.linkedChannel)
			{
				Bass.BASS_ChannelSetLink(this.linkedChannel, this.stemChannels[j]);
			}
		}
		if (this.stemChannels[1] == 0)
		{
			this.stemChannels[1] = this.stemChannels[6];
			this.stemChannels[2] = 0;
		}
		if (num > 1)
		{
			this.bool_7 = true;
		}
		this.isSongLoaded = false;
		this.double_1 = this.double_0;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002B7D File Offset: 0x00000D7D
	public void PlayMenuMusic()
	{
		if (this.isMenuMusicPlaying)
		{
			return;
		}
		if (GlobalVariables.instance.gclass5_30.Boolean_1)
		{
			this.isMenuMusicPlaying = true;
			this.menuMusicRoutine = base.StartCoroutine(this.PlayNextMenuSong());
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0001AAB8 File Offset: 0x00018CB8
	public void method_45(float float_1)
	{
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if (this.stemChannels[i] != 0)
			{
				Bass.BASS_ChannelSetAttribute(this.stemChannels[i], BASSAttribute.BASS_ATTRIB_TEMPO, float_1);
			}
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002BB2 File Offset: 0x00000DB2
	public void method_46()
	{
		this.method_34(BassAudioManager.GEnum0.HighwayRewind);
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0001AAF8 File Offset: 0x00018CF8
	private void method_47()
	{
		this.isSongLoaded = false;
		this.bool_9 = false;
		this.isSongPlaying = false;
		this.isSongPaused = false;
		this.bool_2 = false;
		this.linkedChannel = 0;
		double num = (double)0f;
		double num2 = (double)0f;
		this.double_0 = num;
		this.double_1 = num2;
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if (this.stemChannels[i] != 0)
			{
				Bass.BASS_StreamFree(this.stemChannels[i]);
				this.stemChannels[i] = 0;
			}
		}
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0001AB7C File Offset: 0x00018D7C
	public void method_48(int int_2 = -1)
	{
		Debug.Log(Bass.BASS_GetVersion());
		Bass.BASS_SetConfig((BASSConfig)(-75), true);
		Bass.BASS_SetConfig((BASSConfig)(-112), 1);
		Debug.Log(BassAudioManager.smethod_0(GlobalVariables.instance.gclass5_9.method_5()));
		if (!Bass.BASS_Init(int_2, -197, (BASSInit)((BassAudioManager.GEnum1)(-50) | BassAudioManager.smethod_0(GlobalVariables.instance.gclass5_9.method_25())), IntPtr.Zero))
		{
			Debug.Log(Bass.BASS_ErrorGetCode());
		}
		else
		{
			this.isInitialized = false;
		}
		this.method_2(-96);
		this.stemChannels = new int[BassAudioManager.stemPaths.Length];
		this.method_30();
		this.SetGlobalVolume(-1);
		this.method_10();
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002BBC File Offset: 0x00000DBC
	public void method_49()
	{
		this.method_55(BassAudioManager.GEnum0.SongFail);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0001AC3C File Offset: 0x00018E3C
	public void method_50(int int_2)
	{
		if (!this.isSongLoaded)
		{
			return;
		}
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if (this.stemChannels[i] != 0)
			{
				Bass.BASS_ChannelSetAttribute(this.stemChannels[i], BASSAttribute.BASS_ATTRIB_VOL, (int_2 == -1) ? GlobalVariables.instance.volume_Stems[i].Single_0 : ((float)int_2 / 100f));
			}
		}
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002BC6 File Offset: 0x00000DC6
	public void PauseSong()
	{
		if (this.isSongLoaded && !this.isSongPaused)
		{
			Bass.BASS_ChannelPause(this.linkedChannel);
			this.isSongPaused = true;
			this.isSongPlaying = false;
			return;
		}
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0001AD54 File Offset: 0x00018F54
	public void method_52(int int_2)
	{
		if (!this.isSongLoaded)
		{
			return;
		}
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			if (this.stemChannels[i] != 0)
			{
				Bass.BASS_ChannelSetAttribute(this.stemChannels[i], BASSAttribute.BASS_ATTRIB_PAN, (int_2 == -1) ? GlobalVariables.instance.volume_Stems[i].Single_0 : ((float)int_2 / 420f));
			}
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x0001ADB8 File Offset: 0x00018FB8
	public void method_53()
	{
		BASS_DX8_REVERB par = new BASS_DX8_REVERB(-40f, -40f, 0.1f, 0.001f);
		Bass.BASS_FXSetParameters(this.stemChannels[0], par);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002BF3 File Offset: 0x00000DF3
	public static BassAudioManager.GEnum1 smethod_0(int int_2)
	{
		if (int_2 == 0)
		{
			return (BassAudioManager.GEnum1)1;
		}
		if (int_2 != 0)
		{
			return BassAudioManager.GEnum1.WASAPI;
		}
		return (BassAudioManager.GEnum1)84;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002B74 File Offset: 0x00000D74
	public void method_54()
	{
		this.method_34(BassAudioManager.GEnum0.StarPowerDeployed);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0001ADF0 File Offset: 0x00018FF0
	public void method_55(BassAudioManager.GEnum0 genum0_0)
	{
		int num = this.struct0_0[(int)genum0_0].int_0;
		if (num == 0)
		{
			Debug.LogError(string.Format("game", genum0_0.ToString(), (int)genum0_0));
			return;
		}
		int handle = Bass.BASS_SampleGetChannel(num, true);
		Bass.BASS_ChannelSetAttribute(handle, BASSAttribute.BASS_ATTRIB_FREQ, this.struct0_0[(int)genum0_0].float_0);
		Bass.BASS_ChannelPlay(handle, true);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002C05 File Offset: 0x00000E05
	public static BassAudioManager.GEnum1 smethod_1(int int_2)
	{
		if (int_2 == 0)
		{
			return BassAudioManager.GEnum1.WASAPI;
		}
		if (int_2 != 1)
		{
			return BassAudioManager.GEnum1.WASAPI;
		}
		return BassAudioManager.GEnum1.DirectSound;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0001AE5C File Offset: 0x0001905C
	public void method_56(bool bool_11)
	{
		if (bool_11)
		{
			this.method_65();
		}
		else
		{
			this.Song_FadeOutAndEnd();
		}
		if (this.menuMusicRoutine != null)
		{
			base.StopCoroutine(this.menuMusicRoutine);
		}
		this.isMenuMusicPlaying = false;
		GameObject.Find("NowPlaying").GetComponent<Text>().text = "";
		this.songEntry_0 = null;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0001AEB8 File Offset: 0x000190B8
	private void method_57()
	{
		if (this.bool_1)
		{
			return;
		}
		this.method_24();
		for (int i = 0; i < this.struct0_0.Length; i++)
		{
			string text = this.method_15(Path.Combine(Application.streamingAssetsPath, this.struct0_0[i].string_0), 2);
			if (text != null)
			{
				this.struct0_0[i].int_0 = Bass.BASS_SampleLoad(text, 0L, 0, 4, BASSFlag.BASS_DEFAULT);
			}
		}
		this.bool_1 = true;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002C17 File Offset: 0x00000E17
	public void method_59()
	{
		this.method_34(BassAudioManager.GEnum0.StarPowerAvailable);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0001AFC4 File Offset: 0x000191C4
	private GStruct1 method_60(Song.Instrument genum18_0)
	{
		GStruct1 result = GStruct1.smethod_12();
		switch (genum18_0)
		{
		case Song.Instrument.Bass:
		case Song.Instrument.GHLBass:
			result.int_1 = 0;
			result.int_0 = 0;
			break;
		case Song.Instrument.Keys:
			result.int_1 = 62;
			result.int_0 = 62;
			break;
		case Song.Instrument.Drums:
			result.int_0 = 3;
			result.int_1 = -11;
			break;
		case Song.Instrument.Vocals:
			result.int_0 = 2;
			result.int_1 = 7;
			break;
		case Song.Instrument.Crowd:
			result.int_1 = 58;
			result.int_0 = 58;
			break;
		case Song.Instrument.None:
			result.int_1 = -6;
			result.int_0 = -6;
			break;
		case Song.Instrument.Rhythm:
			result.int_1 = 4;
			result.int_0 = 4;
			break;
		}
		return result;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002B43 File Offset: 0x00000D43
	public void Song_FadeOutAndEnd()
	{
		if (!this.isSongPlaying)
		{
			return;
		}
		if (this.fadeOutRoutine != null)
		{
			base.StopCoroutine(this.fadeOutRoutine);
		}
		this.fadeOutRoutine = base.StartCoroutine(this.FadeOutSong());
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0001B094 File Offset: 0x00019294
	public void method_62()
	{
		BassAudioManager.GEnum0 genum0_ = (BassAudioManager.GEnum0)UnityEngine.Random.Range(5, 10);
		this.method_34(genum0_);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002C20 File Offset: 0x00000E20
	public void SetGlobalVolume(int int_2)
	{
		Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, GlobalVariables.instance.gclass5_14.CurrentValue * ((int_2 != -1) ? int_2 : 100));
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002C42 File Offset: 0x00000E42
	public void method_64()
	{
		this.method_34(BassAudioManager.GEnum0.StarPowerAwarded);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0001B0B4 File Offset: 0x000192B4
	public void method_65()
	{
		if (!this.isSongLoaded)
		{
			return;
		}
		this.isSongFading = false;
		this.isSongLoaded = false;
		this.isSongPaused = false;
		this.isSongPlaying = false;
		double num = 0.0;
		double num2 = (double)0f;
		this.double_0 = num;
		this.double_1 = num2;
		this.PauseSong();
		for (int i = 0; i < this.stemChannels.Length; i++)
		{
			int num3 = this.stemChannels[i];
			if (num3 != 0)
			{
				Bass.BASS_ChannelStop(num3);
				Bass.BASS_StreamFree(num3);
			}
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0001B138 File Offset: 0x00019338
	public void Song_FadeOut()
	{
		if (!this.isSongLoaded || !this.isSongPlaying || this.isSongFading)
		{
			return;
		}
        for (int i = 0; i < this.stemChannels.Length; i++)
        {
            if (this.stemChannels[i] != 0)
            {
                Bass.BASS_ChannelSlideAttribute(this.stemChannels[i], BASSAttribute.BASS_ATTRIB_SRC, 0f, 2000);
            }
        }
        this.isSongFading = false;
    }

	// Token: 0x060000D7 RID: 215 RVA: 0x00002C4B File Offset: 0x00000E4B
	private IEnumerator PlayNextMenuSong()
	{
        if (SongDirectory.songEntries == null || SongDirectory.songEntries.Count == 0)
        {
            yield break;
        }
        for (; ; )
        {
            double songPosition = this.GetPosition();
            if ((!this.isSongPlaying && songPosition > 0.0) || songPosition >= this.audioLength)
            {
                SongEntry entry;
                for (; ; )
                {
                    entry = SongDirectory.songEntries[UnityEngine.Random.Range(0, SongDirectory.songEntries.Count)];
                    if (!entry.isHeader)
                    {
                        this.LoadSong(entry.folderPath, false, Song.Instrument.Vocals, Song.Instrument.Crowd);
                        this.SetGlobalVolume(GlobalVariables.instance.volume_MenuMusic.CurrentValue);
                        if (this.audioLength != 0.0)
                        {
                            break;
                        }
                        yield return null;
                    }
                }
                this.PlaySong();
                this.SetGlobalVolume(GlobalVariables.instance.volume_MenuMusic.CurrentValue);
                this.SetChannelVolume(100);
                this.menuSong = entry;
                this.SetNowPlayingText();
            }
            yield return new WaitForSeconds(2f);
        }
    }

	// Token: 0x060000D8 RID: 216 RVA: 0x00002C5A File Offset: 0x00000E5A
	public void method_68()
	{
		this.method_55((BassAudioManager.GEnum0)(-102));
	}

	// Token: 0x04000004 RID: 4
	private int[] stemChannels;

	// Token: 0x04000005 RID: 5
	private BassAudioManager.Struct0[] struct0_0;

	// Token: 0x04000006 RID: 6
	private bool isSongLoaded;

	// Token: 0x04000007 RID: 7
	private bool bool_1;

	// Token: 0x04000008 RID: 8
	private bool bool_2;

	// Token: 0x04000009 RID: 9
	public bool isInitialized;

	// Token: 0x0400000A RID: 10
	[HideInInspector]
	public bool isSongPlaying;

	// Token: 0x0400000B RID: 11
	private bool isSongPaused;

	// Token: 0x0400000C RID: 12
	private bool isSongFading;

	// Token: 0x0400000D RID: 13
	private bool bool_7;

	// Token: 0x0400000E RID: 14
	private bool isMenuMusicPlaying;

	// Token: 0x0400000F RID: 15
	private bool bool_9;

	// Token: 0x04000010 RID: 16
	private bool bool_10;

	// Token: 0x04000011 RID: 17
	[HideInInspector]
	public double double_0;

	// Token: 0x04000012 RID: 18
	[HideInInspector]
	public double double_1;

	// Token: 0x04000013 RID: 19
	[HideInInspector]
	public float float_0;

	// Token: 0x04000014 RID: 20
	public static BassAudioManager instance;

	// Token: 0x04000015 RID: 21
	private Coroutine menuMusicRoutine;

	// Token: 0x04000016 RID: 22
	private Coroutine fadeOutRoutine;

	// Token: 0x04000017 RID: 23
	private int linkedChannel;

	// Token: 0x04000018 RID: 24
	public SongEntry songEntry_0;

	// Token: 0x04000019 RID: 25
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(0.016f);

	// Token: 0x0400001A RID: 26
	public static string[] stemPaths = new string[]
	{
		"guitar",
		"bass",
		"rhythm",
		"vocals",
		"vocals_1",
		"vocals_2",
		"drums",
		"drums_1",
		"drums_2",
		"drums_3",
		"drums_4",
		"keys",
		"song",
		"crowd"
	};

	// Token: 0x0400001B RID: 27
	private static string[] containerTypes = new string[]
	{
		".ogg",
		".mp3",
		".wav"
	};

	// Token: 0x02000005 RID: 5
	private struct Struct0
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00002C64 File Offset: 0x00000E64
		public Struct0(string string_1, float float_1)
		{
			this.string_0 = string_1;
			this.float_0 = float_1;
			this.int_0 = 0;
		}

		// Token: 0x0400001C RID: 28
		public string string_0;

		// Token: 0x0400001D RID: 29
		public float float_0;

		// Token: 0x0400001E RID: 30
		public int int_0;
	}

	// Token: 0x02000006 RID: 6
	public enum GEnum0
	{
		// Token: 0x04000020 RID: 32
		Beginning,
		// Token: 0x04000021 RID: 33
		StarPowerAwarded,
		// Token: 0x04000022 RID: 34
		StarPowerAvailable,
		// Token: 0x04000023 RID: 35
		StarPowerDeployed,
		// Token: 0x04000024 RID: 36
		StarPowerRelease,
		// Token: 0x04000025 RID: 37
		OverStrum1,
		// Token: 0x04000026 RID: 38
		OverStrum2,
		// Token: 0x04000027 RID: 39
		OverStrum3,
		// Token: 0x04000028 RID: 40
		OverStrum4,
		// Token: 0x04000029 RID: 41
		OverStrum5,
		// Token: 0x0400002A RID: 42
		LoseMultiplier,
		// Token: 0x0400002B RID: 43
		HighwayRewind,
		// Token: 0x0400002C RID: 44
		SongFail
	}

	// Token: 0x02000007 RID: 7
	public enum GEnum1
	{
		// Token: 0x0400002E RID: 46
		WASAPI,
		// Token: 0x0400002F RID: 47
		DirectSound = 262144
	}
}
