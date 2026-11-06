using UnityEngine;

public class BeatSprite : MonoBehaviour
{
	public AudioSource music;

	public float rotateAmount;

	public float returnSpeed;

	public float beatThreshold;

	public float beatCooldown;

	private float[] samples;

	private float lastBeatTime;

	private bool rotateLeft;

	private Quaternion normalRotation;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
