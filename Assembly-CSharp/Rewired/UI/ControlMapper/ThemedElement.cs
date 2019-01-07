using System;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200013C RID: 316
	[AddComponentMenu("")]
	public class ThemedElement : MonoBehaviour
	{
		// Token: 0x06003142 RID: 12610 RVA: 0x00015BEE File Offset: 0x00013DEE
		private void Start()
		{
			ControlMapper.ApplyTheme(this._elements);
		}

		// Token: 0x04000A85 RID: 2693
		[SerializeField]
		private ThemedElement.ElementInfo[] _elements;

		// Token: 0x0200013D RID: 317
		[Serializable]
		public class ElementInfo
		{
			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06003144 RID: 12612 RVA: 0x00015BFB File Offset: 0x00013DFB
			public string themeClass
			{
				get
				{
					return this._themeClass;
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06003145 RID: 12613 RVA: 0x00015C03 File Offset: 0x00013E03
			public Component component
			{
				get
				{
					return this._component;
				}
			}

			// Token: 0x04000A86 RID: 2694
			[SerializeField]
			private string _themeClass;

			// Token: 0x04000A87 RID: 2695
			[SerializeField]
			private Component _component;
		}
	}
}
