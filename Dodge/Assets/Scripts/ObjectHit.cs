using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        //"other" adalah variabel yg berisikan info siapa yg menabrak (collison)nya
        if(other.gameObject.tag == "Player"){
            GetComponent<MeshRenderer>().material.color = Color.red;
            //script Objecthit ini ditempelkan ke berbagai objek selain player, maka yg kita sebut gameObject saat ini yakni objek yg sedang terkena collision oleh player
            gameObject.tag = "hit";
            //tag objek yg menabrak diubah menjadi tag "hit"
        }
    }
}
