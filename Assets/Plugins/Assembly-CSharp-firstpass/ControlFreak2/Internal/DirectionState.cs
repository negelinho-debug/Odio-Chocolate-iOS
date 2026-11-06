namespace ControlFreak2.Internal
{
	public class DirectionState
	{
		public enum OriginalDirResetMode
		{
			OnNeutral = 0,
			On180 = 1,
			On135 = 2,
			On90 = 3
		}

		private Dir dirCur;

		private Dir dirPrev;

		private Dir dirOriginalCur;

		private Dir dirOriginalPrev;

		public Dir GetCur()
		{
			return Dir.N;
		}

		public Dir GetPrev()
		{
			return Dir.N;
		}

		public Dir GetOriginal()
		{
			return Dir.N;
		}

		public Dir GetPrevOriginal()
		{
			return Dir.N;
		}

		public bool JustPressed(Dir dir)
		{
			return false;
		}

		public bool JustReleased(Dir dir)
		{
			return false;
		}

		public void Reset()
		{
		}

		public void BeginFrame()
		{
		}

		public void SetDir(Dir dir, OriginalDirResetMode resetMode)
		{
		}
	}
}
