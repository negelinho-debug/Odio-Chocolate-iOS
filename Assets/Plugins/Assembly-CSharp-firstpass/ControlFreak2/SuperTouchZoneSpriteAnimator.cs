using ControlFreak2.Internal;
using UnityEngine;

namespace ControlFreak2
{
	[ExecuteInEditMode]
	public class SuperTouchZoneSpriteAnimator : TouchControlSpriteAnimatorBase, ISpriteAnimator
	{
		public enum ControlState
		{
			Neutral = 0,
			RawPress = 1,
			NormalPress = 2,
			LongPress = 3,
			Tap = 4,
			DoubleTap = 5,
			LongTap = 6,
			NormalScrollU = 7,
			NormalScrollR = 8,
			NormalScrollD = 9,
			NormalScrollL = 10,
			LongScrollU = 11,
			LongScrollR = 12,
			LongScrollD = 13,
			LongScrollL = 14,
			All = 15
		}

		public SpriteConfig spriteRawPress;

		public SpriteConfig spriteNormalPress;

		public SpriteConfig spriteLongPress;

		public SpriteConfig spriteTap;

		public SpriteConfig spriteDoubleTap;

		public SpriteConfig spriteLongTap;

		public SpriteConfig spriteNormalScrollU;

		public SpriteConfig spriteNormalScrollR;

		public SpriteConfig spriteNormalScrollD;

		public SpriteConfig spriteNormalScrollL;

		public SpriteConfig spriteLongScrollU;

		public SpriteConfig spriteLongScrollR;

		public SpriteConfig spriteLongScrollD;

		public SpriteConfig spriteLongScrollL;

		public const ControlState ControlStateFirst = ControlState.Neutral;

		public const ControlState ControlStateCount = ControlState.All;

		public SuperTouchZoneSpriteAnimator()
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
