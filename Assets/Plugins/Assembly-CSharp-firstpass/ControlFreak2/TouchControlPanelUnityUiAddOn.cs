using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ControlFreak2
{
	[ExecuteInEditMode]
	public class TouchControlPanelUnityUiAddOn : Graphic, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		private TouchControlPanel panel;

		private TouchControlPanel.SystemTouchEventData eventData;

		public bool IsConnectedToPanel()
		{
			return false;
		}

		private TouchControlPanel.SystemTouchEventData TranslateEvent(PointerEventData data)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public override bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return false;
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData data)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData data)
		{
		}

		void IDragHandler.OnDrag(PointerEventData data)
		{
		}

		protected override void UpdateGeometry()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void DrawGizmos(bool selected)
		{
		}
	}
}
