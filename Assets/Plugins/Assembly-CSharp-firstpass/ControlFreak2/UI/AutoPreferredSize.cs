using UnityEngine;
using UnityEngine.UI;

namespace ControlFreak2.UI
{
	[ExecuteInEditMode]
	public class AutoPreferredSize : MonoBehaviour
	{
		public LayoutElement target;

		public bool autoWidth;

		public bool autoHeight;

		public float horzPadding;

		public float vertPadding;

		public RectTransform source;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void UpdatePreferredDimensions()
		{
		}
	}
}
