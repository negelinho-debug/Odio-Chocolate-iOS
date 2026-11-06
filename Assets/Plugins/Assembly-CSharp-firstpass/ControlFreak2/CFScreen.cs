using UnityEngine;

namespace ControlFreak2
{
	public static class CFScreen
	{
		private const float DEFAULT_FALLBACK_SCREEN_DIAMETER = 7f;

		private static bool mForceFallbackDpi;

		private static Resolution mLastScreenResolution;

		private static Resolution mNativeScreenResolution;

		private static float mFallbackDpi;

		private static float mFallbackDiameter;

		private static float mLastScreenWidth;

		private static float mLastScreenHeight;

		private static float mLastScreenDpi;

		private static float mNativeScreenDpi;

		private static float mDpi;

		private static float mDpcm;

		private static float mInvDpi;

		private static float mInvDpcm;

		public static float dpi => 0f;

		public static float dpcm => 0f;

		public static float invDpi => 0f;

		public static float invDpcm => 0f;

		public static float width => 0f;

		public static float height => 0f;

		public static bool lockCursor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool showCursor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool fullScreen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static FullScreenMode fullScreenMode
		{
			get
			{
				return FullScreenMode.ExclusiveFullScreen;
			}
			set
			{
			}
		}

		public static void SetResolution(int width, int height, bool fullScreen, int refreshRate = 0)
		{
		}

		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate = 0)
		{
		}

		public static void ForceFallbackDpi(bool enableFallbackDpi)
		{
		}

		public static void SetFallbackScreenDiameter(float diameterInInches)
		{
		}

		private static void UpdateDpiIfNeeded()
		{
		}

		public static void UpdateDpi()
		{
		}
	}
}
