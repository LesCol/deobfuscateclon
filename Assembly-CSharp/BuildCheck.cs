using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200005F RID: 95
public class BuildCheck : MonoBehaviour
{
	// Token: 0x060012DD RID: 4829 RVA: 0x0000A112 File Offset: 0x00008312
	private IEnumerator method_0()
	{
		UnityWebRequest unityWebRequest = UnityWebRequest.Get(this.string_0);
		yield return unityWebRequest.SendWebRequest();
		if (!unityWebRequest.isNetworkError)
		{
			BuildVersion buildVersion = null;
			try
			{
				buildVersion = JsonUtility.FromJson<BuildVersion>(unityWebRequest.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (buildVersion != null)
			{
				yield return null;
				if (this.int_0 < buildVersion.method_9())
				{
					this.bool_1 = true;
				}
				if (this.int_0 == buildVersion.method_9() && this.int_1 < buildVersion.method_0())
				{
					this.bool_1 = true;
				}
				if (this.bool_1)
				{
					this.string_1 = buildVersion.download;
				}
			}
			base.enabled = false;
			buildVersion = null;
		}
		yield break;
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x0000A121 File Offset: 0x00008321
	private void method_1()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_2());
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x0000A140 File Offset: 0x00008340
	private IEnumerator method_2()
	{
		BuildCheck.Class28 @class = new BuildCheck.Class28(1);
		@class.buildCheck_0 = this;
		return @class;
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x0000A14F File Offset: 0x0000834F
	private void method_3()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_18());
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0000A16E File Offset: 0x0000836E
	private void method_4()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_0());
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0000A18D File Offset: 0x0000838D
	private void method_5()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_11());
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0000A16E File Offset: 0x0000836E
	private void Start()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_0());
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0000A1AC File Offset: 0x000083AC
	private void method_6()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_17());
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0000A140 File Offset: 0x00008340
	private IEnumerator method_7()
	{
		BuildCheck.Class28 @class = new BuildCheck.Class28(1);
		@class.buildCheck_0 = this;
		return @class;
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0000A121 File Offset: 0x00008321
	private void method_8()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_2());
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0000A1CB File Offset: 0x000083CB
	private void method_9()
	{
		if (this.bool_0)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.method_0());
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0000A121 File Offset: 0x00008321
	private void method_10()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_2());
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0000A112 File Offset: 0x00008312
	private IEnumerator method_11()
	{
		unityWebRequest = UnityWebRequest.Get(this.string_0);
		yield return unityWebRequest.SendWebRequest();
		if (!unityWebRequest.isNetworkError)
		{
			buildVersion = null;
			try
			{
				buildVersion = JsonUtility.FromJson<BuildVersion>(unityWebRequest.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (buildVersion != null)
			{
				yield return null;
				if (this.int_0 < buildVersion.method_9())
				{
					this.bool_1 = true;
				}
				if (this.int_0 == buildVersion.method_9() && this.int_1 < buildVersion.method_0())
				{
					this.bool_1 = true;
				}
				if (this.bool_1)
				{
					this.string_1 = buildVersion.download;
				}
			}
			base.enabled = false;
			buildVersion = null;
		}
		yield break;
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x0000A1AC File Offset: 0x000083AC
	private void method_12()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_17());
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x0000A1CB File Offset: 0x000083CB
	private void method_13()
	{
		if (this.bool_0)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.method_0());
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x0000A201 File Offset: 0x00008401
	private void method_14()
	{
		if (this.bool_0)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.method_7());
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x0000A1CB File Offset: 0x000083CB
	private void method_15()
	{
		if (this.bool_0)
		{
			base.enabled = true;
			return;
		}
		base.StartCoroutine(this.method_0());
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x0000A121 File Offset: 0x00008321
	private void method_16()
	{
		if (this.bool_0)
		{
			base.enabled = false;
			return;
		}
		base.StartCoroutine(this.method_2());
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x0000A140 File Offset: 0x00008340
	private IEnumerator method_17()
	{
		BuildCheck.Class28 @class = new BuildCheck.Class28(1);
		@class.buildCheck_0 = this;
		return @class;
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x0000A112 File Offset: 0x00008312
	private IEnumerator method_18()
	{
		unityWebRequest = UnityWebRequest.Get(this.string_0);
		yield return unityWebRequest.SendWebRequest();
		if (!unityWebRequest.isNetworkError)
		{
			buildVersion = null;
			try
			{
				buildVersion = JsonUtility.FromJson<BuildVersion>(unityWebRequest.downloadHandler.text);
			}
			catch (ArgumentException ex)
			{
				MonoBehaviour.print(ex.Message);
			}
			if (buildVersion != null)
			{
				yield return null;
				if (this.int_0 < buildVersion.method_9())
				{
					this.bool_1 = true;
				}
				if (this.int_0 == buildVersion.method_9() && this.int_1 < buildVersion.method_0())
				{
					this.bool_1 = true;
				}
				if (this.bool_1)
				{
					this.string_1 = buildVersion.download;
				}
			}
			base.enabled = false;
			buildVersion = null;
		}
		yield break;
	}

	// Token: 0x040002B6 RID: 694
	public string string_0;

	// Token: 0x040002B7 RID: 695
	[HideInInspector]
	public string string_1;

	// Token: 0x040002B8 RID: 696
	public int int_0 = 14;

	// Token: 0x040002B9 RID: 697
	public int int_1 = 1;

	// Token: 0x040002BA RID: 698
	public bool bool_0;

	// Token: 0x040002BB RID: 699
	public GameObject gameObject_0;

	// Token: 0x040002BC RID: 700
	[HideInInspector]
	public bool bool_1;
}
