using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001D0 RID: 464
	public static class DataTypesUtilities
	{
		// Token: 0x06003471 RID: 13425 RVA: 0x000181A0 File Offset: 0x000163A0
		public static byte Combine(FourBitNumber head, FourBitNumber tail)
		{
			return (byte)((int)head << 4 | (int)tail);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000181B2 File Offset: 0x000163B2
		public static ushort Combine(SevenBitNumber head, SevenBitNumber tail)
		{
			return (ushort)((int)head << 7 | (int)tail);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000181C4 File Offset: 0x000163C4
		public static short Combine(byte head, byte tail)
		{
			return (short)((int)head << 8 | (int)tail);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x000181CC File Offset: 0x000163CC
		public static FourBitNumber GetTail(this byte number)
		{
			return (FourBitNumber)(number & FourBitNumber.MaxValue);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000181E0 File Offset: 0x000163E0
		public static SevenBitNumber GetTail(this ushort number)
		{
			return (SevenBitNumber)((byte)(number & (ushort)SevenBitNumber.MaxValue));
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000181F4 File Offset: 0x000163F4
		public static byte GetTail(this short number)
		{
			return (byte)(number & 255);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000181FE File Offset: 0x000163FE
		public static FourBitNumber GetHead(this byte number)
		{
			return (FourBitNumber)((byte)(number >> 4));
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00018209 File Offset: 0x00016409
		public static SevenBitNumber GetHead(this ushort number)
		{
			return (SevenBitNumber)((byte)(number >> 7));
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00018214 File Offset: 0x00016414
		public static byte GetHead(this short number)
		{
			return (byte)(number >> 8);
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x001490E8 File Offset: 0x001472E8
		public static int GetVlqLength(this int number)
		{
			int num = 1073741824;
			int num2 = 31;
			while ((number & num) == 0 && num > 0)
			{
				num >>= 1;
				num2--;
			}
			return Math.Max(num2 / 7 + ((num2 % 7 > 0) ? 1 : 0), 1);
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00149128 File Offset: 0x00147328
		public static int GetVlqLength(this long number)
		{
			long num = 4611686018427387904L;
			int num2 = 63;
			while ((number & num) == 0L && num > 0L)
			{
				num >>= 1;
				num2--;
			}
			return Math.Max(num2 / 7 + ((num2 % 7 > 0) ? 1 : 0), 1);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x0001821A File Offset: 0x0001641A
		public static byte[] GetVlqBytes(this int number)
		{
			return ((long)number).GetVlqBytes();
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00149174 File Offset: 0x00147374
		public static byte[] GetVlqBytes(this long number)
		{
			byte[] array = new byte[number.GetVlqLength()];
			int num = array.Length - 1;
			array[num--] = (byte)(number & 127L);
			while ((number >>= 7) > 0L)
			{
				byte[] array2 = array;
				int num2 = num;
				array2[num2] |= 128;
				byte[] array3 = array;
				int num3 = num--;
				array3[num3] += (byte)(number & 127L);
			}
			return array;
		}
	}
}
