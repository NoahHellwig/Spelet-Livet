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
    public GameObject[] levelOne;
    public GameObject[] levelTwo;
    public GameObject[] levelThree;
    public GameObject[] levelFour;
    public GameObject[] levelFive;
    public GameObject[] levelSix;
    public GameObject[] levelSeven;
    public GameObject[] levelEight;
    public GameObject[] levelNine;
    public GameObject[] levelTen;
    public GameObject[] levelEleven;
    public GameObject[] levelTwelve;
    public GameObject[] levelThirteen;
    public GameObject[] levelFourteen;
    
    
    void Start() {
        //Hämta skriptet Playerhistory från spelaren
        myPlayer = GameObject.Find("Tanken - Spelaren");
        ph = myPlayer.GetComponent<PlayerHistory>();

        //Hämta GameObjectArrayer för varje bana
        levelOne = GameObject.FindGameObjectsWithTag("Level 1");
        levelTwo = GameObject.FindGameObjectsWithTag("Level 2");
        levelThree = GameObject.FindGameObjectsWithTag("Level 3");
        levelFour = GameObject.FindGameObjectsWithTag("Level 4");
        levelFive = GameObject.FindGameObjectsWithTag("Level 5");
        levelSix = GameObject.FindGameObjectsWithTag("Level 6");
    }

    void OnTriggerEnter(Collider other)
    {
        GameInfo.PlayerIsExiting = false;

        if (other.tag != "Player") {
            return;
        }

        //Använd string med spelarens historik        
        if (ph.History == "A"){
            
            foreach(GameObject go in levelTwo) 
            {
                go.SetActive(false);
                Debug.Log("Deaktiverar bana 2");
            }
            
        }
        
        if (ph.History == "B"){
            
            foreach(GameObject go in levelOne) 
            {
                go.SetActive(false);
                Debug.Log("Deaktiverar bana 1");
            }
            
        }


        if (ph.History == "AA"){
            
            foreach(GameObject go in levelFour) 
            {
                go.SetActive(false);
                Debug.Log("Deaktiverar bana 4");
            }
            
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
