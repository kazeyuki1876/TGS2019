using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Kettei_Script : MonoBehaviour
{
    //初期設定------------
    public GameObject KetteiSprite1;//かぶる画像Sprite;
                                  //初期設定------------
    public bool KetteiSpriteStart = false;//画像かぶるを始まりレバー
    public float Kettei_A = 0.0f;//かぶる画像Sprite1のCOLORA;
  
    public float KeittennSpriteASpeed;//かぶる画像SpriteのCOLORAの速度;
    void Update()
    {
        KetteiChangeMove();
    }
    //---------------
    //入力VOID
    void KetteiSpriteON()
    {
        KetteiSpriteStart = true;
    }
    //--------------ChangeMove
    void KetteiChangeMove()
    {
        if (KetteiSpriteStart)
        {//EgaoSpriteStart　は真（ま）
            if (Kettei_A < 255)
            {
                Kettei_A = Kettei_A + KeittennSpriteASpeed * Time.deltaTime;//KeittennSprite1を染まる
                KetteiSprite1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Kettei_A / 255);
            }
            else
            {
                //演出完了出力処理
                 GameObject.Find("Main Controller").SendMessage("KetteiIllustration00");//決定のエフェクト終わったら処理
                GameObject.Find("Main Effect Controller").GetComponent<Main_Kettei_Script>().enabled = false;//このスクリプトもういらないので閉じます。
            }
        }
    }
}
