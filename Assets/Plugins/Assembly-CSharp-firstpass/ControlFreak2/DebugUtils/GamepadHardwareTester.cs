using UnityEngine;

namespace ControlFreak2.DebugUtils
{
	[ExecuteInEditMode]
	public class GamepadHardwareTester : MonoBehaviour
	{
		public GUISkin skin;

		public const int MAX_JOYSTICKS = 4;

		public const int MAX_JOYSTICK_AXES = 10;

		public const int MAX_JOYSTICK_KEYS = 20;

		private const float AXIS_DEADZONE = 0.05f;

		private const int AXIS_COUNT = 8;

		private const int KEY_COUNT = 20;

		public static string GetJoyAxisName(int joyId, int axisId)
		{
			return null;
		}

		public static KeyCode GetJoyKeyCode(int joyId, int keyId)
		{
			return KeyCode.None;
		}

		private string GetAxisCode(int axis, bool positiveSide)
		{
			return null;
		}

		private string GetAxisName(int axis, bool positiveSide)
		{
			return null;
		}

		private float GetAxisState(int axis)
		{
			return 0f;
		}

		private string GetKeyCode(int key)
		{
			return null;
		}

		private bool GetKeyState(int key)
		{
			return false;
		}

		private void OnGUI()
		{
		}
	}
}
