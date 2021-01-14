using System.Collections;
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
            if (other.tag == "Right Key") {
                Destroy (other.gameObject);
                //source.Play (); 
                //GameInfo.NumCoins--;
                GameInfo.storingKey = true;
                GameInfo.keyType = "Right";
            } 
            else if (other.tag == "Left Key") {
                Destroy (other.gameObject);
                GameInfo.storingKey = true;
                GameInfo.keyType = "Left";
            }
        }     
    }
}