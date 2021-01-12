using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonenMovementScript : MonoBehaviour
{
    // The target marker (needs to be choosen in Unity editor) 
    [SerializeField]
    Transform target;

    // Maxspeed in units per sec.
    [SerializeField]
    float maxSpeed = 7f; 
    float minSpeed = 0f; 

    // Max-Distance before Script-Carrier/"Personen" stops 
    [SerializeField]
    float maxDistance = 20f; 
    float minDistance = 0f; 

    // Position of player/"Tanken" (needs to be choosen in Unity editor) 
    [SerializeField]
    Transform player;


    void Update()
    {
        // Calculate distance between script-carrier and player. 
        float dist = Vector3.Distance(player.position, transform.position);
        // Debug.Log("Distance to other: " + dist);



        // Scale dist to speed - The closer dist the higher speed is to maxspeed.  
        float speed = scale(minDistance, maxDistance, maxSpeed, minSpeed, dist);
        Debug.Log("This is the scaled dist to speed: " + speed);


        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;


        // If step is a negative value, don't do any steps. Otherwise walk towards target
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

    // Scale function to map distance to speed
    public float scale(float OldMin, float OldMax, float NewMin, float NewMax, float OldValue)
    {

        float OldRange = (OldMax - OldMin);
        float NewRange = (NewMax - NewMin);
        float NewValue = (((OldValue - OldMin) * NewRange) / OldRange) + NewMin;

        return (NewValue);
    }

}