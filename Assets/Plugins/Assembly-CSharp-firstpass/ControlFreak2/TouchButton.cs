using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public class TouchButton : DynamicTouchControl, IBindingContainer
	{
		public enum ToggleOnAction
		{
			OnPress = 0,
			OnRelease = 1
		}

		public enum ToggleOffAction
		{
			OnPress = 0,
			OnRelease = 1,
			OnTimeout = 2
		}

		public bool toggle;

		public ToggleOnAction toggleOnAction;

		public ToggleOffAction toggleOffAction;

		public bool toggleOffWhenHiding;

		public bool autoToggleOff;

		public float autoToggleOffTimeOut;

		public bool linkToggleToRigSwitch;

		public string toggleRigSwitchName;

		private int toggleRigSwitchId;

		public DigitalBinding pressBinding;

		public DigitalBinding toggleOnlyBinding;

		public bool emulateTouchPressure;

		public AxisBinding touchPressureBinding;

		private bool toggledCur;

		private bool toggledPrev;

		private bool curTouchToggledOn;

		private float elapsedSinceToggled;

		public bool Toggled()
		{
			return false;
		}

		public bool JustToggled()
		{
			return false;
		}

		public bool JustUntoggled()
		{
			return false;
		}

		public bool PressedOrToggled()
		{
			return false;
		}

		protected override void OnInitControl()
		{
		}

		public override void ResetControl()
		{
		}

		protected override void OnUpdateControl()
		{
		}

		public void ChangeToggleState(bool toggleState, bool syncRigSwitch = true)
		{
		}

		private void SyncRigState()
		{
		}

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, Object undoObject, string parentMenuPath)
		{
		}

		protected override bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		public override void ReleaseAllTouches()
		{
		}
	}
}
