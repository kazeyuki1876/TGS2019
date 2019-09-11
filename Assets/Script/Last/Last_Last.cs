using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Last_Last : MonoBehaviour
{
    public GameObject SourceBOX;
    // Start is called before the first frame update
    void Start()
    {
        SourceBOX = GameObject.Find("Source　BOX");



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)||Input.GetMouseButton(0))
        {
            Destroy(SourceBOX.gameObject);
            //Source BOX
            SceneManager.LoadScene("START");//シーンの切り替え
                                           //Application.Quit();//GAME Quit

        }
        if (Input.GetKey(KeyCode.J))
        {
        Application.Quit();//GAME Quit

        }
    }
}
