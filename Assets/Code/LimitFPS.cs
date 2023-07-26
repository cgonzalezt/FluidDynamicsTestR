using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Capping the frame rate. However, if you want a constant frame rate, this code alone won't be helpful. In project settings you can set up an artifical time per frame (useful for mathematical computations)
       Application.targetFrameRate = 6; 
    }
}
