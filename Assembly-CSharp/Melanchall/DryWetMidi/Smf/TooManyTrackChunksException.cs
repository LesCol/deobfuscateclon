using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public sealed class TooManyTrackChunksException : MidiException
	{
		// Token: 0x060033E5 RID: 13285 RVA: 0x00017817 File Offset: 0x00015A17
		public TooManyTrackChunksException()
		{
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00017A17 File Offset: 0x00015C17
		public TooManyTrackChunksException(string message, int trackChunksCount) : base(message)
		{
			this.TrackChunksCount = trackChunksCount;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00017A27 File Offset: 0x00015C27
		private TooManyTrackChunksException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.TrackChunksCount = info.GetInt32("TrackChunksCount");
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x00017A42 File Offset: 0x00015C42
		public int TrackChunksCount { get; }

		// Token: 0x060033E9 RID: 13289 RVA: 0x00017A4A File Offset: 0x00015C4A
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("TrackChunksCount", this.TrackChunksCount);
			base.GetObjectData(info, context);
		}

		// Token: 0x04000BAE RID: 2990
		private const string TrackChunksCountSerializationPropertyName = "TrackChunksCount";
	}
}
