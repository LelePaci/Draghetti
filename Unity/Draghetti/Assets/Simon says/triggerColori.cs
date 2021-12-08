using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerColori : MonoBehaviour
{
    [SerializeField]
    char colore;
    [SerializeField]
    GameObject manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.GetComponent<simone_dice>().controllaColore(colore);
        }
    }
}
