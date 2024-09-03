using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectHoverBehavior : MonoBehaviour
{

    public UnityEvent mouseEnter, mouseExit;

    public void OnMouseEnter(){
        mouseEnter.Invoke();
    }

    public void OnMouseExit(){
        mouseExit.Invoke();
    }
}
