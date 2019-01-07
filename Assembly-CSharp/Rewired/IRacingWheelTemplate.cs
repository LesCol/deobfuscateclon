using System;

namespace Rewired
{
	// Token: 0x020000E0 RID: 224
	public interface IRacingWheelTemplate : IControllerTemplate
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06002A85 RID: 10885
		IControllerTemplateAxis wheel { get; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06002A86 RID: 10886
		IControllerTemplateAxis accelerator { get; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06002A87 RID: 10887
		IControllerTemplateAxis brake { get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06002A88 RID: 10888
		IControllerTemplateAxis clutch { get; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06002A89 RID: 10889
		IControllerTemplateButton shiftDown { get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06002A8A RID: 10890
		IControllerTemplateButton shiftUp { get; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06002A8B RID: 10891
		IControllerTemplateButton wheelButton1 { get; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06002A8C RID: 10892
		IControllerTemplateButton wheelButton2 { get; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06002A8D RID: 10893
		IControllerTemplateButton wheelButton3 { get; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06002A8E RID: 10894
		IControllerTemplateButton wheelButton4 { get; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06002A8F RID: 10895
		IControllerTemplateButton wheelButton5 { get; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06002A90 RID: 10896
		IControllerTemplateButton wheelButton6 { get; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06002A91 RID: 10897
		IControllerTemplateButton wheelButton7 { get; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06002A92 RID: 10898
		IControllerTemplateButton wheelButton8 { get; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06002A93 RID: 10899
		IControllerTemplateButton wheelButton9 { get; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06002A94 RID: 10900
		IControllerTemplateButton wheelButton10 { get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06002A95 RID: 10901
		IControllerTemplateButton consoleButton1 { get; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06002A96 RID: 10902
		IControllerTemplateButton consoleButton2 { get; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06002A97 RID: 10903
		IControllerTemplateButton consoleButton3 { get; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06002A98 RID: 10904
		IControllerTemplateButton consoleButton4 { get; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06002A99 RID: 10905
		IControllerTemplateButton consoleButton5 { get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06002A9A RID: 10906
		IControllerTemplateButton consoleButton6 { get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06002A9B RID: 10907
		IControllerTemplateButton consoleButton7 { get; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06002A9C RID: 10908
		IControllerTemplateButton consoleButton8 { get; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06002A9D RID: 10909
		IControllerTemplateButton consoleButton9 { get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06002A9E RID: 10910
		IControllerTemplateButton consoleButton10 { get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06002A9F RID: 10911
		IControllerTemplateButton shifter1 { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06002AA0 RID: 10912
		IControllerTemplateButton shifter2 { get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06002AA1 RID: 10913
		IControllerTemplateButton shifter3 { get; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06002AA2 RID: 10914
		IControllerTemplateButton shifter4 { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06002AA3 RID: 10915
		IControllerTemplateButton shifter5 { get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06002AA4 RID: 10916
		IControllerTemplateButton shifter6 { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06002AA5 RID: 10917
		IControllerTemplateButton shifter7 { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06002AA6 RID: 10918
		IControllerTemplateButton shifter8 { get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06002AA7 RID: 10919
		IControllerTemplateButton shifter9 { get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06002AA8 RID: 10920
		IControllerTemplateButton shifter10 { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06002AA9 RID: 10921
		IControllerTemplateButton reverseGear { get; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06002AAA RID: 10922
		IControllerTemplateButton select { get; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06002AAB RID: 10923
		IControllerTemplateButton start { get; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06002AAC RID: 10924
		IControllerTemplateButton systemButton { get; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06002AAD RID: 10925
		IControllerTemplateButton horn { get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06002AAE RID: 10926
		IControllerTemplateDPad dPad { get; }
	}
}
