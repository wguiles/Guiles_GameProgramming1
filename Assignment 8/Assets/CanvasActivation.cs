using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Warren Guiles
 * CanvasActivation.cs
 * Assignment 8
 * This script is attached to the invisible collider box and activates 
 two methods when it detects collision with the player. The first method,
 disaplay prompt, enables the worldspace canvas that displays a message.
 The second method, StopSpawning, Stops the boxes from spawning above 
 the player.
 */


public class CanvasActivation : MonoBehaviour
{

    //When something collides with the player
    void OnTriggerEnter(Collider other) 
    {
        //if the thing that collided is the player
        if (other.gameObject.tag == "Player")
        {
            //display the prompt in the ui manager 
            //and stop spawning from the spawn manager
            UIManager.instance.DisplayPrompt();
            SpawnManager.instance.StopSpawning();
        }
    }
}
