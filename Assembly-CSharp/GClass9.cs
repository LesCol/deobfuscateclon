using System;
using Rewired;

// Token: 0x0200007D RID: 125
public class CHPlayer
{
	// Token: 0x06001749 RID: 5961 RVA: 0x0000C654 File Offset: 0x0000A854
	public void method_0()
	{
		this.player_0.isPlaying = true;
		this.player_0 = null;
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x0000C669 File Offset: 0x0000A869
	public void method_1()
	{
		this.player_0.isPlaying = false;
		this.player_0 = null;
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_2()
	{
		return this.player_0 != null;
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x000BCB0C File Offset: 0x000BAD0C
	private static void smethod_0(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "song_length");
			}
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600174D RID: 5965 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool Boolean_0
	{
		get
		{
			return this.player_0 != null;
		}
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x0000C669 File Offset: 0x0000A869
	public void method_3()
	{
		this.player_0.isPlaying = false;
		this.player_0 = null;
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x0000C689 File Offset: 0x0000A889
	public static void smethod_1()
	{
		CHPlayer.smethod_13(true);
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x000BCB84 File Offset: 0x000BAD84
	private static void smethod_2(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "Error writing metadata");
			}
		}
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_4()
	{
		return this.player_0 != null;
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x0000C691 File Offset: 0x0000A891
	public static void smethod_3()
	{
		CHPlayer.smethod_17(true);
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_5()
	{
		return this.player_0 != null;
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x0000C699 File Offset: 0x0000A899
	public static void smethod_4()
	{
		CHPlayer.smethod_16(true);
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x0000C689 File Offset: 0x0000A889
	public static void smethod_5()
	{
		CHPlayer.smethod_13(true);
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x0000C669 File Offset: 0x0000A869
	public void method_6()
	{
		this.player_0.isPlaying = false;
		this.player_0 = null;
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x0000C6A1 File Offset: 0x0000A8A1
	public static void smethod_6()
	{
		CHPlayer.smethod_16(false);
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x0000C6A9 File Offset: 0x0000A8A9
	public static void smethod_7()
	{
		CHPlayer.smethod_18(false);
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_7()
	{
		return this.player_0 != null;
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x0000C654 File Offset: 0x0000A854
	public void method_8()
	{
		this.player_0.isPlaying = true;
		this.player_0 = null;
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x0000C6B1 File Offset: 0x0000A8B1
	public static void smethod_8()
	{
		CHPlayer.smethod_25(true);
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_9()
	{
		return this.player_0 != null;
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x000BCBFC File Offset: 0x000BADFC
	private static void smethod_9(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "Stars Earned");
			}
		}
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x0000C654 File Offset: 0x0000A854
	public void method_10()
	{
		this.player_0.isPlaying = true;
		this.player_0 = null;
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_11()
	{
		return this.player_0 != null;
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x0000C6B9 File Offset: 0x0000A8B9
	public static void smethod_10()
	{
		CHPlayer.smethod_2(false);
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x0000C6C1 File Offset: 0x0000A8C1
	public static void smethod_11()
	{
		CHPlayer.smethod_0(false);
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x0000C654 File Offset: 0x0000A854
	public void method_12()
	{
		this.player_0.isPlaying = true;
		this.player_0 = null;
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x0000C654 File Offset: 0x0000A854
	public void method_13()
	{
		this.player_0.isPlaying = true;
		this.player_0 = null;
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x0000C6C9 File Offset: 0x0000A8C9
	public static void smethod_12()
	{
		CHPlayer.smethod_24(true);
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x000BCC74 File Offset: 0x000BAE74
	private static void smethod_13(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "");
			}
		}
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x0000C6D1 File Offset: 0x0000A8D1
	public static void smethod_14()
	{
		CHPlayer.smethod_20(true);
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x0000C6D9 File Offset: 0x0000A8D9
	public static void smethod_15()
	{
		CHPlayer.smethod_17(false);
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_14()
	{
		return this.player_0 != null;
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x000BCCEC File Offset: 0x000BAEEC
	private static void smethod_16(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "cd");
			}
		}
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x000BCD64 File Offset: 0x000BAF64
	private static void smethod_17(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "Gameplay");
			}
		}
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_15()
	{
		return this.player_0 != null;
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x000BCDDC File Offset: 0x000BAFDC
	private static void smethod_18(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "Continue");
			}
		}
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x0000C669 File Offset: 0x0000A869
	public void method_16()
	{
		this.player_0.isPlaying = false;
		this.player_0 = null;
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x0000C6E1 File Offset: 0x0000A8E1
	public static void smethod_19()
	{
		CHPlayer.smethod_0(true);
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x000BCE54 File Offset: 0x000BB054
	private static void smethod_20(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "\\d+ = E \"section [^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
			}
		}
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x0000C6B1 File Offset: 0x0000A8B1
	public static void smethod_21()
	{
		CHPlayer.smethod_25(true);
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x0000C6E9 File Offset: 0x0000A8E9
	public static void smethod_22()
	{
		CHPlayer.smethod_9(false);
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x0000C691 File Offset: 0x0000A891
	public static void smethod_23()
	{
		CHPlayer.smethod_17(true);
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_17()
	{
		return this.player_0 != null;
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x000BCECC File Offset: 0x000BB0CC
	private static void smethod_24(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "preview_volume");
			}
		}
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x000BCF44 File Offset: 0x000BB144
	private static void smethod_25(bool bool_1)
	{
		foreach (CHPlayer gclass in GlobalVariables.instance.playerList)
		{
			if (gclass != null && gclass.player_0 != null)
			{
				gclass.player_0.controllers.maps.SetMapsEnabled(bool_1, "particles");
			}
		}
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x0000C699 File Offset: 0x0000A899
	public static void smethod_26()
	{
		CHPlayer.smethod_16(true);
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x0000C6B1 File Offset: 0x0000A8B1
	public static void smethod_27()
	{
		CHPlayer.smethod_25(true);
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x0000C689 File Offset: 0x0000A889
	public static void smethod_28()
	{
		CHPlayer.smethod_13(true);
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_18()
	{
		return this.player_0 != null;
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x0000C699 File Offset: 0x0000A899
	public static void smethod_29()
	{
		CHPlayer.smethod_16(true);
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x0000C6A9 File Offset: 0x0000A8A9
	public static void smethod_30()
	{
		CHPlayer.smethod_18(false);
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x0000C67E File Offset: 0x0000A87E
	public bool method_19()
	{
		return this.player_0 != null;
	}

	// Token: 0x040003A5 RID: 933
	public GClass10 gclass10_0;

	// Token: 0x040003A6 RID: 934
	public Player player_0;

	// Token: 0x040003A7 RID: 935
	public PlayerProfileMenu playerProfileMenu_0;

	// Token: 0x040003A8 RID: 936
	public int int_0;

	// Token: 0x040003A9 RID: 937
	public bool bool_0;
}
