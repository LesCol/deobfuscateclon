using System;
using System.Text;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x020000F8 RID: 248
	public class PlayerPointerEventData : PointerEventData
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000128EC File Offset: 0x00010AEC
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x000128F4 File Offset: 0x00010AF4
		public int playerId { get; set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000128FD File Offset: 0x00010AFD
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x00012905 File Offset: 0x00010B05
		public int inputSourceIndex { get; set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x0001290E File Offset: 0x00010B0E
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x00012916 File Offset: 0x00010B16
		public IMouseInputSource mouseSource { get; set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x0001291F File Offset: 0x00010B1F
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x00012927 File Offset: 0x00010B27
		public ITouchInputSource touchSource { get; set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x00012930 File Offset: 0x00010B30
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x00012938 File Offset: 0x00010B38
		public PointerEventType sourceType { get; set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x00012941 File Offset: 0x00010B41
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x00012949 File Offset: 0x00010B49
		public int buttonIndex { get; set; }

		// Token: 0x06002D2B RID: 11563 RVA: 0x00012952 File Offset: 0x00010B52
		public PlayerPointerEventData(EventSystem eventSystem) : base(eventSystem)
		{
			this.playerId = -1;
			this.inputSourceIndex = -1;
			this.buttonIndex = -1;
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x0013A3B8 File Offset: 0x001385B8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<b>Player Id</b>: " + this.playerId);
			stringBuilder.AppendLine("<b>Mouse Source</b>: " + this.mouseSource);
			stringBuilder.AppendLine("<b>Input Source Index</b>: " + this.inputSourceIndex);
			stringBuilder.AppendLine("<b>Touch Source/b>: " + this.touchSource);
			stringBuilder.AppendLine("<b>Source Type</b>: " + this.sourceType);
			stringBuilder.AppendLine("<b>Button Index</b>: " + this.buttonIndex);
			stringBuilder.Append(base.ToString());
			return stringBuilder.ToString();
		}
	}
}
