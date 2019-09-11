using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ERSRT_QUITButton : MonoBehaviour
{
    bool OnClickOFF = true;
    public void OnClick()
    {
        if (OnClickOFF)
        {
            Application.Quit();//GAME Quit
            Debug.Log("88");
            OnClickOFF = false;
        }


    }
}