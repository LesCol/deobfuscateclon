using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Internal;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Utils
{
	// Token: 0x020000EC RID: 236
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExternalTools : IExternalTools
	{
		// Token: 0x06002C71 RID: 11377 RVA: 0x00012393 File Offset: 0x00010593
		public object GetPlatformInitializer()
		{
			return null;
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00012396 File Offset: 0x00010596
		public string GetFocusedEditorWindowTitle()
		{
			return string.Empty;
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public bool IsEditorSceneViewFocused()
		{
			return false;
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return false;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06002C75 RID: 11381 RVA: 0x00138C0C File Offset: 0x00136E0C
		// (remove) Token: 0x06002C76 RID: 11382 RVA: 0x00138C44 File Offset: 0x00136E44
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

		// Token: 0x06002C77 RID: 11383 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			return 0;
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x0001239D File Offset: 0x0001059D
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return 0UL;
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return false;
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00012396 File Offset: 0x00010596
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return string.Empty;
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return 0u;
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return false;
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000123A8 File Offset: 0x000105A8
		public Vector3 PS4Input_GetLastAcceleration(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000123A8 File Offset: 0x000105A8
		public Vector3 PS4Input_GetLastGyro(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000123AF File Offset: 0x000105AF
		public Vector4 PS4Input_GetLastOrientation(int id)
		{
			return Vector4.zero;
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000123B6 File Offset: 0x000105B6
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
			touchNum = 0;
			touch0x = 0;
			touch0y = 0;
			touch0id = 0;
			touch1x = 0;
			touch1y = 0;
			touch1id = 0;
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000123D2 File Offset: 0x000105D2
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
			touchpixelDensity = 0f;
			touchResolutionX = 0;
			touchResolutionY = 0;
			analogDeadZoneLeft = 0;
			analogDeadZoneright = 0;
			connectionType = 0;
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_PadResetLightBar(int id)
		{
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_PadResetOrientation(int id)
		{
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public bool PS4Input_PadIsConnected(int id)
		{
			return false;
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000123EE File Offset: 0x000105EE
		public int PS4Input_GetDeviceClassForHandle(int handle)
		{
			return -1;
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00012393 File Offset: 0x00010593
		public string PS4Input_GetDeviceClassString(int intValue)
		{
			return null;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000123A8 File Offset: 0x000105A8
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			return Vector3.zero;
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000123A8 File Offset: 0x000105A8
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			return Vector3.zero;
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_MoveGetButtons(int id, int index)
		{
			return 0;
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			return 0;
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public bool PS4Input_MoveIsConnected(int id, int index)
		{
			return false;
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
		{
			return 0;
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
		{
			return 0;
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			return 0;
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000123F1 File Offset: 0x000105F1
		public IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			return IntPtr.Zero;
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
		{
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x000123A8 File Offset: 0x000105A8
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x000123A8 File Offset: 0x000105A8
		public Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000123AF File Offset: 0x000105AF
		public Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			return Vector4.zero;
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public bool PS4Input_SpecialIsConnected(int id)
		{
			return false;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_SpecialResetLightSphere(int id)
		{
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_SpecialResetOrientation(int id)
		{
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x00002C8A File Offset: 0x00000E8A
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000123F8 File Offset: 0x000105F8
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
			vids = new List<int>();
			pids = new List<int>();
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000123EE File Offset: 0x000105EE
		public int GetAndroidAPILevel()
		{
			return -1;
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00012408 File Offset: 0x00010608
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return !(graphic as Graphic == null) && (graphic as Graphic).raycastTarget;
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00012425 File Offset: 0x00010625
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
			if (graphic as Graphic == null)
			{
				return;
			}
			(graphic as Graphic).raycastTarget = value;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x00012442 File Offset: 0x00010642
		public bool UnityInput_IsTouchPressureSupported
		{
			get
			{
				return Input.touchPressureSupported;
			}
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00012449 File Offset: 0x00010649
		public float UnityInput_GetTouchPressure(ref Touch touch)
		{
			return touch.pressure;
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x00012451 File Offset: 0x00010651
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			return touch.maximumPossiblePressure;
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00012459 File Offset: 0x00010659
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return ControllerTemplateFactory.Create(typeGuid, payload);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00012462 File Offset: 0x00010662
		public Type[] GetControllerTemplateTypes()
		{
			return ControllerTemplateFactory.templateTypes;
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x00012469 File Offset: 0x00010669
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return ControllerTemplateFactory.templateInterfaceTypes;
		}
	}
}
