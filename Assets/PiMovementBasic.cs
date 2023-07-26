using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiMovementBasic : MonoBehaviour
{
    // Start is called before the first frame update
    // private int framecount = 0;
    public static float x = 0.03518f;
    public static float y = 1.1574f;
    public static float z = 0.018f;
    public static Vector3 velocity = new Vector3(x,y,z);
    Quaternion start = Quaternion.Euler(0,0,0);
    Quaternion end = Quaternion.Euler(0,180,0);
    public Quaternion currentAngle;
    private float timeCount = 0.0f;
    private float rotationSpeed = 45f;

    void FixedUpdate()
    {
        timeCount = timeCount + Time.deltaTime;
        if(timeCount < 16.7)
        {
            timeCount = timeCount + Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
            rotationSpeed = timeCount;
            transform.rotation = Quaternion.Slerp(start, end, rotationSpeed*Time.deltaTime);
        }
    }
}
