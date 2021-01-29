using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myEndText : MonoBehaviour
{
    public Text endText;

    void Start()
    {
       endText.text = "";
    }

    void Update ()
    {

    }


        void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }
        
        foreach(string quest in PlayerMemory.Quests)
           {
           endText.text = ("" + quest);  // Denna visar bara upp det senaste i listan
           Debug.Log("" + quest + "VISAS DENNA PORT?"); // Denna visar alla objekt i listan
}       


    }

    
}
