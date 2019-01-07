using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000191 RID: 401
	public sealed class InstrumentNameEvent : BaseTextEvent
	{
		// Token: 0x06003322 RID: 13090 RVA: 0x0001707F File Offset: 0x0001527F
		public InstrumentNameEvent()
		{
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x00017087 File Offset: 0x00015287
		public InstrumentNameEvent(string instrumentName) : base(instrumentName)
		{
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x0001710A File Offset: 0x0001530A
		protected override MidiEvent CloneEvent()
		{
			return new InstrumentNameEvent(base.Text);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00017117 File Offset: 0x00015317
		public override string ToString()
		{
			return "Instrument Name (" + base.Text + ")";
		}
	}
}
