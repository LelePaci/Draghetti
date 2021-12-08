using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeLab : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            GameVariables.cretaDone = true;
            SceneManager.LoadScene("Lobby", LoadSceneMode.Single);
        }
    }
}
