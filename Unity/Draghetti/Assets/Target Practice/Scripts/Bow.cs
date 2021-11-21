using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    [SerializeField]
    private float reloadTime;
    [SerializeField]
    private Arrow freccia;
    [SerializeField]
    private Transform spawnPoint;
    private Arrow currentArrow;
    private string enemyTag;
    private bool isReloading;
    public void setEnemyTag(string enemyTag){
        this.enemyTag = enemyTag;
    }

    public void Reload(){
        if(isReloading || currentArrow!=null) return;
        isReloading = true;
        StartCoroutine(reloadAfterTime());
    }

    private IEnumerator reloadAfterTime(){
        yield return new WaitForSeconds(reloadTime);
        currentArrow = Instantiate(freccia,spawnPoint);
        currentArrow.transform.Rotate(0f,90f,90f);
        currentArrow.transform.localPosition = Vector3.zero;
        currentArrow.setEnemyTag(enemyTag);
        isReloading = false;
    }

    public void Fire(float firePower){
        if(isReloading || currentArrow==null) return;
        var force = spawnPoint.TransformDirection(Vector3.forward*firePower);
        currentArrow.Flight(force);
        currentArrow = null;
        Reload();
    }

    public bool isReady(){
        return(!isReloading && currentArrow!=null);
    }

}
