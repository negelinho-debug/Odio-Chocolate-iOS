using System.Collections;
using UnityEngine;

public class UIOpenAnimation : MonoBehaviour
{
	public RectTransform target;

	public CanvasGroup canvasGroup;

	public float travelDuration;

	public float bounceDuration;

	public float startOffsetY;

	public float firstBounceHeight;

	public int bounceCount;

	private Vector2 originalPosition;

	private Coroutine animationCoroutine;

	private void Awake()
	{
	}

	public void PlayAnimation()
	{
	}

	private IEnumerator Animate()
	{
		return null;
	}
}
