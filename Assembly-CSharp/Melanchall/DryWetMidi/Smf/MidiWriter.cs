using System;
using System.IO;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001BC RID: 444
	public sealed class MidiWriter : IDisposable
	{
		// Token: 0x06003429 RID: 13353 RVA: 0x00017E3F File Offset: 0x0001603F
		public MidiWriter(Stream stream)
		{
			this._binaryWriter = new BinaryWriter(stream, SmfUtilities.DefaultEncoding);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00017E58 File Offset: 0x00016058
		public void Flush()
		{
			this._binaryWriter.Flush();
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00017E65 File Offset: 0x00016065
		public void WriteByte(byte value)
		{
			this._binaryWriter.Write(value);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00017E73 File Offset: 0x00016073
		public void WriteBytes(byte[] bytes)
		{
			this._binaryWriter.Write(bytes);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00017E81 File Offset: 0x00016081
		public void WriteSByte(sbyte value)
		{
			this._binaryWriter.Write(value);
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00148F9C File Offset: 0x0014719C
		public void WriteWord(ushort value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			this.WriteBytes(bytes);
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00148FC4 File Offset: 0x001471C4
		public void WriteDword(uint value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			this.WriteBytes(bytes);
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00148FEC File Offset: 0x001471EC
		public void WriteInt16(short value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			this.WriteBytes(bytes);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00149014 File Offset: 0x00147214
		public void WriteString(string value)
		{
			char[] array = (value != null) ? value.ToCharArray() : null;
			if (array != null && array.Length != 0)
			{
				this._binaryWriter.Write(array);
			}
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00017E8F File Offset: 0x0001608F
		public void WriteVlqNumber(int value)
		{
			this.WriteVlqNumber((long)value);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00149044 File Offset: 0x00147244
		public void WriteVlqNumber(long value)
		{
			byte[] vlqBytes = value.GetVlqBytes();
			this.WriteBytes(vlqBytes);
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00149060 File Offset: 0x00147260
		public void Write3ByteDword(uint value)
		{
			byte[] array = new byte[3];
			int num = array.Length;
			while (--num >= 0)
			{
				array[num] = (byte)(value & 255u);
				value >>= 8;
			}
			this.WriteBytes(array);
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00017E99 File Offset: 0x00016099
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00017EA2 File Offset: 0x000160A2
		private void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			if (disposing)
			{
				this._binaryWriter.Dispose();
			}
			this._disposed = true;
		}

		// Token: 0x04000BCB RID: 3019
		private readonly BinaryWriter _binaryWriter;

		// Token: 0x04000BCC RID: 3020
		private bool _disposed;
	}
}
