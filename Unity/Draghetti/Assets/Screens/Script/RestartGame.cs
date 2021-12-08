using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartGame : MonoBehaviour
{
    [SerializeField]
    private TMP_Text grazie, quellibbelli;
    void Start()
    {
        StartCoroutine(restart());
    }
    public IEnumerator restart(){
        yield return new WaitForSeconds(1);
        grazie.text = "Grazie per aver giocato!!!";
        yield return new WaitForSeconds(2);
        quellibbelli.text = "Gioco realizzato da:\n- Samuele Mornatta\n- Emanuele Paci\n- Christian Baccaglini\n- Cristian Consonni\n- Edoardo Russo";
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
