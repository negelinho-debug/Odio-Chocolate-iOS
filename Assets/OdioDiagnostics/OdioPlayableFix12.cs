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

    private float nextChase;
    private float nextLog;
    private float schoolStarted;

    private int inventoryCount;

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

        if (
            baldiAgent != null &&
            baldiAgent.enabled &&
            baldiAgent.gameObject.activeInHierarchy &&
            baldiAgent.isOnNavMesh &&
            Time.unscaledTime - schoolStarted > 30f
        )
        {
            if (Time.unscaledTime > nextChase)
            {
                nextChase = Time.unscaledTime + 1f;
                baldiAgent.speed = 3.2f;

                baldiAgent.SetDestination(
                    player.position
                );
            }

            if (
                Vector3.Distance(
                    baldiAgent.transform.position,
                    player.position
                ) < 1.6f
            )
            {
                gameOver = true;
                ShowNotice("Baldi caught you!");

                Debug.Log(
                    "ODIO FIX12: Player caught"
                );
            }
        }
    }

    private void ShowNotice(string message)
    {
        notice = message;
        noticeUntil = Time.unscaledTime + 4f;

        Debug.Log("ODIO FIX12: " + message);
    }

    private void Interact()
    {
        if (player == null || gameOver)
            return;

        float minDistance = 3.1f;
        int kind = 0;

        MonoBehaviour nearest = null;

        foreach (NotebookScript n in notebooks)
        {
            if (
                n == null ||
                !n.gameObject.activeInHierarchy ||
                collected.Contains(n.GetInstanceID())
            )
                continue;

            float d = Vector3.Distance(
                player.position,
                n.transform.position
            );

            if (d < minDistance)
            {
                minDistance = d;
                nearest = n;
                kind = 1;
            }
        }

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

        if (kind == 1)
        {
            collected.Add(
                nearest.GetInstanceID()
            );

                      // ODIO RECOVERY13: synchronized notebook counter.
                      GameControllerScript controller =
                          FindObjectOfType<GameControllerScript>();
                      if (controller != null) controller.CollectNotebook();

            nearest.gameObject.SetActive(false);

            ShowNotice(
                "Collected: " +
                collected.Count + "/" + Goal
            );

            if (collected.Count >= Goal)
                ShowNotice(
                    "All 13 collected! Find an exit!"
                );
        }
        else if (kind == 2)
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
