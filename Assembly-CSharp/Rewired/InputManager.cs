using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired
{
	// Token: 0x020000EB RID: 235
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base
	{
		// Token: 0x06002C6C RID: 11372 RVA: 0x0001233B File Offset: 0x0001053B
		protected override void DetectPlatform()
		{
			this.editorPlatform = EditorPlatform.None;
			this.platform = Platform.Unknown;
			this.webplayerPlatform = WebplayerPlatform.None;
			this.isEditor = false;
			if (SystemInfo.deviceName != null)
			{
			}
			if (SystemInfo.deviceModel != null)
			{
			}
			this.platform = Platform.Windows;
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00002C8A File Offset: 0x00000E8A
		protected override void CheckRecompile()
		{
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x0001236E File Offset: 0x0001056E
		protected override IExternalTools GetExternalTools()
		{
			return new ExternalTools();
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00012375 File Offset: 0x00010575
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return Regex.IsMatch(deviceName, searchPattern, RegexOptions.IgnoreCase) || Regex.IsMatch(deviceModel, searchPattern, RegexOptions.IgnoreCase);
		}
	}
}
