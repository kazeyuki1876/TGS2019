using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Main＿UPButton  : MonoBehaviour
{
    public bool ButtonSwitchON = true;
    public float ButtonSwitchTimeINT = 3;


    void Reset() {
        Invoke("UPButtonReset", ButtonSwitchTimeINT);
    }
    void UPButtonReset() {
        ButtonSwitchON = true;
    }

    public void OnClick()
    {
        if (ButtonSwitchON) {
            GameObject.Find("Main Controller").SendMessage("ButtonUpInput");// GameStart  
            Debug.Log("ButtonUpInput");
            ButtonSwitchON = false;
            Reset();
        }
           
    }
}

