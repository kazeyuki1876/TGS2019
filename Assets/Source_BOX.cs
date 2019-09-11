using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Source_BOX : MonoBehaviour
{
    //-------s
    /*首先
    物体名 
    物体路径
    物体格位
    音量
    BGM
    
        */
    public GameObject MainCO;
    public GameObject[] SourceGameObject;
    public int SEUnread;
    /*
     BGM BGM2 VOICE SE
         
         
         */
    public string[] GameObjectName;

    public AudioClip[] BGMS;
    public float[] BGMSize;

    public AudioClip[] SES;
    public float[] SESize;

    public float[] SESTiming;

    public AudioClip[] VOICES;
    public float[] VOICESSize;
    public float[] VoiceTiming;//延时
    public int VoiceKIsu;//计数器
    public float[] VOICEVolume;//音量


    AudioSource audioSource;// Musicals インターフェース


    // Start is called before the first frame update
    void Start()
    {
        audioSource = SourceGameObject[3].GetComponent<AudioSource>();//SE
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        MATURI();
    }
    // BGM
    void BGM0()
    { //　もし　今流しているBGMはBGMS[0])ではないなら　BGMS[0])を流す
        if (SourceGameObject[0].GetComponent<AudioSource>().clip != BGMS[0])
        {
            SourceGameObject[0].GetComponent<AudioSource>().volume = BGMSize[0];
            SourceGameObject[0].GetComponent<AudioSource>().clip = BGMS[0];
            SourceGameObject[0].GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + SourceGameObject[0].GetComponent<AudioSource>().clip.name);
    }
    void BGM1()
    { //　もし　今流しているBGMはBGMS[1])ではないなら　BGMS[1])を流す

        if (SourceGameObject[0].GetComponent<AudioSource>().clip != BGMS[1])
        {
            SourceGameObject[0].GetComponent<AudioSource>().volume = BGMSize[1];
            SourceGameObject[0].GetComponent<AudioSource>().clip = BGMS[1];
            SourceGameObject[0].GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + SourceGameObject[0].GetComponent<AudioSource>().clip.name);
    }
    void BGM2()
    { //　もし　今流しているBGMはBGMS[1])ではないなら　BGMS[2)を流す
        if (SourceGameObject[0].GetComponent<AudioSource>().clip != BGMS[2])
        {
            SourceGameObject[0].GetComponent<AudioSource>().volume = BGMSize[2];
            SourceGameObject[0].GetComponent<AudioSource>().clip = BGMS[2];
            SourceGameObject[0].GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + SourceGameObject[0].GetComponent<AudioSource>().clip.name);//BGM待ち
    }
    void BGM3()
    { //　もし　今流しているBGMはBGMS3])ではないなら　BGMS[3])を流す
        if (SourceGameObject[0].GetComponent<AudioSource>().clip != BGMS[3])
        {
            SourceGameObject[0].GetComponent<AudioSource>().volume = BGMSize[3];
            SourceGameObject[0].GetComponent<AudioSource>().clip = BGMS[3];
            SourceGameObject[0].GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + SourceGameObject[0].GetComponent<AudioSource>().clip.name);
    }
    void BGM4()
    { //　もし　今流しているBGMはBGMS[4])ではないなら　BGMS[4])を流す
        if (SourceGameObject[0].GetComponent<AudioSource>().clip != BGMS[4])
        {
            SourceGameObject[0].GetComponent<AudioSource>().volume = BGMSize[4];
            SourceGameObject[0].GetComponent<AudioSource>().clip = BGMS[4];
            SourceGameObject[0].GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + SourceGameObject[0].GetComponent<AudioSource>().clip.name);
    }
    //--------------
    //-----------SE

    void MakiON()
    {

        Invoke("Maki", SESTiming[0]);
    }


    void Maki()
    {
        SourceGameObject[3].GetComponent<AudioSource>().volume = SESize[0];//
        Debug.Log("Maki" + SES[0]);
        audioSource.PlayOneShot(SES[0]);

    }
    void AmeON()
    {
        Invoke("Ame", SESTiming[1]);
    }
    void Ame()
    {
        SourceGameObject[3].GetComponent<AudioSource>().volume = SESize[1];//
        Debug.Log("Ame" + SES[1]);
        audioSource.PlayOneShot(SES[1]);
    }
    void KazeON()
    {
        Invoke("Kaze", SESTiming[2]);
    }
    void Kaze()
    {
        SourceGameObject[3].GetComponent<AudioSource>().volume = SESize[2];//
        Debug.Log("Kaze" + SES[2]);
        audioSource.PlayOneShot(SES[2]);
    }
    void BattouON()
    {
        Invoke("Battou", SESTiming[3]);
    }
    void Battou()
    {//A
        SEUnread = MainCO.GetComponent<Main_Controller>().Read;
        if (SEUnread < 21) {
             SourceGameObject[3].GetComponent<AudioSource>().volume = SESize[3];//
        Debug.Log("Battou" + SES[3]);
        audioSource.PlayOneShot(SES[3]);
        }
       
    }
    void UchiaiON()
    {

        Invoke("Uchiai", SESTiming[4]);
    }
    void Uchiai()
    {
        SourceGameObject[3].GetComponent<AudioSource>().volume = SESize[4];//
        Debug.Log("Uchiai" + SES[4]);
        audioSource.PlayOneShot(SES[4]);
    }
    //-------------
    void MasturiON()
    {
        Invoke("Masturi", SESTiming[5]);
    }
    void Masturi()
    {
        SourceGameObject[3].GetComponent<AudioSource>().volume = SESize[5];//
        Debug.Log("Masturi" + SES[5]);
        audioSource.PlayOneShot(SES[5]);
    }

    //------------







 
    //　接口
    void VOICEplayON()
    {
      



        //SourceGameObject[0].GetComponent<AudioSource>().clip = BGMS[0];
        SourceGameObject[2].GetComponent<AudioSource>().clip = VOICES[VoiceKIsu];//
        SourceGameObject[2].GetComponent<AudioSource>().volume = VOICEVolume[VoiceKIsu];//
        SourceGameObject[2].GetComponent<AudioSource>().Play();//
        VoiceKIsu++;


    }
    void VOICESInterruption()
    {
        SourceGameObject[2].GetComponent<AudioSource>().clip = null;//
        SourceGameObject[2].GetComponent<AudioSource>().volume = VOICEVolume[VoiceKIsu];//
        SourceGameObject[2].GetComponent<AudioSource>().Play();//
    }

    //---------------------------祭り
    public float MATURIMAX;
    public float MATURIXMIN;
    public float MATURIEND;
    public float MATURISPEED;
    public float MARYRUVolume;
    public bool MATURIwitch = false;
    public bool MATURISwitchOFF = false;
    //---------------------------MATURIStart
    void MATURIStart() {
        if (!MATURISwitchOFF) {
            MARYRUVolume = MATURIMAX;
            SourceGameObject[1].GetComponent<AudioSource>().clip = SES[5];//
            SourceGameObject[1].GetComponent<AudioSource>().volume = MARYRUVolume;//
            SourceGameObject[1].GetComponent<AudioSource>().loop = true;
            SourceGameObject[1].GetComponent<AudioSource>().Play();//
        }
    }
    void MATURION() {
        if (!MATURISwitchOFF) {
            MATURIwitch = true;
            MATURISwitchOFF = true;
        }
    }
    void MATUEIEND()
    {
        MATURIwitch = false;
        SourceGameObject[1].GetComponent<AudioSource>().volume = MATURIEND;//
    }
    void MATURI() {
        if (MARYRUVolume > MATURIXMIN && MATURIwitch) {
            MARYRUVolume = MARYRUVolume - MATURISPEED * Time.deltaTime;
            SourceGameObject[1].GetComponent<AudioSource>().volume = MARYRUVolume;//
        }
    }
    //---------------------------風
    public float KAZEVolume = 1;
    public bool KAZESwitchOFF = false;
    void KAZEStart() {
        if (!KAZESwitchOFF) {
            KAZESwitchOFF = true;
            SourceGameObject[1].GetComponent<AudioSource>().clip = SES[2];//
            SourceGameObject[1].GetComponent<AudioSource>().volume = KAZEVolume;//
            SourceGameObject[1].GetComponent<AudioSource>().loop = true;
            SourceGameObject[1].GetComponent<AudioSource>().Play();//
        }
    }
    //---------------雨
    public float AMEVolume = 1;
    public bool AMESwitch = false;
    void AMEStart() {
        if (!AMESwitch)
        {
            AMESwitch = true;
            SourceGameObject[1].GetComponent<AudioSource>().clip = SES[1];//
            SourceGameObject[1].GetComponent<AudioSource>().volume = AMEVolume;//
            SourceGameObject[1].GetComponent<AudioSource>().loop = true;
            SourceGameObject[1].GetComponent<AudioSource>().Play();//\
            Invoke("AMEOVER", 2.0f);
        }
    }
    void AMEOVER() {
        if (SourceGameObject[1].GetComponent<AudioSource>().clip == SES[2])
        {
            BGMOVER();
        }
    }
    //-----------------撃ち合い
    public float UCHIAIVolume = 1;
    public bool UCHIAISwitch = false;
    void UCHIAIStart()
    {
        if (!UCHIAISwitch) {
            UCHIAISwitch = true;
            SourceGameObject[1].GetComponent<AudioSource>().clip = SES[4];//
            SourceGameObject[1].GetComponent<AudioSource>().volume = UCHIAIVolume;//
            SourceGameObject[1].GetComponent<AudioSource>().Play();//\
        }
    }
    //-------------nitamade zhenshige rencai 1
    public bool Battou1 = false;
    public float Battou1Volume = 1;
    public float Battou1TIME=5;
    public float Battou1ENDTIME = 2;

    void Battou1STARTON() {
        Invoke("Battou1START", Battou1TIME);

    }
    void Battou1START() {
        //A
        SEUnread = MainCO.GetComponent<Main_Controller>().Read;
        if (!Battou1)
        {
            if (SEUnread <6) { 
        
        
              
                    Battou1 = true;
                    SourceGameObject[1].GetComponent<AudioSource>().clip = SES[3];//
                    SourceGameObject[1].GetComponent<AudioSource>().volume = Battou1Volume;//
                    SourceGameObject[1].GetComponent<AudioSource>().loop = false;
                    SourceGameObject[1].GetComponent<AudioSource>().Play();//
                    Invoke("Battou1END", Battou1ENDTIME);
                }
        
            }
        }
    void Battou1END()
    {
        SEUnread = MainCO.GetComponent<Main_Controller>().Unread;

        if (SEUnread < 6)
        {
            GameObject.Find("Main Controller").SendMessage("SouguuIllustration06");//MoveRight
        }
        
    }
    //---------------------------------nitamade zhenshige rencai 2
    public bool Battou2 = false;
    public float Battou2Volume = 1;
    public float Battou2TIME = 5;
    public float Battou2ENDTIME = 2;

    void Battou2STARTON()
    {
        Invoke("Battou2START", Battou2TIME);
    }
    void Battou2START()
    {
      

       
            if (!Battou2)
        {
            SEUnread = MainCO.GetComponent<Main_Controller>().Unread;
            if (SEUnread < 22) { 
                Battou2 = true;
                SourceGameObject[1].GetComponent<AudioSource>().clip = SES[3];//
                SourceGameObject[1].GetComponent<AudioSource>().volume = Battou2Volume;//
                SourceGameObject[1].GetComponent<AudioSource>().loop = false;
                SourceGameObject[1].GetComponent<AudioSource>().Play();//\
                Invoke("Battou2END", Battou2ENDTIME);
            }
         }
        
    }
    void Battou2END()
    { SEUnread = MainCO.GetComponent<Main_Controller>().Unread;
        if (SEUnread < 22)
        {
            GameObject.Find("Main Controller").SendMessage("NyutouIllustration012");//MoveRight
        }

    }
    void BGMOVER() {
        SourceGameObject[1].GetComponent<AudioSource>().volume = 0;//
        SourceGameObject[1].GetComponent<AudioSource>().loop = false;
        SourceGameObject[1].GetComponent<AudioSource>().clip = null;//
     //   SourceGameObject[1].GetComponent<AudioSource>().Play();//
    }
    //---------------

}
