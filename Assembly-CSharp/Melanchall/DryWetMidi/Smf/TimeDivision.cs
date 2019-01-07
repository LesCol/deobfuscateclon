using System;

namespace Melanchall.DryWetMidi.Smf
{
	// Token: 0x020001CC RID: 460
	public abstract class TimeDivision
	{
		// Token: 0x06003469 RID: 13417
		internal abstract short ToInt16();

		// Token: 0x0600346A RID: 13418
		public abstract TimeDivision Clone();
	}
}
