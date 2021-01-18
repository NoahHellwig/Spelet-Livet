using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorReleaseKey : MonoBehaviour
{

    public GameObject newKey1;
    public GameObject newKey2;
    public GameObject newKey3;
    public GameObject newKey4;
    public GameObject newKey5;
    public GameObject newKey6;
    public GameObject newKey7;
    public GameObject newKey8;
    public Transform placementKey1;
    public Transform placementKey2;
    public Transform placementKey3;
    public Transform placementKey4;
    public Transform placementKey5;
    public Transform placementKey6;
    public Transform placementKey7;
    public Transform placementKey8;

    //om personen går genom dörren (collision?) 
    //storingKey = false;

    // Update is called once per frame
    public void OnTriggerEnter(Collider other) {
        if (GameInfo.storingKey == true) {
            if (other.tag == "Portal 1" || other.tag == "Portal 2" || other.tag == "Portal 3" || other.tag == "Portal 4" || other.tag == "Portal 5" || other.tag == "Portal 6" || other.tag == "Portal 7" || other.tag == "Portal 8") 
            {
                if (GameInfo.keyType == "Key 1") {
                    Instantiate(newKey1, placementKey1.position, placementKey1.rotation);
                    GameInfo.storingKey = false;
                    Debug.Log("hej");
                } 
                else if (GameInfo.keyType == "Key 2") {
                    Instantiate(newKey2, placementKey2.position, placementKey2.rotation);
                    GameInfo.storingKey = false;
                } 
                else if (GameInfo.keyType == "Key 3") {
                    Instantiate(newKey3, placementKey3.position, placementKey3.rotation);
                    GameInfo.storingKey = false;
                }
                else if (GameInfo.keyType == "Key 4") {
                    Instantiate(newKey4, placementKey4.position, placementKey4.rotation);
                    GameInfo.storingKey = false;
                } 
                else if (GameInfo.keyType == "Key 5") {
                    Instantiate(newKey5, placementKey5.position, placementKey5.rotation);
                    GameInfo.storingKey = false;
                } 
                else if (GameInfo.keyType == "Key 6") {
                    Instantiate(newKey6, placementKey6.position, placementKey6.rotation);
                    GameInfo.storingKey = false;
                } 
                else if (GameInfo.keyType == "Key 7") {
                    Instantiate(newKey7, placementKey7.position, placementKey7.rotation);
                    GameInfo.storingKey = false;
                } 
                else if (GameInfo.keyType == "Key 8") {
                    Instantiate(newKey8, placementKey8.position, placementKey8.rotation);
                    GameInfo.storingKey = false;
                }
            }
        }
    }
}
