using System;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000065 RID: 101
[RequireComponent(typeof(NetworkDiscovery))]
[RequireComponent(typeof(NetworkManager))]
public class NetworkHUD : MonoBehaviour
{
	// Token: 0x0600140D RID: 5133 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_0()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x00089044 File Offset: 0x00087244
	private void method_1(string string_0)
	{
		string networkAddress = string_0.Remove(0, string_0.LastIndexOf('\u0003') + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x0008907C File Offset: 0x0008727C
	private void method_2()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(358f, 35f, 962f, 1625f);
				object[] array = new object[8];
				array[0] = "song";
				array[0] = this.myNetManager_0.networkAddress;
				array[7] = "Ready";
				array[3] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1038f, 200f, 1623f, 150f), "Lights Out" + (this.customNetworkDiscovery_0.running ? "Show in Finder" : ""));
			}
			else
			{
				Rect position2 = new Rect(419f, 771f, 1556f, 1296f);
				object[] array2 = new object[4];
				array2[0] = " - ";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[8] = "Name = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"";
				array2[0] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1312f, 1201f, 498f, 1739f), "New Setlist"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(31f, 43f, 313f, 1737f), "video"))
				{
					this.customNetworkDiscovery_0.method_4();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(907f, (float)(77 + i * 87), 997f, 795f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_1(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1619f, 183f, 1670f, 233f), "diff_bass"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1399f, 757f, 1694f, 30f), this.myNetManager_0.networkAddress, 7);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1099f, 714f, 1570f, 788f), "Songs"))
			{
				this.method_38(text);
			}
			if (GUI.Button(new Rect(1712f, 668f, 342f, 1548f), "game"))
			{
				this.customNetworkDiscovery_0.method_10();
			}
		}
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_3()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00089368 File Offset: 0x00087568
	private void method_4()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(781f, 956f, 1448f, 264f);
				object[] array = new object[3];
				array[1] = "Press Enter to confirm";
				array[1] = this.myNetManager_0.networkAddress;
				array[2] = "year";
				array[0] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1689f, 959f, 441f, 1357f), "Note Shuffle" + (this.customNetworkDiscovery_0.running ? "<NULL PATH>" : "Genre = \"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""));
			}
			else
			{
				Rect position2 = new Rect(1660f, 1982f, 155f, 1004f);
				object[] array2 = new object[2];
				array2[0] = "show_hit_window";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[8] = "Unknown Charter";
				array2[2] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(734f, 1279f, 508f, 1045f), "song"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(144f, 1504f, 1276f, 1144f), "Continue"))
				{
					this.customNetworkDiscovery_0.method_2();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(355f, (float)(-32 + i * 65), 1546f, 1782f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_16(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(856f, 1037f, 898f, 1596f), "rhythm"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(104f, 1404f, 568f, 1455f), this.myNetManager_0.networkAddress, 99);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(327f, 1396f, 1929f, 1472f), "Unknown Genre"))
			{
				this.method_30(text);
			}
			if (GUI.Button(new Rect(1470f, 910f, 1826f, 463f), "song"))
			{
				this.customNetworkDiscovery_0.method_10();
			}
		}
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_5()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00089654 File Offset: 0x00087854
	private void method_6()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1954f, 1616f, 1938f, 1452f);
				object[] array = new object[1];
				array[1] = "playlist_track";
				array[0] = this.myNetManager_0.networkAddress;
				array[8] = "Unknown Charter";
				array[8] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1740f, 44f, 1113f, 969f), "No" + (this.customNetworkDiscovery_0.running ? "highway_shake_enabled" : "Unknown Album"));
			}
			else
			{
				Rect position2 = new Rect(1577f, 1872f, 1195f, 933f);
				object[] array2 = new object[6];
				array2[1] = "device";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[2] = "This is a placeholder";
				array2[7] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1153f, 1781f, 627f, 561f), "\\D+"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(76f, 1446f, 1161f, 1261f), "No"))
				{
					this.customNetworkDiscovery_0.method_15();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(576f, (float)(57 + i * -20), 669f, 1746f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_38(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1254f, 1943f, 623f, 1163f), "Album"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1690f, 1193f, 324f, 668f), this.myNetManager_0.networkAddress, 2);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(278f, 489f, 963f, 53f), ""))
			{
				this.method_39(text);
			}
			if (GUI.Button(new Rect(1183f, 701f, 665f, 1891f), "Setlist"))
			{
				this.customNetworkDiscovery_0.method_17();
			}
		}
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x00089940 File Offset: 0x00087B40
	private void method_7()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(643f, 458f, 190f, 660f);
				object[] array = new object[4];
				array[1] = "song";
				array[1] = this.myNetManager_0.networkAddress;
				array[3] = "background_video";
				array[5] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1028f, 1605f, 1998f, 1214f), "" + (this.customNetworkDiscovery_0.running ? "/songs.txt" : "Open Data Privacy Page"));
			}
			else
			{
				Rect position2 = new Rect(165f, 1578f, 1294f, 329f);
				object[] array2 = new object[6];
				array2[1] = "Good Solo";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[5] = "Game Manager";
				array2[7] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(894f, 1965f, 174f, 1340f), "Easy"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(153f, 1852f, 500f, 743f), "Quit"))
				{
					this.customNetworkDiscovery_0.method_21();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1529f, (float)(117 + i * -72), 1501f, 1259f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_30(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1018f, 1092f, 775f, 1870f), "drums_3"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1556f, 1660f, 342f, 475f), this.myNetManager_0.networkAddress, -88);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1015f, 974f, 1240f, 1012f), ")"))
			{
				this.method_26(text);
			}
			if (GUI.Button(new Rect(309f, 1530f, 1812f, 482f), "SONG SETTINGS"))
			{
				this.customNetworkDiscovery_0.method_5();
			}
		}
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_8()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x0000AE05 File Offset: 0x00009005
	private void Awake()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00089C2C File Offset: 0x00087E2C
	private void method_9()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1547f, 267f, 601f, 909f);
				object[] array = new object[2];
				array[0] = "setlistSongCountSingular";
				array[0] = this.myNetManager_0.networkAddress;
				array[2] = "Gem Size";
				array[6] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(696f, 1065f, 852f, 1813f), "Rhythm Guitar" + (this.customNetworkDiscovery_0.running ? "volume" : "/"));
			}
			else
			{
				Rect position2 = new Rect(802f, 1457f, 1566f, 327f);
				object[] array2 = new object[7];
				array2[0] = "";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[8] = "Cancel";
				array2[8] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(217f, 1361f, 1075f, 1058f), "volume"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(664f, 1826f, 1320f, 58f), "%n"))
				{
					this.customNetworkDiscovery_0.method_15();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1369f, (float)(102 + i * -74), 502f, 1574f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_20(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(410f, 720f, 1226f, 762f), "%"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(859f, 1599f, 1143f, 1801f), this.myNetManager_0.networkAddress, 28);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(684f, 96f, 1672f, 152f), "No"))
			{
				this.method_16(text);
			}
			if (GUI.Button(new Rect(38f, 102f, 429f, 1483f), "song_export"))
			{
				this.customNetworkDiscovery_0.method_11();
			}
		}
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x00089F18 File Offset: 0x00088118
	private void method_10()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(51f, 823f, 1949f, 246f);
				object[] array = new object[8];
				array[0] = "Stars";
				array[0] = this.myNetManager_0.networkAddress;
				array[8] = "Camera";
				array[7] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(57f, 933f, 292f, 754f), "custom" + (this.customNetworkDiscovery_0.running ? "artist" : "%"));
			}
			else
			{
				Rect position2 = new Rect(326f, 198f, 1449f, 1188f);
				object[] array2 = new object[7];
				array2[0] = "Video Settings";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[5] = "SONG SETTINGS";
				array2[1] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(555f, 314f, 1335f, 475f), "custom"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1551f, 1811f, 1732f, 543f), ": <color=#FDB400FF>"))
				{
					this.customNetworkDiscovery_0.method_4();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1151f, (float)(-96 + i * 7), 1910f, 643f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_20(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(225f, 1212f, 1223f, 37f), "Options"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(819f, 691f, 1748f, 508f), this.myNetManager_0.networkAddress, -18);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1157f, 1164f, 1285f, 439f), ".mp4|.avi|.webm|.vp8|.ogv|.mpeg"))
			{
				this.method_31(text);
			}
			if (GUI.Button(new Rect(562f, 1606f, 1375f, 1817f), "game"))
			{
				this.customNetworkDiscovery_0.method_5();
			}
		}
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x0008A204 File Offset: 0x00088404
	private void method_11()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1160f, 1129f, 1984f, 219f);
				object[] array = new object[3];
				array[0] = "genre";
				array[1] = this.myNetManager_0.networkAddress;
				array[8] = "";
				array[7] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(648f, 124f, 1858f, 1604f), "Difficulty" + (this.customNetworkDiscovery_0.running ? "ch" : "Songs"));
			}
			else
			{
				Rect position2 = new Rect(1696f, 1584f, 177f, 1499f);
				object[] array2 = new object[8];
				array2[0] = "Song Options";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[0] = "[prc_";
				array2[8] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(582f, 744f, 1942f, 352f), "Press Enter to confirm"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(663f, 367f, 676f, 1669f), "Options"))
				{
					this.customNetworkDiscovery_0.method_12();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1846f, (float)(-86 + i * 127), 4f, 1164f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_30(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(101f, 179f, 325f, 760f), "cpu_count"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1167f, 1974f, 656f, 1431f), this.myNetManager_0.networkAddress, 84);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1139f, 1245f, 1044f, 323f), "keys"))
			{
				this.method_1(text);
			}
			if (GUI.Button(new Rect(1741f, 1766f, 1271f, 1354f), "..."))
			{
				this.customNetworkDiscovery_0.method_5();
			}
		}
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x0008A4F0 File Offset: 0x000886F0
	private void method_12()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1491f, 1083f, 268f, 535f);
				object[] array = new object[]
				{
					"Main Menu"
				};
				array[0] = this.myNetManager_0.networkAddress;
				array[1] = "Song Options";
				array[4] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(477f, 290f, 367f, 1176f), "Easy" + (this.customNetworkDiscovery_0.running ? "Audio Backend" : "SORTING BY"));
			}
			else
			{
				Rect position2 = new Rect(1050f, 885f, 1841f, 1686f);
				object[] array2 = new object[]
				{
					"Press Escape to cancel",
					this.myNetManager_0.networkAddress,
					null,
					"x"
				};
				array2[0] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1662f, 1213f, 378f, 941f), ".wav"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(286f, 1244f, 1127f, 1393f), "Resolution"))
				{
					this.customNetworkDiscovery_0.method_20();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(691f, (float)(-126 + i * 71), 1288f, 606f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_39(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(922f, 1929f, 676f, 1563f), ""))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1808f, 1975f, 740f, 1561f), this.myNetManager_0.networkAddress, 103);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(0f, 196f, 1379f, 799f), "beatscore"))
			{
				this.method_53(text);
			}
			if (GUI.Button(new Rect(1732f, 736f, 606f, 1960f), "Guitar Coop"))
			{
				this.customNetworkDiscovery_0.method_8();
			}
		}
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_13()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x0008A7DC File Offset: 0x000889DC
	private void method_14(string string_0)
	{
		string networkAddress = string_0.Remove(0, string_0.LastIndexOf('m') + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x0008A814 File Offset: 0x00088A14
	private void method_15()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(592f, 188f, 1987f, 1379f);
				object[] array = new object[5];
				array[1] = "SORTING BY";
				array[0] = this.myNetManager_0.networkAddress;
				array[7] = "\"([^\"]*)\"";
				array[4] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(930f, 757f, 1935f, 1138f), "Difficulty = \\d+" + (this.customNetworkDiscovery_0.running ? "Volume" : "</color>"));
			}
			else
			{
				Rect position2 = new Rect(501f, 1475f, 1915f, 671f);
				object[] array2 = new object[6];
				array2[1] = "Songs";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[1] = "Rename Profile";
				array2[5] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1696f, 1993f, 1018f, 1134f), "Note Animation FPS"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1817f, 532f, 1238f, 1383f), "..."))
				{
					this.customNetworkDiscovery_0.method_22();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(372f, (float)(7 + i * -124), 1314f, 1602f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_56(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(915f, 216f, 1502f, 95f), "Calibration"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1546f, 982f, 963f, 1722f), this.myNetManager_0.networkAddress, 117);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(743f, 845f, 155f, 880f), "Solid Solo"))
			{
				this.method_17(text);
			}
			if (GUI.Button(new Rect(293f, 757f, 71f, 1911f), ")"))
			{
				this.customNetworkDiscovery_0.method_9();
			}
		}
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x0008AB00 File Offset: 0x00088D00
	private void method_16(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf((char)-61) + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x0008AB38 File Offset: 0x00088D38
	private void method_17(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf('\u001e') + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x0008AB70 File Offset: 0x00088D70
	private void method_18()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1042f, 327f, 1062f, 348f);
				object[] array = new object[6];
				array[1] = "allow_duplicate_songs";
				array[0] = this.myNetManager_0.networkAddress;
				array[6] = "game";
				array[3] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1687f, 226f, 530f, 1043f), "%" + (this.customNetworkDiscovery_0.running ? "diff_bassghl" : "game"));
			}
			else
			{
				Rect position2 = new Rect(490f, 780f, 960f, 1000f);
				object[] array2 = new object[0];
				array2[0] = "</color> ";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[6] = "-";
				array2[1] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(805f, 1386f, 887f, 1728f), "system_ram"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1707f, 1093f, 1543f, 570f), "Rhythm Guitar"))
				{
					this.customNetworkDiscovery_0.method_2();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(757f, (float)(3 + i * -17), 354f, 421f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_53(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1603f, 634f, 1681f, 789f), "Track Mute"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1059f, 689f, 279f, 986f), this.myNetManager_0.networkAddress, -123);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(308f, 582f, 1159f, 1505f), "part rhythm"))
			{
				this.method_1(text);
			}
			if (GUI.Button(new Rect(340f, 475f, 553f, 1018f), "PreviewStart = [\\-\\+]?\\d+(\\.\\d+)?"))
			{
				this.customNetworkDiscovery_0.method_13();
			}
		}
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x0008AE5C File Offset: 0x0008905C
	private void method_19(string string_0)
	{
		string networkAddress = string_0.Remove(0, string_0.LastIndexOf('\u0004') + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0008AE94 File Offset: 0x00089094
	private void method_20(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf('\\') + 0);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x0008AECC File Offset: 0x000890CC
	private void OnGUI()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				GUI.Label(new Rect(25f, 60f, 200f, 50f), string.Concat(new object[]
				{
					"Connecting to server...\nServer: ",
					this.myNetManager_0.networkAddress,
					":",
					this.myNetManager_0.networkPort
				}));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(25f, 60f, 200f, 50f), "Server\n" + (this.customNetworkDiscovery_0.running ? "Waiting for connection" : "Connected to client"));
			}
			else
			{
				GUI.Label(new Rect(25f, 60f, 200f, 50f), string.Concat(new object[]
				{
					"Client\nServer IP: ",
					this.myNetManager_0.networkAddress,
					":",
					this.myNetManager_0.networkPort
				}));
			}
			if (GUI.Button(new Rect(10f, 40f, 200f, 20f), "Disconnect"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(10f, 40f, 200f, 20f), "Cancel LAN Search"))
				{
					this.customNetworkDiscovery_0.method_21();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(10f, (float)(65 + i * 25), 200f, 20f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_38(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(10f, 40f, 200f, 20f), "Host"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(115f, 65f, 95f, 20f), this.myNetManager_0.networkAddress, 15);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(10f, 65f, 95f, 20f), "Connect to:"))
			{
				this.method_38(text);
			}
			if (GUI.Button(new Rect(10f, 90f, 200f, 20f), "Search LAN"))
			{
				this.customNetworkDiscovery_0.method_10();
			}
		}
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x0008B1B8 File Offset: 0x000893B8
	private void method_21()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(428f, 1672f, 270f, 438f);
				object[] array = new object[8];
				array[0] = "No";
				array[0] = this.myNetManager_0.networkAddress;
				array[4] = "%y";
				array[2] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1095f, 820f, 462f, 675f), "Menu Music" + (this.customNetworkDiscovery_0.running ? "Bot" : "-"));
			}
			else
			{
				Rect position2 = new Rect(175f, 1128f, 877f, 1838f);
				object[] array2 = new object[]
				{
					null,
					"directories"
				};
				array2[1] = this.myNetManager_0.networkAddress;
				array2[7] = "MSAA Level";
				array2[1] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(918f, 690f, 768f, 599f), "background"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(516f, 591f, 1891f, 16f), "<"))
				{
					this.customNetworkDiscovery_0.method_21();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1373f, (float)(-96 + i * -71), 1450f, 1376f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_53(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(959f, 1259f, 163f, 58f), "Flames"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(181f, 1030f, 1062f, 1083f), this.myNetManager_0.networkAddress, -53);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1098f, 671f, 87f, 411f), "%count%"))
			{
				this.method_26(text);
			}
			if (GUI.Button(new Rect(230f, 170f, 108f, 1819f), "0%"))
			{
				this.customNetworkDiscovery_0.method_17();
			}
		}
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x0008B4A4 File Offset: 0x000896A4
	private void method_22()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1408f, 595f, 700f, 82f);
				object[] array = new object[6];
				array[0] = "No";
				array[0] = this.myNetManager_0.networkAddress;
				array[0] = "Language";
				array[1] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1280f, 636f, 817f, 945f), "Errors" + (this.customNetworkDiscovery_0.running ? "" : "/Video Backgrounds"));
			}
			else
			{
				Rect position2 = new Rect(321f, 1932f, 1417f, 1526f);
				object[] array2 = new object[6];
				array2[1] = "Song Offset";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[4] = "Drums";
				array2[8] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(621f, 295f, 1295f, 877f), "vocals_1"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1449f, 1397f, 930f, 1594f), "game"))
				{
					this.customNetworkDiscovery_0.method_4();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(1431f, (float)(-102 + i * 56), 878f, 507f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_1(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1660f, 1841f, 211f, 93f), "\\s+"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(968f, 1008f, 75f, 577f), this.myNetManager_0.networkAddress, 112);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1069f, 1347f, 1089f, 1177f), ""))
			{
				this.method_14(text);
			}
			if (GUI.Button(new Rect(1572f, 1040f, 1461f, 660f), "Press Enter to confirm"))
			{
				this.customNetworkDiscovery_0.method_8();
			}
		}
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x0008B790 File Offset: 0x00089990
	private void method_23()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(635f, 740f, 943f, 570f);
				object[] array = new object[4];
				array[0] = "video";
				array[1] = this.myNetManager_0.networkAddress;
				array[5] = "Camera";
				array[7] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(141f, 437f, 1185f, 1965f), "song" + (this.customNetworkDiscovery_0.running ? "Unknown Genre" : "video"));
			}
			else
			{
				Rect position2 = new Rect(1495f, 644f, 727f, 1789f);
				object[] array2 = new object[3];
				array2[0] = "Quit";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[3] = "custom";
				array2[2] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(648f, 1680f, 92f, 314f), "No"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1590f, 472f, 280f, 1466f), "en-US"))
				{
					this.customNetworkDiscovery_0.method_12();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(457f, (float)(-39 + i * 40), 730f, 1402f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_55(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(847f, 1253f, 1823f, 810f), "SORTING BY"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1753f, 322f, 1684f, 854f), this.myNetManager_0.networkAddress, -20);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(51f, 289f, 3f, 1741f), "song"))
			{
				this.method_55(text);
			}
			if (GUI.Button(new Rect(1930f, 457f, 544f, 452f), "song"))
			{
				this.customNetworkDiscovery_0.method_13();
			}
		}
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_24()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x0008BA7C File Offset: 0x00089C7C
	private void method_25()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1230f, 1303f, 907f, 105f);
				object[] array = new object[5];
				array[1] = "^\\s*\\d+ = S 2 \\d+$";
				array[1] = this.myNetManager_0.networkAddress;
				array[5] = "Are you sure you want to practice?";
				array[8] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(18f, 1942f, 2f, 100f), "SECTION" + (this.customNetworkDiscovery_0.running ? "Audio Backend" : "GHLBass"));
			}
			else
			{
				Rect position2 = new Rect(1570f, 1982f, 232f, 1330f);
				object[] array2 = new object[4];
				array2[1] = "";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[2] = "Rename Profile";
				array2[2] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1862f, 696f, 1325f, 507f), "%>"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1848f, 1174f, 1469f, 1553f), ""))
				{
					this.customNetworkDiscovery_0.method_20();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(1058f, (float)(34 + i * -1), 889f, 1463f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_56(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1411f, 681f, 926f, 1880f), "ModChart Lite"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(740f, 322f, 674f, 1617f), this.myNetManager_0.networkAddress, 115);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(317f, 1321f, 730f, 156f), "volume"))
			{
				this.method_1(text);
			}
			if (GUI.Button(new Rect(893f, 600f, 1319f, 1950f), "Are you sure you want to quit?"))
			{
				this.customNetworkDiscovery_0.method_5();
			}
		}
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x0008BD68 File Offset: 0x00089F68
	private void method_26(string string_0)
	{
		string networkAddress = string_0.Remove(0, string_0.LastIndexOf('\f') + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x0600142A RID: 5162 RVA: 0x0008BDA0 File Offset: 0x00089FA0
	private void method_27()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(688f, 470f, 40f, 534f);
				object[] array = new object[8];
				array[1] = "song";
				array[0] = this.myNetManager_0.networkAddress;
				array[1] = "volume";
				array[2] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1175f, 1086f, 1130f, 1776f), "flames" + (this.customNetworkDiscovery_0.running ? "SECTION" : ": <color=#FDB400FF>"));
			}
			else
			{
				Rect position2 = new Rect(702f, 1937f, 1513f, 1743f);
				object[] array2 = new object[0];
				array2[1] = ")";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[1] = "[^\\u0020-\\u007E]";
				array2[8] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(834f, 298f, 606f, 1885f), ""))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1408f, 938f, 1241f, 327f), "}"))
				{
					this.customNetworkDiscovery_0.method_4();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(1746f, (float)(70 + i * 40), 534f, 1607f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_20(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1224f, 1476f, 1853f, 1383f), "%"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1787f, 1974f, 790f, 486f), this.myNetManager_0.networkAddress, -7);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(263f, 162f, 455f, 763f), "#"))
			{
				this.method_14(text);
			}
			if (GUI.Button(new Rect(618f, 674f, 1475f, 1960f), "star_deployed"))
			{
				this.customNetworkDiscovery_0.method_9();
			}
		}
	}

	// Token: 0x0600142B RID: 5163 RVA: 0x0008C08C File Offset: 0x0008A28C
	private void method_28()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(137f, 154f, 926f, 1305f);
				object[] array = new object[1];
				array[1] = "ui_rewind_highway_sound";
				array[0] = this.myNetManager_0.networkAddress;
				array[4] = "game";
				array[0] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(121f, 1991f, 1567f, 1857f), "star_deployed" + (this.customNetworkDiscovery_0.running ? "guitar" : "Scan Songs"));
			}
			else
			{
				Rect position2 = new Rect(1956f, 1003f, 1833f, 187f);
				object[] array2 = new object[8];
				array2[0] = "genre";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[6] = "Low Latency Mode";
				array2[0] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(667f, 1675f, 939f, 829f), "-"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1274f, 527f, 0f, 575f), "Master Volume"))
				{
					this.customNetworkDiscovery_0.method_20();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(303f, (float)(96 + i * -45), 1565f, 220f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_48(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(739f, 588f, 625f, 885f), "guitar"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(858f, 1993f, 1630f, 1677f), this.myNetManager_0.networkAddress, 121);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(205f, 68f, 1157f, 1526f), "Error: "))
			{
				this.method_26(text);
			}
			if (GUI.Button(new Rect(950f, 757f, 296f, 658f), "There are no saved setlists"))
			{
				this.customNetworkDiscovery_0.method_8();
			}
		}
	}

	// Token: 0x0600142C RID: 5164 RVA: 0x0008C378 File Offset: 0x0008A578
	private void method_29()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1180f, 772f, 1316f, 737f);
				object[] array = new object[]
				{
					"note_animation"
				};
				array[0] = this.myNetManager_0.networkAddress;
				array[3] = "Artist";
				array[3] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1997f, 568f, 425f, 1764f), "" + (this.customNetworkDiscovery_0.running ? "game" : "Camera"));
			}
			else
			{
				Rect position2 = new Rect(1388f, 738f, 1810f, 1293f);
				object[] array2 = new object[6];
				array2[0] = ")";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[2] = "No Part";
				array2[8] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(150f, 483f, 1739f, 1474f), "0"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1536f, 605f, 666f, 1471f), "Error writing metadata"))
				{
					this.customNetworkDiscovery_0.method_21();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(732f, (float)(112 + i * 37), 1074f, 1194f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_14(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(944f, 251f, 847f, 430f), "Default"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1171f, 1320f, 1718f, 10f), this.myNetManager_0.networkAddress, 113);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1285f, 410f, 1500f, 1673f), "[section "))
			{
				this.method_20(text);
			}
			if (GUI.Button(new Rect(1532f, 1049f, 575f, 1033f), "Menu Backgrounds"))
			{
				this.customNetworkDiscovery_0.method_17();
			}
		}
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x0008C664 File Offset: 0x0008A864
	private void method_30(string string_0)
	{
		string networkAddress = string_0.Remove(0, string_0.LastIndexOf((char)-91) + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x0008C69C File Offset: 0x0008A89C
	private void method_31(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf((char)-30) + 0);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x0008C6D4 File Offset: 0x0008A8D4
	private void method_32()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(448f, 1557f, 1779f, 1345f);
				object[] array = new object[8];
				array[1] = "Client connected";
				array[1] = this.myNetManager_0.networkAddress;
				array[1] = "Album";
				array[2] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(116f, 122f, 1849f, 1813f), "Guitar Coop" + (this.customNetworkDiscovery_0.running ? "%" : "song"));
			}
			else
			{
				Rect position2 = new Rect(904f, 968f, 609f, 499f);
				object[] array2 = new object[5];
				array2[0] = "Bass Guitar";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[6] = "MSAA Level";
				array2[1] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(233f, 1722f, 719f, 346f), "Song"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1391f, 1623f, 909f, 696f), "poll_rate"))
				{
					this.customNetworkDiscovery_0.method_15();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(1832f, (float)(115 + i * -122), 0f, 1261f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_14(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(796f, 310f, 690f, 1403f), "Unknown Album"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1556f, 1141f, 1051f, 1150f), this.myNetManager_0.networkAddress, 121);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(407f, 1489f, 623f, 1090f), ", Vel: "))
			{
				this.method_31(text);
			}
			if (GUI.Button(new Rect(227f, 1007f, 86f, 1826f), "Error while parsing \"{0}\": {1} "))
			{
				this.customNetworkDiscovery_0.method_5();
			}
		}
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x0008C9C0 File Offset: 0x0008ABC0
	private void method_33()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(186f, 295f, 876f, 1113f);
				object[] array = new object[7];
				array[1] = "%";
				array[0] = this.myNetManager_0.networkAddress;
				array[3] = "playlist_track";
				array[6] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1761f, 507f, 1222f, 1647f), "Resolution" + (this.customNetworkDiscovery_0.running ? "This is a placeholder" : "songcache.bin"));
			}
			else
			{
				Rect position2 = new Rect(1669f, 946f, 1824f, 83f);
				object[] array2 = new object[6];
				array2[1] = "<";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[4] = "%";
				array2[4] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1464f, 102f, 1171f, 152f), "Easy"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(93f, 1662f, 810f, 669f), "\0\0"))
				{
					this.customNetworkDiscovery_0.method_4();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1306f, (float)(124 + i * 126), 1613f, 593f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_39(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1824f, 1496f, 661f, 1889f), " + "))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(406f, 1586f, 1975f, 1847f), this.myNetManager_0.networkAddress, -115);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(922f, 1635f, 225f, 38f), "phrase_end"))
			{
				this.method_48(text);
			}
			if (GUI.Button(new Rect(1432f, 1386f, 1240f, 1671f), "song_display"))
			{
				this.customNetworkDiscovery_0.method_10();
			}
		}
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x0008CCAC File Offset: 0x0008AEAC
	private void method_34()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(238f, 81f, 1932f, 751f);
				object[] array = new object[8];
				array[0] = "custom";
				array[0] = this.myNetManager_0.networkAddress;
				array[8] = "Prefabs/Gameplay/Players/Guitar Player ";
				array[8] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1466f, 989f, 720f, 810f), "msaa" + (this.customNetworkDiscovery_0.running ? "378347429537251328" : "Portuguese"));
			}
			else
			{
				Rect position2 = new Rect(1405f, 402f, 201f, 490f);
				object[] array2 = new object[]
				{
					null,
					"Drop Out"
				};
				array2[0] = this.myNetManager_0.networkAddress;
				array2[1] = "Quit";
				array2[4] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1283f, 951f, 1327f, 1879f), "New Section"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(684f, 1848f, 743f, 811f), "preview_start_time"))
				{
					this.customNetworkDiscovery_0.method_15();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1680f, (float)(-59 + i * 94), 1676f, 206f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_16(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(390f, 79f, 1275f, 1363f), ""))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(531f, 555f, 323f, 1334f), this.myNetManager_0.networkAddress, 95);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1600f, 688f, 1820f, 1807f), "Not match flags previous {0} {1}"))
			{
				this.method_56(text);
			}
			if (GUI.Button(new Rect(1626f, 1234f, 538f, 1177f), "rhythm"))
			{
				this.customNetworkDiscovery_0.method_13();
			}
		}
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_35()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x0008CF98 File Offset: 0x0008B198
	private void method_36()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(258f, 1845f, 1362f, 1856f);
				object[] array = new object[0];
				array[1] = "diff_rhythm";
				array[0] = this.myNetManager_0.networkAddress;
				array[6] = "Hard";
				array[8] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1956f, 959f, 1055f, 123f), "" + (this.customNetworkDiscovery_0.running ? "Mute Track on Miss" : "artist"));
			}
			else
			{
				Rect position2 = new Rect(409f, 514f, 998f, 870f);
				object[] array2 = new object[]
				{
					"Date Added",
					this.myNetManager_0.networkAddress,
					null,
					null,
					null,
					null,
					null,
					"Mirror Mode"
				};
				array2[5] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(384f, 630f, 1019f, 284f), "N/A"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(759f, 1247f, 1413f, 13f), "\\d+ = E \"section [^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\""))
				{
					this.customNetworkDiscovery_0.method_15();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(23f, (float)(-91 + i * 12), 427f, 1074f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_38(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(280f, 1957f, 1687f, 1782f), "/"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(960f, 72f, 460f, 689f), this.myNetManager_0.networkAddress, 49);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(5f, 525f, 331f, 719f), "game"))
			{
				this.method_38(text);
			}
			if (GUI.Button(new Rect(919f, 828f, 994f, 1256f), "Note Speed"))
			{
				this.customNetworkDiscovery_0.method_9();
			}
		}
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_37()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x0008D284 File Offset: 0x0008B484
	private void method_38(string string_0)
	{
		string networkAddress = string_0.Remove(0, string_0.LastIndexOf(':') + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x0008D2BC File Offset: 0x0008B4BC
	private void method_39(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf((char)-14) + 0);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x0008D2F4 File Offset: 0x0008B4F4
	private void method_40()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1859f, 1794f, 776f, 132f);
				object[] array = new object[3];
				array[0] = "diff_guitarghl";
				array[1] = this.myNetManager_0.networkAddress;
				array[1] = "Get Hardware Latency";
				array[0] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1915f, 1859f, 874f, 1501f), "Gameplay" + (this.customNetworkDiscovery_0.running ? " (" : "Medium"));
			}
			else
			{
				Rect position2 = new Rect(1080f, 200f, 1709f, 570f);
				object[] array2 = new object[8];
				array2[1] = "sort_filter";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[8] = "Elapsed: ";
				array2[6] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(770f, 1741f, 1485f, 304f), "Sound Effects"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1917f, 53f, 1824f, 1114f), "Medium"))
				{
					this.customNetworkDiscovery_0.method_21();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(803f, (float)(18 + i * -22), 1573f, 1596f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_56(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(926f, 460f, 724f, 1409f), ""))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(81f, 1503f, 148f, 73f), this.myNetManager_0.networkAddress, 36);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1f, 1489f, 1815f, 1479f), "volume"))
			{
				this.method_19(text);
			}
			if (GUI.Button(new Rect(316f, 413f, 1549f, 1064f), "bassinitfail"))
			{
				this.customNetworkDiscovery_0.method_10();
			}
		}
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_41()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x0008D5E0 File Offset: 0x0008B7E0
	private void method_42()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1914f, 117f, 605f, 704f);
				object[] array = new object[8];
				array[0] = "Good Solo";
				array[1] = this.myNetManager_0.networkAddress;
				array[3] = "Are you sure you want to quit?";
				array[0] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1539f, 58f, 1471f, 139f), "%points%" + (this.customNetworkDiscovery_0.running ? "Audio Offset" : " ("));
			}
			else
			{
				Rect position2 = new Rect(447f, 36f, 170f, 1120f);
				object[] array2 = new object[8];
				array2[1] = "song_display";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[5] = "playlist_track";
				array2[0] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(297f, 1961f, 1402f, 1539f), "All Opens"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1000f, 99f, 896f, 1391f), "Resolution"))
				{
					this.customNetworkDiscovery_0.method_15();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(1561f, (float)(110 + i * -18), 1282f, 613f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_56(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(97f, 1409f, 1281f, 861f), "Charter"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1259f, 1464f, 26f, 1625f), this.myNetManager_0.networkAddress, -27);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(221f, 817f, 311f, 607f), "song"))
			{
				this.method_31(text);
			}
			if (GUI.Button(new Rect(1760f, 1024f, 563f, 676f), "6 Fret Bass Guitar"))
			{
				this.customNetworkDiscovery_0.method_9();
			}
		}
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_43()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_44()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_45()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_46()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x0600143F RID: 5183 RVA: 0x0008D8CC File Offset: 0x0008BACC
	private void method_47()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(336f, 1002f, 160f, 1296f);
				object[] array = new object[7];
				array[0] = "Quit";
				array[1] = this.myNetManager_0.networkAddress;
				array[8] = "There was an error deleting the file";
				array[2] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1967f, 400f, 1672f, 91f), "" + (this.customNetworkDiscovery_0.running ? "Are you sure you want to delete this song?" : "video"));
			}
			else
			{
				Rect position2 = new Rect(1055f, 1167f, 671f, 298f);
				object[] array2 = new object[5];
				array2[0] = "Lights Out";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[0] = "Main Menu";
				array2[2] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1385f, 1040f, 906f, 1100f), " + "))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1144f, 687f, 1033f, 1028f), "Controller"))
				{
					this.customNetworkDiscovery_0.method_20();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(1610f, (float)(-28 + i * 4), 956f, 189f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_30(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(300f, 993f, 1800f, 1740f), "No"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1051f, 1982f, 355f, 1111f), this.myNetManager_0.networkAddress, -124);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1890f, 1551f, 1902f, 1000f), "GHLGuitar"))
			{
				this.method_31(text);
			}
			if (GUI.Button(new Rect(1890f, 1130f, 538f, 56f), "song"))
			{
				this.customNetworkDiscovery_0.method_11();
			}
		}
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x0008DBB8 File Offset: 0x0008BDB8
	private void method_48(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf('7') + 0);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x0008DBF0 File Offset: 0x0008BDF0
	private void method_49()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1448f, 1801f, 1737f, 1841f);
				object[] array = new object[6];
				array[1] = "notes.chart";
				array[0] = this.myNetManager_0.networkAddress;
				array[1] = ".chart";
				array[7] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1113f, 410f, 1577f, 1967f), "Unknown Charter" + (this.customNetworkDiscovery_0.running ? "Songs are still scanning..." : "song"));
			}
			else
			{
				Rect position2 = new Rect(1228f, 1431f, 625f, 300f);
				object[] array2 = new object[6];
				array2[0] = "No songs were found!";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[2] = "6 Fret Lead Guitar";
				array2[3] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1131f, 984f, 1089f, 764f), "Set B Position"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1718f, 173f, 919f, 1590f), "Build: "))
				{
					this.customNetworkDiscovery_0.method_4();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(1670f, (float)(-19 + i * 125), 614f, 68f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_38(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(861f, 1776f, 1847f, 601f), "Yes"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(192f, 8f, 564f, 918f), this.myNetManager_0.networkAddress, 18);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(380f, 1632f, 1273f, 786f), "%"))
			{
				this.method_53(text);
			}
			if (GUI.Button(new Rect(226f, 1498f, 1210f, 873f), "isSupported"))
			{
				this.customNetworkDiscovery_0.method_10();
			}
		}
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x0000AE05 File Offset: 0x00009005
	private void method_50()
	{
		this.myNetManager_0 = base.GetComponent<MyNetManager>();
		this.customNetworkDiscovery_0 = base.GetComponent<CustomNetworkDiscovery>();
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x0008DEDC File Offset: 0x0008C0DC
	private void method_51()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1259f, 155f, 419f, 177f);
				object[] array = new object[]
				{
					null,
					"Okay"
				};
				array[0] = this.myNetManager_0.networkAddress;
				array[1] = ", Vel: ";
				array[4] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(745f, 269f, 1106f, 797f), "Album" + (this.customNetworkDiscovery_0.running ? "Error while parsing \"{0}\": {1} " : "Save Setlist"));
			}
			else
			{
				Rect position2 = new Rect(1035f, 1719f, 1657f, 500f);
				object[] array2 = new object[4];
				array2[0] = "%s%n%a%n%c";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[2] = "game";
				array2[6] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1733f, 810f, 1863f, 798f), "SORTING BY"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(778f, 1735f, 1132f, 1724f), "Continue"))
				{
					this.customNetworkDiscovery_0.method_12();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i += 0)
				{
					if (GUI.Button(new Rect(912f, (float)(-90 + i * -116), 66f, 789f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_20(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(750f, 1421f, 606f, 919f), "botnosave"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(319f, 1082f, 1837f, 226f), this.myNetManager_0.networkAddress, -31);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1255f, 1943f, 1829f, 1165f), "Guitar Coop"))
			{
				this.method_38(text);
			}
			if (GUI.Button(new Rect(580f, 1492f, 709f, 1179f), "Rhythm"))
			{
				this.customNetworkDiscovery_0.method_3();
			}
		}
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x0008E1C8 File Offset: 0x0008C3C8
	private void method_52()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(1792f, 6f, 1934f, 1998f);
				object[] array = new object[1];
				array[1] = "-";
				array[1] = this.myNetManager_0.networkAddress;
				array[1] = "Keys - ";
				array[6] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(1232f, 1312f, 418f, 1756f), "Full Song" + (this.customNetworkDiscovery_0.running ? " " : "song"));
			}
			else
			{
				Rect position2 = new Rect(256f, 1971f, 1302f, 1600f);
				object[] array2 = new object[5];
				array2[0] = "Note Shuffle";
				array2[0] = this.myNetManager_0.networkAddress;
				array2[0] = "None";
				array2[2] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1362f, 1688f, 994f, 258f), "^\\s*\\d+ = N \\d \\d+$"))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(1527f, 1711f, 76f, 1889f), "Show Bot Score"))
				{
					this.customNetworkDiscovery_0.method_2();
				}
				for (int i = 0; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(192f, (float)(122 + i * 91), 1684f, 1551f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_39(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(1720f, 613f, 765f, 365f), " ("))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(1839f, 1180f, 688f, 42f), this.myNetManager_0.networkAddress, -104);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(807f, 1107f, 1279f, 372f), "Genre"))
			{
				this.method_16(text);
			}
			if (GUI.Button(new Rect(1902f, 1234f, 919f, 159f), "%s"))
			{
				this.customNetworkDiscovery_0.method_18();
			}
		}
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x0008E4B4 File Offset: 0x0008C6B4
	private void method_53(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf('K') + 0);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x0008E4EC File Offset: 0x0008C6EC
	private void method_54()
	{
		if (!this.bool_1)
		{
			return;
		}
		if (this.myNetManager_0.isNetworkActive)
		{
			if (!this.myNetManager_0.IsClientConnected())
			{
				Rect position = new Rect(83f, 1186f, 1855f, 7f);
				object[] array = new object[8];
				array[1] = "Practice";
				array[1] = this.myNetManager_0.networkAddress;
				array[5] = "particles";
				array[0] = this.myNetManager_0.networkPort;
				GUI.Label(position, string.Concat(array));
			}
			else if (NetworkServer.active)
			{
				GUI.Label(new Rect(484f, 494f, 852f, 188f), "GHLGuitar" + (this.customNetworkDiscovery_0.running ? "song" : "%n"));
			}
			else
			{
				Rect position2 = new Rect(1536f, 1441f, 1926f, 1492f);
				object[] array2 = new object[5];
				array2[1] = "backend";
				array2[1] = this.myNetManager_0.networkAddress;
				array2[5] = "beatscore";
				array2[1] = this.myNetManager_0.networkPort;
				GUI.Label(position2, string.Concat(array2));
			}
			if (GUI.Button(new Rect(1631f, 1513f, 1698f, 664f), "="))
			{
				if (NetworkServer.active)
				{
					this.myNetManager_0.StopHost();
					return;
				}
				this.myNetManager_0.StopClient();
				return;
			}
		}
		else
		{
			if (this.customNetworkDiscovery_0.running)
			{
				if (GUI.Button(new Rect(79f, 871f, 1162f, 174f), "{0} {1}"))
				{
					this.customNetworkDiscovery_0.method_21();
				}
				for (int i = 1; i < this.customNetworkDiscovery_0.list_0.Count; i++)
				{
					if (GUI.Button(new Rect(463f, (float)(25 + i * 124), 448f, 1931f), this.customNetworkDiscovery_0.list_0[i]))
					{
						this.method_17(this.customNetworkDiscovery_0.list_0[i]);
					}
				}
				return;
			}
			if (GUI.Button(new Rect(717f, 1378f, 1982f, 208f), "-"))
			{
				this.myNetManager_0.StartHost();
			}
			string text = GUI.TextField(new Rect(124f, 960f, 853f, 20f), this.myNetManager_0.networkAddress, -53);
			this.myNetManager_0.networkAddress = text;
			if (GUI.Button(new Rect(1966f, 1925f, 1512f, 676f), "Gameplay"))
			{
				this.method_30(text);
			}
			if (GUI.Button(new Rect(534f, 1049f, 1491f, 709f), "volume"))
			{
				this.customNetworkDiscovery_0.method_8();
			}
		}
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x0008E7D8 File Offset: 0x0008C9D8
	private void method_55(string string_0)
	{
		string networkAddress = string_0.Remove(0, string_0.LastIndexOf((char)-113) + 1);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x0008E810 File Offset: 0x0008CA10
	private void method_56(string string_0)
	{
		string networkAddress = string_0.Remove(1, string_0.LastIndexOf('r') + 0);
		this.myNetManager_0.networkAddress = networkAddress;
		this.myNetManager_0.StartClient();
	}

	// Token: 0x040002C9 RID: 713
	private MyNetManager myNetManager_0;

	// Token: 0x040002CA RID: 714
	private CustomNetworkDiscovery customNetworkDiscovery_0;

	// Token: 0x040002CB RID: 715
	[HideInInspector]
	public bool bool_0;

	// Token: 0x040002CC RID: 716
	public bool bool_1 = true;
}
