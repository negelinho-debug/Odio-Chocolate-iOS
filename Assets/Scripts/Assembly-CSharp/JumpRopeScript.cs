using TMPro;
using UnityEngine;

public class JumpRopeScript : MonoBehaviour
{
	public TMP_Text jumpCount;

	public Animator rope;

	public CameraScript cs;

	public PlayerScript ps;

	public PlaytimeScript playtime;

	public int jumps;

	public float jumpDelay;

	public float ropePosition;

	public bool ropeHit;

	public bool jumpStarted;

	public Slendy slendy;

	public AudioSource audSlendy;

	public string mode;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void RopeHit()
	{
	}

	private void Success()
	{
	}

	private void Fail()
	{
	}
}
