using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDatabase : MonoBehaviour
{

/*
	* Warren Guiles
    * EnemyDatabase.cs
	* Assignment 10
	* this script contains a dictionary of the enemy class that I made and creates 3 enemies and adds them
    to the dictionary in in start. After that it removes one and prints out the twostrings of the remaining 2

 */
    Dictionary <string, Enemy> enemies = new Dictionary<string, Enemy>();
    // Start is called before the first frame update
    void Start()
    {

        enemies.Add("taco", new Enemy());
        enemies.Add("burrito", new Enemy("Why", 2, 3.1f, 3.4f));
        enemies.Add("nacho", new Enemy("Because", 8, 2.3f, 9.9f));

        if (enemies.ContainsKey("taco"))
        {
            enemies.Remove("taco");
        }

        foreach(KeyValuePair<string, Enemy> enemy in enemies)
        {
            Debug.Log(enemy.Value.ToString());
        }


    }
}
