using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkOk : MonoBehaviour
{
    int nlevel;
    LockedLevel lmaker;
    public string combination;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ButtonPressed);
    }

    public void loadLevel(int nlevel, string combination, LockedLevel lmaker)
    {
        this.nlevel = nlevel;
        this.lmaker = lmaker;
        this.combination = combination;
    }
    void ButtonPressed()
    {
        GlobalVariables gv = GameObject.Find("MiniManager").GetComponent<GlobalVariables>();
        int n1 = int.Parse(combination[0].ToString());
        int n2 = int.Parse(combination[1].ToString());
        int n3 = int.Parse(combination[2].ToString());
        int n4 = int.Parse(combination[3].ToString());
        Image img1 = GameObject.Find("img1").GetComponent<Image>();
        Image img2 = GameObject.Find("img2").GetComponent<Image>();
        Image img3 = GameObject.Find("img3").GetComponent<Image>();
        Image img4 = GameObject.Find("img4").GetComponent<Image>();
        if (gv.dig1 == n1){
            img1.sprite = gv.correct;
        }
        else if (gv.dig1 == n2){
            img1.sprite = gv.partial;
        }
        else if (gv.dig1 == n3){
            img1.sprite = gv.partial;
        }
        else if (gv.dig1 == n4){
            img1.sprite = gv.partial;
        }
        else{
            img1.sprite = gv.wrong;
        }
        if (gv.dig2 == n1){
            img2.sprite = gv.partial;
        }
        else if (gv.dig2 == n2){
            img2.sprite = gv.correct;
        }
        else if (gv.dig2 == n3){
            img2.sprite = gv.partial;
        }
        else if (gv.dig2 == n4){
            img2.sprite = gv.partial;
        }
        else{
            img2.sprite = gv.wrong;
        }
        if (gv.dig3 == n1){
            img3.sprite = gv.partial;
        }
        else if (gv.dig3 == n2){
            img3.sprite = gv.partial;
        }
        else if (gv.dig3 == n3){
            img3.sprite = gv.correct;
        }
        else if (gv.dig3 == n4){
            img3.sprite = gv.partial;
        }
        else{
            img3.sprite = gv.wrong;
        }
        if (gv.dig4 == n1){
            img4.sprite = gv.partial;
        }
        else if (gv.dig4 == n2){
            img4.sprite = gv.partial;
        }
        else if (gv.dig4 == n3){
            img4.sprite = gv.partial;
        }
        else if (gv.dig4 == n4){
            img4.sprite = gv.correct;
        }
        else{
            img4.sprite = gv.wrong;
        }
        if (gv.dig1 == n1 && gv.dig2 == n2 && gv.dig3 == n3 && gv.dig4 == n4){
            lmaker.EndLevel(nlevel);
        }
    }
}
