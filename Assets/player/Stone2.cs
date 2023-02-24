using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone2 : MonoBehaviour
{
    public Route2 currentRoute;

    int routePosition;
    public static bool timepermission = false;

    public int steps;
    bool isMoving;
    public static bool playermove = true;

    public static bool player2 = false;

    public static int dicenumber2;

    int location = 0;

    int player1distance;

    public AudioSource mybgm;
    [SerializeField] public AudioClip[] dicenumberbgm;

    void Start()
    {
    }

    void Update()
    {
        if (dicenumber2 != 0 && !isMoving && player2)
        {
            steps = dicenumber2;
            //steps = 5;
            //Debug.Log("Dice Rolled " + steps);
            
            if (playermove)
            {
                StartCoroutine(Give());
                playermove = false;
            }
        }
        if (timepermission && !isMoving)
        {
            steps = Å¸ÀÓ¸Ó½Å.timemove;
            if (playermove)
            {
                StartCoroutine(Give());
                timepermission = false;
                playermove = false;
            }
        }
    }

    IEnumerator Give()
    {
        if (dicenumber2 == 1)
            DiceSound(0);
        else if (dicenumber2 == 2)
            DiceSound(1);
        else if (dicenumber2 == 3)
            DiceSound(2);
        else if (dicenumber2 == 4)
            DiceSound(3);
        else if (dicenumber2 == 5)
            DiceSound(4);
        else if (dicenumber2 == 6)
            DiceSound(5);
        else if (dicenumber2 == 7)
            DiceSound(6);
        else if (dicenumber2 == 8)
            DiceSound(7);
        else if (dicenumber2 == 9)
            DiceSound(8);
        else if (dicenumber2 == 10)
            DiceSound(9);
        else if (dicenumber2 == 11)
            DiceSound(10);
        else if (dicenumber2 == 12)
            DiceSound(11);
        yield return StartCoroutine(Move());
        GameManager.distance2 = location;
        Debug.Log("ÇÃ·¹ÀÌ¾î2 ÃÑ ÀÌµ¿ °ª " + GameManager.distance2);
        GameManager.UIScrean = true;
    }

    IEnumerator Move()
    {
        if (isMoving)
        {
            yield break;
        }
        isMoving = true;

        while (steps > 0)
        {

            routePosition++;
            routePosition %= currentRoute.childNodeList.Count;

            Vector3 nextPos = currentRoute.childNodeList[routePosition].position;
            while (MoveToNextNode(nextPos)) { yield return null; }
            location++;
            yield return new WaitForSeconds(0.05f);
            steps--;
            //routePosition++;
        }
        isMoving = false;
        /*if (DiceNumberTextScript.diceNumber == DiceNumberTextScript.diceNumber2)
        {
            DiceScript.order = 2;
        }
        else
        {*/
        GameObject ½Â¸® = GameObject.Find("½Â¸®");
        if (player3money.money < 0)
        {
            if (player4money.money < 0)
            {
                if (player1money.money < 0)
                {
                    Debug.Log("player2 ½Â¸®");
                    ½Â¸®.SetActive(true);
                }
                else
                {
                    DiceScript.order = 1;
                }
            }
            else
            {
                DiceScript.order = 4;
            }
        }
        else
        {
            DiceScript.order = 3;
        }
        //}
    }

    bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 150f * Time.deltaTime));
    }

    public void DiceSound(int i)
    {
        mybgm.PlayOneShot(dicenumberbgm[i]);
    }
}
