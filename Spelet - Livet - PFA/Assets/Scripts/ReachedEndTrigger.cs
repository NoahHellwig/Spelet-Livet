using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReachedEndTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other4)
    {
        if (other4.tag == "Avatar")
        {
            GameInfo.avatarReachedEnd = true;
            // Debug.Log("Personen/Avataren has reached the End");
        }

    }

}