using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningScreenScript : MonoBehaviour
{
    public string LoadScene;

    private IEnumerator Start()
    {
        Debug.Log("ODIO FIX7: Warning entered");
        yield return new WaitForSecondsRealtime(5f);

        string next = string.IsNullOrEmpty(LoadScene)
            ? "MainMenu" : LoadScene;

        if (!Application.CanStreamedLevelBeLoaded(next))
        {
            Debug.LogError(
                "ODIO FIX7: Scene unavailable: " + next
            );
            yield break;
        }

        Debug.Log("ODIO FIX7: Loading " + next);
        try
        {
            SceneManager.LoadScene(next);
        }
        catch (Exception ex)
        {
            Debug.LogError("ODIO FIX7: " + ex);
        }
    }
}
