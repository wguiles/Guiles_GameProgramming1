using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superhero
{

    public string name{get; set}

    public float speed{get; set;}

    public GameObject body { get; set; }

    public static int count { get; set; }

    public Superhero()
    {
        name = "Superman";
        speed = 10f;
        count++;
    }

    public Superhero(string name, float speed)
    {
        this.name = name;
        this.speed = speed;
        count++;
    }

    public override string ToString()
    {
        return name + " runs at " + speed + "km per hour. ";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
