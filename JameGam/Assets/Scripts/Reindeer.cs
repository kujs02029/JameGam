using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reindeer : MonoBehaviour
{
    private WheelJoint2D wheel;
    private bool inv;
    public SpriteRenderer roof;
    private void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (wheel.jointLinearSpeed > 5 || wheel.jointLinearSpeed < -5)
        {
            if (!inv)
            {
                Invoke("InvF", 1);
                inv = true;
                GetComponentInParent<EnemySleigh>().health--;
            }
        }
    }

    void InvF()
    {
        inv = false;
    }
}
