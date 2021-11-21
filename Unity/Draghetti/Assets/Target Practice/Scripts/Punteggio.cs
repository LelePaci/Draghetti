using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Punteggio : MonoBehaviour
{
    private int punteggio = 0;
    [SerializeField]
    private TMP_Text puntiText;
    public void addPunteggio(int punti){
        punteggio += punti;
    }

    void Update() {
        puntiText.text = punteggio.ToString();
        if(punteggio >= 1000){
            PlayerPrefs.SetInt("TargetPracticeDone", 1);
            SceneManager.LoadScene("Lobby", LoadSceneMode.Single);
        }
    }
}
