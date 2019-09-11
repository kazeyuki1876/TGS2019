using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Main_Controller : MonoBehaviour
{

    //カメラ拡大

    public bool CamaraSwitch = false;//　拡大縮小スイッチ   ture縮小 　false拡大


    public bool CameraMoveStitch = false;//カメラが動かない時　テキストを流れる

    public bool CamaraSwitchON = true;//　カウントダウン
    public float CamaraSwitchTimeINT;
    public float CamaraSwitchTime;

    public bool TEXTSwitchON = true;
    public float TEXTSwitchTimeINT;
    public float TEXTSwitchTime;

    //記数変数
    public int ImageCalculator = 0;//ImageCalculator 記数
    public int Souguu = -1;
    public int Nyuutou = -1;
    public int Keiko = -1;
    public int Masturi = -1;
    public int Tentou = -1;
    public int Kiseki = -1;
    public int Kiseki2 = -1;
    public int Honkao = -1;
    public int kesshin = -1;
    public int Egao = -1;

    public int Hiten = -1;
    public int Syugyou = -1;
    public int Renjyo = -1;
    public int Sibetu = -1;
    public int Hakamari = -1;
    public int Kenmai = -1;
    public int Miti = -1;

    //-----
    public Image ImageText1;
    public Image ImageText2;
    public Image ImageText3;
    public Image ImageText4;
    public Image ImageText5;
    public Image ImageText6;
    public Image ImageText7;
    public Image ImageText8;

    public bool ImageText1ON = false;
    public bool ImageText2ON = false;
    public bool ImageText3ON = false;
    public bool ImageText4ON = false;
    public bool ImageText5ON = false;
    public bool ImageText6ON = false;
    public bool ImageText7ON = false;
    public bool ImageText8ON = false;
    //テキスト
    /*
    //ImageText1の変数
    
    public float ImageText1POSX;
    public float ImageText1POSY;
    public float ImageText1POSZ;
    public float ImageText1width;
    public float ImageText1height;

    //ImageText2の変数
  
    public float ImageText2POSX;
    public float ImageText2POSY;
    public float ImageText2POSZ;
    public float ImageText2width;
    public float ImageText2height;

    //ImageText3の変数
    
    public float ImageText3POSX;
    public float ImageText3POSY;
    public float ImageText3POSZ;
    public float ImageText3width;
    public float ImageText3height;
    //ImageText4の変数
    
    public float ImageText4POSX;
    public float ImageText4POSY;
    public float ImageText4POSZ;
    public float ImageText4width;
    public float ImageText4height;
    //ImageText5の変数
   
    public float ImageText5POSX;
    public float ImageText5POSY;
    public float ImageText5POSZ;
    public float ImageText5width;
    public float ImageText5height;
    //-*/
    public Image Image;

    public bool fillAmountNO = true;

    public float ImagePercentage = 0;//fillAmountの数字
    public float ImagePercentage1 = 0;
    public float ImagePercentage2 = 0;
    public float ImagePercentage3 = 0;
    public float ImagePercentage4 = 0;
    public float ImagePercentage5 = 0;
    public float ImagePercentage6 = 0;
    public float ImagePercentage7 = 0;
    public float ImagePercentage8 = 0;
    public float ImagePercentage12 = 0;
    public float ImagePercentage22 = 0;
    public float ImagePercentage32 = 0;
    public float ImagePercentage42 = 0;
    public float ImagePercentage52 = 0;
    public float ImagePercentage62 = 0;
    public float ImagePercentage72 = 0;
    public float ImagePercentage82 = 0;
    public float ImagePercentageSpeed = 0.01f;//fillAmount速度sou
    //----------------
    public bool TextMove;//テキスト　が動く
    public bool CameraMove;
    public bool CameraLeft = false;
    //-
    public int Read;
    public int Unread;
    public string[] BGM;
    //----------
    public int[] X;
    public int[] Y;
    public string[] PASS;
    public int I = 0;
    public float Stafftime=20.0f;
    //----------

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        text();
    }

    void TestON()
    {
        CameraMoveStitch = true;
    }


    //------------------Button入力
    void ButtonUpInput()
    {

        if (CameraMove && ImageCalculator < 99)
        {
            GameObject.Find("Main Camera").SendMessage("CameraLeft");//MoveLeft
            GameObject.Find("Source　BOX").SendMessage("Maki");//SE
            GameObject.Find("Source　BOX").SendMessage("VOICESInterruption");//VOICES中断

            // tsxtR();
            Text0();
            ImageCalculator++;//ImageCalculator 記数
            Read = ImageCalculator * 10;
            Souguu = -1;
            Nyuutou = -1;
            Keiko = -1;
            Masturi = -1;
            Tentou = -1;
            Kiseki = -1;
            Kiseki2 = -1;
            Honkao = -1;
            kesshin = -1;
            Egao = -1;
            Hiten = -1;
            Syugyou = -1;
            Renjyo = -1;
            Sibetu = -1;
            Hakamari = -1;
            Kenmai = -1;
            Miti = -1;
            Debug.Log("ButtonUpInput");
        }

    }
    void ButtonTEXTInput()
    {
        TEXTM();
    }

    void ButtonDownInput()
    {

        if (CameraMove && ImageCalculator > 0)
        {
            GameObject.Find("Main Camera").SendMessage("CameraRight");//MoveRight
            GameObject.Find("Source　BOX").SendMessage("Maki");//SE
            GameObject.Find("Source　BOX").SendMessage("VOICESInterruption");//VOICES中断
            //tsxtR();
            Text0();

            ImageCalculator--;//ImageCalculator 記数
            Read = ImageCalculator * 10;
            Souguu = -1;
            Nyuutou = -1;
            Keiko = -1;
            Masturi = -1;
            Tentou = -1;
            Kiseki = -1;
            Kiseki2 = -1;
            Honkao = -1;
            kesshin = -1;
            Egao = -1;
            Hiten = -1;
            Syugyou = -1;
            Renjyo = -1;
            Sibetu = -1;
            Hakamari = -1;
            Kenmai = -1;
            Miti = -1;
            Debug.Log("Main＿DownButton");
        }
    }
    //----------------------テキスト

    void TEXTM()
    {
        if (TextMove)
        {
            TEXTSwitchON = false;

            if (ImageCalculator < 1 && TextMove)
            {


                Debug.Log("Illustration1;");
                Text0();
                ImageCalculator++;//!

            }
            else if (ImageCalculator < 2 && TextMove)
            {
                if (Souguu < 0)
                {
                    Souguu++;
                    
                }
                else if (Souguu < 1)
                {
                    SouguuIllustration01();
                    GameObject.Find("Main Effect Controller").SendMessage("RakuyouOVER");//落葉止め
                  
                }
                else if (Souguu < 2)
                {
                    SouguuIllustration02();
                }
                else if (Souguu < 3)
                {

                    SouguuIllustration03();

                }
                else if (Souguu < 4)
                {

                    SouguuIllustration04();

                }
                else if (Souguu < 5)
                {

                    SouguuIllustration05();
                    GameObject.Find("Source　BOX").SendMessage("Battou1STARTON");//


                }
                else if (Souguu < 6)
                {

                    if (Unread > 4) {
                        Souguu++;
                        TEXTM();
                    }
                    //入力待ち

                }
                else
                {
                    Text0();
                    tsxtR();

                    Souguu = -1;
                    Debug.Log("遭遇 END ");

                }

            }//遭遇
            else if (ImageCalculator < 3 && TextMove)
            {
                if (Nyuutou < 0)
                {
                    Nyuutou++;
                }
                else if (Nyuutou < 1)
                {
                    NyutouIllustration01();
                    GameObject.Find("Source　BOX").SendMessage("Battou2STARTON");//

                    //-------
                }
                else if (Nyuutou < 2)
                {    //入力待ち    GameObject.Find("Source　BOX").SendMessage("Battou2STARTON");//
                    if (Unread > 20) {
                        Nyuutou++;
                        TEXTM();
                    }

                }
                else if (Nyuutou < 3)
                {
                    NyutouIllustration02();
                }
                else if (Nyuutou < 4)
                {

                    NyutouIllustration03();

                }

                else
                {
                    Text0();
                    tsxtR();

                    Nyuutou = -1;
                    Debug.Log("入唐 END ");

                }


            }//入唐
            else if (ImageCalculator < 4 && TextMove)
            {
                if (Keiko < 0)
                {

                    Keiko++;
                }
                else
                  if (Keiko < 1)
                {
                    KeikoIllustration01();
                    GameObject.Find("Source　BOX").SendMessage("AMEStart");//
                }
                else if (Keiko < 2)
                {
                    KeikoIllustration02();
                }
                else if (Keiko < 3)
                {

                    KeikoIllustration03();
                    GameObject.Find("Source　BOX").SendMessage("UCHIAIStart");//

                }
                else if (Keiko < 4)
                {

                    KeikoIllustration04();

                }

                else
                {
                    Text0();
                    tsxtR();


                    Keiko = -1;
                    Debug.Log("稽古 END ");
                    GameObject.Find("Source　BOX").SendMessage("BGMOVER");//
                }




            }//稽古
            else if (ImageCalculator < 5 && TextMove)//祭り
            {
                if (Masturi < 0)
                {
                    Masturi++;
                }
                else
                if (Masturi < 1)
                {
                    MaturiIllustration01();
                }
                else if (Masturi < 2)
                {
                    MaturiIllustration02();
                }
                else if (Masturi < 3)
                {
                    MaturiIllustration03();
                }
                else if (Masturi < 4)
                {
                    MaturiIllustration04();
                }
                else if (Masturi < 5)
                {
                    MaturiIllustration05();
                }
                else
                {
                    Text0();
                    tsxtR();

                    Masturi = -1;
                    Debug.Log("祭り END ");

                }
            }//祭り
            else if (ImageCalculator < 6 && TextMove)//天灯
            {
                if (Tentou < 0)
                {
                    Tentou++;

                }
                else
                  if (Tentou < 1)
                {
                    TentouIllustration01();
                }
                else if (Tentou < 2)
                {
                    TentouIllustration02();
                }
                else if (Tentou < 3)
                {
                    TentouIllustration03();

                }
                else if (Tentou < 4)
                {
                    TentouIllustration04();

                }
                else if (Tentou < 5)
                {
                    TentouIllustration05();

                }
                else if (Tentou < 6)
                {
                    TentouIllustration06();

                }
                else if (Tentou < 7)
                {
                    TentouIllustration07();

                }
                else
                {
                    Text0();
                    tsxtR();
                    GameObject.Find("Source　BOX").SendMessage("BGMOVER");//遭遇BGM} 
                    Tentou = -1;
                    Debug.Log("天灯 END ");

                }
            }//天灯
            else if (ImageCalculator < 7 && TextMove)
            {
                if (Kiseki < 0)
                {
                    Kiseki++;
                }
                else
                if (Kiseki < 1)
                {
                    Kiseki1Illustration01();
                }
                else if (Kiseki < 2)
                {
                    Kiseki1Illustration02();
                }
                else if (Kiseki < 3)
                {
                    Kiseki1Illustration03();
                }
                else if (Kiseki < 4)
                {
                    Kiseki1Illustration04();
                }
                else if (Kiseki < 5)
                {
                    Kiseki1Illustration05();
                }
                else if (Kiseki < 6)
                {
                    Kiseki1Illustration06();
                }
                else
                {
                    Text0();
                    tsxtR();

                    Kiseki = -1;
                    Debug.Log("奇跡 END ");

                }
            }//奇跡
            else if (ImageCalculator < 8 && TextMove)

            {
                if (Kiseki2 < 0)
                {
                    if (Unread > 71) {
                        Kiseki2++;
                        //TEXTM();
                    }

                    // Kiseki2++;
                    GameObject.Find("Main Effect Controller").SendMessage("SkylanternMoveStart");//奇跡アニメーション
                    // 命令待ち GameObject.Find("Main Effect Controller").SendMessage("Kiseki2Illustration00");//奇跡2のエフェクト終わるまでテキストが出てこないように設定。
                }
                else if (Kiseki2 < 1)
                {
                    Kiseki2Illustration01();

                }
                else if (Kiseki2 < 2)
                {
                    Kiseki2Illustration02();
                }
                else if (Kiseki2 < 3)
                {
                    Kiseki2Illustration03();
                }
                else if (Kiseki2 < 4)
                {
                    Kiseki2Illustration04();
                }
                else if (Kiseki2 < 5)
                {
                    Kiseki2Illustration05();
                }
                else if (Kiseki2 < 6)
                {
                    Kiseki2Illustration06();
                }
                else if (Kiseki2 < 7)
                {
                    Kiseki2Illustration07();
                }

                else
                {
                    Text0();
                    tsxtR();

                    Kiseki2 = -1;
                    Debug.Log("奇跡2" +
                        " END ");
                }
            }//奇跡２
            else if (ImageCalculator < 9 && TextMove)
            {
                if (Honkao < 0)
                {
                    
                    GameObject.Find("Main Effect Controller").SendMessage("HonganMoveStart");

                    if (Unread > 81)
                    {
                        Nyuutou++;
                        TEXTM();
                    }
                }
                else
               if (Honkao < 1)
                {
                    HonganIllustration01();
                }
                else if (Honkao < 2)
                {
                    HonganIllustration02();
                }
                else if (Honkao < 3)
                {
                    HonganIllustration03();
                }
                else if (Honkao < 4)
                {
                    HonganIllustration04();
                }
                else if (Honkao < 5)
                {
                    HonganIllustration05();
                }
                else if (Honkao < 6)
                {
                    HonganIllustration06();
                }
                else if (Honkao < 7)
                {
                    HonganIllustration07();
                }
                else
                {
                    Text0();
                    tsxtR();

                    Honkao = -1;
                    Debug.Log("本顔 END ");

                }
            }//本顔
            else if (ImageCalculator < 10 && TextMove)//天灯
            {
                if (kesshin < 0)
                {
                    GameObject.Find("Main Effect Controller").SendMessage("KetteiSpriteON");//KetteiSpriteON
                 //???入力待ち     KetteiIllustration00();
                    if (Unread > 91)
                    {
                        kesshin++;
                        TEXTM();
                    }
                }
                else
            if (kesshin < 1)
                {
                    KetteiIllustration01();
                }
                else if (kesshin < 2)
                {
                    KetteiIllustration02();
                }
                else if (kesshin < 3)
                {

                    KetteiIllustration03();

                }
                else if (kesshin < 4)
                {
                    KetteiIllustration04();

                }
                else if (kesshin < 5)
                {
                    KetteiIllustration05();
                }
                else if (kesshin < 6)
                {
                    KetteiIllustration06();

                }
                else if (kesshin < 7)
                {
                    KetteiIllustration07();
                } else
                {
                    Text0();
                    tsxtR();

                    kesshin = -1;
                    Debug.Log("決心 END ");

                }
            }//決心
            else if (ImageCalculator < 11 && TextMove)

            {
                if (Egao < 0)
                { 
                    GameObject.Find("Main Effect Controller").SendMessage("EgaoSpriteON");//KetteiSpriteON
                    if (Unread > 101)
                    {
                        Egao++;
                        TEXTM();
                    }
                }
                else if (Egao < 1)
                {
                    EgaoIllustration01();

                }
                else if (Egao < 2)
                {
                    EgaoIllustration02();

                }
                else if (Egao < 3)
                {
                    EgaoIllustration03();

                }
                else if (Egao < 4)
                {
                    EgaoIllustration04();

                }
                else if (Egao < 5)
                {
                    EgaoIllustration05();

                }
                else if (Egao < 6)
                {
                    EgaoIllustration06();

                }
                else if (Egao < 7)
                {
                    EgaoIllustration07();

                }
                else if (Egao < 8)
                {
                    EgaoIllustration08();

                }
                else
                {
                    Text0();
                    tsxtR();

                    Debug.Log("笑顔 END ");
                    Egao = -1;
                    GameObject.Find("Source　BOX").SendMessage("KAZEStart");//
                    
                    GameObject.Find("Main Effect Controller").SendMessage("WindMoveSTART");//KetteiSpriteON
                }
            }//笑顔
            else if (ImageCalculator < 12 && TextMove)
            {
                if (Hiten < 0)
                {
                    Hiten++;
                }
                else if (Hiten < 1)
                {
                    GameObject.Find("Main Effect Controller").SendMessage("MoveOVER");//飛天アニメーションOVER
                    HitenIllustration01();
                }
                else if (Hiten < 2)
                {
                    HitenIllustration02();
                }
                else
                {
                    Text0();
                    tsxtR();

                    Hiten = -1;
                    Debug.Log("飛天 END ");

                    GameObject.Find("Source　BOX").SendMessage("BGMOVER");//

                }


            }//飛天
            else if (ImageCalculator < 13 && TextMove)
            {
                if (Syugyou < 0)
                {
                    GameObject.Find("Main Effect Controller").SendMessage("SyugyouSpriteON");//MoveRight
                    if (Unread > 121) {
                        Syugyou++;
                        TEXTM();
                    }                                       
                }
                else if (Syugyou < 1)
                {
                    SyugyouIllustration01();
                }
                else if (Syugyou < 2)
                {
                    SyugyouIllustration02();
                }
                else if (Syugyou < 3)
                {
                    SyugyouIllustration03();
                }
                else if (Syugyou < 4)
                {
                    SyugyouIllustration04();
                }
                else if (Syugyou < 5)
                {
                    SyugyouIllustration05();
                }
                else if (Syugyou < 6)
                {
                    SyugyouIllustration06();
                }
                else if (Syugyou < 7)
                {
                    SyugyouIllustration07();
                }
                else
                {
                    Text0();
                    tsxtR();

                    Syugyou = -1;
                    Debug.Log("修行 END ");

                }


            }//修行
            else if (ImageCalculator < 14 && TextMove)
            {
                if (Renjyo < 0)
                {
                    Renjyo++;
                }
                else if (Renjyo < 1)
                {
                    RenjyoIllustration01();
                }
                else if (Renjyo < 2)
                {
                    RenjyoIllustration02();
                }
                else if (Renjyo < 3)
                {
                    RenjyoIllustration03();
                }
                else if (Renjyo < 4)
                {
                    RenjyoIllustration04();
                }
                else if (Renjyo < 5)
                {
                    RenjyoIllustration05();
                }
                else if (Renjyo < 6)
                {
                    RenjyoIllustration06();
                }

                else
                {
                    Text0();
                    tsxtR();

                    Renjyo = -1;
                    Debug.Log("恋情 END ");

                }


            }//恋情
            else if (ImageCalculator < 15 && TextMove)
            {
                if (Sibetu < 0)
                {
                    Sibetu++;
                }
                else if (Sibetu < 1)
                {
                    SibetuIllustration01();
                }
                else if (Sibetu < 2)
                {
                    SibetuIllustration02();
                }
                else if (Sibetu < 3)
                {
                    SibetuIllustration03();
                }
                else if (Sibetu < 4)
                {
                    SibetuIllustration04();
                }
                else if (Sibetu < 5)
                {
                    SibetuIllustration05();
                }
                else if (Sibetu < 6)
                {
                    SibetuIllustration06();
                }
                else if (Sibetu < 7)
                {
                    SibetuIllustration07();
                }

                else
                {
                    Text0();
                    tsxtR();

                    Sibetu = -1;
                    Debug.Log("死別 END ");

                }


            }//死別
            else if (ImageCalculator < 16 && TextMove)
            {
                if (Hakamari < 0)
                {
                    Hakamari++;
                }
                else if (Hakamari < 1)
                {
                    HakamairiIllustration01();
                }
                else if (Hakamari < 2)
                {
                    HakamairiIllustration02();
                }
                else if (Hakamari < 3)
                {
                    HakamairiIllustration03();
                }
                else if (Hakamari < 4)
                {
                    HakamairiIllustration04();
                }
                else if (Hakamari < 5)
                {
                    HakamairiIllustration05();
                }
                else
                {
                    Text0();
                    tsxtR();

                    Hakamari = -1;
                    Debug.Log("墓参り END ");

                }


            }//墓参り
            else if (ImageCalculator < 17 && TextMove)
            {
                if (Kenmai < 0)
                {
                    Kenmai++;
                }
                else if (Kenmai < 1)
                {
                    KenmaiIllustration01();
                }
                else if (Kenmai < 2)
                {
                    KenmaiIllustration02();
                }
                else if (Kenmai < 3)
                {
                    KenmaiIllustration03();
                }
                else if (Kenmai < 4)
                {
                    KenmaiIllustration04();
                }
                else if (Kenmai < 5)
                {
                    KenmaiIllustration05();
                }
                else if (Kenmai < 6)
                {
                    KenmaiIllustration06();
                }
                else if (Kenmai < 7)
                {
                    KenmaiIllustration07();
                }
                else if (Kenmai < 8)
                {
                    KenmaiIllustration08();
                }


                else
                {
                    Text0();
                    tsxtR();

                    Kenmai = -1;
                    Debug.Log("剣舞 END ");

                }


            }//剣舞
            else if (ImageCalculator < 18 && TextMove)
            {
                if (Miti < 0)
                {
                    GameObject.Find("Main Effect Controller").SendMessage("PlayMIti1");
                    //Miti++;
                }
                else if (Miti < 1)
                {
                    MitiIllustration01();
                }
                else if (Miti < 2)
                {
                    MitiIllustration02();
                }
                else if (Miti < 3)
                {
                    MitiIllustration03();
                }
                else if (Miti < 4)
                {
                    MitiIllustration04();

                }
                else if (Miti < 5)
                {
                    GameObject.Find("Main Effect Controller").SendMessage("PlayMIti2");//MoveRight
                    Miti++;
                   
                    Text0();
                    GameObject.Find("Filter").SendMessage("VDOWN");//MoveRight;
                }
                
                else if (Miti < 6)
                {
                    GameObject.Find("Main Effect Controller").SendMessage("PlayMItiOVER");//MoveRight
                    Debug.Log("ごプレイ　ありがとうなす");
                    Stagebudge();
                }
                else if (Miti < 7) {
                    Invoke("Stagebudge", 1.0f);

                }


                else
                {
                    Text0();
                    tsxtR();

                    Miti = -1;
                    Debug.Log("道 END ");

                }


            }//道

            else if (TextMove)// END
            {
                Debug.Log("ごプレイ　ありがとうなす");
                //tagebudge();

            }//END
        }

    }

    void text()
    {


        if (fillAmountNO)
        {

            if (ImageText1ON)
            {
                ImageText1.fillAmount = ImagePercentage1;
                ImagePercentage12 = ImagePercentage1;
                ImagePercentage1 = ImagePercentage12 + ImagePercentageSpeed;
            }
            if (ImageText2ON)
            {
                ImageText2.fillAmount = ImagePercentage2;
                ImagePercentage22 = ImagePercentage2;
                ImagePercentage2 = ImagePercentage22 + ImagePercentageSpeed;

            }
            if (ImageText3ON)
            {
                ImageText3.fillAmount = ImagePercentage3;
                ImagePercentage32 = ImagePercentage3;
                ImagePercentage3 = ImagePercentage32 + ImagePercentageSpeed;
            }
            if (ImageText4ON)
            {
                ImageText4.fillAmount = ImagePercentage4;
                ImagePercentage42 = ImagePercentage4;
                ImagePercentage4 = ImagePercentage42 + ImagePercentageSpeed;
            }
            if (ImageText5ON)
            {
                ImageText5.fillAmount = ImagePercentage5;
                ImagePercentage52 = ImagePercentage5;
                ImagePercentage5 = ImagePercentage52 + ImagePercentageSpeed;
            }
            if (ImageText6ON)
            {
                ImageText6.fillAmount = ImagePercentage6;
                ImagePercentage62 = ImagePercentage6;
                ImagePercentage6 = ImagePercentage62 + ImagePercentageSpeed;
            }
            if (ImageText7ON)
            {
                ImageText7.fillAmount = ImagePercentage7;
                ImagePercentage72 = ImagePercentage7;
                ImagePercentage7 = ImagePercentage72 + ImagePercentageSpeed;
            }
            if (ImageText8ON)
            {
                ImageText8.fillAmount = ImagePercentage8;
                ImagePercentage82 = ImagePercentage8;
                ImagePercentage8 = ImagePercentage82 + ImagePercentageSpeed;
            }





            ImagePercentage = ImagePercentage + ImagePercentageSpeed;
            //---------



            //---------------------------
            Image.fillAmount = ImagePercentage;//







        }
        else
        {
            Text0();
        }
    }



    void tsxtR()
    {
        fillAmountNO = false;
        ImagePercentage = 0;
        CameraMoveStitch = false;
        CamaraSwitchTime = 1.0f;
        GameObject.Find("Filter").SendMessage("VDOWN");//MoveRight;
        CameraMove = true;
        ButtonUpInput();



    }
    void ImageText2OFF()
    {
        ImageText1ON = false;
        ImageText2ON = false;
        ImageText3ON = false;
        ImageText4ON = false;
        ImageText5ON = false;
        ImageText6ON = false;
        ImageText7ON = false;
        ImageText8ON = false;

    }

    void Text0()// imeji Reset 何もない画像　テキストリセット用
    {

        ImageText1.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//
        ImageText2.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//
        ImageText3.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//
        ImageText4.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//
        ImageText5.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//
        ImageText6.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//
        ImageText7.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//
        ImageText8.sprite = Resources.Load("Image/Reset", typeof(Sprite)) as Sprite;//

        ImagePercentage1 = 0;
        ImagePercentage2 = 0;
        ImagePercentage3 = 0;
        ImagePercentage4 = 0;
        ImagePercentage5 = 0;
        ImagePercentage6 = 0;
        ImagePercentage7 = 0;
        ImagePercentage8 = 0;
        ImagePercentage12 = 0;
        ImagePercentage22 = 0;
        ImagePercentage32 = 0;
        ImagePercentage42 = 0;
        ImagePercentage52 = 0;
        ImagePercentage62 = 0;
        ImagePercentage72 = 0;
        ImagePercentage82 = 0;
        Image.fillAmount = 0;//
        ImageText1.fillAmount = 0;
        ImageText2.fillAmount = 0;
        ImageText3.fillAmount = 0;
        ImageText4.fillAmount = 0;
        ImageText5.fillAmount = 0;
        ImageText6.fillAmount = 0;
        ImageText7.fillAmount = 0;
        ImageText8.fillAmount = 0;
        ImageText2OFF();



    }
    void ImageText1SwitchON()
    {
        ImagePercentage12 = 0;
        ImagePercentage1 = 0;
        ImageText1ON = true;
    }
    void ImageText2SwitchON()
    {
        ImagePercentage22 = 0;
        ImagePercentage2 = 0;
        ImageText2ON = true;

    }
    void ImageText3SwitchON()
    {
        ImagePercentage32 = 0;
        ImagePercentage3 = 0;
        ImageText3ON = true;
    }
    void ImageText4SwitchON()
    {
        ImagePercentage42 = 0;
        ImagePercentage4 = 0;
        ImageText4ON = true;
    }
    void ImageText5SwitchON()
    {
        ImagePercentage52 = 0;
        ImagePercentage5 = 0;
        ImageText5ON = true;
    }
    void ImageText6SwitchON()
    {
        ImagePercentage62 = 0;
        ImagePercentage6 = 0;
        ImageText6ON = true;
    }
    void ImageText7SwitchON()
    {
        ImagePercentage72 = 0;
        ImagePercentage7 = 0;
        ImageText7ON = true;
    }
    void ImageText8SwitchON()
    {
        ImagePercentage82 = 0;
        ImagePercentage8 = 0;
        ImageText8ON = true;
    }
    //--------遭遇TEXTvoid SouguuIllustration01() {    
    //-----------------------------------------
    void SouguuIllustration01()
    {
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
        GameObject.Find("Source　BOX").SendMessage(BGM[0]);//遭遇BGM}
        VOICEplay();


        //----------------------------
        ImageText1SwitchON();
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(X[I], Y[I], 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/" + PASS[I], typeof(Sprite)) as Sprite;//
                                                                                              //  ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, -30, 0);//UIのPOSX　Y　Z
                                                                                              //ImageText1.sprite = Resources.Load("Image/Text/01-zaoyu/01zaoyu-1", typeof(Sprite)) as Sprite;//
                                                                                              //I++; 配列されていなかったので　エラー
        Souguu++;//!
    }
    void SouguuIllustration02()
    {
        ImageText2SwitchON();
        VOICEplay();
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(350, -30, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/01-zaoyu/01zaoyu-2", typeof(Sprite)) as Sprite;//
        Souguu++;//!
    }
    void SouguuIllustration03()
    {
        ImageText3SwitchON();
        VOICEplay();
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(110, -30, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/01-zaoyu/01zaoyu-3", typeof(Sprite)) as Sprite;//
        Souguu++;//!
    }
    void SouguuIllustration04()
    {
        ImageText4SwitchON();
        VOICEplay();
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(40, -30, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/01-zaoyu/01zaoyu-4", typeof(Sprite)) as Sprite;//
        Souguu++;//!
    }
    void SouguuIllustration05()
    {
        ImageText5SwitchON();
        VOICEplay();
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-210, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/01-zaoyu/01zaoyu-5", typeof(Sprite)) as Sprite;//
        Souguu++;//!
    }
    void SouguuIllustration06()
    {
        Souguu++;//!
        TEXTM();
    }



    //---------入唐TEXT　TEXT置き場待ち

    void NyutouIllustration01()
    {

        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
        GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                                        //----------------------------
        ImageText1SwitchON();
        VOICEplay();
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/02-rutang/02rutang-1", typeof(Sprite)) as Sprite;//
        Nyuutou++;//!
    }
    void NyutouIllustration02()
    {
        ImageText2SwitchON();
        VOICEplay();
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(270, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/02-rutang/02rutang-2", typeof(Sprite)) as Sprite;//
        Nyuutou++;//!
    }
    void NyutouIllustration03()
    {
        ImageText3SwitchON();
        VOICEplay();
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-100, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/02-rutang/02rutang-3", typeof(Sprite)) as Sprite;//
        Nyuutou++;//!
    }
    void NyutouIllustration012()
    {
        Nyuutou++;//!
                  //  TEXTM();
    }


    //--------稽古TEXT

    void KeikoIllustration01()
    {

        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
        GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
        ImageText1SwitchON();
        VOICEplay();
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/03-jigu/03jigu-1", typeof(Sprite)) as Sprite;//
        Keiko++;//!
    }
    void KeikoIllustration02()
    {

        ImageText2SwitchON();
        VOICEplay();
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(260, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/03-jigu/03jigu-2", typeof(Sprite)) as Sprite;//
        Keiko++;//!
    }
    void KeikoIllustration03()
    {

        ImageText3SwitchON();
        VOICEplay();
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(90, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/03-jigu/03jigu-3", typeof(Sprite)) as Sprite;//
        Keiko++;//!
    }
    void KeikoIllustration04()
    {

        ImageText4SwitchON();
        VOICEplay();
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-400, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/03-jigu/03jigu-4", typeof(Sprite)) as Sprite;//
        Keiko++;//!
    }






    //------------祭りTEXT

    void MaturiIllustration01()
    {
        GameObject.Find("Source　BOX").SendMessage("MATURIStart");//MATURION
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight

        ImageText1SwitchON();
        VOICEplay();
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/04-jidian/04jidian-1", typeof(Sprite)) as Sprite;//
        Masturi++;//!
    }
    void MaturiIllustration02()
    {
        GameObject.Find("Source　BOX").SendMessage("MATURION");//遭遇BGM} 
        ImageText2SwitchON();
        VOICEplay();
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(350, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/04-jidian/04jidian-2", typeof(Sprite)) as Sprite;//
        Masturi++;//!
    }
    void MaturiIllustration03()
    {

        ImageText3SwitchON();
        VOICEplay();
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(190, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/04-jidian/04jidian-3", typeof(Sprite)) as Sprite;//
        Masturi++;
    }
    void MaturiIllustration04()
    {

        ImageText4SwitchON();
        VOICEplay();
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-100, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/04-jidian/04jidian-4", typeof(Sprite)) as Sprite;//
        Masturi++;//!
    }
    void MaturiIllustration05()
    {

        ImageText5SwitchON();
        VOICEplay();
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-260, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/04-jidian/04jidian-5", typeof(Sprite)) as Sprite;//
        Masturi++;//!
    }


    //--------------天灯
    void TentouIllustration01()
    {

        fillAmountNO = true;
        CameraMove = false;
        VOICEplay();
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
        GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                                        //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/05-tiandeng/05tiandeng-1", typeof(Sprite)) as Sprite;//
        Tentou++;//!
    }
    void TentouIllustration02()
    {

        ImageText2SwitchON();
        VOICEplay();
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(350, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/05-tiandeng/05tiandeng-2", typeof(Sprite)) as Sprite;//
        Tentou++;//!
    }
    void TentouIllustration03()
    {

        ImageText3SwitchON();
        VOICEplay();
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(130, -30, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/05-tiandeng/05tiandeng-3", typeof(Sprite)) as Sprite;//
        Tentou++;//!
    }
    void TentouIllustration04()
    {

        ImageText4SwitchON();
        VOICEplay();
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-100, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/05-tiandeng/05tiandeng-4", typeof(Sprite)) as Sprite;//
        Tentou++;//!
    }
    void TentouIllustration05()
    {

        ImageText5SwitchON();
        VOICEplay();
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-330, -30, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/05-tiandeng/05tiandeng-5", typeof(Sprite)) as Sprite;//
        Tentou++;//!
    }
    void TentouIllustration06()
    {

        ImageText6SwitchON();
        VOICEplay();
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-500, 0, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/05-tiandeng/05tiandeng-6", typeof(Sprite)) as Sprite;//
        Tentou++;//!
    }
    void TentouIllustration07()
    {
        GameObject.Find("Source　BOX").SendMessage("MATUEIEND");//遭遇BGM} 
        ImageText7SwitchON();
        VOICEplay();
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-590, 0, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/05-tiandeng/05tiandeng-7", typeof(Sprite)) as Sprite;//
        Tentou++;//!
    }


    //------------奇跡TEXT

    void Kiseki1Illustration01()
    {

        fillAmountNO = true;
        CameraMove = false;
        VOICEplay();
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
        GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}

        ImageText1SwitchON();
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/06-qiji1/06qiji1-1", typeof(Sprite)) as Sprite;//
        Kiseki++;//!
    }
    void Kiseki1Illustration02()
    {

        ImageText2SwitchON();
        VOICEplay();
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(350, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/06-qiji1/06qiji1-2", typeof(Sprite)) as Sprite;//
        Kiseki++;//!
    }
    void Kiseki1Illustration03()
    {

        ImageText3SwitchON();
        VOICEplay();
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(130, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/06-qiji1/06qiji1-3", typeof(Sprite)) as Sprite;//
        Kiseki++;//!
    }
    void Kiseki1Illustration04()
    {

        ImageText4SwitchON();
        VOICEplay();
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-200, -30, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/06-qiji1/06qiji1-4", typeof(Sprite)) as Sprite;//
        Kiseki++;//!
    }
    void Kiseki1Illustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-500, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/06-qiji1/06qiji1-5", typeof(Sprite)) as Sprite;//
        Kiseki++;//!
    }
    void Kiseki1Illustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-710, 0, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/06-qiji1/06qiji1-6", typeof(Sprite)) as Sprite;//
        Kiseki++;//!
    }


    //-------------------奇跡NO.２TEXT
    void Kiseki2Illustration00() {
        GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
        Kiseki2++;//!
       // TEXTM();
    }
    void Kiseki2Illustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
        GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                                        //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/07-qiji2/07qiji2-1", typeof(Sprite)) as Sprite;//
        Kiseki2++;//!
    }
    void Kiseki2Illustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(150, -30, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/07-qiji2/07qiji2-2", typeof(Sprite)) as Sprite;//
        Kiseki2++;//!
    }
    void Kiseki2Illustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-250, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/07-qiji2/07qiji2-3", typeof(Sprite)) as Sprite;//
        Kiseki2++;//!
    }
    void Kiseki2Illustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-390, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/07-qiji2/07qiji2-4", typeof(Sprite)) as Sprite;//
        Kiseki2++;//!
    }
    void Kiseki2Illustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-530, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/07-qiji2/07qiji2-5", typeof(Sprite)) as Sprite;//
        Kiseki2++;//!
    }
    void Kiseki2Illustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-760, 0, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/07-qiji2/07qiji2-6", typeof(Sprite)) as Sprite;//
        Kiseki2++;//!
    }
    void Kiseki2Illustration07()
    {
        VOICEplay();
        //----------------------------
        ImageText7SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-850, 0, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/07-qiji2/07qiji2-7", typeof(Sprite)) as Sprite;//
        Kiseki2++;//!
    }
    //----本顔

    void HonganIllustration00 (){
        Honkao++;//!
    }
    void HonganIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
        GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                                        //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, -30, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/08-benyuan/08benyuan-1", typeof(Sprite)) as Sprite;//
        Honkao++;//!
    }
    void HonganIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(230, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/08-benyuan/08benyuan-2", typeof(Sprite)) as Sprite;//
        Honkao++;//!
    }
    void HonganIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(90, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/08-benyuan/08benyuan-3", typeof(Sprite)) as Sprite;//
        Honkao++;//!
    }
    void HonganIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-50, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/08-benyuan/08benyuan-4", typeof(Sprite)) as Sprite;//
        Honkao++;//!
    }
    void HonganIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-300, -30, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/08-benyuan/08benyuan-5", typeof(Sprite)) as Sprite;//
        Honkao++;//!
    }
    void HonganIllustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-530, -30, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/08-benyuan/08benyuan-6", typeof(Sprite)) as Sprite;//
        Honkao++;//!
    }
    void HonganIllustration07()
    {
        VOICEplay();
        //----------------------------
        ImageText7SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-800, 0, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/08-benyuan/08benyuan-7", typeof(Sprite)) as Sprite;//
        Honkao++;//!
    }


    //-----------------決心

    void KetteiIllustration00()
    {

        kesshin++;
       
    }
    void KetteiIllustration01(){
    VOICEplay();
    //-----------------------------------------
    fillAmountNO = true;
    CameraMove = false;
    GameObject.Find("Filter").SendMessage("VUP");//MoveRight
    GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                            //----------------------------
    ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
    ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, -30, 0);//UIのPOSX　Y　Z
    ImageText1.sprite = Resources.Load("Image/Text/09-jueding/09jueding-1", typeof(Sprite)) as Sprite;//
        kesshin++;//!
    }
    void KetteiIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(150, -30, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/09-jueding/09jueding-2", typeof(Sprite)) as Sprite;//
        kesshin++;//!
    }
    void KetteiIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, -30, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/09-jueding/09jueding-3", typeof(Sprite)) as Sprite;//
        kesshin++;//!
    }
    void KetteiIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-100, -30, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/09-jueding/09jueding-4", typeof(Sprite)) as Sprite;//
        kesshin++;//!
    }
    void KetteiIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-300, -30, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/09-jueding/09jueding-5", typeof(Sprite)) as Sprite;//
        kesshin++;//!
    }
    void KetteiIllustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-450, -30, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/09-jueding/09jueding-6", typeof(Sprite)) as Sprite;//
        kesshin++;//!
    }
    void KetteiIllustration07()
    {
        VOICEplay();
        //----------------------------
        ImageText7SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-800, -30, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/09-jueding/09jueding-7", typeof(Sprite)) as Sprite;//
        kesshin++;//!
    }

    //---------------------笑顔
    void EgaoIllustration00() {
        Egao++;//!
    }
    void EgaoIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-1", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    void EgaoIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(350, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-2", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    void EgaoIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(180, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-3", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    void EgaoIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-30, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-4", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    void EgaoIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-190, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-5", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    void EgaoIllustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-290, 0, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-6", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    void EgaoIllustration07()
    {
        VOICEplay();
        //----------------------------
        ImageText7SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-690, 0, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-7", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    void EgaoIllustration08()
    {
        VOICEplay();
        //----------------------------
        ImageText8SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText8.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-950, -30, 0);//UIのPOSX　Y　Z
        ImageText8.sprite = Resources.Load("Image/Text/10-xiaoyan/10xiaoyan-8", typeof(Sprite)) as Sprite;//
        Egao++;//!
    }
    //---------------------飛天

    void HitenIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/11-feitian/11feitian-1", typeof(Sprite)) as Sprite;//
        Hiten++;//!
    }
    void HitenIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-700, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/11-feitian/11feitian-2", typeof(Sprite)) as Sprite;//
        Hiten++;//!
    }

    //---------------------修行
    void SyugyouIllustration00() {
        Syugyou++;//!
    }

    void SyugyouIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/12-xiuxing/12xiuxing-1", typeof(Sprite)) as Sprite;//
        Syugyou++;//!
    }
    void SyugyouIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(200, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/12-xiuxing/12xiuxing-2", typeof(Sprite)) as Sprite;//
        Syugyou++;//!
    }
    void SyugyouIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(110, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/12-xiuxing/12xiuxing-3", typeof(Sprite)) as Sprite;//
        Syugyou++;//!
    }
    void SyugyouIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON(); //第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-200, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/12-xiuxing/12xiuxing-4", typeof(Sprite)) as Sprite;//
        Syugyou++;//!
    }
    void SyugyouIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON(); //第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-400, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/12-xiuxing/12xiuxing-5", typeof(Sprite)) as Sprite;//
        Syugyou++;//!
    }
    void SyugyouIllustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON(); //第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-640, 0, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/12-xiuxing/12xiuxing-6", typeof(Sprite)) as Sprite;//
        Syugyou++;//!
    }
    void SyugyouIllustration07()
    {
        VOICEplay();
        //----------------------------
        ImageText7SwitchON(); //第一个出现 那红色的地方全全写1                                         
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-850, 0, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/12-xiuxing/12xiuxing-7", typeof(Sprite)) as Sprite;//
        Syugyou++;//!
    }
    //-----------恋情

    void RenjyoIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/13-lianqing/13lianqing-1", typeof(Sprite)) as Sprite;//
        Renjyo++;//!
    }
    void RenjyoIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(200, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/13-lianqing/13lianqing-2", typeof(Sprite)) as Sprite;//
        Renjyo++;//!
    }
    void RenjyoIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(30, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/13-lianqing/13lianqing-3", typeof(Sprite)) as Sprite;//
        Renjyo++;//!
    }
    void RenjyoIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-200, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/13-lianqing/13lianqing-4", typeof(Sprite)) as Sprite;//
        Renjyo++;//!
    }
    void RenjyoIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-420, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/13-lianqing/13lianqing-5", typeof(Sprite)) as Sprite;//
        Renjyo++;//!
    }
    void RenjyoIllustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-640, 0, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/13-lianqing/13lianqing-6", typeof(Sprite)) as Sprite;//
        Renjyo++;//!
    }

    //---------------死別

    void SibetuIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/14-sibie/14sibie-1", typeof(Sprite)) as Sprite;//
        Sibetu++;//!
    }
    void SibetuIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(280, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/14-sibie/14sibie-2", typeof(Sprite)) as Sprite;//
        Sibetu++;//!
    }
    void SibetuIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(120, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/14-sibie/14sibie-3", typeof(Sprite)) as Sprite;//
        Sibetu++;//!
    }
    void SibetuIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-300, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/14-sibie/14sibie-4", typeof(Sprite)) as Sprite;//
        Sibetu++;//!
    }
    void SibetuIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-460, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/14-sibie/14sibie-5", typeof(Sprite)) as Sprite;//
        Sibetu++;//!
    }
    void SibetuIllustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-700, 0, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/14-sibie/14sibie-6", typeof(Sprite)) as Sprite;//
        Sibetu++;//!
    }
    void SibetuIllustration07()
    {
        VOICEplay();
        //----------------------------
        ImageText7SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-850, 0, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/14-sibie/14sibie-7", typeof(Sprite)) as Sprite;//
        Sibetu++;//!
    }
    //-------------墓参り

    void HakamairiIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/15-saomu/15saomu-1", typeof(Sprite)) as Sprite;//
        Hakamari++;//!
    }
    void HakamairiIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(350, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/15-saomu/15saomu-2", typeof(Sprite)) as Sprite;//
        Hakamari++;//!
    }
    void HakamairiIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(120, 0, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/15-saomu/15saomu-3", typeof(Sprite)) as Sprite;//
        Hakamari++;//!
    }
    void HakamairiIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-300, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/15-saomu/15saomu-4", typeof(Sprite)) as Sprite;//
        Hakamari++;//!
    }
    void HakamairiIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-530, 0, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/15-saomu/15saomu-5", typeof(Sprite)) as Sprite;//
        Hakamari++;//!
    }
    //----------剣舞

    void KenmaiIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//遭遇BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-1", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    void KenmaiIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(280, 0, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-2", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    void KenmaiIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-450, -30, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-3", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    void KenmaiIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-530, -30, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-4", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    void KenmaiIllustration05()
    {
        VOICEplay();
        //----------------------------
        ImageText5SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText5.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-610, -30, 0);//UIのPOSX　Y　Z
        ImageText5.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-5", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    void KenmaiIllustration06()
    {
        VOICEplay();
        //----------------------------
        ImageText6SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText6.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-690, -30, 0);//UIのPOSX　Y　Z
        ImageText6.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-6", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    void KenmaiIllustration07()
    {
        VOICEplay();
        //----------------------------
        ImageText7SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText7.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-770, -30, 0);//UIのPOSX　Y　Z
        ImageText7.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-7", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    void KenmaiIllustration08()
    {
        VOICEplay();
        //----------------------------
        ImageText8SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText8.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-850, -30, 0);//UIのPOSX　Y　Z
        ImageText8.sprite = Resources.Load("Image/Text/16-jianwu/16jianwu-8", typeof(Sprite)) as Sprite;//
        Kenmai++;//!
    }
    //-----------道化

     void MitiIllustration00()
    {
        Miti++;
    }
    void MitiIllustration01()
    {
        VOICEplay();
        //-----------------------------------------
        fillAmountNO = true;
        CameraMove = false;
        GameObject.Find("Filter").SendMessage("VUP");//MoveRight
       GameObject.Find("Source　BOX").SendMessage(BGM[ImageCalculator]);//BGM}
                                                              //----------------------------
        ImageText1SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText1.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(500, 0, 0);//UIのPOSX　Y　Z
        ImageText1.sprite = Resources.Load("Image/Text/17-dao/17dao-1", typeof(Sprite)) as Sprite;//
        Miti++;//!
    }
    void MitiIllustration02()
    {
        VOICEplay();
        //----------------------------
        ImageText2SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText2.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(120, -30, 0);//UIのPOSX　Y　Z
        ImageText2.sprite = Resources.Load("Image/Text/17-dao/17dao-2", typeof(Sprite)) as Sprite;//
        Miti++;//!
    }
    void MitiIllustration03()
    {
        VOICEplay();
        //----------------------------
        ImageText3SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText3.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-500, -30, 0);//UIのPOSX　Y　Z
        ImageText3.sprite = Resources.Load("Image/Text/17-dao/17dao-3", typeof(Sprite)) as Sprite;//
        Miti++;//!
    }
    void MitiIllustration04()
    {
        VOICEplay();
        //----------------------------
        ImageText4SwitchON();　//第一个出现 那红色的地方全全写1                                         
        ImageText4.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-800, 0, 0);//UIのPOSX　Y　Z
        ImageText4.sprite = Resources.Load("Image/Text/17-dao/17dao-4", typeof(Sprite)) as Sprite;//
        Miti++;//!
    }


    //------------シーン転移
    void Stagebudge()
    {
         SceneManager.LoadScene("Last");//シーンの切り替え
    }
    //-------------------------
  
    void VOICEplay()
    {//　ボイスが二度がなさないため
        Read++;    //テキストが流れる度に
        if (Read > Unread) {//　読み済みの変数が未読むより大きいの場合は
            Unread = Read;
          
            GameObject.Find("Source　BOX").SendMessage("VOICEplayON");//``ボイスのVOIDが呼び出し 
        }
    
    }
   


}


