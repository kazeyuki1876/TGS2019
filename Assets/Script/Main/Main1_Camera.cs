using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main1_Camera : MonoBehaviour
{
    public bool CameraMoveSwitchON = false;
    public bool CameraEnlargeswitchON = false;
    public bool CameraMetastasisSwitchOFF = false;

    public bool CameraMoveRight = false;
    public bool CameraMoveLeft = false;

    public float MINEnlargesScaie = 11.40f;
    public float MAXEnlargesScaie = 13.70f;


   
   
    public float Distance =70.0f;
    public float StartTransformPositionX = 0;
  
   
    public float TransformPositionX1;//左
    public float TransformPositionX2;//使てない
    public float TransformPositionX3;//右
    public float Speed;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(StartTransformPositionX, transform.position.y, -50.0f);
        TransformPositionX3 = StartTransformPositionX + Distance;
        TransformPositionX1 = StartTransformPositionX - Distance;
    }


    // Update is called once per frame
    void Update()
    {

        CameraMoveLeftSwitch();
        CameraMoveRightSwitch();
      //  CameraMoveSwitch();
      //  CameraEnlargeON();
      //  CameraEnlargeOFF();
    }
    void MoveON(){ CameraMoveSwitchON = true; }


    void EnlargeON(){
        CameraEnlargeswitchON = true;
    }

    void EnlargeOFF()
    {
        CameraMoveRight = true;
    }

    void CameraRight(){ CameraMoveRight = true; }//右に行きましょう
    void CameraLeft() { CameraMoveLeft = true; }//左に行きましょう





    void CameraMoveLeftSwitch()
    {
        if (CameraMoveLeft && this.transform.position.x > TransformPositionX1)
        {

            this.transform.position = new Vector3(transform.position.x - Speed, transform.position.y, -50.0f);

        }
        else if (CameraMoveLeft && this.transform.position.x <= TransformPositionX1)
        {
            CameraMoveLeft = false;
            this.transform.position = new Vector3(TransformPositionX1, transform.position.y, -50.0f);
            TransformPositionX1 = transform.position.x - Distance;
            TransformPositionX3 = transform.position.x + Distance;

        }
    }


    

    void CameraMoveRightSwitch()
    {
        if (CameraMoveRight && this.transform.position.x < TransformPositionX3)
        {

            this.transform.position = new Vector3(transform.position.x + Speed, transform.position.y, -50.0f);

        }
        else if (CameraMoveRight && this.transform.position.x >= TransformPositionX3)
        {
            CameraMoveRight = false;
            this.transform.position = new Vector3(TransformPositionX3, transform.position.y, -50.0f);
            TransformPositionX3 = transform.position.x + Distance;
            TransformPositionX1 = transform.position.x - Distance;

        }
    }
   /* void CameraMoveSwitch()
    {
        if (CameraMoveSwitchON && this.transform.position.x > TransformPositionX1)
        {

            this.transform.position = new Vector3(transform.position.x - Speed, transform.position.y, -50.0f);

        }
        else if (CameraMoveSwitchON && this.transform.position.x  <= TransformPositionX1) {
            CameraMoveSwitchON = false;
              this.transform.position = new Vector3(TransformPositionX1, transform.position.y, -50.0f);
            TransformPositionX1 = TransformPositionX1 - 70.0f;

        }
    }*/




    /*
    void CameraEnlargeON()
    {
        if (CameraEnlargeswitchON)
        {
            if (Camera.main.orthographicSize >= MINEnlargesScaie-0.1f) //このサイズより //
            {
               //Camera.main.orthographicSize = Camera.main.orthographicSize - 0.05f;
               //イラストの拡大機能まだ縮小機能は削除していません。　参数を調整しただけ。　上のソースコードをコメント化を解除し判定変数を直せばまだ使える。
            }
            else
            {
                Camera.main.orthographicSize = MINEnlargesScaie;
                CameraEnlargeswitchON = false;
            }
        }
    }

    void CameraEnlargeOFF()
    {
        if (CameraMetastasisSwitchOFF)
        {
            if (Camera.main.orthographicSize <= MAXEnlargesScaie-0.1f) //このサイズより //
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize + 0.05f;
            }
            else
            {
                Camera.main.orthographicSize = MAXEnlargesScaie;
                CameraMetastasisSwitchOFF = false;
                MoveON();
            }
        }
    }*/
}
