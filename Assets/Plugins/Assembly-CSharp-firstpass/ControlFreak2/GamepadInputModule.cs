using UnityEngine;
using UnityEngine.EventSystems;

namespace ControlFreak2
{
	public class GamepadInputModule : BaseInputModule
	{
		public GamepadManager.GamepadKey submitGamepadButton;

		public GamepadManager.GamepadKey submitGamepadButtonAlt;

		public GamepadManager.GamepadKey cancelGamepadButton;

		public GamepadManager.GamepadKey cancelGamepadButtonAlt;

		public override bool IsModuleSupported()
		{
			return false;
		}

		private bool JustPressedSubmitButton()
		{
			return false;
		}

		private bool JustPressedCancelButton()
		{
			return false;
		}

		private MoveDirection JustPressedDirectionKey()
		{
			return MoveDirection.Left;
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		public override void ActivateModule()
		{
		}

		private GameObject FindFirstSelectableInScene()
		{
			return null;
		}

		public override void DeactivateModule()
		{
		}

		public override void Process()
		{
		}

		protected bool SendSubmitEventToSelectedObject()
		{
			return false;
		}

		protected bool SendMoveEventToSelectedObject()
		{
			return false;
		}

		protected bool SendUpdateEventToSelectedObject()
		{
			return false;
		}
	}
}
