using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A5 RID: 421
	public sealed class NormalSysExEvent : SysExEvent
	{
		// Token: 0x060033AD RID: 13229 RVA: 0x00017797 File Offset: 0x00015997
		public NormalSysExEvent()
		{
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x0001779F File Offset: 0x0001599F
		public NormalSysExEvent(byte[] data)
		{
			base.Data = data;
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x000177B5 File Offset: 0x000159B5
		public override string ToString()
		{
			return "Normal SysEx";
		}
	}
}
