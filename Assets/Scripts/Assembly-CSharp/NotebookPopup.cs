using System.Collections;
using TMPro;
using UnityEngine;

public class NotebookPopup : MonoBehaviour
{
	private Color currentTargetColor;

	public AudioSource perfect;

	public TMP_Text popupText;

	public string defaultMessage;

	public float animationDuration;

	public float maxScale;

	public float rotationAmount;

	public float shakeAmount;

	public float movementAmount;

	public Color startColor;

	public Color flashColor;

	public Color endColor;

	private Coroutine currentRoutine;

	private RectTransform rect;

	private Vector3 originalScale;

	private Vector2 originalPosition;

	private Quaternion originalRotation;

	private void Awake()
	{
	}

	public void ShowMessage(string message)
	{
	}

	private IEnumerator AnimatePopup()
	{
		return null;
	}

	private void SetAlpha(float alpha)
	{
	}

	private void SetColor(Color color)
	{
	}
}
