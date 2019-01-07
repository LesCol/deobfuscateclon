using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B7 RID: 439
	[Serializable]
	public sealed class UnknownFileFormatException : MidiException
	{
		// Token: 0x060033FF RID: 13311 RVA: 0x00017817 File Offset: 0x00015A17
		public UnknownFileFormatException()
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00017985 File Offset: 0x00015B85
		public UnknownFileFormatException(string message) : base(message)
		{
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00017BDE File Offset: 0x00015DDE
		public UnknownFileFormatException(string message, ushort fileFormat) : this(message)
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00017BE7 File Offset: 0x00015DE7
		private UnknownFileFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileFormat = info.GetUInt16("FileFormat");
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x00017C02 File Offset: 0x00015E02
		public ushort FileFormat { get; }

		// Token: 0x06003404 RID: 13316 RVA: 0x00017C0A File Offset: 0x00015E0A
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("FileFormat", this.FileFormat);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BBA RID: 3002
		private const string FileFormatSerializationPropertyName = "FileFormat";
	}
}
