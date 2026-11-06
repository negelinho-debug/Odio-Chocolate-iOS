using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	public CursorControllerScript cc;

	private bool joystickEnabled;

	public bool controlMouse;

	public bool unlockOnStart;

	public bool uiControlEnabled;

	public Selectable firstButton;

	public Selectable dummyButtonPC;

	public Selectable dummyButtonElse;

	public string buttonTag;

	public bool usingJoystick => false;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SwitchMenu()
	{
	}

	private void UpdateControllerType()
	{
	}

	private void UIUpdate()
	{
	}

	public void EnableControl()
	{
	}

	public void DisableControl()
	{
	}

	private void SelectDummy()
	{
	}
}
