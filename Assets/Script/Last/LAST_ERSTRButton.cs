using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//シーン転移　には必要


public class LAST_ERSTRButton: MonoBehaviour
{
    bool OnClickOFF = true;
    public void OnClick()
    {
        if (OnClickOFF)
        {
            SceneManager.LoadScene("START");//シーンの切り替え
            OnClickOFF = false;
        }


    }
}
