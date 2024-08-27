using UnityEngine;
using UnityEngine.UIElements;


public class Teleporter : MonoBehaviour
{
    
    public Vector3Data teleportDestination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportDestination.value;
        }
    }
}
