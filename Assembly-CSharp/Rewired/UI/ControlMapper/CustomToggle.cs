using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200012F RID: 303
	[AddComponentMenu("")]
	public class CustomToggle : Toggle, ICancelHandler, ICustomSelectable, IEventSystemHandler
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x00015641 File Offset: 0x00013841
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x00015649 File Offset: 0x00013849
		public Sprite disabledHighlightedSprite
		{
			get
			{
				return this._disabledHighlightedSprite;
			}
			set
			{
				this._disabledHighlightedSprite = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x00015652 File Offset: 0x00013852
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x0001565A File Offset: 0x0001385A
		public Color disabledHighlightedColor
		{
			get
			{
				return this._disabledHighlightedColor;
			}
			set
			{
				this._disabledHighlightedColor = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x00015663 File Offset: 0x00013863
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x0001566B File Offset: 0x0001386B
		public string disabledHighlightedTrigger
		{
			get
			{
				return this._disabledHighlightedTrigger;
			}
			set
			{
				this._disabledHighlightedTrigger = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x00015674 File Offset: 0x00013874
		// (set) Token: 0x060030A9 RID: 12457 RVA: 0x0001567C File Offset: 0x0001387C
		public bool autoNavUp
		{
			get
			{
				return this._autoNavUp;
			}
			set
			{
				this._autoNavUp = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x00015685 File Offset: 0x00013885
		// (set) Token: 0x060030AB RID: 12459 RVA: 0x0001568D File Offset: 0x0001388D
		public bool autoNavDown
		{
			get
			{
				return this._autoNavDown;
			}
			set
			{
				this._autoNavDown = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x00015696 File Offset: 0x00013896
		// (set) Token: 0x060030AD RID: 12461 RVA: 0x0001569E File Offset: 0x0001389E
		public bool autoNavLeft
		{
			get
			{
				return this._autoNavLeft;
			}
			set
			{
				this._autoNavLeft = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x000156A7 File Offset: 0x000138A7
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x000156AF File Offset: 0x000138AF
		public bool autoNavRight
		{
			get
			{
				return this._autoNavRight;
			}
			set
			{
				this._autoNavRight = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060030B0 RID: 12464 RVA: 0x000153E9 File Offset: 0x000135E9
		private bool isDisabled
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060030B1 RID: 12465 RVA: 0x00144990 File Offset: 0x00142B90
		// (remove) Token: 0x060030B2 RID: 12466 RVA: 0x001449C8 File Offset: 0x00142BC8
		private event UnityAction _CancelEvent;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060030B3 RID: 12467 RVA: 0x000156B8 File Offset: 0x000138B8
		// (remove) Token: 0x060030B4 RID: 12468 RVA: 0x000156C1 File Offset: 0x000138C1
		public event UnityAction CancelEvent
		{
			add
			{
				this._CancelEvent += value;
			}
			remove
			{
				this._CancelEvent -= value;
			}
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00144A00 File Offset: 0x00142C00
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) == Navigation.Mode.None && !this._autoNavLeft)
			{
				return base.FindSelectableOnLeft();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.left);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00144A44 File Offset: 0x00142C44
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) == Navigation.Mode.None && !this._autoNavRight)
			{
				return base.FindSelectableOnRight();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.right);
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00144A88 File Offset: 0x00142C88
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) == Navigation.Mode.None && !this._autoNavUp)
			{
				return base.FindSelectableOnUp();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.up);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00144ACC File Offset: 0x00142CCC
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) == Navigation.Mode.None && !this._autoNavDown)
			{
				return base.FindSelectableOnDown();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.down);
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x000156CA File Offset: 0x000138CA
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.EvaluateHightlightDisabled(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00144B10 File Offset: 0x00142D10
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.isHighlightDisabled)
			{
				Color disabledHighlightedColor = this._disabledHighlightedColor;
				Sprite disabledHighlightedSprite = this._disabledHighlightedSprite;
				string disabledHighlightedTrigger = this._disabledHighlightedTrigger;
				if (base.gameObject.activeInHierarchy)
				{
					switch (base.transition)
					{
					case Selectable.Transition.ColorTint:
						this.StartColorTween(disabledHighlightedColor * base.colors.colorMultiplier, instant);
						return;
					case Selectable.Transition.SpriteSwap:
						this.DoSpriteSwap(disabledHighlightedSprite);
						return;
					case Selectable.Transition.Animation:
						this.TriggerAnimation(disabledHighlightedTrigger);
						return;
					default:
						return;
					}
				}
			}
			else
			{
				base.DoStateTransition(state, instant);
			}
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x001444DC File Offset: 0x001426DC
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(targetColor, instant ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00015437 File Offset: 0x00013637
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = newSprite;
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00144B98 File Offset: 0x00142D98
		private void TriggerAnimation(string triggername)
		{
			if (!(base.animator == null) && base.animator.enabled && base.animator.isActiveAndEnabled && !(base.animator.runtimeAnimatorController == null) && !string.IsNullOrEmpty(triggername))
			{
				base.animator.ResetTrigger(this._disabledHighlightedTrigger);
				base.animator.SetTrigger(triggername);
				return;
			}
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x000156FB File Offset: 0x000138FB
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.EvaluateHightlightDisabled(true);
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0001570B File Offset: 0x0001390B
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.EvaluateHightlightDisabled(false);
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00144C08 File Offset: 0x00142E08
		private void EvaluateHightlightDisabled(bool isSelected)
		{
			if (!isSelected)
			{
				if (this.isHighlightDisabled)
				{
					this.isHighlightDisabled = false;
					Selectable.SelectionState state = this.isDisabled ? Selectable.SelectionState.Disabled : base.currentSelectionState;
					this.DoStateTransition(state, false);
					return;
				}
			}
			else
			{
				if (!this.isDisabled)
				{
					return;
				}
				this.isHighlightDisabled = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0001571B File Offset: 0x0001391B
		public void OnCancel(BaseEventData eventData)
		{
			if (this._CancelEvent != null)
			{
				this._CancelEvent();
			}
		}

		// Token: 0x04000A16 RID: 2582
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04000A17 RID: 2583
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04000A18 RID: 2584
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04000A19 RID: 2585
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x04000A1A RID: 2586
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04000A1B RID: 2587
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x04000A1C RID: 2588
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x04000A1D RID: 2589
		private bool isHighlightDisabled;
	}
}
