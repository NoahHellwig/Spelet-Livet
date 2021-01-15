using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTextOnScreen : MonoBehaviour
{
    public Text myKeyText;
    private string myKeyStatus;
  
    void Start() 
    {
        GameInfo.storingKey = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (GameInfo.storingKey == true) {
        
            if(GameInfo.keyType == "Key 1") {
            myKeyStatus = "Key One  ";
            }
            else if (GameInfo.keyType == "Key 2") {
            myKeyStatus = "Key Two";
            }
            else if (GameInfo.keyType == "Key 3") {
            myKeyStatus = "Key Three";
            }
            else if (GameInfo.keyType == "Key 4") {
            myKeyStatus = "Key Four";
            }
        }
        else if (GameInfo.storingKey == false) {
            myKeyStatus = "None";
        }
        myKeyText.text = "Current key: " + myKeyStatus;
    }
}
