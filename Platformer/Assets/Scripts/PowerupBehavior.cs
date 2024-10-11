using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PowerupBehavior : MonoBehaviour
{

    public UnityEvent powerup, powerdown;
    public float duration = 3;
    private WaitForSeconds wfsObj;

    private void Awake(){
        wfsObj = new WaitForSeconds(duration);
    }
    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){

            StartCoroutine(pickUp(other));

        }
    }

    private IEnumerator pickUp(Collider other){

        GetComponent<Collider>().enabled = false;
        GetComponent<Renderer>().enabled = false;
        Debug.Log("Power Up!");
        powerup.Invoke();
        yield return wfsObj;

        GetComponent<Collider>().enabled = true;
        GetComponent<Renderer>().enabled = true;
        powerdown.Invoke();
        Debug.Log("Power Down!");


    }
}
