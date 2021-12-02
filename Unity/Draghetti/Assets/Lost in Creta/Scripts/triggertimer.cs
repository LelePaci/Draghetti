using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertimer : MonoBehaviour
{ 
    public bool acceso=false;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            if(!acceso){
                acceso=true;
                timerScript tmp = GameObject.Find("LabManager").GetComponent<timerScript>();
                StartCoroutine(tmp.waiter());
            }
        }
    }
}
