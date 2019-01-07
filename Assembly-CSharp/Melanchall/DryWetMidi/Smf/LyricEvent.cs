using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000193 RID: 403
	public sealed class LyricEvent : BaseTextEvent
	{
		// Token: 0x06003332 RID: 13106 RVA: 0x0001707F File Offset: 0x0001527F
		public LyricEvent()
		{
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00017087 File Offset: 0x00015287
		public LyricEvent(string text) : base(text)
		{
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000171F4 File Offset: 0x000153F4
		protected override MidiEvent CloneEvent()
		{
			return new LyricEvent(base.Text);
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00017201 File Offset: 0x00015401
		public override string ToString()
		{
			return "Lyric (" + base.Text + ")";
		}
	}
}
