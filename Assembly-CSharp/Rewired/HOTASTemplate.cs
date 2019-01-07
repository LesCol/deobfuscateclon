using System;

namespace Rewired
{
	// Token: 0x020000E7 RID: 231
	public sealed class HOTASTemplate : ControllerTemplate, IControllerTemplate, IHOTASTemplate
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x00011F42 File Offset: 0x00010142
		IControllerTemplateButton IHOTASTemplate.stickTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(3);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x00011D4A File Offset: 0x0000FF4A
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x00011D53 File Offset: 0x0000FF53
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x00011F4B File Offset: 0x0001014B
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(154);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x00011D5C File Offset: 0x0000FF5C
		IControllerTemplateButton IHOTASTemplate.stickButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x00011D65 File Offset: 0x0000FF65
		IControllerTemplateButton IHOTASTemplate.stickButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x00011D6E File Offset: 0x0000FF6E
		IControllerTemplateButton IHOTASTemplate.stickButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x00011D77 File Offset: 0x0000FF77
		IControllerTemplateButton IHOTASTemplate.stickButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x00011D81 File Offset: 0x0000FF81
		IControllerTemplateButton IHOTASTemplate.stickButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x00011E23 File Offset: 0x00010023
		IControllerTemplateButton IHOTASTemplate.stickButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(11);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x00011D95 File Offset: 0x0000FF95
		IControllerTemplateButton IHOTASTemplate.stickButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x00011E2D File Offset: 0x0001002D
		IControllerTemplateButton IHOTASTemplate.stickButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		IControllerTemplateButton IHOTASTemplate.stickButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x00011DB3 File Offset: 0x0000FFB3
		IControllerTemplateButton IHOTASTemplate.stickButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x00011E41 File Offset: 0x00010041
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x00011E4B File Offset: 0x0001004B
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x00011E55 File Offset: 0x00010055
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x00011E5F File Offset: 0x0001005F
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x00011E69 File Offset: 0x00010069
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x00011E73 File Offset: 0x00010073
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x00011E7D File Offset: 0x0001007D
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x00011E87 File Offset: 0x00010087
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x00011E91 File Offset: 0x00010091
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x00011E9B File Offset: 0x0001009B
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(27);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x00011F58 File Offset: 0x00010158
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(161);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x00011F65 File Offset: 0x00010165
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(162);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x00011EF5 File Offset: 0x000100F5
		IControllerTemplateButton IHOTASTemplate.mode1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(44);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x00011F72 File Offset: 0x00010172
		IControllerTemplateButton IHOTASTemplate.mode2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(45);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x00011F7C File Offset: 0x0001017C
		IControllerTemplateButton IHOTASTemplate.mode3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(46);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x00011F86 File Offset: 0x00010186
		IControllerTemplateButton IHOTASTemplate.throttleButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(50);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00011F90 File Offset: 0x00010190
		IControllerTemplateButton IHOTASTemplate.throttleButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(51);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x00011F9A File Offset: 0x0001019A
		IControllerTemplateButton IHOTASTemplate.throttleButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(52);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x00011FA4 File Offset: 0x000101A4
		IControllerTemplateButton IHOTASTemplate.throttleButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(53);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x00011FAE File Offset: 0x000101AE
		IControllerTemplateButton IHOTASTemplate.throttleButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(54);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x00011FB8 File Offset: 0x000101B8
		IControllerTemplateButton IHOTASTemplate.throttleButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(55);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x00011FC2 File Offset: 0x000101C2
		IControllerTemplateButton IHOTASTemplate.throttleButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(56);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x00011FCC File Offset: 0x000101CC
		IControllerTemplateButton IHOTASTemplate.throttleButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(57);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x00011FD6 File Offset: 0x000101D6
		IControllerTemplateButton IHOTASTemplate.throttleButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(58);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x00011FE0 File Offset: 0x000101E0
		IControllerTemplateButton IHOTASTemplate.throttleButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(59);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x00011FEA File Offset: 0x000101EA
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(60);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x00011FF4 File Offset: 0x000101F4
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(61);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x00011FFE File Offset: 0x000101FE
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(62);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x00012008 File Offset: 0x00010208
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(63);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x00012012 File Offset: 0x00010212
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(64);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x0001201C File Offset: 0x0001021C
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(65);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x00012026 File Offset: 0x00010226
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(66);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x00012030 File Offset: 0x00010230
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(67);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x0001203A File Offset: 0x0001023A
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(68);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x00012044 File Offset: 0x00010244
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(69);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x0001204E File Offset: 0x0001024E
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(132);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x0001205B File Offset: 0x0001025B
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(133);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x00012068 File Offset: 0x00010268
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(134);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x00012075 File Offset: 0x00010275
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(135);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x00012082 File Offset: 0x00010282
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(136);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x0001208F File Offset: 0x0001028F
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(70);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x00012099 File Offset: 0x00010299
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(71);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x000120A3 File Offset: 0x000102A3
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(72);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x000120AD File Offset: 0x000102AD
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(73);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000120B7 File Offset: 0x000102B7
		IControllerTemplateAxis IHOTASTemplate.throttleDial1
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(74);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x000120C1 File Offset: 0x000102C1
		IControllerTemplateAxis IHOTASTemplate.throttleDial2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(142);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000120CE File Offset: 0x000102CE
		IControllerTemplateAxis IHOTASTemplate.throttleDial3
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(143);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000120DB File Offset: 0x000102DB
		IControllerTemplateAxis IHOTASTemplate.throttleDial4
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(144);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x000120E8 File Offset: 0x000102E8
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(145);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000120F5 File Offset: 0x000102F5
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(146);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x00012102 File Offset: 0x00010302
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(147);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x0001210F File Offset: 0x0001030F
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(148);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x0001211C File Offset: 0x0001031C
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(149);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x00012129 File Offset: 0x00010329
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(150);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x00012136 File Offset: 0x00010336
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(151);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x00012143 File Offset: 0x00010343
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(152);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x00012150 File Offset: 0x00010350
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(153);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x0001215D File Offset: 0x0001035D
		IControllerTemplateAxis IHOTASTemplate.leftPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(168);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x0001216A File Offset: 0x0001036A
		IControllerTemplateAxis IHOTASTemplate.rightPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(169);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x00012177 File Offset: 0x00010377
		IControllerTemplateAxis IHOTASTemplate.slidePedals
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(170);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x00012184 File Offset: 0x00010384
		IControllerTemplateStick IHOTASTemplate.stick
		{
			get
			{
				return base.GetElement<IControllerTemplateStick>(171);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x00012191 File Offset: 0x00010391
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(172);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x0001219E File Offset: 0x0001039E
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(173);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000121AB File Offset: 0x000103AB
		IControllerTemplateHat IHOTASTemplate.stickHat1
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(174);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000121B8 File Offset: 0x000103B8
		IControllerTemplateHat IHOTASTemplate.stickHat2
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(175);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000121C5 File Offset: 0x000103C5
		IControllerTemplateHat IHOTASTemplate.stickHat3
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(176);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x000121D2 File Offset: 0x000103D2
		IControllerTemplateHat IHOTASTemplate.stickHat4
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(177);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000121DF File Offset: 0x000103DF
		IControllerTemplateThrottle IHOTASTemplate.throttle1
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(178);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000121EC File Offset: 0x000103EC
		IControllerTemplateThrottle IHOTASTemplate.throttle2
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(179);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x000121F9 File Offset: 0x000103F9
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(180);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x00012206 File Offset: 0x00010406
		IControllerTemplateHat IHOTASTemplate.throttleHat1
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(181);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x00012213 File Offset: 0x00010413
		IControllerTemplateHat IHOTASTemplate.throttleHat2
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(182);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x00012220 File Offset: 0x00010420
		IControllerTemplateHat IHOTASTemplate.throttleHat3
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(183);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x0001222D File Offset: 0x0001042D
		IControllerTemplateHat IHOTASTemplate.throttleHat4
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(184);
			}
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public HOTASTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x04000712 RID: 1810
		public static readonly Guid typeGuid = new Guid("061a00cf-d8c2-4f8d-8cb5-a15a010bc53e");

		// Token: 0x04000713 RID: 1811
		public const int elementId_stickX = 0;

		// Token: 0x04000714 RID: 1812
		public const int elementId_stickY = 1;

		// Token: 0x04000715 RID: 1813
		public const int elementId_stickRotate = 2;

		// Token: 0x04000716 RID: 1814
		public const int elementId_stickMiniStick1X = 78;

		// Token: 0x04000717 RID: 1815
		public const int elementId_stickMiniStick1Y = 79;

		// Token: 0x04000718 RID: 1816
		public const int elementId_stickMiniStick1Press = 80;

		// Token: 0x04000719 RID: 1817
		public const int elementId_stickMiniStick2X = 81;

		// Token: 0x0400071A RID: 1818
		public const int elementId_stickMiniStick2Y = 82;

		// Token: 0x0400071B RID: 1819
		public const int elementId_stickMiniStick2Press = 83;

		// Token: 0x0400071C RID: 1820
		public const int elementId_stickTrigger = 3;

		// Token: 0x0400071D RID: 1821
		public const int elementId_stickTriggerStage2 = 4;

		// Token: 0x0400071E RID: 1822
		public const int elementId_stickPinkyButton = 5;

		// Token: 0x0400071F RID: 1823
		public const int elementId_stickPinkyTrigger = 154;

		// Token: 0x04000720 RID: 1824
		public const int elementId_stickButton1 = 6;

		// Token: 0x04000721 RID: 1825
		public const int elementId_stickButton2 = 7;

		// Token: 0x04000722 RID: 1826
		public const int elementId_stickButton3 = 8;

		// Token: 0x04000723 RID: 1827
		public const int elementId_stickButton4 = 9;

		// Token: 0x04000724 RID: 1828
		public const int elementId_stickButton5 = 10;

		// Token: 0x04000725 RID: 1829
		public const int elementId_stickButton6 = 11;

		// Token: 0x04000726 RID: 1830
		public const int elementId_stickButton7 = 12;

		// Token: 0x04000727 RID: 1831
		public const int elementId_stickButton8 = 13;

		// Token: 0x04000728 RID: 1832
		public const int elementId_stickButton9 = 14;

		// Token: 0x04000729 RID: 1833
		public const int elementId_stickButton10 = 15;

		// Token: 0x0400072A RID: 1834
		public const int elementId_stickBaseButton1 = 18;

		// Token: 0x0400072B RID: 1835
		public const int elementId_stickBaseButton2 = 19;

		// Token: 0x0400072C RID: 1836
		public const int elementId_stickBaseButton3 = 20;

		// Token: 0x0400072D RID: 1837
		public const int elementId_stickBaseButton4 = 21;

		// Token: 0x0400072E RID: 1838
		public const int elementId_stickBaseButton5 = 22;

		// Token: 0x0400072F RID: 1839
		public const int elementId_stickBaseButton6 = 23;

		// Token: 0x04000730 RID: 1840
		public const int elementId_stickBaseButton7 = 24;

		// Token: 0x04000731 RID: 1841
		public const int elementId_stickBaseButton8 = 25;

		// Token: 0x04000732 RID: 1842
		public const int elementId_stickBaseButton9 = 26;

		// Token: 0x04000733 RID: 1843
		public const int elementId_stickBaseButton10 = 27;

		// Token: 0x04000734 RID: 1844
		public const int elementId_stickBaseButton11 = 161;

		// Token: 0x04000735 RID: 1845
		public const int elementId_stickBaseButton12 = 162;

		// Token: 0x04000736 RID: 1846
		public const int elementId_stickHat1Up = 28;

		// Token: 0x04000737 RID: 1847
		public const int elementId_stickHat1UpRight = 29;

		// Token: 0x04000738 RID: 1848
		public const int elementId_stickHat1Right = 30;

		// Token: 0x04000739 RID: 1849
		public const int elementId_stickHat1DownRight = 31;

		// Token: 0x0400073A RID: 1850
		public const int elementId_stickHat1Down = 32;

		// Token: 0x0400073B RID: 1851
		public const int elementId_stickHat1DownLeft = 33;

		// Token: 0x0400073C RID: 1852
		public const int elementId_stickHat1Left = 34;

		// Token: 0x0400073D RID: 1853
		public const int elementId_stickHat1Up_Left = 35;

		// Token: 0x0400073E RID: 1854
		public const int elementId_stickHat2Up = 36;

		// Token: 0x0400073F RID: 1855
		public const int elementId_stickHat2Up_right = 37;

		// Token: 0x04000740 RID: 1856
		public const int elementId_stickHat2Right = 38;

		// Token: 0x04000741 RID: 1857
		public const int elementId_stickHat2Down_Right = 39;

		// Token: 0x04000742 RID: 1858
		public const int elementId_stickHat2Down = 40;

		// Token: 0x04000743 RID: 1859
		public const int elementId_stickHat2Down_Left = 41;

		// Token: 0x04000744 RID: 1860
		public const int elementId_stickHat2Left = 42;

		// Token: 0x04000745 RID: 1861
		public const int elementId_stickHat2Up_Left = 43;

		// Token: 0x04000746 RID: 1862
		public const int elementId_stickHat3Up = 84;

		// Token: 0x04000747 RID: 1863
		public const int elementId_stickHat3Up_Right = 85;

		// Token: 0x04000748 RID: 1864
		public const int elementId_stickHat3Right = 86;

		// Token: 0x04000749 RID: 1865
		public const int elementId_stickHat3Down_Right = 87;

		// Token: 0x0400074A RID: 1866
		public const int elementId_stickHat3Down = 88;

		// Token: 0x0400074B RID: 1867
		public const int elementId_stickHat3Down_Left = 89;

		// Token: 0x0400074C RID: 1868
		public const int elementId_stickHat3Left = 90;

		// Token: 0x0400074D RID: 1869
		public const int elementId_stickHat3Up_Left = 91;

		// Token: 0x0400074E RID: 1870
		public const int elementId_stickHat4Up = 92;

		// Token: 0x0400074F RID: 1871
		public const int elementId_stickHat4Up_Right = 93;

		// Token: 0x04000750 RID: 1872
		public const int elementId_stickHat4Right = 94;

		// Token: 0x04000751 RID: 1873
		public const int elementId_stickHat4Down_Right = 95;

		// Token: 0x04000752 RID: 1874
		public const int elementId_stickHat4Down = 96;

		// Token: 0x04000753 RID: 1875
		public const int elementId_stickHat4Down_Left = 97;

		// Token: 0x04000754 RID: 1876
		public const int elementId_stickHat4Left = 98;

		// Token: 0x04000755 RID: 1877
		public const int elementId_stickHat4Up_Left = 99;

		// Token: 0x04000756 RID: 1878
		public const int elementId_mode1 = 44;

		// Token: 0x04000757 RID: 1879
		public const int elementId_mode2 = 45;

		// Token: 0x04000758 RID: 1880
		public const int elementId_mode3 = 46;

		// Token: 0x04000759 RID: 1881
		public const int elementId_throttle1Axis = 49;

		// Token: 0x0400075A RID: 1882
		public const int elementId_throttle2Axis = 155;

		// Token: 0x0400075B RID: 1883
		public const int elementId_throttle1MinDetent = 166;

		// Token: 0x0400075C RID: 1884
		public const int elementId_throttle2MinDetent = 167;

		// Token: 0x0400075D RID: 1885
		public const int elementId_throttleButton1 = 50;

		// Token: 0x0400075E RID: 1886
		public const int elementId_throttleButton2 = 51;

		// Token: 0x0400075F RID: 1887
		public const int elementId_throttleButton3 = 52;

		// Token: 0x04000760 RID: 1888
		public const int elementId_throttleButton4 = 53;

		// Token: 0x04000761 RID: 1889
		public const int elementId_throttleButton5 = 54;

		// Token: 0x04000762 RID: 1890
		public const int elementId_throttleButton6 = 55;

		// Token: 0x04000763 RID: 1891
		public const int elementId_throttleButton7 = 56;

		// Token: 0x04000764 RID: 1892
		public const int elementId_throttleButton8 = 57;

		// Token: 0x04000765 RID: 1893
		public const int elementId_throttleButton9 = 58;

		// Token: 0x04000766 RID: 1894
		public const int elementId_throttleButton10 = 59;

		// Token: 0x04000767 RID: 1895
		public const int elementId_throttleBaseButton1 = 60;

		// Token: 0x04000768 RID: 1896
		public const int elementId_throttleBaseButton2 = 61;

		// Token: 0x04000769 RID: 1897
		public const int elementId_throttleBaseButton3 = 62;

		// Token: 0x0400076A RID: 1898
		public const int elementId_throttleBaseButton4 = 63;

		// Token: 0x0400076B RID: 1899
		public const int elementId_throttleBaseButton5 = 64;

		// Token: 0x0400076C RID: 1900
		public const int elementId_throttleBaseButton6 = 65;

		// Token: 0x0400076D RID: 1901
		public const int elementId_throttleBaseButton7 = 66;

		// Token: 0x0400076E RID: 1902
		public const int elementId_throttleBaseButton8 = 67;

		// Token: 0x0400076F RID: 1903
		public const int elementId_throttleBaseButton9 = 68;

		// Token: 0x04000770 RID: 1904
		public const int elementId_throttleBaseButton10 = 69;

		// Token: 0x04000771 RID: 1905
		public const int elementId_throttleBaseButton11 = 132;

		// Token: 0x04000772 RID: 1906
		public const int elementId_throttleBaseButton12 = 133;

		// Token: 0x04000773 RID: 1907
		public const int elementId_throttleBaseButton13 = 134;

		// Token: 0x04000774 RID: 1908
		public const int elementId_throttleBaseButton14 = 135;

		// Token: 0x04000775 RID: 1909
		public const int elementId_throttleBaseButton15 = 136;

		// Token: 0x04000776 RID: 1910
		public const int elementId_throttleSlider1 = 70;

		// Token: 0x04000777 RID: 1911
		public const int elementId_throttleSlider2 = 71;

		// Token: 0x04000778 RID: 1912
		public const int elementId_throttleSlider3 = 72;

		// Token: 0x04000779 RID: 1913
		public const int elementId_throttleSlider4 = 73;

		// Token: 0x0400077A RID: 1914
		public const int elementId_throttleDial1 = 74;

		// Token: 0x0400077B RID: 1915
		public const int elementId_throttleDial2 = 142;

		// Token: 0x0400077C RID: 1916
		public const int elementId_throttleDial3 = 143;

		// Token: 0x0400077D RID: 1917
		public const int elementId_throttleDial4 = 144;

		// Token: 0x0400077E RID: 1918
		public const int elementId_throttleMiniStickX = 75;

		// Token: 0x0400077F RID: 1919
		public const int elementId_throttleMiniStickY = 76;

		// Token: 0x04000780 RID: 1920
		public const int elementId_throttleMiniStickPress = 77;

		// Token: 0x04000781 RID: 1921
		public const int elementId_throttleWheel1Forward = 145;

		// Token: 0x04000782 RID: 1922
		public const int elementId_throttleWheel1Back = 146;

		// Token: 0x04000783 RID: 1923
		public const int elementId_throttleWheel1Press = 147;

		// Token: 0x04000784 RID: 1924
		public const int elementId_throttleWheel2Forward = 148;

		// Token: 0x04000785 RID: 1925
		public const int elementId_throttleWheel2Back = 149;

		// Token: 0x04000786 RID: 1926
		public const int elementId_throttleWheel2Press = 150;

		// Token: 0x04000787 RID: 1927
		public const int elementId_throttleWheel3Forward = 151;

		// Token: 0x04000788 RID: 1928
		public const int elementId_throttleWheel3Back = 152;

		// Token: 0x04000789 RID: 1929
		public const int elementId_throttleWheel3Press = 153;

		// Token: 0x0400078A RID: 1930
		public const int elementId_throttleHat1Up = 100;

		// Token: 0x0400078B RID: 1931
		public const int elementId_throttleHat1Up_Right = 101;

		// Token: 0x0400078C RID: 1932
		public const int elementId_throttleHat1Right = 102;

		// Token: 0x0400078D RID: 1933
		public const int elementId_throttleHat1Down_Right = 103;

		// Token: 0x0400078E RID: 1934
		public const int elementId_throttleHat1Down = 104;

		// Token: 0x0400078F RID: 1935
		public const int elementId_throttleHat1Down_Left = 105;

		// Token: 0x04000790 RID: 1936
		public const int elementId_throttleHat1Left = 106;

		// Token: 0x04000791 RID: 1937
		public const int elementId_throttleHat1Up_Left = 107;

		// Token: 0x04000792 RID: 1938
		public const int elementId_throttleHat2Up = 108;

		// Token: 0x04000793 RID: 1939
		public const int elementId_throttleHat2Up_Right = 109;

		// Token: 0x04000794 RID: 1940
		public const int elementId_throttleHat2Right = 110;

		// Token: 0x04000795 RID: 1941
		public const int elementId_throttleHat2Down_Right = 111;

		// Token: 0x04000796 RID: 1942
		public const int elementId_throttleHat2Down = 112;

		// Token: 0x04000797 RID: 1943
		public const int elementId_throttleHat2Down_Left = 113;

		// Token: 0x04000798 RID: 1944
		public const int elementId_throttleHat2Left = 114;

		// Token: 0x04000799 RID: 1945
		public const int elementId_throttleHat2Up_Left = 115;

		// Token: 0x0400079A RID: 1946
		public const int elementId_throttleHat3Up = 116;

		// Token: 0x0400079B RID: 1947
		public const int elementId_throttleHat3Up_Right = 117;

		// Token: 0x0400079C RID: 1948
		public const int elementId_throttleHat3Right = 118;

		// Token: 0x0400079D RID: 1949
		public const int elementId_throttleHat3Down_Right = 119;

		// Token: 0x0400079E RID: 1950
		public const int elementId_throttleHat3Down = 120;

		// Token: 0x0400079F RID: 1951
		public const int elementId_throttleHat3Down_Left = 121;

		// Token: 0x040007A0 RID: 1952
		public const int elementId_throttleHat3Left = 122;

		// Token: 0x040007A1 RID: 1953
		public const int elementId_throttleHat3Up_Left = 123;

		// Token: 0x040007A2 RID: 1954
		public const int elementId_throttleHat4Up = 124;

		// Token: 0x040007A3 RID: 1955
		public const int elementId_throttleHat4Up_Right = 125;

		// Token: 0x040007A4 RID: 1956
		public const int elementId_throttleHat4Right = 126;

		// Token: 0x040007A5 RID: 1957
		public const int elementId_throttleHat4Down_Right = 127;

		// Token: 0x040007A6 RID: 1958
		public const int elementId_throttleHat4Down = 128;

		// Token: 0x040007A7 RID: 1959
		public const int elementId_throttleHat4Down_Left = 129;

		// Token: 0x040007A8 RID: 1960
		public const int elementId_throttleHat4Left = 130;

		// Token: 0x040007A9 RID: 1961
		public const int elementId_throttleHat4Up_Left = 131;

		// Token: 0x040007AA RID: 1962
		public const int elementId_leftPedal = 168;

		// Token: 0x040007AB RID: 1963
		public const int elementId_rightPedal = 169;

		// Token: 0x040007AC RID: 1964
		public const int elementId_slidePedals = 170;

		// Token: 0x040007AD RID: 1965
		public const int elementId_stick = 171;

		// Token: 0x040007AE RID: 1966
		public const int elementId_stickMiniStick1 = 172;

		// Token: 0x040007AF RID: 1967
		public const int elementId_stickMiniStick2 = 173;

		// Token: 0x040007B0 RID: 1968
		public const int elementId_stickHat1 = 174;

		// Token: 0x040007B1 RID: 1969
		public const int elementId_stickHat2 = 175;

		// Token: 0x040007B2 RID: 1970
		public const int elementId_stickHat3 = 176;

		// Token: 0x040007B3 RID: 1971
		public const int elementId_stickHat4 = 177;

		// Token: 0x040007B4 RID: 1972
		public const int elementId_throttle1 = 178;

		// Token: 0x040007B5 RID: 1973
		public const int elementId_throttle2 = 179;

		// Token: 0x040007B6 RID: 1974
		public const int elementId_throttleMiniStick = 180;

		// Token: 0x040007B7 RID: 1975
		public const int elementId_throttleHat1 = 181;

		// Token: 0x040007B8 RID: 1976
		public const int elementId_throttleHat2 = 182;

		// Token: 0x040007B9 RID: 1977
		public const int elementId_throttleHat3 = 183;

		// Token: 0x040007BA RID: 1978
		public const int elementId_throttleHat4 = 184;
	}
}
