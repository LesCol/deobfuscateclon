using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200014B RID: 331
	[AddComponentMenu("")]
	public class UIControlSet : MonoBehaviour
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00145E7C File Offset: 0x0014407C
		private Dictionary<int, UIControl> controls
		{
			get
			{
				Dictionary<int, UIControl> result;
				if ((result = this._controls) == null)
				{
					result = (this._controls = new Dictionary<int, UIControl>());
				}
				return result;
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x00015FA2 File Offset: 0x000141A2
		public void SetTitle(string text)
		{
			if (this.title == null)
			{
				return;
			}
			this.title.text = text;
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x00145EA4 File Offset: 0x001440A4
		public T GetControl<T>(int uniqueId) where T : UIControl
		{
			UIControl uicontrol;
			this.controls.TryGetValue(uniqueId, out uicontrol);
			return uicontrol as T;
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00145ECC File Offset: 0x001440CC
		public UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<int, float> valueChangedCallback, Action<int> cancelCallback)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(prefab);
			UISliderControl control = gameObject.GetComponent<UISliderControl>();
			if (control == null)
			{
				UnityEngine.Object.Destroy(gameObject);
				Debug.LogError("Prefab missing UISliderControl component!");
				return null;
			}
			gameObject.transform.SetParent(base.transform, false);
			if (control.iconImage != null)
			{
				control.iconImage.sprite = icon;
			}
			if (control.slider != null)
			{
				control.slider.minValue = minValue;
				control.slider.maxValue = maxValue;
				if (valueChangedCallback != null)
				{
					control.slider.onValueChanged.AddListener(delegate(float value)
					{
						valueChangedCallback(control.id, value);
					});
				}
				if (cancelCallback != null)
				{
					control.SetCancelCallback(delegate
					{
						cancelCallback(control.id);
					});
				}
			}
			this.controls.Add(control.id, control);
			return control;
		}

		// Token: 0x04000ACA RID: 2762
		[SerializeField]
		private Text title;

		// Token: 0x04000ACB RID: 2763
		private Dictionary<int, UIControl> _controls;
	}
}
