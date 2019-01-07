using System;

namespace Rewired
{
	// Token: 0x020000EA RID: 234
	public sealed class SixDofControllerTemplate : ControllerTemplate, IControllerTemplate, ISixDofControllerTemplate
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000122DB File Offset: 0x000104DB
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(8);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x000122E4 File Offset: 0x000104E4
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(9);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x000122EE File Offset: 0x000104EE
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(10);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00011D8B File Offset: 0x0000FF8B
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(11);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00011D95 File Offset: 0x0000FF95
		IControllerTemplateButton ISixDofControllerTemplate.button1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x00011E2D File Offset: 0x0001002D
		IControllerTemplateButton ISixDofControllerTemplate.button2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		IControllerTemplateButton ISixDofControllerTemplate.button3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00011DB3 File Offset: 0x0000FFB3
		IControllerTemplateButton ISixDofControllerTemplate.button4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x00011DBD File Offset: 0x0000FFBD
		IControllerTemplateButton ISixDofControllerTemplate.button5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x00011E37 File Offset: 0x00010037
		IControllerTemplateButton ISixDofControllerTemplate.button6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(17);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x00011E41 File Offset: 0x00010041
		IControllerTemplateButton ISixDofControllerTemplate.button7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x00011E4B File Offset: 0x0001004B
		IControllerTemplateButton ISixDofControllerTemplate.button8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x00011E55 File Offset: 0x00010055
		IControllerTemplateButton ISixDofControllerTemplate.button9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00011E5F File Offset: 0x0001005F
		IControllerTemplateButton ISixDofControllerTemplate.button10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x00011E69 File Offset: 0x00010069
		IControllerTemplateButton ISixDofControllerTemplate.button11
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x00011E73 File Offset: 0x00010073
		IControllerTemplateButton ISixDofControllerTemplate.button12
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x00011E7D File Offset: 0x0001007D
		IControllerTemplateButton ISixDofControllerTemplate.button13
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x00011E87 File Offset: 0x00010087
		IControllerTemplateButton ISixDofControllerTemplate.button14
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x00011E91 File Offset: 0x00010091
		IControllerTemplateButton ISixDofControllerTemplate.button15
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x00011E9B File Offset: 0x0001009B
		IControllerTemplateButton ISixDofControllerTemplate.button16
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(27);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x00011EA5 File Offset: 0x000100A5
		IControllerTemplateButton ISixDofControllerTemplate.button17
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(28);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x00011EAF File Offset: 0x000100AF
		IControllerTemplateButton ISixDofControllerTemplate.button18
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(29);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x00011EB9 File Offset: 0x000100B9
		IControllerTemplateButton ISixDofControllerTemplate.button19
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(30);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x00011EC3 File Offset: 0x000100C3
		IControllerTemplateButton ISixDofControllerTemplate.button20
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(31);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x00011FB8 File Offset: 0x000101B8
		IControllerTemplateButton ISixDofControllerTemplate.button21
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(55);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x00011FC2 File Offset: 0x000101C2
		IControllerTemplateButton ISixDofControllerTemplate.button22
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(56);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x00011FCC File Offset: 0x000101CC
		IControllerTemplateButton ISixDofControllerTemplate.button23
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(57);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x00011FD6 File Offset: 0x000101D6
		IControllerTemplateButton ISixDofControllerTemplate.button24
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(58);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x00011FE0 File Offset: 0x000101E0
		IControllerTemplateButton ISixDofControllerTemplate.button25
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(59);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x00011FEA File Offset: 0x000101EA
		IControllerTemplateButton ISixDofControllerTemplate.button26
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(60);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x00011FF4 File Offset: 0x000101F4
		IControllerTemplateButton ISixDofControllerTemplate.button27
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(61);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x00011FFE File Offset: 0x000101FE
		IControllerTemplateButton ISixDofControllerTemplate.button28
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(62);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x00012008 File Offset: 0x00010208
		IControllerTemplateButton ISixDofControllerTemplate.button29
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(63);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x00012012 File Offset: 0x00010212
		IControllerTemplateButton ISixDofControllerTemplate.button30
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(64);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x0001201C File Offset: 0x0001021C
		IControllerTemplateButton ISixDofControllerTemplate.button31
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(65);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x00012026 File Offset: 0x00010226
		IControllerTemplateButton ISixDofControllerTemplate.button32
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(66);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000122F8 File Offset: 0x000104F8
		IControllerTemplateHat ISixDofControllerTemplate.hat1
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(48);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00012302 File Offset: 0x00010502
		IControllerTemplateHat ISixDofControllerTemplate.hat2
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(49);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x0001230C File Offset: 0x0001050C
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(52);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x00012316 File Offset: 0x00010516
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(53);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00012320 File Offset: 0x00010520
		IControllerTemplateStick6D ISixDofControllerTemplate.stick
		{
			get
			{
				return base.GetElement<IControllerTemplateStick6D>(54);
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public SixDofControllerTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x0400080D RID: 2061
		public static readonly Guid typeGuid = new Guid("2599beb3-522b-43dd-a4ef-93fd60e5eafa");

		// Token: 0x0400080E RID: 2062
		public const int elementId_positionX = 1;

		// Token: 0x0400080F RID: 2063
		public const int elementId_positionY = 2;

		// Token: 0x04000810 RID: 2064
		public const int elementId_positionZ = 0;

		// Token: 0x04000811 RID: 2065
		public const int elementId_rotationX = 3;

		// Token: 0x04000812 RID: 2066
		public const int elementId_rotationY = 5;

		// Token: 0x04000813 RID: 2067
		public const int elementId_rotationZ = 4;

		// Token: 0x04000814 RID: 2068
		public const int elementId_throttle1Axis = 6;

		// Token: 0x04000815 RID: 2069
		public const int elementId_throttle1MinDetent = 50;

		// Token: 0x04000816 RID: 2070
		public const int elementId_throttle2Axis = 7;

		// Token: 0x04000817 RID: 2071
		public const int elementId_throttle2MinDetent = 51;

		// Token: 0x04000818 RID: 2072
		public const int elementId_extraAxis1 = 8;

		// Token: 0x04000819 RID: 2073
		public const int elementId_extraAxis2 = 9;

		// Token: 0x0400081A RID: 2074
		public const int elementId_extraAxis3 = 10;

		// Token: 0x0400081B RID: 2075
		public const int elementId_extraAxis4 = 11;

		// Token: 0x0400081C RID: 2076
		public const int elementId_button1 = 12;

		// Token: 0x0400081D RID: 2077
		public const int elementId_button2 = 13;

		// Token: 0x0400081E RID: 2078
		public const int elementId_button3 = 14;

		// Token: 0x0400081F RID: 2079
		public const int elementId_button4 = 15;

		// Token: 0x04000820 RID: 2080
		public const int elementId_button5 = 16;

		// Token: 0x04000821 RID: 2081
		public const int elementId_button6 = 17;

		// Token: 0x04000822 RID: 2082
		public const int elementId_button7 = 18;

		// Token: 0x04000823 RID: 2083
		public const int elementId_button8 = 19;

		// Token: 0x04000824 RID: 2084
		public const int elementId_button9 = 20;

		// Token: 0x04000825 RID: 2085
		public const int elementId_button10 = 21;

		// Token: 0x04000826 RID: 2086
		public const int elementId_button11 = 22;

		// Token: 0x04000827 RID: 2087
		public const int elementId_button12 = 23;

		// Token: 0x04000828 RID: 2088
		public const int elementId_button13 = 24;

		// Token: 0x04000829 RID: 2089
		public const int elementId_button14 = 25;

		// Token: 0x0400082A RID: 2090
		public const int elementId_button15 = 26;

		// Token: 0x0400082B RID: 2091
		public const int elementId_button16 = 27;

		// Token: 0x0400082C RID: 2092
		public const int elementId_button17 = 28;

		// Token: 0x0400082D RID: 2093
		public const int elementId_button18 = 29;

		// Token: 0x0400082E RID: 2094
		public const int elementId_button19 = 30;

		// Token: 0x0400082F RID: 2095
		public const int elementId_button20 = 31;

		// Token: 0x04000830 RID: 2096
		public const int elementId_button21 = 55;

		// Token: 0x04000831 RID: 2097
		public const int elementId_button22 = 56;

		// Token: 0x04000832 RID: 2098
		public const int elementId_button23 = 57;

		// Token: 0x04000833 RID: 2099
		public const int elementId_button24 = 58;

		// Token: 0x04000834 RID: 2100
		public const int elementId_button25 = 59;

		// Token: 0x04000835 RID: 2101
		public const int elementId_button26 = 60;

		// Token: 0x04000836 RID: 2102
		public const int elementId_button27 = 61;

		// Token: 0x04000837 RID: 2103
		public const int elementId_button28 = 62;

		// Token: 0x04000838 RID: 2104
		public const int elementId_button29 = 63;

		// Token: 0x04000839 RID: 2105
		public const int elementId_button30 = 64;

		// Token: 0x0400083A RID: 2106
		public const int elementId_button31 = 65;

		// Token: 0x0400083B RID: 2107
		public const int elementId_button32 = 66;

		// Token: 0x0400083C RID: 2108
		public const int elementId_hat1Up = 32;

		// Token: 0x0400083D RID: 2109
		public const int elementId_hat1UpRight = 33;

		// Token: 0x0400083E RID: 2110
		public const int elementId_hat1Right = 34;

		// Token: 0x0400083F RID: 2111
		public const int elementId_hat1DownRight = 35;

		// Token: 0x04000840 RID: 2112
		public const int elementId_hat1Down = 36;

		// Token: 0x04000841 RID: 2113
		public const int elementId_hat1DownLeft = 37;

		// Token: 0x04000842 RID: 2114
		public const int elementId_hat1Left = 38;

		// Token: 0x04000843 RID: 2115
		public const int elementId_hat1UpLeft = 39;

		// Token: 0x04000844 RID: 2116
		public const int elementId_hat2Up = 40;

		// Token: 0x04000845 RID: 2117
		public const int elementId_hat2UpRight = 41;

		// Token: 0x04000846 RID: 2118
		public const int elementId_hat2Right = 42;

		// Token: 0x04000847 RID: 2119
		public const int elementId_hat2DownRight = 43;

		// Token: 0x04000848 RID: 2120
		public const int elementId_hat2Down = 44;

		// Token: 0x04000849 RID: 2121
		public const int elementId_hat2DownLeft = 45;

		// Token: 0x0400084A RID: 2122
		public const int elementId_hat2Left = 46;

		// Token: 0x0400084B RID: 2123
		public const int elementId_hat2UpLeft = 47;

		// Token: 0x0400084C RID: 2124
		public const int elementId_hat1 = 48;

		// Token: 0x0400084D RID: 2125
		public const int elementId_hat2 = 49;

		// Token: 0x0400084E RID: 2126
		public const int elementId_throttle1 = 52;

		// Token: 0x0400084F RID: 2127
		public const int elementId_throttle2 = 53;

		// Token: 0x04000850 RID: 2128
		public const int elementId_stick = 54;
	}
}
