using UnityEngine;
using UnityEngine.UI;

namespace ControlFreak2
{
	public class NotificationElementGUI : MonoBehaviour
	{
		public Text targetText;

		public Image targetIcon;

		private float duration;

		private float elapsed;

		public void End()
		{
		}

		public void Show(string msg, Sprite icon, RectTransform parent, float duration)
		{
		}

		public void UpdateNotification(float dt)
		{
		}

		public float GetTimeElapsed()
		{
			return 0f;
		}

		protected virtual void OnUpdate()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public static int Compare(NotificationElementGUI a, NotificationElementGUI b)
		{
			return 0;
		}
	}
}
