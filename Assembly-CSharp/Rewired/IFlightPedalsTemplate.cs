using System;

namespace Rewired
{
	// Token: 0x020000E3 RID: 227
	public interface IFlightPedalsTemplate : IControllerTemplate
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06002B38 RID: 11064
		IControllerTemplateAxis leftPedal { get; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06002B39 RID: 11065
		IControllerTemplateAxis rightPedal { get; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06002B3A RID: 11066
		IControllerTemplateAxis slide { get; }
	}
}
