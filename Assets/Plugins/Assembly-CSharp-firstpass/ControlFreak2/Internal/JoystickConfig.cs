using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class JoystickConfig : AnalogConfig
	{
		public enum ClampMode
		{
			Circle = 0,
			Square = 1
		}

		public enum StickMode
		{
			Analog = 0,
			Digital4 = 1,
			Digital8 = 2
		}

		public enum DigitalDetectionMode
		{
			Touch = 0,
			Joystick = 1
		}

		public ClampMode clampMode;

		public bool perAxisDeadzones;

		public StickMode stickMode;

		public DirectionState.OriginalDirResetMode originalDirResetMode;

		public float angularMagnet;

		public DigitalDetectionMode digitalDetectionMode;

		public bool blockX;

		public bool blockY;

		private const float MIN_SAFE_TILT = 0.01f;

		private const float MIN_SAFE_TILT_SQ = 0.0001f;

		private const float MIN_DIGITAL_DEADZONE = 0.05f;

		private const float MAX_DIGITAL_DEADZONE = 0.9f;

		private const float MIN_ANALOG_DEADZONE = 0f;

		private const float MAX_ANALOG_DEADZONE = 0.9f;

		private const float MIN_ANALOG_ENDZONE = 0.1f;

		private const float MAX_ANALOG_ENDZONE = 1f;

		private const float MAX_DIGI_LEAVE_MARGIN = 0.4f;

		private const float MIN_DIGI_LEAVE_THRESH = 0.1f;

		private const float DIGI_MAX_4WAY_ANGLE_MAGNET = 22.5f;

		private const float DIGI_MAX_8WAY_ANGLE_MAGNET = 11.75f;

		public Vector2 AnimateDirToAnalogVec(Vector2 curVec, Dir targetDir)
		{
			return default;
		}

		public Vector2 ClampNormalizedPos(Vector2 np)
		{
			return default;
		}
	}
}
