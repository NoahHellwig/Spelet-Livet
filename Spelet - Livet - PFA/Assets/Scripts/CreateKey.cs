using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateKey : MonoBehaviour
{
    public GameObject newKey1;
    public GameObject newKey2;
    public GameObject newKey3;
    public GameObject newKey4;
    public Transform placementKey1;
    public Transform placementKey2;
    public Transform placementKey3;
    public Transform placementKey4;


    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey("g") ) {
           
            if (GameInfo.storingKey == true) {
                if (GameInfo.keyType == "Key 1") {
                    Instantiate(newKey1, placementKey1.position, placementKey1.rotation);
                    GameInfo.storingKey = false;
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
            } 
        }
    }
}
