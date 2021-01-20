using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Exit : MonoBehaviour
{
     
    public Renderer cube;   
    public Material[] materialstwo;
    

    void OnTriggerEnter(Collider other)
    {
        GameInfo.PlayerIsExiting = false;

        if (other.tag != "Player") {
            return;
        }


        if(GameInfo.PlayerIsEntering == true) {
            cube.material.color = Color.black;
            foreach (var mat in materialstwo) 
            {               
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);   
            }

            GameInfo.PlayerIsEntering = false;

            Debug.Log("Händer detta?");
        } else {
            GameInfo.PlayerIsExiting = true;
             
            cube.material.color = Color.yellow;
            Debug.Log("Trigger portal exiting");
            foreach (var mat in materialstwo)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
        }    
    }
}
