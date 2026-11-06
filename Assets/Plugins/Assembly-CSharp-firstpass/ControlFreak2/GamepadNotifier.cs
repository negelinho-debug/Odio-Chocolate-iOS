using System.Collections.Generic;
using UnityEngine;

namespace ControlFreak2
{
	public class GamepadNotifier : MonoBehaviour
	{
		public int maxNotifications;

		public float msgDuration;

		public NotificationElementGUI notificationTemplate;

		public RectTransform notificationListBox;

		private List<NotificationElementGUI> notificationList;

		public string msgUnknownGamepadConnected;

		public string msgKnownGamepadConnected;

		public string msgGamepadDisconnected;

		public string msgGamepadActivated;

		public string msgGamepadDisactivated;

		public Sprite iconUnknownGamepadConnected;

		public Sprite iconKnownGamepadConnected;

		public Sprite iconGamepadDisconnected;

		public Sprite iconGamepadActivated;

		public Sprite iconGamepadDisactivated;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnGamepadConnected(GamepadManager.Gamepad gamepad)
		{
		}

		private void OnGamepadActivated(GamepadManager.Gamepad gamepad)
		{
		}

		private void OnGamepadDisconnected(GamepadManager.Gamepad gamepad, GamepadManager.DisconnectionReason reason)
		{
		}

		private void OnGamepadDisactivated(GamepadManager.Gamepad gamepad, GamepadManager.DisconnectionReason reason)
		{
		}

		private void AddNotification(string msg, Sprite icon)
		{
		}

		private void SortNotifications()
		{
		}
	}
}
