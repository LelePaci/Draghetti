using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BowController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text firePowerText;
    [SerializeField]
    private Bow arco;
    [SerializeField]
    private string enemyTag;
    [SerializeField]
    private float maxFirePower;
    [SerializeField]
    private float firePowerSpeed;
    private float firePower;
    [SerializeField]
    private float rotateSpeed;
    [SerializeField]
    private float minRotation;
    [SerializeField]
    private float maxRotation;
    private float mouseY;
    private bool isFire;

    void Start(){
        arco.setEnemyTag(enemyTag);
        arco.Reload();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        mouseY-=Input.GetAxis("Mouse Y")*rotateSpeed;
        mouseY = Mathf.Clamp(mouseY,minRotation,maxRotation);
        //arco.transform.localRotation = Quaternion.Euler(mouseY,arco.transform.localEulerAngles.y,arco.transform.localEulerAngles.z);
        if(Input.GetMouseButtonDown(0)){
            isFire = true;
        }
        if(isFire && firePower < maxFirePower){
            firePower += Time.deltaTime * firePowerSpeed;
        }
        if(isFire && Input.GetMouseButtonUp(0)){
            arco.Fire(firePower);
            firePower = 0;
            isFire = false;
            //Debug.Log("sono entrato!");
        }
        if(isFire){
            firePowerText.text = (Mathf.Round(firePower)).ToString();
        }
    }
}
