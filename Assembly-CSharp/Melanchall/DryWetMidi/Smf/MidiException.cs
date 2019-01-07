using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001AE RID: 430
	public abstract class MidiException : Exception
	{
		// Token: 0x060033D4 RID: 13268 RVA: 0x00017946 File Offset: 0x00015B46
		public MidiException()
		{
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x0001794E File Offset: 0x00015B4E
		public MidiException(string message) : base(message)
		{
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		public MidiException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00017957 File Offset: 0x00015B57
		protected MidiException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
