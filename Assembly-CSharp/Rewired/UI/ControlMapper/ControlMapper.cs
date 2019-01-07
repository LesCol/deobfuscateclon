using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000108 RID: 264
	[AddComponentMenu("")]
	public class ControlMapper : MonoBehaviour
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06002DEA RID: 11754 RVA: 0x000132CD File Offset: 0x000114CD
		// (remove) Token: 0x06002DEB RID: 11755 RVA: 0x000132E6 File Offset: 0x000114E6
		public event Action ScreenClosedEvent
		{
			add
			{
				this._ScreenClosedEvent = (Action)Delegate.Combine(this._ScreenClosedEvent, value);
			}
			remove
			{
				this._ScreenClosedEvent = (Action)Delegate.Remove(this._ScreenClosedEvent, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06002DEC RID: 11756 RVA: 0x000132FF File Offset: 0x000114FF
		// (remove) Token: 0x06002DED RID: 11757 RVA: 0x00013318 File Offset: 0x00011518
		public event Action ScreenOpenedEvent
		{
			add
			{
				this._ScreenOpenedEvent = (Action)Delegate.Combine(this._ScreenOpenedEvent, value);
			}
			remove
			{
				this._ScreenOpenedEvent = (Action)Delegate.Remove(this._ScreenOpenedEvent, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06002DEE RID: 11758 RVA: 0x00013331 File Offset: 0x00011531
		// (remove) Token: 0x06002DEF RID: 11759 RVA: 0x0001334A File Offset: 0x0001154A
		public event Action PopupWindowClosedEvent
		{
			add
			{
				this._PopupWindowClosedEvent = (Action)Delegate.Combine(this._PopupWindowClosedEvent, value);
			}
			remove
			{
				this._PopupWindowClosedEvent = (Action)Delegate.Remove(this._PopupWindowClosedEvent, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06002DF0 RID: 11760 RVA: 0x00013363 File Offset: 0x00011563
		// (remove) Token: 0x06002DF1 RID: 11761 RVA: 0x0001337C File Offset: 0x0001157C
		public event Action PopupWindowOpenedEvent
		{
			add
			{
				this._PopupWindowOpenedEvent = (Action)Delegate.Combine(this._PopupWindowOpenedEvent, value);
			}
			remove
			{
				this._PopupWindowOpenedEvent = (Action)Delegate.Remove(this._PopupWindowOpenedEvent, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06002DF2 RID: 11762 RVA: 0x00013395 File Offset: 0x00011595
		// (remove) Token: 0x06002DF3 RID: 11763 RVA: 0x000133AE File Offset: 0x000115AE
		public event Action InputPollingStartedEvent
		{
			add
			{
				this._InputPollingStartedEvent = (Action)Delegate.Combine(this._InputPollingStartedEvent, value);
			}
			remove
			{
				this._InputPollingStartedEvent = (Action)Delegate.Remove(this._InputPollingStartedEvent, value);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06002DF4 RID: 11764 RVA: 0x000133C7 File Offset: 0x000115C7
		// (remove) Token: 0x06002DF5 RID: 11765 RVA: 0x000133E0 File Offset: 0x000115E0
		public event Action InputPollingEndedEvent
		{
			add
			{
				this._InputPollingEndedEvent = (Action)Delegate.Combine(this._InputPollingEndedEvent, value);
			}
			remove
			{
				this._InputPollingEndedEvent = (Action)Delegate.Remove(this._InputPollingEndedEvent, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06002DF6 RID: 11766 RVA: 0x000133F9 File Offset: 0x000115F9
		// (remove) Token: 0x06002DF7 RID: 11767 RVA: 0x00013407 File Offset: 0x00011607
		public event UnityAction onScreenClosed
		{
			add
			{
				this._onScreenClosed.AddListener(value);
			}
			remove
			{
				this._onScreenClosed.RemoveListener(value);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06002DF8 RID: 11768 RVA: 0x00013415 File Offset: 0x00011615
		// (remove) Token: 0x06002DF9 RID: 11769 RVA: 0x00013423 File Offset: 0x00011623
		public event UnityAction onScreenOpened
		{
			add
			{
				this._onScreenOpened.AddListener(value);
			}
			remove
			{
				this._onScreenOpened.RemoveListener(value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06002DFA RID: 11770 RVA: 0x00013431 File Offset: 0x00011631
		// (remove) Token: 0x06002DFB RID: 11771 RVA: 0x0001343F File Offset: 0x0001163F
		public event UnityAction onPopupWindowClosed
		{
			add
			{
				this._onPopupWindowClosed.AddListener(value);
			}
			remove
			{
				this._onPopupWindowClosed.RemoveListener(value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06002DFC RID: 11772 RVA: 0x0001344D File Offset: 0x0001164D
		// (remove) Token: 0x06002DFD RID: 11773 RVA: 0x0001345B File Offset: 0x0001165B
		public event UnityAction onPopupWindowOpened
		{
			add
			{
				this._onPopupWindowOpened.AddListener(value);
			}
			remove
			{
				this._onPopupWindowOpened.RemoveListener(value);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06002DFE RID: 11774 RVA: 0x00013469 File Offset: 0x00011669
		// (remove) Token: 0x06002DFF RID: 11775 RVA: 0x00013477 File Offset: 0x00011677
		public event UnityAction onInputPollingStarted
		{
			add
			{
				this._onInputPollingStarted.AddListener(value);
			}
			remove
			{
				this._onInputPollingStarted.RemoveListener(value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06002E00 RID: 11776 RVA: 0x00013485 File Offset: 0x00011685
		// (remove) Token: 0x06002E01 RID: 11777 RVA: 0x00013493 File Offset: 0x00011693
		public event UnityAction onInputPollingEnded
		{
			add
			{
				this._onInputPollingEnded.AddListener(value);
			}
			remove
			{
				this._onInputPollingEnded.RemoveListener(value);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000134A1 File Offset: 0x000116A1
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x000134A9 File Offset: 0x000116A9
		public InputManager rewiredInputManager
		{
			get
			{
				return this._rewiredInputManager;
			}
			set
			{
				this._rewiredInputManager = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x000134B9 File Offset: 0x000116B9
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x000134C1 File Offset: 0x000116C1
		public bool dontDestroyOnLoad
		{
			get
			{
				return this._dontDestroyOnLoad;
			}
			set
			{
				if (value != this._dontDestroyOnLoad && value)
				{
					UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
				}
				this._dontDestroyOnLoad = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x000134E6 File Offset: 0x000116E6
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x000134EE File Offset: 0x000116EE
		public int keyboardMapDefaultLayout
		{
			get
			{
				return this._keyboardMapDefaultLayout;
			}
			set
			{
				this._keyboardMapDefaultLayout = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x000134FE File Offset: 0x000116FE
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x00013506 File Offset: 0x00011706
		public int mouseMapDefaultLayout
		{
			get
			{
				return this._mouseMapDefaultLayout;
			}
			set
			{
				this._mouseMapDefaultLayout = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x00013516 File Offset: 0x00011716
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x0001351E File Offset: 0x0001171E
		public int joystickMapDefaultLayout
		{
			get
			{
				return this._joystickMapDefaultLayout;
			}
			set
			{
				this._joystickMapDefaultLayout = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x0001352E File Offset: 0x0001172E
		// (set) Token: 0x06002E0D RID: 11789 RVA: 0x00013547 File Offset: 0x00011747
		public bool showPlayers
		{
			get
			{
				return this._showPlayers && ReInput.players.playerCount > 1;
			}
			set
			{
				this._showPlayers = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x00013557 File Offset: 0x00011757
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x0001355F File Offset: 0x0001175F
		public bool showControllers
		{
			get
			{
				return this._showControllers;
			}
			set
			{
				this._showControllers = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x0001356F File Offset: 0x0001176F
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x00013577 File Offset: 0x00011777
		public bool showKeyboard
		{
			get
			{
				return this._showKeyboard;
			}
			set
			{
				this._showKeyboard = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x00013587 File Offset: 0x00011787
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x0001358F File Offset: 0x0001178F
		public bool showMouse
		{
			get
			{
				return this._showMouse;
			}
			set
			{
				this._showMouse = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x0001359F File Offset: 0x0001179F
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x000135A7 File Offset: 0x000117A7
		public int maxControllersPerPlayer
		{
			get
			{
				return this._maxControllersPerPlayer;
			}
			set
			{
				this._maxControllersPerPlayer = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000135B7 File Offset: 0x000117B7
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x000135BF File Offset: 0x000117BF
		public bool showActionCategoryLabels
		{
			get
			{
				return this._showActionCategoryLabels;
			}
			set
			{
				this._showActionCategoryLabels = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000135CF File Offset: 0x000117CF
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x000135D7 File Offset: 0x000117D7
		public int keyboardInputFieldCount
		{
			get
			{
				return this._keyboardInputFieldCount;
			}
			set
			{
				this._keyboardInputFieldCount = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000135E7 File Offset: 0x000117E7
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x000135EF File Offset: 0x000117EF
		public int mouseInputFieldCount
		{
			get
			{
				return this._mouseInputFieldCount;
			}
			set
			{
				this._mouseInputFieldCount = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000135FF File Offset: 0x000117FF
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00013607 File Offset: 0x00011807
		public int controllerInputFieldCount
		{
			get
			{
				return this._controllerInputFieldCount;
			}
			set
			{
				this._controllerInputFieldCount = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x00013617 File Offset: 0x00011817
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x0001361F File Offset: 0x0001181F
		public bool showFullAxisInputFields
		{
			get
			{
				return this._showFullAxisInputFields;
			}
			set
			{
				this._showFullAxisInputFields = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x0001362F File Offset: 0x0001182F
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x00013637 File Offset: 0x00011837
		public bool showSplitAxisInputFields
		{
			get
			{
				return this._showSplitAxisInputFields;
			}
			set
			{
				this._showSplitAxisInputFields = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x00013647 File Offset: 0x00011847
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x0001364F File Offset: 0x0001184F
		public bool allowElementAssignmentConflicts
		{
			get
			{
				return this._allowElementAssignmentConflicts;
			}
			set
			{
				this._allowElementAssignmentConflicts = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x0001365F File Offset: 0x0001185F
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00013667 File Offset: 0x00011867
		public bool allowElementAssignmentSwap
		{
			get
			{
				return this._allowElementAssignmentSwap;
			}
			set
			{
				this._allowElementAssignmentSwap = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x00013677 File Offset: 0x00011877
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x0001367F File Offset: 0x0001187F
		public int actionLabelWidth
		{
			get
			{
				return this._actionLabelWidth;
			}
			set
			{
				this._actionLabelWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x0001368F File Offset: 0x0001188F
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x00013697 File Offset: 0x00011897
		public int keyboardColMaxWidth
		{
			get
			{
				return this._keyboardColMaxWidth;
			}
			set
			{
				this._keyboardColMaxWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000136A7 File Offset: 0x000118A7
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x000136AF File Offset: 0x000118AF
		public int mouseColMaxWidth
		{
			get
			{
				return this._mouseColMaxWidth;
			}
			set
			{
				this._mouseColMaxWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000136BF File Offset: 0x000118BF
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x000136C7 File Offset: 0x000118C7
		public int controllerColMaxWidth
		{
			get
			{
				return this._controllerColMaxWidth;
			}
			set
			{
				this._controllerColMaxWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000136D7 File Offset: 0x000118D7
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x000136DF File Offset: 0x000118DF
		public int inputRowHeight
		{
			get
			{
				return this._inputRowHeight;
			}
			set
			{
				this._inputRowHeight = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x000136EF File Offset: 0x000118EF
		// (set) Token: 0x06002E31 RID: 11825 RVA: 0x000136F7 File Offset: 0x000118F7
		public int inputColumnSpacing
		{
			get
			{
				return this._inputColumnSpacing;
			}
			set
			{
				this._inputColumnSpacing = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x00013707 File Offset: 0x00011907
		// (set) Token: 0x06002E33 RID: 11827 RVA: 0x0001370F File Offset: 0x0001190F
		public int inputRowCategorySpacing
		{
			get
			{
				return this._inputRowCategorySpacing;
			}
			set
			{
				this._inputRowCategorySpacing = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x0001371F File Offset: 0x0001191F
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x00013727 File Offset: 0x00011927
		public int invertToggleWidth
		{
			get
			{
				return this._invertToggleWidth;
			}
			set
			{
				this._invertToggleWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x00013737 File Offset: 0x00011937
		// (set) Token: 0x06002E37 RID: 11831 RVA: 0x0001373F File Offset: 0x0001193F
		public int defaultWindowWidth
		{
			get
			{
				return this._defaultWindowWidth;
			}
			set
			{
				this._defaultWindowWidth = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x0001374F File Offset: 0x0001194F
		// (set) Token: 0x06002E39 RID: 11833 RVA: 0x00013757 File Offset: 0x00011957
		public int defaultWindowHeight
		{
			get
			{
				return this._defaultWindowHeight;
			}
			set
			{
				this._defaultWindowHeight = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x00013767 File Offset: 0x00011967
		// (set) Token: 0x06002E3B RID: 11835 RVA: 0x0001376F File Offset: 0x0001196F
		public float controllerAssignmentTimeout
		{
			get
			{
				return this._controllerAssignmentTimeout;
			}
			set
			{
				this._controllerAssignmentTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x0001377F File Offset: 0x0001197F
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x00013787 File Offset: 0x00011987
		public float preInputAssignmentTimeout
		{
			get
			{
				return this._preInputAssignmentTimeout;
			}
			set
			{
				this._preInputAssignmentTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x00013797 File Offset: 0x00011997
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x0001379F File Offset: 0x0001199F
		public float inputAssignmentTimeout
		{
			get
			{
				return this._inputAssignmentTimeout;
			}
			set
			{
				this._inputAssignmentTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000137AF File Offset: 0x000119AF
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x000137B7 File Offset: 0x000119B7
		public float axisCalibrationTimeout
		{
			get
			{
				return this._axisCalibrationTimeout;
			}
			set
			{
				this._axisCalibrationTimeout = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x000137C7 File Offset: 0x000119C7
		// (set) Token: 0x06002E43 RID: 11843 RVA: 0x000137CF File Offset: 0x000119CF
		public bool ignoreMouseXAxisAssignment
		{
			get
			{
				return this._ignoreMouseXAxisAssignment;
			}
			set
			{
				this._ignoreMouseXAxisAssignment = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000137DF File Offset: 0x000119DF
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x000137E7 File Offset: 0x000119E7
		public bool ignoreMouseYAxisAssignment
		{
			get
			{
				return this._ignoreMouseYAxisAssignment;
			}
			set
			{
				this._ignoreMouseYAxisAssignment = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x000137F7 File Offset: 0x000119F7
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x000137FF File Offset: 0x000119FF
		public bool universalCancelClosesScreen
		{
			get
			{
				return this._universalCancelClosesScreen;
			}
			set
			{
				this._universalCancelClosesScreen = value;
				this.InspectorPropertyChanged(false);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x0001380F File Offset: 0x00011A0F
		// (set) Token: 0x06002E49 RID: 11849 RVA: 0x00013817 File Offset: 0x00011A17
		public bool showInputBehaviorSettings
		{
			get
			{
				return this._showInputBehaviorSettings;
			}
			set
			{
				this._showInputBehaviorSettings = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x00013827 File Offset: 0x00011A27
		// (set) Token: 0x06002E4B RID: 11851 RVA: 0x0001382F File Offset: 0x00011A2F
		public bool useThemeSettings
		{
			get
			{
				return this._useThemeSettings;
			}
			set
			{
				this._useThemeSettings = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x0001383F File Offset: 0x00011A3F
		// (set) Token: 0x06002E4D RID: 11853 RVA: 0x00013847 File Offset: 0x00011A47
		public LanguageData language
		{
			get
			{
				return this._language;
			}
			set
			{
				this._language = value;
				if (this._language != null)
				{
					this._language.Initialize();
				}
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x00013870 File Offset: 0x00011A70
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x00013878 File Offset: 0x00011A78
		public bool showPlayersGroupLabel
		{
			get
			{
				return this._showPlayersGroupLabel;
			}
			set
			{
				this._showPlayersGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x00013888 File Offset: 0x00011A88
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00013890 File Offset: 0x00011A90
		public bool showControllerGroupLabel
		{
			get
			{
				return this._showControllerGroupLabel;
			}
			set
			{
				this._showControllerGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x000138A0 File Offset: 0x00011AA0
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x000138A8 File Offset: 0x00011AA8
		public bool showAssignedControllersGroupLabel
		{
			get
			{
				return this._showAssignedControllersGroupLabel;
			}
			set
			{
				this._showAssignedControllersGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x000138B8 File Offset: 0x00011AB8
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x000138C0 File Offset: 0x00011AC0
		public bool showSettingsGroupLabel
		{
			get
			{
				return this._showSettingsGroupLabel;
			}
			set
			{
				this._showSettingsGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x000138D0 File Offset: 0x00011AD0
		// (set) Token: 0x06002E57 RID: 11863 RVA: 0x000138D8 File Offset: 0x00011AD8
		public bool showMapCategoriesGroupLabel
		{
			get
			{
				return this._showMapCategoriesGroupLabel;
			}
			set
			{
				this._showMapCategoriesGroupLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x000138E8 File Offset: 0x00011AE8
		// (set) Token: 0x06002E59 RID: 11865 RVA: 0x000138F0 File Offset: 0x00011AF0
		public bool showControllerNameLabel
		{
			get
			{
				return this._showControllerNameLabel;
			}
			set
			{
				this._showControllerNameLabel = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x00013900 File Offset: 0x00011B00
		// (set) Token: 0x06002E5B RID: 11867 RVA: 0x00013908 File Offset: 0x00011B08
		public bool showAssignedControllers
		{
			get
			{
				return this._showAssignedControllers;
			}
			set
			{
				this._showAssignedControllers = value;
				this.InspectorPropertyChanged(true);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06002E5C RID: 11868 RVA: 0x00013918 File Offset: 0x00011B18
		// (set) Token: 0x06002E5D RID: 11869 RVA: 0x00013920 File Offset: 0x00011B20
		public Action restoreDefaultsDelegate
		{
			get
			{
				return this._restoreDefaultsDelegate;
			}
			set
			{
				this._restoreDefaultsDelegate = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x00013929 File Offset: 0x00011B29
		public bool isOpen
		{
			get
			{
				if (!this.initialized)
				{
					return this.references.canvas != null && this.references.canvas.gameObject.activeInHierarchy;
				}
				return this.canvas.activeInHierarchy;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x00013969 File Offset: 0x00011B69
		private bool isFocused
		{
			get
			{
				return this.initialized && !this.windowManager.isWindowOpen;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06002E60 RID: 11872 RVA: 0x00013983 File Offset: 0x00011B83
		private bool inputAllowed
		{
			get
			{
				return this.blockInputOnFocusEndTime <= Time.unscaledTime;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x0013D09C File Offset: 0x0013B29C
		private int inputGridColumnCount
		{
			get
			{
				int num = 1;
				if (this._showKeyboard)
				{
					num++;
				}
				if (this._showMouse)
				{
					num++;
				}
				if (this._showControllers)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x0013D0D0 File Offset: 0x0013B2D0
		private int inputGridWidth
		{
			get
			{
				return this._actionLabelWidth + (this._showKeyboard ? this._keyboardColMaxWidth : 0) + (this._showMouse ? this._mouseColMaxWidth : 0) + (this._showControllers ? this._controllerColMaxWidth : 0) + (this.inputGridColumnCount - 1) * this._inputColumnSpacing;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x00013995 File Offset: 0x00011B95
		private Player currentPlayer
		{
			get
			{
				return ReInput.players.GetPlayer(this.currentPlayerId);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x000139A7 File Offset: 0x00011BA7
		private InputCategory currentMapCategory
		{
			get
			{
				return ReInput.mapping.GetMapCategory(this.currentMapCategoryId);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x0013D12C File Offset: 0x0013B32C
		private ControlMapper.MappingSet currentMappingSet
		{
			get
			{
				if (this.currentMapCategoryId < 0)
				{
					return null;
				}
				for (int i = 0; i < this._mappingSets.Length; i++)
				{
					if (this._mappingSets[i].mapCategoryId == this.currentMapCategoryId)
					{
						return this._mappingSets[i];
					}
				}
				return null;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x000139B9 File Offset: 0x00011BB9
		private Joystick currentJoystick
		{
			get
			{
				return ReInput.controllers.GetJoystick(this.currentJoystickId);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000139CB File Offset: 0x00011BCB
		private bool isJoystickSelected
		{
			get
			{
				return this.currentJoystickId >= 0;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x000139D9 File Offset: 0x00011BD9
		private GameObject currentUISelection
		{
			get
			{
				if (!(EventSystem.current != null))
				{
					return null;
				}
				return EventSystem.current.currentSelectedGameObject;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000139F4 File Offset: 0x00011BF4
		private bool showSettings
		{
			get
			{
				return this._showInputBehaviorSettings && this._inputBehaviorSettings.Length != 0;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x00013A0A File Offset: 0x00011C0A
		private bool showMapCategories
		{
			get
			{
				return this._mappingSets != null && this._mappingSets.Length > 1;
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00013A24 File Offset: 0x00011C24
		private void Awake()
		{
			if (this._dontDestroyOnLoad)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
			}
			this.PreInitialize();
			if (this.isOpen)
			{
				this.Initialize();
				this.Open(true);
			}
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00013A59 File Offset: 0x00011C59
		private void Start()
		{
			if (this._openOnStart)
			{
				this.Open(false);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00013A6A File Offset: 0x00011C6A
		private void Update()
		{
			if (!this.isOpen)
			{
				return;
			}
			if (!this.initialized)
			{
				return;
			}
			this.CheckUISelection();
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00013A84 File Offset: 0x00011C84
		private void OnDestroy()
		{
			ReInput.ControllerConnectedEvent -= this.OnJoystickConnected;
			ReInput.ControllerDisconnectedEvent -= this.OnJoystickDisconnected;
			ReInput.ControllerPreDisconnectEvent -= this.OnJoystickPreDisconnect;
			this.UnsubscribeMenuControlInputEvents();
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00013ABF File Offset: 0x00011CBF
		private void PreInitialize()
		{
			if (!ReInput.isReady)
			{
				Debug.LogError("Rewired Control Mapper: Rewired has not been initialized! Are you missing a Rewired Input Manager in your scene?");
				return;
			}
			this.SubscribeMenuControlInputEvents();
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x0013D178 File Offset: 0x0013B378
		private void Initialize()
		{
			if (this.initialized)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (this._rewiredInputManager == null)
			{
				this._rewiredInputManager = UnityEngine.Object.FindObjectOfType<InputManager>();
				if (this._rewiredInputManager == null)
				{
					Debug.LogError("Rewired Control Mapper: A Rewired Input Manager was not assigned in the inspector or found in the current scene! Control Mapper will not function.");
					return;
				}
			}
			if (ControlMapper.Instance != null)
			{
				Debug.LogError("Rewired Control Mapper: Only one ControlMapper can exist at one time!");
				return;
			}
			ControlMapper.Instance = this;
			if (this.prefabs == null || !this.prefabs.Check())
			{
				Debug.LogError("Rewired Control Mapper: All prefabs must be assigned in the inspector!");
				return;
			}
			if (this.references == null || !this.references.Check())
			{
				Debug.LogError("Rewired Control Mapper: All references must be assigned in the inspector!");
				return;
			}
			this.references.inputGridLayoutElement = this.references.inputGridContainer.GetComponent<LayoutElement>();
			if (this.references.inputGridLayoutElement == null)
			{
				Debug.LogError("Rewired Control Mapper: InputGridContainer is missing LayoutElement component!");
				return;
			}
			if (this._showKeyboard && this._keyboardInputFieldCount < 1)
			{
				Debug.LogWarning("Rewired Control Mapper: Keyboard Input Fields must be at least 1!");
				this._keyboardInputFieldCount = 1;
			}
			if (this._showMouse && this._mouseInputFieldCount < 1)
			{
				Debug.LogWarning("Rewired Control Mapper: Mouse Input Fields must be at least 1!");
				this._mouseInputFieldCount = 1;
			}
			if (this._showControllers && this._controllerInputFieldCount < 1)
			{
				Debug.LogWarning("Rewired Control Mapper: Controller Input Fields must be at least 1!");
				this._controllerInputFieldCount = 1;
			}
			if (this._maxControllersPerPlayer < 0)
			{
				Debug.LogWarning("Rewired Control Mapper: Max Controllers Per Player must be at least 0 (no limit)!");
				this._maxControllersPerPlayer = 0;
			}
			if (this._useThemeSettings && this._themeSettings == null)
			{
				Debug.LogWarning("Rewired Control Mapper: To use theming, Theme Settings must be set in the inspector! Theming has been disabled.");
				this._useThemeSettings = false;
			}
			if (this._language == null)
			{
				Debug.LogError("Rawired UI: Language must be set in the inspector!");
				return;
			}
			this._language.Initialize();
			this.inputFieldActivatedDelegate = new Action<InputFieldInfo>(this.OnInputFieldActivated);
			this.inputFieldInvertToggleStateChangedDelegate = new Action<ToggleInfo, bool>(this.OnInputFieldInvertToggleStateChanged);
			ReInput.ControllerConnectedEvent += this.OnJoystickConnected;
			ReInput.ControllerDisconnectedEvent += this.OnJoystickDisconnected;
			ReInput.ControllerPreDisconnectEvent += this.OnJoystickPreDisconnect;
			this.playerCount = ReInput.players.playerCount;
			this.canvas = this.references.canvas.gameObject;
			this.windowManager = new ControlMapper.WindowManager(this.prefabs.window, this.prefabs.fader, this.references.canvas.transform);
			this.playerButtons = new List<ControlMapper.GUIButton>();
			this.mapCategoryButtons = new List<ControlMapper.GUIButton>();
			this.assignedControllerButtons = new List<ControlMapper.GUIButton>();
			this.miscInstantiatedObjects = new List<GameObject>();
			this.currentMapCategoryId = this._mappingSets[0].mapCategoryId;
			this.Draw();
			this.CreateInputGrid();
			this.CreateLayout();
			this.SubscribeFixedUISelectionEvents();
			this.initialized = true;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00013AD9 File Offset: 0x00011CD9
		private void OnJoystickConnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this._showControllers)
			{
				return;
			}
			this.ClearVarsOnJoystickChange();
			this.ForceRefresh();
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x00013AD9 File Offset: 0x00011CD9
		private void OnJoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this._showControllers)
			{
				return;
			}
			this.ClearVarsOnJoystickChange();
			this.ForceRefresh();
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00013AF9 File Offset: 0x00011CF9
		private void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			if (!this.initialized)
			{
				return;
			}
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x0013D444 File Offset: 0x0013B644
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.inputAllowed)
			{
				return;
			}
			string identifier = buttonInfo.identifier;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(identifier);
			if (num <= 1656078790u)
			{
				if (num <= 1293854844u)
				{
					if (num != 36291085u)
					{
						if (num != 1293854844u)
						{
							return;
						}
						if (!(identifier == "AssignController"))
						{
							return;
						}
						this.ShowAssignControllerWindow();
						return;
					}
					else
					{
						if (!(identifier == "MapCategorySelection"))
						{
							return;
						}
						this.OnMapCategorySelected(buttonInfo.intData, true);
						return;
					}
				}
				else if (num != 1619204974u)
				{
					if (num != 1656078790u)
					{
						return;
					}
					if (!(identifier == "EditInputBehaviors"))
					{
						return;
					}
					this.ShowEditInputBehaviorsWindow();
					return;
				}
				else
				{
					if (!(identifier == "PlayerSelection"))
					{
						return;
					}
					this.OnPlayerSelected(buttonInfo.intData, true);
					return;
				}
			}
			else if (num <= 2379421585u)
			{
				if (num != 2139278426u)
				{
					if (num != 2379421585u)
					{
						return;
					}
					if (!(identifier == "Done"))
					{
						return;
					}
					this.Close(true);
					return;
				}
				else
				{
					if (!(identifier == "CalibrateController"))
					{
						return;
					}
					this.ShowCalibrateControllerWindow();
					return;
				}
			}
			else if (num != 2857234147u)
			{
				if (num != 3019194153u)
				{
					if (num != 3496297297u)
					{
						return;
					}
					if (!(identifier == "AssignedControllerSelection"))
					{
						return;
					}
					this.OnControllerSelected(buttonInfo.intData);
					return;
				}
				else
				{
					if (!(identifier == "RemoveController"))
					{
						return;
					}
					this.OnRemoveCurrentController();
					return;
				}
			}
			else
			{
				if (!(identifier == "RestoreDefaults"))
				{
					return;
				}
				this.OnRestoreDefaults();
				return;
			}
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0013D5AC File Offset: 0x0013B7AC
		public void OnInputFieldActivated(InputFieldInfo fieldInfo)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.inputAllowed)
			{
				return;
			}
			if (this.currentPlayer == null)
			{
				return;
			}
			InputAction action = ReInput.mapping.GetAction(fieldInfo.actionId);
			if (action == null)
			{
				return;
			}
			string actionName;
			if (action.type == InputActionType.Button)
			{
				actionName = action.descriptiveName;
			}
			else
			{
				if (action.type != InputActionType.Axis)
				{
					throw new NotImplementedException();
				}
				if (fieldInfo.axisRange == AxisRange.Full)
				{
					actionName = action.descriptiveName;
				}
				else if (fieldInfo.axisRange == AxisRange.Positive)
				{
					if (string.IsNullOrEmpty(action.positiveDescriptiveName))
					{
						actionName = action.descriptiveName + " +";
					}
					else
					{
						actionName = action.positiveDescriptiveName;
					}
				}
				else
				{
					if (fieldInfo.axisRange != AxisRange.Negative)
					{
						throw new NotImplementedException();
					}
					if (string.IsNullOrEmpty(action.negativeDescriptiveName))
					{
						actionName = action.descriptiveName + " -";
					}
					else
					{
						actionName = action.negativeDescriptiveName;
					}
				}
			}
			ControllerMap controllerMap = this.GetControllerMap(fieldInfo.controllerType);
			if (controllerMap == null)
			{
				return;
			}
			ActionElementMap actionElementMap = (fieldInfo.actionElementMapId >= 0) ? controllerMap.GetElementMap(fieldInfo.actionElementMapId) : null;
			if (actionElementMap != null)
			{
				this.ShowBeginElementAssignmentReplacementWindow(fieldInfo, action, controllerMap, actionElementMap, actionName);
				return;
			}
			this.ShowCreateNewElementAssignmentWindow(fieldInfo, action, controllerMap, actionName);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x00013B04 File Offset: 0x00011D04
		public void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.inputAllowed)
			{
				return;
			}
			this.SetActionAxisInverted(newState, toggleInfo.controllerType, toggleInfo.actionElementMapId);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00013B2B File Offset: 0x00011D2B
		private void OnPlayerSelected(int playerId, bool redraw)
		{
			if (!this.initialized)
			{
				return;
			}
			this.currentPlayerId = playerId;
			this.ClearVarsOnPlayerChange();
			if (redraw)
			{
				this.Redraw(true, true);
			}
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00013B4E File Offset: 0x00011D4E
		private void OnControllerSelected(int joystickId)
		{
			if (!this.initialized)
			{
				return;
			}
			this.currentJoystickId = joystickId;
			this.Redraw(true, true);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00013B68 File Offset: 0x00011D68
		private void OnRemoveCurrentController()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this.currentJoystickId < 0)
			{
				return;
			}
			this.RemoveController(this.currentPlayer, this.currentJoystickId);
			this.ClearVarsOnJoystickChange();
			this.Redraw(false, false);
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x00013B9D File Offset: 0x00011D9D
		private void OnMapCategorySelected(int id, bool redraw)
		{
			if (!this.initialized)
			{
				return;
			}
			this.currentMapCategoryId = id;
			if (redraw)
			{
				this.Redraw(true, true);
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00013BBA File Offset: 0x00011DBA
		private void OnRestoreDefaults()
		{
			if (!this.initialized)
			{
				return;
			}
			this.ShowRestoreDefaultsWindow();
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00013BCB File Offset: 0x00011DCB
		private void OnScreenToggleActionPressed(InputActionEventData data)
		{
			if (!this.isOpen)
			{
				this.Open();
				return;
			}
			if (!this.initialized)
			{
				return;
			}
			if (!this.isFocused)
			{
				return;
			}
			this.Close(true);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00013BF5 File Offset: 0x00011DF5
		private void OnScreenOpenActionPressed(InputActionEventData data)
		{
			this.Open();
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00013BFD File Offset: 0x00011DFD
		private void OnScreenCloseActionPressed(InputActionEventData data)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (!this.isFocused)
			{
				return;
			}
			this.Close(true);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00013C21 File Offset: 0x00011E21
		private void OnUniversalCancelActionPressed(InputActionEventData data)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (this._universalCancelClosesScreen)
			{
				if (this.isFocused)
				{
					this.Close(true);
					return;
				}
			}
			else if (this.isFocused)
			{
				return;
			}
			this.CloseAllWindows();
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00013C5C File Offset: 0x00011E5C
		private void OnWindowCancel(int windowId)
		{
			if (!this.initialized)
			{
				return;
			}
			if (windowId < 0)
			{
				return;
			}
			this.CloseWindow(windowId);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00013C73 File Offset: 0x00011E73
		private void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem)
		{
			if (map != null && aem != null)
			{
				map.DeleteElementMap(aem.id);
				this.CloseWindow(windowId);
				return;
			}
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x0013D6C8 File Offset: 0x0013B8C8
		private void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName)
		{
			if (fieldInfo == null || map == null)
			{
				return;
			}
			this.pendingInputMapping = new ControlMapper.InputMapping(actionName, fieldInfo, map, aem, fieldInfo.controllerType, fieldInfo.controllerId);
			switch (fieldInfo.controllerType)
			{
			case ControllerType.Keyboard:
				this.ShowElementAssignmentPollingWindow();
				return;
			case ControllerType.Mouse:
				this.ShowElementAssignmentPollingWindow();
				return;
			case ControllerType.Joystick:
				this.ShowElementAssignmentPrePollingWindow();
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00013C90 File Offset: 0x00011E90
		private void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId)
		{
			if (windowId >= 0 && player != null && controllerId >= 0)
			{
				this.AssignController(player, controllerId);
				this.CloseWindow(windowId);
				return;
			}
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x0013D734 File Offset: 0x0013B934
		private void OnMouseAssignmentConfirmed(int windowId, Player player)
		{
			if (windowId >= 0 && player != null)
			{
				IList<Player> players = ReInput.players.Players;
				for (int i = 0; i < players.Count; i++)
				{
					if (players[i] != player)
					{
						players[i].controllers.hasMouse = false;
					}
				}
				player.controllers.hasMouse = true;
				this.CloseWindow(windowId);
				return;
			}
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x0013D794 File Offset: 0x0013B994
		private void OnElementAssignmentConflictReplaceConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap)
		{
			if (this.currentPlayer == null || mapping == null)
			{
				return;
			}
			ElementAssignmentConflictCheck conflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out conflictCheck))
			{
				Debug.LogError("Rewired Control Mapper: Error creating conflict check!");
				this.CloseWindow(windowId);
				return;
			}
			ElementAssignmentConflictInfo elementAssignmentConflictInfo = default(ElementAssignmentConflictInfo);
			ActionElementMap actionElementMap = null;
			ActionElementMap actionElementMap2 = null;
			bool flag = false;
			if (allowSwap && mapping.aem != null && this.GetFirstElementAssignmentConflict(conflictCheck, out elementAssignmentConflictInfo, skipOtherPlayers))
			{
				flag = true;
				actionElementMap2 = new ActionElementMap(mapping.aem);
				actionElementMap = new ActionElementMap(elementAssignmentConflictInfo.elementMap);
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (!skipOtherPlayers || player == this.currentPlayer || player == ReInput.players.SystemPlayer)
				{
					player.controllers.conflictChecking.RemoveElementAssignmentConflicts(conflictCheck);
				}
			}
			mapping.map.ReplaceOrCreateElementMap(assignment);
			if (allowSwap && flag)
			{
				int actionId = actionElementMap.actionId;
				Pole axisContribution = actionElementMap.axisContribution;
				bool invert = actionElementMap.invert;
				AxisRange axisRange = actionElementMap2.axisRange;
				ControllerElementType elementType = actionElementMap2.elementType;
				int elementIdentifierId = actionElementMap2.elementIdentifierId;
				KeyCode keyCode = actionElementMap2.keyCode;
				ModifierKeyFlags modifierKeyFlags = actionElementMap2.modifierKeyFlags;
				if (elementType == actionElementMap.elementType && elementType == ControllerElementType.Axis)
				{
					if (axisRange != actionElementMap.axisRange)
					{
						if (axisRange == AxisRange.Full)
						{
							axisRange = AxisRange.Positive;
						}
						else if (actionElementMap.axisRange == AxisRange.Full)
						{
						}
					}
				}
				else if (elementType == ControllerElementType.Axis && (actionElementMap.elementType == ControllerElementType.Button || (actionElementMap.elementType == ControllerElementType.Axis && actionElementMap.axisRange != AxisRange.Full)) && axisRange == AxisRange.Full)
				{
					axisRange = AxisRange.Positive;
				}
				if (elementType != ControllerElementType.Axis || axisRange != AxisRange.Full)
				{
					invert = false;
				}
				int num = 0;
				foreach (ActionElementMap actionElementMap3 in elementAssignmentConflictInfo.controllerMap.ElementMapsWithAction(actionId))
				{
					if (this.SwapIsSameInputRange(elementType, axisRange, axisContribution, actionElementMap3.elementType, actionElementMap3.axisRange, actionElementMap3.axisContribution))
					{
						num++;
					}
				}
				if (num < this.GetControllerInputFieldCount(mapping.controllerType))
				{
					elementAssignmentConflictInfo.controllerMap.ReplaceOrCreateElementMap(ElementAssignment.CompleteAssignment(mapping.controllerType, elementType, elementIdentifierId, axisRange, keyCode, modifierKeyFlags, actionId, axisContribution, invert));
				}
			}
			this.CloseWindow(windowId);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00013CAD File Offset: 0x00011EAD
		private void OnElementAssignmentAddConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment)
		{
			if (this.currentPlayer != null && mapping != null)
			{
				mapping.map.ReplaceOrCreateElementMap(assignment);
				this.CloseWindow(windowId);
				return;
			}
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x0013D9D8 File Offset: 0x0013BBD8
		private void OnRestoreDefaultsConfirmed(int windowId)
		{
			if (this._restoreDefaultsDelegate == null)
			{
				IList<Player> players = ReInput.players.Players;
				for (int i = 0; i < players.Count; i++)
				{
					Player player = players[i];
					if (this._showControllers)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Joystick);
					}
					if (this._showKeyboard)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Keyboard);
					}
					if (this._showMouse)
					{
						player.controllers.maps.LoadDefaultMaps(ControllerType.Mouse);
					}
				}
			}
			this.CloseWindow(windowId);
			if (this._restoreDefaultsDelegate != null)
			{
				this._restoreDefaultsDelegate();
			}
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x0013DA78 File Offset: 0x0013BC78
		private void OnAssignControllerWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			ControllerPollingInfo controllerPollingInfo = ReInput.controllers.polling.PollAllControllersOfTypeForFirstElementDown(ControllerType.Joystick);
			if (!controllerPollingInfo.success)
			{
				window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
				return;
			}
			this.InputPollingStopped();
			if (ReInput.controllers.IsControllerAssigned(ControllerType.Joystick, controllerPollingInfo.controllerId) && !this.currentPlayer.controllers.ContainsController(ControllerType.Joystick, controllerPollingInfo.controllerId))
			{
				this.ShowControllerAssignmentConflictWindow(controllerPollingInfo.controllerId);
				return;
			}
			this.OnControllerAssignmentConfirmed(windowId, this.currentPlayer, controllerPollingInfo.controllerId);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x0013DB54 File Offset: 0x0013BD54
		private void OnElementAssignmentPrePollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (!window.timer.finished)
			{
				window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
				ControllerType controllerType = this.pendingInputMapping.controllerType;
				ControllerPollingInfo controllerPollingInfo;
				if (controllerType > ControllerType.Mouse)
				{
					if (controllerType != ControllerType.Joystick)
					{
						throw new NotImplementedException();
					}
					if (this.currentPlayer.controllers.joystickCount == 0)
					{
						return;
					}
					controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstButtonDown(this.pendingInputMapping.controllerType, this.currentJoystick.id);
				}
				else
				{
					controllerPollingInfo = ReInput.controllers.polling.PollControllerForFirstButtonDown(this.pendingInputMapping.controllerType, 0);
				}
				if (!controllerPollingInfo.success)
				{
					return;
				}
			}
			this.ShowElementAssignmentPollingWindow();
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x0013DC3C File Offset: 0x0013BE3C
		private void OnJoystickElementAssignmentPollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
			if (this.currentPlayer.controllers.joystickCount == 0)
			{
				return;
			}
			ControllerPollingInfo pollingInfo = ReInput.controllers.polling.PollControllerForFirstElementDown(ControllerType.Joystick, this.currentJoystick.id);
			if (!pollingInfo.success)
			{
				return;
			}
			if (!this.IsAllowedAssignment(this.pendingInputMapping, pollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.pendingInputMapping.ToElementAssignment(pollingInfo);
			if (!this.HasElementAssignmentConflicts(this.currentPlayer, this.pendingInputMapping, elementAssignment, false))
			{
				this.pendingInputMapping.map.ReplaceOrCreateElementMap(elementAssignment);
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			this.InputPollingStopped();
			this.ShowElementAssignmentConflictWindow(elementAssignment, false);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x0013DD48 File Offset: 0x0013BF48
		private void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			ControllerPollingInfo pollingInfo;
			bool flag;
			ModifierKeyFlags modifierKeyFlags;
			string text;
			this.PollKeyboardForAssignment(out pollingInfo, out flag, out modifierKeyFlags, out text);
			if (flag)
			{
				window.timer.Start(this._inputAssignmentTimeout);
			}
			window.SetContentText(flag ? string.Empty : Mathf.CeilToInt(window.timer.remaining).ToString(), 2);
			window.SetContentText(text, 1);
			if (!pollingInfo.success)
			{
				return;
			}
			if (!this.IsAllowedAssignment(this.pendingInputMapping, pollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.pendingInputMapping.ToElementAssignment(pollingInfo, modifierKeyFlags);
			if (!this.HasElementAssignmentConflicts(this.currentPlayer, this.pendingInputMapping, elementAssignment, false))
			{
				this.pendingInputMapping.map.ReplaceOrCreateElementMap(elementAssignment);
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			this.InputPollingStopped();
			this.ShowElementAssignmentConflictWindow(elementAssignment, false);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x0013DE60 File Offset: 0x0013C060
		private void OnMouseElementAssignmentPollingWindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingInputMapping == null)
			{
				return;
			}
			this.InputPollingStarted();
			if (window.timer.finished)
			{
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
			ControllerPollingInfo pollingInfo;
			if (!this._ignoreMouseXAxisAssignment && !this._ignoreMouseYAxisAssignment)
			{
				pollingInfo = ReInput.controllers.polling.PollControllerForFirstElementDown(ControllerType.Mouse, 0);
			}
			else
			{
				pollingInfo = default(ControllerPollingInfo);
				foreach (ControllerPollingInfo controllerPollingInfo in ReInput.controllers.polling.PollControllerForAllElementsDown(ControllerType.Mouse, 0))
				{
					if (controllerPollingInfo.elementType == ControllerElementType.Axis)
					{
						if (this._ignoreMouseXAxisAssignment && controllerPollingInfo.elementIndex == 0)
						{
							continue;
						}
						if (this._ignoreMouseYAxisAssignment)
						{
							if (controllerPollingInfo.elementIndex == 1)
							{
								continue;
							}
						}
					}
					pollingInfo = controllerPollingInfo;
					break;
				}
			}
			if (!pollingInfo.success)
			{
				return;
			}
			if (!this.IsAllowedAssignment(this.pendingInputMapping, pollingInfo))
			{
				return;
			}
			ElementAssignment elementAssignment = this.pendingInputMapping.ToElementAssignment(pollingInfo);
			if (!this.HasElementAssignmentConflicts(this.currentPlayer, this.pendingInputMapping, elementAssignment, true))
			{
				this.pendingInputMapping.map.ReplaceOrCreateElementMap(elementAssignment);
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
			this.InputPollingStopped();
			this.ShowElementAssignmentConflictWindow(elementAssignment, true);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x0013DFE8 File Offset: 0x0013C1E8
		private void OnCalibrateAxisStep1WindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingAxisCalibration != null && this.pendingAxisCalibration.isValid)
			{
				this.InputPollingStarted();
				if (!window.timer.finished)
				{
					window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
					if (this.currentPlayer.controllers.joystickCount == 0)
					{
						return;
					}
					if (!this.pendingAxisCalibration.joystick.PollForFirstButtonDown().success)
					{
						return;
					}
				}
				this.pendingAxisCalibration.RecordZero();
				this.CloseWindow(windowId);
				this.ShowCalibrateAxisStep2Window();
				return;
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x0013E0A4 File Offset: 0x0013C2A4
		private void OnCalibrateAxisStep2WindowUpdate(int windowId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.windowManager.GetWindow(windowId);
			if (windowId < 0)
			{
				return;
			}
			if (this.pendingAxisCalibration != null && this.pendingAxisCalibration.isValid)
			{
				if (!window.timer.finished)
				{
					window.SetContentText(Mathf.CeilToInt(window.timer.remaining).ToString(), 1);
					this.pendingAxisCalibration.RecordMinMax();
					if (this.currentPlayer.controllers.joystickCount == 0)
					{
						return;
					}
					if (!this.pendingAxisCalibration.joystick.PollForFirstButtonDown().success)
					{
						return;
					}
				}
				this.EndAxisCalibration();
				this.InputPollingStopped();
				this.CloseWindow(windowId);
				return;
			}
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x0013E160 File Offset: 0x0013C360
		private void ShowAssignControllerWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (ReInput.controllers.joystickCount == 0)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.SetUpdateCallback(new Action<int>(this.OnAssignControllerWindowUpdate));
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.assignControllerWindowTitle);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.assignControllerWindowMessage);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.timer.Start(this._controllerAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x0013E240 File Offset: 0x0013C440
		private void ShowControllerAssignmentConflictWindow(int controllerId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (ReInput.controllers.joystickCount == 0)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string otherPlayerName = string.Empty;
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != this.currentPlayer && players[i].controllers.ContainsController(ControllerType.Joystick, controllerId))
				{
					otherPlayerName = players[i].descriptiveName;
					IL_A7:
					Joystick joystick = ReInput.controllers.GetJoystick(controllerId);
					window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.controllerAssignmentConflictWindowTitle);
					window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetControllerAssignmentConflictWindowMessage(joystick.name, otherPlayerName, this.currentPlayer.descriptiveName));
					UnityAction unityAction = delegate()
					{
						this.OnWindowCancel(window.id);
					};
					window.cancelCallback = unityAction;
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.yes, delegate()
					{
						this.OnControllerAssignmentConfirmed(window.id, this.currentPlayer, controllerId);
					}, unityAction, true);
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.no, unityAction, unityAction, false);
					this.windowManager.Focus(window);
					return;
				}
			}
			goto IL_A7;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x0013E418 File Offset: 0x0013C618
		private void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName)
		{
			ControlMapper.GUIInputField guiinputField = this.inputGrid.GetGUIInputField(this.currentMapCategoryId, action.id, fieldInfo.axisRange, fieldInfo.controllerType, fieldInfo.intData);
			if (guiinputField == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), guiinputField.GetLabel());
			UnityAction unityAction = delegate()
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.replace, delegate()
			{
				this.OnBeginElementAssignment(fieldInfo, map, aem, actionName);
			}, unityAction, true);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.remove, delegate()
			{
				this.OnRemoveElementAssignment(window.id, map, aem);
			}, unityAction, false);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.cancel, unityAction, unityAction, false);
			this.windowManager.Focus(window);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00013CCF File Offset: 0x00011ECF
		private void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName)
		{
			if (this.inputGrid.GetGUIInputField(this.currentMapCategoryId, action.id, fieldInfo.axisRange, fieldInfo.controllerType, fieldInfo.intData) == null)
			{
				return;
			}
			this.OnBeginElementAssignment(fieldInfo, map, null, actionName);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x0013E5D8 File Offset: 0x0013C7D8
		private void ShowElementAssignmentPrePollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.elementAssignmentPrePollingWindowMessage);
			if (this.prefabs.centerStickGraphic != null)
			{
				window.AddContentImage(this.prefabs.centerStickGraphic, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
			}
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnElementAssignmentPrePollingWindowUpdate));
			window.timer.Start(this._preInputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x0013E6E8 File Offset: 0x0013C8E8
		private void ShowElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			switch (this.pendingInputMapping.controllerType)
			{
			case ControllerType.Keyboard:
				this.ShowKeyboardElementAssignmentPollingWindow();
				return;
			case ControllerType.Mouse:
				if (this.currentPlayer.controllers.hasMouse)
				{
					this.ShowMouseElementAssignmentPollingWindow();
					return;
				}
				this.ShowMouseAssignmentConflictWindow();
				return;
			case ControllerType.Joystick:
				this.ShowJoystickElementAssignmentPollingWindow();
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x0013E750 File Offset: 0x0013C950
		private void ShowJoystickElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string text = (this.pendingInputMapping.axisRange != AxisRange.Full || !this._showFullAxisInputFields || this._showSplitAxisInputFields) ? this._language.GetJoystickElementAssignmentPollingWindowMessage(this.pendingInputMapping.actionName) : this._language.GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(this.pendingInputMapping.actionName);
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnJoystickElementAssignmentPollingWindowUpdate));
			window.timer.Start(this._inputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x0013E864 File Offset: 0x0013CA64
		private void ShowKeyboardElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetKeyboardElementAssignmentPollingWindowMessage(this.pendingInputMapping.actionName));
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -(window.GetContentTextHeight(0) + 50f)), "");
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnKeyboardElementAssignmentPollingWindowUpdate));
			window.timer.Start(this._inputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x0013E97C File Offset: 0x0013CB7C
		private void ShowMouseElementAssignmentPollingWindow()
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string text = (this.pendingInputMapping.axisRange != AxisRange.Full || !this._showFullAxisInputFields || this._showSplitAxisInputFields) ? this._language.GetMouseElementAssignmentPollingWindowMessage(this.pendingInputMapping.actionName) : this._language.GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(this.pendingInputMapping.actionName);
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this.pendingInputMapping.actionName);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
			window.SetUpdateCallback(new Action<int>(this.OnMouseElementAssignmentPollingWindowUpdate));
			window.timer.Start(this._inputAssignmentTimeout);
			this.windowManager.Focus(window);
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x0013EA90 File Offset: 0x0013CC90
		private void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers)
		{
			if (this.pendingInputMapping == null)
			{
				return;
			}
			bool flag;
			string text = (flag = this.IsBlockingAssignmentConflict(this.pendingInputMapping, assignment, skipOtherPlayers)) ? this._language.GetElementAlreadyInUseBlocked(this.pendingInputMapping.elementName) : this._language.GetElementAlreadyInUseCanReplace(this.pendingInputMapping.elementName, this._allowElementAssignmentConflicts);
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.elementAssignmentConflictWindowMessage);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), text);
			UnityAction unityAction = delegate()
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			if (flag)
			{
				window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.okay, unityAction, unityAction, true);
			}
			else
			{
				window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.replace, delegate()
				{
					this.OnElementAssignmentConflictReplaceConfirmed(window.id, this.pendingInputMapping, assignment, skipOtherPlayers, false);
				}, unityAction, true);
				if (this._allowElementAssignmentConflicts)
				{
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.add, delegate()
					{
						this.OnElementAssignmentAddConfirmed(window.id, this.pendingInputMapping, assignment);
					}, unityAction, false);
				}
				else if (this.ShowSwapButton(window.id, this.pendingInputMapping, assignment, skipOtherPlayers))
				{
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomCenter, UIAnchor.BottomCenter, Vector2.zero, this._language.swap, delegate()
					{
						this.OnElementAssignmentConflictReplaceConfirmed(window.id, this.pendingInputMapping, assignment, skipOtherPlayers, true);
					}, unityAction, false);
				}
				window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.cancel, unityAction, unityAction, false);
			}
			this.windowManager.Focus(window);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x0013ED08 File Offset: 0x0013CF08
		private void ShowMouseAssignmentConflictWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.OpenWindow(true);
			if (window == null)
			{
				return;
			}
			string otherPlayerName = string.Empty;
			IList<Player> players = ReInput.players.Players;
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i] != this.currentPlayer && players[i].controllers.hasMouse)
				{
					otherPlayerName = players[i].descriptiveName;
					IL_8C:
					window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.mouseAssignmentConflictWindowTitle);
					window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetMouseAssignmentConflictWindowMessage(otherPlayerName, this.currentPlayer.descriptiveName));
					UnityAction unityAction = delegate()
					{
						this.OnWindowCancel(window.id);
					};
					window.cancelCallback = unityAction;
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, this._language.yes, delegate()
					{
						this.OnMouseAssignmentConfirmed(window.id, this.currentPlayer);
					}, unityAction, true);
					window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, this._language.no, unityAction, unityAction, false);
					this.windowManager.Focus(window);
					return;
				}
			}
			goto IL_8C;
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x0013EEA8 File Offset: 0x0013D0A8
		private void ShowCalibrateControllerWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this.currentPlayer.controllers.joystickCount == 0)
			{
				return;
			}
			CalibrationWindow calibrationWindow = this.OpenWindow(this.prefabs.calibrationWindow, "CalibrationWindow", true) as CalibrationWindow;
			if (calibrationWindow == null)
			{
				return;
			}
			Joystick currentJoystick = this.currentJoystick;
			calibrationWindow.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.calibrateControllerWindowTitle);
			calibrationWindow.SetJoystick(this.currentPlayer.id, currentJoystick);
			calibrationWindow.SetButtonCallback(CalibrationWindow.ButtonIdentifier.Done, new Action<int>(this.CloseWindow));
			calibrationWindow.SetButtonCallback(CalibrationWindow.ButtonIdentifier.Calibrate, new Action<int>(this.StartAxisCalibration));
			calibrationWindow.SetButtonCallback(CalibrationWindow.ButtonIdentifier.Cancel, new Action<int>(this.CloseWindow));
			this.windowManager.Focus(calibrationWindow);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x0013EF78 File Offset: 0x0013D178
		private void ShowCalibrateAxisStep1Window()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.OpenWindow(false);
			if (window == null)
			{
				return;
			}
			if (this.pendingAxisCalibration == null)
			{
				return;
			}
			Joystick joystick = this.pendingAxisCalibration.joystick;
			if (joystick.axisCount == 0)
			{
				return;
			}
			int axisIndex = this.pendingAxisCalibration.axisIndex;
			if (axisIndex >= 0 && axisIndex < joystick.axisCount)
			{
				window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.calibrateAxisStep1WindowTitle);
				window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetCalibrateAxisStep1WindowMessage(joystick.AxisElementIdentifiers[axisIndex].name));
				if (this.prefabs.centerStickGraphic != null)
				{
					window.AddContentImage(this.prefabs.centerStickGraphic, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
				}
				window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
				window.SetUpdateCallback(new Action<int>(this.OnCalibrateAxisStep1WindowUpdate));
				window.timer.Start(this._axisCalibrationTimeout);
				this.windowManager.Focus(window);
				return;
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x0013F0D8 File Offset: 0x0013D2D8
		private void ShowCalibrateAxisStep2Window()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			Window window = this.OpenWindow(false);
			if (window == null)
			{
				return;
			}
			if (this.pendingAxisCalibration == null)
			{
				return;
			}
			Joystick joystick = this.pendingAxisCalibration.joystick;
			if (joystick.axisCount == 0)
			{
				return;
			}
			int axisIndex = this.pendingAxisCalibration.axisIndex;
			if (axisIndex >= 0 && axisIndex < joystick.axisCount)
			{
				window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.calibrateAxisStep2WindowTitle);
				window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), this._language.GetCalibrateAxisStep2WindowMessage(joystick.AxisElementIdentifiers[axisIndex].name));
				if (this.prefabs.moveStickGraphic != null)
				{
					window.AddContentImage(this.prefabs.moveStickGraphic, UIPivot.BottomCenter, UIAnchor.BottomCenter, new Vector2(0f, 40f));
				}
				window.AddContentText(this.prefabs.windowContentText, UIPivot.BottomCenter, UIAnchor.BottomHStretch, Vector2.zero, "");
				window.SetUpdateCallback(new Action<int>(this.OnCalibrateAxisStep2WindowUpdate));
				window.timer.Start(this._axisCalibrationTimeout);
				this.windowManager.Focus(window);
				return;
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x0013F238 File Offset: 0x0013D438
		private void ShowEditInputBehaviorsWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this._inputBehaviorSettings == null)
			{
				return;
			}
			InputBehaviorWindow inputBehaviorWindow = this.OpenWindow(this.prefabs.inputBehaviorsWindow, "EditInputBehaviorsWindow", true) as InputBehaviorWindow;
			if (inputBehaviorWindow == null)
			{
				return;
			}
			inputBehaviorWindow.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, this._language.inputBehaviorSettingsWindowTitle);
			inputBehaviorWindow.SetData(this.currentPlayer.id, this._inputBehaviorSettings);
			inputBehaviorWindow.SetButtonCallback(InputBehaviorWindow.ButtonIdentifier.Done, new Action<int>(this.CloseWindow));
			inputBehaviorWindow.SetButtonCallback(InputBehaviorWindow.ButtonIdentifier.Cancel, new Action<int>(this.CloseWindow));
			this.windowManager.Focus(inputBehaviorWindow);
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x0013F2E8 File Offset: 0x0013D4E8
		private void ShowRestoreDefaultsWindow()
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			this.OpenModal(this._language.restoreDefaultsWindowTitle, this._language.restoreDefaultsWindowMessage, this._language.yes, new Action<int>(this.OnRestoreDefaultsConfirmed), this._language.no, new Action<int>(this.OnWindowCancel), true);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x0013F34C File Offset: 0x0013D54C
		private void CreateInputGrid()
		{
			this.InitializeInputGrid();
			this.CreateHeaderLabels();
			this.CreateActionLabelColumn();
			this.CreateKeyboardInputFieldColumn();
			this.CreateMouseInputFieldColumn();
			this.CreateControllerInputFieldColumn();
			this.CreateInputActionLabels();
			this.CreateInputFields();
			this.inputGrid.HideAll();
			this.ResetInputGridScrollBar();
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x0013F39C File Offset: 0x0013D59C
		private void InitializeInputGrid()
		{
			if (this.inputGrid == null)
			{
				this.inputGrid = new ControlMapper.InputGrid();
			}
			else
			{
				this.inputGrid.ClearAll();
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.isValid)
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(mappingSet.mapCategoryId);
					if (mapCategory != null && mapCategory.userAssignable)
					{
						this.inputGrid.AddMapCategory(mappingSet.mapCategoryId);
						if (mappingSet.actionListMode == ControlMapper.MappingSet.ActionListMode.ActionCategory)
						{
							IList<int> actionCategoryIds = mappingSet.actionCategoryIds;
							for (int j = 0; j < actionCategoryIds.Count; j++)
							{
								int num = actionCategoryIds[j];
								InputCategory actionCategory = ReInput.mapping.GetActionCategory(num);
								if (actionCategory != null && actionCategory.userAssignable)
								{
									this.inputGrid.AddActionCategory(mappingSet.mapCategoryId, num);
									foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(num))
									{
										if (inputAction.type == InputActionType.Axis)
										{
											if (this._showFullAxisInputFields)
											{
												this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Full);
											}
											if (this._showSplitAxisInputFields)
											{
												this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Positive);
												this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Negative);
											}
										}
										else if (inputAction.type == InputActionType.Button)
										{
											this.inputGrid.AddAction(mappingSet.mapCategoryId, inputAction, AxisRange.Positive);
										}
									}
								}
							}
						}
						else
						{
							IList<int> actionIds = mappingSet.actionIds;
							for (int k = 0; k < actionIds.Count; k++)
							{
								InputAction action = ReInput.mapping.GetAction(actionIds[k]);
								if (action != null)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Full);
										}
										if (this._showSplitAxisInputFields)
										{
											this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Positive);
											this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Negative);
										}
									}
									else if (action.type == InputActionType.Button)
									{
										this.inputGrid.AddAction(mappingSet.mapCategoryId, action, AxisRange.Positive);
									}
								}
							}
						}
					}
				}
			}
			this.references.inputGridInnerGroup.GetComponent<HorizontalLayoutGroup>().spacing = (float)this._inputColumnSpacing;
			this.references.inputGridLayoutElement.flexibleWidth = 0f;
			this.references.inputGridLayoutElement.preferredWidth = (float)this.inputGridWidth;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x0013F658 File Offset: 0x0013D858
		private void RefreshInputGridStructure()
		{
			if (this.currentMappingSet == null)
			{
				return;
			}
			this.inputGrid.HideAll();
			this.inputGrid.Show(this.currentMappingSet.mapCategoryId);
			this.references.inputGridInnerGroup.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.inputGrid.GetColumnHeight(this.currentMappingSet.mapCategoryId));
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x0013F6BC File Offset: 0x0013D8BC
		private void CreateHeaderLabels()
		{
			this.references.inputGridHeader1 = this.CreateNewColumnGroup("ActionsHeader", this.references.inputGridHeadersGroup, this._actionLabelWidth).transform;
			this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.actionColumnLabel, this.references.inputGridHeader1, Vector2.zero);
			if (this._showKeyboard)
			{
				this.references.inputGridHeader2 = this.CreateNewColumnGroup("KeybordHeader", this.references.inputGridHeadersGroup, this._keyboardColMaxWidth).transform;
				this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.keyboardColumnLabel, this.references.inputGridHeader2, Vector2.zero).SetTextAlignment(TextAnchor.MiddleCenter);
			}
			if (this._showMouse)
			{
				this.references.inputGridHeader3 = this.CreateNewColumnGroup("MouseHeader", this.references.inputGridHeadersGroup, this._mouseColMaxWidth).transform;
				this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.mouseColumnLabel, this.references.inputGridHeader3, Vector2.zero).SetTextAlignment(TextAnchor.MiddleCenter);
			}
			if (this._showControllers)
			{
				this.references.inputGridHeader4 = this.CreateNewColumnGroup("ControllerHeader", this.references.inputGridHeadersGroup, this._controllerColMaxWidth).transform;
				this.CreateLabel(this.prefabs.inputGridHeaderLabel, this._language.controllerColumnLabel, this.references.inputGridHeader4, Vector2.zero).SetTextAlignment(TextAnchor.MiddleCenter);
			}
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x0013F854 File Offset: 0x0013DA54
		private void CreateActionLabelColumn()
		{
			Transform transform = this.CreateNewColumnGroup("ActionLabelColumn", this.references.inputGridInnerGroup, this._actionLabelWidth).transform;
			this.references.inputGridActionColumn = transform;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00013D08 File Offset: 0x00011F08
		private void CreateKeyboardInputFieldColumn()
		{
			if (!this._showKeyboard)
			{
				return;
			}
			this.CreateInputFieldColumn("KeyboardColumn", ControllerType.Keyboard, this._keyboardColMaxWidth, this._keyboardInputFieldCount, true);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00013D2C File Offset: 0x00011F2C
		private void CreateMouseInputFieldColumn()
		{
			if (!this._showMouse)
			{
				return;
			}
			this.CreateInputFieldColumn("MouseColumn", ControllerType.Mouse, this._mouseColMaxWidth, this._mouseInputFieldCount, false);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00013D50 File Offset: 0x00011F50
		private void CreateControllerInputFieldColumn()
		{
			if (!this._showControllers)
			{
				return;
			}
			this.CreateInputFieldColumn("ControllerColumn", ControllerType.Joystick, this._controllerColMaxWidth, this._controllerInputFieldCount, false);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x0013F890 File Offset: 0x0013DA90
		private void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
			Transform transform = this.CreateNewColumnGroup(name, this.references.inputGridInnerGroup, maxWidth).transform;
			switch (controllerType)
			{
			case ControllerType.Keyboard:
				this.references.inputGridKeyboardColumn = transform;
				return;
			case ControllerType.Mouse:
				this.references.inputGridMouseColumn = transform;
				return;
			case ControllerType.Joystick:
				this.references.inputGridControllerColumn = transform;
				return;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x0013F8F4 File Offset: 0x0013DAF4
		private void CreateInputActionLabels()
		{
			Transform inputGridActionColumn = this.references.inputGridActionColumn;
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.isValid)
				{
					int num = 0;
					if (mappingSet.actionListMode == ControlMapper.MappingSet.ActionListMode.ActionCategory)
					{
						int num2 = 0;
						IList<int> actionCategoryIds = mappingSet.actionCategoryIds;
						for (int j = 0; j < actionCategoryIds.Count; j++)
						{
							InputCategory actionCategory = ReInput.mapping.GetActionCategory(actionCategoryIds[j]);
							if (actionCategory != null && actionCategory.userAssignable && this.CountIEnumerable<InputAction>(ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id)) != 0)
							{
								if (this._showActionCategoryLabels)
								{
									if (num2 > 0)
									{
										num -= this._inputRowCategorySpacing;
									}
									ControlMapper.GUILabel guilabel = this.CreateLabel(actionCategory.descriptiveName, inputGridActionColumn, new Vector2(0f, (float)num));
									guilabel.SetFontStyle(FontStyle.Bold);
									guilabel.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
									this.inputGrid.AddActionCategoryLabel(mappingSet.mapCategoryId, actionCategory.id, guilabel);
									num -= this._inputRowHeight;
								}
								foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id, true))
								{
									if (inputAction.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											ControlMapper.GUILabel guilabel2 = this.CreateLabel(inputAction.descriptiveName, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Full, guilabel2);
											num -= this._inputRowHeight;
										}
										if (this._showSplitAxisInputFields)
										{
											string labelText = (!string.IsNullOrEmpty(inputAction.positiveDescriptiveName)) ? inputAction.positiveDescriptiveName : (inputAction.descriptiveName + " +");
											ControlMapper.GUILabel guilabel2 = this.CreateLabel(labelText, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Positive, guilabel2);
											num -= this._inputRowHeight;
											string labelText2 = (!string.IsNullOrEmpty(inputAction.negativeDescriptiveName)) ? inputAction.negativeDescriptiveName : (inputAction.descriptiveName + " -");
											guilabel2 = this.CreateLabel(labelText2, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Negative, guilabel2);
											num -= this._inputRowHeight;
										}
									}
									else if (inputAction.type == InputActionType.Button)
									{
										ControlMapper.GUILabel guilabel2 = this.CreateLabel(inputAction.descriptiveName, inputGridActionColumn, new Vector2(0f, (float)num));
										guilabel2.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
										this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, inputAction.id, AxisRange.Positive, guilabel2);
										num -= this._inputRowHeight;
									}
								}
								num2++;
							}
						}
					}
					else
					{
						IList<int> actionIds = mappingSet.actionIds;
						for (int k = 0; k < actionIds.Count; k++)
						{
							InputAction action = ReInput.mapping.GetAction(actionIds[k]);
							if (action != null && action.userAssignable)
							{
								InputCategory actionCategory2 = ReInput.mapping.GetActionCategory(action.categoryId);
								if (actionCategory2 != null && actionCategory2.userAssignable)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											ControlMapper.GUILabel guilabel3 = this.CreateLabel(action.descriptiveName, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Full, guilabel3);
											num -= this._inputRowHeight;
										}
										if (this._showSplitAxisInputFields)
										{
											ControlMapper.GUILabel guilabel3 = this.CreateLabel(action.positiveDescriptiveName, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Positive, guilabel3);
											num -= this._inputRowHeight;
											guilabel3 = this.CreateLabel(action.negativeDescriptiveName, inputGridActionColumn, new Vector2(0f, (float)num));
											guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
											this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Negative, guilabel3);
											num -= this._inputRowHeight;
										}
									}
									else if (action.type == InputActionType.Button)
									{
										ControlMapper.GUILabel guilabel3 = this.CreateLabel(action.descriptiveName, inputGridActionColumn, new Vector2(0f, (float)num));
										guilabel3.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
										this.inputGrid.AddActionLabel(mappingSet.mapCategoryId, action.id, AxisRange.Positive, guilabel3);
										num -= this._inputRowHeight;
									}
								}
							}
						}
					}
					this.inputGrid.SetColumnHeight(mappingSet.mapCategoryId, (float)(-(float)num));
				}
			}
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x0013FE58 File Offset: 0x0013E058
		private void CreateInputFields()
		{
			if (this._showControllers)
			{
				this.CreateInputFields(this.references.inputGridControllerColumn, ControllerType.Joystick, this._controllerColMaxWidth, this._controllerInputFieldCount, false);
			}
			if (this._showKeyboard)
			{
				this.CreateInputFields(this.references.inputGridKeyboardColumn, ControllerType.Keyboard, this._keyboardColMaxWidth, this._keyboardInputFieldCount, true);
			}
			if (this._showMouse)
			{
				this.CreateInputFields(this.references.inputGridMouseColumn, ControllerType.Mouse, this._mouseColMaxWidth, this._mouseInputFieldCount, false);
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x0013FEDC File Offset: 0x0013E0DC
		private void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null && mappingSet.isValid)
				{
					int fieldWidth = maxWidth / cols;
					int num = 0;
					int num2 = 0;
					if (mappingSet.actionListMode == ControlMapper.MappingSet.ActionListMode.ActionCategory)
					{
						IList<int> actionCategoryIds = mappingSet.actionCategoryIds;
						for (int j = 0; j < actionCategoryIds.Count; j++)
						{
							InputCategory actionCategory = ReInput.mapping.GetActionCategory(actionCategoryIds[j]);
							if (actionCategory != null && actionCategory.userAssignable && this.CountIEnumerable<InputAction>(ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id)) != 0)
							{
								if (this._showActionCategoryLabels)
								{
									num -= ((num2 > 0) ? (this._inputRowHeight + this._inputRowCategorySpacing) : this._inputRowHeight);
								}
								foreach (InputAction inputAction in ReInput.mapping.UserAssignableActionsInCategory(actionCategory.id, true))
								{
									if (inputAction.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Full, controllerType, cols, fieldWidth, ref num, disableFullAxis);
										}
										if (this._showSplitAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Positive, controllerType, cols, fieldWidth, ref num, false);
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Negative, controllerType, cols, fieldWidth, ref num, false);
										}
									}
									else if (inputAction.type == InputActionType.Button)
									{
										this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, inputAction, AxisRange.Positive, controllerType, cols, fieldWidth, ref num, false);
									}
									num2++;
								}
							}
						}
					}
					else
					{
						IList<int> actionIds = mappingSet.actionIds;
						for (int k = 0; k < actionIds.Count; k++)
						{
							InputAction action = ReInput.mapping.GetAction(actionIds[k]);
							if (action != null && action.userAssignable)
							{
								InputCategory actionCategory2 = ReInput.mapping.GetActionCategory(action.categoryId);
								if (actionCategory2 != null && actionCategory2.userAssignable)
								{
									if (action.type == InputActionType.Axis)
									{
										if (this._showFullAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Full, controllerType, cols, fieldWidth, ref num, disableFullAxis);
										}
										if (this._showSplitAxisInputFields)
										{
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Positive, controllerType, cols, fieldWidth, ref num, false);
											this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Negative, controllerType, cols, fieldWidth, ref num, false);
										}
									}
									else if (action.type == InputActionType.Button)
									{
										this.CreateInputFieldSet(columnXform, mappingSet.mapCategoryId, action, AxisRange.Positive, controllerType, cols, fieldWidth, ref num, false);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00140194 File Offset: 0x0013E394
		private void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis)
		{
			GameObject gameObject = this.CreateNewGUIObject("FieldLayoutGroup", parent, new Vector2(0f, (float)yPos));
			HorizontalLayoutGroup horizontalLayoutGroup = gameObject.AddComponent<HorizontalLayoutGroup>();
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 1f);
			component.anchorMax = new Vector2(1f, 1f);
			component.pivot = new Vector2(0f, 1f);
			component.sizeDelta = Vector2.zero;
			component.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)this._inputRowHeight);
			this.inputGrid.AddInputFieldSet(mapCategoryId, action, axisRange, controllerType, gameObject);
			for (int i = 0; i < cols; i++)
			{
				int num = (axisRange == AxisRange.Full) ? this._invertToggleWidth : 0;
				ControlMapper.GUIInputField guiinputField = this.CreateInputField(horizontalLayoutGroup.transform, Vector2.zero, "", action.id, axisRange, controllerType, i);
				guiinputField.SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType.PreferredSize, fieldWidth - num);
				this.inputGrid.AddInputField(mapCategoryId, action, axisRange, controllerType, i, guiinputField);
				if (axisRange == AxisRange.Full)
				{
					if (!disableFullAxis)
					{
						ControlMapper.GUIToggle guitoggle = this.CreateToggle(this.prefabs.inputGridFieldInvertToggle, horizontalLayoutGroup.transform, Vector2.zero, "", action.id, axisRange, controllerType, i);
						guitoggle.SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType.MinSize, num);
						guiinputField.AddToggle(guitoggle);
					}
					else
					{
						guiinputField.SetInteractible(false, false, true);
					}
				}
			}
			yPos -= this._inputRowHeight;
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x001402F8 File Offset: 0x0013E4F8
		private void PopulateInputFields()
		{
			this.inputGrid.InitializeFields(this.currentMapCategoryId);
			if (this.currentPlayer == null)
			{
				return;
			}
			this.inputGrid.SetFieldsActive(this.currentMapCategoryId, true);
			foreach (ControlMapper.InputActionSet actionSet in this.inputGrid.GetActionSets(this.currentMapCategoryId))
			{
				if (this._showKeyboard)
				{
					int layoutId = this._keyboardMapDefaultLayout;
					int maxFields = this._keyboardInputFieldCount;
					ControllerMap controllerMapOrCreateNew = this.GetControllerMapOrCreateNew(ControllerType.Keyboard, 0, layoutId);
					this.PopulateInputFieldGroup(actionSet, controllerMapOrCreateNew, ControllerType.Keyboard, 0, maxFields);
				}
				if (this._showMouse)
				{
					ControllerType controllerType = ControllerType.Mouse;
					int controllerId = 0;
					int layoutId = this._mouseMapDefaultLayout;
					int maxFields = this._mouseInputFieldCount;
					ControllerMap controllerMapOrCreateNew2 = this.GetControllerMapOrCreateNew(ControllerType.Mouse, 0, layoutId);
					if (this.currentPlayer.controllers.hasMouse)
					{
						this.PopulateInputFieldGroup(actionSet, controllerMapOrCreateNew2, controllerType, controllerId, maxFields);
					}
				}
				if (this.isJoystickSelected && this.currentPlayer.controllers.joystickCount > 0)
				{
					int controllerId = this.currentJoystick.id;
					int layoutId = this._joystickMapDefaultLayout;
					int maxFields = this._controllerInputFieldCount;
					ControllerMap controllerMapOrCreateNew3 = this.GetControllerMapOrCreateNew(ControllerType.Joystick, controllerId, layoutId);
					this.PopulateInputFieldGroup(actionSet, controllerMapOrCreateNew3, ControllerType.Joystick, controllerId, maxFields);
				}
				else
				{
					this.DisableInputFieldGroup(actionSet, ControllerType.Joystick, this._controllerInputFieldCount);
				}
			}
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x0014045C File Offset: 0x0013E65C
		private void PopulateInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields)
		{
			if (controllerMap == null)
			{
				return;
			}
			int num = 0;
			this.inputGrid.SetFixedFieldData(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId);
			foreach (ActionElementMap actionElementMap in controllerMap.ElementMapsWithAction(actionSet.actionId))
			{
				if (actionElementMap.elementType == ControllerElementType.Button)
				{
					if (actionSet.axisRange == AxisRange.Full)
					{
						continue;
					}
					if (actionSet.axisRange == AxisRange.Positive)
					{
						if (actionElementMap.axisContribution == Pole.Negative)
						{
							continue;
						}
					}
					else if (actionSet.axisRange == AxisRange.Negative && actionElementMap.axisContribution == Pole.Positive)
					{
						continue;
					}
					this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, actionElementMap.elementIdentifierName, false);
				}
				else if (actionElementMap.elementType == ControllerElementType.Axis)
				{
					if (actionSet.axisRange == AxisRange.Full)
					{
						if (actionElementMap.axisRange != AxisRange.Full)
						{
							continue;
						}
						this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, actionElementMap.elementIdentifierName, actionElementMap.invert);
					}
					else if (actionSet.axisRange == AxisRange.Positive)
					{
						if ((actionElementMap.axisRange == AxisRange.Full && ReInput.mapping.GetAction(actionSet.actionId).type != InputActionType.Button) || actionElementMap.axisContribution == Pole.Negative)
						{
							continue;
						}
						this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, actionElementMap.elementIdentifierName, false);
					}
					else if (actionSet.axisRange == AxisRange.Negative)
					{
						if (actionElementMap.axisRange == AxisRange.Full || actionElementMap.axisContribution == Pole.Positive)
						{
							continue;
						}
						this.inputGrid.PopulateField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, controllerId, num, actionElementMap.id, actionElementMap.elementIdentifierName, false);
					}
				}
				num++;
				if (num > maxFields)
				{
					break;
				}
			}
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00140664 File Offset: 0x0013E864
		private void DisableInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerType controllerType, int fieldCount)
		{
			for (int i = 0; i < fieldCount; i++)
			{
				ControlMapper.GUIInputField guiinputField = this.inputGrid.GetGUIInputField(this.currentMapCategoryId, actionSet.actionId, actionSet.axisRange, controllerType, i);
				if (guiinputField != null)
				{
					guiinputField.SetInteractible(false, false);
				}
			}
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x001406A8 File Offset: 0x0013E8A8
		private void ResetInputGridScrollBar()
		{
			this.references.inputGridInnerGroup.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
			this.references.inputGridVScrollbar.value = 1f;
			this.references.inputGridScrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHide;
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x001406F8 File Offset: 0x0013E8F8
		private void CreateLayout()
		{
			this.references.playersGroup.gameObject.SetActive(this.showPlayers);
			this.references.controllerGroup.gameObject.SetActive(this._showControllers);
			this.references.assignedControllersGroup.gameObject.SetActive(this._showControllers && this.ShowAssignedControllers());
			this.references.settingsAndMapCategoriesGroup.gameObject.SetActive(this.showSettings || this.showMapCategories);
			this.references.settingsGroup.gameObject.SetActive(this.showSettings);
			this.references.mapCategoriesGroup.gameObject.SetActive(this.showMapCategories);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00013D74 File Offset: 0x00011F74
		private void Draw()
		{
			this.DrawPlayersGroup();
			this.DrawControllersGroup();
			this.DrawSettingsGroup();
			this.DrawMapCategoriesGroup();
			this.DrawWindowButtonsGroup();
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x001407C0 File Offset: 0x0013E9C0
		private void DrawPlayersGroup()
		{
			if (!this.showPlayers)
			{
				return;
			}
			this.references.playersGroup.labelText = this._language.playersGroupLabel;
			this.references.playersGroup.SetLabelActive(this._showPlayersGroupLabel);
			for (int i = 0; i < this.playerCount; i++)
			{
				Player player = ReInput.players.GetPlayer(i);
				if (player != null)
				{
					ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(UITools.InstantiateGUIObject<ButtonInfo>(this.prefabs.button, this.references.playersGroup.content, "Player" + i + "Button"));
					guibutton.SetLabel(player.descriptiveName);
					guibutton.SetButtonInfoData("PlayerSelection", player.id);
					guibutton.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
					guibutton.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
					this.playerButtons.Add(guibutton);
				}
			}
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x001408C0 File Offset: 0x0013EAC0
		private void DrawControllersGroup()
		{
			if (!this._showControllers)
			{
				return;
			}
			this.references.controllerSettingsGroup.labelText = this._language.controllerSettingsGroupLabel;
			this.references.controllerSettingsGroup.SetLabelActive(this._showControllerGroupLabel);
			this.references.controllerNameLabel.gameObject.SetActive(this._showControllerNameLabel);
			this.references.controllerGroupLabelGroup.gameObject.SetActive(this._showControllerGroupLabel || this._showControllerNameLabel);
			if (this.ShowAssignedControllers())
			{
				this.references.assignedControllersGroup.labelText = this._language.assignedControllersGroupLabel;
				this.references.assignedControllersGroup.SetLabelActive(this._showAssignedControllersGroupLabel);
			}
			this.references.removeControllerButton.GetComponent<ButtonInfo>().text.text = this._language.removeControllerButtonLabel;
			this.references.calibrateControllerButton.GetComponent<ButtonInfo>().text.text = this._language.calibrateControllerButtonLabel;
			this.references.assignControllerButton.GetComponent<ButtonInfo>().text.text = this._language.assignControllerButtonLabel;
			ControlMapper.GUIButton guibutton = this.CreateButton(this._language.none, this.references.assignedControllersGroup.content, Vector2.zero);
			guibutton.SetInteractible(false, false, true);
			this.assignedControllerButtonsPlaceholder = guibutton;
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00140A28 File Offset: 0x0013EC28
		private void DrawSettingsGroup()
		{
			if (!this.showSettings)
			{
				return;
			}
			this.references.settingsGroup.labelText = this._language.settingsGroupLabel;
			this.references.settingsGroup.SetLabelActive(this._showSettingsGroupLabel);
			ControlMapper.GUIButton guibutton = this.CreateButton(this._language.inputBehaviorSettingsButtonLabel, this.references.settingsGroup.content, Vector2.zero);
			this.miscInstantiatedObjects.Add(guibutton.gameObject);
			guibutton.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
			guibutton.SetButtonInfoData("EditInputBehaviors", 0);
			guibutton.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00140ADC File Offset: 0x0013ECDC
		private void DrawMapCategoriesGroup()
		{
			if (!this.showMapCategories)
			{
				return;
			}
			if (this._mappingSets == null)
			{
				return;
			}
			this.references.mapCategoriesGroup.labelText = this._language.mapCategoriesGroupLabel;
			this.references.mapCategoriesGroup.SetLabelActive(this._showMapCategoriesGroupLabel);
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				ControlMapper.MappingSet mappingSet = this._mappingSets[i];
				if (mappingSet != null)
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(mappingSet.mapCategoryId);
					if (mapCategory != null)
					{
						ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(UITools.InstantiateGUIObject<ButtonInfo>(this.prefabs.button, this.references.mapCategoriesGroup.content, mapCategory.name + "Button"));
						guibutton.SetLabel(mapCategory.descriptiveName);
						guibutton.SetButtonInfoData("MapCategorySelection", mapCategory.id);
						guibutton.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
						guibutton.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
						this.mapCategoryButtons.Add(guibutton);
					}
				}
			}
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00140BF4 File Offset: 0x0013EDF4
		private void DrawWindowButtonsGroup()
		{
			this.references.doneButton.GetComponent<ButtonInfo>().text.text = this._language.doneButtonLabel;
			this.references.restoreDefaultsButton.GetComponent<ButtonInfo>().text.text = this._language.restoreDefaultsButtonLabel;
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00013D94 File Offset: 0x00011F94
		private void Redraw(bool listsChanged, bool playTransitions)
		{
			this.RedrawPlayerGroup(playTransitions);
			this.RedrawControllerGroup();
			this.RedrawMapCategoriesGroup(playTransitions);
			this.RedrawInputGrid(listsChanged);
			if (this.currentUISelection == null || !this.currentUISelection.activeInHierarchy)
			{
				this.RestoreLastUISelection();
			}
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00140C4C File Offset: 0x0013EE4C
		private void RedrawPlayerGroup(bool playTransitions)
		{
			if (!this.showPlayers)
			{
				return;
			}
			for (int i = 0; i < this.playerButtons.Count; i++)
			{
				bool state = this.currentPlayerId != this.playerButtons[i].buttonInfo.intData;
				this.playerButtons[i].SetInteractible(state, playTransitions);
			}
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00140CB0 File Offset: 0x0013EEB0
		private void RedrawControllerGroup()
		{
			int num = -1;
			this.references.controllerNameLabel.text = this._language.none;
			UITools.SetInteractable(this.references.removeControllerButton, false, false);
			UITools.SetInteractable(this.references.assignControllerButton, false, false);
			UITools.SetInteractable(this.references.calibrateControllerButton, false, false);
			if (this.ShowAssignedControllers())
			{
				foreach (ControlMapper.GUIButton guibutton in this.assignedControllerButtons)
				{
					if (!(guibutton.gameObject == null))
					{
						if (this.currentUISelection == guibutton.gameObject)
						{
							num = guibutton.buttonInfo.intData;
						}
						UnityEngine.Object.Destroy(guibutton.gameObject);
					}
				}
				this.assignedControllerButtons.Clear();
				this.assignedControllerButtonsPlaceholder.SetActive(true);
			}
			Player player = ReInput.players.GetPlayer(this.currentPlayerId);
			if (player == null)
			{
				return;
			}
			if (this.ShowAssignedControllers())
			{
				if (player.controllers.joystickCount > 0)
				{
					this.assignedControllerButtonsPlaceholder.SetActive(false);
				}
				foreach (Joystick joystick in player.controllers.Joysticks)
				{
					ControlMapper.GUIButton guibutton2 = this.CreateButton(joystick.name, this.references.assignedControllersGroup.content, Vector2.zero);
					guibutton2.SetButtonInfoData("AssignedControllerSelection", joystick.id);
					guibutton2.SetOnClickCallback(new Action<ButtonInfo>(this.OnButtonActivated));
					guibutton2.buttonInfo.OnSelectedEvent += this.OnUIElementSelected;
					this.assignedControllerButtons.Add(guibutton2);
					if (joystick.id == this.currentJoystickId)
					{
						guibutton2.SetInteractible(false, true);
					}
				}
				if (player.controllers.joystickCount > 0 && !this.isJoystickSelected)
				{
					this.currentJoystickId = player.controllers.Joysticks[0].id;
					this.assignedControllerButtons[0].SetInteractible(false, false);
				}
				if (num < 0)
				{
					goto IL_2AF;
				}
				using (List<ControlMapper.GUIButton>.Enumerator enumerator = this.assignedControllerButtons.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ControlMapper.GUIButton guibutton3 = enumerator.Current;
						if (guibutton3.buttonInfo.intData == num)
						{
							this.SetUISelection(guibutton3.gameObject);
							break;
						}
					}
					goto IL_2AF;
				}
			}
			if (player.controllers.joystickCount > 0 && !this.isJoystickSelected)
			{
				this.currentJoystickId = player.controllers.Joysticks[0].id;
			}
			IL_2AF:
			if (this.isJoystickSelected && player.controllers.joystickCount > 0)
			{
				this.references.removeControllerButton.interactable = true;
				this.references.controllerNameLabel.text = this.currentJoystick.name;
				if (this.currentJoystick.axisCount > 0)
				{
					this.references.calibrateControllerButton.interactable = true;
				}
			}
			int joystickCount = player.controllers.joystickCount;
			int joystickCount2 = ReInput.controllers.joystickCount;
			int maxControllersPerPlayer = this.GetMaxControllersPerPlayer();
			bool flag = maxControllersPerPlayer == 0;
			if (joystickCount2 > 0 && joystickCount < joystickCount2 && (maxControllersPerPlayer == 1 || flag || joystickCount < maxControllersPerPlayer))
			{
				UITools.SetInteractable(this.references.assignControllerButton, true, false);
			}
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00141044 File Offset: 0x0013F244
		private void RedrawMapCategoriesGroup(bool playTransitions)
		{
			if (!this.showMapCategories)
			{
				return;
			}
			for (int i = 0; i < this.mapCategoryButtons.Count; i++)
			{
				bool state = this.currentMapCategoryId != this.mapCategoryButtons[i].buttonInfo.intData;
				this.mapCategoryButtons[i].SetInteractible(state, playTransitions);
			}
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00013DD2 File Offset: 0x00011FD2
		private void RedrawInputGrid(bool listsChanged)
		{
			if (listsChanged)
			{
				this.RefreshInputGridStructure();
			}
			this.PopulateInputFields();
			if (listsChanged)
			{
				this.ResetInputGridScrollBar();
			}
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x00013DEC File Offset: 0x00011FEC
		private void ForceRefresh()
		{
			if (this.windowManager.isWindowOpen)
			{
				this.CloseAllWindows();
				return;
			}
			this.Redraw(false, false);
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00013E0A File Offset: 0x0001200A
		private void CreateInputCategoryRow(ref int rowCount, InputCategory category)
		{
			this.CreateLabel(category.descriptiveName, this.references.inputGridActionColumn, new Vector2(0f, (float)(rowCount * this._inputRowHeight) * -1f));
			rowCount++;
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x00013E44 File Offset: 0x00012044
		private ControlMapper.GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset)
		{
			return this.CreateLabel(this.prefabs.inputGridLabel, labelText, parent, offset);
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x001410A8 File Offset: 0x0013F2A8
		private ControlMapper.GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset)
		{
			GameObject gameObject = this.InstantiateGUIObject(prefab, parent, offset);
			Text componentInSelfOrChildren = UnityTools.GetComponentInSelfOrChildren<Text>(gameObject);
			if (componentInSelfOrChildren == null)
			{
				Debug.LogError("Rewired Control Mapper: Label prefab is missing Text component!");
				return null;
			}
			componentInSelfOrChildren.text = labelText;
			return new ControlMapper.GUILabel(gameObject);
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00013E5A File Offset: 0x0001205A
		private ControlMapper.GUIButton CreateButton(string labelText, Transform parent, Vector2 offset)
		{
			ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(this.InstantiateGUIObject(this.prefabs.button, parent, offset));
			guibutton.SetLabel(labelText);
			return guibutton;
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x00013E7B File Offset: 0x0001207B
		private ControlMapper.GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset)
		{
			ControlMapper.GUIButton guibutton = new ControlMapper.GUIButton(this.InstantiateGUIObject(this.prefabs.fitButton, parent, offset));
			guibutton.SetLabel(labelText);
			return guibutton;
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x001410EC File Offset: 0x0013F2EC
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			ControlMapper.GUIInputField guiinputField = this.CreateInputField(parent, offset);
			guiinputField.SetLabel("");
			guiinputField.SetFieldInfoData(actionId, axisRange, controllerType, fieldIndex);
			guiinputField.SetOnClickCallback(this.inputFieldActivatedDelegate);
			guiinputField.fieldInfo.OnSelectedEvent += this.OnUIElementSelected;
			return guiinputField;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00013E9C File Offset: 0x0001209C
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset)
		{
			return new ControlMapper.GUIInputField(this.InstantiateGUIObject(this.prefabs.inputGridFieldButton, parent, offset));
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00013EB6 File Offset: 0x000120B6
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			ControlMapper.GUIToggle guitoggle = this.CreateToggle(prefab, parent, offset);
			guitoggle.SetToggleInfoData(actionId, axisRange, controllerType, fieldIndex);
			guitoggle.SetOnSubmitCallback(this.inputFieldInvertToggleStateChangedDelegate);
			guitoggle.toggleInfo.OnSelectedEvent += this.OnUIElementSelected;
			return guitoggle;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00013EF2 File Offset: 0x000120F2
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset)
		{
			return new ControlMapper.GUIToggle(this.InstantiateGUIObject(prefab, parent, offset));
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00141140 File Offset: 0x0013F340
		private GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset)
		{
			if (prefab == null)
			{
				Debug.LogError("Rewired Control Mapper: Prefab is null!");
				return null;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(prefab);
			return this.InitializeNewGUIGameObject(gameObject, parent, offset);
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00141174 File Offset: 0x0013F374
		private GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset)
		{
			GameObject gameObject = new GameObject();
			gameObject.name = name;
			gameObject.AddComponent<RectTransform>();
			return this.InitializeNewGUIGameObject(gameObject, parent, offset);
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x001411A0 File Offset: 0x0013F3A0
		private GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset)
		{
			if (gameObject == null)
			{
				Debug.LogError("Rewired Control Mapper: GameObject is null!");
				return null;
			}
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (component == null)
			{
				Debug.LogError("Rewired Control Mapper: GameObject does not have a RectTransform component!");
				return gameObject;
			}
			if (parent != null)
			{
				component.SetParent(parent, false);
			}
			component.anchoredPosition = offset;
			return gameObject;
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x001411F8 File Offset: 0x0013F3F8
		private GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth)
		{
			GameObject gameObject = this.CreateNewGUIObject(name, parent, Vector2.zero);
			this.inputGrid.AddGroup(gameObject);
			LayoutElement layoutElement = gameObject.AddComponent<LayoutElement>();
			if (maxWidth >= 0)
			{
				layoutElement.preferredWidth = (float)maxWidth;
			}
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 0f);
			component.anchorMax = new Vector2(1f, 0f);
			return gameObject;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00013F02 File Offset: 0x00012102
		private Window OpenWindow(bool closeOthers)
		{
			return this.OpenWindow(string.Empty, closeOthers);
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00141264 File Offset: 0x0013F464
		private Window OpenWindow(string name, bool closeOthers)
		{
			if (closeOthers)
			{
				this.windowManager.CancelAll();
			}
			Window window = this.windowManager.OpenWindow(name, this._defaultWindowWidth, this._defaultWindowHeight);
			if (window == null)
			{
				return null;
			}
			this.ChildWindowOpened();
			return window;
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00013F10 File Offset: 0x00012110
		private Window OpenWindow(GameObject windowPrefab, bool closeOthers)
		{
			return this.OpenWindow(windowPrefab, string.Empty, closeOthers);
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x001412AC File Offset: 0x0013F4AC
		private Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers)
		{
			if (closeOthers)
			{
				this.windowManager.CancelAll();
			}
			Window window = this.windowManager.OpenWindow(windowPrefab, name);
			if (window == null)
			{
				return null;
			}
			this.ChildWindowOpened();
			return window;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x001412E8 File Offset: 0x0013F4E8
		private void OpenModal(string title, string message, string confirmText, Action<int> confirmAction, string cancelText, Action<int> cancelAction, bool closeOthers)
		{
			Window window = this.OpenWindow(closeOthers);
			if (window == null)
			{
				return;
			}
			window.CreateTitleText(this.prefabs.windowTitleText, Vector2.zero, title);
			window.AddContentText(this.prefabs.windowContentText, UIPivot.TopCenter, UIAnchor.TopHStretch, new Vector2(0f, -100f), message);
			UnityAction unityAction = delegate()
			{
				this.OnWindowCancel(window.id);
			};
			window.cancelCallback = unityAction;
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomLeft, UIAnchor.BottomLeft, Vector2.zero, confirmText, delegate()
			{
				this.OnRestoreDefaultsConfirmed(window.id);
			}, unityAction, false);
			window.CreateButton(this.prefabs.fitButton, UIPivot.BottomRight, UIAnchor.BottomRight, Vector2.zero, cancelText, unityAction, unityAction, true);
			this.windowManager.Focus(window);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00013F1F File Offset: 0x0001211F
		private void CloseWindow(int windowId)
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.windowManager.CloseWindow(windowId);
			this.ChildWindowClosed();
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00013F41 File Offset: 0x00012141
		private void CloseTopWindow()
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.windowManager.CloseTop();
			this.ChildWindowClosed();
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00013F62 File Offset: 0x00012162
		private void CloseAllWindows()
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.windowManager.CancelAll();
			this.ChildWindowClosed();
			this.InputPollingStopped();
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00013F89 File Offset: 0x00012189
		private void ChildWindowOpened()
		{
			if (!this.windowManager.isWindowOpen)
			{
				return;
			}
			this.SetIsFocused(false);
			if (this._PopupWindowOpenedEvent != null)
			{
				this._PopupWindowOpenedEvent();
			}
			if (this._onPopupWindowOpened != null)
			{
				this._onPopupWindowOpened.Invoke();
			}
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00013FC6 File Offset: 0x000121C6
		private void ChildWindowClosed()
		{
			if (this.windowManager.isWindowOpen)
			{
				return;
			}
			this.SetIsFocused(true);
			if (this._PopupWindowClosedEvent != null)
			{
				this._PopupWindowClosedEvent();
			}
			if (this._onPopupWindowClosed != null)
			{
				this._onPopupWindowClosed.Invoke();
			}
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x001413F4 File Offset: 0x0013F5F4
		private bool HasElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			if (player == null || mapping == null)
			{
				return false;
			}
			ElementAssignmentConflictCheck conflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out conflictCheck))
			{
				return false;
			}
			if (skipOtherPlayers)
			{
				return ReInput.players.SystemPlayer.controllers.conflictChecking.DoesElementAssignmentConflict(conflictCheck) || player.controllers.conflictChecking.DoesElementAssignmentConflict(conflictCheck);
			}
			return ReInput.controllers.conflictChecking.DoesElementAssignmentConflict(conflictCheck);
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00141460 File Offset: 0x0013F660
		private bool IsBlockingAssignmentConflict(ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			ElementAssignmentConflictCheck conflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out conflictCheck))
			{
				return false;
			}
			if (skipOtherPlayers)
			{
				foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo in ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck))
				{
					if (!elementAssignmentConflictInfo.isUserAssignable)
					{
						return true;
					}
				}
				using (IEnumerator<ElementAssignmentConflictInfo> enumerator = this.currentPlayer.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ElementAssignmentConflictInfo elementAssignmentConflictInfo2 = enumerator.Current;
						if (!elementAssignmentConflictInfo2.isUserAssignable)
						{
							return true;
						}
					}
					return false;
				}
			}
			foreach (ElementAssignmentConflictInfo elementAssignmentConflictInfo3 in ReInput.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck))
			{
				if (!elementAssignmentConflictInfo3.isUserAssignable)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00014003 File Offset: 0x00012203
		private IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			ControlMapper.<ElementAssignmentConflicts>d__406 <ElementAssignmentConflicts>d__ = new ControlMapper.<ElementAssignmentConflicts>d__406(-2);
			<ElementAssignmentConflicts>d__.<>4__this = this;
			<ElementAssignmentConflicts>d__.<>3__player = player;
			<ElementAssignmentConflicts>d__.<>3__mapping = mapping;
			<ElementAssignmentConflicts>d__.<>3__assignment = assignment;
			<ElementAssignmentConflicts>d__.<>3__skipOtherPlayers = skipOtherPlayers;
			return <ElementAssignmentConflicts>d__;
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00141584 File Offset: 0x0013F784
		private bool CreateConflictCheck(ControlMapper.InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck)
		{
			if (mapping != null && this.currentPlayer != null)
			{
				conflictCheck = assignment.ToElementAssignmentConflictCheck();
				conflictCheck.playerId = this.currentPlayer.id;
				conflictCheck.controllerType = mapping.controllerType;
				conflictCheck.controllerId = mapping.controllerId;
				conflictCheck.controllerMapId = mapping.map.id;
				conflictCheck.controllerMapCategoryId = mapping.map.categoryId;
				if (mapping.aem != null)
				{
					conflictCheck.elementMapId = mapping.aem.id;
				}
				return true;
			}
			conflictCheck = default(ElementAssignmentConflictCheck);
			return false;
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00141618 File Offset: 0x0013F818
		private void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label)
		{
			pollingInfo = default(ControllerPollingInfo);
			label = string.Empty;
			modifierKeyPressed = false;
			modifierFlags = ModifierKeyFlags.None;
			int num = 0;
			ControllerPollingInfo controllerPollingInfo = default(ControllerPollingInfo);
			ControllerPollingInfo controllerPollingInfo2 = default(ControllerPollingInfo);
			ModifierKeyFlags modifierKeyFlags = ModifierKeyFlags.None;
			foreach (ControllerPollingInfo controllerPollingInfo3 in ReInput.controllers.Keyboard.PollForAllKeys())
			{
				KeyCode keyboardKey = controllerPollingInfo3.keyboardKey;
				if (keyboardKey != KeyCode.AltGr)
				{
					if (Keyboard.IsModifierKey(controllerPollingInfo3.keyboardKey))
					{
						if (num == 0)
						{
							controllerPollingInfo2 = controllerPollingInfo3;
						}
						modifierKeyFlags |= Keyboard.KeyCodeToModifierKeyFlags(keyboardKey);
						num++;
					}
					else if (controllerPollingInfo.keyboardKey == KeyCode.None)
					{
						controllerPollingInfo = controllerPollingInfo3;
					}
				}
			}
			if (controllerPollingInfo.keyboardKey == KeyCode.None)
			{
				if (num > 0)
				{
					modifierKeyPressed = true;
					if (num == 1)
					{
						if (ReInput.controllers.Keyboard.GetKeyTimePressed(controllerPollingInfo2.keyboardKey) > 1f)
						{
							pollingInfo = controllerPollingInfo2;
							return;
						}
						label = Keyboard.GetKeyName(controllerPollingInfo2.keyboardKey);
						return;
					}
					else
					{
						label = Keyboard.ModifierKeyFlagsToString(modifierKeyFlags);
					}
				}
				return;
			}
			if (!ReInput.controllers.Keyboard.GetKeyDown(controllerPollingInfo.keyboardKey))
			{
				return;
			}
			if (num == 0)
			{
				pollingInfo = controllerPollingInfo;
				return;
			}
			pollingInfo = controllerPollingInfo;
			modifierFlags = modifierKeyFlags;
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x0014175C File Offset: 0x0013F95C
		private bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers)
		{
			if (this.GetFirstElementAssignmentConflict(this.currentPlayer, conflictCheck, out conflict))
			{
				return true;
			}
			if (this.GetFirstElementAssignmentConflict(ReInput.players.SystemPlayer, conflictCheck, out conflict))
			{
				return true;
			}
			if (!skipOtherPlayers)
			{
				IList<Player> players = ReInput.players.Players;
				for (int i = 0; i < players.Count; i++)
				{
					Player player = players[i];
					if (player != this.currentPlayer && this.GetFirstElementAssignmentConflict(player, conflictCheck, out conflict))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x001417D4 File Offset: 0x0013F9D4
		private bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict)
		{
			using (IEnumerator<ElementAssignmentConflictInfo> enumerator = player.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ElementAssignmentConflictInfo elementAssignmentConflictInfo = enumerator.Current;
					conflict = elementAssignmentConflictInfo;
					return true;
				}
			}
			conflict = default(ElementAssignmentConflictInfo);
			return false;
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00141838 File Offset: 0x0013FA38
		private void StartAxisCalibration(int axisIndex)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			if (this.currentPlayer.controllers.joystickCount == 0)
			{
				return;
			}
			Joystick currentJoystick = this.currentJoystick;
			if (axisIndex >= 0 && axisIndex < currentJoystick.axisCount)
			{
				this.pendingAxisCalibration = new ControlMapper.AxisCalibrator(currentJoystick, axisIndex);
				this.ShowCalibrateAxisStep1Window();
				return;
			}
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00014030 File Offset: 0x00012230
		private void EndAxisCalibration()
		{
			if (this.pendingAxisCalibration == null)
			{
				return;
			}
			this.pendingAxisCalibration.Commit();
			this.pendingAxisCalibration = null;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x0001404D File Offset: 0x0001224D
		private void SetUISelection(GameObject selection)
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(selection);
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00014068 File Offset: 0x00012268
		private void RestoreLastUISelection()
		{
			if (!(this.lastUISelection == null) && this.lastUISelection.activeInHierarchy)
			{
				this.SetUISelection(this.lastUISelection);
				return;
			}
			this.SetDefaultUISelection();
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00014098 File Offset: 0x00012298
		private void SetDefaultUISelection()
		{
			if (!this.isOpen)
			{
				return;
			}
			if (this.references.defaultSelection == null)
			{
				this.SetUISelection(null);
				return;
			}
			this.SetUISelection(this.references.defaultSelection.gameObject);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x0014188C File Offset: 0x0013FA8C
		private void SelectDefaultMapCategory(bool redraw)
		{
			this.currentMapCategoryId = this.GetDefaultMapCategoryId();
			this.OnMapCategorySelected(this.currentMapCategoryId, redraw);
			if (!this.showMapCategories)
			{
				return;
			}
			int i = 0;
			while (i < this._mappingSets.Length)
			{
				if (ReInput.mapping.GetMapCategory(this._mappingSets[i].mapCategoryId) == null)
				{
					i++;
				}
				else
				{
					this.currentMapCategoryId = this._mappingSets[i].mapCategoryId;
					IL_63:
					if (this.currentMapCategoryId < 0)
					{
						return;
					}
					for (int j = 0; j < this._mappingSets.Length; j++)
					{
						bool state = this._mappingSets[j].mapCategoryId != this.currentMapCategoryId;
						this.mapCategoryButtons[j].SetInteractible(state, false);
					}
					return;
				}
			}
			goto IL_63;
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000140D4 File Offset: 0x000122D4
		private void CheckUISelection()
		{
			if (!this.isFocused)
			{
				return;
			}
			if (this.currentUISelection == null)
			{
				this.RestoreLastUISelection();
			}
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000140F3 File Offset: 0x000122F3
		private void OnUIElementSelected(GameObject selectedObject)
		{
			this.lastUISelection = selectedObject;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x000140FC File Offset: 0x000122FC
		private void SetIsFocused(bool state)
		{
			this.references.mainCanvasGroup.interactable = state;
			if (state)
			{
				this.Redraw(false, false);
				this.RestoreLastUISelection();
				this.blockInputOnFocusEndTime = Time.unscaledTime + 0.1f;
			}
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00014131 File Offset: 0x00012331
		public void Toggle()
		{
			if (this.isOpen)
			{
				this.Close(true);
				return;
			}
			this.Open();
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00014149 File Offset: 0x00012349
		public void Open()
		{
			this.Open(false);
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00141948 File Offset: 0x0013FB48
		private void Open(bool force)
		{
			if (!this.initialized)
			{
				this.Initialize();
			}
			if (!this.initialized)
			{
				return;
			}
			if (!force && this.isOpen)
			{
				return;
			}
			this.Clear();
			this.canvas.SetActive(true);
			this.OnPlayerSelected(0, false);
			this.SelectDefaultMapCategory(false);
			this.SetDefaultUISelection();
			this.Redraw(true, false);
			if (this._ScreenOpenedEvent != null)
			{
				this._ScreenOpenedEvent();
			}
			if (this._onScreenOpened != null)
			{
				this._onScreenOpened.Invoke();
			}
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x001419D0 File Offset: 0x0013FBD0
		public void Close(bool save)
		{
			if (!this.initialized)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (save && ReInput.userDataStore != null)
			{
				ReInput.userDataStore.Save();
			}
			this.Clear();
			this.canvas.SetActive(false);
			this.SetUISelection(null);
			if (this._ScreenClosedEvent != null)
			{
				this._ScreenClosedEvent();
			}
			if (this._onScreenClosed != null)
			{
				this._onScreenClosed.Invoke();
			}
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00014152 File Offset: 0x00012352
		private void Clear()
		{
			this.windowManager.CancelAll();
			this.lastUISelection = null;
			this.pendingInputMapping = null;
			this.pendingAxisCalibration = null;
			this.InputPollingStopped();
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x0001417A File Offset: 0x0001237A
		private void ClearCompletely()
		{
			this.ClearSpawnedObjects();
			this.ClearAllVars();
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00141A44 File Offset: 0x0013FC44
		private void ClearSpawnedObjects()
		{
			this.windowManager.ClearCompletely();
			this.inputGrid.ClearAll();
			foreach (ControlMapper.GUIButton guibutton in this.playerButtons)
			{
				UnityEngine.Object.Destroy(guibutton.gameObject);
			}
			this.playerButtons.Clear();
			foreach (ControlMapper.GUIButton guibutton2 in this.mapCategoryButtons)
			{
				UnityEngine.Object.Destroy(guibutton2.gameObject);
			}
			this.mapCategoryButtons.Clear();
			foreach (ControlMapper.GUIButton guibutton3 in this.assignedControllerButtons)
			{
				UnityEngine.Object.Destroy(guibutton3.gameObject);
			}
			this.assignedControllerButtons.Clear();
			if (this.assignedControllerButtonsPlaceholder != null)
			{
				UnityEngine.Object.Destroy(this.assignedControllerButtonsPlaceholder.gameObject);
				this.assignedControllerButtonsPlaceholder = null;
			}
			foreach (GameObject obj in this.miscInstantiatedObjects)
			{
				UnityEngine.Object.Destroy(obj);
			}
			this.miscInstantiatedObjects.Clear();
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00014188 File Offset: 0x00012388
		private void ClearVarsOnPlayerChange()
		{
			this.currentJoystickId = -1;
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00014188 File Offset: 0x00012388
		private void ClearVarsOnJoystickChange()
		{
			this.currentJoystickId = -1;
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00141BC8 File Offset: 0x0013FDC8
		private void ClearAllVars()
		{
			this.initialized = false;
			ControlMapper.Instance = null;
			this.playerCount = 0;
			this.inputGrid = null;
			this.windowManager = null;
			this.currentPlayerId = -1;
			this.currentMapCategoryId = -1;
			this.playerButtons = null;
			this.mapCategoryButtons = null;
			this.miscInstantiatedObjects = null;
			this.canvas = null;
			this.lastUISelection = null;
			this.currentJoystickId = -1;
			this.pendingInputMapping = null;
			this.pendingAxisCalibration = null;
			this.inputFieldActivatedDelegate = null;
			this.inputFieldInvertToggleStateChangedDelegate = null;
			this.isPollingForInput = false;
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00014191 File Offset: 0x00012391
		public void Reset()
		{
			if (!this.initialized)
			{
				return;
			}
			this.ClearCompletely();
			this.Initialize();
			if (this.isOpen)
			{
				this.Open(true);
			}
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x00141C54 File Offset: 0x0013FE54
		private void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId)
		{
			if (this.currentPlayer == null)
			{
				return;
			}
			ControllerMapWithAxes controllerMapWithAxes = this.GetControllerMap(controllerType) as ControllerMapWithAxes;
			if (controllerMapWithAxes == null)
			{
				return;
			}
			ActionElementMap elementMap = controllerMapWithAxes.GetElementMap(actionElementMapId);
			if (elementMap == null)
			{
				return;
			}
			elementMap.invert = state;
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00141C90 File Offset: 0x0013FE90
		private ControllerMap GetControllerMap(ControllerType type)
		{
			if (this.currentPlayer == null)
			{
				return null;
			}
			int controllerId = 0;
			switch (type)
			{
			case ControllerType.Keyboard:
			case ControllerType.Mouse:
				break;
			case ControllerType.Joystick:
				if (this.currentPlayer.controllers.joystickCount <= 0)
				{
					return null;
				}
				controllerId = this.currentJoystick.id;
				break;
			default:
				throw new NotImplementedException();
			}
			return this.currentPlayer.controllers.maps.GetFirstMapInCategory(type, controllerId, this.currentMapCategoryId);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x00141D00 File Offset: 0x0013FF00
		private ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId)
		{
			ControllerMap controllerMap = this.GetControllerMap(controllerType);
			if (controllerMap == null)
			{
				this.currentPlayer.controllers.maps.AddEmptyMap(controllerType, controllerId, this.currentMapCategoryId, layoutId);
				controllerMap = this.currentPlayer.controllers.maps.GetMap(controllerType, controllerId, this.currentMapCategoryId, layoutId);
			}
			return controllerMap;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00141D58 File Offset: 0x0013FF58
		private int CountIEnumerable<T>(IEnumerable<T> enumerable)
		{
			if (enumerable == null)
			{
				return 0;
			}
			IEnumerator<T> enumerator = enumerable.GetEnumerator();
			if (enumerator == null)
			{
				return 0;
			}
			int num = 0;
			while (enumerator.MoveNext())
			{
				num++;
			}
			return num;
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00141D88 File Offset: 0x0013FF88
		private int GetDefaultMapCategoryId()
		{
			if (this._mappingSets.Length == 0)
			{
				return 0;
			}
			for (int i = 0; i < this._mappingSets.Length; i++)
			{
				if (ReInput.mapping.GetMapCategory(this._mappingSets[i].mapCategoryId) != null)
				{
					return this._mappingSets[i].mapCategoryId;
				}
			}
			return 0;
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00141DDC File Offset: 0x0013FFDC
		private void SubscribeFixedUISelectionEvents()
		{
			if (this.references.fixedSelectableUIElements == null)
			{
				return;
			}
			GameObject[] fixedSelectableUIElements = this.references.fixedSelectableUIElements;
			for (int i = 0; i < fixedSelectableUIElements.Length; i++)
			{
				UIElementInfo component = UnityTools.GetComponent<UIElementInfo>(fixedSelectableUIElements[i]);
				if (!(component == null))
				{
					component.OnSelectedEvent += this.OnUIElementSelected;
				}
			}
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00141E38 File Offset: 0x00140038
		private void SubscribeMenuControlInputEvents()
		{
			this.SubscribeRewiredInputEventAllPlayers(this._screenToggleAction, new Action<InputActionEventData>(this.OnScreenToggleActionPressed));
			this.SubscribeRewiredInputEventAllPlayers(this._screenOpenAction, new Action<InputActionEventData>(this.OnScreenOpenActionPressed));
			this.SubscribeRewiredInputEventAllPlayers(this._screenCloseAction, new Action<InputActionEventData>(this.OnScreenCloseActionPressed));
			this.SubscribeRewiredInputEventAllPlayers(this._universalCancelAction, new Action<InputActionEventData>(this.OnUniversalCancelActionPressed));
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00141EA8 File Offset: 0x001400A8
		private void UnsubscribeMenuControlInputEvents()
		{
			this.UnsubscribeRewiredInputEventAllPlayers(this._screenToggleAction, new Action<InputActionEventData>(this.OnScreenToggleActionPressed));
			this.UnsubscribeRewiredInputEventAllPlayers(this._screenOpenAction, new Action<InputActionEventData>(this.OnScreenOpenActionPressed));
			this.UnsubscribeRewiredInputEventAllPlayers(this._screenCloseAction, new Action<InputActionEventData>(this.OnScreenCloseActionPressed));
			this.UnsubscribeRewiredInputEventAllPlayers(this._universalCancelAction, new Action<InputActionEventData>(this.OnUniversalCancelActionPressed));
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00141F18 File Offset: 0x00140118
		private void SubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
			if (actionId < 0 || callback == null)
			{
				return;
			}
			if (ReInput.mapping.GetAction(actionId) == null)
			{
				Debug.LogWarning("Rewired Control Mapper: " + actionId + " is not a valid Action id!");
				return;
			}
			foreach (Player player in ReInput.players.AllPlayers)
			{
				player.AddInputEventDelegate(callback, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, actionId);
			}
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00141F9C File Offset: 0x0014019C
		private void UnsubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
			if (actionId < 0 || callback == null)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput.mapping.GetAction(actionId) == null)
			{
				Debug.LogWarning("Rewired Control Mapper: " + actionId + " is not a valid Action id!");
				return;
			}
			foreach (Player player in ReInput.players.AllPlayers)
			{
				player.RemoveInputEventDelegate(callback, UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, actionId);
			}
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000141B7 File Offset: 0x000123B7
		private int GetMaxControllersPerPlayer()
		{
			if (this._rewiredInputManager.userData.ConfigVars.autoAssignJoysticks)
			{
				return this._rewiredInputManager.userData.ConfigVars.maxJoysticksPerPlayer;
			}
			return this._maxControllersPerPlayer;
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000141EC File Offset: 0x000123EC
		private bool ShowAssignedControllers()
		{
			return this._showControllers && (this._showAssignedControllers || this.GetMaxControllersPerPlayer() != 1);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x0001420E File Offset: 0x0001240E
		private void InspectorPropertyChanged(bool reset = false)
		{
			if (reset)
			{
				this.Reset();
			}
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00142028 File Offset: 0x00140228
		private void AssignController(Player player, int controllerId)
		{
			if (player == null)
			{
				return;
			}
			if (player.controllers.ContainsController(ControllerType.Joystick, controllerId))
			{
				return;
			}
			if (this.GetMaxControllersPerPlayer() == 1)
			{
				this.RemoveAllControllers(player);
				this.ClearVarsOnJoystickChange();
			}
			foreach (Player player2 in ReInput.players.Players)
			{
				if (player2 != player)
				{
					this.RemoveController(player2, controllerId);
				}
			}
			player.controllers.AddController(ControllerType.Joystick, controllerId, false);
			if (ReInput.userDataStore != null)
			{
				ReInput.userDataStore.LoadControllerData(player.id, ControllerType.Joystick, controllerId);
			}
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x001420D0 File Offset: 0x001402D0
		private void RemoveAllControllers(Player player)
		{
			if (player == null)
			{
				return;
			}
			IList<Joystick> joysticks = player.controllers.Joysticks;
			for (int i = joysticks.Count - 1; i >= 0; i--)
			{
				this.RemoveController(player, joysticks[i].id);
			}
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00014219 File Offset: 0x00012419
		private void RemoveController(Player player, int controllerId)
		{
			if (player == null)
			{
				return;
			}
			if (!player.controllers.ContainsController(ControllerType.Joystick, controllerId))
			{
				return;
			}
			if (ReInput.userDataStore != null)
			{
				ReInput.userDataStore.SaveControllerData(player.id, ControllerType.Joystick, controllerId);
			}
			player.controllers.RemoveController(ControllerType.Joystick, controllerId);
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00014255 File Offset: 0x00012455
		private bool IsAllowedAssignment(ControlMapper.InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo)
		{
			return pendingInputMapping != null && (pendingInputMapping.axisRange != AxisRange.Full || this._showSplitAxisInputFields || pollingInfo.elementType != ControllerElementType.Button);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00014279 File Offset: 0x00012479
		private void InputPollingStarted()
		{
			bool flag = this.isPollingForInput;
			this.isPollingForInput = true;
			if (!flag)
			{
				if (this._InputPollingStartedEvent != null)
				{
					this._InputPollingStartedEvent();
				}
				if (this._onInputPollingStarted != null)
				{
					this._onInputPollingStarted.Invoke();
				}
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x000142B0 File Offset: 0x000124B0
		private void InputPollingStopped()
		{
			bool flag = this.isPollingForInput;
			this.isPollingForInput = false;
			if (flag)
			{
				if (this._InputPollingEndedEvent != null)
				{
					this._InputPollingEndedEvent();
				}
				if (this._onInputPollingEnded != null)
				{
					this._onInputPollingEnded.Invoke();
				}
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000142E7 File Offset: 0x000124E7
		private int GetControllerInputFieldCount(ControllerType controllerType)
		{
			switch (controllerType)
			{
			case ControllerType.Keyboard:
				return this._keyboardInputFieldCount;
			case ControllerType.Mouse:
				return this._mouseInputFieldCount;
			case ControllerType.Joystick:
				return this._controllerInputFieldCount;
			default:
				throw new NotImplementedException();
			}
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00142114 File Offset: 0x00140314
		private bool ShowSwapButton(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			if (this.currentPlayer == null)
			{
				return false;
			}
			if (!this._allowElementAssignmentSwap)
			{
				return false;
			}
			if (mapping == null || mapping.aem == null)
			{
				return false;
			}
			ElementAssignmentConflictCheck conflictCheck;
			if (!this.CreateConflictCheck(mapping, assignment, out conflictCheck))
			{
				Debug.LogError("Rewired Control Mapper: Error creating conflict check!");
				return false;
			}
			List<ElementAssignmentConflictInfo> list = new List<ElementAssignmentConflictInfo>();
			list.AddRange(this.currentPlayer.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck));
			list.AddRange(ReInput.players.SystemPlayer.controllers.conflictChecking.ElementAssignmentConflicts(conflictCheck));
			if (list.Count == 0)
			{
				return false;
			}
			ActionElementMap aem2 = mapping.aem;
			ElementAssignmentConflictInfo elementAssignmentConflictInfo = list[0];
			int actionId = elementAssignmentConflictInfo.elementMap.actionId;
			Pole axisContribution = elementAssignmentConflictInfo.elementMap.axisContribution;
			AxisRange axisRange = aem2.axisRange;
			ControllerElementType elementType = aem2.elementType;
			if (elementType == elementAssignmentConflictInfo.elementMap.elementType && elementType == ControllerElementType.Axis)
			{
				if (axisRange != elementAssignmentConflictInfo.elementMap.axisRange)
				{
					if (axisRange == AxisRange.Full)
					{
						axisRange = AxisRange.Positive;
					}
					else if (elementAssignmentConflictInfo.elementMap.axisRange == AxisRange.Full)
					{
					}
				}
			}
			else if (elementType == ControllerElementType.Axis && (elementAssignmentConflictInfo.elementMap.elementType == ControllerElementType.Button || (elementAssignmentConflictInfo.elementMap.elementType == ControllerElementType.Axis && elementAssignmentConflictInfo.elementMap.axisRange != AxisRange.Full)) && axisRange == AxisRange.Full)
			{
				axisRange = AxisRange.Positive;
			}
			int num = 0;
			if (assignment.actionId == elementAssignmentConflictInfo.actionId && mapping.map == elementAssignmentConflictInfo.controllerMap)
			{
				Controller controller = ReInput.controllers.GetController(mapping.controllerType, mapping.controllerId);
				if (this.SwapIsSameInputRange(elementType, axisRange, axisContribution, controller.GetElementById(assignment.elementIdentifierId).type, assignment.axisRange, assignment.axisContribution))
				{
					num++;
				}
			}
			using (IEnumerator<ActionElementMap> enumerator = elementAssignmentConflictInfo.controllerMap.ElementMapsWithAction(actionId).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ActionElementMap aem = enumerator.Current;
					if (aem.id != aem2.id && list.FindIndex((ElementAssignmentConflictInfo x) => x.elementMapId == aem.id) < 0 && this.SwapIsSameInputRange(elementType, axisRange, axisContribution, aem.elementType, aem.axisRange, aem.axisContribution))
					{
						num++;
					}
				}
			}
			return num < this.GetControllerInputFieldCount(mapping.controllerType);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00014315 File Offset: 0x00012515
		private bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution)
		{
			return ((origElementType == ControllerElementType.Button || (origElementType == ControllerElementType.Axis && origAxisRange != AxisRange.Full)) && (conflictElementType == ControllerElementType.Button || (conflictElementType == ControllerElementType.Axis && conflictAxisRange != AxisRange.Full)) && conflictAxisContribution == origAxisContribution) || (origElementType == ControllerElementType.Axis && origAxisRange == AxisRange.Full && conflictElementType == ControllerElementType.Axis && conflictAxisRange == AxisRange.Full);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00014346 File Offset: 0x00012546
		public static void ApplyTheme(ThemedElement.ElementInfo[] elementInfo)
		{
			if (ControlMapper.Instance == null)
			{
				return;
			}
			if (ControlMapper.Instance._themeSettings == null)
			{
				return;
			}
			if (!ControlMapper.Instance._useThemeSettings)
			{
				return;
			}
			ControlMapper.Instance._themeSettings.Apply(elementInfo);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00014386 File Offset: 0x00012586
		public static LanguageData GetLanguage()
		{
			if (ControlMapper.Instance == null)
			{
				return null;
			}
			return ControlMapper.Instance._language;
		}

		// Token: 0x040008E6 RID: 2278
		private const float blockInputOnFocusTimeout = 0.1f;

		// Token: 0x040008E7 RID: 2279
		private const string buttonIdentifier_playerSelection = "PlayerSelection";

		// Token: 0x040008E8 RID: 2280
		private const string buttonIdentifier_removeController = "RemoveController";

		// Token: 0x040008E9 RID: 2281
		private const string buttonIdentifier_assignController = "AssignController";

		// Token: 0x040008EA RID: 2282
		private const string buttonIdentifier_calibrateController = "CalibrateController";

		// Token: 0x040008EB RID: 2283
		private const string buttonIdentifier_editInputBehaviors = "EditInputBehaviors";

		// Token: 0x040008EC RID: 2284
		private const string buttonIdentifier_mapCategorySelection = "MapCategorySelection";

		// Token: 0x040008ED RID: 2285
		private const string buttonIdentifier_assignedControllerSelection = "AssignedControllerSelection";

		// Token: 0x040008EE RID: 2286
		private const string buttonIdentifier_done = "Done";

		// Token: 0x040008EF RID: 2287
		private const string buttonIdentifier_restoreDefaults = "RestoreDefaults";

		// Token: 0x040008F0 RID: 2288
		[SerializeField]
		[Tooltip("Must be assigned a Rewired Input Manager scene object or prefab.")]
		private InputManager _rewiredInputManager;

		// Token: 0x040008F1 RID: 2289
		[SerializeField]
		[Tooltip("Set to True to prevent the Game Object from being destroyed when a new scene is loaded.\n\nNOTE: Changing this value from True to False at runtime will have no effect because Object.DontDestroyOnLoad cannot be undone once set.")]
		private bool _dontDestroyOnLoad;

		// Token: 0x040008F2 RID: 2290
		[SerializeField]
		[Tooltip("Open the control mapping screen immediately on start. Mainly used for testing.")]
		private bool _openOnStart;

		// Token: 0x040008F3 RID: 2291
		[Tooltip("The Layout of the Keyboard Maps to be displayed.")]
		[SerializeField]
		private int _keyboardMapDefaultLayout;

		// Token: 0x040008F4 RID: 2292
		[SerializeField]
		[Tooltip("The Layout of the Mouse Maps to be displayed.")]
		private int _mouseMapDefaultLayout;

		// Token: 0x040008F5 RID: 2293
		[SerializeField]
		[Tooltip("The Layout of the Mouse Maps to be displayed.")]
		private int _joystickMapDefaultLayout;

		// Token: 0x040008F6 RID: 2294
		[SerializeField]
		private ControlMapper.MappingSet[] _mappingSets = new ControlMapper.MappingSet[]
		{
			ControlMapper.MappingSet.Default
		};

		// Token: 0x040008F7 RID: 2295
		[Tooltip("Display a selectable list of Players. If your game only supports 1 player, you can disable this.")]
		[SerializeField]
		private bool _showPlayers = true;

		// Token: 0x040008F8 RID: 2296
		[Tooltip("Display the Controller column for input mapping.")]
		[SerializeField]
		private bool _showControllers = true;

		// Token: 0x040008F9 RID: 2297
		[Tooltip("Display the Keyboard column for input mapping.")]
		[SerializeField]
		private bool _showKeyboard = true;

		// Token: 0x040008FA RID: 2298
		[Tooltip("Display the Mouse column for input mapping.")]
		[SerializeField]
		private bool _showMouse = true;

		// Token: 0x040008FB RID: 2299
		[SerializeField]
		[Tooltip("The maximum number of controllers allowed to be assigned to a Player. If set to any value other than 1, a selectable list of currently-assigned controller will be displayed to the user. [0 = infinite]")]
		private int _maxControllersPerPlayer = 1;

		// Token: 0x040008FC RID: 2300
		[SerializeField]
		[Tooltip("Display section labels for each Action Category in the input field grid. Only applies if Action Categories are used to display the Action list.")]
		private bool _showActionCategoryLabels;

		// Token: 0x040008FD RID: 2301
		[Tooltip("The number of input fields to display for the keyboard. If you want to support alternate mappings on the same device, set this to 2 or more.")]
		[SerializeField]
		private int _keyboardInputFieldCount = 2;

		// Token: 0x040008FE RID: 2302
		[SerializeField]
		[Tooltip("The number of input fields to display for the mouse. If you want to support alternate mappings on the same device, set this to 2 or more.")]
		private int _mouseInputFieldCount = 1;

		// Token: 0x040008FF RID: 2303
		[Tooltip("The number of input fields to display for joysticks. If you want to support alternate mappings on the same device, set this to 2 or more.")]
		[SerializeField]
		private int _controllerInputFieldCount = 1;

		// Token: 0x04000900 RID: 2304
		[SerializeField]
		[Tooltip("Display a full-axis input assignment field for every axis-type Action in the input field grid. Also displays an invert toggle for the user  to invert the full-axis assignment direction.\n\n*IMPORTANT*: This field is required if you have made any full-axis assignments in the Rewired Input Manager or in saved XML user data. Disabling this field when you have full-axis assignments will result in the inability for the user to view, remove, or modify these full-axis assignments. In addition, these assignments may cause conflicts when trying to remap the same axes to Actions.")]
		private bool _showFullAxisInputFields = true;

		// Token: 0x04000901 RID: 2305
		[SerializeField]
		[Tooltip("Display a positive and negative input assignment field for every axis-type Action in the input field grid.\n\n*IMPORTANT*: These fields are required to assign buttons, keyboard keys, and hat or D-Pad directions to axis-type Actions. If you have made any split-axis assignments or button/key/D-pad assignments to axis-type Actions in the Rewired Input Manager or in saved XML user data, disabling these fields will result in the inability for the user to view, remove, or modify these assignments. In addition, these assignments may cause conflicts when trying to remap the same elements to Actions.")]
		private bool _showSplitAxisInputFields = true;

		// Token: 0x04000902 RID: 2306
		[Tooltip("If enabled, when an element assignment conflict is found, an option will be displayed that allows the user to make the conflicting assignment anyway.")]
		[SerializeField]
		private bool _allowElementAssignmentConflicts;

		// Token: 0x04000903 RID: 2307
		[SerializeField]
		[Tooltip("If enabled, when an element assignment conflict is found, an option will be displayed that allows the user to swap conflicting assignments. This only applies to the first conflicting assignment found. This option will not be displayed if allowElementAssignmentConflicts is true.")]
		private bool _allowElementAssignmentSwap;

		// Token: 0x04000904 RID: 2308
		[Tooltip("The width in relative pixels of the Action label column.")]
		[SerializeField]
		private int _actionLabelWidth = 200;

		// Token: 0x04000905 RID: 2309
		[Tooltip("The width in relative pixels of the Keyboard column.")]
		[SerializeField]
		private int _keyboardColMaxWidth = 360;

		// Token: 0x04000906 RID: 2310
		[SerializeField]
		[Tooltip("The width in relative pixels of the Mouse column.")]
		private int _mouseColMaxWidth = 200;

		// Token: 0x04000907 RID: 2311
		[SerializeField]
		[Tooltip("The width in relative pixels of the Controller column.")]
		private int _controllerColMaxWidth = 200;

		// Token: 0x04000908 RID: 2312
		[SerializeField]
		[Tooltip("The height in relative pixels of the input grid button rows.")]
		private int _inputRowHeight = 40;

		// Token: 0x04000909 RID: 2313
		[SerializeField]
		[Tooltip("The width in relative pixels of spacing between columns.")]
		private int _inputColumnSpacing = 40;

		// Token: 0x0400090A RID: 2314
		[SerializeField]
		[Tooltip("The height in relative pixels of the space between Action Category sections. Only applicable if Show Action Category Labels is checked.")]
		private int _inputRowCategorySpacing = 20;

		// Token: 0x0400090B RID: 2315
		[SerializeField]
		[Tooltip("The width in relative pixels of the invert toggle buttons.")]
		private int _invertToggleWidth = 40;

		// Token: 0x0400090C RID: 2316
		[Tooltip("The width in relative pixels of generated popup windows.")]
		[SerializeField]
		private int _defaultWindowWidth = 500;

		// Token: 0x0400090D RID: 2317
		[Tooltip("The height in relative pixels of generated popup windows.")]
		[SerializeField]
		private int _defaultWindowHeight = 400;

		// Token: 0x0400090E RID: 2318
		[Tooltip("The time in seconds the user has to press an element on a controller when assigning a controller to a Player. If this time elapses with no user input a controller, the assignment will be canceled.")]
		[SerializeField]
		private float _controllerAssignmentTimeout = 5f;

		// Token: 0x0400090F RID: 2319
		[Tooltip("The time in seconds the user has to press an element on a controller while waiting for axes to be centered before assigning input.")]
		[SerializeField]
		private float _preInputAssignmentTimeout = 5f;

		// Token: 0x04000910 RID: 2320
		[Tooltip("The time in seconds the user has to press an element on a controller when assigning input. If this time elapses with no user input on the target controller, the assignment will be canceled.")]
		[SerializeField]
		private float _inputAssignmentTimeout = 5f;

		// Token: 0x04000911 RID: 2321
		[Tooltip("The time in seconds the user has to press an element on a controller during calibration.")]
		[SerializeField]
		private float _axisCalibrationTimeout = 5f;

		// Token: 0x04000912 RID: 2322
		[Tooltip("If checked, mouse X-axis movement will always be ignored during input assignment. Check this if you don't want the horizontal mouse axis to be user-assignable to any Actions.")]
		[SerializeField]
		private bool _ignoreMouseXAxisAssignment = true;

		// Token: 0x04000913 RID: 2323
		[Tooltip("If checked, mouse Y-axis movement will always be ignored during input assignment. Check this if you don't want the vertical mouse axis to be user-assignable to any Actions.")]
		[SerializeField]
		private bool _ignoreMouseYAxisAssignment = true;

		// Token: 0x04000914 RID: 2324
		[Tooltip("An Action that when activated will alternately close or open the main screen as long as no popup windows are open.")]
		[SerializeField]
		private int _screenToggleAction = -1;

		// Token: 0x04000915 RID: 2325
		[Tooltip("An Action that when activated will open the main screen if it is closed.")]
		[SerializeField]
		private int _screenOpenAction = -1;

		// Token: 0x04000916 RID: 2326
		[SerializeField]
		[Tooltip("An Action that when activated will close the main screen as long as no popup windows are open.")]
		private int _screenCloseAction = -1;

		// Token: 0x04000917 RID: 2327
		[SerializeField]
		[Tooltip("An Action that when activated will cancel and close any open popup window. Use with care because the element assigned to this Action can never be mapped by the user (because it would just cancel his assignment).")]
		private int _universalCancelAction = -1;

		// Token: 0x04000918 RID: 2328
		[SerializeField]
		[Tooltip("If enabled, Universal Cancel will also close the main screen if pressed when no windows are open.")]
		private bool _universalCancelClosesScreen = true;

		// Token: 0x04000919 RID: 2329
		[Tooltip("If checked, controls will be displayed which will allow the user to customize certain Input Behavior settings.")]
		[SerializeField]
		private bool _showInputBehaviorSettings;

		// Token: 0x0400091A RID: 2330
		[Tooltip("Customizable settings for user-modifiable Input Behaviors. This can be used for settings like Mouse Look Sensitivity.")]
		[SerializeField]
		private ControlMapper.InputBehaviorSettings[] _inputBehaviorSettings;

		// Token: 0x0400091B RID: 2331
		[SerializeField]
		[Tooltip("If enabled, UI elements will be themed based on the settings in Theme Settings.")]
		private bool _useThemeSettings = true;

		// Token: 0x0400091C RID: 2332
		[SerializeField]
		[Tooltip("Must be assigned a ThemeSettings object. Used to theme UI elements.")]
		private ThemeSettings _themeSettings;

		// Token: 0x0400091D RID: 2333
		[SerializeField]
		[Tooltip("Must be assigned a LanguageData object. Used to retrieve language entries for UI elements.")]
		private LanguageData _language;

		// Token: 0x0400091E RID: 2334
		[Tooltip("A list of prefabs. You should not have to modify this.")]
		[SerializeField]
		private ControlMapper.Prefabs prefabs;

		// Token: 0x0400091F RID: 2335
		[SerializeField]
		[Tooltip("A list of references to elements in the hierarchy. You should not have to modify this.")]
		private ControlMapper.References references;

		// Token: 0x04000920 RID: 2336
		[Tooltip("Show the label for the Players button group?")]
		[SerializeField]
		private bool _showPlayersGroupLabel = true;

		// Token: 0x04000921 RID: 2337
		[Tooltip("Show the label for the Controller button group?")]
		[SerializeField]
		private bool _showControllerGroupLabel = true;

		// Token: 0x04000922 RID: 2338
		[Tooltip("Show the label for the Assigned Controllers button group?")]
		[SerializeField]
		private bool _showAssignedControllersGroupLabel = true;

		// Token: 0x04000923 RID: 2339
		[Tooltip("Show the label for the Settings button group?")]
		[SerializeField]
		private bool _showSettingsGroupLabel = true;

		// Token: 0x04000924 RID: 2340
		[Tooltip("Show the label for the Map Categories button group?")]
		[SerializeField]
		private bool _showMapCategoriesGroupLabel = true;

		// Token: 0x04000925 RID: 2341
		[SerializeField]
		[Tooltip("Show the label for the current controller name?")]
		private bool _showControllerNameLabel = true;

		// Token: 0x04000926 RID: 2342
		[Tooltip("Show the Assigned Controllers group? If joystick auto-assignment is enabled in the Rewired Input Manager and the max joysticks per player is set to any value other than 1, the Assigned Controllers group will always be displayed.")]
		[SerializeField]
		private bool _showAssignedControllers = true;

		// Token: 0x04000927 RID: 2343
		private Action _ScreenClosedEvent;

		// Token: 0x04000928 RID: 2344
		private Action _ScreenOpenedEvent;

		// Token: 0x04000929 RID: 2345
		private Action _PopupWindowOpenedEvent;

		// Token: 0x0400092A RID: 2346
		private Action _PopupWindowClosedEvent;

		// Token: 0x0400092B RID: 2347
		private Action _InputPollingStartedEvent;

		// Token: 0x0400092C RID: 2348
		private Action _InputPollingEndedEvent;

		// Token: 0x0400092D RID: 2349
		[Tooltip("Event sent when the UI is closed.")]
		[SerializeField]
		private UnityEvent _onScreenClosed;

		// Token: 0x0400092E RID: 2350
		[Tooltip("Event sent when the UI is opened.")]
		[SerializeField]
		private UnityEvent _onScreenOpened;

		// Token: 0x0400092F RID: 2351
		[SerializeField]
		[Tooltip("Event sent when a popup window is closed.")]
		private UnityEvent _onPopupWindowClosed;

		// Token: 0x04000930 RID: 2352
		[Tooltip("Event sent when a popup window is opened.")]
		[SerializeField]
		private UnityEvent _onPopupWindowOpened;

		// Token: 0x04000931 RID: 2353
		[SerializeField]
		[Tooltip("Event sent when polling for input has started.")]
		private UnityEvent _onInputPollingStarted;

		// Token: 0x04000932 RID: 2354
		[SerializeField]
		[Tooltip("Event sent when polling for input has ended.")]
		private UnityEvent _onInputPollingEnded;

		// Token: 0x04000933 RID: 2355
		private static ControlMapper Instance;

		// Token: 0x04000934 RID: 2356
		private bool initialized;

		// Token: 0x04000935 RID: 2357
		private int playerCount;

		// Token: 0x04000936 RID: 2358
		private ControlMapper.InputGrid inputGrid;

		// Token: 0x04000937 RID: 2359
		private ControlMapper.WindowManager windowManager;

		// Token: 0x04000938 RID: 2360
		private int currentPlayerId;

		// Token: 0x04000939 RID: 2361
		private int currentMapCategoryId;

		// Token: 0x0400093A RID: 2362
		private List<ControlMapper.GUIButton> playerButtons;

		// Token: 0x0400093B RID: 2363
		private List<ControlMapper.GUIButton> mapCategoryButtons;

		// Token: 0x0400093C RID: 2364
		private List<ControlMapper.GUIButton> assignedControllerButtons;

		// Token: 0x0400093D RID: 2365
		private ControlMapper.GUIButton assignedControllerButtonsPlaceholder;

		// Token: 0x0400093E RID: 2366
		private List<GameObject> miscInstantiatedObjects;

		// Token: 0x0400093F RID: 2367
		private GameObject canvas;

		// Token: 0x04000940 RID: 2368
		private GameObject lastUISelection;

		// Token: 0x04000941 RID: 2369
		private int currentJoystickId = -1;

		// Token: 0x04000942 RID: 2370
		private float blockInputOnFocusEndTime;

		// Token: 0x04000943 RID: 2371
		private bool isPollingForInput;

		// Token: 0x04000944 RID: 2372
		private ControlMapper.InputMapping pendingInputMapping;

		// Token: 0x04000945 RID: 2373
		private ControlMapper.AxisCalibrator pendingAxisCalibration;

		// Token: 0x04000946 RID: 2374
		private Action<InputFieldInfo> inputFieldActivatedDelegate;

		// Token: 0x04000947 RID: 2375
		private Action<ToggleInfo, bool> inputFieldInvertToggleStateChangedDelegate;

		// Token: 0x04000948 RID: 2376
		private Action _restoreDefaultsDelegate;

		// Token: 0x02000109 RID: 265
		private abstract class GUIElement
		{
			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06002F08 RID: 12040 RVA: 0x000143A1 File Offset: 0x000125A1
			// (set) Token: 0x06002F09 RID: 12041 RVA: 0x000143A9 File Offset: 0x000125A9
			public RectTransform rectTransform { get; private set; }

			// Token: 0x06002F0A RID: 12042 RVA: 0x001424F8 File Offset: 0x001406F8
			public GUIElement(GameObject gameObject)
			{
				if (gameObject == null)
				{
					Debug.LogError("Rewired Control Mapper: gameObject is null!");
					return;
				}
				this.selectable = gameObject.GetComponent<Selectable>();
				if (this.selectable == null)
				{
					Debug.LogError("Rewired Control Mapper: Selectable is null!");
					return;
				}
				this.gameObject = gameObject;
				this.rectTransform = gameObject.GetComponent<RectTransform>();
				this.text = UnityTools.GetComponentInSelfOrChildren<Text>(gameObject);
				this.uiElementInfo = gameObject.GetComponent<UIElementInfo>();
				this.children = new List<ControlMapper.GUIElement>();
			}

			// Token: 0x06002F0B RID: 12043 RVA: 0x0014257C File Offset: 0x0014077C
			public GUIElement(Selectable selectable, Text label)
			{
				if (selectable == null)
				{
					Debug.LogError("Rewired Control Mapper: Selectable is null!");
					return;
				}
				this.selectable = selectable;
				this.gameObject = selectable.gameObject;
				this.rectTransform = this.gameObject.GetComponent<RectTransform>();
				this.text = label;
				this.uiElementInfo = this.gameObject.GetComponent<UIElementInfo>();
				this.children = new List<ControlMapper.GUIElement>();
			}

			// Token: 0x06002F0C RID: 12044 RVA: 0x000143B2 File Offset: 0x000125B2
			public virtual void SetInteractible(bool state, bool playTransition)
			{
				this.SetInteractible(state, playTransition, false);
			}

			// Token: 0x06002F0D RID: 12045 RVA: 0x001425EC File Offset: 0x001407EC
			public virtual void SetInteractible(bool state, bool playTransition, bool permanent)
			{
				for (int i = 0; i < this.children.Count; i++)
				{
					if (this.children[i] != null)
					{
						this.children[i].SetInteractible(state, playTransition, permanent);
					}
				}
				if (this.permanentStateSet)
				{
					return;
				}
				if (this.selectable == null)
				{
					return;
				}
				if (permanent)
				{
					this.permanentStateSet = true;
				}
				if (this.selectable.interactable == state)
				{
					return;
				}
				UITools.SetInteractable(this.selectable, state, playTransition);
			}

			// Token: 0x06002F0E RID: 12046 RVA: 0x00142670 File Offset: 0x00140870
			public virtual void SetTextWidth(int value)
			{
				if (this.text == null)
				{
					return;
				}
				LayoutElement layoutElement = this.text.GetComponent<LayoutElement>();
				if (layoutElement == null)
				{
					layoutElement = this.text.gameObject.AddComponent<LayoutElement>();
				}
				layoutElement.preferredWidth = (float)value;
			}

			// Token: 0x06002F0F RID: 12047 RVA: 0x001426BC File Offset: 0x001408BC
			public virtual void SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType type, int value)
			{
				if (this.rectTransform.childCount == 0)
				{
					return;
				}
				Transform child = this.rectTransform.GetChild(0);
				LayoutElement layoutElement = child.GetComponent<LayoutElement>();
				if (layoutElement == null)
				{
					layoutElement = child.gameObject.AddComponent<LayoutElement>();
				}
				if (type == ControlMapper.LayoutElementSizeType.MinSize)
				{
					layoutElement.minWidth = (float)value;
					return;
				}
				if (type == ControlMapper.LayoutElementSizeType.PreferredSize)
				{
					layoutElement.preferredWidth = (float)value;
					return;
				}
				throw new NotImplementedException();
			}

			// Token: 0x06002F10 RID: 12048 RVA: 0x000143BD File Offset: 0x000125BD
			public virtual void SetLabel(string label)
			{
				if (this.text == null)
				{
					return;
				}
				this.text.text = label;
			}

			// Token: 0x06002F11 RID: 12049 RVA: 0x000143DA File Offset: 0x000125DA
			public virtual string GetLabel()
			{
				if (this.text == null)
				{
					return string.Empty;
				}
				return this.text.text;
			}

			// Token: 0x06002F12 RID: 12050 RVA: 0x000143FB File Offset: 0x000125FB
			public virtual void AddChild(ControlMapper.GUIElement child)
			{
				this.children.Add(child);
			}

			// Token: 0x06002F13 RID: 12051 RVA: 0x00014409 File Offset: 0x00012609
			public void SetElementInfoData(string identifier, int intData)
			{
				if (this.uiElementInfo == null)
				{
					return;
				}
				this.uiElementInfo.identifier = identifier;
				this.uiElementInfo.intData = intData;
			}

			// Token: 0x06002F14 RID: 12052 RVA: 0x00014432 File Offset: 0x00012632
			public virtual void SetActive(bool state)
			{
				if (this.gameObject == null)
				{
					return;
				}
				this.gameObject.SetActive(state);
			}

			// Token: 0x06002F15 RID: 12053 RVA: 0x00142720 File Offset: 0x00140920
			protected virtual bool Init()
			{
				bool result = true;
				for (int i = 0; i < this.children.Count; i++)
				{
					if (this.children[i] != null && !this.children[i].Init())
					{
						result = false;
					}
				}
				if (this.selectable == null)
				{
					Debug.LogError("Rewired Control Mapper: UI Element is missing Selectable component!");
					result = false;
				}
				if (this.rectTransform == null)
				{
					Debug.LogError("Rewired Control Mapper: UI Element is missing RectTransform component!");
					result = false;
				}
				if (this.uiElementInfo == null)
				{
					Debug.LogError("Rewired Control Mapper: UI Element is missing UIElementInfo component!");
					result = false;
				}
				return result;
			}

			// Token: 0x04000949 RID: 2377
			public readonly GameObject gameObject;

			// Token: 0x0400094A RID: 2378
			protected readonly Text text;

			// Token: 0x0400094B RID: 2379
			public readonly Selectable selectable;

			// Token: 0x0400094C RID: 2380
			protected readonly UIElementInfo uiElementInfo;

			// Token: 0x0400094D RID: 2381
			protected bool permanentStateSet;

			// Token: 0x0400094E RID: 2382
			protected readonly List<ControlMapper.GUIElement> children;
		}

		// Token: 0x0200010A RID: 266
		private class GUIButton : ControlMapper.GUIElement
		{
			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06002F16 RID: 12054 RVA: 0x0001444F File Offset: 0x0001264F
			protected Button button
			{
				get
				{
					return this.selectable as Button;
				}
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x06002F17 RID: 12055 RVA: 0x0001445C File Offset: 0x0001265C
			public ButtonInfo buttonInfo
			{
				get
				{
					return this.uiElementInfo as ButtonInfo;
				}
			}

			// Token: 0x06002F18 RID: 12056 RVA: 0x00014469 File Offset: 0x00012669
			public GUIButton(GameObject gameObject) : base(gameObject)
			{
				this.Init();
			}

			// Token: 0x06002F19 RID: 12057 RVA: 0x00014479 File Offset: 0x00012679
			public GUIButton(Button button, Text label) : base(button, label)
			{
				this.Init();
			}

			// Token: 0x06002F1A RID: 12058 RVA: 0x0001448A File Offset: 0x0001268A
			public void SetButtonInfoData(string identifier, int intData)
			{
				base.SetElementInfoData(identifier, intData);
			}

			// Token: 0x06002F1B RID: 12059 RVA: 0x001427B8 File Offset: 0x001409B8
			public void SetOnClickCallback(Action<ButtonInfo> callback)
			{
				if (this.button == null)
				{
					return;
				}
				this.button.onClick.AddListener(delegate()
				{
					callback(this.buttonInfo);
				});
			}
		}

		// Token: 0x0200010C RID: 268
		private class GUIInputField : ControlMapper.GUIElement
		{
			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06002F1E RID: 12062 RVA: 0x0001444F File Offset: 0x0001264F
			protected Button button
			{
				get
				{
					return this.selectable as Button;
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000144AC File Offset: 0x000126AC
			public InputFieldInfo fieldInfo
			{
				get
				{
					return this.uiElementInfo as InputFieldInfo;
				}
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000144B9 File Offset: 0x000126B9
			public bool hasToggle
			{
				get
				{
					return this.toggle != null;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000144C4 File Offset: 0x000126C4
			// (set) Token: 0x06002F22 RID: 12066 RVA: 0x000144CC File Offset: 0x000126CC
			public ControlMapper.GUIToggle toggle { get; private set; }

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000144D5 File Offset: 0x000126D5
			// (set) Token: 0x06002F24 RID: 12068 RVA: 0x000144F2 File Offset: 0x000126F2
			public int actionElementMapId
			{
				get
				{
					if (this.fieldInfo == null)
					{
						return -1;
					}
					return this.fieldInfo.actionElementMapId;
				}
				set
				{
					if (this.fieldInfo == null)
					{
						return;
					}
					this.fieldInfo.actionElementMapId = value;
				}
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06002F25 RID: 12069 RVA: 0x0001450F File Offset: 0x0001270F
			// (set) Token: 0x06002F26 RID: 12070 RVA: 0x0001452C File Offset: 0x0001272C
			public int controllerId
			{
				get
				{
					if (this.fieldInfo == null)
					{
						return -1;
					}
					return this.fieldInfo.controllerId;
				}
				set
				{
					if (this.fieldInfo == null)
					{
						return;
					}
					this.fieldInfo.controllerId = value;
				}
			}

			// Token: 0x06002F27 RID: 12071 RVA: 0x00014469 File Offset: 0x00012669
			public GUIInputField(GameObject gameObject) : base(gameObject)
			{
				this.Init();
			}

			// Token: 0x06002F28 RID: 12072 RVA: 0x00014479 File Offset: 0x00012679
			public GUIInputField(Button button, Text label) : base(button, label)
			{
				this.Init();
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x00142804 File Offset: 0x00140A04
			public void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
				base.SetElementInfoData(string.Empty, intData);
				if (this.fieldInfo == null)
				{
					return;
				}
				this.fieldInfo.actionId = actionId;
				this.fieldInfo.axisRange = axisRange;
				this.fieldInfo.controllerType = controllerType;
			}

			// Token: 0x06002F2A RID: 12074 RVA: 0x00142854 File Offset: 0x00140A54
			public void SetOnClickCallback(Action<InputFieldInfo> callback)
			{
				if (this.button == null)
				{
					return;
				}
				this.button.onClick.AddListener(delegate()
				{
					callback(this.fieldInfo);
				});
			}

			// Token: 0x06002F2B RID: 12075 RVA: 0x00014549 File Offset: 0x00012749
			public virtual void SetInteractable(bool state, bool playTransition, bool permanent)
			{
				if (this.permanentStateSet)
				{
					return;
				}
				if (this.hasToggle && !state)
				{
					this.toggle.SetInteractible(state, playTransition, permanent);
				}
				base.SetInteractible(state, playTransition, permanent);
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x00014576 File Offset: 0x00012776
			public void AddToggle(ControlMapper.GUIToggle toggle)
			{
				if (toggle == null)
				{
					return;
				}
				this.toggle = toggle;
			}
		}

		// Token: 0x0200010E RID: 270
		private class GUIToggle : ControlMapper.GUIElement
		{
			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06002F2F RID: 12079 RVA: 0x0001459B File Offset: 0x0001279B
			protected Toggle toggle
			{
				get
				{
					return this.selectable as Toggle;
				}
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06002F30 RID: 12080 RVA: 0x000145A8 File Offset: 0x000127A8
			public ToggleInfo toggleInfo
			{
				get
				{
					return this.uiElementInfo as ToggleInfo;
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000145B5 File Offset: 0x000127B5
			// (set) Token: 0x06002F32 RID: 12082 RVA: 0x000145D2 File Offset: 0x000127D2
			public int actionElementMapId
			{
				get
				{
					if (this.toggleInfo == null)
					{
						return -1;
					}
					return this.toggleInfo.actionElementMapId;
				}
				set
				{
					if (this.toggleInfo == null)
					{
						return;
					}
					this.toggleInfo.actionElementMapId = value;
				}
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x00014469 File Offset: 0x00012669
			public GUIToggle(GameObject gameObject) : base(gameObject)
			{
				this.Init();
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x00014479 File Offset: 0x00012679
			public GUIToggle(Toggle toggle, Text label) : base(toggle, label)
			{
				this.Init();
			}

			// Token: 0x06002F35 RID: 12085 RVA: 0x001428A0 File Offset: 0x00140AA0
			public void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
				base.SetElementInfoData(string.Empty, intData);
				if (this.toggleInfo == null)
				{
					return;
				}
				this.toggleInfo.actionId = actionId;
				this.toggleInfo.axisRange = axisRange;
				this.toggleInfo.controllerType = controllerType;
			}

			// Token: 0x06002F36 RID: 12086 RVA: 0x001428F0 File Offset: 0x00140AF0
			public void SetOnSubmitCallback(Action<ToggleInfo, bool> callback)
			{
				if (this.toggle == null)
				{
					return;
				}
				EventTrigger eventTrigger = this.toggle.GetComponent<EventTrigger>();
				if (eventTrigger == null)
				{
					eventTrigger = this.toggle.gameObject.AddComponent<EventTrigger>();
				}
				EventTrigger.TriggerEvent triggerEvent = new EventTrigger.TriggerEvent();
				triggerEvent.AddListener(delegate(BaseEventData data)
				{
					PointerEventData pointerEventData = data as PointerEventData;
					if (pointerEventData != null && pointerEventData.button != PointerEventData.InputButton.Left)
					{
						return;
					}
					callback(this.toggleInfo, this.toggle.isOn);
				});
				EventTrigger.Entry item = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = EventTriggerType.Submit
				};
				EventTrigger.Entry item2 = new EventTrigger.Entry
				{
					callback = triggerEvent,
					eventID = EventTriggerType.PointerClick
				};
				if (eventTrigger.triggers != null)
				{
					eventTrigger.triggers.Clear();
				}
				else
				{
					eventTrigger.triggers = new List<EventTrigger.Entry>();
				}
				eventTrigger.triggers.Add(item);
				eventTrigger.triggers.Add(item2);
			}

			// Token: 0x06002F37 RID: 12087 RVA: 0x000145EF File Offset: 0x000127EF
			public void SetToggleState(bool state)
			{
				if (this.toggle == null)
				{
					return;
				}
				this.toggle.isOn = state;
			}
		}

		// Token: 0x02000110 RID: 272
		private class GUILabel
		{
			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06002F3A RID: 12090 RVA: 0x0001460C File Offset: 0x0001280C
			// (set) Token: 0x06002F3B RID: 12091 RVA: 0x00014614 File Offset: 0x00012814
			public GameObject gameObject { get; private set; }

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x06002F3C RID: 12092 RVA: 0x0001461D File Offset: 0x0001281D
			// (set) Token: 0x06002F3D RID: 12093 RVA: 0x00014625 File Offset: 0x00012825
			private Text text { get; set; }

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06002F3E RID: 12094 RVA: 0x0001462E File Offset: 0x0001282E
			// (set) Token: 0x06002F3F RID: 12095 RVA: 0x00014636 File Offset: 0x00012836
			public RectTransform rectTransform { get; private set; }

			// Token: 0x06002F40 RID: 12096 RVA: 0x0001463F File Offset: 0x0001283F
			public GUILabel(GameObject gameObject)
			{
				if (gameObject == null)
				{
					Debug.LogError("Rewired Control Mapper: gameObject is null!");
					return;
				}
				this.text = UnityTools.GetComponentInSelfOrChildren<Text>(gameObject);
				this.Check();
			}

			// Token: 0x06002F41 RID: 12097 RVA: 0x0001466E File Offset: 0x0001286E
			public GUILabel(Text label)
			{
				this.text = label;
				this.Check();
			}

			// Token: 0x06002F42 RID: 12098 RVA: 0x00014684 File Offset: 0x00012884
			public void SetSize(int width, int height)
			{
				if (this.text == null)
				{
					return;
				}
				this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)width);
				this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)height);
			}

			// Token: 0x06002F43 RID: 12099 RVA: 0x000146B1 File Offset: 0x000128B1
			public void SetWidth(int width)
			{
				if (this.text == null)
				{
					return;
				}
				this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (float)width);
			}

			// Token: 0x06002F44 RID: 12100 RVA: 0x000146D0 File Offset: 0x000128D0
			public void SetHeight(int height)
			{
				if (this.text == null)
				{
					return;
				}
				this.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (float)height);
			}

			// Token: 0x06002F45 RID: 12101 RVA: 0x000146EF File Offset: 0x000128EF
			public void SetLabel(string label)
			{
				if (this.text == null)
				{
					return;
				}
				this.text.text = label;
			}

			// Token: 0x06002F46 RID: 12102 RVA: 0x0001470C File Offset: 0x0001290C
			public void SetFontStyle(FontStyle style)
			{
				if (this.text == null)
				{
					return;
				}
				this.text.fontStyle = style;
			}

			// Token: 0x06002F47 RID: 12103 RVA: 0x00014729 File Offset: 0x00012929
			public void SetTextAlignment(TextAnchor alignment)
			{
				if (this.text == null)
				{
					return;
				}
				this.text.alignment = alignment;
			}

			// Token: 0x06002F48 RID: 12104 RVA: 0x00014746 File Offset: 0x00012946
			public void SetActive(bool state)
			{
				if (this.gameObject == null)
				{
					return;
				}
				this.gameObject.SetActive(state);
			}

			// Token: 0x06002F49 RID: 12105 RVA: 0x00142A0C File Offset: 0x00140C0C
			private bool Check()
			{
				bool result = true;
				if (this.text == null)
				{
					Debug.LogError("Rewired Control Mapper: Button is missing Text child component!");
					result = false;
				}
				this.gameObject = this.text.gameObject;
				this.rectTransform = this.text.GetComponent<RectTransform>();
				return result;
			}
		}

		// Token: 0x02000111 RID: 273
		[Serializable]
		public class MappingSet
		{
			// Token: 0x17000338 RID: 824
			// (get) Token: 0x06002F4A RID: 12106 RVA: 0x00014763 File Offset: 0x00012963
			public int mapCategoryId
			{
				get
				{
					return this._mapCategoryId;
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x06002F4B RID: 12107 RVA: 0x0001476B File Offset: 0x0001296B
			public ControlMapper.MappingSet.ActionListMode actionListMode
			{
				get
				{
					return this._actionListMode;
				}
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x06002F4C RID: 12108 RVA: 0x00014773 File Offset: 0x00012973
			public IList<int> actionCategoryIds
			{
				get
				{
					if (this._actionCategoryIds == null)
					{
						return null;
					}
					if (this._actionCategoryIdsReadOnly == null)
					{
						this._actionCategoryIdsReadOnly = new ReadOnlyCollection<int>(this._actionCategoryIds);
					}
					return this._actionCategoryIdsReadOnly;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x06002F4D RID: 12109 RVA: 0x0001479E File Offset: 0x0001299E
			public IList<int> actionIds
			{
				get
				{
					if (this._actionIds == null)
					{
						return null;
					}
					if (this._actionIdsReadOnly == null)
					{
						this._actionIdsReadOnly = new ReadOnlyCollection<int>(this._actionIds);
					}
					return this._actionIds;
				}
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x06002F4E RID: 12110 RVA: 0x000147C9 File Offset: 0x000129C9
			public bool isValid
			{
				get
				{
					return this._mapCategoryId >= 0 && ReInput.mapping.GetMapCategory(this._mapCategoryId) != null;
				}
			}

			// Token: 0x06002F4F RID: 12111 RVA: 0x000147E9 File Offset: 0x000129E9
			public MappingSet()
			{
				this._mapCategoryId = -1;
				this._actionCategoryIds = new int[0];
				this._actionIds = new int[0];
				this._actionListMode = ControlMapper.MappingSet.ActionListMode.ActionCategory;
			}

			// Token: 0x06002F50 RID: 12112 RVA: 0x00014817 File Offset: 0x00012A17
			private MappingSet(int mapCategoryId, ControlMapper.MappingSet.ActionListMode actionListMode, int[] actionCategoryIds, int[] actionIds)
			{
				this._mapCategoryId = mapCategoryId;
				this._actionListMode = actionListMode;
				this._actionCategoryIds = actionCategoryIds;
				this._actionIds = actionIds;
			}

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x06002F51 RID: 12113 RVA: 0x0001483C File Offset: 0x00012A3C
			public static ControlMapper.MappingSet Default
			{
				get
				{
					return new ControlMapper.MappingSet(0, ControlMapper.MappingSet.ActionListMode.ActionCategory, new int[1], new int[0]);
				}
			}

			// Token: 0x0400095A RID: 2394
			[SerializeField]
			[Tooltip("The Map Category that will be displayed to the user for remapping.")]
			private int _mapCategoryId;

			// Token: 0x0400095B RID: 2395
			[Tooltip("Choose whether you want to list Actions to display for this Map Category by individual Action or by all the Actions in an Action Category.")]
			[SerializeField]
			private ControlMapper.MappingSet.ActionListMode _actionListMode;

			// Token: 0x0400095C RID: 2396
			[SerializeField]
			private int[] _actionCategoryIds;

			// Token: 0x0400095D RID: 2397
			[SerializeField]
			private int[] _actionIds;

			// Token: 0x0400095E RID: 2398
			private IList<int> _actionCategoryIdsReadOnly;

			// Token: 0x0400095F RID: 2399
			private IList<int> _actionIdsReadOnly;

			// Token: 0x02000112 RID: 274
			public enum ActionListMode
			{
				// Token: 0x04000961 RID: 2401
				ActionCategory,
				// Token: 0x04000962 RID: 2402
				Action
			}
		}

		// Token: 0x02000113 RID: 275
		[Serializable]
		public class InputBehaviorSettings
		{
			// Token: 0x1700033E RID: 830
			// (get) Token: 0x06002F52 RID: 12114 RVA: 0x00014851 File Offset: 0x00012A51
			public int inputBehaviorId
			{
				get
				{
					return this._inputBehaviorId;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x06002F53 RID: 12115 RVA: 0x00014859 File Offset: 0x00012A59
			public bool showJoystickAxisSensitivity
			{
				get
				{
					return this._showJoystickAxisSensitivity;
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x06002F54 RID: 12116 RVA: 0x00014861 File Offset: 0x00012A61
			public bool showMouseXYAxisSensitivity
			{
				get
				{
					return this._showMouseXYAxisSensitivity;
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x06002F55 RID: 12117 RVA: 0x00014869 File Offset: 0x00012A69
			public string labelLanguageKey
			{
				get
				{
					return this._labelLanguageKey;
				}
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x06002F56 RID: 12118 RVA: 0x00014871 File Offset: 0x00012A71
			public string joystickAxisSensitivityLabelLanguageKey
			{
				get
				{
					return this._joystickAxisSensitivityLabelLanguageKey;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x06002F57 RID: 12119 RVA: 0x00014879 File Offset: 0x00012A79
			public string mouseXYAxisSensitivityLabelLanguageKey
			{
				get
				{
					return this._mouseXYAxisSensitivityLabelLanguageKey;
				}
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x06002F58 RID: 12120 RVA: 0x00014881 File Offset: 0x00012A81
			public Sprite joystickAxisSensitivityIcon
			{
				get
				{
					return this._joystickAxisSensitivityIcon;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x06002F59 RID: 12121 RVA: 0x00014889 File Offset: 0x00012A89
			public Sprite mouseXYAxisSensitivityIcon
			{
				get
				{
					return this._mouseXYAxisSensitivityIcon;
				}
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x06002F5A RID: 12122 RVA: 0x00014891 File Offset: 0x00012A91
			public float joystickAxisSensitivityMin
			{
				get
				{
					return this._joystickAxisSensitivityMin;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00014899 File Offset: 0x00012A99
			public float joystickAxisSensitivityMax
			{
				get
				{
					return this._joystickAxisSensitivityMax;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000148A1 File Offset: 0x00012AA1
			public float mouseXYAxisSensitivityMin
			{
				get
				{
					return this._mouseXYAxisSensitivityMin;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06002F5D RID: 12125 RVA: 0x000148A9 File Offset: 0x00012AA9
			public float mouseXYAxisSensitivityMax
			{
				get
				{
					return this._mouseXYAxisSensitivityMax;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000148B1 File Offset: 0x00012AB1
			public bool isValid
			{
				get
				{
					return this._inputBehaviorId >= 0 && (this._showJoystickAxisSensitivity || this._showMouseXYAxisSensitivity);
				}
			}

			// Token: 0x04000963 RID: 2403
			[Tooltip("The Input Behavior that will be displayed to the user for modification.")]
			[SerializeField]
			private int _inputBehaviorId = -1;

			// Token: 0x04000964 RID: 2404
			[Tooltip("If checked, a slider will be displayed so the user can change this value.")]
			[SerializeField]
			private bool _showJoystickAxisSensitivity = true;

			// Token: 0x04000965 RID: 2405
			[Tooltip("If checked, a slider will be displayed so the user can change this value.")]
			[SerializeField]
			private bool _showMouseXYAxisSensitivity = true;

			// Token: 0x04000966 RID: 2406
			[Tooltip("If set to a non-blank value, this key will be used to look up the name in Language to be displayed as the title for the Input Behavior control set. Otherwise, the name field of the InputBehavior will be used.")]
			[SerializeField]
			private string _labelLanguageKey = string.Empty;

			// Token: 0x04000967 RID: 2407
			[SerializeField]
			[Tooltip("If set to a non-blank value, this name will be displayed above the individual slider control. Otherwise, no name will be displayed.")]
			private string _joystickAxisSensitivityLabelLanguageKey = string.Empty;

			// Token: 0x04000968 RID: 2408
			[Tooltip("If set to a non-blank value, this key will be used to look up the name in Language to be displayed above the individual slider control. Otherwise, no name will be displayed.")]
			[SerializeField]
			private string _mouseXYAxisSensitivityLabelLanguageKey = string.Empty;

			// Token: 0x04000969 RID: 2409
			[Tooltip("The icon to display next to the slider. Set to none for no icon.")]
			[SerializeField]
			private Sprite _joystickAxisSensitivityIcon;

			// Token: 0x0400096A RID: 2410
			[SerializeField]
			[Tooltip("The icon to display next to the slider. Set to none for no icon.")]
			private Sprite _mouseXYAxisSensitivityIcon;

			// Token: 0x0400096B RID: 2411
			[SerializeField]
			[Tooltip("Minimum value the user is allowed to set for this property.")]
			private float _joystickAxisSensitivityMin;

			// Token: 0x0400096C RID: 2412
			[Tooltip("Maximum value the user is allowed to set for this property.")]
			[SerializeField]
			private float _joystickAxisSensitivityMax = 2f;

			// Token: 0x0400096D RID: 2413
			[Tooltip("Minimum value the user is allowed to set for this property.")]
			[SerializeField]
			private float _mouseXYAxisSensitivityMin;

			// Token: 0x0400096E RID: 2414
			[SerializeField]
			[Tooltip("Maximum value the user is allowed to set for this property.")]
			private float _mouseXYAxisSensitivityMax = 2f;
		}

		// Token: 0x02000114 RID: 276
		[Serializable]
		private class Prefabs
		{
			// Token: 0x1700034B RID: 843
			// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000148CE File Offset: 0x00012ACE
			public GameObject button
			{
				get
				{
					return this._button;
				}
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000148D6 File Offset: 0x00012AD6
			public GameObject fitButton
			{
				get
				{
					return this._fitButton;
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x06002F62 RID: 12130 RVA: 0x000148DE File Offset: 0x00012ADE
			public GameObject inputGridLabel
			{
				get
				{
					return this._inputGridLabel;
				}
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06002F63 RID: 12131 RVA: 0x000148E6 File Offset: 0x00012AE6
			public GameObject inputGridHeaderLabel
			{
				get
				{
					return this._inputGridHeaderLabel;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06002F64 RID: 12132 RVA: 0x000148EE File Offset: 0x00012AEE
			public GameObject inputGridFieldButton
			{
				get
				{
					return this._inputGridFieldButton;
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x06002F65 RID: 12133 RVA: 0x000148F6 File Offset: 0x00012AF6
			public GameObject inputGridFieldInvertToggle
			{
				get
				{
					return this._inputGridFieldInvertToggle;
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x06002F66 RID: 12134 RVA: 0x000148FE File Offset: 0x00012AFE
			public GameObject window
			{
				get
				{
					return this._window;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x06002F67 RID: 12135 RVA: 0x00014906 File Offset: 0x00012B06
			public GameObject windowTitleText
			{
				get
				{
					return this._windowTitleText;
				}
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x06002F68 RID: 12136 RVA: 0x0001490E File Offset: 0x00012B0E
			public GameObject windowContentText
			{
				get
				{
					return this._windowContentText;
				}
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06002F69 RID: 12137 RVA: 0x00014916 File Offset: 0x00012B16
			public GameObject fader
			{
				get
				{
					return this._fader;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06002F6A RID: 12138 RVA: 0x0001491E File Offset: 0x00012B1E
			public GameObject calibrationWindow
			{
				get
				{
					return this._calibrationWindow;
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06002F6B RID: 12139 RVA: 0x00014926 File Offset: 0x00012B26
			public GameObject inputBehaviorsWindow
			{
				get
				{
					return this._inputBehaviorsWindow;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06002F6C RID: 12140 RVA: 0x0001492E File Offset: 0x00012B2E
			public GameObject centerStickGraphic
			{
				get
				{
					return this._centerStickGraphic;
				}
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x06002F6D RID: 12141 RVA: 0x00014936 File Offset: 0x00012B36
			public GameObject moveStickGraphic
			{
				get
				{
					return this._moveStickGraphic;
				}
			}

			// Token: 0x06002F6E RID: 12142 RVA: 0x00142AB8 File Offset: 0x00140CB8
			public bool Check()
			{
				return !(this._button == null) && !(this._fitButton == null) && !(this._inputGridLabel == null) && !(this._inputGridHeaderLabel == null) && !(this._inputGridFieldButton == null) && !(this._inputGridFieldInvertToggle == null) && !(this._window == null) && !(this._windowTitleText == null) && !(this._windowContentText == null) && !(this._fader == null) && !(this._calibrationWindow == null) && !(this._inputBehaviorsWindow == null);
			}

			// Token: 0x0400096F RID: 2415
			[SerializeField]
			private GameObject _button;

			// Token: 0x04000970 RID: 2416
			[SerializeField]
			private GameObject _fitButton;

			// Token: 0x04000971 RID: 2417
			[SerializeField]
			private GameObject _inputGridLabel;

			// Token: 0x04000972 RID: 2418
			[SerializeField]
			private GameObject _inputGridHeaderLabel;

			// Token: 0x04000973 RID: 2419
			[SerializeField]
			private GameObject _inputGridFieldButton;

			// Token: 0x04000974 RID: 2420
			[SerializeField]
			private GameObject _inputGridFieldInvertToggle;

			// Token: 0x04000975 RID: 2421
			[SerializeField]
			private GameObject _window;

			// Token: 0x04000976 RID: 2422
			[SerializeField]
			private GameObject _windowTitleText;

			// Token: 0x04000977 RID: 2423
			[SerializeField]
			private GameObject _windowContentText;

			// Token: 0x04000978 RID: 2424
			[SerializeField]
			private GameObject _fader;

			// Token: 0x04000979 RID: 2425
			[SerializeField]
			private GameObject _calibrationWindow;

			// Token: 0x0400097A RID: 2426
			[SerializeField]
			private GameObject _inputBehaviorsWindow;

			// Token: 0x0400097B RID: 2427
			[SerializeField]
			private GameObject _centerStickGraphic;

			// Token: 0x0400097C RID: 2428
			[SerializeField]
			private GameObject _moveStickGraphic;
		}

		// Token: 0x02000115 RID: 277
		[Serializable]
		private class References
		{
			// Token: 0x17000359 RID: 857
			// (get) Token: 0x06002F70 RID: 12144 RVA: 0x0001493E File Offset: 0x00012B3E
			public Canvas canvas
			{
				get
				{
					return this._canvas;
				}
			}

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x06002F71 RID: 12145 RVA: 0x00014946 File Offset: 0x00012B46
			public CanvasGroup mainCanvasGroup
			{
				get
				{
					return this._mainCanvasGroup;
				}
			}

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x06002F72 RID: 12146 RVA: 0x0001494E File Offset: 0x00012B4E
			public Transform mainContent
			{
				get
				{
					return this._mainContent;
				}
			}

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x06002F73 RID: 12147 RVA: 0x00014956 File Offset: 0x00012B56
			public Transform mainContentInner
			{
				get
				{
					return this._mainContentInner;
				}
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x06002F74 RID: 12148 RVA: 0x0001495E File Offset: 0x00012B5E
			public UIGroup playersGroup
			{
				get
				{
					return this._playersGroup;
				}
			}

			// Token: 0x1700035E RID: 862
			// (get) Token: 0x06002F75 RID: 12149 RVA: 0x00014966 File Offset: 0x00012B66
			public Transform controllerGroup
			{
				get
				{
					return this._controllerGroup;
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x06002F76 RID: 12150 RVA: 0x0001496E File Offset: 0x00012B6E
			public Transform controllerGroupLabelGroup
			{
				get
				{
					return this._controllerGroupLabelGroup;
				}
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06002F77 RID: 12151 RVA: 0x00014976 File Offset: 0x00012B76
			public UIGroup controllerSettingsGroup
			{
				get
				{
					return this._controllerSettingsGroup;
				}
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06002F78 RID: 12152 RVA: 0x0001497E File Offset: 0x00012B7E
			public UIGroup assignedControllersGroup
			{
				get
				{
					return this._assignedControllersGroup;
				}
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00014986 File Offset: 0x00012B86
			public Transform settingsAndMapCategoriesGroup
			{
				get
				{
					return this._settingsAndMapCategoriesGroup;
				}
			}

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06002F7A RID: 12154 RVA: 0x0001498E File Offset: 0x00012B8E
			public UIGroup settingsGroup
			{
				get
				{
					return this._settingsGroup;
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06002F7B RID: 12155 RVA: 0x00014996 File Offset: 0x00012B96
			public UIGroup mapCategoriesGroup
			{
				get
				{
					return this._mapCategoriesGroup;
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06002F7C RID: 12156 RVA: 0x0001499E File Offset: 0x00012B9E
			public Transform inputGridGroup
			{
				get
				{
					return this._inputGridGroup;
				}
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06002F7D RID: 12157 RVA: 0x000149A6 File Offset: 0x00012BA6
			public Transform inputGridContainer
			{
				get
				{
					return this._inputGridContainer;
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06002F7E RID: 12158 RVA: 0x000149AE File Offset: 0x00012BAE
			public Transform inputGridHeadersGroup
			{
				get
				{
					return this._inputGridHeadersGroup;
				}
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06002F7F RID: 12159 RVA: 0x000149B6 File Offset: 0x00012BB6
			public Scrollbar inputGridVScrollbar
			{
				get
				{
					return this._inputGridVScrollbar;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06002F80 RID: 12160 RVA: 0x000149BE File Offset: 0x00012BBE
			public ScrollRect inputGridScrollRect
			{
				get
				{
					return this._inputGridScrollRect;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06002F81 RID: 12161 RVA: 0x000149C6 File Offset: 0x00012BC6
			public Transform inputGridInnerGroup
			{
				get
				{
					return this._inputGridInnerGroup;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x06002F82 RID: 12162 RVA: 0x000149CE File Offset: 0x00012BCE
			public Text controllerNameLabel
			{
				get
				{
					return this._controllerNameLabel;
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x06002F83 RID: 12163 RVA: 0x000149D6 File Offset: 0x00012BD6
			public Button removeControllerButton
			{
				get
				{
					return this._removeControllerButton;
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x06002F84 RID: 12164 RVA: 0x000149DE File Offset: 0x00012BDE
			public Button assignControllerButton
			{
				get
				{
					return this._assignControllerButton;
				}
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x06002F85 RID: 12165 RVA: 0x000149E6 File Offset: 0x00012BE6
			public Button calibrateControllerButton
			{
				get
				{
					return this._calibrateControllerButton;
				}
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x06002F86 RID: 12166 RVA: 0x000149EE File Offset: 0x00012BEE
			public Button doneButton
			{
				get
				{
					return this._doneButton;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x06002F87 RID: 12167 RVA: 0x000149F6 File Offset: 0x00012BF6
			public Button restoreDefaultsButton
			{
				get
				{
					return this._restoreDefaultsButton;
				}
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000149FE File Offset: 0x00012BFE
			public Selectable defaultSelection
			{
				get
				{
					return this._defaultSelection;
				}
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00014A06 File Offset: 0x00012C06
			public GameObject[] fixedSelectableUIElements
			{
				get
				{
					return this._fixedSelectableUIElements;
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x06002F8A RID: 12170 RVA: 0x00014A0E File Offset: 0x00012C0E
			public Image mainBackgroundImage
			{
				get
				{
					return this._mainBackgroundImage;
				}
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x06002F8B RID: 12171 RVA: 0x00014A16 File Offset: 0x00012C16
			// (set) Token: 0x06002F8C RID: 12172 RVA: 0x00014A1E File Offset: 0x00012C1E
			public LayoutElement inputGridLayoutElement { get; set; }

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x06002F8D RID: 12173 RVA: 0x00014A27 File Offset: 0x00012C27
			// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00014A2F File Offset: 0x00012C2F
			public Transform inputGridActionColumn { get; set; }

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x06002F8F RID: 12175 RVA: 0x00014A38 File Offset: 0x00012C38
			// (set) Token: 0x06002F90 RID: 12176 RVA: 0x00014A40 File Offset: 0x00012C40
			public Transform inputGridKeyboardColumn { get; set; }

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06002F91 RID: 12177 RVA: 0x00014A49 File Offset: 0x00012C49
			// (set) Token: 0x06002F92 RID: 12178 RVA: 0x00014A51 File Offset: 0x00012C51
			public Transform inputGridMouseColumn { get; set; }

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06002F93 RID: 12179 RVA: 0x00014A5A File Offset: 0x00012C5A
			// (set) Token: 0x06002F94 RID: 12180 RVA: 0x00014A62 File Offset: 0x00012C62
			public Transform inputGridControllerColumn { get; set; }

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06002F95 RID: 12181 RVA: 0x00014A6B File Offset: 0x00012C6B
			// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00014A73 File Offset: 0x00012C73
			public Transform inputGridHeader1 { get; set; }

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x06002F97 RID: 12183 RVA: 0x00014A7C File Offset: 0x00012C7C
			// (set) Token: 0x06002F98 RID: 12184 RVA: 0x00014A84 File Offset: 0x00012C84
			public Transform inputGridHeader2 { get; set; }

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06002F99 RID: 12185 RVA: 0x00014A8D File Offset: 0x00012C8D
			// (set) Token: 0x06002F9A RID: 12186 RVA: 0x00014A95 File Offset: 0x00012C95
			public Transform inputGridHeader3 { get; set; }

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06002F9B RID: 12187 RVA: 0x00014A9E File Offset: 0x00012C9E
			// (set) Token: 0x06002F9C RID: 12188 RVA: 0x00014AA6 File Offset: 0x00012CA6
			public Transform inputGridHeader4 { get; set; }

			// Token: 0x06002F9D RID: 12189 RVA: 0x00142B7C File Offset: 0x00140D7C
			public bool Check()
			{
				return !(this._canvas == null) && !(this._mainCanvasGroup == null) && !(this._mainContent == null) && !(this._mainContentInner == null) && !(this._playersGroup == null) && !(this._controllerGroup == null) && !(this._controllerGroupLabelGroup == null) && !(this._controllerSettingsGroup == null) && !(this._assignedControllersGroup == null) && !(this._settingsAndMapCategoriesGroup == null) && !(this._settingsGroup == null) && !(this._mapCategoriesGroup == null) && !(this._inputGridGroup == null) && !(this._inputGridContainer == null) && !(this._inputGridHeadersGroup == null) && !(this._inputGridVScrollbar == null) && !(this._inputGridScrollRect == null) && !(this._inputGridInnerGroup == null) && !(this._controllerNameLabel == null) && !(this._removeControllerButton == null) && !(this._assignControllerButton == null) && !(this._calibrateControllerButton == null) && !(this._doneButton == null) && !(this._restoreDefaultsButton == null) && !(this._defaultSelection == null);
			}

			// Token: 0x0400097D RID: 2429
			[SerializeField]
			private Canvas _canvas;

			// Token: 0x0400097E RID: 2430
			[SerializeField]
			private CanvasGroup _mainCanvasGroup;

			// Token: 0x0400097F RID: 2431
			[SerializeField]
			private Transform _mainContent;

			// Token: 0x04000980 RID: 2432
			[SerializeField]
			private Transform _mainContentInner;

			// Token: 0x04000981 RID: 2433
			[SerializeField]
			private UIGroup _playersGroup;

			// Token: 0x04000982 RID: 2434
			[SerializeField]
			private Transform _controllerGroup;

			// Token: 0x04000983 RID: 2435
			[SerializeField]
			private Transform _controllerGroupLabelGroup;

			// Token: 0x04000984 RID: 2436
			[SerializeField]
			private UIGroup _controllerSettingsGroup;

			// Token: 0x04000985 RID: 2437
			[SerializeField]
			private UIGroup _assignedControllersGroup;

			// Token: 0x04000986 RID: 2438
			[SerializeField]
			private Transform _settingsAndMapCategoriesGroup;

			// Token: 0x04000987 RID: 2439
			[SerializeField]
			private UIGroup _settingsGroup;

			// Token: 0x04000988 RID: 2440
			[SerializeField]
			private UIGroup _mapCategoriesGroup;

			// Token: 0x04000989 RID: 2441
			[SerializeField]
			private Transform _inputGridGroup;

			// Token: 0x0400098A RID: 2442
			[SerializeField]
			private Transform _inputGridContainer;

			// Token: 0x0400098B RID: 2443
			[SerializeField]
			private Transform _inputGridHeadersGroup;

			// Token: 0x0400098C RID: 2444
			[SerializeField]
			private Scrollbar _inputGridVScrollbar;

			// Token: 0x0400098D RID: 2445
			[SerializeField]
			private ScrollRect _inputGridScrollRect;

			// Token: 0x0400098E RID: 2446
			[SerializeField]
			private Transform _inputGridInnerGroup;

			// Token: 0x0400098F RID: 2447
			[SerializeField]
			private Text _controllerNameLabel;

			// Token: 0x04000990 RID: 2448
			[SerializeField]
			private Button _removeControllerButton;

			// Token: 0x04000991 RID: 2449
			[SerializeField]
			private Button _assignControllerButton;

			// Token: 0x04000992 RID: 2450
			[SerializeField]
			private Button _calibrateControllerButton;

			// Token: 0x04000993 RID: 2451
			[SerializeField]
			private Button _doneButton;

			// Token: 0x04000994 RID: 2452
			[SerializeField]
			private Button _restoreDefaultsButton;

			// Token: 0x04000995 RID: 2453
			[SerializeField]
			private Selectable _defaultSelection;

			// Token: 0x04000996 RID: 2454
			[SerializeField]
			private GameObject[] _fixedSelectableUIElements;

			// Token: 0x04000997 RID: 2455
			[SerializeField]
			private Image _mainBackgroundImage;
		}

		// Token: 0x02000116 RID: 278
		private class InputActionSet
		{
			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06002F9F RID: 12191 RVA: 0x00014AAF File Offset: 0x00012CAF
			public int actionId
			{
				get
				{
					return this._actionId;
				}
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x00014AB7 File Offset: 0x00012CB7
			public AxisRange axisRange
			{
				get
				{
					return this._axisRange;
				}
			}

			// Token: 0x06002FA1 RID: 12193 RVA: 0x00014ABF File Offset: 0x00012CBF
			public InputActionSet(int actionId, AxisRange axisRange)
			{
				this._actionId = actionId;
				this._axisRange = axisRange;
			}

			// Token: 0x040009A1 RID: 2465
			private int _actionId;

			// Token: 0x040009A2 RID: 2466
			private AxisRange _axisRange;
		}

		// Token: 0x02000117 RID: 279
		private class InputMapping
		{
			// Token: 0x1700037F RID: 895
			// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x00014AD5 File Offset: 0x00012CD5
			// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x00014ADD File Offset: 0x00012CDD
			public string actionName { get; private set; }

			// Token: 0x17000380 RID: 896
			// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x00014AE6 File Offset: 0x00012CE6
			// (set) Token: 0x06002FA5 RID: 12197 RVA: 0x00014AEE File Offset: 0x00012CEE
			public InputFieldInfo fieldInfo { get; private set; }

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x00014AF7 File Offset: 0x00012CF7
			// (set) Token: 0x06002FA7 RID: 12199 RVA: 0x00014AFF File Offset: 0x00012CFF
			public ControllerMap map { get; private set; }

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x00014B08 File Offset: 0x00012D08
			// (set) Token: 0x06002FA9 RID: 12201 RVA: 0x00014B10 File Offset: 0x00012D10
			public ActionElementMap aem { get; private set; }

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x06002FAA RID: 12202 RVA: 0x00014B19 File Offset: 0x00012D19
			// (set) Token: 0x06002FAB RID: 12203 RVA: 0x00014B21 File Offset: 0x00012D21
			public ControllerType controllerType { get; private set; }

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06002FAC RID: 12204 RVA: 0x00014B2A File Offset: 0x00012D2A
			// (set) Token: 0x06002FAD RID: 12205 RVA: 0x00014B32 File Offset: 0x00012D32
			public int controllerId { get; private set; }

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06002FAE RID: 12206 RVA: 0x00014B3B File Offset: 0x00012D3B
			// (set) Token: 0x06002FAF RID: 12207 RVA: 0x00014B43 File Offset: 0x00012D43
			public ControllerPollingInfo pollingInfo { get; set; }

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x00014B4C File Offset: 0x00012D4C
			// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x00014B54 File Offset: 0x00012D54
			public ModifierKeyFlags modifierKeyFlags { get; set; }

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x00142D1C File Offset: 0x00140F1C
			public AxisRange axisRange
			{
				get
				{
					AxisRange result = AxisRange.Positive;
					if (this.pollingInfo.elementType == ControllerElementType.Axis)
					{
						if (this.fieldInfo.axisRange == AxisRange.Full)
						{
							result = AxisRange.Full;
						}
						else
						{
							result = ((this.pollingInfo.axisPole == Pole.Positive) ? AxisRange.Positive : AxisRange.Negative);
						}
					}
					return result;
				}
			}

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x00142D64 File Offset: 0x00140F64
			public string elementName
			{
				get
				{
					if (this.controllerType == ControllerType.Keyboard && this.modifierKeyFlags != ModifierKeyFlags.None)
					{
						return string.Format("{0} + {1}", Keyboard.ModifierKeyFlagsToString(this.modifierKeyFlags), this.pollingInfo.elementIdentifierName);
					}
					string result = this.pollingInfo.elementIdentifierName;
					if (this.pollingInfo.elementType == ControllerElementType.Axis)
					{
						if (this.axisRange == AxisRange.Positive)
						{
							result = this.pollingInfo.elementIdentifier.positiveName;
						}
						else if (this.axisRange == AxisRange.Negative)
						{
							result = this.pollingInfo.elementIdentifier.negativeName;
						}
					}
					return result;
				}
			}

			// Token: 0x06002FB4 RID: 12212 RVA: 0x00014B5D File Offset: 0x00012D5D
			public InputMapping(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId)
			{
				this.actionName = actionName;
				this.fieldInfo = fieldInfo;
				this.map = map;
				this.aem = aem;
				this.controllerType = controllerType;
				this.controllerId = controllerId;
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x00014B92 File Offset: 0x00012D92
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo)
			{
				this.pollingInfo = pollingInfo;
				return this.ToElementAssignment();
			}

			// Token: 0x06002FB6 RID: 12214 RVA: 0x00014BA1 File Offset: 0x00012DA1
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags)
			{
				this.pollingInfo = pollingInfo;
				this.modifierKeyFlags = modifierKeyFlags;
				return this.ToElementAssignment();
			}

			// Token: 0x06002FB7 RID: 12215 RVA: 0x00142E04 File Offset: 0x00141004
			public ElementAssignment ToElementAssignment()
			{
				return new ElementAssignment(this.controllerType, this.pollingInfo.elementType, this.pollingInfo.elementIdentifierId, this.axisRange, this.pollingInfo.keyboardKey, this.modifierKeyFlags, this.fieldInfo.actionId, (this.fieldInfo.axisRange == AxisRange.Negative) ? Pole.Negative : Pole.Positive, false, (this.aem != null) ? this.aem.id : -1);
			}
		}

		// Token: 0x02000118 RID: 280
		private class AxisCalibrator
		{
			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06002FB8 RID: 12216 RVA: 0x00014BB7 File Offset: 0x00012DB7
			public bool isValid
			{
				get
				{
					return this.axis != null;
				}
			}

			// Token: 0x06002FB9 RID: 12217 RVA: 0x00142E88 File Offset: 0x00141088
			public AxisCalibrator(Joystick joystick, int axisIndex)
			{
				this.data = default(AxisCalibrationData);
				this.joystick = joystick;
				this.axisIndex = axisIndex;
				if (joystick != null && axisIndex >= 0 && joystick.axisCount > axisIndex)
				{
					this.axis = joystick.Axes[axisIndex];
					this.data = joystick.calibrationMap.GetAxis(axisIndex).GetData();
				}
				this.firstRun = true;
			}

			// Token: 0x06002FBA RID: 12218 RVA: 0x00142EF8 File Offset: 0x001410F8
			public void RecordMinMax()
			{
				if (this.axis == null)
				{
					return;
				}
				float valueRaw = this.axis.valueRaw;
				if (this.firstRun || valueRaw < this.data.min)
				{
					this.data.min = valueRaw;
				}
				if (this.firstRun || valueRaw > this.data.max)
				{
					this.data.max = valueRaw;
				}
				this.firstRun = false;
			}

			// Token: 0x06002FBB RID: 12219 RVA: 0x00014BC2 File Offset: 0x00012DC2
			public void RecordZero()
			{
				if (this.axis == null)
				{
					return;
				}
				this.data.zero = this.axis.valueRaw;
			}

			// Token: 0x06002FBC RID: 12220 RVA: 0x00142F68 File Offset: 0x00141168
			public void Commit()
			{
				if (this.axis == null)
				{
					return;
				}
				AxisCalibration axisCalibration = this.joystick.calibrationMap.GetAxis(this.axisIndex);
				if (axisCalibration == null)
				{
					return;
				}
				if ((double)Mathf.Abs(this.data.max - this.data.min) < 0.1)
				{
					return;
				}
				axisCalibration.SetData(this.data);
			}

			// Token: 0x040009AB RID: 2475
			public AxisCalibrationData data;

			// Token: 0x040009AC RID: 2476
			public readonly Joystick joystick;

			// Token: 0x040009AD RID: 2477
			public readonly int axisIndex;

			// Token: 0x040009AE RID: 2478
			private Controller.Axis axis;

			// Token: 0x040009AF RID: 2479
			private bool firstRun;
		}

		// Token: 0x02000119 RID: 281
		private class IndexedDictionary<TKey, TValue>
		{
			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06002FBD RID: 12221 RVA: 0x00014BE3 File Offset: 0x00012DE3
			public int Count
			{
				get
				{
					return this.list.Count;
				}
			}

			// Token: 0x06002FBE RID: 12222 RVA: 0x00014BF0 File Offset: 0x00012DF0
			public IndexedDictionary()
			{
				this.list = new List<ControlMapper.IndexedDictionary<TKey, TValue>.Entry>();
			}

			// Token: 0x1700038B RID: 907
			public TValue this[int index]
			{
				get
				{
					return this.list[index].value;
				}
			}

			// Token: 0x06002FC0 RID: 12224 RVA: 0x00142FD0 File Offset: 0x001411D0
			public TValue Get(TKey key)
			{
				int num = this.IndexOfKey(key);
				if (num < 0)
				{
					throw new Exception("Key does not exist!");
				}
				return this.list[num].value;
			}

			// Token: 0x06002FC1 RID: 12225 RVA: 0x00143008 File Offset: 0x00141208
			public bool TryGet(TKey key, out TValue value)
			{
				value = default(TValue);
				int num = this.IndexOfKey(key);
				if (num < 0)
				{
					return false;
				}
				value = this.list[num].value;
				return true;
			}

			// Token: 0x06002FC2 RID: 12226 RVA: 0x00014C16 File Offset: 0x00012E16
			public void Add(TKey key, TValue value)
			{
				if (this.ContainsKey(key))
				{
					throw new Exception("Key " + key.ToString() + " is already in use!");
				}
				this.list.Add(new ControlMapper.IndexedDictionary<TKey, TValue>.Entry(key, value));
			}

			// Token: 0x06002FC3 RID: 12227 RVA: 0x00143044 File Offset: 0x00141244
			public int IndexOfKey(TKey key)
			{
				int count = this.list.Count;
				for (int i = 0; i < count; i++)
				{
					if (EqualityComparer<TKey>.Default.Equals(this.list[i].key, key))
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06002FC4 RID: 12228 RVA: 0x0014308C File Offset: 0x0014128C
			public bool ContainsKey(TKey key)
			{
				int count = this.list.Count;
				for (int i = 0; i < count; i++)
				{
					if (EqualityComparer<TKey>.Default.Equals(this.list[i].key, key))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06002FC5 RID: 12229 RVA: 0x00014C55 File Offset: 0x00012E55
			public void Clear()
			{
				this.list.Clear();
			}

			// Token: 0x040009B0 RID: 2480
			private List<ControlMapper.IndexedDictionary<TKey, TValue>.Entry> list;

			// Token: 0x0200011A RID: 282
			private class Entry
			{
				// Token: 0x06002FC6 RID: 12230 RVA: 0x00014C62 File Offset: 0x00012E62
				public Entry(TKey key, TValue value)
				{
					this.key = key;
					this.value = value;
				}

				// Token: 0x040009B1 RID: 2481
				public TKey key;

				// Token: 0x040009B2 RID: 2482
				public TValue value;
			}
		}

		// Token: 0x0200011B RID: 283
		private enum LayoutElementSizeType
		{
			// Token: 0x040009B4 RID: 2484
			MinSize,
			// Token: 0x040009B5 RID: 2485
			PreferredSize
		}

		// Token: 0x0200011C RID: 284
		private enum WindowType
		{
			// Token: 0x040009B7 RID: 2487
			None,
			// Token: 0x040009B8 RID: 2488
			ChooseJoystick,
			// Token: 0x040009B9 RID: 2489
			JoystickAssignmentConflict,
			// Token: 0x040009BA RID: 2490
			ElementAssignment,
			// Token: 0x040009BB RID: 2491
			ElementAssignmentPrePolling,
			// Token: 0x040009BC RID: 2492
			ElementAssignmentPolling,
			// Token: 0x040009BD RID: 2493
			ElementAssignmentResult,
			// Token: 0x040009BE RID: 2494
			ElementAssignmentConflict,
			// Token: 0x040009BF RID: 2495
			Calibration,
			// Token: 0x040009C0 RID: 2496
			CalibrateStep1,
			// Token: 0x040009C1 RID: 2497
			CalibrateStep2
		}

		// Token: 0x0200011D RID: 285
		private class InputGrid
		{
			// Token: 0x06002FC7 RID: 12231 RVA: 0x00014C78 File Offset: 0x00012E78
			public InputGrid()
			{
				this.list = new ControlMapper.InputGridEntryList();
				this.groups = new List<GameObject>();
			}

			// Token: 0x06002FC8 RID: 12232 RVA: 0x00014C96 File Offset: 0x00012E96
			public void AddMapCategory(int mapCategoryId)
			{
				this.list.AddMapCategory(mapCategoryId);
			}

			// Token: 0x06002FC9 RID: 12233 RVA: 0x00014CA4 File Offset: 0x00012EA4
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				this.list.AddAction(mapCategoryId, action, axisRange);
			}

			// Token: 0x06002FCA RID: 12234 RVA: 0x00014CB4 File Offset: 0x00012EB4
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
				this.list.AddActionCategory(mapCategoryId, actionCategoryId);
			}

			// Token: 0x06002FCB RID: 12235 RVA: 0x00014CC3 File Offset: 0x00012EC3
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
				this.list.AddInputFieldSet(mapCategoryId, action, axisRange, controllerType, fieldSetContainer);
			}

			// Token: 0x06002FCC RID: 12236 RVA: 0x00014CD7 File Offset: 0x00012ED7
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
				this.list.AddInputField(mapCategoryId, action, axisRange, controllerType, fieldIndex, inputField);
			}

			// Token: 0x06002FCD RID: 12237 RVA: 0x00014CED File Offset: 0x00012EED
			public void AddGroup(GameObject group)
			{
				this.groups.Add(group);
			}

			// Token: 0x06002FCE RID: 12238 RVA: 0x00014CFB File Offset: 0x00012EFB
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
				this.list.AddActionLabel(mapCategoryId, actionId, axisRange, label);
			}

			// Token: 0x06002FCF RID: 12239 RVA: 0x00014D0D File Offset: 0x00012F0D
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
				this.list.AddActionCategoryLabel(mapCategoryId, actionCategoryId, label);
			}

			// Token: 0x06002FD0 RID: 12240 RVA: 0x00014D1D File Offset: 0x00012F1D
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return this.list.Contains(mapCategoryId, actionId, axisRange, controllerType, fieldIndex);
			}

			// Token: 0x06002FD1 RID: 12241 RVA: 0x00014D31 File Offset: 0x00012F31
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return this.list.GetGUIInputField(mapCategoryId, actionId, axisRange, controllerType, fieldIndex);
			}

			// Token: 0x06002FD2 RID: 12242 RVA: 0x00014D45 File Offset: 0x00012F45
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				return this.list.GetActionSets(mapCategoryId);
			}

			// Token: 0x06002FD3 RID: 12243 RVA: 0x00014D53 File Offset: 0x00012F53
			public void SetColumnHeight(int mapCategoryId, float height)
			{
				this.list.SetColumnHeight(mapCategoryId, height);
			}

			// Token: 0x06002FD4 RID: 12244 RVA: 0x00014D62 File Offset: 0x00012F62
			public float GetColumnHeight(int mapCategoryId)
			{
				return this.list.GetColumnHeight(mapCategoryId);
			}

			// Token: 0x06002FD5 RID: 12245 RVA: 0x00014D70 File Offset: 0x00012F70
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
				this.list.SetFieldsActive(mapCategoryId, state);
			}

			// Token: 0x06002FD6 RID: 12246 RVA: 0x00014D7F File Offset: 0x00012F7F
			public void SetFieldLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
			{
				this.list.SetLabel(mapCategoryId, actionId, axisRange, controllerType, index, label);
			}

			// Token: 0x06002FD7 RID: 12247 RVA: 0x001430D4 File Offset: 0x001412D4
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
				this.list.PopulateField(mapCategoryId, actionId, axisRange, controllerType, controllerId, index, actionElementMapId, label, invert);
			}

			// Token: 0x06002FD8 RID: 12248 RVA: 0x00014D95 File Offset: 0x00012F95
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
				this.list.SetFixedFieldData(mapCategoryId, actionId, axisRange, controllerType, controllerId);
			}

			// Token: 0x06002FD9 RID: 12249 RVA: 0x00014DA9 File Offset: 0x00012FA9
			public void InitializeFields(int mapCategoryId)
			{
				this.list.InitializeFields(mapCategoryId);
			}

			// Token: 0x06002FDA RID: 12250 RVA: 0x00014DB7 File Offset: 0x00012FB7
			public void Show(int mapCategoryId)
			{
				this.list.Show(mapCategoryId);
			}

			// Token: 0x06002FDB RID: 12251 RVA: 0x00014DC5 File Offset: 0x00012FC5
			public void HideAll()
			{
				this.list.HideAll();
			}

			// Token: 0x06002FDC RID: 12252 RVA: 0x00014DD2 File Offset: 0x00012FD2
			public void ClearLabels(int mapCategoryId)
			{
				this.list.ClearLabels(mapCategoryId);
			}

			// Token: 0x06002FDD RID: 12253 RVA: 0x001430FC File Offset: 0x001412FC
			private void ClearGroups()
			{
				for (int i = 0; i < this.groups.Count; i++)
				{
					if (!(this.groups[i] == null))
					{
						UnityEngine.Object.Destroy(this.groups[i]);
					}
				}
			}

			// Token: 0x06002FDE RID: 12254 RVA: 0x00014DE0 File Offset: 0x00012FE0
			public void ClearAll()
			{
				this.ClearGroups();
				this.list.Clear();
			}

			// Token: 0x040009C2 RID: 2498
			private ControlMapper.InputGridEntryList list;

			// Token: 0x040009C3 RID: 2499
			private List<GameObject> groups;
		}

		// Token: 0x0200011E RID: 286
		private class InputGridEntryList
		{
			// Token: 0x06002FDF RID: 12255 RVA: 0x00014DF3 File Offset: 0x00012FF3
			public InputGridEntryList()
			{
				this.entries = new ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.MapCategoryEntry>();
			}

			// Token: 0x06002FE0 RID: 12256 RVA: 0x00014E06 File Offset: 0x00013006
			public void AddMapCategory(int mapCategoryId)
			{
				if (mapCategoryId < 0)
				{
					return;
				}
				if (this.entries.ContainsKey(mapCategoryId))
				{
					return;
				}
				this.entries.Add(mapCategoryId, new ControlMapper.InputGridEntryList.MapCategoryEntry());
			}

			// Token: 0x06002FE1 RID: 12257 RVA: 0x00014E2D File Offset: 0x0001302D
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				this.AddActionEntry(mapCategoryId, action, axisRange);
			}

			// Token: 0x06002FE2 RID: 12258 RVA: 0x00143144 File Offset: 0x00141344
			private ControlMapper.InputGridEntryList.ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				if (action == null)
				{
					return null;
				}
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return null;
				}
				return mapCategoryEntry.AddAction(action, axisRange);
			}

			// Token: 0x06002FE3 RID: 12259 RVA: 0x00143170 File Offset: 0x00141370
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = mapCategoryEntry.GetActionEntry(actionId, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.SetLabel(label);
			}

			// Token: 0x06002FE4 RID: 12260 RVA: 0x00014E39 File Offset: 0x00013039
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
				this.AddActionCategoryEntry(mapCategoryId, actionCategoryId);
			}

			// Token: 0x06002FE5 RID: 12261 RVA: 0x001431A4 File Offset: 0x001413A4
			private ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return null;
				}
				return mapCategoryEntry.AddActionCategory(actionCategoryId);
			}

			// Token: 0x06002FE6 RID: 12262 RVA: 0x001431CC File Offset: 0x001413CC
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				ControlMapper.InputGridEntryList.ActionCategoryEntry actionCategoryEntry = mapCategoryEntry.GetActionCategoryEntry(actionCategoryId);
				if (actionCategoryEntry == null)
				{
					return;
				}
				actionCategoryEntry.SetLabel(label);
			}

			// Token: 0x06002FE7 RID: 12263 RVA: 0x00143200 File Offset: 0x00141400
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, action, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.AddInputFieldSet(controllerType, fieldSetContainer);
			}

			// Token: 0x06002FE8 RID: 12264 RVA: 0x00143228 File Offset: 0x00141428
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, action, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.AddInputField(controllerType, fieldIndex, inputField);
			}

			// Token: 0x06002FE9 RID: 12265 RVA: 0x00014E44 File Offset: 0x00013044
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange)
			{
				return this.GetActionEntry(mapCategoryId, actionId, axisRange) != null;
			}

			// Token: 0x06002FEA RID: 12266 RVA: 0x00143250 File Offset: 0x00141450
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				return actionEntry != null && actionEntry.Contains(controllerType, fieldIndex);
			}

			// Token: 0x06002FEB RID: 12267 RVA: 0x00143278 File Offset: 0x00141478
			public void SetColumnHeight(int mapCategoryId, float height)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				mapCategoryEntry.columnHeight = height;
			}

			// Token: 0x06002FEC RID: 12268 RVA: 0x001432A0 File Offset: 0x001414A0
			public float GetColumnHeight(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return 0f;
				}
				return mapCategoryEntry.columnHeight;
			}

			// Token: 0x06002FED RID: 12269 RVA: 0x001432CC File Offset: 0x001414CC
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				if (actionEntry == null)
				{
					return null;
				}
				return actionEntry.GetGUIInputField(controllerType, fieldIndex);
			}

			// Token: 0x06002FEE RID: 12270 RVA: 0x001432F4 File Offset: 0x001414F4
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange)
			{
				if (actionId < 0)
				{
					return null;
				}
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return null;
				}
				return mapCategoryEntry.GetActionEntry(actionId, axisRange);
			}

			// Token: 0x06002FEF RID: 12271 RVA: 0x00014E52 File Offset: 0x00013052
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				if (action == null)
				{
					return null;
				}
				return this.GetActionEntry(mapCategoryId, action.id, axisRange);
			}

			// Token: 0x06002FF0 RID: 12272 RVA: 0x00014E67 File Offset: 0x00013067
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.<GetActionSets>d__18 <GetActionSets>d__ = new ControlMapper.InputGridEntryList.<GetActionSets>d__18(-2);
				<GetActionSets>d__.<>4__this = this;
				<GetActionSets>d__.<>3__mapCategoryId = mapCategoryId;
				return <GetActionSets>d__;
			}

			// Token: 0x06002FF1 RID: 12273 RVA: 0x00143324 File Offset: 0x00141524
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				List<ControlMapper.InputGridEntryList.ActionEntry> actionList = mapCategoryEntry.actionList;
				int num = (actionList != null) ? actionList.Count : 0;
				for (int i = 0; i < num; i++)
				{
					actionList[i].SetFieldsActive(state);
				}
			}

			// Token: 0x06002FF2 RID: 12274 RVA: 0x00143370 File Offset: 0x00141570
			public void SetLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.SetFieldLabel(controllerType, index, label);
			}

			// Token: 0x06002FF3 RID: 12275 RVA: 0x00143398 File Offset: 0x00141598
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.PopulateField(controllerType, controllerId, index, actionElementMapId, label, invert);
			}

			// Token: 0x06002FF4 RID: 12276 RVA: 0x001433C8 File Offset: 0x001415C8
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
				ControlMapper.InputGridEntryList.ActionEntry actionEntry = this.GetActionEntry(mapCategoryId, actionId, axisRange);
				if (actionEntry == null)
				{
					return;
				}
				actionEntry.SetFixedFieldData(controllerType, controllerId);
			}

			// Token: 0x06002FF5 RID: 12277 RVA: 0x001433F0 File Offset: 0x001415F0
			public void InitializeFields(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				List<ControlMapper.InputGridEntryList.ActionEntry> actionList = mapCategoryEntry.actionList;
				int num = (actionList != null) ? actionList.Count : 0;
				for (int i = 0; i < num; i++)
				{
					actionList[i].Initialize();
				}
			}

			// Token: 0x06002FF6 RID: 12278 RVA: 0x0014343C File Offset: 0x0014163C
			public void Show(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				mapCategoryEntry.SetAllActive(true);
			}

			// Token: 0x06002FF7 RID: 12279 RVA: 0x00143464 File Offset: 0x00141664
			public void HideAll()
			{
				for (int i = 0; i < this.entries.Count; i++)
				{
					this.entries[i].SetAllActive(false);
				}
			}

			// Token: 0x06002FF8 RID: 12280 RVA: 0x0014349C File Offset: 0x0014169C
			public void ClearLabels(int mapCategoryId)
			{
				ControlMapper.InputGridEntryList.MapCategoryEntry mapCategoryEntry;
				if (!this.entries.TryGet(mapCategoryId, out mapCategoryEntry))
				{
					return;
				}
				List<ControlMapper.InputGridEntryList.ActionEntry> actionList = mapCategoryEntry.actionList;
				int num = (actionList != null) ? actionList.Count : 0;
				for (int i = 0; i < num; i++)
				{
					actionList[i].ClearLabels();
				}
			}

			// Token: 0x06002FF9 RID: 12281 RVA: 0x00014E7E File Offset: 0x0001307E
			public void Clear()
			{
				this.entries.Clear();
			}

			// Token: 0x040009C4 RID: 2500
			private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.MapCategoryEntry> entries;

			// Token: 0x0200011F RID: 287
			private class MapCategoryEntry
			{
				// Token: 0x1700038C RID: 908
				// (get) Token: 0x06002FFA RID: 12282 RVA: 0x00014E8B File Offset: 0x0001308B
				public List<ControlMapper.InputGridEntryList.ActionEntry> actionList
				{
					get
					{
						return this._actionList;
					}
				}

				// Token: 0x1700038D RID: 909
				// (get) Token: 0x06002FFB RID: 12283 RVA: 0x00014E93 File Offset: 0x00013093
				public ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> actionCategoryList
				{
					get
					{
						return this._actionCategoryList;
					}
				}

				// Token: 0x1700038E RID: 910
				// (get) Token: 0x06002FFC RID: 12284 RVA: 0x00014E9B File Offset: 0x0001309B
				// (set) Token: 0x06002FFD RID: 12285 RVA: 0x00014EA3 File Offset: 0x000130A3
				public float columnHeight
				{
					get
					{
						return this._columnHeight;
					}
					set
					{
						this._columnHeight = value;
					}
				}

				// Token: 0x06002FFE RID: 12286 RVA: 0x00014EAC File Offset: 0x000130AC
				public MapCategoryEntry()
				{
					this._actionList = new List<ControlMapper.InputGridEntryList.ActionEntry>();
					this._actionCategoryList = new ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry>();
				}

				// Token: 0x06002FFF RID: 12287 RVA: 0x001434E8 File Offset: 0x001416E8
				public ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int actionId, AxisRange axisRange)
				{
					int num = this.IndexOfActionEntry(actionId, axisRange);
					if (num < 0)
					{
						return null;
					}
					return this._actionList[num];
				}

				// Token: 0x06003000 RID: 12288 RVA: 0x00143510 File Offset: 0x00141710
				public int IndexOfActionEntry(int actionId, AxisRange axisRange)
				{
					int count = this._actionList.Count;
					for (int i = 0; i < count; i++)
					{
						if (this._actionList[i].Matches(actionId, axisRange))
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06003001 RID: 12289 RVA: 0x00014ECA File Offset: 0x000130CA
				public bool ContainsActionEntry(int actionId, AxisRange axisRange)
				{
					return this.IndexOfActionEntry(actionId, axisRange) >= 0;
				}

				// Token: 0x06003002 RID: 12290 RVA: 0x00143550 File Offset: 0x00141750
				public ControlMapper.InputGridEntryList.ActionEntry AddAction(InputAction action, AxisRange axisRange)
				{
					if (action == null)
					{
						return null;
					}
					if (this.ContainsActionEntry(action.id, axisRange))
					{
						return null;
					}
					this._actionList.Add(new ControlMapper.InputGridEntryList.ActionEntry(action, axisRange));
					return this._actionList[this._actionList.Count - 1];
				}

				// Token: 0x06003003 RID: 12291 RVA: 0x00014EDA File Offset: 0x000130DA
				public ControlMapper.InputGridEntryList.ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId)
				{
					if (!this._actionCategoryList.ContainsKey(actionCategoryId))
					{
						return null;
					}
					return this._actionCategoryList.Get(actionCategoryId);
				}

				// Token: 0x06003004 RID: 12292 RVA: 0x00014EF8 File Offset: 0x000130F8
				public ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategory(int actionCategoryId)
				{
					if (actionCategoryId < 0)
					{
						return null;
					}
					if (this._actionCategoryList.ContainsKey(actionCategoryId))
					{
						return null;
					}
					this._actionCategoryList.Add(actionCategoryId, new ControlMapper.InputGridEntryList.ActionCategoryEntry(actionCategoryId));
					return this._actionCategoryList.Get(actionCategoryId);
				}

				// Token: 0x06003005 RID: 12293 RVA: 0x001435A0 File Offset: 0x001417A0
				public void SetAllActive(bool state)
				{
					for (int i = 0; i < this._actionCategoryList.Count; i++)
					{
						this._actionCategoryList[i].SetActive(state);
					}
					for (int j = 0; j < this._actionList.Count; j++)
					{
						this._actionList[j].SetActive(state);
					}
				}

				// Token: 0x040009C5 RID: 2501
				private List<ControlMapper.InputGridEntryList.ActionEntry> _actionList;

				// Token: 0x040009C6 RID: 2502
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> _actionCategoryList;

				// Token: 0x040009C7 RID: 2503
				private float _columnHeight;
			}

			// Token: 0x02000120 RID: 288
			private class ActionEntry
			{
				// Token: 0x06003006 RID: 12294 RVA: 0x00014F2E File Offset: 0x0001312E
				public ActionEntry(InputAction action, AxisRange axisRange)
				{
					this.action = action;
					this.axisRange = axisRange;
					this.actionSet = new ControlMapper.InputActionSet(action.id, axisRange);
					this.fieldSets = new ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.FieldSet>();
				}

				// Token: 0x06003007 RID: 12295 RVA: 0x00014F61 File Offset: 0x00013161
				public void SetLabel(ControlMapper.GUILabel label)
				{
					this.label = label;
				}

				// Token: 0x06003008 RID: 12296 RVA: 0x00014F6A File Offset: 0x0001316A
				public bool Matches(int actionId, AxisRange axisRange)
				{
					return this.action.id == actionId && this.axisRange == axisRange;
				}

				// Token: 0x06003009 RID: 12297 RVA: 0x00014F88 File Offset: 0x00013188
				public void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer)
				{
					if (this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					this.fieldSets.Add((int)controllerType, new ControlMapper.InputGridEntryList.FieldSet(fieldSetContainer));
				}

				// Token: 0x0600300A RID: 12298 RVA: 0x00143600 File Offset: 0x00141800
				public void AddInputField(ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets.Get((int)controllerType);
					if (fieldSet.fields.ContainsKey(fieldIndex))
					{
						return;
					}
					fieldSet.fields.Add(fieldIndex, inputField);
				}

				// Token: 0x0600300B RID: 12299 RVA: 0x00143648 File Offset: 0x00141848
				public ControlMapper.GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return null;
					}
					if (!this.fieldSets.Get((int)controllerType).fields.ContainsKey(fieldIndex))
					{
						return null;
					}
					return this.fieldSets.Get((int)controllerType).fields.Get(fieldIndex);
				}

				// Token: 0x0600300C RID: 12300 RVA: 0x00014FAB File Offset: 0x000131AB
				public bool Contains(ControllerType controllerType, int fieldId)
				{
					return this.fieldSets.ContainsKey((int)controllerType) && this.fieldSets.Get((int)controllerType).fields.ContainsKey(fieldId);
				}

				// Token: 0x0600300D RID: 12301 RVA: 0x00143698 File Offset: 0x00141898
				public void SetFieldLabel(ControllerType controllerType, int index, string label)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					if (!this.fieldSets.Get((int)controllerType).fields.ContainsKey(index))
					{
						return;
					}
					this.fieldSets.Get((int)controllerType).fields.Get(index).SetLabel(label);
				}

				// Token: 0x0600300E RID: 12302 RVA: 0x001436EC File Offset: 0x001418EC
				public void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					if (!this.fieldSets.Get((int)controllerType).fields.ContainsKey(index))
					{
						return;
					}
					ControlMapper.GUIInputField guiinputField = this.fieldSets.Get((int)controllerType).fields.Get(index);
					guiinputField.SetLabel(label);
					guiinputField.actionElementMapId = actionElementMapId;
					guiinputField.controllerId = controllerId;
					if (guiinputField.hasToggle)
					{
						guiinputField.toggle.SetInteractible(true, false);
						guiinputField.toggle.SetToggleState(invert);
						guiinputField.toggle.actionElementMapId = actionElementMapId;
					}
				}

				// Token: 0x0600300F RID: 12303 RVA: 0x00143780 File Offset: 0x00141980
				public void SetFixedFieldData(ControllerType controllerType, int controllerId)
				{
					if (!this.fieldSets.ContainsKey((int)controllerType))
					{
						return;
					}
					ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets.Get((int)controllerType);
					int count = fieldSet.fields.Count;
					for (int i = 0; i < count; i++)
					{
						fieldSet.fields[i].controllerId = controllerId;
					}
				}

				// Token: 0x06003010 RID: 12304 RVA: 0x001437D4 File Offset: 0x001419D4
				public void Initialize()
				{
					for (int i = 0; i < this.fieldSets.Count; i++)
					{
						ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets[i];
						int count = fieldSet.fields.Count;
						for (int j = 0; j < count; j++)
						{
							ControlMapper.GUIInputField guiinputField = fieldSet.fields[j];
							if (guiinputField.hasToggle)
							{
								guiinputField.toggle.SetInteractible(false, false);
								guiinputField.toggle.SetToggleState(false);
								guiinputField.toggle.actionElementMapId = -1;
							}
							guiinputField.SetLabel("");
							guiinputField.actionElementMapId = -1;
							guiinputField.controllerId = -1;
						}
					}
				}

				// Token: 0x06003011 RID: 12305 RVA: 0x00143880 File Offset: 0x00141A80
				public void SetActive(bool state)
				{
					if (this.label != null)
					{
						this.label.SetActive(state);
					}
					int count = this.fieldSets.Count;
					for (int i = 0; i < count; i++)
					{
						this.fieldSets[i].groupContainer.SetActive(state);
					}
				}

				// Token: 0x06003012 RID: 12306 RVA: 0x001438D0 File Offset: 0x00141AD0
				public void ClearLabels()
				{
					for (int i = 0; i < this.fieldSets.Count; i++)
					{
						ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets[i];
						int count = fieldSet.fields.Count;
						for (int j = 0; j < count; j++)
						{
							fieldSet.fields[j].SetLabel("");
						}
					}
				}

				// Token: 0x06003013 RID: 12307 RVA: 0x00143930 File Offset: 0x00141B30
				public void SetFieldsActive(bool state)
				{
					for (int i = 0; i < this.fieldSets.Count; i++)
					{
						ControlMapper.InputGridEntryList.FieldSet fieldSet = this.fieldSets[i];
						int count = fieldSet.fields.Count;
						for (int j = 0; j < count; j++)
						{
							ControlMapper.GUIInputField guiinputField = fieldSet.fields[j];
							guiinputField.SetInteractible(state, false);
							if (guiinputField.hasToggle && (!state || guiinputField.toggle.actionElementMapId >= 0))
							{
								guiinputField.toggle.SetInteractible(state, false);
							}
						}
					}
				}

				// Token: 0x040009C8 RID: 2504
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.FieldSet> fieldSets;

				// Token: 0x040009C9 RID: 2505
				public ControlMapper.GUILabel label;

				// Token: 0x040009CA RID: 2506
				public readonly InputAction action;

				// Token: 0x040009CB RID: 2507
				public readonly AxisRange axisRange;

				// Token: 0x040009CC RID: 2508
				public readonly ControlMapper.InputActionSet actionSet;
			}

			// Token: 0x02000121 RID: 289
			private class FieldSet
			{
				// Token: 0x06003014 RID: 12308 RVA: 0x00014FD9 File Offset: 0x000131D9
				public FieldSet(GameObject groupContainer)
				{
					this.groupContainer = groupContainer;
					this.fields = new ControlMapper.IndexedDictionary<int, ControlMapper.GUIInputField>();
				}

				// Token: 0x040009CD RID: 2509
				public readonly GameObject groupContainer;

				// Token: 0x040009CE RID: 2510
				public readonly ControlMapper.IndexedDictionary<int, ControlMapper.GUIInputField> fields;
			}

			// Token: 0x02000122 RID: 290
			private class ActionCategoryEntry
			{
				// Token: 0x06003015 RID: 12309 RVA: 0x00014FF3 File Offset: 0x000131F3
				public ActionCategoryEntry(int actionCategoryId)
				{
					this.actionCategoryId = actionCategoryId;
				}

				// Token: 0x06003016 RID: 12310 RVA: 0x00015002 File Offset: 0x00013202
				public void SetLabel(ControlMapper.GUILabel label)
				{
					this.label = label;
				}

				// Token: 0x06003017 RID: 12311 RVA: 0x0001500B File Offset: 0x0001320B
				public void SetActive(bool state)
				{
					if (this.label != null)
					{
						this.label.SetActive(state);
					}
				}

				// Token: 0x040009CF RID: 2511
				public readonly int actionCategoryId;

				// Token: 0x040009D0 RID: 2512
				public ControlMapper.GUILabel label;
			}
		}

		// Token: 0x02000124 RID: 292
		private class WindowManager
		{
			// Token: 0x17000391 RID: 913
			// (get) Token: 0x06003020 RID: 12320 RVA: 0x00143AC8 File Offset: 0x00141CC8
			public bool isWindowOpen
			{
				get
				{
					for (int i = this.windows.Count - 1; i >= 0; i--)
					{
						if (!(this.windows[i] == null))
						{
							return true;
						}
					}
					return false;
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x06003021 RID: 12321 RVA: 0x00143B04 File Offset: 0x00141D04
			public Window topWindow
			{
				get
				{
					for (int i = this.windows.Count - 1; i >= 0; i--)
					{
						if (!(this.windows[i] == null))
						{
							return this.windows[i];
						}
					}
					return null;
				}
			}

			// Token: 0x06003022 RID: 12322 RVA: 0x00143B4C File Offset: 0x00141D4C
			public WindowManager(GameObject windowPrefab, GameObject faderPrefab, Transform parent)
			{
				this.windowPrefab = windowPrefab;
				this.parent = parent;
				this.windows = new List<Window>();
				this.fader = UnityEngine.Object.Instantiate<GameObject>(faderPrefab);
				this.fader.transform.SetParent(parent, false);
				this.fader.GetComponent<RectTransform>().localScale = Vector2.one;
				this.SetFaderActive(false);
			}

			// Token: 0x06003023 RID: 12323 RVA: 0x0001504B File Offset: 0x0001324B
			public Window OpenWindow(string name, int width, int height)
			{
				Window result = this.InstantiateWindow(name, width, height);
				this.UpdateFader();
				return result;
			}

			// Token: 0x06003024 RID: 12324 RVA: 0x0001505C File Offset: 0x0001325C
			public Window OpenWindow(GameObject windowPrefab, string name)
			{
				if (windowPrefab == null)
				{
					Debug.LogError("Rewired Control Mapper: Window Prefab is null!");
					return null;
				}
				Window result = this.InstantiateWindow(name, windowPrefab);
				this.UpdateFader();
				return result;
			}

			// Token: 0x06003025 RID: 12325 RVA: 0x00143BB8 File Offset: 0x00141DB8
			public void CloseTop()
			{
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null))
					{
						this.DestroyWindow(this.windows[i]);
						this.windows.RemoveAt(i);
						IL_58:
						this.UpdateFader();
						return;
					}
					this.windows.RemoveAt(i);
				}
				goto IL_58;
			}

			// Token: 0x06003026 RID: 12326 RVA: 0x00015081 File Offset: 0x00013281
			public void CloseWindow(int windowId)
			{
				this.CloseWindow(this.GetWindow(windowId));
			}

			// Token: 0x06003027 RID: 12327 RVA: 0x00143C24 File Offset: 0x00141E24
			public void CloseWindow(Window window)
			{
				if (window == null)
				{
					return;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (this.windows[i] == null)
					{
						this.windows.RemoveAt(i);
					}
					else if (!(this.windows[i] != window))
					{
						this.DestroyWindow(this.windows[i]);
						this.windows.RemoveAt(i);
						IL_78:
						this.UpdateFader();
						this.FocusTopWindow();
						return;
					}
				}
				goto IL_78;
			}

			// Token: 0x06003028 RID: 12328 RVA: 0x00143CB8 File Offset: 0x00141EB8
			public void CloseAll()
			{
				this.SetFaderActive(false);
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (this.windows[i] == null)
					{
						this.windows.RemoveAt(i);
					}
					else
					{
						this.DestroyWindow(this.windows[i]);
						this.windows.RemoveAt(i);
					}
				}
				this.UpdateFader();
			}

			// Token: 0x06003029 RID: 12329 RVA: 0x00143D2C File Offset: 0x00141F2C
			public void CancelAll()
			{
				if (!this.isWindowOpen)
				{
					return;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null))
					{
						this.windows[i].Cancel();
					}
				}
				this.CloseAll();
			}

			// Token: 0x0600302A RID: 12330 RVA: 0x00143D88 File Offset: 0x00141F88
			public Window GetWindow(int windowId)
			{
				if (windowId < 0)
				{
					return null;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null) && this.windows[i].id == windowId)
					{
						return this.windows[i];
					}
				}
				return null;
			}

			// Token: 0x0600302B RID: 12331 RVA: 0x00015090 File Offset: 0x00013290
			public bool IsFocused(int windowId)
			{
				return windowId >= 0 && !(this.topWindow == null) && this.topWindow.id == windowId;
			}

			// Token: 0x0600302C RID: 12332 RVA: 0x000150B6 File Offset: 0x000132B6
			public void Focus(int windowId)
			{
				this.Focus(this.GetWindow(windowId));
			}

			// Token: 0x0600302D RID: 12333 RVA: 0x000150C5 File Offset: 0x000132C5
			public void Focus(Window window)
			{
				if (window == null)
				{
					return;
				}
				window.TakeInputFocus();
				this.DefocusOtherWindows(window.id);
			}

			// Token: 0x0600302E RID: 12334 RVA: 0x00143DEC File Offset: 0x00141FEC
			private void DefocusOtherWindows(int focusedWindowId)
			{
				if (focusedWindowId < 0)
				{
					return;
				}
				for (int i = this.windows.Count - 1; i >= 0; i--)
				{
					if (!(this.windows[i] == null) && this.windows[i].id != focusedWindowId)
					{
						this.windows[i].Disable();
					}
				}
			}

			// Token: 0x0600302F RID: 12335 RVA: 0x00143E50 File Offset: 0x00142050
			private void UpdateFader()
			{
				if (!this.isWindowOpen)
				{
					this.SetFaderActive(false);
					return;
				}
				if (this.topWindow.transform.parent == null)
				{
					return;
				}
				this.SetFaderActive(true);
				this.fader.transform.SetAsLastSibling();
				int siblingIndex = this.topWindow.transform.GetSiblingIndex();
				this.fader.transform.SetSiblingIndex(siblingIndex);
			}

			// Token: 0x06003030 RID: 12336 RVA: 0x000150E3 File Offset: 0x000132E3
			private void FocusTopWindow()
			{
				if (this.topWindow == null)
				{
					return;
				}
				this.topWindow.TakeInputFocus();
			}

			// Token: 0x06003031 RID: 12337 RVA: 0x000150FF File Offset: 0x000132FF
			private void SetFaderActive(bool state)
			{
				this.fader.SetActive(state);
			}

			// Token: 0x06003032 RID: 12338 RVA: 0x00143EC0 File Offset: 0x001420C0
			private Window InstantiateWindow(string name, int width, int height)
			{
				if (string.IsNullOrEmpty(name))
				{
					name = "Window";
				}
				GameObject gameObject = UITools.InstantiateGUIObject<Window>(this.windowPrefab, this.parent, name);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.Initialize(this.GetNewId(), new Func<int, bool>(this.IsFocused));
					this.windows.Add(component);
					component.SetSize(width, height);
				}
				return component;
			}

			// Token: 0x06003033 RID: 12339 RVA: 0x00143F38 File Offset: 0x00142138
			private Window InstantiateWindow(string name, GameObject windowPrefab)
			{
				if (string.IsNullOrEmpty(name))
				{
					name = "Window";
				}
				if (windowPrefab == null)
				{
					return null;
				}
				GameObject gameObject = UITools.InstantiateGUIObject<Window>(windowPrefab, this.parent, name);
				if (gameObject == null)
				{
					return null;
				}
				Window component = gameObject.GetComponent<Window>();
				if (component != null)
				{
					component.Initialize(this.GetNewId(), new Func<int, bool>(this.IsFocused));
					this.windows.Add(component);
				}
				return component;
			}

			// Token: 0x06003034 RID: 12340 RVA: 0x0001510D File Offset: 0x0001330D
			private void DestroyWindow(Window window)
			{
				if (window == null)
				{
					return;
				}
				UnityEngine.Object.Destroy(window.gameObject);
			}

			// Token: 0x06003035 RID: 12341 RVA: 0x00015124 File Offset: 0x00013324
			private int GetNewId()
			{
				int result = this.idCounter;
				this.idCounter++;
				return result;
			}

			// Token: 0x06003036 RID: 12342 RVA: 0x0001513A File Offset: 0x0001333A
			public void ClearCompletely()
			{
				this.CloseAll();
				if (this.fader != null)
				{
					UnityEngine.Object.Destroy(this.fader);
				}
			}

			// Token: 0x040009DA RID: 2522
			private List<Window> windows;

			// Token: 0x040009DB RID: 2523
			private GameObject windowPrefab;

			// Token: 0x040009DC RID: 2524
			private Transform parent;

			// Token: 0x040009DD RID: 2525
			private GameObject fader;

			// Token: 0x040009DE RID: 2526
			private int idCounter;
		}
	}
}
