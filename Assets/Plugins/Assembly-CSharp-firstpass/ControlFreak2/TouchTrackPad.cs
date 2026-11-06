using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public class TouchTrackPad : TouchControl
	{
		public float touchSmoothing;

		public DigitalBinding pressBinding;

		public AxisBinding horzSwipeBinding;

		public AxisBinding vertSwipeBinding;

		public bool emulateTouchPressure;

		public AxisBinding touchPressureBinding;

		private TouchObject touchObj;

		private TouchStartType touchStartType;

		private TouchGestureBasicState touchState;

		public bool Pressed()
		{
			return false;
		}

		public bool JustPressed()
		{
			return false;
		}

		public bool JustReleased()
		{
			return false;
		}

		public bool IsTouchPressureSensitive()
		{
			return false;
		}

		public float GetTouchPressure()
		{
			return 0f;
		}

		public Vector2 GetSwipeDelta()
		{
			return default;
		}

		public void SetTouchSmoothing(float smTime)
		{
		}

		protected override void OnInitControl()
		{
		}

		protected override void OnDestroyControl()
		{
		}

		public override void ResetControl()
		{
		}

		protected override void OnUpdateControl()
		{
		}

		private void SyncRigState()
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

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, Object undoObject, string parentMenuPath)
		{
		}

		public override bool CanBeTouchedDirectly(TouchObject touchObj)
		{
			return false;
		}

		public override bool CanBeActivatedByOtherControl(TouchControl c, TouchObject touchObj)
		{
			return false;
		}

		public override bool CanBeSwipedOverFromNothing(TouchObject touchObj)
		{
			return false;
		}

		public override bool CanBeSwipedOverFromRestrictedList(TouchObject touchObj)
		{
			return false;
		}

		public override bool CanSwipeOverOthers(TouchObject touchObj)
		{
			return false;
		}

		public override void ReleaseAllTouches()
		{
		}

		public override bool OnTouchStart(TouchObject touchObj, TouchControl sender, TouchStartType touchStartType)
		{
			return false;
		}

		public override bool OnTouchEnd(TouchObject touchObj, TouchEndType touchEndType)
		{
			return false;
		}

		public override bool OnTouchMove(TouchObject touchObj)
		{
			return false;
		}

		public override bool OnTouchPressureChange(TouchObject touchObj)
		{
			return false;
		}
	}
}
