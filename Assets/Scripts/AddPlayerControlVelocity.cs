using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlVelocity : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float torque;

    [SerializeField]
    Vector3 v3RotationSpeed;
    [SerializeField]
    KeyCode keyForward;
    [SerializeField]
    KeyCode keyBackwards;
    [SerializeField]
    KeyCode keyLeft;
    [SerializeField]
    KeyCode keyRight;
    [SerializeField]
    Vector3 speed;

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

        /*Vector3 movement = rigidBody.transform.rotation * speed;

        if (Input.GetKey(keyForward))
            rigidBody.AddForce(rigidBody.velocity += movement);

        if (Input.GetKey(keyBackwards))
            rigidBody.AddForce(rigidBody.velocity -= movement);*/


        //We dont even need left/right movement, just rotate
        /* if (Input.GetKey(keyRight))
             rigidBody.velocity += v3ForceLeftRight;


         if (Input.GetKey(keyLeft))
             rigidBody.velocity -= v3ForceLeftRight;*/





        if (Input.GetKey(keyLeft))
        {
            //wtf is a Quaternion?
            Quaternion deltaRotation = Quaternion.Euler(-v3RotationSpeed * Time.deltaTime);
            rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
            
            

        }
        else if (Input.GetKey(keyRight))
        {

            Quaternion deltaRotation = Quaternion.Euler(v3RotationSpeed * Time.deltaTime);
            rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
            
        }







    }
}