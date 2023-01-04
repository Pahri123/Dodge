using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigid;
    [SerializeField] int waitTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad >= waitTime){
            renderer.enabled = true;
            rigid.useGravity = true;
        }
    }
}
