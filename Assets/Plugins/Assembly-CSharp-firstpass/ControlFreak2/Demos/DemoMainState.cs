using UnityEngine;

namespace ControlFreak2.Demos
{
	public class DemoMainState : GameState
	{
		public MultiDemoManager multiDemoManager;

		public HelpBoxState helpBox;

		public KeyCode helpKey;

		protected override void OnStartState(GameState parentState)
		{
		}

		protected override void OnExitState()
		{
		}

		protected override void OnUpdateState()
		{
		}

		public void ExitToMainMenu()
		{
		}

		public void ShowHelpBox()
		{
		}
	}
}
