using System;
using System.Runtime.Serialization;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public sealed class NoHeaderChunkException : MidiException
	{
		// Token: 0x060033DA RID: 13274 RVA: 0x00017978 File Offset: 0x00015B78
		public NoHeaderChunkException() : base("MIDI file doesn't contain the header chunk.")
		{
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00017985 File Offset: 0x00015B85
		public NoHeaderChunkException(string message) : base(message)
		{
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x0001796E File Offset: 0x00015B6E
		private NoHeaderChunkException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
