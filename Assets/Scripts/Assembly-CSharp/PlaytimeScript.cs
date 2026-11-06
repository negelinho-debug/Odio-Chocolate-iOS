using UnityEngine;
using UnityEngine.AI;

public class PlaytimeScript : MonoBehaviour
{
	public bool db;

	public bool playerSeen;

	public bool disappointed;

	public int audVal;

	public Animator animator;

	public Transform player;

	public PlayerScript ps;

	public Transform wanderTarget;

	public AILocationSelectorScript wanderer;

	public float coolDown;

	public float playCool;

	public bool playerSpotted;

	public bool jumpRopeStarted;

	private NavMeshAgent agent;

	public AudioClip[] aud_Random;

	public AudioClip aud_Instrcutions;

	public AudioClip aud_Oops;

	public AudioClip aud_LetsPlay;

	public AudioClip aud_Congrats;

	public AudioClip aud_ReadyGo;

	public AudioClip aud_Sad;

	public AudioSource audioDevice;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Wander()
	{
	}

	private void TargetPlayer()
	{
	}

	public void Disappoint()
	{
	}
}
