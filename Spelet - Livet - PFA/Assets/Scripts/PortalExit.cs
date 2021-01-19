using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalExit : MonoBehaviour
{

    public static bool PlayerIsExiting = false; 
    public Renderer cube; 

    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }

      //      Debug.Log("Trigger portal exiting"); 
        if(PortalEnter.PlayerIsEntering == true) {
            // show old world
            //Debug.Log("is entering"); 
            cube.material.color = Color.black;
            PortalEnter.PlayerIsEntering = false;
        } else {
            PlayerIsExiting = true;
            //Debug.Log("can exit"); 
            cube.material.color = Color.black;

        }    
    }
}
