using UnityEngine;

namespace ControlFreak2.Demos.Cameras
{
	public class SimpleFollowCam : MonoBehaviour
	{
		public Transform targetTransform;

		public float smoothingTime;

		private Vector3 targetOfs;

		private Vector3 smoothPosVel;

		private float camZoomFactor;

		public float perspZoomOutOffset;

		public float orthoZoomInSize;

		public float orthoZoomOutSize;

		public string camZoomDeltaAxis;

		private Camera cam;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
