using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerScript : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_Text timer;
    int tempo = 60;
    void Start()
    {
        timer=GameObject.Find("Timer").GetComponent<TMP_Text>();
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        tempo--;
        string min = "";
        string sec = "";
        if (tempo < 600){
            min = "0" + (Mathf.Floor(tempo/60));
        }
        else {
            min = "" + (Mathf.Floor(tempo/60));
        }
        int seconds = tempo%60;
        if (seconds < 10){
            sec = "0" + seconds;
        }
        else
        {
            sec = "" + seconds;
        }
        timer.text = min + ":" + seconds;
    }
}
