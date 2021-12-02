using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patternselect : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject pattern1;
    [SerializeField]
    GameObject pattern2;
    void Start()
    {
        int rand = Random.Range(0,2000);
        if (rand<1000){
            pattern1.SetActive(true);
        }else if (rand>=1000){
            pattern2.SetActive(true);
        }
    }
}
