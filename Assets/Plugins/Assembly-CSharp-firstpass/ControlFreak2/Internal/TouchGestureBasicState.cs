using UnityEngine;

namespace ControlFreak2.Internal
{
	public class TouchGestureBasicState
	{
		protected bool controlledByMouse;

		protected bool pollStartedByMouse;

		protected bool isPressureSensitive;

		protected bool pollStartPressureSensitive;

		protected float pressureCur;

		protected float pollStartPressure;

		protected bool pressCur;

		protected bool pressPrev;

		protected float releasedDur;

		protected float elapsedSincePress;

		protected float elapsedSinceRelease;

		protected float curDist;

		protected float releasedDist;

		protected Vector2 posCurRaw;

		protected Vector2 posPrevRaw;

		protected Vector2 posCurSmooth;

		protected Vector2 posPrevSmooth;

		protected Vector2 posNext;

		protected Vector2 posStart;

		protected float elapsedSinceLastMove;

		protected Vector2 relStartPos;

		protected Vector2 relEndPos;

		protected Vector2 relExtremeDistPerAxis;

		protected float relDur;

		protected float relExtremeDistSq;

		protected float relDistSq;

		protected float extremeDistCurSq;

		protected float extremeDistPrevSq;

		protected Vector2 extremeDistPerAxisCur;

		protected Vector2 extremeDistPerAxisPrev;

		protected float smoothingTime;

		protected bool prepollState;

		protected bool pollStartedPress;

		protected bool pollReleased;

		protected bool pollReleasedAsCancel;

		protected float pollCurPressure;

		protected Vector2 pollCurPos;

		protected Vector2 pollPressStartPos;

		protected Vector2 pollReleasePos;

		protected float pollPressStartDelay;

		public virtual void Reset()
		{
		}

		public void SetSmoothingTime(float smt)
		{
		}

		public bool PressedRaw()
		{
			return false;
		}

		public bool JustPressedRaw()
		{
			return false;
		}

		public bool JustReleasedRaw()
		{
			return false;
		}

		public Vector2 GetCurPosRaw()
		{
			return default;
		}

		public Vector2 GetCurPosSmooth()
		{
			return default;
		}

		public Vector2 GetStartPos()
		{
			return default;
		}

		public Vector2 GetReleasedStartPos()
		{
			return default;
		}

		public Vector2 GetReleasedEndPos()
		{
			return default;
		}

		public Vector2 GetSwipeVecRaw()
		{
			return default;
		}

		public Vector2 GetSwipeVecSmooth()
		{
			return default;
		}

		public Vector2 GetDeltaVecRaw()
		{
			return default;
		}

		public Vector2 GetDeltaVecSmooth()
		{
			return default;
		}

		public bool Moved(float threshSquared)
		{
			return false;
		}

		public bool JustMoved(float threshSquared)
		{
			return false;
		}

		public bool IsControlledByMouse()
		{
			return false;
		}

		public bool IsPressureSensitive()
		{
			return false;
		}

		public float GetPressure()
		{
			return 0f;
		}

		public virtual void Update()
		{
		}

		protected void InternalUpdate()
		{
		}

		protected void InternalPostUpdate()
		{
		}

		public void OnTouchStart(Vector2 startPos, Vector2 curPos, float timeElapsed, TouchObject touchObj)
		{
		}

		public void OnTouchStart(Vector2 startPos, Vector2 curPos, float timeElapsed, bool controlledByMouse, bool isPressureSensitive, float pressure)
		{
		}

		public void OnTouchPressureChange(float pressure)
		{
		}

		public void OnTouchMove(Vector2 pos)
		{
		}

		public void OnTouchMoveByDelta(Vector2 delta)
		{
		}

		public void OnTouchEnd(Vector2 pos, bool cancel)
		{
		}

		public void OnTouchEnd(bool cancel)
		{
		}

		protected virtual void OnPress(Vector2 startPos, Vector2 pos, float delay, bool startedByMouse, bool isPressureSensitive = false, float pressure = 1f)
		{
		}

		protected virtual void OnRelease(Vector2 pos, bool cancel)
		{
		}

		protected virtual void CheckMovement(bool itsFinalUpdate)
		{
		}
	}
}
