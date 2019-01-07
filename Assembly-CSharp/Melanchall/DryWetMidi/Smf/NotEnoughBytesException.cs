using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B1 RID: 433
	[Serializable]
	public sealed class NotEnoughBytesException : MidiException
	{
		// Token: 0x060033DD RID: 13277 RVA: 0x00017817 File Offset: 0x00015A17
		public NotEnoughBytesException()
		{
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00017985 File Offset: 0x00015B85
		public NotEnoughBytesException(string message) : base(message)
		{
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0001798E File Offset: 0x00015B8E
		public NotEnoughBytesException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00017998 File Offset: 0x00015B98
		public NotEnoughBytesException(string message, long expectedCount, long actualCount) : this(message)
		{
			this.ExpectedCount = expectedCount;
			this.ActualCount = actualCount;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x000179AF File Offset: 0x00015BAF
		private NotEnoughBytesException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ExpectedCount = info.GetInt64("ExpectedCount");
			this.ActualCount = info.GetInt64("ActualCount");
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060033E2 RID: 13282 RVA: 0x000179DB File Offset: 0x00015BDB
		public long ExpectedCount { get; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000179E3 File Offset: 0x00015BE3
		public long ActualCount { get; }

		// Token: 0x060033E4 RID: 13284 RVA: 0x000179EB File Offset: 0x00015BEB
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("ExpectedCount", this.ExpectedCount);
			info.AddValue("ActualCount", this.ActualCount);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BAA RID: 2986
		private const string ExpectedCountSerializationPropertyName = "ExpectedCount";

		// Token: 0x04000BAB RID: 2987
		private const string ActualCountSerializationPropertyName = "ActualCount";
	}
}
