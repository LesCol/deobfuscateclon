using System;
using System.Collections;
using Rewired.UI.ControlMapper;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x02000158 RID: 344
	[AddComponentMenu("")]
	public class ControlMapperDemoMessage : MonoBehaviour
	{
		// Token: 0x06003202 RID: 12802 RVA: 0x0001647E File Offset: 0x0001467E
		private void Awake()
		{
			if (this.controlMapper != null)
			{
				this.controlMapper.ScreenClosedEvent += this.OnControlMapperClosed;
				this.controlMapper.ScreenOpenedEvent += this.OnControlMapperOpened;
			}
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000164BC File Offset: 0x000146BC
		private void Start()
		{
			this.SelectDefault();
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000164C4 File Offset: 0x000146C4
		private void OnControlMapperClosed()
		{
			base.gameObject.SetActive(true);
			base.StartCoroutine(this.SelectDefaultDeferred());
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000164DF File Offset: 0x000146DF
		private void OnControlMapperOpened()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000164ED File Offset: 0x000146ED
		private void SelectDefault()
		{
			if (EventSystem.current == null)
			{
				return;
			}
			if (this.defaultSelectable != null)
			{
				EventSystem.current.SetSelectedGameObject(this.defaultSelectable.gameObject);
			}
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00016520 File Offset: 0x00014720
		private IEnumerator SelectDefaultDeferred()
		{
			ControlMapperDemoMessage.<SelectDefaultDeferred>d__7 <SelectDefaultDeferred>d__ = new ControlMapperDemoMessage.<SelectDefaultDeferred>d__7(0);
			<SelectDefaultDeferred>d__.<>4__this = this;
			return <SelectDefaultDeferred>d__;
		}

		// Token: 0x04000AF1 RID: 2801
		public ControlMapper controlMapper;

		// Token: 0x04000AF2 RID: 2802
		public Selectable defaultSelectable;
	}
}
