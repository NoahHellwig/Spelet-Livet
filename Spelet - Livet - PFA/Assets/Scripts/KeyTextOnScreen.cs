using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTextOnScreen : MonoBehaviour
{
    public Text myKeyText;
    private string myKeyStatus;

    public RectTransform rt2; //textens position på skärmen
  
    void Start() 
    {
        
        GameInfo.keyType  = "None"; 

        //textstorlek ställs in beroende på hur stor skärmen är
        if(Screen.width > 700) { 
            myKeyText.fontSize = 20;
        } else {
            myKeyText.fontSize = 15;
        }


        float xPosText = Screen.width*0.3f; 
        float yPosText = Screen.height*0.4f;
        rt2.anchoredPosition = new Vector2(xPosText, yPosText); //textens position på skärmen

    }

    void Update()
    {

            if(GameInfo.keyType == "Key 1") {
            myKeyStatus = "Cigg";
            }
            else if (GameInfo.keyType == "Key 2") {
            myKeyStatus = "Skolböcker";
            }
            else if (GameInfo.keyType == "Key 3") {
            myKeyStatus = "Jobb";
            }
            else if (GameInfo.keyType == "Key 4") {
            myKeyStatus = "Ballar ur";
            }
            else if (GameInfo.keyType == "Key 5") {
            myKeyStatus = "Universitetet";
            }
            else if (GameInfo.keyType == "Key 6") {
            myKeyStatus = "Gatan";
            }
            else if (GameInfo.keyType == "Key 7") {
            myKeyStatus = "Karriär";
            }
            else if (GameInfo.keyType == "Key 8") {
            myKeyStatus = "Resa";
            }
            else if (GameInfo.keyType == "Key 9") {
            myKeyStatus = "Relation";
            }
            else if (GameInfo.keyType == "Key 10") {
            myKeyStatus = "Spirituell ledare";
            }
            else if (GameInfo.keyType == "Key 11") {
            myKeyStatus = "Konstnär";
            }
            else if (GameInfo.keyType == "Key 12") {
            myKeyStatus = "Horder";
            }
            else if (GameInfo.keyType == "Key 13") {
            myKeyStatus = "Villa, Volvo, vovve";
            }
            else {
                myKeyStatus = "None";
            }
     
        
        myKeyText.text = "Current key: " + myKeyStatus;
    }
}
