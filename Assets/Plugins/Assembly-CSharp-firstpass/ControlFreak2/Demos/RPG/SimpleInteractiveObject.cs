using UnityEngine;

namespace ControlFreak2.Demos.RPG
{
	public class SimpleInteractiveObject : InteractiveObjectBase
	{
		public Color activatedColor;

		public Renderer targetRenderer;

		public AudioClip soundEffect;

		private bool isActivated;

		public override void OnCharacterAction(CharacterAction chara)
		{
		}
	}
}
