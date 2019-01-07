using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200019E RID: 414
	public sealed class UnknownMetaEvent : MetaEvent
	{
		// Token: 0x06003393 RID: 13203 RVA: 0x00017680 File Offset: 0x00015880
		internal UnknownMetaEvent(byte statusByte) : this(statusByte, null)
		{
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x0001768A File Offset: 0x0001588A
		private UnknownMetaEvent(byte statusByte, byte[] data)
		{
			this.StatusByte = statusByte;
			this.Data = data;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x000176A0 File Offset: 0x000158A0
		public byte StatusByte { get; }

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x000176A8 File Offset: 0x000158A8
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x000176B0 File Offset: 0x000158B0
		public byte[] Data { get; private set; }

		// Token: 0x06003398 RID: 13208 RVA: 0x000176B9 File Offset: 0x000158B9
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size)
		{
			this.Data = reader.ReadBytes(size);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x0014819C File Offset: 0x0014639C
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data != null)
			{
				writer.WriteBytes(data);
			}
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000176C8 File Offset: 0x000158C8
		protected override int GetContentSize(WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.Length;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x000176D8 File Offset: 0x000158D8
		protected override MidiEvent CloneEvent()
		{
			byte statusByte = this.StatusByte;
			byte[] data = this.Data;
			return new UnknownMetaEvent(statusByte, ((data != null) ? data.Clone() : null) as byte[]);
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x000176FC File Offset: 0x000158FC
		public override string ToString()
		{
			return string.Format("Unknown meta event ({0})", this.StatusByte);
		}
	}
}
