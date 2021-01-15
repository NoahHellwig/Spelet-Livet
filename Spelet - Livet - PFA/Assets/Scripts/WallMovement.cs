using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    //private Rigidbody rbw; //a reference to the Rigidbody-component called "rb"
    private float speedWall = 1.5f;

    // Update is called once per frame. Fixed update works better for physics stuff, Unity likes it better, will look smoother.
    void Update()
    {
        //add forward force 
        //rbw.AddForce(0, 0, forwardForceWall * Time.deltaTime); //adjusts the framerate so that it is the same for all computers
        transform.position += transform.forward * Time.deltaTime * speedWall;
    }
}
