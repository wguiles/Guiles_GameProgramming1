using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    		/*
		 * Warren Guiles
		 * DestroyObjectX
		 * Assignment 7
		 * This script destroys the object it's attached to 2 seconds after it's created.
		 */
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
