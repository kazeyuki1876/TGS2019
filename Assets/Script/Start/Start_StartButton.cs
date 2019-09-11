using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Start_StartButton : MonoBehaviour
{
    bool OnClickOFF = false;
    public void Start()
    {
        Invoke("ON", 5.0f);
    }
   
    private void ON()
    {
        OnClickOFF = true; 
    }
    public void OnClick()
    {
        if (OnClickOFF)
        {
            GameObject.Find("StartController").SendMessage("GameStart");// GameStart  
            OnClickOFF = false;
        }


    }

}
