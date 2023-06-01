using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject CamXY;
    public GameObject CamYZ;
    public GameObject CamXZ;
    public GameObject CamXYCU;
    public GameObject CamYZCU;
    public GameObject CamXZCU;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XYKey")){
            CamXY.SetActive(true);
            CamYZ.SetActive(false);
            CamXZ.SetActive(false);
            CamXYCU.SetActive(false);
            CamYZCU.SetActive(false);
            CamXZCU.SetActive(false);
        }
        if (Input.GetButtonDown("YZKey")){
            CamXY.SetActive(false);
            CamYZ.SetActive(true);
            CamXZ.SetActive(false);
            CamXYCU.SetActive(false);
            CamYZCU.SetActive(false);
            CamXZCU.SetActive(false);
        }

        if (Input.GetButtonDown("XZKey")){
            CamXY.SetActive(false);
            CamYZ.SetActive(false);
            CamXZ.SetActive(true);
            CamXYCU.SetActive(false);
            CamYZCU.SetActive(false);
            CamXZCU.SetActive(false);
        }
        
        if (Input.GetButtonDown("XYCUKey")){
            CamXY.SetActive(false);
            CamYZ.SetActive(false);
            CamXZ.SetActive(false);
            CamXYCU.SetActive(true);
            CamYZCU.SetActive(false);
            CamXZCU.SetActive(false);
        }
        if (Input.GetButtonDown("YZCUKey")){
            CamXY.SetActive(false);
            CamYZ.SetActive(false);
            CamXZ.SetActive(false);
            CamXYCU.SetActive(false);
            CamYZCU.SetActive(true);
            CamXZCU.SetActive(false);
        }
        
        if (Input.GetButtonDown("XZCUKey")){
            CamXY.SetActive(false);
            CamYZ.SetActive(false);
            CamXZ.SetActive(false);
            CamXYCU.SetActive(false);
            CamYZCU.SetActive(false);
            CamXZCU.SetActive(true);
        }
    }
}
