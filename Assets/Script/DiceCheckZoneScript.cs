using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour
{
    Vector3 diceVelocity;

    //Update is called once per frame
    void FixedUpdate()
    {
        diceVelocity = WhiteDiceScript.diceVelocity;
        diceVelocity = BlackDiceScript.diceVelocity;
    }

    void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "SideB1":
                    DiceNumberTextScript.BlackdiceNumber = 6;
                    break;

                case "SideW1":
                    DiceNumberTextScript.WhitediceNumber = 6;
                    break;


                case "SideB2":
                    DiceNumberTextScript.BlackdiceNumber = 5;
                    break;

                case "SideW2":
                    DiceNumberTextScript.WhitediceNumber = 5;
                    break;


                case "SideB3":
                    DiceNumberTextScript.BlackdiceNumber = 4;
                    break;

                case "SideW3":
                    DiceNumberTextScript.WhitediceNumber = 4;
                    break;


                case "SideB4":
                    DiceNumberTextScript.BlackdiceNumber = 3;
                    break;

                case "SideW4":
                    DiceNumberTextScript.WhitediceNumber = 3;
                    break;


                case "SideB5":
                    DiceNumberTextScript.BlackdiceNumber = 2;
                    break;

                case "SideW5":
                    DiceNumberTextScript.WhitediceNumber = 2;
                    break;


                case "SideB6":
                    DiceNumberTextScript.BlackdiceNumber = 1;
                    break;

                case "SideW6":
                    DiceNumberTextScript.WhitediceNumber = 1;
                    break;

            }
        }
    }
}
