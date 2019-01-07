using System;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200013B RID: 315
	[RequireComponent(typeof(Selectable))]
	[AddComponentMenu("")]
	public class ScrollRectSelectableChild : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x00015B95 File Offset: 0x00013D95
		private RectTransform parentScrollRectContentTransform
		{
			get
			{
				return this.parentScrollRect.content;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x00145608 File Offset: 0x00143808
		private Selectable selectable
		{
			get
			{
				Selectable result;
				if ((result = this._selectable) == null)
				{
					result = (this._selectable = base.GetComponent<Selectable>());
				}
				return result;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x00015BA2 File Offset: 0x00013DA2
		private RectTransform rectTransform
		{
			get
			{
				return base.transform as RectTransform;
			}
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x00015BAF File Offset: 0x00013DAF
		private void Start()
		{
			this.parentScrollRect = base.transform.GetComponentInParent<ScrollRect>();
			if (this.parentScrollRect == null)
			{
				Debug.LogError("Rewired Control Mapper: No ScrollRect found! This component must be a child of a ScrollRect!");
				return;
			}
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x00145630 File Offset: 0x00143830
		public void OnSelect(BaseEventData eventData)
		{
			if (this.parentScrollRect == null)
			{
				return;
			}
			if (!(eventData is AxisEventData))
			{
				return;
			}
			RectTransform rectTransform = this.parentScrollRect.transform as RectTransform;
			Rect child = MathTools.TransformRect(this.rectTransform.rect, this.rectTransform, rectTransform);
			Rect rect = rectTransform.rect;
			Rect rect2 = rectTransform.rect;
			float height;
			if (this.useCustomEdgePadding)
			{
				height = this.customEdgePadding;
			}
			else
			{
				height = child.height;
			}
			rect2.yMax -= height;
			rect2.yMin += height;
			if (MathTools.RectContains(rect2, child))
			{
				return;
			}
			Vector2 vector;
			if (!MathTools.GetOffsetToContainRect(rect2, child, out vector))
			{
				return;
			}
			Vector2 anchoredPosition = this.parentScrollRectContentTransform.anchoredPosition;
			anchoredPosition.x = Mathf.Clamp(anchoredPosition.x + vector.x, 0f, Mathf.Abs(rect.width - this.parentScrollRectContentTransform.sizeDelta.x));
			anchoredPosition.y = Mathf.Clamp(anchoredPosition.y + vector.y, 0f, Mathf.Abs(rect.height - this.parentScrollRectContentTransform.sizeDelta.y));
			this.parentScrollRectContentTransform.anchoredPosition = anchoredPosition;
		}

		// Token: 0x04000A81 RID: 2689
		public bool useCustomEdgePadding;

		// Token: 0x04000A82 RID: 2690
		public float customEdgePadding = 50f;

		// Token: 0x04000A83 RID: 2691
		private ScrollRect parentScrollRect;

		// Token: 0x04000A84 RID: 2692
		private Selectable _selectable;
	}
}
