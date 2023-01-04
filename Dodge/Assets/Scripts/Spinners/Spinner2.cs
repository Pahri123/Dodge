using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner2 : MonoBehaviour
{
    float yAngle = -3f;

    void Update() {
        transform.Rotate(0,yAngle,0);
    }
}
