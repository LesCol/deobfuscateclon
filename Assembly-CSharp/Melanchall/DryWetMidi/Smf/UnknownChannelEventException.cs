using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B5 RID: 437
	[Serializable]
	public sealed class UnknownChannelEventException : MidiException
	{
		// Token: 0x060033F2 RID: 13298 RVA: 0x00017AF1 File Offset: 0x00015CF1
		public UnknownChannelEventException() : base("Unknown channel event.")
		{
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00017AFE File Offset: 0x00015CFE
		public UnknownChannelEventException(FourBitNumber statusByte, FourBitNumber channel) : this()
		{
			this.StatusByte = statusByte;
			this.Channel = channel;
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00017B14 File Offset: 0x00015D14
		private UnknownChannelEventException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.StatusByte = (FourBitNumber)info.GetByte("StatusByte");
			this.Channel = (FourBitNumber)info.GetByte("Channel");
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x00017B4A File Offset: 0x00015D4A
		public FourBitNumber Channel { get; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x00017B52 File Offset: 0x00015D52
		public FourBitNumber StatusByte { get; }

		// Token: 0x060033F7 RID: 13303 RVA: 0x00017B5A File Offset: 0x00015D5A
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("Channel", this.Channel);
			info.AddValue("StatusByte", this.StatusByte);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BB4 RID: 2996
		private const string ChannelSerializationPropertyName = "Channel";

		// Token: 0x04000BB5 RID: 2997
		private const string StatusByteSerializationPropertyName = "StatusByte";
	}
}
