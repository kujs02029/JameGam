using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toys : MonoBehaviour
{
    public bool bad;
    public float speed;

    private void Start()
    {
        if(Random.Range(0, 3) == 2)
        {
            bad = true;
        }
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(speed, 0) * Time.fixedDeltaTime;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
