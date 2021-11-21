using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingTarget : MonoBehaviour
{
    [SerializeField]
    private GameObject pos1;
    [SerializeField]
    private GameObject pos2;
    [SerializeField]
    private float speed;
    private int stepNumber = 1000;
    private bool forward = true;
    void Update()
    {
        float step = speed * Time.deltaTime;
        if(forward){
            transform.position = Vector3.MoveTowards(transform.position,pos1.transform.position,step);
            stepNumber--;
            if(stepNumber<=0){
                stepNumber = 1000;
                forward = false;
            }
            //Debug.Log("CAIO");
        }else{
            transform.position = Vector3.MoveTowards(transform.position,pos2.transform.position,step);
            stepNumber--;
            if(stepNumber<=0){
                stepNumber = 1000;
                forward = true;
            }
            //Debug.Log("SEMPRONIO");
        }
    }
}
