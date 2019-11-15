using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    private Rigidbody playerRB;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRB.AddForce(Vector3.forward * speed * forwardInput, ForceMode.Force);

        float horizontalInput = Input.GetAxis("Horizontal");

        playerRB.AddForce(Vector3.right * speed * horizontalInput, ForceMode.Force);


    }
}
