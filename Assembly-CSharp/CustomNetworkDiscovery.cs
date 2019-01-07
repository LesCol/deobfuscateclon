using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000061 RID: 97
public class CustomNetworkDiscovery : NetworkDiscovery
{
	// Token: 0x06001326 RID: 4902 RVA: 0x0000A237 File Offset: 0x00008437
	private IEnumerator method_0()
	{
		CustomNetworkDiscovery.Class29 @class = new CustomNetworkDiscovery.Class29(1);
		@class.customNetworkDiscovery_0 = this;
		return @class;
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0000A246 File Offset: 0x00008446
	private IEnumerator method_1()
	{
		for (;;)
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<string>();
			}
			this.list_0.Clear();
			if (base.broadcastsReceived == null)
			{
				break;
			}
			foreach (KeyValuePair<string, NetworkBroadcastResult> keyValuePair in base.broadcastsReceived)
			{
				this.list_0.Add(keyValuePair.Value.serverAddress);
			}
			base.broadcastsReceived.Clear();
			yield return new WaitForSeconds((float)base.broadcastInterval / 1000f * this.float_0);
		}
		yield break;
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x0000A268 File Offset: 0x00008468
	public void method_2()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		base.StopBroadcast();
		MonoBehaviour.print("");
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x0000A28E File Offset: 0x0000848E
	public void method_3()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_14());
		MonoBehaviour.print("MSAA Level" + base.broadcastPort);
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x0000A2CA File Offset: 0x000084CA
	public void method_4()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		base.StopBroadcast();
		MonoBehaviour.print("menu_music");
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x0000A2F0 File Offset: 0x000084F0
	public void method_5()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_0());
		MonoBehaviour.print("part guitar coop" + base.broadcastPort);
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x0000A237 File Offset: 0x00008437
	private IEnumerator method_6()
	{
		CustomNetworkDiscovery.Class29 @class = new CustomNetworkDiscovery.Class29(1);
		@class.customNetworkDiscovery_0 = this;
		return @class;
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x0000A32C File Offset: 0x0000852C
	public void method_7()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_19());
		MonoBehaviour.print("song" + base.broadcastPort);
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x0000A368 File Offset: 0x00008568
	public void method_8()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_1());
		MonoBehaviour.print("Unknown Charter" + base.broadcastPort);
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x0000A3A4 File Offset: 0x000085A4
	public void method_9()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_14());
		MonoBehaviour.print("Song Preview" + base.broadcastPort);
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x0000A3E0 File Offset: 0x000085E0
	public void method_10()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_16());
		MonoBehaviour.print("Listening on port: " + base.broadcastPort);
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x0000A41C File Offset: 0x0000861C
	public void method_11()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_14());
		MonoBehaviour.print("game" + base.broadcastPort);
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x0000A458 File Offset: 0x00008658
	public void method_12()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		base.StopBroadcast();
		MonoBehaviour.print("Expert");
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x0000A47E File Offset: 0x0000867E
	public void method_13()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_14());
		MonoBehaviour.print("album" + base.broadcastPort);
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x0000A246 File Offset: 0x00008446
	private IEnumerator method_14()
	{
		for (;;)
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<string>();
			}
			this.list_0.Clear();
			if (base.broadcastsReceived == null)
			{
				break;
			}
			foreach (KeyValuePair<string, NetworkBroadcastResult> keyValuePair in base.broadcastsReceived)
			{
				this.list_0.Add(keyValuePair.Value.serverAddress);
			}
			base.broadcastsReceived.Clear();
			yield return new WaitForSeconds((float)base.broadcastInterval / 1000f * this.float_0);
		}
		yield break;
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x0000A4BA File Offset: 0x000086BA
	public void method_15()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		base.StopBroadcast();
		MonoBehaviour.print("video");
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x0000A246 File Offset: 0x00008446
	private IEnumerator method_16()
	{
		for (;;)
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<string>();
			}
			this.list_0.Clear();
			if (base.broadcastsReceived == null)
			{
				break;
			}
			foreach (KeyValuePair<string, NetworkBroadcastResult> keyValuePair in base.broadcastsReceived)
			{
				this.list_0.Add(keyValuePair.Value.serverAddress);
			}
			base.broadcastsReceived.Clear();
			yield return new WaitForSeconds((float)base.broadcastInterval / 1000f * this.float_0);
		}
		yield break;
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x0000A4E0 File Offset: 0x000086E0
	public void method_17()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_1());
		MonoBehaviour.print("=" + base.broadcastPort);
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x0000A51C File Offset: 0x0000871C
	public void method_18()
	{
		base.Initialize();
		base.StartAsClient();
		this.coroutine_0 = base.StartCoroutine(this.method_19());
		MonoBehaviour.print("isHidden" + base.broadcastPort);
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x0000A237 File Offset: 0x00008437
	private IEnumerator method_19()
	{
		CustomNetworkDiscovery.Class29 @class = new CustomNetworkDiscovery.Class29(1);
		@class.customNetworkDiscovery_0 = this;
		return @class;
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x0000A558 File Offset: 0x00008758
	public void method_20()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		base.StopBroadcast();
		MonoBehaviour.print("Songs");
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x0000A57E File Offset: 0x0000877E
	public void method_21()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		base.StopBroadcast();
		MonoBehaviour.print("Stopped broadcast.");
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x0000A5A4 File Offset: 0x000087A4
	public void method_22()
	{
		if (this.coroutine_0 != null)
		{
			base.StopCoroutine(this.coroutine_0);
		}
		base.StopBroadcast();
		MonoBehaviour.print("pause_on_focus_lost");
	}

	// Token: 0x040002C2 RID: 706
	private float float_0 = 3f;

	// Token: 0x040002C3 RID: 707
	public List<string> list_0;

	// Token: 0x040002C4 RID: 708
	private Coroutine coroutine_0;
}
