using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000131 RID: 305
	[AddComponentMenu("")]
	public class InputBehaviorWindow : Window
	{
		// Token: 0x060030D3 RID: 12499 RVA: 0x00144C5C File Offset: 0x00142E5C
		public override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
			if (!(this.spawnTransform == null) && !(this.doneButton == null) && !(this.cancelButton == null) && !(this.defaultButton == null) && !(this.uiControlSetPrefab == null) && !(this.uiSliderControlPrefab == null) && !(this.doneButtonLabel == null) && !(this.cancelButtonLabel == null) && !(this.defaultButtonLabel == null))
			{
				this.inputBehaviorInfo = new List<InputBehaviorWindow.InputBehaviorInfo>();
				this.buttonCallbacks = new Dictionary<int, Action<int>>();
				this.doneButtonLabel.text = ControlMapper.GetLanguage().done;
				this.cancelButtonLabel.text = ControlMapper.GetLanguage().cancel;
				this.defaultButtonLabel.text = ControlMapper.GetLanguage().default_;
				base.Initialize(id, isFocusedCallback);
				return;
			}
			Debug.LogError("Rewired Control Mapper: All inspector values must be assigned!");
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00144D64 File Offset: 0x00142F64
		public void SetData(int playerId, ControlMapper.InputBehaviorSettings[] data)
		{
			if (!base.initialized)
			{
				return;
			}
			this.playerId = playerId;
			foreach (ControlMapper.InputBehaviorSettings inputBehaviorSettings in data)
			{
				if (inputBehaviorSettings != null && inputBehaviorSettings.isValid)
				{
					InputBehavior inputBehavior = this.GetInputBehavior(inputBehaviorSettings.inputBehaviorId);
					if (inputBehavior != null)
					{
						UIControlSet uicontrolSet = this.CreateControlSet();
						Dictionary<int, InputBehaviorWindow.PropertyType> dictionary = new Dictionary<int, InputBehaviorWindow.PropertyType>();
						string customEntry = ControlMapper.GetLanguage().GetCustomEntry(inputBehaviorSettings.labelLanguageKey);
						if (!string.IsNullOrEmpty(customEntry))
						{
							uicontrolSet.SetTitle(customEntry);
						}
						else
						{
							uicontrolSet.SetTitle(inputBehavior.name);
						}
						if (inputBehaviorSettings.showJoystickAxisSensitivity)
						{
							UISliderControl uisliderControl = this.CreateSlider(uicontrolSet, inputBehavior.id, null, ControlMapper.GetLanguage().GetCustomEntry(inputBehaviorSettings.joystickAxisSensitivityLabelLanguageKey), inputBehaviorSettings.joystickAxisSensitivityIcon, inputBehaviorSettings.joystickAxisSensitivityMin, inputBehaviorSettings.joystickAxisSensitivityMax, new Action<int, int, float>(this.JoystickAxisSensitivityValueChanged), new Action<int, int>(this.JoystickAxisSensitivityCanceled));
							uisliderControl.slider.value = Mathf.Clamp(inputBehavior.joystickAxisSensitivity, inputBehaviorSettings.joystickAxisSensitivityMin, inputBehaviorSettings.joystickAxisSensitivityMax);
							dictionary.Add(uisliderControl.id, InputBehaviorWindow.PropertyType.JoystickAxisSensitivity);
						}
						if (inputBehaviorSettings.showMouseXYAxisSensitivity)
						{
							UISliderControl uisliderControl2 = this.CreateSlider(uicontrolSet, inputBehavior.id, null, ControlMapper.GetLanguage().GetCustomEntry(inputBehaviorSettings.mouseXYAxisSensitivityLabelLanguageKey), inputBehaviorSettings.mouseXYAxisSensitivityIcon, inputBehaviorSettings.mouseXYAxisSensitivityMin, inputBehaviorSettings.mouseXYAxisSensitivityMax, new Action<int, int, float>(this.MouseXYAxisSensitivityValueChanged), new Action<int, int>(this.MouseXYAxisSensitivityCanceled));
							uisliderControl2.slider.value = Mathf.Clamp(inputBehavior.mouseXYAxisSensitivity, inputBehaviorSettings.mouseXYAxisSensitivityMin, inputBehaviorSettings.mouseXYAxisSensitivityMax);
							dictionary.Add(uisliderControl2.id, InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity);
						}
						this.inputBehaviorInfo.Add(new InputBehaviorWindow.InputBehaviorInfo(inputBehavior, uicontrolSet, dictionary));
					}
				}
			}
			base.defaultUIElement = this.doneButton.gameObject;
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x00015754 File Offset: 0x00013954
		public void SetButtonCallback(InputBehaviorWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
		{
			if (!base.initialized)
			{
				return;
			}
			if (callback == null)
			{
				return;
			}
			if (this.buttonCallbacks.ContainsKey((int)buttonIdentifier))
			{
				this.buttonCallbacks[(int)buttonIdentifier] = callback;
				return;
			}
			this.buttonCallbacks.Add((int)buttonIdentifier, callback);
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00144F2C File Offset: 0x0014312C
		public override void Cancel()
		{
			if (!base.initialized)
			{
				return;
			}
			foreach (InputBehaviorWindow.InputBehaviorInfo inputBehaviorInfo in this.inputBehaviorInfo)
			{
				inputBehaviorInfo.RestorePreviousData();
			}
			Action<int> action;
			if (!this.buttonCallbacks.TryGetValue(1, out action))
			{
				if (this.cancelCallback != null)
				{
					this.cancelCallback();
				}
				return;
			}
			action(base.id);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x00144FB8 File Offset: 0x001431B8
		public void OnDone()
		{
			if (!base.initialized)
			{
				return;
			}
			Action<int> action;
			if (!this.buttonCallbacks.TryGetValue(0, out action))
			{
				return;
			}
			action(base.id);
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x000130A7 File Offset: 0x000112A7
		public void OnCancel()
		{
			this.Cancel();
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x00144FEC File Offset: 0x001431EC
		public void OnRestoreDefault()
		{
			if (!base.initialized)
			{
				return;
			}
			foreach (InputBehaviorWindow.InputBehaviorInfo inputBehaviorInfo in this.inputBehaviorInfo)
			{
				inputBehaviorInfo.RestoreDefaultData();
			}
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x0001578C File Offset: 0x0001398C
		private void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
			this.GetInputBehavior(inputBehaviorId).joystickAxisSensitivity = value;
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x0001579B File Offset: 0x0001399B
		private void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
			this.GetInputBehavior(inputBehaviorId).mouseXYAxisSensitivity = value;
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x00145048 File Offset: 0x00143248
		private void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
			InputBehaviorWindow.InputBehaviorInfo inputBehaviorInfo = this.GetInputBehaviorInfo(inputBehaviorId);
			if (inputBehaviorInfo == null)
			{
				return;
			}
			inputBehaviorInfo.RestoreData(InputBehaviorWindow.PropertyType.JoystickAxisSensitivity, controlId);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x0014506C File Offset: 0x0014326C
		private void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
			InputBehaviorWindow.InputBehaviorInfo inputBehaviorInfo = this.GetInputBehaviorInfo(inputBehaviorId);
			if (inputBehaviorInfo == null)
			{
				return;
			}
			inputBehaviorInfo.RestoreData(InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity, controlId);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x000157AA File Offset: 0x000139AA
		public override void TakeInputFocus()
		{
			base.TakeInputFocus();
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000157B2 File Offset: 0x000139B2
		private UIControlSet CreateControlSet()
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.uiControlSetPrefab);
			gameObject.transform.SetParent(this.spawnTransform, false);
			return gameObject.GetComponent<UIControlSet>();
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x00145090 File Offset: 0x00143290
		private UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Action<int, int, float> valueChangedCallback, Action<int, int> cancelCallback)
		{
			UISliderControl uisliderControl = set.CreateSlider(this.uiSliderControlPrefab, icon, minValue, maxValue, delegate(int cId, float value)
			{
				valueChangedCallback(inputBehaviorId, cId, value);
			}, delegate(int cId)
			{
				cancelCallback(inputBehaviorId, cId);
			});
			string text = string.IsNullOrEmpty(overrideTitle) ? defaultTitle : overrideTitle;
			if (!string.IsNullOrEmpty(text))
			{
				uisliderControl.showTitle = true;
				uisliderControl.title.text = text;
			}
			else
			{
				uisliderControl.showTitle = false;
			}
			uisliderControl.showIcon = (icon != null);
			return uisliderControl;
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x000157D6 File Offset: 0x000139D6
		private InputBehavior GetInputBehavior(int id)
		{
			return ReInput.mapping.GetInputBehavior(this.playerId, id);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x00145128 File Offset: 0x00143328
		private InputBehaviorWindow.InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId)
		{
			int count = this.inputBehaviorInfo.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.inputBehaviorInfo[i].inputBehavior.id == inputBehaviorId)
				{
					return this.inputBehaviorInfo[i];
				}
			}
			return null;
		}

		// Token: 0x04000A1F RID: 2591
		private const float minSensitivity = 0.1f;

		// Token: 0x04000A20 RID: 2592
		[SerializeField]
		private RectTransform spawnTransform;

		// Token: 0x04000A21 RID: 2593
		[SerializeField]
		private Button doneButton;

		// Token: 0x04000A22 RID: 2594
		[SerializeField]
		private Button cancelButton;

		// Token: 0x04000A23 RID: 2595
		[SerializeField]
		private Button defaultButton;

		// Token: 0x04000A24 RID: 2596
		[SerializeField]
		private Text doneButtonLabel;

		// Token: 0x04000A25 RID: 2597
		[SerializeField]
		private Text cancelButtonLabel;

		// Token: 0x04000A26 RID: 2598
		[SerializeField]
		private Text defaultButtonLabel;

		// Token: 0x04000A27 RID: 2599
		[SerializeField]
		private GameObject uiControlSetPrefab;

		// Token: 0x04000A28 RID: 2600
		[SerializeField]
		private GameObject uiSliderControlPrefab;

		// Token: 0x04000A29 RID: 2601
		private List<InputBehaviorWindow.InputBehaviorInfo> inputBehaviorInfo;

		// Token: 0x04000A2A RID: 2602
		private Dictionary<int, Action<int>> buttonCallbacks;

		// Token: 0x04000A2B RID: 2603
		private int playerId;

		// Token: 0x02000132 RID: 306
		private class InputBehaviorInfo
		{
			// Token: 0x170003B6 RID: 950
			// (get) Token: 0x060030E4 RID: 12516 RVA: 0x000157F1 File Offset: 0x000139F1
			public InputBehavior inputBehavior
			{
				get
				{
					return this._inputBehavior;
				}
			}

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x060030E5 RID: 12517 RVA: 0x000157F9 File Offset: 0x000139F9
			public UIControlSet controlSet
			{
				get
				{
					return this._controlSet;
				}
			}

			// Token: 0x060030E6 RID: 12518 RVA: 0x00015801 File Offset: 0x00013A01
			public InputBehaviorInfo(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty)
			{
				this._inputBehavior = inputBehavior;
				this._controlSet = controlSet;
				this.idToProperty = idToProperty;
				this.copyOfOriginal = new InputBehavior(inputBehavior);
			}

			// Token: 0x060030E7 RID: 12519 RVA: 0x0001582A File Offset: 0x00013A2A
			public void RestorePreviousData()
			{
				this._inputBehavior.ImportData(this.copyOfOriginal);
			}

			// Token: 0x060030E8 RID: 12520 RVA: 0x0001583E File Offset: 0x00013A3E
			public void RestoreDefaultData()
			{
				this._inputBehavior.Reset();
				this.RefreshControls();
			}

			// Token: 0x060030E9 RID: 12521 RVA: 0x00145178 File Offset: 0x00143378
			public void RestoreData(InputBehaviorWindow.PropertyType propertyType, int controlId)
			{
				if (propertyType != InputBehaviorWindow.PropertyType.JoystickAxisSensitivity)
				{
					if (propertyType != InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity)
					{
						return;
					}
					float mouseXYAxisSensitivity = this.copyOfOriginal.mouseXYAxisSensitivity;
					this._inputBehavior.mouseXYAxisSensitivity = mouseXYAxisSensitivity;
					UISliderControl control = this._controlSet.GetControl<UISliderControl>(controlId);
					if (control != null)
					{
						control.slider.value = mouseXYAxisSensitivity;
					}
				}
				else
				{
					float joystickAxisSensitivity = this.copyOfOriginal.joystickAxisSensitivity;
					this._inputBehavior.joystickAxisSensitivity = joystickAxisSensitivity;
					UISliderControl control2 = this._controlSet.GetControl<UISliderControl>(controlId);
					if (control2 != null)
					{
						control2.slider.value = joystickAxisSensitivity;
						return;
					}
				}
			}

			// Token: 0x060030EA RID: 12522 RVA: 0x00145204 File Offset: 0x00143404
			public void RefreshControls()
			{
				if (this._controlSet == null)
				{
					return;
				}
				if (this.idToProperty == null)
				{
					return;
				}
				foreach (KeyValuePair<int, InputBehaviorWindow.PropertyType> keyValuePair in this.idToProperty)
				{
					UISliderControl control = this._controlSet.GetControl<UISliderControl>(keyValuePair.Key);
					if (!(control == null))
					{
						InputBehaviorWindow.PropertyType value = keyValuePair.Value;
						if (value != InputBehaviorWindow.PropertyType.JoystickAxisSensitivity)
						{
							if (value == InputBehaviorWindow.PropertyType.MouseXYAxisSensitivity)
							{
								control.slider.value = this._inputBehavior.mouseXYAxisSensitivity;
							}
						}
						else
						{
							control.slider.value = this._inputBehavior.joystickAxisSensitivity;
						}
					}
				}
			}

			// Token: 0x04000A2C RID: 2604
			private InputBehavior _inputBehavior;

			// Token: 0x04000A2D RID: 2605
			private UIControlSet _controlSet;

			// Token: 0x04000A2E RID: 2606
			private Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty;

			// Token: 0x04000A2F RID: 2607
			private InputBehavior copyOfOriginal;
		}

		// Token: 0x02000133 RID: 307
		public enum ButtonIdentifier
		{
			// Token: 0x04000A31 RID: 2609
			Done,
			// Token: 0x04000A32 RID: 2610
			Cancel,
			// Token: 0x04000A33 RID: 2611
			Default
		}

		// Token: 0x02000134 RID: 308
		private enum PropertyType
		{
			// Token: 0x04000A35 RID: 2613
			JoystickAxisSensitivity,
			// Token: 0x04000A36 RID: 2614
			MouseXYAxisSensitivity
		}
	}
}
