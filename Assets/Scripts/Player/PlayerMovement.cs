using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody miRigidBody;
    [SerializeField]int speed = 1;

    private void Start()
    {
        miRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            miRigidBody.AddForce(transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            miRigidBody.AddForce(-transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            miRigidBody.AddForce(-transform.right * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            miRigidBody.AddForce(transform.right * speed);
        }
    }
}
