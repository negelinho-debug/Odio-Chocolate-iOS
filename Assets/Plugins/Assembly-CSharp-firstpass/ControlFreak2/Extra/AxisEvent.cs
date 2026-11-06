using UnityEngine;
using UnityEngine.Events;

namespace ControlFreak2.Extra
{
	public class AxisEvent : MonoBehaviour
	{
		public enum EventType
		{
			OnPress = 0,
			OnRelease = 1,
			WhenPressed = 2
		}

		public string axisName;

		public float axisDeadzone;

		private int axisId;

		private int prevAxisDir;

		public EventType eventType;

		public UnityEvent positiveEvent;

		public UnityEvent negativeEvent;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
