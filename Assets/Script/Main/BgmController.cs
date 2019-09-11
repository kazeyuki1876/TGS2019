using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmController : MonoBehaviour
{
    AudioSource audioSource1;// Musicals インターフェース
                             //
    public AudioClip[] BGMS = new AudioClip[0];
    public AudioClip[] SES = new AudioClip[0];
    /*
     * Maki
     * Ame
     * Kaze
     * Battou
     * Uchiai
     * Masturi
    */
    public int i;
    string s;


    void Start()
    {
        //Componentを取得

        audioSource1 = GetComponent<AudioSource>();
        this.GetComponent<AudioSource>().loop = true;
        DontDestroyOnLoad(this);
    }
    void Update()
    {

    }

    void BGM()
    { //　もし　今流しているBGMはBGMS[0])ではないなら　BGMS[0])を流す
        if (this.GetComponent<AudioSource>().clip != BGMS[0]) { 
        this.GetComponent<AudioSource>().clip = BGMS[0];
        this.GetComponent<AudioSource>().Play();  
     }
        Debug.Log("BGM:" + this.GetComponent<AudioSource>().clip.name);
    }
    void BGM2()
    { //　もし　今流しているBGMはBGMS[0])ではないなら　BGMS[0])を流す
        if (this.GetComponent<AudioSource>().clip != BGMS[0])
        {
            this.GetComponent<AudioSource>().clip = BGMS[0];
            this.GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + this.GetComponent<AudioSource>().clip.name);
    }
    void BGM3()
    { //　もし　今流しているBGMはBGMS[0])ではないなら　BGMS[0])を流す
        if (this.GetComponent<AudioSource>().clip != BGMS[0])
        {
            this.GetComponent<AudioSource>().clip = BGMS[0];
            this.GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + this.GetComponent<AudioSource>().clip.name);
    }
    void BGM4()
    { //　もし　今流しているBGMはBGMS[0])ではないなら　BGMS[0])を流す
        if (this.GetComponent<AudioSource>().clip != BGMS[0])
        {
            this.GetComponent<AudioSource>().clip = BGMS[0];
            this.GetComponent<AudioSource>().Play();
        }
        Debug.Log("BGM:" + this.GetComponent<AudioSource>().clip.name);
    }


    //-----------SE
    void Maki()
    {
        Debug.Log("Maki" + SES[0]);
        audioSource1.PlayOneShot(SES[0]);
       
    }
    void Ame() {
        Debug.Log("Ame" + SES[1]);
        audioSource1.PlayOneShot(SES[1]);
    }
    void Kaze (){
        Debug.Log("Kaze" + SES[2]);
        audioSource1.PlayOneShot(SES[2]);
   

    }
    void Battou() {
        Debug.Log("Battou" + SES[3]);
        audioSource1.PlayOneShot(SES[3]);
    }


    void Uchiai(){
        Debug.Log("Battou" + SES[4]);
        audioSource1.PlayOneShot(SES[4]);
    }
    void Masturi()
    {
        Debug.Log("Masturi" + SES[5]);
        audioSource1.PlayOneShot(SES[5]);

    }



}

/*
          public int i;
    string s;



        s = i.ToString();
        if (i < 10){
            Debug.Log("00"+s);
        }
        else if (i < 100)
        {
            Debug.Log("0" + s);
        }
        else if (i < 1000)
        {
            Debug.Log("" + s);
        }
        */
