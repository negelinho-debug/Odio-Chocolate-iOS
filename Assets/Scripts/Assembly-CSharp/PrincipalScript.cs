using UnityEngine;
using UnityEngine.AI;

public class PrincipalScript : MonoBehaviour
{
	public bool seesRuleBreak;

	public Transform player;

	public Transform bully;

	public bool bullySeen;

	public PlayerScript playerScript;

	public BullyScript bullyScript;

	public BaldiScript baldiScript;

	public Transform wanderTarget;

	public AILocationSelectorScript wanderer;

	public DoorScript officeDoor;

	public Transform principalDetentionPoint;

	public Transform playerDetentionPoint;

	public float coolDown;

	public float timeSeenRuleBreak;

	public bool angry;

	public bool inOffice;

	private int detentions;

	private int[] lockTime;

	public AudioClip[] audTimes;

	public AudioClip[] audScolds;

	public AudioClip audDetention;

	public AudioClip audNoDrinking;

	public AudioClip audNoEating;

	public AudioClip audNoBullying;

	public AudioClip audNoFaculty;

	public AudioClip audNoLockers;

	public AudioClip audNoRunning;

	public AudioClip audNoStabbing;

	public AudioClip audNoEscaping;

	public AudioClip aud_Whistle;

	public AudioClip aud_Delay;

	private NavMeshAgent agent;

	private AudioQueueScript audioQueue;

	private AudioSource audioDevice;

	public AudioSource quietAudioDevice;

	private RaycastHit hit;

	private Vector3 aim;

	public CharacterController cc;

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

	private void TargetBully()
	{
	}

	private void CorrectPlayer()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
