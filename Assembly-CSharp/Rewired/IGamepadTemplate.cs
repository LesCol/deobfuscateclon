using System;

namespace Rewired
{
	// Token: 0x020000DF RID: 223
	public interface IGamepadTemplate : IControllerTemplate
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06002A68 RID: 10856
		IControllerTemplateButton actionBottomRow1 { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06002A69 RID: 10857
		IControllerTemplateButton a { get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06002A6A RID: 10858
		IControllerTemplateButton actionBottomRow2 { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06002A6B RID: 10859
		IControllerTemplateButton b { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06002A6C RID: 10860
		IControllerTemplateButton actionBottomRow3 { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06002A6D RID: 10861
		IControllerTemplateButton c { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06002A6E RID: 10862
		IControllerTemplateButton actionTopRow1 { get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06002A6F RID: 10863
		IControllerTemplateButton x { get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06002A70 RID: 10864
		IControllerTemplateButton actionTopRow2 { get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06002A71 RID: 10865
		IControllerTemplateButton y { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06002A72 RID: 10866
		IControllerTemplateButton actionTopRow3 { get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06002A73 RID: 10867
		IControllerTemplateButton z { get; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06002A74 RID: 10868
		IControllerTemplateButton leftShoulder1 { get; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06002A75 RID: 10869
		IControllerTemplateButton leftBumper { get; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06002A76 RID: 10870
		IControllerTemplateAxis leftShoulder2 { get; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06002A77 RID: 10871
		IControllerTemplateAxis leftTrigger { get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06002A78 RID: 10872
		IControllerTemplateButton rightShoulder1 { get; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06002A79 RID: 10873
		IControllerTemplateButton rightBumper { get; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06002A7A RID: 10874
		IControllerTemplateAxis rightShoulder2 { get; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06002A7B RID: 10875
		IControllerTemplateAxis rightTrigger { get; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06002A7C RID: 10876
		IControllerTemplateButton center1 { get; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06002A7D RID: 10877
		IControllerTemplateButton back { get; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06002A7E RID: 10878
		IControllerTemplateButton center2 { get; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06002A7F RID: 10879
		IControllerTemplateButton start { get; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06002A80 RID: 10880
		IControllerTemplateButton center3 { get; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06002A81 RID: 10881
		IControllerTemplateButton guide { get; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06002A82 RID: 10882
		IControllerTemplateThumbStick leftStick { get; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06002A83 RID: 10883
		IControllerTemplateThumbStick rightStick { get; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06002A84 RID: 10884
		IControllerTemplateDPad dPad { get; }
	}
}
