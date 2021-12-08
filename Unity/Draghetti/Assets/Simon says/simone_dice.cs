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
    Image fatto1, fatto2, fatto3, fatto4, fatto5, fatto6;

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
        fatto1.sprite = vuoto;
        fatto2.sprite = vuoto;
        fatto3.sprite = vuoto;
        fatto4.sprite = vuoto;
        fatto5.sprite = vuoto;
        fatto6.sprite = vuoto;
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
            switch (Random.Range(0, 4))
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

                    switch (c)
                    {
                        case 'r':
                            switch (numColore)
                            {
                                case 0:
                                    fatto1.sprite = stellaRossa;
                                    break;
                                case 1:
                                    fatto2.sprite = stellaRossa;
                                    break;
                                case 2:
                                    fatto3.sprite = stellaRossa;
                                    break;
                                case 3:
                                    fatto4.sprite = stellaRossa;
                                    break;
                                case 4:
                                    fatto5.sprite = stellaRossa;
                                    break;
                                case 5:
                                    fatto6.sprite = stellaRossa;
                                    break;
                            }
                            break;
                        case 'g':
                            switch (numColore)
                            {
                                case 0:
                                    fatto1.sprite = triangoloGiallo;
                                    break;
                                case 1:
                                    fatto2.sprite = triangoloGiallo;
                                    break;
                                case 2:
                                    fatto3.sprite = triangoloGiallo;
                                    break;
                                case 3:
                                    fatto4.sprite = triangoloGiallo;
                                    break;
                                case 4:
                                    fatto5.sprite = triangoloGiallo;
                                    break;
                                case 5:
                                    fatto6.sprite = triangoloGiallo;
                                    break;
                            }
                            break;
                        case 'b':
                            switch (numColore)
                            {
                                case 0:
                                    fatto1.sprite = cerchioBlu;
                                    break;
                                case 1:
                                    fatto2.sprite = cerchioBlu;
                                    break;
                                case 2:
                                    fatto3.sprite = cerchioBlu;
                                    break;
                                case 3:
                                    fatto4.sprite = cerchioBlu;
                                    break;
                                case 4:
                                    fatto5.sprite = cerchioBlu;
                                    break;
                                case 5:
                                    fatto6.sprite = cerchioBlu;
                                    break;
                            }
                            break;
                        case 'v':
                            switch (numColore)
                            {
                                case 0:
                                    fatto1.sprite = quadratoVerde;
                                    break;
                                case 1:
                                    fatto2.sprite = quadratoVerde;
                                    break;
                                case 2:
                                    fatto3.sprite = quadratoVerde;
                                    break;
                                case 3:
                                    fatto4.sprite = quadratoVerde;
                                    break;
                                case 4:
                                    fatto5.sprite = quadratoVerde;
                                    break;
                                case 5:
                                    fatto6.sprite = quadratoVerde;
                                    break;
                            }
                            break;
                    }
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
