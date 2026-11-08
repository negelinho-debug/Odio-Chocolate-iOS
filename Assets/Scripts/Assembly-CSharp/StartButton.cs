using UnityEngine;
using UnityEngine.SceneManagement;

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
    // ODIO RECOVERY13
    string selected;

    switch (currentMode)
    {
        case Mode.Ez:
            selected = "ez";
            break;
        case Mode.Duo:
            selected = "duo";
            break;
        case Mode.Duo2:
            selected = "duo2";
            break;
        case Mode.Endless:
            selected = "endless";
            break;
        default:
            selected = "story";
            break;
    }

    PlayerPrefs.SetString(
        "CurrentMode", selected
    );

    PlayerPrefs.Save();

    Debug.Log(
        "ODIO RECOVERY13: Mode=" + selected
    );

    string sceneName =
        string.IsNullOrEmpty(LoadScene)
        ? "School" : LoadScene;

    if (!Application.CanStreamedLevelBeLoaded(sceneName))
    {
        Debug.LogError(
            "Scene missing: " + sceneName
        );
        return;
    }

    SceneManager.LoadScene(sceneName);

    }
}
