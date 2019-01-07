using System;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000137 RID: 311
	[AddComponentMenu("")]
	public class InputRow : MonoBehaviour
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000158CF File Offset: 0x00013ACF
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x000158D7 File Offset: 0x00013AD7
		public ButtonInfo[] buttons { get; private set; }

		// Token: 0x060030FB RID: 12539 RVA: 0x000158E0 File Offset: 0x00013AE0
		public void Initialize(int rowIndex, string label, Action<int, ButtonInfo> inputFieldActivatedCallback)
		{
			this.rowIndex = rowIndex;
			this.label.text = label;
			this.inputFieldActivatedCallback = inputFieldActivatedCallback;
			this.buttons = base.transform.GetComponentsInChildren<ButtonInfo>(true);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x0001590E File Offset: 0x00013B0E
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
			if (this.inputFieldActivatedCallback == null)
			{
				return;
			}
			this.inputFieldActivatedCallback(this.rowIndex, buttonInfo);
		}

		// Token: 0x04000A3F RID: 2623
		public Text label;

		// Token: 0x04000A41 RID: 2625
		private int rowIndex;

		// Token: 0x04000A42 RID: 2626
		private Action<int, ButtonInfo> inputFieldActivatedCallback;
	}
}
