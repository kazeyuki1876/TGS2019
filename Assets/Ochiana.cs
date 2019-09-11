using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Ochiana : MonoBehaviour
{
    public float TIME = 3.0f;
    public bool isMain= true;
    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(this);
        
        GameObject container = GameObject.Find("Main Camera");
        //https://blog.csdn.net/yy763496668/article/details/51576694 优化？
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main"&& isMain)
        {
            isMain = !isMain;
            Invoke("OchianaOVER", TIME);
            this.transform.position = new Vector3( 40, 28, -15.0f);
        }
       
    }
    void OchianaOVER() {
        
        Destroy(this.gameObject, 3.0f);
        GameObject.Find("Main Effect Controller").SendMessage("RakuyouInstantiate");//
    }
 
}

