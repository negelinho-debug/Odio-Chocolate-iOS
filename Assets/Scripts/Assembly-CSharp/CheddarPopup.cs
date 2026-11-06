using System.Collections;
using TMPro;
using UnityEngine;

public class CheddarPopup : MonoBehaviour
{
	public TMP_Text popupText;

	public AudioSource audioSource;

	public string defaultMessage;

	public float flipDuration;

	public float pauseDuration;

	public float fadeOutDuration;

	public AnimationCurve flipCurve;

	public AnimationCurve fadeCurve;

	private Vector3 normalScale;

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

	private IEnumerator AnimateY(float startY, float endY, float duration)
	{
		return null;
	}

	private void ResetPopup()
	{
	}

	private void SetAlpha(float alpha)
	{
	}
}
