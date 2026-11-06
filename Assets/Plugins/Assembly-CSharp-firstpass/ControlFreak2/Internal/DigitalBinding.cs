using System;
using System.Collections.Generic;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class DigitalBinding : InputBindingBase
	{
		[Serializable]
		public class AxisElem
		{
			public string axisName;

			public bool axisPositiveSide;

			[NonSerialized]
			private int cachedAxisId;

			private bool OnIsBoundToAxis(string axisName, InputRig rig)
			{
				return false;
			}

			public void SetAxis(string axisName, bool positiveSide)
			{
			}

			public void CopyFrom(AxisElem b)
			{
			}

			public void ApplyToRig(InputRig rig, bool skipIfTargetIsMuted)
			{
			}
		}

		public List<AxisElem> axisList;

		public List<KeyCode> keyList;

		private void BasicConstructor()
		{
		}

		public DigitalBinding(InputBindingBase parent = null)
			: base(null)
		{
		}

		public DigitalBinding(KeyCode key, bool bindToAxis, string axisName, bool axisNegSide, bool enabled, InputBindingBase parent = null)
			: base(null)
		{
		}

		public DigitalBinding(KeyCode key, string axisName, bool enabled, InputBindingBase parent = null)
			: base(null)
		{
		}

		public DigitalBinding(KeyCode key, bool enabled, InputBindingBase parent = null)
			: base(null)
		{
		}

		public void CopyFrom(DigitalBinding b)
		{
		}

		public void Sync(bool state, InputRig rig, bool skipIfTargetIsMuted = false)
		{
		}

		public void Clear()
		{
		}

		public void ClearKeys()
		{
		}

		public void ClearAxes()
		{
		}

		public void AddKey(KeyCode code)
		{
		}

		public void RemoveLastKey()
		{
		}

		public void ReplaceKey(int keyElemId, KeyCode key)
		{
		}

		public AxisElem AddAxis()
		{
			return null;
		}

		public AxisElem GetAxisElem(int id)
		{
			return null;
		}

		public void RemoveLastAxis()
		{
		}

		protected override bool OnIsBoundToKey(KeyCode keycode, InputRig rig)
		{
			return false;
		}

		protected override bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}
	}
}
