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

    ///

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

    ///

    // Tredje valet positionen 
    [SerializeField]
    Transform choiceThree;

    // Dörr #3 A position, innan gått igenom dörren.  
    [SerializeField]
    Transform choiceThreeDoorA;

    // Dörr #3 B position, innan gått igenom dörren.
    [SerializeField]
    Transform choiceThreeDoorB;

    // Dörr #3 A position, går igenom dörr #1A.  
    [SerializeField]
    Transform choiceThreeDoorApass;

    // Dörr #3 B position, går igenom dörr #1B.
    [SerializeField]
    Transform choiceThreeDoorBpass;

    ///

    // Fjärde valet positionen 
    [SerializeField]
    Transform choiceFour;

    // Dörr #4 A position, innan gått igenom dörren.  
    [SerializeField]
    Transform choiceFourDoorA;

    // Dörr #4 B position, innan gått igenom dörren.
    [SerializeField]
    Transform choiceFourDoorB;

    // Dörr #4 A position, går igenom dörr #1A.  
    [SerializeField]
    Transform choiceFourDoorApass;

    // Dörr #4 B position, går igenom dörr #1B.
    [SerializeField]
    Transform choiceFourDoorBpass;

    // 

    // End Position
    [SerializeField]
    Transform endPosition;

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

    // Choice #3  made.
    private bool choiceThreeMade = false;

    // Door #3 passed check.
    private bool doorThreePassed = false;

    // Choice #4  made.
    private bool choiceFourMade = false;

    // Door #4 passed check
    private bool doorFourPassed = false;


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

        #region Target positions for 3rd section

        else if (doorOnePassed == true && doorTwoPassed == true && doorThreePassed == false)
        {
            if (choiceThreeMade == false)
            {
                if (GameInfo.keyType == "Key 5" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceThreeDoorApass.position;
                    choiceThreeMade = true;
                    GameInfo.avatarCloseToTarget = false;
                }

                else if (GameInfo.keyType == "Key 6" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceThreeDoorBpass.position;
                    choiceThreeMade = true;
                    GameInfo.avatarCloseToTarget = false;
                }

                else if (GameInfo.keyType == "Key 5") // *** BYT NAMN PÅ STRING SOM SÄGER Key 1 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceThreeDoorA.position; }

                else if (GameInfo.keyType == "Key 6") // *** BYT NAMN PÅ STRING SOM SÄGER Key 2 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceThreeDoorB.position; }

                else { this.transform.position = choiceThree.position; }

            }

            else if (choiceThreeMade == true && GameInfo.avatarCloseToTarget == true)
            {
                this.transform.position = choiceFour.position;
                doorThreePassed = true;
            }

        }

        #endregion


        #region positions for 4th section 

        else if (doorOnePassed == true && doorTwoPassed == true && doorThreePassed == true && doorFourPassed == false)
        {
            if (choiceFourMade == false)
            {
                if (GameInfo.keyType == "Key 7" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceFourDoorApass.position;
                    choiceFourMade = true;
                    GameInfo.avatarCloseToTarget = false;
                }

                else if (GameInfo.keyType == "Key 8" && GameInfo.playerCloseToTarget == true && GameInfo.avatarCloseToTarget == true)
                {
                    this.transform.position = choiceFourDoorBpass.position;
                    choiceFourMade = true;
                    GameInfo.avatarCloseToTarget = false;
                }

                else if (GameInfo.keyType == "Key 7") // *** BYT NAMN PÅ STRING SOM SÄGER Key 1 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceFourDoorA.position; }

                else if (GameInfo.keyType == "Key 8") // *** BYT NAMN PÅ STRING SOM SÄGER Key 2 TILL NYA NYCKELNAMN SOM I KeyScripts när det ändras där ***
                { this.transform.position = choiceFourDoorB.position; }

                else { this.transform.position = choiceFour.position; }

            }

            else if (choiceFourMade == true && GameInfo.avatarCloseToTarget == true)
            {
                // LAST POSITION FOR TARGET
                this.transform.position = endPosition.position;
                doorFourPassed = true;
            }

        }
        #endregion


    }



}
