using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockPadlock : Interactable
{
    public override string GetDescription()
    {
        return "Press [E] to Unlock Padlock";
    }

    public override void Interact()
    {
        GlobalVariables gv = GameObject.Find("MiniManager").GetComponent<GlobalVariables>();
        GameObject door = GameObject.Find("EscapeDoor");
        if (gv.haskey1 && gv.haskey2 && gv.haskey3){
            door.SetActive(false);
        }
    }
}
