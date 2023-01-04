using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,0,zValue);      
    }
}
