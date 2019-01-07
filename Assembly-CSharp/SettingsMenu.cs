using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

// Token: 0x0200004B RID: 75
public class SettingsMenu : BaseMenu
{
	// Token: 0x06000DB3 RID: 3507 RVA: 0x00007BAF File Offset: 0x00005DAF
	public virtual void vmethod_81()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.bool_10 = false;
		this.method_50();
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x00007BD8 File Offset: 0x00005DD8
	private void method_44()
	{
		base.StartCoroutine(this.method_55());
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00007BE7 File Offset: 0x00005DE7
	private IEnumerator method_45()
	{
		this.songScan.method_43();
		if (this.songScan.bool_0)
		{
			yield break;
		}
		IEnumerator routine = this.songScan.method_60(true);
		base.StartCoroutine(routine);
		yield break;
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x00007BF6 File Offset: 0x00005DF6
	protected virtual void vmethod_82()
	{
		base.OnEnable();
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00007BFE File Offset: 0x00005DFE
	public virtual void vmethod_83()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_29();
		this.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x00068670 File Offset: 0x00066870
	private void method_46()
	{
		if (this.string_0 == "%b")
		{
			this.textObjects[this.int_1].text = GlobalVariables.instance.languages[this.gclass5_0.method_25()];
			return;
		}
		this.textObjects[this.int_1].text = this.gclass5_0.method_10();
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00007C27 File Offset: 0x00005E27
	private void method_47()
	{
		base.StartCoroutine(this.method_45());
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_84()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00007C59 File Offset: 0x00005E59
	private void method_48()
	{
		base.StartCoroutine(this.method_51());
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00007C68 File Offset: 0x00005E68
	public override void vmethod_26()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.bool_10 = true;
		this.method_52();
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x000686D8 File Offset: 0x000668D8
	public virtual void vmethod_85()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == "^\\s*\\d+ = S 2 \\d+$")
			{
				GlobalVariables.instance.method_38();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.method_39();
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 37u)
		{
			if (num <= 4294967186u)
			{
				if (num != 153u)
				{
					if (num != 157u)
					{
						return;
					}
					if (!(string_ == "name"))
					{
						return;
					}
					this.string_0 = null;
					this.calibrationMenu.gameObject.SetActive(true);
					base.gameObject.SetActive(false);
					return;
				}
				else
				{
					if (!(string_ == "Sound Effects"))
					{
						return;
					}
					this.confirmMenu.method_48("Background Video", "No Fail", "FULL COMBO", new ConfirmationMenu.GDelegate6(this.method_48), null, null);
					this.string_0 = null;
					return;
				}
			}
			else if (num != 169u)
			{
				if (num != 4294967125u)
				{
					if (num != 82u)
					{
						return;
					}
					if (!(string_ == ")"))
					{
						return;
					}
					this.gclass5_0 = GlobalVariables.instance.gclass5_42;
					this.method_50();
					return;
				}
				else
				{
					if (!(string_ == "PAUSED"))
					{
						return;
					}
					this.string_0 = null;
					this.videoMenu.gameObject.SetActive(false);
					base.gameObject.SetActive(false);
					return;
				}
			}
			else
			{
				if (!(string_ == "Framerate"))
				{
					return;
				}
				this.string_0 = null;
				this.volumeMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(false);
				return;
			}
		}
		else if (num <= 4294967120u)
		{
			if (num != 136u)
			{
				if (num != 107u)
				{
					return;
				}
				if (!(string_ == "Play Count"))
				{
					return;
				}
				this.string_0 = null;
				this.streamerSettingsMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(false);
				return;
			}
			else
			{
				if (!(string_ == "Quickplay"))
				{
					return;
				}
				DataPrivacy.FetchPrivacyUrl(new Action<string>(SettingsMenu.<>c.<>9.method_25), new Action<string>(SettingsMenu.<>c.<>9.method_44));
				this.string_0 = null;
				return;
			}
		}
		else if (num != 72u)
		{
			if (num != 4294967176u)
			{
				if (num != 4294967185u)
				{
					return;
				}
				if (!(string_ == "Unknown Year"))
				{
					return;
				}
				this.gclass5_0 = GlobalVariables.instance.gclass5_27;
				this.method_46();
				return;
			}
			else
			{
				if (!(string_ == "ModChart Lite"))
				{
					return;
				}
				this.string_0 = null;
				this.customMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			if (!(string_ == "Alpha "))
			{
				return;
			}
			this.string_0 = null;
			this.gameModifiersMenu.gameObject.SetActive(true);
			base.gameObject.SetActive(true);
			return;
		}
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00007C91 File Offset: 0x00005E91
	private void method_49()
	{
		base.StartCoroutine(this.method_54());
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00007CA0 File Offset: 0x00005EA0
	public virtual void vmethod_86()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.bool_10 = true;
		this.method_53();
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x000689C4 File Offset: 0x00066BC4
	public virtual void vmethod_87()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == ": <color=#FDB400FF>")
			{
				GlobalVariables.instance.method_9();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_30();
			return;
		}
		this.string_0 = base.method_39();
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 4u)
		{
			if (num <= 56u)
			{
				if (num != 174u)
				{
					if (num != 4294967213u)
					{
						return;
					}
					if (!(string_ == "<color=#FFFF04FF>"))
					{
						return;
					}
					this.string_0 = null;
					this.calibrationMenu.gameObject.SetActive(true);
					base.gameObject.SetActive(true);
					return;
				}
				else
				{
					if (!(string_ == "has_bots"))
					{
						return;
					}
					this.confirmMenu.method_52("diff_bassghl", "Create Profile", "Background Image", new ConfirmationMenu.GDelegate6(this.method_44), null, null);
					this.string_0 = null;
					return;
				}
			}
			else if (num != 46u)
			{
				if (num != 4294967192u)
				{
					if (num != 4294967218u)
					{
						return;
					}
					if (!(string_ == "pause_on_focus_lost"))
					{
						return;
					}
					this.gclass5_0 = GlobalVariables.instance.gclass5_42;
					this.method_46();
					return;
				}
				else
				{
					if (!(string_ == "In Menus: Stats"))
					{
						return;
					}
					this.string_0 = null;
					this.videoMenu.gameObject.SetActive(true);
					base.gameObject.SetActive(false);
					return;
				}
			}
			else
			{
				if (!(string_ == "PRESS START"))
				{
					return;
				}
				this.string_0 = null;
				this.volumeMenu.gameObject.SetActive(false);
				base.gameObject.SetActive(false);
				return;
			}
		}
		else if (num <= 93u)
		{
			if (num != 178u)
			{
				if (num != 4294967139u)
				{
					return;
				}
				if (!(string_ == "Allow Duplicate Songs"))
				{
					return;
				}
				this.string_0 = null;
				this.streamerSettingsMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(false);
				return;
			}
			else
			{
				if (!(string_ == "Guitar Coop"))
				{
					return;
				}
				DataPrivacy.FetchPrivacyUrl(new Action<string>(SettingsMenu.<>c.<>9.method_39), new Action<string>(SettingsMenu.<>c.<>9.method_71));
				this.string_0 = null;
				return;
			}
		}
		else if (num != 150u)
		{
			if (num != 4294967244u)
			{
				if (num != 59u)
				{
					return;
				}
				if (!(string_ == "bass"))
				{
					return;
				}
				this.gclass5_0 = GlobalVariables.instance.gclass5_27;
				this.method_53();
				return;
			}
			else
			{
				if (!(string_ == "Unknown Artist"))
				{
					return;
				}
				this.string_0 = null;
				this.customMenu.gameObject.SetActive(false);
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			if (!(string_ == "Show Lyrics"))
			{
				return;
			}
			this.string_0 = null;
			this.gameModifiersMenu.gameObject.SetActive(false);
			base.gameObject.SetActive(false);
			return;
		}
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_88()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00068CB0 File Offset: 0x00066EB0
	private void method_50()
	{
		if (this.string_0 == "master_volume")
		{
			this.textObjects[this.int_1].text = GlobalVariables.instance.languages[this.gclass5_0.method_25()];
			return;
		}
		this.textObjects[this.int_1].text = this.gclass5_0.method_9();
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_89()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_90()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00007CC9 File Offset: 0x00005EC9
	public virtual void vmethod_91()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.bool_10 = false;
		this.method_52();
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00007CF2 File Offset: 0x00005EF2
	public virtual void vmethod_92()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_2();
		this.bool_10 = false;
		this.method_52();
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_93()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00007D1B File Offset: 0x00005F1B
	public virtual void vmethod_94()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_29();
		this.bool_10 = true;
		this.method_56();
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x00007C36 File Offset: 0x00005E36
	protected override void Update()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00007BF6 File Offset: 0x00005DF6
	protected virtual void vmethod_95()
	{
		base.OnEnable();
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00007D44 File Offset: 0x00005F44
	private IEnumerator method_51()
	{
		SettingsMenu.Class21 @class = new SettingsMenu.Class21(1);
		@class.settingsMenu_0 = this;
		return @class;
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00007D53 File Offset: 0x00005F53
	public virtual void vmethod_96()
	{
		if (this.string_0 == null)
		{
			base.vmethod_26();
			return;
		}
		this.gclass5_0.method_7();
		this.bool_10 = true;
		this.method_53();
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00007D7C File Offset: 0x00005F7C
	public virtual void vmethod_97()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_19();
		this.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x00007DA5 File Offset: 0x00005FA5
	public virtual void vmethod_98()
	{
		if (this.string_0 == null)
		{
			base.vmethod_46();
			return;
		}
		this.gclass5_0.method_2();
		this.bool_10 = false;
		this.method_46();
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00068D18 File Offset: 0x00066F18
	private void method_52()
	{
		if (this.string_0 == "Language")
		{
			this.textObjects[this.int_1].text = GlobalVariables.instance.languages[this.gclass5_0.CurrentValue];
			return;
		}
		this.textObjects[this.int_1].text = this.gclass5_0.String_0;
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00068D80 File Offset: 0x00066F80
	private void method_53()
	{
		if (this.string_0 == "")
		{
			this.textObjects[this.int_1].text = GlobalVariables.instance.languages[this.gclass5_0.CurrentValue];
			return;
		}
		this.textObjects[this.int_1].text = this.gclass5_0.String_0;
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x00007DCE File Offset: 0x00005FCE
	public virtual void vmethod_99()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_15();
		this.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x00007DF7 File Offset: 0x00005FF7
	public virtual void vmethod_100()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.bool_10 = false;
		this.method_46();
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x00007BF6 File Offset: 0x00005DF6
	protected virtual void vmethod_101()
	{
		base.OnEnable();
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x00007E20 File Offset: 0x00006020
	public virtual void vmethod_102()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.bool_10 = true;
		this.method_50();
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00007E49 File Offset: 0x00006049
	protected virtual void vmethod_103()
	{
		base.vmethod_9();
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00007D44 File Offset: 0x00005F44
	private IEnumerator method_54()
	{
		SettingsMenu.Class21 @class = new SettingsMenu.Class21(1);
		@class.settingsMenu_0 = this;
		return @class;
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x00007E51 File Offset: 0x00006051
	public virtual void vmethod_104()
	{
		if (this.string_0 == null)
		{
			base.vmethod_55();
			return;
		}
		this.gclass5_0.method_19();
		this.bool_10 = true;
		this.method_46();
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00007D44 File Offset: 0x00005F44
	private IEnumerator method_55()
	{
		SettingsMenu.Class21 @class = new SettingsMenu.Class21(1);
		@class.settingsMenu_0 = this;
		return @class;
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00007BF6 File Offset: 0x00005DF6
	protected virtual void vmethod_105()
	{
		base.OnEnable();
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00068DE8 File Offset: 0x00066FE8
	public virtual void vmethod_106()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == "Medium")
			{
				GlobalVariables.instance.method_99();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
			GlobalVariables.instance.method_60(true);
		}
		this.vmethod_15();
		this.mainMenu.SetActive(false);
		this.vmethod_59();
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00068E6C File Offset: 0x0006706C
	public virtual void vmethod_107()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == "%s%n%a%n%c")
			{
				GlobalVariables.instance.method_24();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 199u)
		{
			if (num <= 4294967293u)
			{
				if (num != 193u)
				{
					if (num != 10u)
					{
						return;
					}
					if (!(string_ == "Ready"))
					{
						return;
					}
					this.string_0 = null;
					this.calibrationMenu.gameObject.SetActive(true);
					base.gameObject.SetActive(false);
					return;
				}
				else
				{
					if (!(string_ == "Language"))
					{
						return;
					}
					this.confirmMenu.method_45(".ogg", "game", "Full Song", new ConfirmationMenu.GDelegate6(this.method_44), null, null);
					this.string_0 = null;
					return;
				}
			}
			else if (num != 148u)
			{
				if (num != 75u)
				{
					if (num != 136u)
					{
						return;
					}
					if (!(string_ == " "))
					{
						return;
					}
					this.gclass5_0 = GlobalVariables.instance.gclass5_42;
					this.method_46();
					return;
				}
				else
				{
					if (!(string_ == "Okay"))
					{
						return;
					}
					this.string_0 = null;
					this.videoMenu.gameObject.SetActive(false);
					base.gameObject.SetActive(true);
					return;
				}
			}
			else
			{
				if (!(string_ == "video"))
				{
					return;
				}
				this.string_0 = null;
				this.volumeMenu.gameObject.SetActive(false);
				base.gameObject.SetActive(false);
				return;
			}
		}
		else if (num <= 4294967277u)
		{
			if (num != 4294967161u)
			{
				if (num != 171u)
				{
					return;
				}
				if (!(string_ == "band"))
				{
					return;
				}
				this.string_0 = null;
				this.streamerSettingsMenu.gameObject.SetActive(false);
				base.gameObject.SetActive(true);
				return;
			}
			else
			{
				if (!(string_ == "diff_keys"))
				{
					return;
				}
				DataPrivacy.FetchPrivacyUrl(new Action<string>(SettingsMenu.<>c.<>9.method_27), new Action<string>(SettingsMenu.<>c.<>9.method_70));
				this.string_0 = null;
				return;
			}
		}
		else if (num != 4294967205u)
		{
			if (num != 116u)
			{
				if (num != 4294967121u)
				{
					return;
				}
				if (!(string_ == "streamer"))
				{
					return;
				}
				this.gclass5_0 = GlobalVariables.instance.gclass5_27;
				this.method_56();
				return;
			}
			else
			{
				if (!(string_ == "phrase_end"))
				{
					return;
				}
				this.string_0 = null;
				this.customMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			if (!(string_ == "background"))
			{
				return;
			}
			this.string_0 = null;
			this.gameModifiersMenu.gameObject.SetActive(true);
			base.gameObject.SetActive(true);
			return;
		}
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00007E7A File Offset: 0x0000607A
	public virtual void vmethod_108()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_15();
		this.bool_10 = false;
		this.method_56();
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00069158 File Offset: 0x00067358
	public override void vmethod_39()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == "Language")
			{
				GlobalVariables.instance.method_113();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		this.string_0 = base.String_0;
		string string_ = this.string_0;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(string_);
		if (num <= 2591284123u)
		{
			if (num <= 1751856583u)
			{
				if (num != 1297251446u)
				{
					if (num != 1751856583u)
					{
						return;
					}
					if (!(string_ == "Calibration"))
					{
						return;
					}
					this.string_0 = null;
					this.calibrationMenu.gameObject.SetActive(true);
					base.gameObject.SetActive(false);
					return;
				}
				else
				{
					if (!(string_ == "Scan Songs"))
					{
						return;
					}
					this.confirmMenu.method_44("This will take a while. Are you sure?", "Yes", "No", new ConfirmationMenu.GDelegate6(this.method_47), null, null);
					this.string_0 = null;
					return;
				}
			}
			else if (num != 2151039526u)
			{
				if (num != 2313977385u)
				{
					if (num != 2591284123u)
					{
						return;
					}
					if (!(string_ == "Language"))
					{
						return;
					}
					this.gclass5_0 = GlobalVariables.instance.gclass5_42;
					this.method_52();
					return;
				}
				else
				{
					if (!(string_ == "Video Settings"))
					{
						return;
					}
					this.string_0 = null;
					this.videoMenu.gameObject.SetActive(true);
					base.gameObject.SetActive(false);
					return;
				}
			}
			else
			{
				if (!(string_ == "Audio Settings"))
				{
					return;
				}
				this.string_0 = null;
				this.volumeMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(false);
				return;
			}
		}
		else if (num <= 3720450055u)
		{
			if (num != 3192252706u)
			{
				if (num != 3720450055u)
				{
					return;
				}
				if (!(string_ == "Streamer Settings"))
				{
					return;
				}
				this.string_0 = null;
				this.streamerSettingsMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(false);
				return;
			}
			else
			{
				if (!(string_ == "Open Data Privacy Page"))
				{
					return;
				}
				DataPrivacy.FetchPrivacyUrl(new Action<string>(SettingsMenu.<>c.<>9.method_73), new Action<string>(SettingsMenu.<>c.<>9.method_51));
				this.string_0 = null;
				return;
			}
		}
		else if (num != 3981378553u)
		{
			if (num != 4181349251u)
			{
				if (num != 4185652605u)
				{
					return;
				}
				if (!(string_ == "Show Full Playlist"))
				{
					return;
				}
				this.gclass5_0 = GlobalVariables.instance.gclass5_27;
				this.method_52();
				return;
			}
			else
			{
				if (!(string_ == "Custom Content"))
				{
					return;
				}
				this.string_0 = null;
				this.customMenu.gameObject.SetActive(true);
				base.gameObject.SetActive(false);
				return;
			}
		}
		else
		{
			if (!(string_ == "Game Modifiers"))
			{
				return;
			}
			this.string_0 = null;
			this.gameModifiersMenu.gameObject.SetActive(true);
			base.gameObject.SetActive(false);
			return;
		}
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00007BF6 File Offset: 0x00005DF6
	protected override void OnEnable()
	{
		base.OnEnable();
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00069444 File Offset: 0x00067644
	public virtual void vmethod_109()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == "volume")
			{
				GlobalVariables.instance.method_99();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = false;
			GlobalVariables.instance.method_23(true);
		}
		this.vmethod_15();
		this.mainMenu.SetActive(false);
		this.vmethod_59();
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x000694C8 File Offset: 0x000676C8
	public virtual void vmethod_110()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == "profiles_backup.bin")
			{
				GlobalVariables.instance.method_9();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.bool_10)
		{
			GlobalVariables.instance.method_29();
			this.bool_10 = true;
			GlobalVariables.instance.ApplyGraphicsSettings(false);
		}
		this.vmethod_15();
		this.mainMenu.SetActive(false);
		this.vmethod_59();
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x0006954C File Offset: 0x0006774C
	private void method_56()
	{
		if (this.string_0 == "game")
		{
			this.textObjects[this.int_1].text = GlobalVariables.instance.languages[this.gclass5_0.method_5()];
			return;
		}
		this.textObjects[this.int_1].text = this.gclass5_0.method_10();
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_111()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00007EA3 File Offset: 0x000060A3
	public virtual void vmethod_112()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.bool_10 = true;
		this.method_56();
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00007BF6 File Offset: 0x00005DF6
	protected virtual void vmethod_113()
	{
		base.OnEnable();
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00007ECC File Offset: 0x000060CC
	public override void vmethod_44()
	{
		if (this.string_0 == null)
		{
			base.vmethod_44();
			return;
		}
		this.gclass5_0.method_27();
		this.bool_10 = true;
		this.method_52();
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x000695B4 File Offset: 0x000677B4
	public override void vmethod_43()
	{
		if (this.string_0 != null)
		{
			if (this.string_0 == "Language")
			{
				GlobalVariables.instance.method_113();
			}
			this.gclass5_0 = null;
			this.string_0 = null;
			this.vmethod_50();
			return;
		}
		if (this.bool_10)
		{
			GlobalVariables.instance.method_26();
			this.bool_10 = false;
			GlobalVariables.instance.ApplyGraphicsSettings(true);
		}
		this.vmethod_15();
		this.mainMenu.SetActive(true);
		this.vmethod_59();
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00007E49 File Offset: 0x00006049
	protected virtual void vmethod_114()
	{
		base.vmethod_9();
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_115()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00007C36 File Offset: 0x00005E36
	protected virtual void vmethod_116()
	{
		if (!this.songScan.bool_1 && !this.confirmMenu.bool_11)
		{
			base.Update();
			return;
		}
	}

	// Token: 0x04000228 RID: 552
	[SerializeField]
	private GameObject mainMenu;

	// Token: 0x04000229 RID: 553
	[SerializeField]
	private SongScan songScan;

	// Token: 0x0400022A RID: 554
	[SerializeField]
	private BaseMenu volumeMenu;

	// Token: 0x0400022B RID: 555
	[SerializeField]
	private BaseMenu calibrationMenu;

	// Token: 0x0400022C RID: 556
	[SerializeField]
	private BaseMenu videoMenu;

	// Token: 0x0400022D RID: 557
	[SerializeField]
	private BaseMenu gameModifiersMenu;

	// Token: 0x0400022E RID: 558
	[SerializeField]
	private BaseMenu streamerSettingsMenu;

	// Token: 0x0400022F RID: 559
	[SerializeField]
	private BaseMenu customMenu;

	// Token: 0x04000230 RID: 560
	[SerializeField]
	private ConfirmationMenu confirmMenu;

	// Token: 0x04000231 RID: 561
	private string string_1;

	// Token: 0x04000232 RID: 562
	private int int_4;

	// Token: 0x04000233 RID: 563
	private List<string> list_0;
}
