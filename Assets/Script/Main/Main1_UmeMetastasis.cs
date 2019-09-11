using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main1_UmeMetastasis : MonoBehaviour
{
    public float YSpeed;
    public float XSpeed;
    public float DestroyTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(transform.position.x + XSpeed, transform.position.y+ YSpeed, 0.0f);
    }
}
