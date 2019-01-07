using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001AC RID: 428
	[Serializable]
	public sealed class InvalidChunkSizeException : MidiException
	{
		// Token: 0x060033C9 RID: 13257 RVA: 0x0001786D File Offset: 0x00015A6D
		public InvalidChunkSizeException() : base("Actual size of a chunk differs from the one declared in the chunk's header.")
		{
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x0001787A File Offset: 0x00015A7A
		public InvalidChunkSizeException(long expectedSize, long actualSize) : this()
		{
			this.ExpectedSize = expectedSize;
			this.ActualSize = actualSize;
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00017890 File Offset: 0x00015A90
		private InvalidChunkSizeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ExpectedSize = info.GetInt64("ExpectedSize");
			this.ActualSize = info.GetInt64("ActualSize");
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x000178BC File Offset: 0x00015ABC
		public long ExpectedSize { get; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000178C4 File Offset: 0x00015AC4
		public long ActualSize { get; }

		// Token: 0x060033CE RID: 13262 RVA: 0x000178CC File Offset: 0x00015ACC
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ExpectedSize", this.ExpectedSize);
			info.AddValue("ActualSize", this.ActualSize);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BA4 RID: 2980
		private const string ExpectedSizeSerializationPropertyName = "ExpectedSize";

		// Token: 0x04000BA5 RID: 2981
		private const string ActualSizeSerializationPropertyName = "ActualSize";
	}
}
