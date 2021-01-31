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
        if (other.tag != "Player") 
        {
            return;
        }
            foreach(string quest in avatarMemoryFirstPortal.Quests)
        {
                firstDoorText.text = ("" + quest);  // Denna visar bara upp det senaste i listan
        }
    }
}


