using System;

namespace Rewired
{
	// Token: 0x020000E5 RID: 229
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x00011D4A File Offset: 0x0000FF4A
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x00011D4A File Offset: 0x0000FF4A
		IControllerTemplateButton IGamepadTemplate.a
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x00011D53 File Offset: 0x0000FF53
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x00011D53 File Offset: 0x0000FF53
		IControllerTemplateButton IGamepadTemplate.b
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x00011D5C File Offset: 0x0000FF5C
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x00011D5C File Offset: 0x0000FF5C
		IControllerTemplateButton IGamepadTemplate.c
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x00011D65 File Offset: 0x0000FF65
		IControllerTemplateButton IGamepadTemplate.actionTopRow1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x00011D65 File Offset: 0x0000FF65
		IControllerTemplateButton IGamepadTemplate.x
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x00011D6E File Offset: 0x0000FF6E
		IControllerTemplateButton IGamepadTemplate.actionTopRow2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x00011D6E File Offset: 0x0000FF6E
		IControllerTemplateButton IGamepadTemplate.y
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x00011D77 File Offset: 0x0000FF77
		IControllerTemplateButton IGamepadTemplate.actionTopRow3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x00011D77 File Offset: 0x0000FF77
		IControllerTemplateButton IGamepadTemplate.z
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x00011D81 File Offset: 0x0000FF81
		IControllerTemplateButton IGamepadTemplate.leftShoulder1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x00011D81 File Offset: 0x0000FF81
		IControllerTemplateButton IGamepadTemplate.leftBumper
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x00011D8B File Offset: 0x0000FF8B
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(11);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x00011D8B File Offset: 0x0000FF8B
		IControllerTemplateAxis IGamepadTemplate.leftTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(11);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x00011D95 File Offset: 0x0000FF95
		IControllerTemplateButton IGamepadTemplate.rightShoulder1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x00011D95 File Offset: 0x0000FF95
		IControllerTemplateButton IGamepadTemplate.rightBumper
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x00011D9F File Offset: 0x0000FF9F
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(13);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x00011D9F File Offset: 0x0000FF9F
		IControllerTemplateAxis IGamepadTemplate.rightTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(13);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		IControllerTemplateButton IGamepadTemplate.center1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		IControllerTemplateButton IGamepadTemplate.back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x00011DB3 File Offset: 0x0000FFB3
		IControllerTemplateButton IGamepadTemplate.center2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x00011DB3 File Offset: 0x0000FFB3
		IControllerTemplateButton IGamepadTemplate.start
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x00011DBD File Offset: 0x0000FFBD
		IControllerTemplateButton IGamepadTemplate.center3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x00011DBD File Offset: 0x0000FFBD
		IControllerTemplateButton IGamepadTemplate.guide
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x00011DC7 File Offset: 0x0000FFC7
		IControllerTemplateThumbStick IGamepadTemplate.leftStick
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(23);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x00011DD1 File Offset: 0x0000FFD1
		IControllerTemplateThumbStick IGamepadTemplate.rightStick
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(24);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x00011DDB File Offset: 0x0000FFDB
		IControllerTemplateDPad IGamepadTemplate.dPad
		{
			get
			{
				return base.GetElement<IControllerTemplateDPad>(25);
			}
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public GamepadTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x040006BB RID: 1723
		public static readonly Guid typeGuid = new Guid("83b427e4-086f-47f3-bb06-be266abd1ca5");

		// Token: 0x040006BC RID: 1724
		public const int elementId_leftStickX = 0;

		// Token: 0x040006BD RID: 1725
		public const int elementId_leftStickY = 1;

		// Token: 0x040006BE RID: 1726
		public const int elementId_rightStickX = 2;

		// Token: 0x040006BF RID: 1727
		public const int elementId_rightStickY = 3;

		// Token: 0x040006C0 RID: 1728
		public const int elementId_actionBottomRow1 = 4;

		// Token: 0x040006C1 RID: 1729
		public const int elementId_a = 4;

		// Token: 0x040006C2 RID: 1730
		public const int elementId_actionBottomRow2 = 5;

		// Token: 0x040006C3 RID: 1731
		public const int elementId_b = 5;

		// Token: 0x040006C4 RID: 1732
		public const int elementId_actionBottomRow3 = 6;

		// Token: 0x040006C5 RID: 1733
		public const int elementId_c = 6;

		// Token: 0x040006C6 RID: 1734
		public const int elementId_actionTopRow1 = 7;

		// Token: 0x040006C7 RID: 1735
		public const int elementId_x = 7;

		// Token: 0x040006C8 RID: 1736
		public const int elementId_actionTopRow2 = 8;

		// Token: 0x040006C9 RID: 1737
		public const int elementId_y = 8;

		// Token: 0x040006CA RID: 1738
		public const int elementId_actionTopRow3 = 9;

		// Token: 0x040006CB RID: 1739
		public const int elementId_z = 9;

		// Token: 0x040006CC RID: 1740
		public const int elementId_leftShoulder1 = 10;

		// Token: 0x040006CD RID: 1741
		public const int elementId_leftBumper = 10;

		// Token: 0x040006CE RID: 1742
		public const int elementId_leftShoulder2 = 11;

		// Token: 0x040006CF RID: 1743
		public const int elementId_leftTrigger = 11;

		// Token: 0x040006D0 RID: 1744
		public const int elementId_rightShoulder1 = 12;

		// Token: 0x040006D1 RID: 1745
		public const int elementId_rightBumper = 12;

		// Token: 0x040006D2 RID: 1746
		public const int elementId_rightShoulder2 = 13;

		// Token: 0x040006D3 RID: 1747
		public const int elementId_rightTrigger = 13;

		// Token: 0x040006D4 RID: 1748
		public const int elementId_center1 = 14;

		// Token: 0x040006D5 RID: 1749
		public const int elementId_back = 14;

		// Token: 0x040006D6 RID: 1750
		public const int elementId_center2 = 15;

		// Token: 0x040006D7 RID: 1751
		public const int elementId_start = 15;

		// Token: 0x040006D8 RID: 1752
		public const int elementId_center3 = 16;

		// Token: 0x040006D9 RID: 1753
		public const int elementId_guide = 16;

		// Token: 0x040006DA RID: 1754
		public const int elementId_leftStickButton = 17;

		// Token: 0x040006DB RID: 1755
		public const int elementId_rightStickButton = 18;

		// Token: 0x040006DC RID: 1756
		public const int elementId_dPadUp = 19;

		// Token: 0x040006DD RID: 1757
		public const int elementId_dPadRight = 20;

		// Token: 0x040006DE RID: 1758
		public const int elementId_dPadDown = 21;

		// Token: 0x040006DF RID: 1759
		public const int elementId_dPadLeft = 22;

		// Token: 0x040006E0 RID: 1760
		public const int elementId_leftStick = 23;

		// Token: 0x040006E1 RID: 1761
		public const int elementId_rightStick = 24;

		// Token: 0x040006E2 RID: 1762
		public const int elementId_dPad = 25;
	}
}
