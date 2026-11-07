using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class OdioLaunchLogger : MonoBehaviour
{
    private static readonly object FileLock = new object();
    private static string logPath;
    private float nextHeartbeat;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Install()
    {
        try
        {
            Directory.CreateDirectory(Application.persistentDataPath);
            logPath = Path.Combine(Application.persistentDataPath, "odio-launch.log");
            File.WriteAllText(logPath,
                "=== Odio iOS launch ===\n" + DateTime.UtcNow.ToString("u") + " UTC\n" +
                "Unity: " + Application.unityVersion + "\n" +
                "Bundle: " + Application.identifier + "\n" +
                "Log file: " + logPath + "\n");
        }
        catch (Exception ex)
        {
            Debug.LogError("Odio logger setup failed: " + ex);
            return;
        }

        Application.logMessageReceivedThreaded += OnUnityLog;
        SceneManager.sceneLoaded += OnSceneLoaded;
        GameObject obj = new GameObject("__OdioLaunchLogger");
        DontDestroyOnLoad(obj);
        obj.AddComponent<OdioLaunchLogger>();
        Write("LOGGER STARTED");
    }

    private static void OnUnityLog(string message, string stackTrace, LogType type)
    {
        Write("[" + type + "] " + message +
            (string.IsNullOrEmpty(stackTrace) ? "" : "\n" + stackTrace));
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Write("SCENE LOADED: " + scene.name + " (index " + scene.buildIndex + ")");
        try
        {
            GameObject[] roots = scene.GetRootGameObjects();
            Write("Root objects: " + roots.Length);
            int missing = 0;
            foreach (GameObject root in roots)
            {
                Write("  ROOT: " + root.name + " active=" + root.activeSelf);
                MonoBehaviour[] components = root.GetComponentsInChildren<MonoBehaviour>(true);
                foreach (MonoBehaviour component in components)
                {
                    if (component == null) missing++;
                }
            }
            Write("Missing script components: " + missing);
        }
        catch (Exception ex)
        {
            Write("Scene inspection failed: " + ex);
        }
    }

    private void Update()
    {
        if (Time.unscaledTime < nextHeartbeat) return;
        nextHeartbeat = Time.unscaledTime + 5f;
        Scene scene = SceneManager.GetActiveScene();
        Write("HEARTBEAT t=" + Time.unscaledTime.ToString("F1") +
            " activeScene=" + scene.name + " index=" + scene.buildIndex);
    }

    private static void Write(string line)
    {
        if (string.IsNullOrEmpty(logPath)) return;
        lock (FileLock)
        {
            try
            {
                if (new FileInfo(logPath).Length > 2 * 1024 * 1024) return;
                File.AppendAllText(logPath,
                    "[" + DateTime.UtcNow.ToString("HH:mm:ss.fff") + "] " + line + "\n");
            }
            catch
            {
                // Never crash the game because of logging.
            }
        }
    }
}
