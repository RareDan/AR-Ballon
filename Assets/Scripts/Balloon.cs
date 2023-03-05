using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0.2f * Time.deltaTime * Vector3.up);
    }
}
