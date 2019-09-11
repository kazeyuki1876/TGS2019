using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MAIN_MITI_Script : MonoBehaviour
{
    public VideoPlayer MIti1;
    public VideoPlayer MIti2;
    public GameObject Snow;
    public float[] XYZ;
     void Start()
    {
        var vPlayer = gameObject.AddComponent<VideoPlayer>();
    }
    void PlayMIti1() {
        MIti1.GetComponent<VideoPlayer>().Play();

        Invoke("PlayMiti1END", 3.0f);
    }
    void PlayMiti1END() {
        GameObject.Find("Main Controller").SendMessage("MitiIllustration00");//MoveRight
    }
    void Prepared(VideoPlayer vPlayer)
    {
        Debug.Log("End reached!");
        vPlayer.Play();
    }


    void PlayMIti2()
    {
        Snow = Instantiate(Snow, new Vector3(XYZ[0], XYZ[1], XYZ[2]), Quaternion.identity); //
    }
    void PlayMItiOVER() {
        Destroy(Snow.gameObject, 0.1f);
    }
    void STAFF() {

        MIti2.GetComponent<VideoPlayer>().Play();
    }


}