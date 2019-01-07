using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000152 RID: 338
	[AddComponentMenu("")]
	public class UISliderControl : UIControl
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000160A7 File Offset: 0x000142A7
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x000160AF File Offset: 0x000142AF
		public bool showIcon
		{
			get
			{
				return this._showIcon;
			}
			set
			{
				if (this.iconImage == null)
				{
					return;
				}
				this.iconImage.gameObject.SetActive(value);
				this._showIcon = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x000160D8 File Offset: 0x000142D8
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x000160E0 File Offset: 0x000142E0
		public bool showSlider
		{
			get
			{
				return this._showSlider;
			}
			set
			{
				if (this.slider == null)
				{
					return;
				}
				this.slider.gameObject.SetActive(value);
				this._showSlider = value;
			}
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x001462D0 File Offset: 0x001444D0
		public override void SetCancelCallback(Action cancelCallback)
		{
			base.SetCancelCallback(cancelCallback);
			if (cancelCallback == null || this.slider == null)
			{
				return;
			}
			if (this.slider is ICustomSelectable)
			{
				(this.slider as ICustomSelectable).CancelEvent += delegate()
				{
					cancelCallback();
				};
				return;
			}
			EventTrigger eventTrigger = this.slider.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = this.slider.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.callback = new EventTrigger.TriggerEvent();
			entry.eventID = EventTriggerType.Cancel;
			entry.callback.AddListener(delegate(BaseEventData data)
			{
				cancelCallback();
			});
			if (eventTrigger.triggers == null)
			{
				eventTrigger.triggers = new List<EventTrigger.Entry>();
			}
			eventTrigger.triggers.Add(entry);
		}

		// Token: 0x04000AD9 RID: 2777
		public Image iconImage;

		// Token: 0x04000ADA RID: 2778
		public Slider slider;

		// Token: 0x04000ADB RID: 2779
		private bool _showIcon;

		// Token: 0x04000ADC RID: 2780
		private bool _showSlider;
	}
}
