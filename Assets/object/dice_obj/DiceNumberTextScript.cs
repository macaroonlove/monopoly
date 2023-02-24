using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour
{
    Text text;
    public static int diceNumber;
    public static int diceNumber2;
    public static int diceNumberplus;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (diceNumber != 0 && diceNumber2 != 0)
        {
            diceNumberplus = diceNumber + diceNumber2;
            text.text = diceNumberplus.ToString();
            if(DiceScript.order == 1)
            {
                Stone.dicenumber = diceNumberplus;
            }
            else if(DiceScript.order == 2)
            {
                Stone2.dicenumber2 = diceNumberplus;
            }
            else if (DiceScript.order == 3)
            {
                Stone3.dicenumber3 = diceNumberplus;
            }
            else if (DiceScript.order == 4)
            {
                Stone4.dicenumber4 = diceNumberplus;
            }
            
        }
        StartCoroutine(SomeCoroutine());
    }

    IEnumerator SomeCoroutine()
    {
        yield return null;
        //Stone.dicenumber = 0;
        //Stone2.dicenumber2 = 0;
    }
}
