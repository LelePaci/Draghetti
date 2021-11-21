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
    private Rigidbody rigidbody;
    private string enemyTag;
    private bool didHit;

    public void setEnemyTag(string enemyTag){
        this.enemyTag = enemyTag;
    }

    public void Flight(Vector3 forza){
        rigidbody.isKinematic = false;
        rigidbody.AddForce(forza,ForceMode.Impulse);
        rigidbody.AddTorque(transform.right*torque);
        transform.SetParent(null);
    }

    void OnTriggerEnter(Collider other) {
        if(didHit) return;
        didHit = true;
        if(other.CompareTag(enemyTag)){

        }
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.isKinematic = true;
        transform.SetParent(other.transform);
    }
}
