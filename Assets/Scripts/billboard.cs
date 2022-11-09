using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
    private Camera theCam;

    public void Start()
    {
        theCam = Camera.main;
    }

    public void FixedUpdate()
    {
        transform.LookAt(theCam.transform);
    }
}
