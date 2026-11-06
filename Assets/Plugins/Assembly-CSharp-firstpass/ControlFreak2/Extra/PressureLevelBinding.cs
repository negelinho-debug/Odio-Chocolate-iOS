using System;
using System.Collections.Generic;
using UnityEngine;

namespace ControlFreak2.Extra
{
	public class PressureLevelBinding : MonoBehaviour
	{
		[Serializable]
		public class RangeConfig
		{
			public float min;

			public float max;

			public KeyCode keyTarget;

			public string axisTarget;

			public bool positiveAxisSide;

			private int cachedAxisId;

			public void Update(InputRig rig, float val)
			{
			}
		}

		private InputRig rig;

		public string sourceAxis;

		private int sourceAxisId;

		public List<RangeConfig> rangeConfigList;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected void UpdateRanges()
		{
		}
	}
}
