using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public class TouchJoystick : DynamicTouchControl
	{
		public JoystickConfig config;

		private JoystickState state;

		public DigitalBinding pressBinding;

		public JoystickStateBinding joyStateBinding;

		public bool emulateTouchPressure;

		public AxisBinding touchPressureBinding;

		protected override void OnInitControl()
		{
		}

		public Vector2 GetVector()
		{
			return default;
		}

		public Vector2 GetVectorRaw()
		{
			return default;
		}

		public Dir GetDir()
		{
			return Dir.N;
		}

		public JoystickState GetState()
		{
			return null;
		}

		public override void ResetControl()
		{
		}

		protected override void OnUpdateControl()
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

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, Object undoObject, string parentMenuPath)
		{
		}

		public override bool IsUsingKeyForEmulation(KeyCode key)
		{
			return false;
		}

		private void SyncRigState()
		{
		}
	}
}
