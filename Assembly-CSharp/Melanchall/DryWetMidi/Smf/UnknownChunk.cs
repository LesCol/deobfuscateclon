using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000162 RID: 354
	public sealed class UnknownChunk : MidiChunk
	{
		// Token: 0x0600323C RID: 12860 RVA: 0x00016718 File Offset: 0x00014918
		internal UnknownChunk(string id) : base(id)
		{
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x00016721 File Offset: 0x00014921
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x00016729 File Offset: 0x00014929
		public byte[] Data { get; private set; }

		// Token: 0x0600323F RID: 12863 RVA: 0x00147394 File Offset: 0x00145594
		protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size)
		{
			long num = reader.Length - reader.Position;
			byte[] array = reader.ReadBytes((int)((num < (long)((ulong)size)) ? num : ((long)((ulong)size))));
			if ((long)array.Length < (long)((ulong)size) && settings.NotEnoughBytesPolicy == NotEnoughBytesPolicy.Abort)
			{
				throw new NotEnoughBytesException("Chunk's data cannot be read since the reader's underlying stream doesn't have enough bytes.", (long)((ulong)size), (long)array.Length);
			}
			this.Data = array;
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x001473EC File Offset: 0x001455EC
		protected override void WriteContent(MidiWriter writer, WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data != null)
			{
				writer.WriteBytes(data);
			}
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x00016732 File Offset: 0x00014932
		protected override uint GetContentSize(WritingSettings settings)
		{
			byte[] data = this.Data;
			if (data == null)
			{
				return 0u;
			}
			return (uint)data.Length;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x00016742 File Offset: 0x00014942
		public override string ToString()
		{
			return "Unknown Chunk";
		}
	}
}
