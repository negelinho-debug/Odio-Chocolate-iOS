using UnityEngine;

public class BullyScript : MonoBehaviour
{
	public Transform player;

	public GameControllerScript gc;

	public Renderer bullyRenderer;

	public Transform wanderTarget;

	public AILocationSelectorScript wanderer;

	public float waitTime;

	public float activeTime;

	public float guilt;

	public bool active;

	public bool spoken;

	private AudioSource audioDevice;

	public AudioClip[] aud_Taunts;

	public AudioClip[] aud_Thanks;

	public AudioClip aud_Denied;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Activate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void Reset()
	{
	}
}
