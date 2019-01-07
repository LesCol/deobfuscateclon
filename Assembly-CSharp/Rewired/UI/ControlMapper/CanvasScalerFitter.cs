using System;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000106 RID: 262
	[RequireComponent(typeof(CanvasScalerExt))]
	public class CanvasScalerFitter : MonoBehaviour
	{
		// Token: 0x06002DE5 RID: 11749 RVA: 0x00013276 File Offset: 0x00011476
		private void OnEnable()
		{
			this.canvasScaler = base.GetComponent<CanvasScalerExt>();
			this.Update();
			this.canvasScaler.ForceRefresh();
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00013295 File Offset: 0x00011495
		private void Update()
		{
			if (Screen.width != this.screenWidth || Screen.height != this.screenHeight)
			{
				this.screenWidth = Screen.width;
				this.screenHeight = Screen.height;
				this.UpdateSize();
			}
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x0013CFEC File Offset: 0x0013B1EC
		private void UpdateSize()
		{
			if (this.canvasScaler.uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize)
			{
				return;
			}
			if (this.breakPoints == null)
			{
				return;
			}
			float num = (float)Screen.width / (float)Screen.height;
			float num2 = float.PositiveInfinity;
			int num3 = 0;
			for (int i = 0; i < this.breakPoints.Length; i++)
			{
				float num4 = Mathf.Abs(num - this.breakPoints[i].screenAspectRatio);
				if ((num4 <= this.breakPoints[i].screenAspectRatio || MathTools.IsNear(this.breakPoints[i].screenAspectRatio, 0.01f)) && num4 < num2)
				{
					num2 = num4;
					num3 = i;
				}
			}
			this.canvasScaler.referenceResolution = this.breakPoints[num3].referenceResolution;
		}

		// Token: 0x040008DE RID: 2270
		[SerializeField]
		private CanvasScalerFitter.BreakPoint[] breakPoints;

		// Token: 0x040008DF RID: 2271
		private CanvasScalerExt canvasScaler;

		// Token: 0x040008E0 RID: 2272
		private int screenWidth;

		// Token: 0x040008E1 RID: 2273
		private int screenHeight;

		// Token: 0x040008E2 RID: 2274
		private Action ScreenSizeChanged;

		// Token: 0x02000107 RID: 263
		[Serializable]
		private class BreakPoint
		{
			// Token: 0x040008E3 RID: 2275
			[SerializeField]
			public string name;

			// Token: 0x040008E4 RID: 2276
			[SerializeField]
			public float screenAspectRatio;

			// Token: 0x040008E5 RID: 2277
			[SerializeField]
			public Vector2 referenceResolution;
		}
	}
}
