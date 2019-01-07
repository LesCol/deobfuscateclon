using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200017F RID: 383
	public sealed class NoteOffEvent : NoteEvent
	{
		// Token: 0x060032E1 RID: 13025 RVA: 0x00016DDF File Offset: 0x00014FDF
		public NoteOffEvent()
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00016DE7 File Offset: 0x00014FE7
		public NoteOffEvent(SevenBitNumber noteNumber, SevenBitNumber velocity) : base(noteNumber, velocity)
		{
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00016DF1 File Offset: 0x00014FF1
		public override string ToString()
		{
			return string.Format("Note Off [{0}] ({1}, {2})", base.Channel, base.NoteNumber, base.Velocity);
		}
	}
}
