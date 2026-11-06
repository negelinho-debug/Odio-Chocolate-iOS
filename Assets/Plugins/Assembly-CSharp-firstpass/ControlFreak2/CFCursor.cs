using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ControlFreak2
{
	public static class CFCursor
	{
		[CompilerGenerated]
		private static Action m_onLockStateChange;

		private static CursorLockMode mLockState;

		private static bool mVisible;

		public static CursorLockMode lockState
		{
			get
			{
				return CursorLockMode.None;
			}
			set
			{
			}
		}

		public static bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event Action onLockStateChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static CFCursor()
		{
		}

		private static bool IsCursorLockingAllowed()
		{
			return false;
		}

		public static void InternalRefresh()
		{
		}

		public static void SetCursor(Texture2D tex, Vector2 hotSpot, CursorMode mode)
		{
		}

		private static CursorLockMode InternalGetLockMode()
		{
			return CursorLockMode.None;
		}

		private static void InternalSetLockMode(CursorLockMode mode)
		{
		}

		private static bool InternalIsVisible()
		{
			return false;
		}

		private static void InternalSetVisible(bool visible)
		{
		}
	}
}
