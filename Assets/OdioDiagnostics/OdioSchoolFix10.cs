using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class OdioSchoolFix10 : MonoBehaviour
{
    private Camera schoolCamera;
    private GameObject schoolUI;
    private bool schoolActive;
    private bool uiHidden;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void Install()
    {
        if (FindObjectOfType<OdioSchoolFix10>() != null) return;
        GameObject go = new GameObject("ODIO FIX10 School Diagnostics");
        DontDestroyOnLoad(go);
        go.AddComponent<OdioSchoolFix10>();
    }

    private void Awake()
    {
        SceneManager.sceneLoaded += SceneLoaded;
        Scene current = SceneManager.GetActiveScene();
        if (current.name == "School") StartCoroutine(CheckSchool());
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
    }

    private void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        schoolActive = false;
        schoolCamera = null;
        schoolUI = null;
        uiHidden = false;
        if (scene.name == "School") StartCoroutine(CheckSchool());
    }

    private IEnumerator CheckSchool()
    {
        yield return new WaitForSecondsRealtime(1f);
        if (SceneManager.GetActiveScene().name != "School") yield break;
        schoolActive = true;
        Debug.Log("ODIO FIX10: School diagnostics begin");

        Camera[] cameras = FindObjectsOfType<Camera>(true);
        Debug.Log("ODIO FIX10: Cameras found = " + cameras.Length);
        foreach (Camera c in cameras)
        {
            if (c.gameObject.scene.name != "School") continue;
            Debug.Log("ODIO FIX10 CAMERA: " + c.name
                + " enabled=" + c.enabled
                + " active=" + c.gameObject.activeInHierarchy
                + " pos=" + c.transform.position
                + " rot=" + c.transform.eulerAngles
                + " culling=" + c.cullingMask
                + " targetDisplay=" + c.targetDisplay
                + " targetTexture=" + (c.targetTexture == null ? "none" : "assigned"));
            if (schoolCamera == null || c.CompareTag("MainCamera") || c.name == "Main Camera")
                schoolCamera = c;
        }

        GameObject player = GameObject.Find("Player");
        Debug.Log("ODIO FIX10: Player=" + (player == null ? "missing" : player.transform.position.ToString()));

        if (schoolCamera == null)
        {
            GameObject go = new GameObject("ODIO FIX10 Fallback Camera");
            if (player != null)
            {
                go.transform.SetParent(player.transform, false);
                go.transform.localPosition = new Vector3(0f, 0.25f, 0f);
            }
            else
            {
                go.transform.position = new Vector3(5f, 5f, -6.11f);
            }
            schoolCamera = go.AddComponent<Camera>();
            go.tag = "MainCamera";
            Debug.LogWarning("ODIO FIX10: Created fallback camera");
        }
        else
        {
            if (!schoolCamera.gameObject.activeSelf)
                schoolCamera.gameObject.SetActive(true);
            if (!schoolCamera.enabled) schoolCamera.enabled = true;
            schoolCamera.targetTexture = null;
            schoolCamera.targetDisplay = 0;
        }

        // Temporary blue background for diagnosis
        schoolCamera.clearFlags = CameraClearFlags.SolidColor;
        schoolCamera.backgroundColor = new Color(0.08f, 0.2f, 0.55f, 1f);
        Debug.Log("ODIO FIX10: Camera output enabled; diagnostic blue background set");

        Renderer[] renderers = FindObjectsOfType<Renderer>();
        int visibleInFrustum = 0;
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(schoolCamera);
        foreach (Renderer r in renderers)
        {
            if (r.gameObject.scene.name != "School") continue;
            if (r.enabled && GeometryUtility.TestPlanesAABB(planes, r.bounds))
            {
                visibleInFrustum++;
                if (visibleInFrustum <= 8)
                    Debug.Log("ODIO FIX10 VISIBLE: " + r.name
                        + " pos=" + r.transform.position);
            }
        }
        Debug.Log("ODIO FIX10: Renderers total=" + renderers.Length
            + " inCameraFrustum=" + visibleInFrustum);

        RaycastHit hit;
        if (Physics.Raycast(schoolCamera.transform.position,
            schoolCamera.transform.forward, out hit, 100f))
            Debug.Log("ODIO FIX10: Camera raycast hits " + hit.collider.name
                + " at " + hit.distance.ToString("F1") + "m");
        else
            Debug.Log("ODIO FIX10: Camera raycast hits nothing within 100m");

        schoolUI = GameObject.Find("UIElements");
        Debug.Log("ODIO FIX10: UIElements="
            + (schoolUI == null ? "missing" : "active"));
        Image[] images = FindObjectsOfType<Image>();
        int darkImages = 0;
        foreach (Image im in images)
        {
            Color color = im.color;
            if (color.a > 0.75f && color.r < 0.2f
                && color.g < 0.2f && color.b < 0.2f)
            {
                darkImages++;
                if (darkImages <= 12)
                    Debug.Log("ODIO FIX10 DARK UI: " + im.name
                        + " canvas=" + (im.canvas == null ? "none" : im.canvas.name));
            }
        }
        Debug.Log("ODIO FIX10: Dark UI images=" + darkImages);

        yield return new WaitForEndOfFrame();
        try
        {
            string screenshot = System.IO.Path.Combine(
                Application.persistentDataPath, "odio-school-fix10.png");
            ScreenCapture.CaptureScreenshot(screenshot);
            Debug.Log("ODIO FIX10: Screenshot requested at " + screenshot);
        }
        catch (Exception ex)
        {
            Debug.LogError("ODIO FIX10 screenshot: " + ex);
        }
    }

    private void OnGUI()
    {
        if (!schoolActive) return;
        float height = Mathf.Clamp(Screen.height * 0.14f, 64f, 115f);
        float width = Mathf.Clamp(Screen.width * 0.25f, 175f, 260f);
        string label = uiHidden ? "SHOW SCHOOL UI" : "HIDE SCHOOL UI";
        if (GUI.Button(new Rect(16f, 16f, width, height), label))
        {
            if (schoolUI == null)
            {
                Debug.LogWarning("ODIO FIX10: UIElements not found");
                return;
            }
            uiHidden = !uiHidden;
            schoolUI.SetActive(!uiHidden);
            Debug.Log("ODIO FIX10: UIElements active=" + !uiHidden);
        }
    }
}
