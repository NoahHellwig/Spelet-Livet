using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalQuestInfo : MonoBehaviour
{

    public string PortalName; 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {
            return;
        }
        PlayerMemory.Quests.Add(PortalName);   
    }
}
