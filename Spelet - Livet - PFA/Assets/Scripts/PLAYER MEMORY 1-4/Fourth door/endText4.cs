using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText4 : MonoBehaviour
{
    public Text fourthDoorText;

    void Start()
    {
       fourthDoorText.text = "";
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Avatar") {
            return;
        }
        
        foreach(string quest in avatarMemoryFourthPortal.Quests)
           {
           fourthDoorText.text = ("" + quest);  // Denna visar bara upp det senaste i listan
           // Debug.Log("" + quest + "VISAS DENNA PORT?"); // Denna visar alla objekt i listan
}       

    }

    
}



