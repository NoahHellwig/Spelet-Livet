using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalescript : MonoBehaviour
{

    [SerializeField] 
    float testdist;

    // Update is called once per frame
    void Update()
    {
        
    float scaled = scale(0f, 100f, 0f, 10f, testdist);
    Debug.Log("This is the scale of testdist: " + scaled); 
    

    }
  

    public float scale(float OldMin, float OldMax, float NewMin, float NewMax, float OldValue)
    {

    float OldRange = (OldMax - OldMin);
    float NewRange = (NewMax - NewMin);
    float NewValue = (((OldValue - OldMin) * NewRange) / OldRange) + NewMin;

    return (NewValue);
    }
}
       


