using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000028 RID: 40
public class BuildHyperlink : MonoBehaviour
{
	// Token: 0x0600064A RID: 1610 RVA: 0x00042FB4 File Offset: 0x000411B4
	private void method_0()
	{
		if (!this.t.enabled && this.buildCheck_0.bool_1)
		{
			Behaviour behaviour = this.t;
			this.t1.enabled = true;
			behaviour.enabled = true;
		}
		if (this.t.enabled && Input.GetKeyDown((KeyCode)(-160)))
		{
			Application.OpenURL(this.buildCheck_0.string_1);
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000042DF File Offset: 0x000024DF
	private void method_1()
	{
		this.buildCheck_0 = base.GetComponent<BuildCheck>();
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0004301C File Offset: 0x0004121C
	private void method_2()
	{
		if (!this.t.enabled && this.buildCheck_0.bool_1)
		{
			Behaviour behaviour = this.t;
			this.t1.enabled = true;
			behaviour.enabled = true;
		}
		if (this.t.enabled && Input.GetKeyDown(KeyCode.Hash))
		{
			Application.OpenURL(this.buildCheck_0.string_1);
		}
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x000042DF File Offset: 0x000024DF
	private void method_3()
	{
		this.buildCheck_0 = base.GetComponent<BuildCheck>();
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00043084 File Offset: 0x00041284
	private void method_4()
	{
		if (!this.t.enabled && this.buildCheck_0.bool_1)
		{
			Behaviour behaviour = this.t;
			this.t1.enabled = true;
			behaviour.enabled = true;
		}
		if (this.t.enabled && Input.GetKeyDown((KeyCode)(-165)))
		{
			Application.OpenURL(this.buildCheck_0.string_1);
		}
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000430EC File Offset: 0x000412EC
	private void method_5()
	{
		if (!this.t.enabled && this.buildCheck_0.bool_1)
		{
			Behaviour behaviour = this.t;
			this.t1.enabled = false;
			behaviour.enabled = false;
		}
		if (this.t.enabled && Input.GetKeyDown((KeyCode)(-175)))
		{
			Application.OpenURL(this.buildCheck_0.string_1);
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x000042DF File Offset: 0x000024DF
	private void Start()
	{
		this.buildCheck_0 = base.GetComponent<BuildCheck>();
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00043154 File Offset: 0x00041354
	private void method_6()
	{
		if (!this.t.enabled && this.buildCheck_0.bool_1)
		{
			Behaviour behaviour = this.t;
			this.t1.enabled = false;
			behaviour.enabled = false;
		}
		if (this.t.enabled && Input.GetKeyDown((KeyCode)(-27)))
		{
			Application.OpenURL(this.buildCheck_0.string_1);
		}
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x000431BC File Offset: 0x000413BC
	private void Update()
	{
		if (!this.t.enabled && this.buildCheck_0.bool_1)
		{
			Behaviour behaviour = this.t;
			this.t1.enabled = true;
			behaviour.enabled = true;
		}
		if (this.t.enabled && Input.GetKeyDown(KeyCode.F12))
		{
			Application.OpenURL(this.buildCheck_0.string_1);
		}
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x000042DF File Offset: 0x000024DF
	private void method_7()
	{
		this.buildCheck_0 = base.GetComponent<BuildCheck>();
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00043224 File Offset: 0x00041424
	private void method_8()
	{
		if (!this.t.enabled && this.buildCheck_0.bool_1)
		{
			Behaviour behaviour = this.t;
			this.t1.enabled = false;
			behaviour.enabled = false;
		}
		if (this.t.enabled && Input.GetKeyDown((KeyCode)(-3)))
		{
			Application.OpenURL(this.buildCheck_0.string_1);
		}
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x000042DF File Offset: 0x000024DF
	private void method_9()
	{
		this.buildCheck_0 = base.GetComponent<BuildCheck>();
	}

	// Token: 0x04000160 RID: 352
	private BuildCheck buildCheck_0;

	// Token: 0x04000161 RID: 353
	[SerializeField]
	private Text t;

	// Token: 0x04000162 RID: 354
	[SerializeField]
	private Text t1;
}
