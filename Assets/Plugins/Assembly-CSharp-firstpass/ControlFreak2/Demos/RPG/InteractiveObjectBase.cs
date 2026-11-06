using UnityEngine;

namespace ControlFreak2.Demos.RPG
{
	public abstract class InteractiveObjectBase : MonoBehaviour
	{
		public float radius;

		public abstract void OnCharacterAction(CharacterAction chara);

		public virtual bool IsNear(CharacterAction chara)
		{
			return false;
		}

		private void OnDrawGizmos()
		{
		}

		protected void DrawDefaultGizmo()
		{
		}
	}
}
