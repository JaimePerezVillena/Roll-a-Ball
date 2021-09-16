using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{

    private RigidBody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        // Cuerpo de funcion
        Vector2 movementVector = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {

    }
}
