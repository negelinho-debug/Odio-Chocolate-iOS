using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public sealed class OdioPlayableFix12 : MonoBehaviour
{
    private const int Goal = 13;

    private Transform player;
    private Camera viewCamera;

    private NotebookScript[] notebooks =
        new NotebookScript[0];

    private PickupScript[] pickups =
        new PickupScript[0];

    private DoorScript[] doors =
        new DoorScript[0];

    private ExitTriggerScript[] exits =
        new ExitTriggerScript[0];

    private readonly HashSet<int> collected =
        new HashSet<int>();

    private readonly HashSet<int> takenItems =
        new HashSet<int>();

    private NavMeshAgent baldiAgent;
    private BaldiScript recoveryBaldi;

    private float nextChase;
    private float nextLog;
    private float schoolStarted;

    private int inventoryCount;

    // ODIO RECOVERY16: quiz state
    private NotebookScript quizNotebook;
    private PlayerScript quizPlayer;
    private bool quizPreviousCutscene;
    private float quizPreviousTimeScale = 1f;
    private int quizIndex;
    private int quizWrong;
    private int quizLeft;
    private int quizRight;
    private int quizOperation;
    private int quizAnswer;
    private int[] quizOptions = new int[3];


    private bool inSchool;
    private bool gameOver;
    private bool won;

    private string notice = "";
    private float noticeUntil;

    [RuntimeInitializeOnLoadMethod(
        RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void Install()
    {
        if (FindObjectOfType<OdioPlayableFix12>() != null)
            return;

        GameObject go = new GameObject(
            "ODIO Playable Foundation FIX12"
        );

        DontDestroyOnLoad(go);
        go.AddComponent<OdioPlayableFix12>();
    }

    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

        if (SceneManager.GetActiveScene().name == "School")
            StartCoroutine(ConfigureSchool());
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(
        Scene scene,
        LoadSceneMode mode)
    {
        if (quizNotebook != null)
        {
            Time.timeScale = quizPreviousTimeScale;
            if (quizPlayer != null)
                quizPlayer.cameraCutscene = quizPreviousCutscene;
            quizNotebook = null;
            quizPlayer = null;
        }

        inSchool = false;

        if (scene.name == "School")
            StartCoroutine(ConfigureSchool());
    }

    private IEnumerator ConfigureSchool()
    {
        yield return null;
        yield return new WaitForSecondsRealtime(0.4f);

        if (SceneManager.GetActiveScene().name != "School")
            yield break;

        GameObject playerObject =
            GameObject.Find("Player");

        player = playerObject == null
            ? null : playerObject.transform;

        viewCamera = Camera.main;

        if (viewCamera == null && player != null)
            viewCamera =
                player.GetComponentInChildren<Camera>(true);

        notebooks =
            FindObjectsOfType<NotebookScript>(true);

        pickups =
            FindObjectsOfType<PickupScript>(true);

        doors =
            FindObjectsOfType<DoorScript>(true);

        exits =
            FindObjectsOfType<ExitTriggerScript>(true);

        collected.Clear();
        takenItems.Clear();

        inventoryCount = 0;
        won = false;
        gameOver = false;

        schoolStarted = Time.unscaledTime;
        nextChase = 0f;
        nextLog = 0f;

        baldiAgent = null;
        recoveryBaldi = null;

        BaldiScript[] enemies =
            FindObjectsOfType<BaldiScript>(true);

        foreach (BaldiScript enemy in enemies)
        {
            if (
                enemy == null ||
                enemy.gameObject.name != "Baldi"
            )
                continue;

            baldiAgent =
                enemy.GetComponent<NavMeshAgent>();
            recoveryBaldi = enemy;

            break;
        }

        inSchool = true;

        Debug.Log(
            "ODIO FIX12: Started! player=" +
            (player == null ? "MISSING" : "ok") +
            " camera=" +
            (viewCamera == null ? "MISSING" : "ok") +
            " notebooks=" + notebooks.Length +
            " pickups=" + pickups.Length +
            " doors=" + doors.Length +
            " exits=" + exits.Length
        );

        ShowNotice(
            "Explore the school! Collect 13 notebooks."
        );
    }

    private void Update()
    {
        if (!inSchool || player == null || gameOver)
            return;

        if (
            Input.GetKeyDown(KeyCode.E) ||
            Input.GetKeyDown(KeyCode.F)
        )
            Interact();

        if (Time.unscaledTime > nextLog)
        {
            nextLog = Time.unscaledTime + 12f;

            Debug.Log(
                "ODIO FIX12: Player=" + player.position +
                " collected=" + collected.Count +
                "/" + Goal +
                " inventory=" + inventoryCount
            );
        }


    // ODIO RECOVERY15: activate inactive Baldi after first chocolate
    if (recoveryBaldi != null &&
        collected.Count > 0 &&
        !recoveryBaldi.gameObject.activeSelf &&
        Time.unscaledTime - schoolStarted > 18f)
    {
        recoveryBaldi.gameObject.SetActive(true);
        Debug.Log(
            "ODIO RECOVERY15: enabled Baldi"
        );
    }

    // FIX12 only handles defeat.
    // BaldiScript handles movement.
    if (baldiAgent != null &&
        baldiAgent.enabled &&
        baldiAgent.gameObject.activeInHierarchy &&
        baldiAgent.isOnNavMesh &&
        Time.unscaledTime - schoolStarted > 30f &&
        Vector3.Distance(
            baldiAgent.transform.position,
            player.position
        ) < 1.6f)
    {
        gameOver = true;

        PlayerScript ps =
            player.GetComponent<PlayerScript>();

        if (ps != null)
            ps.gameOver = true;

        ShowNotice("Baldi caught you!");

        Debug.Log(
            "ODIO RECOVERY15: player caught"
        );
    }

    }

    private void ShowNotice(string message)
    {
        notice = message;
        noticeUntil = Time.unscaledTime + 4f;

        Debug.Log("ODIO FIX12: " + message);
    }


    // ODIO RECOVERY14: camera-based collection
    private bool TryCollectAimedChocolate()
    {
        if (viewCamera == null)
            viewCamera = Camera.main;

        if (viewCamera == null || player == null)
            return false;

        Ray ray = viewCamera.ViewportPointToRay(
            new Vector3(0.5f, 0.5f, 0f));

        RaycastHit[] hits = Physics.RaycastAll(
            ray, 12f, ~0,
            QueryTriggerInteraction.Collide);

        Array.Sort(hits, (a, b) =>
            a.distance.CompareTo(b.distance));

        foreach (RaycastHit hit in hits)
        {
            Collider c = hit.collider;
            if (c == null) continue;

            if (c.transform.IsChildOf(player))
                continue;

            NotebookScript notebook =
                c.GetComponentInParent<NotebookScript>();

            if (notebook != null)
            {
                if (!notebook.gameObject.activeInHierarchy ||
                    collected.Contains(notebook.GetInstanceID()))
                    return false;

                float reach = notebook.openingDistance > 0f
                    ? notebook.openingDistance : 10f;

                if (hit.distance > reach ||
                    Vector3.Distance(
                        player.position,
                        notebook.transform.position
                    ) > reach + 1.5f)
                {
                    ShowNotice("Move closer to the chocolate");
                    return true;
                }

                BeginChocolateQuiz(notebook);

                return true;
            }

            if (!c.isTrigger)
                break;
        }

        return false;
    }


    // ODIO RECOVERY16: quiz - three mobile-friendly questions
    private void BeginChocolateQuiz(NotebookScript notebook)
    {
        if (quizNotebook != null || notebook == null)
            return;

        quizNotebook = notebook;
        quizIndex = 0;
        quizWrong = 0;

        quizPlayer = player == null ? null
            : player.GetComponent<PlayerScript>();

        if (quizPlayer != null)
        {
            quizPreviousCutscene = quizPlayer.cameraCutscene;
            quizPlayer.cameraCutscene = true;
        }

        quizPreviousTimeScale = Time.timeScale;
        Time.timeScale = 0f;

        NewChocolateQuestion();
        Debug.Log("ODIO RECOVERY16: quiz started");
    }

    private void NewChocolateQuestion()
    {
        quizLeft = UnityEngine.Random.Range(1, 10);
        quizRight = UnityEngine.Random.Range(1, 10);
        quizOperation = UnityEngine.Random.Range(0, 3);

        if (quizOperation == 0)
            quizAnswer = quizLeft + quizRight;
        else if (quizOperation == 1)
            quizAnswer = quizLeft - quizRight;
        else
            quizAnswer = quizLeft * quizRight;

        quizOptions[0] = quizAnswer;
        quizOptions[1] = quizAnswer +
            UnityEngine.Random.Range(1, 5);
        quizOptions[2] = quizAnswer -
            UnityEngine.Random.Range(1, 5);

        for (int i = 2; i > 0; i--)
        {
            int j = UnityEngine.Random.Range(0, i + 1);
            int tmp = quizOptions[i];
            quizOptions[i] = quizOptions[j];
            quizOptions[j] = tmp;
        }
    }

    private void AnswerChocolateQuestion(int answer)
    {
        if (quizNotebook == null)
            return;

        if (answer != quizAnswer)
            quizWrong++;

        quizIndex++;

        if (quizIndex < 3)
        {
            NewChocolateQuestion();
            return;
        }

        NotebookScript completed = quizNotebook;
        quizNotebook = null;

        Time.timeScale = quizPreviousTimeScale;

        if (quizPlayer != null)
            quizPlayer.cameraCutscene = quizPreviousCutscene;

        quizPlayer = null;

        if (completed == null ||
            !collected.Add(completed.GetInstanceID()))
            return;

        GameControllerScript gc =
            FindObjectOfType<GameControllerScript>();

        if (gc != null)
        {
            gc.failedNotebooks += quizWrong;
            gc.CollectNotebook();
        }

        if (recoveryBaldi != null && quizWrong > 0)
            recoveryBaldi.GetAngry(quizWrong * 0.7f);

        completed.gameObject.SetActive(false);

        ShowNotice("Chocolate " + collected.Count +
            "/" + Goal + " | Wrong: " + quizWrong);

        Debug.Log("ODIO RECOVERY16: quiz finished; " +
            "collected=" + collected.Count +
            " wrong=" + quizWrong);

        if (collected.Count >= Goal)
            ShowNotice("All 13! Find an exit!");
    }

    private void DrawChocolateQuiz(float w, float h)
    {
        int font = (int)Mathf.Clamp(h * 0.064f, 17f, 30f);

        GUI.skin.label.fontSize = font;
        GUI.skin.button.fontSize = font;

        float px = w * 0.1f;
        float py = h * 0.08f;
        float pw = w * 0.8f;
        float ph = h * 0.84f;

        GUI.Box(
            new Rect(px, py, pw, ph),
            "CHOCOLATE QUESTION " + (quizIndex + 1) + "/3"
        );

        string sign = quizOperation == 0 ? "+" :
            (quizOperation == 1 ? "-" : "x");

        GUI.Label(
            new Rect(
                px + 16f,
                py + ph * 0.22f,
                pw - 32f,
                ph * 0.17f
            ),
            quizLeft + " " + sign + " " +
            quizRight + " = ?"
        );

        for (int i = 0; i < 3; i++)
        {
            float bw = (pw - 48f) / 3f;

            Rect r = new Rect(
                px + 12f + i * (bw + 12f),
                py + ph * 0.51f,
                bw,
                ph * 0.30f
            );

            if (GUI.Button(
                r, quizOptions[i].ToString()
            ))
            {
                AnswerChocolateQuestion(
                    quizOptions[i]
                );
                break;
            }
        }
    }

    private void Interact()
    {
        if (player == null || gameOver)
            return;

        if (TryCollectAimedChocolate()) return;

        float minDistance = 3.1f;
        int kind = 0;

        MonoBehaviour nearest = null;

        foreach (PickupScript p in pickups)
        {
            if (
                p == null ||
                !p.gameObject.activeInHierarchy ||
                takenItems.Contains(p.GetInstanceID())
            )
                continue;

            float d = Vector3.Distance(
                player.position,
                p.transform.position
            );

            if (d < minDistance)
            {
                minDistance = d;
                nearest = p;
                kind = 2;
            }
        }

        foreach (DoorScript d in doors)
        {
            if (
                d == null ||
                !d.gameObject.activeInHierarchy
            )
                continue;

            float distance = Vector3.Distance(
                player.position,
                d.transform.position
            );

            if (distance < minDistance)
            {
                minDistance = distance;
                nearest = d;
                kind = 3;
            }
        }

        foreach (ExitTriggerScript x in exits)
        {
            if (
                x == null ||
                !x.gameObject.activeInHierarchy
            )
                continue;

            float distance = Vector3.Distance(
                player.position,
                x.transform.position
            );

            if (distance < minDistance)
            {
                minDistance = distance;
                nearest = x;
                kind = 4;
            }
        }

        if (nearest == null)
        {
            ShowNotice(
                "Nothing close enough to interact with"
            );
            return;
        }

        if (kind == 2)
        {
            if (inventoryCount >= 3)
            {
                ShowNotice(
                    "Inventory full (3 items)"
                );
                return;
            }

            takenItems.Add(
                nearest.GetInstanceID()
            );

            nearest.gameObject.SetActive(false);
            inventoryCount++;

            ShowNotice(
                "Item collected (" +
                inventoryCount + "/3)"
            );
        }
        else if (kind == 3)
        {
            StartCoroutine(
                OpenDoorTemporarily(
                    (DoorScript)nearest
                )
            );
        }
        else if (kind == 4)
        {
            if (collected.Count < Goal)
            {
                ShowNotice(
                    "Need all 13 notebooks to escape!"
                );
            }
            else
            {
                won = true;
                gameOver = true;

                Debug.Log(
                    "ODIO FIX12: Prototype level completed"
                );
            }
        }
    }

    private IEnumerator OpenDoorTemporarily(
        DoorScript door)
    {
        if (door == null)
            yield break;

        MeshCollider barrier = door.barrier;

        if (barrier == null)
        {
            ShowNotice(
                "Door has no linked barrier"
            );
            yield break;
        }

        barrier.enabled = false;
        ShowNotice("Door opened");

        yield return new WaitForSeconds(7f);

        if (barrier != null)
            barrier.enabled = true;
    }

    private void OnGUI()
    {
        if (!inSchool)
            return;

        if (quizNotebook != null)
    {
        DrawChocolateQuiz(Screen.width, Screen.height);
        return;
    }

        float h = Screen.height;
        float w = Screen.width;

        float size = Mathf.Clamp(
            h * 0.055f,
            16f,
            27f
        );

        GUI.skin.label.fontSize = (int)size;
        GUI.skin.button.fontSize = (int)size;

        GUI.Box(
            new Rect(
                10f,
                10f,
                Mathf.Min(w * 0.47f, 400f),
                82f
            ),
            "ODIO: " + collected.Count +
            "/" + Goal +
            " | Items: " + inventoryCount + "/3"
        );

        if (Time.unscaledTime < noticeUntil)
        {
            GUI.Label(
                new Rect(
                    12f,
                    98f,
                    Mathf.Min(w * 0.85f, 710f),
                    75f
                ),
                notice
            );
        }

        if (gameOver)
        {
            GUI.Box(
                new Rect(
                    w * 0.3f,
                    h * 0.3f,
                    w * 0.4f,
                    h * 0.37f
                ),
                won
                    ? "YOU ESCAPED!"
                    : "BALDI CAUGHT YOU"
            );

            if (
                GUI.Button(
                    new Rect(
                        w * 0.36f,
                        h * 0.48f,
                        w * 0.28f,
                        h * 0.1f
                    ),
                    "RETRY"
                )
            )
                SceneManager.LoadScene("School");

            return;
        }

        float buttonSize = Mathf.Clamp(
            h * 0.17f,
            85f,
            155f
        );

        float runAreaWidth = 135f;

        if (
            GUI.Button(
                new Rect(
                    w - buttonSize - runAreaWidth,
                    h - buttonSize - 13f,
                    buttonSize,
                    buttonSize
                ),
                "USE"
            )
        )
            Interact();
    }
}
