using System;
using System.Collections.Generic;
using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	[ExecuteInEditMode]
	public class TouchControlPanel : ComponentBase
	{
		public class SystemTouchEventData
		{
			public Vector2 pos;

			public Camera cam;

			public int id;

			public bool isMouseEvent;

			public int touchId;
		}

		private class SystemTouch
		{
			public TouchObject touch;

			public int hwId;

			public float elapsedSinceLastAction;

			public int startFrame;

			public SystemTouch(TouchControlPanel panel)
			{
			}

			public void WakeUp()
			{
			}

			public void Update()
			{
			}
		}

		private const float staticFingerTimeout = 2f;

		public bool autoConnectToRig;

		public InputRig rig;

		[NonSerialized]
		protected List<TouchControl> controls;

		[NonSerialized]
		private List<SystemTouch> touchList;

		[NonSerialized]
		private TouchControl.HitPool hitPool;

		private const int MAX_SYSTEM_TOUCHES = 16;

		private const int MAX_RAYCAST_HITS = 8;

		private float fingerRadInPx;

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

		private void Update()
		{
		}

		public void UpdatePanel()
		{
		}

		public void InvalidateHierarchy()
		{
		}

		public void AddControl(TouchControl c)
		{
		}

		public void RemoveControl(TouchControl c)
		{
		}

		public List<TouchControl> GetControlList()
		{
			return null;
		}

		private void Prepare()
		{
		}

		public bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return false;
		}

		private bool RaycastControlFilter(TouchControl c)
		{
			return false;
		}

		public void OnSystemTouchStart(SystemTouchEventData data)
		{
		}

		public void OnSystemTouchEnd(SystemTouchEventData data)
		{
		}

		public void OnSystemTouchMove(SystemTouchEventData data)
		{
		}

		public void UpdateTouches()
		{
		}

		private bool IsTouchPressureSensitive(int touchId, out float pressureOut)
		{
			pressureOut = default;
			return false;
		}

		private void UpdateTouchPressure()
		{
		}

		private void ReleaseAll(bool cancel)
		{
		}

		private SystemTouch FindTouch(int hwId)
		{
			return null;
		}

		private SystemTouch StartNewTouch(SystemTouchEventData data)
		{
			return null;
		}

		public int GetActiveTouchCount()
		{
			return 0;
		}
	}
}
