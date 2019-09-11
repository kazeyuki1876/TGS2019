using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Main＿TEXTButton : MonoBehaviour
{
    public bool ButtonSwitchON = true;
    public float ButtonSwitchTimeINT =0.5f;


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
            GameObject.Find("Main Controller").SendMessage("ButtonTEXTInput");// 
            Debug.Log("Main＿TEXTButton");
            ButtonSwitchON = false;
            Reset();
        }

    }
}

