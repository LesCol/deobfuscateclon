using System;
using Melanchall.DryWetMidi.Common;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001CD RID: 461
	internal static class TimeDivisionFactory
	{
		// Token: 0x0600346C RID: 13420 RVA: 0x00018117 File Offset: 0x00016317
		internal static TimeDivision GetTimeDivision(short division)
		{
			if (division < 0)
			{
				division = -division;
				return new SmpteTimeDivision((SmpteFormat)division.GetHead(), division.GetTail());
			}
			return new TicksPerQuarterNoteTimeDivision(division);
		}
	}
}
