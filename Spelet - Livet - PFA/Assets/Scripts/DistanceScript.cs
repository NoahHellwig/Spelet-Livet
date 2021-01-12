using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour
{
    // Other needs to be defined in Unity Engine
    [SerializeField]
    Transform other; 

        void Update()
        {   
            // Calculate distance between script carrier and "other". 
            float dist = Vector3.Distance(other.position, transform.position);

            // Uncomment Debug below to see distance between other and scriptcarrier. 
            Debug.Log("Distance to other" + dist);
        }
}