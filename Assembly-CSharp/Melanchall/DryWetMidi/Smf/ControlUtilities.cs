using System;
using Melanchall.DryWetMidi.Common;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001CF RID: 463
	public static class ControlUtilities
	{
		// Token: 0x0600346F RID: 13423 RVA: 0x0001816E File Offset: 0x0001636E
		public static ControlName GetControlName(this ControlChangeEvent controlChangeEvent)
		{
			return ControlUtilities.GetControlName(controlChangeEvent.ControlNumber);
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x0001817B File Offset: 0x0001637B
		private static ControlName GetControlName(SevenBitNumber controlNumber)
		{
			if (!Enum.IsDefined(typeof(ControlName), controlNumber))
			{
				return ControlName.Undefined;
			}
			return (ControlName)controlNumber;
		}
	}
}
