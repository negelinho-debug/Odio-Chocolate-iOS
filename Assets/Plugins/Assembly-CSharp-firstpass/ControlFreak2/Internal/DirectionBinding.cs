using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class DirectionBinding : InputBindingBase
	{
		public enum BindMode
		{
			Normal = 0,
			OnChange = 1,
			OnRelease = 2,
			OriginalOnStart = 3,
			OriginalUntilRelease = 4,
			OriginalUntilChange = 5
		}

		public bool bindDiagonals;

		public BindMode bindMode;

		public DigitalBinding dirBindingU;

		public DigitalBinding dirBindingUR;

		public DigitalBinding dirBindingR;

		public DigitalBinding dirBindingDR;

		public DigitalBinding dirBindingD;

		public DigitalBinding dirBindingDL;

		public DigitalBinding dirBindingL;

		public DigitalBinding dirBindingUL;

		public DigitalBinding dirBindingN;

		public DigitalBinding dirBindingAny;

		public DirectionBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(DirectionBinding b)
		{
		}

		protected override void OnGetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		public void SyncDirectionState(DirectionState dirState, InputRig rig)
		{
		}

		public void SyncDirRaw(Dir dir, InputRig rig)
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
