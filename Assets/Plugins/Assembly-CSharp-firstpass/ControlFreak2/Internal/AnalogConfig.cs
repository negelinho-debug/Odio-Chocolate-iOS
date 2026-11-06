using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class AnalogConfig
	{
		public float analogDeadZone;

		public float analogEndZone;

		public float analogRangeStartValue;

		public float digitalEnterThresh;

		public float digitalLeaveThresh;

		public float digitalToAnalogPressSpeed;

		public float digitalToAnalogReleaseSpeed;

		public const float DIGITAL_TO_ANALOG_SMOOTHING_TIME = 0.2f;

		public bool useRamp;

		public AnimationCurve ramp;

		private const float MIN_DIGITAL_DEADZONE = 0.05f;

		private const float MAX_DIGITAL_DEADZONE = 0.9f;

		private const float MIN_ANALOG_DEADZONE = 0f;

		private const float MAX_ANALOG_DEADZONE = 0.9f;

		private const float MIN_ANALOG_ENDZONE = 0.1f;

		private const float MAX_ANALOG_ENDZONE = 1f;

		private const float MAX_DIGI_LEAVE_MARGIN = 0.1f;

		private const float MIN_DIGI_LEAVE_THRESH = 0.1f;

		public float GetAnalogVal(float rawVal)
		{
			return 0f;
		}

		public int GetSignedDigitalVal(float rawVal, int prevDigiVal)
		{
			return 0;
		}

		public bool GetDigitalVal(float rawVal, bool prevDigiVal)
		{
			return false;
		}

		public float AnimateDigitalToAnalog(float curVal, float targetVal, bool pressed)
		{
			return 0f;
		}
	}
}
