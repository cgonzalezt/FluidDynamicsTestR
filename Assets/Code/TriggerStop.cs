using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStop : MonoBehaviour
{
    public GameObject helixP;

    void OnTriggerEnter(Collider other) {
        Destroy(helixP);
    }
}
