using System;
using UnityEngine;

namespace ControlFreak2.Internal
{
	[Serializable]
	public class SpriteConfig
	{
		public bool enabled;

		public Sprite sprite;

		public Color color;

		public float scale;

		public float rotation;

		public Vector2 offset;

		public bool resetOffset;

		public bool resetRotation;

		public bool resetScale;

		[NonSerialized]
		public bool oneShotState;

		public float duration;

		public float baseTransitionTime;

		public float colorTransitionFactor;

		public float scaleTransitionFactor;

		public float rotationTransitionFactor;

		public float offsetTransitionFactor;

		public SpriteConfig()
		{
		}

		public SpriteConfig(Sprite sprite, Color color)
		{
		}

		public SpriteConfig(bool enabled, bool oneShot, float scale)
		{
		}
	}
}
