using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x0200018D RID: 397
	public sealed class CopyrightNoticeEvent : BaseTextEvent
	{
		// Token: 0x06003310 RID: 13072 RVA: 0x0001707F File Offset: 0x0001527F
		public CopyrightNoticeEvent()
		{
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00017087 File Offset: 0x00015287
		public CopyrightNoticeEvent(string text) : base(text)
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00017090 File Offset: 0x00015290
		protected override MidiEvent CloneEvent()
		{
			return new CopyrightNoticeEvent(base.Text);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0001709D File Offset: 0x0001529D
		public override string ToString()
		{
			return "Copyright Notice (" + base.Text + ")";
		}
	}
}
