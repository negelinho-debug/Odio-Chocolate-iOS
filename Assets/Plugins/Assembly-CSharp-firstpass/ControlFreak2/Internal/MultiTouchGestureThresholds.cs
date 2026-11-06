using System;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class MultiTouchGestureThresholds : TouchGestureThresholds
	{
		public float pinchDistThreshCm;

		public float pinchAnalogRangeCm;

		public float pinchDeltaRangeCm;

		public float pinchDigitalThreshCm;

		public float pinchScrollStepCm;

		public float pinchScrollMagnet;

		public float twistMinDistCm;

		public float twistAngleThresh;

		public float twistAnalogRange;

		public float twistDeltaRange;

		public float twistDigitalThresh;

		public float twistScrollStep;

		public float twistScrollMagnet;

		public float multiFingerTapMaxFingerDistCm;

		private float _pinchDistThreshPx;

		private float _pinchAnalogRangePx;

		private float _pinchDeltaRangePx;

		private float _pinchDigitalThreshPx;

		private float _pinchScrollStepPx;

		private float _twistMinDistPx;

		private float _multiFingerTapMaxFingerDistPx;

		public float pinchDistThreshPx => 0f;

		public float pinchDistThreshPxSq => 0f;

		public float pinchAnalogRangePx => 0f;

		public float pinchAnalogRangePxSq => 0f;

		public float pinchDeltaRangePx => 0f;

		public float pinchDeltaRangePxSq => 0f;

		public float pinchDigitalThreshPx => 0f;

		public float pinchDigitalThreshPxSq => 0f;

		public float pinchScrollStepPx => 0f;

		public float pinchScrollStepPxSq => 0f;

		public float twistMinDistPx => 0f;

		public float twistMinDistPxSq => 0f;

		public float multiFingerTapMaxFingerDistPx => 0f;

		public float multiFingerTapMaxFingerDistPxSq => 0f;

		protected override void OnRecalc(float dpcm)
		{
		}
	}
}
