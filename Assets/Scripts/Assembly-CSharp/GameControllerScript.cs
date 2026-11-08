using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
	public GameObject MobileControls;

	private bool madStart;

	public AudioClip SchoolRun1;

	public AudioClip SchoolRun2;

	public AudioClip SchoolTrouble;

	public AudioSource source;

	public AudioMixerGroup mixer;

	private int before;

	public float collectAnimationDuration;

	public float collectStartOffsetY;

	public float collectFadeDuration;

	private Coroutine[] collectAnimations;

	private bool Mad;

	private Coroutine itemTextCoroutine;

	private string currentItemText;

	public CursorControllerScript cursorController;

	public PlayerScript player;

	public Transform playerTransform;

	public CharacterController playerCharacter;

	public Collider playerCollider;

	public AILocationSelectorScript AILocationSelector;

	public Transform cameraTransform;

	public Camera playerCamera;

	private int cullingMask;

	public EntranceScript entrance_0;

	public EntranceScript entrance_1;

	public EntranceScript entrance_2;

	public EntranceScript entrance_3;

	public GameObject baldiTutor;

	public GameObject baldi;

	public BaldiScript baldiScrpt;

	public GameObject baldiTutor2;

	public GameObject baldi2;

	public BaldiScript2 baldiScrpt2;

	public GameObject baldiTutor3;

	public GameObject baldi3;

	public MondaysSlap baldiScrpt3;

	public GameObject baldiTutor4;

	public GameObject baldi4;

	public BaldiScript2 baldiScrpt4;

	public AudioClip aud_Prize;

	public AudioClip aud_PrizeMobile;

	public AudioClip aud_AllNotebooks;

	public AudioClip aud_Teleport;

	private bool flipped;

	public GameObject principal;

	public GameObject crafters;

	public GameObject playtime;

	public PlaytimeScript playtimeScript;

	public GameObject gottaSweep;

	public GameObject bully;

	public GameObject firstPrize;

	public GameObject TestEnemy;

	public FirstPrizeScript firstPrizeScript;

	public GameObject quarter;

	public GameObject soda;

	public GameObject soda2;

	public GameObject quarterHide;

	public AudioSource tutorBaldi;

	public RectTransform boots;

	public string mode;

	public int notebooks;

	public int failedNotebooks;

	public bool spoopMode;

	public bool finaleMode;

	public bool debugMode;

	public bool mouseLocked;

	public int exitsReached;

	public int itemSelected;

	public int[] item;

	public RawImage[] itemSlot;

	private string[] itemNames;

	public TMP_Text itemText;

	public Texture[] itemTextures;

	public GameObject bsodaSpray;

	public GameObject alarmClock;

	public TMP_Text notebookCount;

	public GameObject pauseMenu;

	public string ExitGameScene;

	public GameObject highScoreText;

	public GameObject warning;

	public GameObject reticle;

	public RectTransform itemSelect;

	public float[] itemSelectOffset;

	public int itemSelectPosition;

	private bool gamePaused;

	private bool learningActive;

	private float gameOverDelay;

	public string GameOverScene;

	private AudioSource audioDevice;

	public AudioClip aud_Soda;

	public AudioClip aud_Spray;

	public AudioClip aud_buzz;

	public AudioClip aud_bunn;

	public AudioClip aud_burr;

	public AudioClip aud_world;

	public AudioClip aud_Hang;

	public AudioClip aud_MachineQuiet;

	public AudioClip aud_Switch;

	public AudioSource schoolMusic;

	public AudioSource learnMusic;

	public AudioClip eating;

	public HUDPulse hudpulse1;

	public HUDPulse hudpulse3;

	public float NPCwait;

	public float Baldiwait;

	private bool Baldiactive;

	private bool NPCactive;

	public FadeB fadeB;

	public Sprite newSprite;

	public SpriteRenderer spriteRenderer;

	public Sprite newSprite2;

	public SpriteRenderer spriteRenderer2;

	public Animator animator;

	public Animator animator2;

	public AudioSource pauseBaldiSound;

	public AudioSource pauseNotebookSound;

	public TextMeshProUGUI modeText;

	private IEnumerator AnimateCollectedItem(int slotIndex)
	{
		return null;
	}

	private IEnumerator PlayMad()
	{
		return null;
	}

	public void StartAnimator()
	{
	}

	public void PlayMusic()
	{
	}

	private void Start()
	{
    // ODIO RECOVERY13
    mode = PlayerPrefs.GetString(
        "CurrentMode", "story"
    );

    if (string.IsNullOrEmpty(mode))
        mode = "story";

    if (player == null)
        player = FindObjectOfType<PlayerScript>();

    if (playerCamera == null)
        playerCamera = Camera.main;

    if (baldiScrpt != null)
        baldiScrpt.endless =
            (mode == "endless");

    if (modeText != null)
    {
        switch (mode)
        {
            case "ez":
                modeText.text = "Ez Mode";
                break;
            case "duo":
                modeText.text = "Baltazar Mode";
                break;
            case "duo2":
                modeText.text = "Triple Mode";
                break;
            case "endless":
                modeText.text = "Endless Mode";
                break;
            default:
                modeText.text = "Normal Mode";
                break;
        }
    }

    UpdateNotebookCount();

    Debug.Log(
        "ODIO RECOVERY13: School mode=" + mode
    );

    }

	private void Update()
	{
	}

	private void UpdateNotebookCount()
	{
    // ODIO RECOVERY13
    if (notebookCount != null)
    {
        notebookCount.text =
            mode == "endless"
            ? notebooks.ToString() + " chocolates"
            : notebooks.ToString() + "/13 chocolates";
    }

    }

	public void CollectNotebook()
	{
    // ODIO RECOVERY13
    notebooks++;

    UpdateNotebookCount();

    Debug.Log(
        "ODIO RECOVERY13: Collected=" + notebooks
    );

    }

	public void LockMouse()
	{
	}

	public void UnlockMouse()
	{
	}

	public void PauseGame()
	{
	}

	public void ExitGame()
	{
	}

	public void UnpauseGame()
	{
	}

	public void ActivateSpoopMode()
	{
	}

	private void ActivateFinaleMode()
	{
	}

	public void GetAngry(float value)
	{
	}

	public void ActivateLearningGame()
	{
	}

	public void DeactivateLearningGame(GameObject subject)
	{
	}

	private void IncreaseItemSelection()
	{
	}

	private void DecreaseItemSelection()
	{
	}

	private void UpdateItemSelection()
	{
	}

	public void CollectItem(int item_ID)
	{
	}

	public void Selectitem(int value)
	{
	}

	public void UseItem()
	{
	}

	private IEnumerator BootAnimation()
	{
		return null;
	}

	private IEnumerator Teleporter()
	{
		return null;
	}

	private void Teleport()
	{
	}

	private void ResetItem()
	{
	}

	public void LoseItem(int id)
	{
	}

	private void UpdateItemName()
	{
	}

	private IEnumerator TypeItemName(string newText)
	{
		return null;
	}

	public void ExitReached()
	{
	}

	private IEnumerator ChangeAmbientColor(Color from, Color to, float duration)
	{
		return null;
	}

	public void Fliparoo()
	{
	}

	private IEnumerator ChangeFogDensity(float from, float to, float duration)
	{
		return null;
	}
}
