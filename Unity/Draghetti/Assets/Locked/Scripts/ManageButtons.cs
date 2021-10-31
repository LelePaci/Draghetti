using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ManageButtons : MonoBehaviour
{
    public int dignumber = 0;
    public bool somma = true;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ButtonPressed);
    }

    void ButtonPressed()
    {
        GlobalVariables gv = GameObject.Find("MiniManager").GetComponent<GlobalVariables>();
        switch (dignumber){
            case 1:
                if (somma){
                    gv.dig1 += 1;
                } else {
                    gv.dig1 -= 1;
                }
                if (gv.dig1 > 9){
                    gv.dig1 = 0;
                }
                if (gv.dig1 < 0){
                    gv.dig1 = 9;
                }
                gv.RefreshNumbers();
            break;
            case 2:
                if (somma){
                    gv.dig2 += 1;
                } else {
                    gv.dig2 -= 1;
                }
                if (gv.dig2 > 9){
                    gv.dig2 = 0;
                }
                if (gv.dig2 < 0){
                    gv.dig2 = 9;
                }
                gv.RefreshNumbers();
            break;
            case 3:
                if (somma){
                    gv.dig3 += 1;
                } else {
                    gv.dig3 -= 1;
                }
                if (gv.dig3 > 9){
                    gv.dig3 = 0;
                }
                if (gv.dig3 < 0){
                    gv.dig3 = 9;
                }
                gv.RefreshNumbers();
            break;
            case 4:
                if (somma){
                    gv.dig4 += 1;
                } else {
                    gv.dig4 -= 1;
                }
                if (gv.dig4 > 9){
                    gv.dig4 = 0;
                }
                if (gv.dig4 < 0){
                    gv.dig4 = 9;
                }
                gv.RefreshNumbers();
            break;
        }
    }
}
