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

    
    public GameObject[] ciggNyckel;
    public GameObject[] skolaNyckel;
    public GameObject[] jobbNyckel;
    public GameObject[] jobbNyckelTvå;
    public GameObject[] ballaUrNyckel;
    public GameObject[] uniNyckel;
    public GameObject[] gatanNyckel;
    public GameObject[] karriärNyckel;
    public GameObject[] resaNyckel;
    public GameObject[] relationNyckel;
    public GameObject[] guruNyckel;
    public GameObject[] konstnärNyckel;
    public GameObject[] konstnärNyckelTvå;
    public GameObject[] horderNyckel;
    public GameObject[] vvvNyckel;
/*
    public GameObject ciggNyckel;
    public GameObject skolaNyckel;
    public GameObject jobbNyckel;
    public GameObject jobbTvåNyckel;
    public GameObject ballaUrNyckel;
    public GameObject uniNyckel;
    public GameObject gatanNyckel;
    public GameObject karriärNyckel;
    public GameObject resaNyckel;
    public GameObject relationNyckel;
    public GameObject guruNyckel;
    public GameObject konstnärNyckel;
    public GameObject konstnärTvåNyckel;
    public GameObject horderNyckel;
    public GameObject vvvNyckel;

    public Transform[] placementKeys;
*/
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
        levelSeven = GameObject.FindGameObjectsWithTag("Level 7");
        levelEight = GameObject.FindGameObjectsWithTag("Level 8");
        levelNine = GameObject.FindGameObjectsWithTag("Level 9");
        levelTen = GameObject.FindGameObjectsWithTag("Level 10");
        levelEleven = GameObject.FindGameObjectsWithTag("Level 11");
        levelTwelve = GameObject.FindGameObjectsWithTag("Level 12");
        levelThirteen = GameObject.FindGameObjectsWithTag("Level 13");
        
        ciggNyckel = GameObject.FindGameObjectsWithTag("Key 1");
        skolaNyckel = GameObject.FindGameObjectsWithTag("Key 2");
        jobbNyckel = GameObject.FindGameObjectsWithTag("Key 3");
        jobbNyckelTvå = GameObject.FindGameObjectsWithTag("Key 14");
        ballaUrNyckel = GameObject.FindGameObjectsWithTag("Key 4");
        uniNyckel = GameObject.FindGameObjectsWithTag("Key 5");
        gatanNyckel = GameObject.FindGameObjectsWithTag("Key 6");
        karriärNyckel = GameObject.FindGameObjectsWithTag("Key 7");
        resaNyckel = GameObject.FindGameObjectsWithTag("Key 8");
        relationNyckel = GameObject.FindGameObjectsWithTag("Key 9");
        guruNyckel = GameObject.FindGameObjectsWithTag("Key 10");
        konstnärNyckel = GameObject.FindGameObjectsWithTag("Key 11");
        konstnärNyckelTvå = GameObject.FindGameObjectsWithTag("Key 15");
        horderNyckel = GameObject.FindGameObjectsWithTag("Key 12");
        vvvNyckel = GameObject.FindGameObjectsWithTag("Key 13");
        

        
    }

    void OnTriggerEnter(Collider other)
    {

        
        GameInfo.PlayerIsExiting = false;

        if (other.tag != "Player") {
            return;
        }

        Debug.Log("exit script" + ph.History);
        //Använd string med spelarens historik
        if (ph.History == "A"){  //cigg
        
            
            foreach(GameObject go in levelTwo)
            {
                go.SetActive(false);
                Debug.Log("Deaktiverar skola");
            }
            foreach(GameObject go in uniNyckel)
            {
                go.SetActive(false);
                //go.transform.Translate(0,-50,0);
                Debug.Log("Deaktiverar uniNyckel");
            }
            foreach(GameObject go in jobbNyckelTvå)
            {
                go.SetActive(false);
                //go.transform.Translate(0,-50,0);
                Debug.Log("Deaktiverar jobbNyckelTvå");
            }
            //Instantiate(ballaUrNyckel, placementKeys[4-1].position, placementKeys[4-1].rotation);
            //Instantiate(jobbNyckel, placementKeys[3-1].position, placementKeys[3-1].rotation);
            
        }
        else if (ph.History == "B"){ //skola
            foreach(GameObject go in levelOne)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar cigg");
            }
            foreach(GameObject go in ballaUrNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar ballaUrNyckel");
            }
            foreach(GameObject go in jobbNyckel)
            {
                go.SetActive(false);
                //go.transform.Translate(0,-50,0);
                Debug.Log("Deaktiverar jobbNyckelEtt");
            }
            //Instantiate(uniNyckel, placementKeys[5-1].position, placementKeys[5-1].rotation);
            //Instantiate(jobbTvåNyckel, placementKeys[14-1].position, placementKeys[14-1].rotation);
        }
        else if (ph.History == "AA"){ //balla ur
            foreach(GameObject go in levelThree)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar jobb");
            }
            foreach(GameObject go in levelFive) 
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar universitet");
            }
            foreach(GameObject go in karriärNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar karriärNyckel");
            }
            foreach(GameObject go in relationNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar relationsNyckel");
            }
            //Instantiate(gatanNyckel, placementKeys[6-1].position, placementKeys[6-1].rotation);
            //Instantiate(resaNyckel, placementKeys[8-1].position, placementKeys[8-1].rotation);
            
        }
         else if (ph.History == "AB" || ph.History == "BA"){ //jobb
            foreach(GameObject go in levelFour)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar balla ur");
            }
            foreach(GameObject go in levelFive)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar universitet");
            }
            foreach(GameObject go in resaNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar resaNyckel");
            }
            foreach(GameObject go in gatanNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar gatanNyckel");
            }
            //Instantiate(karriärNyckel, placementKeys[7-1].position, placementKeys[7-1].rotation);
            //Instantiate(relationNyckel, placementKeys[9-1].position, placementKeys[9-1].rotation);

        }
        else if (ph.History == "BB"){ //universitet
            foreach(GameObject go in levelFour)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar balla ur");
            }
            foreach(GameObject go in levelThree)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar jobb");
            }
            foreach(GameObject go in resaNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar resaNyckel");
            }
            foreach(GameObject go in gatanNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar gatanNyckel");
            }
            //Instantiate(karriärNyckel, placementKeys[7-1].position, placementKeys[7-1].rotation);
            //Instantiate(relationNyckel, placementKeys[9-1].position, placementKeys[9-1].rotation);
        }
        else if (ph.History == "AAA"){ //gatan
            foreach(GameObject go in levelEight)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar resa");
            }
            foreach(GameObject go in levelSeven)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar karriär");
            }
            foreach(GameObject go in levelNine)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar relation");
            }
            foreach(GameObject go in konstnärNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar konstnärNyckel");
            }
            foreach(GameObject go in vvvNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar vvvNyckel");
            }
            //Instantiate(horderNyckel, placementKeys[12-1].position, placementKeys[12-1].rotation);
            //Instantiate(guruNyckel, placementKeys[10-1].position, placementKeys[10-1].rotation);
        }
        else if (ph.History == "AAB"){ //resa
            foreach(GameObject go in levelSix)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar gatan");
            }
            foreach(GameObject go in levelSeven)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar karriär");
            }
            foreach(GameObject go in levelNine)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar relation");
            }
            foreach(GameObject go in horderNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar horderNyckel");
            }
            foreach(GameObject go in vvvNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar vvvNyckel");
            }
            //Instantiate(guruNyckel, placementKeys[10-1].position, placementKeys[10-1].rotation);
            //Instantiate(konstnärNyckel, placementKeys[11-1].position, placementKeys[11-1].rotation);
        }
        else if (ph.History == "ABA" || ph.History == "BAA" || ph.History == "BBA"){ //karriär
            foreach(GameObject go in levelSix)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar gatan");
            }
            foreach(GameObject go in levelEight)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar resa");
            }
            foreach(GameObject go in levelNine)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar relation");
            }
            foreach(GameObject go in konstnärNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar konstnärNyckel");
            }
            foreach(GameObject go in horderNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar horderNyckel");
            }
            //Instantiate(guruNyckel, placementKeys[10-1].position, placementKeys[10-1].rotation);
            //Instantiate(vvvNyckel, placementKeys[13-1].position, placementKeys[13-1].rotation);
        }
        else if (ph.History == "ABB" || ph.History == "BAB" || ph.History == "BBB"){ //relation
            foreach(GameObject go in levelSix)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar gatan");
            }
            foreach(GameObject go in levelSeven)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar karriär");
            }
            foreach(GameObject go in levelEight)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar resa");
            }
            foreach(GameObject go in guruNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar guruNyckel");
            }
            foreach(GameObject go in horderNyckel)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar horderNyckel");
            }
            //Instantiate(konstnärTvåNyckel, placementKeys[15-1].position, placementKeys[15-1].rotation);
            //Instantiate(vvvNyckel, placementKeys[13-1].position, placementKeys[13-1].rotation);
        }
        else if (ph.History == "AAAA"){ //horder
            foreach(GameObject go in levelTen)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar guru");
            }
            foreach(GameObject go in levelEleven)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar konstnär");
            }
            foreach(GameObject go in levelThirteen)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar vvv");
            }
        }
        else if (ph.History == "AAAB" || ph.History == "AABA" || ph.History == "ABAA" || ph.History == "BAAA" || ph.History == "BBAA"){ //guru
            foreach(GameObject go in levelTwelve)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar horder");
            }
            foreach(GameObject go in levelEleven)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar konstnär");
            }
            foreach(GameObject go in levelThirteen)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar vvv");
            }
        } else if (ph.History == "AABB" || ph.History == "ABBA" || ph.History == "BABA" || ph.History == "BBBA"){ //konstnär
            foreach(GameObject go in levelTwelve)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar horder");
            }
            foreach(GameObject go in levelTen)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar guru");
            }
            foreach(GameObject go in levelThirteen)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar vvv");
            }
        } else if (ph.History == "ABAB" || ph.History == "BAAB" || ph.History == "BBAB" || ph.History == "ABBB" || ph.History == "BABB" || ph.History == "BBBB"){ //vvv
            foreach(GameObject go in levelTwelve)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar horder");
            }
            foreach(GameObject go in levelEleven)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar konstnär");
            }
            foreach(GameObject go in levelTen)
            {
                go.SetActive(false);
                //Debug.Log("Deaktiverar banor: guru");
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









