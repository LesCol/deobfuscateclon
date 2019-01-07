using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000194 RID: 404
	public sealed class MarkerEvent : BaseTextEvent
	{
		// Token: 0x06003336 RID: 13110 RVA: 0x0001707F File Offset: 0x0001527F
		public MarkerEvent()
		{
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00017087 File Offset: 0x00015287
		public MarkerEvent(string text) : base(text)
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00017218 File Offset: 0x00015418
		protected override MidiEvent CloneEvent()
		{
			return new MarkerEvent(base.Text);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00017225 File Offset: 0x00015425
		public override string ToString()
		{
			return "Marker (" + base.Text + ")";
		}
	}
}
