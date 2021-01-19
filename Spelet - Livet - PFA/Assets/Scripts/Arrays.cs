using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

  //  public GameObject[] portals;
    List<GameObject> portals = new List<GameObject>();


    
    // Start is called before the first frame update
    void Start()
    {
        //portals = GameObject.FindGameObjectsWithTag("Portal");
        //for (int i = 0; i < portals.Length; i++)
        // {
        //Updated upstream
        //Debug.Log("You have to choose between " +i+ portals[i].name);
        //  }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Portal")
        {
            portals.Add(other.gameObject);   
        }
        Debug.Log("Went through door" + ' ' + List.GameObject);

    }


}
