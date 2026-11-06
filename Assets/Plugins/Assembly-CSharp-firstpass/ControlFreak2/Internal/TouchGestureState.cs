using UnityEngine;

namespace ControlFreak2.Internal
{
	public class TouchGestureState : TouchGestureBasicState
	{
		private float elapsedSinceLastTapCandidate;

		private Vector2 segmentOrigin;

		private Vector2 constrainedVecCur;

		private Vector2 constrainedVecPrev;

		private Vector2 scrollVecCur;

		private Vector2 scrollVecPrev;

		private TouchGestureConfig.DirConstraint swipeConstraint;

		private TouchGestureConfig.DirConstraint swipeDirConstraint;

		private TouchGestureConfig.DirConstraint scrollConstraint;

		private bool cleanPressCur;

		private bool cleanPressPrev;

		private bool holdPressCur;

		private bool holdPressPrev;

		private Vector2 lastDirOrigin;

		public TouchGestureThresholds thresh;

		public TouchGestureConfig config;

		private bool moved;

		private bool justMoved;

		private bool nonStaticFlag;

		private bool cancelTapFlag;

		private bool disableTapUntilReleaseFlag;

		private bool flushTapsFlag;

		private bool holdDelayedEvents;

		private bool justTapped;

		private bool justLongTapped;

		private Vector2 tapPos;

		private int tapCount;

		private DirectionState swipeDirState;

		private DirectionState swipeDirState4;

		private DirectionState swipeDirState8;

		private bool blockDrag;

		private Vector2 tapFirstPos;

		private int tapCandidateCount;

		private int lastReportedTapCount;

		private bool tapCandidateReleased;

		private void BasicConstructor(TouchGestureThresholds thresholds, TouchGestureConfig config)
		{
		}

		public TouchGestureState(TouchGestureThresholds thresholds, TouchGestureConfig config)
		{
		}

		public TouchGestureState()
		{
		}

		public void SetThresholds(TouchGestureThresholds thresh)
		{
		}

		public void SetConfig(TouchGestureConfig config)
		{
		}

		public override void Reset()
		{
		}

		public bool PressedNormal()
		{
			return false;
		}

		public bool JustPressedNormal()
		{
			return false;
		}

		public bool JustReleasedNormal()
		{
			return false;
		}

		public bool PressedLong()
		{
			return false;
		}

		public bool JustPressedLong()
		{
			return false;
		}

		public bool JustReleasedLong()
		{
			return false;
		}

		public bool JustTapped(int howManyTimes)
		{
			return false;
		}

		public Vector2 GetTapPos()
		{
			return default;
		}

		public bool JustLongTapped()
		{
			return false;
		}

		public DirectionState GetSwipeDirState()
		{
			return null;
		}

		public DirectionState GetSwipeDirState4()
		{
			return null;
		}

		public DirectionState GetSwipeDirState8()
		{
			return null;
		}

		public Vector2 GetSegmentOrigin()
		{
			return default;
		}

		public bool JustSwiped()
		{
			return false;
		}

		public bool Swiped()
		{
			return false;
		}

		public Vector2 GetConstrainedSwipeVec()
		{
			return default;
		}

		public Vector2 GetConstrainedDeltaVec()
		{
			return default;
		}

		public Vector2 GetScroll()
		{
			return default;
		}

		public Vector2 GetScrollDelta()
		{
			return default;
		}

		public float GetReleasedDurationRaw()
		{
			return 0f;
		}

		public void ForceSwipe()
		{
		}

		public void BlockSwipe()
		{
		}

		public void HoldDelayedEvents(bool holdThemForNow)
		{
		}

		public void CancelTap()
		{
		}

		public void DisableTapUntilRelease()
		{
		}

		public void FlushRegisteredTaps()
		{
		}

		public void MarkAsNonStatic()
		{
		}

		public override void Update()
		{
		}

		protected override void OnRelease(Vector2 pos, bool cancel)
		{
		}

		protected override void OnPress(Vector2 startPos, Vector2 pos, float delay, bool startedByMouse, bool isPressureSensitive, float pressure)
		{
		}

		private void OnSwipeStart()
		{
		}

		protected override void CheckMovement(bool itsFinalUpdate)
		{
		}

		private void ResetTapState()
		{
		}

		public bool IsPotentialTap()
		{
			return false;
		}

		public bool IsPotentialLongPress()
		{
			return false;
		}

		private void CheckTap(bool lastUpdate)
		{
		}

		private void ReportTap()
		{
		}

		private void ReportTap(bool reset)
		{
		}
	}
}
