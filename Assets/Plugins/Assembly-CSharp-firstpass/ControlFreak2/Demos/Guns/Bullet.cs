using UnityEngine;

namespace ControlFreak2.Demos.Guns
{
	public class Bullet : MonoBehaviour
	{
		private Gun gun;

		private Rigidbody rigidBody;

		public float maxLifetime;

		private float lifetime;

		public float initialSpeed;

		public float maxSpeed;

		public float accel;

		private float speed;

		private void OnEnable()
		{
		}

		public void Init(Gun gun)
		{
		}

		public Gun GetGun()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}
	}
}
