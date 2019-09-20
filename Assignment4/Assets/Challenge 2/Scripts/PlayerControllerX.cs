using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    /*
    Warren Guiles
     PlayerControllerX
    Assignment 4
    This script lets the player press the space bar in order to spawn a dog.
     Here I added 2 member variables that will keep track
    of the cooldown time between dog spawns
     */
    public GameObject dogPrefab;
    private float timeCounter = 0.0f;
    public float reloadTime;

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;

        // On spacebar press, send dog if enough time has passed
        if (Input.GetKeyDown(KeyCode.Space) && timeCounter >= reloadTime)
        {
            timeCounter = 0.0f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
