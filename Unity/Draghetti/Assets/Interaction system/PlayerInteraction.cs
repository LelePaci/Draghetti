using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance;

    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance)) {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null) {
                HandleInteraction(interactable);
            }
        }
    }

    void HandleInteraction(Interactable interactable) {
        KeyCode key = KeyCode.E;
        switch (interactable.interactionType){
            case Interactable.InteractionType.Click:
                if (Input.GetKeyDown(key)) {
                    interactable.Interact();
                }
                break;
            case Interactable.InteractionType.Hold:
                if (Input.GetKeyDown(key)) {
                    interactable.Interact();
                }
                break;
            case Interactable.InteractionType.Minigame:
                break;
            default:
                throw new System.Exception("Unsupported type of interactable");
        }
    }
}
