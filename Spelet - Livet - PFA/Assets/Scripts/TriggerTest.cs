using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour

{
    
    public GameObject portal1;
    public GameObject portal2;
    public GameObject portal3;
    public GameObject portal4;



    void Start()
    {
        //Sätter texten för GameObjects
        portal1.name = "you partyed all night.";
        portal2.name = "you slept all day.";        
        portal3.name = "you were tired.";
        portal4.name = "you had energy.";
    }

//Grundfärg på tröskel bara för test
private Color m_oldColor = Color.white;

//Aktiveras när du kliver på tröskeln
    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        m_oldColor = render.material.color;
        render.material.color = Color.green;
        Debug.Log("Went through door" + ' ' + gameObject.name);
    }

//Aktiveras när du kliver av tröskeln
    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;
    }

        
}