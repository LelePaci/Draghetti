using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LockedLevel : MonoBehaviour
{
    Camera miniCamera;
    GameObject player;
    Canvas miniCanvas;

    // Start is called before the first frame update
    void Start()
    {
        miniCamera = GameObject.Find("MinigameCamera").GetComponent<Camera>();
        player = GameObject.Find("FirstPersonController");
        miniCanvas = GameObject.Find("MinigameCanvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLevel(int nlevel)
    {
        player.SetActive(false);
        miniCamera.enabled = true;
        miniCanvas.enabled = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        string random = Random.Range(1000,9999).ToString();
        GlobalVariables gv = GameObject.Find("MiniManager").GetComponent<GlobalVariables>();
        gv.dig1 = 0;
        gv.dig2 = 0;
        gv.dig3 = 0;
        gv.dig4 = 0;
        gv.RefreshNumbers();
        checkOk c = GameObject.Find("BtnOk").GetComponent<checkOk>();
        c.loadLevel(nlevel, random,this);
    }

    public void EndLevel(int nlevel){
        TMP_Text text = null;
        GameObject door = null;
        switch(nlevel){
            case 1:
                text = GameObject.Find("1levelText").GetComponent<TMP_Text>();
                door = GameObject.Find("1levelDoor");
                break;
            case 2:
                text = GameObject.Find("2levelText").GetComponent<TMP_Text>();
                door = GameObject.Find("2levelDoor");
                break;
            case 3:
                text = GameObject.Find("3levelText").GetComponent<TMP_Text>();
                door = GameObject.Find("3levelDoor");
                break;
        }
        text.color = Color.green;
        door.SetActive(false);
        miniCamera.enabled = false;
        miniCanvas.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.SetActive(true);
    }
}
