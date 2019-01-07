using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000155 RID: 341
	[AddComponentMenu("")]
	[RequireComponent(typeof(CanvasGroup))]
	public class Window : MonoBehaviour
	{
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x00016142 File Offset: 0x00014342
		public bool hasFocus
		{
			get
			{
				return this._isFocusedCallback != null && this._isFocusedCallback(this._id);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x0001615F File Offset: 0x0001435F
		public int id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x00016167 File Offset: 0x00014367
		public RectTransform rectTransform
		{
			get
			{
				if (this._rectTransform == null)
				{
					this._rectTransform = base.gameObject.GetComponent<RectTransform>();
				}
				return this._rectTransform;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x0001618E File Offset: 0x0001438E
		public Text titleText
		{
			get
			{
				return this._titleText;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x00016196 File Offset: 0x00014396
		public List<Text> contentText
		{
			get
			{
				return this._contentText;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x0001619E File Offset: 0x0001439E
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x000161A6 File Offset: 0x000143A6
		public GameObject defaultUIElement
		{
			get
			{
				return this._defaultUIElement;
			}
			set
			{
				this._defaultUIElement = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x000161AF File Offset: 0x000143AF
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x000161B7 File Offset: 0x000143B7
		public Action<int> updateCallback
		{
			get
			{
				return this._updateCallback;
			}
			set
			{
				this._updateCallback = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x000161C0 File Offset: 0x000143C0
		public Window.Timer timer
		{
			get
			{
				return this._timer;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x000161C8 File Offset: 0x000143C8
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x001467C0 File Offset: 0x001449C0
		public int width
		{
			get
			{
				return (int)this.rectTransform.sizeDelta.x;
			}
			set
			{
				Vector2 sizeDelta = this.rectTransform.sizeDelta;
				sizeDelta.x = (float)value;
				this.rectTransform.sizeDelta = sizeDelta;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x000161DB File Offset: 0x000143DB
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x001467F0 File Offset: 0x001449F0
		public int height
		{
			get
			{
				return (int)this.rectTransform.sizeDelta.y;
			}
			set
			{
				Vector2 sizeDelta = this.rectTransform.sizeDelta;
				sizeDelta.y = (float)value;
				this.rectTransform.sizeDelta = sizeDelta;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x000161EE File Offset: 0x000143EE
		protected bool initialized
		{
			get
			{
				return this._initialized;
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000161F6 File Offset: 0x000143F6
		private void OnEnable()
		{
			base.StartCoroutine("OnEnableAsync");
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00016204 File Offset: 0x00014404
		protected virtual void Update()
		{
			if (!this._initialized)
			{
				return;
			}
			if (!this.hasFocus)
			{
				return;
			}
			this.CheckUISelection();
			if (this._updateCallback != null)
			{
				this._updateCallback(this._id);
			}
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00146820 File Offset: 0x00144A20
		public virtual void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
			if (this._initialized)
			{
				Debug.LogError("Window is already initialized!");
				return;
			}
			this._id = id;
			this._isFocusedCallback = isFocusedCallback;
			this._timer = new Window.Timer();
			this._contentText = new List<Text>();
			this._canvasGroup = base.GetComponent<CanvasGroup>();
			this._initialized = true;
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x00016237 File Offset: 0x00014437
		public void SetSize(int width, int height)
		{
			this.rectTransform.sizeDelta = new Vector2((float)width, (float)height);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0001624D File Offset: 0x0001444D
		public void CreateTitleText(GameObject prefab, Vector2 offset)
		{
			this.CreateText(prefab, ref this._titleText, "Title Text", UIPivot.TopCenter, UIAnchor.TopHStretch, offset);
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0001626C File Offset: 0x0001446C
		public void CreateTitleText(GameObject prefab, Vector2 offset, string text)
		{
			this.CreateTitleText(prefab, offset);
			this.SetTitleText(text);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00146878 File Offset: 0x00144A78
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			Text item = null;
			this.CreateText(prefab, ref item, "Content Text", pivot, anchor, offset);
			this._contentText.Add(item);
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0001627D File Offset: 0x0001447D
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
			this.AddContentText(prefab, pivot, anchor, offset);
			this.SetContentText(text, this._contentText.Count - 1);
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x0001629F File Offset: 0x0001449F
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			this.CreateImage(prefab, "Image", pivot, anchor, offset);
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000162B1 File Offset: 0x000144B1
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
			this.AddContentImage(prefab, pivot, anchor, offset);
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x001468A8 File Offset: 0x00144AA8
		public void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault)
		{
			if (prefab == null)
			{
				return;
			}
			ButtonInfo buttonInfo;
			GameObject gameObject = this.CreateButton(prefab, "Button", anchor, pivot, offset, out buttonInfo);
			if (gameObject == null)
			{
				return;
			}
			Button component = gameObject.GetComponent<Button>();
			if (confirmCallback != null)
			{
				component.onClick.AddListener(confirmCallback);
			}
			CustomButton customButton = component as CustomButton;
			if (cancelCallback != null && customButton != null)
			{
				customButton.CancelEvent += cancelCallback;
			}
			if (buttonInfo.text != null)
			{
				buttonInfo.text.text = buttonText;
			}
			if (setDefault)
			{
				this._defaultUIElement = gameObject;
			}
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000162BE File Offset: 0x000144BE
		public string GetTitleText(string text)
		{
			if (this._titleText == null)
			{
				return string.Empty;
			}
			return this._titleText.text;
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x000162DF File Offset: 0x000144DF
		public void SetTitleText(string text)
		{
			if (this._titleText == null)
			{
				return;
			}
			this._titleText.text = text;
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x00146938 File Offset: 0x00144B38
		public string GetContentText(int index)
		{
			if (this._contentText != null && this._contentText.Count > index && !(this._contentText[index] == null))
			{
				return this._contentText[index].text;
			}
			return string.Empty;
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00146988 File Offset: 0x00144B88
		public float GetContentTextHeight(int index)
		{
			if (this._contentText != null && this._contentText.Count > index && !(this._contentText[index] == null))
			{
				return this._contentText[index].rectTransform.sizeDelta.y;
			}
			return 0f;
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000162FC File Offset: 0x000144FC
		public void SetContentText(string text, int index)
		{
			if (this._contentText != null && this._contentText.Count > index && !(this._contentText[index] == null))
			{
				this._contentText[index].text = text;
				return;
			}
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x0001633B File Offset: 0x0001453B
		public void SetUpdateCallback(Action<int> callback)
		{
			this.updateCallback = callback;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x00016344 File Offset: 0x00014544
		public virtual void TakeInputFocus()
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(this._defaultUIElement);
			this.Enable();
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0001636A File Offset: 0x0001456A
		public virtual void Enable()
		{
			this._canvasGroup.interactable = true;
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x00016378 File Offset: 0x00014578
		public virtual void Disable()
		{
			this._canvasGroup.interactable = false;
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00016386 File Offset: 0x00014586
		public virtual void Cancel()
		{
			if (!this.initialized)
			{
				return;
			}
			if (this.cancelCallback != null)
			{
				this.cancelCallback();
			}
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x001469E0 File Offset: 0x00144BE0
		private void CreateText(GameObject prefab, ref Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			if (prefab == null || this.content == null)
			{
				return;
			}
			if (textComponent != null)
			{
				Debug.LogError("Window already has " + name + "!");
				return;
			}
			GameObject gameObject = UITools.InstantiateGUIObject<Text>(prefab, this.content.transform, name, pivot, anchor.min, anchor.max, offset);
			if (gameObject == null)
			{
				return;
			}
			textComponent = gameObject.GetComponent<Text>();
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00146A64 File Offset: 0x00144C64
		private void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
			if (!(prefab == null) && !(this.content == null))
			{
				UITools.InstantiateGUIObject<Image>(prefab, this.content.transform, name, pivot, anchor.min, anchor.max, offset);
				return;
			}
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00146AB4 File Offset: 0x00144CB4
		private GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo)
		{
			buttonInfo = null;
			if (prefab == null)
			{
				return null;
			}
			GameObject gameObject = UITools.InstantiateGUIObject<ButtonInfo>(prefab, this.content.transform, name, pivot, anchor.min, anchor.max, offset);
			if (gameObject == null)
			{
				return null;
			}
			buttonInfo = gameObject.GetComponent<ButtonInfo>();
			if (gameObject.GetComponent<Button>() == null)
			{
				Debug.Log("Button prefab is missing Button component!");
				return null;
			}
			if (buttonInfo == null)
			{
				Debug.Log("Button prefab is missing ButtonInfo component!");
				return null;
			}
			return gameObject;
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x000163A4 File Offset: 0x000145A4
		private IEnumerator OnEnableAsync()
		{
			Window.<OnEnableAsync>d__64 <OnEnableAsync>d__ = new Window.<OnEnableAsync>d__64(0);
			<OnEnableAsync>d__.<>4__this = this;
			return <OnEnableAsync>d__;
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x00146B40 File Offset: 0x00144D40
		private void CheckUISelection()
		{
			if (!this.hasFocus)
			{
				return;
			}
			if (EventSystem.current == null)
			{
				return;
			}
			if (EventSystem.current.currentSelectedGameObject == null)
			{
				this.RestoreDefaultOrLastUISelection();
			}
			this.lastUISelection = EventSystem.current.currentSelectedGameObject;
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000163B3 File Offset: 0x000145B3
		private void RestoreDefaultOrLastUISelection()
		{
			if (!this.hasFocus)
			{
				return;
			}
			if (!(this.lastUISelection == null) && this.lastUISelection.activeInHierarchy)
			{
				this.SetUISelection(this.lastUISelection);
				return;
			}
			this.SetUISelection(this._defaultUIElement);
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x0001404D File Offset: 0x0001224D
		private void SetUISelection(GameObject selection)
		{
			if (EventSystem.current == null)
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(selection);
		}

		// Token: 0x04000ADE RID: 2782
		public Image backgroundImage;

		// Token: 0x04000ADF RID: 2783
		public GameObject content;

		// Token: 0x04000AE0 RID: 2784
		private bool _initialized;

		// Token: 0x04000AE1 RID: 2785
		private int _id = -1;

		// Token: 0x04000AE2 RID: 2786
		private RectTransform _rectTransform;

		// Token: 0x04000AE3 RID: 2787
		private Text _titleText;

		// Token: 0x04000AE4 RID: 2788
		private List<Text> _contentText;

		// Token: 0x04000AE5 RID: 2789
		private GameObject _defaultUIElement;

		// Token: 0x04000AE6 RID: 2790
		private Action<int> _updateCallback;

		// Token: 0x04000AE7 RID: 2791
		private Func<int, bool> _isFocusedCallback;

		// Token: 0x04000AE8 RID: 2792
		private Window.Timer _timer;

		// Token: 0x04000AE9 RID: 2793
		private CanvasGroup _canvasGroup;

		// Token: 0x04000AEA RID: 2794
		public UnityAction cancelCallback;

		// Token: 0x04000AEB RID: 2795
		private GameObject lastUISelection;

		// Token: 0x02000156 RID: 342
		public class Timer
		{
			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x060031F6 RID: 12790 RVA: 0x00016401 File Offset: 0x00014601
			public bool started
			{
				get
				{
					return this._started;
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x060031F7 RID: 12791 RVA: 0x00016409 File Offset: 0x00014609
			public bool finished
			{
				get
				{
					if (!this.started)
					{
						return false;
					}
					if (Time.realtimeSinceStartup < this.end)
					{
						return false;
					}
					this._started = false;
					return true;
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x060031F8 RID: 12792 RVA: 0x0001642C File Offset: 0x0001462C
			public float remaining
			{
				get
				{
					if (!this._started)
					{
						return 0f;
					}
					return this.end - Time.realtimeSinceStartup;
				}
			}

			// Token: 0x060031FA RID: 12794 RVA: 0x00016448 File Offset: 0x00014648
			public void Start(float length)
			{
				this.end = Time.realtimeSinceStartup + length;
				this._started = true;
			}

			// Token: 0x060031FB RID: 12795 RVA: 0x0001645E File Offset: 0x0001465E
			public void Stop()
			{
				this._started = false;
			}

			// Token: 0x04000AEC RID: 2796
			private bool _started;

			// Token: 0x04000AED RID: 2797
			private float end;
		}
	}
}
