using System;
using System.Collections.Generic;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class DisablingConditionSet
	{
		public enum MobileModeRelation
		{
			EnabledOnlyInMobileMode = 0,
			DisabledInMobileMode = 1,
			AlwaysEnabled = 2
		}

		[Serializable]
		public class DisablingRigSwitch
		{
			public string name;

			public bool disableWhenSwitchIsOff;

			private int cachedId;

			public DisablingRigSwitch()
			{
			}

			public DisablingRigSwitch(string name)
			{
			}

			public bool IsInEffect(InputRig rig)
			{
				return false;
			}
		}

		public MobileModeRelation mobileModeRelation;

		public bool disableWhenTouchScreenInactive;

		public bool disableWhenCursorIsUnlocked;

		public List<DisablingRigSwitch> switchList;

		[NonSerialized]
		private InputRig rig;

		public DisablingConditionSet(InputRig rig)
		{
		}

		public void SetRig(InputRig rig)
		{
		}

		public bool IsInEffect()
		{
			return false;
		}

		public bool IsDisabledByRigSwitches()
		{
			return false;
		}
	}
}
