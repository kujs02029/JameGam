using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    public Transform target;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, - 10f);
        transform.position = Vector3.Slerp(transform.position, newPos, speed * Time.fixedDeltaTime);
    }
}
