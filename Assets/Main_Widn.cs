using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Widn : MonoBehaviour
{

    public GameObject KUmo1;
    public GameObject KUmo2;
    //X YSTART 
    public float STARTXKUmo1;
    public float STARTYKUmo1;
    public float STARTXKUmo2;
    public float STARTYKUmo2;
    //X Y最大
    public float MAXX;
    public float MINX;
    //X Y最小
    public float MINY;
    public float MAXY;
    //
    public bool RightDown;
    public bool RightUp;
    public bool LeftUp;
    public bool LeftDown;
    public bool A;
    //
    public int Z;
    /*
     RightDown
     RightUp
     LeftUp
     LeftDown
     */
    //X Y 
    public float X;
    public float Y;

    public float SpeedX;
    public float SpeedY;
    public bool WindMOVE=false;
    //X+Y-
    //X+Y+
    //X-Y+
    //X-Y-


    void Start()
    {
        STARTXKUmo1 = KUmo1.transform.position.x;
        STARTYKUmo1 = KUmo1.transform.position.y;
        STARTXKUmo2 = KUmo2.transform.position.x;
        STARTYKUmo2 = KUmo2.transform.position.y;

    }

    void Update()
    {
        if (WindMOVE) {
            RightDownMove();
            RightUpMove();
            LeftUpMove();
            LeftDownMove();
        }
       

    }
    //              
    void RightDownMove() {
        if (RightDown)
        {
            X = X + SpeedX;
            Y = Y - SpeedY;
            KUmo1.transform.position = new Vector3(KUmo1.transform.position.x + X, KUmo1.transform.position.y + Y, Z);
            KUmo2.transform.position = new Vector3(KUmo2.transform.position.x + X, KUmo2.transform.position.y + Y, Z);
            if (Y <= MINY) {
                //if()

                // KUmo1.transform.position = new Vector3(STARTXKUmo1, STARTYKUmo1 + MINY, Z);
                //  KUmo2.transform.position = new Vector3(STARTXKUmo2, STARTYKUmo2 + MINY, Z);
                X = 0;
                Y = 0;
                RightDown = false;
                RightUp = true;

            }
        }
    }
    void RightUpMove() {

        if (RightUp)
        {
            X = X + SpeedX;
            Y = Y + SpeedY;
            KUmo2.transform.position = new Vector3(KUmo2.transform.position.x + X, KUmo2.transform.position.y + Y, Z);
            KUmo1.transform.position = new Vector3(KUmo1.transform.position.x + X, KUmo1.transform.position.y + Y, Z);
            if (X >= MAXX)
            {
                //if()

                // KUmo1.transform.position = new Vector3(STARTXKUmo1+ MAXX, STARTYKUmo1, Z);
                // KUmo2.transform.position = new Vector3(STARTXKUmo2+ MAXX, STARTYKUmo2, Z);
                X = 0;
                Y = 0;
                RightUp = false;
                LeftUp = true;
            }
        }
    }
    void LeftUpMove() {
        if (LeftUp)
        {
            //if()
            X = X - SpeedX;
            Y = Y + SpeedY;
            KUmo1.transform.position = new Vector3(KUmo1.transform.position.x + X, KUmo1.transform.position.y + Y, Z);
            KUmo2.transform.position = new Vector3(KUmo2.transform.position.x + X, KUmo2.transform.position.y + Y, Z);
            if (Y >= MAXY)
            {

                //  KUmo1.transform.position = new Vector3(STARTXKUmo1 , STARTYKUmo1+ MAXY, Z);
                //  KUmo2.transform.position = new Vector3(STARTXKUmo2 , STARTYKUmo2+ MAXY, Z);
                X = 0;
                Y = 0;
                LeftUp = false;
                LeftDown = true;
            }

        }
    }
    void LeftDownMove() {

        if (LeftDown)
        {
            //if()
            X = X - SpeedX;
            Y = Y - SpeedY;
            KUmo1.transform.position = new Vector3(KUmo1.transform.position.x + X, KUmo1.transform.position.y + Y, Z);
            KUmo2.transform.position = new Vector3(KUmo2.transform.position.x + X, KUmo2.transform.position.y + Y, Z);
            if (X <= MINX)
            {

                //  KUmo1.transform.position = new Vector3(STARTXKUmo1+MINX, STARTYKUmo1 , Z);
                //KUmo2.transform.position = new Vector3(STARTXKUmo2+MINX, STARTYKUmo2 , Z);
                X = 0;
                Y = 0;
                LeftDown = false;
                RightDown = true;
            }
        }


        //
    }
    void WindMoveSTART() {
        WindMOVE = true;

    }
    void MoveOVER()
    {

        KUmo1.transform.position = new Vector3(STARTXKUmo1 + MAXX, STARTYKUmo1, Z);
        KUmo2.transform.position = new Vector3(STARTXKUmo2 + MAXX, STARTYKUmo2, Z);
        RightDown = false;
        RightUp = false;
        LeftUp = false;
        LeftDown = false;

    }





}
