using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaRiservata : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
           other.transform.position = GameObject.Find("RespawnPoint").transform.position;
        }
    }
}
