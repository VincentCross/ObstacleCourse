using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int dropTimeSecs = 0;
    MeshRenderer objRenderer;
    Rigidbody objRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        objRenderer = GetComponent<MeshRenderer>();
        objRigidbody = GetComponent<Rigidbody>();

        objRenderer.enabled = false;
        objRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTimeSecs) {
            objRenderer.enabled = true;
            objRigidbody.useGravity = true;
        }
    }
}
