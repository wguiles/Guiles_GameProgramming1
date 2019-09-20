using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{

        /*
    Warren Guiles
    SpawnManager
    Assignment 4
    This script spawns random ball prefabs between random timed intervals.
    Here I added the random number used to  pull a GameObject from the ballprefabs array,
    as well as changing the invoke method to be a coroutine so that I could have it 
    wait 3-5 seconds before executing again
     */
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomBallCoroutine());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        //spawn a random ball based on a random number
        int randomNum = Random.Range(0, 3);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomNum], spawnPos, ballPrefabs[randomNum].transform.rotation);

    }

    IEnumerator SpawnRandomBallCoroutine()
    {
        //once the coroutine starts, this repeats forever
        while(true)
        {
            //wait a random number of seconds 
            int RandomWaitTime = Random.Range(3,6);
            yield return new WaitForSeconds(RandomWaitTime);

            //spawn a random ball
            SpawnRandomBall();
        }
    }

}
