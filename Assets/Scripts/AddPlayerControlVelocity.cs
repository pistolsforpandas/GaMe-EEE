/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlVelocity : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float torque;
    [SerializeField]
    Vector3 v3ForceForwardBack;
    [SerializeField]
    Vector3 v3ForceLeftRight;
    [SerializeField]
    Vector3 v3RotationSpeed;
    [SerializeField]
    KeyCode keyForward;
    [SerializeField]
    KeyCode keyBackwards;
    [SerializeField]
    KeyCode keyRight;
    [SerializeField]
    KeyCode keyLeft;
    [SerializeField]
    KeyCode keyRLeft;
    [SerializeField]
    KeyCode keyRRight;
    Vector3 movement;

    //Make sure you attach a Rigidbody in the Inspector of this GameObject
    Rigidbody m_Rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (Input.GetKey(keyForward))
            rigidBody.velocity += v3ForceForwardBack;

            if (Input.GetKey(keyBackwards))
            rigidBody.velocity -= v3ForceForwardBack;

           

        if (Input.GetKey(keyRight))
            rigidBody.velocity += v3ForceLeftRight;


        if (Input.GetKey(keyLeft))
            rigidBody.velocity -= v3ForceLeftRight;

        



        if (Input.GetKey(keyRLeft))
        {

            *//*Quaternion deltaRotation = Quaternion.Euler(-v3RotationSpeed * Time.deltaTime);
            rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);*//*
            rigidBody.MoveRotation(Quaternion.LookRotation(movement));

        }
        else if (Input.GetKey(keyRRight))
        {
           
            Quaternion deltaRotation = Quaternion.Euler(v3RotationSpeed * Time.deltaTime);
            rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
        }







    }
}*/