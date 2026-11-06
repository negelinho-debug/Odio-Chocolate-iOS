using UnityEngine;

public class SwingingDoorScript : MonoBehaviour
{
	public GameControllerScript gc;

	public BaldiScript baldi;

	public MeshCollider barrier;

	public GameObject obstacle;

	public MeshCollider trigger;

	public MeshRenderer inside;

	public MeshRenderer outside;

	public Material closed;

	public Material open;

	public Material locked;

	public Material closedOutside;

	public Material openOutside;

	public Material lockedOutside;

	public AudioClip doorOpen;

	public AudioClip baldiDoor;

	private float openTime;

	private float lockTime;

	public bool bDoorOpen;

	public bool bDoorLocked;

	private bool requirementMet;

	private AudioSource myAudio;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void LockDoor(float time)
	{
	}

	private void UnlockDoor()
	{
	}
}
