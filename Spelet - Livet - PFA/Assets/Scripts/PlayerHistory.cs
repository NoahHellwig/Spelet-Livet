using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHistory : MonoBehaviour
{
    public string History;    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        string newDoor = other.tag;

        if (other.tag == "A" || other.tag == "B" )
        {            
            History += newDoor;
            Debug.Log(History);
        }
        else
        {
            return;
        }
           


        
    }
}
