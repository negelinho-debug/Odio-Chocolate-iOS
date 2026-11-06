using UnityEngine;
using UnityEngine.AI;

public class SweepScript : MonoBehaviour
{
	public Transform wanderTarget;

	public AILocationSelectorScript wanderer;

	public float coolDown;

	public float waitTime;

	public int wanders;

	public bool active;

	private Vector3 origin;

	public AudioClip aud_Sweep;

	public AudioClip aud_Intro;

	private NavMeshAgent agent;

	private AudioSource audioDevice;

	public string mode;

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

	private void GoHome()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
