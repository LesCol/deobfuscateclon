using System;

namespace Rewired
{
	// Token: 0x020000E2 RID: 226
	public interface IFlightYokeTemplate : IControllerTemplate
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06002B07 RID: 11015
		IControllerTemplateButton leftPaddle { get; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06002B08 RID: 11016
		IControllerTemplateButton rightPaddle { get; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06002B09 RID: 11017
		IControllerTemplateButton leftGripButton1 { get; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06002B0A RID: 11018
		IControllerTemplateButton leftGripButton2 { get; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06002B0B RID: 11019
		IControllerTemplateButton leftGripButton3 { get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06002B0C RID: 11020
		IControllerTemplateButton leftGripButton4 { get; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06002B0D RID: 11021
		IControllerTemplateButton leftGripButton5 { get; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06002B0E RID: 11022
		IControllerTemplateButton leftGripButton6 { get; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06002B0F RID: 11023
		IControllerTemplateButton rightGripButton1 { get; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06002B10 RID: 11024
		IControllerTemplateButton rightGripButton2 { get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06002B11 RID: 11025
		IControllerTemplateButton rightGripButton3 { get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06002B12 RID: 11026
		IControllerTemplateButton rightGripButton4 { get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06002B13 RID: 11027
		IControllerTemplateButton rightGripButton5 { get; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06002B14 RID: 11028
		IControllerTemplateButton rightGripButton6 { get; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06002B15 RID: 11029
		IControllerTemplateButton centerButton1 { get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06002B16 RID: 11030
		IControllerTemplateButton centerButton2 { get; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06002B17 RID: 11031
		IControllerTemplateButton centerButton3 { get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06002B18 RID: 11032
		IControllerTemplateButton centerButton4 { get; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06002B19 RID: 11033
		IControllerTemplateButton centerButton5 { get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06002B1A RID: 11034
		IControllerTemplateButton centerButton6 { get; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06002B1B RID: 11035
		IControllerTemplateButton centerButton7 { get; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06002B1C RID: 11036
		IControllerTemplateButton centerButton8 { get; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06002B1D RID: 11037
		IControllerTemplateButton wheel1Up { get; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06002B1E RID: 11038
		IControllerTemplateButton wheel1Down { get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06002B1F RID: 11039
		IControllerTemplateButton wheel1Press { get; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06002B20 RID: 11040
		IControllerTemplateButton wheel2Up { get; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06002B21 RID: 11041
		IControllerTemplateButton wheel2Down { get; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06002B22 RID: 11042
		IControllerTemplateButton wheel2Press { get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06002B23 RID: 11043
		IControllerTemplateButton consoleButton1 { get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06002B24 RID: 11044
		IControllerTemplateButton consoleButton2 { get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06002B25 RID: 11045
		IControllerTemplateButton consoleButton3 { get; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06002B26 RID: 11046
		IControllerTemplateButton consoleButton4 { get; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06002B27 RID: 11047
		IControllerTemplateButton consoleButton5 { get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06002B28 RID: 11048
		IControllerTemplateButton consoleButton6 { get; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06002B29 RID: 11049
		IControllerTemplateButton consoleButton7 { get; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06002B2A RID: 11050
		IControllerTemplateButton consoleButton8 { get; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06002B2B RID: 11051
		IControllerTemplateButton consoleButton9 { get; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06002B2C RID: 11052
		IControllerTemplateButton consoleButton10 { get; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06002B2D RID: 11053
		IControllerTemplateButton mode1 { get; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06002B2E RID: 11054
		IControllerTemplateButton mode2 { get; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06002B2F RID: 11055
		IControllerTemplateButton mode3 { get; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06002B30 RID: 11056
		IControllerTemplateYoke yoke { get; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06002B31 RID: 11057
		IControllerTemplateThrottle lever1 { get; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06002B32 RID: 11058
		IControllerTemplateThrottle lever2 { get; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06002B33 RID: 11059
		IControllerTemplateThrottle lever3 { get; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06002B34 RID: 11060
		IControllerTemplateThrottle lever4 { get; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06002B35 RID: 11061
		IControllerTemplateThrottle lever5 { get; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06002B36 RID: 11062
		IControllerTemplateHat leftGripHat { get; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06002B37 RID: 11063
		IControllerTemplateHat rightGripHat { get; }
	}
}
