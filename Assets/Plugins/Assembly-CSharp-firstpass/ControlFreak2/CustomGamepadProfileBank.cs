using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace ControlFreak2
{
	public class CustomGamepadProfileBank
	{
		public List<GamepadProfile> profileList;

		public const string GAMEPAD_PROFILE_LIST_KEY = "CF2GamepadProfiles";

		public int FindDuplicate(GamepadProfile profile)
		{
			return 0;
		}

		public GamepadProfile GetProfileById(int i)
		{
			return null;
		}

		public GamepadProfile GetProfile(string deviceName)
		{
			return null;
		}

		public void GetCompatibleProfiles(string deviceName, List<GamepadProfile> targetList)
		{
		}

		public GamepadProfile AddProfile(GamepadProfile profile)
		{
			return null;
		}

		public void Load()
		{
		}

		public void Save()
		{
		}

		private bool LoadFromPlayerPrefs()
		{
			return false;
		}

		private bool SaveToPlayerPrefs()
		{
			return false;
		}

		private XmlSerializer CreateSerializer()
		{
			return null;
		}

		private bool SaveToStream(XmlTextWriter stream)
		{
			return false;
		}

		private bool LoadFromStream(XmlTextReader stream)
		{
			return false;
		}
	}
}
