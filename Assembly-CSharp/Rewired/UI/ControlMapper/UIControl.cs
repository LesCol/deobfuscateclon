using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200014A RID: 330
	[AddComponentMenu("")]
	public class UIControl : MonoBehaviour
	{
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x00015F37 File Offset: 0x00014137
		public int id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00015F3F File Offset: 0x0001413F
		private void Awake()
		{
			this._id = UIControl.GetNextUid();
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x00015F4C File Offset: 0x0001414C
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x00015F54 File Offset: 0x00014154
		public bool showTitle
		{
			get
			{
				return this._showTitle;
			}
			set
			{
				if (this.title == null)
				{
					return;
				}
				this.title.gameObject.SetActive(value);
				this._showTitle = value;
			}
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x00002C8A File Offset: 0x00000E8A
		public virtual void SetCancelCallback(Action cancelCallback)
		{
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x00015F7D File Offset: 0x0001417D
		private static int GetNextUid()
		{
			if (UIControl._uidCounter == 2147483647)
			{
				UIControl._uidCounter = 0;
			}
			int uidCounter = UIControl._uidCounter;
			UIControl._uidCounter++;
			return uidCounter;
		}

		// Token: 0x04000AC6 RID: 2758
		public Text title;

		// Token: 0x04000AC7 RID: 2759
		private int _id;

		// Token: 0x04000AC8 RID: 2760
		private bool _showTitle;

		// Token: 0x04000AC9 RID: 2761
		private static int _uidCounter;
	}
}
