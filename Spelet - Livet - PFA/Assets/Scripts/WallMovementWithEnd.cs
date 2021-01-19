using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovementWithEnd : MonoBehaviour
{

    //private Rigidbody rbw; //a reference to the Rigidbody-component called "rb"
    private float speedWall = 1.5f;

    private bool startEndMovement = false;

    // Tiden är ungefär så många sekunder tills den slår till lasttarget positionen. 
    [SerializeField]
    float timeBeforeImpact = 5f ; 

    // Position of Last Target Position (needs to be choosen in Unity editor) 
    [SerializeField]
    Transform lastTarget;

    private float lastSpeed;


    // Update is called once per frame. Fixed update works better for physics stuff, Unity likes it better, will look smoother.
    void Update()
    {

        if (GameInfo.avatarReachedEnd == true && startEndMovement == false)
        {
            Debug.Log("Death Wall sees Personen/Avatar at the End");

            // Calculate distance between script-carrier and lastTarget. 
            float lastDist = Vector3.Distance(lastTarget.position, transform.position);

            lastSpeed = lastDist / timeBeforeImpact;
            Debug.Log("This is the lastSpeed for Death Wall: " + lastSpeed);

            startEndMovement = true;
        }

        else if (GameInfo.avatarReachedEnd == true && startEndMovement == true)
        {
            // Dearth Wall will reach the lastTarget about same amount of seconds as timeBeforeImpact float. 
            transform.position += transform.forward * Time.deltaTime * lastSpeed;
        }

        else
        { 
            // Move Death Wall forward in steady tempo. 
            transform.position += transform.forward * Time.deltaTime * speedWall;
        }

    }
}
