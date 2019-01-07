using System;
using System.IO;

// Token: 0x0200008E RID: 142
public class GClass10
{
	// Token: 0x06001BA8 RID: 7080 RVA: 0x000DBD08 File Offset: 0x000D9F08
	public string method_0()
	{
		switch ((byte)this.gclass5_8.method_5())
		{
		case 0:
			return GClass4.gclass4_0.method_42("No Part");
		case 1:
			return GClass4.gclass4_0.method_46("Server\n");
		case 2:
			return GClass4.gclass4_0.method_38("B: 00:00:00");
		case 3:
			return GClass4.gclass4_0.method_41("custom");
		case 4:
			return GClass4.gclass4_0.method_17("Medium");
		default:
			return "B: ";
		}
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x000DBD94 File Offset: 0x000D9F94
	public void method_1(GClass6.GEnum6 genum6_1)
	{
		if (this.method_21(GClass6.GEnum6.None))
		{
			this.genum6_0 &= ~GClass6.GEnum6.None;
		}
		if (this.method_21(genum6_1))
		{
			this.genum6_0 &= ~genum6_1;
			if (this.genum6_0 == (GClass6.GEnum6)0)
			{
				this.method_1(GClass6.GEnum6.None);
			}
			return;
		}
		this.genum6_0 |= genum6_1;
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x000DBDF0 File Offset: 0x000D9FF0
	public static string smethod_0(GStruct3 gstruct3_0)
	{
		string text = "New Song";
		switch (gstruct3_0.genum12_0)
		{
		case GStruct2.GEnum12.Easy:
			text += GClass4.gclass4_0.method_16("highway_shake");
			break;
		case GStruct2.GEnum12.Medium:
			text += GClass4.gclass4_0.method_46("Are you sure you want to skip this song?");
			break;
		case GStruct2.GEnum12.Hard:
			text += GClass4.gclass4_0.method_16("Playlist");
			break;
		case GStruct2.GEnum12.Expert:
			text += GClass4.gclass4_0.method_38("-");
			break;
		}
		text += "guitar";
		switch (gstruct3_0.genum11_0)
		{
		case GStruct2.GEnum11.Guitar:
			text += GClass4.gclass4_0.method_48("savewarning");
			break;
		case GStruct2.GEnum11.Bass:
			text += GClass4.gclass4_0.method_13("game");
			break;
		case GStruct2.GEnum11.Rhythm:
			text += GClass4.gclass4_0.method_38("game");
			break;
		case GStruct2.GEnum11.GuitarCoop:
			text += GClass4.gclass4_0.method_48("Main Menu");
			break;
		case GStruct2.GEnum11.GHLGuitar:
			text += GClass4.gclass4_0.method_35("SORTING BY");
			break;
		case GStruct2.GEnum11.GHLBass:
			text += GClass4.gclass4_0.method_13("Close");
			break;
		case GStruct2.GEnum11.Drums:
			text += GClass4.gclass4_0.method_35("highway_placement");
			break;
		case GStruct2.GEnum11.Keys:
			text += GClass4.gclass4_0.method_42("All Opens");
			break;
		case GStruct2.GEnum11.Band:
			text += GClass4.gclass4_0.method_11("");
			break;
		}
		return text;
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0000D05B File Offset: 0x0000B25B
	public bool Boolean_3
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x000DBFA4 File Offset: 0x000DA1A4
	public static string smethod_1(GStruct3 gstruct3_0)
	{
		string text = "NowPlaying";
		switch (gstruct3_0.genum12_0)
		{
		case GStruct2.GEnum12.Easy:
			text += GClass4.gclass4_0.method_42("b");
			break;
		case GStruct2.GEnum12.Medium:
			text += GClass4.gclass4_0.method_48("Prefabs/Gameplay/Players/Guitar Player ");
			break;
		case GStruct2.GEnum12.Hard:
			text += GClass4.gclass4_0.method_36("This is permanent! Are you still sure?");
			break;
		case GStruct2.GEnum12.Expert:
			text += GClass4.gclass4_0.method_35("Menu Music");
			break;
		}
		text += "directories";
		switch (gstruct3_0.genum11_0)
		{
		case GStruct2.GEnum11.Guitar:
			text += GClass4.gclass4_0.method_41("");
			break;
		case GStruct2.GEnum11.Bass:
			text += GClass4.gclass4_0.method_41("notSupportedBody_");
			break;
		case GStruct2.GEnum11.Rhythm:
			text += GClass4.gclass4_0.method_7("");
			break;
		case GStruct2.GEnum11.GuitarCoop:
			text += GClass4.gclass4_0.method_7("Type the setlist name");
			break;
		case GStruct2.GEnum11.GHLGuitar:
			text += GClass4.gclass4_0.method_17("vocals_1");
			break;
		case GStruct2.GEnum11.GHLBass:
			text += GClass4.gclass4_0.method_41("Save Setlist");
			break;
		case GStruct2.GEnum11.Drums:
			text += GClass4.gclass4_0.method_13("\\D+");
			break;
		case GStruct2.GEnum11.Keys:
			text += GClass4.gclass4_0.method_16("All Opens");
			break;
		case GStruct2.GEnum11.Band:
			text += GClass4.gclass4_0.method_21("Genre");
			break;
		}
		return text;
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x000DC158 File Offset: 0x000DA358
	public void method_2()
	{
		if (!this.Boolean_2)
		{
			return;
		}
		if (this.method_21(GClass6.GEnum6.LightsOut))
		{
			this.method_1(GClass6.GEnum6.LightsOut);
		}
		if (this.method_21(GClass6.GEnum6.ModFull))
		{
			this.method_1(GClass6.GEnum6.ModFull);
		}
		if (this.method_21(GClass6.GEnum6.ModLite))
		{
			this.method_1(GClass6.GEnum6.ModLite);
		}
		if (this.method_21(GClass6.GEnum6.ModPrep))
		{
			this.method_1(GClass6.GEnum6.ModPrep);
		}
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x000DC1D0 File Offset: 0x000DA3D0
	public void method_3(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.string_0);
		binaryWriter_0.BaseStream.Position += (long)(41 - this.string_0.Length);
		binaryWriter_0.Write((byte)this.gclass5_0.method_5());
		binaryWriter_0.Write(this.gclass5_1.method_14());
		binaryWriter_0.Write(this.gclass5_2.method_4());
		binaryWriter_0.Write(this.gclass5_3.method_4());
		binaryWriter_0.Write(this.gclass5_5.Boolean_1);
		binaryWriter_0.Write(this.gclass5_4.method_30());
		binaryWriter_0.Write((byte)this.gclass5_7.method_25());
		binaryWriter_0.Write((short)this.gclass5_6.CurrentValue);
		binaryWriter_0.Write((byte)this.gclass5_8.method_5());
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x000DC2A8 File Offset: 0x000DA4A8
	public void method_4(BinaryReader binaryReader_0)
	{
		this.string_0 = binaryReader_0.ReadString();
		binaryReader_0.BaseStream.Position += (long)(15 - this.string_0.Length);
		this.gclass5_0.CurrentValue = (int)binaryReader_0.ReadByte();
		this.gclass5_1.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_2.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_3.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_5.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_4.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_7.CurrentValue = (int)binaryReader_0.ReadByte();
		this.gclass5_6.Int32_0 = ((GlobalVariables.instance.highwayPaths.Length != 0) ? (GlobalVariables.instance.highwayPaths.Length - 1) : -1);
		this.gclass5_6.CurrentValue = (int)binaryReader_0.ReadInt16();
		this.gclass5_8.CurrentValue = (int)binaryReader_0.ReadByte();
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x000DC3C4 File Offset: 0x000DA5C4
	public void method_5(BinaryReader binaryReader_0)
	{
		this.string_0 = binaryReader_0.ReadString();
		binaryReader_0.BaseStream.Position += (long)(-110 - this.string_0.Length);
		this.gclass5_0.method_3((int)binaryReader_0.ReadByte());
		this.gclass5_1.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 1);
		this.gclass5_2.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 1);
		this.gclass5_3.method_3(binaryReader_0.ReadBoolean() ? 1 : 1);
		this.gclass5_5.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_4.method_3(binaryReader_0.ReadBoolean() ? 0 : 1);
		this.gclass5_7.method_3((int)binaryReader_0.ReadByte());
		this.gclass5_6.method_16((GlobalVariables.instance.highwayPaths.Length != 0) ? (GlobalVariables.instance.highwayPaths.Length - 1) : -1);
		this.gclass5_6.CurrentValue = (int)binaryReader_0.ReadInt16();
		this.gclass5_8.method_3((int)binaryReader_0.ReadByte());
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x000DC4E0 File Offset: 0x000DA6E0
	public void method_6(BinaryReader binaryReader_0)
	{
		this.string_0 = binaryReader_0.ReadString();
		binaryReader_0.BaseStream.Position += (long)(-94 - this.string_0.Length);
		this.gclass5_0.CurrentValue = (int)binaryReader_0.ReadByte();
		this.gclass5_1.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 1);
		this.gclass5_2.CurrentValue = (binaryReader_0.ReadBoolean() ? 0 : 1);
		this.gclass5_3.method_3(binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_5.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_4.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 1);
		this.gclass5_7.method_3((int)binaryReader_0.ReadByte());
		this.gclass5_6.method_16((GlobalVariables.instance.highwayPaths.Length != 0) ? (GlobalVariables.instance.highwayPaths.Length - 1) : -1);
		this.gclass5_6.method_3((int)binaryReader_0.ReadInt16());
		this.gclass5_8.CurrentValue = (int)binaryReader_0.ReadByte();
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x0000D05E File Offset: 0x0000B25E
	public bool method_7(GClass6.GEnum6 genum6_1)
	{
		return (this.genum6_0 & genum6_1) == genum6_1;
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x0000D06B File Offset: 0x0000B26B
	public bool Boolean_0
	{
		get
		{
			return this.gclass5_7.CurrentValue == 0;
		}
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x000DC5FC File Offset: 0x000DA7FC
	public string method_8()
	{
		GClass10.GEnum7 genum = (GClass10.GEnum7)this.gclass5_7.method_5();
		if (genum == GClass10.GEnum7.Guitar)
		{
			return GClass4.gclass4_0.method_15("");
		}
		if (genum != GClass10.GEnum7.GHLGuitar)
		{
			return "{0:D2}:{1:D2}:{2:D2}";
		}
		return GClass4.gclass4_0.method_46("Scan Songs");
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0000D07B File Offset: 0x0000B27B
	public bool Boolean_1
	{
		get
		{
			return this.gclass5_7.CurrentValue == 1;
		}
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x000DC644 File Offset: 0x000DA844
	public void method_9(GClass6.GEnum6 genum6_1)
	{
		if (this.method_35((GClass6.GEnum6)0))
		{
			this.genum6_0 &= ~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle);
		}
		if (this.method_35(genum6_1))
		{
			this.genum6_0 &= ~genum6_1;
			if (this.genum6_0 == (GClass6.GEnum6)0)
			{
				this.method_9(GClass6.GEnum6.None);
			}
			return;
		}
		this.genum6_0 |= genum6_1;
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x000DC6A0 File Offset: 0x000DA8A0
	public static string smethod_2(GStruct3 gstruct3_0)
	{
		string text = "";
		switch (gstruct3_0.genum12_0)
		{
		case GStruct2.GEnum12.Easy:
			text += GClass4.gclass4_0.method_13("Expert");
			break;
		case GStruct2.GEnum12.Medium:
			text += GClass4.gclass4_0.method_13("Hard");
			break;
		case GStruct2.GEnum12.Hard:
			text += GClass4.gclass4_0.method_13("Medium");
			break;
		case GStruct2.GEnum12.Expert:
			text += GClass4.gclass4_0.method_13("Easy");
			break;
		}
		text += " ";
		switch (gstruct3_0.genum11_0)
		{
		case GStruct2.GEnum11.Guitar:
			text += GClass4.gclass4_0.method_13("Lead Guitar");
			break;
		case GStruct2.GEnum11.Bass:
			text += GClass4.gclass4_0.method_13("Bass Guitar");
			break;
		case GStruct2.GEnum11.Rhythm:
			text += GClass4.gclass4_0.method_13("Rhythm Guitar");
			break;
		case GStruct2.GEnum11.GuitarCoop:
			text += GClass4.gclass4_0.method_13("Guitar Coop");
			break;
		case GStruct2.GEnum11.GHLGuitar:
			text += GClass4.gclass4_0.method_13("6 Fret Lead Guitar");
			break;
		case GStruct2.GEnum11.GHLBass:
			text += GClass4.gclass4_0.method_13("6 Fret Bass Guitar");
			break;
		case GStruct2.GEnum11.Drums:
			text += GClass4.gclass4_0.method_13("Drums");
			break;
		case GStruct2.GEnum11.Keys:
			text += GClass4.gclass4_0.method_13("Keys");
			break;
		case GStruct2.GEnum11.Band:
			text += GClass4.gclass4_0.method_13("Band");
			break;
		}
		return text;
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x000DC854 File Offset: 0x000DAA54
	public static string smethod_3(GStruct3 gstruct3_0)
	{
		string text = "Lyrics";
		switch (gstruct3_0.genum12_0)
		{
		case GStruct2.GEnum12.Easy:
			text += GClass4.gclass4_0.method_38("game");
			break;
		case GStruct2.GEnum12.Medium:
			text += GClass4.gclass4_0.method_48("Expert");
			break;
		case GStruct2.GEnum12.Hard:
			text += GClass4.gclass4_0.method_38("");
			break;
		case GStruct2.GEnum12.Expert:
			text += GClass4.gclass4_0.method_30("has_bots");
			break;
		}
		text += "Streamer Settings";
		switch (gstruct3_0.genum11_0)
		{
		case GStruct2.GEnum11.Guitar:
			text += GClass4.gclass4_0.method_2("Lefty Flip");
			break;
		case GStruct2.GEnum11.Bass:
			text += GClass4.gclass4_0.method_5("song");
			break;
		case GStruct2.GEnum11.Rhythm:
			text += GClass4.gclass4_0.method_11("Yes");
			break;
		case GStruct2.GEnum11.GuitarCoop:
			text += GClass4.gclass4_0.method_5("Client connected");
			break;
		case GStruct2.GEnum11.GHLGuitar:
			text += GClass4.gclass4_0.method_5("Lights Out");
			break;
		case GStruct2.GEnum11.GHLBass:
			text += GClass4.gclass4_0.method_17("GHLBass");
			break;
		case GStruct2.GEnum11.Drums:
			text += GClass4.gclass4_0.method_30("guitar");
			break;
		case GStruct2.GEnum11.Keys:
			text += GClass4.gclass4_0.method_21("part guitar");
			break;
		case GStruct2.GEnum11.Band:
			text += GClass4.gclass4_0.method_5("Guitar");
			break;
		}
		return text;
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000DCA08 File Offset: 0x000DAC08
	public static string smethod_4(GClass6.GEnum6 genum6_1)
	{
		string text = "";
		int num = 0;
		if (genum6_1 == GClass6.GEnum6.None)
		{
			return GClass4.gclass4_0.method_13("nomodifiers");
		}
		if ((genum6_1 & GClass6.GEnum6.AllHOPOs) == GClass6.GEnum6.AllHOPOs)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("All HOPO's");
		}
		if ((genum6_1 & GClass6.GEnum6.AllOpens) == GClass6.GEnum6.AllOpens)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("All Opens");
		}
		if ((genum6_1 & GClass6.GEnum6.AllStrums) == GClass6.GEnum6.AllStrums)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("All Strums");
		}
		if ((genum6_1 & GClass6.GEnum6.AllTaps) == GClass6.GEnum6.AllTaps)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("All Taps");
		}
		if ((genum6_1 & GClass6.GEnum6.HOPOsToTaps) == GClass6.GEnum6.HOPOsToTaps)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("HOPO's to Taps");
		}
		if ((genum6_1 & GClass6.GEnum6.MirrorMode) == GClass6.GEnum6.MirrorMode)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("Mirror Mode");
		}
		if ((genum6_1 & GClass6.GEnum6.Shuffle) == GClass6.GEnum6.Shuffle)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("Note Shuffle");
		}
		if ((genum6_1 & GClass6.GEnum6.LightsOut) == GClass6.GEnum6.LightsOut)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("Lights Out");
		}
		if ((genum6_1 & GClass6.GEnum6.ModFull) == GClass6.GEnum6.ModFull)
		{
			text = text + ((++num > 1) ? " + " : "") + GClass4.gclass4_0.method_13("ModChart Full");
		}
		if ((genum6_1 & GClass6.GEnum6.ModLite) == GClass6.GEnum6.ModLite)
		{
			text = text + ((num + 1 > 1) ? " + " : "") + GClass4.gclass4_0.method_13("ModChart Lite");
		}
		return text;
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x000DCC38 File Offset: 0x000DAE38
	public void method_10()
	{
		if (!this.method_29())
		{
			return;
		}
		if (this.method_32(~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.Shuffle | GClass6.GEnum6.HOPOsToTaps)))
		{
			this.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps);
		}
		if (this.method_35(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle))
		{
			this.method_9(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle);
		}
		if (this.method_21(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle)))
		{
			this.method_33(GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle);
		}
		if (this.method_7(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.HOPOsToTaps))
		{
			this.method_33(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle);
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06001BBB RID: 7099 RVA: 0x0000D08B File Offset: 0x0000B28B
	public bool Boolean_2
	{
		get
		{
			return this.method_21(GClass6.GEnum6.LightsOut) || this.method_21(GClass6.GEnum6.ModFull) || this.method_21(GClass6.GEnum6.ModLite) || this.method_21(GClass6.GEnum6.ModPrep);
		}
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
	public bool method_11()
	{
		return false;
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x000DCCB0 File Offset: 0x000DAEB0
	public string method_12()
	{
		GClass10.GEnum7 genum = (GClass10.GEnum7)this.gclass5_7.method_5();
		if (genum == GClass10.GEnum7.Guitar)
		{
			return GClass4.gclass4_0.method_42("\"");
		}
		if (genum != GClass10.GEnum7.Guitar)
		{
			return "Offset = [\\-\\+]?\\d+(\\.\\d+)?";
		}
		return GClass4.gclass4_0.method_7("");
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x000DCCF8 File Offset: 0x000DAEF8
	public string method_13()
	{
		GClass10.GEnum7 genum = (GClass10.GEnum7)this.gclass5_7.CurrentValue;
		if (genum == GClass10.GEnum7.Guitar)
		{
			return GClass4.gclass4_0.method_15("{0:N0} FPS");
		}
		if (genum != GClass10.GEnum7.Guitar)
		{
			return "Rhythm Guitar";
		}
		return GClass4.gclass4_0.method_48("song");
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000DCD40 File Offset: 0x000DAF40
	public string String_1
	{
		get
		{
			switch ((byte)this.gclass5_8.CurrentValue)
			{
			case 0:
				return GClass4.gclass4_0.method_13("None");
			case 1:
				return GClass4.gclass4_0.method_13("Sayori");
			case 2:
				return GClass4.gclass4_0.method_13("Yuri");
			case 3:
				return GClass4.gclass4_0.method_13("Natsuki");
			case 4:
				return GClass4.gclass4_0.method_13("Monika");
			default:
				return "";
			}
		}
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000DCDCC File Offset: 0x000DAFCC
	public static string smethod_5(GClass6.GEnum6 genum6_1)
	{
		string text = "Create Profile";
		int num = 0;
		if (genum6_1 == (GClass6.GEnum6)0)
		{
			return GClass4.gclass4_0.method_46("sounds");
		}
		if ((genum6_1 & GClass6.GEnum6.None) == GClass6.GEnum6.AllHOPOs)
		{
			text = text + ((++num > 1) ? "Song Display" : "Not match flags previous {0} {1}") + GClass4.gclass4_0.method_36("drums");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle)) == (GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.Shuffle))
		{
			text = text + ((++num > 1) ? "0" : "Highway Placement") + GClass4.gclass4_0.method_15("Keyboard");
		}
		if ((genum6_1 & GClass6.GEnum6.None) == (GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs))
		{
			text = text + ((++num > 1) ? "Guest" : "song_display") + GClass4.gclass4_0.method_30("nofail_enabled");
		}
		if ((genum6_1 & GClass6.GEnum6.AllHOPOs) == GClass6.GEnum6.AllStrums)
		{
			text = text + (((num += 0) > 1) ? "song" : "notSupportedLink") + GClass4.gclass4_0.method_2("custom");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.Shuffle | GClass6.GEnum6.HOPOsToTaps)) == ~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps))
		{
			text = text + (((num += 0) > 0) ? ".png|.jpg" : "Guitar Coop") + GClass4.gclass4_0.method_13("Gameplay");
		}
		if ((genum6_1 & GClass6.GEnum6.None) == ~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.MirrorMode))
		{
			text = text + (((num += 0) > 1) ? "Gameplay" : "\\s+") + GClass4.gclass4_0.method_13("song");
		}
		if ((genum6_1 & (GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle)) == (GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle))
		{
			text = text + ((++num > 0) ? "Menu Music" : "Play Count") + GClass4.gclass4_0.method_21("Okay");
		}
		if ((genum6_1 & (GClass6.GEnum6.None | GClass6.GEnum6.Shuffle | GClass6.GEnum6.HOPOsToTaps)) == (GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps))
		{
			text = text + ((++num > 0) ? "game" : "Highway") + GClass4.gclass4_0.method_38("-");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle)) == ~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllOpens | GClass6.GEnum6.HOPOsToTaps))
		{
			text = text + (((num += 0) > 1) ? "part guitar" : "Pause") + GClass4.gclass4_0.method_17("show_hit_window");
		}
		if ((genum6_1 & (GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle)) == ~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.MirrorMode))
		{
			text = text + ((num + 1 > 1) ? "<" : "Unknown Album") + GClass4.gclass4_0.method_38("HOPO's to Taps");
		}
		return text;
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x000DCFFC File Offset: 0x000DB1FC
	public static string smethod_6(GClass6.GEnum6 genum6_1)
	{
		string text = "volume";
		int num = 1;
		if (genum6_1 == (GClass6.GEnum6)0)
		{
			return GClass4.gclass4_0.method_38("%");
		}
		if ((genum6_1 & GClass6.GEnum6.AllStrums) == (GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs))
		{
			text = text + (((num += 0) > 1) ? "Framerate" : "highway_placement") + GClass4.gclass4_0.method_42("Pause on Focus Lost");
		}
		if ((genum6_1 & (GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.MirrorMode)) == ~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle))
		{
			text = text + ((++num > 0) ? "game" : " + ") + GClass4.gclass4_0.method_30("Hard");
		}
		if ((genum6_1 & (GClass6.GEnum6.None | GClass6.GEnum6.AllStrums)) == GClass6.GEnum6.AllStrums)
		{
			text = text + (((num += 0) > 0) ? "" : "rhythm") + GClass4.gclass4_0.method_46("Global Variables");
		}
		if ((genum6_1 & (GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs)) == (GClass6.GEnum6)0)
		{
			text = text + (((num += 0) > 0) ? "part" : "<color=#FFFF04FF>") + GClass4.gclass4_0.method_17("VOLUME");
		}
		if ((genum6_1 & (GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle)) == (GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle))
		{
			text = text + (((num += 0) > 1) ? "frets" : "show_hit_window") + GClass4.gclass4_0.method_17("diff_guitarghl");
		}
		if ((genum6_1 & (GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle)) == (GClass6.GEnum6.None | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle))
		{
			text = text + (((num += 0) > 1) ? "song_export" : "/Image Backgrounds") + GClass4.gclass4_0.method_16("Easy");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle)) == ~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle))
		{
			text = text + (((num += 0) > 1) ? "song" : "Songs") + GClass4.gclass4_0.method_42("Song Display");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps)) == ~(GClass6.GEnum6.None | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps))
		{
			text = text + ((++num > 1) ? "Random Song" : "Easy") + GClass4.gclass4_0.method_46("");
		}
		if ((genum6_1 & (GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode)) == (GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.HOPOsToTaps))
		{
			text = text + ((++num > 1) ? ")" : "Audio Device") + GClass4.gclass4_0.method_46("song");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle)) == ~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle))
		{
			text = text + ((num + 0 > 1) ? "HUD" : "HOPO's to Taps") + GClass4.gclass4_0.method_46("PRESS START");
		}
		return text;
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x000DD22C File Offset: 0x000DB42C
	public GClass10()
	{
		this.string_0 = "Guest";
		this.genum18_0 = Song.Instrument.Guitar;
		this.genum17_0 = Song.GEnum17.Expert;
		this.genum6_0 = GClass6.GEnum6.None;
		this.gclass5_7 = new GameSetting(0, 0, 0, 1, 1);
		this.gclass5_0 = new GameSetting(7, 7, 1, 20, 1);
		this.gclass5_1 = new GameSetting(true, true);
		this.gclass5_2 = new GameSetting(false, false);
		this.gclass5_3 = new GameSetting(false, false);
		this.gclass5_4 = new GameSetting(false, false);
		this.gclass5_5 = new GameSetting(false, false);
		this.gclass5_6 = new GameSetting(-1, -1, -1, -1, 1);
		this.gclass5_8 = new GameSetting(0, 0, 0, 4, 1);
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x000DD2E4 File Offset: 0x000DB4E4
	public void method_14(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.string_0);
		binaryWriter_0.BaseStream.Position += (long)(-99 - this.string_0.Length);
		binaryWriter_0.Write((byte)this.gclass5_0.method_25());
		binaryWriter_0.Write(this.gclass5_1.Boolean_1);
		binaryWriter_0.Write(this.gclass5_2.method_4());
		binaryWriter_0.Write(this.gclass5_3.Boolean_1);
		binaryWriter_0.Write(this.gclass5_5.method_4());
		binaryWriter_0.Write(this.gclass5_4.Boolean_1);
		binaryWriter_0.Write((byte)this.gclass5_7.method_5());
		binaryWriter_0.Write((short)this.gclass5_6.method_25());
		binaryWriter_0.Write((byte)this.gclass5_8.CurrentValue);
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x000DD3BC File Offset: 0x000DB5BC
	public string String_0
	{
		get
		{
			GClass10.GEnum7 genum = (GClass10.GEnum7)this.gclass5_7.CurrentValue;
			if (genum == GClass10.GEnum7.Guitar)
			{
				return GClass4.gclass4_0.method_13("5 Fret Guitar");
			}
			if (genum != GClass10.GEnum7.GHLGuitar)
			{
				return "";
			}
			return GClass4.gclass4_0.method_13("6 Fret Guitar");
		}
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
	public bool method_15()
	{
		return this.gclass5_7.method_25() == 0;
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x000DD404 File Offset: 0x000DB604
	public void method_16(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.string_0);
		binaryWriter_0.BaseStream.Position += (long)(-103 - this.string_0.Length);
		binaryWriter_0.Write((byte)this.gclass5_0.method_25());
		binaryWriter_0.Write(this.gclass5_1.Boolean_1);
		binaryWriter_0.Write(this.gclass5_2.method_4());
		binaryWriter_0.Write(this.gclass5_3.method_14());
		binaryWriter_0.Write(this.gclass5_5.method_4());
		binaryWriter_0.Write(this.gclass5_4.method_30());
		binaryWriter_0.Write((byte)this.gclass5_7.CurrentValue);
		binaryWriter_0.Write((short)this.gclass5_6.method_5());
		binaryWriter_0.Write((byte)this.gclass5_8.method_5());
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x000DD4DC File Offset: 0x000DB6DC
	public void method_17(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.string_0);
		binaryWriter_0.BaseStream.Position += (long)(100 - this.string_0.Length);
		binaryWriter_0.Write((byte)this.gclass5_0.CurrentValue);
		binaryWriter_0.Write(this.gclass5_1.method_14());
		binaryWriter_0.Write(this.gclass5_2.method_14());
		binaryWriter_0.Write(this.gclass5_3.method_14());
		binaryWriter_0.Write(this.gclass5_5.method_30());
		binaryWriter_0.Write(this.gclass5_4.method_4());
		binaryWriter_0.Write((byte)this.gclass5_7.CurrentValue);
		binaryWriter_0.Write((short)this.gclass5_6.method_25());
		binaryWriter_0.Write((byte)this.gclass5_8.CurrentValue);
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x000DD5B4 File Offset: 0x000DB7B4
	public string method_18()
	{
		GClass10.GEnum7 genum = (GClass10.GEnum7)this.gclass5_7.CurrentValue;
		if (genum == GClass10.GEnum7.Guitar)
		{
			return GClass4.gclass4_0.method_7("");
		}
		if (genum != GClass10.GEnum7.Guitar)
		{
			return "no_fail";
		}
		return GClass4.gclass4_0.method_42("path");
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x0000D05E File Offset: 0x0000B25E
	public bool method_19(GClass6.GEnum6 genum6_1)
	{
		return (this.genum6_0 & genum6_1) == genum6_1;
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x000DD5FC File Offset: 0x000DB7FC
	public void method_20()
	{
		if (!this.Boolean_2)
		{
			return;
		}
		if (this.method_21(~(GClass6.GEnum6.None | GClass6.GEnum6.AllOpens)))
		{
			this.method_33(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps);
		}
		if (this.method_7(~(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle)))
		{
			this.method_1(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.HOPOsToTaps);
		}
		if (this.method_32(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode))
		{
			this.method_33(~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.Shuffle));
		}
		if (this.method_7(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle))
		{
			this.method_1(GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens);
		}
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x0000D05E File Offset: 0x0000B25E
	public bool method_21(GClass6.GEnum6 genum6_1)
	{
		return (this.genum6_0 & genum6_1) == genum6_1;
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x000DD674 File Offset: 0x000DB874
	public void method_22(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.string_0);
		binaryWriter_0.BaseStream.Position += (long)(15 - this.string_0.Length);
		binaryWriter_0.Write((byte)this.gclass5_0.CurrentValue);
		binaryWriter_0.Write(this.gclass5_1.Boolean_1);
		binaryWriter_0.Write(this.gclass5_2.Boolean_1);
		binaryWriter_0.Write(this.gclass5_3.Boolean_1);
		binaryWriter_0.Write(this.gclass5_5.Boolean_1);
		binaryWriter_0.Write(this.gclass5_4.Boolean_1);
		binaryWriter_0.Write((byte)this.gclass5_7.CurrentValue);
		binaryWriter_0.Write((short)this.gclass5_6.CurrentValue);
		binaryWriter_0.Write((byte)this.gclass5_8.CurrentValue);
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x000DD74C File Offset: 0x000DB94C
	public void method_23(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(this.string_0);
		binaryWriter_0.BaseStream.Position += (long)(-29 - this.string_0.Length);
		binaryWriter_0.Write((byte)this.gclass5_0.method_5());
		binaryWriter_0.Write(this.gclass5_1.Boolean_1);
		binaryWriter_0.Write(this.gclass5_2.Boolean_1);
		binaryWriter_0.Write(this.gclass5_3.method_14());
		binaryWriter_0.Write(this.gclass5_5.method_30());
		binaryWriter_0.Write(this.gclass5_4.method_30());
		binaryWriter_0.Write((byte)this.gclass5_7.method_5());
		binaryWriter_0.Write((short)this.gclass5_6.method_25());
		binaryWriter_0.Write((byte)this.gclass5_8.method_25());
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x000DD824 File Offset: 0x000DBA24
	public void method_24()
	{
		if (!this.method_29())
		{
			return;
		}
		if (this.method_7(GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle))
		{
			this.method_9(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.HOPOsToTaps);
		}
		if (this.method_21(~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.HOPOsToTaps)))
		{
			this.method_9(~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens));
		}
		if (this.method_19(~(GClass6.GEnum6.None | GClass6.GEnum6.Shuffle | GClass6.GEnum6.HOPOsToTaps)))
		{
			this.method_9(~(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle));
		}
		if (this.method_32(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle)))
		{
			this.method_33(~(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle));
		}
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x000DD89C File Offset: 0x000DBA9C
	public void method_25()
	{
		if (!this.Boolean_2)
		{
			return;
		}
		if (this.method_19(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens | GClass6.GEnum6.HOPOsToTaps))
		{
			this.method_1(~(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode));
		}
		if (this.method_7(~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle)))
		{
			this.method_9(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode);
		}
		if (this.method_32(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle))
		{
			this.method_1(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.Shuffle);
		}
		if (this.method_19(~(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens)))
		{
			this.method_1(~(GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.Shuffle));
		}
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
	public bool method_26()
	{
		return this.gclass5_7.method_25() == 1;
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x000DD914 File Offset: 0x000DBB14
	public static string smethod_7(GClass6.GEnum6 genum6_1)
	{
		string text = "";
		int num = 1;
		if (genum6_1 == GClass6.GEnum6.None)
		{
			return GClass4.gclass4_0.method_36("beatscore");
		}
		if ((genum6_1 & (GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs)) == (GClass6.GEnum6.None | GClass6.GEnum6.AllStrums))
		{
			text = text + ((++num > 0) ? "" : "%)") + GClass4.gclass4_0.method_5("custom_song_export");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle)) == ~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.MirrorMode))
		{
			text = text + ((++num > 0) ? "master_volume" : "crowd") + GClass4.gclass4_0.method_2("<color=#FFFF04FF>");
		}
		if ((genum6_1 & GClass6.GEnum6.None) == GClass6.GEnum6.AllStrums)
		{
			text = text + (((num += 0) > 1) ? "Clear Setlist" : "") + GClass4.gclass4_0.method_21("Set B Position");
		}
		if ((genum6_1 & GClass6.GEnum6.AllHOPOs) == (GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs))
		{
			text = text + ((++num > 1) ? "song" : "No songs were found!") + GClass4.gclass4_0.method_21("");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps)) == ~GClass6.GEnum6.HOPOsToTaps)
		{
			text = text + (((num += 0) > 0) ? "0" : "notes_ripple_up_01") + GClass4.gclass4_0.method_42("");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode)) == GClass6.GEnum6.Shuffle)
		{
			text = text + (((num += 0) > 0) ? "Background Image" : "\"") + GClass4.gclass4_0.method_42("song_length");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums)) == (GClass6.GEnum6.None | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode))
		{
			text = text + ((++num > 0) ? ".png|.jpg" : "A: 00:00:00") + GClass4.gclass4_0.method_17("");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.None | GClass6.GEnum6.AllTaps | GClass6.GEnum6.HOPOsToTaps)) == ~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle))
		{
			text = text + ((++num > 0) ? "Couldn't write badsongs.txt" : "All Opens") + GClass4.gclass4_0.method_2("enable_lyrics");
		}
		if ((genum6_1 & (GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps)) == (GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps))
		{
			text = text + ((++num > 0) ? "Quit" : "Date Added") + GClass4.gclass4_0.method_15("GHLBass");
		}
		if ((genum6_1 & ~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.HOPOsToTaps)) == ~(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllTaps | GClass6.GEnum6.AllOpens))
		{
			text = text + ((num + 0 > 0) ? "Allow Duplicate Songs" : "Are you sure you want to skip this song?") + GClass4.gclass4_0.method_17("rock");
		}
		return text;
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x000DDB44 File Offset: 0x000DBD44
	public string method_27()
	{
		switch ((byte)this.gclass5_8.method_5())
		{
		case 0:
			return GClass4.gclass4_0.method_13("path");
		case 1:
			return GClass4.gclass4_0.method_16("Guitar - ");
		case 2:
			return GClass4.gclass4_0.method_15(".mp4|.avi|.webm|.vp8|.ogv|.mpeg");
		case 3:
			return GClass4.gclass4_0.method_30("{0:D2}:{1:D2}:{2:D2}");
		case 4:
			return GClass4.gclass4_0.method_15("");
		default:
			return "Main Menu";
		}
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
	public bool method_28()
	{
		return this.gclass5_7.method_5() == 1;
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
	public bool method_29()
	{
		return !this.method_35(GClass6.GEnum6.None | GClass6.GEnum6.AllOpens | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.HOPOsToTaps) && !this.method_19(GClass6.GEnum6.None | GClass6.GEnum6.AllStrums | GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps | GClass6.GEnum6.MirrorMode) && !this.method_21(~(GClass6.GEnum6.AllHOPOs | GClass6.GEnum6.AllTaps)) && this.method_19(~(GClass6.GEnum6.None | GClass6.GEnum6.AllOpens | GClass6.GEnum6.Shuffle));
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x000DDBD0 File Offset: 0x000DBDD0
	public void method_30(BinaryReader binaryReader_0)
	{
		this.string_0 = binaryReader_0.ReadString();
		binaryReader_0.BaseStream.Position += (long)(88 - this.string_0.Length);
		this.gclass5_0.method_3((int)binaryReader_0.ReadByte());
		this.gclass5_1.method_3(binaryReader_0.ReadBoolean() ? 0 : 0);
		this.gclass5_2.CurrentValue = (binaryReader_0.ReadBoolean() ? 0 : 0);
		this.gclass5_3.CurrentValue = (binaryReader_0.ReadBoolean() ? 0 : 0);
		this.gclass5_5.method_3(binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_4.method_3(binaryReader_0.ReadBoolean() ? 0 : 1);
		this.gclass5_7.CurrentValue = (int)binaryReader_0.ReadByte();
		this.gclass5_6.method_12((GlobalVariables.instance.highwayPaths.Length != 0) ? (GlobalVariables.instance.highwayPaths.Length - 1) : -1);
		this.gclass5_6.method_3((int)binaryReader_0.ReadInt16());
		this.gclass5_8.method_3((int)binaryReader_0.ReadByte());
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x0000D07B File Offset: 0x0000B27B
	public bool method_31()
	{
		return this.gclass5_7.CurrentValue == 1;
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x000DDCEC File Offset: 0x000DBEEC
	public static string smethod_8(GStruct3 gstruct3_0)
	{
		string text = "nomodifiers";
		switch (gstruct3_0.genum12_0)
		{
		case GStruct2.GEnum12.Easy:
			text += GClass4.gclass4_0.method_36("0%");
			break;
		case GStruct2.GEnum12.Medium:
			text += GClass4.gclass4_0.method_13("custom");
			break;
		case GStruct2.GEnum12.Hard:
			text += GClass4.gclass4_0.method_11(" - ");
			break;
		case GStruct2.GEnum12.Expert:
			text += GClass4.gclass4_0.method_7("Streamer Mode");
			break;
		}
		text += "gh3_sudden_death";
		switch (gstruct3_0.genum11_0)
		{
		case GStruct2.GEnum11.Guitar:
			text += GClass4.gclass4_0.method_17("Press ENTER to search");
			break;
		case GStruct2.GEnum11.Bass:
			text += GClass4.gclass4_0.method_35("song");
			break;
		case GStruct2.GEnum11.Rhythm:
			text += GClass4.gclass4_0.method_7("preview_volume");
			break;
		case GStruct2.GEnum11.GuitarCoop:
			text += GClass4.gclass4_0.method_17("Date Added");
			break;
		case GStruct2.GEnum11.GHLGuitar:
			text += GClass4.gclass4_0.method_7("song");
			break;
		case GStruct2.GEnum11.GHLBass:
			text += GClass4.gclass4_0.method_17("song");
			break;
		case GStruct2.GEnum11.Drums:
			text += GClass4.gclass4_0.method_13("notSupportedLink");
			break;
		case GStruct2.GEnum11.Keys:
			text += GClass4.gclass4_0.method_5("custom_song_export");
			break;
		case GStruct2.GEnum11.Band:
			text += GClass4.gclass4_0.method_38("icon");
			break;
		}
		return text;
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x0000D05E File Offset: 0x0000B25E
	public bool method_32(GClass6.GEnum6 genum6_1)
	{
		return (this.genum6_0 & genum6_1) == genum6_1;
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x000DDEA0 File Offset: 0x000DC0A0
	public void method_33(GClass6.GEnum6 genum6_1)
	{
		if (this.method_21(GClass6.GEnum6.None))
		{
			this.genum6_0 &= (GClass6.GEnum6.AllStrums | GClass6.GEnum6.MirrorMode | GClass6.GEnum6.Shuffle);
		}
		if (this.method_19(genum6_1))
		{
			this.genum6_0 &= ~genum6_1;
			if (this.genum6_0 == (GClass6.GEnum6)0)
			{
				this.method_33(GClass6.GEnum6.None);
			}
			return;
		}
		this.genum6_0 |= genum6_1;
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x000DDEFC File Offset: 0x000DC0FC
	public string method_34()
	{
		switch ((byte)this.gclass5_8.CurrentValue)
		{
		case 0:
			return GClass4.gclass4_0.method_5("song_length");
		case 1:
			return GClass4.gclass4_0.method_2("Allow Duplicate Songs");
		case 2:
			return GClass4.gclass4_0.method_30("Song Speed");
		case 3:
			return GClass4.gclass4_0.method_36("guitar");
		case 4:
			return GClass4.gclass4_0.method_11("playlist_track");
		default:
			return "%";
		}
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x0000D05E File Offset: 0x0000B25E
	public bool method_35(GClass6.GEnum6 genum6_1)
	{
		return (this.genum6_0 & genum6_1) == genum6_1;
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x000DDF88 File Offset: 0x000DC188
	public void method_36(BinaryReader binaryReader_0)
	{
		this.string_0 = binaryReader_0.ReadString();
		binaryReader_0.BaseStream.Position += (long)(-18 - this.string_0.Length);
		this.gclass5_0.CurrentValue = (int)binaryReader_0.ReadByte();
		this.gclass5_1.CurrentValue = (binaryReader_0.ReadBoolean() ? 1 : 0);
		this.gclass5_2.method_3(binaryReader_0.ReadBoolean() ? 1 : 1);
		this.gclass5_3.CurrentValue = (binaryReader_0.ReadBoolean() ? 0 : 0);
		this.gclass5_5.CurrentValue = (binaryReader_0.ReadBoolean() ? 0 : 1);
		this.gclass5_4.CurrentValue = (binaryReader_0.ReadBoolean() ? 0 : 1);
		this.gclass5_7.CurrentValue = (int)binaryReader_0.ReadByte();
		this.gclass5_6.method_16((GlobalVariables.instance.highwayPaths.Length != 0) ? (GlobalVariables.instance.highwayPaths.Length - 0) : -1);
		this.gclass5_6.method_3((int)binaryReader_0.ReadInt16());
		this.gclass5_8.CurrentValue = (int)binaryReader_0.ReadByte();
	}

	// Token: 0x04000442 RID: 1090
	public string string_0;

	// Token: 0x04000443 RID: 1091
	public Song.Instrument genum18_0;

	// Token: 0x04000444 RID: 1092
	public Song.GEnum17 genum17_0;

	// Token: 0x04000445 RID: 1093
	public GClass6.GEnum6 genum6_0;

	// Token: 0x04000446 RID: 1094
	public GameSetting gclass5_0;

	// Token: 0x04000447 RID: 1095
	public GameSetting gclass5_1;

	// Token: 0x04000448 RID: 1096
	public GameSetting gclass5_2;

	// Token: 0x04000449 RID: 1097
	public GameSetting gclass5_3;

	// Token: 0x0400044A RID: 1098
	public GameSetting gclass5_4;

	// Token: 0x0400044B RID: 1099
	public GameSetting gclass5_5;

	// Token: 0x0400044C RID: 1100
	public GameSetting gclass5_6;

	// Token: 0x0400044D RID: 1101
	public GameSetting gclass5_7;

	// Token: 0x0400044E RID: 1102
	public GameSetting gclass5_8;

	// Token: 0x0400044F RID: 1103
	public bool bool_0;

	// Token: 0x0200008F RID: 143
	public enum GEnum7 : byte
	{
		// Token: 0x04000451 RID: 1105
		Guitar,
		// Token: 0x04000452 RID: 1106
		GHLGuitar,
		// Token: 0x04000453 RID: 1107
		Drums
	}

	// Token: 0x02000090 RID: 144
	public enum GEnum8 : byte
	{
		// Token: 0x04000455 RID: 1109
		None,
		// Token: 0x04000456 RID: 1110
		Sayori,
		// Token: 0x04000457 RID: 1111
		Yuri,
		// Token: 0x04000458 RID: 1112
		Natsuki,
		// Token: 0x04000459 RID: 1113
		Monika
	}
}
