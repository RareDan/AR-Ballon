using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ArCamera;
    public GameObject Smoke;

    public void TryToKill()
    {
        if (Physics.Raycast(
            ArCamera.transform.position, 
            ArCamera.transform.forward, 
            out RaycastHit hit))
        {
            if (hit.transform.name == "balloon1(Clone)" 
                || hit.transform.name == "balloon2(Clone)" 
                || hit.transform.name == "balloon3(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(Smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
