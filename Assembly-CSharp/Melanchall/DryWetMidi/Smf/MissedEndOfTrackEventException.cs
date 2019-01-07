using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001AF RID: 431
	[Serializable]
	public sealed class MissedEndOfTrackEventException : MidiException
	{
		// Token: 0x060033D8 RID: 13272 RVA: 0x00017961 File Offset: 0x00015B61
		public MissedEndOfTrackEventException() : base("Track chunk doesn't end with End Of Track event.")
		{
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x0001796E File Offset: 0x00015B6E
		private MissedEndOfTrackEventException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
