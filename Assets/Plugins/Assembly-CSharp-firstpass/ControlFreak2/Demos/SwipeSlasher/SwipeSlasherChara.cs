using UnityEngine;
using UnityEngine.UI;

namespace ControlFreak2.Demos.SwipeSlasher
{
	public class SwipeSlasherChara : MonoBehaviour
	{
		public enum ActionType
		{
			LEFT_STAB = 0,
			LEFT_SLASH_U = 1,
			LEFT_SLASH_R = 2,
			LEFT_SLASH_D = 3,
			LEFT_SLASH_L = 4,
			RIGHT_STAB = 5,
			RIGHT_SLASH_U = 6,
			RIGHT_SLASH_R = 7,
			RIGHT_SLASH_D = 8,
			RIGHT_SLASH_L = 9,
			DODGE_LEFT = 10,
			DODGE_RIGHT = 11
		}

		public AudioClip soundDodge;

		public AudioClip soundSlash;

		public AudioClip soundStab;

		public Graphic graphicLeftStab;

		public Graphic graphicLeftSlashU;

		public Graphic graphicLeftSlashR;

		public Graphic graphicLeftSlashD;

		public Graphic graphicLeftSlashL;

		public Graphic graphicRightStab;

		public Graphic graphicRightSlashU;

		public Graphic graphicRightSlashR;

		public Graphic graphicRightSlashD;

		public Graphic graphicRightSlashL;

		public Graphic graphicDodgeLeft;

		public Graphic graphicDodgeRight;

		public float fadeDur;

		private Animator animator;

		public string animLeftStab;

		public string animLeftSlashU;

		public string animLeftSlashR;

		public string animLeftSlashD;

		public string animLeftSlashL;

		public string animRightStab;

		public string animRightSlashU;

		public string animRightSlashR;

		public string animRightSlashD;

		public string animRightSlashL;

		public string animDodgeLeft;

		public string animDodgeRight;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private Graphic GetActionGraphic(ActionType a)
		{
			return null;
		}

		private void SetActionTriggerState(ActionType action)
		{
		}

		public void ExecuteAction(ActionType action)
		{
		}

		private void PlaySound(AudioClip clip)
		{
		}
	}
}
