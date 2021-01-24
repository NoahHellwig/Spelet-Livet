
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{

    public GameObject[] newKeys; //lista med nycklar
    public Transform[] placementKeys; //lista med nyckel-positioner

        public void OnTriggerEnter(Collider other) { 
           string[] otherTypeAndId = other.tag.Split(' '); //dela upp tag:en på mellanslag och lägg i lista

            //om GameInfo.currentlyHeldKey  inte är samma som other.tag och första ordet i tagen är "Key"
            if ((GameInfo.keyType != other.tag) && (otherTypeAndId[0] == "Key")) { 

                //om GameInfo.currentlyHeldKey inte är "None"
                if (GameInfo.keyType != "None") {
                    string[] currentKeyTypeAndId = GameInfo.keyType.Split(' '); //dela upp GameInfo.currentlyHeldKey  
                    int id = int.Parse(currentKeyTypeAndId[1]); //gör andra ordet i listan till en int


                    //skapa nyckel baserat på vilken nyckel du hållit i 
                    Instantiate(newKeys[id - 1], placementKeys[id - 1].position, placementKeys[id - 1].rotation);
                   
                }
   
                GameInfo.keyType = other.tag; //ändra GameInfo.keyType 
                Destroy (other.gameObject); //förstör objektet
            }
        }
            
}