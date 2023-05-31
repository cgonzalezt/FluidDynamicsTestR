using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject CamXY;
    public GameObject CamYZ;
    public GameObject CamXZ;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XYKey")){
            CamXY.SetActive(true);
            CamYZ.SetActive(false);
            CamXZ.SetActive(false);
        }
        if (Input.GetButtonDown("YZKey")){
            CamXY.SetActive(false);
            CamYZ.SetActive(true);
            CamXZ.SetActive(false);
        }
        if (Input.GetButtonDown("XZKey")){
            CamXY.SetActive(false);
            CamYZ.SetActive(false);
            CamXZ.SetActive(true);
        }
    }
}
