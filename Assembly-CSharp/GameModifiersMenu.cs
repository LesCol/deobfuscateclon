using System;
using Rewired;
using UnityEngine;

// Token: 0x02000044 RID: 68
public class GameModifiersMenu : BaseMenu
{
	// Token: 0x06000C1D RID: 3101 RVA: 0x00006BF7 File Offset: 0x00004DF7
	public virtual void vmethod_81()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x00006C2D File Offset: 0x00004E2D
	public virtual void vmethod_82()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_46();
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x00006C5B File Offset: 0x00004E5B
	public virtual void vmethod_83()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = false;
		this.method_56();
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x000618F0 File Offset: 0x0005FAF0
	private void method_44()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967160u)
		{
			if (num <= 4294967258u)
			{
				if (num != 75u)
				{
					if (num != 105u)
					{
						if (num == 4294967181u)
						{
							if (string_ == "Play Count")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "game")
					{
						text = this.gclass5_0.method_9();
						Application.runInBackground = this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "Show Hit Window")
				{
					goto IL_1DE;
				}
			}
			else if (num != 139u)
			{
				if (num != 4294967138u)
				{
					if (num == 4294967148u)
					{
						if (string_ == "mute_on_miss")
						{
							text = GClass4.gclass4_0.method_46(SongDirectory.string_0[this.gclass5_0.method_5()]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "Percentage")
				{
					text = this.gclass5_0.String_2 + "hardware_info";
					goto IL_1EA;
				}
			}
			else if (string_ == "Audio Device")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 59u)
		{
			if (num != 4294967148u)
			{
				if (num != 4294967199u)
				{
					if (num == 78u)
					{
						if (string_ == "Guitar - ")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "vocals")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "volume")
			{
				goto IL_1DE;
			}
		}
		else if (num != 143u)
		{
			if (num != 4294967231u)
			{
				if (num == 114u)
				{
					if (string_ == "")
					{
						text = this.gclass5_0.method_28();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "song_display")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "diff_band")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.String_0;
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00006C89 File Offset: 0x00004E89
	public virtual void vmethod_84()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00006CBF File Offset: 0x00004EBF
	public virtual void vmethod_85()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_58();
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00006CED File Offset: 0x00004EED
	public virtual void vmethod_86()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_56();
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00006D1B File Offset: 0x00004F1B
	public virtual void vmethod_87()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00061AFC File Offset: 0x0005FCFC
	private void method_45()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 13u)
		{
			if (num <= 131u)
			{
				if (num != 137u)
				{
					if (num != 4294967115u)
					{
						if (num == 79u)
						{
							if (string_ == "WRITING CACHE...")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "drums")
					{
						text = this.gclass5_0.String_0;
						Application.runInBackground = this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "^\\s*\\d+ = E \\S")
				{
					goto IL_1DE;
				}
			}
			else if (num != 21u)
			{
				if (num != 23u)
				{
					if (num == 170u)
					{
						if (string_ == "volume")
						{
							text = GClass4.gclass4_0.method_30(SongDirectory.string_0[this.gclass5_0.method_5()]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "background_image")
				{
					text = this.gclass5_0.String_2 + "\\d+ = E \"section [^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
					goto IL_1EA;
				}
			}
			else if (string_ == "diff_rhythm")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967176u)
		{
			if (num != 80u)
			{
				if (num != 132u)
				{
					if (num == 134u)
					{
						if (string_ == "Set B Position")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "Yes")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "No")
			{
				goto IL_1DE;
			}
		}
		else if (num != 31u)
		{
			if (num != 78u)
			{
				if (num == 113u)
				{
					if (string_ == "diff_band")
					{
						text = this.gclass5_0.method_26();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == " (")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == ", Vel: ")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.String_0;
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00006D51 File Offset: 0x00004F51
	public virtual void vmethod_88()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_49();
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00006D1B File Offset: 0x00004F1B
	public virtual void vmethod_89()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00006D7F File Offset: 0x00004F7F
	public virtual void vmethod_90()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_55();
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00061D08 File Offset: 0x0005FF08
	private void method_46()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967263u)
		{
			if (num <= 16u)
			{
				if (num != 4294967166u)
				{
					if (num != 110u)
					{
						if (num == 4294967200u)
						{
							if (string_ == "-")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "song")
					{
						text = this.gclass5_0.String_0;
						Application.runInBackground = !this.gclass5_0.method_4();
						goto IL_1EA;
					}
				}
				else if (string_ == ")")
				{
					goto IL_1DE;
				}
			}
			else if (num != 2u)
			{
				if (num != 187u)
				{
					if (num == 4294967239u)
					{
						if (string_ == "game")
						{
							text = GClass4.gclass4_0.method_46(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == ".png")
				{
					text = this.gclass5_0.String_2 + "video";
					goto IL_1EA;
				}
			}
			else if (string_ == "Main Menu")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967239u)
		{
			if (num != 141u)
			{
				if (num != 4294967154u)
				{
					if (num == 37u)
					{
						if (string_ == "Rename Setlist")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "Song Speed")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "vsync")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967167u)
		{
			if (num != 104u)
			{
				if (num == 58u)
				{
					if (string_ == "allow_duplicate_songs")
					{
						text = this.gclass5_0.String_1;
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "part bass ghl")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "Song Speed")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_9();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00006DAD File Offset: 0x00004FAD
	public virtual void vmethod_91()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_29();
		this.optionsMenu.bool_10 = false;
		this.method_57();
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00006DDB File Offset: 0x00004FDB
	public virtual void vmethod_92()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = false;
		this.method_55();
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00006E09 File Offset: 0x00005009
	public virtual void vmethod_93()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_47();
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00006D1B File Offset: 0x00004F1B
	public virtual void vmethod_94()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00006E37 File Offset: 0x00005037
	public virtual void vmethod_95()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_53();
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00061F14 File Offset: 0x00060114
	private void method_47()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967258u)
		{
			if (num <= 4294967255u)
			{
				if (num != 4294967132u)
				{
					if (num != 4294967115u)
					{
						if (num == 4294967180u)
						{
							if (string_ == "\0\0")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "")
					{
						text = this.gclass5_0.String_0;
						Application.runInBackground = !this.gclass5_0.method_4();
						goto IL_1EA;
					}
				}
				else if (string_ == "A setlist with that name already exists")
				{
					goto IL_1DE;
				}
			}
			else if (num != 138u)
			{
				if (num != 84u)
				{
					if (num == 4294967291u)
					{
						if (string_ == "Bad file type")
						{
							text = GClass4.gclass4_0.method_2(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "File does not exist")
				{
					text = this.gclass5_0.String_2 + "6 Fret Guitar";
					goto IL_1EA;
				}
			}
			else if (string_ == "Overwrite")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967276u)
		{
			if (num != 129u)
			{
				if (num != 139u)
				{
					if (num == 4294967166u)
					{
						if (string_ == "No")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "Practice")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Failed to get data privacy url: {0}")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967282u)
		{
			if (num != 45u)
			{
				if (num == 4294967217u)
				{
					if (string_ == "Lyrics")
					{
						text = this.gclass5_0.method_26();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "Note Shuffle")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == ", Off pos: ")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_10();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00006E65 File Offset: 0x00005065
	public virtual void vmethod_96()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x00006E9B File Offset: 0x0000509B
	public virtual void vmethod_97()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_56();
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00062120 File Offset: 0x00060320
	private void method_48()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967143u)
		{
			if (num <= 4294967226u)
			{
				if (num != 173u)
				{
					if (num != 101u)
					{
						if (num == 4294967193u)
						{
							if (string_ == "Artist")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "Folders")
					{
						text = this.gclass5_0.method_9();
						Application.runInBackground = this.gclass5_0.method_4();
						goto IL_1EA;
					}
				}
				else if (string_ == "There was a problem saving the file")
				{
					goto IL_1DE;
				}
			}
			else if (num != 180u)
			{
				if (num != 64u)
				{
					if (num == 4294967136u)
					{
						if (string_ == " ")
						{
							text = GClass4.gclass4_0.method_15(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "No Part")
				{
					text = this.gclass5_0.String_2 + "Guitar";
					goto IL_1EA;
				}
			}
			else if (string_ == "Unknown Album")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967139u)
		{
			if (num != 95u)
			{
				if (num != 199u)
				{
					if (num == 187u)
					{
						if (string_ == "Pause")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "open")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Play Count")
			{
				goto IL_1DE;
			}
		}
		else if (num != 122u)
		{
			if (num != 4294967209u)
			{
				if (num == 114u)
				{
					if (string_ == "Folders")
					{
						text = this.gclass5_0.method_1();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "album_track")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "Problem saving setlist")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_9();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x0006232C File Offset: 0x0006052C
	private void method_49()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967187u)
		{
			if (num <= 70u)
			{
				if (num != 154u)
				{
					if (num != 4294967154u)
					{
						if (num == 83u)
						{
							if (string_ == "Broadcasting started.")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "Clear A/B")
					{
						text = this.gclass5_0.method_10();
						Application.runInBackground = this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "Volume")
				{
					goto IL_1DE;
				}
			}
			else if (num != 87u)
			{
				if (num != 4294967263u)
				{
					if (num == 4294967152u)
					{
						if (string_ == "Quit")
						{
							text = GClass4.gclass4_0.method_41(SongDirectory.string_0[this.gclass5_0.method_5()]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "streamer")
				{
					text = this.gclass5_0.String_2 + "";
					goto IL_1EA;
				}
			}
			else if (string_ == "particles")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967294u)
		{
			if (num != 51u)
			{
				if (num != 162u)
				{
					if (num == 115u)
					{
						if (string_ == "</color>")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "bass")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Scan Songs")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967287u)
		{
			if (num != 4294967274u)
			{
				if (num == 154u)
				{
					if (string_ == "song")
					{
						text = this.gclass5_0.String_1;
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "SECTION")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "has_bots")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_9();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00006EC9 File Offset: 0x000050C9
	public virtual void vmethod_98()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = true;
		this.method_44();
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x00062538 File Offset: 0x00060738
	private void method_50()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967120u)
		{
			if (num <= 93u)
			{
				if (num != 190u)
				{
					if (num != 9u)
					{
						if (num == 158u)
						{
							if (string_ == "Resolution")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "volume")
					{
						text = this.gclass5_0.method_10();
						Application.runInBackground = this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "Are you sure?")
				{
					goto IL_1DE;
				}
			}
			else if (num != 51u)
			{
				if (num != 4294967121u)
				{
					if (num == 50u)
					{
						if (string_ == "Song Options")
						{
							text = GClass4.gclass4_0.method_15(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "All Strums")
				{
					text = this.gclass5_0.String_2 + "difficulty_name_";
					goto IL_1EA;
				}
			}
			else if (string_ == "Visit Website")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 29u)
		{
			if (num != 4294967125u)
			{
				if (num != 122u)
				{
					if (num == 4294967117u)
					{
						if (string_ == "Settings")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "diff_bass")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Waiting for connection")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967116u)
		{
			if (num != 4294967111u)
			{
				if (num == 4294967103u)
				{
					if (string_ == "Quickplay")
					{
						text = this.gclass5_0.String_1;
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "0")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "Unknown Album")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.String_0;
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x00062744 File Offset: 0x00060944
	private void method_51()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 44u)
		{
			if (num <= 4294967271u)
			{
				if (num != 4294967193u)
				{
					if (num != 176u)
					{
						if (num == 1u)
						{
							if (string_ == "Songs")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "")
					{
						text = this.gclass5_0.String_0;
						Application.runInBackground = !this.gclass5_0.method_4();
						goto IL_1EA;
					}
				}
				else if (string_ == "Source")
				{
					goto IL_1DE;
				}
			}
			else if (num != 4294967228u)
			{
				if (num != 172u)
				{
					if (num == 89u)
					{
						if (string_ == "graphics_api")
						{
							text = GClass4.gclass4_0.method_30(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "")
				{
					text = this.gclass5_0.String_2 + "...";
					goto IL_1EA;
				}
			}
			else if (string_ == ":")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 88u)
		{
			if (num != 159u)
			{
				if (num != 4294967254u)
				{
					if (num == 84u)
					{
						if (string_ == "}")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == " ")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Quit")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967212u)
		{
			if (num != 4294967233u)
			{
				if (num == 137u)
				{
					if (string_ == "Prefabs/Gameplay/Notes/open_sustain_glow")
					{
						text = this.gclass5_0.method_28();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "Save Playlist")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "Drums")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_10();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x00006D1B File Offset: 0x00004F1B
	public virtual void vmethod_99()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x00006EF7 File Offset: 0x000050F7
	public virtual void vmethod_100()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = false;
		this.method_52();
	}

	// Token: 0x06000C3A RID: 3130 RVA: 0x00006E65 File Offset: 0x00005065
	public virtual void vmethod_101()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C3B RID: 3131 RVA: 0x00006F25 File Offset: 0x00005125
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_58();
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00006EC9 File Offset: 0x000050C9
	public virtual void vmethod_104()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_19();
		this.optionsMenu.bool_10 = true;
		this.method_44();
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00006E65 File Offset: 0x00005065
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00063080 File Offset: 0x00061280
	private void method_52()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967111u)
		{
			if (num <= 110u)
			{
				if (num != 4294967267u)
				{
					if (num != 4294967266u)
					{
						if (num == 4294967198u)
						{
							if (string_ == "All Strums")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "song")
					{
						text = this.gclass5_0.String_0;
						Application.runInBackground = !this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "}")
				{
					goto IL_1DE;
				}
			}
			else if (num != 4294967112u)
			{
				if (num != 4294967164u)
				{
					if (num == 133u)
					{
						if (string_ == "<NULL PATH>")
						{
							text = GClass4.gclass4_0.method_36(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "GETTING FOLDERS...")
				{
					text = this.gclass5_0.String_2 + "SECTION";
					goto IL_1EA;
				}
			}
			else if (string_ == "Song")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 80u)
		{
			if (num != 112u)
			{
				if (num != 4294967191u)
				{
					if (num == 122u)
					{
						if (string_ == "system_ram")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "Note: ")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Stars Earned")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967097u)
		{
			if (num != 4294967288u)
			{
				if (num == 83u)
				{
					if (string_ == "Year = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
					{
						text = this.gclass5_0.method_26();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "Year")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "Prefabs/Gameplay/Notes/open_sustain_glow")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_10();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00006F53 File Offset: 0x00005153
	public virtual void vmethod_105()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = true;
		this.method_50();
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x00006F81 File Offset: 0x00005181
	public virtual void vmethod_106()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = true;
		this.method_58();
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x0006328C File Offset: 0x0006148C
	private void method_53()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967271u)
		{
			if (num <= 5u)
			{
				if (num != 57u)
				{
					if (num != 4294967277u)
					{
						if (num == 4294967248u)
						{
							if (string_ == "song")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "</color> ")
					{
						text = this.gclass5_0.method_9();
						Application.runInBackground = this.gclass5_0.method_4();
						goto IL_1EA;
					}
				}
				else if (string_ == "preview_volume")
				{
					goto IL_1DE;
				}
			}
			else if (num != 100u)
			{
				if (num != 4294967097u)
				{
					if (num == 4294967187u)
					{
						if (string_ == "target_framerate")
						{
							text = GClass4.gclass4_0.method_7(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "genre")
				{
					text = this.gclass5_0.String_2 + "";
					goto IL_1EA;
				}
			}
			else if (string_ == "video")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967228u)
		{
			if (num != 4294967284u)
			{
				if (num != 161u)
				{
					if (num == 65u)
					{
						if (string_ == "B: 00:00:00")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "msaa")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Connecting to server...\nServer: ")
			{
				goto IL_1DE;
			}
		}
		else if (num != 10u)
		{
			if (num != 4294967191u)
			{
				if (num == 24u)
				{
					if (string_ == "Album")
					{
						text = this.gclass5_0.String_1;
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "delay")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "%count%")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_10();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00063498 File Offset: 0x00061698
	private void method_54()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 53u)
		{
			if (num <= 28u)
			{
				if (num != 4294967142u)
				{
					if (num != 4294967147u)
					{
						if (num == 4294967236u)
						{
							if (string_ == "debug_fps")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "vsync")
					{
						text = this.gclass5_0.method_10();
						Application.runInBackground = !this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "Guitar Coop")
				{
					goto IL_1DE;
				}
			}
			else if (num != 150u)
			{
				if (num != 75u)
				{
					if (num == 49u)
					{
						if (string_ == "0")
						{
							text = GClass4.gclass4_0.method_5(SongDirectory.string_0[this.gclass5_0.method_5()]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "path")
				{
					text = this.gclass5_0.String_2 + "Menu Music";
					goto IL_1EA;
				}
			}
			else if (string_ == "All Strums")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 30u)
		{
			if (num != 4294967288u)
			{
				if (num != 176u)
				{
					if (num == 4294967225u)
					{
						if (string_ == "Play Count")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "client_info")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "")
			{
				goto IL_1DE;
			}
		}
		else if (num != 143u)
		{
			if (num != 111u)
			{
				if (num == 137u)
				{
					if (string_ == "%")
					{
						text = this.gclass5_0.String_1;
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "Cancel")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "Songs")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.String_0;
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x000636A4 File Offset: 0x000618A4
	public override void vmethod_39()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.String_0;
			string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 2087995404u)
			{
				if (num <= 1268920152u)
				{
					if (num != 554341610u)
					{
						if (num != 972458324u)
						{
							if (num == 1268920152u)
							{
								if (string_ == "Song Preview")
								{
									this.gclass5_0 = GlobalVariables.instance.gclass5_26;
								}
							}
						}
						else if (string_ == "Pause on Focus Lost")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_28;
						}
					}
					else if (string_ == "Highway Shake")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_29;
					}
				}
				else if (num <= 1485671700u)
				{
					if (num != 1351274325u)
					{
						if (num == 1485671700u)
						{
							if (string_ == "Controller Poll Rate")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_16;
							}
						}
					}
					else if (string_ == "Allow Duplicate Songs")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_43;
					}
				}
				else if (num != 1976894744u)
				{
					if (num == 2087995404u)
					{
						if (string_ == "Mute Track on Miss")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_31;
						}
					}
				}
				else if (string_ == "Default Sort Filter")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_6;
				}
			}
			else if (num <= 3148303310u)
			{
				if (num <= 2209223988u)
				{
					if (num != 2125539120u)
					{
						if (num == 2209223988u)
						{
							if (string_ == "Star Animation FPS")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_40;
							}
						}
					}
					else if (string_ == "Note Animation FPS")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_39;
					}
				}
				else if (num != 2770175893u)
				{
					if (num == 3148303310u)
					{
						if (string_ == "No Fail")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_21;
						}
					}
				}
				else if (string_ == "Menu Music")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_30;
				}
			}
			else if (num <= 3502736215u)
			{
				if (num != 3235865788u)
				{
					if (num == 3502736215u)
					{
						if (string_ == "Show Bot Score")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_41;
						}
					}
				}
				else if (string_ == "Show Lyrics")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_45;
				}
			}
			else if (num != 3558350423u)
			{
				if (num == 3924729133u)
				{
					if (string_ == "Gem Size")
					{
						this.gclass5_0 = GlobalVariables.instance.gemSize;
					}
				}
			}
			else if (string_ == "Song Speed")
			{
				this.gclass5_0 = GlobalVariables.instance.songSpeed;
			}
			this.method_58();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "Menu Music"))
		{
			if (string_ == "Controller Poll Rate")
			{
				ReInput.configuration.joystickRefreshRate = this.gclass5_0.CurrentValue;
			}
		}
		else if (this.gclass5_0.Boolean_1)
		{
			if (!BassAudioManager.instance.isSongPlaying)
			{
				BassAudioManager.instance.PlayMenuMusic();
			}
		}
		else
		{
			BassAudioManager.instance.method_56(false);
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_50();
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00006FAF File Offset: 0x000051AF
	public virtual void vmethod_107()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.optionsMenu.bool_10 = true;
		this.method_50();
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00006C89 File Offset: 0x00004E89
	public virtual void vmethod_108()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(false);
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00006D1B File Offset: 0x00004F1B
	public virtual void vmethod_109()
	{
		if (this.string_0 != null)
		{
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.vmethod_15();
		this.optionsMenu.gameObject.SetActive(true);
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x00006FDD File Offset: 0x000051DD
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_58();
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00063A3C File Offset: 0x00061C3C
	private void method_55()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 198u)
		{
			if (num <= 71u)
			{
				if (num != 4294967128u)
				{
					if (num != 4294967152u)
					{
						if (num == 44u)
						{
							if (string_ == "Yes")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "Gameplay")
					{
						text = this.gclass5_0.method_9();
						Application.runInBackground = this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "\\d+")
				{
					goto IL_1DE;
				}
			}
			else if (num != 116u)
			{
				if (num != 4294967154u)
				{
					if (num == 31u)
					{
						if (string_ == "_ENDOFSONG")
						{
							text = GClass4.gclass4_0.method_5(SongDirectory.string_0[this.gclass5_0.method_25()]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "N/A")
				{
					text = this.gclass5_0.String_2 + "";
					goto IL_1EA;
				}
			}
			else if (string_ == "Lead Guitar")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967274u)
		{
			if (num != 50u)
			{
				if (num != 4294967293u)
				{
					if (num == 114u)
					{
						if (string_ == "Audio Settings")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "Rhythm Guitar")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Enable Lanes")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967219u)
		{
			if (num != 4294967195u)
			{
				if (num == 197u)
				{
					if (string_ == "")
					{
						text = this.gclass5_0.method_28();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "video")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_10();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x0000700B File Offset: 0x0000520B
	public virtual void vmethod_110()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_27();
		this.optionsMenu.bool_10 = false;
		this.method_45();
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00007039 File Offset: 0x00005239
	public virtual void vmethod_111()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = false;
		this.method_50();
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x00063C48 File Offset: 0x00061E48
	private void method_56()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 52u)
		{
			if (num <= 4294967194u)
			{
				if (num != 160u)
				{
					if (num != 16u)
					{
						if (num == 4294967185u)
						{
							if (string_ == "Game Manager")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == ".mp4|.avi|.webm|.vp8|.ogv|.mpeg")
					{
						text = this.gclass5_0.method_9();
						Application.runInBackground = this.gclass5_0.method_4();
						goto IL_1EA;
					}
				}
				else if (string_ == "Create Profile")
				{
					goto IL_1DE;
				}
			}
			else if (num != 4294967235u)
			{
				if (num != 4294967276u)
				{
					if (num == 4294967185u)
					{
						if (string_ == "Player2 = \\w+")
						{
							text = GClass4.gclass4_0.method_15(SongDirectory.string_0[this.gclass5_0.method_5()]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "Lead Guitar")
				{
					text = this.gclass5_0.String_2 + "";
					goto IL_1EA;
				}
			}
			else if (string_ == "_ENDOFSONG")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967175u)
		{
			if (num != 68u)
			{
				if (num != 2u)
				{
					if (num == 93u)
					{
						if (string_ == "Quit")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "song")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "nomodifiers")
			{
				goto IL_1DE;
			}
		}
		else if (num != 4294967265u)
		{
			if (num != 131u)
			{
				if (num == 4294967173u)
				{
					if (string_ == "sp_awarded")
					{
						text = this.gclass5_0.method_26();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "Artist = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "song")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_10();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00063E54 File Offset: 0x00062054
	public virtual void vmethod_112()
	{
		string string_;
		if (this.string_0 == null)
		{
			this.string_0 = base.method_39();
			string_ = this.string_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 4294967210u)
			{
				if (num <= 4294967245u)
				{
					if (num != 60u)
					{
						if (num != 4294967222u)
						{
							if (num == 29u)
							{
								if (string_ == "Expert")
								{
									this.gclass5_0 = GlobalVariables.instance.gclass5_26;
								}
							}
						}
						else if (string_ == "MSAA Level")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_28;
						}
					}
					else if (string_ == "name")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_29;
					}
				}
				else if (num <= 160u)
				{
					if (num != 76u)
					{
						if (num == 187u)
						{
							if (string_ == "song")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_16;
							}
						}
					}
					else if (string_ == "%")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_43;
					}
				}
				else if (num != 4294967134u)
				{
					if (num == 4294967156u)
					{
						if (string_ == ")")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_31;
						}
					}
				}
				else if (string_ == "Expert")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_6;
				}
			}
			else if (num <= 174u)
			{
				if (num <= 4294967162u)
				{
					if (num != 4294967266u)
					{
						if (num == 112u)
						{
							if (string_ == "video")
							{
								this.gclass5_0 = GlobalVariables.instance.gclass5_40;
							}
						}
					}
					else if (string_ == "")
					{
						this.gclass5_0 = GlobalVariables.instance.gclass5_39;
					}
				}
				else if (num != 4294967123u)
				{
					if (num == 4294967123u)
					{
						if (string_ == "bassinitfail")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_21;
						}
					}
				}
				else if (string_ == "icon")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_30;
				}
			}
			else if (num <= 4294967230u)
			{
				if (num != 4294967176u)
				{
					if (num == 124u)
					{
						if (string_ == "Okay")
						{
							this.gclass5_0 = GlobalVariables.instance.gclass5_41;
						}
					}
				}
				else if (string_ == "Modifiers")
				{
					this.gclass5_0 = GlobalVariables.instance.gclass5_45;
				}
			}
			else if (num != 4294967261u)
			{
				if (num == 4294967219u)
				{
					if (string_ == "Highway Placement")
					{
						this.gclass5_0 = GlobalVariables.instance.gemSize;
					}
				}
			}
			else if (string_ == "You must restart, settings were changed")
			{
				this.gclass5_0 = GlobalVariables.instance.songSpeed;
			}
			this.method_58();
			return;
		}
		string_ = this.string_0;
		if (!(string_ == "Mute Track on Miss"))
		{
			if (string_ == "volume")
			{
				ReInput.configuration.joystickRefreshRate = this.gclass5_0.CurrentValue;
			}
		}
		else if (this.gclass5_0.Boolean_1)
		{
			if (!BassAudioManager.instance.isSongPlaying)
			{
				BassAudioManager.instance.PlayMenuMusic();
			}
		}
		else
		{
			BassAudioManager.instance.method_56(false);
		}
		this.gclass5_0 = null;
		this.string_0 = null;
		this.vmethod_30();
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00007067 File Offset: 0x00005267
	public virtual void vmethod_113()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_7();
		this.optionsMenu.bool_10 = true;
		this.method_58();
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x000641EC File Offset: 0x000623EC
	private void method_57()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 111u)
		{
			if (num <= 4294967246u)
			{
				if (num != 108u)
				{
					if (num != 27u)
					{
						if (num == 4294967173u)
						{
							if (string_ == "game")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == " (")
					{
						text = this.gclass5_0.method_10();
						Application.runInBackground = !this.gclass5_0.method_4();
						goto IL_1EA;
					}
				}
				else if (string_ == "Easy")
				{
					goto IL_1DE;
				}
			}
			else if (num != 100u)
			{
				if (num != 4294967261u)
				{
					if (num == 142u)
					{
						if (string_ == "Bad file type")
						{
							text = GClass4.gclass4_0.method_35(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "genre")
				{
					text = this.gclass5_0.String_2 + "Quit";
					goto IL_1EA;
				}
			}
			else if (string_ == "Build: ")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 4294967233u)
		{
			if (num != 132u)
			{
				if (num != 4294967199u)
				{
					if (num == 4294967216u)
					{
						if (string_ == "+")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "no_fail")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "READING CACHE...")
			{
				goto IL_1DE;
			}
		}
		else if (num != 155u)
		{
			if (num != 4294967165u)
			{
				if (num == 4294967102u)
				{
					if (string_ == "framerate")
					{
						text = this.gclass5_0.method_1();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "path")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "isHidden")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.method_10();
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x000643F8 File Offset: 0x000625F8
	private void method_58()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 1976894744u)
		{
			if (num <= 1268920152u)
			{
				if (num != 554341610u)
				{
					if (num != 972458324u)
					{
						if (num == 1268920152u)
						{
							if (string_ == "Song Preview")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "Pause on Focus Lost")
					{
						text = this.gclass5_0.String_0;
						Application.runInBackground = !this.gclass5_0.Boolean_1;
						goto IL_1EA;
					}
				}
				else if (string_ == "Highway Shake")
				{
					goto IL_1DE;
				}
			}
			else if (num != 1351274325u)
			{
				if (num != 1485671700u)
				{
					if (num == 1976894744u)
					{
						if (string_ == "Default Sort Filter")
						{
							text = GClass4.gclass4_0.method_13(SongDirectory.string_0[this.gclass5_0.CurrentValue]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "Controller Poll Rate")
				{
					text = this.gclass5_0.String_2 + "Hz";
					goto IL_1EA;
				}
			}
			else if (string_ == "Allow Duplicate Songs")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 3148303310u)
		{
			if (num != 2087995404u)
			{
				if (num != 2770175893u)
				{
					if (num == 3148303310u)
					{
						if (string_ == "No Fail")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "Menu Music")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Mute Track on Miss")
			{
				goto IL_1DE;
			}
		}
		else if (num != 3235865788u)
		{
			if (num != 3502736215u)
			{
				if (num == 3558350423u)
				{
					if (string_ == "Song Speed")
					{
						text = this.gclass5_0.String_1;
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "Show Bot Score")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "Show Lyrics")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.String_0;
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00064604 File Offset: 0x00062804
	private void method_59()
	{
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		string text;
		if (num <= 4294967223u)
		{
			if (num <= 153u)
			{
				if (num != 81u)
				{
					if (num != 4294967261u)
					{
						if (num == 4294967129u)
						{
							if (string_ == "Unknown Charter")
							{
								goto IL_1DE;
							}
						}
					}
					else if (string_ == "streamer")
					{
						text = this.gclass5_0.method_10();
						Application.runInBackground = !this.gclass5_0.method_30();
						goto IL_1EA;
					}
				}
				else if (string_ == "Okay")
				{
					goto IL_1DE;
				}
			}
			else if (num != 4294967196u)
			{
				if (num != 16u)
				{
					if (num == 4294967148u)
					{
						if (string_ == " - ")
						{
							text = GClass4.gclass4_0.method_30(SongDirectory.string_0[this.gclass5_0.method_25()]);
							goto IL_1EA;
						}
					}
				}
				else if (string_ == "")
				{
					text = this.gclass5_0.String_2 + "Unknown Album";
					goto IL_1EA;
				}
			}
			else if (string_ == "graphics_devid")
			{
				goto IL_1DE;
			}
		}
		else if (num <= 126u)
		{
			if (num != 4294967289u)
			{
				if (num != 4294967121u)
				{
					if (num == 4294967100u)
					{
						if (string_ == "Press Enter to confirm")
						{
							goto IL_1DE;
						}
					}
				}
				else if (string_ == "Unknown Year")
				{
					goto IL_1DE;
				}
			}
			else if (string_ == "Restart")
			{
				goto IL_1DE;
			}
		}
		else if (num != 119u)
		{
			if (num != 111u)
			{
				if (num == 4294967147u)
				{
					if (string_ == "audio")
					{
						text = this.gclass5_0.method_26();
						goto IL_1EA;
					}
				}
			}
			else if (string_ == "Failed to get data privacy url: {0}")
			{
				goto IL_1DE;
			}
		}
		else if (string_ == "SONG SETTINGS")
		{
			goto IL_1DE;
		}
		text = this.gclass5_0.String_2;
		goto IL_1EA;
		IL_1DE:
		text = this.gclass5_0.String_0;
		IL_1EA:
		this.textObjects[this.int_1].text = text;
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00007095 File Offset: 0x00005295
	public virtual void vmethod_114()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_2();
		this.optionsMenu.bool_10 = false;
		this.method_55();
	}

	// Token: 0x04000205 RID: 517
	[SerializeField]
	private BaseMenu optionsMenu;
}
