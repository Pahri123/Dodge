using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    float yAngle = 2f;

    void Update() {
        transform.Rotate(0,yAngle,0);
    }
}
