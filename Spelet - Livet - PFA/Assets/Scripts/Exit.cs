using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class Exit : MonoBehaviour
{
     
    //public Renderer cube;   
    GameObject myPlayer;
    PlayerHistory ph;
    public Material[] materialstwo;
    void Start() {
        myPlayer = GameObject.Find("Tanken - Spelaren");
        ph = myPlayer.GetComponent<PlayerHistory>();
    }

    void OnTriggerEnter(Collider other)
    {
        GameInfo.PlayerIsExiting = false;

        if (other.tag != "Player") {
            return;
        }

        //Hämta string med spelarens historik
        
        if (ph.History == "BB"){
            Debug.Log("Booooooo");
        }

        if(GameInfo.PlayerIsEntering == true) {
            //cube.material.color = Color.black;

            foreach (var mat in materialstwo) 
            {               
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);   
            }

            GameInfo.PlayerIsEntering = false;

        } else {
            GameInfo.PlayerIsExiting = true;
             
            //cube.material.color = Color.yellow;
            Debug.Log("Trigger portal exiting");
            foreach (var mat in materialstwo)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
        }    
    }
}
