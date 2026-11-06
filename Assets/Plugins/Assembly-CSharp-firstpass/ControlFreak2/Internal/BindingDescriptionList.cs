using System.Collections.Generic;
using UnityEngine;

namespace ControlFreak2.Internal
{
	public class BindingDescriptionList : List<BindingDescription>
	{
		public delegate string NameFormatter(InputBindingBase bind, string name);

		public BindingDescription.BindingType typeMask;

		public bool addUnusedBindings;

		public int axisInputSourceMask;

		public NameFormatter menuNameFormatter;

		public BindingDescriptionList(BindingDescription.BindingType typeMask, bool addUnusedBindings, int axisInputSourceMask, NameFormatter menuNameFormatter)
		{
		}

		public void Setup(BindingDescription.BindingType typeMask, bool addUnusedBindings, int axisInputSourceMask, NameFormatter menuNameFormatter)
		{
		}

		public void Add(InputBindingBase binding, string name, string menuPath, Object undoObject)
		{
		}

		public void Add(AxisBinding binding, InputRig.InputSource sourceType, string name, string menuPath, Object undoObject)
		{
		}
	}
}
