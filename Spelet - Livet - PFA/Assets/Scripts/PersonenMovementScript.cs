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
    float speed;

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}