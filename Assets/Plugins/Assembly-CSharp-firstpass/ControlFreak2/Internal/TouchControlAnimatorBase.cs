using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[ExecuteInEditMode]
	public abstract class TouchControlAnimatorBase : ComponentBase
	{
		public bool autoConnectToSource;

		public TouchControl sourceControl;

		protected Type sourceType;

		public TouchControlAnimatorBase(Type sourceType)
		{
		}

		protected abstract void OnUpdateAnimator(bool skipAnim);

		public void UpdateAnimator(bool skipAnim)
		{
		}

		public void SetSourceControl(TouchControl c)
		{
		}

		public Type GetSourceControlType()
		{
			return null;
		}

		public TouchControl FindAutoSource()
		{
			return null;
		}

		public void AutoConnectToSource()
		{
		}

		public bool IsIllegallyAttachedToSource()
		{
			return false;
		}

		public void InvalidateHierarchy()
		{
		}

		protected override void OnInitComponent()
		{
		}

		protected override void OnDestroyComponent()
		{
		}

		protected override void OnEnableComponent()
		{
		}

		protected override void OnDisableComponent()
		{
		}
	}
}
