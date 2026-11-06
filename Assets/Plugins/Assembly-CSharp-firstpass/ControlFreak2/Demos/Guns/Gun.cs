using UnityEngine;

namespace ControlFreak2.Demos.Guns
{
	public class Gun : MonoBehaviour
	{
		public ParticleSystem shotParticles;

		public AudioClip shotSound;

		public AudioClip emptySound;

		public AudioClip reloadSound;

		private bool isFiring;

		public float shotInterval;

		private float lastShotTime;

		public bool unlimitedAmmo;

		public int bulletCapacity;

		public int bulletCount;

		public Transform projectileOrigin;

		public Bullet bulletPrefab;

		private AudioSource audioSource;

		private void OnEnable()
		{
		}

		public void SetTriggerState(bool fire)
		{
		}

		private void FixedUpdate()
		{
		}

		public void Reload()
		{
		}

		private void FireBullet()
		{
		}
	}
}
