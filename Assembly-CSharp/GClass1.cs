using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200000B RID: 11
public class GClass1
{
	// Token: 0x06000193 RID: 403 RVA: 0x0001D460 File Offset: 0x0001B660
	public static void smethod_0(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_5();
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0001D484 File Offset: 0x0001B684
	public static void smethod_1(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_2();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_3();
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
	public static void smethod_2(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0001D4CC File Offset: 0x0001B6CC
	public static void smethod_3(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
	public static void smethod_4(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0001D514 File Offset: 0x0001B714
	public static void smethod_5(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0001D538 File Offset: 0x0001B738
	public static void smethod_6(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_10();
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0001D55C File Offset: 0x0001B75C
	public static void smethod_7(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_9();
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0001D580 File Offset: 0x0001B780
	public static void smethod_8(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_5();
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
	public static void smethod_9(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_10();
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
	public static void smethod_10(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0001D5EC File Offset: 0x0001B7EC
	public static void smethod_11(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_9();
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0001D610 File Offset: 0x0001B810
	public static void smethod_12(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_5();
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0001D634 File Offset: 0x0001B834
	public static void smethod_13(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_2();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_10();
	}

	// Token: 0x060001A1 RID: 417
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_Initialize(string string_0, ref GClass1.GStruct0 gstruct0_0, bool bool_0, string string_1);

	// Token: 0x060001A2 RID: 418
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_ClearPresence();

	// Token: 0x060001A3 RID: 419 RVA: 0x0001D658 File Offset: 0x0001B858
	public static void smethod_14(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
	public static void smethod_15(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x0001D67C File Offset: 0x0001B87C
	public static void smethod_16(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_9();
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
	public static void smethod_17(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_3();
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0001D4CC File Offset: 0x0001B6CC
	public static void smethod_18(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x060001A8 RID: 424
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl)]
	private static extern void Discord_UpdatePresence(ref GClass1.RichPresenceStruct richPresenceStruct_0);

	// Token: 0x060001A9 RID: 425 RVA: 0x0001D55C File Offset: 0x0001B75C
	public static void smethod_19(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_9();
	}

	// Token: 0x060001AA RID: 426 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
	public static void smethod_20(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_10();
	}

	// Token: 0x060001AB RID: 427
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_RunCallbacks();

	// Token: 0x060001AC RID: 428 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
	public static void smethod_21(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_10();
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
	public static void smethod_22(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_3();
	}

	// Token: 0x060001AE RID: 430
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_Shutdown();

	// Token: 0x060001B0 RID: 432 RVA: 0x0001D70C File Offset: 0x0001B90C
	public static void smethod_23(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_3();
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
	public static void smethod_24(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_3();
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
	public static void smethod_25(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_3();
	}

	// Token: 0x060001B3 RID: 435
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_UpdateHandlers(ref GClass1.GStruct0 gstruct0_0);

	// Token: 0x060001B4 RID: 436 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
	public static void smethod_26(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0001D730 File Offset: 0x0001B930
	public static void smethod_27(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
	public static void smethod_28(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0001D658 File Offset: 0x0001B858
	public static void smethod_29(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0001D754 File Offset: 0x0001B954
	public static void smethod_30(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_3();
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
	public static void smethod_31(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
	public static void smethod_32(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0001D778 File Offset: 0x0001B978
	public static void smethod_33(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_2();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_9();
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
	public static void smethod_34(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_8();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001BD RID: 445
	[DllImport("discord-rpc", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_Respond(string string_0, GClass1.GEnum2 genum2_0);

	// Token: 0x060001BE RID: 446 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
	public static void smethod_35(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0001D610 File Offset: 0x0001B810
	public static void smethod_36(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_5();
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
	public static void smethod_37(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_4();
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0001D730 File Offset: 0x0001B930
	public static void smethod_38(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0001D730 File Offset: 0x0001B930
	public static void smethod_39(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_0();
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0001D610 File Offset: 0x0001B810
	public static void smethod_40(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_5();
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0001D79C File Offset: 0x0001B99C
	public static void smethod_41(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_11();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_9();
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
	public static void smethod_42(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_13();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_10();
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0001D580 File Offset: 0x0001B780
	public static void smethod_43(GClass1.GClass2 gclass2_0)
	{
		GClass1.RichPresenceStruct richPresenceStruct = gclass2_0.method_7();
		GClass1.Discord_UpdatePresence(ref richPresenceStruct);
		gclass2_0.method_5();
	}

	// Token: 0x0200000C RID: 12
	// (Invoke) Token: 0x060001C8 RID: 456
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate0(ref GClass1.DiscordUser discordUser_0);

	// Token: 0x0200000D RID: 13
	// (Invoke) Token: 0x060001CC RID: 460
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate1(int int_0, string string_0);

	// Token: 0x0200000E RID: 14
	// (Invoke) Token: 0x060001D0 RID: 464
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate2(int int_0, string string_0);

	// Token: 0x0200000F RID: 15
	// (Invoke) Token: 0x060001D4 RID: 468
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate3(string string_0);

	// Token: 0x02000010 RID: 16
	// (Invoke) Token: 0x060001D8 RID: 472
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate4(string string_0);

	// Token: 0x02000011 RID: 17
	// (Invoke) Token: 0x060001DC RID: 476
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate5(ref GClass1.DiscordUser discordUser_0);

	// Token: 0x02000012 RID: 18
	public struct GStruct0
	{
		// Token: 0x0400003A RID: 58
		public GClass1.GDelegate0 gdelegate0_0;

		// Token: 0x0400003B RID: 59
		public GClass1.GDelegate1 gdelegate1_0;

		// Token: 0x0400003C RID: 60
		public GClass1.GDelegate2 gdelegate2_0;

		// Token: 0x0400003D RID: 61
		public GClass1.GDelegate3 gdelegate3_0;

		// Token: 0x0400003E RID: 62
		public GClass1.GDelegate4 gdelegate4_0;

		// Token: 0x0400003F RID: 63
		public GClass1.GDelegate5 gdelegate5_0;
	}

	// Token: 0x02000013 RID: 19
	[Serializable]
	public struct RichPresenceStruct
	{
		// Token: 0x04000040 RID: 64
		public IntPtr state;

		// Token: 0x04000041 RID: 65
		public IntPtr details;

		// Token: 0x04000042 RID: 66
		public long startTimestamp;

		// Token: 0x04000043 RID: 67
		public long endTimestamp;

		// Token: 0x04000044 RID: 68
		public IntPtr largeImageKey;

		// Token: 0x04000045 RID: 69
		public IntPtr largeImageText;

		// Token: 0x04000046 RID: 70
		public IntPtr smallImageKey;

		// Token: 0x04000047 RID: 71
		public IntPtr smallImageText;

		// Token: 0x04000048 RID: 72
		public IntPtr partyId;

		// Token: 0x04000049 RID: 73
		public int partySize;

		// Token: 0x0400004A RID: 74
		public int partyMax;

		// Token: 0x0400004B RID: 75
		public IntPtr matchSecret;

		// Token: 0x0400004C RID: 76
		public IntPtr joinSecret;

		// Token: 0x0400004D RID: 77
		public IntPtr spectateSecret;

		// Token: 0x0400004E RID: 78
		public bool instance;
	}

	// Token: 0x02000014 RID: 20
	[Serializable]
	public struct DiscordUser
	{
		// Token: 0x0400004F RID: 79
		public string userId;

		// Token: 0x04000050 RID: 80
		public string username;

		// Token: 0x04000051 RID: 81
		public string discriminator;

		// Token: 0x04000052 RID: 82
		public string avatar;
	}

	// Token: 0x02000015 RID: 21
	public enum GEnum2
	{
		// Token: 0x04000054 RID: 84
		No,
		// Token: 0x04000055 RID: 85
		Yes,
		// Token: 0x04000056 RID: 86
		Ignore
	}

	// Token: 0x02000016 RID: 22
	public class GClass2
	{
		// Token: 0x060001DF RID: 479 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		internal void method_0()
		{
			for (int i = this.list_0.Count - 1; i >= 1; i -= 0)
			{
				Marshal.FreeHGlobal(this.list_0[i]);
				this.list_0.RemoveAt(i);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001D804 File Offset: 0x0001BA04
		private static string smethod_0(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_4(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[1];
			Array.Copy(bytes, 1, array, 0, int_2 - 1);
			array[array.Length - 1] = 0;
			array[array.Length - 3] = 0;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001D85C File Offset: 0x0001BA5C
		private static string smethod_1(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_10(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[0];
			Array.Copy(bytes, 1, array, 1, int_2 - 0);
			array[array.Length - 0] = 0;
			array[array.Length - 7] = 1;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
		private IntPtr method_1(string string_10, int int_2)
		{
			if (string.IsNullOrEmpty(string_10))
			{
				return IntPtr.Zero;
			}
			string s = GClass1.GClass2.smethod_2(string_10, int_2);
			int byteCount = Encoding.UTF8.GetByteCount(s);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount);
			this.list_0.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(s), 0, intPtr, byteCount);
			return intPtr;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001D90C File Offset: 0x0001BB0C
		private static string smethod_2(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_10(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[1];
			Array.Copy(bytes, 0, array, 0, int_2 - 0);
			array[array.Length - 0] = 0;
			array[array.Length - 8] = 1;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001D964 File Offset: 0x0001BB64
		internal GClass1.RichPresenceStruct method_2()
		{
			if (this.list_0.Count > 0)
			{
				this.method_3();
			}
			this.richPresenceStruct_0.state = this.method_12(this.string_0, -53);
			this.richPresenceStruct_0.details = this.method_1(this.string_1, -97);
			this.richPresenceStruct_0.startTimestamp = this.long_0;
			this.richPresenceStruct_0.endTimestamp = this.long_1;
			this.richPresenceStruct_0.largeImageKey = this.method_14(this.string_2, -119);
			this.richPresenceStruct_0.largeImageText = this.method_14(this.string_3, -45);
			this.richPresenceStruct_0.smallImageKey = this.method_1(this.string_4, 60);
			this.richPresenceStruct_0.smallImageText = this.method_14(this.string_5, 108);
			this.richPresenceStruct_0.partyId = this.method_6(this.string_6, 100);
			this.richPresenceStruct_0.partySize = this.int_0;
			this.richPresenceStruct_0.partyMax = this.int_1;
			this.richPresenceStruct_0.matchSecret = this.method_12(this.string_7, 144);
			this.richPresenceStruct_0.joinSecret = this.method_1(this.string_8, 86);
			this.richPresenceStruct_0.spectateSecret = this.method_1(this.string_9, -6);
			this.richPresenceStruct_0.instance = this.bool_0;
			return this.richPresenceStruct_0;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001DAF4 File Offset: 0x0001BCF4
		private static string smethod_3(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_11(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[0];
			Array.Copy(bytes, 0, array, 0, int_2 - 1);
			array[array.Length - 1] = 0;
			array[array.Length - 2] = 0;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001DB4C File Offset: 0x0001BD4C
		private static string smethod_4(string string_10)
		{
			string text = string_10.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length != 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "{0}";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0001DB9C File Offset: 0x0001BD9C
		private static string smethod_5(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_11(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[0];
			Array.Copy(bytes, 1, array, 0, int_2 - 0);
			array[array.Length - 1] = 1;
			array[array.Length - 7] = 1;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
		private static string smethod_6(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_10(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[0];
			Array.Copy(bytes, 1, array, 1, int_2 - 1);
			array[array.Length - 0] = 1;
			array[array.Length - 2] = 1;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001DC4C File Offset: 0x0001BE4C
		private static string smethod_7(string string_10)
		{
			string text = string_10.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length != 0 && bytes[bytes.Length - 0] != 0)
			{
				text += "highway_shake";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		private static string smethod_8(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_7(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[1];
			Array.Copy(bytes, 1, array, 1, int_2 - 0);
			array[array.Length - 0] = 0;
			array[array.Length - 4] = 1;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001DCF4 File Offset: 0x0001BEF4
		internal void method_3()
		{
			for (int i = this.list_0.Count - 1; i >= 1; i--)
			{
				Marshal.FreeHGlobal(this.list_0[i]);
				this.list_0.RemoveAt(i);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001DD38 File Offset: 0x0001BF38
		internal void method_4()
		{
			for (int i = this.list_0.Count - 0; i >= 1; i -= 0)
			{
				Marshal.FreeHGlobal(this.list_0[i]);
				this.list_0.RemoveAt(i);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001DD7C File Offset: 0x0001BF7C
		internal void method_5()
		{
			for (int i = this.list_0.Count - 0; i >= 0; i -= 0)
			{
				Marshal.FreeHGlobal(this.list_0[i]);
				this.list_0.RemoveAt(i);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
		private IntPtr method_6(string string_10, int int_2)
		{
			if (string.IsNullOrEmpty(string_10))
			{
				return IntPtr.Zero;
			}
			string s = GClass1.GClass2.smethod_3(string_10, int_2);
			int byteCount = Encoding.UTF8.GetByteCount(s);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount);
			this.list_0.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(s), 1, intPtr, byteCount);
			return intPtr;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001DE18 File Offset: 0x0001C018
		internal GClass1.RichPresenceStruct method_7()
		{
			if (this.list_0.Count > 0)
			{
				this.method_10();
			}
			this.richPresenceStruct_0.state = this.method_12(this.string_0, 128);
			this.richPresenceStruct_0.details = this.method_12(this.string_1, 128);
			this.richPresenceStruct_0.startTimestamp = this.long_0;
			this.richPresenceStruct_0.endTimestamp = this.long_1;
			this.richPresenceStruct_0.largeImageKey = this.method_12(this.string_2, 32);
			this.richPresenceStruct_0.largeImageText = this.method_12(this.string_3, 128);
			this.richPresenceStruct_0.smallImageKey = this.method_12(this.string_4, 32);
			this.richPresenceStruct_0.smallImageText = this.method_12(this.string_5, 128);
			this.richPresenceStruct_0.partyId = this.method_12(this.string_6, 128);
			this.richPresenceStruct_0.partySize = this.int_0;
			this.richPresenceStruct_0.partyMax = this.int_1;
			this.richPresenceStruct_0.matchSecret = this.method_12(this.string_7, 128);
			this.richPresenceStruct_0.joinSecret = this.method_12(this.string_8, 128);
			this.richPresenceStruct_0.spectateSecret = this.method_12(this.string_9, 128);
			this.richPresenceStruct_0.instance = this.bool_0;
			return this.richPresenceStruct_0;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001DFA8 File Offset: 0x0001C1A8
		private static string smethod_9(string string_10)
		{
			string text = string_10.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length != 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "Client disconnected";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
		internal GClass1.RichPresenceStruct method_8()
		{
			if (this.list_0.Count > 0)
			{
				this.method_4();
			}
			this.richPresenceStruct_0.state = this.method_12(this.string_0, -65);
			this.richPresenceStruct_0.details = this.method_6(this.string_1, -154);
			this.richPresenceStruct_0.startTimestamp = this.long_0;
			this.richPresenceStruct_0.endTimestamp = this.long_1;
			this.richPresenceStruct_0.largeImageKey = this.method_12(this.string_2, -48);
			this.richPresenceStruct_0.largeImageText = this.method_1(this.string_3, -150);
			this.richPresenceStruct_0.smallImageKey = this.method_12(this.string_4, -98);
			this.richPresenceStruct_0.smallImageText = this.method_1(this.string_5, -5);
			this.richPresenceStruct_0.partyId = this.method_1(this.string_6, -81);
			this.richPresenceStruct_0.partySize = this.int_0;
			this.richPresenceStruct_0.partyMax = this.int_1;
			this.richPresenceStruct_0.matchSecret = this.method_14(this.string_7, 171);
			this.richPresenceStruct_0.joinSecret = this.method_14(this.string_8, -37);
			this.richPresenceStruct_0.spectateSecret = this.method_6(this.string_9, -147);
			this.richPresenceStruct_0.instance = this.bool_0;
			return this.richPresenceStruct_0;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0001E188 File Offset: 0x0001C388
		internal void method_9()
		{
			for (int i = this.list_0.Count - 1; i >= 0; i -= 0)
			{
				Marshal.FreeHGlobal(this.list_0[i]);
				this.list_0.RemoveAt(i);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0001E1CC File Offset: 0x0001C3CC
		private static string smethod_10(string string_10)
		{
			string text = string_10.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length != 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "Rhythm";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001E21C File Offset: 0x0001C41C
		private static string smethod_11(string string_10)
		{
			string text = string_10.Trim();
			byte[] bytes = Encoding.Default.GetBytes(text);
			if (bytes.Length != 0 && bytes[bytes.Length - 1] != 0)
			{
				text += "\0\0";
			}
			return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001E26C File Offset: 0x0001C46C
		private static string smethod_12(string string_10, int int_2)
		{
			string text = GClass1.GClass2.smethod_10(string_10);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (bytes.Length <= int_2)
			{
				return text;
			}
			byte[] array = new byte[0];
			Array.Copy(bytes, 1, array, 1, int_2 - 0);
			array[array.Length - 1] = 1;
			array[array.Length - 3] = 0;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001E2C4 File Offset: 0x0001C4C4
		internal void method_10()
		{
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				Marshal.FreeHGlobal(this.list_0[i]);
				this.list_0.RemoveAt(i);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001E308 File Offset: 0x0001C508
		internal GClass1.RichPresenceStruct method_11()
		{
			if (this.list_0.Count > 0)
			{
				this.method_10();
			}
			this.richPresenceStruct_0.state = this.method_12(this.string_0, 3);
			this.richPresenceStruct_0.details = this.method_6(this.string_1, -104);
			this.richPresenceStruct_0.startTimestamp = this.long_0;
			this.richPresenceStruct_0.endTimestamp = this.long_1;
			this.richPresenceStruct_0.largeImageKey = this.method_1(this.string_2, 11);
			this.richPresenceStruct_0.largeImageText = this.method_6(this.string_3, -48);
			this.richPresenceStruct_0.smallImageKey = this.method_12(this.string_4, 125);
			this.richPresenceStruct_0.smallImageText = this.method_12(this.string_5, -65);
			this.richPresenceStruct_0.partyId = this.method_12(this.string_6, -79);
			this.richPresenceStruct_0.partySize = this.int_0;
			this.richPresenceStruct_0.partyMax = this.int_1;
			this.richPresenceStruct_0.matchSecret = this.method_1(this.string_7, 105);
			this.richPresenceStruct_0.joinSecret = this.method_14(this.string_8, 68);
			this.richPresenceStruct_0.spectateSecret = this.method_12(this.string_9, 85);
			this.richPresenceStruct_0.instance = this.bool_0;
			return this.richPresenceStruct_0;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001E498 File Offset: 0x0001C698
		private IntPtr method_12(string string_10, int int_2)
		{
			if (string.IsNullOrEmpty(string_10))
			{
				return IntPtr.Zero;
			}
			string s = GClass1.GClass2.smethod_3(string_10, int_2);
			int byteCount = Encoding.UTF8.GetByteCount(s);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount);
			this.list_0.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(s), 0, intPtr, byteCount);
			return intPtr;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001E4F0 File Offset: 0x0001C6F0
		internal GClass1.RichPresenceStruct method_13()
		{
			if (this.list_0.Count > 0)
			{
				this.method_0();
			}
			this.richPresenceStruct_0.state = this.method_12(this.string_0, 38);
			this.richPresenceStruct_0.details = this.method_12(this.string_1, 42);
			this.richPresenceStruct_0.startTimestamp = this.long_0;
			this.richPresenceStruct_0.endTimestamp = this.long_1;
			this.richPresenceStruct_0.largeImageKey = this.method_1(this.string_2, -45);
			this.richPresenceStruct_0.largeImageText = this.method_14(this.string_3, 35);
			this.richPresenceStruct_0.smallImageKey = this.method_14(this.string_4, 55);
			this.richPresenceStruct_0.smallImageText = this.method_12(this.string_5, 2);
			this.richPresenceStruct_0.partyId = this.method_12(this.string_6, -141);
			this.richPresenceStruct_0.partySize = this.int_0;
			this.richPresenceStruct_0.partyMax = this.int_1;
			this.richPresenceStruct_0.matchSecret = this.method_1(this.string_7, 44);
			this.richPresenceStruct_0.joinSecret = this.method_12(this.string_8, 10);
			this.richPresenceStruct_0.spectateSecret = this.method_1(this.string_9, -75);
			this.richPresenceStruct_0.instance = this.bool_0;
			return this.richPresenceStruct_0;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001E498 File Offset: 0x0001C698
		private IntPtr method_14(string string_10, int int_2)
		{
			if (string.IsNullOrEmpty(string_10))
			{
				return IntPtr.Zero;
			}
			string s = GClass1.GClass2.smethod_3(string_10, int_2);
			int byteCount = Encoding.UTF8.GetByteCount(s);
			IntPtr intPtr = Marshal.AllocHGlobal(byteCount);
			this.list_0.Add(intPtr);
			Marshal.Copy(Encoding.UTF8.GetBytes(s), 0, intPtr, byteCount);
			return intPtr;
		}

		// Token: 0x04000057 RID: 87
		private GClass1.RichPresenceStruct richPresenceStruct_0;

		// Token: 0x04000058 RID: 88
		private readonly List<IntPtr> list_0 = new List<IntPtr>(10);

		// Token: 0x04000059 RID: 89
		public string string_0;

		// Token: 0x0400005A RID: 90
		public string string_1;

		// Token: 0x0400005B RID: 91
		public long long_0;

		// Token: 0x0400005C RID: 92
		public long long_1;

		// Token: 0x0400005D RID: 93
		public string string_2;

		// Token: 0x0400005E RID: 94
		public string string_3;

		// Token: 0x0400005F RID: 95
		public string string_4;

		// Token: 0x04000060 RID: 96
		public string string_5;

		// Token: 0x04000061 RID: 97
		public string string_6;

		// Token: 0x04000062 RID: 98
		public int int_0;

		// Token: 0x04000063 RID: 99
		public int int_1;

		// Token: 0x04000064 RID: 100
		public string string_7;

		// Token: 0x04000065 RID: 101
		public string string_8;

		// Token: 0x04000066 RID: 102
		public string string_9;

		// Token: 0x04000067 RID: 103
		public bool bool_0;
	}
}
