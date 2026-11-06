using UnityEngine;

public class StartButton : MonoBehaviour
{
	public enum Mode
	{
		Story = 0,
		Ez = 1,
		Duo = 2,
		Duo2 = 3,
		Endless = 4
	}

	public Mode currentMode;

	public string LoadScene;

	public void StartGame()
	{
	}
}
