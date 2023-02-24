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
        //GameObject 동굴권리증 = GameObject.Find("UI모음").transform.Find("동굴UI").gameObject;
        if (gameObject.activeSelf == true)
            gameObject.SetActive(false);
        Debug.Log("버튼 클릭함");
    }
}
