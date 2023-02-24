using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 은행 : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = 사회기금.bank.ToString() + "\n만원";
    }
}
