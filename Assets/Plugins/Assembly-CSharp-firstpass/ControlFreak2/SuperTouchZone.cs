using System;
using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	[ExecuteInEditMode]
	public class SuperTouchZone : TouchControl
	{
		public enum GestureDetectionOrder
		{
			TwistPinchSwipe = 0,
			TwistSwipePinch = 1,
			PinchTwistSwipe = 2,
			PinchSwipeTwist = 3,
			SwipeTwistPinch = 4,
			SwipePinchTwist = 5
		}

		public enum EmuMouseAxis
		{
			X = 0,
			Y = 1
		}

		protected class FingerState
		{
			public SuperTouchZone zone;

			public TouchObject touchObj;

			public TouchStartType touchStartType;

			public int emuTouchId;

			public TouchGestureBasicState touchScreen;

			public TouchGestureBasicState touchOriented;

			public bool IsActive => false;

			public FingerState(SuperTouchZone zone)
			{
			}

			public bool IsControlledByMouse()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Update()
			{
			}

			public bool OnTouchStart(TouchObject touchObj, float delay, TouchStartType touchStartType)
			{
				return false;
			}

			public bool OnTouchEnd(TouchObject touchObj, TouchEndType touchEndType)
			{
				return false;
			}

			public bool OnTouchMove(TouchObject touchObj)
			{
				return false;
			}

			public bool OnTouchPressureChange(TouchObject touchObj)
			{
				return false;
			}

			public void ReleaseTouch(bool cancel)
			{
			}
		}

		[Serializable]
		public class MultiFingerTouchConfig
		{
			public TouchGestureStateBinding binding;

			public bool driveOtherControl;

			public TouchControl controlToDriveOnRawPress;

			public TouchControl controlToDriveOnNormalPress;

			public TouchControl controlToDriveOnLongPress;

			public TouchControl controlToDriveOnNormalPressSwipe;

			public TouchControl controlToDriveOnNormalPressSwipeU;

			public TouchControl controlToDriveOnNormalPressSwipeR;

			public TouchControl controlToDriveOnNormalPressSwipeD;

			public TouchControl controlToDriveOnNormalPressSwipeL;

			public TouchControl controlToDriveOnLongPressSwipe;

			public TouchControl controlToDriveOnLongPressSwipeU;

			public TouchControl controlToDriveOnLongPressSwipeR;

			public TouchControl controlToDriveOnLongPressSwipeD;

			public TouchControl controlToDriveOnLongPressSwipeL;

			public TouchGestureConfig touchConfig;

			public JoystickConfig swipeJoyConfig;
		}

		protected class MultiFingerTouch
		{
			private SuperTouchZone zone;

			public TouchGestureState touchScreen;

			public TouchGestureState touchOriented;

			public float quietModeElapsed;

			private FingerState[] fingers;

			public bool active;

			public bool quietMode;

			private Vector2 posStartScreen;

			private Vector2 posStartOriented;

			private Vector2 posCurScreen;

			private Vector2 posCurOriented;

			private bool controlledByMouse;

			private JoystickState swipeJoyState;

			private MultiFingerTouchConfig config;

			private TouchObject drivingTouch;

			public MultiFingerTouch(int fingerCount, SuperTouchZone zone)
			{
			}

			public void Init(MultiFingerTouchConfig config)
			{
			}

			public int GetFingerCount()
			{
				return 0;
			}

			public FingerState GetFinger(int i)
			{
				return null;
			}

			public bool IsActive()
			{
				return false;
			}

			public bool IsQuiet()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void EndDrivingTouch(bool cancel)
			{
			}

			public void SyncToRig()
			{
			}

			public void Start(FingerState[] fingers, Vector2 startScreenPos, Vector2 startOrientedPos, bool quietMode, float quietAlreadyElapsed)
			{
			}

			public void End(bool cancel)
			{
			}

			public void EndAndReport()
			{
			}

			public void SetPos(Vector2 screenPos, Vector2 orientedPos)
			{
			}

			private bool IsPotentialTapPossible()
			{
				return false;
			}

			public void CancelTap()
			{
			}

			public void DisableTapUntilRelease()
			{
			}

			public void StartOfficially()
			{
			}

			public void Update()
			{
			}

			private void StartDrivingControl(TouchControl c)
			{
			}
		}

		private class EmulatedFingerObject : TouchObject
		{
			public Vector2 emuPos;

			public SuperTouchZone parentZone;

			public EmulatedFingerObject(SuperTouchZone parentZone)
			{
			}
		}

		private class EmulatedFingerSystem
		{
			public EmulatedFingerObject[] fingers;

			private SuperTouchZone zone;

			private TouchObject mouseTouchObj;

			private Vector2 lastMousePos;

			private int curFingerNum;

			private Vector2 centerPos;

			private float twistCur;

			private float pinchDistCur;

			public EmulatedFingerSystem(SuperTouchZone zone)
			{
			}

			public void EndMouseAndTouches(bool cancel)
			{
			}

			public void EndTouches(bool cancel)
			{
			}

			public bool OnSystemTouchStart(TouchObject touchObj, TouchControl sender, TouchStartType touchStartType)
			{
				return false;
			}

			public bool OnSystemTouchEnd(TouchObject touchObj, TouchEndType touchEndType)
			{
				return false;
			}

			public bool OnSystemTouchMove(TouchObject touchObj)
			{
				return false;
			}

			public void StartTouches(int num, Vector2 center, bool isMouse)
			{
			}

			public void Update()
			{
			}

			public void DrawMarkers()
			{
			}

			private Vector2 GetFingerPos(int fingerId)
			{
				return default;
			}

			private float GetFingerAngle(int fingerId)
			{
				return 0f;
			}
		}

		public MultiTouchGestureThresholds customThresh;

		public int maxFingers;

		public float touchSmoothing;

		public bool disableTouchMarkers;

		public bool strictMultiTouch;

		public float strictMultiTouchTime;

		public bool freezeTwistWhenTooClose;

		public bool noPinchAfterDrag;

		public bool noPinchAfterTwist;

		public bool noTwistAfterDrag;

		public bool noTwistAfterPinch;

		public bool noDragAfterPinch;

		public bool noDragAfterTwist;

		public bool startPinchWhenTwisting;

		public bool startPinchWhenDragging;

		public bool startDragWhenPinching;

		public bool startDragWhenTwisting;

		public bool startTwistWhenDragging;

		public bool startTwistWhenPinching;

		public GestureDetectionOrder gestureDetectionOrder;

		private MultiFingerTouch[] multiFingerTouch;

		public MultiFingerTouchConfig[] multiFingerConfigs;

		private FingerState[] fingers;

		private FingerState[] fingersOrdered;

		private int rawFingersPressedCur;

		private int rawFingersPressedPrev;

		private bool dontAllowNewFingers;

		private bool waitingForMoreFingers;

		private float elapsedSinceFirstTouch;

		private bool pinchMoved;

		private bool pinchJustMoved;

		private bool twistMoved;

		private bool twistJustMoved;

		private float pinchDistQuietInitial;

		private float pinchDistInitial;

		private float pinchDistCur;

		private float pinchDistPrev;

		private float twistAngleQuietInitial;

		private float twistAngleInitial;

		private float twistAngleCur;

		private float twistAnglePrev;

		private int twistScrollPrev;

		private int twistScrollCur;

		private int pinchScrollPrev;

		private int pinchScrollCur;

		public const int MAX_FINGERS = 3;

		private const float MIN_TWIST_FINGER_DIST_SQ = 0.1f;

		private const float MIN_PINCH_DIST = 0.1f;

		public EmuTouchBinding separateFingersAsEmuTouchesBinding;

		public AnalogConfig twistAnalogConfig;

		public AnalogConfig pinchAnalogConfig;

		public AxisBinding twistAnalogBinding;

		public AxisBinding twistDeltaBinding;

		public DigitalBinding twistRightDigitalBinding;

		public DigitalBinding twistLeftDigitalBinding;

		public ScrollDeltaBinding pinchScrollDeltaBinding;

		public ScrollDeltaBinding twistScrollDeltaBinding;

		public AxisBinding pinchAnalogBinding;

		public AxisBinding pinchDeltaBinding;

		public DigitalBinding pinchDigitalBinding;

		public DigitalBinding spreadDigitalBinding;

		public bool emuWithKeys;

		public KeyCode emuKeyOneFinger;

		public KeyCode emuKeyTwoFingers;

		public KeyCode emuKeyThreeFingers;

		public KeyCode emuKeySwipeU;

		public KeyCode emuKeySwipeR;

		public KeyCode emuKeySwipeD;

		public KeyCode emuKeySwipeL;

		public KeyCode emuKeyTwistR;

		public KeyCode emuKeyTwistL;

		public KeyCode emuKeyPinch;

		public KeyCode emuKeySpread;

		public KeyCode emuMouseTwoFingersKey;

		public KeyCode emuMouseTwistKey;

		public KeyCode emuMousePinchKey;

		public KeyCode emuMouseThreeFingersKey;

		public EmuMouseAxis emuMousePinchAxis;

		public EmuMouseAxis emuMouseTwistAxis;

		public float emuKeySwipeSpeed;

		public float emuKeyPinchSpeed;

		public float emuKeyTwistSpeed;

		public float mouseEmuTwistScreenFactor;

		private int multiFingerCountCur;

		private int multiFingerCountPrev;

		private const float MIN_EMU_FINGER_DIST_FACTOR = 0.1f;

		private const float MAX_EMU_FINGER_DIST_FACTOR = 0.9f;

		private EmulatedFingerSystem emulatedFingers;

		protected override void OnDestroyControl()
		{
		}

		protected override void OnInitControl()
		{
		}

		public override void ResetControl()
		{
		}

		public bool PressedRaw(int fingerCount)
		{
			return false;
		}

		public bool JustPressedRaw(int fingerCount)
		{
			return false;
		}

		public bool JustReleasedRaw(int fingerCount)
		{
			return false;
		}

		public bool PressedNormal(int fingerCount)
		{
			return false;
		}

		public bool JustPressedNormal(int fingerCount)
		{
			return false;
		}

		public bool JustReleasedNormal(int fingerCount)
		{
			return false;
		}

		public bool PressedLong(int fingerCount)
		{
			return false;
		}

		public bool JustPressedLong(int fingerCount)
		{
			return false;
		}

		public bool JustReleasedLong(int fingerCount)
		{
			return false;
		}

		public bool JustTapped(int fingerCount, int howManyTimes)
		{
			return false;
		}

		public bool JustLongTapped(int fingerCount)
		{
			return false;
		}

		public bool SwipeActive(int fingerCount)
		{
			return false;
		}

		public bool SwipeJustActivated(int fingerCount)
		{
			return false;
		}

		public Vector2 GetCurPos(int fingerCount)
		{
			return default;
		}

		public Vector2 GetStartPos(int fingerCount)
		{
			return default;
		}

		public Vector2 GetTapPos(int fingerCount)
		{
			return default;
		}

		public Vector2 GetRawSwipeVector(int fingerCount)
		{
			return default;
		}

		public Vector2 GetRawSwipeDelta(int fingerCount)
		{
			return default;
		}

		public Vector2 GetUnconstrainedSwipeVector(int fingerCount)
		{
			return default;
		}

		public Vector2 GetUnconstrainedSwipeDelta(int fingerCount)
		{
			return default;
		}

		public Vector2 GetSwipeVector(int fingerCount)
		{
			return default;
		}

		public Vector2 GetSwipeDelta(int fingerCount)
		{
			return default;
		}

		public Dir GetSwipeDir(int fingerCount)
		{
			return Dir.N;
		}

		public Vector2 GetScroll(int fingerCount)
		{
			return default;
		}

		public Vector2 GetScrollDelta(int fingerCount)
		{
			return default;
		}

		public bool PinchActive()
		{
			return false;
		}

		public bool PinchJustActivated()
		{
			return false;
		}

		public float GetPinchScale()
		{
			return 0f;
		}

		public float GetPinchScaleDelta()
		{
			return 0f;
		}

		public float GetPinchDist()
		{
			return 0f;
		}

		public float GetPinchDistDelta()
		{
			return 0f;
		}

		public bool TwistActive()
		{
			return false;
		}

		public bool TwistJustActivated()
		{
			return false;
		}

		public float GetTwist()
		{
			return 0f;
		}

		public float GetTwistDelta()
		{
			return 0f;
		}

		public int GetTwistScrollDelta()
		{
			return 0;
		}

		public int GetPinchScrollDelta()
		{
			return 0;
		}

		public float GetReleasedDuration(int fingerCount)
		{
			return 0f;
		}

		public void SetTouchSmoothing(float smPow)
		{
		}

		protected MultiFingerTouch GetMultiFingerTouch(int fingerCount)
		{
			return null;
		}

		public MultiTouchGestureThresholds GetThresholds()
		{
			return null;
		}

		private Vector2 GetAveragedFingerPos(FingerState[] fingers, int count, bool orientedSpace, bool useSmoothPos)
		{
			return default;
		}

		private void StartMultiFingerTouch(int fingerNum, FingerState[] fingers, Vector2 startScreenPos, Vector2 startOrientedPos, bool quietMode)
		{
		}

		private void CancelTapsOnMultiFingersOtherThan(int howManyFingers)
		{
		}

		protected override void OnUpdateControl()
		{
		}

		private float GetTwoFingerDist()
		{
			return 0f;
		}

		private float GetTwoFingerAngle(float defaultAngle)
		{
			return 0f;
		}

		private void UpdateTwistAndPinch()
		{
		}

		private void UpdateTwistAndPinch(bool lastUpdateMode)
		{
		}

		private void OnPinchStart()
		{
		}

		private void OnTwistStart()
		{
		}

		private void OnTwoFingerDragStart()
		{
		}

		private FingerState GetFirstUnusedFinger(TouchObject newTouchObj)
		{
			return null;
		}

		private FingerState GetFingerByTouch(TouchObject touchObj)
		{
			return null;
		}

		public override bool CanBeActivatedByOtherControl(TouchControl c, TouchObject touchObj)
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

		public override void ReleaseAllTouches()
		{
		}

		protected override bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		public override bool IsUsingKeyForEmulation(KeyCode key)
		{
			return false;
		}

		protected override bool OnIsEmulatingTouches()
		{
			return false;
		}

		protected override bool OnIsEmulatingMousePosition()
		{
			return false;
		}

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		public void DrawMarkerGUI()
		{
		}

		private void InitEmulatedFingers()
		{
		}

		private void ReleaseEmulatedFingers(bool cancel)
		{
		}

		private void UpdateEmulatedFingers()
		{
		}
	}
}
