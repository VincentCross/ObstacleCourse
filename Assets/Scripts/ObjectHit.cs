using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer objRenderer;
    Rigidbody objRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        objRenderer = GetComponent<MeshRenderer>();
        objRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag != "Hit" && other.gameObject.tag == "Player") {
            objRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }

        //if (objRigidbody.constraints != RigidbodyConstraints.FreezeAll)
        //    objRigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }
}
