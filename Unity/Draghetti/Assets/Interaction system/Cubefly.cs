using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubefly : Interactable
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    void Start() {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    public override string GetDescription()
    {
        return "Press [E] to make the cube fly";
    }

    public override void Interact()
    {
        m_Rigidbody.AddForce(transform.up * m_Thrust);
    }
}
