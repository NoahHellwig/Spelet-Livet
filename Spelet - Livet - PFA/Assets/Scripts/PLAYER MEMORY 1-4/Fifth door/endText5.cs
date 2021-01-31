using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText5 : MonoBehaviour
{
    public Text fifthDoorText;

    void Start()
    {
       fifthDoorText.text = "";
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Avatar") {
            return;
        }
        
        foreach(string quest in avatarMemoryFifthPortal.Quests)
           {
           fifthDoorText.text = ("" + quest);  // Denna visar bara upp det senaste i listan
           // Debug.Log("" + quest + "VISAS DENNA PORT?"); // Denna visar alla objekt i listan
}       

    }

    
}



