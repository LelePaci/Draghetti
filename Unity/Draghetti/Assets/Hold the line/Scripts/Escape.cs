using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            PlayerPrefs.SetInt("HoldTheLineDone", 1);
            SceneManager.LoadScene("Lobby", LoadSceneMode.Single);
        }
    }
}
