using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCameraWidth : MonoBehaviour
{
    public RectTransform rt;
   
    // Update is called once per frame
    void Update()
    {
        float width = Screen.width*2;
        float height = rt.rect.height;

        rt.sizeDelta = new Vector2(width, height);
        
    }
}
