using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MouseoverScript : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	public UnityEvent mouseOver;

	public UnityEvent mouseLeave;

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
