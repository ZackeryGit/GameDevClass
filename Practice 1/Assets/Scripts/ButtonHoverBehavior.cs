using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonHoverBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public UnityEvent mouseEnter, mouseExit;

    public void OnPointerEnter(PointerEventData eventData){
        mouseEnter.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData){
        mouseExit.Invoke();
    }
}
