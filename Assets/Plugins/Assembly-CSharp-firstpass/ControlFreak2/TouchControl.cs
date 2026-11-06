using System;
using System.Collections.Generic;
using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public abstract class TouchControl : ComponentBase, IBindingContainer
	{
		public enum Shape
		{
			Rectangle = 0,
			Square = 1,
			Circle = 2,
			Ellipse = 3
		}

		public enum SwipeOffMode
		{
			Disabled = 0,
			Enabled = 1,
			OnlyIfSwipedOver = 2
		}

		public enum SwipeOverOthersMode
		{
			Disabled = 0,
			Enabled = 1,
			OnlyIfTouchedDirectly = 2
		}

		public enum TouchStartType
		{
			DirectPress = 0,
			ProxyPress = 1,
			SwipeOver = 2
		}

		public enum TouchEndType
		{
			Release = 0,
			Cancel = 1,
			SwipeOff = 2
		}

		public class Hit
		{
			public TouchControl c;

			public float depth;

			public bool indirectHit;

			public Vector2 localPos;

			public Vector2 closestLocalPos;

			public Vector2 screenPos;

			public Vector2 closestScreenPos;

			public float screenDistSqPx;

			public void Reset()
			{
			}

			public bool IsEmpty()
			{
				return false;
			}

			public void CopyFrom(Hit b)
			{
			}

			public bool IsHigherThan(Hit r)
			{
				return false;
			}
		}

		public class HitPool : ObjectPoolBase<Hit>
		{
			public delegate bool TouchControlFilterFunc(TouchControl c);

			private Hit tempHit;

			public bool HitTestAny(List<TouchControl> controlList, Vector2 screenPos, Camera cam, float fingerRadPx = 0f, TouchControlFilterFunc filter = null)
			{
				return false;
			}

			public int HitTest(List<TouchControl> controlList, Vector2 screenPos, Camera cam, int maxHits = 8, float fingerRadPx = 0f, TouchControlFilterFunc filter = null)
			{
				return 0;
			}

			protected override Hit CreateInternalObject()
			{
				return null;
			}
		}

		public bool ignoreFingerRadius;

		public bool cantBeControlledDirectly;

		public bool shareTouch;

		public bool dontAcceptSharedTouches;

		public bool canBeSwipedOver;

		public bool restictSwipeOverTargets;

		public SwipeOverOthersMode swipeOverOthersMode;

		public SwipeOffMode swipeOffMode;

		public List<TouchControl> swipeOverTargetList;

		public Shape shape;

		[NonSerialized]
		protected List<TouchControlAnimatorBase> animatorList;

		public DisablingConditionSet disablingConditions;

		[NonSerialized]
		private int hidingFlagsCur;

		[NonSerialized]
		private InputRig _rig;

		[NonSerialized]
		private Canvas _canvas;

		[NonSerialized]
		private TouchControlPanel _panel;

		protected const int HIDDEN_BY_USER = 0;

		protected const int HIDDEN_BY_DISABLED_GO = 1;

		protected const int HIDDEN_BY_CONDITIONS = 4;

		protected const int HIDDEN_BY_RIG = 5;

		protected const int HIDDEN_DUE_TO_INACTIVITY = 6;

		protected const int HIDDEN_AND_DISABLED_MASK = -65;

		[NonSerialized]
		private bool isHidden;

		[NonSerialized]
		private bool baseAlphaAnimOn;

		[NonSerialized]
		private float baseAlphaStart;

		[NonSerialized]
		private float baseAlphaEnd;

		[NonSerialized]
		private float baseAlphaCur;

		[NonSerialized]
		private float baseAlphaAnimDur;

		[NonSerialized]
		private float baseAlphaAnimElapsed;

		public InputRig rig
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Canvas canvas
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public TouchControlPanel panel
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public TouchControl()
		{
		}

		protected abstract void OnInitControl();

		protected abstract void OnUpdateControl();

		protected abstract void OnDestroyControl();

		public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		public bool IsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		public bool IsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		public bool IsEmulatingTouches()
		{
			return false;
		}

		public bool IsEmulatingMousePosition()
		{
			return false;
		}

		public virtual bool IsUsingKeyForEmulation(KeyCode key)
		{
			return false;
		}

		protected virtual void OnGetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		protected virtual bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected virtual bool OnIsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		protected virtual bool OnIsEmulatingTouches()
		{
			return false;
		}

		protected virtual bool OnIsEmulatingMousePosition()
		{
			return false;
		}

		public abstract void ResetControl();

		public abstract void ReleaseAllTouches();

		public abstract bool OnTouchStart(TouchObject touch, TouchControl sender, TouchStartType touchStartType);

		public abstract bool OnTouchEnd(TouchObject touch, TouchEndType touchEndType);

		public abstract bool OnTouchMove(TouchObject touch);

		public abstract bool OnTouchPressureChange(TouchObject touch);

		protected bool CheckSwipeOff(TouchObject touchObj, TouchStartType touchStartType)
		{
			return false;
		}

		public virtual bool CanShareTouchWith(TouchControl c)
		{
			return false;
		}

		public abstract bool CanBeSwipedOverFromNothing(TouchObject touchObj);

		protected bool CanBeSwipedOverFromNothingDefault(TouchObject touchObj)
		{
			return false;
		}

		public abstract bool CanBeSwipedOverFromRestrictedList(TouchObject touchObj);

		protected bool CanBeSwipedOverFromRestrictedListDefault(TouchObject touchObj)
		{
			return false;
		}

		public abstract bool CanSwipeOverOthers(TouchObject touchObj);

		protected bool CanSwipeOverOthersDefault(TouchObject touchObj, TouchObject myTouchObj, TouchStartType touchStartType)
		{
			return false;
		}

		public virtual bool CanBeTouchedDirectly(TouchObject touchObj)
		{
			return false;
		}

		public virtual bool CanBeActivatedByOtherControl(TouchControl c, TouchObject touchObj)
		{
			return false;
		}

		public static int CompareByDepth(TouchControl a, TouchControl b)
		{
			return 0;
		}

		public void ShowOrHideControl(bool show, bool noAnim = false)
		{
		}

		public void ShowControl(bool noAnim = false)
		{
		}

		public void HideControl(bool noAnim = false)
		{
		}

		public bool IsHiddenManually()
		{
			return false;
		}

		public void ToggleVisibility(bool noAnim)
		{
		}

		public void ToggleVisibility()
		{
		}

		public bool IsActiveButInvisible()
		{
			return false;
		}

		public bool IsActiveAndVisible()
		{
			return false;
		}

		public bool IsActive()
		{
			return false;
		}

		public virtual void StoreDefaultPos()
		{
		}

		public void SetHidingFlag(int flagBit, bool state)
		{
		}

		public void SyncDisablingConditions(bool skipAnim)
		{
		}

		public void AddAnimator(TouchControlAnimatorBase a)
		{
		}

		public void RemoveAnimator(TouchControlAnimatorBase a)
		{
		}

		public List<TouchControlAnimatorBase> GetAnimatorList()
		{
			return null;
		}

		protected void UpdateAnimators(bool skipAnim)
		{
		}

		private void SyncBaseAlphaToHidingConditions(bool noAnim)
		{
		}

		private void StartAlphaAnim(float targetAlpha, float duration)
		{
		}

		private void UpdateBaseAlpha()
		{
		}

		public float GetBaseAlpha()
		{
			return 0f;
		}

		public virtual float GetAlpha()
		{
			return 0f;
		}

		public Camera GetCamera()
		{
			return null;
		}

		public void SetRig(InputRig rig)
		{
		}

		public void SetTouchControlPanel(TouchControlPanel panel)
		{
		}

		public virtual void InvalidateHierarchy()
		{
		}

		public Vector3 GetWorldPos()
		{
			return default;
		}

		public virtual void SetWorldPos(Vector2 pos2D)
		{
		}

		protected void SetWorldPosRaw(Vector2 pos2D)
		{
		}

		public virtual Rect GetLocalRect()
		{
			return default;
		}

		protected Vector3 ScreenToWorldPos(Vector2 sp, Camera cam)
		{
			return default;
		}

		protected Vector2 WorldToLocalPos(Vector3 wp, Vector2 worldOffset)
		{
			return default;
		}

		protected Vector2 WorldToLocalPos(Vector3 wp)
		{
			return default;
		}

		protected Vector2 ScreenToLocalPos(Vector2 sp, Camera cam, Vector2 worldOffset)
		{
			return default;
		}

		protected Vector2 ScreenToLocalPos(Vector2 sp, Camera cam)
		{
			return default;
		}

		protected Vector2 ScreenToNormalizedPos(Vector2 sp, Camera cam, Vector2 worldOffset)
		{
			return default;
		}

		protected Vector2 ScreenToNormalizedPos(Vector2 sp, Camera cam)
		{
			return default;
		}

		protected Vector2 LocalToNormalizedPos(Vector2 lp)
		{
			return default;
		}

		protected Vector2 WorldToNormalizedPos(Vector2 wp, Vector2 worldOffset)
		{
			return default;
		}

		protected Vector2 WorldToNormalizedPos(Vector2 wp)
		{
			return default;
		}

		protected Vector2 NormalizedToLocalPos(Vector2 np)
		{
			return default;
		}

		protected Vector2 NormalizedToLocalOffset(Vector2 np)
		{
			return default;
		}

		protected Vector3 NormalizedToWorldPos(Vector2 np)
		{
			return default;
		}

		protected Vector2 NormalizedToWorldOffset(Vector2 np)
		{
			return default;
		}

		protected Vector3 WorldToScreenPos(Vector3 wp, Camera cam)
		{
			return default;
		}

		protected Vector2 LocalToScreenPos(Vector2 lp, Camera cam)
		{
			return default;
		}

		public Vector2 ScreenToOrientedPos(Vector2 sp, Camera cam)
		{
			return default;
		}

		public Vector3 GetWorldSpaceCenter()
		{
			return default;
		}

		public Vector3 GetWorldSpaceSize()
		{
			return default;
		}

		public Bounds GetWorldSpaceAABB()
		{
			return default;
		}

		public Vector2 GetScreenSpaceCenter(Camera cam)
		{
			return default;
		}

		public Matrix4x4 GetWorldToNormalizedMatrix()
		{
			return default;
		}

		public Matrix4x4 GetNormalizedToWorldMatrix()
		{
			return default;
		}

		protected Vector3 GetFollowPos(Vector3 targetWorldPos, Vector2 worldOffset, out bool posWasOutside)
		{
			posWasOutside = default;
			return default;
		}

		protected Vector3 GetFollowPos(Vector3 targetWorldPos, Vector3 worldOffset)
		{
			return default;
		}

		protected Vector3 ClampInsideCanvas(Vector3 targetWorldPos, Canvas limiterCanvas)
		{
			return default;
		}

		protected Vector3 ClampInsideOther(Vector3 targetWorldPos, TouchControl limiter)
		{
			return default;
		}

		public bool RaycastScreen(Vector2 screenPos, Camera cam)
		{
			return false;
		}

		public bool RaycastLocal(Vector2 localPos)
		{
			return false;
		}

		public bool HitTest(Vector2 sp, Camera cam, float fingerRadPx, Hit hit)
		{
			return false;
		}

		protected override void OnInitComponent()
		{
		}

		protected override void OnEnableComponent()
		{
		}

		protected override void OnDisableComponent()
		{
		}

		protected override void OnDestroyComponent()
		{
		}

		public void UpdateControl()
		{
		}

		protected void DrawDefaultGizmo(bool drawFullRect)
		{
		}

		protected void DrawDefaultGizmo(bool drawFullRect, float fullRectColorShade)
		{
		}

		protected virtual void DrawCustomGizmos(bool selected)
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
