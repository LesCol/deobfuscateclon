using System;
using System.Collections.Generic;
using Rewired.Integration.UnityUI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000102 RID: 258
	[AddComponentMenu("")]
	public class CalibrationWindow : Window
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x00013006 File Offset: 0x00011206
		private bool axisSelected
		{
			get
			{
				return this.joystick != null && (this.selectedAxis >= 0 && this.selectedAxis < this.joystick.calibrationMap.axisCount);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x00013036 File Offset: 0x00011236
		private AxisCalibration axisCalibration
		{
			get
			{
				if (!this.axisSelected)
				{
					return null;
				}
				return this.joystick.calibrationMap.GetAxis(this.selectedAxis);
			}
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x0013C54C File Offset: 0x0013A74C
		public override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
			if (!(this.rightContentContainer == null) && !(this.valueDisplayGroup == null) && !(this.calibratedValueMarker == null) && !(this.rawValueMarker == null) && !(this.calibratedZeroMarker == null) && !(this.deadzoneArea == null) && !(this.deadzoneSlider == null) && !(this.sensitivitySlider == null) && !(this.zeroSlider == null) && !(this.invertToggle == null) && !(this.axisScrollAreaContent == null) && !(this.doneButton == null) && !(this.calibrateButton == null) && !(this.axisButtonPrefab == null) && !(this.doneButtonLabel == null) && !(this.cancelButtonLabel == null) && !(this.defaultButtonLabel == null) && !(this.deadzoneSliderLabel == null) && !(this.zeroSliderLabel == null) && !(this.sensitivitySliderLabel == null) && !(this.invertToggleLabel == null) && !(this.calibrateButtonLabel == null))
			{
				this.axisButtons = new List<Button>();
				this.buttonCallbacks = new Dictionary<int, Action<int>>();
				this.doneButtonLabel.text = ControlMapper.GetLanguage().done;
				this.cancelButtonLabel.text = ControlMapper.GetLanguage().cancel;
				this.defaultButtonLabel.text = ControlMapper.GetLanguage().default_;
				this.deadzoneSliderLabel.text = ControlMapper.GetLanguage().calibrateWindow_deadZoneSliderLabel;
				this.zeroSliderLabel.text = ControlMapper.GetLanguage().calibrateWindow_zeroSliderLabel;
				this.sensitivitySliderLabel.text = ControlMapper.GetLanguage().calibrateWindow_sensitivitySliderLabel;
				this.invertToggleLabel.text = ControlMapper.GetLanguage().calibrateWindow_invertToggleLabel;
				this.calibrateButtonLabel.text = ControlMapper.GetLanguage().calibrateWindow_calibrateButtonLabel;
				base.Initialize(id, isFocusedCallback);
				return;
			}
			Debug.LogError("Rewired Control Mapper: All inspector values must be assigned!");
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x0013C7A0 File Offset: 0x0013A9A0
		public void SetJoystick(int playerId, Joystick joystick)
		{
			if (!base.initialized)
			{
				return;
			}
			this.playerId = playerId;
			this.joystick = joystick;
			if (joystick == null)
			{
				Debug.LogError("Rewired Control Mapper: Joystick cannot be null!");
				return;
			}
			float num = 0f;
			for (int i = 0; i < joystick.axisCount; i++)
			{
				int index = i;
				GameObject gameObject = UITools.InstantiateGUIObject<Button>(this.axisButtonPrefab, this.axisScrollAreaContent, "Axis" + i);
				Button button = gameObject.GetComponent<Button>();
				button.onClick.AddListener(delegate()
				{
					this.OnAxisSelected(index, button);
				});
				Text componentInSelfOrChildren = UnityTools.GetComponentInSelfOrChildren<Text>(gameObject);
				if (componentInSelfOrChildren != null)
				{
					componentInSelfOrChildren.text = joystick.AxisElementIdentifiers[i].name;
				}
				if (num == 0f)
				{
					num = UnityTools.GetComponentInSelfOrChildren<LayoutElement>(gameObject).minHeight;
				}
				this.axisButtons.Add(button);
			}
			float spacing = this.axisScrollAreaContent.GetComponent<VerticalLayoutGroup>().spacing;
			this.axisScrollAreaContent.sizeDelta = new Vector2(this.axisScrollAreaContent.sizeDelta.x, Mathf.Max((float)joystick.axisCount * (num + spacing) - spacing, this.axisScrollAreaContent.sizeDelta.y));
			this.origCalibrationData = joystick.calibrationMap.ToXmlString();
			this.displayAreaWidth = this.rightContentContainer.sizeDelta.x;
			this.rewiredStandaloneInputModule = base.gameObject.transform.root.GetComponentInChildren<RewiredStandaloneInputModule>();
			if (this.rewiredStandaloneInputModule != null)
			{
				this.menuHorizActionId = ReInput.mapping.GetActionId(this.rewiredStandaloneInputModule.horizontalAxis);
				this.menuVertActionId = ReInput.mapping.GetActionId(this.rewiredStandaloneInputModule.verticalAxis);
			}
			if (joystick.axisCount > 0)
			{
				this.SelectAxis(0);
			}
			base.defaultUIElement = this.doneButton.gameObject;
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00013058 File Offset: 0x00011258
		public void SetButtonCallback(CalibrationWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
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

		// Token: 0x06002DC6 RID: 11718 RVA: 0x0013C9A8 File Offset: 0x0013ABA8
		public override void Cancel()
		{
			if (!base.initialized)
			{
				return;
			}
			if (this.joystick != null)
			{
				this.joystick.ImportCalibrationMapFromXmlString(this.origCalibrationData);
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

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00013090 File Offset: 0x00011290
		protected override void Update()
		{
			if (!base.initialized)
			{
				return;
			}
			base.Update();
			this.UpdateDisplay();
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x0013CA08 File Offset: 0x0013AC08
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

		// Token: 0x06002DC9 RID: 11721 RVA: 0x000130A7 File Offset: 0x000112A7
		public void OnCancel()
		{
			this.Cancel();
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x000130AF File Offset: 0x000112AF
		public void OnRestoreDefault()
		{
			if (!base.initialized)
			{
				return;
			}
			if (this.joystick == null)
			{
				return;
			}
			this.joystick.calibrationMap.Reset();
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x0013CA3C File Offset: 0x0013AC3C
		public void OnCalibrate()
		{
			if (!base.initialized)
			{
				return;
			}
			Action<int> action;
			if (!this.buttonCallbacks.TryGetValue(3, out action))
			{
				return;
			}
			action(this.selectedAxis);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000130DF File Offset: 0x000112DF
		public void OnInvert(bool state)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.invert = state;
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000130FF File Offset: 0x000112FF
		public void OnZeroValueChange(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.calibratedZero = value;
			this.RedrawCalibratedZero();
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00013125 File Offset: 0x00011325
		public void OnZeroCancel()
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.calibratedZero = this.origSelectedAxisCalibrationData.zero;
			this.RedrawCalibratedZero();
			this.RefreshControls();
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0013CA70 File Offset: 0x0013AC70
		public void OnDeadzoneValueChange(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.deadZone = Mathf.Clamp(value, 0f, 0.8f);
			if (value > 0.8f)
			{
				this.deadzoneSlider.value = 0.8f;
			}
			this.RedrawDeadzone();
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x0001315B File Offset: 0x0001135B
		public void OnDeadzoneCancel()
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.deadZone = this.origSelectedAxisCalibrationData.deadZone;
			this.RedrawDeadzone();
			this.RefreshControls();
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x0013CAC8 File Offset: 0x0013ACC8
		public void OnSensitivityValueChange(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.sensitivity = Mathf.Clamp(value, this.minSensitivity, float.PositiveInfinity);
			if (value < this.minSensitivity)
			{
				this.sensitivitySlider.value = this.minSensitivity;
			}
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00013191 File Offset: 0x00011391
		public void OnSensitivityCancel(float value)
		{
			if (!base.initialized)
			{
				return;
			}
			if (!this.axisSelected)
			{
				return;
			}
			this.axisCalibration.sensitivity = this.origSelectedAxisCalibrationData.sensitivity;
			this.RefreshControls();
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000131C1 File Offset: 0x000113C1
		public void OnAxisScrollRectScroll(Vector2 pos)
		{
			bool initialized = base.initialized;
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000131CA File Offset: 0x000113CA
		private void OnAxisSelected(int axisIndex, Button button)
		{
			if (!base.initialized)
			{
				return;
			}
			if (this.joystick == null)
			{
				return;
			}
			this.SelectAxis(axisIndex);
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000131F1 File Offset: 0x000113F1
		private void UpdateDisplay()
		{
			this.RedrawValueMarkers();
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000131F9 File Offset: 0x000113F9
		private void Redraw()
		{
			this.RedrawCalibratedZero();
			this.RedrawValueMarkers();
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x0013CB20 File Offset: 0x0013AD20
		private void RefreshControls()
		{
			if (!this.axisSelected)
			{
				this.deadzoneSlider.value = 0f;
				this.zeroSlider.value = 0f;
				this.sensitivitySlider.value = 0f;
				this.invertToggle.isOn = false;
				return;
			}
			this.deadzoneSlider.value = this.axisCalibration.deadZone;
			this.zeroSlider.value = this.axisCalibration.calibratedZero;
			this.sensitivitySlider.value = this.axisCalibration.sensitivity;
			this.invertToggle.isOn = this.axisCalibration.invert;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x0013CBCC File Offset: 0x0013ADCC
		private void RedrawDeadzone()
		{
			if (!this.axisSelected)
			{
				return;
			}
			float x = this.displayAreaWidth * this.axisCalibration.deadZone;
			this.deadzoneArea.sizeDelta = new Vector2(x, this.deadzoneArea.sizeDelta.y);
			this.deadzoneArea.anchoredPosition = new Vector2(this.axisCalibration.calibratedZero * -this.deadzoneArea.parent.localPosition.x, this.deadzoneArea.anchoredPosition.y);
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x0013CC58 File Offset: 0x0013AE58
		private void RedrawCalibratedZero()
		{
			if (!this.axisSelected)
			{
				return;
			}
			this.calibratedZeroMarker.anchoredPosition = new Vector2(this.axisCalibration.calibratedZero * -this.deadzoneArea.parent.localPosition.x, this.calibratedZeroMarker.anchoredPosition.y);
			this.RedrawDeadzone();
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x0013CCB8 File Offset: 0x0013AEB8
		private void RedrawValueMarkers()
		{
			if (!this.axisSelected)
			{
				this.calibratedValueMarker.anchoredPosition = new Vector2(0f, this.calibratedValueMarker.anchoredPosition.y);
				this.rawValueMarker.anchoredPosition = new Vector2(0f, this.rawValueMarker.anchoredPosition.y);
				return;
			}
			float axis = this.joystick.GetAxis(this.selectedAxis);
			float num = Mathf.Clamp(this.joystick.GetAxisRaw(this.selectedAxis), -1f, 1f);
			this.calibratedValueMarker.anchoredPosition = new Vector2(this.displayAreaWidth * 0.5f * axis, this.calibratedValueMarker.anchoredPosition.y);
			this.rawValueMarker.anchoredPosition = new Vector2(this.displayAreaWidth * 0.5f * num, this.rawValueMarker.anchoredPosition.y);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x0013CDA8 File Offset: 0x0013AFA8
		private void SelectAxis(int index)
		{
			if (index < 0 || index >= this.axisButtons.Count)
			{
				return;
			}
			if (this.axisButtons[index] == null)
			{
				return;
			}
			this.axisButtons[index].interactable = false;
			this.axisButtons[index].Select();
			for (int i = 0; i < this.axisButtons.Count; i++)
			{
				if (i != index)
				{
					this.axisButtons[i].interactable = true;
				}
			}
			this.selectedAxis = index;
			this.origSelectedAxisCalibrationData = this.axisCalibration.GetData();
			this.SetMinSensitivity();
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00013207 File Offset: 0x00011407
		public override void TakeInputFocus()
		{
			base.TakeInputFocus();
			if (this.selectedAxis >= 0)
			{
				this.SelectAxis(this.selectedAxis);
			}
			this.RefreshControls();
			this.Redraw();
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x0013CE50 File Offset: 0x0013B050
		private void SetMinSensitivity()
		{
			if (!this.axisSelected)
			{
				return;
			}
			this.minSensitivity = 0.1f;
			if (this.rewiredStandaloneInputModule != null)
			{
				if (this.IsMenuAxis(this.menuHorizActionId, this.selectedAxis))
				{
					this.GetAxisButtonDeadZone(this.playerId, this.menuHorizActionId, ref this.minSensitivity);
					return;
				}
				if (this.IsMenuAxis(this.menuVertActionId, this.selectedAxis))
				{
					this.GetAxisButtonDeadZone(this.playerId, this.menuVertActionId, ref this.minSensitivity);
				}
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x0013CED8 File Offset: 0x0013B0D8
		private bool IsMenuAxis(int actionId, int axisIndex)
		{
			if (this.rewiredStandaloneInputModule == null)
			{
				return false;
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			int count = allPlayers.Count;
			for (int i = 0; i < count; i++)
			{
				IList<JoystickMap> maps = allPlayers[i].controllers.maps.GetMaps<JoystickMap>(this.joystick.id);
				if (maps != null)
				{
					int count2 = maps.Count;
					for (int j = 0; j < count2; j++)
					{
						IList<ActionElementMap> axisMaps = maps[j].AxisMaps;
						if (axisMaps != null)
						{
							int count3 = axisMaps.Count;
							for (int k = 0; k < count3; k++)
							{
								ActionElementMap actionElementMap = axisMaps[k];
								if (actionElementMap.actionId == actionId && actionElementMap.elementIndex == axisIndex)
								{
									return true;
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0013CFA8 File Offset: 0x0013B1A8
		private void GetAxisButtonDeadZone(int playerId, int actionId, ref float value)
		{
			InputAction action = ReInput.mapping.GetAction(actionId);
			if (action == null)
			{
				return;
			}
			int behaviorId = action.behaviorId;
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
			if (inputBehavior == null)
			{
				return;
			}
			value = inputBehavior.buttonDeadZone + 0.1f;
		}

		// Token: 0x040008B2 RID: 2226
		private const float minSensitivityOtherAxes = 0.1f;

		// Token: 0x040008B3 RID: 2227
		private const float maxDeadzone = 0.8f;

		// Token: 0x040008B4 RID: 2228
		[SerializeField]
		private RectTransform rightContentContainer;

		// Token: 0x040008B5 RID: 2229
		[SerializeField]
		private RectTransform valueDisplayGroup;

		// Token: 0x040008B6 RID: 2230
		[SerializeField]
		private RectTransform calibratedValueMarker;

		// Token: 0x040008B7 RID: 2231
		[SerializeField]
		private RectTransform rawValueMarker;

		// Token: 0x040008B8 RID: 2232
		[SerializeField]
		private RectTransform calibratedZeroMarker;

		// Token: 0x040008B9 RID: 2233
		[SerializeField]
		private RectTransform deadzoneArea;

		// Token: 0x040008BA RID: 2234
		[SerializeField]
		private Slider deadzoneSlider;

		// Token: 0x040008BB RID: 2235
		[SerializeField]
		private Slider zeroSlider;

		// Token: 0x040008BC RID: 2236
		[SerializeField]
		private Slider sensitivitySlider;

		// Token: 0x040008BD RID: 2237
		[SerializeField]
		private Toggle invertToggle;

		// Token: 0x040008BE RID: 2238
		[SerializeField]
		private RectTransform axisScrollAreaContent;

		// Token: 0x040008BF RID: 2239
		[SerializeField]
		private Button doneButton;

		// Token: 0x040008C0 RID: 2240
		[SerializeField]
		private Button calibrateButton;

		// Token: 0x040008C1 RID: 2241
		[SerializeField]
		private Text doneButtonLabel;

		// Token: 0x040008C2 RID: 2242
		[SerializeField]
		private Text cancelButtonLabel;

		// Token: 0x040008C3 RID: 2243
		[SerializeField]
		private Text defaultButtonLabel;

		// Token: 0x040008C4 RID: 2244
		[SerializeField]
		private Text deadzoneSliderLabel;

		// Token: 0x040008C5 RID: 2245
		[SerializeField]
		private Text zeroSliderLabel;

		// Token: 0x040008C6 RID: 2246
		[SerializeField]
		private Text sensitivitySliderLabel;

		// Token: 0x040008C7 RID: 2247
		[SerializeField]
		private Text invertToggleLabel;

		// Token: 0x040008C8 RID: 2248
		[SerializeField]
		private Text calibrateButtonLabel;

		// Token: 0x040008C9 RID: 2249
		[SerializeField]
		private GameObject axisButtonPrefab;

		// Token: 0x040008CA RID: 2250
		private Joystick joystick;

		// Token: 0x040008CB RID: 2251
		private string origCalibrationData;

		// Token: 0x040008CC RID: 2252
		private int selectedAxis = -1;

		// Token: 0x040008CD RID: 2253
		private AxisCalibrationData origSelectedAxisCalibrationData;

		// Token: 0x040008CE RID: 2254
		private float displayAreaWidth;

		// Token: 0x040008CF RID: 2255
		private List<Button> axisButtons;

		// Token: 0x040008D0 RID: 2256
		private Dictionary<int, Action<int>> buttonCallbacks;

		// Token: 0x040008D1 RID: 2257
		private int playerId;

		// Token: 0x040008D2 RID: 2258
		private RewiredStandaloneInputModule rewiredStandaloneInputModule;

		// Token: 0x040008D3 RID: 2259
		private int menuHorizActionId = -1;

		// Token: 0x040008D4 RID: 2260
		private int menuVertActionId = -1;

		// Token: 0x040008D5 RID: 2261
		private float minSensitivity;

		// Token: 0x02000103 RID: 259
		public enum ButtonIdentifier
		{
			// Token: 0x040008D7 RID: 2263
			Done,
			// Token: 0x040008D8 RID: 2264
			Cancel,
			// Token: 0x040008D9 RID: 2265
			Default,
			// Token: 0x040008DA RID: 2266
			Calibrate
		}
	}
}
