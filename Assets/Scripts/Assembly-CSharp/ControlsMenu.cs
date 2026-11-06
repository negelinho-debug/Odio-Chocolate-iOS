using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlsMenu : MonoBehaviour
{
	[SerializeField]
	private Button[] allButtons;

	[SerializeField]
	private TMP_Text[] buttonTexts;

	[SerializeField]
	private TMP_Text[] secondaryButtonTexts;

	[SerializeField]
	private TMP_Text[] labelTexts;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private GameObject confirmationPanel;

	[SerializeField]
	private GameObject resetConfirmationPanel;

	[SerializeField]
	private TMP_Text counterText;

	[SerializeField]
	private TMP_Text confirmText;

	private int currentActionIndex;

	private Coroutine rebindCoroutine;

	private KeyCode[] allKeyCodes;

	private bool isBindingMouseInput;

	private InputManager inputMan;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateAllButtonTexts()
	{
	}

	private string FormatKeyText(KeyCode key)
	{
		return null;
	}

	private string FormatMouseText(KeyCode mouseKey)
	{
		return null;
	}

	public void StartRebindKeyboard(int actionIndex)
	{
	}

	public void StartRebindMouse(int actionIndex)
	{
	}

	public void ShowResetConfirmation()
	{
	}

	public void ResetKey()
	{
	}

	public void ConfirmRebind()
	{
	}

	public void ConfirmReset()
	{
	}

	public void CancelRebind()
	{
	}

	public void CancelReset()
	{
	}

	private IEnumerator RebindCoroutine(float duration)
	{
		return null;
	}

	private bool GetPressedInput(out KeyCode pressedKey)
	{
		pressedKey = default;
		return false;
	}

	private bool IsMouseKey(KeyCode key)
	{
		return false;
	}

	private void SetButtonsInteractable(bool state)
	{
	}

	public void ResetToDefaults()
	{
	}
}
