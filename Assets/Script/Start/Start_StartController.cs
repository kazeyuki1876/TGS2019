using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Start_StartController : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Camera;
    public GameObject Ochihana1;
    public GameObject Ochihana2;
    public bool StartON;
    public float VolumeMOVETime=1;
    GameObject Father_gameObject;   //宣告一個GameObject(用來放取得的子物件)。
    public int i;
    void Start(){
            StartON= true;
        Father_gameObject = GameObject.Find("Main Camera");

    }
    void Update() {
        if (StartON && Input.GetKeyDown(KeyCode.Space)) {
            StartON = false;
            GameStart();
        }

        Ochihana1.transform.position = new Vector3(Father_gameObject.transform.position.x + 40, Father_gameObject.transform.position.y + 28, -15.0f);

    }
    
    //GameObject.Find("GameObject.name").SendMessage("Void.ma,e");//public private
    void GameStart() {

        if (i < 1)
        {
            
            Debug.Log("GameStart   UmehanaScaleEnlarge  タイトル画像全体拡大 梅枝移動");//タイトル画像全体拡大
            Ochi();
            UmeEdeMetastasis();
            UmehanaScaleEnlarge();
            

            i++;
        }
        else if (i < 2)
        {
            Debug.Log("GameStart   TitelTransparentON  タイトル透明化");//タイトル透明化
            i++;
            TitelTransparent();
        }
        else if (i < 3)
        {
            Debug.Log("GameStart  CameraMetastasis  カメラ移動");// カメラ移動、
           // CameraEnlarge();
            Invoke("CameraEnlarge", 0.1f);
            Invoke("VolumeMOVEON", VolumeMOVETime);
            i++;
        }
        else if (i < 4) {
            Debug.Log("GameStart  シーンの転移");// カメラ移動、
            //Invoke("Stagebudge", 2.0f);
         
            i++;

        }
      

    }

    
    void　UmehanaScaleEnlarge() {
        GameObject.Find("TitleImeji").SendMessage("UmehanaScaleEnlargeswitchNO");//タイトル画像全体拡大 //ソースコード　削除していません。　参数をいまより小さくしました。


    }
   void UmeEdeMetastasis()
    {
        GameObject.Find("umeL").SendMessage("EdaaMetastasisSwitchON");// 梅枝移動
        GameObject.Find("umeR").SendMessage("EdaaMetastasisSwitchON");// 
    }

    void TitelTransparent() {
        GameObject.Find("Title").SendMessage("TitelTransparentON");//タイトル透明化
     
    }


    
    void CameraEnlarge()
    {
       
        
        GameObject.Find("Main Camera").SendMessage("CameraEnlargeON");// カメラ移動、
    }
    //
    void StagebudgeOn() {
      
     
    }
    void Stagebudge (){
       // SceneManager.LoadScene("Main");//シーンの切り替え
    }
    void Ochi() {
      
        Ochihana1 = Instantiate(Ochihana1, new Vector3(40, 28, 15.0f), Quaternion.identity); //花びらが上のから落ちるエフェクト  


        // 宣告的物件 = children物件(利用Find尋找)。



        //  Ochihana1.transform.parent = Father_gameObject.transform;
        GameObject.Find("Main Camera").SendMessage("HanabiraMOVECamera");// カメラ移動、
       // GameObject.Find("Main Camera").SendMessage("HanabiraMOVECamera");// カメラ移動、
    }
    void VolumeMOVEON()
    {
        GameObject.Find("Main Camera").SendMessage("VolumeMOVEON");
    }
}
