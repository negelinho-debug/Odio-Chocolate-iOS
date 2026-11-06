using System.Collections;
using TMPro;
using UnityEngine;

public class PerfectPopup : MonoBehaviour
{
	public AudioSource perfect;

	public TMP_Text popupText;

	public string defaultMessage;

	public float pauseDuration;

	public float fadeOutDuration;

	private Coroutine currentRoutine;

	private bool initialized;

	private void Awake()
	{
	}

	public void ShowMessage(string message)
	{
	}

	private IEnumerator FadeRoutine()
	{
		return null;
	}

	private void SetAlpha(float alpha)
	{
	}
}
