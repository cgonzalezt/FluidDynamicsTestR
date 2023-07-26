using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchExt : MonoBehaviour
{
    //original cam switch project. Set up of seven cameras (including real life and closeup cameras)
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject Cam5;
    public GameObject Cam6;
    public GameObject Cam7;

    // Update is called once per frame
    void Update()
    {
        //enabling/disabling cameras. For the future it might be helpful to make more efficient code (avoding repetition!)
        if (Input.GetButtonDown("XYKey")){
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(false);
            Cam6.SetActive(false);
            Cam7.SetActive(false);
        }
        if (Input.GetButtonDown("YZKey")){
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(false);
            Cam6.SetActive(false);
            Cam7.SetActive(false);
        }

        if (Input.GetButtonDown("XZKey")){
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(true);
            Cam4.SetActive(false);
            Cam5.SetActive(false);
            Cam6.SetActive(false);
            Cam7.SetActive(false);
        }
        
        if (Input.GetButtonDown("XYCUKey")){
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(true);
            Cam5.SetActive(false);
            Cam6.SetActive(false);
            Cam7.SetActive(false);
        }
        if (Input.GetButtonDown("YZCUKey")){
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(true);
            Cam6.SetActive(false);
            Cam7.SetActive(false);
        }
        
        if (Input.GetButtonDown("XZCUKey")){
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(false);
            Cam6.SetActive(true);
            Cam7.SetActive(false);
        }
        if (Input.GetButtonDown("Cam7Key")){
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
            Cam5.SetActive(false);
            Cam6.SetActive(false);
            Cam7.SetActive(true);
        }
    }
}
