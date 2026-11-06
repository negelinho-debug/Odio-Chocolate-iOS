using UnityEngine;

public class DoorScript : MonoBehaviour
{
	public float openingDistance;

	public Transform player;

	public BaldiScript baldi;

	public BaldiScript2 baltazar;

	public MeshCollider barrier;

	public MeshCollider trigger;

	public MeshCollider invisibleBarrier;

	public MeshRenderer inside;

	public MeshRenderer outside;

	public AudioClip doorOpen;

	public AudioClip doorClose;

	public Material closed;

	public Material open;

	public Material closedOutside;

	public Material openOutside;

	public Material baltazarClosed;

	public Material baltazarOpen;

	private bool bDoorOpen;

	private bool bDoorLocked;

	public int silentOpens;

	private float openTime;

	public float lockTime;

	private AudioSource myAudio;

	public GameControllerScript gc;

	public bool DoorLocked => false;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OpenDoor()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	public void LockDoor(float time)
	{
	}

	public void UnlockDoor()
	{
	}

	public void SilenceDoor()
	{
	}
}
