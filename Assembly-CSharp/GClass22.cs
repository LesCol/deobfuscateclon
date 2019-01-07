using System;
using System.Text.RegularExpressions;

// Token: 0x020000D0 RID: 208
public class GClass22 : GClass21
{
	// Token: 0x0600286D RID: 10349 RVA: 0x000110DE File Offset: 0x0000F2DE
	public static bool smethod_63(string string_1)
	{
		return new Regex("\\d+ = E \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"").IsMatch(string_1);
	}

	// Token: 0x0600286E RID: 10350 RVA: 0x00010DE5 File Offset: 0x0000EFE5
	public static bool smethod_64(string string_1)
	{
		return new Regex("video").IsMatch(string_1);
	}

	// Token: 0x0600286F RID: 10351 RVA: 0x0001131D File Offset: 0x0000F51D
	public static bool smethod_65(string string_1)
	{
		return new Regex("song_display").IsMatch(string_1);
	}

	// Token: 0x06002870 RID: 10352 RVA: 0x0001132F File Offset: 0x0000F52F
	public static bool smethod_66(string string_1)
	{
		return new Regex("Controller Poll Rate").IsMatch(string_1);
	}

	// Token: 0x06002871 RID: 10353 RVA: 0x00011341 File Offset: 0x0000F541
	public static bool smethod_67(string string_1)
	{
		return new Regex("<color=#FFFF04FF>").IsMatch(string_1);
	}

	// Token: 0x06002872 RID: 10354 RVA: 0x00011353 File Offset: 0x0000F553
	public static bool smethod_68(string string_1)
	{
		return new Regex("Couldn't write badsongs.txt").IsMatch(string_1);
	}

	// Token: 0x06002873 RID: 10355 RVA: 0x00011138 File Offset: 0x0000F338
	public static bool smethod_69(string string_1)
	{
		return new Regex("%").IsMatch(string_1);
	}

	// Token: 0x06002874 RID: 10356 RVA: 0x00011365 File Offset: 0x0000F565
	public static bool smethod_70(string string_1)
	{
		return new Regex("\\d+ = E \"section [^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"").IsMatch(string_1);
	}

	// Token: 0x06002875 RID: 10357 RVA: 0x00011377 File Offset: 0x0000F577
	public static bool smethod_71(string string_1)
	{
		return new Regex("FULL COMBO").IsMatch(string_1);
	}

	// Token: 0x06002876 RID: 10358 RVA: 0x00010DAF File Offset: 0x0000EFAF
	public static bool smethod_72(string string_1)
	{
		return new Regex("").IsMatch(string_1);
	}

	// Token: 0x06002877 RID: 10359 RVA: 0x00011389 File Offset: 0x0000F589
	public static bool smethod_73(string string_1)
	{
		return new Regex("language").IsMatch(string_1);
	}

	// Token: 0x06002878 RID: 10360 RVA: 0x0001139B File Offset: 0x0000F59B
	public static bool smethod_74(string string_1)
	{
		return new Regex("Quit").IsMatch(string_1);
	}

	// Token: 0x06002879 RID: 10361 RVA: 0x000113AD File Offset: 0x0000F5AD
	public override int vmethod_23()
	{
		return (int)this.genum16_1;
	}

	// Token: 0x0600287A RID: 10362 RVA: 0x000113B5 File Offset: 0x0000F5B5
	public static bool smethod_75(string string_1)
	{
		return new Regex("volume").IsMatch(string_1);
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x000113C7 File Offset: 0x0000F5C7
	public static bool smethod_76(string string_1)
	{
		return new Regex("Song Speed").IsMatch(string_1);
	}

	// Token: 0x0600287C RID: 10364 RVA: 0x000113AD File Offset: 0x0000F5AD
	public override int vmethod_47()
	{
		return (int)this.genum16_1;
	}

	// Token: 0x0600287D RID: 10365 RVA: 0x000113D9 File Offset: 0x0000F5D9
	public static bool smethod_77(string string_1)
	{
		return new Regex("/Image Backgrounds").IsMatch(string_1);
	}

	// Token: 0x0600287E RID: 10366 RVA: 0x000113AD File Offset: 0x0000F5AD
	public virtual int vmethod_49()
	{
		return (int)this.genum16_1;
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x00010E2D File Offset: 0x0000F02D
	public static bool smethod_78(string string_1)
	{
		return new Regex("song").IsMatch(string_1);
	}

	// Token: 0x06002880 RID: 10368 RVA: 0x000113EB File Offset: 0x0000F5EB
	public static bool smethod_79(string string_1)
	{
		return new Regex("In Menus: Stats").IsMatch(string_1);
	}

	// Token: 0x06002881 RID: 10369 RVA: 0x000113AD File Offset: 0x0000F5AD
	public override int vmethod_39()
	{
		return (int)this.genum16_1;
	}

	// Token: 0x06002882 RID: 10370 RVA: 0x000113FD File Offset: 0x0000F5FD
	public GClass22(string string_1, uint uint_1) : base(string_1, uint_1)
	{
	}

	// Token: 0x06002883 RID: 10371 RVA: 0x000113AD File Offset: 0x0000F5AD
	public virtual int vmethod_50()
	{
		return (int)this.genum16_1;
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06002884 RID: 10372 RVA: 0x000113AD File Offset: 0x0000F5AD
	public override int Int32_1
	{
		get
		{
			return (int)this.genum16_1;
		}
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x0001140E File Offset: 0x0000F60E
	public GClass22(GClass22 gclass22_0) : base(gclass22_0.string_0, gclass22_0.uint_0)
	{
	}

	// Token: 0x0400062C RID: 1580
	private readonly GClass16.GEnum16 genum16_1 = GClass16.GEnum16.Section;
}
