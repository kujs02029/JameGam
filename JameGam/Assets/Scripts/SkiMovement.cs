using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiMovement : MonoBehaviour
{
    float v;
    [SerializeField] float speed;
    private void FixedUpdate()
    {      
        transform.position += new Vector3(v * speed, 0) * Time.fixedDeltaTime;
    }
    private void Update()
    {
        if(Input.GetAxis("Vertical") < 0)
        {
            speed = 7;
        }
        else
        {
            speed = 5;
        }
        v = Input.GetAxis("Horizontal");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponentInParent<skiHurdle>().touch = true;
    }
}
