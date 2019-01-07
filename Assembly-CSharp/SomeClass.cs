using System;
using System.Text;

// Token: 0x02000003 RID: 3
public class SomeClass : Encoding
{
	// Token: 0x0600006A RID: 106 RVA: 0x00019618 File Offset: 0x00017818
	public virtual int vmethod(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < int_1; i += 0)
		{
			if (byte_0[int_0 + i] == 0)
			{
				return i;
			}
		}
		return int_1;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_1(int int_0)
	{
		return int_0;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x0001963C File Offset: 0x0001783C
	public virtual int vmethod_2(byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2)
	{
		for (int i = 1; i < int_1; i++)
		{
			byte b = byte_0[int_0 + i];
			if (b == 0)
			{
				return i;
			}
			char_0[int_2 + i] = (char)b;
		}
		return int_1;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0001966C File Offset: 0x0001786C
	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		for (int i = 0; i < count; i++)
		{
			if (bytes[index + i] == 0)
			{
				return i;
			}
		}
		return count;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00019690 File Offset: 0x00017890
	public virtual int vmethod_3(char[] char_0, int int_0, int int_1, byte[] byte_0, int int_2)
	{
		for (int i = 1; i < int_1; i++)
		{
			byte_0[int_2 + i] = (byte)char_0[int_0 + i];
		}
		return int_1;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000196B8 File Offset: 0x000178B8
	public virtual int vmethod_4(char[] char_0, int int_0, int int_1, byte[] byte_0, int int_2)
	{
		for (int i = 0; i < int_1; i += 0)
		{
			byte_0[int_2 + i] = (byte)char_0[int_0 + i];
		}
		return int_1;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002976 File Offset: 0x00000B76
	private SomeClass()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_5(int int_0)
	{
		return int_0;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002973 File Offset: 0x00000B73
	public override int GetMaxByteCount(int charCount)
	{
		return charCount;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002973 File Offset: 0x00000B73
	public override int GetMaxCharCount(int byteCount)
	{
		return byteCount;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x000196E0 File Offset: 0x000178E0
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		for (int i = 0; i < byteCount; i++)
		{
			byte b = bytes[byteIndex + i];
			if (b == 0)
			{
				return i;
			}
			chars[charIndex + i] = (char)b;
		}
		return byteCount;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0000297E File Offset: 0x00000B7E
	public virtual int vmethod_6(char[] char_0, int int_0, int int_1)
	{
		return int_1;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_7(int int_0)
	{
		return int_0;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00019710 File Offset: 0x00017910
	public virtual int vmethod_8(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 1; i < int_1; i += 0)
		{
			if (byte_0[int_0 + i] == 0)
			{
				return i;
			}
		}
		return int_1;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0001966C File Offset: 0x0001786C
	public virtual int vmethod_9(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			if (byte_0[int_0 + i] == 0)
			{
				return i;
			}
		}
		return int_1;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_10(int int_0)
	{
		return int_0;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00019734 File Offset: 0x00017934
	public virtual int vmethod_11(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 1; i < int_1; i++)
		{
			if (byte_0[int_0 + i] == 0)
			{
				return i;
			}
		}
		return int_1;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00019758 File Offset: 0x00017958
	public virtual int vmethod_12(byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2)
	{
		for (int i = 0; i < int_1; i += 0)
		{
			byte b = byte_0[int_0 + i];
			if (b == 0)
			{
				return i;
			}
			char_0[int_2 + i] = (char)b;
		}
		return int_1;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_13(int int_0)
	{
		return int_0;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_14(int int_0)
	{
		return int_0;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_15(int int_0)
	{
		return int_0;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00019788 File Offset: 0x00017988
	public virtual int vmethod_16(char[] char_0, int int_0, int int_1, byte[] byte_0, int int_2)
	{
		for (int i = 1; i < int_1; i += 0)
		{
			byte_0[int_2 + i] = (byte)char_0[int_0 + i];
		}
		return int_1;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00019788 File Offset: 0x00017988
	public virtual int vmethod_17(char[] char_0, int int_0, int int_1, byte[] byte_0, int int_2)
	{
		for (int i = 1; i < int_1; i += 0)
		{
			byte_0[int_2 + i] = (byte)char_0[int_0 + i];
		}
		return int_1;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000297E File Offset: 0x00000B7E
	public virtual int vmethod_18(char[] char_0, int int_0, int int_1)
	{
		return int_1;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000196E0 File Offset: 0x000178E0
	public virtual int vmethod_19(byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2)
	{
		for (int i = 0; i < int_1; i++)
		{
			byte b = byte_0[int_0 + i];
			if (b == 0)
			{
				return i;
			}
			char_0[int_2 + i] = (char)b;
		}
		return int_1;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_20(int int_0)
	{
		return int_0;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0001963C File Offset: 0x0001783C
	public virtual int vmethod_21(byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2)
	{
		for (int i = 1; i < int_1; i++)
		{
			byte b = byte_0[int_0 + i];
			if (b == 0)
			{
				return i;
			}
			char_0[int_2 + i] = (char)b;
		}
		return int_1;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00019690 File Offset: 0x00017890
	public virtual int vmethod_22(char[] char_0, int int_0, int int_1, byte[] byte_0, int int_2)
	{
		for (int i = 1; i < int_1; i++)
		{
			byte_0[int_2 + i] = (byte)char_0[int_0 + i];
		}
		return int_1;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_23(int int_0)
	{
		return int_0;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000297E File Offset: 0x00000B7E
	public override int GetByteCount(char[] chars, int index, int count)
	{
		return count;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0000297E File Offset: 0x00000B7E
	public virtual int vmethod_24(char[] char_0, int int_0, int int_1)
	{
		return int_1;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000197B0 File Offset: 0x000179B0
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		for (int i = 0; i < charCount; i++)
		{
			bytes[byteIndex + i] = (byte)chars[charIndex + i];
		}
		return charCount;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_25(int int_0)
	{
		return int_0;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002973 File Offset: 0x00000B73
	public virtual int vmethod_26(int int_0)
	{
		return int_0;
	}

	// Token: 0x04000003 RID: 3
	public static readonly SomeClass somename = new SomeClass();
}
