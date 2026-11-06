using System;

namespace ControlFreak2
{
	public class DynamicRegion : TouchControl
	{
		[NonSerialized]
		private DynamicTouchControl targetControl;

		public DynamicTouchControl GetTargetControl()
		{
			return null;
		}

		public void SetTargetControl(DynamicTouchControl targetControl)
		{
		}

		protected override void OnInitControl()
		{
		}

		protected override void OnUpdateControl()
		{
		}

		protected override void OnDestroyControl()
		{
		}

		public override void ResetControl()
		{
		}

		public override void ReleaseAllTouches()
		{
		}

		public override bool OnTouchStart(TouchObject touch, TouchControl sender, TouchStartType touchStartType)
		{
			return false;
		}

		public override bool OnTouchEnd(TouchObject touch, TouchEndType touchEndType)
		{
			return false;
		}

		public override bool OnTouchMove(TouchObject touch)
		{
			return false;
		}

		public override bool OnTouchPressureChange(TouchObject touch)
		{
			return false;
		}

		public override bool CanBeTouchedDirectly(TouchObject touchObj)
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

		public override bool CanBeActivatedByOtherControl(TouchControl c, TouchObject touchObj)
		{
			return false;
		}
	}
}
