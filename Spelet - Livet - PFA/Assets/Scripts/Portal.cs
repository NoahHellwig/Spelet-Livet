using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Portal : MonoBehaviour
{
    public Material[] materials;
    
    void Start()
    {
        foreach (var mat in materials) 
        {
        mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.tag);
    }

    void OnTriggerStay(Collider other) 
    {
        //Anger att denna collider inte känner av något annat än spelaren
        if (other.tag != "Player"){
            Debug.Log(other.name);
            return;           
        }

        //Kolla vinkeln på dörren så det blir rätt > eller <
        //Ändra till z-värde i spelet

        //Sätter en int till materialet och jämför detta mot shader
        if (transform.position.z < other.transform.position.z)
        {
            Debug.Log("Outside other world");
            foreach (var mat in materials) 
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
        } 
        else
        {
            
            Debug.Log("Inside other world");           
            foreach (var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
        }   
    }

    void OnDestroy() {
                 
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
