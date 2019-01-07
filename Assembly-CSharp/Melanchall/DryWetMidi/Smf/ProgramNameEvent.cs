using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x02000196 RID: 406
	public sealed class ProgramNameEvent : BaseTextEvent
	{
		// Token: 0x06003343 RID: 13123 RVA: 0x0001707F File Offset: 0x0001527F
		public ProgramNameEvent()
		{
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00017087 File Offset: 0x00015287
		public ProgramNameEvent(string programName) : base(programName)
		{
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x000172A0 File Offset: 0x000154A0
		protected override MidiEvent CloneEvent()
		{
			return new ProgramNameEvent(base.Text);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x000172AD File Offset: 0x000154AD
		public override string ToString()
		{
			return "Program Name (" + base.Text + ")";
		}
	}
}
