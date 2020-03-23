using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlVelocitymk2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    [SerializeField]
    KeyCode keyRLeft;
    [SerializeField]
    KeyCode keyRRight;
    [SerializeField]
    Vector3 v3RotationSpeed;
    Vector3 movement;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        movement = transform.worldToLocalMatrix.inverse * movement;
        Rigidbody.MovePosition(transform.position + movement);
    }
}