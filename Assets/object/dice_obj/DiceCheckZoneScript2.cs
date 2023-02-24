using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript2 : MonoBehaviour
{
    Vector3 diceVelocity;

    void FixedUpdate()
    {
        diceVelocity = DiceScript.diceVelocity;
    }

    void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side2_1":
                    DiceNumberTextScript.diceNumber2 = 6;
                    break;
                case "Side2_2":
                    DiceNumberTextScript.diceNumber2 = 5;
                    break;
                case "Side2_3":
                    DiceNumberTextScript.diceNumber2 = 4;
                    break;
                case "Side2_4":
                    DiceNumberTextScript.diceNumber2 = 3;
                    break;
                case "Side2_5":
                    DiceNumberTextScript.diceNumber2 = 2;
                    break;
                case "Side2_6":
                    DiceNumberTextScript.diceNumber2 = 1;
                    break;
            }
        }
    }
}
