using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piattaforma : MonoBehaviour
{
    public bool giusto=false;//variabile per controllo posizione
    public Material rosso;
    public Material verde;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
           if(giusto==true) {
               this.GetComponent<MeshRenderer>().material = verde; 
           }else{
               this.GetComponent<MeshRenderer>().material = rosso; 
               other.transform.position = GameObject.Find("RespawnPoint").transform.position;
           }
        }
    }
}
