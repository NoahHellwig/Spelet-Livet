using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarCloseToColliderScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar")
        {
            GameInfo.avatarCloseToTarget = true;
            Debug.Log("Avatar is close");
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Avatar")
        {
            GameInfo.avatarCloseToTarget = false;
            Debug.Log("Avatar is NOT close");
        }
    }
}
