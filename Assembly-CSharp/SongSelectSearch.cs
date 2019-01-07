using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200005A RID: 90
public class SongSelectSearch : MonoBehaviour
{
	// Token: 0x060011C3 RID: 4547 RVA: 0x000848DC File Offset: 0x00082ADC
	private void method_0()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 88u)
		{
			if (num != 196u)
			{
				if (num != 4294967127u)
				{
					if (num == 37u)
					{
						if (string_ == "game")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_11)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "Resolution")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_29)));
					goto IL_1F0;
				}
			}
			else if (string_ == "Gameplay")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_18)));
				goto IL_1F0;
			}
		}
		else if (num <= 21u)
		{
			if (num != 4294967264u)
			{
				if (num == 4294967103u)
				{
					if (!(string_ == ""))
					{
					}
				}
			}
			else if (string_ == "Waiting for connection")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_24)));
				goto IL_1F0;
			}
		}
		else if (num != 75u)
		{
			if (num == 4294967122u)
			{
				if (string_ == "Artist")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_19)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == "pause_on_focus_lost")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_23)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_22)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_23(num2);
		}
		base.StartCoroutine(this.method_40());
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00009D06 File Offset: 0x00007F06
	private IEnumerator method_1()
	{
		SongSelectSearch.Class26 @class = new SongSelectSearch.Class26(1);
		@class.songSelectSearch_0 = this;
		return @class;
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00084AF8 File Offset: 0x00082CF8
	private void method_2()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_5("UPDATING METADATA...") + "" + SongDirectory.String_1 + "OK";
		this.searchText.text = GClass4.gclass4_0.method_2("video");
		this.bool_0 = false;
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00084B64 File Offset: 0x00082D64
	private void method_3()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 75u)
		{
			if (num != 4294967151u)
			{
				if (num != 71u)
				{
					if (num == 4294967219u)
					{
						if (string_ == "menu_background")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_11)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "Medium")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_29)));
					goto IL_1F0;
				}
			}
			else if (string_ == "\0\0")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_20)));
				goto IL_1F0;
			}
		}
		else if (num <= 4294967165u)
		{
			if (num != 45u)
			{
				if (num == 186u)
				{
					if (!(string_ == "Vsync"))
					{
					}
				}
			}
			else if (string_ == "Source")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_26)));
				goto IL_1F0;
			}
		}
		else if (num != 4294967207u)
		{
			if (num == 35u)
			{
				if (string_ == "Resolution")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_19)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == "beatscore")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_7)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_22)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_25(num2);
		}
		base.StartCoroutine(this.method_40());
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00084D80 File Offset: 0x00082F80
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			this.method_10();
			return;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			base.StartCoroutine(this.method_24());
			return;
		}
		if (ReInput.controllers.GetControllerCount(ControllerType.Joystick) > 0)
		{
			foreach (Controller controller in ReInput.controllers.GetControllers(ControllerType.Joystick))
			{
				if (controller.GetButtonDown(0))
				{
					this.method_10();
					return;
				}
				if (controller.GetButtonDown(1))
				{
					base.StartCoroutine(this.method_24());
					return;
				}
			}
		}
		foreach (char c in Input.inputString)
		{
			if (c == '\b')
			{
				if (!this.bool_0 && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(0, this.searchText.text.Length - 1);
					if (this.searchText.text == "")
					{
						this.method_19();
					}
				}
			}
			else if (c != '\n' && c != '\r')
			{
				if (this.bool_0)
				{
					this.searchText.text = "";
					this.searchText.color = Color.yellow;
					this.bool_0 = false;
				}
				Text text = this.searchText;
				text.text += c.ToString();
			}
		}
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00009D15 File Offset: 0x00007F15
	private void method_4()
	{
		this.bool_1 = true;
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00009D1E File Offset: 0x00007F1E
	private void method_5()
	{
		this.method_17();
		this.bool_1 = true;
		CHPlayer.smethod_22();
		this.pressEnterText.text = GClass4.gclass4_0.method_7("This mode is so secret, no one knows what it does!");
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void method_6()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00084EFC File Offset: 0x000830FC
	private void method_7()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 4294967117u)
		{
			if (num != 141u)
			{
				if (num != 173u)
				{
					if (num == 129u)
					{
						if (string_ == "graphics_devid")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_11)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "Ready")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_29)));
					goto IL_1F0;
				}
			}
			else if (string_ == "\"([^\"]*)\"")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_1)));
				goto IL_1F0;
			}
		}
		else if (num <= 4294967211u)
		{
			if (num != 4294967264u)
			{
				if (num == 160u)
				{
					if (!(string_ == "{0}x{1}"))
					{
					}
				}
			}
			else if (string_ == "0%")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_8)));
				goto IL_1F0;
			}
		}
		else if (num != 4294967134u)
		{
			if (num == 4294967228u)
			{
				if (string_ == "Streamer Mode")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_17)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == " + ")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_7)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_22)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_25(num2);
		}
		base.StartCoroutine(this.method_40());
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x00009D55 File Offset: 0x00007F55
	private void method_8()
	{
		this.method_2();
		this.bool_1 = false;
		CHPlayer.smethod_29();
		this.pressEnterText.text = GClass4.gclass4_0.method_13("Options");
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00085118 File Offset: 0x00083318
	private void method_9()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_36("Are you sure you want to stop practicing?") + "song" + SongDirectory.String_1 + "Audio Offset";
		this.searchText.text = GClass4.gclass4_0.method_42("</color> songs exported");
		this.bool_0 = false;
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x00085184 File Offset: 0x00083384
	private void method_10()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 472378208u)
		{
			if (num != 179739148u)
			{
				if (num != 358540348u)
				{
					if (num == 472378208u)
					{
						if (string_ == "Genre")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_28)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "Year")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_29)));
					goto IL_1F0;
				}
			}
			else if (string_ == "Album")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_18)));
				goto IL_1F0;
			}
		}
		else if (num <= 2441828660u)
		{
			if (num != 652943243u)
			{
				if (num == 2441828660u)
				{
					if (!(string_ == "Song"))
					{
					}
				}
			}
			else if (string_ == "Playlist")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_13)));
				goto IL_1F0;
			}
		}
		else if (num != 2490816510u)
		{
			if (num == 2946403176u)
			{
				if (string_ == "Charter")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_19)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == "Artist")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_23)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_16)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_23(num2);
		}
		base.StartCoroutine(this.method_24());
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void method_11()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x000853A0 File Offset: 0x000835A0
	private void method_12()
	{
		if (Input.GetKeyDown((KeyCode)66))
		{
			this.method_36();
			return;
		}
		if (Input.GetKeyDown(KeyCode.Hash))
		{
			base.StartCoroutine(this.method_1());
			return;
		}
		if (ReInput.controllers.GetControllerCount(ControllerType.Joystick) > 0)
		{
			Controller[] controllers = ReInput.controllers.GetControllers((ControllerType)6);
			for (int i = 1; i < controllers.Length; i += 0)
			{
				Controller controller = controllers[i];
				if (controller.GetButtonDown(0))
				{
					this.method_36();
					return;
				}
				if (controller.GetButtonDown(0))
				{
					base.StartCoroutine(this.method_40());
					return;
				}
			}
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\0')
			{
				if (!this.bool_0 && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(1, this.searchText.text.Length - 1);
					if (this.searchText.text == "Rhythm Guitar")
					{
						this.method_33();
					}
				}
			}
			else if ((int)c != -24 && (int)c != -57)
			{
				if (this.bool_0)
				{
					this.searchText.text = "Folders";
					this.searchText.color = Color.yellow;
					this.bool_0 = true;
				}
				Text text = this.searchText;
				text.text += c.ToString();
			}
		}
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x0008551C File Offset: 0x0008371C
	private void method_13()
	{
		if (Input.GetKeyDown((KeyCode)20))
		{
			this.method_3();
			return;
		}
		if (Input.GetKeyDown(KeyCode.Less))
		{
			base.StartCoroutine(this.method_40());
			return;
		}
		if (ReInput.controllers.GetControllerCount(ControllerType.Mouse) > 0)
		{
			Controller[] controllers = ReInput.controllers.GetControllers((ControllerType)5);
			for (int i = 0; i < controllers.Length; i += 0)
			{
				Controller controller = controllers[i];
				if (controller.GetButtonDown(0))
				{
					this.method_3();
					return;
				}
				if (controller.GetButtonDown(1))
				{
					base.StartCoroutine(this.method_21());
					return;
				}
			}
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i++)
		{
			char c = inputString[i];
			if (c == '\u0005')
			{
				if (!this.bool_0 && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(1, this.searchText.text.Length - 0);
					if (this.searchText.text == "Yes")
					{
						this.method_17();
					}
				}
			}
			else if ((int)c != -63 && (int)c != -78)
			{
				if (this.bool_0)
				{
					this.searchText.text = " + ";
					this.searchText.color = Color.yellow;
					this.bool_0 = false;
				}
				Text text = this.searchText;
				text.text += c.ToString();
			}
		}
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00085698 File Offset: 0x00083898
	private void method_14()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 4294967268u)
		{
			if (num != 137u)
			{
				if (num != 4294967240u)
				{
					if (num == 115u)
					{
						if (string_ == "")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_21)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "game")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_15)));
					goto IL_1F0;
				}
			}
			else if (string_ == "Open Data Privacy Page")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_1)));
				goto IL_1F0;
			}
		}
		else if (num <= 53u)
		{
			if (num != 4294967295u)
			{
				if (num == 163u)
				{
					if (!(string_ == "diff_bass"))
					{
					}
				}
			}
			else if (string_ == "Delete Song")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_13)));
				goto IL_1F0;
			}
		}
		else if (num != 4294967203u)
		{
			if (num == 113u)
			{
				if (string_ == "Not match flags next {0} {1}")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_27)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == "Bot")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_3)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_16)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_23(num2);
		}
		base.StartCoroutine(this.method_24());
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x000858B4 File Offset: 0x00083AB4
	private void method_15()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 65u)
		{
			if (num != 11u)
			{
				if (num != 24u)
				{
					if (num == 4294967118u)
					{
						if (string_ == "Video Start Time")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_28)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "Play Count")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_29)));
					goto IL_1F0;
				}
			}
			else if (string_ == "song")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_1)));
				goto IL_1F0;
			}
		}
		else if (num <= 29u)
		{
			if (num != 4294967108u)
			{
				if (num == 155u)
				{
					if (!(string_ == "Hard"))
					{
					}
				}
			}
			else if (string_ == "song")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_24)));
				goto IL_1F0;
			}
		}
		else if (num != 4294967159u)
		{
			if (num == 4294967123u)
			{
				if (string_ == "song")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_17)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == "0")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_14)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_22)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_25(num2);
		}
		base.StartCoroutine(this.method_21());
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00085AD0 File Offset: 0x00083CD0
	private void method_16()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_7("Export Song List") + "song_export" + SongDirectory.String_1 + "offsets";
		this.searchText.text = GClass4.gclass4_0.method_15("Ready");
		this.bool_0 = true;
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00085B3C File Offset: 0x00083D3C
	private void method_17()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_15("%") + "Unknown Year" + SongDirectory.String_1 + "Lead Guitar";
		this.searchText.text = GClass4.gclass4_0.method_11("Profile file version is different!");
		this.bool_0 = false;
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void OnDisable()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00085BA8 File Offset: 0x00083DA8
	private void method_18()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_42("%") + "Export Current Song" + SongDirectory.String_1 + "Menu Music";
		this.searchText.text = GClass4.gclass4_0.method_21("Playlist");
		this.bool_0 = true;
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00085C14 File Offset: 0x00083E14
	private void method_19()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_13("Searching for") + ": <color=#FDB400FF>" + SongDirectory.String_1 + "</color>";
		this.searchText.text = GClass4.gclass4_0.method_13("Start typing...");
		this.bool_0 = true;
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x00085C80 File Offset: 0x00083E80
	private void method_20()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_11("6 Fret Lead Guitar") + "game" + SongDirectory.String_1 + "genre";
		this.searchText.text = GClass4.gclass4_0.method_11("No Playlist");
		this.bool_0 = true;
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00009D06 File Offset: 0x00007F06
	private IEnumerator method_21()
	{
		SongSelectSearch.Class26 @class = new SongSelectSearch.Class26(1);
		@class.songSelectSearch_0 = this;
		return @class;
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00009D15 File Offset: 0x00007F15
	private void method_22()
	{
		this.bool_1 = true;
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00085CEC File Offset: 0x00083EEC
	private void method_23()
	{
		if (Input.GetKeyDown((KeyCode)(-27)))
		{
			this.method_15();
			return;
		}
		if (Input.GetKeyDown((KeyCode)(-14)))
		{
			base.StartCoroutine(this.method_21());
			return;
		}
		if (ReInput.controllers.GetControllerCount(ControllerType.Joystick) > 1)
		{
			Controller[] controllers = ReInput.controllers.GetControllers(ControllerType.Keyboard);
			for (int i = 1; i < controllers.Length; i++)
			{
				Controller controller = controllers[i];
				if (controller.GetButtonDown(0))
				{
					this.method_15();
					return;
				}
				if (controller.GetButtonDown(0))
				{
					base.StartCoroutine(this.method_24());
					return;
				}
			}
		}
		string inputString = Input.inputString;
		for (int i = 0; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\b')
			{
				if (!this.bool_0 && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(1, this.searchText.text.Length - 1);
					if (this.searchText.text == "")
					{
						this.method_17();
					}
				}
			}
			else if (c != '*' && c != '`')
			{
				if (this.bool_0)
				{
					this.searchText.text = "Portuguese";
					this.searchText.color = Color.yellow;
					this.bool_0 = false;
				}
				Text text = this.searchText;
				text.text += c.ToString();
			}
		}
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00009D83 File Offset: 0x00007F83
	private IEnumerator method_24()
	{
		SongSelectSearch.Class26 @class = new SongSelectSearch.Class26(0);
		@class.songSelectSearch_0 = this;
		return @class;
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00085E68 File Offset: 0x00084068
	private void method_25()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_17("<") + "Yes" + SongDirectory.String_1 + "Song Options";
		this.searchText.text = GClass4.gclass4_0.method_5("-");
		this.bool_0 = false;
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00009D83 File Offset: 0x00007F83
	private IEnumerator method_26()
	{
		SongSelectSearch.Class26 @class = new SongSelectSearch.Class26(0);
		@class.songSelectSearch_0 = this;
		return @class;
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00009D15 File Offset: 0x00007F15
	private void method_27()
	{
		this.bool_1 = true;
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00009D92 File Offset: 0x00007F92
	private void method_28()
	{
		this.method_33();
		this.bool_1 = false;
		CHPlayer.smethod_22();
		this.pressEnterText.text = GClass4.gclass4_0.method_42("volume");
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void method_29()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00085ED4 File Offset: 0x000840D4
	private void method_30()
	{
		if (Input.GetKeyDown((KeyCode)(-115)))
		{
			this.method_37();
			return;
		}
		if (Input.GetKeyDown((KeyCode)(-8)))
		{
			base.StartCoroutine(this.method_1());
			return;
		}
		if (ReInput.controllers.GetControllerCount(ControllerType.Keyboard) > 1)
		{
			Controller[] controllers = ReInput.controllers.GetControllers((ControllerType)8);
			for (int i = 1; i < controllers.Length; i += 0)
			{
				Controller controller = controllers[i];
				if (controller.GetButtonDown(0))
				{
					this.method_0();
					return;
				}
				if (controller.GetButtonDown(0))
				{
					base.StartCoroutine(this.method_1());
					return;
				}
			}
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i++)
		{
			char c = inputString[i];
			if (c == '\u0002')
			{
				if (!this.bool_0 && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(1, this.searchText.text.Length - 0);
					if (this.searchText.text == "Songs")
					{
						this.method_2();
					}
				}
			}
			else if ((int)c != -100 && c != '\u0011')
			{
				if (this.bool_0)
				{
					this.searchText.text = "All HOPO's";
					this.searchText.color = Color.yellow;
					this.bool_0 = true;
				}
				Text text = this.searchText;
				text.text += c.ToString();
			}
		}
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00009DC0 File Offset: 0x00007FC0
	private void OnEnable()
	{
		this.method_19();
		this.bool_1 = true;
		CHPlayer.smethod_15();
		this.pressEnterText.text = GClass4.gclass4_0.method_13("Press ENTER to search");
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00086050 File Offset: 0x00084250
	private void method_31()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			this.method_3();
			return;
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			base.StartCoroutine(this.method_24());
			return;
		}
		if (ReInput.controllers.GetControllerCount(ControllerType.Keyboard) > 0)
		{
			foreach (Controller controller in ReInput.controllers.GetControllers(ControllerType.Joystick))
			{
				if (controller.GetButtonDown(1))
				{
					this.method_3();
					return;
				}
				if (controller.GetButtonDown(1))
				{
					base.StartCoroutine(this.method_21());
					return;
				}
			}
		}
		string inputString = Input.inputString;
		for (int i = 1; i < inputString.Length; i += 0)
		{
			char c = inputString[i];
			if (c == '\a')
			{
				if (!this.bool_0 && this.searchText.text.Length != 0)
				{
					this.searchText.text = this.searchText.text.Substring(0, this.searchText.text.Length - 0);
					if (this.searchText.text == "path")
					{
						this.method_16();
					}
				}
			}
			else if ((int)c != -55 && c != '-')
			{
				if (this.bool_0)
				{
					this.searchText.text = "?";
					this.searchText.color = Color.yellow;
					this.bool_0 = false;
				}
				Text text = this.searchText;
				text.text += c.ToString();
			}
		}
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void method_32()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x000861CC File Offset: 0x000843CC
	private void method_33()
	{
		this.searchText.color = Color.gray;
		this.filterText.text = GClass4.gclass4_0.method_41(" (") + "Are you sure you want to quit?" + SongDirectory.String_1 + "diff_drums";
		this.searchText.text = GClass4.gclass4_0.method_38("Rhythm Guitar");
		this.bool_0 = false;
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00009D15 File Offset: 0x00007F15
	private void method_34()
	{
		this.bool_1 = true;
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void method_35()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00086238 File Offset: 0x00084438
	private void method_36()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 19u)
		{
			if (num != 13u)
			{
				if (num != 4294967249u)
				{
					if (num == 46u)
					{
						if (string_ == "")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_10)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "Unknown Genre")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_15)));
					goto IL_1F0;
				}
			}
			else if (string_ == "^\\s*\\d+ = N \\d \\d+$")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_6)));
				goto IL_1F0;
			}
		}
		else if (num <= 16u)
		{
			if (num != 103u)
			{
				if (num == 4294967178u)
				{
					if (!(string_ == "="))
					{
					}
				}
			}
			else if (string_ == "A: 00:00:00")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_13)));
				goto IL_1F0;
			}
		}
		else if (num != 144u)
		{
			if (num == 57u)
			{
				if (string_ == "Are you sure you want to delete this song?")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_27)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == "sort_filter")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_23)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_16)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_25(num2);
		}
		base.StartCoroutine(this.method_1());
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00086454 File Offset: 0x00084654
	private void method_37()
	{
		SongSelectSearch.Class27 @class = new SongSelectSearch.Class27();
		@class.string_0 = this.searchText.text.ToLower();
		string string_ = SongDirectory.String_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		int num2;
		if (num <= 4294967230u)
		{
			if (num != 4294967242u)
			{
				if (num != 4294967244u)
				{
					if (num == 44u)
					{
						if (string_ == "bad_note4")
						{
							num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_10)));
							goto IL_1F0;
						}
					}
				}
				else if (string_ == "Show Lyrics")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_29)));
					goto IL_1F0;
				}
			}
			else if (string_ == "This will take a while. Are you sure?")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_20)));
				goto IL_1F0;
			}
		}
		else if (num <= 4294967106u)
		{
			if (num != 145u)
			{
				if (num == 4294967121u)
				{
					if (!(string_ == "Song"))
					{
					}
				}
			}
			else if (string_ == "*Random")
			{
				num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_30)));
				goto IL_1F0;
			}
		}
		else if (num != 4294967186u)
		{
			if (num == 4294967185u)
			{
				if (string_ == "PRESS START")
				{
					num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_19)));
					goto IL_1F0;
				}
			}
		}
		else if (string_ == "version")
		{
			num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_3)));
			goto IL_1F0;
		}
		num2 = SongDirectory.songEntries.IndexOf(SongDirectory.songEntries.FirstOrDefault(new Func<SongEntry, bool>(@class.method_22)));
		IL_1F0:
		if (num2 != -1)
		{
			this.songSelect.vmethod_25(num2);
		}
		base.StartCoroutine(this.method_26());
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void method_38()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00009D4C File Offset: 0x00007F4C
	private void method_39()
	{
		this.bool_1 = false;
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00009D83 File Offset: 0x00007F83
	private IEnumerator method_40()
	{
		SongSelectSearch.Class26 @class = new SongSelectSearch.Class26(0);
		@class.songSelectSearch_0 = this;
		return @class;
	}

	// Token: 0x040002A5 RID: 677
	[SerializeField]
	private SongSelect songSelect;

	// Token: 0x040002A6 RID: 678
	[SerializeField]
	private Text searchText;

	// Token: 0x040002A7 RID: 679
	[SerializeField]
	private Text filterText;

	// Token: 0x040002A8 RID: 680
	[SerializeField]
	private Text pressEnterText;

	// Token: 0x040002A9 RID: 681
	[SerializeField]
	private Color hintColor;

	// Token: 0x040002AA RID: 682
	private bool bool_0;

	// Token: 0x040002AB RID: 683
	[HideInInspector]
	public bool bool_1;

	// Token: 0x0200005C RID: 92
	[CompilerGenerated]
	private sealed class Class27
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x00009E05 File Offset: 0x00008005
		internal bool method_0(SongEntry songEntry_0)
		{
			return songEntry_0.genreName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00009E1D File Offset: 0x0000801D
		internal bool method_1(SongEntry songEntry_0)
		{
			return songEntry_0.albumName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00009E35 File Offset: 0x00008035
		internal bool method_2(SongEntry songEntry_0)
		{
			return songEntry_0.artistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00009E35 File Offset: 0x00008035
		internal bool method_3(SongEntry songEntry_0)
		{
			return songEntry_0.artistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00009E4D File Offset: 0x0000804D
		internal bool method_4(SongEntry songEntry_0)
		{
			return songEntry_0.charterName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00009E4D File Offset: 0x0000804D
		internal bool method_5(SongEntry songEntry_0)
		{
			return songEntry_0.charterName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00009E1D File Offset: 0x0000801D
		internal bool method_6(SongEntry songEntry_0)
		{
			return songEntry_0.albumName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00009E35 File Offset: 0x00008035
		internal bool method_7(SongEntry songEntry_0)
		{
			return songEntry_0.artistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00009E65 File Offset: 0x00008065
		internal bool method_8(SongEntry songEntry_0)
		{
			return songEntry_0.playlistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00009E05 File Offset: 0x00008005
		internal bool method_9(SongEntry songEntry_0)
		{
			return songEntry_0.genreName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00009E05 File Offset: 0x00008005
		internal bool method_10(SongEntry songEntry_0)
		{
			return songEntry_0.genreName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00009E05 File Offset: 0x00008005
		internal bool method_11(SongEntry songEntry_0)
		{
			return songEntry_0.genreName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00009E35 File Offset: 0x00008035
		internal bool method_12(SongEntry songEntry_0)
		{
			return songEntry_0.artistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00009E65 File Offset: 0x00008065
		internal bool method_13(SongEntry songEntry_0)
		{
			return songEntry_0.playlistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00009E35 File Offset: 0x00008035
		internal bool method_14(SongEntry songEntry_0)
		{
			return songEntry_0.artistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00009E7D File Offset: 0x0000807D
		internal bool method_15(SongEntry songEntry_0)
		{
			return songEntry_0.year.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00009E95 File Offset: 0x00008095
		internal bool method_16(SongEntry songEntry_0)
		{
			return songEntry_0.songName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00009E4D File Offset: 0x0000804D
		internal bool method_17(SongEntry songEntry_0)
		{
			return songEntry_0.charterName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00009E1D File Offset: 0x0000801D
		internal bool method_18(SongEntry songEntry_0)
		{
			return songEntry_0.albumName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00009E4D File Offset: 0x0000804D
		internal bool method_19(SongEntry songEntry_0)
		{
			return songEntry_0.charterName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00009E1D File Offset: 0x0000801D
		internal bool method_20(SongEntry songEntry_0)
		{
			return songEntry_0.albumName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00009E05 File Offset: 0x00008005
		internal bool method_21(SongEntry songEntry_0)
		{
			return songEntry_0.genreName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00009E95 File Offset: 0x00008095
		internal bool method_22(SongEntry songEntry_0)
		{
			return songEntry_0.songName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00009E35 File Offset: 0x00008035
		internal bool method_23(SongEntry songEntry_0)
		{
			return songEntry_0.artistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00009E65 File Offset: 0x00008065
		internal bool method_24(SongEntry songEntry_0)
		{
			return songEntry_0.playlistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00009E05 File Offset: 0x00008005
		internal bool method_25(SongEntry songEntry_0)
		{
			return songEntry_0.genreName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00009E65 File Offset: 0x00008065
		internal bool method_26(SongEntry songEntry_0)
		{
			return songEntry_0.playlistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00009E4D File Offset: 0x0000804D
		internal bool method_27(SongEntry songEntry_0)
		{
			return songEntry_0.charterName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00009E05 File Offset: 0x00008005
		internal bool method_28(SongEntry songEntry_0)
		{
			return songEntry_0.genreName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00009E7D File Offset: 0x0000807D
		internal bool method_29(SongEntry songEntry_0)
		{
			return songEntry_0.year.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00009E65 File Offset: 0x00008065
		internal bool method_30(SongEntry songEntry_0)
		{
			return songEntry_0.playlistName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00009E95 File Offset: 0x00008095
		internal bool method_31(SongEntry songEntry_0)
		{
			return songEntry_0.songName.ToLower().StartsWith(this.string_0);
		}

		// Token: 0x040002AF RID: 687
		public string string_0;
	}
}
