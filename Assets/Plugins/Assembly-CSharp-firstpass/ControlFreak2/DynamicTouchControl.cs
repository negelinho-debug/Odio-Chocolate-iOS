using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public abstract class DynamicTouchControl : TouchControl
	{
		public bool fadeOutWhenReleased;

		public bool startFadedOut;

		public float fadeOutTargetAlpha;

		public float fadeInDuration;

		public float fadeOutDelay;

		public float fadeOutDuration;

		public bool centerOnDirectTouch;

		public bool centerOnIndirectTouch;

		public bool centerWhenFollowing;

		public bool stickyMode;

		public bool clampInsideRegion;

		public bool clampInsideCanvas;

		public bool returnToStartingPosition;

		public Vector2 directInitialVector;

		public Vector2 indirectInitialVector;

		public float touchSmoothing;

		public float originSmoothTime;

		private const float ORIGIN_ANIM_MAX_TIME = 0.2f;

		public DynamicRegion targetDynamicRegion;

		protected bool linkedToDynamicRegion;

		protected bool touchStartedByRegion;

		protected TouchStartType touchStartType;

		protected TouchGestureBasicState touchStateOriented;

		protected TouchGestureBasicState touchStateScreen;

		protected TouchGestureBasicState touchStateWorld;

		protected TouchObject touchObj;

		private RectTransform initialRectCopy;

		private Vector3 originPos;

		private Vector3 originStartPos;

		private bool originAnimOn;

		private float originAnimElapsed;

		private bool dynamicIsFadingOut;

		private bool dynamicAlphaAnimOn;

		private bool dynamicWaitingToFadeOut;

		private float dynamicAlphaAnimDur;

		private float dynamicAlphaAnimElapsed;

		private float dynamicFadeOutDelayElapsed;

		private float dynamicAlphaCur;

		private float dynamicAlphaStart;

		private float dynamicAlphaTarget;

		private GameObject initialRectCopyGo;

		private Vector2 initialAnchorMax;

		private Vector2 initialAnchorMin;

		private Vector2 initialOffsetMin;

		private Vector2 initialOffsetMax;

		private Vector2 initialPivot;

		private Vector3 initialAnchoredPosition3D;

		public TouchGestureBasicState TouchStateScreen => null;

		public TouchGestureBasicState TouchStateOriented => null;

		public TouchGestureBasicState TouchStateWorld => null;

		public DynamicTouchControl()
		{
		}

		protected override void OnInitControl()
		{
		}

		public override void ResetControl()
		{
		}

		public override void InvalidateHierarchy()
		{
		}

		public bool Pressed()
		{
			return false;
		}

		public bool JustPressed()
		{
			return false;
		}

		public bool JustReleased()
		{
			return false;
		}

		public bool IsTouchPressureSensitive()
		{
			return false;
		}

		public float GetTouchPressure()
		{
			return 0f;
		}

		public void SetTouchSmoothing(float smTime)
		{
		}

		public void SetTargetDynamicRegion(DynamicRegion targetDynamicRegion)
		{
		}

		public void OnLinkToDynamicRegion(DynamicRegion dynRegion)
		{
		}

		public DynamicRegion GetDynamicRegion()
		{
			return null;
		}

		public bool IsInDynamicMode()
		{
			return false;
		}

		public float GetDynamicAlpha()
		{
			return 0f;
		}

		public override float GetAlpha()
		{
			return 0f;
		}

		private void SetDynamicAlpha(float alpha, float animDur)
		{
		}

		private void DynamicWakeUp(bool animate)
		{
		}

		private void DynamicFadeOut(bool animate)
		{
		}

		private bool CanFadeOut()
		{
			return false;
		}

		private void UpdateDynamicAlpha()
		{
		}

		public override void SetWorldPos(Vector2 pos2D)
		{
		}

		protected void SetOriginPos(Vector3 pos, bool animate)
		{
		}

		protected void SetOriginPos(Vector3 pos)
		{
		}

		protected Vector2 GetOriginOffset()
		{
			return default;
		}

		protected void UpdateOriginAnimation()
		{
		}

		public override void StoreDefaultPos()
		{
		}

		private void SetupInitialRectPosition()
		{
		}

		protected Vector3 GetDefaultPos()
		{
			return default;
		}

		protected override void OnDestroyControl()
		{
		}

		protected override void OnUpdateControl()
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

		public override void ReleaseAllTouches()
		{
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

		public virtual bool CanBeActivatedByDynamicRegion()
		{
			return false;
		}

		public override bool CanBeActivatedByOtherControl(TouchControl c, TouchObject touchObj)
		{
			return false;
		}
	}
}
