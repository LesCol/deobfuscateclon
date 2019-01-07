using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B3 RID: 435
	public sealed class UnexpectedRunningStatusException : MidiException
	{
		// Token: 0x060033EA RID: 13290 RVA: 0x00017A65 File Offset: 0x00015C65
		public UnexpectedRunningStatusException() : base("Unexpected running status is encountered.")
		{
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x0001796E File Offset: 0x00015B6E
		private UnexpectedRunningStatusException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
