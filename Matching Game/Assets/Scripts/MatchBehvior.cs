using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehvior : MonoBehaviour
{

    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

    public void OnTriggerEnter(Collider other){

            // Get other object component, and check if it exists
            var tempObj = other.GetComponent<IDContainerBehavior>();
            if (tempObj == null) {return;}

            var otherID = tempObj.idObj;

            if (otherID == idObj) {
                matchEvent.Invoke();
            } else {
                noMatchEvent.Invoke();
            }
    }
}
