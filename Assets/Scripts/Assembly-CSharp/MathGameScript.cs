using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MathGameScript : MonoBehaviour
{
	public GameControllerScript gc;

	public BaldiScript baldiScript;

	public Vector3 playerPosition;

	public GameObject mathGame;

	public RawImage[] results;

	public Texture correct;

	public Texture incorrect;

	public TMP_InputField playerAnswer;

	public TMP_Text questionText;

	public TMP_Text questionText2;

	public TMP_Text questionText3;

	public Animator baldiFeed;

	public Transform baldiFeedTransform;

	public AudioClip bal_plus;

	public AudioClip bal_minus;

	public AudioClip bal_times;

	public AudioClip bal_divided;

	public AudioClip bal_equals;

	public AudioClip bal_howto;

	public AudioClip bal_intro;

	public AudioClip bal_screech;

	public AudioClip[] bal_numbers;

	public AudioClip[] bal_praises;

	public AudioClip[] bal_problems;

	public Button firstButton;

	private float endDelay;

	private int problem;

	private int audioInQueue;

	private float num1;

	private float num2;

	private float num3;

	private int sign;

	private float solution;

	private string[] hintText;

	private string[] endlessHintText;

	private bool questionInProgress;

	private bool impossibleMode;

	private bool joystickEnabled;

	private int problemsWrong;

	private AudioClip[] audioQueue;

	public AudioSource baldiAudio;

	public VideoPlayer videoPlayer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void NewProblem()
	{
	}

	public void CheckAnswer()
	{
	}

	private void QueueAudio(AudioClip sound)
	{
	}

	private void PlayQueue()
	{
	}

	private void UnqueueAudio()
	{
	}

	private void ClearAudioQueue()
	{
	}

	private void ExitGame()
	{
	}

	public void ButtonPress(int value)
	{
	}

	private IEnumerator CheatText(string text)
	{
		return null;
	}

	public void ExitGame(VideoPlayer vp)
	{
	}
}
