using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishState : MonoBehaviour
{
    public bool isGameOver = false;
    public void OnCollisionEnter(Collision other) {
            if(other.gameObject.tag == "Player"){
            isGameOver = true;
        }
    }
}
