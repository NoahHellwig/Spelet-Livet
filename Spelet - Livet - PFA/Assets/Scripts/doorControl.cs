using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{
    public float speed;
    public float angle;
    public Vector3 direction;
    private GameObject battery;

    
    void Start()
    {
        angle = transform.eulerAngles.y;
        //Tilldelar angle det värde, vad det än var, den hade vid uppstarten av programmet

        battery = GameObject.Find("Battery");
    }

    // Update is called once per frame
    void Update()
    {

        //anger dörren utan att specificera då det ska gälla objektet som scriptet är knutet till - stämmer
        float distance = Vector3.Distance(transform.position, battery.transform.position);
        float maxDistance = 10.0f;
        bool isNear = distance <= maxDistance;    

        if (Mathf.Round(transform.eulerAngles.y) != angle)
        {
            transform.Rotate(direction * speed);
        }

        if (isNear != true)
            return;

        if (Input.GetKeyDown(KeyCode.O))
        {
            angle = 180;
            direction = Vector3.up; //Vector3.up ger motsatt håll 
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            angle = 90;
            direction = -Vector3.up; //Vector3.up ger motsatt håll 
        }
    }
}
