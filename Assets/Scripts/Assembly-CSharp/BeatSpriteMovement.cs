using UnityEngine;

public class BeatSpriteMovement : MonoBehaviour
{
	[SerializeField]
	private float horizontalDistance;

	[SerializeField]
	private float moveDuration;

	[SerializeField]
	private float bounceDistance;

	[SerializeField]
	private float bounceDuration;

	[SerializeField]
	private float squashAmount;

	[SerializeField]
	private AnimationCurve movementCurve;

	private Vector3 startPosition;

	private Vector3 originalScale;

	private float time;

	private bool movingForward;

	private float bounceTimer;

	private bool bouncing;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void StartBounce()
	{
	}
}
