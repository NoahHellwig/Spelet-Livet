using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalQuest3 : MonoBehaviour
{

    public string PortalName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }
        avatarMemoryThirdPortal.Quests.Add(PortalName);   
    }
}
