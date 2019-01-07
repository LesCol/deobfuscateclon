using System;

namespace Rewired
{
	// Token: 0x020000E6 RID: 230
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x00011DFF File Offset: 0x0000FFFF
		IControllerTemplateAxis IRacingWheelTemplate.wheel
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(0);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x00011E08 File Offset: 0x00010008
		IControllerTemplateAxis IRacingWheelTemplate.accelerator
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(1);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x00011E11 File Offset: 0x00010011
		IControllerTemplateAxis IRacingWheelTemplate.brake
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(2);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x00011E1A File Offset: 0x0001001A
		IControllerTemplateAxis IRacingWheelTemplate.clutch
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(3);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x00011D4A File Offset: 0x0000FF4A
		IControllerTemplateButton IRacingWheelTemplate.shiftDown
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x00011D53 File Offset: 0x0000FF53
		IControllerTemplateButton IRacingWheelTemplate.shiftUp
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x00011D5C File Offset: 0x0000FF5C
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x00011D65 File Offset: 0x0000FF65
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x00011D6E File Offset: 0x0000FF6E
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x00011D77 File Offset: 0x0000FF77
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x00011D81 File Offset: 0x0000FF81
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x00011E23 File Offset: 0x00010023
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(11);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x00011D95 File Offset: 0x0000FF95
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x00011E2D File Offset: 0x0001002D
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x00011DB3 File Offset: 0x0000FFB3
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x00011DBD File Offset: 0x0000FFBD
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x00011E37 File Offset: 0x00010037
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(17);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x00011E41 File Offset: 0x00010041
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x00011E4B File Offset: 0x0001004B
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x00011E55 File Offset: 0x00010055
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x00011E5F File Offset: 0x0001005F
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x00011E69 File Offset: 0x00010069
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x00011E73 File Offset: 0x00010073
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x00011E7D File Offset: 0x0001007D
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x00011E87 File Offset: 0x00010087
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x00011E91 File Offset: 0x00010091
		IControllerTemplateButton IRacingWheelTemplate.shifter1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x00011E9B File Offset: 0x0001009B
		IControllerTemplateButton IRacingWheelTemplate.shifter2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(27);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x00011EA5 File Offset: 0x000100A5
		IControllerTemplateButton IRacingWheelTemplate.shifter3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(28);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x00011EAF File Offset: 0x000100AF
		IControllerTemplateButton IRacingWheelTemplate.shifter4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(29);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00011EB9 File Offset: 0x000100B9
		IControllerTemplateButton IRacingWheelTemplate.shifter5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(30);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x00011EC3 File Offset: 0x000100C3
		IControllerTemplateButton IRacingWheelTemplate.shifter6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(31);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x00011ECD File Offset: 0x000100CD
		IControllerTemplateButton IRacingWheelTemplate.shifter7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(32);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x00011ED7 File Offset: 0x000100D7
		IControllerTemplateButton IRacingWheelTemplate.shifter8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(33);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x00011EE1 File Offset: 0x000100E1
		IControllerTemplateButton IRacingWheelTemplate.shifter9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(34);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x00011EEB File Offset: 0x000100EB
		IControllerTemplateButton IRacingWheelTemplate.shifter10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(35);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x00011EF5 File Offset: 0x000100F5
		IControllerTemplateButton IRacingWheelTemplate.reverseGear
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(44);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x00011EFF File Offset: 0x000100FF
		IControllerTemplateButton IRacingWheelTemplate.select
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(36);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x00011F09 File Offset: 0x00010109
		IControllerTemplateButton IRacingWheelTemplate.start
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(37);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x00011F13 File Offset: 0x00010113
		IControllerTemplateButton IRacingWheelTemplate.systemButton
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(38);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x00011F1D File Offset: 0x0001011D
		IControllerTemplateButton IRacingWheelTemplate.horn
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(43);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00011F27 File Offset: 0x00010127
		IControllerTemplateDPad IRacingWheelTemplate.dPad
		{
			get
			{
				return base.GetElement<IControllerTemplateDPad>(45);
			}
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public RacingWheelTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x040006E3 RID: 1763
		public static readonly Guid typeGuid = new Guid("104e31d8-9115-4dd5-a398-2e54d35e6c83");

		// Token: 0x040006E4 RID: 1764
		public const int elementId_wheel = 0;

		// Token: 0x040006E5 RID: 1765
		public const int elementId_accelerator = 1;

		// Token: 0x040006E6 RID: 1766
		public const int elementId_brake = 2;

		// Token: 0x040006E7 RID: 1767
		public const int elementId_clutch = 3;

		// Token: 0x040006E8 RID: 1768
		public const int elementId_shiftDown = 4;

		// Token: 0x040006E9 RID: 1769
		public const int elementId_shiftUp = 5;

		// Token: 0x040006EA RID: 1770
		public const int elementId_wheelButton1 = 6;

		// Token: 0x040006EB RID: 1771
		public const int elementId_wheelButton2 = 7;

		// Token: 0x040006EC RID: 1772
		public const int elementId_wheelButton3 = 8;

		// Token: 0x040006ED RID: 1773
		public const int elementId_wheelButton4 = 9;

		// Token: 0x040006EE RID: 1774
		public const int elementId_wheelButton5 = 10;

		// Token: 0x040006EF RID: 1775
		public const int elementId_wheelButton6 = 11;

		// Token: 0x040006F0 RID: 1776
		public const int elementId_wheelButton7 = 12;

		// Token: 0x040006F1 RID: 1777
		public const int elementId_wheelButton8 = 13;

		// Token: 0x040006F2 RID: 1778
		public const int elementId_wheelButton9 = 14;

		// Token: 0x040006F3 RID: 1779
		public const int elementId_wheelButton10 = 15;

		// Token: 0x040006F4 RID: 1780
		public const int elementId_consoleButton1 = 16;

		// Token: 0x040006F5 RID: 1781
		public const int elementId_consoleButton2 = 17;

		// Token: 0x040006F6 RID: 1782
		public const int elementId_consoleButton3 = 18;

		// Token: 0x040006F7 RID: 1783
		public const int elementId_consoleButton4 = 19;

		// Token: 0x040006F8 RID: 1784
		public const int elementId_consoleButton5 = 20;

		// Token: 0x040006F9 RID: 1785
		public const int elementId_consoleButton6 = 21;

		// Token: 0x040006FA RID: 1786
		public const int elementId_consoleButton7 = 22;

		// Token: 0x040006FB RID: 1787
		public const int elementId_consoleButton8 = 23;

		// Token: 0x040006FC RID: 1788
		public const int elementId_consoleButton9 = 24;

		// Token: 0x040006FD RID: 1789
		public const int elementId_consoleButton10 = 25;

		// Token: 0x040006FE RID: 1790
		public const int elementId_shifter1 = 26;

		// Token: 0x040006FF RID: 1791
		public const int elementId_shifter2 = 27;

		// Token: 0x04000700 RID: 1792
		public const int elementId_shifter3 = 28;

		// Token: 0x04000701 RID: 1793
		public const int elementId_shifter4 = 29;

		// Token: 0x04000702 RID: 1794
		public const int elementId_shifter5 = 30;

		// Token: 0x04000703 RID: 1795
		public const int elementId_shifter6 = 31;

		// Token: 0x04000704 RID: 1796
		public const int elementId_shifter7 = 32;

		// Token: 0x04000705 RID: 1797
		public const int elementId_shifter8 = 33;

		// Token: 0x04000706 RID: 1798
		public const int elementId_shifter9 = 34;

		// Token: 0x04000707 RID: 1799
		public const int elementId_shifter10 = 35;

		// Token: 0x04000708 RID: 1800
		public const int elementId_reverseGear = 44;

		// Token: 0x04000709 RID: 1801
		public const int elementId_select = 36;

		// Token: 0x0400070A RID: 1802
		public const int elementId_start = 37;

		// Token: 0x0400070B RID: 1803
		public const int elementId_systemButton = 38;

		// Token: 0x0400070C RID: 1804
		public const int elementId_horn = 43;

		// Token: 0x0400070D RID: 1805
		public const int elementId_dPadUp = 39;

		// Token: 0x0400070E RID: 1806
		public const int elementId_dPadRight = 40;

		// Token: 0x0400070F RID: 1807
		public const int elementId_dPadDown = 41;

		// Token: 0x04000710 RID: 1808
		public const int elementId_dPadLeft = 42;

		// Token: 0x04000711 RID: 1809
		public const int elementId_dPad = 45;
	}
}
