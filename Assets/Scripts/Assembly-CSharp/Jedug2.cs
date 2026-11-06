using UnityEngine;
using UnityEngine.UI;

public class Jedug2 : BaseMeshEffect
{
	public AudioSource music;

	public float minSkew;

	public float maxSkew;

	public float moveRightTime;

	public float pauseRightTime;

	public float moveLeftTime;

	public float pauseLeftTime;

	public float minScaleY;

	public float maxScaleY;

	public AnimationCurve skewCurve;

	public AnimationCurve bounceCurve;

	private float currentSkew;

	private float currentScaleY;

	private float skewTimer;

	private int skewState;

	private bool wasPlaying;

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateSkew()
	{
	}

	private void UpdateBounce()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}
