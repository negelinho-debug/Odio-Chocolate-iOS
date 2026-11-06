using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
	private static T instance;

	public static bool isApplicationQuitting;

	public static T Instance => null;

	public static bool Exist => false;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public static bool TryGetInstance(out T result)
	{
		result = null;
		return false;
	}

	private static T CreateInstance()
	{
		return null;
	}
}
