using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

/*
 * Warren Guiles
 * UIManager.cs
 * Assignment 8
 * This script is a singleton that handles the world space canvas that 
   displays the text "hello' in front of the player by enabling the 
   same world space canvas. All methods are encapsulated and called from other 
   scripts.
 */

    //singleton reference
    public static UIManager instance;

    //Worldspace canvas to activate
    public GameObject TriggerCanvas;


    //awake method to declare singleton
    private void Awake() 
    {
        //if the instance doesn't exist, then this becomes the singleton
        if (instance == null)
        {
            instance = this;
        }
    }

    //the method  turns on the GameObject to activate the 
    //worlspace canvas. It also starts the coroutine 
    //to disable the display prompt.

    public void DisplayPrompt()
    {
        TriggerCanvas.SetActive(true);
        StartCoroutine(DisableDisplayPrompt(5));
    }

    //this coroutine turns off the world space canvas
    //after a specified number of seconds
    private IEnumerator DisableDisplayPrompt(int secondsToWait)
    {
        yield return new WaitForSeconds(secondsToWait);
        TriggerCanvas.SetActive(false);
    }
}
