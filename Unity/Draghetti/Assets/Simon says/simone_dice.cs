using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class simone_dice : MonoBehaviour
{
    [SerializeField]
    Sprite stellaRossa = null;
    [SerializeField]
    Sprite cerchioBlu = null;
    [SerializeField]
    Sprite quadratoVerde = null;
    [SerializeField]
    Sprite triangoloGiallo = null;
    [SerializeField]
    Sprite vuoto = null;

    [SerializeField]
    TMP_Text preparati = null;

    [SerializeField]
    Image image = null;

    [SerializeField]
    TMP_Text livelloCorrente = null;

    private char[] colori = new char[6];
    private int livello = 0;
    int numColore;
    bool canPress;
    void Start()
    {
        image.sprite = vuoto;
        canPress = false;
        numColore = 0;
        preparati.text = "Preparati";
        generaColori();
        StartCoroutine(waitSimon());
    }
    void Update()
    {
        livelloCorrente.text = "Livello attuale: " + (livello + 1) + "/3";
    }
    private void generaColori()
    {
        for (int i = 0; i < colori.Length; i++)
        {
            switch (Random.Range(0, 3))
            {
                case 0:
                    colori[i] = 'r';
                    break;
                case 1:
                    colori[i] = 'g';
                    break;
                case 2:
                    colori[i] = 'b';
                    break;
                case 3:
                    colori[i] = 'v';
                    break;
            }
        }
    }

    public IEnumerator waitSimon()
    {
        yield return new WaitForSeconds(3);
        preparati.text = "";
        for (int i = 0; i < colori.Length; i++)
        {
            switch (colori[i])
            {
                case 'r':
                    image.sprite = stellaRossa;
                    break;
                case 'g':
                    image.sprite = triangoloGiallo;
                    break;
                case 'b':
                    image.sprite = cerchioBlu;
                    break;
                case 'v':
                    image.sprite = quadratoVerde;
                    break;
            }
            yield return new WaitForSeconds(1);
            image.sprite = vuoto;
            yield return new WaitForSeconds(1);
        }
        canPress = true;
    }

    public bool controllaColore(char c)
    {
        if (canPress)
        {
            if (numColore < colori.Length)
            {
                if (c == colori[numColore])
                {
                    numColore++;
                    if (numColore == colori.Length)
                    {
                        if (livello == 2)
                        {
                            GameVariables.simonDone = true;
                            SceneManager.LoadScene("Lobby", LoadSceneMode.Single);
                        }
                        else
                        {
                            livello += 1;
                            Start();
                        }
                    }
                }
                else
                {
                    preparati.text = "Hai sbagliato, ricomincia";
                    Start();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return false;
    }
}
