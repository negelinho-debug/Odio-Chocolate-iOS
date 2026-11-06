using System.Collections.Generic;
using UnityEngine;

namespace ControlFreak2
{
	public class TouchObject
	{
		private bool isOn;

		private bool isMouse;

		private bool isPressureSensitive;

		private float normalizedPressure;

		private List<TouchControl> controls;

		public Vector2 screenPosCur;

		public Vector2 screenPosStart;

		public Camera cam;

		private bool isSwipeOverRestricted;

		private List<TouchControl> swipeOverTargetList;

		public bool IsOn()
		{
			return false;
		}

		public bool IsMouse()
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

		public int GetControlCount()
		{
			return 0;
		}

		public void Start(Vector2 screenPosStart, Vector2 screenPosCur, Camera cam, bool isMouse, bool isPressureSensitive, float pressure)
		{
		}

		public void MoveIfNeeded(Vector2 screenPos, Camera cam)
		{
		}

		public void Move(Vector2 screenPos, Camera cam)
		{
		}

		public void End(bool cancel)
		{
		}

		public void SetPressure(float rawPressure, float maxPressure)
		{
		}

		public void ReleaseControl(TouchControl c, TouchControl.TouchEndType touchEndType)
		{
		}

		public void AddControl(TouchControl c)
		{
		}

		protected void OnControlListChange()
		{
		}

		public bool CanAcceptControl(TouchControl c)
		{
			return false;
		}

		public List<TouchControl> GetRestrictedSwipeOverTargetList()
		{
			return null;
		}

		public bool SwipeOverFromNothingControlFilter(TouchControl c)
		{
			return false;
		}

		public bool DirectTouchControlFilter(TouchControl c)
		{
			return false;
		}
	}
}
