using System;

namespace Rewired
{
	// Token: 0x020000E8 RID: 232
	public sealed class FlightYokeTemplate : ControllerTemplate, IControllerTemplate, IFlightYokeTemplate
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00011FE0 File Offset: 0x000101E0
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(59);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x00011FEA File Offset: 0x000101EA
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(60);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x00011D65 File Offset: 0x0000FF65
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x00011D6E File Offset: 0x0000FF6E
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x00011D77 File Offset: 0x0000FF77
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x00011D81 File Offset: 0x0000FF81
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x00011E23 File Offset: 0x00010023
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(11);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x00011D95 File Offset: 0x0000FF95
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x00011E2D File Offset: 0x0001002D
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x00011DB3 File Offset: 0x0000FFB3
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x00011DBD File Offset: 0x0000FFBD
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x00011E37 File Offset: 0x00010037
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(17);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x00011E41 File Offset: 0x00010041
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x00011E4B File Offset: 0x0001004B
		IControllerTemplateButton IFlightYokeTemplate.centerButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x00011E55 File Offset: 0x00010055
		IControllerTemplateButton IFlightYokeTemplate.centerButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x00011E5F File Offset: 0x0001005F
		IControllerTemplateButton IFlightYokeTemplate.centerButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x00011E69 File Offset: 0x00010069
		IControllerTemplateButton IFlightYokeTemplate.centerButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x00011E73 File Offset: 0x00010073
		IControllerTemplateButton IFlightYokeTemplate.centerButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x00011E7D File Offset: 0x0001007D
		IControllerTemplateButton IFlightYokeTemplate.centerButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x00011E87 File Offset: 0x00010087
		IControllerTemplateButton IFlightYokeTemplate.centerButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x00011E91 File Offset: 0x00010091
		IControllerTemplateButton IFlightYokeTemplate.centerButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x00011FA4 File Offset: 0x000101A4
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(53);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x00011FAE File Offset: 0x000101AE
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(54);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x00011FB8 File Offset: 0x000101B8
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(55);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x00011FC2 File Offset: 0x000101C2
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(56);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x00011FCC File Offset: 0x000101CC
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(57);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x00011FD6 File Offset: 0x000101D6
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(58);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x00011F1D File Offset: 0x0001011D
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(43);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x00011EF5 File Offset: 0x000100F5
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(44);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x00011F72 File Offset: 0x00010172
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(45);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x00011F7C File Offset: 0x0001017C
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(46);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06002C29 RID: 11305 RVA: 0x0001224B File Offset: 0x0001044B
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(47);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x00012255 File Offset: 0x00010455
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(48);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x0001225F File Offset: 0x0001045F
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(49);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x00011F86 File Offset: 0x00010186
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(50);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x00011F90 File Offset: 0x00010190
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(51);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x00011F9A File Offset: 0x0001019A
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(52);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x00011FF4 File Offset: 0x000101F4
		IControllerTemplateButton IFlightYokeTemplate.mode1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(61);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x00011FFE File Offset: 0x000101FE
		IControllerTemplateButton IFlightYokeTemplate.mode2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(62);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x00012008 File Offset: 0x00010208
		IControllerTemplateButton IFlightYokeTemplate.mode3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(63);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x00012269 File Offset: 0x00010469
		IControllerTemplateYoke IFlightYokeTemplate.yoke
		{
			get
			{
				return base.GetElement<IControllerTemplateYoke>(69);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x00012273 File Offset: 0x00010473
		IControllerTemplateThrottle IFlightYokeTemplate.lever1
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(70);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x0001227D File Offset: 0x0001047D
		IControllerTemplateThrottle IFlightYokeTemplate.lever2
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(71);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x00012287 File Offset: 0x00010487
		IControllerTemplateThrottle IFlightYokeTemplate.lever3
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(72);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x00012291 File Offset: 0x00010491
		IControllerTemplateThrottle IFlightYokeTemplate.lever4
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(73);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x0001229B File Offset: 0x0001049B
		IControllerTemplateThrottle IFlightYokeTemplate.lever5
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(74);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x000122A5 File Offset: 0x000104A5
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(75);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000122AF File Offset: 0x000104AF
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(76);
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public FlightYokeTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x040007BB RID: 1979
		public static readonly Guid typeGuid = new Guid("f311fa16-0ccc-41c0-ac4b-50f7100bb8ff");

		// Token: 0x040007BC RID: 1980
		public const int elementId_rotateYoke = 0;

		// Token: 0x040007BD RID: 1981
		public const int elementId_yokeZ = 1;

		// Token: 0x040007BE RID: 1982
		public const int elementId_leftPaddle = 59;

		// Token: 0x040007BF RID: 1983
		public const int elementId_rightPaddle = 60;

		// Token: 0x040007C0 RID: 1984
		public const int elementId_lever1Axis = 2;

		// Token: 0x040007C1 RID: 1985
		public const int elementId_lever1MinDetent = 64;

		// Token: 0x040007C2 RID: 1986
		public const int elementId_lever2Axis = 3;

		// Token: 0x040007C3 RID: 1987
		public const int elementId_lever2MinDetent = 65;

		// Token: 0x040007C4 RID: 1988
		public const int elementId_lever3Axis = 4;

		// Token: 0x040007C5 RID: 1989
		public const int elementId_lever3MinDetent = 66;

		// Token: 0x040007C6 RID: 1990
		public const int elementId_lever4Axis = 5;

		// Token: 0x040007C7 RID: 1991
		public const int elementId_lever4MinDetent = 67;

		// Token: 0x040007C8 RID: 1992
		public const int elementId_lever5Axis = 6;

		// Token: 0x040007C9 RID: 1993
		public const int elementId_lever5MinDetent = 68;

		// Token: 0x040007CA RID: 1994
		public const int elementId_leftGripButton1 = 7;

		// Token: 0x040007CB RID: 1995
		public const int elementId_leftGripButton2 = 8;

		// Token: 0x040007CC RID: 1996
		public const int elementId_leftGripButton3 = 9;

		// Token: 0x040007CD RID: 1997
		public const int elementId_leftGripButton4 = 10;

		// Token: 0x040007CE RID: 1998
		public const int elementId_leftGripButton5 = 11;

		// Token: 0x040007CF RID: 1999
		public const int elementId_leftGripButton6 = 12;

		// Token: 0x040007D0 RID: 2000
		public const int elementId_rightGripButton1 = 13;

		// Token: 0x040007D1 RID: 2001
		public const int elementId_rightGripButton2 = 14;

		// Token: 0x040007D2 RID: 2002
		public const int elementId_rightGripButton3 = 15;

		// Token: 0x040007D3 RID: 2003
		public const int elementId_rightGripButton4 = 16;

		// Token: 0x040007D4 RID: 2004
		public const int elementId_rightGripButton5 = 17;

		// Token: 0x040007D5 RID: 2005
		public const int elementId_rightGripButton6 = 18;

		// Token: 0x040007D6 RID: 2006
		public const int elementId_centerButton1 = 19;

		// Token: 0x040007D7 RID: 2007
		public const int elementId_centerButton2 = 20;

		// Token: 0x040007D8 RID: 2008
		public const int elementId_centerButton3 = 21;

		// Token: 0x040007D9 RID: 2009
		public const int elementId_centerButton4 = 22;

		// Token: 0x040007DA RID: 2010
		public const int elementId_centerButton5 = 23;

		// Token: 0x040007DB RID: 2011
		public const int elementId_centerButton6 = 24;

		// Token: 0x040007DC RID: 2012
		public const int elementId_centerButton7 = 25;

		// Token: 0x040007DD RID: 2013
		public const int elementId_centerButton8 = 26;

		// Token: 0x040007DE RID: 2014
		public const int elementId_wheel1Up = 53;

		// Token: 0x040007DF RID: 2015
		public const int elementId_wheel1Down = 54;

		// Token: 0x040007E0 RID: 2016
		public const int elementId_wheel1Press = 55;

		// Token: 0x040007E1 RID: 2017
		public const int elementId_wheel2Up = 56;

		// Token: 0x040007E2 RID: 2018
		public const int elementId_wheel2Down = 57;

		// Token: 0x040007E3 RID: 2019
		public const int elementId_wheel2Press = 58;

		// Token: 0x040007E4 RID: 2020
		public const int elementId_leftGripHatUp = 27;

		// Token: 0x040007E5 RID: 2021
		public const int elementId_leftGripHatUpRight = 28;

		// Token: 0x040007E6 RID: 2022
		public const int elementId_leftGripHatRight = 29;

		// Token: 0x040007E7 RID: 2023
		public const int elementId_leftGripHatDownRight = 30;

		// Token: 0x040007E8 RID: 2024
		public const int elementId_leftGripHatDown = 31;

		// Token: 0x040007E9 RID: 2025
		public const int elementId_leftGripHatDownLeft = 32;

		// Token: 0x040007EA RID: 2026
		public const int elementId_leftGripHatLeft = 33;

		// Token: 0x040007EB RID: 2027
		public const int elementId_leftGripHatUpLeft = 34;

		// Token: 0x040007EC RID: 2028
		public const int elementId_rightGripHatUp = 35;

		// Token: 0x040007ED RID: 2029
		public const int elementId_rightGripHatUpRight = 36;

		// Token: 0x040007EE RID: 2030
		public const int elementId_rightGripHatRight = 37;

		// Token: 0x040007EF RID: 2031
		public const int elementId_rightGripHatDownRight = 38;

		// Token: 0x040007F0 RID: 2032
		public const int elementId_rightGripHatDown = 39;

		// Token: 0x040007F1 RID: 2033
		public const int elementId_rightGripHatDownLeft = 40;

		// Token: 0x040007F2 RID: 2034
		public const int elementId_rightGripHatLeft = 41;

		// Token: 0x040007F3 RID: 2035
		public const int elementId_rightGripHatUpLeft = 42;

		// Token: 0x040007F4 RID: 2036
		public const int elementId_consoleButton1 = 43;

		// Token: 0x040007F5 RID: 2037
		public const int elementId_consoleButton2 = 44;

		// Token: 0x040007F6 RID: 2038
		public const int elementId_consoleButton3 = 45;

		// Token: 0x040007F7 RID: 2039
		public const int elementId_consoleButton4 = 46;

		// Token: 0x040007F8 RID: 2040
		public const int elementId_consoleButton5 = 47;

		// Token: 0x040007F9 RID: 2041
		public const int elementId_consoleButton6 = 48;

		// Token: 0x040007FA RID: 2042
		public const int elementId_consoleButton7 = 49;

		// Token: 0x040007FB RID: 2043
		public const int elementId_consoleButton8 = 50;

		// Token: 0x040007FC RID: 2044
		public const int elementId_consoleButton9 = 51;

		// Token: 0x040007FD RID: 2045
		public const int elementId_consoleButton10 = 52;

		// Token: 0x040007FE RID: 2046
		public const int elementId_mode1 = 61;

		// Token: 0x040007FF RID: 2047
		public const int elementId_mode2 = 62;

		// Token: 0x04000800 RID: 2048
		public const int elementId_mode3 = 63;

		// Token: 0x04000801 RID: 2049
		public const int elementId_yoke = 69;

		// Token: 0x04000802 RID: 2050
		public const int elementId_lever1 = 70;

		// Token: 0x04000803 RID: 2051
		public const int elementId_lever2 = 71;

		// Token: 0x04000804 RID: 2052
		public const int elementId_lever3 = 72;

		// Token: 0x04000805 RID: 2053
		public const int elementId_lever4 = 73;

		// Token: 0x04000806 RID: 2054
		public const int elementId_lever5 = 74;

		// Token: 0x04000807 RID: 2055
		public const int elementId_leftGripHat = 75;

		// Token: 0x04000808 RID: 2056
		public const int elementId_rightGripHat = 76;
	}
}
