using System;

namespace ControlFreak2
{
	[Serializable]
	public class GamepadProfile
	{
		public enum DeviceType
		{
			Unknown = 0,
			PS3 = 1,
			PS4 = 2,
			Xbox360 = 3,
			XboxOne = 4,
			MOGA = 5,
			OUYA = 6
		}

		public enum ProfileMode
		{
			Normal = 0,
			Regex = 1
		}

		[Serializable]
		public class JoystickSource
		{
			public KeySource keyU;

			public KeySource keyD;

			public KeySource keyR;

			public KeySource keyL;

			public static JoystickSource Dpad(int keyU, int keyR, int keyD, int keyL)
			{
				return null;
			}

			public static JoystickSource Axes(int horzAxisId, bool horzPositiveRight, int vertAxisId, bool vertPositiveUp)
			{
				return null;
			}

			public bool IsDuplicateOf(JoystickSource a)
			{
				return false;
			}

			public static JoystickSource Empty()
			{
				return null;
			}
		}

		[Serializable]
		public class KeySource
		{
			public int keyId;

			public int axisId;

			public bool axisSign;

			public KeySource()
			{
			}

			public bool IsEmpty()
			{
				return false;
			}

			public bool IsDuplicateOf(KeySource a)
			{
				return false;
			}

			public void Clear()
			{
			}

			public void SetKey(int keyId)
			{
			}

			public void SetAxis(int axisId, bool axisSign)
			{
			}

			private KeySource(int keyId, int axisId, bool axisSign)
			{
			}

			public static KeySource Key(int keyId)
			{
				return null;
			}

			public static KeySource PlusAxis(int axisId)
			{
				return null;
			}

			public static KeySource MinusAxis(int axisId)
			{
				return null;
			}

			public static KeySource KeyAndPlusAxis(int keyId, int axisId)
			{
				return null;
			}

			public static KeySource KeyAndMinusAxis(int keyId, int axisId)
			{
				return null;
			}

			public static KeySource Empty()
			{
				return null;
			}
		}

		public class GenericProfile : GamepadProfile
		{
			public GenericProfile(JoystickSource leftStick = null, JoystickSource rightStick = null, JoystickSource dpad = null, KeySource faceBottom = null, KeySource faceRight = null, KeySource faceLeft = null, KeySource faceTop = null, KeySource select = null, KeySource start = null, KeySource L1 = null, KeySource R1 = null, KeySource L2 = null, KeySource R2 = null, KeySource L3 = null, KeySource R3 = null)
			{
			}
		}

		public const int CAP_DPAD = 1;

		public const int CAP_LEFT_STICK = 2;

		public const int CAP_RIGHT_STICK = 4;

		public const int CAP_START = 8;

		public const int CAP_SELECT = 16;

		public const int CAP_SHOULDER_KEYS = 32;

		public const int CAP_ANALOG_TRIGGERS = 64;

		public const int CAP_PRESSABLE_STICKS = 128;

		public string name;

		public string joystickIdentifier;

		public ProfileMode profileMode;

		public string unityVerFrom;

		public string unityVerTo;

		public JoystickSource leftStick;

		public JoystickSource rightStick;

		public JoystickSource dpad;

		public KeySource keyFaceU;

		public KeySource keyFaceR;

		public KeySource keyFaceD;

		public KeySource keyFaceL;

		public KeySource keyStart;

		public KeySource keySelect;

		public KeySource keyL1;

		public KeySource keyR1;

		public KeySource keyL2;

		public KeySource keyR2;

		public KeySource keyL3;

		public KeySource keyR3;

		public GamepadProfile()
		{
		}

		public bool IsCompatible(string deviceName)
		{
			return false;
		}

		public void AddSupportedVersion(string unityVer)
		{
		}

		public JoystickSource GetJoystickSource(int id)
		{
			return null;
		}

		public KeySource GetKeySource(int id)
		{
			return null;
		}

		public bool IsDuplicateOf(GamepadProfile profile)
		{
			return false;
		}

		public GamepadProfile(string name, string deviceIdentifier, ProfileMode profileMode = ProfileMode.Normal, string unityVerFrom = null, string unityVerTo = null, JoystickSource leftStick = null, JoystickSource rightStick = null, JoystickSource dpad = null, KeySource faceBottom = null, KeySource faceRight = null, KeySource faceLeft = null, KeySource faceTop = null, KeySource select = null, KeySource start = null, KeySource L1 = null, KeySource R1 = null, KeySource L2 = null, KeySource R2 = null, KeySource L3 = null, KeySource R3 = null)
		{
		}
	}
}
