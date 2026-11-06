using UnityEngine;
using UnityEngine.Events;

namespace ControlFreak2.Extra
{
	public class KeyPressEvent : MonoBehaviour
	{
		public enum EventType
		{
			OnPress = 0,
			OnRelease = 1,
			WhenPressed = 2
		}

		public KeyCode keyCode;

		public EventType eventType;

		public UnityEvent keyEvent;

		private void Update()
		{
		}
	}
}
