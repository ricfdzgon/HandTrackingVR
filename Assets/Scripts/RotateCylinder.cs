using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
    bool rotating;
    float rotationSpeed = 90f;
    void Update()
    {
        if (rotating)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
    }

    public void ActivateRotation(bool activate)
    {
        Debug.Log("ActivateRotation " + activate);
        rotating = activate;
    }
}
