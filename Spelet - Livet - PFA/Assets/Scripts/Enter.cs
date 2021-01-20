using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Enter : MonoBehaviour
{
    public Renderer cube;  
    public Material[] materials;

    void Start()
    {
        foreach (var mat in materials) 
        {
        mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        GameInfo.PlayerIsEntering = false;
        
        if (other.tag != "Player") {
            return;
        }

        //Kollar om spelaren kommer från exit-hållet
        if(GameInfo.PlayerIsExiting == true) {
            // show old world
            Debug.Log("Is exiting");
            cube.material.color = Color.red;
            GameInfo.PlayerIsExiting = false;

        //Om inte, sätts PlayerIsEntering till true, och     
        } else {
            GameInfo.PlayerIsEntering = true;
            Debug.Log("Is entering"); 
            cube.material.color = Color.white;
        }      
    }

    void OnDestroy() {
                 
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }
    }   
     
        
    
}
