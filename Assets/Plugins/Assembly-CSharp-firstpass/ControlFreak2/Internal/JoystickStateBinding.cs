using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class JoystickStateBinding : InputBindingBase
	{
		public AxisBinding horzAxisBinding;

		public AxisBinding vertAxisBinding;

		public DirectionBinding dirBinding;

		public JoystickStateBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(JoystickStateBinding b)
		{
		}

		public void SyncJoyState(JoystickState state, InputRig rig)
		{
		}

		protected override bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsBoundToKey(KeyCode keyCode, InputRig rig)
		{
			return false;
		}

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}
	}
}
