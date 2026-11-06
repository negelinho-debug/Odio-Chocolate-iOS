using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace TMPro.Examples
{
	public class VertexJitter : MonoBehaviour
	{
		[StructLayout((LayoutKind)0, Size = 12)]
		private struct VertexAnim
		{
			public float angleRange;

			public float angle;

			public float speed;
		}

		public float AngleMultiplier;

		public float SpeedMultiplier;

		public float CurveScale;

		private TMP_Text m_TextComponent;

		private bool hasTextChanged;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void ON_TEXT_CHANGED(Object obj)
		{
		}

		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
}
