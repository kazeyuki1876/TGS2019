using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Syugyou_Script : MonoBehaviour
{
    //初期設定------------
    public GameObject RihakuSprite;//かぶる画像Sprite李白
    public GameObject AkamaruiSprite;//かぶる画像Sprite赤丸 //初期設定------------
    public SpriteRenderer RihakuSpriteL;
    public SpriteRenderer AkamaruiSpritL;

    public Sprite[] KetteiSprite;

    public bool SyugyouSpriteStart = false;//画像かぶるを始まりレバー
    public float Syugyou_A = 0;//かぶる画像Sprite1のCOLORA;
    public float SyugyouSpriteASpeed;//かぶる画像SpriteのCOLORAの速度;
    public bool MOVE = true;
    public int SpritePOS = 0;
    public float RihakuPOSX0;
    public float RihakuPOSY0;
    public float AkamaruPOSX0;
    public float AkamaruPOSY0;
    public float RihakuPOSX1;
    public float RihakuPOSY1;
    public float RihakuPOSX2;
    public float RihakuPOSY2;
    public float AkamaruPOSX1;
    public float AkamaruPOSY1;
    public float AkamaruPOSX2;
    public float AkamaruPOSY2;
    public float StartScale0;
    public float StartScale1;
    public float StartScale2;
   

    void Start (){
       /* RihakuSprite.GetComponent<Transform>().transform.position = new Vector3(RihakuPOSX0, RihakuPOSY0, -5);
        AkamaruiSprite.GetComponent<Transform>().transform.position = new Vector3(AkamaruPOSX0, AkamaruPOSY0, -5);
        //size
        RihakuSprite.GetComponent<Transform>().localScale = new Vector3(StartScale0, StartScale0, 1);
        AkamaruiSprite.GetComponent<Transform>().localScale = new Vector3(StartScale0, StartScale0, 1);*/
        RihakuSprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Syugyou_A / 255);
        AkamaruiSprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Syugyou_A / 255);

        RihakuSpriteL= RihakuSpriteL.GetComponent<SpriteRenderer>();
 

    }
    void Update()
    {
        SyugyouChangeMove();
    }
    //入力VOID
    void SyugyouSpriteON()
    {
        SyugyouSpriteStart = true;
    }
    //--------------ChangeMove
    void SyugyouChangeMove()
    {
        if (SyugyouSpriteStart)
        {//SyugyouSpriteStart　は真（ま）
            if (Syugyou_A < 255 && MOVE)
            {
                Syugyou_A = Syugyou_A + SyugyouSpriteASpeed * Time.deltaTime;//Sprite1を染まる
                RihakuSprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Syugyou_A / 255);
                AkamaruiSprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Syugyou_A / 255);
                if (Syugyou_A > 255) {
                    MOVE = false;
                }
            }
            else if (Syugyou_A > 0 && !MOVE && SpritePOS < 2)
            {
                Syugyou_A = Syugyou_A - SyugyouSpriteASpeed * Time.deltaTime;//Sprite1を染まる
                RihakuSprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Syugyou_A / 255);
                AkamaruiSprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Syugyou_A / 255);
            }
            else if (Syugyou_A < 0 && !MOVE && SpritePOS < 1)
            {//pos
             /*
             RihakuSprite.GetComponent<Transform>().transform.position = new Vector3(RihakuPOSX1, RihakuPOSY1, -5);
             AkamaruiSprite.GetComponent<Transform>().transform.position = new Vector3(AkamaruPOSX1, AkamaruPOSY1, -5);
          

               /* RihakuSprite.GetComponent<Transform>().localScale = new Vector3(StartScale1, StartScale1, 1);
                AkamaruiSprite.GetComponent<Transform>().localScale = new Vector3(StartScale1, StartScale1, 1);*/
                AkamaruiSpritL.sprite = KetteiSprite[3];
                RihakuSpriteL.sprite = KetteiSprite[2];
                //---
                MOVE = true;
                SpritePOS++;
            }
            else if (Syugyou_A < 0 && !MOVE && SpritePOS < 2)
            { 
               /*
                RihakuSprite.GetComponent<Transform>().transform.position = new Vector3(RihakuPOSX2, RihakuPOSY2, -5);
                AkamaruiSprite.GetComponent<Transform>().transform.position = new Vector3(AkamaruPOSX2, AkamaruPOSY2, -5);
                /*
                  RihakuSprite.GetComponent<Transform>().localScale = new Vector3(StartScale2, StartScale2, 1);
                  AkamaruiSprite.GetComponent<Transform>().localScale = new Vector3(StartScale2, StartScale2, 1);
                  //---*/
                AkamaruiSpritL.sprite = KetteiSprite[5];
                RihakuSpriteL.sprite = KetteiSprite[4];
                MOVE = true;
                SpritePOS++;
            
            }else if (Syugyou_A > 255 && !MOVE && SpritePOS<3)
            {//pos
                Debug.Log("エフェクト12終わったら処理");
                GameObject.Find("Main Controller").SendMessage("SyugyouIllustration00");//決定のエフェクト終わったら処理
                GameObject.Find("Main Effect Controller").GetComponent<Main_Syugyou_Script>().enabled = false;//このスクリプトもういらないので閉じます。
            }
        }
    }
}
