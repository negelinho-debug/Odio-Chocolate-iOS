using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class TiltState
	{
		public Vector2 analogRange;

		private Vector3 curVec;

		private Vector3 nextFrVec;

		private Vector2 anglesNeutral;

		private Vector2 anglesAbsCur;

		private Vector2 anglesAbsRaw;

		private Vector2 anglesCur;

		private Vector2 analogCur;

		private bool calibrated;

		private bool setRefAnglesFlag;

		public void Reset()
		{
		}

		public void InternalApplyVector(Vector3 v)
		{
		}

		public static bool IsAvailable()
		{
			return false;
		}

		public void Calibate()
		{
		}

		public bool IsCalibrated()
		{
			return false;
		}

		public void Update()
		{
		}

		public Vector2 GetAngles()
		{
			return default;
		}

		public Vector2 GetAnalog()
		{
			return default;
		}
	}
}
