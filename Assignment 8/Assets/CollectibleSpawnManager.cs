using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManager : MonoBehaviour
{

    
/*
	* Warren Guiles
    * CollectibleSpawnManager.cs
	* Assignment 10
	* this script has lists for collectibles that will spawn near the player when they press either one or two.
    It also contains functionailty for removing and adding things to the list.

 */

    //list that is assigned in the inspector
    public List<GameObject> collectibles;

    //list that is removed and added programatically 
    public List<GameObject> multicolorCollectibles;


    void Update()
    {

        //if the player presses 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //do this 3 times
            for (int i = 0; i < 3; i++)
            {
                //randomly grab an object from the collectibles
                int randomNum = Random.Range(0,2);
                GameObject itemToPaint = collectibles[randomNum];

                //spawn it
                Instantiate(itemToPaint, transform.position, Quaternion.identity);

                //change it's color to a random color
                itemToPaint.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

                //randomly insert it into the multicolorCollectibleslist
                multicolorCollectibles.Insert(Random.Range(0, multicolorCollectibles.Count), itemToPaint);
            }
        }
        //otherwise if the player presses 2
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //grab the last object in the multicolorCollectibles list
                GameObject itemToPaint = multicolorCollectibles[multicolorCollectibles.Count - 1];
                GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

            //create a position that randomly branches out from 5 units in front of the player
                Vector3 posInFrontOfPlayer = playerObject.transform.position + new Vector3(0f, 0f, 5f);
                Vector3 randomOffset = new Vector3(Random.Range(0, 5), Random.Range(0,5), Random.Range(0,5));

            //spawn that object at that position and remove it from the multicolorCollectibles list
                Instantiate(itemToPaint, posInFrontOfPlayer + randomOffset, Quaternion.identity);
                multicolorCollectibles.Remove(itemToPaint);

        }
    }
}
