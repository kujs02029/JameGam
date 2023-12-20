using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float rotationModifier;
    private WheelJoint2D wheel;

    private void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
    }
    private void FixedUpdate()
    {
        if(wheel.jointLinearSpeed > 5 || wheel.jointLinearSpeed < -5)
        {
            GetComponentInParent<Follow>().MovementSpeed--;
        }
        if (player != null)
        {
            Vector3 vectorToTarget = player.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier; 
            Quaternion q  = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation =  Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        }
    }   
}
