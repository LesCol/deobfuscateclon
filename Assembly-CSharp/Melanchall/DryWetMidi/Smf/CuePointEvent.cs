using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200018E RID: 398
	public sealed class CuePointEvent : BaseTextEvent
	{
		// Token: 0x06003314 RID: 13076 RVA: 0x0001707F File Offset: 0x0001527F
		public CuePointEvent()
		{
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00017087 File Offset: 0x00015287
		public CuePointEvent(string text) : base(text)
		{
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000170B4 File Offset: 0x000152B4
		protected override MidiEvent CloneEvent()
		{
			return new CuePointEvent(base.Text);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000170C1 File Offset: 0x000152C1
		public override string ToString()
		{
			return "Cue Point (" + base.Text + ")";
		}
	}
}
