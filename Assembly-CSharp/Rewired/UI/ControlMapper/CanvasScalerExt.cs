using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000105 RID: 261
	[AddComponentMenu("")]
	public class CanvasScalerExt : CanvasScaler
	{
		// Token: 0x06002DE3 RID: 11747 RVA: 0x00013266 File Offset: 0x00011466
		public void ForceRefresh()
		{
			this.Handle();
		}
	}
}
