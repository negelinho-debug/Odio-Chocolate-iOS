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

    string sceneName = string.IsNullOrEmpty(LoadScene)
        ? "School" : LoadScene;

    Debug.Log("ODIO FIX9: StartGame pressed. Mode="
        + currentMode + "; Scene=" + sceneName);

    if (!Application.CanStreamedLevelBeLoaded(sceneName))
    {
        Debug.LogError(
            "ODIO FIX9: Scene is missing from build: "
            + sceneName);
        return;
    }

    try
    {
        Debug.Log("ODIO FIX9: Loading school");
        SceneManager.LoadScene(sceneName);
    }
    catch (System.Exception ex)
    {
        Debug.LogError(
            "ODIO FIX9: Scene load failed: " + ex);
    }

    }
}
