using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReindeerController : MonoBehaviour
{
    public float maxZrot;
    public float minZrot;
    float h;
    float v;
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if(v > 0)
        {
            rb.velocity = (transform.up * speed);
        }
        transform.eulerAngles += new Vector3(0, 0, -h);

        LimitRot();
    }

    private void LimitRot()
    {
        Vector3 playerEulerAngles = transform.rotation.eulerAngles;
        playerEulerAngles.z = (playerEulerAngles.z > 180) ? playerEulerAngles.z - 360 : playerEulerAngles.z;
        playerEulerAngles.z = Mathf.Clamp(playerEulerAngles.z, minZrot, maxZrot);
        transform.rotation = Quaternion.Euler(playerEulerAngles);
    }
}
