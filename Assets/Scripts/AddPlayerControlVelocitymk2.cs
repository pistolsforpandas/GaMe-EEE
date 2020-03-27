/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlVelocitymk2 : MonoBehaviour
{
    Rigidbody rb;
    Vector3 movement;
    Camera cam;
    [SerializeField]
    float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveCharacter(movement);
        void moveCharacter(Vector3 direction) {
            rb.AddForce(direction * speed);

        }


    }
}*/