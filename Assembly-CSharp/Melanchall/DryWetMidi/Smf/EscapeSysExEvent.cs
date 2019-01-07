using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001A4 RID: 420
	public sealed class EscapeSysExEvent : SysExEvent
	{
		// Token: 0x060033AA RID: 13226 RVA: 0x00017797 File Offset: 0x00015997
		public EscapeSysExEvent()
		{
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x0001779F File Offset: 0x0001599F
		public EscapeSysExEvent(byte[] data)
		{
			base.Data = data;
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x000177AE File Offset: 0x000159AE
		public override string ToString()
		{
			return "Escape SysEx";
		}
	}
}
