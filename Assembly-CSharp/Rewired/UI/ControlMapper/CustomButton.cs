using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200012C RID: 300
	[AddComponentMenu("")]
	public class CustomButton : Button, ICancelHandler, ICustomSelectable, IEventSystemHandler
	{
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x00015372 File Offset: 0x00013572
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x0001537A File Offset: 0x0001357A
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

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x00015383 File Offset: 0x00013583
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x0001538B File Offset: 0x0001358B
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x00015394 File Offset: 0x00013594
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x0001539C File Offset: 0x0001359C
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x000153A5 File Offset: 0x000135A5
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x000153AD File Offset: 0x000135AD
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x000153B6 File Offset: 0x000135B6
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x000153BE File Offset: 0x000135BE
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x000153C7 File Offset: 0x000135C7
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x000153CF File Offset: 0x000135CF
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

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x000153D8 File Offset: 0x000135D8
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x000153E0 File Offset: 0x000135E0
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

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x000153E9 File Offset: 0x000135E9
		private bool isDisabled
		{
			get
			{
				return !this.IsInteractable();
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06003065 RID: 12389 RVA: 0x001442D4 File Offset: 0x001424D4
		// (remove) Token: 0x06003066 RID: 12390 RVA: 0x0014430C File Offset: 0x0014250C
		private event UnityAction _CancelEvent;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06003067 RID: 12391 RVA: 0x000153F4 File Offset: 0x000135F4
		// (remove) Token: 0x06003068 RID: 12392 RVA: 0x000153FD File Offset: 0x000135FD
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

		// Token: 0x06003069 RID: 12393 RVA: 0x00144344 File Offset: 0x00142544
		public override Selectable FindSelectableOnLeft()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) == Navigation.Mode.None && !this._autoNavLeft)
			{
				return base.FindSelectableOnLeft();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.left);
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00144388 File Offset: 0x00142588
		public override Selectable FindSelectableOnRight()
		{
			if ((base.navigation.mode & Navigation.Mode.Horizontal) == Navigation.Mode.None && !this._autoNavRight)
			{
				return base.FindSelectableOnRight();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.right);
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x001443CC File Offset: 0x001425CC
		public override Selectable FindSelectableOnUp()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) == Navigation.Mode.None && !this._autoNavUp)
			{
				return base.FindSelectableOnUp();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.up);
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00144410 File Offset: 0x00142610
		public override Selectable FindSelectableOnDown()
		{
			if ((base.navigation.mode & Navigation.Mode.Vertical) == Navigation.Mode.None && !this._autoNavDown)
			{
				return base.FindSelectableOnDown();
			}
			return UISelectionUtility.FindNextSelectable(this, base.transform, Selectable.allSelectables, Vector3.down);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00015406 File Offset: 0x00013606
		protected override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (EventSystem.current == null)
			{
				return;
			}
			this.EvaluateHightlightDisabled(EventSystem.current.currentSelectedGameObject == base.gameObject);
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00144454 File Offset: 0x00142654
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

		// Token: 0x0600306F RID: 12399 RVA: 0x001444DC File Offset: 0x001426DC
		private void StartColorTween(Color targetColor, bool instant)
		{
			if (base.targetGraphic == null)
			{
				return;
			}
			base.targetGraphic.CrossFadeColor(targetColor, instant ? 0f : base.colors.fadeDuration, true, true);
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x00015437 File Offset: 0x00013637
		private void DoSpriteSwap(Sprite newSprite)
		{
			if (base.image == null)
			{
				return;
			}
			base.image.overrideSprite = newSprite;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00144520 File Offset: 0x00142720
		private void TriggerAnimation(string triggername)
		{
			if (!(base.animator == null) && base.animator.enabled && base.animator.isActiveAndEnabled && !(base.animator.runtimeAnimatorController == null) && !string.IsNullOrEmpty(triggername))
			{
				base.animator.ResetTrigger(this._disabledHighlightedTrigger);
				base.animator.SetTrigger(triggername);
				return;
			}
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00015454 File Offset: 0x00013654
		public override void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			this.EvaluateHightlightDisabled(true);
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00015464 File Offset: 0x00013664
		public override void OnDeselect(BaseEventData eventData)
		{
			base.OnDeselect(eventData);
			this.EvaluateHightlightDisabled(false);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00015474 File Offset: 0x00013674
		private void Press()
		{
			if (this.IsActive() && this.IsInteractable())
			{
				base.onClick.Invoke();
				return;
			}
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00144590 File Offset: 0x00142790
		public override void OnPointerClick(PointerEventData eventData)
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.Press();
			if (!this.IsActive() || !this.IsInteractable())
			{
				this.isHighlightDisabled = true;
				this.DoStateTransition(Selectable.SelectionState.Disabled, false);
			}
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00015492 File Offset: 0x00013692
		public override void OnSubmit(BaseEventData eventData)
		{
			this.Press();
			if (this.IsActive() && this.IsInteractable())
			{
				this.DoStateTransition(Selectable.SelectionState.Pressed, false);
				base.StartCoroutine(this.OnFinishSubmit());
				return;
			}
			this.isHighlightDisabled = true;
			this.DoStateTransition(Selectable.SelectionState.Disabled, false);
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x000154CF File Offset: 0x000136CF
		private IEnumerator OnFinishSubmit()
		{
			CustomButton.<OnFinishSubmit>d__51 <OnFinishSubmit>d__ = new CustomButton.<OnFinishSubmit>d__51(0);
			<OnFinishSubmit>d__.<>4__this = this;
			return <OnFinishSubmit>d__;
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x001445DC File Offset: 0x001427DC
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

		// Token: 0x06003079 RID: 12409 RVA: 0x000154DE File Offset: 0x000136DE
		public void OnCancel(BaseEventData eventData)
		{
			if (this._CancelEvent != null)
			{
				this._CancelEvent();
			}
		}

		// Token: 0x040009FF RID: 2559
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04000A00 RID: 2560
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04000A01 RID: 2561
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04000A02 RID: 2562
		[SerializeField]
		private bool _autoNavUp = true;

		// Token: 0x04000A03 RID: 2563
		[SerializeField]
		private bool _autoNavDown = true;

		// Token: 0x04000A04 RID: 2564
		[SerializeField]
		private bool _autoNavLeft = true;

		// Token: 0x04000A05 RID: 2565
		[SerializeField]
		private bool _autoNavRight = true;

		// Token: 0x04000A06 RID: 2566
		private bool isHighlightDisabled;
	}
}
