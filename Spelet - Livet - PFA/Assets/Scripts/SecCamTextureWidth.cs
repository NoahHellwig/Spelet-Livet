using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecCamTextureWidth : MonoBehaviour
{
  
    public Camera secondCam;

    // Update is called once per frame
    void Start()
    {

        secondCam.targetTexture.width = (int)(Screen.width * 2);

         //Debug.Log(Screen.dpi);
    }
}
