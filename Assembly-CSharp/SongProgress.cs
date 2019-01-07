using System;
using UnityEngine;

// Token: 0x020000BE RID: 190
public class SongProgress : MonoBehaviour
{
	// Token: 0x06002519 RID: 9497 RVA: 0x0011D470 File Offset: 0x0011B670
	private void method_0()
	{
		GameObject gameObject = GameObject.Find("part rhythm");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x0011D524 File Offset: 0x0011B724
	private void method_1()
	{
		GameObject gameObject = GameObject.Find("{0}");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x0011D5D8 File Offset: 0x0011B7D8
	private void method_2()
	{
		if (this.gameManager_0.double_1 < 134.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 914f)
		{
			num = 1700f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x0011D67C File Offset: 0x0011B87C
	private void method_3()
	{
		GameObject gameObject = GameObject.Find(" %n ");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x0011D730 File Offset: 0x0011B930
	private void method_4()
	{
		if (this.gameManager_0.double_1 < 1903.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 618f)
		{
			num = 311f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x0011D7D4 File Offset: 0x0011B9D4
	private void method_5()
	{
		if (this.gameManager_0.double_1 < 1713.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 782f)
		{
			num = 560f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x0011D878 File Offset: 0x0011BA78
	private void method_6()
	{
		if (this.gameManager_0.double_1 < 1927.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 22f)
		{
			num = 988f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x0011D91C File Offset: 0x0011BB1C
	private void method_7()
	{
		if (this.gameManager_0.double_1 < 491.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 87f)
		{
			num = 249f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x0011D9C0 File Offset: 0x0011BBC0
	private void method_8()
	{
		GameObject gameObject = GameObject.Find("Errors");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x0011DA74 File Offset: 0x0011BC74
	private void method_9()
	{
		if (this.gameManager_0.double_1 < 1072.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1497f)
		{
			num = 978f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x0011DB18 File Offset: 0x0011BD18
	private void method_10()
	{
		GameObject gameObject = GameObject.Find("diff_rhythm");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x0011DBCC File Offset: 0x0011BDCC
	private void method_11()
	{
		if (this.gameManager_0.double_1 < 890.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 944f)
		{
			num = 1363f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x0011DC70 File Offset: 0x0011BE70
	private void method_12()
	{
		GameObject gameObject = GameObject.Find("]");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x0011DD24 File Offset: 0x0011BF24
	private void method_13()
	{
		GameObject gameObject = GameObject.Find("Hard");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x0011DDD8 File Offset: 0x0011BFD8
	private void method_14()
	{
		GameObject gameObject = GameObject.Find("Tried to initialize the already initialized sound effects!");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x0011DE8C File Offset: 0x0011C08C
	private void method_15()
	{
		if (this.gameManager_0.double_1 < 1507.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1244f)
		{
			num = 842f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x0011DF30 File Offset: 0x0011C130
	private void method_16()
	{
		GameObject gameObject = GameObject.Find("");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x0011DFE4 File Offset: 0x0011C1E4
	private void method_17()
	{
		GameObject gameObject = GameObject.Find("Rename Setlist");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x0011E098 File Offset: 0x0011C298
	private void method_18()
	{
		if (this.gameManager_0.double_1 < 1757.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 493f)
		{
			num = 1458f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600252C RID: 9516 RVA: 0x0011E13C File Offset: 0x0011C33C
	private void method_19()
	{
		if (this.gameManager_0.double_1 < 1954.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 587f)
		{
			num = 4f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600252D RID: 9517 RVA: 0x0011E1E0 File Offset: 0x0011C3E0
	private void method_20()
	{
		if (this.gameManager_0.double_1 < 166.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 441f)
		{
			num = 934f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600252F RID: 9519 RVA: 0x0011E2EC File Offset: 0x0011C4EC
	private void method_21()
	{
		if (this.gameManager_0.double_1 < 945.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 844f)
		{
			num = 1531f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x0011E390 File Offset: 0x0011C590
	private void method_22()
	{
		GameObject gameObject = GameObject.Find("game");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x0011E444 File Offset: 0x0011C644
	private void method_23()
	{
		if (this.gameManager_0.double_1 < 1272.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 686f)
		{
			num = 683f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x0011E4E8 File Offset: 0x0011C6E8
	private void method_24()
	{
		if (this.gameManager_0.double_1 < 1710.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 566f)
		{
			num = 1488f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x0011E58C File Offset: 0x0011C78C
	private void method_25()
	{
		GameObject gameObject = GameObject.Find("Show Lyrics");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x0011E640 File Offset: 0x0011C840
	private void method_26()
	{
		if (this.gameManager_0.double_1 < 1898.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 92f)
		{
			num = 1223f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x0011E6E4 File Offset: 0x0011C8E4
	private void Start()
	{
		GameObject gameObject = GameObject.Find("Game Manager");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x0011E798 File Offset: 0x0011C998
	private void method_27()
	{
		GameObject gameObject = GameObject.Find(" (");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x0011E84C File Offset: 0x0011CA4C
	private void method_28()
	{
		if (this.gameManager_0.double_1 < 434.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 610f)
		{
			num = 576f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x0011E8F0 File Offset: 0x0011CAF0
	private void method_29()
	{
		if (this.gameManager_0.double_1 < 1981.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1153f)
		{
			num = 1744f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x0011E994 File Offset: 0x0011CB94
	private void method_30()
	{
		GameObject gameObject = GameObject.Find("Bass Guitar");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x0011EA48 File Offset: 0x0011CC48
	private void method_31()
	{
		if (this.gameManager_0.double_1 < 1176.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 732f)
		{
			num = 11f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x0011EAEC File Offset: 0x0011CCEC
	private void method_32()
	{
		if (this.gameManager_0.double_1 < 930.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1450f)
		{
			num = 303f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x0011EB90 File Offset: 0x0011CD90
	private void method_33()
	{
		if (this.gameManager_0.double_1 < 530.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 842f)
		{
			num = 1232f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x0011EC34 File Offset: 0x0011CE34
	private void method_34()
	{
		GameObject gameObject = GameObject.Find("setlistSongCountSingular");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x0011ECE8 File Offset: 0x0011CEE8
	private void method_35()
	{
		GameObject gameObject = GameObject.Find("Cancel");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x0011ED9C File Offset: 0x0011CF9C
	private void method_36()
	{
		if (this.gameManager_0.double_1 < 656.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 996f)
		{
			num = 365f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x0011EE40 File Offset: 0x0011D040
	private void method_37()
	{
		GameObject gameObject = GameObject.Find("offsets");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x0011EEF4 File Offset: 0x0011D0F4
	private void method_38()
	{
		GameObject gameObject = GameObject.Find("Are you sure you want to stop practicing?");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x0011EFA8 File Offset: 0x0011D1A8
	private void method_39()
	{
		if (this.gameManager_0.double_1 < 416.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1813f)
		{
			num = 927f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x0011F04C File Offset: 0x0011D24C
	private void method_40()
	{
		GameObject gameObject = GameObject.Find("\\d+ = E \"section [^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x0011F100 File Offset: 0x0011D300
	private void method_41()
	{
		if (this.gameManager_0.double_1 < 655.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 672f)
		{
			num = 1443f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
	private void method_42()
	{
		GameObject gameObject = GameObject.Find("GETTING FOLDERS...");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x0011F258 File Offset: 0x0011D458
	private void method_43()
	{
		GameObject gameObject = GameObject.Find("[SyncTrack]");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x0011F30C File Offset: 0x0011D50C
	private void method_44()
	{
		GameObject gameObject = GameObject.Find(".setlist");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x0011F3C0 File Offset: 0x0011D5C0
	private void method_45()
	{
		if (this.gameManager_0.double_1 < 1078.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1208f)
		{
			num = 1336f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x0011F464 File Offset: 0x0011D664
	private void method_46()
	{
		GameObject gameObject = GameObject.Find("mute_volume");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x0011F518 File Offset: 0x0011D718
	private void method_47()
	{
		if (this.gameManager_0.double_1 < 156.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 677f)
		{
			num = 1455f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x0011F5BC File Offset: 0x0011D7BC
	private void method_48()
	{
		GameObject gameObject = GameObject.Find("No");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x0011F670 File Offset: 0x0011D870
	private void method_49()
	{
		if (this.gameManager_0.double_1 < 381.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 197f)
		{
			num = 486f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x0011F714 File Offset: 0x0011D914
	private void FixedUpdate()
	{
		if (this.gameManager_0.double_1 < 0.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1f)
		{
			num = 1f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x0011F7B8 File Offset: 0x0011D9B8
	private void method_50()
	{
		GameObject gameObject = GameObject.Find("rhythm");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x0011E390 File Offset: 0x0011C590
	private void method_51()
	{
		GameObject gameObject = GameObject.Find("game");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x0011F86C File Offset: 0x0011DA6C
	private void method_52()
	{
		if (this.gameManager_0.double_1 < 1247.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 954f)
		{
			num = 269f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x0011F910 File Offset: 0x0011DB10
	private void method_53()
	{
		GameObject gameObject = GameObject.Find("ms");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x0011F9C4 File Offset: 0x0011DBC4
	private void method_54()
	{
		if (this.gameManager_0.double_1 < 1717.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 468f)
		{
			num = 1099f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x0011FA68 File Offset: 0x0011DC68
	private void method_55()
	{
		if (this.gameManager_0.double_1 < 527.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 554f)
		{
			num = 765f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x0011FB0C File Offset: 0x0011DD0C
	private void method_56()
	{
		if (this.gameManager_0.double_1 < 457.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1134f)
		{
			num = 1634f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x0011FBB0 File Offset: 0x0011DDB0
	private void method_57()
	{
		GameObject gameObject = GameObject.Find("No Part");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x0011FC64 File Offset: 0x0011DE64
	private void method_58()
	{
		if (this.gameManager_0.double_1 < 833.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 1920f)
		{
			num = 266f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x0011FD08 File Offset: 0x0011DF08
	private void method_59()
	{
		if (this.gameManager_0.double_1 < 1612.0)
		{
			return;
		}
		float num = (float)(this.gameManager_0.double_1 / this.gameManager_0.double_0);
		if (num > 280f)
		{
			num = 1636f;
		}
		this.vector3_0.x = this.float_0 + (this.float_1 - this.float_0) * num;
		this.vector3_1.x = this.float_2 * num;
		this.transform_0.localScale = this.vector3_1;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x0011FDAC File Offset: 0x0011DFAC
	private void method_60()
	{
		GameObject gameObject = GameObject.Find(".png|.jpg");
		this.gameManager_0 = gameObject.GetComponent<GameManager>();
		this.transform_0.localScale = this.vector3_1;
		this.vector3_0.x = (this.float_0 += base.transform.parent.position.x);
		this.float_1 += base.transform.parent.position.x;
		this.vector3_0.y = this.transform_1.position.y;
		this.transform_1.position = this.vector3_0;
	}

	// Token: 0x040005D2 RID: 1490
	private GameManager gameManager_0;

	// Token: 0x040005D3 RID: 1491
	public Transform transform_0;

	// Token: 0x040005D4 RID: 1492
	public Transform transform_1;

	// Token: 0x040005D5 RID: 1493
	private float float_0 = 1.06f;

	// Token: 0x040005D6 RID: 1494
	private float float_1 = 1.655f;

	// Token: 0x040005D7 RID: 1495
	private Vector3 vector3_0 = new Vector3(1.06f, -0.148f, 0f);

	// Token: 0x040005D8 RID: 1496
	private Vector3 vector3_1 = new Vector3(0f, 0.1f, 1f);

	// Token: 0x040005D9 RID: 1497
	private float float_2 = 3.71f;
}
