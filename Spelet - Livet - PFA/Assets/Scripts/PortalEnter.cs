using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalEnter : MonoBehaviour
{

    public static bool PlayerIsEntering = false; 
    public Renderer cube; 
    public string PortalName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }

        Debug.Log("Trigger portal entering"); 
        if(PortalExit.PlayerIsExiting == true) {
            // show old world
            Debug.Log("Is exiting");
            cube.material.color = Color.red;
            PortalExit.PlayerIsExiting = false;
            
        } else {
            PlayerIsEntering = true;
            Debug.Log("Is entering"); 
            cube.material.color = Color.white;
        }
       
   
        
     
        
    }
}
