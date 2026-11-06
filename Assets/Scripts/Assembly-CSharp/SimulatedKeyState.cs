using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout((LayoutKind)0, Size = 8)]
public struct SimulatedKeyState
{
	public bool currentFrame;

	public bool previousFrame;
}
