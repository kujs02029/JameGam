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
    bool invincible;
    [SerializeField] SleighNPlayer SP;
    WheelJoint2D wheel;
    // Start is called before the first frame update
    void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
        rb  = GetComponent<Rigidbody2D>();  
    }
    void Minus()
    {
        if (speed > 15)
        {
            speed--;
        }
        Invoke("Minus", .8f);

    }
    void InF()
    {
        invincible = false;
    }
    // Update is called once per frame
    void Update()
    {

      //  print(wheel.jointLinearSpeed);
        if (wheel.jointLinearSpeed > 7 || wheel.jointLinearSpeed < -7)
        {
            if (!invincible)
            {
                invincible = true;
                speed--;
                Invoke("InF", 1);
            }
        }
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if (SP.isOnSleigh == true)
        {
            if (v > 0)
            {
                rb.velocity = (transform.up * speed);
            }
            if (v < 0)
            {
                rb.velocity = Vector2.zero;
            }
            transform.eulerAngles += new Vector3(0, 0, -h * 1.75f);

            LimitRot();
        }
    }

    private void LimitRot()
    {
        Vector3 playerEulerAngles = transform.rotation.eulerAngles;
        playerEulerAngles.z = (playerEulerAngles.z > 180) ? playerEulerAngles.z - 360 : playerEulerAngles.z;
        playerEulerAngles.z = Mathf.Clamp(playerEulerAngles.z, minZrot, maxZrot);
        transform.rotation = Quaternion.Euler(playerEulerAngles);
    }
}
