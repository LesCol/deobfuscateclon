using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200014E RID: 334
	[AddComponentMenu("")]
	public class UIGroup : MonoBehaviour
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x0001600B File Offset: 0x0001420B
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x0001602C File Offset: 0x0001422C
		public string labelText
		{
			get
			{
				if (!(this._label != null))
				{
					return string.Empty;
				}
				return this._label.text;
			}
			set
			{
				if (this._label == null)
				{
					return;
				}
				this._label.text = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x00016049 File Offset: 0x00014249
		public Transform content
		{
			get
			{
				return this._content;
			}
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x00016051 File Offset: 0x00014251
		public void SetLabelActive(bool state)
		{
			if (this._label == null)
			{
				return;
			}
			this._label.gameObject.SetActive(state);
		}

		// Token: 0x04000AD3 RID: 2771
		[SerializeField]
		private Text _label;

		// Token: 0x04000AD4 RID: 2772
		[SerializeField]
		private Transform _content;
	}
}
