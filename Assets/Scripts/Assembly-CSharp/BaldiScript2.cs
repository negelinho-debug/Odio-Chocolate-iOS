using UnityEngine;
using UnityEngine.AI;

public class BaldiScript2 : MonoBehaviour
{
	public bool headStartActive;

	public float headStartDuration;

	private float headStartTimer;

	public float baseSpeed;

	public float speedAngerScale;

	private float currentSpeed;

	public float slapInterval;

	private float slapTimer;

	public bool db;

	public float baldiAnger;

	public float baldiTempAnger;

	public float baldiSpeedScale;

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

	private bool rumble;

	private NavMeshAgent agent;

	public GameControllerScript gameController;

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
