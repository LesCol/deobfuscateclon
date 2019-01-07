using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000199 RID: 409
	public sealed class SequenceTrackNameEvent : BaseTextEvent
	{
		// Token: 0x06003359 RID: 13145 RVA: 0x0001707F File Offset: 0x0001527F
		public SequenceTrackNameEvent()
		{
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00017087 File Offset: 0x00015287
		public SequenceTrackNameEvent(string name) : base(name)
		{
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x0001738D File Offset: 0x0001558D
		protected override MidiEvent CloneEvent()
		{
			return new SequenceTrackNameEvent(base.Text);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x0001739A File Offset: 0x0001559A
		public override string ToString()
		{
			return "Sequence/Track Name (" + base.Text + ")";
		}
	}
}
