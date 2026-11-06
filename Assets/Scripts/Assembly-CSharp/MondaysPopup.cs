using System.Collections;
using TMPro;
using UnityEngine;

public class MondaysPopup : MonoBehaviour
{
	public AudioSource mondays;

	public TMP_Text popupText;

	public string defaultMessage;

	public float fadeInDuration;

	public float growDuration;

	public float growMultiplier;

	public float returnDuration;

	public float fadeOutDuration;

	public float shakeAmount;

	public float normalShakeSpeed;

	public float growShakeSpeed;

	public float fadeOutShakeSpeed;

	public AnimationCurve fadeInCurve;

	public AnimationCurve growCurve;

	public AnimationCurve returnCurve;

	public AnimationCurve fadeOutCurve;

	private Vector3 normalScale;

	private Quaternion normalRotation;

	private Coroutine currentRoutine;

	private void Awake()
	{
	}

	public void ShowMessage(string message)
	{
	}

	private IEnumerator ShowRoutine()
	{
		return null;
	}

	private void SetAlpha(float alpha)
	{
	}
}
