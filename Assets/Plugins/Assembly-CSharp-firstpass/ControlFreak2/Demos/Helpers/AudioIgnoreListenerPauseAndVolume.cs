using UnityEngine;

namespace ControlFreak2.Demos.Helpers
{
	public class AudioIgnoreListenerPauseAndVolume : MonoBehaviour
	{
		public AudioSource[] targetSources;

		public bool ignoreListenerVolume;

		public bool ignoreListenerPause;

		private void OnEnable()
		{
		}
	}
}
