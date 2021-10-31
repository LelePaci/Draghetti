using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    public int dig1 = 0;
    public int dig2 = 0;
    public int dig3 = 0;
    public int dig4 = 0;
    public bool haskey1 = false;
    public bool haskey2 = false;
    public bool haskey3 = false;
    public Sprite num0;
    public Sprite num1;
    public Sprite num2;
    public Sprite num3;
    public Sprite num4;
    public Sprite num5;
    public Sprite num6;
    public Sprite num7;
    public Sprite num8;
    public Sprite num9;
    public Sprite correct;
    public Sprite partial;
    public Sprite wrong;

    public void RefreshNumbers()
    {
        Image d1 = GameObject.Find("Num1").GetComponent<Image>();
        Image d2 = GameObject.Find("Num2").GetComponent<Image>();
        Image d3 = GameObject.Find("Num3").GetComponent<Image>();
        Image d4 = GameObject.Find("Num4").GetComponent<Image>();
        switch(dig1){
            case 0:
                d1.sprite = num0;
            break;
            case 1:
                d1.sprite = num1;
            break;
            case 2:
                d1.sprite = num2;
            break;
            case 3:
                d1.sprite = num3;
            break;
            case 4:
                d1.sprite = num4;
            break;
            case 5:
                d1.sprite = num5;
            break;
            case 6:
                d1.sprite = num6;
            break;
            case 7:
                d1.sprite = num7;
            break;
            case 8:
                d1.sprite = num8;
            break;
            case 9:
                d1.sprite = num9;
            break;
        }
        switch(dig2){
            case 0:
                d2.sprite = num0;
            break;
            case 1:
                d2.sprite = num1;
            break;
            case 2:
                d2.sprite = num2;
            break;
            case 3:
                d2.sprite = num3;
            break;
            case 4:
                d2.sprite = num4;
            break;
            case 5:
                d2.sprite = num5;
            break;
            case 6:
                d2.sprite = num6;
            break;
            case 7:
                d2.sprite = num7;
            break;
            case 8:
                d2.sprite = num8;
            break;
            case 9:
                d2.sprite = num9;
            break;
        }
        switch(dig3){
            case 0:
                d3.sprite = num0;
            break;
            case 1:
                d3.sprite = num1;
            break;
            case 2:
                d3.sprite = num2;
            break;
            case 3:
                d3.sprite = num3;
            break;
            case 4:
                d3.sprite = num4;
            break;
            case 5:
                d3.sprite = num5;
            break;
            case 6:
                d3.sprite = num6;
            break;
            case 7:
                d3.sprite = num7;
            break;
            case 8:
                d3.sprite = num8;
            break;
            case 9:
                d3.sprite = num9;
            break;
        }
        switch(dig4){
            case 0:
                d4.sprite = num0;
            break;
            case 1:
                d4.sprite = num1;
            break;
            case 2:
                d4.sprite = num2;
            break;
            case 3:
                d4.sprite = num3;
            break;
            case 4:
                d4.sprite = num4;
            break;
            case 5:
                d4.sprite = num5;
            break;
            case 6:
                d4.sprite = num6;
            break;
            case 7:
                d4.sprite = num7;
            break;
            case 8:
                d4.sprite = num8;
            break;
            case 9:
                d4.sprite = num9;
            break;
        }
    }
}
