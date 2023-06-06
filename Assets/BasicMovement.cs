using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.0836f,1.125f,0.1409f);
    }
}
