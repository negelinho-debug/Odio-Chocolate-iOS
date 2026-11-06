using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	[ExecuteInEditMode]
	public class TouchJoystickSpriteAnimator : TouchControlSpriteAnimatorBase, ISpriteAnimator
	{
		public enum SpriteMode
		{
			Simple = 0,
			FourWay = 1,
			EightWay = 2
		}

		public enum RotationMode
		{
			Disabled = 0,
			SimpleHorizontal = 1,
			SimpleVertical = 2,
			Compass = 3
		}

		public enum ControlState
		{
			Neutral = 0,
			NeutralPressed = 1,
			U = 2,
			UR = 3,
			R = 4,
			DR = 5,
			D = 6,
			DL = 7,
			L = 8,
			UL = 9,
			All = 10
		}

		public SpriteMode spriteMode;

		public SpriteConfig spriteNeutralPressed;

		public SpriteConfig spriteUp;

		public SpriteConfig spriteUpRight;

		public SpriteConfig spriteRight;

		public SpriteConfig spriteDownRight;

		public SpriteConfig spriteDown;

		public SpriteConfig spriteDownLeft;

		public SpriteConfig spriteLeft;

		public SpriteConfig spriteUpLeft;

		public bool animateTransl;

		public Vector2 moveScale;

		public float translationSmoothingTime;

		public RotationMode rotationMode;

		public float simpleRotationRange;

		public float rotationSmoothingTime;

		private float lastSafeCompassAngle;

		public TouchJoystickSpriteAnimator()
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
