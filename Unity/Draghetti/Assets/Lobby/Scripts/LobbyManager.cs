using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LobbyManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txtLocked,txtCreta,txtLine,txtTarget,txtComplete,txtSimon;
    [SerializeField]
    private GameObject doorLocked,doorCreta,doorLine,doorTarget,doorComplete,doorSimon, player, respawnpoint, doorslide;
    void Start()
    {
        int completi = 0;
        if (GameVariables.lockedDone) {
            txtLocked.color = Color.red;
            doorLocked.SetActive(true);
            completi++;
        }
        if (GameVariables.cretaDone){
            txtCreta.color = Color.red;
            doorCreta.SetActive(true);
            completi++;
        }
        if (GameVariables.lineDone){
            txtLine.color = Color.red;
            doorLine.SetActive(true);
            completi++;
        }
        if (GameVariables.targetDone){
            txtTarget.color = Color.red;
            doorTarget.SetActive(true);
            completi++;
        }
        if (GameVariables.simonDone){
            txtSimon.color = Color.red;
            doorSimon.SetActive(true);
            completi++; 
        }
        txtComplete.text = "Completa giochi: " + completi + "/5";
        if (completi == 5){
            txtComplete.color = Color.green;
            doorComplete.SetActive(false);
        }
        if (completi > 0){
            player.transform.position = respawnpoint.transform.position;
            doorslide.GetComponent<SC_SlidingDoor>().enabled = false;
        }
    }
}
