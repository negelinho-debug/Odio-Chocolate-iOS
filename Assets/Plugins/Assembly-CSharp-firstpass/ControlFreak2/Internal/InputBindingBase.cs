using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public abstract class InputBindingBase : IBindingContainer
	{
		public bool enabled;

		[NonSerialized]
		private InputBindingBase parent;

		public InputBindingBase(InputBindingBase parent)
		{
		}

		public InputBindingBase GetParent()
		{
			return null;
		}

		public void Enable()
		{
		}

		public bool IsEnabledInHierarchy()
		{
			return false;
		}

		public void GetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		protected virtual void OnGetSubBindingDescriptions(BindingDescriptionList descList, UnityEngine.Object undoObject, string parentMenuPath)
		{
		}

		public bool IsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		public bool IsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		public bool IsEmulatingTouches()
		{
			return false;
		}

		public bool IsEmulatingMousePosition()
		{
			return false;
		}

		protected virtual bool OnIsBoundToKey(KeyCode key, InputRig rig)
		{
			return false;
		}

		protected virtual bool OnIsBoundToAxis(string axisName, InputRig rig)
		{
			return false;
		}

		protected virtual bool OnIsEmulatingTouches()
		{
			return false;
		}

		protected virtual bool OnIsEmulatingMousePosition()
		{
			return false;
		}
	}
}
