using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class ScrollDeltaBinding : InputBindingBase
	{
		public AxisBinding deltaBinding;

		public DigitalBinding positiveDigitalBinding;

		public DigitalBinding negativeDigitalBinding;

		public ScrollDeltaBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public ScrollDeltaBinding(string axisName, bool enabled = false, InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(ScrollDeltaBinding b)
		{
		}

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		public void SyncScrollDelta(int delta, InputRig rig)
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
	}
}
