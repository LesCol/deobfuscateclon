using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Melanchall.DryWetMidi.Smf;

// Token: 0x020000DD RID: 221
public static class GClass30
{
	// Token: 0x06002A5E RID: 10846 RVA: 0x00137824 File Offset: 0x00135A24
	private static string smethod_0(EventsCollection eventsCollection_0)
	{
		for (int i = 0; i < eventsCollection_0.Count; i++)
		{
			if (eventsCollection_0[i].GetType() == typeof(SequenceTrackNameEvent))
			{
				string text = ((SequenceTrackNameEvent)eventsCollection_0[i]).Text.ToLower();
				if (text.Contains("part") || text == "t1 gems" || text == "events" || text == "beat")
				{
					return text;
				}
			}
		}
		return "";
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x001378B4 File Offset: 0x00135AB4
	public static Song smethod_1(string string_0, bool bool_1)
	{
		Song song = new Song();
		GClass30.bool_0 = bool_1;
		MidiFile midiFile;
		Song result;
		try
		{
			midiFile = MidiFile.Read(Path.Combine(string_0, "notes.mid"), null);
			goto IL_27;
		}
		catch (SystemException)
		{
			result = null;
		}
		return result;
		IL_27:
		IEnumerable<TrackChunk> trackChunks = midiFile.GetTrackChunks();
		song.float_4 = (float)((TicksPerQuarterNoteTimeDivision)midiFile.TimeDivision).TicksPerQuarterNote;
		song.float_3 = song.float_4 * GlobalVariables.instance.songSpeed.Single_0;
		GClass30.smethod_5(trackChunks.First<TrackChunk>().Events, song);
		foreach (TrackChunk trackChunk in trackChunks.Skip(1))
		{
			string text = GClass30.smethod_0(trackChunk.Events);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 2134366526u)
			{
				if (num <= 583162216u)
				{
					if (num != 316203908u)
					{
						if (num != 583162216u)
						{
							continue;
						}
						if (text == "part keys")
						{
							GClass30.smethod_7(trackChunk.Events, song, Song.Instrument.Keys);
							continue;
						}
						continue;
					}
					else
					{
						if (text == "events")
						{
							GClass30.smethod_6(trackChunk.Events, song);
							continue;
						}
						continue;
					}
				}
				else if (num != 969470554u)
				{
					if (num != 1314878412u)
					{
						if (num != 2134366526u)
						{
							continue;
						}
						if (!(text == "t1 gems"))
						{
							continue;
						}
					}
					else
					{
						if (text == "part rhythm")
						{
							GClass30.smethod_7(trackChunk.Events, song, Song.Instrument.Rhythm);
							continue;
						}
						continue;
					}
				}
				else
				{
					if (text == "part vocals")
					{
						GClass30.smethod_3(trackChunk.Events, song);
						continue;
					}
					continue;
				}
			}
			else if (num <= 2421315013u)
			{
				if (num != 2329120099u)
				{
					if (num != 2387209770u)
					{
						if (num != 2421315013u)
						{
							continue;
						}
						if (text == "beat")
						{
							GClass30.smethod_2(trackChunk.Events, song);
							continue;
						}
						continue;
					}
					else
					{
						if (text == "part bass ghl")
						{
							GClass30.smethod_7(trackChunk.Events, song, Song.Instrument.GHLBass);
							continue;
						}
						continue;
					}
				}
				else
				{
					if (text == "part guitar coop")
					{
						GClass30.smethod_7(trackChunk.Events, song, Song.Instrument.GuitarCoop);
						continue;
					}
					continue;
				}
			}
			else if (num != 2594645819u)
			{
				if (num != 3225037695u)
				{
					if (num != 3641264310u)
					{
						continue;
					}
					if (!(text == "part guitar"))
					{
						continue;
					}
				}
				else
				{
					if (text == "part bass")
					{
						GClass30.smethod_7(trackChunk.Events, song, Song.Instrument.Bass);
						continue;
					}
					continue;
				}
			}
			else
			{
				if (text == "part guitar ghl")
				{
					GClass30.smethod_7(trackChunk.Events, song, Song.Instrument.GHLGuitar);
					continue;
				}
				continue;
			}
			GClass30.smethod_7(trackChunk.Events, song, Song.Instrument.Guitar);
		}
		song.method_1();
		return song;
	}

