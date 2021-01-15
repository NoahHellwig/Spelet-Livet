﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
 
    //if colliding with key
    //check if already storing key
    //if not, pick up key
    
    public void OnTriggerEnter(Collider other) {
        if (GameInfo.storingKey == false) {
            if (other.tag == "Key 1") {
                Destroy (other.gameObject);
                //source.Play (); 
                //GameInfo.NumCoins--;
                GameInfo.storingKey = true;
                GameInfo.keyType = "Key 1";
            } 
            else if (other.tag == "Key 2") {
                Destroy (other.gameObject);
                GameInfo.storingKey = true;
                GameInfo.keyType = "Key 2";
            }
            else if (other.tag == "Key 3") {
                Destroy (other.gameObject);
                GameInfo.storingKey = true;
                GameInfo.keyType = "Key 3";
            }
            else if (other.tag == "Key 4") {
                Destroy (other.gameObject);
                GameInfo.storingKey = true;
                GameInfo.keyType = "Key 4";
            }
        }     
    }
}