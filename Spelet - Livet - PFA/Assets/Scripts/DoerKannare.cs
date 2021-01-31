using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoerKannare : MonoBehaviour
{

    public float angle;
    float tiltAngle = 60.0f;
    float smooth = 5.0f;
       private void OnTriggerEnter(Collider other)
    {   

        if (other.tag == "spelaren")
       {
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") - 75;
            Quaternion target = Quaternion.Euler(0 , tiltAroundX,0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
            
            
        }
       
        
    }
}
