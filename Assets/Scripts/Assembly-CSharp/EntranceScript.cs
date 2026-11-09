using UnityEngine;

public class EntranceScript : MonoBehaviour
{
	public GameControllerScript gc;

	public Material map;

	public MeshRenderer wall;

	public void Lower()
	{
        // ODIO RECOVERY17 ORIGINAL
    transform.position -= new Vector3(0f, 10f, 0f);
    if (gc != null && gc.finaleMode &&
        wall != null && map != null)
        wall.material = map;

    }

	public void Raise()
	{
        // ODIO RECOVERY17 ORIGINAL
    transform.position += new Vector3(0f, 10f, 0f);

    }
}
