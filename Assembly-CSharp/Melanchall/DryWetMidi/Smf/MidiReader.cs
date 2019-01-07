using System;
using System.IO;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001BB RID: 443
	public sealed class MidiReader : IDisposable
	{
		// Token: 0x06003418 RID: 13336 RVA: 0x00017D1C File Offset: 0x00015F1C
		public MidiReader(Stream stream)
		{
			this._binaryReader = new BinaryReader(stream, SmfUtilities.DefaultEncoding);
			this.streamLength = this._binaryReader.BaseStream.Length;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x00017D4B File Offset: 0x00015F4B
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x00017D53 File Offset: 0x00015F53
		public long Position
		{
			get
			{
				return this.streamPos;
			}
			set
			{
				this._binaryReader.BaseStream.Position = value;
				this.streamPos = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x00017D6D File Offset: 0x00015F6D
		public long Length
		{
			get
			{
				return this.streamLength;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600341C RID: 13340 RVA: 0x00017D75 File Offset: 0x00015F75
		public bool EndReached
		{
			get
			{
				return this.Position >= this.Length;
			}
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00017D88 File Offset: 0x00015F88
		public byte ReadByte()
		{
			this.streamPos += 1L;
			return this._binaryReader.ReadByte();
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00017DAB File Offset: 0x00015FAB
		public sbyte ReadSByte()
		{
			this.streamPos += 1L;
			return this._binaryReader.ReadSByte();
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00017DCE File Offset: 0x00015FCE
		public byte[] ReadBytes(int count)
		{
			this.streamPos += (long)count;
			return this._binaryReader.ReadBytes(count);
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00148E14 File Offset: 0x00147014
		public ushort ReadWord()
		{
			byte[] array = this.ReadBytes(2);
			if (array.Length < 2)
			{
				throw new NotEnoughBytesException("Not enough bytes in the stream to read a WORD.", 2L, (long)array.Length);
			}
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToUInt16(array, 0);
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00148E5C File Offset: 0x0014705C
		public uint ReadDword()
		{
			byte[] array = this.ReadBytes(4);
			if (array.Length < 4)
			{
				throw new NotEnoughBytesException("Not enough bytes in the stream to read a DWORD.", 4L, (long)array.Length);
			}
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00148EA4 File Offset: 0x001470A4
		public short ReadInt16()
		{
			byte[] array = this.ReadBytes(2);
			if (array.Length < 2)
			{
				throw new NotEnoughBytesException("Not enough bytes in the stream to read a INT16.", 2L, (long)array.Length);
			}
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToInt16(array, 0);
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00017DEB File Offset: 0x00015FEB
		public string ReadString(int count)
		{
			char[] value = this._binaryReader.ReadChars(count);
			this.streamPos += (long)count;
			return new string(value);
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00017E0D File Offset: 0x0001600D
		public int ReadVlqNumber()
		{
			return (int)this.ReadVlqLongNumber();
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00148EEC File Offset: 0x001470EC
		public long ReadVlqLongNumber()
		{
			long num = 0L;
			try
			{
				byte b;
				do
				{
					b = this.ReadByte();
					num = (num << 7) + (long)(b & 127);
				}
				while (b >> 7 != 0);
			}
			catch (EndOfStreamException innerException)
			{
				throw new NotEnoughBytesException("Not enough bytes in the stream to read a variable-length quantity number.", innerException);
			}
			return num;
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00148F3C File Offset: 0x0014713C
		public uint Read3ByteDword()
		{
			byte[] array = this.ReadBytes(3);
			if (array.Length < 3)
			{
				throw new NotEnoughBytesException("Not enough bytes in the stream to read a 3-byte DWORD.", 3L, (long)array.Length);
			}
			byte[] array2 = new byte[4];
			Array.Copy(array, 0, array2, array2.Length - array.Length, array.Length);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array2);
			}
			return BitConverter.ToUInt32(array2, 0);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00017E16 File Offset: 0x00016016
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00017E1F File Offset: 0x0001601F
		private void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			if (disposing)
			{
				this._binaryReader.Dispose();
			}
			this._disposed = true;
		}

		// Token: 0x04000BC7 RID: 3015
		private readonly BinaryReader _binaryReader;

		// Token: 0x04000BC8 RID: 3016
		private bool _disposed;

		// Token: 0x04000BC9 RID: 3017
		private long streamLength;

		// Token: 0x04000BCA RID: 3018
		private long streamPos;
	}
}
