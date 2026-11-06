using UnityEngine;
using UnityEngine.UI;

public class ItemImageScript : MonoBehaviour
{
	public RawImage sprite;

	[SerializeField]
	private Texture noItemSprite;

	[SerializeField]
	private Texture blankSprite;

	public GameControllerScript gs;

	private void Update()
	{
	}
}
