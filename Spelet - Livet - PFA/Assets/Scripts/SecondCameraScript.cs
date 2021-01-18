using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Z-värdet zoomas


public class SecondCameraScript : MonoBehaviour
{
    
    public Transform tanken;
    public Transform personen;
    public Camera m_OrthographicCamera; 

    void Start () 
    {
        m_OrthographicCamera.orthographic = true;
        m_OrthographicCamera.orthographicSize = 5.0f; //ut-eller in-zoomning värde
    }

    void LateUpdate ()
    {
        Transform follow = tanken;

        float distance = tanken.transform.position.z - personen.transform.position.z; //avståndet mellan spelarna

            distance = Mathf.Abs(distance); //håller avståndsvärdet alltid positivt

            if(distance >= 6 ) //om avståndet är 7 eller högre, följ personen
            {
                distance = 6;
                follow = personen;

            } else if(distance < 6) //om avståndet är 4 eller mindre, följ tanken
            {
                distance = 6;
                follow = tanken;
            }

            m_OrthographicCamera.orthographicSize = distance; //set size in/ut-zoomning till avståndet mellan spelarna


            Vector3 newPosition = follow.position; //kamerans nya position är smama som positionen för den spelaren vi följer
            newPosition.y = transform.position.y;  //ersätt newPosition.y med kamerans y-pos
            newPosition.x = transform.position.x;  //ersätt newPosition.y med kamerans x-pos
            transform.position = Vector3.MoveTowards(transform.position, newPosition, 0.1f); //ändrar endast z-pos, smooth change of target for camera
        
        
    }
}
