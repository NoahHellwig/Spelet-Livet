using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonenMovementScript : MonoBehaviour
{
    // The target marker.
    [SerializeField] 
    Transform target;

    // Speed in units per sec.
    [SerializeField]
    float maxspeed;

    private float speed; 

    // Position of player (needs to be choosen in Unity editor) 
    [SerializeField]
    Transform player;

    
    void Update()
    {
        // Calculate distance between script-carrier and player. 
        float dist = Vector3.Distance(player.position, transform.position);
        Debug.Log("Distance to other" + dist);

        // The step size is equal to speed times frame time.
        float step = (maxspeed - dist) * Time.deltaTime;

        if (step < 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0f);
        }
        else
        {
            // Move our position a step closer to the target.
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }

    }
}