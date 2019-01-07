using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200006C RID: 108
public class GClass6
{
	// Token: 0x0600155A RID: 5466 RVA: 0x0000B94C File Offset: 0x00009B4C
	private void method_0(uint uint_2)
	{
		this.uint_1 = uint_2;
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600155B RID: 5467 RVA: 0x0000B955 File Offset: 0x00009B55
	public bool Boolean_3
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.STAR_POWER) == GClass6.GEnum3.STAR_POWER;
		}
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x0000B964 File Offset: 0x00009B64
	public bool method_1()
	{
		return (this.genum3_0 & GClass6.GEnum3.CHORD) == GClass6.GEnum3.CHORD;
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x0000B971 File Offset: 0x00009B71
	public bool method_2()
	{
		return (int)(this.genum3_0 & ~(GClass6.GEnum3.STAR_POWER_END | GClass6.GEnum3.SOLO_BEGIN | GClass6.GEnum3.SOLO_END)) == -34;
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x0000B986 File Offset: 0x00009B86
	public bool method_3()
	{
		return (this.genum3_0 & (GClass6.GEnum3.CHORD | GClass6.GEnum3.DISJOINT | GClass6.GEnum3.SLAVE)) == GClass6.GEnum3.CHORD;
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x0000B993 File Offset: 0x00009B93
	public bool method_4()
	{
		return ((int)this.genum3_0 & -104) == -131;
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06001560 RID: 5472 RVA: 0x0000B9A8 File Offset: 0x00009BA8
	public bool Boolean_2
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.SLAVE) == GClass6.GEnum3.SLAVE;
		}
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x0000B9B5 File Offset: 0x00009BB5
	public uint method_5()
	{
		return this.uint_1;
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06001580 RID: 5504 RVA: 0x0000BA1B File Offset: 0x00009C1B
	// (set) Token: 0x06001562 RID: 5474 RVA: 0x0000B9BD File Offset: 0x00009BBD
	public float Single_0 { get; private set; }

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06001563 RID: 5475 RVA: 0x0000B9C6 File Offset: 0x00009BC6
	public bool Boolean_8
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.SOLO_BEGIN) == GClass6.GEnum3.SOLO_BEGIN;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06001564 RID: 5476 RVA: 0x0000B9D5 File Offset: 0x00009BD5
	public bool Boolean_6
	{
		get
		{
			return (this.genum14_0 & GClass19.GEnum14.Hopo) == GClass19.GEnum14.Hopo;
		}
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x0000B9E2 File Offset: 0x00009BE2
	public IEnumerable<GClass6> method_6()
	{
		GClass6.Class30 @class = new GClass6.Class30(36);
		@class.gclass6_1 = this;
		return @class;
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x0000B9BD File Offset: 0x00009BBD
	private void method_7(float float_3)
	{
		this.float_2 = float_3;
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06001567 RID: 5479 RVA: 0x0000B9F2 File Offset: 0x00009BF2
	public bool Boolean_4
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.STAR_POWER_END) == GClass6.GEnum3.STAR_POWER_END;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06001568 RID: 5480 RVA: 0x0000BA01 File Offset: 0x00009C01
	public bool Boolean_7
	{
		get
		{
			return (this.genum14_0 & GClass19.GEnum14.Tap) == GClass19.GEnum14.Tap;
		}
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x0000BA0E File Offset: 0x00009C0E
	public bool method_8()
	{
		return (this.genum14_0 & GClass19.GEnum14.Tap) == (GClass19.GEnum14)8;
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x0000BA1B File Offset: 0x00009C1B
	public float method_9()
	{
		return this.float_2;
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x0600156B RID: 5483 RVA: 0x0000B964 File Offset: 0x00009B64
	public bool Boolean_0
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.CHORD) == GClass6.GEnum3.CHORD;
		}
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x0000BA23 File Offset: 0x00009C23
	public bool method_10()
	{
		return (this.genum3_0 & GClass6.GEnum3.NONE) == GClass6.GEnum3.CHORD;
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x0000BA30 File Offset: 0x00009C30
	public IEnumerable<GClass6> method_11()
	{
		GClass6.Class30 @class = new GClass6.Class30(-15);
		@class.gclass6_1 = this;
		return @class;
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x000B1540 File Offset: 0x000AF740
	public GClass6(float float_3, float float_4, byte byte_1, GClass19.GEnum14 genum14_1, GClass6.GEnum3 genum3_1, uint uint_2, int int_1)
	{
		this.float_0 = float_3;
		this.float_1 = float_4;
		this.Single_0 = this.float_0 + this.float_1;
		this.byte_0 = byte_1;
		this.genum14_0 = genum14_1;
		this.genum3_0 = genum3_1;
		this.uint_0 = uint_2;
		this.int_0 = int_1;
		this.UInt32_0 = this.uint_0 + (uint)this.int_0;
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x0600156F RID: 5487 RVA: 0x0000BA40 File Offset: 0x00009C40
	public bool Boolean_9
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.SOLO_END) == GClass6.GEnum3.SOLO_END;
		}
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x0000BA55 File Offset: 0x00009C55
	public IEnumerable<GClass6> method_12()
	{
		GClass6.Class30 @class = new GClass6.Class30(-61);
		@class.gclass6_1 = this;
		return @class;
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06001571 RID: 5489 RVA: 0x0000BA65 File Offset: 0x00009C65
	public bool Boolean_5
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.EXTENDED_SUSTAIN) == GClass6.GEnum3.EXTENDED_SUSTAIN;
		}
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x0000BA72 File Offset: 0x00009C72
	public bool method_13()
	{
		return ((int)this.genum3_0 & -88) == -98;
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x000B15B0 File Offset: 0x000AF7B0
	public byte method_14()
	{
		byte b = 1;
		foreach (GClass6 gclass in this.method_6())
		{
			b |= gclass.byte_0;
		}
		return b;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x0000BA81 File Offset: 0x00009C81
	public bool method_15()
	{
		return (this.genum14_0 & GClass19.GEnum14.Tap) == (GClass19.GEnum14)6;
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06001582 RID: 5506 RVA: 0x0000B9B5 File Offset: 0x00009BB5
	// (set) Token: 0x06001575 RID: 5493 RVA: 0x0000B94C File Offset: 0x00009B4C
	public uint UInt32_0 { get; private set; }

	// Token: 0x06001576 RID: 5494 RVA: 0x0000BA8E File Offset: 0x00009C8E
	public bool method_16()
	{
		return (this.genum3_0 & GClass6.GEnum3.SLAVE) == GClass6.GEnum3.NONE;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06001577 RID: 5495 RVA: 0x0000BA9B File Offset: 0x00009C9B
	public IEnumerable<GClass6> IEnumerable_0
	{
		get
		{
			GClass6 gclass;
			for (gclass = this.gclass6_1; gclass != null; gclass = gclass.gclass6_1)
			{
				yield return gclass;
			}
			gclass = null;
			for (gclass = this.gclass6_0; gclass != null; gclass = gclass.gclass6_0)
			{
				yield return gclass;
			}
			gclass = null;
			yield return this;
			yield break;
		}
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x0000BAAB File Offset: 0x00009CAB
	public bool method_17()
	{
		return (this.genum3_0 & GClass6.GEnum3.EXTENDED_SUSTAIN) == GClass6.GEnum3.CHORD;
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06001579 RID: 5497 RVA: 0x000B1604 File Offset: 0x000AF804
	public byte Byte_0
	{
		get
		{
			byte b = 0;
			foreach (GClass6 gclass in this.IEnumerable_0)
			{
				b |= gclass.byte_0;
			}
			return b;
		}
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x0000B94C File Offset: 0x00009B4C
	private void method_18(uint uint_2)
	{
		this.uint_1 = uint_2;
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x0000BAB8 File Offset: 0x00009CB8
	public bool method_19()
	{
		return ((int)this.genum3_0 & -126) == -42;
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x0000B9B5 File Offset: 0x00009BB5
	public uint method_20()
	{
		return this.uint_1;
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x0000BA1B File Offset: 0x00009C1B
	public float method_21()
	{
		return this.float_2;
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x000B1658 File Offset: 0x000AF858
	public byte method_22()
	{
		byte b = 1;
		foreach (GClass6 gclass in this.method_12())
		{
			b |= gclass.byte_0;
		}
		return b;
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x0000BAC7 File Offset: 0x00009CC7
	public bool method_23()
	{
		return (this.genum3_0 & (GClass6.GEnum3.CHORD | GClass6.GEnum3.DISJOINT | GClass6.GEnum3.EXTENDED_SUSTAIN | GClass6.GEnum3.STAR_POWER_END)) == (GClass6.GEnum3.SLAVE | GClass6.GEnum3.STAR_POWER | GClass6.GEnum3.SOLO_BEGIN);
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x0000BAD6 File Offset: 0x00009CD6
	public bool method_24()
	{
		return (this.genum3_0 & (GClass6.GEnum3.CHORD | GClass6.GEnum3.DISJOINT)) == GClass6.GEnum3.EXTENDED_SUSTAIN;
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x0000B9BD File Offset: 0x00009BBD
	private void method_25(float float_3)
	{
		this.float_2 = float_3;
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06001584 RID: 5508 RVA: 0x0000BAE3 File Offset: 0x00009CE3
	public bool Boolean_1
	{
		get
		{
			return (this.genum3_0 & GClass6.GEnum3.DISJOINT) == GClass6.GEnum3.DISJOINT;
		}
	}

	// Token: 0x040002FB RID: 763
	public float float_0;

	// Token: 0x040002FC RID: 764
	public float float_1;

	// Token: 0x040002FD RID: 765
	[CompilerGenerated]
	private float float_2;

	// Token: 0x040002FE RID: 766
	public byte byte_0;

	// Token: 0x040002FF RID: 767
	public GClass6 gclass6_0;

	// Token: 0x04000300 RID: 768
	public GClass6 gclass6_1;

	// Token: 0x04000301 RID: 769
	public bool bool_0;

	// Token: 0x04000302 RID: 770
	public bool bool_1;

	// Token: 0x04000303 RID: 771
	public bool bool_2;

	// Token: 0x04000304 RID: 772
	public GClass19.GEnum14 genum14_0;

	// Token: 0x04000305 RID: 773
	public GClass6.GEnum3 genum3_0;

	// Token: 0x04000306 RID: 774
	public uint uint_0;

	// Token: 0x04000307 RID: 775
	public int int_0;

	// Token: 0x04000308 RID: 776
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x0200006D RID: 109
	[Flags]
	public enum GEnum3 : byte
	{
		// Token: 0x0400030A RID: 778
		NONE = 0,
		// Token: 0x0400030B RID: 779
		CHORD = 1,
		// Token: 0x0400030C RID: 780
		DISJOINT = 2,
		// Token: 0x0400030D RID: 781
		SLAVE = 4,
		// Token: 0x0400030E RID: 782
		EXTENDED_SUSTAIN = 8,
		// Token: 0x0400030F RID: 783
		STAR_POWER = 16,
		// Token: 0x04000310 RID: 784
		STAR_POWER_END = 32,
		// Token: 0x04000311 RID: 785
		SOLO_BEGIN = 64,
		// Token: 0x04000312 RID: 786
		SOLO_END = 128
	}

	// Token: 0x0200006E RID: 110
	[Flags]
	public enum GEnum4 : short
	{
		// Token: 0x04000314 RID: 788
		B1 = 1,
		// Token: 0x04000315 RID: 789
		B2 = 2,
		// Token: 0x04000316 RID: 790
		B3 = 4,
		// Token: 0x04000317 RID: 791
		W1 = 8,
		// Token: 0x04000318 RID: 792
		W2 = 16,
		// Token: 0x04000319 RID: 793
		W3 = 32,
		// Token: 0x0400031A RID: 794
		Open = 64
	}

	// Token: 0x0200006F RID: 111
	[Flags]
	public enum GEnum5
	{
		// Token: 0x0400031C RID: 796
		Lane1 = 1,
		// Token: 0x0400031D RID: 797
		Lane2 = 2,
		// Token: 0x0400031E RID: 798
		Lane3 = 4,
		// Token: 0x0400031F RID: 799
		OpenLane = 8
	}

	// Token: 0x02000070 RID: 112
	[Flags]
	public enum GEnum6
	{
		// Token: 0x04000321 RID: 801
		None = 1,
		// Token: 0x04000322 RID: 802
		AllStrums = 2,
		// Token: 0x04000323 RID: 803
		AllHOPOs = 4,
		// Token: 0x04000324 RID: 804
		AllTaps = 8,
		// Token: 0x04000325 RID: 805
		AllOpens = 16,
		// Token: 0x04000326 RID: 806
		MirrorMode = 32,
		// Token: 0x04000327 RID: 807
		Shuffle = 64,
		// Token: 0x04000328 RID: 808
		HOPOsToTaps = 128,
		// Token: 0x04000329 RID: 809
		LightsOut = 256,
		// Token: 0x0400032A RID: 810
		ModFull = 512,
		// Token: 0x0400032B RID: 811
		ModLite = 1024,
		// Token: 0x0400032C RID: 812
		ModPrep = 2048
	}
}
