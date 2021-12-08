using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private float damage;
    [SerializeField]
    private float torque;
    [SerializeField]
    private Rigidbody arigidbody;
    private string enemyTag;
    private bool didHit;

    public void setEnemyTag(string enemyTag){
        this.enemyTag = enemyTag;
    }

    public void Flight(Vector3 forza){
        arigidbody.isKinematic = false;
        arigidbody.AddForce(forza,ForceMode.Impulse);
        arigidbody.AddTorque(transform.right*torque);
        transform.SetParent(null);
    }

    void OnTriggerEnter(Collider other) {
        if(didHit) return;
        didHit = true;
        if(other.CompareTag(enemyTag)){
            Target bersaglio = other.gameObject.GetComponent<Target>();
            int punteggio = bersaglio.getPunteggio();
            Punteggio ciccio = GameObject.Find("ScoreManager").GetComponent<Punteggio>();
            ciccio.addPunteggio(punteggio);
        }
        arigidbody.velocity = Vector3.zero;
        arigidbody.angularVelocity = Vector3.zero;
        arigidbody.isKinematic = true;
        transform.SetParent(other.transform);
    }
}
