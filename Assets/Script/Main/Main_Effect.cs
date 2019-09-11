using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Effect : MonoBehaviour
{
    //----天灯エフェクト
    public GameObject tenntou1;
    public GameObject tenntou2;
    public GameObject tenntou3;
    public float tenntou1_A = 0;
    public float tenntou2_A = 0;
    public float tenntou3_A = 0;
    public bool SkylanternMoveON;


  //--------
    void Start()
    {
        Skylantern();
    }
    void Update()
    {
        SkylanternMove();
    }
    //---------------------天灯エフェクト
    void Skylantern() {
        tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou1_A / 255);
        tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou2_A / 255);
        tenntou3.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou3_A / 255);
    }
    void SkylanternMoveStart() {
        SkylanternMoveON = true;
        Debug.Log("天灯エフェクトSTART");
    }
    void SkylanternMove()
    {
        if (SkylanternMoveON) {
          
            tenntou1_A += 1f;
            if (tenntou1_A >= 255)
            {
                tenntou2_A += 2f;

            }
            if (tenntou2_A >= 255)
            {
                tenntou3_A += 2f;
            }
            if(tenntou3_A >= 255) {
                //  SkylanternMoveON = false;
                GameObject.Find("Main Controller").SendMessage("Kiseki2Illustration00");//奇跡2のエフェクト終わるまでテキストが出てこないように設定。
                GameObject.Find("Main Effect Controller").GetComponent<Main_Effect>().enabled = false;
              





            }
            tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou1_A / 255);
            tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou2_A / 255);
            tenntou3.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou3_A / 255);
        }
    }
    //----------------天灯エフェクトOVER
    //----------------

}
