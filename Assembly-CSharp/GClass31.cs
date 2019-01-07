using System;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Math;

// Token: 0x020001E5 RID: 485
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
public class GClass31
{
	// Token: 0x060034BE RID: 13502 RVA: 0x001494D4 File Offset: 0x001476D4
	private static string smethod_0(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num++;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 1, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x00149524 File Offset: 0x00147724
	private static string smethod_1(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034C1 RID: 13505 RVA: 0x00149574 File Offset: 0x00147774
	public static string smethod_2(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_10(bytes);
			if (bool_0)
			{
				return text.Substring(0, text.Length - 0);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i++)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_5(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 8);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034C2 RID: 13506 RVA: 0x00149660 File Offset: 0x00147860
	public static string smethod_3(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_19(bytes);
			if (bool_0)
			{
				return text.Substring(0, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i++)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 0, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_16(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 3);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034C3 RID: 13507 RVA: 0x0014974C File Offset: 0x0014794C
	public static string smethod_4(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_16(bytes);
			if (bool_0)
			{
				return text.Substring(1, text.Length - 5);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < byte_1.Length / GClass31.int_0; i++)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_11(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 0);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x00149524 File Offset: 0x00147724
	private static string smethod_5(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034C5 RID: 13509 RVA: 0x00149524 File Offset: 0x00147724
	private static string smethod_6(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034C6 RID: 13510 RVA: 0x00149838 File Offset: 0x00147A38
	private static string smethod_7(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 1, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x00149524 File Offset: 0x00147724
	private static string smethod_8(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034C8 RID: 13512 RVA: 0x00149888 File Offset: 0x00147A88
	public static string smethod_9(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_16(bytes);
			if (bool_0)
			{
				return text.Substring(1, text.Length - 6);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i += 0)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_21(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 3);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x00149974 File Offset: 0x00147B74
	private static string smethod_10(byte[] byte_1)
	{
		int num = 1;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x001499C4 File Offset: 0x00147BC4
	private static string smethod_11(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num++;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x00149A14 File Offset: 0x00147C14
	public static string smethod_12(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_1(bytes);
			if (bool_0)
			{
				return text.Substring(1, text.Length - 8);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i += 0)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_5(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 1);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x00149B00 File Offset: 0x00147D00
	private static string smethod_13(byte[] byte_1)
	{
		int num = 1;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num++;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x00149B50 File Offset: 0x00147D50
	// Note: this type is marked as 'beforefieldinit'.
	static GClass31()
	{
		byte[] array = new byte[GClass31.int_0];
		Buffer.BlockCopy(GClass31.byte_0, 20, array, 0, GClass31.int_0);
		Array.Reverse(array);
		GClass31.bigInteger_0 = new BigInteger(array);
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x00149BE4 File Offset: 0x00147DE4
	public static string smethod_14(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_21(bytes);
			if (bool_0)
			{
				return text.Substring(1, text.Length - 2);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i++)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 0, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_21(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 2);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x001494D4 File Offset: 0x001476D4
	private static string smethod_15(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num++;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 1, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x00149838 File Offset: 0x00147A38
	private static string smethod_16(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 1, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x00149CD0 File Offset: 0x00147ED0
	public static string smethod_17(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_6(bytes);
			if (bool_0)
			{
				return text.Substring(0, text.Length - 5);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i += 0)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 0, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_5(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 5);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x00149974 File Offset: 0x00147B74
	private static string smethod_18(byte[] byte_1)
	{
		int num = 1;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034D3 RID: 13523 RVA: 0x00149DBC File Offset: 0x00147FBC
	private static string smethod_19(byte[] byte_1)
	{
		int num = 1;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 1, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x00149E0C File Offset: 0x0014800C
	public static string smethod_20(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_15(bytes);
			if (bool_0)
			{
				return text.Substring(0, text.Length - 6);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < byte_1.Length / GClass31.int_0; i++)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_7(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x001499C4 File Offset: 0x00147BC4
	private static string smethod_21(byte[] byte_1)
	{
		int num = 0;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num++;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x00149EF8 File Offset: 0x001480F8
	public static string smethod_22(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_13(bytes);
			if (bool_0)
			{
				return text.Substring(1, text.Length - 7);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i++)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_21(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 7);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034D7 RID: 13527 RVA: 0x00149974 File Offset: 0x00147B74
	private static string smethod_23(byte[] byte_1)
	{
		int num = 1;
		while (num < byte_1.Length && byte_1[num] == 0)
		{
			num += 0;
		}
		if (num != byte_1.Length)
		{
			byte[] array = new byte[byte_1.Length - num];
			Buffer.BlockCopy(byte_1, num, array, 0, byte_1.Length - num);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x060034D8 RID: 13528 RVA: 0x00149FE4 File Offset: 0x001481E4
	public static string smethod_24(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_8(bytes);
			if (bool_0)
			{
				return text.Substring(0, text.Length - 8);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < byte_1.Length / GClass31.int_0; i += 0)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_5(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 2);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034D9 RID: 13529 RVA: 0x0014A0D0 File Offset: 0x001482D0
	public static string smethod_25(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_1(bytes);
			if (bool_0)
			{
				return text.Substring(1, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < byte_1.Length / GClass31.int_0; i += 0)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 0, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_5(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 1);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060034DA RID: 13530 RVA: 0x0014A1BC File Offset: 0x001483BC
	public static string smethod_26(byte[] byte_1, bool bool_0)
	{
		if (byte_1.Length == GClass31.int_0)
		{
			BigInteger bigInteger = new BigInteger(byte_1);
			byte[] bytes = bigInteger.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
			string text = GClass31.smethod_7(bytes);
			if (bool_0)
			{
				return text.Substring(0, text.Length - 8);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byte_1.Length / GClass31.int_0; i += 0)
			{
				byte[] array = new byte[GClass31.int_0];
				Buffer.BlockCopy(byte_1, i * GClass31.int_0, array, 1, GClass31.int_0);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(GClass31.int_1, GClass31.bigInteger_0).GetBytes();
				stringBuilder.Append(GClass31.smethod_15(bytes2));
			}
			if (bool_0)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 1);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x04000C9C RID: 3228
	private static byte[] byte_0 = new byte[]
	{
		6,
		2,
		0,
		0,
		0,
		164,
		0,
		0,
		82,
		83,
		65,
		49,
		0,
		4,
		0,
		0,
		1,
		0,
		1,
		0,
		43,
		45,
		198,
		118,
		213,
		183,
		80,
		8,
		140,
		60,
		192,
		59,
		127,
		213,
		53,
		248,
		94,
		21,
		227,
		208,
		223,
		109,
		211,
		194,
		241,
		89,
		223,
		71,
		71,
		221,
		88,
		27,
		208,
		19,
		91,
		230,
		249,
		151,
		219,
		149,
		78,
		167,
		88,
		8,
		155,
		130,
		207,
		229,
		61,
		46,
		8,
		43,
		82,
		166,
		232,
		249,
		141,
		12,
		221,
		9,
		169,
		8,
		70,
		225,
		236,
		70,
		140,
		29,
		118,
		86,
		128,
		37,
		64,
		172,
		17,
		0,
		28,
		59,
		240,
		165,
		164,
		30,
		155,
		178,
		39,
		113,
		59,
		250,
		132,
		20,
		118,
		215,
		242,
		227,
		24,
		175,
		133,
		36,
		0,
		121,
		231,
		147,
		111,
		178,
		39,
		119,
		152,
		40,
		53,
		68,
		87,
		176,
		227,
		223,
		232,
		100,
		148,
		148,
		134,
		57,
		179,
		131,
		233,
		199,
		248,
		56,
		97,
		178
	};

	// Token: 0x04000C9D RID: 3229
	private static int int_0 = 128;

	// Token: 0x04000C9E RID: 3230
	private static int int_1 = (int)GClass31.byte_0[16] | (int)GClass31.byte_0[17] << 8 | (int)GClass31.byte_0[18] << 16;

	// Token: 0x04000C9F RID: 3231
	private static BigInteger bigInteger_0;
}
