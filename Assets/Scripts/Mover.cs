using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Controls the movement speed of the player object.
    [SerializeField] float moveSpeed = 10.0f;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xInput = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float zInput = -Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(xInput, 0f, zInput);
    }
}
