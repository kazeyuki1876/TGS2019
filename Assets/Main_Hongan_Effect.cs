using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_Hongan_Effect : MonoBehaviour
{
    public GameObject Main_Hongan_Tenntou1;
    public GameObject Main_Hongan_Tenntou2;
    public GameObject Main_Hongan_Chara1;
    public float Hongan_Tenntou1_A = 0;
    public float Hongan_Tenntou2_A = 0;
    public float Hongan_Chara1_A = 0;
    public float Hongan_Tenntou1_Aspeed = 0;
    public float Hongan_Tenntou2_Aspeed = 0;
    public float Hongan_Chara1_Aspeed = 0;
    public bool HonganON;
    public bool X;
    // Use this for initialization

    void Start()
    {
        Main_Hongan_Tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Hongan_Tenntou1_A / 255);
        Main_Hongan_Tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Hongan_Tenntou2_A / 255);
        Main_Hongan_Chara1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Hongan_Chara1_A / 255);

    }


    // Update is called once per frame

    void Update()
    {
       Hongan();
    }

    void HonganMoveStart()
    {
       HonganON = true;
        Debug.Log("決定START");
    }

    void Hongan()

    {
        if (HonganON)
        {
            Main_Hongan_Tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Hongan_Tenntou1_A / 255);
            Debug.Log(Main_Hongan_Tenntou1.GetComponent<SpriteRenderer>().color);
            Main_Hongan_Tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Hongan_Tenntou2_A / 255);
            Debug.Log(Main_Hongan_Tenntou2.GetComponent<SpriteRenderer>().color);
            Main_Hongan_Chara1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Hongan_Chara1_A / 255);
            Debug.Log(Main_Hongan_Chara1.GetComponent<SpriteRenderer>().color);

            Hongan_Tenntou1_A += Hongan_Tenntou1_Aspeed;

            if (Hongan_Tenntou1_A >= 255)
            {
                Hongan_Tenntou2_A += Hongan_Tenntou2_Aspeed;

            }


            if (Hongan_Tenntou2_A >= 255)
            {
                Hongan_Chara1_A += Hongan_Chara1_Aspeed;
                if (Hongan_Chara1_A >= 255)
                {
                    GameObject.Find("Main Effect Controller").GetComponent<Main_Hongan_Effect>().enabled = false;
                    GameObject.Find("Main Controller").SendMessage("HonganIllustration00");//MoveRight
                }
            }

            
        }
    }
}


