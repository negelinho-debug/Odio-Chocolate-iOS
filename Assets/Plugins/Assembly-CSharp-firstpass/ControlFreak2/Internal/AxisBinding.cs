using System;
using System.Collections.Generic;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class AxisBinding : InputBindingBase
	{
		[Serializable]
		public class TargetElem
		{
			public bool separateAxes;

			public string singleAxis;

			public bool reverseSingleAxis;

			public string positiveAxis;

			public string negativeAxis;

			public bool positiveAxisAsPositive;

			public bool negativeAxisAsPositive;

			private int singleAxisId;

			private int positiveAxisId;

			private int negativeAxisId;

			public void SetSingleAxis(string name, bool flip)
			{
			}

			public void SetSeparateAxis(string name, bool positiveSide, bool asPositive)
			{
			}

			public void SyncFloat(float val, InputRig.InputSource source, InputRig rig)
			{
			}

			public void SyncScroll(int val, InputRig rig)
			{
			}

			public float GetAxis(InputRig rig)
			{
				return 0f;
			}

			public bool IsBoundToAxis(string axisName)
			{
				return false;
			}

			public void CopyFrom(TargetElem elem)
			{
			}
		}

		public List<TargetElem> targetList;

		private void BasicConstructor()
		{
		}

		public AxisBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public AxisBinding(string singleName, bool enabled, InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(AxisBinding b)
		{
		}

		public void Clear()
		{
		}

		public TargetElem AddTarget()
		{
			return null;
		}

		public void RemoveLastTarget()
		{
		}

		public TargetElem GetTarget(int axisElemId)
		{
			return null;
		}

		public void SyncFloat(float val, InputRig.InputSource source, InputRig rig)
		{
		}

		public void SyncScroll(int val, InputRig rig)
		{
		}

		protected override bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsBoundToKey(KeyCode keycode, InputRig rig)
		{
			return false;
		}

		public float GetAxis(InputRig rig)
		{
			return 0f;
		}
	}
}
