using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000A0 RID: 160
public static class SongDirectory
{
    // Token: 0x17000077 RID: 119
    // (get) Token: 0x06001E61 RID: 7777 RVA: 0x0000DBD3 File Offset: 0x0000BDD3
    public static string String_0
    {
        get
        {
            return SongDirectory.string_0[SongDirectory.sortCounter];
        }
    }

    // Token: 0x17000078 RID: 120
    // (get) Token: 0x06001E62 RID: 7778 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
    public static string String_1
    {
        get
        {
            return GClass4.gclass4_0.method_13(SongDirectory.string_0[SongDirectory.sortCounter]);
        }
    }

    // Token: 0x06001E73 RID: 7795 RVA: 0x000FB078 File Offset: 0x000F9278
    public static int smethod_16(int int_1)
    {
        int num = int_1;
        do
        {
            int_1++;
            if (int_1 >= SongDirectory.songEntries.Count)
            {
                int_1 = 0;
            }
            if (SongDirectory.songEntries[int_1].isHeader)
            {
                return int_1;
            }
        }
        while (int_1 != num);
        return num;
    }

    // Token: 0x06001E75 RID: 7797 RVA: 0x000FBE2C File Offset: 0x000FA02C
    private static void smethod_18()
    {
        SongDirectory.headerEntries = new List<string>(1000);
        foreach (SongEntry songEntry in SongDirectory.songEntries)
        {
            if (songEntry.isHeader)
            {
                SongDirectory.headerEntries.Add(songEntry.songName);
            }
        }
    }

    // Token: 0x06001E76 RID: 7798 RVA: 0x000FBEA0 File Offset: 0x000FA0A0
    private static int smethod_19(SongEntry songEntry_0)
    {
        int result = 0;
        switch (SongDirectory.sortedInstrument)
        {
            case GStruct2.GEnum11.Guitar:
            case GStruct2.GEnum11.GuitarCoop:
                result = (int)songEntry_0.guitarDifficulty;
                break;
            case GStruct2.GEnum11.Bass:
                result = (int)songEntry_0.bassDifficulty;
                break;
            case GStruct2.GEnum11.Rhythm:
                result = (int)songEntry_0.rhythmDifficulty;
                break;
            case GStruct2.GEnum11.GHLGuitar:
                result = (int)songEntry_0.ghlGuitarDifficulty;
                break;
            case GStruct2.GEnum11.GHLBass:
                result = (int)songEntry_0.ghlBassDifficulty;
                break;
            case GStruct2.GEnum11.Keys:
                result = (int)songEntry_0.keysDifficulty;
                break;
        }
        return result;
    }

    // Token: 0x040004C5 RID: 1221
    public static List<SongEntry> songEntries;

    // Token: 0x040004C6 RID: 1222
    public static List<SongEntry> setlistSongEntries;

    // Token: 0x040004C7 RID: 1223
    public static List<int> setlistSongSpeeds;

    // Token: 0x040004C8 RID: 1224
    public static List<string> headerEntries;

    // Token: 0x040004C9 RID: 1225
    public static int sortCounter = -1;

    // Token: 0x040004CA RID: 1226
    private static bool sortedByInstrument;

    // Token: 0x040004CB RID: 1227
    private static GStruct2.GEnum11 sortedInstrument;

    // Token: 0x040004CC RID: 1228
    private static Hashtable sourceStrings;

    // Token: 0x040004CD RID: 1229
    public static string[] string_0 = new string[]
    {
        "Song",
        "Artist",
        "Album",
        "Genre",
        "Year",
        "Charter",
        "Song Length",
        "Date Added",
        "Playlist",
        "Source",
        "Lyrics",
        "Play Count",
        "Stars Earned",
        "Percentage",
        "Lead Guitar",
        "Bass Guitar",
        "6 Fret Lead Guitar",
        "6 Fret Bass Guitar",
        "Rhythm Guitar",
        "Guitar Coop",
        "Keys"
    };

}