using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nobuy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cancelbutton()
    {
        //GameObject �����Ǹ��� = GameObject.Find("UI����").transform.Find("����UI").gameObject;
        if (gameObject.activeSelf == true)
            gameObject.SetActive(false);
        Debug.Log("��ư Ŭ����");
    }
}
