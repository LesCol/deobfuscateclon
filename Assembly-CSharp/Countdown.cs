using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000AD RID: 173
public class Countdown : MonoBehaviour
{
	// Token: 0x06002166 RID: 8550 RVA: 0x0010B4D4 File Offset: 0x001096D4
	private void method_0()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_15("drums");
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x0010B540 File Offset: 0x00109740
	private void Start()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = false;
		behaviour.enabled = false;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_13("Get Ready!");
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_1()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x0010B5AC File Offset: 0x001097AC
	public void method_2(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_39(gclass9_0, true));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_37());
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_3()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x0010B614 File Offset: 0x00109814
	public void method_4(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_39(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_46());
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x0010B738 File Offset: 0x00109938
	public void method_6(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_30(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[0];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_37());
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x0010B7A0 File Offset: 0x001099A0
	private void method_7()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = false;
		behaviour.enabled = false;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = true;
		behaviour2.enabled = true;
		this.string_0 = GClass4.gclass4_0.method_21("mute_volume");
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x0010B80C File Offset: 0x00109A0C
	public void method_8(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_30(gclass9_0, true));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[0];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_3());
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x0010B874 File Offset: 0x00109A74
	public void method_9(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_30(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_18());
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x0010B8DC File Offset: 0x00109ADC
	public void method_10(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_30(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_39());
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x0010B944 File Offset: 0x00109B44
	public void method_11(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_39(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_37());
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_12()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x0010B9AC File Offset: 0x00109BAC
	private void method_13()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = false;
		behaviour.enabled = false;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = true;
		behaviour2.enabled = true;
		this.string_0 = GClass4.gclass4_0.method_16("delay");
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x0010BA18 File Offset: 0x00109C18
	private void method_14()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = false;
		behaviour.enabled = false;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_35("");
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_15()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_16()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_17()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_18()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x0010BA84 File Offset: 0x00109C84
	public void method_19(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_39(gclass9_0, true));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_16());
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x0010BAEC File Offset: 0x00109CEC
	public void method_20(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_39(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_51());
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_21()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_22()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x0010BB54 File Offset: 0x00109D54
	public void method_23(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_39(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[0];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_21());
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x0010BBBC File Offset: 0x00109DBC
	private void method_24()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = false;
		behaviour.enabled = false;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = true;
		behaviour2.enabled = true;
		this.string_0 = GClass4.gclass4_0.method_21("Don't Scan Songs");
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x0010BC28 File Offset: 0x00109E28
	public void method_25(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_30(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_17());
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x0010BC90 File Offset: 0x00109E90
	public void method_26(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_30(gclass9_0, true));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[0];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_32());
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x0010BCF8 File Offset: 0x00109EF8
	public void method_27(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_51(this.gameManager_0.method_30(gclass9_0, true));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_22());
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x0010BD60 File Offset: 0x00109F60
	private void method_28()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = false;
		behaviour.enabled = false;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_30("");
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x0010BDCC File Offset: 0x00109FCC
	private void method_29()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_13("Track Mute");
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x0010BE38 File Offset: 0x0010A038
	public void method_30(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_30(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_17());
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_31()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_32()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_33()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_34()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x0010BEA0 File Offset: 0x0010A0A0
	private void method_35()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_46("soloPointsText");
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x0010BF0C File Offset: 0x0010A10C
	public void method_36(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_30(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_1());
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_37()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x0010BF74 File Offset: 0x0010A174
	private void method_38()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = true;
		behaviour2.enabled = true;
		this.string_0 = GClass4.gclass4_0.method_42("Note Speed");
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_39()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x0010BFE0 File Offset: 0x0010A1E0
	public void method_40(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_39(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[0];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_51());
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x0010C048 File Offset: 0x0010A248
	private void method_41()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_16("No Part");
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_42()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x0010C0B4 File Offset: 0x0010A2B4
	public void method_43(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_39(gclass9_0, false));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[0];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_1());
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x0010BA84 File Offset: 0x00109C84
	public void method_44(CHPlayer gclass9_0)
	{
		this.list_0 = Chart.smethod_30(this.gameManager_0.method_39(gclass9_0, true));
		if (this.list_0 != null && this.list_0.Count != 0)
		{
			this.vector2_0 = this.list_0[1];
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.StartCoroutine(this.method_16());
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x0010C11C File Offset: 0x0010A31C
	private void method_45()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = true;
		behaviour2.enabled = true;
		this.string_0 = GClass4.gclass4_0.method_38("\"([^\"]*)\"");
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
	private IEnumerator method_46()
	{
		Countdown.Class47 @class = new Countdown.Class47(1);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x0010C188 File Offset: 0x0010A388
	private void method_47()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = false;
		behaviour.enabled = false;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = true;
		behaviour2.enabled = true;
		this.string_0 = GClass4.gclass4_0.method_17("Playlist");
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x0010C1F4 File Offset: 0x0010A3F4
	private void method_48()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_30("Ready");
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x0010C260 File Offset: 0x0010A460
	private void method_49()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_21("video");
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x0010C2CC File Offset: 0x0010A4CC
	private void method_50()
	{
		if (GlobalVariables.instance.isPracticeEnabled)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		Behaviour behaviour = this.textImage;
		this.textText.enabled = true;
		behaviour.enabled = true;
		Behaviour behaviour2 = this.timerText;
		this.timerImage.enabled = false;
		behaviour2.enabled = false;
		this.string_0 = GClass4.gclass4_0.method_42("video");
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x0000F605 File Offset: 0x0000D805
	private IEnumerator method_51()
	{
		Countdown.Class47 @class = new Countdown.Class47(0);
		@class.countdown_0 = this;
		return @class;
	}

	// Token: 0x0400055C RID: 1372
	[HideInInspector]
	public GameManager gameManager_0;

	// Token: 0x0400055D RID: 1373
	private List<Vector2> list_0;

	// Token: 0x0400055E RID: 1374
	[SerializeField]
	private Image textImage;

	// Token: 0x0400055F RID: 1375
	[SerializeField]
	private Image timerImage;

	// Token: 0x04000560 RID: 1376
	[SerializeField]
	private Text timerText;

	// Token: 0x04000561 RID: 1377
	[SerializeField]
	private Text textText;

	// Token: 0x04000562 RID: 1378
	private Vector2 vector2_0;

	// Token: 0x04000563 RID: 1379
	private int int_0;

	// Token: 0x04000564 RID: 1380
	private Color color_0 = Color.white;

	// Token: 0x04000565 RID: 1381
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(1f);

	// Token: 0x04000566 RID: 1382
	private WaitForSeconds waitForSeconds_1 = new WaitForSeconds(0.033f);

	// Token: 0x04000567 RID: 1383
	private WaitForSeconds waitForSeconds_2 = new WaitForSeconds(0.2f);

	// Token: 0x04000568 RID: 1384
	private string string_0;
}
