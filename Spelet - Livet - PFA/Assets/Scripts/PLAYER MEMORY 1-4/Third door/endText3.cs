using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText3 : MonoBehaviour
{
    public Text thirdDoorText;

    void Start()
    {
       thirdDoorText.text = "";
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Avatar") {
            return;
        }
        
        foreach(string quest in avatarMemoryThirdPortal.Quests)
           {
           thirdDoorText.text = ("" + quest);  // Denna visar bara upp det senaste i listan
           // Debug.Log("" + quest + "VISAS DENNA PORT?"); // Denna visar alla objekt i listan
}       

    }

    
}
