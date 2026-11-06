using UnityEngine;
using UnityEngine.AI;

public class FirstPrizeScript : MonoBehaviour
{
	public float debug;

	public float turnSpeed;

	public float str;

	public float angleDiff;

	public float normSpeed;

	public float runSpeed;

	public float currentSpeed;

	public float acceleration;

	public float speed;

	public float autoBrakeCool;

	public float crazyTime;

	public Quaternion targetRotation;

	public float coolDown;

	private float prevSpeed;

	public bool playerSeen;

	public bool hugAnnounced;

	public AILocationSelectorScript wanderer;

	public Transform player;

	public Transform wanderTarget;

	public AudioClip[] aud_Found;

	public AudioClip[] aud_Lost;

	public AudioClip[] aud_Hug;

	public AudioClip[] aud_Random;

	public AudioClip audBang;

	public AudioSource audioDevice;

	public AudioSource motorAudio;

	private NavMeshAgent agent;

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

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void GoCrazy()
	{
	}
}
