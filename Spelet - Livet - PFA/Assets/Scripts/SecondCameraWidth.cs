using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCameraWidth : MonoBehaviour
{
    public RectTransform rt;
    
  
    void Start()
    {
        float width = Screen.width*2;
        float height = Screen.height/4;
        //float xPos = 300f;
        //float yPos = Screen.height*0.2f;

        rt.sizeDelta = new Vector2(width, height);
        
        //rt.anchoredPosition = Vector2(xPos, yPos); 
    }
}
