using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeB : MonoBehaviour
{
	public RawImage rawImage;

	public Image blackImage;

	public AudioSource musicSource;

	public float fadeInTime;

	public float displayTime;

	public float maxAlpha;

	public float rotationAmount;

	public float beatThreshold;

	public float beatSensitivity;

	public float rotationSmoothness;

	private Vector2 initialPosition;

	private Quaternion initialRotation;

	private float[] samples;

	private float previousVolume;

	private float targetAngle;

	private float currentAngle;

	private bool isPlayingSequence;

	private bool sequenceFinished;

	public GameControllerScript gc;

	private void Start()
	{
	}

	public void PlaySequence()
	{
	}

	private IEnumerator ShowImages()
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private void SetRawAlpha(float alpha)
	{
	}

	private void SetBlackAlpha(float alpha)
	{
	}
}
