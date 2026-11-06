using UnityEngine;
using UnityEngine.AI;

public class MondaysSlap : MonoBehaviour
{
	public bool db;

	public float baseTime;

	public float speed;

	public float timeToMove;

	public float baldiAnger;

	public float baldiTempAnger;

	public float baldiWait;

	public float baldiSpeedScale;

	private float moveFrames;

	private float currentPriority;

	public bool antiHearing;

	public float antiHearingTime;

	public float vibrationDistance;

	public float angerRate;

	public float angerRateRate;

	public float angerFrequency;

	public float timeToAnger;

	public bool endless;

	public Transform player;

	public Transform wanderTarget;

	public AILocationSelectorScript wanderer;

	private AudioSource baldiAudio;

	public AudioClip slap;

	public Animator baldiAnimator;

	public float coolDown;

	private Vector3 previous;

	private bool rumble;

	private NavMeshAgent agent;

	public float slapSpeed;

	private float slapSpeedTimer;

	private bool slapSpeedActive;

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

	public void TargetPlayer()
	{
	}

	private void Move()
	{
	}

	public void GetAngry(float value)
	{
	}

	public void GetTempAngry(float value)
	{
	}

	public void Hear(Vector3 soundLocation, float priority)
	{
	}

	public void ActivateAntiHearing(float t)
	{
	}
}
