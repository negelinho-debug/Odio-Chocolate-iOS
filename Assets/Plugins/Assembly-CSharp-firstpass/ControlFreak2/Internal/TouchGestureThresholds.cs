using System;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class TouchGestureThresholds
	{
		public float tapMoveThreshCm;

		public float tapPosThreshCm;

		public float dragThreshCm;

		public float scrollThreshCm;

		public float scrollMagnetFactor;

		public float swipeSegLenCm;

		public float swipeJoystickRadCm;

		public float tapMaxDur;

		public float multiTapMaxTimeGap;

		public float longPressMinTime;

		public float longTapMaxDuration;

		private float _tapMoveThreshPx;

		private float _tapPosThreshPx;

		private float _dragThreshPx;

		private float _swipeSegLenPx;

		private float _swipeJoystickRadPx;

		private float _scrollThreshPx;

		private float storedDpi;

		public float tapMoveThreshPx => 0f;

		public float tapMoveThreshPxSq => 0f;

		public float tapPosThreshPx => 0f;

		public float tapPosThreshPxSq => 0f;

		public float dragThreshPx => 0f;

		public float dragThreshPxSq => 0f;

		public float swipeSegLenPx => 0f;

		public float swipeSegLenPxSq => 0f;

		public float swipeJoystickRadPx => 0f;

		public float swipeJoystickRadPxSq => 0f;

		public float scrollThreshPx => 0f;

		public float scrollThreshPxSq => 0f;

		public void Recalc(float dpi)
		{
		}

		protected virtual void OnRecalc(float dpcm)
		{
		}
	}
}
