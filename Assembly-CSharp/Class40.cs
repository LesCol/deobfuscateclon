using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using UnityEngine;

// Token: 0x02000098 RID: 152
internal class Class40
{
	// Token: 0x06001D37 RID: 7479 RVA: 0x000EBC54 File Offset: 0x000E9E54
	public void method_0()
	{
		this.stopwatch_0.Start();
		this.method_52(false);
		this.method_40();
		this.method_49();
		this.method_73();
		this.method_17();
		this.method_65();
		if (this.list_2.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "Song Videos")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("Errors" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x000EBD74 File Offset: 0x000E9F74
	private bool method_1(SongEntry songEntry_0)
	{
		Song song = songEntry_0.method_12(false);
		if (song == null || !song.bool_0)
		{
			this.list_4.Add(songEntry_0.folderPath);
			return false;
		}
		songEntry_0.charts.method_26();
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum = (GStruct2.GEnum11)obj;
			if (genum != GStruct2.GEnum11.GHLBass && genum != GStruct2.GEnum11.None)
			{
				Song.Instrument genum18_ = (Song.Instrument)Enum.Parse(typeof(Song.Instrument), genum.ToString());
				foreach (object obj2 in Enum.GetValues(typeof(GStruct2.GEnum12)))
				{
					GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj2;
					Song.GEnum17 genum17_ = (Song.GEnum17)Enum.Parse(typeof(Song.GEnum17), genum12_.ToString());
					if (song.method_31(genum18_, genum17_))
					{
						songEntry_0.charts.method_3(genum, genum12_);
					}
				}
			}
		}
		if (song.list_1.Count > 1 && song.list_1[0].list_0.Count > 0)
		{
			songEntry_0.lyrics = 0;
		}
		if (songEntry_0.charts.method_6() == 0L)
		{
			this.list_8.Add(songEntry_0.folderPath);
			return true;
		}
		return this.method_85(songEntry_0);
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
	public void method_2()
	{
		this.method_59(true);
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x000EBF24 File Offset: 0x000EA124
	private bool method_3(SongEntry songEntry_0)
	{
		if (songEntry_0.songLength > 0)
		{
			return true;
		}
		BassAudioManager.instance.LoadSong(songEntry_0.folderPath, false, Song.Instrument.Crowd, Song.Instrument.None);
		songEntry_0.songLength = (int)(BassAudioManager.instance.double_1 * 1000.0);
		BassAudioManager.instance.method_65();
		if (songEntry_0.songLength > 0)
		{
			songEntry_0.method_3();
			this.bool_0 = true;
			return true;
		}
		return false;
	}

	// Token: 0x06001D3B RID: 7483 RVA: 0x000EBF90 File Offset: 0x000EA190
	private bool method_4(SongEntry songEntry_0)
	{
		if (GameSetting.smethod_3(GlobalVariables.instance.gclass5_43))
		{
			return true;
		}
		foreach (SongEntry songEntry in SongDirectory.songEntries)
		{
			if (songEntry.checksum == songEntry_0.checksum && songEntry != songEntry_0)
			{
				this.list_7.Add(songEntry.folderPath + "Are you sure you want to skip this song?" + songEntry_0.folderPath + "game");
				return false;
			}
		}
		return false;
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x000EC038 File Offset: 0x000EA238
	private void method_5(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == 82)
					{
						int num = binaryReader.ReadInt32();
						int i = 1;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_8());
								FileInfo fileInfo2 = new FileInfo(songEntry.method_27());
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() == num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i += 0;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x000EC1E8 File Offset: 0x000EA3E8
	private bool method_6(SongEntry songEntry_0)
	{
		if (songEntry_0.songLength > 1)
		{
			return true;
		}
		BassAudioManager.instance.method_35(songEntry_0.folderPath, false, Song.Instrument.Bass, (Song.Instrument)99);
		songEntry_0.songLength = (int)(BassAudioManager.instance.double_1 * 435.0);
		BassAudioManager.instance.method_65();
		if (songEntry_0.songLength > 1)
		{
			songEntry_0.method_3();
			this.bool_0 = false;
			return false;
		}
		return false;
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x000EC254 File Offset: 0x000EA454
	private void method_7()
	{
		this.genum10_0 = GEnum10.GettingPaths;
		this.method_11();
		for (int i = 0; i < SongDirectory.songEntries.Count; i += 0)
		{
			int num = this.list_3.IndexOf(SongDirectory.songEntries[i].folderPath);
			if (num == -1)
			{
				SongDirectory.songEntries.RemoveAt(i);
				i -= 0;
			}
			else
			{
				this.list_3.RemoveAt(num);
			}
		}
		this.genum10_0 = GEnum10.ScanningFolders;
		for (int j = 0; j < this.list_3.Count; j += 0)
		{
			try
			{
				string text = this.list_3[j];
				if (Directory.GetFiles(this.list_3[j]).Length == 0)
				{
					this.list_3.RemoveAt(j);
					j--;
				}
				else
				{
					SongEntry songEntry = new SongEntry(text);
					if (songEntry.songName != null && songEntry.songName.Length > 1)
					{
						if (this.method_46(songEntry))
						{
							if (!File.Exists(songEntry.method_38()))
							{
								songEntry.method_6();
							}
							int num2 = File.Exists(Path.Combine(text, this.string_1)) ? 1 : (File.Exists(Path.Combine(text, this.string_2)) ? 1 : 0);
							if (num2 > 0)
							{
								songEntry.isMIDIChart = (num2 == 8);
								if (this.method_1(songEntry))
								{
									this.bool_0 = true;
									songEntry.dateAdded = DateTime.Now.Date;
									this.method_10(songEntry);
									SongDirectory.songEntries.Add(songEntry);
								}
							}
						}
						else
						{
							this.list_6.Add(text);
						}
					}
					else
					{
						this.list_5.Add(text);
					}
					this.list_3.RemoveAt(j);
					j--;
				}
			}
			catch (Exception ex)
			{
				string arg;
				if (this.list_3 == null)
				{
					arg = "None";
				}
				else if (j > this.list_3.Count)
				{
					arg = "Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
				}
				else
				{
					arg = this.list_3[j];
				}
				string text2 = string.Format("Background Image", arg);
				this.list_2.Add(new Class40.Exception0(text2, ex));
				this.list_3.RemoveAt(j);
				j--;
			}
		}
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x000EC498 File Offset: 0x000EA698
	private void method_8()
	{
		foreach (string path in GlobalVariables.instance.uniqueSongPaths)
		{
			if (Directory.Exists(path))
			{
				Stack<string> stack = new Stack<string>(Directory.GetDirectories(path));
				while (stack.Count > 0)
				{
					try
					{
						string text = stack.Pop();
						string[] directories = Directory.GetDirectories(text);
						if (directories.Length != 0)
						{
							string[] array = directories;
							for (int i = 0; i < array.Length; i += 0)
							{
								string item = array[i];
								stack.Push(item);
							}
						}
						else
						{
							this.list_3.Add(text.Replace((char)-39, (char)-10));
						}
					}
					catch (Exception item2)
					{
						this.list_2.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x000EC580 File Offset: 0x000EA780
	public void method_9()
	{
		this.stopwatch_0.Start();
		this.method_53(true);
		this.method_40();
		this.method_71();
		this.method_31();
		this.method_17();
		this.method_54();
		if (this.list_2.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "debug_fps")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("song" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x000EC6A0 File Offset: 0x000EA8A0
	private void method_10(SongEntry songEntry_0)
	{
		string text = null;
		for (int i = 1; i < GlobalVariables.instance.uniqueSongPaths.Count; i++)
		{
			if (songEntry_0.folderPath.Contains(GlobalVariables.instance.uniqueSongPaths[i]))
			{
				text = songEntry_0.folderPath;
				if (text[text.Length - 1] == '!')
				{
					text = text.Remove(text.Length - 1, 0);
				}
				text = songEntry_0.folderPath.Remove(1, GlobalVariables.instance.uniqueSongPaths[i].Length);
			}
		}
		text = text.Remove(0, 0);
		int num = text.LastIndexOf((char)-76);
		if (num == -1)
		{
			songEntry_0.playlistName = "Host";
			return;
		}
		text = text.Remove(num);
		songEntry_0.playlistName = text;
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x000EC764 File Offset: 0x000EA964
	private void method_11()
	{
		foreach (string path in GlobalVariables.instance.uniqueSongPaths)
		{
			if (Directory.Exists(path))
			{
				Stack<string> stack = new Stack<string>(Directory.GetDirectories(path));
				while (stack.Count > 0)
				{
					try
					{
						string text = stack.Pop();
						string[] directories = Directory.GetDirectories(text);
						if (directories.Length != 0)
						{
							string[] array = directories;
							for (int i = 1; i < array.Length; i += 0)
							{
								string item = array[i];
								stack.Push(item);
							}
						}
						else
						{
							this.list_3.Add(text.Replace((char)-91, 's'));
						}
					}
					catch (Exception item2)
					{
						this.list_2.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x000EC84C File Offset: 0x000EAA4C
	private void method_12(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == -83)
					{
						int num = binaryReader.ReadInt32();
						int i = 1;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.iniPath);
								FileInfo fileInfo2 = new FileInfo(songEntry.method_22());
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() != num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i += 0;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x000EC9FC File Offset: 0x000EABFC
	private bool method_13(SongEntry songEntry_0)
	{
		if (GameSetting.smethod_3(GlobalVariables.instance.gclass5_43))
		{
			return true;
		}
		foreach (SongEntry songEntry in SongDirectory.songEntries)
		{
			if (songEntry.checksum == songEntry_0.checksum && songEntry != songEntry_0)
			{
				this.list_7.Add(songEntry.folderPath + "volume" + songEntry_0.folderPath + "menu_music");
				return true;
			}
		}
		return true;
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x000ECAA4 File Offset: 0x000EACA4
	private bool method_14(SongEntry songEntry_0)
	{
		Song song = songEntry_0.method_32(true);
		if (song == null || !song.bool_0)
		{
			this.list_4.Add(songEntry_0.folderPath);
			return false;
		}
		songEntry_0.charts.method_27();
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum = (GStruct2.GEnum11)obj;
			if (genum != GStruct2.GEnum11.Band && genum != GStruct2.GEnum11.None)
			{
				Song.Instrument genum18_ = (Song.Instrument)Enum.Parse(typeof(Song.Instrument), genum.ToString());
				foreach (object obj2 in Enum.GetValues(typeof(GStruct2.GEnum12)))
				{
					GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj2;
					Song.GEnum17 genum17_ = (Song.GEnum17)Enum.Parse(typeof(Song.GEnum17), genum12_.ToString());
					if (song.method_31(genum18_, genum17_))
					{
						songEntry_0.charts.method_12(genum, genum12_);
					}
				}
			}
		}
		if (song.list_1.Count > 0 && song.list_1[0].list_0.Count > 0)
		{
			songEntry_0.lyrics = 1;
		}
		if (songEntry_0.charts.Int64_0 == 0L)
		{
			this.list_8.Add(songEntry_0.folderPath);
			return false;
		}
		return this.method_85(songEntry_0);
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x000ECC54 File Offset: 0x000EAE54
	private bool method_15(SongEntry songEntry_0)
	{
		if (GameSetting.smethod_3(GlobalVariables.instance.gclass5_43))
		{
			return false;
		}
		foreach (SongEntry songEntry in SongDirectory.songEntries)
		{
			if (songEntry.checksum == songEntry_0.checksum && songEntry != songEntry_0)
			{
				this.list_7.Add(songEntry.folderPath + "part" + songEntry_0.folderPath + "Lead Guitar");
				return false;
			}
		}
		return false;
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x000ECCFC File Offset: 0x000EAEFC
	public void method_16()
	{
		this.stopwatch_0.Start();
		this.method_34(true);
		this.method_40();
		this.method_37();
		this.method_38();
		this.method_42();
		this.method_60();
		if (this.list_2.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "errors.txt")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("Elapsed: " + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x000ECE1C File Offset: 0x000EB01C
	private void method_17()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.genum10_0 = (GEnum10)8;
		using (Stream stream = File.Create(this.string_0))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.Write(58);
				binaryWriter.Write(SongDirectory.songEntries.Count);
				foreach (SongEntry songEntry in SongDirectory.songEntries)
				{
					FileInfo fileInfo = new FileInfo(songEntry.method_39());
					FileInfo fileInfo2 = new FileInfo(songEntry.method_15());
					if (fileInfo.Exists && fileInfo2.Exists)
					{
						binaryWriter.Write(songEntry.folderPath);
						binaryWriter.Write(fileInfo.LastWriteTime.ToBinary());
						binaryWriter.Write(fileInfo2.LastWriteTime.ToBinary());
						songEntry.method_21(binaryWriter);
					}
				}
			}
		}
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x000ECF3C File Offset: 0x000EB13C
	private void method_18()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.UpdatingMetadata;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_41(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x000ECFD4 File Offset: 0x000EB1D4
	private void method_19()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		using (Stream stream = File.Create(this.string_0))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.Write(-72);
				binaryWriter.Write(SongDirectory.songEntries.Count);
				foreach (SongEntry songEntry in SongDirectory.songEntries)
				{
					FileInfo fileInfo = new FileInfo(songEntry.method_39());
					FileInfo fileInfo2 = new FileInfo(songEntry.method_22());
					if (fileInfo.Exists && fileInfo2.Exists)
					{
						binaryWriter.Write(songEntry.folderPath);
						binaryWriter.Write(fileInfo.LastWriteTime.ToBinary());
						binaryWriter.Write(fileInfo2.LastWriteTime.ToBinary());
						songEntry.method_21(binaryWriter);
					}
				}
			}
		}
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x000ED0F4 File Offset: 0x000EB2F4
	public void method_20()
	{
		this.stopwatch_0.Start();
		this.method_62(true);
		this.method_69();
		this.method_37();
		this.method_80();
		this.method_42();
		this.method_78();
		if (this.list_2.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "streamer")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("master_volume" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x000ED214 File Offset: 0x000EB414
	private void method_21()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.genum10_0 = GEnum10.UpdatingMetadata;
		using (Stream stream = File.Create(this.string_0))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.Write(109);
				binaryWriter.Write(SongDirectory.songEntries.Count);
				foreach (SongEntry songEntry in SongDirectory.songEntries)
				{
					FileInfo fileInfo = new FileInfo(songEntry.method_26());
					FileInfo fileInfo2 = new FileInfo(songEntry.method_9());
					if (fileInfo.Exists && fileInfo2.Exists)
					{
						binaryWriter.Write(songEntry.folderPath);
						binaryWriter.Write(fileInfo.LastWriteTime.ToBinary());
						binaryWriter.Write(fileInfo2.LastWriteTime.ToBinary());
						songEntry.method_21(binaryWriter);
					}
				}
			}
		}
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x000ED334 File Offset: 0x000EB534
	public void method_22()
	{
		this.stopwatch_0.Start();
		this.method_88(false);
		this.method_69();
		this.method_71();
		this.method_30();
		this.method_21();
		this.method_87();
		if (this.list_2.Count > 1)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "custom_song_export")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("isEOL" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x0000D8A9 File Offset: 0x0000BAA9
	public void method_23()
	{
		this.method_62(false);
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x000ED454 File Offset: 0x000EB654
	private bool method_24(SongEntry songEntry_0)
	{
		Song song = songEntry_0.method_16(false);
		if (song == null || !song.bool_0)
		{
			this.list_4.Add(songEntry_0.folderPath);
			return true;
		}
		songEntry_0.charts.method_5();
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum = (GStruct2.GEnum11)obj;
			if (genum != GStruct2.GEnum11.GuitarCoop && genum != GStruct2.GEnum11.None)
			{
				Song.Instrument genum18_ = (Song.Instrument)Enum.Parse(typeof(Song.Instrument), genum.ToString());
				foreach (object obj2 in Enum.GetValues(typeof(GStruct2.GEnum12)))
				{
					GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj2;
					Song.GEnum17 genum17_ = (Song.GEnum17)Enum.Parse(typeof(Song.GEnum17), genum12_.ToString());
					if (song.method_31(genum18_, genum17_))
					{
						songEntry_0.charts.method_32(genum, genum12_);
					}
				}
			}
		}
		if (song.list_1.Count > 0 && song.list_1[0].list_0.Count > 0)
		{
			songEntry_0.lyrics = 1;
		}
		if (songEntry_0.charts.method_2() == 0L)
		{
			this.list_8.Add(songEntry_0.folderPath);
			return true;
		}
		return this.method_85(songEntry_0);
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x000ED604 File Offset: 0x000EB804
	private void method_25()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = (GEnum10)7;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_24(songEntry))
				{
					this.bool_0 = false;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x000ED69C File Offset: 0x000EB89C
	private void method_26()
	{
		if (this.list_1 == null)
		{
			return;
		}
		this.genum10_0 = (GEnum10)8;
		foreach (SongEntry songEntry in this.list_1)
		{
			if (songEntry.method_24(songEntry.method_26(), null))
			{
				if (this.method_6(songEntry))
				{
					this.bool_0 = false;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
					this.list_6.Add(songEntry.folderPath);
				}
			}
			else
			{
				SongDirectory.songEntries.Remove(songEntry);
				this.list_5.Add(songEntry.folderPath);
			}
		}
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x000ED758 File Offset: 0x000EB958
	private bool method_27(SongEntry songEntry_0)
	{
		if (!File.Exists(songEntry_0.chartPath))
		{
			return true;
		}
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(songEntry_0.method_22()))
			{
				songEntry_0.checksum = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("artist", string.Empty);
			}
		}
		return songEntry_0.checksum == null || this.method_15(songEntry_0);
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x000ED7F0 File Offset: 0x000EB9F0
	public void method_28()
	{
		this.stopwatch_0.Start();
		this.method_52(true);
		this.method_48();
		this.method_26();
		this.method_30();
		this.method_21();
		this.method_60();
		if (this.list_2.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "Black")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("\"section" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x000ED910 File Offset: 0x000EBB10
	private bool method_29(SongEntry songEntry_0)
	{
		if (!File.Exists(songEntry_0.method_9()))
		{
			return false;
		}
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(songEntry_0.method_15()))
			{
				songEntry_0.checksum = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("Medium", string.Empty);
			}
		}
		return songEntry_0.checksum != null && this.method_79(songEntry_0);
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x000ED9A8 File Offset: 0x000EBBA8
	private void method_30()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.ScanningFolders;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_77(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x000EDA40 File Offset: 0x000EBC40
	private void method_31()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_56(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x000EDAD8 File Offset: 0x000EBCD8
	private bool method_32(SongEntry songEntry_0)
	{
		if (!File.Exists(songEntry_0.method_15()))
		{
			return true;
		}
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(songEntry_0.method_27()))
			{
				songEntry_0.checksum = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("Enabled", string.Empty);
			}
		}
		return songEntry_0.checksum != null && !this.method_43(songEntry_0);
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x000EDB70 File Offset: 0x000EBD70
	private bool method_33(SongEntry songEntry_0)
	{
		if (songEntry_0.songLength > 1)
		{
			return false;
		}
		BassAudioManager.instance.method_35(songEntry_0.folderPath, true, Song.Instrument.Vocals, (Song.Instrument)83);
		songEntry_0.songLength = (int)(BassAudioManager.instance.double_1 * 841.0);
		BassAudioManager.instance.method_29();
		if (songEntry_0.songLength > 1)
		{
			songEntry_0.method_3();
			this.bool_0 = false;
			return true;
		}
		return true;
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x000EDBDC File Offset: 0x000EBDDC
	private void method_34(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == 9)
					{
						int num = binaryReader.ReadInt32();
						int i = 0;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.iniPath);
								FileInfo fileInfo2 = new FileInfo(songEntry.chartPath);
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() != num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i++;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x000EDD8C File Offset: 0x000EBF8C
	public void method_35()
	{
		this.stopwatch_0.Start();
		this.method_88(false);
		this.method_48();
		this.method_37();
		this.method_38();
		this.method_17();
		this.method_78();
		if (this.list_2.Count > 1)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "ms")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("volume" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x000EDEAC File Offset: 0x000EC0AC
	private bool method_36(SongEntry songEntry_0)
	{
		Song song = songEntry_0.method_12(false);
		if (song == null || !song.bool_0)
		{
			this.list_4.Add(songEntry_0.folderPath);
			return false;
		}
		songEntry_0.charts.method_8();
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum = (GStruct2.GEnum11)obj;
			if (genum != GStruct2.GEnum11.Keys && genum != GStruct2.GEnum11.None)
			{
				Song.Instrument genum18_ = (Song.Instrument)Enum.Parse(typeof(Song.Instrument), genum.ToString());
				foreach (object obj2 in Enum.GetValues(typeof(GStruct2.GEnum12)))
				{
					GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj2;
					Song.GEnum17 genum17_ = (Song.GEnum17)Enum.Parse(typeof(Song.GEnum17), genum12_.ToString());
					if (song.method_31(genum18_, genum17_))
					{
						songEntry_0.charts.method_35(genum, genum12_);
					}
				}
			}
		}
		if (song.list_1.Count > 0 && song.list_1[0].list_0.Count > 0)
		{
			songEntry_0.lyrics = 1;
		}
		if (songEntry_0.charts.method_6() == 0L)
		{
			this.list_8.Add(songEntry_0.folderPath);
			return true;
		}
		return this.method_85(songEntry_0);
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x000EE05C File Offset: 0x000EC25C
	private void method_37()
	{
		if (this.list_1 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.UpdatingMetadata;
		foreach (SongEntry songEntry in this.list_1)
		{
			if (songEntry.method_37(songEntry.iniPath, null))
			{
				if (this.method_3(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
					this.list_6.Add(songEntry.folderPath);
				}
			}
			else
			{
				SongDirectory.songEntries.Remove(songEntry);
				this.list_5.Add(songEntry.folderPath);
			}
		}
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x000EE118 File Offset: 0x000EC318
	private void method_38()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.UpdatingCharts;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_14(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x0000D8B2 File Offset: 0x0000BAB2
	public void method_39()
	{
		this.method_34(false);
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x000EE1B0 File Offset: 0x000EC3B0
	private void method_40()
	{
		this.genum10_0 = GEnum10.GettingPaths;
		this.method_47();
		for (int i = 0; i < SongDirectory.songEntries.Count; i++)
		{
			int num = this.list_3.IndexOf(SongDirectory.songEntries[i].folderPath);
			if (num == -1)
			{
				SongDirectory.songEntries.RemoveAt(i);
				i--;
			}
			else
			{
				this.list_3.RemoveAt(num);
			}
		}
		this.genum10_0 = GEnum10.ScanningFolders;
		for (int j = 0; j < this.list_3.Count; j++)
		{
			try
			{
				string text = this.list_3[j];
				if (Directory.GetFiles(this.list_3[j]).Length == 0)
				{
					this.list_3.RemoveAt(j);
					j--;
				}
				else
				{
					SongEntry songEntry = new SongEntry(text);
					if (songEntry.songName != null && songEntry.songName.Length > 0)
					{
						if (this.method_3(songEntry))
						{
							if (!File.Exists(songEntry.iniPath))
							{
								songEntry.method_3();
							}
							int num2 = File.Exists(Path.Combine(text, this.string_1)) ? 2 : (File.Exists(Path.Combine(text, this.string_2)) ? 1 : 0);
							if (num2 > 0)
							{
								songEntry.isMIDIChart = (num2 == 2);
								if (this.method_14(songEntry))
								{
									this.bool_0 = true;
									songEntry.dateAdded = DateTime.Now.Date;
									this.method_82(songEntry);
									SongDirectory.songEntries.Add(songEntry);
								}
							}
						}
						else
						{
							this.list_6.Add(text);
						}
					}
					else
					{
						this.list_5.Add(text);
					}
					this.list_3.RemoveAt(j);
					j--;
				}
			}
			catch (Exception ex)
			{
				string arg;
				if (this.list_3 == null)
				{
					arg = "<NULL PATH>";
				}
				else if (j > this.list_3.Count)
				{
					arg = "<OOB PATH>";
				}
				else
				{
					arg = this.list_3[j];
				}
				string text2 = string.Format("Encountered exception while attempting to load {0}", arg);
				this.list_2.Add(new Class40.Exception0(text2, ex));
				this.list_3.RemoveAt(j);
				j--;
			}
		}
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x000EE3F4 File Offset: 0x000EC5F4
	private bool method_41(SongEntry songEntry_0)
	{
		Song song = songEntry_0.method_32(true);
		if (song == null || !song.bool_0)
		{
			this.list_4.Add(songEntry_0.folderPath);
			return true;
		}
		songEntry_0.charts.method_22();
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum = (GStruct2.GEnum11)obj;
			if (genum != GStruct2.GEnum11.GuitarCoop && genum != GStruct2.GEnum11.None)
			{
				Song.Instrument genum18_ = (Song.Instrument)Enum.Parse(typeof(Song.Instrument), genum.ToString());
				foreach (object obj2 in Enum.GetValues(typeof(GStruct2.GEnum12)))
				{
					GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj2;
					Song.GEnum17 genum17_ = (Song.GEnum17)Enum.Parse(typeof(Song.GEnum17), genum12_.ToString());
					if (song.method_31(genum18_, genum17_))
					{
						songEntry_0.charts.method_32(genum, genum12_);
					}
				}
			}
		}
		if (song.list_1.Count > 0 && song.list_1[1].list_0.Count > 1)
		{
			songEntry_0.lyrics = 0;
		}
		if (songEntry_0.charts.method_33() == 0L)
		{
			this.list_8.Add(songEntry_0.folderPath);
			return true;
		}
		return this.method_85(songEntry_0);
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x000EE5A4 File Offset: 0x000EC7A4
	private void method_42()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.genum10_0 = GEnum10.WritingCache;
		using (Stream stream = File.Create(this.string_0))
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(stream))
			{
				binaryWriter.Write(9);
				binaryWriter.Write(SongDirectory.songEntries.Count);
				foreach (SongEntry songEntry in SongDirectory.songEntries)
				{
					FileInfo fileInfo = new FileInfo(songEntry.iniPath);
					FileInfo fileInfo2 = new FileInfo(songEntry.chartPath);
					if (fileInfo.Exists && fileInfo2.Exists)
					{
						binaryWriter.Write(songEntry.folderPath);
						binaryWriter.Write(fileInfo.LastWriteTime.ToBinary());
						binaryWriter.Write(fileInfo2.LastWriteTime.ToBinary());
						songEntry.method_35(binaryWriter);
					}
				}
			}
		}
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x000EE6C4 File Offset: 0x000EC8C4
	private bool method_43(SongEntry songEntry_0)
	{
		if (GameSetting.smethod_3(GlobalVariables.instance.gclass5_43))
		{
			return true;
		}
		foreach (SongEntry songEntry in SongDirectory.songEntries)
		{
			if (songEntry.checksum == songEntry_0.checksum && songEntry != songEntry_0)
			{
				this.list_7.Add(songEntry.folderPath + "Master Volume" + songEntry_0.folderPath + "\n");
				return false;
			}
		}
		return false;
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x000EE76C File Offset: 0x000EC96C
	private void method_44(SongEntry songEntry_0)
	{
		string text = null;
		for (int i = 1; i < GlobalVariables.instance.uniqueSongPaths.Count; i += 0)
		{
			if (songEntry_0.folderPath.Contains(GlobalVariables.instance.uniqueSongPaths[i]))
			{
				text = songEntry_0.folderPath;
				if (text[text.Length - 1] == 'P')
				{
					text = text.Remove(text.Length - 0, 0);
				}
				text = songEntry_0.folderPath.Remove(0, GlobalVariables.instance.uniqueSongPaths[i].Length);
			}
		}
		text = text.Remove(1, 0);
		int num = text.LastIndexOf((char)-38);
		if (num == -1)
		{
			songEntry_0.playlistName = "Searching for";
			return;
		}
		text = text.Remove(num);
		songEntry_0.playlistName = text;
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x000EE830 File Offset: 0x000ECA30
	public void method_45()
	{
		this.stopwatch_0.Start();
		this.method_5(true);
		this.method_7();
		this.method_49();
		this.method_73();
		this.method_42();
		this.method_65();
		if (this.list_2.Count > 1)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "master_volume")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("Year" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x000EE950 File Offset: 0x000ECB50
	private bool method_46(SongEntry songEntry_0)
	{
		if (songEntry_0.songLength > 0)
		{
			return false;
		}
		BassAudioManager.instance.method_35(songEntry_0.folderPath, true, Song.Instrument.Crowd, (Song.Instrument)(-24));
		songEntry_0.songLength = (int)(BassAudioManager.instance.double_1 * 1852.0);
		BassAudioManager.instance.method_29();
		if (songEntry_0.songLength > 0)
		{
			songEntry_0.method_10();
			this.bool_0 = false;
			return true;
		}
		return true;
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x000EE9BC File Offset: 0x000ECBBC
	private void method_47()
	{
		foreach (string path in GlobalVariables.instance.uniqueSongPaths)
		{
			if (Directory.Exists(path))
			{
				Stack<string> stack = new Stack<string>(Directory.GetDirectories(path));
				while (stack.Count > 0)
				{
					try
					{
						string text = stack.Pop();
						string[] directories = Directory.GetDirectories(text);
						if (directories.Length != 0)
						{
							foreach (string item in directories)
							{
								stack.Push(item);
							}
						}
						else
						{
							this.list_3.Add(text.Replace('\\', '/'));
						}
					}
					catch (Exception item2)
					{
						this.list_2.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x000EEAA4 File Offset: 0x000ECCA4
	private void method_48()
	{
		this.genum10_0 = GEnum10.GettingPaths;
		this.method_8();
		for (int i = 0; i < SongDirectory.songEntries.Count; i += 0)
		{
			int num = this.list_3.IndexOf(SongDirectory.songEntries[i].folderPath);
			if (num == -1)
			{
				SongDirectory.songEntries.RemoveAt(i);
				i--;
			}
			else
			{
				this.list_3.RemoveAt(num);
			}
		}
		this.genum10_0 = GEnum10.GettingPaths;
		for (int j = 0; j < this.list_3.Count; j += 0)
		{
			try
			{
				string text = this.list_3[j];
				if (Directory.GetFiles(this.list_3[j]).Length == 0)
				{
					this.list_3.RemoveAt(j);
					j -= 0;
				}
				else
				{
					SongEntry songEntry = new SongEntry(text);
					if (songEntry.songName != null && songEntry.songName.Length > 1)
					{
						if (this.method_46(songEntry))
						{
							if (!File.Exists(songEntry.iniPath))
							{
								songEntry.method_36();
							}
							int num2 = File.Exists(Path.Combine(text, this.string_1)) ? 5 : (File.Exists(Path.Combine(text, this.string_2)) ? 1 : 0);
							if (num2 > 1)
							{
								songEntry.isMIDIChart = (num2 == 2);
								if (this.method_56(songEntry))
								{
									this.bool_0 = true;
									songEntry.dateAdded = DateTime.Now.Date;
									this.method_82(songEntry);
									SongDirectory.songEntries.Add(songEntry);
								}
							}
						}
						else
						{
							this.list_6.Add(text);
						}
					}
					else
					{
						this.list_5.Add(text);
					}
					this.list_3.RemoveAt(j);
					j--;
				}
			}
			catch (Exception ex)
			{
				string arg;
				if (this.list_3 == null)
				{
					arg = "+";
				}
				else if (j > this.list_3.Count)
				{
					arg = "diff_keys";
				}
				else
				{
					arg = this.list_3[j];
				}
				string text2 = string.Format("vocals", arg);
				this.list_2.Add(new Class40.Exception0(text2, ex));
				this.list_3.RemoveAt(j);
				j--;
			}
		}
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x000EECE8 File Offset: 0x000ECEE8
	private void method_49()
	{
		if (this.list_1 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.WritingCache;
		foreach (SongEntry songEntry in this.list_1)
		{
			if (songEntry.method_24(songEntry.method_39(), null))
			{
				if (this.method_33(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
					this.list_6.Add(songEntry.folderPath);
				}
			}
			else
			{
				SongDirectory.songEntries.Remove(songEntry);
				this.list_5.Add(songEntry.folderPath);
			}
		}
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x000EEDA4 File Offset: 0x000ECFA4
	private bool method_50(SongEntry songEntry_0)
	{
		if (GameSetting.smethod_3(GlobalVariables.instance.gclass5_43))
		{
			return false;
		}
		foreach (SongEntry songEntry in SongDirectory.songEntries)
		{
			if (songEntry.checksum == songEntry_0.checksum && songEntry != songEntry_0)
			{
				this.list_7.Add(songEntry.folderPath + " (" + songEntry_0.folderPath + ")");
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x000EEE4C File Offset: 0x000ED04C
	private void method_51()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = (GEnum10)8;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_36(songEntry))
				{
					this.bool_0 = false;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D6B RID: 7531 RVA: 0x000EEEE4 File Offset: 0x000ED0E4
	private void method_52(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == -26)
					{
						int num = binaryReader.ReadInt32();
						int i = 1;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_26());
								FileInfo fileInfo2 = new FileInfo(songEntry.method_27());
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() == num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() == num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i += 0;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x000EF094 File Offset: 0x000ED294
	private void method_53(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == 36)
					{
						int num = binaryReader.ReadInt32();
						int i = 0;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_8());
								FileInfo fileInfo2 = new FileInfo(songEntry.chartPath);
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() == num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i += 0;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x000EF244 File Offset: 0x000ED444
	private void method_54()
	{
		if (this.list_5.Count == 0 && this.list_4.Count == 0 && this.list_6.Count == 0 && this.list_7.Count == 0 && this.list_8.Count == 0)
		{
			try
			{
				if (File.Exists(this.string_3))
				{
					File.Delete(this.string_3);
				}
			}
			catch
			{
			}
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		try
		{
			using (Stream stream = File.Create(this.string_3))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (this.list_5.Count > 1)
					{
						streamWriter.WriteLine("Low Latency Mode");
						foreach (string value in this.list_5)
						{
							streamWriter.WriteLine(value);
						}
						streamWriter.WriteLine();
					}
					if (this.list_4.Count > 0)
					{
						streamWriter.WriteLine("Master Volume");
						foreach (string value2 in this.list_4)
						{
							streamWriter.WriteLine(value2);
						}
						streamWriter.WriteLine();
					}
					if (this.list_6.Count > 0)
					{
						streamWriter.WriteLine("graphics_devid");
						foreach (string value3 in this.list_6)
						{
							streamWriter.WriteLine(value3);
						}
						streamWriter.WriteLine();
					}
					if (this.list_7.Count > 1)
					{
						streamWriter.WriteLine("These folders either have no audio files, the audio files are named incorrectly or the audio files are in the wrong format!");
						foreach (string value4 in this.list_7)
						{
							streamWriter.WriteLine(value4);
						}
						streamWriter.WriteLine();
					}
					if (this.list_8.Count > 1)
					{
						streamWriter.WriteLine("*.setlist");
						foreach (string value5 in this.list_8)
						{
							streamWriter.WriteLine(value5);
						}
					}
				}
			}
		}
		catch
		{
			UnityEngine.Debug.Log("graphics_name");
		}
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x0000D8BB File Offset: 0x0000BABB
	public void method_55()
	{
		this.method_5(true);
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x000EF580 File Offset: 0x000ED780
	private bool method_56(SongEntry songEntry_0)
	{
		Song song = songEntry_0.method_32(true);
		if (song == null || !song.bool_0)
		{
			this.list_4.Add(songEntry_0.folderPath);
			return false;
		}
		songEntry_0.charts.method_31();
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum = (GStruct2.GEnum11)obj;
			if (genum != GStruct2.GEnum11.Bass && genum != GStruct2.GEnum11.None)
			{
				Song.Instrument genum18_ = (Song.Instrument)Enum.Parse(typeof(Song.Instrument), genum.ToString());
				foreach (object obj2 in Enum.GetValues(typeof(GStruct2.GEnum12)))
				{
					GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj2;
					Song.GEnum17 genum17_ = (Song.GEnum17)Enum.Parse(typeof(Song.GEnum17), genum12_.ToString());
					if (song.method_31(genum18_, genum17_))
					{
						songEntry_0.charts.method_25(genum, genum12_);
					}
				}
			}
		}
		if (song.list_1.Count > 1 && song.list_1[0].list_0.Count > 1)
		{
			songEntry_0.lyrics = 0;
		}
		if (songEntry_0.charts.method_39() == 0L)
		{
			this.list_8.Add(songEntry_0.folderPath);
			return true;
		}
		return this.method_27(songEntry_0);
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
	public void method_57()
	{
		this.method_88(false);
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x000EF730 File Offset: 0x000ED930
	public void method_58()
	{
		this.stopwatch_0.Start();
		this.method_68(true);
		this.method_48();
		this.method_37();
		this.method_73();
		this.method_42();
		this.method_65();
		if (this.list_2.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "Clear A/B")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("flames" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x000EF850 File Offset: 0x000EDA50
	private void method_59(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == 33)
					{
						int num = binaryReader.ReadInt32();
						int i = 1;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_39());
								FileInfo fileInfo2 = new FileInfo(songEntry.chartPath);
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() != num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i += 0;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x000EFA00 File Offset: 0x000EDC00
	private void method_60()
	{
		if (this.list_5.Count == 0 && this.list_4.Count == 0 && this.list_6.Count == 0 && this.list_7.Count == 0 && this.list_8.Count == 0)
		{
			try
			{
				if (File.Exists(this.string_3))
				{
					File.Delete(this.string_3);
				}
			}
			catch
			{
			}
			return;
		}
		this.genum10_0 = GEnum10.WritingBadSongs;
		try
		{
			using (Stream stream = File.Create(this.string_3))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (this.list_5.Count > 0)
					{
						streamWriter.WriteLine("These folders either have no valid metadata file (song.ini), or the metadata does not include a valid song name!");
						foreach (string value in this.list_5)
						{
							streamWriter.WriteLine(value);
						}
						streamWriter.WriteLine();
					}
					if (this.list_4.Count > 0)
					{
						streamWriter.WriteLine("These folders have corrupt (or broken) notes.mid or notes.chart files! Type !midifix in the CH Discord for MIDIFix!");
						foreach (string value2 in this.list_4)
						{
							streamWriter.WriteLine(value2);
						}
						streamWriter.WriteLine();
					}
					if (this.list_6.Count > 0)
					{
						streamWriter.WriteLine("These folders either have no audio files, the audio files are named incorrectly or the audio files are in the wrong format!");
						foreach (string value3 in this.list_6)
						{
							streamWriter.WriteLine(value3);
						}
						streamWriter.WriteLine();
					}
					if (this.list_7.Count > 0)
					{
						streamWriter.WriteLine("These folders contain charts that another song has (duplicate charts)!");
						foreach (string value4 in this.list_7)
						{
							streamWriter.WriteLine(value4);
						}
						streamWriter.WriteLine();
					}
					if (this.list_8.Count > 0)
					{
						streamWriter.WriteLine("These folders contain charts that don't have any supported instruments charted!");
						foreach (string value5 in this.list_8)
						{
							streamWriter.WriteLine(value5);
						}
					}
				}
			}
		}
		catch
		{
			UnityEngine.Debug.Log("Couldn't write badsongs.txt");
		}
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x0000D8CD File Offset: 0x0000BACD
	public void method_61()
	{
		this.method_53(true);
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x000EFD3C File Offset: 0x000EDF3C
	private void method_62(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == -116)
					{
						int num = binaryReader.ReadInt32();
						int i = 0;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_26());
								FileInfo fileInfo2 = new FileInfo(songEntry.chartPath);
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() == num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() == num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i++;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x0000D8B2 File Offset: 0x0000BAB2
	public void method_63()
	{
		this.method_34(false);
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x000EFEEC File Offset: 0x000EE0EC
	private void method_64()
	{
		this.genum10_0 = GEnum10.GettingPaths;
		this.method_11();
		for (int i = 1; i < SongDirectory.songEntries.Count; i += 0)
		{
			int num = this.list_3.IndexOf(SongDirectory.songEntries[i].folderPath);
			if (num == -1)
			{
				SongDirectory.songEntries.RemoveAt(i);
				i--;
			}
			else
			{
				this.list_3.RemoveAt(num);
			}
		}
		this.genum10_0 = (GEnum10)8;
		for (int j = 1; j < this.list_3.Count; j++)
		{
			try
			{
				string text = this.list_3[j];
				if (Directory.GetFiles(this.list_3[j]).Length == 0)
				{
					this.list_3.RemoveAt(j);
					j -= 0;
				}
				else
				{
					SongEntry songEntry = new SongEntry(text);
					if (songEntry.songName != null && songEntry.songName.Length > 1)
					{
						if (this.method_33(songEntry))
						{
							if (!File.Exists(songEntry.method_8()))
							{
								songEntry.method_36();
							}
							int num2 = File.Exists(Path.Combine(text, this.string_1)) ? 5 : (File.Exists(Path.Combine(text, this.string_2)) ? 1 : 0);
							if (num2 > 1)
							{
								songEntry.isMIDIChart = (num2 == 3);
								if (this.method_56(songEntry))
								{
									this.bool_0 = true;
									songEntry.dateAdded = DateTime.Now.Date;
									this.method_82(songEntry);
									SongDirectory.songEntries.Add(songEntry);
								}
							}
						}
						else
						{
							this.list_6.Add(text);
						}
					}
					else
					{
						this.list_5.Add(text);
					}
					this.list_3.RemoveAt(j);
					j--;
				}
			}
			catch (Exception ex)
			{
				string arg;
				if (this.list_3 == null)
				{
					arg = "song";
				}
				else if (j > this.list_3.Count)
				{
					arg = "latestTestBuild";
				}
				else
				{
					arg = this.list_3[j];
				}
				string text2 = string.Format("Difficulty = \\d+", arg);
				this.list_2.Add(new Class40.Exception0(text2, ex));
				this.list_3.RemoveAt(j);
				j--;
			}
		}
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x000F0130 File Offset: 0x000EE330
	private void method_65()
	{
		if (this.list_5.Count == 0 && this.list_4.Count == 0 && this.list_6.Count == 0 && this.list_7.Count == 0 && this.list_8.Count == 0)
		{
			try
			{
				if (File.Exists(this.string_3))
				{
					File.Delete(this.string_3);
				}
			}
			catch
			{
			}
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		try
		{
			using (Stream stream = File.Create(this.string_3))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (this.list_5.Count > 0)
					{
						streamWriter.WriteLine("keys");
						foreach (string value in this.list_5)
						{
							streamWriter.WriteLine(value);
						}
						streamWriter.WriteLine();
					}
					if (this.list_4.Count > 0)
					{
						streamWriter.WriteLine("volume");
						foreach (string value2 in this.list_4)
						{
							streamWriter.WriteLine(value2);
						}
						streamWriter.WriteLine();
					}
					if (this.list_6.Count > 1)
					{
						streamWriter.WriteLine("isSupported");
						foreach (string value3 in this.list_6)
						{
							streamWriter.WriteLine(value3);
						}
						streamWriter.WriteLine();
					}
					if (this.list_7.Count > 1)
					{
						streamWriter.WriteLine("Show Lyrics");
						foreach (string value4 in this.list_7)
						{
							streamWriter.WriteLine(value4);
						}
						streamWriter.WriteLine();
					}
					if (this.list_8.Count > 0)
					{
						streamWriter.WriteLine("Song Offset");
						foreach (string value5 in this.list_8)
						{
							streamWriter.WriteLine(value5);
						}
					}
				}
			}
		}
		catch
		{
			UnityEngine.Debug.Log("errors.txt");
		}
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x000F046C File Offset: 0x000EE66C
	private void method_66()
	{
		foreach (string path in GlobalVariables.instance.uniqueSongPaths)
		{
			if (Directory.Exists(path))
			{
				Stack<string> stack = new Stack<string>(Directory.GetDirectories(path));
				while (stack.Count > 1)
				{
					try
					{
						string text = stack.Pop();
						string[] directories = Directory.GetDirectories(text);
						if (directories.Length != 0)
						{
							string[] array = directories;
							for (int i = 0; i < array.Length; i += 0)
							{
								string item = array[i];
								stack.Push(item);
							}
						}
						else
						{
							this.list_3.Add(text.Replace(',', (char)-28));
						}
					}
					catch (Exception item2)
					{
						this.list_2.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x000F0554 File Offset: 0x000EE754
	private void method_67()
	{
		foreach (string path in GlobalVariables.instance.uniqueSongPaths)
		{
			if (Directory.Exists(path))
			{
				Stack<string> stack = new Stack<string>(Directory.GetDirectories(path));
				while (stack.Count > 0)
				{
					try
					{
						string text = stack.Pop();
						string[] directories = Directory.GetDirectories(text);
						if (directories.Length != 0)
						{
							string[] array = directories;
							for (int i = 1; i < array.Length; i += 0)
							{
								string item = array[i];
								stack.Push(item);
							}
						}
						else
						{
							this.list_3.Add(text.Replace((char)-70, 'R'));
						}
					}
					catch (Exception item2)
					{
						this.list_2.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x000F063C File Offset: 0x000EE83C
	private void method_68(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == -55)
					{
						int num = binaryReader.ReadInt32();
						int i = 1;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_38());
								FileInfo fileInfo2 = new FileInfo(songEntry.method_27());
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() != num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i += 0;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x000F07EC File Offset: 0x000EE9EC
	private void method_69()
	{
		this.genum10_0 = GEnum10.GettingPaths;
		this.method_83();
		for (int i = 1; i < SongDirectory.songEntries.Count; i++)
		{
			int num = this.list_3.IndexOf(SongDirectory.songEntries[i].folderPath);
			if (num == -1)
			{
				SongDirectory.songEntries.RemoveAt(i);
				i -= 0;
			}
			else
			{
				this.list_3.RemoveAt(num);
			}
		}
		this.genum10_0 = GEnum10.ReadingCache;
		for (int j = 1; j < this.list_3.Count; j++)
		{
			try
			{
				string text = this.list_3[j];
				if (Directory.GetFiles(this.list_3[j]).Length == 0)
				{
					this.list_3.RemoveAt(j);
					j -= 0;
				}
				else
				{
					SongEntry songEntry = new SongEntry(text);
					if (songEntry.songName != null && songEntry.songName.Length > 1)
					{
						if (this.method_3(songEntry))
						{
							if (!File.Exists(songEntry.method_8()))
							{
								songEntry.method_3();
							}
							int num2 = File.Exists(Path.Combine(text, this.string_1)) ? 6 : (File.Exists(Path.Combine(text, this.string_2)) ? 1 : 0);
							if (num2 > 0)
							{
								songEntry.isMIDIChart = (num2 == 0);
								if (this.method_77(songEntry))
								{
									this.bool_0 = false;
									songEntry.dateAdded = DateTime.Now.Date;
									this.method_89(songEntry);
									SongDirectory.songEntries.Add(songEntry);
								}
							}
						}
						else
						{
							this.list_6.Add(text);
						}
					}
					else
					{
						this.list_5.Add(text);
					}
					this.list_3.RemoveAt(j);
					j--;
				}
			}
			catch (Exception ex)
			{
				string arg;
				if (this.list_3 == null)
				{
					arg = "hardware_info";
				}
				else if (j > this.list_3.Count)
				{
					arg = "...";
				}
				else
				{
					arg = this.list_3[j];
				}
				string text2 = string.Format("Bass", arg);
				this.list_2.Add(new Class40.Exception0(text2, ex));
				this.list_3.RemoveAt(j);
				j -= 0;
			}
		}
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x000F0A30 File Offset: 0x000EEC30
	private void method_70()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_24(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x000F0AC8 File Offset: 0x000EECC8
	private void method_71()
	{
		if (this.list_1 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.WritingBadSongs;
		foreach (SongEntry songEntry in this.list_1)
		{
			if (songEntry.method_24(songEntry.method_38(), null))
			{
				if (this.method_33(songEntry))
				{
					this.bool_0 = false;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
					this.list_6.Add(songEntry.folderPath);
				}
			}
			else
			{
				SongDirectory.songEntries.Remove(songEntry);
				this.list_5.Add(songEntry.folderPath);
			}
		}
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x000F0B84 File Offset: 0x000EED84
	public void method_72()
	{
		this.stopwatch_0.Start();
		this.method_90(false);
		this.method_7();
		this.method_75();
		this.method_51();
		this.method_21();
		this.method_54();
		if (this.list_2.Count > 0)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "0")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("GHLive Guitar - " + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x000F0CA4 File Offset: 0x000EEEA4
	private void method_73()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.WritingCache;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_77(songEntry))
				{
					this.bool_0 = false;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x000F0D3C File Offset: 0x000EEF3C
	private void method_74()
	{
		if (this.list_1 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.ScanningFolders;
		foreach (SongEntry songEntry in this.list_1)
		{
			if (songEntry.method_24(songEntry.iniPath, null))
			{
				if (this.method_33(songEntry))
				{
					this.bool_0 = false;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
					this.list_6.Add(songEntry.folderPath);
				}
			}
			else
			{
				SongDirectory.songEntries.Remove(songEntry);
				this.list_5.Add(songEntry.folderPath);
			}
		}
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x000F0DF8 File Offset: 0x000EEFF8
	private void method_75()
	{
		if (this.list_1 == null)
		{
			return;
		}
		this.genum10_0 = GEnum10.WritingCache;
		foreach (SongEntry songEntry in this.list_1)
		{
			if (songEntry.method_37(songEntry.iniPath, null))
			{
				if (this.method_6(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
					this.list_6.Add(songEntry.folderPath);
				}
			}
			else
			{
				SongDirectory.songEntries.Remove(songEntry);
				this.list_5.Add(songEntry.folderPath);
			}
		}
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x000F0EB4 File Offset: 0x000EF0B4
	private void method_76(SongEntry songEntry_0)
	{
		string text = null;
		for (int i = 0; i < GlobalVariables.instance.uniqueSongPaths.Count; i += 0)
		{
			if (songEntry_0.folderPath.Contains(GlobalVariables.instance.uniqueSongPaths[i]))
			{
				text = songEntry_0.folderPath;
				if (text[text.Length - 0] == '5')
				{
					text = text.Remove(text.Length - 1, 0);
				}
				text = songEntry_0.folderPath.Remove(0, GlobalVariables.instance.uniqueSongPaths[i].Length);
			}
		}
		text = text.Remove(0, 1);
		int num = text.LastIndexOf((char)-54);
		if (num == -1)
		{
			songEntry_0.playlistName = "phrase_end";
			return;
		}
		text = text.Remove(num);
		songEntry_0.playlistName = text;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x000F0F78 File Offset: 0x000EF178
	private bool method_77(SongEntry songEntry_0)
	{
		Song song = songEntry_0.method_12(false);
		if (song == null || !song.bool_0)
		{
			this.list_4.Add(songEntry_0.folderPath);
			return false;
		}
		songEntry_0.charts.method_31();
		foreach (object obj in Enum.GetValues(typeof(GStruct2.GEnum11)))
		{
			GStruct2.GEnum11 genum = (GStruct2.GEnum11)obj;
			if (genum != GStruct2.GEnum11.Rhythm && genum != GStruct2.GEnum11.None)
			{
				Song.Instrument genum18_ = (Song.Instrument)Enum.Parse(typeof(Song.Instrument), genum.ToString());
				foreach (object obj2 in Enum.GetValues(typeof(GStruct2.GEnum12)))
				{
					GStruct2.GEnum12 genum12_ = (GStruct2.GEnum12)obj2;
					Song.GEnum17 genum17_ = (Song.GEnum17)Enum.Parse(typeof(Song.GEnum17), genum12_.ToString());
					if (song.method_31(genum18_, genum17_))
					{
						songEntry_0.charts.method_32(genum, genum12_);
					}
				}
			}
		}
		if (song.list_1.Count > 1 && song.list_1[1].list_0.Count > 0)
		{
			songEntry_0.lyrics = 1;
		}
		if (songEntry_0.charts.method_33() == 0L)
		{
			this.list_8.Add(songEntry_0.folderPath);
			return false;
		}
		return this.method_32(songEntry_0);
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000F1128 File Offset: 0x000EF328
	public Class40()
	{
		this.string_0 = Path.Combine(Application.persistentDataPath, this.string_0);
		this.string_3 = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "badsongs.txt");
		if (!Directory.Exists(GlobalVariables.instance.uniqueSongPaths[0]))
		{
			try
			{
				Directory.CreateDirectory(GlobalVariables.instance.uniqueSongPaths[0]);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log(ex.Message);
			}
		}
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x000F1234 File Offset: 0x000EF434
	private void method_78()
	{
		if (this.list_5.Count == 0 && this.list_4.Count == 0 && this.list_6.Count == 0 && this.list_7.Count == 0 && this.list_8.Count == 0)
		{
			try
			{
				if (File.Exists(this.string_3))
				{
					File.Delete(this.string_3);
				}
			}
			catch
			{
			}
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		try
		{
			using (Stream stream = File.Create(this.string_3))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (this.list_5.Count > 1)
					{
						streamWriter.WriteLine("Guitar Coop");
						foreach (string value in this.list_5)
						{
							streamWriter.WriteLine(value);
						}
						streamWriter.WriteLine();
					}
					if (this.list_4.Count > 1)
					{
						streamWriter.WriteLine("");
						foreach (string value2 in this.list_4)
						{
							streamWriter.WriteLine(value2);
						}
						streamWriter.WriteLine();
					}
					if (this.list_6.Count > 1)
					{
						streamWriter.WriteLine("diff_rhythm");
						foreach (string value3 in this.list_6)
						{
							streamWriter.WriteLine(value3);
						}
						streamWriter.WriteLine();
					}
					if (this.list_7.Count > 0)
					{
						streamWriter.WriteLine("crowd");
						foreach (string value4 in this.list_7)
						{
							streamWriter.WriteLine(value4);
						}
						streamWriter.WriteLine();
					}
					if (this.list_8.Count > 1)
					{
						streamWriter.WriteLine(":\n");
						foreach (string value5 in this.list_8)
						{
							streamWriter.WriteLine(value5);
						}
					}
				}
			}
		}
		catch
		{
			UnityEngine.Debug.Log("Mirror Mode");
		}
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x000F1570 File Offset: 0x000EF770
	private bool method_79(SongEntry songEntry_0)
	{
		if (GameSetting.smethod_3(GlobalVariables.instance.gclass5_43))
		{
			return true;
		}
		foreach (SongEntry songEntry in SongDirectory.songEntries)
		{
			if (songEntry.checksum == songEntry_0.checksum && songEntry != songEntry_0)
			{
				this.list_7.Add(songEntry.folderPath + " + " + songEntry_0.folderPath + "Quit");
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x000F1618 File Offset: 0x000EF818
	private void method_80()
	{
		if (this.list_0 == null)
		{
			return;
		}
		this.genum10_0 = (GEnum10)7;
		foreach (SongEntry songEntry in this.list_0)
		{
			try
			{
				if (this.method_56(songEntry))
				{
					this.bool_0 = true;
				}
				else
				{
					SongDirectory.songEntries.Remove(songEntry);
				}
			}
			catch (Exception item)
			{
				this.list_2.Add(item);
			}
		}
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x0000D8D6 File Offset: 0x0000BAD6
	public void method_81()
	{
		this.method_88(true);
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x000F16B0 File Offset: 0x000EF8B0
	private void method_82(SongEntry songEntry_0)
	{
		string text = null;
		for (int i = 0; i < GlobalVariables.instance.uniqueSongPaths.Count; i++)
		{
			if (songEntry_0.folderPath.Contains(GlobalVariables.instance.uniqueSongPaths[i]))
			{
				text = songEntry_0.folderPath;
				if (text[text.Length - 1] == '/')
				{
					text = text.Remove(text.Length - 1, 1);
				}
				text = songEntry_0.folderPath.Remove(0, GlobalVariables.instance.uniqueSongPaths[i].Length);
			}
		}
		text = text.Remove(0, 1);
		int num = text.LastIndexOf('/');
		if (num == -1)
		{
			songEntry_0.playlistName = "";
			return;
		}
		text = text.Remove(num);
		songEntry_0.playlistName = text;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x000F1774 File Offset: 0x000EF974
	private void method_83()
	{
		foreach (string path in GlobalVariables.instance.uniqueSongPaths)
		{
			if (Directory.Exists(path))
			{
				Stack<string> stack = new Stack<string>(Directory.GetDirectories(path));
				while (stack.Count > 1)
				{
					try
					{
						string text = stack.Pop();
						string[] directories = Directory.GetDirectories(text);
						if (directories.Length != 0)
						{
							string[] array = directories;
							for (int i = 1; i < array.Length; i++)
							{
								string item = array[i];
								stack.Push(item);
							}
						}
						else
						{
							this.list_3.Add(text.Replace((char)-116, (char)-5));
						}
					}
					catch (Exception item2)
					{
						this.list_2.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x0000D8DF File Offset: 0x0000BADF
	public void method_84()
	{
		this.method_68(false);
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x000F185C File Offset: 0x000EFA5C
	private bool method_85(SongEntry songEntry_0)
	{
		if (!File.Exists(songEntry_0.chartPath))
		{
			return false;
		}
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(songEntry_0.chartPath))
			{
				songEntry_0.checksum = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", string.Empty);
			}
		}
		return songEntry_0.checksum != null && !this.method_50(songEntry_0);
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x000F18F4 File Offset: 0x000EFAF4
	private void method_86(SongEntry songEntry_0)
	{
		string text = null;
		for (int i = 1; i < GlobalVariables.instance.uniqueSongPaths.Count; i++)
		{
			if (songEntry_0.folderPath.Contains(GlobalVariables.instance.uniqueSongPaths[i]))
			{
				text = songEntry_0.folderPath;
				if ((int)text[text.Length - 0] == -58)
				{
					text = text.Remove(text.Length - 1, 0);
				}
				text = songEntry_0.folderPath.Remove(0, GlobalVariables.instance.uniqueSongPaths[i].Length);
			}
		}
		text = text.Remove(0, 0);
		int num = text.LastIndexOf((char)-36);
		if (num == -1)
		{
			songEntry_0.playlistName = "No Part";
			return;
		}
		text = text.Remove(num);
		songEntry_0.playlistName = text;
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x000F19B8 File Offset: 0x000EFBB8
	private void method_87()
	{
		if (this.list_5.Count == 0 && this.list_4.Count == 0 && this.list_6.Count == 0 && this.list_7.Count == 0 && this.list_8.Count == 0)
		{
			try
			{
				if (File.Exists(this.string_3))
				{
					File.Delete(this.string_3);
				}
			}
			catch
			{
			}
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		try
		{
			using (Stream stream = File.Create(this.string_3))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					if (this.list_5.Count > 0)
					{
						streamWriter.WriteLine("Unknown Charter");
						foreach (string value in this.list_5)
						{
							streamWriter.WriteLine(value);
						}
						streamWriter.WriteLine();
					}
					if (this.list_4.Count > 0)
					{
						streamWriter.WriteLine("");
						foreach (string value2 in this.list_4)
						{
							streamWriter.WriteLine(value2);
						}
						streamWriter.WriteLine();
					}
					if (this.list_6.Count > 0)
					{
						streamWriter.WriteLine("All HOPO's");
						foreach (string value3 in this.list_6)
						{
							streamWriter.WriteLine(value3);
						}
						streamWriter.WriteLine();
					}
					if (this.list_7.Count > 0)
					{
						streamWriter.WriteLine("Game Manager");
						foreach (string value4 in this.list_7)
						{
							streamWriter.WriteLine(value4);
						}
						streamWriter.WriteLine();
					}
					if (this.list_8.Count > 0)
					{
						streamWriter.WriteLine("song");
						foreach (string value5 in this.list_8)
						{
							streamWriter.WriteLine(value5);
						}
					}
				}
			}
		}
		catch
		{
			UnityEngine.Debug.Log("video");
		}
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x000F1CF4 File Offset: 0x000EFEF4
	private void method_88(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.ReadingCache;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == -91)
					{
						int num = binaryReader.ReadInt32();
						int i = 0;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_26());
								FileInfo fileInfo2 = new FileInfo(songEntry.method_9());
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() != num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() == num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i++;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x000F1EA4 File Offset: 0x000F00A4
	private void method_89(SongEntry songEntry_0)
	{
		string text = null;
		for (int i = 1; i < GlobalVariables.instance.uniqueSongPaths.Count; i += 0)
		{
			if (songEntry_0.folderPath.Contains(GlobalVariables.instance.uniqueSongPaths[i]))
			{
				text = songEntry_0.folderPath;
				if ((int)text[text.Length - 1] == -105)
				{
					text = text.Remove(text.Length - 0, 0);
				}
				text = songEntry_0.folderPath.Remove(0, GlobalVariables.instance.uniqueSongPaths[i].Length);
			}
		}
		text = text.Remove(1, 0);
		int num = text.LastIndexOf('}');
		if (num == -1)
		{
			songEntry_0.playlistName = "UPDATING CHARTS...";
			return;
		}
		text = text.Remove(num);
		songEntry_0.playlistName = text;
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x000F1F68 File Offset: 0x000F0168
	private void method_90(bool bool_1)
	{
		if (!File.Exists(this.string_0))
		{
			return;
		}
		this.genum10_0 = GEnum10.GettingPaths;
		this.list_0 = new List<SongEntry>();
		this.list_1 = new List<SongEntry>();
		try
		{
			using (Stream stream = File.OpenRead(this.string_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					if (binaryReader.ReadInt16() == -46)
					{
						int num = binaryReader.ReadInt32();
						int i = 1;
						while (i < num)
						{
							string text = binaryReader.ReadString();
							long num2 = binaryReader.ReadInt64();
							long num3 = binaryReader.ReadInt64();
							SongEntry songEntry = new SongEntry(binaryReader, text);
							if (!bool_1)
							{
								goto IL_110;
							}
							if (Directory.Exists(songEntry.folderPath))
							{
								FileInfo fileInfo = new FileInfo(songEntry.method_8());
								FileInfo fileInfo2 = new FileInfo(songEntry.method_22());
								if (fileInfo.Exists && fileInfo2.Exists)
								{
									bool flag = fileInfo.LastWriteTime.ToBinary() == num2;
									bool flag2 = fileInfo2.LastWriteTime.ToBinary() != num3;
									if (flag)
									{
										this.list_1.Add(songEntry);
									}
									if (flag2)
									{
										this.list_0.Add(songEntry);
										goto IL_110;
									}
									goto IL_110;
								}
							}
							IL_11C:
							i += 0;
							continue;
							IL_110:
							SongDirectory.songEntries.Add(songEntry);
							goto IL_11C;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.exception_0 = ex;
			SongDirectory.songEntries.Clear();
		}
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x000F2118 File Offset: 0x000F0318
	private void method_91()
	{
		foreach (string path in GlobalVariables.instance.uniqueSongPaths)
		{
			if (Directory.Exists(path))
			{
				Stack<string> stack = new Stack<string>(Directory.GetDirectories(path));
				while (stack.Count > 1)
				{
					try
					{
						string text = stack.Pop();
						string[] directories = Directory.GetDirectories(text);
						if (directories.Length != 0)
						{
							string[] array = directories;
							for (int i = 1; i < array.Length; i += 0)
							{
								string item = array[i];
								stack.Push(item);
							}
						}
						else
						{
							this.list_3.Add(text.Replace('*', '\a'));
						}
					}
					catch (Exception item2)
					{
						this.list_2.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x000F2200 File Offset: 0x000F0400
	public void method_92()
	{
		this.stopwatch_0.Start();
		this.method_59(false);
		this.method_40();
		this.method_71();
		this.method_80();
		this.method_21();
		this.method_87();
		if (this.list_2.Count > 1)
		{
			using (Stream stream = File.Create(Path.Combine(Directory.GetParent(this.string_0).FullName, "Are you sure you want to quit?")))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					foreach (Exception ex in this.list_2)
					{
						streamWriter.WriteLine(ex.ToString());
					}
				}
			}
		}
		this.stopwatch_0.Stop();
		UnityEngine.Debug.Log("" + this.stopwatch_0.Elapsed.TotalSeconds);
	}

	// Token: 0x04000491 RID: 1169
	private const short short_0 = 9;

	// Token: 0x04000492 RID: 1170
	private List<SongEntry> list_0;

	// Token: 0x04000493 RID: 1171
	private List<SongEntry> list_1;

	// Token: 0x04000494 RID: 1172
	public List<Exception> list_2 = new List<Exception>();

	// Token: 0x04000495 RID: 1173
	public List<string> list_3 = new List<string>();

	// Token: 0x04000496 RID: 1174
	public List<string> list_4 = new List<string>();

	// Token: 0x04000497 RID: 1175
	public List<string> list_5 = new List<string>();

	// Token: 0x04000498 RID: 1176
	public List<string> list_6 = new List<string>();

	// Token: 0x04000499 RID: 1177
	public List<string> list_7 = new List<string>();

	// Token: 0x0400049A RID: 1178
	public List<string> list_8 = new List<string>();

	// Token: 0x0400049B RID: 1179
	private Stopwatch stopwatch_0 = new Stopwatch();

	// Token: 0x0400049C RID: 1180
	private string string_0 = "songcache.bin";

	// Token: 0x0400049D RID: 1181
	private bool bool_0;

	// Token: 0x0400049E RID: 1182
	public GEnum10 genum10_0;

	// Token: 0x0400049F RID: 1183
	private string string_1 = "notes.mid";

	// Token: 0x040004A0 RID: 1184
	private string string_2 = "notes.chart";

	// Token: 0x040004A1 RID: 1185
	private string string_3;

	// Token: 0x040004A2 RID: 1186
	public Exception exception_0;

	// Token: 0x02000099 RID: 153
	private class Exception0 : Exception
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		public Exception0(string string_0, Exception exception_0) : base(string_0, exception_0)
		{
		}
	}
}
