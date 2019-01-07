using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	// Token: 0x020000ED RID: 237
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x00012470 File Offset: 0x00010670
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x00012478 File Offset: 0x00010678
		public bool IsEnabled
		{
			get
			{
				return this.isEnabled;
			}
			set
			{
				this.isEnabled = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x00012481 File Offset: 0x00010681
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x00012489 File Offset: 0x00010689
		public bool LoadDataOnStart
		{
			get
			{
				return this.loadDataOnStart;
			}
			set
			{
				this.loadDataOnStart = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x00012492 File Offset: 0x00010692
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x0001249A File Offset: 0x0001069A
		public bool LoadJoystickAssignments
		{
			get
			{
				return this.loadJoystickAssignments;
			}
			set
			{
				this.loadJoystickAssignments = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x000124A3 File Offset: 0x000106A3
		// (set) Token: 0x06002CB9 RID: 11449 RVA: 0x000124AB File Offset: 0x000106AB
		public bool LoadKeyboardAssignments
		{
			get
			{
				return this.loadKeyboardAssignments;
			}
			set
			{
				this.loadKeyboardAssignments = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06002CBA RID: 11450 RVA: 0x000124B4 File Offset: 0x000106B4
		// (set) Token: 0x06002CBB RID: 11451 RVA: 0x000124BC File Offset: 0x000106BC
		public bool LoadMouseAssignments
		{
			get
			{
				return this.loadMouseAssignments;
			}
			set
			{
				this.loadMouseAssignments = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000124C5 File Offset: 0x000106C5
		// (set) Token: 0x06002CBD RID: 11453 RVA: 0x000124CD File Offset: 0x000106CD
		public string PlayerPrefsKeyPrefix
		{
			get
			{
				return this.playerPrefsKeyPrefix;
			}
			set
			{
				this.playerPrefsKeyPrefix = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x000124D6 File Offset: 0x000106D6
		private string playerPrefsKey_controllerAssignments
		{
			get
			{
				return string.Format("{0}_{1}", this.playerPrefsKeyPrefix, "ControllerAssignments");
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000124ED File Offset: 0x000106ED
		private bool loadControllerAssignments
		{
			get
			{
				return this.loadKeyboardAssignments || this.loadMouseAssignments || this.loadJoystickAssignments;
			}
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x00012507 File Offset: 0x00010707
		public override void Save()
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveAll();
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x00012523 File Offset: 0x00010723
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveControllerDataNow(playerId, controllerType, controllerId);
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00012542 File Offset: 0x00010742
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveControllerDataNow(controllerType, controllerId);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x00012560 File Offset: 0x00010760
		public override void SavePlayerData(int playerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SavePlayerDataNow(playerId);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0001257D File Offset: 0x0001077D
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveInputBehaviorNow(playerId, behaviorId);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0001259B File Offset: 0x0001079B
		public override void Load()
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadAll();
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000125B8 File Offset: 0x000107B8
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadControllerDataNow(playerId, controllerType, controllerId);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000125D8 File Offset: 0x000107D8
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadControllerDataNow(controllerType, controllerId);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000125F7 File Offset: 0x000107F7
		public override void LoadPlayerData(int playerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadPlayerDataNow(playerId);
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00012615 File Offset: 0x00010815
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadInputBehaviorNow(playerId, behaviorId);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00012634 File Offset: 0x00010834
		protected override void OnInitialize()
		{
			if (this.loadDataOnStart)
			{
				this.Load();
				if (this.loadControllerAssignments && ReInput.controllers.joystickCount > 0)
				{
					this.SaveControllerAssignments();
				}
			}
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00138C7C File Offset: 0x00136E7C
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.LoadJoystickData(args.controllerId);
				if (this.loadDataOnStart && this.loadJoystickAssignments && !this.wasJoystickEverDetected)
				{
					base.StartCoroutine(this.LoadJoystickAssignmentsDeferred());
				}
				if (this.loadJoystickAssignments && !this.deferredJoystickAssignmentLoadPending)
				{
					this.SaveControllerAssignments();
				}
				this.wasJoystickEverDetected = true;
			}
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00012660 File Offset: 0x00010860
		protected override void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.SaveJoystickData(args.controllerId);
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00012680 File Offset: 0x00010880
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (this.loadControllerAssignments)
			{
				this.SaveControllerAssignments();
			}
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x00138CEC File Offset: 0x00136EEC
		private int LoadAll()
		{
			int num = 0;
			if (this.loadControllerAssignments && this.LoadControllerAssignmentsNow())
			{
				num++;
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				num += this.LoadPlayerDataNow(allPlayers[i]);
			}
			return num + this.LoadAllJoystickCalibrationData();
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0001269A File Offset: 0x0001089A
		private int LoadPlayerDataNow(int playerId)
		{
			return this.LoadPlayerDataNow(ReInput.players.GetPlayer(playerId));
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x00138D48 File Offset: 0x00136F48
		private int LoadPlayerDataNow(Player player)
		{
			if (player == null)
			{
				return 0;
			}
			int num = 0;
			num = 0 + this.LoadInputBehaviors(player.id);
			num += this.LoadControllerMaps(player.id, ControllerType.Keyboard, 0);
			num += this.LoadControllerMaps(player.id, ControllerType.Mouse, 0);
			foreach (Joystick joystick in player.controllers.Joysticks)
			{
				num += this.LoadControllerMaps(player.id, ControllerType.Joystick, joystick.id);
			}
			return num;
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00138DE4 File Offset: 0x00136FE4
		private int LoadAllJoystickCalibrationData()
		{
			int num = 0;
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				num += this.LoadJoystickCalibrationData(joysticks[i]);
			}
			return num;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000126AD File Offset: 0x000108AD
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			if (joystick == null)
			{
				return 0;
			}
			if (!joystick.ImportCalibrationMapFromXmlString(this.GetJoystickCalibrationMapXml(joystick)))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000126C6 File Offset: 0x000108C6
		private int LoadJoystickCalibrationData(int joystickId)
		{
			return this.LoadJoystickCalibrationData(ReInput.controllers.GetJoystick(joystickId));
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x00138E20 File Offset: 0x00137020
		private int LoadJoystickData(int joystickId)
		{
			int num = 0;
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, joystickId))
				{
					num += this.LoadControllerMaps(player.id, ControllerType.Joystick, joystickId);
				}
			}
			return num + this.LoadJoystickCalibrationData(joystickId);
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000126D9 File Offset: 0x000108D9
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return 0 + this.LoadControllerMaps(playerId, controllerType, controllerId) + this.LoadControllerDataNow(controllerType, controllerId);
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00138E80 File Offset: 0x00137080
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			int num = 0;
			if (controllerType == ControllerType.Joystick)
			{
				num += this.LoadJoystickCalibrationData(controllerId);
			}
			return num;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00138EA0 File Offset: 0x001370A0
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return num;
			}
			Controller controller = ReInput.controllers.GetController(controllerType, controllerId);
			if (controller == null)
			{
				return num;
			}
			List<UserDataStore_PlayerPrefs.SavedControllerMapData> allControllerMapsXml = this.GetAllControllerMapsXml(player, true, controller);
			if (allControllerMapsXml.Count == 0)
			{
				return num;
			}
			num += player.controllers.maps.AddMapsFromXml(controllerType, controllerId, UserDataStore_PlayerPrefs.SavedControllerMapData.GetXmlStringList(allControllerMapsXml));
			this.AddDefaultMappingsForNewActions(player, allControllerMapsXml, controllerType, controllerId);
			return num;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00138F0C File Offset: 0x0013710C
		private int LoadInputBehaviors(int playerId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return 0;
			}
			int num = 0;
			IList<InputBehavior> inputBehaviors = ReInput.mapping.GetInputBehaviors(player.id);
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				num += this.LoadInputBehaviorNow(player, inputBehaviors[i]);
			}
			return num;
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00138F60 File Offset: 0x00137160
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return 0;
			}
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
			if (inputBehavior == null)
			{
				return 0;
			}
			return this.LoadInputBehaviorNow(player, inputBehavior);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00138F98 File Offset: 0x00137198
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			if (player == null || inputBehavior == null)
			{
				return 0;
			}
			string inputBehaviorXml = this.GetInputBehaviorXml(player, inputBehavior.id);
			if (inputBehaviorXml == null || inputBehaviorXml == string.Empty)
			{
				return 0;
			}
			if (!inputBehavior.ImportXmlString(inputBehaviorXml))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00138FDC File Offset: 0x001371DC
		private bool LoadControllerAssignmentsNow()
		{
			try
			{
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = this.LoadControllerAssignmentData();
				if (controllerAssignmentSaveInfo == null)
				{
					return false;
				}
				if (this.loadKeyboardAssignments || this.loadMouseAssignments)
				{
					this.LoadKeyboardAndMouseAssignmentsNow(controllerAssignmentSaveInfo);
				}
				if (this.loadJoystickAssignments)
				{
					this.LoadJoystickAssignmentsNow(controllerAssignmentSaveInfo);
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00139038 File Offset: 0x00137238
		private bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			try
			{
				if (data == null && (data = this.LoadControllerAssignmentData()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					if (data.ContainsPlayer(player.id))
					{
						UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo = data.players[data.IndexOfPlayer(player.id)];
						if (this.loadKeyboardAssignments)
						{
							player.controllers.hasKeyboard = playerInfo.hasKeyboard;
						}
						if (this.loadMouseAssignments)
						{
							player.controllers.hasMouse = playerInfo.hasMouse;
						}
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00139100 File Offset: 0x00137300
		private bool LoadJoystickAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			try
			{
				if (ReInput.controllers.joystickCount == 0)
				{
					return false;
				}
				if (data == null && (data = this.LoadControllerAssignmentData()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					player.controllers.ClearControllersOfType(ControllerType.Joystick);
				}
				List<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo> list = this.loadJoystickAssignments ? new List<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>() : null;
				foreach (Player player2 in ReInput.players.AllPlayers)
				{
					if (data.ContainsPlayer(player2.id))
					{
						UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo = data.players[data.IndexOfPlayer(player2.id)];
						for (int i = 0; i < playerInfo.joystickCount; i++)
						{
							UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo2 = playerInfo.joysticks[i];
							if (joystickInfo2 != null)
							{
								Joystick joystick = this.FindJoystickPrecise(joystickInfo2);
								if (joystick != null)
								{
									if (list.Find((UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) => x.joystick == joystick) == null)
									{
										list.Add(new UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo(joystick, joystickInfo2.id));
									}
									player2.controllers.AddController(joystick, false);
								}
							}
						}
					}
				}
				if (this.allowImpreciseJoystickAssignmentMatching)
				{
					foreach (Player player3 in ReInput.players.AllPlayers)
					{
						if (data.ContainsPlayer(player3.id))
						{
							UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo2 = data.players[data.IndexOfPlayer(player3.id)];
							for (int j = 0; j < playerInfo2.joystickCount; j++)
							{
								UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo = playerInfo2.joysticks[j];
								if (joystickInfo != null)
								{
									Joystick joystick2 = null;
									int num = list.FindIndex((UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) => x.oldJoystickId == joystickInfo.id);
									if (num >= 0)
									{
										joystick2 = list[num].joystick;
									}
									else
									{
										List<Joystick> list2;
										if (!this.TryFindJoysticksImprecise(joystickInfo, out list2))
										{
											goto IL_29C;
										}
										using (List<Joystick>.Enumerator enumerator2 = list2.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												Joystick match = enumerator2.Current;
												if (list.Find((UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) => x.joystick == match) == null)
												{
													joystick2 = match;
													break;
												}
											}
										}
										if (joystick2 == null)
										{
											goto IL_29C;
										}
										list.Add(new UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo(joystick2, joystickInfo.id));
									}
									player3.controllers.AddController(joystick2, false);
								}
								IL_29C:;
							}
						}
					}
				}
			}
			catch
			{
			}
			if (ReInput.configuration.autoAssignJoysticks)
			{
				ReInput.controllers.AutoAssignJoysticks();
			}
			return true;
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00139470 File Offset: 0x00137670
		private UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo result;
			try
			{
				if (!PlayerPrefs.HasKey(this.playerPrefsKey_controllerAssignments))
				{
					result = null;
				}
				else
				{
					string @string = PlayerPrefs.GetString(this.playerPrefsKey_controllerAssignments);
					if (string.IsNullOrEmpty(@string))
					{
						result = null;
					}
					else
					{
						UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = JsonParser.FromJson<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>(@string);
						if (controllerAssignmentSaveInfo != null && controllerAssignmentSaveInfo.playerCount != 0)
						{
							result = controllerAssignmentSaveInfo;
						}
						else
						{
							result = null;
						}
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000126EF File Offset: 0x000108EF
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			UserDataStore_PlayerPrefs.<LoadJoystickAssignmentsDeferred>d__65 <LoadJoystickAssignmentsDeferred>d__ = new UserDataStore_PlayerPrefs.<LoadJoystickAssignmentsDeferred>d__65(0);
			<LoadJoystickAssignmentsDeferred>d__.<>4__this = this;
			return <LoadJoystickAssignmentsDeferred>d__;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x001394D8 File Offset: 0x001376D8
		private void SaveAll()
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				this.SavePlayerDataNow(allPlayers[i]);
			}
			this.SaveAllJoystickCalibrationData();
			if (this.loadControllerAssignments)
			{
				this.SaveControllerAssignments();
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000126FE File Offset: 0x000108FE
		private void SavePlayerDataNow(int playerId)
		{
			this.SavePlayerDataNow(ReInput.players.GetPlayer(playerId));
			PlayerPrefs.Save();
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00139528 File Offset: 0x00137728
		private void SavePlayerDataNow(Player player)
		{
			if (player == null)
			{
				return;
			}
			PlayerSaveData saveData = player.GetSaveData(true);
			this.SaveInputBehaviors(player, saveData);
			this.SaveControllerMaps(player, saveData);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00139554 File Offset: 0x00137754
		private void SaveAllJoystickCalibrationData()
		{
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				this.SaveJoystickCalibrationData(joysticks[i]);
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00012716 File Offset: 0x00010916
		private void SaveJoystickCalibrationData(int joystickId)
		{
			this.SaveJoystickCalibrationData(ReInput.controllers.GetJoystick(joystickId));
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x0013958C File Offset: 0x0013778C
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
			if (joystick == null)
			{
				return;
			}
			JoystickCalibrationMapSaveData calibrationMapSaveData = joystick.GetCalibrationMapSaveData();
			PlayerPrefs.SetString(this.GetJoystickCalibrationMapPlayerPrefsKey(joystick), calibrationMapSaveData.map.ToXmlString());
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x001395BC File Offset: 0x001377BC
		private void SaveJoystickData(int joystickId)
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, joystickId))
				{
					this.SaveControllerMaps(player.id, ControllerType.Joystick, joystickId);
				}
			}
			this.SaveJoystickCalibrationData(joystickId);
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00012729 File Offset: 0x00010929
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			this.SaveControllerMaps(playerId, controllerType, controllerId);
			this.SaveControllerDataNow(controllerType, controllerId);
			PlayerPrefs.Save();
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00012741 File Offset: 0x00010941
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
			if (controllerType == ControllerType.Joystick)
			{
				this.SaveJoystickCalibrationData(controllerId);
			}
			PlayerPrefs.Save();
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00139614 File Offset: 0x00137814
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
			foreach (ControllerMapSaveData saveData in playerSaveData.AllControllerMapSaveData)
			{
				this.SaveControllerMap(player, saveData);
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00139664 File Offset: 0x00137864
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			if (!player.controllers.ContainsController(controllerType, controllerId))
			{
				return;
			}
			ControllerMapSaveData[] mapSaveData = player.controllers.maps.GetMapSaveData(controllerType, controllerId, true);
			if (mapSaveData == null)
			{
				return;
			}
			for (int i = 0; i < mapSaveData.Length; i++)
			{
				this.SaveControllerMap(player, mapSaveData[i]);
			}
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x001396C4 File Offset: 0x001378C4
		private void SaveControllerMap(Player player, ControllerMapSaveData saveData)
		{
			PlayerPrefs.SetString(this.GetControllerMapPlayerPrefsKey(player, saveData.controller, saveData.categoryId, saveData.layoutId, true), saveData.map.ToXmlString());
			PlayerPrefs.SetString(this.GetControllerMapKnownActionIdsPlayerPrefsKey(player, saveData.controller, saveData.categoryId, saveData.layoutId, true), this.GetAllActionIdsString());
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00139720 File Offset: 0x00137920
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
			if (player == null)
			{
				return;
			}
			InputBehavior[] inputBehaviors = playerSaveData.inputBehaviors;
			for (int i = 0; i < inputBehaviors.Length; i++)
			{
				this.SaveInputBehaviorNow(player, inputBehaviors[i]);
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00139754 File Offset: 0x00137954
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
			if (inputBehavior == null)
			{
				return;
			}
			this.SaveInputBehaviorNow(player, inputBehavior);
			PlayerPrefs.Save();
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00012753 File Offset: 0x00010953
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			if (player != null && inputBehavior != null)
			{
				PlayerPrefs.SetString(this.GetInputBehaviorPlayerPrefsKey(player, inputBehavior.id), inputBehavior.ToXmlString());
				return;
			}
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00139790 File Offset: 0x00137990
		private bool SaveControllerAssignments()
		{
			try
			{
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo(ReInput.players.allPlayerCount);
				for (int i = 0; i < ReInput.players.allPlayerCount; i++)
				{
					Player player = ReInput.players.AllPlayers[i];
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo();
					controllerAssignmentSaveInfo.players[i] = playerInfo;
					playerInfo.id = player.id;
					playerInfo.hasKeyboard = player.controllers.hasKeyboard;
					playerInfo.hasMouse = player.controllers.hasMouse;
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] array = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[player.controllers.joystickCount];
					playerInfo.joysticks = array;
					for (int j = 0; j < player.controllers.joystickCount; j++)
					{
						Joystick joystick = player.controllers.Joysticks[j];
						array[j] = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo
						{
							instanceGuid = joystick.deviceInstanceGuid,
							id = joystick.id,
							hardwareIdentifier = joystick.hardwareIdentifier
						};
					}
				}
				PlayerPrefs.SetString(this.playerPrefsKey_controllerAssignments, JsonWriter.ToJson(controllerAssignmentSaveInfo));
				PlayerPrefs.Save();
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00012774 File Offset: 0x00010974
		private bool ControllerAssignmentSaveDataExists()
		{
			return PlayerPrefs.HasKey(this.playerPrefsKey_controllerAssignments) && !string.IsNullOrEmpty(PlayerPrefs.GetString(this.playerPrefsKey_controllerAssignments));
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0001279A File Offset: 0x0001099A
		private string GetBasePlayerPrefsKey(Player player)
		{
			return this.playerPrefsKeyPrefix + "|playerName=" + player.name;
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x001398D0 File Offset: 0x00137AD0
		private string GetControllerMapPlayerPrefsKey(Player player, Controller controller, int categoryId, int layoutId, bool includeDuplicateIndex)
		{
			string text = this.GetBasePlayerPrefsKey(player);
			text += "|dataType=ControllerMap";
			text = text + "|controllerMapType=" + controller.mapTypeString;
			text = string.Concat(new object[]
			{
				text,
				"|categoryId=",
				categoryId,
				"|layoutId=",
				layoutId
			});
			text = text + "|hardwareIdentifier=" + controller.hardwareIdentifier;
			if (controller.type == ControllerType.Joystick)
			{
				text = text + "|hardwareGuid=" + ((Joystick)controller).hardwareTypeGuid.ToString();
				if (includeDuplicateIndex)
				{
					text = text + "|duplicate=" + UserDataStore_PlayerPrefs.GetDuplicateIndex(player, controller).ToString();
				}
			}
			return text;
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x00139998 File Offset: 0x00137B98
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, Controller controller, int categoryId, int layoutId, bool includeDuplicateIndex)
		{
			string text = this.GetBasePlayerPrefsKey(player);
			text += "|dataType=ControllerMap_KnownActionIds";
			text = text + "|controllerMapType=" + controller.mapTypeString;
			text = string.Concat(new object[]
			{
				text,
				"|categoryId=",
				categoryId,
				"|layoutId=",
				layoutId
			});
			text = text + "|hardwareIdentifier=" + controller.hardwareIdentifier;
			if (controller.type == ControllerType.Joystick)
			{
				text = text + "|hardwareGuid=" + ((Joystick)controller).hardwareTypeGuid.ToString();
				if (includeDuplicateIndex)
				{
					text = text + "|duplicate=" + UserDataStore_PlayerPrefs.GetDuplicateIndex(player, controller).ToString();
				}
			}
			return text;
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00139A60 File Offset: 0x00137C60
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return this.playerPrefsKeyPrefix + "|dataType=CalibrationMap" + "|controllerType=" + joystick.type.ToString() + "|hardwareIdentifier=" + joystick.hardwareIdentifier + "|hardwareGuid=" + joystick.hardwareTypeGuid.ToString();
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000127B2 File Offset: 0x000109B2
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return this.GetBasePlayerPrefsKey(player) + "|dataType=InputBehavior" + "|id=" + inputBehaviorId;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00139ACC File Offset: 0x00137CCC
		private string GetControllerMapXml(Player player, Controller controller, int categoryId, int layoutId)
		{
			string controllerMapPlayerPrefsKey = this.GetControllerMapPlayerPrefsKey(player, controller, categoryId, layoutId, true);
			if (!PlayerPrefs.HasKey(controllerMapPlayerPrefsKey))
			{
				if (controller.type != ControllerType.Joystick)
				{
					return string.Empty;
				}
				controllerMapPlayerPrefsKey = this.GetControllerMapPlayerPrefsKey(player, controller, categoryId, layoutId, false);
				if (!PlayerPrefs.HasKey(controllerMapPlayerPrefsKey))
				{
					return string.Empty;
				}
			}
			return PlayerPrefs.GetString(controllerMapPlayerPrefsKey);
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00139B20 File Offset: 0x00137D20
		private List<int> GetControllerMapKnownActionIds(Player player, Controller controller, int categoryId, int layoutId)
		{
			List<int> list = new List<int>();
			string controllerMapKnownActionIdsPlayerPrefsKey = this.GetControllerMapKnownActionIdsPlayerPrefsKey(player, controller, categoryId, layoutId, true);
			if (!PlayerPrefs.HasKey(controllerMapKnownActionIdsPlayerPrefsKey))
			{
				if (controller.type != ControllerType.Joystick)
				{
					return list;
				}
				controllerMapKnownActionIdsPlayerPrefsKey = this.GetControllerMapKnownActionIdsPlayerPrefsKey(player, controller, categoryId, layoutId, false);
				if (!PlayerPrefs.HasKey(controllerMapKnownActionIdsPlayerPrefsKey))
				{
					return list;
				}
			}
			string @string = PlayerPrefs.GetString(controllerMapKnownActionIdsPlayerPrefsKey);
			if (string.IsNullOrEmpty(@string))
			{
				return list;
			}
			string[] array = @string.Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				int item;
				if (!string.IsNullOrEmpty(array[i]) && int.TryParse(array[i], out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00139BC0 File Offset: 0x00137DC0
		private List<UserDataStore_PlayerPrefs.SavedControllerMapData> GetAllControllerMapsXml(Player player, bool userAssignableMapsOnly, Controller controller)
		{
			List<UserDataStore_PlayerPrefs.SavedControllerMapData> list = new List<UserDataStore_PlayerPrefs.SavedControllerMapData>();
			IList<InputMapCategory> mapCategories = ReInput.mapping.MapCategories;
			for (int i = 0; i < mapCategories.Count; i++)
			{
				InputMapCategory inputMapCategory = mapCategories[i];
				if (!userAssignableMapsOnly || inputMapCategory.userAssignable)
				{
					IList<InputLayout> list2 = ReInput.mapping.MapLayouts(controller.type);
					for (int j = 0; j < list2.Count; j++)
					{
						InputLayout inputLayout = list2[j];
						string controllerMapXml = this.GetControllerMapXml(player, controller, inputMapCategory.id, inputLayout.id);
						if (!(controllerMapXml == string.Empty))
						{
							List<int> controllerMapKnownActionIds = this.GetControllerMapKnownActionIds(player, controller, inputMapCategory.id, inputLayout.id);
							list.Add(new UserDataStore_PlayerPrefs.SavedControllerMapData(controllerMapXml, controllerMapKnownActionIds));
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00139C88 File Offset: 0x00137E88
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			string joystickCalibrationMapPlayerPrefsKey = this.GetJoystickCalibrationMapPlayerPrefsKey(joystick);
			if (!PlayerPrefs.HasKey(joystickCalibrationMapPlayerPrefsKey))
			{
				return string.Empty;
			}
			return PlayerPrefs.GetString(joystickCalibrationMapPlayerPrefsKey);
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00139CB4 File Offset: 0x00137EB4
		private string GetInputBehaviorXml(Player player, int id)
		{
			string inputBehaviorPlayerPrefsKey = this.GetInputBehaviorPlayerPrefsKey(player, id);
			if (!PlayerPrefs.HasKey(inputBehaviorPlayerPrefsKey))
			{
				return string.Empty;
			}
			return PlayerPrefs.GetString(inputBehaviorPlayerPrefsKey);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00139CE0 File Offset: 0x00137EE0
		private void AddDefaultMappingsForNewActions(Player player, List<UserDataStore_PlayerPrefs.SavedControllerMapData> savedData, ControllerType controllerType, int controllerId)
		{
			if (player != null && savedData != null)
			{
				List<int> allActionIds = this.GetAllActionIds();
				for (int i = 0; i < savedData.Count; i++)
				{
					UserDataStore_PlayerPrefs.SavedControllerMapData savedControllerMapData = savedData[i];
					if (savedControllerMapData != null && savedControllerMapData.knownActionIds != null && savedControllerMapData.knownActionIds.Count != 0)
					{
						ControllerMap controllerMap = ControllerMap.CreateFromXml(controllerType, savedData[i].xml);
						if (controllerMap != null)
						{
							ControllerMap map = player.controllers.maps.GetMap(controllerType, controllerId, controllerMap.categoryId, controllerMap.layoutId);
							if (map != null)
							{
								ControllerMap controllerMapInstance = ReInput.mapping.GetControllerMapInstance(ReInput.controllers.GetController(controllerType, controllerId), controllerMap.categoryId, controllerMap.layoutId);
								if (controllerMapInstance != null)
								{
									List<int> list = new List<int>();
									foreach (int item in allActionIds)
									{
										if (!savedControllerMapData.knownActionIds.Contains(item))
										{
											list.Add(item);
										}
									}
									if (list.Count != 0)
									{
										foreach (ActionElementMap actionElementMap in controllerMapInstance.AllMaps)
										{
											if (list.Contains(actionElementMap.actionId) && !map.DoesElementAssignmentConflict(actionElementMap))
											{
												ElementAssignment elementAssignment = new ElementAssignment(controllerType, actionElementMap.elementType, actionElementMap.elementIdentifierId, actionElementMap.axisRange, actionElementMap.keyCode, actionElementMap.modifierKeyFlags, actionElementMap.actionId, actionElementMap.axisContribution, actionElementMap.invert);
												map.CreateElementMap(elementAssignment);
											}
										}
									}
								}
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00139EB8 File Offset: 0x001380B8
		private List<int> GetAllActionIds()
		{
			List<int> list = new List<int>();
			IList<InputAction> actions = ReInput.mapping.Actions;
			for (int i = 0; i < actions.Count; i++)
			{
				list.Add(actions[i].id);
			}
			return list;
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00139EFC File Offset: 0x001380FC
		private string GetAllActionIdsString()
		{
			string text = string.Empty;
			List<int> allActionIds = this.GetAllActionIds();
			for (int i = 0; i < allActionIds.Count; i++)
			{
				if (i > 0)
				{
					text += ",";
				}
				text += allActionIds[i];
			}
			return text;
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00139F4C File Offset: 0x0013814C
		private Joystick FindJoystickPrecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			if (joystickInfo == null)
			{
				return null;
			}
			if (joystickInfo.instanceGuid == Guid.Empty)
			{
				return null;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i].deviceInstanceGuid == joystickInfo.instanceGuid)
				{
					return joysticks[i];
				}
			}
			return null;
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00139FB0 File Offset: 0x001381B0
		private bool TryFindJoysticksImprecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			matches = null;
			if (joystickInfo == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(joystickInfo.hardwareIdentifier))
			{
				return false;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (string.Equals(joysticks[i].hardwareIdentifier, joystickInfo.hardwareIdentifier, StringComparison.OrdinalIgnoreCase))
				{
					if (matches == null)
					{
						matches = new List<Joystick>();
					}
					matches.Add(joysticks[i]);
				}
			}
			return matches != null;
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0013A028 File Offset: 0x00138228
		private static int GetDuplicateIndex(Player player, Controller controller)
		{
			int num = 0;
			foreach (Controller controller2 in player.controllers.Controllers)
			{
				if (controller2.type == controller.type)
				{
					bool flag = false;
					if (controller.type == ControllerType.Joystick)
					{
						if ((controller2 as Joystick).hardwareTypeGuid != (controller as Joystick).hardwareTypeGuid)
						{
							continue;
						}
						if ((controller as Joystick).hardwareTypeGuid != Guid.Empty)
						{
							flag = true;
						}
					}
					if (flag || !(controller2.hardwareIdentifier != controller.hardwareIdentifier))
					{
						if (controller2 == controller)
						{
							return num;
						}
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x04000852 RID: 2130
		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		// Token: 0x04000853 RID: 2131
		private const string editorLoadedMessage = "\nIf unexpected input issues occur, the loaded XML data may be outdated or invalid. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		// Token: 0x04000854 RID: 2132
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		// Token: 0x04000855 RID: 2133
		[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
		[SerializeField]
		private bool isEnabled = true;

		// Token: 0x04000856 RID: 2134
		[Tooltip("Should saved data be loaded on start?")]
		[SerializeField]
		private bool loadDataOnStart = true;

		// Token: 0x04000857 RID: 2135
		[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
		[SerializeField]
		private bool loadJoystickAssignments = true;

		// Token: 0x04000858 RID: 2136
		[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
		[SerializeField]
		private bool loadKeyboardAssignments = true;

		// Token: 0x04000859 RID: 2137
		[SerializeField]
		[Tooltip("Should Player Mouse assignments be saved and loaded?")]
		private bool loadMouseAssignments = true;

		// Token: 0x0400085A RID: 2138
		[SerializeField]
		[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
		private string playerPrefsKeyPrefix = "RewiredSaveData";

		// Token: 0x0400085B RID: 2139
		private bool allowImpreciseJoystickAssignmentMatching = true;

		// Token: 0x0400085C RID: 2140
		private bool deferredJoystickAssignmentLoadPending;

		// Token: 0x0400085D RID: 2141
		private bool wasJoystickEverDetected;

		// Token: 0x020000EE RID: 238
		private class SavedControllerMapData
		{
			// Token: 0x06002D02 RID: 11522 RVA: 0x00012812 File Offset: 0x00010A12
			public SavedControllerMapData(string xml, List<int> knownActionIds)
			{
				this.xml = xml;
				this.knownActionIds = knownActionIds;
			}

			// Token: 0x06002D03 RID: 11523 RVA: 0x0013A0F0 File Offset: 0x001382F0
			public static List<string> GetXmlStringList(List<UserDataStore_PlayerPrefs.SavedControllerMapData> data)
			{
				List<string> list = new List<string>();
				if (data == null)
				{
					return list;
				}
				for (int i = 0; i < data.Count; i++)
				{
					if (data[i] != null && !string.IsNullOrEmpty(data[i].xml))
					{
						list.Add(data[i].xml);
					}
				}
				return list;
			}

			// Token: 0x0400085E RID: 2142
			public string xml;

			// Token: 0x0400085F RID: 2143
			public List<int> knownActionIds;
		}

		// Token: 0x020000EF RID: 239
		private class ControllerAssignmentSaveInfo
		{
			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06002D04 RID: 11524 RVA: 0x00012828 File Offset: 0x00010A28
			public int playerCount
			{
				get
				{
					if (this.players == null)
					{
						return 0;
					}
					return this.players.Length;
				}
			}

			// Token: 0x06002D05 RID: 11525 RVA: 0x0000306E File Offset: 0x0000126E
			public ControllerAssignmentSaveInfo()
			{
			}

			// Token: 0x06002D06 RID: 11526 RVA: 0x0013A148 File Offset: 0x00138348
			public ControllerAssignmentSaveInfo(int playerCount)
			{
				this.players = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[playerCount];
				for (int i = 0; i < playerCount; i++)
				{
					this.players[i] = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo();
				}
			}

			// Token: 0x06002D07 RID: 11527 RVA: 0x0013A180 File Offset: 0x00138380
			public int IndexOfPlayer(int playerId)
			{
				for (int i = 0; i < this.playerCount; i++)
				{
					if (this.players[i] != null && this.players[i].id == playerId)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06002D08 RID: 11528 RVA: 0x0001283C File Offset: 0x00010A3C
			public bool ContainsPlayer(int playerId)
			{
				return this.IndexOfPlayer(playerId) >= 0;
			}

			// Token: 0x04000860 RID: 2144
			public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;

			// Token: 0x020000F0 RID: 240
			public class PlayerInfo
			{
				// Token: 0x170002B8 RID: 696
				// (get) Token: 0x06002D09 RID: 11529 RVA: 0x0001284B File Offset: 0x00010A4B
				public int joystickCount
				{
					get
					{
						if (this.joysticks == null)
						{
							return 0;
						}
						return this.joysticks.Length;
					}
				}

				// Token: 0x06002D0A RID: 11530 RVA: 0x0013A1C0 File Offset: 0x001383C0
				public int IndexOfJoystick(int joystickId)
				{
					for (int i = 0; i < this.joystickCount; i++)
					{
						if (this.joysticks[i] != null && this.joysticks[i].id == joystickId)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x06002D0B RID: 11531 RVA: 0x0001285F File Offset: 0x00010A5F
				public bool ContainsJoystick(int joystickId)
				{
					return this.IndexOfJoystick(joystickId) >= 0;
				}

				// Token: 0x04000861 RID: 2145
				public int id;

				// Token: 0x04000862 RID: 2146
				public bool hasKeyboard;

				// Token: 0x04000863 RID: 2147
				public bool hasMouse;

				// Token: 0x04000864 RID: 2148
				public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;
			}

			// Token: 0x020000F1 RID: 241
			public class JoystickInfo
			{
				// Token: 0x04000865 RID: 2149
				public Guid instanceGuid;

				// Token: 0x04000866 RID: 2150
				public string hardwareIdentifier;

				// Token: 0x04000867 RID: 2151
				public int id;
			}
		}

		// Token: 0x020000F2 RID: 242
		private class JoystickAssignmentHistoryInfo
		{
			// Token: 0x06002D0E RID: 11534 RVA: 0x0001286E File Offset: 0x00010A6E
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
				if (joystick == null)
				{
					throw new ArgumentNullException("joystick");
				}
				this.joystick = joystick;
				this.oldJoystickId = oldJoystickId;
			}

			// Token: 0x04000868 RID: 2152
			public readonly Joystick joystick;

			// Token: 0x04000869 RID: 2153
			public readonly int oldJoystickId;
		}
	}
}
