using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
	public Dictionary<InputAction, InputBinding> KeyboardMapping;

	private Dictionary<KeyCode, SimulatedKeyState> simulatedKeys;

	private bool[] currentKeyStates;

	private bool[] previousKeyStates;

	private const string SavePrefix = "InputBinding_";

	public Dictionary<InputAction, InputBinding> Mappings => null;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	private void UpdateSimulatedKeys()
	{
	}

	public void SimulateKey(KeyCode key)
	{
	}

	private bool GetKeyState(KeyCode key)
	{
		return false;
	}

	public bool GetActionKey(InputAction action)
	{
		return false;
	}

	public bool GetActionKeyDown(InputAction action)
	{
		return false;
	}

	public bool GetActionKeyUp(InputAction action)
	{
		return false;
	}

	public void ClearPrimaryKey(InputAction action)
	{
	}

	public void ClearSecondaryKey(InputAction action)
	{
	}

	public string ConvertInputActionToString(InputAction action)
	{
		return null;
	}

	public void Modify(InputAction action, KeyCode newKey, KeyCode secondaryKey = KeyCode.None)
	{
	}

	public void Save()
	{
	}

	public void Load()
	{
	}

	public void SetDefaults()
	{
	}

	public string KeyCodeToDisplayString(KeyCode key)
	{
		return null;
	}

	private InputBinding GetDefaultBinding(InputAction action)
	{
		return default;
	}
}
