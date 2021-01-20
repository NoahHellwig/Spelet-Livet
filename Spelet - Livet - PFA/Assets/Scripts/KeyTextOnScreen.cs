using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTextOnScreen : MonoBehaviour
{
    public Text myKeyText;
    private string myKeyStatus;

    public RectTransform rt2;
  
    void Start() 
    {
        GameInfo.storingKey = false;

        if(Screen.width > 700) {
            myKeyText.fontSize = 20;
        } else {
            myKeyText.fontSize = 15;
        }
        Debug.Log(Screen.width);


        float xPosText = Screen.width*0.4f;
        float yPosText = Screen.height*0.4f; //15
        //Debug.Log(xPosText);
        //Debug.Log(yPosText);
        //Debug.Log(yPos);
        
        rt2.anchoredPosition = new Vector2(xPosText, yPosText);

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
            else if (GameInfo.keyType == "Key 5") {
            myKeyStatus = "Key Five";
            }
            else if (GameInfo.keyType == "Key 6") {
            myKeyStatus = "Key Six";
            }
            else if (GameInfo.keyType == "Key 7") {
            myKeyStatus = "Key Seven";
            }
            else if (GameInfo.keyType == "Key 8") {
            myKeyStatus = "Key Eight";
            }
        }
        else if (GameInfo.storingKey == false) {
            myKeyStatus = "None";
        }
        
        myKeyText.text = "Current key: " + myKeyStatus;
    }
}
