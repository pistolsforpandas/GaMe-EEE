/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlVelocityRotate : MonoBehaviour
{
    
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    [SerializeField]
    float RotateSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.forward();

        if (Input.GetKey(keyPositive))
            *//* transform.Rotate(-Vector3.up * RotateSpeed);*//*
            GetComponent<Rigidbody>().rotation += RotateSpeed;


        else if (Input.GetKey(keyNegative))
            transform.Rotate(Vector3.up * RotateSpeed);


    }
}*/