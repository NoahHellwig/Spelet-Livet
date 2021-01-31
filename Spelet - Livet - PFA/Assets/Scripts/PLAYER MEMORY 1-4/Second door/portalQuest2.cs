﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalQuest2 : MonoBehaviour
{

    public string PortalName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Avatar") {
            return;
        }
        avatarMemorySecondPortal.Quests.Add(PortalName);   
    }
}

