using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelareMovementScript : MonoBehaviour
{
    [SerializeField]
    float PlayerSpeed = 20f;

    [SerializeField]
    float PlayerRotationSpeed = 100;

    private Transform myPlayer;
    private CharacterController myControllerPlayer;

    public AudioSource source;

    void Awake()
    {
        myPlayer = GetComponent<Transform>();
        myControllerPlayer = GetComponent<CharacterController>();

    }

    void Update()
    {
        // rotera
        float moveHorizontal = Input.GetAxis("Horizontal");

        myPlayer.Rotate(
                        0f,
                        PlayerRotationSpeed * Time.deltaTime * moveHorizontal,
                        0f
                        );
        // flytta    
        float moveVertical = Input.GetAxis("Vertical");
        myControllerPlayer.SimpleMove(myPlayer.forward * PlayerSpeed * moveVertical);

    }

}
