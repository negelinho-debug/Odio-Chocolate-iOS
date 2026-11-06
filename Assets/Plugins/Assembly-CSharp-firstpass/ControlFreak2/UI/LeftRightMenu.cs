using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ControlFreak2.UI
{
	public class LeftRightMenu : Selectable
	{
		public delegate void OptionSwitchCallback(int dir);

		public Button buttonLeft;

		public Button buttonRight;

		public Button buttonBack;

		public RectTransform contentPlaceholder;

		public Text titleText;

		public Action onBackPressed;

		public OptionSwitchCallback onOptionSwitch;

		public RectTransform[] optionItems;

		public override void OnSelect(BaseEventData data)
		{
		}

		public override void OnDeselect(BaseEventData data)
		{
		}

		public override void OnMove(AxisEventData data)
		{
		}

		public int GetItemCount()
		{
			return 0;
		}

		public void SetItemActive(int id)
		{
		}

		public void SetTitle(string title)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnSwitch(int dir)
		{
		}

		private void OnBackPressed()
		{
		}

		private void OnLeftPressed()
		{
		}

		private void OnRightPressed()
		{
		}
	}
}
