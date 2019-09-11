using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_TitelImeji : MonoBehaviour
{
   
    public bool UmehanaScaleEnlargeswitch = false;
    public float Acceleration;//サイズ拡大速度
    public float MAXAcceleration;//MAXサイズ

    void Update()
    {
        UmehanaScaleEnlarge();

    }
    void UmehanaScaleEnlargeswitchNO() {
        UmehanaScaleEnlargeswitch = true;
    }
    void UmehanaScaleEnlarge(){
        if (UmehanaScaleEnlargeswitch) {
            if (this.transform.localScale.x < MAXAcceleration)
            {

                this.transform.localScale = new Vector3(transform.localScale.x + Acceleration, transform.localScale.y + Acceleration, 1.0f);
            }
            else {
                UmehanaScaleEnlargeswitch = false;
                GameObject.Find("StartController").SendMessage("GameStart");// GameStartに戻り
            }
        }
    }
}
