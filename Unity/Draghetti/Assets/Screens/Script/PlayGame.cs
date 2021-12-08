using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void Play()
    {
        SceneManager.LoadScene("Lobby", LoadSceneMode.Single);
        GameVariables.lockedDone = false;
        GameVariables.cretaDone = false;
        GameVariables.lineDone = false;
        GameVariables.targetDone = false;
        GameVariables.simonDone = false;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
