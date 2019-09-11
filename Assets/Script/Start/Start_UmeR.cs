using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_UmeR : MonoBehaviour
{
    public bool EtaaMetastasisSwitch = false;
    public float Acceleration;//加速度
    void Update()
    {
        EtaaMetastasis();
    }
    void EdaaMetastasisSwitchON()
    {
        EtaaMetastasisSwitch = true;
        Destroy(gameObject, 5.0f);
    }
    void EtaaMetastasis()
    {
        if (EtaaMetastasisSwitch)
        {
            this.transform.position = new Vector3(transform.position.x + Acceleration, transform.position.y,0);
           
        }

    }
}
