using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class GlitchAppear : MonoBehaviour
{
	public float startDelay;

	public float fadeDuration;

	public float glitchDuration;

	public bool loopForever;

	public float minGlitchInterval;

	public float maxGlitchInterval;

	public float glitchAcceleration;

	public float glitchIntensity;

	public float positionOffset;

	public float verticalOffset;

	public float depthOffset;

	public float rotationAmount;

	public float rotationXAmount;

	public float rotationYAmount;

	public float scaleDistortion;

	public float maxScaleMultiplier;

	public bool allowFlip;

	public float skewAmount;

	public bool randomColors;

	public bool rgbColorGlitch;

	public Color glitchColor1;

	public Color glitchColor2;

	public Color glitchColor3;

	public float flickerChance;

	public float invisibleChance;

	public bool randomCharacterVisibility;

	public float characterGlitchChance;

	public AnimationCurve scaleCurve;

	public int seed;

	private TMP_Text text;

	private RectTransform rect;

	private Vector3 originalPosition;

	private Vector3 originalScale;

	private Quaternion originalRotation;

	private Color originalColor;

	private Vector3[] originalVertices;

	private bool[] hiddenCharacters;

	private float elapsed;

	private float glitchTimer;

	private float currentInterval;

	private System.Random random;

	private void Start()
	{
	}

	private IEnumerator PlayEffect()
	{
		return null;
	}

	private void ApplyRandomGlitch(float multiplier)
	{
	}

	private void GlitchCharacters()
	{
	}

	private float RandomRange(float min, float max)
	{
		return 0f;
	}

	private void SetAlpha(float alpha)
	{
	}

	private void RestoreText()
	{
	}

	private void OnDisable()
	{
	}
}
