using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main＿DownButton : MonoBehaviour
{
    public bool ButtonSwitchON = true;
    public float ButtonSwitchTimeINT =3;


    void Reset()
    {
        Invoke("UPButtonReset", ButtonSwitchTimeINT);
    }
    void UPButtonReset()
    {
        ButtonSwitchON = true;
    }

    public void OnClick()
    {
        if (ButtonSwitchON)
        {
            GameObject.Find("Main Controller").SendMessage("ButtonDownInput");// 
            Debug.Log("Main＿DownButton");
            ButtonSwitchON = false;
            Reset();
        }

    }
}
