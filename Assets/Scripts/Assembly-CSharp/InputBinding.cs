using System;
using System.Runtime.InteropServices;
using UnityEngine;

[Serializable]
[StructLayout((LayoutKind)0, Size = 8)]
public struct InputBinding
{
	public KeyCode primaryKey;

	public KeyCode secondaryKey;

	public InputBinding(KeyCode primary, KeyCode secondary = KeyCode.None)
	{
		primaryKey = KeyCode.None;
		secondaryKey = KeyCode.None;
	}
}
