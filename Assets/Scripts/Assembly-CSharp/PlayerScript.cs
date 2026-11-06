using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
	public GameControllerScript gc;

	public DoorScript door;

	public PlaytimeScript playtime;

	public bool gameOver;

	public bool jumpRope;

	public bool sweeping;

	public bool hugging;

	public bool bootsActive;

	public int principalBugFixer;

	public float sweepingFailsave;

	public float fliparoo;

	private bool lookingBehind;

	public float flipaturn;

	private Quaternion playerRotation;

	public Vector3 frozenPosition;

	private bool sensitivityActive;

	private float sensitivity;

	public float mouseSensitivity;

	public float walkSpeed;

	public float runSpeed;

	public float slowSpeed;

	public float maxStamina;

	public float staminaRate;

	public float guilt;

	public float initGuilt;

	private Vector3 moveDirection;

	private float playerSpeed;

	public float stamina;

	public CharacterController cc;

	public NavMeshAgent gottaSweep;

	public NavMeshAgent firstPrize;

	public Transform firstPrizeTransform;

	public Slider staminaBar;

	public float db;

	public string guiltType;

	public GameObject jumpRopeScreen;

	public float height;

	public Material blackSky;

	public Canvas hud;

	public bool runToggled;

	public bool walkToggled;

	[SerializeField]
	private float jumpRopeSpeedMultiplier;

	private Camera m_Camera;

	private CameraScript cameraScript;

	public bool cameraCutscene;

	public float baldy;

	public IEnumerator LookBehind()
	{
		return null;
	}

	public void StartLookBehind()
	{
	}

	
private int fixJoyFinger = -1;
private Vector2 fixJoyOrigin;
private Vector2 fixMove;
private Vector2 fixLook;
private float fixPitch;
private float fixVertical;
private bool fixRun;

private void OnGUI()
{
    if (Application.isMobilePlatform)
    {
        fixRun = GUI.RepeatButton(
            new Rect(Screen.width - 125,
                Screen.height - 125, 110, 110),
            "RUN");
    }
}

private void Start()
{

    cc = cc != null
        ? cc : GetComponent<CharacterController>();
    m_Camera = GetComponentInChildren<Camera>();
    if (m_Camera == null)
        m_Camera = Camera.main;
    if (walkSpeed <= 0f) walkSpeed = 4f;
    if (runSpeed <= 0f) runSpeed = 7f;
    if (maxStamina <= 0f) maxStamina = 100f;
    if (staminaRate <= 0f) staminaRate = 12f;
    if (mouseSensitivity <= 0f)
        mouseSensitivity = 2f;
    stamina = maxStamina;

}

	private void Update()
{

    if (gameOver || cameraCutscene) return;

    fixMove = Vector2.zero;
    fixLook = Vector2.zero;

    if (Application.isMobilePlatform)
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began &&
                touch.position.x <
                    Screen.width * 0.5f &&
                fixJoyFinger == -1)
            {
                fixJoyFinger = touch.fingerId;
                fixJoyOrigin = touch.position;
            }

            if (touch.fingerId == fixJoyFinger)
            {
                if (touch.phase ==
                    TouchPhase.Ended ||
                    touch.phase ==
                    TouchPhase.Canceled)
                {
                    fixJoyFinger = -1;
                }
                else
                {
                    fixMove =
                        Vector2.ClampMagnitude(
                        (touch.position -
                            fixJoyOrigin) / 90f,
                        1f);
                }
            }
            else if (
                touch.position.x >=
                    Screen.width * 0.5f &&
                touch.position.y > 145f &&
                touch.phase == TouchPhase.Moved)
            {
                fixLook += touch.deltaPosition;
            }
        }
    }

    MouseMove();
    PlayerMove();
    StaminaCheck();

}

	private void MouseMove()
{

    float sens = mouseSensitivity > 0f
        ? mouseSensitivity : 2f;

    float x = Application.isMobilePlatform
        ? fixLook.x * 0.045f * sens
        : Input.GetAxis("Mouse X") * sens;

    float y = Application.isMobilePlatform
        ? fixLook.y * 0.045f * sens
        : Input.GetAxis("Mouse Y") * sens;

    transform.Rotate(0f, x, 0f);

    fixPitch = Mathf.Clamp(
        fixPitch - y, -80f, 80f);

    if (m_Camera != null)
        m_Camera.transform.localRotation =
            Quaternion.Euler(fixPitch, 0f, 0f);

}

	private void PlayerMove()
{

    if (cc == null || !cc.enabled) return;

    Vector2 axes =
        Application.isMobilePlatform
        ? fixMove
        : new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));

    axes = Vector2.ClampMagnitude(axes, 1f);

    bool running = Application.isMobilePlatform
        ? fixRun
        : Input.GetKey(KeyCode.LeftShift);

    bool canRun = running &&
        axes.sqrMagnitude > 0.05f &&
        stamina > 0f;

    playerSpeed = canRun
        ? runSpeed : walkSpeed;

    Vector3 motion =
        transform.right * axes.x +
        transform.forward * axes.y;

    if (cc.isGrounded && fixVertical < 0f)
        fixVertical = -2f;

    fixVertical -= 18f * Time.deltaTime;

    motion = motion * playerSpeed
        + Vector3.up * fixVertical;

    cc.Move(motion * Time.deltaTime);

}

	private void StaminaCheck()
{

    bool moving =
        Application.isMobilePlatform
        ? fixMove.sqrMagnitude > 0.05f
        : (Mathf.Abs(Input.GetAxisRaw(
                "Horizontal")) +
           Mathf.Abs(Input.GetAxisRaw(
                "Vertical"))) > 0.1f;

    bool running =
        Application.isMobilePlatform
        ? fixRun
        : Input.GetKey(KeyCode.LeftShift);

    stamina +=
        (running && moving
            ? -staminaRate
            : staminaRate * 0.55f)
        * Time.deltaTime;

    stamina = Mathf.Clamp(
        stamina, 0f, maxStamina);

    if (staminaBar != null)
        staminaBar.value =
            maxStamina > 0f
            ? stamina / maxStamina : 0f;

}

	private void OnTriggerEnter(Collider other)
	{
	}

	public IEnumerator KeepTheHudOff()
	{
		return null;
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void ResetGuilt(string type, float amount)
	{
	}

	private void GuiltCheck()
	{
	}

	public void ActivateJumpRope()
	{
	}

	public void DeactivateJumpRope()
	{
	}

	public void ActivateBoots()
	{
	}

	private IEnumerator BootTimer()
	{
		return null;
	}
}
