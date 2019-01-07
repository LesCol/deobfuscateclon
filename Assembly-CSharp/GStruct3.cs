using System;
using System.IO;

// Token: 0x020000A6 RID: 166
public struct GStruct3
{
	// Token: 0x06001F84 RID: 8068 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_0(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x00100D3C File Offset: 0x000FEF3C
	public void method_0(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 1L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_1(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_2(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x00100ED4 File Offset: 0x000FF0D4
	public void method_1(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 8L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x00100F70 File Offset: 0x000FF170
	public static GStruct3 smethod_3(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (!gstruct3_0.bool_0 && gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x0010106C File Offset: 0x000FF26C
	public void method_2(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 0L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_4(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_5(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x00101108 File Offset: 0x000FF308
	public void method_3(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 1L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x001011A4 File Offset: 0x000FF3A4
	public void method_4(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 8L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x0010106C File Offset: 0x000FF26C
	public void method_5(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 0L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_6(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x00100F70 File Offset: 0x000FF170
	public static GStruct3 smethod_7(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (!gstruct3_0.bool_0 && gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x00100F70 File Offset: 0x000FF170
	public static GStruct3 smethod_8(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (!gstruct3_0.bool_0 && gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_9(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x0000E04D File Offset: 0x0000C24D
	public GStruct3(GStruct2.GEnum11 genum11_1, GStruct2.GEnum12 genum12_1, byte byte_3, bool bool_1, byte byte_4, byte byte_5, int int_1, short short_1)
	{
		this.genum11_0 = genum11_1;
		this.genum12_0 = genum12_1;
		this.byte_2 = byte_3;
		this.bool_0 = bool_1;
		this.byte_0 = byte_4;
		this.byte_1 = byte_5;
		this.int_0 = int_1;
		this.short_0 = short_1;
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x00101240 File Offset: 0x000FF440
	public void method_6(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 3L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x001012DC File Offset: 0x000FF4DC
	public void method_7(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 1L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x0010106C File Offset: 0x000FF26C
	public void method_8(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 0L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_10(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_11(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_12(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_13(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x001011A4 File Offset: 0x000FF3A4
	public void method_9(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 8L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x00100F70 File Offset: 0x000FF170
	public static GStruct3 smethod_14(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (!gstruct3_0.bool_0 && gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x00101378 File Offset: 0x000FF578
	public void method_10(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 4L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x00100F70 File Offset: 0x000FF170
	public static GStruct3 smethod_15(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (!gstruct3_0.bool_0 && gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x00101414 File Offset: 0x000FF614
	public void method_11(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 5L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x001014B0 File Offset: 0x000FF6B0
	public void method_12(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 4L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x0010154C File Offset: 0x000FF74C
	public void method_13(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 0L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_16(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x00100F70 File Offset: 0x000FF170
	public static GStruct3 smethod_17(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (!gstruct3_0.bool_0 && gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_18(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_19(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_20(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x001015E8 File Offset: 0x000FF7E8
	public void method_14(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 2L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_21(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x00101684 File Offset: 0x000FF884
	public void method_15(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 3L;
			binaryWriter_0.Write(true);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(!bool_2 && this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_22(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_23(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x00100F70 File Offset: 0x000FF170
	public static GStruct3 smethod_24(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (!gstruct3_0.bool_0 && gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_25(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_26(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_27(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_28(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_29(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	public static GStruct3 smethod_30(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		if (gstruct3_0.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_1;
		}
		if (gstruct3_1.genum11_0 == GStruct2.GEnum11.None)
		{
			return gstruct3_0;
		}
		GStruct3 result;
		result.genum11_0 = gstruct3_0.genum11_0;
		result.byte_2 = Math.Max(gstruct3_0.byte_2, gstruct3_1.byte_2);
		result.bool_0 = (gstruct3_0.bool_0 || gstruct3_1.bool_0);
		result.byte_0 = Math.Max(gstruct3_0.byte_0, gstruct3_1.byte_0);
		result.int_0 = Math.Max(gstruct3_0.int_0, gstruct3_1.int_0);
		result.genum12_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.genum12_0 : gstruct3_1.genum12_0);
		result.byte_1 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.byte_1 : gstruct3_1.byte_1);
		result.short_0 = ((gstruct3_0.int_0 > gstruct3_1.int_0) ? gstruct3_0.short_0 : gstruct3_1.short_0);
		return result;
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x00101720 File Offset: 0x000FF920
	public void method_16(BinaryWriter binaryWriter_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			binaryWriter_0.BaseStream.Position += 5L;
			binaryWriter_0.Write(false);
			return;
		}
		binaryWriter_0.Write((short)this.genum11_0);
		binaryWriter_0.Write((byte)this.genum12_0);
		binaryWriter_0.Write(this.byte_2);
		binaryWriter_0.Write(bool_2 || this.bool_0);
		binaryWriter_0.Write(this.short_0);
		binaryWriter_0.Write(this.byte_0);
		binaryWriter_0.Write(this.byte_1);
		binaryWriter_0.Write(this.int_0);
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x00100CC4 File Offset: 0x000FEEC4
	public static GStruct3 smethod_31(BinaryReader binaryReader_0)
	{
		GStruct3 result;
		result.genum11_0 = (GStruct2.GEnum11)binaryReader_0.ReadInt16();
		result.genum12_0 = (GStruct2.GEnum12)binaryReader_0.ReadByte();
		result.byte_2 = binaryReader_0.ReadByte();
		result.bool_0 = binaryReader_0.ReadBoolean();
		result.short_0 = binaryReader_0.ReadInt16();
		result.byte_0 = binaryReader_0.ReadByte();
		result.byte_1 = binaryReader_0.ReadByte();
		result.int_0 = binaryReader_0.ReadInt32();
		return result;
	}

	// Token: 0x04000503 RID: 1283
	public GStruct2.GEnum11 genum11_0;

	// Token: 0x04000504 RID: 1284
	public GStruct2.GEnum12 genum12_0;

	// Token: 0x04000505 RID: 1285
	public int int_0;

	// Token: 0x04000506 RID: 1286
	public bool bool_0;

	// Token: 0x04000507 RID: 1287
	public short short_0;

	// Token: 0x04000508 RID: 1288
	public byte byte_0;

	// Token: 0x04000509 RID: 1289
	public byte byte_1;

	// Token: 0x0400050A RID: 1290
	public byte byte_2;
}
