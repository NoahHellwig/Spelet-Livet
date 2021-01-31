using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText1 : MonoBehaviour
{
    public Text firstDoorText;

    void Start()
    {
       firstDoorText.text = "";
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Avatar") {
            return;
        }
        
        foreach(string quest in avatarMemoryFirstPortal.Quests)
           {
           firstDoorText.text = ("" + quest);  // Denna visar bara upp det senaste i listan
         //  Debug.Log("" + quest + "VISAS DENNA PORT?"); // Denna visar alla objekt i listan
}       


    }

    
}
