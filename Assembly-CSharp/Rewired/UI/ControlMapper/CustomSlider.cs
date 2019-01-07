using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200012E RID: 302
	[AddComponentMenu("")]
	public class CustomSlider : Slider, ICancelHandler, ICustomSelectable, IEventSystemHandler
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x0001552E File Offset: 0x0001372E
		// (set) Token: 0x06003082 RID: 12418 RVA: 0x00015536 File Offset: 0x00013736
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x0001553F File Offset: 0x0001373F
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x00015547 File Offset: 0x00013747
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x00015550 File Offset: 0x00013750
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x00015558 File Offset: 0x00013758
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

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x00015561 File Offset: 0x00013761
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x00015569 File Offset: 0x00013769
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x00015572 File Offset: 0x00013772
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x0001557A File Offset: 0x0001377A
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

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x00015583 File Offset: 0x00013783
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x0001558B File Offset: 0x0001378B
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

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x00015594 File Offset: 0x00013794
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x0001559C File Offset: 0x0001379C
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

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x000153E9 File Offset: 0x000135E9
		private bool isDisabled
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06003090 RID: 12432 RVA: 0x001446C4 File Offset: 0x001428C4
		// (remove) Token: 0x06003091 RID: 12433 RVA: 0x001446FC File Offset: 0x001428FC
		private event UnityAction _CancelEvent;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06003092 RID: 12434 RVA: 0x000155A5 File Offset: 0x000137A5
		// (remove) Token: 0x06003093 RID: 12435 RVA: 0x000155AE File Offset: 0x000137AE
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

		// Token: 0x06003094 RID: 12436 RVA: 0x00144734 File Offset: 0x00142934
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) == Navigation.Mode.None && !this._autoNavLeft)
			{
				return base.FindSelectableOnLeft();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.left);
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00144778 File Offset: 0x00142978
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) == Navigation.Mode.None && !this._autoNavRight)
			{
				return base.FindSelectableOnRight();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.right);
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x001447BC File Offset: 0x001429BC
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) == Navigation.Mode.None && !this._autoNavUp)
			{
				return base.FindSelectableOnUp();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.up);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00144800 File Offset: 0x00142A00
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) == Navigation.Mode.None && !this._autoNavDown)
			{
				return base.FindSelectableOnDown();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.down);
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x000155B7 File Offset: 0x000137B7
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.EvaluateHightlightDisabled(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x00144844 File Offset: 0x00142A44
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

		// Token: 0x0600309A RID: 12442 RVA: 0x001444DC File Offset: 0x001426DC
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(targetColor, instant ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x00015437 File Offset: 0x00013637
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = newSprite;
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x001448CC File Offset: 0x00142ACC
		private void TriggerAnimation(string triggername)
		{
			if (!(base.animator == null) && base.animator.enabled && base.animator.isActiveAndEnabled && !(base.animator.runtimeAnimatorController == null) && !string.IsNullOrEmpty(triggername))
			{
				base.animator.ResetTrigger(this._disabledHighlightedTrigger);
				base.animator.SetTrigger(triggername);
				return;
			}
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x000155E8 File Offset: 0x000137E8
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.EvaluateHightlightDisabled(true);
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x000155F8 File Offset: 0x000137F8
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.EvaluateHightlightDisabled(false);
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x0014493C File Offset: 0x00142B3C
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

		// Token: 0x060030A0 RID: 12448 RVA: 0x00015608 File Offset: 0x00013808
		public void OnCancel(BaseEventData eventData)
		{
			if (this._CancelEvent != null)
			{
				this._CancelEvent();
			}
		}

		// Token: 0x04000A0D RID: 2573
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04000A0E RID: 2574
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04000A0F RID: 2575
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04000A10 RID: 2576
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x04000A11 RID: 2577
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04000A12 RID: 2578
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x04000A13 RID: 2579
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x04000A14 RID: 2580
		private bool isHighlightDisabled;
	}
}
