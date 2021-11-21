using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  [SerializeField]
  private int punteggio;

  public int getPunteggio(){
      return punteggio;
  }
}
