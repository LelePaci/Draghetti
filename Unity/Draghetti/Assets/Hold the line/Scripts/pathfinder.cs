using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfinder : MonoBehaviour
{
    string[] pattern1 = {"piatt2", "piatt13", "piatt16", "piatt15","piatt28","piatt29","piatt30","piatt31","piatt32","piatt33","piatt38","piatt47","piatt52"};
    string[] pattern2 = {"piatt55","piatt44","piatt41","piatt40","piatt31","piatt26","piatt25","piatt18","piatt11","piatt10","piatt5"};
    string[] pattern3 = {"piatt56","piatt43","piatt42","piatt29","piatt28","piatt15","piatt14","piatt1"};
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(1,3);
        string[] tmp = {};
        GameObject piattaforma = null;
        if (rand == 1){
            tmp = pattern1;
        } else if (rand == 2){
            tmp = pattern2;
        } else if (rand == 3){
            tmp = pattern3;
        }
        for (int i = 0; i<tmp.Length; i++){
            piattaforma = GameObject.Find(tmp[i]);
            piattaforma.GetComponent<Piattaforma>().giusto = true;
        }
    }
}
