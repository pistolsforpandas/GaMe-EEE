using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceTrack : MonoBehaviour
{



    public Rigidbody rigidBody;
    public float torque;

    /*[SerializeField]
    Vector3 v3RotationSpeed;*/
    [SerializeField]
    KeyCode keyRotateP;
    [SerializeField]
    KeyCode keyRotateM;
    [SerializeField]
    KeyCode keyForwards;
    [SerializeField]
    KeyCode keyBack;
    /*  [SerializeField]
      KeyCode keyLeft;
      [SerializeField]
      KeyCode keyRight;*/
    [SerializeField]
    Vector3 speed;

    //Make sure you attach a Rigidbody in the Inspector of this GameObject
    Rigidbody m_Rigidbody;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = rigidBody.transform.rotation * speed;

        if (Input.GetKey(keyForwards))
            rigidBody.AddForce(rigidBody.velocity += movement);

        if (Input.GetKey(keyBack))
            rigidBody.AddForce(rigidBody.velocity -= movement);

        if (Input.GetKey(keyRotateP))
            rigidBody.AddForce(rigidBody.velocity += movement);

        if (Input.GetKey(keyRotateM))
            rigidBody.AddForce(rigidBody.velocity -= movement);

        //We dont even need left/right movement, just rotate
        /* if (Input.GetKey(keyRight))
             rigidBody.velocity += v3ForceLeftRight;


         if (Input.GetKey(keyLeft))
             rigidBody.velocity -= v3ForceLeftRight;*/





        /*if (Input.GetKey(keyLeft))
        {
            //wtf is a Quaternion?
            Quaternion deltaRotation = Quaternion.Euler(-v3RotationSpeed * Time.deltaTime);
            rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);



        }
        else if (Input.GetKey(keyRight))
        {

            Quaternion deltaRotation = Quaternion.Euler(v3RotationSpeed * Time.deltaTime);
            rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);

        }*/

    }
}
