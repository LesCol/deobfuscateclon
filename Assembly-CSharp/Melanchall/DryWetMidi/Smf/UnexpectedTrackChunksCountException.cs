using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B4 RID: 436
	[Serializable]
	public sealed class UnexpectedTrackChunksCountException : MidiException
	{
		// Token: 0x060033EC RID: 13292 RVA: 0x00017817 File Offset: 0x00015A17
		public UnexpectedTrackChunksCountException()
		{
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00017A72 File Offset: 0x00015C72
		public UnexpectedTrackChunksCountException(string message, int expectedCount, int actualCount) : base(message)
		{
			this.ExpectedCount = expectedCount;
			this.ActualCount = actualCount;
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00017A89 File Offset: 0x00015C89
		private UnexpectedTrackChunksCountException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ExpectedCount = info.GetInt32("ExpectedCount");
			this.ActualCount = info.GetInt32("ActualCount");
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x00017AB5 File Offset: 0x00015CB5
		public int ExpectedCount { get; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x00017ABD File Offset: 0x00015CBD
		public int ActualCount { get; }

		// Token: 0x060033F1 RID: 13297 RVA: 0x00017AC5 File Offset: 0x00015CC5
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ExpectedCount", this.ExpectedCount);
			info.AddValue("ActualCount", this.ActualCount);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BB0 RID: 2992
		private const string ExpectedCountSerializationPropertyName = "ExpectedCount";

		// Token: 0x04000BB1 RID: 2993
		private const string ActualCountSerializationPropertyName = "ActualCount";
	}
}
