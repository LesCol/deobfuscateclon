using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x02000030 RID: 48
public class FadeBehaviour : MonoBehaviour
{
	// Token: 0x06000775 RID: 1909 RVA: 0x000046BA File Offset: 0x000028BA
	public IEnumerator method_0(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(0);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_1()
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_2()
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x000046D0 File Offset: 0x000028D0
	private void method_3(Scene scene_0, Scene scene_1)
	{
		this.bool_0 = true;
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x000046D9 File Offset: 0x000028D9
	private void method_4()
	{
		if (FadeBehaviour.fadeBehaviour_0 != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		FadeBehaviour.fadeBehaviour_0 = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000046D9 File Offset: 0x000028D9
	private void method_5()
	{
		if (FadeBehaviour.fadeBehaviour_0 != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		FadeBehaviour.fadeBehaviour_0 = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x000046FB File Offset: 0x000028FB
	public void method_6(float float_1, float float_2)
	{
		this.fadeGraphic.canvasRenderer.SetAlpha(float_1);
		this.fadeGraphic.gameObject.SetActive(true);
		this.fadeGraphic.CrossFadeAlpha(float_2, this.float_0, true);
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00004732 File Offset: 0x00002932
	private void method_7()
	{
		SceneManager.activeSceneChanged += this.method_41;
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_8()
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000046BA File Offset: 0x000028BA
	public IEnumerator method_9(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(0);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_10()
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00004745 File Offset: 0x00002945
	public void method_11(float float_1, float float_2)
	{
		this.fadeGraphic.canvasRenderer.SetAlpha(float_1);
		this.fadeGraphic.gameObject.SetActive(false);
		this.fadeGraphic.CrossFadeAlpha(float_2, this.float_0, true);
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_12()
	{
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x0000477C File Offset: 0x0000297C
	public void method_13(float float_1, float float_2)
	{
		this.fadeGraphic.canvasRenderer.SetAlpha(float_1);
		this.fadeGraphic.gameObject.SetActive(true);
		this.fadeGraphic.CrossFadeAlpha(float_2, this.float_0, false);
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x000047B3 File Offset: 0x000029B3
	private void method_14()
	{
		SceneManager.activeSceneChanged += this.method_23;
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_15()
	{
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x000047B3 File Offset: 0x000029B3
	private void Start()
	{
		SceneManager.activeSceneChanged += this.method_23;
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x000046BA File Offset: 0x000028BA
	public IEnumerator method_16(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(0);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x000046BA File Offset: 0x000028BA
	public IEnumerator method_17(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(0);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_18()
	{
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x000047C6 File Offset: 0x000029C6
	private void method_19(Scene scene_0, Scene scene_1)
	{
		this.bool_0 = false;
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_20()
	{
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x0000477C File Offset: 0x0000297C
	public void method_21(float float_1, float float_2)
	{
		this.fadeGraphic.canvasRenderer.SetAlpha(float_1);
		this.fadeGraphic.gameObject.SetActive(true);
		this.fadeGraphic.CrossFadeAlpha(float_2, this.float_0, false);
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_22()
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x000047C6 File Offset: 0x000029C6
	private void method_23(Scene scene_0, Scene scene_1)
	{
		this.bool_0 = false;
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x000046BA File Offset: 0x000028BA
	public IEnumerator method_24(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(0);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x000046BA File Offset: 0x000028BA
	public IEnumerator method_25(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(0);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x000046D9 File Offset: 0x000028D9
	private void Awake()
	{
		if (FadeBehaviour.fadeBehaviour_0 != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		FadeBehaviour.fadeBehaviour_0 = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00004745 File Offset: 0x00002945
	public void method_26(float float_1, float float_2)
	{
		this.fadeGraphic.canvasRenderer.SetAlpha(float_1);
		this.fadeGraphic.gameObject.SetActive(false);
		this.fadeGraphic.CrossFadeAlpha(float_2, this.float_0, true);
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void Update()
	{
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_27()
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00004732 File Offset: 0x00002932
	private void method_28()
	{
		SceneManager.activeSceneChanged += this.method_41;
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x000047C6 File Offset: 0x000029C6
	private void method_29(Scene scene_0, Scene scene_1)
	{
		this.bool_0 = false;
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_30()
	{
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_31()
	{
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x000046D9 File Offset: 0x000028D9
	private void method_32()
	{
		if (FadeBehaviour.fadeBehaviour_0 != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		FadeBehaviour.fadeBehaviour_0 = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x000046D9 File Offset: 0x000028D9
	private void method_33()
	{
		if (FadeBehaviour.fadeBehaviour_0 != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		FadeBehaviour.fadeBehaviour_0 = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_34()
	{
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00002C8A File Offset: 0x00000E8A
	private void method_35()
	{
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x000047C6 File Offset: 0x000029C6
	private void method_36(Scene scene_0, Scene scene_1)
	{
		this.bool_0 = false;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x000046D9 File Offset: 0x000028D9
	private void method_37()
	{
		if (FadeBehaviour.fadeBehaviour_0 != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		FadeBehaviour.fadeBehaviour_0 = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x000046BA File Offset: 0x000028BA
	public IEnumerator method_38(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(0);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x000047CF File Offset: 0x000029CF
	private void method_39()
	{
		SceneManager.activeSceneChanged += this.method_29;
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x000046D9 File Offset: 0x000028D9
	private void method_40()
	{
		if (FadeBehaviour.fadeBehaviour_0 != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		FadeBehaviour.fadeBehaviour_0 = this;
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x000046D0 File Offset: 0x000028D0
	private void method_41(Scene scene_0, Scene scene_1)
	{
		this.bool_0 = true;
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x000047E2 File Offset: 0x000029E2
	public IEnumerator method_42(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(1);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x000047E2 File Offset: 0x000029E2
	public IEnumerator method_43(string string_0)
	{
		FadeBehaviour.Class12 @class = new FadeBehaviour.Class12(1);
		@class.fadeBehaviour_0 = this;
		@class.string_0 = string_0;
		return @class;
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x000047C6 File Offset: 0x000029C6
	private void method_44(Scene scene_0, Scene scene_1)
	{
		this.bool_0 = false;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x000047CF File Offset: 0x000029CF
	private void method_45()
	{
		SceneManager.activeSceneChanged += this.method_29;
	}

	// Token: 0x04000188 RID: 392
	public static FadeBehaviour fadeBehaviour_0;

	// Token: 0x04000189 RID: 393
	[SerializeField]
	private Image fadeGraphic;

	// Token: 0x0400018A RID: 394
	public float float_0;

	// Token: 0x0400018B RID: 395
	public bool bool_0;
}
