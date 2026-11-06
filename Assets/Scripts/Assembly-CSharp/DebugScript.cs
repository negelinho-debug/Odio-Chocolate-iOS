using System.Collections;
using TMPro;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
	public bool limitFramerate;

	public int framerate;

	public TextMeshProUGUI fpsText;

	public float deltaTime;

	[SerializeField]
	private TextMeshProUGUI keyText;

	[SerializeField]
	private TMP_Text errorText;

	[SerializeField]
	private AudioSource errorSource;

	private Coroutine logDissappearCoroutine;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LogError(string logString, string stackTrace, LogType type)
	{
	}

	private IEnumerator LogDissappear()
	{
		return null;
	}

	private void Start()
	{
	}

	public void Update()
	{
	}
}
