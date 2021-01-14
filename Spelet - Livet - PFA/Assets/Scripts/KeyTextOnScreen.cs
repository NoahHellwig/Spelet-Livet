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
        
            if(GameInfo.keyType == "Right") {
            myKeyStatus = "Right";
            }
            else if (GameInfo.keyType == "Left") {
            myKeyStatus = "Left";
            }
        }
        else if (GameInfo.storingKey == false) {
            myKeyStatus = "None";
        }
        myKeyText.text = "Current key:" + myKeyStatus;
    }
}
