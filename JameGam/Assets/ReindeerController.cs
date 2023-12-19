using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReindeerController : MonoBehaviour
{
    float h;
    float v;
    Rigidbody2D rb;
    public float speed;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        if(v > 0)
        {
            rb.MovePosition(rb.position + new Vector2(0, 1) * speed * Time.fixedDeltaTime);
        }
        // do not let sleigh rotate too much
        transform.eulerAngles += new Vector3(0, 0, h * -5);
    }
}
