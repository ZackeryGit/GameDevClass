using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TiggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
