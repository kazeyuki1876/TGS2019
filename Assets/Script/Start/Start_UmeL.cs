using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_UmeL : MonoBehaviour
{
    public bool EtaaMetastasisSwitch = false;
    public float Acceleration;//加速度
    void Update()
    {
        EtaaMetastasis();
    }
    void EdaaMetastasisSwitchON() {
        EtaaMetastasisSwitch = true;
        Destroy(gameObject, 3.0f);
    

    }
    void EtaaMetastasis() {
        if (EtaaMetastasisSwitch) {
            this.transform.position = new Vector3(transform.position.x - Acceleration, transform.position.y, 0);
        }
    }
}
