using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerScript : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_Text timer;
    [SerializeField]
    int tempo = 60;
    int temposottr;
    void Start()
    {
        timer=GameObject.Find("Timer").GetComponent<TMP_Text>();
        string min = "";
        string sec = "";
        temposottr = tempo;
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
        timer.text = min + ":" + sec;
    }
    public IEnumerator waiter()
    {
        while (temposottr > 0){
            yield return new WaitForSeconds(1);
            temposottr--;
            string min = "";
            string sec = "";
            if (temposottr < 600){
                min = "0" + (Mathf.Floor(temposottr/60));
            }
            else {
                min = "" + (Mathf.Floor(temposottr/60));
            }
            int seconds = temposottr%60;
            if (seconds < 10){
                sec = "0" + seconds;
            }
            else
            {
                sec = "" + seconds;
            }
            timer.text = min + ":" + sec;
        }
        GameObject ply = GameObject.Find("FirstPersonController");
        GameObject respawn = GameObject.Find("RespawnPoint");
        ply.transform.position = respawn.transform.position;
        GameObject trigger = GameObject.Find("timetrigger");
        trigger.GetComponent<triggertimer>().acceso = false;
        Start();
    }
}
