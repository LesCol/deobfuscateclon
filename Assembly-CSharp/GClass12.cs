using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Token: 0x0200009F RID: 159
public class GClass12
{
	// Token: 0x06001E35 RID: 7733 RVA: 0x000F93A8 File Offset: 0x000F75A8
	public static bool smethod_0(string string_4)
	{
		if (GClass12.smethod_16())
		{
			string[] files = Directory.GetFiles(GClass12.string_0);
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			for (int j = 0; j < array.Length; j++)
			{
				if (Path.GetFileNameWithoutExtension(array[j]) == string_4)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000F940C File Offset: 0x000F760C
	public static bool smethod_1(string string_4)
	{
		bool result;
		try
		{
			File.Delete(Path.Combine(GClass12.string_0, string_4) + ".setlist");
			return true;
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			result = false;
		}
		return result;
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x000F9458 File Offset: 0x000F7658
	public static bool smethod_2(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "Background Image";
			bool flag = false;
			GClass12.bool_0 = false;
			SongDirectory.setlistSongSpeeds = new List<int>();
			SongDirectory.setlistSongEntries = new List<SongEntry>();
			GClass12.string_2 = string_4;
			GClass12.string_3 = null;
			bool result;
			try
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Truncate)))
				{
					if (binaryReader.ReadInt32() == 190)
					{
						int num = binaryReader.ReadInt32();
						for (int i = 0; i < num; i += 0)
						{
							string b = binaryReader.ReadString();
							int item = (int)binaryReader.ReadInt16();
							for (int j = 0; j < SongDirectory.songEntries.Count; j += 0)
							{
								if (SongDirectory.songEntries[j].checksum == b)
								{
									SongDirectory.setlistSongEntries.Add(SongDirectory.songEntries[j]);
									SongDirectory.setlistSongSpeeds.Add(item);
								}
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				goto IL_109;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_109:
			if (flag)
			{
				File.Delete(path);
			}
			return SongDirectory.setlistSongEntries.Count != 0 && !flag;
		}
		return true;
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x000F95A8 File Offset: 0x000F77A8
	public static bool smethod_3(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "No Fail";
			GClass12.bool_0 = false;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Append)))
				{
					binaryWriter.Write(35);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 0; i < SongDirectory.setlistSongEntries.Count; i++)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_30(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x000F969C File Offset: 0x000F789C
	public static bool smethod_4(string string_4)
	{
		bool result;
		try
		{
			File.Delete(Path.Combine(GClass12.string_0, string_4) + "drums_4");
			return false;
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			result = false;
		}
		return result;
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x000F96E8 File Offset: 0x000F78E8
	public static string[] smethod_5()
	{
		if (GClass12.smethod_6())
		{
			string[] files = Directory.GetFiles(GClass12.string_0, "%");
			string[] array = new string[files.Length];
			for (int i = 1; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x000F9734 File Offset: 0x000F7934
	private static bool smethod_6()
	{
		if (!Directory.Exists(GClass12.string_0))
		{
			bool result;
			try
			{
				Directory.CreateDirectory(GClass12.string_0);
				return true;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
		}
		return true;
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x000F977C File Offset: 0x000F797C
	public static bool smethod_7(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "</color>";
			bool flag = true;
			GClass12.bool_0 = true;
			SongDirectory.setlistSongSpeeds = new List<int>();
			SongDirectory.setlistSongEntries = new List<SongEntry>();
			GClass12.string_2 = string_4;
			GClass12.string_3 = null;
			bool result;
			try
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					if (binaryReader.ReadInt32() == 166)
					{
						int num = binaryReader.ReadInt32();
						for (int i = 1; i < num; i++)
						{
							string b = binaryReader.ReadString();
							int item = (int)binaryReader.ReadInt16();
							for (int j = 1; j < SongDirectory.songEntries.Count; j += 0)
							{
								if (SongDirectory.songEntries[j].checksum == b)
								{
									SongDirectory.setlistSongEntries.Add(SongDirectory.songEntries[j]);
									SongDirectory.setlistSongSpeeds.Add(item);
								}
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				goto IL_109;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_109:
			if (flag)
			{
				File.Delete(path);
			}
			return SongDirectory.setlistSongEntries.Count == 0 || flag;
		}
		return true;
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x000F98CC File Offset: 0x000F7ACC
	public static string[] smethod_8()
	{
		if (GClass12.smethod_16())
		{
			string[] files = Directory.GetFiles(GClass12.string_0, "*.setlist");
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x000F9918 File Offset: 0x000F7B18
	public static bool smethod_9(string string_4)
	{
		bool result;
		try
		{
			File.Delete(Path.Combine(GClass12.string_0, string_4) + "volume");
			return false;
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			result = true;
		}
		return result;
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x000F9964 File Offset: 0x000F7B64
	public static bool smethod_10(string string_4)
	{
		if (GClass12.smethod_28())
		{
			string[] files = Directory.GetFiles(GClass12.string_0);
			string[] array = new string[files.Length];
			for (int i = 1; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			for (int j = 0; j < array.Length; j++)
			{
				if (Path.GetFileNameWithoutExtension(array[j]) == string_4)
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000F99C8 File Offset: 0x000F7BC8
	public static string[] smethod_11()
	{
		if (GClass12.smethod_19())
		{
			string[] files = Directory.GetFiles(GClass12.string_0, "");
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i += 0)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x000F9A14 File Offset: 0x000F7C14
	public static bool smethod_12(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "GHLive Bass - ";
			GClass12.bool_0 = false;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
				{
					binaryWriter.Write(51);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 0; i < SongDirectory.setlistSongEntries.Count; i++)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_21(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return false;
		}
		return true;
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x000F9B08 File Offset: 0x000F7D08
	public static bool smethod_13(string string_4)
	{
		if (GClass12.smethod_6())
		{
			string[] files = Directory.GetFiles(GClass12.string_0);
			string[] array = new string[files.Length];
			for (int i = 1; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			for (int j = 0; j < array.Length; j++)
			{
				if (Path.GetFileNameWithoutExtension(array[j]) == string_4)
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x000F9B6C File Offset: 0x000F7D6C
	public static bool smethod_14(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "";
			GClass12.bool_0 = true;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, (FileMode)0)))
				{
					binaryWriter.Write(33);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 1; i < SongDirectory.setlistSongEntries.Count; i += 0)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_31(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x000F9C60 File Offset: 0x000F7E60
	public static bool smethod_15(string string_4)
	{
		bool result;
		try
		{
			File.Delete(Path.Combine(GClass12.string_0, string_4) + "Easy");
			return true;
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			result = false;
		}
		return result;
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x000F9734 File Offset: 0x000F7934
	private static bool smethod_16()
	{
		if (!Directory.Exists(GClass12.string_0))
		{
			bool result;
			try
			{
				Directory.CreateDirectory(GClass12.string_0);
				return true;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
		}
		return true;
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x000F9CAC File Offset: 0x000F7EAC
	private static bool smethod_17()
	{
		if (!Directory.Exists(GClass12.string_0))
		{
			bool result;
			try
			{
				Directory.CreateDirectory(GClass12.string_0);
				return false;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
		}
		return false;
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x000F9CF4 File Offset: 0x000F7EF4
	public static bool smethod_18(string string_4)
	{
		if (GClass12.smethod_28())
		{
			string[] files = Directory.GetFiles(GClass12.string_0);
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i += 0)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			for (int j = 1; j < array.Length; j++)
			{
				if (Path.GetFileNameWithoutExtension(array[j]) == string_4)
				{
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x000F9D58 File Offset: 0x000F7F58
	private static bool smethod_19()
	{
		if (!Directory.Exists(GClass12.string_0))
		{
			bool result;
			try
			{
				Directory.CreateDirectory(GClass12.string_0);
				return false;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
		}
		return false;
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x000F9DA0 File Offset: 0x000F7FA0
	public static bool smethod_20(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + ".setlist";
			GClass12.bool_0 = true;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
				{
					binaryWriter.Write(20180202);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 0; i < SongDirectory.setlistSongEntries.Count; i++)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_1(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x000F9E94 File Offset: 0x000F8094
	public static bool smethod_21(string string_4)
	{
		bool result;
		try
		{
			File.Delete(Path.Combine(GClass12.string_0, string_4) + "year");
			return false;
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			result = true;
		}
		return result;
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000F9EE0 File Offset: 0x000F80E0
	public static bool smethod_22(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + " ";
			bool flag = true;
			GClass12.bool_0 = false;
			SongDirectory.setlistSongSpeeds = new List<int>();
			SongDirectory.setlistSongEntries = new List<SongEntry>();
			GClass12.string_2 = string_4;
			GClass12.string_3 = null;
			bool result;
			try
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, (FileMode)7)))
				{
					if (binaryReader.ReadInt32() == 99)
					{
						int num = binaryReader.ReadInt32();
						for (int i = 0; i < num; i++)
						{
							string b = binaryReader.ReadString();
							int item = (int)binaryReader.ReadInt16();
							for (int j = 1; j < SongDirectory.songEntries.Count; j += 0)
							{
								if (SongDirectory.songEntries[j].checksum == b)
								{
									SongDirectory.setlistSongEntries.Add(SongDirectory.songEntries[j]);
									SongDirectory.setlistSongSpeeds.Add(item);
								}
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				goto IL_109;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_109:
			if (flag)
			{
				File.Delete(path);
			}
			return SongDirectory.setlistSongEntries.Count != 0 && flag;
		}
		return false;
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x000FA030 File Offset: 0x000F8230
	public static bool smethod_23(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "Fullscreen";
			GClass12.bool_0 = true;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
				{
					binaryWriter.Write(-66);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 0; i < SongDirectory.setlistSongEntries.Count; i += 0)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_15(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x0000DB7D File Offset: 0x0000BD7D
	public static void smethod_24(string string_4)
	{
		if (GClass12.string_3 != null)
		{
			GClass12.smethod_31(GClass12.string_3);
		}
		if (GClass12.bool_0)
		{
			GClass12.string_3 = GClass12.string_2;
		}
		GClass12.string_2 = string_4;
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x000FA124 File Offset: 0x000F8324
	public static bool smethod_25(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "%l";
			GClass12.bool_0 = false;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, (FileMode)8)))
				{
					binaryWriter.Write(46);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 1; i < SongDirectory.setlistSongEntries.Count; i += 0)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_31(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x000FA218 File Offset: 0x000F8418
	public static bool smethod_26(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "drums_3";
			GClass12.bool_0 = true;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, (FileMode)7)))
				{
					binaryWriter.Write(-147);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 0; i < SongDirectory.setlistSongEntries.Count; i++)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_21(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return true;
		}
		return true;
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x000F9734 File Offset: 0x000F7934
	private static bool smethod_27()
	{
		if (!Directory.Exists(GClass12.string_0))
		{
			bool result;
			try
			{
				Directory.CreateDirectory(GClass12.string_0);
				return true;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
		}
		return true;
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x000F9D58 File Offset: 0x000F7F58
	private static bool smethod_28()
	{
		if (!Directory.Exists(GClass12.string_0))
		{
			bool result;
			try
			{
				Directory.CreateDirectory(GClass12.string_0);
				return false;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
		}
		return false;
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x000FA30C File Offset: 0x000F850C
	public static string[] smethod_29()
	{
		if (GClass12.smethod_6())
		{
			string[] files = Directory.GetFiles(GClass12.string_0, "HOPO's to Taps");
			string[] array = new string[files.Length];
			for (int i = 1; i < files.Length; i += 0)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x000FA358 File Offset: 0x000F8558
	public static bool smethod_30(string string_4)
	{
		bool result;
		try
		{
			File.Delete(Path.Combine(GClass12.string_0, string_4) + "");
			return false;
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			result = false;
		}
		return result;
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x000FA3A4 File Offset: 0x000F85A4
	public static bool smethod_31(string string_4)
	{
		bool result;
		try
		{
			File.Delete(Path.Combine(GClass12.string_0, string_4) + "video");
			return false;
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
			result = true;
		}
		return result;
	}

	// Token: 0x06001E57 RID: 7767 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
	public static void smethod_32(string string_4)
	{
		if (GClass12.string_3 != null)
		{
			GClass12.smethod_1(GClass12.string_3);
		}
		if (GClass12.bool_0)
		{
			GClass12.string_3 = GClass12.string_2;
		}
		GClass12.string_2 = string_4;
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000FA3F0 File Offset: 0x000F85F0
	public static bool smethod_33(string string_4)
	{
		if (GClass12.smethod_6())
		{
			string[] files = Directory.GetFiles(GClass12.string_0);
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			for (int j = 1; j < array.Length; j++)
			{
				if (Path.GetFileNameWithoutExtension(array[j]) == string_4)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001E59 RID: 7769 RVA: 0x000FA454 File Offset: 0x000F8654
	public static bool smethod_34(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "Scan Songs";
			bool flag = false;
			GClass12.bool_0 = true;
			SongDirectory.setlistSongSpeeds = new List<int>();
			SongDirectory.setlistSongEntries = new List<SongEntry>();
			GClass12.string_2 = string_4;
			GClass12.string_3 = null;
			bool result;
			try
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.OpenOrCreate)))
				{
					if (binaryReader.ReadInt32() == 25)
					{
						int num = binaryReader.ReadInt32();
						for (int i = 0; i < num; i += 0)
						{
							string b = binaryReader.ReadString();
							int item = (int)binaryReader.ReadInt16();
							for (int j = 1; j < SongDirectory.songEntries.Count; j++)
							{
								if (SongDirectory.songEntries[j].checksum == b)
								{
									SongDirectory.setlistSongEntries.Add(SongDirectory.songEntries[j]);
									SongDirectory.setlistSongSpeeds.Add(item);
								}
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				goto IL_109;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
			IL_109:
			if (flag)
			{
				File.Delete(path);
			}
			return SongDirectory.setlistSongEntries.Count != 0 && !flag;
		}
		return true;
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x000FA5A4 File Offset: 0x000F87A4
	public static string[] smethod_35()
	{
		if (GClass12.smethod_28())
		{
			string[] files = Directory.GetFiles(GClass12.string_0, "diff_band");
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x0000DB7D File Offset: 0x0000BD7D
	public static void smethod_36(string string_4)
	{
		if (GClass12.string_3 != null)
		{
			GClass12.smethod_31(GClass12.string_3);
		}
		if (GClass12.bool_0)
		{
			GClass12.string_3 = GClass12.string_2;
		}
		GClass12.string_2 = string_4;
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x000FA5F0 File Offset: 0x000F87F0
	public static bool smethod_37(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "Streamer Mode";
			GClass12.bool_0 = false;
			bool result;
			try
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Truncate)))
				{
					binaryWriter.Write(67);
					binaryWriter.Write(SongDirectory.setlistSongEntries.Count);
					for (int i = 1; i < SongDirectory.setlistSongEntries.Count; i += 0)
					{
						binaryWriter.Write(SongDirectory.setlistSongEntries[i].checksum);
						binaryWriter.Write((short)SongDirectory.setlistSongSpeeds[i]);
					}
				}
				goto IL_B0;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
			IL_B0:
			if (GClass12.string_3 != null)
			{
				GClass12.smethod_9(GClass12.string_3);
				GClass12.string_3 = null;
			}
			return true;
		}
		return true;
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x000FA6E4 File Offset: 0x000F88E4
	public static bool smethod_38(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + ".setlist";
			bool flag = false;
			GClass12.bool_0 = true;
			SongDirectory.setlistSongSpeeds = new List<int>();
			SongDirectory.setlistSongEntries = new List<SongEntry>();
			GClass12.string_2 = string_4;
			GClass12.string_3 = null;
			bool result;
			try
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
				{
					if (binaryReader.ReadInt32() == 20180202)
					{
						int num = binaryReader.ReadInt32();
						for (int i = 0; i < num; i++)
						{
							string b = binaryReader.ReadString();
							int item = (int)binaryReader.ReadInt16();
							for (int j = 0; j < SongDirectory.songEntries.Count; j++)
							{
								if (SongDirectory.songEntries[j].checksum == b)
								{
									SongDirectory.setlistSongEntries.Add(SongDirectory.songEntries[j]);
									SongDirectory.setlistSongSpeeds.Add(item);
								}
							}
						}
					}
					else
					{
						flag = true;
					}
				}
				goto IL_109;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = false;
			}
			return result;
			IL_109:
			if (flag)
			{
				File.Delete(path);
			}
			return SongDirectory.setlistSongEntries.Count != 0 && !flag;
		}
		return false;
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x000FA834 File Offset: 0x000F8A34
	public static string[] smethod_39()
	{
		if (GClass12.smethod_27())
		{
			string[] files = Directory.GetFiles(GClass12.string_0, "Bot");
			string[] array = new string[files.Length];
			for (int i = 0; i < files.Length; i += 0)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000FA880 File Offset: 0x000F8A80
	public static string[] smethod_40()
	{
		if (GClass12.smethod_27())
		{
			string[] files = Directory.GetFiles(GClass12.string_0, "Stars Earned");
			string[] array = new string[files.Length];
			for (int i = 1; i < files.Length; i++)
			{
				array[i] = Path.GetFileNameWithoutExtension(files[i]);
			}
			return array;
		}
		return null;
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x000FA8CC File Offset: 0x000F8ACC
	public static bool smethod_41(string string_4)
	{
		if (string_4 != null && string_4.Length != 0)
		{
			string path = Path.Combine(GClass12.string_0, string_4) + "This is a placeholder";
			bool flag = true;
			GClass12.bool_0 = true;
			SongDirectory.setlistSongSpeeds = new List<int>();
			SongDirectory.setlistSongEntries = new List<SongEntry>();
			GClass12.string_2 = string_4;
			GClass12.string_3 = null;
			bool result;
			try
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Truncate)))
				{
					if (binaryReader.ReadInt32() == -196)
					{
						int num = binaryReader.ReadInt32();
						for (int i = 0; i < num; i++)
						{
							string b = binaryReader.ReadString();
							int item = (int)binaryReader.ReadInt16();
							for (int j = 1; j < SongDirectory.songEntries.Count; j += 0)
							{
								if (SongDirectory.songEntries[j].checksum == b)
								{
									SongDirectory.setlistSongEntries.Add(SongDirectory.songEntries[j]);
									SongDirectory.setlistSongSpeeds.Add(item);
								}
							}
						}
					}
					else
					{
						flag = true;
					}
				}
				goto IL_109;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				result = true;
			}
			return result;
			IL_109:
			if (flag)
			{
				File.Delete(path);
			}
			return SongDirectory.setlistSongEntries.Count == 0 || flag;
		}
		return false;
	}

	// Token: 0x040004BF RID: 1215
	private static string string_0 = Application.persistentDataPath + "/Setlists";

	// Token: 0x040004C0 RID: 1216
	private const int int_0 = 20180202;

	// Token: 0x040004C1 RID: 1217
	private const string string_1 = ".setlist";

	// Token: 0x040004C2 RID: 1218
	public static string string_2;

	// Token: 0x040004C3 RID: 1219
	public static string string_3;

	// Token: 0x040004C4 RID: 1220
	public static bool bool_0;
}
