using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    /*
    Warren Guiles
    CIS_456_Assignment_4

    This script makes sure that objects out of the player's view 
    and/or objects out of bounds are destroyed 
    as to protect performance

     */
public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
