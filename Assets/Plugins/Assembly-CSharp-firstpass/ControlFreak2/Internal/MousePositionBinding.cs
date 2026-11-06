using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class MousePositionBinding : InputBindingBase
	{
		public int priority;

		public MousePositionBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public MousePositionBinding(int prio, bool enabled, InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(MousePositionBinding b)
		{
		}

		public void SyncPos(Vector2 pos, InputRig rig)
		{
		}

		protected override bool OnIsEmulatingMousePosition()
		{
			return false;
		}
	}
}
