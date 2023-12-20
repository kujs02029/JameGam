using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactRot : MonoBehaviour
{
    private Transform cam;

    private void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        transform.rotation = cam.rotation;
    }
}
