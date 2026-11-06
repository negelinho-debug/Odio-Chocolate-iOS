namespace ControlFreak2
{
	public abstract class BuiltInGamepadProfileBank
	{
		private static BuiltInGamepadProfileBank mInst;

		protected GamepadProfile[] profiles;

		protected GamepadProfile genericProfile;

		public static GamepadProfile GetProfile(string deviceName)
		{
			return null;
		}

		public static GamepadProfile GetGenericProfile()
		{
			return null;
		}

		protected virtual GamepadProfile GetInternalGenericProfile()
		{
			return null;
		}

		protected virtual GamepadProfile FindProfile(string deviceName)
		{
			return null;
		}

		protected GamepadProfile FindInternalProfile(string deviceName)
		{
			return null;
		}

		private static BuiltInGamepadProfileBank Inst()
		{
			return null;
		}
	}
}
