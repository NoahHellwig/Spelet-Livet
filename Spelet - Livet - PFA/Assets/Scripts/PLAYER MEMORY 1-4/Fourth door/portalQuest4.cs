using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class portalQuest4: MonoBehaviour
{

    public string PortalName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }
        avatarMemoryFourthPortal.Quests.Add(PortalName);   
    }
}

