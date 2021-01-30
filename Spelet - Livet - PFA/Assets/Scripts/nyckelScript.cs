using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nyckelScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "spelaren")
        {
            Destroy(this.gameObject);
        }
    }
}