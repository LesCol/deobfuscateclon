using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B6 RID: 438
	[Serializable]
	public sealed class UnknownChunkException : MidiException
	{
		// Token: 0x060033F8 RID: 13304 RVA: 0x00017817 File Offset: 0x00015A17
		public UnknownChunkException()
		{
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00017985 File Offset: 0x00015B85
		public UnknownChunkException(string message) : base(message)
		{
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0001798E File Offset: 0x00015B8E
		public UnknownChunkException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00017B90 File Offset: 0x00015D90
		public UnknownChunkException(string message, string chunkId) : this(message)
		{
			this.ChunkId = chunkId;
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00017BA0 File Offset: 0x00015DA0
		private UnknownChunkException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ChunkId = info.GetString("ChunkId");
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060033FD RID: 13309 RVA: 0x00017BBB File Offset: 0x00015DBB
		public string ChunkId { get; }

		// Token: 0x060033FE RID: 13310 RVA: 0x00017BC3 File Offset: 0x00015DC3
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ChunkId", this.ChunkId);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BB8 RID: 3000
		private const string ChunkIdSerializationPropertyName = "ChunkId";
	}
}
