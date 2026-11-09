using UnityEngine;
using UnityEngine.AI;

public class BaldiScript : MonoBehaviour
{
	public AudioSource audioSource;

	public bool headStartActive;

	public float headStartDuration;

	private float headStartTimer;

	public float baseSpeed;

	public float speedAngerScale;

	private float currentSpeed;

	public float slapInterval;

	private float slapTimer;

	public bool db;

	public float baldiAnger;

	public float baldiTempAnger;

	public float baldiSpeedScale;

	private float currentPriority;

	public bool antiHearing;

	public float antiHearingTime;

	public float vibrationDistance;

	public float angerRate;

	public float angerRateRate;

	public float angerFrequency;

	public float timeToAnger;

	public bool endless;

	public Transform player;

	public Transform wanderTarget;

	public AILocationSelectorScript wanderer;

	private AudioSource baldiAudio;

	public AudioClip slap;

	public Animator baldiAnimator;

	public float coolDown;

	private bool rumble;

	private NavMeshAgent agent;

	public GameControllerScript gameController;

	public GameObject baldiSprite;

	public AnimationClip otherSlap;

	private void Start()
	{
    // ODIO RECOVERY15
agent = GetComponent<NavMeshAgent>();

    baldiAudio = audioSource != null
        ? audioSource
        : GetComponent<AudioSource>();

    if (player == null)
    {
        GameObject p = GameObject.Find("Player");

        if (p != null)
            player = p.transform;
    }

    if (gameController == null)
        gameController =
            FindObjectOfType<GameControllerScript>();

    if (baseSpeed <= 0f)
        baseSpeed = 2.5f;

    headStartTimer = headStartDuration > 0f
        ? headStartDuration : 8f;

    headStartActive = true;
    currentSpeed = baseSpeed;

    slapTimer = slapInterval > 0.1f
        ? slapInterval : 1f;

    if (agent != null &&
        agent.enabled && agent.isOnNavMesh)
    {
        agent.speed = currentSpeed;
        agent.isStopped = true;
    }

    Debug.Log(
        "ODIO RECOVERY15: Baldi activated, navmesh="
        + (agent != null &&
           agent.enabled && agent.isOnNavMesh)
    );
    }

	private void Update()
	{
    // ODIO RECOVERY15
if (agent == null ||
        !agent.enabled ||
        !agent.isOnNavMesh) return;

    if (player == null) return;

    if (headStartActive)
    {
        headStartTimer -= Time.deltaTime;

        if (headStartTimer > 0f)
            return;

        headStartActive = false;
        agent.isStopped = false;

        Debug.Log(
            "ODIO RECOVERY15: Baldi begins patrol"
        );
    }

    if (antiHearingTime > 0f)
    {
        antiHearingTime -= Time.deltaTime;

        if (antiHearingTime <= 0f)
            antiHearing = false;
    }

    baldiTempAnger = Mathf.Max(
        0f, baldiTempAnger - Time.deltaTime
    );

    currentSpeed = Mathf.Clamp(
        baseSpeed +
        baldiAnger * 0.45f +
        baldiTempAnger * 0.3f,
        1.5f, 7f
    );

    agent.speed = currentSpeed;

    coolDown = Mathf.Max(
        0f, coolDown - Time.deltaTime
    );

    slapTimer -= Time.deltaTime;

    if (slapTimer <= 0f)
    {
        slapTimer = slapInterval > 0.1f
            ? slapInterval : 1f;

        if (baldiAudio != null && slap != null)
            baldiAudio.PlayOneShot(slap);
    }

    if (coolDown <= 0f &&
        !agent.pathPending &&
        (!agent.hasPath ||
         agent.remainingDistance <=
         agent.stoppingDistance + 0.5f))
    {
        currentPriority = 0f;
        Wander();
    }
    }

	private void FixedUpdate()
	{
    // ODIO RECOVERY15
if (headStartActive ||
        player == null ||
        agent == null ||
        !agent.enabled ||
        !agent.isOnNavMesh ||
        coolDown > 0f) return;

    Vector3 origin =
        transform.position + Vector3.up;

    Vector3 goal =
        player.position + Vector3.up;

    Vector3 delta = goal - origin;

    if (delta.sqrMagnitude > 400f ||
        delta.sqrMagnitude < 0.01f) return;

    RaycastHit[] hits = Physics.RaycastAll(
        origin,
        delta.normalized,
        delta.magnitude,
        ~0,
        QueryTriggerInteraction.Ignore
    );

    System.Array.Sort(
        hits,
        (a, b) => a.distance.CompareTo(b.distance)
    );

    foreach (RaycastHit hit in hits)
    {
        if (hit.collider == null) continue;

        if (hit.collider.transform.IsChildOf(
            transform)) continue;

        if (!hit.collider.transform.IsChildOf(
            player)) return;

        break;
    }

    TargetPlayer();
    }

	private void Wander()
	{
    // ODIO RECOVERY15
if (agent == null ||
        !agent.enabled ||
        !agent.isOnNavMesh) return;

    if (wanderer != null)
        wanderer.GetNewTarget();

    Vector3 target;

    if (wanderTarget != null)
    {
        target = wanderTarget.position;
    }
    else
    {
        NavMeshHit hit;

        if (!NavMesh.SamplePosition(
            transform.position +
            Random.insideUnitSphere * 12f,
            out hit,
            12f,
            NavMesh.AllAreas))
            return;

        target = hit.position;
    }

    agent.SetDestination(target);
    coolDown = 0.8f;
    }

	public void TargetPlayer()
	{
    // ODIO RECOVERY15
if (agent == null ||
        !agent.enabled ||
        !agent.isOnNavMesh ||
        player == null ||
        headStartActive) return;

    agent.SetDestination(player.position);
    coolDown = 0.35f;
    }

	public void GetAngry(float value)
	{
    // ODIO RECOVERY15
baldiAnger = Mathf.Max(
        0f, baldiAnger + value
    );
    }

	public void GetTempAngry(float value)
	{
    // ODIO RECOVERY15
baldiTempAnger = Mathf.Max(
        0f, baldiTempAnger + value
    );
    }

	public void Hear(Vector3 soundLocation, float priority)
	{
    // ODIO RECOVERY15
if (antiHearing ||
        headStartActive ||
        priority < currentPriority ||
        agent == null ||
        !agent.enabled ||
        !agent.isOnNavMesh) return;

    currentPriority = priority;
    agent.SetDestination(soundLocation);
    coolDown = 2.5f;
    }

	public void ActivateAntiHearing(float t)
	{
    // ODIO RECOVERY15
antiHearing = true;
    antiHearingTime = Mathf.Max(0f, t);
    currentPriority = 0f;
    Wander();
    }
}
