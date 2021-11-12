using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    //Rigidbody objRigidBody;
    [SerializeField] float rotationSpeed = 0.1f;
    //Vector3 rotationVelocity;

    // Start is called before the first frame update
    void Start()
    {
        //objRigidBody = GetComponent<Rigidbody>();
        //rotationVelocity = new Vector3(0,rotationSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion rotation = Quaternion.Euler(rotationVelocity * Time.fixedDeltaTime);
        //objRigidBody.MoveRotation(objRigidBody.rotation * rotation);

        transform.Rotate(0f, rotationSpeed, 0f);
    }
}
