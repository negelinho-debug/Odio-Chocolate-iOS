using UnityEngine;

namespace ControlFreak2.Demos.Characters
{
	public class DualStickShooterCharaMotor : MonoBehaviour
	{
		public enum WorldPlane
		{
			XZ = 0,
			XY = 1,
			ZY = 2
		}

		public Transform cameraTransform;

		public string moveHorzAxis;

		public string moveVertAxis;

		public string aimHorzAxis;

		public string aimVertAxis;

		private Rigidbody rb;

		public float forwardSpeed;

		public float strafeSpeed;

		public float backwardSpeed;

		public float turnSpeed;

		public float orientationOffset;

		public Vector3 gravity;

		private Vector3 worldVel;

		private Vector3 localDir;

		private float moveTilt;

		private float worldMoveAngle;

		private float worldOrientAngle;

		private float inputMoveAngle;

		private float inputMoveTilt;

		private float inputAimAngle;

		private float inputAimTilt;

		private void OnEnable()
		{
		}

		private void MoveOrientation(float angle)
		{
		}

		private void MovePosition(Vector3 worldPos)
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		public float GetOrientAngle()
		{
			return 0f;
		}

		public Vector3 GetLocalDir()
		{
			return default;
		}

		public void SetWorldInput(float moveAngle, float moveTilt, float aimAngle, float aimTilt)
		{
		}

		public void SetCameraRelativeInput(Transform camTr, float moveX, float moveY, float aimX, float aimY)
		{
		}

		public static float GetAngleFromDir(Vector3 dir, WorldPlane plane, float fallbackAngle)
		{
			return 0f;
		}

		public static Vector3 GetWorldVecFromCamera(Transform camTr, float x, float y, WorldPlane plane)
		{
			return default;
		}

		public static float GetJoyAngleAndTilt(Transform camTr, float x, float y, WorldPlane plane, out float tilt)
		{
			tilt = default;
			return 0f;
		}

		public static Vector3 AngleToWorldVec(float angle, WorldPlane plane)
		{
			return default;
		}

		public static Vector3 RotateVecOnPlane(Vector3 v, float angle, WorldPlane plane)
		{
			return default;
		}
	}
}
