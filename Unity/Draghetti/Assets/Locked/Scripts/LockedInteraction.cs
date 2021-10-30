using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedInteraction : Interactable
{
    public int nlevel = 0;
    public override string GetDescription()
    {
        return "Press [E] to Start Minigame";
    }

    public override void Interact()
    {
        this.GetComponent<LockedLevel>().StartLevel(nlevel);
    }
}
