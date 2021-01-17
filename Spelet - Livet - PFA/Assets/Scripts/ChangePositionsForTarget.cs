using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionsForTarget : MonoBehaviour
{
    #region // Target positions
    // The player/tanken marker (needs to be choosen in Unity editor) 
    [SerializeField]
    Transform tanken;

    // The avatar/personen marker (needs to be choosen in Unity editor) 
    [SerializeField]
    Transform personen;

    // Första valet positionen 
    [SerializeField]
    Transform choiceOne;

    // Dörr #1 A position, innan gått igenom dörren.  
    [SerializeField]
    Transform choiceOneDoorA;

    // Dörr #1 B position, innan gått igenom dörren.
    [SerializeField]
    Transform choiceOneDoorB;

    // Dörr #1 A position, går igenom dörr #1A.  
    [SerializeField]
    Transform choiceOneDoorApass;

    // Dörr #1 B position, går igenom dörr #1B.
    [SerializeField]
    Transform choiceOneDoorBpass;

    // Andra valet positionen 
    [SerializeField]
    Transform choiceTwo;

    #endregion

    // Choice #1  made.
    private bool choiceOneMade = false;

    // Door #1 passed check.
    private bool doorOnePassed = false;

    // String which says which key is held currently
    private string keyTypeHeld;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = choiceOne.position;
    }

   

    void Update()
    {
        // Get keyType from GameInfo which taken from KeyScritps 
        keyTypeHeld = GameInfo.keyType;
        // Debug.Log("This is the keyType held: " + keyTypeHeld);

        

        if (doorOnePassed == false)
        {   
            if (choiceOneMade == false)
            {
                          

                  
                                // sats om keyTypeHeld = left & om tanken och Personen är inom collider radien/ytan 
                                // { this.transform.position = choiceOneDoorApass.position; 
                                //  choiceOneMade = true; } 


                                // + Sammma som ovan fast för höger & Bpass 


                if (keyTypeHeld == "Left") // *** BYT NAMN PÅ STRING SOM SÄGER LEFT TILL NYA NYCKELNAMN I KeyScripts när det ändras där ***
                { this.transform.position = choiceOneDoorA.position; }

                else if (keyTypeHeld == "Right") // *** BYT NAMN PÅ STRING SOM SÄGER RIGHT TILL NYA NYCKELNAMN I KeyScripts när det ändras där ***
                { this.transform.position = choiceOneDoorB.position; }

                else { this.transform.position = choiceOne.position; }

            }

            //if (choiceOneMade == true)
            //{
            //    // if sats om Personen är inom trigger området för target
            //   //  { this.transform.position = choiceTwo.position; }
            //}

        }
    }

    

}
