using System;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000063 RID: 99
public class MyNetManager : NetworkManager
{
	// Token: 0x060013A6 RID: 5030 RVA: 0x0000A5E1 File Offset: 0x000087E1
	public virtual void vmethod_0(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_22();
			}
			MonoBehaviour.print("You must restart, settings were changed");
		}
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x0000A619 File Offset: 0x00008819
	public virtual void vmethod_1(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_2();
			}
			MonoBehaviour.print("");
		}
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x0000A651 File Offset: 0x00008851
	public override void OnClientConnect(NetworkConnection conn)
	{
		base.OnClientConnect(conn);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_21();
			}
			MonoBehaviour.print("Connected to server");
		}
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x0000A689 File Offset: 0x00008889
	public virtual void vmethod_2(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_15();
			}
			MonoBehaviour.print("has_bots");
		}
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x00088AE0 File Offset: 0x00086CE0
	public virtual void vmethod_3(NetworkConnection networkConnection_0)
	{
		base.OnServerConnect(networkConnection_0);
		if (NetworkManager.singleton.client != null && NetworkManager.singleton.client.connection != networkConnection_0)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_20();
			}
			MonoBehaviour.print("Lyrics");
		}
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x00088B34 File Offset: 0x00086D34
	private void method_0()
	{
		foreach (NetworkConnection networkConnection in NetworkServer.connections)
		{
			if (networkConnection != NetworkManager.singleton.client.connection)
			{
				networkConnection.Disconnect();
			}
		}
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x0000A6C1 File Offset: 0x000088C1
	public virtual void vmethod_4(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_15();
			}
			MonoBehaviour.print("t1 gems");
		}
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x0000A6F9 File Offset: 0x000088F9
	private void Start()
	{
		NetworkManager.singleton.connectionConfig.NetworkDropThreshold = 90;
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00088B34 File Offset: 0x00086D34
	private void method_1()
	{
		foreach (NetworkConnection networkConnection in NetworkServer.connections)
		{
			if (networkConnection != NetworkManager.singleton.client.connection)
			{
				networkConnection.Disconnect();
			}
		}
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x0000A70C File Offset: 0x0000890C
	public virtual void vmethod_5()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_21();
		}
		this.method_2();
		base.OnStopHost();
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x0000A732 File Offset: 0x00008932
	public virtual void vmethod_6(NetworkConnection networkConnection_0, int int_0)
	{
		base.OnServerError(networkConnection_0, int_0);
		MonoBehaviour.print("enable_lyrics");
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x0000A746 File Offset: 0x00008946
	public virtual void vmethod_7(NetworkConnection networkConnection_0)
	{
		base.OnServerDisconnect(networkConnection_0);
		MonoBehaviour.print("drums");
		if (NetworkManager.singleton.client.connection != networkConnection_0 && !this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.StartAsServer();
		}
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x00088B34 File Offset: 0x00086D34
	private void method_2()
	{
		foreach (NetworkConnection networkConnection in NetworkServer.connections)
		{
			if (networkConnection != NetworkManager.singleton.client.connection)
			{
				networkConnection.Disconnect();
			}
		}
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x0000A784 File Offset: 0x00008984
	public override void OnServerDisconnect(NetworkConnection conn)
	{
		base.OnServerDisconnect(conn);
		MonoBehaviour.print("Client disconnected");
		if (NetworkManager.singleton.client.connection != conn && !this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.StartAsServer();
		}
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00088B94 File Offset: 0x00086D94
	public virtual void vmethod_8(NetworkConnection networkConnection_0, short short_0)
	{
		Transform startPosition = base.GetStartPosition();
		if (!startPosition)
		{
			MonoBehaviour.print("t1 gems");
			return;
		}
		GameObject player = UnityEngine.Object.Instantiate<GameObject>(base.spawnPrefabs[1], startPosition.position, startPosition.rotation);
		NetworkServer.AddPlayerForConnection(networkConnection_0, player, short_0);
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x0000A7C2 File Offset: 0x000089C2
	public virtual void vmethod_9(NetworkConnection networkConnection_0)
	{
		base.OnClientDisconnect(networkConnection_0);
		MonoBehaviour.print("song");
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x0000A7D5 File Offset: 0x000089D5
	public override void OnServerError(NetworkConnection conn, int errorCode)
	{
		base.OnServerError(conn, errorCode);
		MonoBehaviour.print("hi");
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x00088BE4 File Offset: 0x00086DE4
	public virtual void vmethod_10(NetworkConnection networkConnection_0)
	{
		base.OnServerConnect(networkConnection_0);
		if (NetworkManager.singleton.client != null && NetworkManager.singleton.client.connection != networkConnection_0)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_15();
			}
			MonoBehaviour.print("rhythm");
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00088C38 File Offset: 0x00086E38
	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		Transform startPosition = base.GetStartPosition();
		if (!startPosition)
		{
			MonoBehaviour.print("No NetworkStartPositions exist!");
			return;
		}
		GameObject player = UnityEngine.Object.Instantiate<GameObject>(base.spawnPrefabs[0], startPosition.position, startPosition.rotation);
		NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x00088C88 File Offset: 0x00086E88
	public virtual void vmethod_11(NetworkConnection networkConnection_0)
	{
		base.OnServerConnect(networkConnection_0);
		if (NetworkManager.singleton.client != null && NetworkManager.singleton.client.connection != networkConnection_0)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_12();
			}
			MonoBehaviour.print("<color=#FFFF04FF>");
		}
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x00088CDC File Offset: 0x00086EDC
	public virtual void vmethod_12()
	{
		NetworkTransport.Shutdown();
		NetworkTransport.Init();
		base.OnStartHost();
		if (!this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.Initialize();
			this.customNetworkDiscovery_0.StartAsServer();
			MonoBehaviour.print("menu_music");
		}
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x0000A7E9 File Offset: 0x000089E9
	public virtual void vmethod_13(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_2();
			}
			MonoBehaviour.print("0");
		}
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x0000A821 File Offset: 0x00008A21
	public virtual void vmethod_14(NetworkConnection networkConnection_0, int int_0)
	{
		base.OnServerError(networkConnection_0, int_0);
		MonoBehaviour.print(">");
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x00088D28 File Offset: 0x00086F28
	public override void OnStartHost()
	{
		NetworkTransport.Shutdown();
		NetworkTransport.Init();
		base.OnStartHost();
		if (!this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.Initialize();
			this.customNetworkDiscovery_0.StartAsServer();
			MonoBehaviour.print("Broadcasting started.");
		}
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x00088D74 File Offset: 0x00086F74
	public virtual void vmethod_15(NetworkConnection networkConnection_0)
	{
		base.OnServerConnect(networkConnection_0);
		if (NetworkManager.singleton.client != null && NetworkManager.singleton.client.connection != networkConnection_0)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_2();
			}
			MonoBehaviour.print("Client disconnected");
		}
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0000A835 File Offset: 0x00008A35
	public override void OnStopHost()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_21();
		}
		this.method_0();
		base.OnStopHost();
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x0000A85B File Offset: 0x00008A5B
	private void method_3()
	{
		NetworkManager.singleton.connectionConfig.NetworkDropThreshold = 120;
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0000A86E File Offset: 0x00008A6E
	public virtual void vmethod_16(NetworkConnection networkConnection_0, int int_0)
	{
		base.OnServerError(networkConnection_0, int_0);
		MonoBehaviour.print("Charter");
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00088B34 File Offset: 0x00086D34
	private void method_4()
	{
		foreach (NetworkConnection networkConnection in NetworkServer.connections)
		{
			if (networkConnection != NetworkManager.singleton.client.connection)
			{
				networkConnection.Disconnect();
			}
		}
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x0000A882 File Offset: 0x00008A82
	public override void OnClientDisconnect(NetworkConnection conn)
	{
		base.OnClientDisconnect(conn);
		MonoBehaviour.print("Disconnected from server.");
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00088DC8 File Offset: 0x00086FC8
	public virtual void vmethod_17(NetworkConnection networkConnection_0, short short_0)
	{
		Transform startPosition = base.GetStartPosition();
		if (!startPosition)
		{
			MonoBehaviour.print("Now Playing (Press Select to play)");
			return;
		}
		GameObject player = UnityEngine.Object.Instantiate<GameObject>(base.spawnPrefabs[0], startPosition.position, startPosition.rotation);
		NetworkServer.AddPlayerForConnection(networkConnection_0, player, short_0);
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00088E18 File Offset: 0x00087018
	public virtual void vmethod_18(NetworkConnection networkConnection_0, short short_0)
	{
		Transform startPosition = base.GetStartPosition();
		if (!startPosition)
		{
			MonoBehaviour.print(": <color=#FDB400FF>");
			return;
		}
		GameObject player = UnityEngine.Object.Instantiate<GameObject>(base.spawnPrefabs[0], startPosition.position, startPosition.rotation);
		NetworkServer.AddPlayerForConnection(networkConnection_0, player, short_0);
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00088B34 File Offset: 0x00086D34
	private void method_5()
	{
		foreach (NetworkConnection networkConnection in NetworkServer.connections)
		{
			if (networkConnection != NetworkManager.singleton.client.connection)
			{
				networkConnection.Disconnect();
			}
		}
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x0000A895 File Offset: 0x00008A95
	private void method_6()
	{
		NetworkManager.singleton.connectionConfig.NetworkDropThreshold = (byte)-76;
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x0000A8A8 File Offset: 0x00008AA8
	public virtual void vmethod_19()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_20();
		}
		this.method_0();
		base.OnStopHost();
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00088E68 File Offset: 0x00087068
	public virtual void vmethod_20()
	{
		NetworkTransport.Shutdown();
		NetworkTransport.Init();
		base.OnStartHost();
		if (!this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.Initialize();
			this.customNetworkDiscovery_0.StartAsServer();
			MonoBehaviour.print("Play Setlist");
		}
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x0000A8CE File Offset: 0x00008ACE
	public virtual void vmethod_21(NetworkConnection networkConnection_0, int int_0)
	{
		base.OnServerError(networkConnection_0, int_0);
		MonoBehaviour.print("MSAA Level");
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x00088EB4 File Offset: 0x000870B4
	public virtual void vmethod_22()
	{
		NetworkTransport.Shutdown();
		NetworkTransport.Init();
		base.OnStartHost();
		if (!this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.Initialize();
			this.customNetworkDiscovery_0.StartAsServer();
			MonoBehaviour.print("Bass Guitar");
		}
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x0000A8E2 File Offset: 0x00008AE2
	public virtual void vmethod_23(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_20();
			}
			MonoBehaviour.print("song");
		}
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00088B34 File Offset: 0x00086D34
	private void method_7()
	{
		foreach (NetworkConnection networkConnection in NetworkServer.connections)
		{
			if (networkConnection != NetworkManager.singleton.client.connection)
			{
				networkConnection.Disconnect();
			}
		}
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x0000A91A File Offset: 0x00008B1A
	public virtual void vmethod_24(NetworkConnection networkConnection_0)
	{
		base.OnClientDisconnect(networkConnection_0);
		MonoBehaviour.print("Unknown Charter");
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x0000A92D File Offset: 0x00008B2D
	public virtual void vmethod_25()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_15();
		}
		this.method_7();
		base.OnStopHost();
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x0000A953 File Offset: 0x00008B53
	public virtual void vmethod_26(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_21();
			}
			MonoBehaviour.print(" (");
		}
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x0000A98B File Offset: 0x00008B8B
	public virtual void vmethod_27()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_20();
		}
		this.method_4();
		base.OnStopHost();
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x0000A9B1 File Offset: 0x00008BB1
	public virtual void vmethod_28(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_15();
			}
			MonoBehaviour.print("volume");
		}
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x0000A9E9 File Offset: 0x00008BE9
	public virtual void vmethod_29(NetworkConnection networkConnection_0)
	{
		base.OnClientDisconnect(networkConnection_0);
		MonoBehaviour.print("");
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x0000A9FC File Offset: 0x00008BFC
	public virtual void vmethod_30(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_20();
			}
			MonoBehaviour.print("custom");
		}
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x0000AA34 File Offset: 0x00008C34
	private void method_8()
	{
		NetworkManager.singleton.connectionConfig.NetworkDropThreshold = 87;
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00088B34 File Offset: 0x00086D34
	private void method_9()
	{
		foreach (NetworkConnection networkConnection in NetworkServer.connections)
		{
			if (networkConnection != NetworkManager.singleton.client.connection)
			{
				networkConnection.Disconnect();
			}
		}
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x0000AA47 File Offset: 0x00008C47
	public virtual void vmethod_31(NetworkConnection networkConnection_0)
	{
		base.OnClientConnect(networkConnection_0);
		if (!this.customNetworkDiscovery_0.isServer)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_21();
			}
			MonoBehaviour.print("[prc_");
		}
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x0000AA7F File Offset: 0x00008C7F
	public virtual void vmethod_32()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_2();
		}
		this.method_0();
		base.OnStopHost();
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x0000AAA5 File Offset: 0x00008CA5
	public virtual void vmethod_33()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_20();
		}
		this.method_7();
		base.OnStopHost();
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x0000AACB File Offset: 0x00008CCB
	public virtual void vmethod_34(NetworkConnection networkConnection_0, int int_0)
	{
		base.OnServerError(networkConnection_0, int_0);
		MonoBehaviour.print("part guitar coop");
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00088F00 File Offset: 0x00087100
	public override void OnServerConnect(NetworkConnection conn)
	{
		base.OnServerConnect(conn);
		if (NetworkManager.singleton.client != null && NetworkManager.singleton.client.connection != conn)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_21();
			}
			MonoBehaviour.print("Client connected");
		}
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x0000AAE7 File Offset: 0x00008CE7
	private void method_10()
	{
		NetworkManager.singleton.connectionConfig.NetworkDropThreshold = 70;
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00088F54 File Offset: 0x00087154
	public virtual void vmethod_35()
	{
		NetworkTransport.Shutdown();
		NetworkTransport.Init();
		base.OnStartHost();
		if (!this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.Initialize();
			this.customNetworkDiscovery_0.StartAsServer();
			MonoBehaviour.print("Guitar Coop");
		}
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0000AAFA File Offset: 0x00008CFA
	public virtual void vmethod_36()
	{
		if (this.customNetworkDiscovery_0.running)
		{
			this.customNetworkDiscovery_0.method_22();
		}
		this.method_4();
		base.OnStopHost();
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x00088FA0 File Offset: 0x000871A0
	public virtual void vmethod_37(NetworkConnection networkConnection_0, short short_0)
	{
		Transform startPosition = base.GetStartPosition();
		if (!startPosition)
		{
			MonoBehaviour.print("no_fail");
			return;
		}
		GameObject player = UnityEngine.Object.Instantiate<GameObject>(base.spawnPrefabs[1], startPosition.position, startPosition.rotation);
		NetworkServer.AddPlayerForConnection(networkConnection_0, player, short_0);
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x00088FF0 File Offset: 0x000871F0
	public virtual void vmethod_38(NetworkConnection networkConnection_0)
	{
		base.OnServerConnect(networkConnection_0);
		if (NetworkManager.singleton.client != null && NetworkManager.singleton.client.connection != networkConnection_0)
		{
			if (this.customNetworkDiscovery_0.running)
			{
				this.customNetworkDiscovery_0.method_2();
			}
			MonoBehaviour.print("NowPlaying");
		}
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x0000AB20 File Offset: 0x00008D20
	private void method_11()
	{
		NetworkManager.singleton.connectionConfig.NetworkDropThreshold = (byte)-14;
	}

	// Token: 0x040002C8 RID: 712
	public CustomNetworkDiscovery customNetworkDiscovery_0;
}
