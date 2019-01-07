using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200015E RID: 350
	public abstract class MidiChunk
	{
		// Token: 0x06003225 RID: 12837 RVA: 0x00146CCC File Offset: 0x00144ECC
		public MidiChunk(string id)
		{
			if (id == null)
			{
				throw new ArgumentNullException(id);
			}
			if (string.IsNullOrEmpty(id))
			{
				throw new ArgumentException("ID is empty string.", "id");
			}
			if (id.Length != 4)
			{
				throw new ArgumentException(string.Format("ID length doesn't equal {0}.", 4), "id");
			}
			this.ChunkId = id;
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x0001668C File Offset: 0x0001488C
		public string ChunkId { get; }

		// Token: 0x06003227 RID: 12839 RVA: 0x00146D2C File Offset: 0x00144F2C
		internal void Read(MidiReader reader, ReadingSettings settings)
		{
			uint num = reader.ReadDword();
			long position = reader.Position;
			this.ReadContent(reader, settings, num);
			long num2 = reader.Position - position;
			if (settings.InvalidChunkSizePolicy == InvalidChunkSizePolicy.Abort && num2 != (long)((ulong)num))
			{
				throw new InvalidChunkSizeException((long)((ulong)num), num2);
			}
			long num3 = (long)((ulong)num - (ulong)num2);
			if (num3 > 0L)
			{
				reader.Position += num3;
			}
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x00146D90 File Offset: 0x00144F90
		internal void Write(MidiWriter writer, WritingSettings settings)
		{
			writer.WriteString(this.ChunkId);
			uint contentSize = this.GetContentSize(settings);
			writer.WriteDword(contentSize);
			this.WriteContent(writer, settings);
		}

		// Token: 0x06003229 RID: 12841
		protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, uint size);

		// Token: 0x0600322A RID: 12842
		protected abstract void WriteContent(MidiWriter writer, WritingSettings settings);

		// Token: 0x0600322B RID: 12843
		protected abstract uint GetContentSize(WritingSettings settings);

		// Token: 0x04000B00 RID: 2816
		public const int IdLength = 4;
	}
}
