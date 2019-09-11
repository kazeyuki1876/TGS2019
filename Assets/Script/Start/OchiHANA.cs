using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OchiHANA : MonoBehaviour
{
    public float TIME = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", TIME);
    }

    // Update is called once per frame
    void Destroy(){
        Destroy(this.gameObject);
       
    }
}
