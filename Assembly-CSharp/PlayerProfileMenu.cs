using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using Rewired;
using Rewired.UI.ControlMapper;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000047 RID: 71
public class PlayerProfileMenu : BaseMenu
{
	// Token: 0x06000CEA RID: 3306 RVA: 0x000654B8 File Offset: 0x000636B8
	private void method_44()
	{
		ReInput.controllers.Keyboard.enabled = true;
		this.bool_12 = false;
		this.controlMapper_0.enabled = true;
		if (this.bool_13)
		{
			this.bool_13 = false;
			this.method_48();
			this.method_64();
			return;
		}
		this.method_69();
		base.method_0("Create Profile");
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00065518 File Offset: 0x00063718
	protected virtual void vmethod_81()
	{
		if (this.gclass9_0 == null || this.controlMapper_0.isOpen || FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (!this.gclass9_0.bool_0)
		{
			if (this.gclass9_0.player_0.GetButtonDown(57))
			{
				this.method_54();
			}
			return;
		}
		if (this.bool_12)
		{
			this.method_60();
			return;
		}
		base.Update();
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x00065584 File Offset: 0x00063784
	private void method_45(Player player_0)
	{
		GlobalVariables.instance.int_1++;
		this.gclass9_0 = GlobalVariables.instance.playerList[this.int_4];
		this.gclass9_0.playerProfileMenu_0 = this;
		this.gclass9_0.player_0 = player_0;
		this.gclass9_0.int_0 = this.int_4;
		player_0.isPlaying = true;
		this.gclass9_0.bool_0 = true;
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_53(true));
		this.method_69();
		this.vmethod_23(0);
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x00007A3F File Offset: 0x00005C3F
	private IEnumerator method_46()
	{
		PlayerProfileMenu.Class18 @class = new PlayerProfileMenu.Class18(0);
		@class.playerProfileMenu_0 = this;
		return @class;
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00065630 File Offset: 0x00063830
	private void method_47(GClass10 gclass10_0)
	{
		if (base.String_0 == "Create Profile")
		{
			this.method_66(false);
			return;
		}
		if (gclass10_0 == null)
		{
			if (base.String_0 == "Guest")
			{
				this.gclass9_0.gclass10_0 = new GClass10
				{
					bool_0 = true
				};
			}
			else
			{
				this.gclass9_0.gclass10_0 = GlobalVariables.instance.playerProfiles[base.Int32_0];
				GlobalVariables.instance.method_80(this.gclass9_0.gclass10_0);
			}
		}
		else
		{
			this.gclass9_0.gclass10_0 = gclass10_0;
		}
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_53(false));
		base.StartCoroutine(this.method_52());
		this.vmethod_23(0);
		this.method_48();
		this.method_49();
		this.allowMultiLanguage = true;
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00065718 File Offset: 0x00063918
	protected override void Update()
	{
		if (this.gclass9_0 == null || this.controlMapper_0.isOpen || FadeBehaviour.fadeBehaviour_0.bool_0)
		{
			return;
		}
		if (!this.gclass9_0.bool_0)
		{
			if (this.gclass9_0.player_0.GetButtonDown(16))
			{
				this.method_54();
			}
			return;
		}
		if (this.bool_12)
		{
			this.method_60();
			return;
		}
		base.Update();
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00007A4E File Offset: 0x00005C4E
	public bool Boolean_1
	{
		get
		{
			return this.gclass9_0 != null;
		}
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00065784 File Offset: 0x00063984
	public override void vmethod_39()
	{
		if (this.gclass9_0.gclass10_0 == null)
		{
			this.method_47(null);
			return;
		}
		if (this.string_0 == null)
		{
			string string_ = base.String_0;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
			if (num <= 2707328673u)
			{
				if (num <= 893259077u)
				{
					if (num != 565687656u)
					{
						if (num != 892887250u)
						{
							if (num == 893259077u)
							{
								if (string_ == "Options")
								{
									this.method_64();
									return;
								}
							}
						}
						else if (string_ == "Lefty Flip")
						{
							this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_2;
						}
					}
					else if (string_ == "Drop Out")
					{
						this.method_51(false);
						return;
					}
				}
				else if (num <= 2464313451u)
				{
					if (num != 1642511898u)
					{
						if (num == 2464313451u)
						{
							if (string_ == "Gamepad Mode")
							{
								this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_3;
							}
						}
					}
					else if (string_ == "No")
					{
						this.method_64();
						this.method_48();
						base.method_0("Delete Profile");
						this.bool_14 = false;
						return;
					}
				}
				else if (num != 2503720658u)
				{
					if (num == 2707328673u)
					{
						if (string_ == "Controller")
						{
							this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_7;
						}
					}
				}
				else if (string_ == "Note Speed")
				{
					this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_0;
				}
			}
			else if (num <= 3460482988u)
			{
				if (num != 2874894780u)
				{
					if (num != 3013883440u)
					{
						if (num == 3460482988u)
						{
							if (string_ == "Display Name")
							{
								this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_5;
							}
						}
					}
					else if (string_ == "Yes")
					{
						GlobalVariables.instance.method_98(this.gclass9_0.gclass10_0);
						this.method_51(true);
						this.bool_14 = false;
						return;
					}
				}
				else if (string_ == "Highway")
				{
					this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_6;
					if (GlobalVariables.instance.highwayPaths.Length == 0)
					{
						this.gclass5_0.Int32_0 = -1;
					}
					else
					{
						this.gclass5_0.Int32_0 = GlobalVariables.instance.highwayPaths.Length - 1;
					}
				}
			}
			else if (num <= 3653993758u)
			{
				if (num != 3607655226u)
				{
					if (num == 3653993758u)
					{
						if (string_ == "Bot")
						{
							this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_4;
						}
					}
				}
				else if (string_ == "Rename Profile")
				{
					this.method_66(true);
					return;
				}
			}
			else if (num != 3804515427u)
			{
				if (num == 3806402342u)
				{
					if (string_ == "Tilt")
					{
						this.gclass5_0 = this.gclass9_0.gclass10_0.gclass5_1;
					}
				}
			}
			else if (string_ == "Delete Profile")
			{
				this.bool_14 = true;
				this.text_0.text = GClass4.gclass4_0.method_13("Are you sure?");
				this.text_0.color = Color.white;
				this.menuStrings = new string[]
				{
					"Yes",
					"No"
				};
				this.vmethod_67();
				base.method_0("No");
				return;
			}
			this.string_0 = base.String_0;
			this.method_61();
			return;
		}
		if (this.string_0 == "Bot")
		{
			this.method_48();
		}
		this.vmethod_50();
		this.gclass5_0 = null;
		this.string_0 = null;
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00065B4C File Offset: 0x00063D4C
	public void method_48()
	{
		if (!this.Boolean_1)
		{
			this.text_0.text = GClass4.gclass4_0.method_13("PRESS START");
			this.text_0.color = Color.white;
			return;
		}
		this.text_0.text = this.gclass9_0.gclass10_0.string_0;
		this.text_0.color = (this.gclass9_0.gclass10_0.bool_0 ? this.guestColor : (GameSetting.smethod_3(this.gclass9_0.gclass10_0.gclass5_4) ? Color.cyan : this.highlightColor));
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00065BF0 File Offset: 0x00063DF0
	protected virtual void vmethod_82()
	{
		this.controlMapper_0 = GameObject.Find("song").GetComponent<ControlMapper>();
		this.rectTransform_0 = base.GetComponent<RectTransform>();
		if (GlobalVariables.instance.playerList[this.int_4].player_0 == null)
		{
			base.StartCoroutine(this.method_46());
		}
		else
		{
			this.method_57();
			this.gclass9_0.playerProfileMenu_0 = this;
		}
		base.vmethod_77();
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00065C64 File Offset: 0x00063E64
	private void method_49()
	{
		foreach (PlayerProfileMenu playerProfileMenu in UnityEngine.Object.FindObjectsOfType<PlayerProfileMenu>())
		{
			if (!(playerProfileMenu == this) && playerProfileMenu.gclass9_0 != null && playerProfileMenu.gclass9_0.gclass10_0 == null)
			{
				playerProfileMenu.method_69();
			}
		}
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00065CB0 File Offset: 0x00063EB0
	private void method_50(bool bool_15)
	{
		ReInput.controllers.Keyboard.enabled = false;
		this.controlMapper_0.enabled = false;
		this.bool_12 = false;
		this.menuStrings = new string[1];
		base.method_5();
		if (!bool_15)
		{
			this.text_0.text = "Client disconnected";
		}
		else
		{
			this.bool_13 = true;
			this.string_1 = this.text_0.text;
		}
		this.textObjects[0].text = GClass4.gclass4_0.method_17("Get Hardware Latency");
		this.textObjects[1].color = Color.white;
		this.textObjects[1].text = GClass4.gclass4_0.method_15("Note number outside of note range");
		this.textObjects[1].color = Color.green;
		this.textObjects[0].text = GClass4.gclass4_0.method_38(" ");
		this.textObjects[5].color = Color.red;
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00065DAC File Offset: 0x00063FAC
	public void method_51(bool bool_15)
	{
		if (this.gclass9_0 == null)
		{
			return;
		}
		if (this.gclass9_0.gclass10_0 != null)
		{
			if (bool_15)
			{
				this.gclass9_0.gclass10_0 = null;
			}
			else
			{
				if (this.bool_10)
				{
					this.bool_10 = false;
					GlobalVariables.instance.method_15(this.gclass9_0.gclass10_0);
				}
				GlobalVariables.instance.method_81(this.gclass9_0.gclass10_0);
				this.gclass9_0.gclass10_0 = null;
				this.method_49();
			}
		}
		GlobalVariables.instance.playerList[this.int_4].method_3();
		GlobalVariables.instance.int_1--;
		this.gclass9_0.playerProfileMenu_0 = null;
		this.gclass9_0 = null;
		this.menuStrings = new string[0];
		base.method_5();
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_53(false));
		base.StartCoroutine(this.method_46());
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00065EB0 File Offset: 0x000640B0
	protected override void vmethod_50()
	{
		base.vmethod_50();
		if (this.Boolean_1 && !this.Boolean_0)
		{
			int num = this.int_0;
			int i = 0;
			while (i < this.int_3)
			{
				if (num >= this.menuStrings.Length - 1)
				{
					this.textObjects[i].text = "<" + GClass4.gclass4_0.method_13(this.textObjects[i].text) + ">";
				}
				else
				{
					if (num >= this.menuStrings.Length - 2)
					{
						this.textObjects[i].text = GClass4.gclass4_0.method_13(this.textObjects[i].text);
					}
					if (i != this.int_1)
					{
						this.textObjects[i].color = Color.white;
						if (num == this.menuStrings.Length - 2)
						{
							this.textObjects[i].color = this.guestColor;
						}
						else if (GameSetting.smethod_3(GlobalVariables.instance.playerProfiles[num].gclass5_4))
						{
							this.textObjects[i].color = Color.cyan;
						}
					}
				}
				i++;
				num++;
			}
		}
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00007A59 File Offset: 0x00005C59
	private IEnumerator method_52()
	{
		PlayerProfileMenu.Class20 @class = new PlayerProfileMenu.Class20(0);
		@class.playerProfileMenu_0 = this;
		return @class;
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00007A68 File Offset: 0x00005C68
	private IEnumerator method_53(bool bool_15)
	{
		PlayerProfileMenu.Class19 @class = new PlayerProfileMenu.Class19(0);
		@class.playerProfileMenu_0 = this;
		@class.bool_0 = bool_15;
		return @class;
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00065FDC File Offset: 0x000641DC
	private void method_54()
	{
		this.vmethod_23(0);
		this.menuStrings = this.settingsOptions;
		this.vmethod_67();
		this.gclass9_0.bool_0 = true;
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_53(true));
		this.vmethod_50();
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x0006603C File Offset: 0x0006423C
	private void method_55()
	{
		this.vmethod_25(0);
		this.menuStrings = this.settingsOptions;
		this.vmethod_67();
		this.gclass9_0.bool_0 = true;
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_53(true));
		this.vmethod_50();
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0006609C File Offset: 0x0006429C
	private void method_56()
	{
		if (this.text_0.text.Trim().Length > 0)
		{
			ReInput.controllers.Keyboard.enabled = true;
			this.bool_12 = false;
			this.controlMapper_0.enabled = true;
			if (this.bool_13)
			{
				this.bool_13 = false;
				this.method_64();
				this.bool_10 = true;
				this.gclass9_0.gclass10_0.string_0 = this.text_0.text;
			}
			else
			{
				GClass10 gclass = new GClass10();
				gclass.string_0 = this.text_0.text.Trim();
				GlobalVariables.instance.method_96(gclass);
				this.method_47(gclass);
			}
			this.method_48();
		}
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x00007A7E File Offset: 0x00005C7E
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.bool_10 = true;
		this.method_61();
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00007AA7 File Offset: 0x00005CA7
	private void method_57()
	{
		this.gclass9_0 = GlobalVariables.instance.playerList[this.int_4];
		this.method_65();
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00007ACA File Offset: 0x00005CCA
	public bool method_58()
	{
		return this.gclass9_0.gclass10_0 != null;
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x00007ADA File Offset: 0x00005CDA
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.bool_10 = true;
		this.method_61();
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x00066154 File Offset: 0x00064354
	private void method_59()
	{
		if (this.bool_10)
		{
			this.bool_10 = false;
			GlobalVariables.instance.method_15(this.gclass9_0.gclass10_0);
		}
		base.StartCoroutine(this.method_52());
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_53(false));
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x000661BC File Offset: 0x000643BC
	private void method_60()
	{
		foreach (char c in Input.inputString)
		{
			if (c != '\b')
			{
				if (c != '\n')
				{
					if (c != '\r')
					{
						if ((this.text_0.text.Length == 0 && c == ' ') || this.text_0.text.Length == 15)
						{
							goto IL_103;
						}
						Text text = this.text_0;
						text.text += c.ToString();
						this.text_0.text = Regex.Replace(this.text_0.text, "[^\\u0020-\\u007E]", string.Empty);
						if (string.IsNullOrEmpty(this.text_0.text))
						{
							this.text_0.text = "";
							goto IL_103;
						}
						goto IL_103;
					}
				}
				this.method_56();
				return;
			}
			if (this.text_0.text.Length > 0)
			{
				this.text_0.text = this.text_0.text.Substring(0, this.text_0.text.Length - 1);
			}
			IL_103:;
		}
		if (!Input.GetKeyDown(KeyCode.Return) && !Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				this.method_44();
			}
			return;
		}
		this.method_56();
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00066310 File Offset: 0x00064510
	private void method_61()
	{
		string str = "<";
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 2707328673u)
		{
			if (num <= 2464313451u)
			{
				if (num != 892887250u)
				{
					if (num != 2464313451u)
					{
						goto IL_19D;
					}
					if (!(string_ == "Gamepad Mode"))
					{
						goto IL_19D;
					}
				}
				else if (!(string_ == "Lefty Flip"))
				{
					goto IL_19D;
				}
			}
			else if (num != 2503720658u)
			{
				if (num != 2707328673u)
				{
					goto IL_19D;
				}
				if (string_ == "Controller")
				{
					str += this.gclass9_0.gclass10_0.String_0;
					goto IL_19D;
				}
				goto IL_19D;
			}
			else
			{
				if (string_ == "Note Speed")
				{
					str += this.gclass5_0.String_2;
					goto IL_19D;
				}
				goto IL_19D;
			}
		}
		else if (num <= 3460482988u)
		{
			if (num != 2874894780u)
			{
				if (num != 3460482988u)
				{
					goto IL_19D;
				}
				if (!(string_ == "Display Name"))
				{
					goto IL_19D;
				}
			}
			else
			{
				if (!(string_ == "Highway"))
				{
					goto IL_19D;
				}
				if (this.gclass5_0.CurrentValue == -1)
				{
					str += GClass4.gclass4_0.method_13("Default");
					goto IL_19D;
				}
				str += Path.GetFileNameWithoutExtension(GlobalVariables.instance.highwayPaths[this.gclass5_0.CurrentValue]);
				goto IL_19D;
			}
		}
		else if (num != 3653993758u)
		{
			if (num != 3806402342u)
			{
				goto IL_19D;
			}
			if (!(string_ == "Tilt"))
			{
				goto IL_19D;
			}
		}
		else if (!(string_ == "Bot"))
		{
			goto IL_19D;
		}
		str += this.gclass5_0.String_0;
		IL_19D:
		this.textObjects[this.int_1].text = str + ">";
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x000664D8 File Offset: 0x000646D8
	public void method_62()
	{
		if (!this.Boolean_1)
		{
			this.text_0.text = GClass4.gclass4_0.method_5("%>");
			this.text_0.color = Color.white;
			return;
		}
		this.text_0.text = this.gclass9_0.gclass10_0.string_0;
		this.text_0.color = (this.gclass9_0.gclass10_0.bool_0 ? this.guestColor : (GameSetting.smethod_3(this.gclass9_0.gclass10_0.gclass5_4) ? Color.cyan : this.highlightColor));
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0006657C File Offset: 0x0006477C
	private void method_63(Player player_0)
	{
		GlobalVariables.instance.int_1 += 0;
		this.gclass9_0 = GlobalVariables.instance.playerList[this.int_4];
		this.gclass9_0.playerProfileMenu_0 = this;
		this.gclass9_0.player_0 = player_0;
		this.gclass9_0.int_0 = this.int_4;
		player_0.isPlaying = true;
		this.gclass9_0.bool_0 = false;
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		this.coroutine_0 = base.StartCoroutine(this.method_53(false));
		this.method_69();
		this.vmethod_25(0);
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00007ACA File Offset: 0x00005CCA
	public bool Boolean_0
	{
		get
		{
			return this.gclass9_0.gclass10_0 != null;
		}
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00007B03 File Offset: 0x00005D03
	private void method_64()
	{
		this.menuStrings = this.profileOptions;
		this.vmethod_67();
		this.vmethod_23(0);
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00066628 File Offset: 0x00064828
	public void method_65()
	{
		if (!this.Boolean_1)
		{
			this.text_0.text = GClass4.gclass4_0.method_48("Album");
			this.text_0.color = Color.white;
			return;
		}
		this.text_0.text = this.gclass9_0.gclass10_0.string_0;
		this.text_0.color = (this.gclass9_0.gclass10_0.bool_0 ? this.guestColor : (GameSetting.smethod_3(this.gclass9_0.gclass10_0.gclass5_4) ? Color.cyan : this.highlightColor));
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x000666CC File Offset: 0x000648CC
	private void method_66(bool bool_15)
	{
		ReInput.controllers.Keyboard.enabled = false;
		this.controlMapper_0.enabled = false;
		this.bool_12 = true;
		this.menuStrings = new string[0];
		base.method_5();
		if (!bool_15)
		{
			this.text_0.text = "";
		}
		else
		{
			this.bool_13 = true;
			this.string_1 = this.text_0.text;
		}
		this.textObjects[0].text = GClass4.gclass4_0.method_13("Type the profile name");
		this.textObjects[0].color = Color.white;
		this.textObjects[1].text = GClass4.gclass4_0.method_13("Press Enter to confirm");
		this.textObjects[1].color = Color.green;
		this.textObjects[2].text = GClass4.gclass4_0.method_13("Press Escape to cancel");
		this.textObjects[2].color = Color.red;
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x000667C8 File Offset: 0x000649C8
	public override void vmethod_43()
	{
		if (this.gclass9_0.gclass10_0 == null)
		{
			this.method_51(false);
			return;
		}
		if (this.string_0 != null)
		{
			this.vmethod_50();
			this.gclass5_0 = null;
			this.string_0 = null;
			return;
		}
		if (this.bool_14)
		{
			this.bool_14 = false;
			this.method_64();
			this.method_48();
			base.method_0("Delete Profile");
			return;
		}
		if (this.menuStrings == this.profileOptions)
		{
			this.method_54();
			base.method_0("Options");
			return;
		}
		this.method_59();
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00007B1E File Offset: 0x00005D1E
	private void method_67()
	{
		this.gclass9_0 = GlobalVariables.instance.playerList[this.int_4];
		this.method_48();
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00066854 File Offset: 0x00064A54
	protected override void Start()
	{
		this.controlMapper_0 = GameObject.Find("ControlMapper").GetComponent<ControlMapper>();
		this.rectTransform_0 = base.GetComponent<RectTransform>();
		if (GlobalVariables.instance.playerList[this.int_4].player_0 == null)
		{
			base.StartCoroutine(this.method_46());
		}
		else
		{
			this.method_67();
			this.gclass9_0.playerProfileMenu_0 = this;
		}
		base.Start();
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x000668C8 File Offset: 0x00064AC8
	public void method_68()
	{
		if (!this.Boolean_1)
		{
			this.text_0.text = GClass4.gclass4_0.method_30("song");
			this.text_0.color = Color.white;
			return;
		}
		this.text_0.text = this.gclass9_0.gclass10_0.string_0;
		this.text_0.color = (this.gclass9_0.gclass10_0.bool_0 ? this.guestColor : (GameSetting.smethod_3(this.gclass9_0.gclass10_0.gclass5_4) ? Color.cyan : this.highlightColor));
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00007B41 File Offset: 0x00005D41
	public virtual void vmethod_83()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.bool_10 = false;
		this.method_61();
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0006696C File Offset: 0x00064B6C
	private void method_69()
	{
		this.text_0.text = GClass4.gclass4_0.method_13("Choose a Profile");
		this.menuStrings = new string[GlobalVariables.instance.playerProfiles.Count + 2];
		this.vmethod_67();
		for (int i = 0; i < GlobalVariables.instance.playerProfiles.Count; i++)
		{
			this.menuStrings[i] = GlobalVariables.instance.playerProfiles[i].string_0;
		}
		this.menuStrings[this.menuStrings.Length - 2] = "Guest";
		this.menuStrings[this.menuStrings.Length - 1] = "Create Profile";
		this.allowMultiLanguage = false;
		this.vmethod_23(0);
		this.vmethod_50();
	}

	// Token: 0x0400020F RID: 527
	public Text text_0;

	// Token: 0x04000210 RID: 528
	public int int_4;

	// Token: 0x04000211 RID: 529
	private ControlMapper controlMapper_0;

	// Token: 0x04000212 RID: 530
	[SerializeField]
	private SongSelectSearch songSelectSearch;

	// Token: 0x04000213 RID: 531
	[SerializeField]
	private string[] settingsOptions;

	// Token: 0x04000214 RID: 532
	[SerializeField]
	private string[] profileOptions;

	// Token: 0x04000215 RID: 533
	private string string_1;

	// Token: 0x04000216 RID: 534
	private RectTransform rectTransform_0;

	// Token: 0x04000217 RID: 535
	private Coroutine coroutine_0;

	// Token: 0x04000218 RID: 536
	private bool bool_12;

	// Token: 0x04000219 RID: 537
	private bool bool_13;

	// Token: 0x0400021A RID: 538
	private bool bool_14;

	// Token: 0x0400021B RID: 539
	[SerializeField]
	private Color guestColor;
}
