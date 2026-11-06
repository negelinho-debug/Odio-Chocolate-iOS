using UnityEngine;

namespace ControlFreak2
{
	public abstract class GameState : MonoBehaviour
	{
		protected GameState parentState;

		protected GameState subState;

		protected bool isRunning;

		public bool IsRunning()
		{
			return false;
		}

		protected virtual void OnStartState(GameState parentState)
		{
		}

		protected virtual void OnExitState()
		{
		}

		protected virtual void OnPreSubStateStart(GameState prevState, GameState nextState)
		{
		}

		protected virtual void OnPostSubStateStart(GameState prevState, GameState nextState)
		{
		}

		protected virtual void OnUpdateState()
		{
		}

		protected virtual void OnFixedUpdateState()
		{
		}

		public void StartSubState(GameState state)
		{
		}

		protected bool FindStateInHierarchy(GameState state)
		{
			return false;
		}

		public void EndState()
		{
		}

		public void EndSubState()
		{
		}

		public GameState GetSubState()
		{
			return null;
		}

		public bool IsSubStateRunning()
		{
			return false;
		}
	}
}
