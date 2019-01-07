using System;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000136 RID: 310
	[AddComponentMenu("")]
	public class InputFieldInfo : UIElementInfo
	{
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x0001587A File Offset: 0x00013A7A
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x00015882 File Offset: 0x00013A82
		public int actionId { get; set; }

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x0001588B File Offset: 0x00013A8B
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x00015893 File Offset: 0x00013A93
		public AxisRange axisRange { get; set; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x0001589C File Offset: 0x00013A9C
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x000158A4 File Offset: 0x00013AA4
		public int actionElementMapId { get; set; }

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x000158AD File Offset: 0x00013AAD
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x000158B5 File Offset: 0x00013AB5
		public ControllerType controllerType { get; set; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000158BE File Offset: 0x00013ABE
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x000158C6 File Offset: 0x00013AC6
		public int controllerId { get; set; }
	}
}
