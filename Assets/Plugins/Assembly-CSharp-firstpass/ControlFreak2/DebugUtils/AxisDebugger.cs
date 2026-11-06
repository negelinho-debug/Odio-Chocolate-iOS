using UnityEngine;

namespace ControlFreak2.DebugUtils
{
	public class AxisDebugger : MonoBehaviour
	{
		public bool drawGUI;

		public bool drawMouseStats;

		public bool drawUnityAxes;

		public bool drawKeyCodes;

		public KeyCode deltaResetKey;

		private Vector2 cfScroll;

		private Vector2 unScroll;

		private Vector2 cfMouseDelta;

		private Vector2 unMouseDelta;

		public GUISkin skin;

		private KeyCode[] allKeyCodes;

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		private float GetUnityAxis(string name, float defaultVal = 0f)
		{
			return 0f;
		}
	}
}
