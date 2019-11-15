using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	* Warren Guiles
    * Enemy.cs
	* Assignment 10
	* this script is a basic c# class enemy that contains a field for it's name, count, speed, and extra 
    variable I created called moat. It has 2 constructors and an overrident ToString method.
 */
public class Enemy
{

    //accesible fields
    public string name { get; set; } 
    public int count { get; set; }
    public float speed { get; set; }
    public float moat { get; set; }

    //default constructor
    public Enemy()
    {
        name = "Franklin";
        count = 0;
        speed = 10f;
        moat = 0f;
    }

    //alternate constructor
    public Enemy(string NameToSet, int countToSet, float speedToSet, float moatToSet)
    {
        name = NameToSet;
        count = countToSet;
        speed = speedToSet;
        moat = moatToSet;
    }

    //overrident toString
    public override string ToString()
    {
        return "Name: " + name + "\n Count: " + count.ToString() + "\n Speed: " + speed.ToString() + "\nMoat: " + moat.ToString();
    }
}
