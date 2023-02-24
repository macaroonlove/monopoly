using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    public static int order = 1;
    //Renderer player1Color;

    public AudioSource mybgm;
    public AudioClip dicebgm;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       /* GameObject player1 = GameObject.Find("Stone").transform.Find("player1").gameObject;
        GameObject player2 = GameObject.Find("Stone").transform.Find("player2").gameObject;
        GameObject player3 = GameObject.Find("Stone").transform.Find("player3").gameObject;
        GameObject player4 = GameObject.Find("Stone").transform.Find("player4").gameObject;

        player1Color = player1.GetComponent<Renderer>();*/

    }

    void Update()
    {
        diceVelocity = rb.velocity;
       
        
        if (order == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Stone.dicenumber = 0;
                Stone.playermove = true;
                Stone.player1 = true;
                Stone2.player2 = false;
                Stone3.player3 = false;
                Stone4.player4 = false;
                DiceNumberTextScript.diceNumber = 0;
                DiceNumberTextScript.diceNumber2 = 0;
                float dirX = Random.Range(100000, 300000000);
                float dirY = Random.Range(100000, 300000000);
                float dirZ = Random.Range(100000, 300000000);
                transform.position = new Vector3(0, 70, 0);
                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50000);
                rb.AddTorque(dirX, dirY, dirZ);
                DiceSound();
            }
        }
        else if(order == 2)
        { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Stone2.dicenumber2 = 0;
                Stone2.playermove = true;
                Stone.player1 = false;
                Stone2.player2 = true;
                Stone3.player3 = false;
                Stone4.player4 = false;
                DiceNumberTextScript.diceNumber = 0;
                DiceNumberTextScript.diceNumber2 = 0;
                float dirX = Random.Range(100000, 300000000);
                float dirY = Random.Range(100000, 300000000);
                float dirZ = Random.Range(100000, 300000000);
                transform.position = new Vector3(0, 70, 0);
                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50000);
                rb.AddTorque(dirX, dirY, dirZ);
                DiceSound();
            }
        }
        else if (order == 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Stone3.dicenumber3 = 0;
                Stone3.playermove = true;
                Stone.player1 = false;
                Stone2.player2 = false;
                Stone3.player3 = true;
                Stone4.player4 = false;
                DiceNumberTextScript.diceNumber = 0;
                DiceNumberTextScript.diceNumber2 = 0;
                float dirX = Random.Range(100000, 300000000);
                float dirY = Random.Range(100000, 300000000);
                float dirZ = Random.Range(100000, 300000000);
                transform.position = new Vector3(0, 70, 0);
                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50000);
                rb.AddTorque(dirX, dirY, dirZ);
                DiceSound();
            }
        }
        else if (order == 4)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Stone4.dicenumber4 = 0;
                Stone4.playermove = true;
                Stone.player1 = false;
                Stone2.player2 = false;
                Stone3.player3 = false;
                Stone4.player4 = true;
                DiceNumberTextScript.diceNumber = 0;
                DiceNumberTextScript.diceNumber2 = 0;
                float dirX = Random.Range(100000, 300000000);
                float dirY = Random.Range(100000, 300000000);
                float dirZ = Random.Range(100000, 300000000);
                transform.position = new Vector3(0, 70, 0);
                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50000);
                rb.AddTorque(dirX, dirY, dirZ);
                DiceSound();
            }
        }
    }

    public void DiceSound()
    {
        mybgm.PlayOneShot(dicebgm);
    }
}
