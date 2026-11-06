using System;
using UnityEngine;
using UnityEngine.UI;

namespace ControlFreak2.Internal
{
	[ExecuteInEditMode]
	public abstract class TouchControlSpriteAnimatorBase : TouchControlAnimatorBase
	{
		protected RectTransform rectTr;

		protected Image image;

		protected CanvasGroup canvasGroup;

		protected Vector3 initialTransl;

		protected Vector3 initialScale;

		protected Quaternion initialRotation;

		public SpriteConfig spriteNeutral;

		[NonSerialized]
		private SpriteConfig curSprite;

		[NonSerialized]
		private SpriteConfig nextSprite;

		private float spriteAnimElapsed;

		protected Vector2 animOffsetStart;

		protected Vector2 animOffsetCur;

		protected Vector2 animScaleStart;

		protected Vector2 animScaleCur;

		protected float animRotationStart;

		protected float animRotationCur;

		protected Color animColorStart;

		protected Color animColorCur;

		protected Vector2 extraOffset;

		protected Vector2 extraScale;

		protected float extraRotation;

		public TouchControlSpriteAnimatorBase(Type sourceType)
			: base(null)
		{
		}

		protected override void OnInitComponent()
		{
		}

		protected override void OnDisableComponent()
		{
		}

		protected void BeginSpriteAnim(SpriteConfig spriteConfig, bool skipAnim, bool forceStart = false)
		{
		}

		protected void UpdateSpriteAnimation(bool skipAnim)
		{
		}

		public void ApplySpriteAnimation()
		{
		}

		private float GetAnimLerpFactor(float duration)
		{
			return 0f;
		}
	}
}
