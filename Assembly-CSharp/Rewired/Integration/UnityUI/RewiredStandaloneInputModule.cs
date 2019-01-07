using System;
using System.Collections.Generic;
using Rewired.Components;
using Rewired.UI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x020000FF RID: 255
	[AddComponentMenu("Event/Rewired Standalone Input Module")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x00012C41 File Offset: 0x00010E41
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00012C49 File Offset: 0x00010E49
		public InputManager_Base RewiredInputManager
		{
			get
			{
				return this.rewiredInputManager;
			}
			set
			{
				this.rewiredInputManager = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x00012C52 File Offset: 0x00010E52
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x00012C5A File Offset: 0x00010E5A
		public bool UseAllRewiredGamePlayers
		{
			get
			{
				return this.useAllRewiredGamePlayers;
			}
			set
			{
				bool flag = value != this.useAllRewiredGamePlayers;
				this.useAllRewiredGamePlayers = value;
				if (flag)
				{
					this.SetupRewiredVars();
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x00012C77 File Offset: 0x00010E77
		// (set) Token: 0x06002D6E RID: 11630 RVA: 0x00012C7F File Offset: 0x00010E7F
		public bool UseRewiredSystemPlayer
		{
			get
			{
				return this.useRewiredSystemPlayer;
			}
			set
			{
				bool flag = value != this.useRewiredSystemPlayer;
				this.useRewiredSystemPlayer = value;
				if (flag)
				{
					this.SetupRewiredVars();
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x00012C9C File Offset: 0x00010E9C
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x00012CAE File Offset: 0x00010EAE
		public int[] RewiredPlayerIds
		{
			get
			{
				return (int[])this.rewiredPlayerIds.Clone();
			}
			set
			{
				this.rewiredPlayerIds = ((value != null) ? ((int[])value.Clone()) : new int[0]);
				this.SetupRewiredVars();
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x00012CD2 File Offset: 0x00010ED2
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x00012CDA File Offset: 0x00010EDA
		public bool UsePlayingPlayersOnly
		{
			get
			{
				return this.usePlayingPlayersOnly;
			}
			set
			{
				this.usePlayingPlayersOnly = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x00012CE3 File Offset: 0x00010EE3
		// (set) Token: 0x06002D74 RID: 11636 RVA: 0x00012CF0 File Offset: 0x00010EF0
		public List<PlayerMouse> PlayerMice
		{
			get
			{
				return new List<PlayerMouse>(this.playerMice);
			}
			set
			{
				if (value == null)
				{
					this.playerMice = new List<PlayerMouse>();
					this.SetupRewiredVars();
					return;
				}
				this.playerMice = new List<PlayerMouse>(value);
				this.SetupRewiredVars();
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x00012D19 File Offset: 0x00010F19
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00012D21 File Offset: 0x00010F21
		public bool MoveOneElementPerAxisPress
		{
			get
			{
				return this.moveOneElementPerAxisPress;
			}
			set
			{
				this.moveOneElementPerAxisPress = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x00012D2A File Offset: 0x00010F2A
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x00012D32 File Offset: 0x00010F32
		public bool allowMouseInput
		{
			get
			{
				return this.m_allowMouseInput;
			}
			set
			{
				this.m_allowMouseInput = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x00012D3B File Offset: 0x00010F3B
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x00012D43 File Offset: 0x00010F43
		public bool allowMouseInputIfTouchSupported
		{
			get
			{
				return this.m_allowMouseInputIfTouchSupported;
			}
			set
			{
				this.m_allowMouseInputIfTouchSupported = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x00012D4C File Offset: 0x00010F4C
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x00012D54 File Offset: 0x00010F54
		public bool allowTouchInput
		{
			get
			{
				return this.m_allowTouchInput;
			}
			set
			{
				this.m_allowTouchInput = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x00012D5D File Offset: 0x00010F5D
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x00012D65 File Offset: 0x00010F65
		public bool SetActionsById
		{
			get
			{
				return this.setActionsById;
			}
			set
			{
				if (this.setActionsById == value)
				{
					return;
				}
				this.setActionsById = value;
				this.SetupRewiredVars();
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x00012D7E File Offset: 0x00010F7E
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x0013B018 File Offset: 0x00139218
		public int HorizontalActionId
		{
			get
			{
				return this.horizontalActionId;
			}
			set
			{
				if (value == this.horizontalActionId)
				{
					return;
				}
				this.horizontalActionId = value;
				if (ReInput.isReady)
				{
					this.m_HorizontalAxis = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x00012D86 File Offset: 0x00010F86
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x0013B068 File Offset: 0x00139268
		public int VerticalActionId
		{
			get
			{
				return this.verticalActionId;
			}
			set
			{
				if (value == this.verticalActionId)
				{
					return;
				}
				this.verticalActionId = value;
				if (ReInput.isReady)
				{
					this.m_VerticalAxis = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00012D8E File Offset: 0x00010F8E
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x0013B0B8 File Offset: 0x001392B8
		public int SubmitActionId
		{
			get
			{
				return this.submitActionId;
			}
			set
			{
				if (value == this.submitActionId)
				{
					return;
				}
				this.submitActionId = value;
				if (ReInput.isReady)
				{
					this.m_SubmitButton = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x00012D96 File Offset: 0x00010F96
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x0013B108 File Offset: 0x00139308
		public int CancelActionId
		{
			get
			{
				return this.cancelActionId;
			}
			set
			{
				if (value == this.cancelActionId)
				{
					return;
				}
				this.cancelActionId = value;
				if (ReInput.isReady)
				{
					this.m_CancelButton = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06002D87 RID: 11655 RVA: 0x00012D9E File Offset: 0x00010F9E
		protected override bool isMouseSupported
		{
			get
			{
				return base.isMouseSupported && this.m_allowMouseInput && (!this.isTouchSupported || this.m_allowMouseInputIfTouchSupported);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x00012DC4 File Offset: 0x00010FC4
		private bool isTouchAllowed
		{
			get
			{
				return this.isTouchSupported && this.m_allowTouchInput;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x00012DD6 File Offset: 0x00010FD6
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x00012DDE File Offset: 0x00010FDE
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
		public bool allowActivationOnMobileDevice
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
				this.m_ForceModuleActive = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00012DD6 File Offset: 0x00010FD6
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00012DDE File Offset: 0x00010FDE
		public bool forceModuleActive
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
				this.m_ForceModuleActive = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x00012DE7 File Offset: 0x00010FE7
		// (set) Token: 0x06002D8E RID: 11662 RVA: 0x00012DEF File Offset: 0x00010FEF
		public float inputActionsPerSecond
		{
			get
			{
				return this.m_InputActionsPerSecond;
			}
			set
			{
				this.m_InputActionsPerSecond = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x00012DF8 File Offset: 0x00010FF8
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00012E00 File Offset: 0x00011000
		public float repeatDelay
		{
			get
			{
				return this.m_RepeatDelay;
			}
			set
			{
				this.m_RepeatDelay = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x00012E09 File Offset: 0x00011009
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x00012E11 File Offset: 0x00011011
		public string horizontalAxis
		{
			get
			{
				return this.m_HorizontalAxis;
			}
			set
			{
				if (this.m_HorizontalAxis == value)
				{
					return;
				}
				this.m_HorizontalAxis = value;
				if (ReInput.isReady)
				{
					this.horizontalActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x00012E41 File Offset: 0x00011041
		// (set) Token: 0x06002D94 RID: 11668 RVA: 0x00012E49 File Offset: 0x00011049
		public string verticalAxis
		{
			get
			{
				return this.m_VerticalAxis;
			}
			set
			{
				if (this.m_VerticalAxis == value)
				{
					return;
				}
				this.m_VerticalAxis = value;
				if (ReInput.isReady)
				{
					this.verticalActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06002D95 RID: 11669 RVA: 0x00012E79 File Offset: 0x00011079
		// (set) Token: 0x06002D96 RID: 11670 RVA: 0x00012E81 File Offset: 0x00011081
		public string submitButton
		{
			get
			{
				return this.m_SubmitButton;
			}
			set
			{
				if (this.m_SubmitButton == value)
				{
					return;
				}
				this.m_SubmitButton = value;
				if (ReInput.isReady)
				{
					this.submitActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x00012EB1 File Offset: 0x000110B1
		// (set) Token: 0x06002D98 RID: 11672 RVA: 0x00012EB9 File Offset: 0x000110B9
		public string cancelButton
		{
			get
			{
				return this.m_CancelButton;
			}
			set
			{
				if (this.m_CancelButton == value)
				{
					return;
				}
				this.m_CancelButton = value;
				if (ReInput.isReady)
				{
					this.cancelActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x0013B158 File Offset: 0x00139358
		private RewiredStandaloneInputModule()
		{
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x0013B1F4 File Offset: 0x001393F4
		protected override void Awake()
		{
			base.Awake();
			this.isTouchSupported = base.defaultTouchInputSource.touchSupported;
			TouchInputModule component = base.GetComponent<TouchInputModule>();
			if (component != null)
			{
				component.enabled = false;
			}
			ReInput.InitializedEvent += this.OnRewiredInitialized;
			this.InitializeRewired();
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00012EE9 File Offset: 0x000110E9
		public override void UpdateModule()
		{
			this.CheckEditorRecompile();
			if (this.recompiling)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.m_HasFocus)
			{
				this.ShouldIgnoreEventsOnNoFocus();
				return;
			}
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x0000D05B File Offset: 0x0000B25B
		public override bool IsModuleSupported()
		{
			return true;
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x0013B248 File Offset: 0x00139448
		public override bool ShouldActivateModule()
		{
			if (!base.ShouldActivateModule())
			{
				return false;
			}
			if (this.recompiling)
			{
				return false;
			}
			if (!ReInput.isReady)
			{
				return false;
			}
			bool flag = this.m_ForceModuleActive;
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					flag = (flag | this.GetButtonDown(player, this.submitActionId) | this.GetButtonDown(player, this.cancelActionId));
					if (this.moveOneElementPerAxisPress)
					{
						flag = (flag | (this.GetButtonDown(player, this.horizontalActionId) || this.GetNegativeButtonDown(player, this.horizontalActionId)) | (this.GetButtonDown(player, this.verticalActionId) || this.GetNegativeButtonDown(player, this.verticalActionId)));
					}
					else
					{
						flag = (flag | !Mathf.Approximately(this.GetAxis(player, this.horizontalActionId), 0f) | !Mathf.Approximately(this.GetAxis(player, this.verticalActionId), 0f));
					}
				}
			}
			if (this.isMouseSupported)
			{
				flag = (flag | this.DidAnyMouseMove() | this.GetMouseButtonDownOnAnyMouse(0));
			}
			if (this.isTouchAllowed)
			{
				for (int j = 0; j < base.defaultTouchInputSource.touchCount; j++)
				{
					Touch touch = base.defaultTouchInputSource.GetTouch(j);
					flag |= (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary);
				}
			}
			return flag;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x0013B3D4 File Offset: 0x001395D4
		public override void ActivateModule()
		{
			if (!this.m_HasFocus && this.ShouldIgnoreEventsOnNoFocus())
			{
				return;
			}
			base.ActivateModule();
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00012F12 File Offset: 0x00011112
		public override void DeactivateModule()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x0013B42C File Offset: 0x0013962C
		public override void Process()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.m_HasFocus && this.ShouldIgnoreEventsOnNoFocus())
			{
				return;
			}
			bool flag = this.SendUpdateEventToSelectedObject();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.SendMoveEventToSelectedObject();
				}
				if (!flag)
				{
					this.SendSubmitEventToSelectedObject();
				}
			}
			if (!this.ProcessTouchEvents() && this.isMouseSupported)
			{
				this.ProcessMouseEvents();
			}
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x0013B494 File Offset: 0x00139694
		private bool ProcessTouchEvents()
		{
			if (!this.isTouchAllowed)
			{
				return false;
			}
			for (int i = 0; i < base.defaultTouchInputSource.touchCount; i++)
			{
				Touch touch = base.defaultTouchInputSource.GetTouch(i);
				if (touch.type != TouchType.Indirect)
				{
					bool pressed;
					bool flag;
					PlayerPointerEventData touchPointerEventData = base.GetTouchPointerEventData(0, 0, touch, out pressed, out flag);
					this.ProcessTouchPress(touchPointerEventData, pressed, flag);
					if (!flag)
					{
						this.ProcessMove(touchPointerEventData);
						this.ProcessDrag(touchPointerEventData);
					}
					else
					{
						base.RemovePointerData(touchPointerEventData);
					}
				}
			}
			return base.defaultTouchInputSource.touchCount > 0;
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x0013B51C File Offset: 0x0013971C
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			GameObject gameObject = pointerEvent.pointerCurrentRaycast.gameObject;
			if (pressed)
			{
				pointerEvent.eligibleForClick = true;
				pointerEvent.delta = Vector2.zero;
				pointerEvent.dragging = false;
				pointerEvent.useDragThreshold = true;
				pointerEvent.pressPosition = pointerEvent.position;
				pointerEvent.pointerPressRaycast = pointerEvent.pointerCurrentRaycast;
				base.DeselectIfSelectionChanged(gameObject, pointerEvent);
				if (pointerEvent.pointerEnter != gameObject)
				{
					base.HandlePointerExitAndEnter(pointerEvent, gameObject);
					pointerEvent.pointerEnter = gameObject;
				}
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, pointerEvent, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				float unscaledTime = Time.unscaledTime;
				if (gameObject2 == pointerEvent.lastPress)
				{
					if (unscaledTime - pointerEvent.clickTime < 0.3f)
					{
						int clickCount = pointerEvent.clickCount + 1;
						pointerEvent.clickCount = clickCount;
					}
					else
					{
						pointerEvent.clickCount = 1;
					}
					pointerEvent.clickTime = unscaledTime;
				}
				else
				{
					pointerEvent.clickCount = 1;
				}
				pointerEvent.pointerPress = gameObject2;
				pointerEvent.rawPointerPress = gameObject;
				pointerEvent.clickTime = unscaledTime;
				pointerEvent.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (pointerEvent.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (released)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (pointerEvent.pointerPress == eventHandler && pointerEvent.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerClickHandler);
				}
				else if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, pointerEvent, ExecuteEvents.dropHandler);
				}
				pointerEvent.eligibleForClick = false;
				pointerEvent.pointerPress = null;
				pointerEvent.rawPointerPress = null;
				if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);
				}
				pointerEvent.dragging = false;
				pointerEvent.pointerDrag = null;
				if (pointerEvent.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);
				}
				pointerEvent.pointerDrag = null;
				ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>(pointerEvent.pointerEnter, pointerEvent, ExecuteEvents.pointerExitHandler);
				pointerEvent.pointerEnter = null;
			}
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0013B740 File Offset: 0x00139940
		private bool SendSubmitEventToSelectedObject()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			if (this.recompiling)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					if (!this.GetButtonDown(player, this.submitActionId))
					{
						if (!this.GetButtonDown(player, this.cancelActionId))
						{
							goto IL_6E;
						}
						ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
					}
					else
					{
						ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
					}
					IL_AF:
					return baseEventData.used;
				}
				IL_6E:;
			}
			goto IL_AF;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0013B804 File Offset: 0x00139A04
		private Vector2 GetRawMoveVector()
		{
			if (this.recompiling)
			{
				return Vector2.zero;
			}
			Vector2 zero = Vector2.zero;
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					if (this.moveOneElementPerAxisPress)
					{
						float num = 0f;
						if (this.GetButtonDown(player, this.horizontalActionId))
						{
							num = 1f;
						}
						else if (this.GetNegativeButtonDown(player, this.horizontalActionId))
						{
							num = -1f;
						}
						float num2 = 0f;
						if (this.GetButtonDown(player, this.verticalActionId))
						{
							num2 = 1f;
						}
						else if (this.GetNegativeButtonDown(player, this.verticalActionId))
						{
							num2 = -1f;
						}
						zero.x += num;
						zero.y += num2;
					}
					else
					{
						zero.x += this.GetAxis(player, this.horizontalActionId);
						zero.y += this.GetAxis(player, this.verticalActionId);
					}
					flag |= (this.GetButtonDown(player, this.horizontalActionId) || this.GetNegativeButtonDown(player, this.horizontalActionId));
					flag2 |= (this.GetButtonDown(player, this.verticalActionId) || this.GetNegativeButtonDown(player, this.verticalActionId));
				}
			}
			if (flag)
			{
				if (zero.x < 0f)
				{
					zero.x = -1f;
				}
				if (zero.x > 0f)
				{
					zero.x = 1f;
				}
			}
			if (flag2)
			{
				if (zero.y < 0f)
				{
					zero.y = -1f;
				}
				if (zero.y > 0f)
				{
					zero.y = 1f;
				}
			}
			return zero;
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0013B9EC File Offset: 0x00139BEC
		private bool SendMoveEventToSelectedObject()
		{
			if (this.recompiling)
			{
				return false;
			}
			float unscaledTime = Time.unscaledTime;
			Vector2 rawMoveVector = this.GetRawMoveVector();
			if (Mathf.Approximately(rawMoveVector.x, 0f) && Mathf.Approximately(rawMoveVector.y, 0f))
			{
				this.m_ConsecutiveMoveCount = 0;
				return false;
			}
			bool flag = Vector2.Dot(rawMoveVector, this.m_LastMoveVector) > 0f;
			bool flag2;
			bool flag3;
			this.CheckButtonOrKeyMovement(unscaledTime, out flag2, out flag3);
			AxisEventData axisEventData = null;
			bool flag4;
			if (flag4 = (flag2 || flag3))
			{
				axisEventData = this.GetAxisEventData(rawMoveVector.x, rawMoveVector.y, 0.6f);
				MoveDirection moveDir = axisEventData.moveDir;
				flag4 = (((moveDir == MoveDirection.Up || moveDir == MoveDirection.Down) && flag3) || ((moveDir == MoveDirection.Left || moveDir == MoveDirection.Right) && flag2));
			}
			if (!flag4)
			{
				if (this.m_RepeatDelay > 0f)
				{
					if (flag && this.m_ConsecutiveMoveCount == 1)
					{
						flag4 = (unscaledTime > this.m_PrevActionTime + this.m_RepeatDelay);
					}
					else
					{
						flag4 = (unscaledTime > this.m_PrevActionTime + 1f / this.m_InputActionsPerSecond);
					}
				}
				else
				{
					flag4 = (unscaledTime > this.m_PrevActionTime + 1f / this.m_InputActionsPerSecond);
				}
			}
			if (!flag4)
			{
				return false;
			}
			if (axisEventData == null)
			{
				axisEventData = this.GetAxisEventData(rawMoveVector.x, rawMoveVector.y, 0.6f);
			}
			if (axisEventData.moveDir != MoveDirection.None)
			{
				ExecuteEvents.Execute<IMoveHandler>(base.eventSystem.currentSelectedGameObject, axisEventData, ExecuteEvents.moveHandler);
				if (!flag)
				{
					this.m_ConsecutiveMoveCount = 0;
				}
				if (this.m_ConsecutiveMoveCount == 0 || (!flag2 && !flag3))
				{
					this.m_ConsecutiveMoveCount++;
				}
				this.m_PrevActionTime = unscaledTime;
				this.m_LastMoveVector = rawMoveVector;
			}
			else
			{
				this.m_ConsecutiveMoveCount = 0;
			}
			return axisEventData.used;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x0013BB9C File Offset: 0x00139D9C
		private void CheckButtonOrKeyMovement(float time, out bool downHorizontal, out bool downVertical)
		{
			downHorizontal = false;
			downVertical = false;
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					downHorizontal |= (this.GetButtonDown(player, this.horizontalActionId) || this.GetNegativeButtonDown(player, this.horizontalActionId));
					downVertical |= (this.GetButtonDown(player, this.verticalActionId) || this.GetNegativeButtonDown(player, this.verticalActionId));
				}
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x0013BC30 File Offset: 0x00139E30
		private void ProcessMouseEvents()
		{
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = base.GetMouseInputSourceCount(this.playerIds[i]);
					for (int j = 0; j < mouseInputSourceCount; j++)
					{
						this.ProcessMouseEvent(this.playerIds[i], j);
					}
				}
			}
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x0013BCA0 File Offset: 0x00139EA0
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
			RewiredPointerInputModule.MouseState mousePointerEventData = this.GetMousePointerEventData(playerId, pointerIndex);
			if (mousePointerEventData == null)
			{
				return;
			}
			RewiredPointerInputModule.MouseButtonEventData eventData = mousePointerEventData.GetButtonState(0).eventData;
			this.ProcessMousePress(eventData);
			this.ProcessMove(eventData.buttonData);
			this.ProcessDrag(eventData.buttonData);
			this.ProcessMousePress(mousePointerEventData.GetButtonState(1).eventData);
			this.ProcessDrag(mousePointerEventData.GetButtonState(1).eventData.buttonData);
			this.ProcessMousePress(mousePointerEventData.GetButtonState(2).eventData);
			this.ProcessDrag(mousePointerEventData.GetButtonState(2).eventData.buttonData);
			IMouseInputSource mouseInputSource = base.GetMouseInputSource(playerId, pointerIndex);
			for (int i = 3; i < mouseInputSource.buttonCount; i++)
			{
				this.ProcessMousePress(mousePointerEventData.GetButtonState(i).eventData);
				this.ProcessDrag(mousePointerEventData.GetButtonState(i).eventData.buttonData);
			}
			if (!Mathf.Approximately(eventData.buttonData.scrollDelta.sqrMagnitude, 0f))
			{
				ExecuteEvents.ExecuteHierarchy<IScrollHandler>(ExecuteEvents.GetEventHandler<IScrollHandler>(eventData.buttonData.pointerCurrentRaycast.gameObject), eventData.buttonData, ExecuteEvents.scrollHandler);
			}
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x0013BDC8 File Offset: 0x00139FC8
		private bool SendUpdateEventToSelectedObject()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			ExecuteEvents.Execute<IUpdateSelectedHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
			return baseEventData.used;
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x0013BE10 File Offset: 0x0013A010
		private void ProcessMousePress(RewiredPointerInputModule.MouseButtonEventData data)
		{
			PlayerPointerEventData buttonData = data.buttonData;
			GameObject gameObject = buttonData.pointerCurrentRaycast.gameObject;
			if (data.PressedThisFrame())
			{
				buttonData.eligibleForClick = true;
				buttonData.delta = Vector2.zero;
				buttonData.dragging = false;
				buttonData.useDragThreshold = true;
				buttonData.pressPosition = buttonData.position;
				buttonData.pointerPressRaycast = buttonData.pointerCurrentRaycast;
				base.DeselectIfSelectionChanged(gameObject, buttonData);
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, buttonData, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				float unscaledTime = Time.unscaledTime;
				if (gameObject2 == buttonData.lastPress)
				{
					if (unscaledTime - buttonData.clickTime < 0.3f)
					{
						PlayerPointerEventData playerPointerEventData = buttonData;
						int clickCount = playerPointerEventData.clickCount + 1;
						playerPointerEventData.clickCount = clickCount;
					}
					else
					{
						buttonData.clickCount = 1;
					}
					buttonData.clickTime = unscaledTime;
				}
				else
				{
					buttonData.clickCount = 1;
				}
				buttonData.pointerPress = gameObject2;
				buttonData.rawPointerPress = gameObject;
				buttonData.clickTime = unscaledTime;
				buttonData.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (buttonData.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(buttonData.pointerDrag, buttonData, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (data.ReleasedThisFrame())
			{
				ExecuteEvents.Execute<IPointerUpHandler>(buttonData.pointerPress, buttonData, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (buttonData.pointerPress == eventHandler && buttonData.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(buttonData.pointerPress, buttonData, ExecuteEvents.pointerClickHandler);
				}
				else if (buttonData.pointerDrag != null && buttonData.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, buttonData, ExecuteEvents.dropHandler);
				}
				buttonData.eligibleForClick = false;
				buttonData.pointerPress = null;
				buttonData.rawPointerPress = null;
				if (buttonData.pointerDrag != null && buttonData.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(buttonData.pointerDrag, buttonData, ExecuteEvents.endDragHandler);
				}
				buttonData.dragging = false;
				buttonData.pointerDrag = null;
				if (gameObject != buttonData.pointerEnter)
				{
					base.HandlePointerExitAndEnter(buttonData, null);
					base.HandlePointerExitAndEnter(buttonData, gameObject);
				}
			}
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00012F20 File Offset: 0x00011120
		private void OnApplicationFocus(bool hasFocus)
		{
			this.m_HasFocus = hasFocus;
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00012F29 File Offset: 0x00011129
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return !ReInput.isReady || ReInput.configuration.ignoreInputWhenAppNotInFocus;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00012F3E File Offset: 0x0001113E
		protected override void OnDestroy()
		{
			base.OnDestroy();
			ReInput.InitializedEvent -= this.OnRewiredInitialized;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x0013C00C File Offset: 0x0013A20C
		protected override bool IsDefaultPlayer(int playerId)
		{
			if (this.playerIds == null)
			{
				return false;
			}
			if (!ReInput.isReady)
			{
				return false;
			}
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < this.playerIds.Length; j++)
				{
					Player player = ReInput.players.GetPlayer(this.playerIds[j]);
					if (player != null && (i >= 1 || !this.usePlayingPlayersOnly || player.isPlaying) && (i >= 2 || player.controllers.hasMouse))
					{
						return this.playerIds[j] == playerId;
					}
				}
			}
			return false;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x0013C094 File Offset: 0x0013A294
		private void InitializeRewired()
		{
			if (!ReInput.isReady)
			{
				Debug.LogError("Rewired is not initialized! Are you missing a Rewired Input Manager in your scene?");
				return;
			}
			ReInput.ShutDownEvent -= this.OnRewiredShutDown;
			ReInput.ShutDownEvent += this.OnRewiredShutDown;
			ReInput.EditorRecompileEvent -= this.OnEditorRecompile;
			ReInput.EditorRecompileEvent += this.OnEditorRecompile;
			this.SetupRewiredVars();
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0013C100 File Offset: 0x0013A300
		private void SetupRewiredVars()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			this.SetUpRewiredActions();
			if (this.useAllRewiredGamePlayers)
			{
				IList<Player> list = this.useRewiredSystemPlayer ? ReInput.players.AllPlayers : ReInput.players.Players;
				this.playerIds = new int[list.Count];
				for (int i = 0; i < list.Count; i++)
				{
					this.playerIds[i] = list[i].id;
				}
			}
			else
			{
				bool flag = false;
				List<int> list2 = new List<int>(this.rewiredPlayerIds.Length + 1);
				for (int j = 0; j < this.rewiredPlayerIds.Length; j++)
				{
					Player player = ReInput.players.GetPlayer(this.rewiredPlayerIds[j]);
					if (player != null && !list2.Contains(player.id))
					{
						list2.Add(player.id);
						if (player.id == 9999999)
						{
							flag = true;
						}
					}
				}
				if (this.useRewiredSystemPlayer && !flag)
				{
					list2.Insert(0, ReInput.players.GetSystemPlayer().id);
				}
				this.playerIds = list2.ToArray();
			}
			this.SetUpRewiredPlayerMice();
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x0013C220 File Offset: 0x0013A420
		private void SetUpRewiredPlayerMice()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			base.ClearMouseInputSources();
			for (int i = 0; i < this.playerMice.Count; i++)
			{
				PlayerMouse playerMouse = this.playerMice[i];
				if (!UnityTools.IsNullOrDestroyed<PlayerMouse>(playerMouse))
				{
					base.AddMouseInputSource(playerMouse);
				}
			}
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x0013C270 File Offset: 0x0013A470
		private void SetUpRewiredActions()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.setActionsById)
			{
				this.horizontalActionId = ReInput.mapping.GetActionId(this.m_HorizontalAxis);
				this.verticalActionId = ReInput.mapping.GetActionId(this.m_VerticalAxis);
				this.submitActionId = ReInput.mapping.GetActionId(this.m_SubmitButton);
				this.cancelActionId = ReInput.mapping.GetActionId(this.m_CancelButton);
				return;
			}
			InputAction action = ReInput.mapping.GetAction(this.horizontalActionId);
			this.m_HorizontalAxis = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.horizontalActionId = -1;
			}
			action = ReInput.mapping.GetAction(this.verticalActionId);
			this.m_VerticalAxis = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.verticalActionId = -1;
			}
			action = ReInput.mapping.GetAction(this.submitActionId);
			this.m_SubmitButton = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.submitActionId = -1;
			}
			action = ReInput.mapping.GetAction(this.cancelActionId);
			this.m_CancelButton = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.cancelActionId = -1;
			}
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00012F57 File Offset: 0x00011157
		private bool GetButtonDown(Player player, int actionId)
		{
			return actionId >= 0 && player.GetButtonDown(actionId);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00012F66 File Offset: 0x00011166
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return actionId >= 0 && player.GetNegativeButtonDown(actionId);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00012F75 File Offset: 0x00011175
		private float GetAxis(Player player, int actionId)
		{
			if (actionId < 0)
			{
				return 0f;
			}
			return player.GetAxis(actionId);
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00012F88 File Offset: 0x00011188
		private void CheckEditorRecompile()
		{
			if (!this.recompiling)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			this.recompiling = false;
			this.InitializeRewired();
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00012FA8 File Offset: 0x000111A8
		private void OnEditorRecompile()
		{
			this.recompiling = true;
			this.ClearRewiredVars();
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00012FB7 File Offset: 0x000111B7
		private void ClearRewiredVars()
		{
			Array.Clear(this.playerIds, 0, this.playerIds.Length);
			base.ClearMouseInputSources();
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x0013C3AC File Offset: 0x0013A5AC
		private bool DidAnyMouseMove()
		{
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				int playerId = this.playerIds[i];
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = base.GetMouseInputSourceCount(playerId);
					for (int j = 0; j < mouseInputSourceCount; j++)
					{
						IMouseInputSource mouseInputSource = base.GetMouseInputSource(playerId, j);
						if (mouseInputSource != null && mouseInputSource.screenPositionDelta.sqrMagnitude > 0f)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x0013C438 File Offset: 0x0013A638
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				int playerId = this.playerIds[i];
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = base.GetMouseInputSourceCount(playerId);
					for (int j = 0; j < mouseInputSourceCount; j++)
					{
						IMouseInputSource mouseInputSource = base.GetMouseInputSource(playerId, j);
						if (mouseInputSource != null && mouseInputSource.GetButtonDown(buttonIndex))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00012FD3 File Offset: 0x000111D3
		private void OnRewiredInitialized()
		{
			this.InitializeRewired();
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00012FDB File Offset: 0x000111DB
		private void OnRewiredShutDown()
		{
			this.ClearRewiredVars();
		}

		// Token: 0x0400088F RID: 2191
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		// Token: 0x04000890 RID: 2192
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		// Token: 0x04000891 RID: 2193
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		// Token: 0x04000892 RID: 2194
		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		// Token: 0x04000893 RID: 2195
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
		[SerializeField]
		private InputManager_Base rewiredInputManager;

		// Token: 0x04000894 RID: 2196
		[SerializeField]
		[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
		private bool useAllRewiredGamePlayers;

		// Token: 0x04000895 RID: 2197
		[Tooltip("Allow the Rewired System Player to control the UI.")]
		[SerializeField]
		private bool useRewiredSystemPlayer;

		// Token: 0x04000896 RID: 2198
		[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
		[SerializeField]
		private int[] rewiredPlayerIds = new int[1];

		// Token: 0x04000897 RID: 2199
		[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
		[SerializeField]
		private bool usePlayingPlayersOnly;

		// Token: 0x04000898 RID: 2200
		[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
		[SerializeField]
		private List<PlayerMouse> playerMice = new List<PlayerMouse>();

		// Token: 0x04000899 RID: 2201
		[SerializeField]
		[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
		private bool moveOneElementPerAxisPress;

		// Token: 0x0400089A RID: 2202
		[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
		[SerializeField]
		private bool setActionsById;

		// Token: 0x0400089B RID: 2203
		[SerializeField]
		[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
		private int horizontalActionId = -1;

		// Token: 0x0400089C RID: 2204
		[SerializeField]
		[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
		private int verticalActionId = -1;

		// Token: 0x0400089D RID: 2205
		[Tooltip("Id of the Action used to submit.")]
		[SerializeField]
		private int submitActionId = -1;

		// Token: 0x0400089E RID: 2206
		[Tooltip("Id of the Action used to cancel.")]
		[SerializeField]
		private int cancelActionId = -1;

		// Token: 0x0400089F RID: 2207
		[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
		[SerializeField]
		private string m_HorizontalAxis = "UIHorizontal";

		// Token: 0x040008A0 RID: 2208
		[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
		[SerializeField]
		private string m_VerticalAxis = "UIVertical";

		// Token: 0x040008A1 RID: 2209
		[SerializeField]
		[Tooltip("Name of the action used to submit.")]
		private string m_SubmitButton = "UISubmit";

		// Token: 0x040008A2 RID: 2210
		[SerializeField]
		[Tooltip("Name of the action used to cancel.")]
		private string m_CancelButton = "UICancel";

		// Token: 0x040008A3 RID: 2211
		[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
		[SerializeField]
		private float m_InputActionsPerSecond = 10f;

		// Token: 0x040008A4 RID: 2212
		[SerializeField]
		[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
		private float m_RepeatDelay;

		// Token: 0x040008A5 RID: 2213
		[Tooltip("Allows the mouse to be used to select elements.")]
		[SerializeField]
		private bool m_allowMouseInput = true;

		// Token: 0x040008A6 RID: 2214
		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
		private bool m_allowMouseInputIfTouchSupported = true;

		// Token: 0x040008A7 RID: 2215
		[SerializeField]
		[Tooltip("Allows touch input to be used to select elements.")]
		private bool m_allowTouchInput = true;

		// Token: 0x040008A8 RID: 2216
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[SerializeField]
		[Tooltip("Forces the module to always be active.")]
		private bool m_ForceModuleActive;

		// Token: 0x040008A9 RID: 2217
		[NonSerialized]
		private int[] playerIds;

		// Token: 0x040008AA RID: 2218
		private bool recompiling;

		// Token: 0x040008AB RID: 2219
		[NonSerialized]
		private bool isTouchSupported;

		// Token: 0x040008AC RID: 2220
		[NonSerialized]
		private float m_PrevActionTime;

		// Token: 0x040008AD RID: 2221
		[NonSerialized]
		private Vector2 m_LastMoveVector;

		// Token: 0x040008AE RID: 2222
		[NonSerialized]
		private int m_ConsecutiveMoveCount;

		// Token: 0x040008AF RID: 2223
		[NonSerialized]
		private bool m_HasFocus = true;

		// Token: 0x02000100 RID: 256
		[Serializable]
		public class PlayerSetting
		{
			// Token: 0x06002DBD RID: 11709 RVA: 0x00012FE3 File Offset: 0x000111E3
			public PlayerSetting()
			{
			}

			// Token: 0x06002DBE RID: 11710 RVA: 0x0013C4B4 File Offset: 0x0013A6B4
			private PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
			{
				if (other == null)
				{
					throw new ArgumentNullException("other");
				}
				this.playerId = other.playerId;
				this.playerMice = new List<PlayerMouse>();
				if (other.playerMice != null)
				{
					foreach (PlayerMouse item in other.playerMice)
					{
						this.playerMice.Add(item);
					}
				}
			}

			// Token: 0x06002DBF RID: 11711 RVA: 0x00012FF6 File Offset: 0x000111F6
			public RewiredStandaloneInputModule.PlayerSetting Clone()
			{
				return new RewiredStandaloneInputModule.PlayerSetting(this);
			}

			// Token: 0x040008B0 RID: 2224
			public int playerId;

			// Token: 0x040008B1 RID: 2225
			public List<PlayerMouse> playerMice = new List<PlayerMouse>();
		}
	}
}
