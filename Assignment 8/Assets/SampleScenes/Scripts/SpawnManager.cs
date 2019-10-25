using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    /*
 * Warren Guiles
 * SpawnManager.cs
 * Assignment 8
 * This script is a singleton that handles spawning
  boxes above the player. It contains a method to spawn the prefab
  above the player and a method to cancel the invoke of spawning
  the boxes
 */

    //singleton reference
    public static SpawnManager instance;

    //reference to prefab we want to spawn.
    public GameObject prefabToSpawn;

      //awake method to declare singleton
     private void Awake() 
    {
        //if the instance doesn't exist, then this becomes the singleton
        if (instance == null)
            instance = this;
    }

    //during start, invoke the spawnprefab every 2 seconds after a 2 second delay.
    void Start()
    {
        InvokeRepeating("SpawnPrefab", 2.0f, 2.0f);
    }



    //spawn the boxprefab in a random location near the player.
    public void SpawnPrefab()
    {
        Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 spawnLocation = new Vector3(playerPosition.x + Random.Range(-4.0f, 4.0f), playerPosition.y + 10f, playerPosition.z + Random.Range(-4.0f, 4.0f));
        Instantiate(prefabToSpawn, spawnLocation, Quaternion.identity);
    }


    //stop the spawning of the box.
    public void StopSpawning()
    {
        CancelInvoke("SpawnPrefab");
    }
}
