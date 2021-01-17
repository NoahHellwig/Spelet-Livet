using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCloseToColliderScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameInfo.playerCloseToTarget = true;
            Debug.Log("Player is close");
        }
       
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameInfo.playerCloseToTarget = false;
            Debug.Log("Player is NOT close");
        }
        
    }
}
