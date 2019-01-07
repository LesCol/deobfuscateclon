using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200008C RID: 140
public class OpenHitAnimator : MonoBehaviour
{
	// Token: 0x06001B1F RID: 6943 RVA: 0x000D9F68 File Offset: 0x000D8168
	public void method_0()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = false;
		renderer.enabled = false;
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void Start()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_1()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
	public IEnumerator method_2(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(0);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_3()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_4()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x000D9F9C File Offset: 0x000D819C
	private void method_5()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 322f)
		{
			return;
		}
		while (this.float_0 >= 1263f)
		{
			this.int_0 += 0;
			this.float_0 -= 1195f;
			this.color_0.a = this.color_0.a - 1784f;
		}
		float t = (float)this.int_0 * 81f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 8)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_23();
			}
		}
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_6()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x000DA0C0 File Offset: 0x000D82C0
	public void method_7()
	{
		base.enabled = false;
		this.bool_1 = false;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = true;
		renderer.enabled = true;
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
	public IEnumerator method_8(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(0);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_9()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
	public IEnumerator method_10(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(0);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x000DA0F4 File Offset: 0x000D82F4
	private void method_11()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1977f)
		{
			return;
		}
		while (this.float_0 >= 185f)
		{
			this.int_0++;
			this.float_0 -= 979f;
			this.color_0.a = this.color_0.a - 1386f;
		}
		float t = (float)this.int_0 * 624f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 4)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_55();
			}
		}
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_12()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x000DA218 File Offset: 0x000D8418
	private void method_13()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1068f)
		{
			return;
		}
		while (this.float_0 >= 190f)
		{
			this.int_0 += 0;
			this.float_0 -= 1500f;
			this.color_0.a = this.color_0.a - 108f;
		}
		float t = (float)this.int_0 * 400f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 6)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_55();
			}
		}
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
	public IEnumerator method_14(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(0);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x000DA33C File Offset: 0x000D853C
	private void method_15()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 353f)
		{
			return;
		}
		while (this.float_0 >= 730f)
		{
			this.int_0++;
			this.float_0 -= 14f;
			this.color_0.a = this.color_0.a - 546f;
		}
		float t = (float)this.int_0 * 1557f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 1)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_57();
			}
		}
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_16()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_17()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x000DA460 File Offset: 0x000D8660
	private void method_18()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1588f)
		{
			return;
		}
		while (this.float_0 >= 1115f)
		{
			this.int_0 += 0;
			this.float_0 -= 435f;
			this.color_0.a = this.color_0.a - 1256f;
		}
		float t = (float)this.int_0 * 1660f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 0)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_55();
			}
		}
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x000DA584 File Offset: 0x000D8784
	private void method_19()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 782f)
		{
			return;
		}
		while (this.float_0 >= 1593f)
		{
			this.int_0++;
			this.float_0 -= 468f;
			this.color_0.a = this.color_0.a - 738f;
		}
		float t = (float)this.int_0 * 532f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 4)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_30();
			}
		}
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x000DA6A8 File Offset: 0x000D88A8
	private void method_20()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1386f)
		{
			return;
		}
		while (this.float_0 >= 1761f)
		{
			this.int_0 += 0;
			this.float_0 -= 1860f;
			this.color_0.a = this.color_0.a - 292f;
		}
		float t = (float)this.int_0 * 1150f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 8)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_26();
			}
		}
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x000D9F68 File Offset: 0x000D8168
	public void method_21()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = false;
		renderer.enabled = false;
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0000D016 File Offset: 0x0000B216
	public IEnumerator method_22(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(1);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x000D9F68 File Offset: 0x000D8168
	public void method_23()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = false;
		renderer.enabled = false;
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_24()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x000DA7CC File Offset: 0x000D89CC
	private void method_25()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1132f)
		{
			return;
		}
		while (this.float_0 >= 1264f)
		{
			this.int_0 += 0;
			this.float_0 -= 9f;
			this.color_0.a = this.color_0.a - 379f;
		}
		float t = (float)this.int_0 * 1047f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 3)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_55();
			}
		}
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x000DA8F0 File Offset: 0x000D8AF0
	public void method_26()
	{
		base.enabled = true;
		this.bool_1 = false;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = true;
		renderer.enabled = true;
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x000DA924 File Offset: 0x000D8B24
	private void Update()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 0.016f)
		{
			return;
		}
		while (this.float_0 >= 0.016f)
		{
			this.int_0++;
			this.float_0 -= 0.016f;
			this.color_0.a = this.color_0.a - 0.15f;
		}
		float t = (float)this.int_0 * 0.2f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 6)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_23();
			}
		}
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x000DA8F0 File Offset: 0x000D8AF0
	public void method_27()
	{
		base.enabled = true;
		this.bool_1 = false;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = true;
		renderer.enabled = true;
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_28()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_29()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x000DAA48 File Offset: 0x000D8C48
	public void method_30()
	{
		base.enabled = true;
		this.bool_1 = false;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = false;
		renderer.enabled = false;
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_31()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_32()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_33()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x0000D016 File Offset: 0x0000B216
	public IEnumerator method_34(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(1);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_35()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x0000D016 File Offset: 0x0000B216
	public IEnumerator method_36(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(1);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x000DAA7C File Offset: 0x000D8C7C
	private void method_37()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1217f)
		{
			return;
		}
		while (this.float_0 >= 1221f)
		{
			this.int_0++;
			this.float_0 -= 1572f;
			this.color_0.a = this.color_0.a - 1986f;
		}
		float t = (float)this.int_0 * 1497f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 0)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_7();
			}
		}
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x000DABA0 File Offset: 0x000D8DA0
	private void method_38()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1207f)
		{
			return;
		}
		while (this.float_0 >= 245f)
		{
			this.int_0 += 0;
			this.float_0 -= 169f;
			this.color_0.a = this.color_0.a - 1229f;
		}
		float t = (float)this.int_0 * 612f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 5)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_0();
			}
		}
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_39()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x0000D016 File Offset: 0x0000B216
	public IEnumerator method_40(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(1);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_41()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_42()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x0000D016 File Offset: 0x0000B216
	public IEnumerator method_43(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(1);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x000DACC4 File Offset: 0x000D8EC4
	private void method_44()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1631f)
		{
			return;
		}
		while (this.float_0 >= 1348f)
		{
			this.int_0 += 0;
			this.float_0 -= 941f;
			this.color_0.a = this.color_0.a - 792f;
		}
		float t = (float)this.int_0 * 826f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 2)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_30();
			}
		}
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x0000D016 File Offset: 0x0000B216
	public IEnumerator method_45(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(1);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x000DADE8 File Offset: 0x000D8FE8
	public void method_46()
	{
		base.enabled = true;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = true;
		renderer.enabled = true;
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_47()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x000DAE1C File Offset: 0x000D901C
	private void method_48()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1224f)
		{
			return;
		}
		while (this.float_0 >= 1654f)
		{
			this.int_0 += 0;
			this.float_0 -= 943f;
			this.color_0.a = this.color_0.a - 316f;
		}
		float t = (float)this.int_0 * 1427f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 1)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_27();
			}
		}
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x000DAF40 File Offset: 0x000D9140
	private void method_49()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 2f)
		{
			return;
		}
		while (this.float_0 >= 167f)
		{
			this.int_0 += 0;
			this.float_0 -= 1436f;
			this.color_0.a = this.color_0.a - 520f;
		}
		float t = (float)this.int_0 * 1953f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 0)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_26();
			}
		}
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x000DB064 File Offset: 0x000D9264
	public void method_50()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = true;
		renderer.enabled = true;
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x000DB098 File Offset: 0x000D9298
	private void method_51()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1819f)
		{
			return;
		}
		while (this.float_0 >= 728f)
		{
			this.int_0++;
			this.float_0 -= 458f;
			this.color_0.a = this.color_0.a - 491f;
		}
		float t = (float)this.int_0 * 1326f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 8)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = true;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_26();
			}
		}
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
	public IEnumerator method_52(bool bool_2)
	{
		OpenHitAnimator.Class38 @class = new OpenHitAnimator.Class38(0);
		@class.openHitAnimator_0 = this;
		@class.bool_0 = bool_2;
		return @class;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x000DB1BC File Offset: 0x000D93BC
	private void method_53()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 324f)
		{
			return;
		}
		while (this.float_0 >= 618f)
		{
			this.int_0 += 0;
			this.float_0 -= 1171f;
			this.color_0.a = this.color_0.a - 323f;
		}
		float t = (float)this.int_0 * 381f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 1)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_27();
			}
		}
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x000DB2E0 File Offset: 0x000D94E0
	private void method_54()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 906f)
		{
			return;
		}
		while (this.float_0 >= 723f)
		{
			this.int_0 += 0;
			this.float_0 -= 1840f;
			this.color_0.a = this.color_0.a - 204f;
		}
		float t = (float)this.int_0 * 1121f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 2)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 0;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_23();
			}
		}
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x000DB064 File Offset: 0x000D9264
	public void method_55()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = true;
		renderer.enabled = true;
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x0000CFEB File Offset: 0x0000B1EB
	private void method_56()
	{
		base.enabled = true;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x000D9F68 File Offset: 0x000D8168
	public void method_57()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = false;
		renderer.enabled = false;
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x000D9F68 File Offset: 0x000D8168
	public void method_58()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = false;
		renderer.enabled = false;
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_59()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x000D9F68 File Offset: 0x000D8168
	public void method_60()
	{
		base.enabled = false;
		this.bool_1 = true;
		Renderer renderer = this.spriteRenderer_0;
		this.spriteRenderer_1.enabled = false;
		renderer.enabled = false;
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	private void method_61()
	{
		base.enabled = false;
		this.spriteRenderer_0 = this.flamesTransform.GetComponent<SpriteRenderer>();
		this.spriteRenderer_1 = this.ovalTransform.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x000DB404 File Offset: 0x000D9604
	private void method_62()
	{
		this.float_0 += Time.deltaTime;
		if (this.float_0 < 1880f)
		{
			return;
		}
		while (this.float_0 >= 1253f)
		{
			this.int_0++;
			this.float_0 -= 1988f;
			this.color_0.a = this.color_0.a - 341f;
		}
		float t = (float)this.int_0 * 33f;
		this.flamesTransform.localScale = Vector3.Lerp(this.defaultFlamesSize, this.endFlamesSize, t);
		this.ovalTransform.localScale = Vector3.Lerp(this.defaultOvalSize, this.endOvalSize, t);
		this.spriteRenderer_0.color = (this.spriteRenderer_1.color = this.color_0);
		if (this.int_0 >= 7)
		{
			if (this.bool_0)
			{
				this.spriteRenderer_1.enabled = false;
				this.int_0 = 1;
				if (this.guitarPlayer.bool_1)
				{
					this.color_0 = GClass7.color_4;
					return;
				}
				this.color_0 = GClass7.color_6;
				return;
			}
			else
			{
				this.method_26();
			}
		}
	}

	// Token: 0x0400042F RID: 1071
	[SerializeField]
	private BasePlayer guitarPlayer;

	// Token: 0x04000430 RID: 1072
	[SerializeField]
	private Transform flamesTransform;

	// Token: 0x04000431 RID: 1073
	[SerializeField]
	private Transform ovalTransform;

	// Token: 0x04000432 RID: 1074
	private SpriteRenderer spriteRenderer_0;

	// Token: 0x04000433 RID: 1075
	private SpriteRenderer spriteRenderer_1;

	// Token: 0x04000434 RID: 1076
	private bool bool_0;

	// Token: 0x04000435 RID: 1077
	private bool bool_1;

	// Token: 0x04000436 RID: 1078
	[SerializeField]
	private Vector3 defaultFlamesSize;

	// Token: 0x04000437 RID: 1079
	[SerializeField]
	private Vector3 endFlamesSize;

	// Token: 0x04000438 RID: 1080
	[SerializeField]
	private Vector3 defaultOvalSize;

	// Token: 0x04000439 RID: 1081
	[SerializeField]
	private Vector3 endOvalSize;

	// Token: 0x0400043A RID: 1082
	private float float_0;

	// Token: 0x0400043B RID: 1083
	private int int_0;

	// Token: 0x0400043C RID: 1084
	private Color color_0;

	// Token: 0x0400043D RID: 1085
	private WaitForSeconds waitForSeconds_0 = new WaitForSeconds(0.096f);
}
