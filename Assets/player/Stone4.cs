using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone4 : MonoBehaviour
{
    public Route4 currentRoute;

    int routePosition;
    public static bool timepermission = false;

    public int steps;
    bool isMoving;
    public static bool playermove = true;

    public static bool player4 = false;

    public static int dicenumber4;

    int location = 0;

    int player1distance;

    public AudioSource mybgm;
    [SerializeField] public AudioClip[] dicenumberbgm;

    void Start()
    {
    }

    void Update()
    {
        if (dicenumber4 != 0 && !isMoving && player4)
        {
            steps = dicenumber4;
            //steps = 7;
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
        if (dicenumber4 == 1)
            DiceSound(0);
        else if (dicenumber4 == 2)
            DiceSound(1);
        else if (dicenumber4 == 3)
            DiceSound(2);
        else if (dicenumber4 == 4)
            DiceSound(3);
        else if (dicenumber4 == 5)
            DiceSound(4);
        else if (dicenumber4 == 6)
            DiceSound(5);
        else if (dicenumber4 == 7)
            DiceSound(6);
        else if (dicenumber4 == 8)
            DiceSound(7);
        else if (dicenumber4 == 9)
            DiceSound(8);
        else if (dicenumber4 == 10)
            DiceSound(9);
        else if (dicenumber4 == 11)
            DiceSound(10);
        else if (dicenumber4 == 12)
            DiceSound(11);
        yield return StartCoroutine(Move());
        GameManager.distance4 = location;
        Debug.Log("ÇÃ·¹ÀÌ¾î4 ÃÑ ÀÌµ¿ °ª " + GameManager.distance4);
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
            DiceScript.order = 4;
        }
        else
        {*/
        GameObject ½Â¸® = GameObject.Find("½Â¸®");
        if (player1money.money < 0)
        {
            if (player2money.money < 0)
            {
                if (player3money.money < 0)
                {
                    Debug.Log("player4 ½Â¸®");
                    ½Â¸®.SetActive(true);
                }
                else
                {
                    DiceScript.order = 3;
                }
            }
            else
            {
                DiceScript.order = 2;
            }
        }
        else
        {
            DiceScript.order = 1;
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
