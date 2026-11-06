using UnityEngine;
using UnityEngine.Events;

namespace ControlFreak2.Extra
{
	public class ButtonPressEvent : MonoBehaviour
	{
		public enum EventType
		{
			OnPress = 0,
			OnRelease = 1,
			WhenPressed = 2
		}

		public string buttonName;

		private int buttonId;

		public EventType eventType;

		public UnityEvent buttonEvent;

		private void Update()
		{
		}
	}
}
