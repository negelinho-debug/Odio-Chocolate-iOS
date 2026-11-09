using UnityEngine;

public class ExitTriggerScript : MonoBehaviour
{
	public GameControllerScript gc;

	public string ResultsScene;

	public string SecretScene;

	private void OnTriggerEnter(Collider other)
	{
        // ODIO RECOVERY17 ORIGINAL
    if (other == null || !other.CompareTag("Player"))
        return;

    if (gc == null)
        gc = FindObjectOfType<GameControllerScript>();

    if (gc == null || gc.notebooks < 7)
        return;

    string target = gc.failedNotebooks >= 7
        ? SecretScene : ResultsScene;

    if (string.IsNullOrEmpty(target) ||
        !Application.CanStreamedLevelBeLoaded(target))
    {
        Debug.LogError(
            "ODIO RECOVERY17: Missing scene " + target
        );
        return;
    }

    UnityEngine.SceneManagement.SceneManager.LoadScene(target);

    }
}
