using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JumpingScript : MonoBehaviour
{
    public float forcaPulo = 7f;
    public float distChao = 0.75f;
    public bool pulo;

    Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    bool isGrounded()
    {
        return Physics.Raycast(transform.position + Vector3.up * 0.01f, Vector3.down, distChao);
    }

    void Update()
    {
        pulo = isGrounded();
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            rigidBody.velocity = Vector3.up * forcaPulo;
        }
    }
}
