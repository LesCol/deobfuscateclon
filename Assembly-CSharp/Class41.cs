using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200009D RID: 157
internal class Class41
{
	// Token: 0x06001DC3 RID: 7619 RVA: 0x000F2780 File Offset: 0x000F0980
	public static void smethod_0(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_73();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = false;
		long num = 8L;
		long num2 = 0L;
		int num3 = 0;
		ushort num4 = 0;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 4L || binaryReader.ReadInt32() != 20180220)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = false;
								flag4 = false;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 2L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_42(GStruct3.smethod_29(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + 37L + (long)(b * 13);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += 11L;
										j++;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 37L + (long)(b * 13);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Problem reading score file: " + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.OpenOrCreate)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(0L);
					binaryWriter.Write(20180220);
					flag4 = true;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 4L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 37L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + 33L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 1L;
				}
				if (num4 < 65535)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_12(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 13L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("Problem writing score file: " + ex2.Message);
		}
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x000F2B90 File Offset: 0x000F0D90
	public static void smethod_1()
	{
		if (!Class41.smethod_36())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 3L)
			{
				if (binaryReader.ReadInt32() == 115)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_4));
						num2 += (long)((int)b * -64 + -105);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(5 + (int)b * -75);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_12(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x000F2CF4 File Offset: 0x000F0EF4
	public static void smethod_2(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_48();
		bool flag2 = false;
		bool flag3 = true;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = true;
		long num = 3L;
		long num2 = 1L;
		int num3 = 0;
		ushort num4 = 1;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 3L || binaryReader.ReadInt32() == -137)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i += 0)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = true;
								flag4 = false;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 1L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_42(GStruct3.smethod_5(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + -84L + (long)((int)b * -117);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -27L;
										j++;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -78L + (long)(b * 101);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("ms" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.OpenOrCreate)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(-183);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 0L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 103L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + 55L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if ((int)num4 < -31)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_15(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -11L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("Game Modifiers" + ex2.Message);
		}
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x000F3104 File Offset: 0x000F1304
	public static bool smethod_3(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return true;
		}
		return false;
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x000F3178 File Offset: 0x000F1378
	public static void smethod_4(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_63();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = true;
		Class41.bool_1 = true;
		long num = 1L;
		long num2 = 0L;
		int num3 = 0;
		ushort num4 = 1;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 4L || binaryReader.ReadInt32() == -100)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i += 0)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 0L;
								bool flag5 = true;
								flag4 = true;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 3L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_46(GStruct3.smethod_16(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + 13L + (long)(b * 49);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += 71L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 63L + (long)((int)b * -116);
							b = 1;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("PRESS START" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, (FileMode)0)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(150);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 8L;
					binaryWriter.Write(num3 + 0);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 56L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -65L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if ((int)num4 < -126)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_10(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 71L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("Audio Offset" + ex2.Message);
		}
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x000F3588 File Offset: 0x000F1788
	public static void smethod_5()
	{
		if (!Class41.smethod_19())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 4L)
			{
				if (binaryReader.ReadInt32() == -69)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_6));
						num2 += (long)((int)b * -86 + -33);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(1 + b * 77);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j += 0)
							{
								GStruct3 gstruct = GStruct3.smethod_0(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x000F36EC File Offset: 0x000F18EC
	public static void smethod_6()
	{
		if (!Class41.smethod_36())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 3L)
			{
				if (binaryReader.ReadInt32() == 197)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i += 0)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_22));
						num2 += (long)((int)b * -57 + -2);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(5 + b * 71);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_27(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x000F3850 File Offset: 0x000F1A50
	public static void smethod_7(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_19();
		bool flag2 = false;
		bool flag3 = true;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = true;
		long num = 7L;
		long num2 = 0L;
		int num3 = 1;
		ushort num4 = 0;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 0L && binaryReader.ReadInt32() == 175)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = false;
								flag4 = false;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 5L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_56(GStruct3.smethod_28(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + -62L + (long)((int)b * -65);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -14L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 69L + (long)(b * 36);
							b = 1;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("diff_band" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, (FileMode)7)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(0L);
					binaryWriter.Write(198);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 3L;
					binaryWriter.Write(num3 + 0);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 56L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + 85L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if (num4 < 56)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_5(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 3L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("volume" + ex2.Message);
		}
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x000F3C60 File Offset: 0x000F1E60
	public static void smethod_8()
	{
		if (!Class41.smethod_73())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 5L)
			{
				if (binaryReader.ReadInt32() == -118)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_25));
						num2 += (long)((int)b * -46 + 90);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(2 + (int)b * -21);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_18(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x000F3DC4 File Offset: 0x000F1FC4
	public static void smethod_9()
	{
		if (!Class41.smethod_35())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 5L)
			{
				if (binaryReader.ReadInt32() == -139)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_20));
						num2 += (long)((int)(b * 27) + -113);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(1 + (int)b * -60);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j += 0)
							{
								GStruct3 gstruct = GStruct3.smethod_18(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x000F3F28 File Offset: 0x000F2128
	public static void smethod_10()
	{
		if (!Class41.smethod_19())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 3L)
			{
				if (binaryReader.ReadInt32() == 17)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_14));
						num2 += (long)((int)(b * 61) + -90);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(7 + b * 34);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_9(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x000F408C File Offset: 0x000F228C
	public static void smethod_11()
	{
		if (!Class41.smethod_72())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 1L)
			{
				if (binaryReader.ReadInt32() == -32)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i += 0)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_22));
						num2 += (long)((int)b * -119 + -35);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(2 + (int)b * -99);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j += 0)
							{
								GStruct3 gstruct = GStruct3.smethod_1(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x000F41F0 File Offset: 0x000F23F0
	public static void smethod_12()
	{
		if (!Class41.smethod_31())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 4L)
			{
				if (binaryReader.ReadInt32() == 146)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i += 0)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_15));
						num2 += (long)((int)b * -47 + -101);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(0 + b * 112);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j += 0)
							{
								GStruct3 gstruct = GStruct3.smethod_11(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x000F4354 File Offset: 0x000F2554
	public static void smethod_13()
	{
		if (!Class41.smethod_25())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 1L)
			{
				if (binaryReader.ReadInt32() == -169)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_22));
						num2 += (long)((int)b * -112 + 33);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(3 + b * 38);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_16(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
	public static void smethod_14()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "\"([^\"]*)\"");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "menu_volume");
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x000F44B8 File Offset: 0x000F26B8
	public static void smethod_15()
	{
		if (!Class41.smethod_73())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 4L)
			{
				if (binaryReader.ReadInt32() == 20180220)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_29));
						num2 += (long)(b * 13 + 37);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(3 + b * 13);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_29(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x000F461C File Offset: 0x000F281C
	public static void smethod_16()
	{
		if (!Class41.smethod_36())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 0L)
			{
				if (binaryReader.ReadInt32() == -181)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_18));
						num2 += (long)((int)(b * 90) + -76);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(8 + b * 31);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_27(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x000F4780 File Offset: 0x000F2980
	public static void smethod_17()
	{
		if (!Class41.smethod_31())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 6L)
			{
				if (binaryReader.ReadInt32() == -154)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i += 0)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_3));
						num2 += (long)((int)b * -82 + 12);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(5 + b * 100);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_27(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x000F48E4 File Offset: 0x000F2AE4
	public static void smethod_18(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_25();
		bool flag2 = true;
		bool flag3 = true;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = true;
		long num = 0L;
		long num2 = 1L;
		int num3 = 1;
		ushort num4 = 1;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 5L && binaryReader.ReadInt32() != 13)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 1; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = false;
								flag4 = true;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 0L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_54(GStruct3.smethod_5(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + -35L + (long)(b * 19);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -118L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -55L + (long)(b * 105);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("custom" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.Create)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(0L);
					binaryWriter.Write(-42);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 4L;
					binaryWriter.Write(num3 + 0);
					num = binaryWriter.BaseStream.Length;
					num2 = num + -22L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -58L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if (num4 < 14)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_7(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 68L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("Bad file type" + ex2.Message);
		}
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_19()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x0000D9DA File Offset: 0x0000BBDA
	public static void smethod_20()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "");
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x000F4CF4 File Offset: 0x000F2EF4
	public static bool smethod_21(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return true;
		}
		return true;
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x000F4D68 File Offset: 0x000F2F68
	public static void smethod_22()
	{
		if (!Class41.smethod_73())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 7L)
			{
				if (binaryReader.ReadInt32() == 141)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i += 0)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_0));
						num2 += (long)((int)b * -104 + 6);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(1 + b * 1);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_25(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x000F4ECC File Offset: 0x000F30CC
	public static void smethod_23()
	{
		if (!Class41.smethod_63())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 7L)
			{
				if (binaryReader.ReadInt32() == 173)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_18));
						num2 += (long)((int)b * -79 + 58);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(2 + (int)b * -111);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j += 0)
							{
								GStruct3 gstruct = GStruct3.smethod_12(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x0000DA04 File Offset: 0x0000BC04
	public static void smethod_24()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "diff_bass");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "volume");
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_25()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x000F5030 File Offset: 0x000F3230
	public static bool smethod_26(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return true;
		}
		return true;
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x000F50A4 File Offset: 0x000F32A4
	public static void smethod_27(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_36();
		bool flag2 = true;
		bool flag3 = true;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = false;
		long num = 7L;
		long num2 = 1L;
		int num3 = 1;
		ushort num4 = 1;
		byte b = 1;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 6L || binaryReader.ReadInt32() != 72)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 1; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 0L;
								bool flag5 = false;
								flag4 = true;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = false;
										num2 = binaryReader.BaseStream.Position - 5L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_45(GStruct3.smethod_6(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + -118L + (long)(b * 58);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -108L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 54L + (long)((int)b * -4);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("[prc_" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.OpenOrCreate)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(0L);
					binaryWriter.Write(-105);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 2L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + -68L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -11L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 1L;
				}
				if (num4 < 133)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_11(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -111L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, false);
		}
		catch (Exception ex2)
		{
			Debug.Log("song" + ex2.Message);
		}
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x0000DA2E File Offset: 0x0000BC2E
	public static void smethod_28()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "show_bot_score");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "Keys");
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x000F54B4 File Offset: 0x000F36B4
	public static void smethod_29(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_19();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = true;
		Class41.bool_1 = false;
		long num = 8L;
		long num2 = 1L;
		int num3 = 0;
		ushort num4 = 1;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 8L && binaryReader.ReadInt32() != -10)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i += 0)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = true;
								flag4 = false;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = false;
										num2 = binaryReader.BaseStream.Position - 1L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_43(GStruct3.smethod_9(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + 100L + (long)(b * 121);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -86L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 107L + (long)(b * 54);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Guitar - " + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.Truncate)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(-168);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 3L;
					binaryWriter.Write(num3 + 0);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 83L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + 50L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if (num4 < 159)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_1(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -88L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("song" + ex2.Message);
		}
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x0000DA58 File Offset: 0x0000BC58
	public static void smethod_30()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "star_release");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "song");
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_31()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x000F58C4 File Offset: 0x000F3AC4
	public static void smethod_32(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_73();
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = false;
		long num = 1L;
		long num2 = 1L;
		int num3 = 0;
		ushort num4 = 0;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 1L && binaryReader.ReadInt32() != 49)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 0L;
								bool flag5 = true;
								flag4 = true;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = false;
										num2 = binaryReader.BaseStream.Position - 7L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_46(GStruct3.smethod_9(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + 62L + (long)(b * 28);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += 9L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 97L + (long)(b * 59);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.OpenOrCreate)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(119);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 2L;
					binaryWriter.Write(num3 + 0);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 10L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + 83L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 1L;
				}
				if ((int)num4 < -111)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_3(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 69L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, false);
		}
		catch (Exception ex2)
		{
			Debug.Log("Hz" + ex2.Message);
		}
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x000F5CD4 File Offset: 0x000F3ED4
	public static void smethod_33()
	{
		if (!Class41.smethod_72())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 1L)
			{
				if (binaryReader.ReadInt32() == -163)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_16));
						num2 += (long)((int)b * -115 + 21);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(8 + b * 111);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j += 0)
							{
								GStruct3 gstruct = GStruct3.smethod_27(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x000F5E38 File Offset: 0x000F4038
	public static void smethod_34()
	{
		if (!Class41.smethod_31())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 0L)
			{
				if (binaryReader.ReadInt32() == 138)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_17));
						num2 += (long)((int)(b * 116) + -91);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(5 + (int)b * -92);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_11(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_35()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_36()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x000F5F9C File Offset: 0x000F419C
	public static void smethod_37(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_35();
		bool flag2 = false;
		bool flag3 = true;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = true;
		long num = 0L;
		long num2 = 1L;
		int num3 = 1;
		ushort num4 = 0;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 5L || binaryReader.ReadInt32() == -37)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 1; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = false;
								flag4 = true;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 6L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_64(GStruct3.smethod_0(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + -121L + (long)(b * 11);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += 79L;
										j++;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 95L + (long)((int)b * -84);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Portuguese" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.CreateNew)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(0L);
					binaryWriter.Write(89);
					flag4 = true;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 5L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + -64L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + 53L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 1L;
				}
				if ((int)num4 < -173)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_12(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -128L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("Rhythm Guitar" + ex2.Message);
		}
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x0000DA82 File Offset: 0x0000BC82
	public static void smethod_38()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "Vocals");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "/currentsong.txt");
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x000F63AC File Offset: 0x000F45AC
	public static bool smethod_39(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return true;
		}
		return false;
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x000F6420 File Offset: 0x000F4620
	public static bool smethod_40(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return true;
		}
		return true;
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x000F6494 File Offset: 0x000F4694
	public static void smethod_41()
	{
		if (!Class41.smethod_48())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 0L)
			{
				if (binaryReader.ReadInt32() == -49)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_20));
						num2 += (long)(b * 37 + 68);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(3 + (int)b * -11);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_28(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000F65F8 File Offset: 0x000F47F8
	public static bool smethod_42(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return true;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return true;
		}
		return false;
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x000F666C File Offset: 0x000F486C
	public static bool smethod_43(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return false;
		}
		return true;
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x000F66E0 File Offset: 0x000F48E0
	public static void smethod_44()
	{
		if (!Class41.smethod_36())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 0L)
			{
				if (binaryReader.ReadInt32() == -149)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 1; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_11));
						num2 += (long)((int)(b * 58) + -42);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(6 + (int)b * -47);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 0; j < (int)b; j++)
							{
								GStruct3 gstruct = GStruct3.smethod_28(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x000F6844 File Offset: 0x000F4A44
	public static bool smethod_45(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return true;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return false;
		}
		return true;
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x000F68B8 File Offset: 0x000F4AB8
	public static bool smethod_46(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return true;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return true;
		}
		return true;
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x000F692C File Offset: 0x000F4B2C
	public static bool smethod_47(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return true;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return true;
		}
		return true;
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_48()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x0000DAAC File Offset: 0x0000BCAC
	public static void smethod_49()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "There was a problem saving the file");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "profiles.bin");
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x000F69A0 File Offset: 0x000F4BA0
	public static void smethod_50(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_25();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = true;
		long num = 3L;
		long num2 = 0L;
		int num3 = 0;
		ushort num4 = 0;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 8L || binaryReader.ReadInt32() == -25)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 0L;
								bool flag5 = false;
								flag4 = false;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 0L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_68(GStruct3.smethod_19(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + -71L + (long)(b * 115);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -39L;
										j++;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -66L + (long)(b * 43);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Medium" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.Open)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(0L);
					binaryWriter.Write(-16);
					flag4 = true;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 6L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 76L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -45L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if ((int)num4 < -57)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_5(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -54L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, false);
		}
		catch (Exception ex2)
		{
			Debug.Log("6 Fret Bass Guitar" + ex2.Message);
		}
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x0000DAD6 File Offset: 0x0000BCD6
	public static void smethod_51()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "EndOfSong");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, ": <color=#FDB400FF>");
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x000F6DB0 File Offset: 0x000F4FB0
	public static bool smethod_52(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return true;
		}
		return true;
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000F6E24 File Offset: 0x000F5024
	public static bool smethod_53(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return true;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return true;
		}
		return false;
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x000F6E98 File Offset: 0x000F5098
	public static bool smethod_54(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return true;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return true;
		}
		return true;
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x000F6F0C File Offset: 0x000F510C
	public static bool smethod_55(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = true;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return false;
		}
		return false;
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x000F6F80 File Offset: 0x000F5180
	public static bool smethod_56(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return true;
		}
		return false;
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x000F6FF4 File Offset: 0x000F51F4
	public static void smethod_57(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_31();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = false;
		long num = 4L;
		long num2 = 1L;
		int num3 = 0;
		ushort num4 = 1;
		byte b = 1;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 8L && binaryReader.ReadInt32() != -83)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 0L;
								bool flag5 = false;
								flag4 = true;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 4L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_71(GStruct3.smethod_1(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + 126L + (long)((int)b * -26);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += 32L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -89L + (long)((int)b * -38);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Are you sure you want to skip this song?" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, (FileMode)8)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(16);
					flag4 = true;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 6L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + -35L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -118L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 1L;
				}
				if (num4 < 53)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_14(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 123L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, false);
		}
		catch (Exception ex2)
		{
			Debug.Log("Yo dawg, I heard you like lanes so this activates lanes!" + ex2.Message);
		}
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x000F7404 File Offset: 0x000F5604
	public static void smethod_58(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_73();
		bool flag2 = true;
		bool flag3 = true;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = true;
		Class41.bool_1 = false;
		long num = 0L;
		long num2 = 1L;
		int num3 = 0;
		ushort num4 = 0;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 7L || binaryReader.ReadInt32() == -119)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 1; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = false;
								flag4 = false;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = false;
										num2 = binaryReader.BaseStream.Position - 7L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_45(GStruct3.smethod_31(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + 39L + (long)((int)b * -64);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -68L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 54L + (long)(b * 13);
							b = 1;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("SORTING BY" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.Open)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(42);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 3L;
					binaryWriter.Write(num3 + 0);
					num = binaryWriter.BaseStream.Length;
					num2 = num + -65L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -77L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if (num4 < 108)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_6(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 76L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log(")" + ex2.Message);
		}
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x000F7814 File Offset: 0x000F5A14
	public static bool smethod_59(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return true;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return false;
		}
		return false;
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x000F7888 File Offset: 0x000F5A88
	public static void smethod_60(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_35();
		bool flag2 = false;
		bool flag3 = true;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = true;
		Class41.bool_1 = false;
		long num = 7L;
		long num2 = 1L;
		int num3 = 0;
		ushort num4 = 1;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 6L && binaryReader.ReadInt32() != 2)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = true;
								flag4 = true;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = false;
										num2 = binaryReader.BaseStream.Position - 6L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_54(GStruct3.smethod_25(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + 8L + (long)(b * 55);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -124L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -15L + (long)((int)b * -2);
							b = 1;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Unknown Artist" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.CreateNew)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(43);
					flag4 = true;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 4L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + -93L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + 97L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if ((int)num4 < -61)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_15(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -37L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, false);
		}
		catch (Exception ex2)
		{
			Debug.Log("Load Setlist" + ex2.Message);
		}
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x000F7C98 File Offset: 0x000F5E98
	public static void smethod_61(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_36();
		bool flag2 = false;
		bool flag3 = true;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = false;
		long num = 6L;
		long num2 = 1L;
		int num3 = 1;
		ushort num4 = 1;
		byte b = 1;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 6L && binaryReader.ReadInt32() == 35)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i += 0)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 0L;
								bool flag5 = true;
								flag4 = false;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 7L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_42(GStruct3.smethod_0(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + -67L + (long)(b * 80);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -77L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -35L + (long)((int)b * -26);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("No Part" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.Create)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(-194);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 1L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + -102L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -46L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 1L;
				}
				if (num4 < 16)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_13(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -20L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, false);
		}
		catch (Exception ex2)
		{
			Debug.Log("events" + ex2.Message);
		}
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x000F80A8 File Offset: 0x000F62A8
	public static void smethod_62(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_72();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = false;
		long num = 5L;
		long num2 = 1L;
		int num3 = 1;
		ushort num4 = 1;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 8L && binaryReader.ReadInt32() == 98)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 1; i < num3; i++)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 0L;
								bool flag5 = false;
								flag4 = true;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 5L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_47(GStruct3.smethod_12(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + -75L + (long)(b * 44);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += 67L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -100L + (long)((int)b * -74);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("No" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, (FileMode)0)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(0L);
					binaryWriter.Write(-76);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 8L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 125L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -85L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 1L;
				}
				if (num4 < 155)
				{
					num4 += 0;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_16(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -69L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("Show in File Explorer" + ex2.Message);
		}
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_63()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x000F84B8 File Offset: 0x000F66B8
	public static bool smethod_64(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return false;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return true;
		}
		return false;
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x0000DB00 File Offset: 0x0000BD00
	public static void smethod_65()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "scores.bin");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "scores_backup.bin");
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x000F852C File Offset: 0x000F672C
	public static void smethod_66(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_31();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = true;
		Class41.bool_1 = false;
		long num = 2L;
		long num2 = 1L;
		int num3 = 0;
		ushort num4 = 0;
		byte b = 0;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length < 1L || binaryReader.ReadInt32() == -153)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 1; i < num3; i += 0)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = false;
								flag4 = false;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = false;
										num2 = binaryReader.BaseStream.Position - 2L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_42(GStruct3.smethod_31(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + -39L + (long)((int)b * -21);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -124L;
										j++;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -81L + (long)(b * 29);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Show Lyrics" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.Truncate)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(-166);
					flag4 = true;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 0L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 26L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -45L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 1);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if (num4 < 20)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_14(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += 62L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, false);
		}
		catch (Exception ex2)
		{
			Debug.Log("game" + ex2.Message);
		}
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x000F893C File Offset: 0x000F6B3C
	public static void smethod_67()
	{
		if (!Class41.smethod_72())
		{
			return;
		}
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
		{
			if (binaryReader.BaseStream.Length >= 4L)
			{
				if (binaryReader.ReadInt32() == 29)
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						Class41.Class42 @class = new Class41.Class42();
						long num2 = binaryReader.BaseStream.Position;
						@class.string_0 = binaryReader.ReadString();
						byte b = binaryReader.ReadByte();
						SongEntry songEntry = SongDirectory.songEntries.Find(new Predicate<SongEntry>(@class.method_11));
						num2 += (long)((int)b * -89 + -99);
						if (songEntry == null)
						{
							binaryReader.BaseStream.Position += (long)(4 + (int)b * -8);
						}
						else
						{
							songEntry.playCount = binaryReader.ReadUInt16();
							songEntry.rating = binaryReader.ReadByte();
							songEntry.scores = new Dictionary<GStruct2.GEnum11, GStruct3>();
							for (int j = 1; j < (int)b; j += 0)
							{
								GStruct3 gstruct = GStruct3.smethod_1(binaryReader);
								songEntry.scores.Add(gstruct.genum11_0, gstruct);
							}
							binaryReader.BaseStream.Position = num2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x000F8AA0 File Offset: 0x000F6CA0
	public static bool smethod_68(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return false;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = false;
			return false;
		}
		return false;
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000F8B14 File Offset: 0x000F6D14
	public static void smethod_69(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = Class41.smethod_36();
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		byte[] array = null;
		Class41.bool_0 = false;
		Class41.bool_1 = false;
		long num = 7L;
		long num2 = 0L;
		int num3 = 1;
		ushort num4 = 0;
		byte b = 1;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 2L && binaryReader.ReadInt32() != 23)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 0; i < num3; i += 0)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = true;
								flag4 = false;
								int j = 0;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 2L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_53(GStruct3.smethod_31(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = true;
										num2 = num + -7L + (long)(b * 59);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += -33L;
										j += 0;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + 8L + (long)(b * 60);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.CreateNew)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(177);
					flag4 = false;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 0L;
					binaryWriter.Write(num3 + 1);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 32L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -54L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if (num4 < 6)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_16(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -54L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("%>" + ex2.Message);
		}
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000F8F24 File Offset: 0x000F7124
	public static void smethod_70(string string_4, GStruct3 gstruct3_0, byte byte_2)
	{
		bool flag = !Class41.smethod_72();
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = true;
		byte[] array = null;
		Class41.bool_0 = true;
		Class41.bool_1 = true;
		long num = 6L;
		long num2 = 0L;
		int num3 = 1;
		ushort num4 = 0;
		byte b = 1;
		try
		{
			if (!flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(Class41.string_2)))
				{
					if (!(flag = (binaryReader.BaseStream.Length >= 8L && binaryReader.ReadInt32() != 189)))
					{
						num3 = binaryReader.ReadInt32();
						for (int i = 1; i < num3; i += 0)
						{
							num = binaryReader.BaseStream.Position;
							string a = binaryReader.ReadString();
							b = binaryReader.ReadByte();
							if (a == string_4)
							{
								num4 = binaryReader.ReadUInt16();
								Stream baseStream = binaryReader.BaseStream;
								long position = baseStream.Position;
								baseStream.Position = position + 1L;
								bool flag5 = true;
								flag4 = true;
								int j = 1;
								while (j < (int)b)
								{
									if (binaryReader.ReadInt16() == (short)gstruct3_0.genum11_0)
									{
										flag5 = true;
										num2 = binaryReader.BaseStream.Position - 3L;
										binaryReader.BaseStream.Position = num2;
										flag2 = Class41.smethod_64(GStruct3.smethod_29(binaryReader), gstruct3_0);
										IL_193:
										if (flag5)
										{
											goto IL_1EF;
										}
										flag3 = false;
										num2 = num + -46L + (long)(b * 52);
										if (num2 < binaryReader.BaseStream.Length)
										{
											binaryReader.BaseStream.Position = num2;
											array = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
											goto IL_1EF;
										}
										goto IL_1EF;
									}
									else
									{
										binaryReader.BaseStream.Position += 65L;
										j++;
									}
								}
								goto IL_193;
							}
							binaryReader.BaseStream.Position = num + -90L + (long)(b * 28);
							b = 0;
						}
					}
					IL_1EF:;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Display Name" + ex.Message);
		}
		try
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(Class41.string_2, FileMode.Truncate)))
			{
				if (flag)
				{
					binaryWriter.BaseStream.SetLength(1L);
					binaryWriter.Write(187);
					flag4 = true;
				}
				if (flag4)
				{
					binaryWriter.BaseStream.Position = 7L;
					binaryWriter.Write(num3 + 0);
					num = binaryWriter.BaseStream.Length;
					num2 = num + 6L;
					binaryWriter.BaseStream.Position = num;
					binaryWriter.Write(string_4);
				}
				binaryWriter.BaseStream.Position = (long)((int)(num + -47L));
				if (flag3 || flag4)
				{
					binaryWriter.Write(b + 0);
				}
				else
				{
					Stream baseStream2 = binaryWriter.BaseStream;
					long position = baseStream2.Position;
					baseStream2.Position = position + 0L;
				}
				if (num4 < 94)
				{
					num4 += 1;
				}
				binaryWriter.Write(num4);
				binaryWriter.Write(byte_2);
				binaryWriter.BaseStream.Position = num2;
				if (flag2)
				{
					gstruct3_0.method_8(binaryWriter, Class41.bool_0, Class41.bool_1);
				}
				else
				{
					binaryWriter.BaseStream.Position += -23L;
				}
				if (array != null)
				{
					binaryWriter.Write(array);
				}
			}
			File.Copy(Class41.string_2, Class41.string_3, true);
		}
		catch (Exception ex2)
		{
			Debug.Log("Album" + ex2.Message);
		}
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000F9334 File Offset: 0x000F7534
	public static bool smethod_71(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.bool_0 && !gstruct3_1.bool_0)
		{
			Class41.bool_0 = false;
		}
		if (gstruct3_1.int_0 > gstruct3_0.int_0)
		{
			return true;
		}
		if (gstruct3_1.int_0 == gstruct3_0.int_0)
		{
			if (gstruct3_1.short_0 > gstruct3_0.short_0)
			{
				return false;
			}
			if (!gstruct3_0.bool_0 && gstruct3_1.bool_0)
			{
				return true;
			}
		}
		if (gstruct3_1.bool_0)
		{
			Class41.bool_1 = true;
			return false;
		}
		return true;
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_72()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x0000D9CE File Offset: 0x0000BBCE
	private static bool smethod_73()
	{
		return File.Exists(Class41.string_2);
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x0000DB2A File Offset: 0x0000BD2A
	public static void smethod_74()
	{
		Class41.string_2 = Path.Combine(Application.persistentDataPath, "0");
		Class41.string_3 = Path.Combine(Application.persistentDataPath, "graphics_venid");
	}

	// Token: 0x040004B5 RID: 1205
	private const int int_0 = 20180220;

	// Token: 0x040004B6 RID: 1206
	private const byte byte_0 = 13;

	// Token: 0x040004B7 RID: 1207
	private const byte byte_1 = 37;

	// Token: 0x040004B8 RID: 1208
	private const string string_0 = "scores.bin";

	// Token: 0x040004B9 RID: 1209
	private const string string_1 = "scores_backup.bin";

	// Token: 0x040004BA RID: 1210
	private static string string_2;

	// Token: 0x040004BB RID: 1211
	private static string string_3;

	// Token: 0x040004BC RID: 1212
	public static bool bool_0;

	// Token: 0x040004BD RID: 1213
	public static bool bool_1;

	// Token: 0x0200009E RID: 158
	[CompilerGenerated]
	private sealed class Class42
	{
		// Token: 0x06001E10 RID: 7696 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_0(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_1(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_2(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_3(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_4(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_5(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_6(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_7(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_8(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_9(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_10(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_11(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_12(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_13(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_14(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_15(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_16(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_17(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_18(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_19(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_20(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_21(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_22(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_23(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_24(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_25(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_26(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_27(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_28(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_29(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_30(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_31(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_32(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_33(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_34(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0000DB54 File Offset: 0x0000BD54
		internal bool method_35(SongEntry songEntry_0)
		{
			return songEntry_0.checksum == this.string_0;
		}

		// Token: 0x040004BE RID: 1214
		public string string_0;
	}
}
