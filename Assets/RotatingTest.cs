using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0.15f,0);
    }
}
