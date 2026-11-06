using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[ExecuteInEditMode]
	public abstract class ComponentBase : MonoBehaviour
	{
		[NonSerialized]
		private bool isReady;

		[NonSerialized]
		private bool isDestroyed;

		public bool IsInitialized => false;

		public bool IsDestroyed => false;

		protected abstract void OnInitComponent();

		protected abstract void OnDestroyComponent();

		protected abstract void OnEnableComponent();

		protected abstract void OnDisableComponent();

		public bool CanBeUsed()
		{
			return false;
		}

		public void Init()
		{
		}

		public void ForceInit()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
