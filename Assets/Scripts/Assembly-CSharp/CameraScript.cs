using System.Collections;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	private float cutsceneTiltVelocity;

	public float cutsceneTiltAmount;

	public float cutsceneTiltSmooth;

	public float cutsceneBeatThreshold;

	public float cutsceneMinimumEnergy;

	public float cutsceneBeatCooldown;

	public float cutsceneBeatSensitivity;

	private float[] cutsceneSpectrum;

	private float cutsceneAverageEnergy;

	private float cutsceneBeatCooldownTimer;

	private float cutsceneBeatDirection;

	private float cutsceneCurrentTargetTilt;

	private float cutsceneCurrentTilt;

	private bool cutsceneHasAudioBaseline;

	public AudioSource music;

	public float fovBeatAmount;

	public float fovBeatSensitivity;

	public float fovBeatSmooth;

	public float fovReturnSpeed;

	private float musicAmplitude;

	private float sideTilt;

	private float sideTiltAmount;

	private float sideTiltSpeed;

	private float rotationShake;

	private float rotationShakeTimer;

	private float walkRotationSpeed;

	private float runRotationSpeed;

	private float walkRotationAmount;

	private float runRotationAmount;

	public float spoopCameraFOV;

	private bool spoopCameraActive;

	private bool spoopCameraPlayed;

	private Vector3 savedCameraPosition;

	private Quaternion savedCameraRotation;

	public float spoopStartDistance;

	public float spoopStartHeight;

	public float spoopStartFOV;

	public float spoopDistance;

	public float spoopLookHeight;

	public float spoopZoomDuration;

	public float spoopLookDuration;

	public float spoopZoomFOV;

	public float spoopCameraDuration;

	private Vector3 lastPlayerPosition;

	private float bobTimer;

	private float bobOffset;

	private float walkBobSpeed;

	private float runBobSpeed;

	private float walkBobAmount;

	private float runBobAmount;

	private float fovTimer;

	private float fovNormal;

	private float fovZoom;

	private float fovZoomTime;

	private float fovJeda;

	public GameObject player;

	public PlayerScript ps;

	public GameControllerScript gc;

	public Transform baldi;

	public Vector3 BaldiOffset;

	public Transform baldi2;

	public Vector3 BaldiOffset2;

	public Transform baldi3;

	public Vector3 BaldiOffset3;

	public Transform baldi4;

	public Vector3 BaldiOffset4;

	public float initVelocity;

	public float velocity;

	public float gravity;

	private float lookBehind;

	public Vector3 offset;

	public float jumpHeight;

	public Vector3 jumpHeightV3;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator SpoopCameraCutscene()
	{
		return null;
	}

	public void StartSpoopCamera()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateCameraBob()
	{
	}

	private void UpdateCutsceneBeat()
	{
	}
}
