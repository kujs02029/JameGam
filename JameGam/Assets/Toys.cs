using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toys : MonoBehaviour
{
    public bool bad;
    public Sprite broken;
    public float speed;

    private void Start()
    {
        if(Random.Range(0, 2) == 1)
        {
            bad = true;
        }
        if (bad)
            GetComponent<SpriteRenderer>().sprite = broken;
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
