using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200014D RID: 333
	[AddComponentMenu("")]
	public abstract class UIElementInfo : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060031A8 RID: 12712 RVA: 0x00145FF8 File Offset: 0x001441F8
		// (remove) Token: 0x060031A9 RID: 12713 RVA: 0x00146030 File Offset: 0x00144230
		public event Action<GameObject> OnSelectedEvent;

		// Token: 0x060031AA RID: 12714 RVA: 0x00015FF0 File Offset: 0x000141F0
		public void OnSelect(BaseEventData eventData)
		{
			if (this.OnSelectedEvent != null)
			{
				this.OnSelectedEvent(base.gameObject);
			}
		}

		// Token: 0x04000ACF RID: 2767
		public string identifier;

		// Token: 0x04000AD0 RID: 2768
		public int intData;

		// Token: 0x04000AD1 RID: 2769
		public Text text;
	}
}
