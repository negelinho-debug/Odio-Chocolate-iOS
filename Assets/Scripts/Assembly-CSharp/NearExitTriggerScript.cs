using UnityEngine;

public class NearExitTriggerScript : MonoBehaviour
{
	public GameControllerScript gc;

	public EntranceScript es;

	private void OnTriggerEnter(Collider other)
	{
        // ODIO RECOVERY17 ORIGINAL
    if (other == null || !other.CompareTag("Player"))
        return;

    if (gc == null)
        gc = FindObjectOfType<GameControllerScript>();

    if (gc == null || !gc.finaleMode ||
        gc.exitsReached > 2)
        return;

    gc.ExitReached();

    if (es != null)
        es.Lower();

    if (gc.baldiScrpt != null &&
        gc.baldiScrpt.isActiveAndEnabled)
        gc.baldiScrpt.Hear(transform.position, 8f);

    }
}
