using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000130 RID: 304
	public interface ICustomSelectable : ICancelHandler, IEventSystemHandler
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060030C3 RID: 12483
		// (set) Token: 0x060030C4 RID: 12484
		Sprite disabledHighlightedSprite { get; set; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060030C5 RID: 12485
		// (set) Token: 0x060030C6 RID: 12486
		Color disabledHighlightedColor { get; set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060030C7 RID: 12487
		// (set) Token: 0x060030C8 RID: 12488
		string disabledHighlightedTrigger { get; set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060030C9 RID: 12489
		// (set) Token: 0x060030CA RID: 12490
		bool autoNavUp { get; set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060030CB RID: 12491
		// (set) Token: 0x060030CC RID: 12492
		bool autoNavDown { get; set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060030CD RID: 12493
		// (set) Token: 0x060030CE RID: 12494
		bool autoNavLeft { get; set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060030CF RID: 12495
		// (set) Token: 0x060030D0 RID: 12496
		bool autoNavRight { get; set; }

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060030D1 RID: 12497
		// (remove) Token: 0x060030D2 RID: 12498
		event UnityAction CancelEvent;
	}
}
