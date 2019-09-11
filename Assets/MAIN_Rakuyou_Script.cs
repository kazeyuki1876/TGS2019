using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAIN_Rakuyou_Script : MonoBehaviour
{
    public GameObject Rakuyou1;//落ち葉のエフェクト
    public GameObject Rakuyou2;
    public float[] XY;

    private void Update()
    {

    }
    void RakuyouInstantiate() {
        //落葉止め生成
        Rakuyou1 = Instantiate(Rakuyou1, new Vector3(XY[0], XY[1], -10), Quaternion.identity); //

        Rakuyou2 = Instantiate(Rakuyou2, new Vector3(XY[2], XY[3], -10), Quaternion.identity); //
        Rakuyou1.transform.Rotate(new Vector3(090, 50, 0), 90);
        Rakuyou2.transform.Rotate(new Vector3(90, 0, 0), 90);

    }
    void RakuyouOVER()

    {//落葉止め
        Debug.Log(GameObject.Find("Rakuyou1"));
        if (GameObject.Find("Rakuyou1") != null) {
            Destroy(Rakuyou1.gameObject);
            Destroy(Rakuyou2.gameObject);
            GameObject.Find("Main Effect Controller").GetComponent<MAIN_Rakuyou_Script>().enabled = false;
        }
       
    }
}
