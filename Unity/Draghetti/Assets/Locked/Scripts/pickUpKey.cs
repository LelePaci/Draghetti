using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpKey : Interactable
{
    public int keynum = 0;
    public override string GetDescription()
    {
        return "Press [E] to Pick up Key";
    }

    public override void Interact()
    {
        GlobalVariables gv = GameObject.Find("MiniManager").GetComponent<GlobalVariables>();
        GameObject key = null;
        switch (keynum){
            case 1:
                gv.haskey1 = true;
                key = GameObject.Find("key1");
            break;
            case 2:
                gv.haskey2 = true;
                key = GameObject.Find("key2");
            break;
            case 3:
                gv.haskey3 = true;
                key = GameObject.Find("key3");
            break;
        }
        key.SetActive(false);
    }
}
