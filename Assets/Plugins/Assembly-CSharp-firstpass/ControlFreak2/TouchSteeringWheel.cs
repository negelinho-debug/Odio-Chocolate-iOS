using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public class TouchSteeringWheel : DynamicTouchControl
	{
		public enum WheelMode
		{
			Swipe = 0,
			Turn = 1
		}

		public WheelMode wheelMode;

		public bool limitTurnSpeed;

		public float minTurnTime;

		public float maxReturnTime;

		public float maxTurnAngle;

		public float turnModeDeadZone;

		public bool physicalMode;

		public float physicalMoveRangeCm;

		public bool sendInputWhileReturning;

		public AnalogConfig analogConfig;

		public DigitalBinding pressBinding;

		public AxisBinding analogTurnBinding;

		public DigitalBinding turnRightBinding;

		public DigitalBinding turnLeftBinding;

		public bool emulateTouchPressure;

		public AxisBinding touchPressureBinding;

		private Vector2 pressOrigin;

		private float rawValCur;

		private float valCur;

		private float valPrev;

		private Vector2 startVec;

		private float startRawVal;

		private float startAngle;

		private float curAngle;

		private float angleDelta;

		private bool angleIsSafe;

		public float GetValue()
		{
			return 0f;
		}

		public float GetValueDelta()
		{
			return 0f;
		}

		protected override void OnInitControl()
		{
		}

		public override void ResetControl()
		{
		}

		protected override void OnUpdateControl()
		{
		}

		private void SyncRigState()
		{
		}

		private float GetWheelAngle(Vector2 np, float fallbackAngle)
		{
			return 0f;
		}

		protected override bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, Object undoObject, string parentMenuPath)
		{
		}
	}
}
