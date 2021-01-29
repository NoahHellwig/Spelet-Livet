﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText2 : MonoBehaviour
{
    public Text secondDoorText;

    void Start()
    {
       secondDoorText.text = "";
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }
        
        foreach(string quest in avatarMemorySecondPortal.Quests)
           {
           secondDoorText.text = ("" + quest);  // Denna visar bara upp det senaste i listan
}       

    }

    
}