﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class portalQuest5: MonoBehaviour
{

    public string PortalName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Avatar") {
            return;
        }
        avatarMemoryFifthPortal.Quests.Add(PortalName);   
    }
}

