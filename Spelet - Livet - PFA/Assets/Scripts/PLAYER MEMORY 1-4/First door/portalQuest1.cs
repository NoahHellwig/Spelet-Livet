using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalQuest1 : MonoBehaviour
{

    public string PortalName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Avatar") {
            return;
        }
        avatarMemoryFirstPortal.Quests.Add(PortalName);   
    }
}
