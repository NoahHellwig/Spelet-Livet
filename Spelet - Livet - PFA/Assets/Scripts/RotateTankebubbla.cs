using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTankebubbla : MonoBehaviour
{
    //  som global variabel 
    public float rotateSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
        transform.Rotate(
                          0f,
                          Random.Range(0f, 360f), //roterar runt y-axeln och ger lite olika vinkel
                          0f,
                          Space.World
                          );

    }

    // Update is called once per frame
    void Update()
    {
                transform.Rotate(
                            0f,
                            rotateSpeed, 
                            0f, 
                            Space.World
                            );
                            
                
    }
}