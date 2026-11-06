using UnityEngine;

namespace ControlFreak2.Internal
{
	public class JoystickState
	{
		public JoystickConfig config;

		private float tilt;

		private float angle;

		private float safeAngle;

		private Vector2 pos;

		private Vector2 posRaw;

		private Vector2 normDir;

		private DirectionState dirState;

		private DirectionState dirState4;

		private DirectionState dirState8;

		private Dir dirLastNonNeutral4;

		private Dir dirLastNonNeutral8;

		private Vector2 nextFramePos;

		private bool nextFrameDigiU;

		private bool nextFrameDigiR;

		private bool nextFrameDigiD;

		private bool nextFrameDigiL;

		private Vector2 digiInputAnalogVecCur;

		private const float MIN_SAFE_TILT = 0.01f;

		private const float MIN_SAFE_TILT_SQ = 0.0001f;

		public JoystickState(JoystickConfig config)
		{
		}

		public Vector2 GetVector()
		{
			return default;
		}

		public Vector2 GetVectorRaw()
		{
			return default;
		}

		public Vector2 GetVectorEx(bool squareMode)
		{
			return default;
		}

		public Vector2 GetVectorRawEx(bool squareMode)
		{
			return default;
		}

		public float GetAngle()
		{
			return 0f;
		}

		public float GetTilt()
		{
			return 0f;
		}

		public DirectionState GetDirState()
		{
			return null;
		}

		public DirectionState GetDirState4()
		{
			return null;
		}

		public DirectionState GetDirState8()
		{
			return null;
		}

		public Dir GetDir()
		{
			return Dir.N;
		}

		public Dir GetDir4()
		{
			return Dir.N;
		}

		public Dir GetDir8()
		{
			return Dir.N;
		}

		public bool JustPressedDir(Dir dir)
		{
			return false;
		}

		public bool JustPressedDir4(Dir dir)
		{
			return false;
		}

		public bool JustPressedDir8(Dir dir)
		{
			return false;
		}

		public bool JustReleasedDir(Dir dir)
		{
			return false;
		}

		public bool JustReleasedDir4(Dir dir)
		{
			return false;
		}

		public bool JustReleasedDir8(Dir dir)
		{
			return false;
		}

		public void SetConfig(JoystickConfig config)
		{
		}

		public void Reset()
		{
		}

		public void ApplyUnclampedVec(Vector2 v)
		{
		}

		public void ApplyClampedVec(Vector2 v, JoystickConfig.ClampMode clampMode)
		{
		}

		public void ApplyDir(Dir dir)
		{
		}

		public void ApplyDigital(bool digiU, bool digiR, bool digiD, bool digiL)
		{
		}

		public void ApplyState(JoystickState state)
		{
		}

		public void Update()
		{
		}
	}
}
