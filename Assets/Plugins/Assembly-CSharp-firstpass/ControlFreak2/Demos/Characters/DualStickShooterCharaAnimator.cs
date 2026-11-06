using UnityEngine;

namespace ControlFreak2.Demos.Characters
{
	public class DualStickShooterCharaAnimator : MonoBehaviour
	{
		public DualStickShooterCharaMotor charaMotor;

		public Animator animator;

		public string forwardBackwardParamName;

		public string strafeParamName;

		public string speedParamName;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
