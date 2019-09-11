 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_BGM_Script : MonoBehaviour
{
    public float Volume;
    public float VolumeSpeed=1;
    public bool IsVolumeMOVE;
    // Start is called before the first frame update
    void Start()
    {
        Volume = this.GetComponent<AudioSource>().volume;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsVolumeMOVE) {
            VolumeMOVE();
        }
        this.GetComponent<AudioSource>().volume = Volume;//

    }
    void VolumeMOVEON()
    {
        IsVolumeMOVE = true;

    }
    void VolumeMOVE() {
        Volume = Volume - VolumeSpeed * Time.deltaTime;
        this.GetComponent<AudioSource>().volume = Volume;//
    }
}
