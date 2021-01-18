using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionsForTarget : MonoBehaviour
{
    #region  Transforms - Target positions

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

    // Dörr #2 A position, innan gått igenom dörren.  
    [SerializeField]
    Transform choiceTwoDoorA;

    // Dörr #2 B position, innan gått igenom dörren.
    [SerializeField]
    Transform choiceTwoDoorB;

    // Dörr #2 A position, går igenom dörr #1A.  
    [SerializeField]
    Transform choiceTwoDoorApass;

    // Dörr #2 B position, går igenom dörr #1B.
    [SerializeField]
    Transform choiceTwoDoorBpass;

    // Andra valet positionen 
    [SerializeField]
    Transform choiceThree;

    #endregion

    #region Booleans - Choices & Doors passed 

    // Choice #1  made.
    private bool choiceOneMade = false;

    // Door #1 passed check.
    private bool doorOnePassed = false;

    // Choice #2  made.
    private bool choiceTwoMade = false;

    // Door #2 passed check.
    private bool doorTwoPassed = false;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // Starting position for target
        this.transform.position = choiceOne.position;
    }


    void Update()
    {
        // Debug.Log("This is the keyType held: " + GameInfo.keyType);
        // Debug.Log("Player close to target: " + GameInfo.playerCloseToTarget);
        // Debug.Log("Avatar close to target: " + GameInfo.avatarCloseToTarget);

        #region Target positions for 1st section

        // Så änge inte första dörren passerats igenom
        if (doorOnePassed == false)
        {   
            // Så länge inte ett första val har gjorts
            if (choiceOneMade == false)
            {
                // Om man håller i Key 1, samt att tanken/player & personen/avataren är nära target som är framför dörrarna. Då gå igenom dörr #1A
                if (GameInfo.keyType == "Key 1" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceOneDoorApass.position;
                    choiceOneMade = true;
                    GameInfo.avatarCloseToTarget = false;
                }

                // Om man håller i Key 2, samt att tanken/player & personen/avataren är nära target som är framför dörrarna. Då gå igenom dörr #1B
                else if (GameInfo.keyType == "Key 2" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceOneDoorBpass.position;
                    choiceOneMade = true;
                    GameInfo.avatarCloseToTarget = false; 
                }
                
                // Håller man i Key 1 så byts target position till framför dörr #1A. 
                else  if (GameInfo.keyType == "Key 1") // *** BYT NAMN PÅ STRING SOM SÄGER Key 1 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceOneDoorA.position; }

                // Håller man i Key 2 så byts target position till framför dörr #1B. 
                else if (GameInfo.keyType == "Key 2") // *** BYT NAMN PÅ STRING SOM SÄGER Key 2 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceOneDoorB.position; }

                // Håller man inte i någon nyckel så hamnar target på start positionen. 
                else { this.transform.position = choiceOne.position; }

            }
            // När första valet har gjort och Personen/Avataren passerat dörren och är nära target så byts target till start position för sektion två. 
            else if (choiceOneMade == true && GameInfo.avatarCloseToTarget == true)
            {
                this.transform.position = choiceTwo.position;
                doorOnePassed = true; 
            }
         
        }
        #endregion 

        #region Target positions for 2nd section

        else if (doorOnePassed == true && doorTwoPassed == false)
        {
            if (choiceTwoMade == false)
            {
                if (GameInfo.keyType == "Key 3" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceTwoDoorApass.position;
                    choiceTwoMade = true;
                    GameInfo.avatarCloseToTarget = false;
                }

                else if (GameInfo.keyType == "Key 4" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceTwoDoorBpass.position;
                    choiceTwoMade = true;
                    GameInfo.avatarCloseToTarget = false;
                }

                else if (GameInfo.keyType == "Key 3") // *** BYT NAMN PÅ STRING SOM SÄGER Key 1 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceTwoDoorA.position; }

                else if (GameInfo.keyType == "Key 4") // *** BYT NAMN PÅ STRING SOM SÄGER Key 2 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceTwoDoorB.position; }

                else { this.transform.position = choiceTwo.position; }

            }

            else if (choiceTwoMade == true && GameInfo.avatarCloseToTarget == true)
            {
                this.transform.position = choiceThree.position;
                doorTwoPassed = true;
            }

        }
        #endregion

    }



}
