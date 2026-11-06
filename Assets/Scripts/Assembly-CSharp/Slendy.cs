using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Slendy : MonoBehaviour
{
	public Image flashImage;

	public float appearDuration;

	public float startScale;

	public float appearRotationSpeed;

	public float shakeDuration;

	public float shakeAmount;

	public float shakeSpeed;

	public float finalDuration;

	public float finalScale;

	public float finalRotationSpeed;

	public float fadeStartAlpha;

	public float fadeEndAlpha;

	private RectTransform rectTransform;

	private Vector3 originalScale;

	private Quaternion originalRotation;

	private Coroutine flashCoroutine;

	private void Awake()
	{
	}

	public void Flash()
	{
	}

	private IEnumerator FadeScare()
	{
		return null;
	}
}
