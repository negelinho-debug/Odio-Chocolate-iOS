using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class TouchGestureStateBinding : InputBindingBase
	{
		public DigitalBinding rawPressBinding;

		public DigitalBinding normalPressBinding;

		public DigitalBinding longPressBinding;

		public DigitalBinding rawTapBinding;

		public DigitalBinding tapBinding;

		public DigitalBinding doubleTapBinding;

		public DigitalBinding longTapBinding;

		public DirectionBinding normalPressSwipeDirBinding;

		public DirectionBinding longPressSwipeDirBinding;

		public AxisBinding normalPressSwipeHorzAxisBinding;

		public AxisBinding normalPressSwipeVertAxisBinding;

		public AxisBinding longPressSwipeHorzAxisBinding;

		public AxisBinding longPressSwipeVertAxisBinding;

		public ScrollDeltaBinding normalPressScrollHorzBinding;

		public ScrollDeltaBinding normalPressScrollVertBinding;

		public ScrollDeltaBinding longPressScrollHorzBinding;

		public ScrollDeltaBinding longPressScrollVertBinding;

		public MousePositionBinding rawPressMousePosBinding;

		public MousePositionBinding normalPressMousePosBinding;

		public MousePositionBinding longPressMousePosBinding;

		public MousePositionBinding tapMousePosBinding;

		public MousePositionBinding doubleTapMousePosBinding;

		public MousePositionBinding longTapMousePosBinding;

		public MousePositionBinding normalPressSwipeMousePosBinding;

		public MousePositionBinding longPressSwipeMousePosBinding;

		public EmuTouchBinding rawPressEmuTouchBinding;

		public EmuTouchBinding normalPressEmuTouchBinding;

		public EmuTouchBinding longPressEmuTouchBinding;

		public JoystickStateBinding normalPressSwipeJoyBinding;

		public JoystickStateBinding longPressSwipeJoyBinding;

		public TouchGestureStateBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(TouchGestureStateBinding b)
		{
		}

		public void SyncTouchState(TouchGestureState screenState, TouchGestureState orientedState, JoystickState swipeJoyState, InputRig rig)
		{
		}

		protected override bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsBoundToKey(KeyCode keyCode, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsEmulatingMousePosition()
		{
			return false;
		}

		protected override bool OnIsEmulatingTouches()
		{
			return false;
		}

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}
	}
}
