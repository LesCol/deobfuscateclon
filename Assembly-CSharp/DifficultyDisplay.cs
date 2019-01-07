using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000AF RID: 175
public class DifficultyDisplay : MonoBehaviour
{
	// Token: 0x060021E2 RID: 8674 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_0()
	{
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_1()
	{
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x0000F62B File Offset: 0x0000D82B
	public IEnumerator method_2(float float_2)
	{
		this.diffIndicator.SetActive(float_2 != -1f);
		if (this.animSpeed != -1f)
		{
			float num = 0f;
			float a = this.float_1;
			this.float_1 = float_2 / this.float_0;
			this.difficultyText.alpha = 0f;
			this.difficultyText.text = float_2.ToString();
			while (num < this.animSpeed)
			{
				this.radialFill.fillAmount = Mathf.Lerp(a, this.float_1, num / this.animSpeed);
				this.difficultyText.alpha = Mathf.Lerp(0f, 1f, num / this.animSpeed);
				yield return this.waitForEndOfFrame_0;
				num += Time.deltaTime;
			}
			this.radialFill.fillAmount = this.float_1;
			this.difficultyText.alpha = 1f;
		}
		yield break;
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_3()
	{
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x0000F641 File Offset: 0x0000D841
	public IEnumerator method_4(float float_2)
	{
		DifficultyDisplay.Class48 @class = new DifficultyDisplay.Class48(1);
		@class.difficultyDisplay_0 = this;
		@class.float_0 = float_2;
		return @class;
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x0000F62B File Offset: 0x0000D82B
	public IEnumerator method_5(float float_2)
	{
		this.diffIndicator.SetActive(float_2 != -1f);
		if (this.animSpeed != -1f)
		{
			num = 0f;
			a = this.float_1;
			this.float_1 = float_2 / this.float_0;
			this.difficultyText.alpha = 0f;
			this.difficultyText.text = float_2.ToString();
			while (num < this.animSpeed)
			{
				this.radialFill.fillAmount = Mathf.Lerp(a, this.float_1, num / this.animSpeed);
				this.difficultyText.alpha = Mathf.Lerp(0f, 1f, num / this.animSpeed);
				yield return this.waitForEndOfFrame_0;
				num += Time.deltaTime;
			}
			this.radialFill.fillAmount = this.float_1;
			this.difficultyText.alpha = 1f;
		}
		yield break;
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_6()
	{
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_7()
	{
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x0000F641 File Offset: 0x0000D841
	public IEnumerator method_8(float float_2)
	{
		DifficultyDisplay.Class48 @class = new DifficultyDisplay.Class48(1);
		@class.difficultyDisplay_0 = this;
		@class.float_0 = float_2;
		return @class;
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void Start()
	{
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_9()
	{
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void Update()
	{
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x0000F62B File Offset: 0x0000D82B
	public IEnumerator method_10(float float_2)
	{
		this.diffIndicator.SetActive(float_2 != -1f);
		if (this.animSpeed != -1f)
		{
			num = 0f;
			a = this.float_1;
			this.float_1 = float_2 / this.float_0;
			this.difficultyText.alpha = 0f;
			this.difficultyText.text = float_2.ToString();
			while (num < this.animSpeed)
			{
				this.radialFill.fillAmount = Mathf.Lerp(a, this.float_1, num / this.animSpeed);
				this.difficultyText.alpha = Mathf.Lerp(0f, 1f, num / this.animSpeed);
				yield return this.waitForEndOfFrame_0;
				num += Time.deltaTime;
			}
			this.radialFill.fillAmount = this.float_1;
			this.difficultyText.alpha = 1f;
		}
		yield break;
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_11()
	{
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_12()
	{
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x0000F62B File Offset: 0x0000D82B
	public IEnumerator method_13(float float_2)
	{
		this.diffIndicator.SetActive(float_2 != -1f);
		if (this.animSpeed != -1f)
		{
			num = 0f;
			a = this.float_1;
			this.float_1 = float_2 / this.float_0;
			this.difficultyText.alpha = 0f;
			this.difficultyText.text = float_2.ToString();
			while (num < this.animSpeed)
			{
				this.radialFill.fillAmount = Mathf.Lerp(a, this.float_1, num / this.animSpeed);
				this.difficultyText.alpha = Mathf.Lerp(0f, 1f, num / this.animSpeed);
				yield return this.waitForEndOfFrame_0;
				num += Time.deltaTime;
			}
			this.radialFill.fillAmount = this.float_1;
			this.difficultyText.alpha = 1f;
		}
		yield break;
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x0000F641 File Offset: 0x0000D841
	public IEnumerator method_14(float float_2)
	{
		DifficultyDisplay.Class48 @class = new DifficultyDisplay.Class48(1);
		@class.difficultyDisplay_0 = this;
		@class.float_0 = float_2;
		return @class;
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x0000F62B File Offset: 0x0000D82B
	public IEnumerator method_15(float float_2)
	{
		this.diffIndicator.SetActive(float_2 != -1f);
		if (this.animSpeed != -1f)
		{
			num = 0f;
			a = this.float_1;
			this.float_1 = float_2 / this.float_0;
			this.difficultyText.alpha = 0f;
			this.difficultyText.text = float_2.ToString();
			while (num < this.animSpeed)
			{
				this.radialFill.fillAmount = Mathf.Lerp(a, this.float_1, num / this.animSpeed);
				this.difficultyText.alpha = Mathf.Lerp(0f, 1f, num / this.animSpeed);
				yield return this.waitForEndOfFrame_0;
				num += Time.deltaTime;
			}
			this.radialFill.fillAmount = this.float_1;
			this.difficultyText.alpha = 1f;
		}
		yield break;
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_16()
	{
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_17()
	{
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_18()
	{
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_19()
	{
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_20()
	{
	}

	// Token: 0x0400056D RID: 1389
	[SerializeField]
	private Image radialFill;

	// Token: 0x0400056E RID: 1390
	[SerializeField]
	private TextMeshProUGUI difficultyText;

	// Token: 0x0400056F RID: 1391
	[SerializeField]
	private GameObject diffIndicator;

	// Token: 0x04000570 RID: 1392
	[SerializeField]
	private float animSpeed = 0.15f;

	// Token: 0x04000571 RID: 1393
	private float float_0 = 6f;

	// Token: 0x04000572 RID: 1394
	private float float_1;

	// Token: 0x04000573 RID: 1395
	public GStruct2.GEnum11 genum11_0;

	// Token: 0x04000574 RID: 1396
	private WaitForEndOfFrame waitForEndOfFrame_0 = new WaitForEndOfFrame();
}
