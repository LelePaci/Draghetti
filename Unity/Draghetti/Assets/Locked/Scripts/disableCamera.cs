using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Camera>().enabled = false;
    }
}
