using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	public class TouchSteeringWheelSpriteAnimator : TouchControlSpriteAnimatorBase, ISpriteAnimator
	{
		public enum ControlState
		{
			Neutral = 0,
			Pressed = 1,
			All = 2
		}

		public SpriteConfig spritePressed;

		public float rotationRange;

		public float rotationSmoothingTime;

		public TouchSteeringWheelSpriteAnimator()
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
