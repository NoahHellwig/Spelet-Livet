using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Exit : MonoBehaviour
{
    public static bool PlayerIsExiting = false; 
    //public Renderer cube; 
    public Material[] materials;
    //private Material[] materials; 
    
    //void Start()
    //{
    //    materials = GameObject.Find("Enter").GetComponents<Material>();
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }


        if(PortalEnter.PlayerIsEntering == true) {
            // show old world
            //Debug.Log("is entering"); 
            //cube.material.color = Color.black;
            foreach (var mat in materials) 
            {
                
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
                
            }

            PortalEnter.PlayerIsEntering = false;

            Debug.Log("Händer detta?");
        } else {
            PlayerIsExiting = true;
            //Debug.Log("Player is exiting"); 
            //cube.material.color = Color.black;
            Debug.Log("Trigger portal exiting");
            foreach (var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
        }    
    }
}
