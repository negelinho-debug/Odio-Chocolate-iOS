using UnityEngine;
using UnityEngine.AI;

public class CraftersScript : MonoBehaviour
{
	public bool db;

	public bool angry;

	public bool gettingAngry;

	public float anger;

	private float forceShowTime;

	public Transform player;

	public CharacterController cc;

	public Transform playerCamera;

	public Transform baldiTeleportPoint;

	public Transform playerTeleportPoint;

	public NavMeshAgent baldiAgent;

	public GameObject sprite;

	public GameControllerScript gc;

	[SerializeField]
	private NavMeshAgent agent;

	public Renderer craftersRenderer;

	public SpriteRenderer spriteImage;

	public Sprite angrySprite;

	private AudioSource audioDevice;

	public AudioClip aud_Intro;

	public AudioClip aud_Loop;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void GiveLocation(Vector3 location, bool flee)
	{
	}

	private void TargetPlayer()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
