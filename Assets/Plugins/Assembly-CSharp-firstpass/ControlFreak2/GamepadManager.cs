using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public class GamepadManager : ComponentBase
	{
		public delegate void OnConnectionChnageCallback(Gamepad gamepad);

		public delegate void OnDisconnectionCallback(Gamepad gamepad, DisconnectionReason reason);

		public enum GamepadStick
		{
			LeftAnalog = 0,
			RightAnalog = 1,
			Dpad = 2
		}

		public enum GamepadKey
		{
			FaceBottom = 0,
			FaceRight = 1,
			FaceTop = 2,
			FaceLeft = 3,
			Start = 4,
			Select = 5,
			L1 = 6,
			R1 = 7,
			L2 = 8,
			R2 = 9,
			L3 = 10,
			R3 = 11
		}

		public enum DisconnectionReason
		{
			MassDisactivation = 0,
			Disactivation = 1,
			Disconnection = 2,
			ManagerDisabled = 3
		}

		public class Gamepad
		{
			public class JoyState
			{
				private Gamepad gamepad;

				public JoystickState state;

				private bool isConnectedToHardware;

				private int srcAxisIdL;

				private int srcAxisIdR;

				private int srcAxisIdU;

				private int srcAxisIdD;

				private bool srcAxisFlipL;

				private bool srcAxisFlipR;

				private bool srcAxisFlipU;

				private bool srcAxisFlipD;

				private int srcKeyU;

				private int srcKeyR;

				private int srcKeyD;

				private int srcKeyL;

				public JoyState(Gamepad gamepad, JoystickConfig config)
				{
				}

				public void SetConfig(JoystickConfig config)
				{
				}

				public void Reset()
				{
				}

				public void Update()
				{
				}

				private float GetCompositeAnalogVal(int posAxisId, bool posFlip, int negAxisId, bool negFlip)
				{
					return 0f;
				}

				private void ReadHardwareState()
				{
				}

				public void ConnectToJoy(GamepadProfile.JoystickSource joySrc)
				{
				}

				public void SyncJoyState(JoystickStateBinding bind, InputRig rig)
				{
				}
			}

			public class KeyState
			{
				private Gamepad gamepad;

				private bool isTrigger;

				private AnalogConfig analogConfig;

				public bool isConnectedToHardware;

				private float frAnalog;

				private bool frDigital;

				private float analogCur;

				private float analogRawCur;

				private bool digiCurRaw;

				private bool digiCur;

				private bool digiPrev;

				private int srcAxisId;

				private int srcKeyId;

				private bool srcAxisSign;

				public KeyState(Gamepad gamepad, bool isTrigger, AnalogConfig analogConfig = null)
				{
				}

				public void SetConfig(AnalogConfig config)
				{
				}

				public void SetDigital(bool state)
				{
				}

				public void SetAnalog(float val)
				{
				}

				public bool GetDigitalRaw()
				{
					return false;
				}

				public bool GetDigital()
				{
					return false;
				}

				public bool GetDigitalDown()
				{
					return false;
				}

				public bool GetDigitalUp()
				{
					return false;
				}

				public float GetAnalog()
				{
					return 0f;
				}

				public float GetAnalogRaw()
				{
					return 0f;
				}

				public bool IsTrigger()
				{
					return false;
				}

				public void Reset()
				{
				}

				public void Update()
				{
				}

				private void ReadHardwareState()
				{
				}

				public void ConnectToJoy(GamepadProfile.KeySource src)
				{
				}

				public void SyncDigital(DigitalBinding bind, InputRig rig)
				{
				}

				public void SyncAnalog(AxisBinding bind, InputRig rig)
				{
				}
			}

			private class InternalKeyState
			{
				private KeyCode key;

				public bool stateCur;

				public bool statePrev;

				public bool isReadyToUse;

				public bool GetState()
				{
					return false;
				}

				public void Reset()
				{
				}

				public void Update()
				{
				}

				private void ReadHardwareState()
				{
				}

				public void ConnectToHardwareKey(int joyId, int keyId)
				{
				}
			}

			private class InternalAxisState
			{
				private string axisName;

				public float valCur;

				public float valPrev;

				public bool isReadyToUse;

				public bool trueAnalogRange;

				public float GetVal()
				{
					return 0f;
				}

				public int GetDigital()
				{
					return 0;
				}

				public void Reset()
				{
				}

				public void Update()
				{
				}

				public void SetVal(float v)
				{
				}

				private void ReadHardwareState()
				{
				}

				public void ConnectToHardwareAxis(int joyId, int axisId)
				{
				}

				public bool IsFullyAnalog()
				{
					return false;
				}
			}

			private GamepadManager manager;

			private GamepadProfile profile;

			private bool isActivated;

			private bool isConnected;

			private bool isBlocked;

			private string internalJoyName;

			private int internalJoyId;

			private int slot;

			public JoyState leftStick;

			public JoyState rightStick;

			public JoyState dpad;

			public KeyState[] keys;

			private InternalAxisState[] internalAxes;

			private InternalKeyState[] internalKeys;

			public Gamepad(GamepadManager manager)
			{
			}

			public bool IsConnected()
			{
				return false;
			}

			public bool IsActivated()
			{
				return false;
			}

			public bool IsSupported()
			{
				return false;
			}

			public int GetSlot()
			{
				return 0;
			}

			public string GetInternalJoyName()
			{
				return null;
			}

			public int GetInternalJoyId()
			{
				return 0;
			}

			public string GetProfileName()
			{
				return null;
			}

			public void Block(bool block)
			{
			}

			public bool IsBlocked()
			{
				return false;
			}

			public void SetRig(InputRig rig)
			{
			}

			public void ConnectToJoy(int internalJoyId, string joyName)
			{
			}

			public void OnDisconnect()
			{
			}

			public void OnActivate(int slot)
			{
			}

			public void OnDisactivate()
			{
			}

			public GamepadProfile GetProfile()
			{
				return null;
			}

			public void SetProfile(GamepadProfile profile)
			{
			}

			public void Reset()
			{
			}

			public bool GetKey(GamepadKey key)
			{
				return false;
			}

			public bool GetKeyDown(GamepadKey key)
			{
				return false;
			}

			public bool GetKeyUp(GamepadKey key)
			{
				return false;
			}

			public float GetKeyAnalog(GamepadKey key)
			{
				return 0f;
			}

			public Vector2 GetStickVec(GamepadStick s)
			{
				return default;
			}

			public Dir GetStickDir8(GamepadStick s)
			{
				return Dir.N;
			}

			public Dir GetStickDir4(GamepadStick s)
			{
				return Dir.N;
			}

			public Dir GetStickDir(GamepadStick s)
			{
				return Dir.N;
			}

			public JoystickState GetStick(GamepadStick s)
			{
				return null;
			}

			public bool GetInternalKeyState(int keyId)
			{
				return false;
			}

			public float GetInternalAxisAnalog(int axisId)
			{
				return 0f;
			}

			public int GetInternalAxisDigital(int axisId)
			{
				return 0;
			}

			public bool IsInternalAxisFullyAnalog(int axisId)
			{
				return false;
			}

			public bool AnyInternalKeyOrAxisPressed()
			{
				return false;
			}

			public bool AnyInternalKeyPressed()
			{
				return false;
			}

			public bool AnyInternalAxisPressed()
			{
				return false;
			}

			public int GetPressedInternalKey(int start = 0)
			{
				return 0;
			}

			public int GetPressedInternalAxis(out bool positiveSide, int start = 0)
			{
				positiveSide = default;
				return 0;
			}

			public void Update()
			{
			}

			public void ApplyGamepadState(Gamepad g)
			{
			}
		}

		[CompilerGenerated]
		private static OnDisconnectionCallback m_onGamepadDisconnected;

		[CompilerGenerated]
		private static OnDisconnectionCallback m_onGamepadDisactivated;

		[CompilerGenerated]
		private static OnConnectionChnageCallback m_onGamepadConnected;

		[CompilerGenerated]
		private static OnConnectionChnageCallback m_onGamepadActivated;

		[CompilerGenerated]
		private static Action m_onChange;

		public const int MAX_JOYSTICKS = 4;

		public const int MAX_INTERNAL_AXES = 10;

		public const int MAX_INTERNAL_KEYS = 20;

		public const int GamepadStickCount = 3;

		public const int GamepadKeyCount = 12;

		private static string[] ignoredDeviceNames;

		private CustomGamepadProfileBank customProfileBank;

		public bool dontDestroyOnLoad;

		public float connectionCheckInterval;

		private float elapsedSinceLastConnectionCheck;

		[NonSerialized]
		private JoystickConfig fallbackDpadConfig;

		[NonSerialized]
		private JoystickConfig fallbackLeftStickConfig;

		[NonSerialized]
		private JoystickConfig fallbackRightStickConfig;

		[NonSerialized]
		private AnalogConfig fallbackLeftTriggerAnalogConfig;

		[NonSerialized]
		private AnalogConfig fallbackRightTriggerAnalogConfig;

		private List<Gamepad> activeGamepads;

		private List<Gamepad> freeGamepads;

		private List<Gamepad> connectedGamepads;

		private Gamepad gamepadsCombined;

		private int activeGamepadNum;

		private string[] deviceConnections;

		public static GamepadManager activeManager { get; private set; }

		public static event OnDisconnectionCallback onGamepadDisconnected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event OnDisconnectionCallback onGamepadDisactivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event OnConnectionChnageCallback onGamepadConnected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event OnConnectionChnageCallback onGamepadActivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action onChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static bool IsDeviceIgnored(string deviceName)
		{
			return false;
		}

		public static string GetJoyAxisName(int joyId, int axisId)
		{
			return null;
		}

		public static KeyCode GetJoyKeyCode(int joyId, int keyId)
		{
			return KeyCode.None;
		}

		protected override void OnInitComponent()
		{
		}

		protected override void OnDestroyComponent()
		{
		}

		protected override void OnEnableComponent()
		{
		}

		public bool IsMain()
		{
			return false;
		}

		public void SetAsMain()
		{
		}

		public void RemoveAsMain()
		{
		}

		public CustomGamepadProfileBank GetCustomProfileBank()
		{
			return null;
		}

		protected override void OnDisableComponent()
		{
		}

		private void OnActiveRigChange()
		{
		}

		private void Update()
		{
		}

		private void ApplyToRig(InputRig rig)
		{
		}

		private void CheckJoystickConnections()
		{
		}

		private string GetConnectedDeviceName(int internalJoyId)
		{
			return null;
		}

		private Gamepad AddConnectedGamepad()
		{
			return null;
		}

		private Gamepad FindDisconnectedGamepad(int internalJoyId, string deviceName)
		{
			return null;
		}

		private void ActivateGamepad(Gamepad g)
		{
		}

		private void DisactivateGamepad(Gamepad g, DisconnectionReason reason)
		{
		}

		private void CountActiveGamepads()
		{
		}

		private void DisconnectGamepad(Gamepad g, DisconnectionReason reason)
		{
		}

		private void ConnectJoysticks()
		{
		}

		private void CheckUnactivatedGamepads()
		{
		}

		public int GetGamepadSlotCount()
		{
			return 0;
		}

		public int GetActiveGamepadCount()
		{
			return 0;
		}

		public Gamepad GetGamepadAtSlot(int slot)
		{
			return null;
		}

		public Gamepad GetCombinedGamepad()
		{
			return null;
		}

		public int GetConnectedGamepadCount()
		{
			return 0;
		}

		public Gamepad GetConnectedGamepad(int index)
		{
			return null;
		}

		public void DisactivateGamepads()
		{
		}

		private GamepadProfile GetProfileForDevice(string joyDevice)
		{
			return null;
		}
	}
}
