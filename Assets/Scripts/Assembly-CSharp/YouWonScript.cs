using UnityEngine;
using UnityEngine.Video;

public class YouWonScript : MonoBehaviour
{
	public string LoadScene;

	public VideoPlayer over;

	public VideoClip clip1;

	public VideoClip clip2;

	public GameObject toScale;

	private void Start()
	{
	}

	private void VideoFinished(VideoPlayer vp)
	{
	}

	private void OnDestroy()
	{
	}
}
