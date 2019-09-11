using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Egao_Script : MonoBehaviour
{
    //初期設定------------
    public GameObject EgaoSprite1;//かぶる画像Sprite1;
    public GameObject EgaoSprite2;//かぶる画像Sprite2;
     //初期設定------------
    public bool EgaoSpriteStart=false;//画像かぶるを始まりレバー
    public float Egao1_A=0.0f;//かぶる画像Sprite1のCOLORA;
    public float Egao2_A=0.0f;//かぶる画像Sprite2のCOLORA;
    public float EgaoSpriteASpeed;//かぶる画像Sprite1のCOLORAの速度;
    void Update()
    {
        EgaoChangeMove();
    }
    //---------------
    //入力VOID
    void EgaoSpriteON() {
        EgaoSpriteStart = true;
    }
    //--------------ChangeMove
    void EgaoChangeMove() {
        if (EgaoSpriteStart) {//EgaoSpriteStart　は真（ま）
            if (Egao1_A < 255) {
                Egao1_A = Egao1_A + EgaoSpriteASpeed * Time.deltaTime;//Egao1Aを染まる
                EgaoSprite1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Egao1_A / 255);
            } else if (Egao1_A > 255 && Egao2_A < 255) {
                Egao2_A = Egao2_A + EgaoSpriteASpeed*Time.deltaTime;//Egao2Aを染まる
                EgaoSprite2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Egao2_A / 255f);
            } else  {
                //演出完了出力処理
                GameObject.Find("Main Controller").SendMessage("EgaoIllustration00");//笑顔のエフェクト終わったら処理
                GameObject.Find("Main Effect Controller").GetComponent<Main_Egao_Script>().enabled = false;//このスクリプトもういらないので閉じます。
            }
        }
    }
}
//----------都写了半年式样书了这么还和云策划一样
//--------- 