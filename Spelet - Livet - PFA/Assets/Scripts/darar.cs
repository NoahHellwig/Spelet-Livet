using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darar : MonoBehaviour
{
    public bool open = false;
    public float oppenVinkel = 90f;
    public float stangdVinkel = 0f;
    public float smooth = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeDoorState()
    {
        open = !open;
    }
    // Update is called once per frame
    void Update(){
    if(open)
    {
        Quaternion targetRotation = Quaternion.Euler(0,oppenVinkel,0);
        transform.localRotation = Quaternion.Slerp(transform.localRotation,targetRotation,smooth*Time.deltaTime);
    }
    else
    {
        Quaternion targetRotation2 = Quaternion.Euler(0,stangdVinkel,0);
        transform.localRotation = Quaternion.Slerp(transform.localRotation,targetRotation2,smooth*Time.deltaTime);
    }}
}
