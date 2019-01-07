using System;
using UnityEngine;

// Token: 0x0200003F RID: 63
public class SectionBrowser : BaseMenu
{
	// Token: 0x06000B09 RID: 2825 RVA: 0x0005CB0C File Offset: 0x0005AD0C
	public void method_44(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_43(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = false;
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x0005CB5C File Offset: 0x0005AD5C
	public void method_45()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_43(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x0005CBAC File Offset: 0x0005ADAC
	public void method_46()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_43(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = true;
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0005CBFC File Offset: 0x0005ADFC
	public virtual void vmethod_81()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 1;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num += 0;
		}
		this.songSelect.vmethod_23(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0005CC70 File Offset: 0x0005AE70
	public virtual void vmethod_82()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num++;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x00005E78 File Offset: 0x00004078
	public virtual void vmethod_83()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_83(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x0005CCE4 File Offset: 0x0005AEE4
	public virtual void vmethod_84()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num += 0;
		}
		this.songSelect.vmethod_25(num + 0);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00005EA0 File Offset: 0x000040A0
	public virtual void vmethod_85()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x0005CD58 File Offset: 0x0005AF58
	public void method_47(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = false;
		this.vmethod_3();
		base.method_43(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = true;
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x0005CDA8 File Offset: 0x0005AFA8
	public void method_48(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00005EC8 File Offset: 0x000040C8
	public virtual void vmethod_86()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0005CDF8 File Offset: 0x0005AFF8
	public virtual void vmethod_87()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num += 0;
		}
		this.songSelect.vmethod_25(num + 0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x0005CDA8 File Offset: 0x0005AFA8
	public void method_49(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x0005CE6C File Offset: 0x0005B06C
	public virtual void vmethod_88()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 1;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num += 0;
		}
		this.songSelect.vmethod_23(num + 1);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x0005CEE0 File Offset: 0x0005B0E0
	public virtual void vmethod_89()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 1;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num++;
		}
		this.songSelect.vmethod_25(num + 0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x0005CF54 File Offset: 0x0005B154
	public void method_50(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
	public virtual void vmethod_90()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 1;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num += 0;
		}
		this.songSelect.vmethod_25(num + 0);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x0005D018 File Offset: 0x0005B218
	public virtual void vmethod_91()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 1;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num += 0;
		}
		this.songSelect.vmethod_23(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00005EF0 File Offset: 0x000040F0
	public virtual void vmethod_92()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.method_39());
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0005D08C File Offset: 0x0005B28C
	public virtual void vmethod_93()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 1;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num++;
		}
		this.songSelect.vmethod_23(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x0005D100 File Offset: 0x0005B300
	public void method_51(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = true;
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0005D150 File Offset: 0x0005B350
	public void method_52()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = false;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x0005D1A0 File Offset: 0x0005B3A0
	public void method_53()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_43(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x0005D1F0 File Offset: 0x0005B3F0
	public void method_54(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = true;
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0005D240 File Offset: 0x0005B440
	public virtual void vmethod_94()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num += 0;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x00005EA0 File Offset: 0x000040A0
	public virtual void vmethod_95()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x00005EA0 File Offset: 0x000040A0
	public virtual void vmethod_96()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x0005D2B4 File Offset: 0x0005B4B4
	public virtual void vmethod_97()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num++;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00005F18 File Offset: 0x00004118
	public virtual void vmethod_98()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_83(base.String_0);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0005CB0C File Offset: 0x0005AD0C
	public void method_55(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_43(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = false;
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0005D328 File Offset: 0x0005B528
	public void method_56(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_43(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x0005D378 File Offset: 0x0005B578
	public virtual void vmethod_99()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num++;
		}
		this.songSelect.vmethod_25(num + 0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x00005EC8 File Offset: 0x000040C8
	public virtual void vmethod_100()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00005F40 File Offset: 0x00004140
	public virtual void vmethod_101()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.method_39());
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0005D3EC File Offset: 0x0005B5EC
	public void method_57(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = true;
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x0005D43C File Offset: 0x0005B63C
	public void method_58(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00005F68 File Offset: 0x00004168
	public override void vmethod_29()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_83(base.method_39());
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00005EC8 File Offset: 0x000040C8
	public override void vmethod_54()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x0005D48C File Offset: 0x0005B68C
	public void method_59()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = false;
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x0005D4DC File Offset: 0x0005B6DC
	public void method_60()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x0005D52C File Offset: 0x0005B72C
	public virtual void vmethod_102()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num += 0;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0005D5A0 File Offset: 0x0005B7A0
	public void method_61()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0005D5F0 File Offset: 0x0005B7F0
	public virtual void vmethod_103()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num++;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x0005D48C File Offset: 0x0005B68C
	public void method_62()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = false;
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x0005D664 File Offset: 0x0005B864
	public void method_63()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_43(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x0005D018 File Offset: 0x0005B218
	public virtual void vmethod_104()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 1;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num += 0;
		}
		this.songSelect.vmethod_23(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x0005D6B4 File Offset: 0x0005B8B4
	public void method_64()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x0005CB5C File Offset: 0x0005AD5C
	public void method_65()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_43(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x00005EF0 File Offset: 0x000040F0
	public virtual void vmethod_105()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.method_39());
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x00005E78 File Offset: 0x00004078
	public virtual void vmethod_106()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_83(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00005EF0 File Offset: 0x000040F0
	public virtual void vmethod_107()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.method_39());
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0005D4DC File Offset: 0x0005B6DC
	public void method_66()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x0005D704 File Offset: 0x0005B904
	public void method_67()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_43(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x0005D754 File Offset: 0x0005B954
	public void method_68()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = true;
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0005D7A4 File Offset: 0x0005B9A4
	public virtual void vmethod_108()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num++;
		}
		this.songSelect.vmethod_23(num + 1);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x0005D818 File Offset: 0x0005BA18
	public virtual void vmethod_109()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num++;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0005D88C File Offset: 0x0005BA8C
	public void method_69(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = false;
		this.vmethod_3();
		base.method_0(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x0005D8DC File Offset: 0x0005BADC
	public void method_70()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = true;
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x0005D52C File Offset: 0x0005B72C
	public virtual void vmethod_110()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num += 0;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0005CC70 File Offset: 0x0005AE70
	public virtual void vmethod_111()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.method_39())))
		{
			num++;
		}
		this.songSelect.vmethod_25(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0005D150 File Offset: 0x0005B350
	public void method_71()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = false;
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x0005D92C File Offset: 0x0005BB2C
	public void method_72(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_3();
		base.method_43(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = true;
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x0005D97C File Offset: 0x0005BB7C
	public override void vmethod_51()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num++;
		}
		this.songSelect.vmethod_23(num + 1);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x00005E78 File Offset: 0x00004078
	public override void vmethod_20()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_83(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00005F90 File Offset: 0x00004190
	public virtual void vmethod_112()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_83(base.method_39());
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00005EC8 File Offset: 0x000040C8
	public virtual void vmethod_113()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00005EC8 File Offset: 0x000040C8
	public virtual void vmethod_114()
	{
		if (!this.bool_12)
		{
			return;
		}
		this.songSelect.method_60(base.String_0);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x0005D5A0 File Offset: 0x0005B7A0
	public void method_73()
	{
		this.menuStrings = SongDirectory.string_0;
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_0(SongDirectory.String_0);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x0005D9F0 File Offset: 0x0005BBF0
	public void method_74(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = true;
		this.vmethod_67();
		base.method_43(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(true);
		this.bool_12 = false;
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x0005DA40 File Offset: 0x0005BC40
	public void method_75(string string_1)
	{
		this.menuStrings = SongDirectory.headerEntries.ToArray();
		this.allowMultiLanguage = false;
		this.vmethod_67();
		base.method_43(string_1);
		this.vmethod_42();
		Canvas.ForceUpdateCanvases();
		base.gameObject.SetActive(false);
		this.bool_12 = false;
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x0005CCE4 File Offset: 0x0005AEE4
	public virtual void vmethod_115()
	{
		if (this.bool_12)
		{
			return;
		}
		int num = 0;
		while (num < SongDirectory.songEntries.Count && (!SongDirectory.songEntries[num].isHeader || !(SongDirectory.songEntries[num].songName == base.String_0)))
		{
			num += 0;
		}
		this.songSelect.vmethod_25(num + 0);
		base.gameObject.SetActive(true);
	}

	// Token: 0x040001EF RID: 495
	[SerializeField]
	private SongSelect songSelect;

	// Token: 0x040001F0 RID: 496
	private bool bool_12;
}
