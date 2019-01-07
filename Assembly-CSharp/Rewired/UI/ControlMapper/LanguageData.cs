using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000138 RID: 312
	public class LanguageData : ScriptableObject
	{
		// Token: 0x060030FE RID: 12542 RVA: 0x0001592B File Offset: 0x00013B2B
		public void Initialize()
		{
			if (this._initialized)
			{
				return;
			}
			this.customDict = LanguageData.CustomEntry.ToDictionary(this._customEntries);
			this._initialized = true;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x001452C4 File Offset: 0x001434C4
		public string GetCustomEntry(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				return string.Empty;
			}
			string result;
			if (!this.customDict.TryGetValue(key, out result))
			{
				return string.Empty;
			}
			return result;
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x0001594E File Offset: 0x00013B4E
		public bool ContainsCustomEntryKey(string key)
		{
			return !string.IsNullOrEmpty(key) && this.customDict.ContainsKey(key);
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x00015966 File Offset: 0x00013B66
		public string yes
		{
			get
			{
				return this._yes;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x0001596E File Offset: 0x00013B6E
		public string no
		{
			get
			{
				return this._no;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x00015976 File Offset: 0x00013B76
		public string add
		{
			get
			{
				return this._add;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x0001597E File Offset: 0x00013B7E
		public string replace
		{
			get
			{
				return this._replace;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x00015986 File Offset: 0x00013B86
		public string remove
		{
			get
			{
				return this._remove;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x0001598E File Offset: 0x00013B8E
		public string swap
		{
			get
			{
				return this._swap;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x00015996 File Offset: 0x00013B96
		public string cancel
		{
			get
			{
				return this._cancel;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x0001599E File Offset: 0x00013B9E
		public string none
		{
			get
			{
				return this._none;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000159A6 File Offset: 0x00013BA6
		public string okay
		{
			get
			{
				return this._okay;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x000159AE File Offset: 0x00013BAE
		public string done
		{
			get
			{
				return this._done;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000159B6 File Offset: 0x00013BB6
		public string default_
		{
			get
			{
				return this._default;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x000159BE File Offset: 0x00013BBE
		public string assignControllerWindowTitle
		{
			get
			{
				return this._assignControllerWindowTitle;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x000159C6 File Offset: 0x00013BC6
		public string assignControllerWindowMessage
		{
			get
			{
				return this._assignControllerWindowMessage;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x000159CE File Offset: 0x00013BCE
		public string controllerAssignmentConflictWindowTitle
		{
			get
			{
				return this._controllerAssignmentConflictWindowTitle;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x000159D6 File Offset: 0x00013BD6
		public string elementAssignmentPrePollingWindowMessage
		{
			get
			{
				return this._elementAssignmentPrePollingWindowMessage;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x000159DE File Offset: 0x00013BDE
		public string elementAssignmentConflictWindowMessage
		{
			get
			{
				return this._elementAssignmentConflictWindowMessage;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x000159E6 File Offset: 0x00013BE6
		public string mouseAssignmentConflictWindowTitle
		{
			get
			{
				return this._mouseAssignmentConflictWindowTitle;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x000159EE File Offset: 0x00013BEE
		public string calibrateControllerWindowTitle
		{
			get
			{
				return this._calibrateControllerWindowTitle;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x000159F6 File Offset: 0x00013BF6
		public string calibrateAxisStep1WindowTitle
		{
			get
			{
				return this._calibrateAxisStep1WindowTitle;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x000159FE File Offset: 0x00013BFE
		public string calibrateAxisStep2WindowTitle
		{
			get
			{
				return this._calibrateAxisStep2WindowTitle;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x00015A06 File Offset: 0x00013C06
		public string inputBehaviorSettingsWindowTitle
		{
			get
			{
				return this._inputBehaviorSettingsWindowTitle;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x00015A0E File Offset: 0x00013C0E
		public string restoreDefaultsWindowTitle
		{
			get
			{
				return this._restoreDefaultsWindowTitle;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x00015A16 File Offset: 0x00013C16
		public string actionColumnLabel
		{
			get
			{
				return this._actionColumnLabel;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x00015A1E File Offset: 0x00013C1E
		public string keyboardColumnLabel
		{
			get
			{
				return this._keyboardColumnLabel;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x00015A26 File Offset: 0x00013C26
		public string mouseColumnLabel
		{
			get
			{
				return this._mouseColumnLabel;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x00015A2E File Offset: 0x00013C2E
		public string controllerColumnLabel
		{
			get
			{
				return this._controllerColumnLabel;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x00015A36 File Offset: 0x00013C36
		public string removeControllerButtonLabel
		{
			get
			{
				return this._removeControllerButtonLabel;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x00015A3E File Offset: 0x00013C3E
		public string calibrateControllerButtonLabel
		{
			get
			{
				return this._calibrateControllerButtonLabel;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x00015A46 File Offset: 0x00013C46
		public string assignControllerButtonLabel
		{
			get
			{
				return this._assignControllerButtonLabel;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x00015A4E File Offset: 0x00013C4E
		public string inputBehaviorSettingsButtonLabel
		{
			get
			{
				return this._inputBehaviorSettingsButtonLabel;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x00015A56 File Offset: 0x00013C56
		public string doneButtonLabel
		{
			get
			{
				return this._doneButtonLabel;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x00015A5E File Offset: 0x00013C5E
		public string restoreDefaultsButtonLabel
		{
			get
			{
				return this._restoreDefaultsButtonLabel;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x00015A66 File Offset: 0x00013C66
		public string controllerSettingsGroupLabel
		{
			get
			{
				return this._controllerSettingsGroupLabel;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x00015A6E File Offset: 0x00013C6E
		public string playersGroupLabel
		{
			get
			{
				return this._playersGroupLabel;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x00015A76 File Offset: 0x00013C76
		public string assignedControllersGroupLabel
		{
			get
			{
				return this._assignedControllersGroupLabel;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x00015A7E File Offset: 0x00013C7E
		public string settingsGroupLabel
		{
			get
			{
				return this._settingsGroupLabel;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x00015A86 File Offset: 0x00013C86
		public string mapCategoriesGroupLabel
		{
			get
			{
				return this._mapCategoriesGroupLabel;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x00015A8E File Offset: 0x00013C8E
		public string restoreDefaultsWindowMessage
		{
			get
			{
				if (ReInput.players.playerCount > 1)
				{
					return this._restoreDefaultsWindowMessage_multiPlayer;
				}
				return this._restoreDefaultsWindowMessage_onePlayer;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x00015AAA File Offset: 0x00013CAA
		public string calibrateWindow_deadZoneSliderLabel
		{
			get
			{
				return this._calibrateWindow_deadZoneSliderLabel;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x00015AB2 File Offset: 0x00013CB2
		public string calibrateWindow_zeroSliderLabel
		{
			get
			{
				return this._calibrateWindow_zeroSliderLabel;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x00015ABA File Offset: 0x00013CBA
		public string calibrateWindow_sensitivitySliderLabel
		{
			get
			{
				return this._calibrateWindow_sensitivitySliderLabel;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x00015AC2 File Offset: 0x00013CC2
		public string calibrateWindow_invertToggleLabel
		{
			get
			{
				return this._calibrateWindow_invertToggleLabel;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x00015ACA File Offset: 0x00013CCA
		public string calibrateWindow_calibrateButtonLabel
		{
			get
			{
				return this._calibrateWindow_calibrateButtonLabel;
			}
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00015AD2 File Offset: 0x00013CD2
		public string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName)
		{
			return string.Format(this._controllerAssignmentConflictWindowMessage, joystickName, otherPlayerName, currentPlayerName);
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00015AE2 File Offset: 0x00013CE2
		public string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(this._joystickElementAssignmentPollingWindowMessage, actionName);
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00015AF0 File Offset: 0x00013CF0
		public string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			return string.Format(this._joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly, actionName);
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00015AFE File Offset: 0x00013CFE
		public string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(this._keyboardElementAssignmentPollingWindowMessage, actionName);
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00015B0C File Offset: 0x00013D0C
		public string GetMouseElementAssignmentPollingWindowMessage(string actionName)
		{
			return string.Format(this._mouseElementAssignmentPollingWindowMessage, actionName);
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x00015B1A File Offset: 0x00013D1A
		public string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
		{
			return string.Format(this._mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly, actionName);
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00015B28 File Offset: 0x00013D28
		public string GetElementAlreadyInUseBlocked(string elementName)
		{
			return string.Format(this._elementAlreadyInUseBlocked, elementName);
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x00015B36 File Offset: 0x00013D36
		public string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts)
		{
			if (!allowConflicts)
			{
				return string.Format(this._elementAlreadyInUseCanReplace, elementName);
			}
			return string.Format(this._elementAlreadyInUseCanReplace_conflictAllowed, elementName);
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00015B54 File Offset: 0x00013D54
		public string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName)
		{
			return string.Format(this._mouseAssignmentConflictWindowMessage, otherPlayerName, thisPlayerName);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00015B63 File Offset: 0x00013D63
		public string GetCalibrateAxisStep1WindowMessage(string axisName)
		{
			return string.Format(this._calibrateAxisStep1WindowMessage, axisName);
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x00015B71 File Offset: 0x00013D71
		public string GetCalibrateAxisStep2WindowMessage(string axisName)
		{
			return string.Format(this._calibrateAxisStep2WindowMessage, axisName);
		}

		// Token: 0x04000A43 RID: 2627
		[SerializeField]
		private string _yes = "Yes";

		// Token: 0x04000A44 RID: 2628
		[SerializeField]
		private string _no = "No";

		// Token: 0x04000A45 RID: 2629
		[SerializeField]
		private string _add = "Add";

		// Token: 0x04000A46 RID: 2630
		[SerializeField]
		private string _replace = "Replace";

		// Token: 0x04000A47 RID: 2631
		[SerializeField]
		private string _remove = "Remove";

		// Token: 0x04000A48 RID: 2632
		[SerializeField]
		private string _swap = "Swap";

		// Token: 0x04000A49 RID: 2633
		[SerializeField]
		private string _cancel = "Cancel";

		// Token: 0x04000A4A RID: 2634
		[SerializeField]
		private string _none = "None";

		// Token: 0x04000A4B RID: 2635
		[SerializeField]
		private string _okay = "Okay";

		// Token: 0x04000A4C RID: 2636
		[SerializeField]
		private string _done = "Done";

		// Token: 0x04000A4D RID: 2637
		[SerializeField]
		private string _default = "Default";

		// Token: 0x04000A4E RID: 2638
		[SerializeField]
		private string _assignControllerWindowTitle = "Choose Controller";

		// Token: 0x04000A4F RID: 2639
		[SerializeField]
		private string _assignControllerWindowMessage = "Press any button or move an axis on the controller you would like to use.";

		// Token: 0x04000A50 RID: 2640
		[SerializeField]
		private string _controllerAssignmentConflictWindowTitle = "Controller Assignment";

		// Token: 0x04000A51 RID: 2641
		[Tooltip("{0} = Joystick Name\n{1} = Other Player Name\n{2} = This Player Name")]
		[SerializeField]
		private string _controllerAssignmentConflictWindowMessage = "{0} is already assigned to {1}. Do you want to assign this controller to {2} instead?";

		// Token: 0x04000A52 RID: 2642
		[SerializeField]
		private string _elementAssignmentPrePollingWindowMessage = "First center or zero all sticks and axes and press any button or wait for the timer to finish.";

		// Token: 0x04000A53 RID: 2643
		[SerializeField]
		[Tooltip("{0} = Action Name")]
		private string _joystickElementAssignmentPollingWindowMessage = "Now press a button or move an axis to assign it to {0}.";

		// Token: 0x04000A54 RID: 2644
		[SerializeField]
		[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.\n{0} = Action Name")]
		private string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly = "Now move an axis to assign it to {0}.";

		// Token: 0x04000A55 RID: 2645
		[SerializeField]
		[Tooltip("{0} = Action Name")]
		private string _keyboardElementAssignmentPollingWindowMessage = "Press a key to assign it to {0}. Modifier keys may also be used. To assign a modifier key alone, hold it down for 1 second.";

		// Token: 0x04000A56 RID: 2646
		[SerializeField]
		[Tooltip("{0} = Action Name")]
		private string _mouseElementAssignmentPollingWindowMessage = "Press a mouse button or move an axis to assign it to {0}.";

		// Token: 0x04000A57 RID: 2647
		[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.\n{0} = Action Name")]
		[SerializeField]
		private string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly = "Move an axis to assign it to {0}.";

		// Token: 0x04000A58 RID: 2648
		[SerializeField]
		private string _elementAssignmentConflictWindowMessage = "Assignment Conflict";

		// Token: 0x04000A59 RID: 2649
		[SerializeField]
		[Tooltip("{0} = Element Name")]
		private string _elementAlreadyInUseBlocked = "{0} is already in use cannot be replaced.";

		// Token: 0x04000A5A RID: 2650
		[Tooltip("{0} = Element Name")]
		[SerializeField]
		private string _elementAlreadyInUseCanReplace = "{0} is already in use. Do you want to replace it?";

		// Token: 0x04000A5B RID: 2651
		[Tooltip("{0} = Element Name")]
		[SerializeField]
		private string _elementAlreadyInUseCanReplace_conflictAllowed = "{0} is already in use. Do you want to replace it? You may also choose to add the assignment anyway.";

		// Token: 0x04000A5C RID: 2652
		[SerializeField]
		private string _mouseAssignmentConflictWindowTitle = "Mouse Assignment";

		// Token: 0x04000A5D RID: 2653
		[Tooltip("{0} = Other Player Name\n{1} = This Player Name")]
		[SerializeField]
		private string _mouseAssignmentConflictWindowMessage = "The mouse is already assigned to {0}. Do you want to assign the mouse to {1} instead?";

		// Token: 0x04000A5E RID: 2654
		[SerializeField]
		private string _calibrateControllerWindowTitle = "Calibrate Controller";

		// Token: 0x04000A5F RID: 2655
		[SerializeField]
		private string _calibrateAxisStep1WindowTitle = "Calibrate Zero";

		// Token: 0x04000A60 RID: 2656
		[Tooltip("{0} = Axis Name")]
		[SerializeField]
		private string _calibrateAxisStep1WindowMessage = "Center or zero {0} and press any button or wait for the timer to finish.";

		// Token: 0x04000A61 RID: 2657
		[SerializeField]
		private string _calibrateAxisStep2WindowTitle = "Calibrate Range";

		// Token: 0x04000A62 RID: 2658
		[Tooltip("{0} = Axis Name")]
		[SerializeField]
		private string _calibrateAxisStep2WindowMessage = "Move {0} through its entire range then press any button or wait for the timer to finish.";

		// Token: 0x04000A63 RID: 2659
		[SerializeField]
		private string _inputBehaviorSettingsWindowTitle = "Sensitivity Settings";

		// Token: 0x04000A64 RID: 2660
		[SerializeField]
		private string _restoreDefaultsWindowTitle = "Restore Defaults";

		// Token: 0x04000A65 RID: 2661
		[SerializeField]
		[Tooltip("Message for a single player game.")]
		private string _restoreDefaultsWindowMessage_onePlayer = "This will restore the default input configuration. Are you sure you want to do this?";

		// Token: 0x04000A66 RID: 2662
		[SerializeField]
		[Tooltip("Message for a multi-player game.")]
		private string _restoreDefaultsWindowMessage_multiPlayer = "This will restore the default input configuration for all players. Are you sure you want to do this?";

		// Token: 0x04000A67 RID: 2663
		[SerializeField]
		private string _actionColumnLabel = "Actions";

		// Token: 0x04000A68 RID: 2664
		[SerializeField]
		private string _keyboardColumnLabel = "Keyboard";

		// Token: 0x04000A69 RID: 2665
		[SerializeField]
		private string _mouseColumnLabel = "Mouse";

		// Token: 0x04000A6A RID: 2666
		[SerializeField]
		private string _controllerColumnLabel = "Controller";

		// Token: 0x04000A6B RID: 2667
		[SerializeField]
		private string _removeControllerButtonLabel = "Remove";

		// Token: 0x04000A6C RID: 2668
		[SerializeField]
		private string _calibrateControllerButtonLabel = "Calibrate";

		// Token: 0x04000A6D RID: 2669
		[SerializeField]
		private string _assignControllerButtonLabel = "Assign Controller";

		// Token: 0x04000A6E RID: 2670
		[SerializeField]
		private string _inputBehaviorSettingsButtonLabel = "Sensitivity";

		// Token: 0x04000A6F RID: 2671
		[SerializeField]
		private string _doneButtonLabel = "Done";

		// Token: 0x04000A70 RID: 2672
		[SerializeField]
		private string _restoreDefaultsButtonLabel = "Restore Defaults";

		// Token: 0x04000A71 RID: 2673
		[SerializeField]
		private string _playersGroupLabel = "Players:";

		// Token: 0x04000A72 RID: 2674
		[SerializeField]
		private string _controllerSettingsGroupLabel = "Controller:";

		// Token: 0x04000A73 RID: 2675
		[SerializeField]
		private string _assignedControllersGroupLabel = "Assigned Controllers:";

		// Token: 0x04000A74 RID: 2676
		[SerializeField]
		private string _settingsGroupLabel = "Settings:";

		// Token: 0x04000A75 RID: 2677
		[SerializeField]
		private string _mapCategoriesGroupLabel = "Categories:";

		// Token: 0x04000A76 RID: 2678
		[SerializeField]
		private string _calibrateWindow_deadZoneSliderLabel = "Dead Zone:";

		// Token: 0x04000A77 RID: 2679
		[SerializeField]
		private string _calibrateWindow_zeroSliderLabel = "Zero:";

		// Token: 0x04000A78 RID: 2680
		[SerializeField]
		private string _calibrateWindow_sensitivitySliderLabel = "Sensitivity:";

		// Token: 0x04000A79 RID: 2681
		[SerializeField]
		private string _calibrateWindow_invertToggleLabel = "Invert";

		// Token: 0x04000A7A RID: 2682
		[SerializeField]
		private string _calibrateWindow_calibrateButtonLabel = "Calibrate";

		// Token: 0x04000A7B RID: 2683
		[SerializeField]
		private LanguageData.CustomEntry[] _customEntries;

		// Token: 0x04000A7C RID: 2684
		private bool _initialized;

		// Token: 0x04000A7D RID: 2685
		private Dictionary<string, string> customDict;

		// Token: 0x02000139 RID: 313
		[Serializable]
		private class CustomEntry
		{
			// Token: 0x06003138 RID: 12600 RVA: 0x0000306E File Offset: 0x0000126E
			public CustomEntry()
			{
			}

			// Token: 0x06003139 RID: 12601 RVA: 0x00015B7F File Offset: 0x00013D7F
			public CustomEntry(string key, string value)
			{
				this.key = key;
				this.value = value;
			}

			// Token: 0x0600313A RID: 12602 RVA: 0x00145574 File Offset: 0x00143774
			public static Dictionary<string, string> ToDictionary(LanguageData.CustomEntry[] array)
			{
				if (array == null)
				{
					return new Dictionary<string, string>();
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && !string.IsNullOrEmpty(array[i].key) && !string.IsNullOrEmpty(array[i].value))
					{
						if (dictionary.ContainsKey(array[i].key))
						{
							Debug.LogError("Key \"" + array[i].key + "\" is already in dictionary!");
						}
						else
						{
							dictionary.Add(array[i].key, array[i].value);
						}
					}
				}
				return dictionary;
			}

			// Token: 0x04000A7E RID: 2686
			public string key;

			// Token: 0x04000A7F RID: 2687
			public string value;
		}
	}
}
