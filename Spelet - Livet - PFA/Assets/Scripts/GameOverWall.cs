using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverWall : MonoBehaviour
{
    public bool EndGame = false;

  
     private void OnTriggerEnter(Collider other) {
        if (other.tag == "Death") {
            //Destroy (other.gameObject);
            //source.Play (); 
            //GameInfo.NumCoins--;
            Debug.Log("Game Over");
            Application.Quit();
        }
    }
}