	// Token: 0x06002A60 RID: 10848 RVA: 0x00137BB0 File Offset: 0x00135DB0
	private static void smethod_2(EventsCollection eventsCollection_0, Song gclass27_0)
	{
		if (!GClass30.bool_0)
		{
			gclass27_0.list_0 = new List<float>();
			for (int i = 0; i < eventsCollection_0.Count; i++)
			{
				NoteOnEvent noteOnEvent = eventsCollection_0[i] as NoteOnEvent;
				if (noteOnEvent != null && noteOnEvent.OffEvent != null && (noteOnEvent.NoteNumber == 12 || noteOnEvent.NoteNumber == 13))
				{
					gclass27_0.list_0.Add(gclass27_0.method_52((uint)noteOnEvent.AbsoluteTime));
				}
			}
		}
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x00137C30 File Offset: 0x00135E30
	private static void smethod_3(EventsCollection eventsCollection_0, Song gclass27_0)
	{
		gclass27_0.list_1 = new List<Song.GClass29>();
		long num = -1L;
		for (int i = 0; i < eventsCollection_0.Count; i++)
		{
			NoteOnEvent noteOnEvent = eventsCollection_0[i] as NoteOnEvent;
			if (noteOnEvent != null && noteOnEvent.OffEvent != null && (noteOnEvent.NoteNumber == 105 || noteOnEvent.NoteNumber == 106) && num != noteOnEvent.AbsoluteTime)
			{
				double num2 = (double)gclass27_0.method_52((uint)noteOnEvent.AbsoluteTime);
				double num3 = (double)gclass27_0.method_52((uint)noteOnEvent.OffEvent.AbsoluteTime);
				Song.GClass29 item = new Song.GClass29
				{
					double_0 = num2,
					double_1 = num3,
					long_0 = noteOnEvent.AbsoluteTime,
					long_1 = noteOnEvent.OffEvent.AbsoluteTime,
					double_2 = num3 - num2
				};
				gclass27_0.list_1.Add(item);
				num = noteOnEvent.AbsoluteTime;
			}
		}
		if (gclass27_0.list_1.Count > 0)
		{
			for (int j = 0; j < gclass27_0.list_1.Count; j++)
			{
				int index = 0;
				int num4 = 0;
				for (int k = 0; k < eventsCollection_0.Count; k++)
				{
					if (num4 > 0 && GClass30.bool_0)
					{
						return;
					}
					BaseTextEvent baseTextEvent = eventsCollection_0[k] as BaseTextEvent;
					uint num5 = 0u;
					if (baseTextEvent != null && baseTextEvent.Text != null && !baseTextEvent.Text.Contains("[") && baseTextEvent.AbsoluteTime >= gclass27_0.list_1[j].long_0 && baseTextEvent.AbsoluteTime <= gclass27_0.list_1[j].long_1)
					{
						uint uint_ = (uint)baseTextEvent.AbsoluteTime;
						int l = 0;
						while (l < eventsCollection_0.Count)
						{
							NoteOnEvent noteOnEvent2 = eventsCollection_0[l] as NoteOnEvent;
							if (noteOnEvent2 != null && noteOnEvent2.NoteNumber >= 36 && noteOnEvent2.NoteNumber <= 84 && baseTextEvent.AbsoluteTime == noteOnEvent2.AbsoluteTime)
							{
								uint_ = (uint)noteOnEvent2.AbsoluteTime;
								num5 = (uint)noteOnEvent2.OffEvent.AbsoluteTime;
								IL_215:
								if (num4 <= 0 || !baseTextEvent.Text.Contains("+"))
								{
									index = num4;
									Song.GClass28 item2 = new Song.GClass28
									{
										string_0 = baseTextEvent.Text,
										double_0 = (double)gclass27_0.method_52(uint_),
										double_2 = (double)gclass27_0.method_2(uint_, num5),
										double_1 = (double)gclass27_0.method_52(num5)
									};
									gclass27_0.list_1[j].list_0.Add(item2);
									num4++;
									goto IL_327;
								}
								gclass27_0.list_1[j].list_0[index].double_2 += (double)gclass27_0.method_2(uint_, num5);
								if (baseTextEvent.Text.Contains("-"))
								{
									gclass27_0.list_1[j].list_0[index].string_0 = gclass27_0.list_1[j].list_0[index].string_0 + "-";
									goto IL_327;
								}
								goto IL_327;
							}
							else
							{
								l++;
							}
						}
						goto IL_215;
					}
					IL_327:;
				}
				if (num4 == 0)
				{
					gclass27_0.list_1.RemoveAt(j);
					if (gclass27_0.list_1.Count <= 0)
					{
						return;
					}
					j--;
				}
			}
		}
	}

	// Token: 0x06002A62 RID: 10850 RVA: 0x00137FB8 File Offset: 0x001361B8
	private static void smethod_4(IList<MidiEvent> ilist_0)
	{
		foreach (MidiEvent midiEvent in ilist_0)
		{
			NoteOnEvent noteOnEvent = midiEvent as NoteOnEvent;
			if (noteOnEvent != null)
			{
				Console.WriteLine(string.Concat(new object[]
				{
					"Note: ",
					noteOnEvent.NoteNumber,
					", Pos: ",
					noteOnEvent.AbsoluteTime,
					", Vel: ",
					noteOnEvent.Velocity,
					", Channel: ",
					noteOnEvent.Channel,
					", Off pos: ",
					noteOnEvent.OffEvent.AbsoluteTime
				}));
			}
			TextEvent textEvent = midiEvent as TextEvent;
			if (textEvent != null)
			{
				Console.WriteLine(textEvent.Text + " " + textEvent.AbsoluteTime);
			}
		}
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x001380BC File Offset: 0x001362BC
	private static void smethod_5(EventsCollection eventsCollection_0, Song gclass27_0)
	{
		if (!GClass30.bool_0)
		{
			foreach (MidiEvent midiEvent in eventsCollection_0)
			{
				TimeSignatureEvent timeSignatureEvent = midiEvent as TimeSignatureEvent;
				if (timeSignatureEvent != null)
				{
					long absoluteTime = midiEvent.AbsoluteTime;
					gclass27_0.method_39(new GClass25((uint)absoluteTime, (uint)timeSignatureEvent.Numerator, (uint)timeSignatureEvent.Denominator), false);
				}
				else
				{
					SetTempoEvent setTempoEvent = midiEvent as SetTempoEvent;
					if (setTempoEvent != null)
					{
						long absoluteTime2 = midiEvent.AbsoluteTime;
						gclass27_0.method_39(new GClass24((uint)absoluteTime2, (uint)(60000000.0 / (double)setTempoEvent.MicrosecondsPerQuarterNote * 1000.0)), false);
					}
					else
					{
						TextEvent textEvent = midiEvent as TextEvent;
						if (textEvent != null)
						{
							gclass27_0.string_0 = textEvent.Text;
						}
					}
				}
			}
			gclass27_0.method_15();
		}
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x0013819C File Offset: 0x0013639C
	private static void smethod_6(EventsCollection eventsCollection_0, Song gclass27_0)
	{
		if (!GClass30.bool_0)
		{
			for (int i = 0; i < eventsCollection_0.Count; i++)
			{
				TextEvent textEvent = eventsCollection_0[i] as TextEvent;
				if (textEvent != null)
				{
					if (textEvent.Text.Contains("[section ") && !textEvent.Text.Contains("_ENDOFSONG"))
					{
						gclass27_0.method_0(new GClass22(textEvent.Text.Substring(9, textEvent.Text.Length - 10), (uint)textEvent.AbsoluteTime), false);
					}
					else if (textEvent.Text.Contains("[prc_"))
					{
						gclass27_0.method_0(new GClass22(textEvent.Text.Substring(5, textEvent.Text.Length - 6), (uint)textEvent.AbsoluteTime), false);
					}
				}
			}
			gclass27_0.method_15();
		}
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x00138278 File Offset: 0x00136478
	private static void smethod_7(EventsCollection eventsCollection_0, Song gclass27_0, Song.Instrument genum18_0)
	{
		List<NoteOnEvent> list = new List<NoteOnEvent>(500);
		List<SysExEvent> list2 = new List<SysExEvent>(500);
		List<int> list3 = new List<int>(10);
		int num = (int)(64f * gclass27_0.float_3 / GClass15.float_0);
		bool flag = false;
		if (!GClass30.bool_0 && SongEntry.currentSongMultiplierNote == 0)
		{
			int num2 = 0;
			for (int i = 0; i < eventsCollection_0.Count; i++)
			{
				NoteOnEvent noteOnEvent = eventsCollection_0[i] as NoteOnEvent;
				if (noteOnEvent != null && noteOnEvent.OffEvent != null)
				{
					if (noteOnEvent.NoteNumber == 103)
					{
						num2++;
					}
					else if (noteOnEvent.NoteNumber == 116)
					{
						num2 = 0;
						IL_A6:
						if (num2 >= 2)
						{
							flag = true;
							goto IL_AE;
						}
						goto IL_AE;
					}
				}
			}
			goto IL_A6;
		}
		IL_AE:
		int j = 0;
		while (j < eventsCollection_0.Count)
		{
			NoteOnEvent noteOnEvent2 = eventsCollection_0[j] as NoteOnEvent;
			if (noteOnEvent2 == null || noteOnEvent2.OffEvent == null)
			{
				goto IL_4E6;
			}
			uint num3 = (uint)noteOnEvent2.AbsoluteTime;
			uint num4 = (uint)(noteOnEvent2.OffEvent.AbsoluteTime - (long)((ulong)num3));
			if (!GClass30.bool_0)
			{
				if (noteOnEvent2.NoteNumber != 116)
				{
					if (!flag || noteOnEvent2.NoteNumber != 103)
					{
						if (noteOnEvent2.NoteNumber == 103)
						{
							using (IEnumerator enumerator = Enum.GetValues(typeof(Song.GEnum17)).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									Song.GEnum17 genum17_ = (Song.GEnum17)obj;
									gclass27_0.method_59(genum18_0, genum17_).list_1.Add(new GClass8(gclass27_0.method_52((uint)noteOnEvent2.AbsoluteTime), gclass27_0.method_2((uint)noteOnEvent2.AbsoluteTime, (uint)noteOnEvent2.OffEvent.AbsoluteTime), (uint)noteOnEvent2.AbsoluteTime, (uint)noteOnEvent2.OffEvent.AbsoluteTime));
								}
								goto IL_564;
							}
						}
						byte b = noteOnEvent2.NoteNumber;
						if (b <= 78)
						{
							if (b - 65 > 1 && b - 77 > 1)
							{
								goto IL_28F;
							}
						}
						else if (b - 89 > 1 && b - 101 > 1)
						{
							goto IL_28F;
						}
						list.Add(noteOnEvent2);
						goto IL_564;
					}
				}
				using (IEnumerator enumerator = Enum.GetValues(typeof(Song.GEnum17)).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						Song.GEnum17 genum17_2 = (Song.GEnum17)obj2;
						gclass27_0.method_59(genum18_0, genum17_2).method_12(new GClass20(num3, num4), false);
					}
					goto IL_564;
				}
			}
			IL_28F:
			GClass19.GEnum13 genum13_ = GClass19.GEnum13.GREEN;
			if ((ulong)num4 <= (ulong)((long)num))
			{
				num4 = 0u;
			}
			if (genum18_0 == Song.Instrument.GHLGuitar)
			{
				goto IL_399;
			}
			if (genum18_0 == Song.Instrument.GHLBass)
			{
				goto IL_399;
			}
			switch (noteOnEvent2.NoteNumber)
			{
			case 60:
			case 72:
			case 84:
			case 96:
				genum13_ = GClass19.GEnum13.GREEN;
				break;
			case 61:
			case 73:
			case 85:
			case 97:
				genum13_ = GClass19.GEnum13.RED;
				break;
			case 62:
			case 74:
			case 86:
			case 98:
				genum13_ = GClass19.GEnum13.YELLOW;
				break;
			case 63:
			case 75:
			case 87:
			case 99:
				genum13_ = GClass19.GEnum13.BLUE;
				break;
			case 64:
			case 76:
			case 88:
			case 100:
				genum13_ = GClass19.GEnum13.ORANGE;
				break;
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 77:
			case 78:
			case 79:
			case 80:
			case 81:
			case 82:
			case 83:
			case 89:
			case 90:
			case 91:
			case 92:
			case 93:
			case 94:
			case 95:
			case 101:
				goto IL_564;
			default:
				goto IL_564;
			}
			IL_483:
			Song.GEnum17 genum;
			try
			{
				genum = GClass30.smethod_8((int)noteOnEvent2.NoteNumber);
				if (GClass30.bool_0 && list3.Contains((int)genum))
				{
					goto IL_564;
				}
			}
			catch
			{
				goto IL_564;
			}
			gclass27_0.method_59(genum18_0, genum).method_12(new GClass19(num3, genum13_, num4, GClass19.GEnum15.NONE), GClass30.bool_0);
			if (GClass30.bool_0)
			{
				list3.Add((int)genum);
				goto IL_564;
			}
			goto IL_4E6;
			IL_399:
			switch (noteOnEvent2.NoteNumber)
			{
			case 58:
			case 70:
			case 82:
			case 94:
				genum13_ = GClass19.GEnum13.OPEN;
				goto IL_483;
			case 59:
			case 71:
			case 83:
			case 95:
				genum13_ = GClass19.GEnum13.W1;
				goto IL_483;
			case 60:
			case 72:
			case 84:
			case 96:
				genum13_ = GClass19.GEnum13.W2;
				goto IL_483;
			case 61:
			case 73:
			case 85:
			case 97:
				genum13_ = GClass19.GEnum13.W3;
				goto IL_483;
			case 62:
			case 74:
			case 86:
			case 98:
				genum13_ = GClass19.GEnum13.B1;
				goto IL_483;
			case 63:
			case 75:
			case 87:
			case 99:
				genum13_ = GClass19.GEnum13.B2;
				goto IL_483;
			case 64:
			case 76:
			case 88:
			case 100:
				genum13_ = GClass19.GEnum13.B3;
				goto IL_483;
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 77:
			case 78:
			case 79:
			case 80:
			case 81:
			case 89:
			case 90:
			case 91:
			case 92:
			case 93:
				goto IL_483;
			default:
				goto IL_483;
			}
			IL_564:
			j++;
			continue;
			IL_4E6:
			if (GClass30.bool_0)
			{
				goto IL_564;
			}
			TextEvent textEvent = eventsCollection_0[j] as TextEvent;
			if (textEvent != null && textEvent.Text != null)
			{
				uint uint_ = (uint)textEvent.AbsoluteTime;
				string string_ = textEvent.Text.Trim(new char[]
				{
					'[',
					']'
				});
				gclass27_0.method_59(genum18_0, Song.GEnum17.Expert).method_12(new ChartEvent(uint_, string_), true);
			}
			SysExEvent sysExEvent = eventsCollection_0[j] as SysExEvent;
			if (sysExEvent != null)
			{
				list2.Add(sysExEvent);
				goto IL_564;
			}
			goto IL_564;
		}
		foreach (object obj3 in Enum.GetValues(typeof(Song.GEnum17)))
		{
			Song.GEnum17 genum17_3 = (Song.GEnum17)obj3;
			gclass27_0.method_59(genum18_0, genum17_3).method_18();
		}
		if (!GClass30.bool_0)
		{
			Array values = Enum.GetValues(typeof(Song.GEnum17));
			GClass26[] array = new GClass26[values.Length];
			int num5 = 0;
			foreach (object obj4 in values)
			{
				Song.GEnum17 genum17_4 = (Song.GEnum17)obj4;
				array[num5++] = gclass27_0.method_59(genum18_0, genum17_4);
			}
			for (int k = 0; k < list2.Count; k++)
			{
				SysExEvent sysExEvent2 = list2[k];
				byte[] data = sysExEvent2.Data;
				if (data.Length == 8 && data[4] == 255 && data[6] == 1)
				{
					uint num6 = (uint)sysExEvent2.AbsoluteTime;
					uint num7 = 0u;
					for (int l = k; l < list2.Count; l++)
					{
						SysExEvent sysExEvent3 = list2[l];
						byte[] data2 = sysExEvent3.Data;
						if (data2.Length == 8 && data2[4] == 255 && data2[6] == 0)
						{
							num7 = (uint)(sysExEvent3.AbsoluteTime - (long)((ulong)num6));
							IL_6D3:
							foreach (GClass26 gclass in array)
							{
								int num8;
								int num9;
								GClass16.smethod_18<GClass19>(gclass.GClass19_0, num6, num6 + num7, out num8, out num9);
								for (int n = num8; n < num8 + num9; n++)
								{
									gclass.GClass19_0[n].method_18(GClass19.GEnum14.Tap);
								}
							}
							goto IL_83C;
						}
					}
					goto IL_6D3;
				}
				if (data.Length == 8 && data[4] >= 0 && data[4] < 4 && data[6] == 1)
				{
					uint num10 = (uint)sysExEvent2.AbsoluteTime;
					Song.GEnum17 genum17_5;
					switch (data[4])
					{
					case 0:
						genum17_5 = Song.GEnum17.Easy;
						break;
					case 1:
						genum17_5 = Song.GEnum17.Medium;
						break;
					case 2:
						genum17_5 = Song.GEnum17.Hard;
						break;
					case 3:
						genum17_5 = Song.GEnum17.Expert;
						break;
					default:
						goto IL_83C;
					}
					uint num11 = 0u;
					for (int num12 = k; num12 < list2.Count; num12++)
					{
						SysExEvent sysExEvent4 = list2[num12];
						if (sysExEvent4 != null)
						{
							byte[] data3 = sysExEvent4.Data;
							if (data3.Length == 8 && data3[4] == data[4] && data3[6] == 0)
							{
								num11 = (uint)(sysExEvent4.AbsoluteTime - (long)((ulong)num10));
								if (num11 > 0u)
								{
									num11 -= 1u;
								}
								IL_7FA:
								GClass19[] gclass19_ = gclass27_0.method_59(genum18_0, genum17_5).GClass19_0;
								int num13;
								int num14;
								GClass16.smethod_18<GClass19>(gclass19_, num10, num10 + num11, out num13, out num14);
								for (int num15 = num13; num15 < num13 + num14; num15++)
								{
									gclass19_[num15].genum13_0 = GClass19.GEnum13.OPEN;
								}
								goto IL_83C;
							}
						}
					}
					goto IL_7FA;
				}
				IL_83C:;
			}
			int num16 = 0;
			while (num16 < list.Count)
			{
				uint num17 = (uint)list[num16].AbsoluteTime;
				uint num18 = (uint)list[num16].OffEvent.AbsoluteTime;
				if (num18 - num17 != 0u)
				{
					num18 -= 1u;
				}
				Song.GEnum17 genum17_6;
				try
				{
					genum17_6 = GClass30.smethod_8((int)list[num16].NoteNumber);
				}
				catch
				{
					goto IL_927;
				}
				goto IL_8A8;
				IL_927:
				num16++;
				continue;
				IL_8A8:
				GClass26 gclass2 = gclass27_0.method_59(genum18_0, genum17_6);
				int num19;
				int num20;
				GClass16.smethod_18<GClass19>(gclass2.GClass19_0, num17, num18, out num19, out num20);
				for (int num21 = num19; num21 < num19 + num20; num21++)
				{
					if ((gclass2.GClass19_0[num21].genum15_0 & GClass19.GEnum15.TAP) == GClass19.GEnum15.NONE)
					{
						if (list[num16].NoteNumber % 2 != 0)
						{
							gclass2.GClass19_0[num21].method_18(GClass19.GEnum14.Hopo);
						}
						else
						{
							gclass2.GClass19_0[num21].method_18(GClass19.GEnum14.Strum);
						}
					}
				}
				goto IL_927;
			}
		}
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x00011D0E File Offset: 0x0000FF0E
	private static Song.GEnum17 smethod_8(int int_0)
	{
		if (int_0 >= 58 && int_0 <= 66)
		{
			return Song.GEnum17.Easy;
		}
		if (int_0 >= 70 && int_0 <= 78)
		{
			return Song.GEnum17.Medium;
		}
		if (int_0 >= 82 && int_0 <= 90)
		{
			return Song.GEnum17.Hard;
		}
		if (int_0 < 94 || int_0 > 102)
		{
			throw new ArgumentOutOfRangeException("Note number outside of note range");
		}
		return Song.GEnum17.Expert;
	}

	// Token: 0x040006A6 RID: 1702
	private static bool bool_0;
}
