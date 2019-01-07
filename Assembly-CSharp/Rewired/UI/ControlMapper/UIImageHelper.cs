using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200014F RID: 335
	[RequireComponent(typeof(Image))]
	[AddComponentMenu("")]
	public class UIImageHelper : MonoBehaviour
	{
		// Token: 0x060031B1 RID: 12721 RVA: 0x00146068 File Offset: 0x00144268
		public void SetEnabledState(bool newState)
		{
			this.currentState = newState;
			UIImageHelper.State state = newState ? this.enabledState : this.disabledState;
			if (state == null)
			{
				return;
			}
			Image component = base.gameObject.GetComponent<Image>();
			if (component == null)
			{
				Debug.LogError("Image is missing!");
				return;
			}
			state.Set(component);
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00016073 File Offset: 0x00014273
		public void SetEnabledStateColor(Color color)
		{
			this.enabledState.color = color;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00016081 File Offset: 0x00014281
		public void SetDisabledStateColor(Color color)
		{
			this.disabledState.color = color;
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x001460BC File Offset: 0x001442BC
		public void Refresh()
		{
			UIImageHelper.State state = this.currentState ? this.enabledState : this.disabledState;
			Image component = base.gameObject.GetComponent<Image>();
			if (component == null)
			{
				return;
			}
			state.Set(component);
		}

		// Token: 0x04000AD5 RID: 2773
		[SerializeField]
		private UIImageHelper.State enabledState;

		// Token: 0x04000AD6 RID: 2774
		[SerializeField]
		private UIImageHelper.State disabledState;

		// Token: 0x04000AD7 RID: 2775
		private bool currentState;

		// Token: 0x02000150 RID: 336
		[Serializable]
		private class State
		{
			// Token: 0x060031B6 RID: 12726 RVA: 0x0001608F File Offset: 0x0001428F
			public void Set(Image image)
			{
				if (image == null)
				{
					return;
				}
				image.color = this.color;
			}

			// Token: 0x04000AD8 RID: 2776
			[SerializeField]
			public Color color;
		}
	}
}
