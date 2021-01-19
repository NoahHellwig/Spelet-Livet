using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Enter : MonoBehaviour
{
    public static bool PlayerIsEntering = false; 
    //public Renderer cube; 
    public Material[] materials; 

    void Start()
    {
        foreach (var mat in materials) 
        {
        mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        Debug.Log("Detta då?");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }

        Debug.Log("Trigger portal entering"); 

        //Kollar om spelaren kommer från exit-hållet
        if(PortalExit.PlayerIsExiting == true) {
            // show old world
            Debug.Log("Is exiting");
            //cube.material.color = Color.red;
            PortalExit.PlayerIsExiting = false;

        //Om inte, sätts PlayerIsEntering till true, och     
        } else {
            PlayerIsEntering = true;
            Debug.Log("Is entering"); 
            //cube.material.color = Color.white;
        }
       
    }

    void OnDestroy() {
                 
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }

    }   
     
        
    
}
