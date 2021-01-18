using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecCameraBorderScript : MonoBehaviour
{
    public RectTransform rt;
   
    // Update is called once per frame
    void Update()
    {
        float width = Screen.width*2;
        float height = (Screen.height/4) + 10;
        float xPos = 300f;
        float yPos = Screen.height*0.15f;

        //Debug.Log(yPos);
        

        rt.sizeDelta = new Vector2(width, height);
        rt.anchoredPosition = new Vector2(xPos, yPos);
    }
}
