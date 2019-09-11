using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_TitelTransparent : MonoBehaviour
{


    //GameObject.Find("GameObject.name").GetComponent<sparent.name>().Void.name();
    public  bool TitelTransparentSwitch = false; //
    public bool TitelTransparentSwitchOFF = false; //
    //Color RGBA
    float changeRed = 1.0f;
    float changeGreen = 1.0f;
    float cahngeBlue = 1.0f;
    float cahngeAlpha = 1.0f;
    
    public float CahngeAlpha_Speed ;

    void Update()
    {
        TitelTransparent();
      
    }
    void TitelTransparentON() {
        TitelTransparentSwitch = true; 
    }
    void TitelTransparent()
    {

        if (TitelTransparentSwitch && cahngeAlpha > 0.0f)
        {
            cahngeAlpha = cahngeAlpha - Time.deltaTime * CahngeAlpha_Speed;
            this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
        }
        else if (TitelTransparentSwitch && cahngeAlpha <= 0.0f && TitelTransparentSwitchOFF == false)
        {
            TitelTransparentSwitch = false;
            TitelTransparentSwitchOFF = true;

            Debug.Log("タイトル文字透明化完成  GameStartに戻り");
            GameObject.Find("StartController").SendMessage("GameStart");// GameStartに戻り

        }
    }
}
