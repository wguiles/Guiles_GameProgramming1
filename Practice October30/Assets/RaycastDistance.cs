using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDistance : MonoBehaviour
{

    public float rayDistance;
    public float max = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, max));
        {
            rayDistance = hit.distance;

            Debug.Log("Our ray hit at " + hit.point);
        }
        else
        {
            
        }
        
    }
}
