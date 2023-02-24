using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource mybgm;
    [SerializeField] public AudioClip[] dicenumberbgm;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Stone.dicenumber == 1)
            DiceSound(0);
        else if (Stone.dicenumber == 2)
            DiceSound(1);
        else if (Stone.dicenumber == 3)
            DiceSound(2);
        else if (Stone.dicenumber == 4)
            DiceSound(3);
        else if (Stone.dicenumber == 5)
            DiceSound(4);
        else if (Stone.dicenumber == 6)
            DiceSound(5);
        else if (Stone.dicenumber == 7)
            DiceSound(6);
        else if (Stone.dicenumber == 8)
            DiceSound(7);
        else if (Stone.dicenumber == 9)
            DiceSound(8);
        else if (Stone.dicenumber == 10)
            DiceSound(9);
        else if (Stone.dicenumber == 11)
            DiceSound(10);
        else if (Stone.dicenumber == 12)
            DiceSound(11);

        if (Stone2.dicenumber2 == 1)
            DiceSound(0);
        else if (Stone2.dicenumber2 == 2)
            DiceSound(1);
        else if (Stone2.dicenumber2 == 3)
            DiceSound(2);
        else if (Stone2.dicenumber2 == 4)
            DiceSound(3);
        else if (Stone2.dicenumber2 == 5)
            DiceSound(4);
        else if (Stone2.dicenumber2 == 6)
            DiceSound(5);
        else if (Stone2.dicenumber2 == 7)
            DiceSound(6);
        else if (Stone2.dicenumber2 == 8)
            DiceSound(7);
        else if (Stone2.dicenumber2 == 9)
            DiceSound(8);
        else if (Stone2.dicenumber2 == 10)
            DiceSound(9);
        else if (Stone2.dicenumber2 == 11)
            DiceSound(10);
        else if (Stone2.dicenumber2 == 12)
            DiceSound(11);
    }

    public void DiceSound(int i)
    {
        mybgm.PlayOneShot(dicenumberbgm[i]);
    }
}
