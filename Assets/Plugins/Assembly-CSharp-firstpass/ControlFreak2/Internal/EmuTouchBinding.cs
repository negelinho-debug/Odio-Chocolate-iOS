using System;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class EmuTouchBinding : InputBindingBase
	{
		private int emuTouchId;

		public EmuTouchBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(EmuTouchBinding b)
		{
		}

		public void SyncState(TouchGestureBasicState touchState, InputRig rig)
		{
		}

		protected override bool OnIsEmulatingTouches()
		{
			return false;
		}
	}
}
