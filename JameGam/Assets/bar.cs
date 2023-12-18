using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    bool movement = true;
    public float speed = 5;
    bool stop = false;
    [SerializeField] Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!stop)
        {
            if (movement)
            {
                if (gameObject.transform.position.y <= 3.9f)
                {
                    rb.MovePosition(rb.position + new Vector2(0, 1) * speed * Time.fixedDeltaTime);
                }
                else
                {
                    movement = false;
                }
            }
            if (!movement)
            {
                if (gameObject.transform.position.y >= -3.9f)
                {
                    rb.MovePosition(rb.position + new Vector2(0, -1) * speed * Time.fixedDeltaTime);
                }
                else
                {
                    movement = true;
                }
            }
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            stop = true;
        }
    }
}
