using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{   
    // set up of velocities and start/ending quaternion positions. Velocities are based on distance moved (in cm) divided by the length of dropping time.
    public static float x = 0.03518f;
    public static float y = 1.1574f;
    public static float z = 0.018f;
    public static Vector3 velocity = new Vector3(x,y,z);
    Quaternion start = Quaternion.Euler(0,0,0);
    Quaternion end = Quaternion.Euler(0,180,0);
    public Quaternion currentAngle;
    private float timeCount = 0.0f;
    //rotation speed set on trial and error
    private float rotationSpeed = 45f;

    void FixedUpdate()
    {
        timeCount = timeCount + Time.deltaTime;
        //if time is less than dropping time
        if(timeCount < 16.7)
        {
            timeCount = timeCount + Time.deltaTime;
            //position change
            transform.position += velocity * Time.deltaTime;
            rotationSpeed = timeCount;
            // Rotation transition in 3D. (Spherical interpolation: see documentation!)
            transform.rotation = Quaternion.Slerp(start, end, rotationSpeed*Time.deltaTime);
        }
    }
}
