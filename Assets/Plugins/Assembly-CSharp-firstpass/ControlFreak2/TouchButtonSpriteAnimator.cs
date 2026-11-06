using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	[ExecuteInEditMode]
	public class TouchButtonSpriteAnimator : TouchControlSpriteAnimatorBase, ISpriteAnimator
	{
		public enum ControlState
		{
			Neutral = 0,
			Pressed = 1,
			Toggled = 2,
			ToggledAndPressed = 3,
			All = 4
		}

		public SpriteConfig spritePressed;

		public SpriteConfig spriteToggled;

		public SpriteConfig spriteToggledAndPressed;

		public TouchButtonSpriteAnimator()
			: base(null)
		{
		}

		public void SetSprite(Sprite sprite)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void SetStateSprite(ControlState state, Sprite sprite)
		{
		}

		public void SetStateColor(ControlState state, Color color)
		{
		}

		public SpriteConfig GetStateSpriteConfig(ControlState state)
		{
			return null;
		}

		protected override void OnInitComponent()
		{
		}

		protected override void OnUpdateAnimator(bool skipAnim)
		{
		}

		MonoBehaviour ISpriteAnimator.GetComponent()
		{
			return null;
		}

		void ISpriteAnimator.AddUsedSprites(ISpriteOptimizer optimizer)
		{
		}

		void ISpriteAnimator.OnSpriteOptimization(ISpriteOptimizer optimizer)
		{
		}
	}
}
