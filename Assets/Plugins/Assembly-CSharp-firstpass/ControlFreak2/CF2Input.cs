using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ControlFreak2
{
	public static class CF2Input
	{
		public enum MobileMode
		{
			Auto = 0,
			Enabled = 1,
			Disabled = 2
		}

		private const bool simulateMouseWithTouchesWhenRigIsActive = false;

		private static MobileMode mMobileMode;

		private static bool mSimulateMouseWithTouches;

		[CompilerGenerated]
		private static Action m_onMobileModeChange;

		[CompilerGenerated]
		private static Action m_onActiveRigChange;

		private static InputRig mRig;

		public static InputRig activeRig
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool anyKey => false;

		public static bool anyKeyDown => false;

		public static int touchCount => 0;

		public static InputRig.Touch[] touches => null;

		public static Vector3 mousePosition => default;

		public static Vector2 mouseScrollDelta => default;

		public static bool simulateMouseWithTouches
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event Action onMobileModeChange
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

		public static event Action onActiveRigChange
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

		public static MobileMode GetMobileMode()
		{
			return MobileMode.Auto;
		}

		public static void SetMobileMode(MobileMode mode)
		{
		}

		public static bool IsInMobileMode()
		{
			return false;
		}

		public static bool IsMobilePlatform()
		{
			return false;
		}

		[Obsolete]
		public static bool ControllerActive()
		{
			return false;
		}

		public static void ResetInputAxes()
		{
		}

		public static float GetAxis(string axisName)
		{
			return 0f;
		}

		public static float GetAxis(string axisName, ref int cachedId)
		{
			return 0f;
		}

		public static float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		public static float GetAxisRaw(string axisName, ref int cachedId)
		{
			return 0f;
		}

		public static bool GetButton(string axisName)
		{
			return false;
		}

		public static bool GetButton(string axisName, ref int cachedId)
		{
			return false;
		}

		public static bool GetButtonDown(string axisName)
		{
			return false;
		}

		public static bool GetButtonDown(string axisName, ref int cachedId)
		{
			return false;
		}

		public static bool GetButtonUp(string axisName)
		{
			return false;
		}

		public static bool GetButtonUp(string axisName, ref int cachedId)
		{
			return false;
		}

		public static bool GetKey(KeyCode keyCode)
		{
			return false;
		}

		public static bool GetKeyDown(KeyCode keyCode)
		{
			return false;
		}

		public static bool GetKeyUp(KeyCode keyCode)
		{
			return false;
		}

		[Obsolete]
		public static bool GetKey(string keyName)
		{
			return false;
		}

		[Obsolete]
		public static bool GetKeyDown(string keyName)
		{
			return false;
		}

		[Obsolete]
		public static bool GetKeyUp(string keyName)
		{
			return false;
		}

		public static InputRig.Touch GetTouch(int i)
		{
			return default;
		}

		public static bool GetMouseButton(int mouseButton)
		{
			return false;
		}

		public static bool GetMouseButtonDown(int mouseButton)
		{
			return false;
		}

		public static bool GetMouseButtonUp(int mouseButton)
		{
			return false;
		}

		public static void CalibrateTilt()
		{
		}
	}
}
