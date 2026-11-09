using UnityEngine;

public class AILocationSelectorScript : MonoBehaviour
{
	public Transform[] newLocation;

	public AmbienceScript ambience;

	private int id;

	public void GetNewTarget()
	{
    // ODIO RECOVERY15
if (newLocation == null ||
        newLocation.Length == 0) return;

    for (int attempt = 0; attempt < 20; attempt++)
    {
        int pick = Random.Range(
            0, newLocation.Length
        );

        if (newLocation[pick] == null)
            continue;

        id = pick;
        transform.position =
            newLocation[pick].position;
        return;
    }
    }

	public void GetNewTargetHallway()
	{
	}

	public void QuarterExclusive()
	{
	}
}
